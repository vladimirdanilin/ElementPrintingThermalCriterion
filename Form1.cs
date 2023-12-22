using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ElementPrinting.Population;

namespace ElementPrinting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PCBwidthTEXTBOX.Text = PCBWidth.ToString();
            PCBheightTEXTBOX.Text = PCBHeight.ToString();
            NumOfSpeciesTEXTBOX.Text = NumOfSpecies.ToString();
            NumOfGensTEXTBOX.Text = MaxNumOfGenerations.ToString();
            MutationTEXTBOX.Text = Mutation.ToString();
        }

        private double X;
        private double Y;
        private int NumOfSpecies = 50; // Default
        private int MaxNumOfGenerations = 5; //Default кол-во поколений, на протяжении которого значение функции пригодности неизменно
        private int Mutation = 100; // Default процент мутации
        private double PCBWidth = 370; // Default ширина платы
        private double PCBHeight = 370; // Default высота платы
        private int k; //Кол-во поколений, на котором работа программы останавливается
        Placement placement;
        Fitness fitness = new Fitness();
        InputData adjacency;
        InputData elementSize;
        InputData heat;
        Bitmap bitmapForElements;
        Graphics graphics;
        Brush brushForElement;
        Brush brushForText;
        Color colorForElement;
        Color colorForText = Color.White;
        Pen pen = new Pen(Color.Red);
        public Random rnd = new Random();
        public List<Chromosome> ListOfParentalSpecies;
        public List<Chromosome> ListOfOffspringSpecies;
        public List<Chromosome> ListOfOffspringSpeciesMutated;
        public List<Chromosome> ListOfSpeciesUNITED;
        public List<Chromosome> ListOfSpeciesSORTED = new List<Chromosome>();
        public List<Chromosome> BestSpecies = new List<Chromosome>();
        private List<Chromosome> BestSpeciesSorted = new List<Chromosome>();

        

        private void StartBTN_Click(object sender, EventArgs e)
        {
            RemoveAllElements(ListOfParentalSpecies);
            RemoveAllElements(ListOfOffspringSpecies);
            RemoveAllElements(ListOfOffspringSpeciesMutated);
            RemoveAllElements(ListOfSpeciesUNITED);
            RemoveAllElements(ListOfSpeciesSORTED);
            RemoveAllElements(BestSpecies);
            RemoveAllElements(BestSpeciesSorted);
            elementSize = new InputData(ElementSizeLABEL.Text);
            heat = new InputData(HeatLABEL.Text);
            FitnessStagnation();
            placement = new Placement();
            BestSpeciesSorted.AddRange(BestSpecies.OrderBy(x => x.Fitness).ToList());
            placement.PackageStart(elementSize.Matrix, BestSpeciesSorted[0].Genes, PCBWidth, PCBHeight);
            DrawElements();
            PrintResult();
        }

        void FitnessStagnation() //Неизменность F на протяжении опр-го числа поколений
        {
            int n = 0;
            bool Stagnation = false;
            Population population = new Population(NumOfSpecies);
            ListOfParentalSpecies = new List<Chromosome>();
            ListOfParentalSpecies.AddRange(population.GenerateInitialPopulation(elementSize.Matrix.Length / 2));

            while (Stagnation != true)
            {
                k++;
                List<Chromosome> TestList = new List<Chromosome>();
                GenerateNewGeneration(population);
                ListOfSpeciesSORTED.RemoveRange(0, ListOfSpeciesSORTED.Count);
                TestList.AddRange(ListOfSpeciesUNITED);
                ListOfSpeciesSORTED.AddRange(TestList.OrderBy(x => x.Fitness).ToList());
                ListOfSpeciesSORTED.RemoveRange(ListOfSpeciesSORTED.Count() / 2, ListOfSpeciesSORTED.Count() / 2);
                BestSpecies.Add(ListOfSpeciesSORTED[0]);
                if (BestSpecies.Count >= MaxNumOfGenerations)
                {
                    for (int i = BestSpecies.Count - 1; i >= BestSpecies.Count - MaxNumOfGenerations; i--)
                    {
                        if (BestSpecies[i].Fitness == BestSpecies[BestSpecies.Count - 1].Fitness)
                        {
                            n++;
                        }
                    }

                    if (n >= MaxNumOfGenerations)
                    {
                        Stagnation = true;
                    }
                    n = 0;
                }

                if (k == 500)
                {
                    Stagnation = true;
                }

            }


        }

        private void GenerateNewGeneration(Population population)
        {
            if (ListOfOffspringSpecies != null)
            {
                if (ListOfOffspringSpecies.Count != 0)
                {
                    ListOfParentalSpecies.RemoveRange(0, ListOfParentalSpecies.Count);
                    ListOfParentalSpecies.AddRange(ListOfSpeciesSORTED);
                }
            }
            ListOfOffspringSpecies = new List<Chromosome>();
            ListOfOffspringSpeciesMutated = new List<Chromosome>();
            ListOfOffspringSpecies.AddRange(population.Crossover(elementSize.Matrix.Length / 2, ListOfParentalSpecies));
            ListOfOffspringSpeciesMutated.AddRange(population.Mutation(elementSize.Matrix.Length / 2, ListOfOffspringSpecies, Mutation));
            ListOfSpeciesUNITED = new List<Chromosome>();
            ListOfSpeciesUNITED.AddRange(ListOfParentalSpecies);
            ListOfSpeciesUNITED.AddRange(ListOfOffspringSpeciesMutated);
            InputData adjacencyExtra = new InputData(AdjacencyLABEL.Text);
            InputData heat = new InputData(HeatLABEL.Text);
            foreach (var item in ListOfSpeciesUNITED)
            {
                placement = new Placement();
                placement.PackageStart(elementSize.Matrix, item.Genes, PCBWidth, PCBHeight);
                item.Fitness = fitness.Count(placement.Elements, adjacencyExtra.Matrix, heat.Matrix);

                foreach (var item1 in placement.Elements)
                {
                    if (((item1.position.x + item1.width) > PCBWidth) || ((item1.position.y + item1.height) > PCBHeight))
                    {
                        item.Fitness = double.MaxValue;
                    }
                }

            }
        } //Метод, создающий новое поколение (без генерации начального поколения)

 

        private void DrawElements() //Метод, рисющий элементы схемы
        {
            heat = new InputData(HeatLABEL.Text);
            bitmapForElements = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmapForElements;
            graphics = Graphics.FromImage(pictureBox1.Image);
            graphics.DrawRectangle(pen, 0, 0, (float)PCBWidth, (float)PCBHeight);
            foreach (var item in placement.Elements)
            {
                int index = placement.ElementsExtra.FindIndex(x => x == item);
                double k = heat.Matrix[index, 0]/110;
                colorForElement = Color.FromArgb(Convert.ToInt32(k * 250), 0, Convert.ToInt32(k / 250));
                colorForText = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                brushForElement = new SolidBrush(colorForElement);
                brushForText = new SolidBrush(colorForText);
                graphics.FillRectangle(brushForElement, (float)item.position.x, (float)item.position.y, (float)item.width, (float)item.height);
                graphics.DrawString($"{index}", new Font("Arial", 7), brushForText, (float)(item.position.x + item.width / 2 - Font.Size / 2), (float)(item.position.y + item.height / 2 - Font.Height / 2));
            }

        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdjacencyBTN_Click(object sender, EventArgs e)
        {
            if (openAdjacencyFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            AdjacencyLABEL.Text = @openAdjacencyFileDialog1.FileName;
        }

        private void ElementSizeBTN_Click(object sender, EventArgs e)
        {
            if (openElementSizeFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            ElementSizeLABEL.Text = @openElementSizeFileDialog1.FileName;
        }

        private void HeatBTN_Click(object sender, EventArgs e)
        {
            if (openHeatFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            HeatLABEL.Text = @openHeatFileDialog1.FileName;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bitmap finalImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Bitmap bitmapForLines = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmapForLines);
            adjacency = new InputData(AdjacencyLABEL.Text);


            var mouseEventArgs = e as MouseEventArgs;
            if (mouseEventArgs != null)
            {
                X = mouseEventArgs.X;
                Y = mouseEventArgs.Y;
            }


            foreach (var item in placement.ElementsExtra)
            {
                int index = placement.ElementsExtra.FindIndex(x => x == item);

                if ((X > item.position.x) && (X < item.position.x + item.width) && (Y > item.position.y) && (Y < item.position.y + item.height))
                {

                    for (int j = 0; j < Math.Sqrt(adjacency.Matrix.Length); j++)
                    {
                        if ((adjacency.Matrix[index, j] != 0) && (index != j))
                        {
                            graphics.DrawLine(pen, (float)placement.ElementsExtra[index].position.x + (float)placement.ElementsExtra[index].width / 2, (float)placement.ElementsExtra[index].position.y + (float)placement.ElementsExtra[index].height / 2, (float)placement.ElementsExtra[j].position.x + (float)placement.ElementsExtra[j].width / 2, (float)placement.ElementsExtra[j].position.y + (float)placement.ElementsExtra[j].height / 2);
                        }
                    }

                }
            }

            using (Graphics g = Graphics.FromImage(finalImage))
            {
                g.DrawImage(bitmapForElements, 0, 0);
                g.DrawImage(bitmapForLines, 0, 0);
            }

            pictureBox1.Image = finalImage;
        }

        private void NumOfSpeciesTEXTBOX_TextChanged(object sender, EventArgs e)
        {
            int numOfSpecies;
            if (int.TryParse(NumOfSpeciesTEXTBOX.Text, out numOfSpecies))
            {
                NumOfSpecies = numOfSpecies;
            }
        }

        private void NumOfSpeciesTEXTBOX_Click(object sender, EventArgs e)
        {
            NumOfSpeciesTEXTBOX.Text = string.Empty;
        }

        private void PCBwidthTEXTBOX_TextChanged(object sender, EventArgs e)
        {
            double pcbWidth;
            if (double.TryParse(PCBwidthTEXTBOX.Text, out pcbWidth))
            {
                PCBWidth = pcbWidth;
            }
        }

        private void PCBwidthTEXTBOX_Click(object sender, EventArgs e)
        {
            PCBwidthTEXTBOX.Text = string.Empty;
        }

        private void PCBheightTEXTBOX_TextChanged(object sender, EventArgs e)
        {
            double pcbHeight;
            if (double.TryParse(PCBheightTEXTBOX.Text, out pcbHeight))
            {
                PCBHeight = pcbHeight;
            }
        }

        private void PCBheightTEXTBOX_Click(object sender, EventArgs e)
        {
            PCBheightTEXTBOX.Text = string.Empty;
        }

        private void NumOfGensTEXTBOX_TextChanged(object sender, EventArgs e)
        {
            int mnumOfGenerations;
            if (int.TryParse(NumOfGensTEXTBOX.Text, out mnumOfGenerations))
            {
                MaxNumOfGenerations = mnumOfGenerations;
            }
        }
        private void NumOfGensTEXTBOX_Click(object sender, EventArgs e)
        {
            NumOfGensTEXTBOX.Text = string.Empty;
        }

        private void MutationTEXTBOX_TextChanged(object sender, EventArgs e)
        {
            int mutation;
            if (int.TryParse(MutationTEXTBOX.Text, out mutation))
            {
                Mutation = mutation;
            }
        }

        private void MutationTEXTBOX_Click(object sender, EventArgs e)
        {
            MutationTEXTBOX.Text = string.Empty;
        }

        private void RemoveAllElements(List<Chromosome> list)
        {
            if (list != null)
            {
                list.RemoveRange(0, list.Count);
            }
        }

        private void PrintResult()
        {
            ProgramResultLABEL.Text = "";
            ProgramResultLABEL.Text += "\n";
            foreach (var gene in BestSpecies[0].Genes)
            {
                ProgramResultLABEL.Text += gene;
                ProgramResultLABEL.Text += " \t";
            }
            ProgramResultLABEL.Text += "\t \t FITNESS = ";
            ProgramResultLABEL.Text += BestSpecies[0].Fitness;
           

        } //Печать результата


    }
}
