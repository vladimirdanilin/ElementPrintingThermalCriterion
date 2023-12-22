using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementPrinting
{
    public class Population
    {
        public int NumOfSpecies { get; set; } //Кол-во особей в популяции
        Random random = new Random(DateTime.Now.Millisecond);

        public Population(int numOfSpecies)
        {
            NumOfSpecies = numOfSpecies;
        }

        public List<Chromosome> GenerateInitialPopulation(int numOfElements)
        {
            List<Chromosome> ListOfParentalSpecies = new List<Chromosome>();

            for (int i = 0; i < NumOfSpecies; i++)
            {
                int[] Genes = new int[numOfElements];

                for (int j = 0; j < numOfElements; j++)
                {
                    Genes[j] = j;
                }
                Genes = Genes.OrderBy(item => random.Next()).ToArray();
                Chromosome chromosome = new Chromosome(Genes, 0);
                ListOfParentalSpecies.Add(chromosome);
            }
            return ListOfParentalSpecies;
        }

        public List<Chromosome> Crossover(int numOfElements, List<Chromosome> listOfParentalSpecies)
        {
            List<Chromosome> ListOfOffspringSpecies = new List<Chromosome>();

            for (int i = 0; i < NumOfSpecies / 2; i++)
            {
                int f = random.Next(0, listOfParentalSpecies.Count - 1);
                int m = random.Next(0, listOfParentalSpecies.Count - 1);
                while (f == m)
                {
                    f = random.Next(0, listOfParentalSpecies.Count - 1);
                }
                int[] Female = listOfParentalSpecies[f].Genes;
                int[] Male = listOfParentalSpecies[m].Genes;
                //Console.WriteLine("F = " + f);
                //Console.WriteLine("M = " + m);
                //Print(Female, "Female");
                //Print(Male, "Male");

                int r = random.Next(0, numOfElements);
                //Console.WriteLine(r);
                int[] Offspring1 = Breeding(Male, Female, numOfElements, r);
                //Print(Offspring1, "Offspring1");
                int[] Offspring2 = Breeding(Female, Male, numOfElements, r);

                Chromosome OffSpring1 = new Chromosome(Offspring1, 0);
                Chromosome OffSpring2 = new Chromosome(Offspring2, 0);
                ListOfOffspringSpecies.Add(OffSpring1);
                ListOfOffspringSpecies.Add(OffSpring2);

                //Print(Offspring2, "Offspring2");
                //Console.WriteLine("--------------------------------------------------------------");
            }
            return ListOfOffspringSpecies;
        }

        private int[] Breeding(int[] parent1, int[] parent2, int numOfElements, int r)
        {

            int[] Offspring = new int[numOfElements];
            for (int i = 0; i < Offspring.Length; i++)
            {
                Offspring[i] = int.MaxValue;
            }
            for (int i = 0; i < r; i++)
            {
                Offspring[i] = parent1[i];
            }

            for (int i = r; i < numOfElements; i++)
            {
                int k = 0;
                foreach (var gene in parent2)
                {
                    if (!Offspring.Contains(gene) && k != 1)
                    {
                        Offspring[i] = gene;
                        k = 1;
                    }
                }
            }

            return Offspring;
        }

        public List<Chromosome> Mutation(int numOfElements, List<Chromosome> listOfOffspringSpecies, double percentOfMutation)
        {
            Console.WriteLine("--------------MUTATION----------------------");
            List<Chromosome> ListOfMutatedSpecies = new List<Chromosome>();
            int[] arr;
            foreach (var offspring in listOfOffspringSpecies)
            {
                int a = random.Next(0, numOfElements);
                int b = random.Next(a + 1, numOfElements);
                while (b - a < 2)
                {
                    a = random.Next(0, numOfElements);
                    b = random.Next(0, numOfElements);
                }
                int mut = Convert.ToInt32(Math.Round((b - a) * percentOfMutation / 100));
                arr = new int[mut];
                //Print(offspring.Genes, "OFFSPRING");
                Array.Copy(offspring.Genes, a, arr, 0, arr.Length);
                //Print(arr, "MUT");
                arr = arr.Reverse().ToArray();
                Array.Copy(arr, 0, offspring.Genes, a, arr.Length);
                //Print(offspring.Genes, "OFFSPRINGMUTATED");
                //Console.WriteLine("++++++++++++++++");
                ListOfMutatedSpecies.Add(offspring);
            }
            return ListOfMutatedSpecies;
        }

        public class Chromosome
        {
            public int[] Genes { get; set; }
            public double Fitness { get; set; }

            public Chromosome(int[] genes, double fitness)
            {
                Genes = genes;
                Fitness = fitness;
            }
        }

        private void Print(int[] arr, string name)
        {
            Console.WriteLine(name);
            foreach (var item in arr)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }
    }
}
