
namespace ElementPrinting
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.HeatBTN = new System.Windows.Forms.Button();
            this.HeatLABEL = new System.Windows.Forms.Label();
            this.MutationTEXTBOX = new System.Windows.Forms.TextBox();
            this.MutationLABEL = new System.Windows.Forms.Label();
            this.NumOfGensTEXTBOX = new System.Windows.Forms.TextBox();
            this.NumOfGensLABEL = new System.Windows.Forms.Label();
            this.PCBheightTEXTBOX = new System.Windows.Forms.TextBox();
            this.PCBwidthTEXTBOX = new System.Windows.Forms.TextBox();
            this.PCBheightLABEL = new System.Windows.Forms.Label();
            this.PCBwidthLABEL = new System.Windows.Forms.Label();
            this.NumOfSpeciesTEXTBOX = new System.Windows.Forms.TextBox();
            this.NumOfSpeciesLABEL = new System.Windows.Forms.Label();
            this.StartBTN = new System.Windows.Forms.Button();
            this.ElementSizeBTN = new System.Windows.Forms.Button();
            this.ElementSizeLABEL = new System.Windows.Forms.Label();
            this.AdjacencyBTN = new System.Windows.Forms.Button();
            this.AdjacencyLABEL = new System.Windows.Forms.Label();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.openAdjacencyFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openElementSizeFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openHeatFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ProgramResultLABEL = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.HeatBTN);
            this.panel1.Controls.Add(this.HeatLABEL);
            this.panel1.Controls.Add(this.MutationTEXTBOX);
            this.panel1.Controls.Add(this.MutationLABEL);
            this.panel1.Controls.Add(this.NumOfGensTEXTBOX);
            this.panel1.Controls.Add(this.NumOfGensLABEL);
            this.panel1.Controls.Add(this.PCBheightTEXTBOX);
            this.panel1.Controls.Add(this.PCBwidthTEXTBOX);
            this.panel1.Controls.Add(this.PCBheightLABEL);
            this.panel1.Controls.Add(this.PCBwidthLABEL);
            this.panel1.Controls.Add(this.NumOfSpeciesTEXTBOX);
            this.panel1.Controls.Add(this.NumOfSpeciesLABEL);
            this.panel1.Controls.Add(this.StartBTN);
            this.panel1.Controls.Add(this.ElementSizeBTN);
            this.panel1.Controls.Add(this.ElementSizeLABEL);
            this.panel1.Controls.Add(this.AdjacencyBTN);
            this.panel1.Controls.Add(this.AdjacencyLABEL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 627);
            this.panel1.TabIndex = 0;
            // 
            // HeatBTN
            // 
            this.HeatBTN.FlatAppearance.BorderSize = 0;
            this.HeatBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeatBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HeatBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.HeatBTN.Location = new System.Drawing.Point(182, 535);
            this.HeatBTN.Name = "HeatBTN";
            this.HeatBTN.Size = new System.Drawing.Size(94, 27);
            this.HeatBTN.TabIndex = 16;
            this.HeatBTN.Text = "Обзор";
            this.HeatBTN.UseVisualStyleBackColor = true;
            this.HeatBTN.Click += new System.EventHandler(this.HeatBTN_Click);
            // 
            // HeatLABEL
            // 
            this.HeatLABEL.AutoSize = true;
            this.HeatLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.HeatLABEL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.HeatLABEL.Location = new System.Drawing.Point(12, 496);
            this.HeatLABEL.Name = "HeatLABEL";
            this.HeatLABEL.Size = new System.Drawing.Size(258, 36);
            this.HeatLABEL.TabIndex = 15;
            this.HeatLABEL.Text = "Матрица тепловых параметров \r\nэлементов";
            // 
            // MutationTEXTBOX
            // 
            this.MutationTEXTBOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.MutationTEXTBOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MutationTEXTBOX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.MutationTEXTBOX.Location = new System.Drawing.Point(73, 338);
            this.MutationTEXTBOX.Name = "MutationTEXTBOX";
            this.MutationTEXTBOX.Size = new System.Drawing.Size(53, 20);
            this.MutationTEXTBOX.TabIndex = 14;
            this.MutationTEXTBOX.Click += new System.EventHandler(this.MutationTEXTBOX_Click);
            this.MutationTEXTBOX.TextChanged += new System.EventHandler(this.MutationTEXTBOX_TextChanged);
            // 
            // MutationLABEL
            // 
            this.MutationLABEL.AutoSize = true;
            this.MutationLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.MutationLABEL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.MutationLABEL.Location = new System.Drawing.Point(132, 338);
            this.MutationLABEL.Name = "MutationLABEL";
            this.MutationLABEL.Size = new System.Drawing.Size(91, 18);
            this.MutationLABEL.TabIndex = 13;
            this.MutationLABEL.Text = "% мутаций";
            this.MutationLABEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumOfGensTEXTBOX
            // 
            this.NumOfGensTEXTBOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.NumOfGensTEXTBOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumOfGensTEXTBOX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.NumOfGensTEXTBOX.Location = new System.Drawing.Point(90, 273);
            this.NumOfGensTEXTBOX.Name = "NumOfGensTEXTBOX";
            this.NumOfGensTEXTBOX.Size = new System.Drawing.Size(100, 20);
            this.NumOfGensTEXTBOX.TabIndex = 12;
            this.NumOfGensTEXTBOX.Click += new System.EventHandler(this.NumOfGensTEXTBOX_Click);
            this.NumOfGensTEXTBOX.TextChanged += new System.EventHandler(this.NumOfGensTEXTBOX_TextChanged);
            // 
            // NumOfGensLABEL
            // 
            this.NumOfGensLABEL.AutoSize = true;
            this.NumOfGensLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.NumOfGensLABEL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.NumOfGensLABEL.Location = new System.Drawing.Point(28, 200);
            this.NumOfGensLABEL.Name = "NumOfGensLABEL";
            this.NumOfGensLABEL.Size = new System.Drawing.Size(231, 54);
            this.NumOfGensLABEL.TabIndex = 11;
            this.NumOfGensLABEL.Text = "Введите кол-во поколений, \r\nна протяжении которого \r\nF неизменно";
            this.NumOfGensLABEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PCBheightTEXTBOX
            // 
            this.PCBheightTEXTBOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.PCBheightTEXTBOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCBheightTEXTBOX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PCBheightTEXTBOX.Location = new System.Drawing.Point(159, 150);
            this.PCBheightTEXTBOX.Name = "PCBheightTEXTBOX";
            this.PCBheightTEXTBOX.Size = new System.Drawing.Size(100, 20);
            this.PCBheightTEXTBOX.TabIndex = 10;
            this.PCBheightTEXTBOX.Click += new System.EventHandler(this.PCBheightTEXTBOX_Click);
            this.PCBheightTEXTBOX.TextChanged += new System.EventHandler(this.PCBheightTEXTBOX_TextChanged);
            // 
            // PCBwidthTEXTBOX
            // 
            this.PCBwidthTEXTBOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.PCBwidthTEXTBOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCBwidthTEXTBOX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PCBwidthTEXTBOX.Location = new System.Drawing.Point(26, 150);
            this.PCBwidthTEXTBOX.Name = "PCBwidthTEXTBOX";
            this.PCBwidthTEXTBOX.Size = new System.Drawing.Size(100, 20);
            this.PCBwidthTEXTBOX.TabIndex = 9;
            this.PCBwidthTEXTBOX.Click += new System.EventHandler(this.PCBwidthTEXTBOX_Click);
            this.PCBwidthTEXTBOX.TextChanged += new System.EventHandler(this.PCBwidthTEXTBOX_TextChanged);
            // 
            // PCBheightLABEL
            // 
            this.PCBheightLABEL.AutoSize = true;
            this.PCBheightLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.PCBheightLABEL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.PCBheightLABEL.Location = new System.Drawing.Point(162, 98);
            this.PCBheightLABEL.Name = "PCBheightLABEL";
            this.PCBheightLABEL.Size = new System.Drawing.Size(97, 36);
            this.PCBheightLABEL.TabIndex = 8;
            this.PCBheightLABEL.Text = "Высота \r\nплаты (мм)";
            this.PCBheightLABEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PCBwidthLABEL
            // 
            this.PCBwidthLABEL.AutoSize = true;
            this.PCBwidthLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.PCBwidthLABEL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.PCBwidthLABEL.Location = new System.Drawing.Point(23, 98);
            this.PCBwidthLABEL.Name = "PCBwidthLABEL";
            this.PCBwidthLABEL.Size = new System.Drawing.Size(97, 36);
            this.PCBwidthLABEL.TabIndex = 7;
            this.PCBwidthLABEL.Text = "Ширина \r\nплаты (мм)";
            this.PCBwidthLABEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumOfSpeciesTEXTBOX
            // 
            this.NumOfSpeciesTEXTBOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.NumOfSpeciesTEXTBOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumOfSpeciesTEXTBOX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.NumOfSpeciesTEXTBOX.Location = new System.Drawing.Point(90, 56);
            this.NumOfSpeciesTEXTBOX.Name = "NumOfSpeciesTEXTBOX";
            this.NumOfSpeciesTEXTBOX.Size = new System.Drawing.Size(100, 20);
            this.NumOfSpeciesTEXTBOX.TabIndex = 6;
            this.NumOfSpeciesTEXTBOX.Click += new System.EventHandler(this.NumOfSpeciesTEXTBOX_Click);
            this.NumOfSpeciesTEXTBOX.TextChanged += new System.EventHandler(this.NumOfSpeciesTEXTBOX_TextChanged);
            // 
            // NumOfSpeciesLABEL
            // 
            this.NumOfSpeciesLABEL.AutoSize = true;
            this.NumOfSpeciesLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.NumOfSpeciesLABEL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.NumOfSpeciesLABEL.Location = new System.Drawing.Point(42, 19);
            this.NumOfSpeciesLABEL.Name = "NumOfSpeciesLABEL";
            this.NumOfSpeciesLABEL.Size = new System.Drawing.Size(194, 18);
            this.NumOfSpeciesLABEL.TabIndex = 5;
            this.NumOfSpeciesLABEL.Text = "Введите кол-во особей";
            // 
            // StartBTN
            // 
            this.StartBTN.FlatAppearance.BorderSize = 0;
            this.StartBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StartBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.StartBTN.Location = new System.Drawing.Point(96, 577);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(94, 27);
            this.StartBTN.TabIndex = 4;
            this.StartBTN.Text = "START";
            this.StartBTN.UseVisualStyleBackColor = true;
            this.StartBTN.Click += new System.EventHandler(this.StartBTN_Click);
            // 
            // ElementSizeBTN
            // 
            this.ElementSizeBTN.FlatAppearance.BorderSize = 0;
            this.ElementSizeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ElementSizeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ElementSizeBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ElementSizeBTN.Location = new System.Drawing.Point(182, 447);
            this.ElementSizeBTN.Name = "ElementSizeBTN";
            this.ElementSizeBTN.Size = new System.Drawing.Size(94, 27);
            this.ElementSizeBTN.TabIndex = 3;
            this.ElementSizeBTN.Text = "Обзор";
            this.ElementSizeBTN.UseVisualStyleBackColor = true;
            this.ElementSizeBTN.Click += new System.EventHandler(this.ElementSizeBTN_Click);
            // 
            // ElementSizeLABEL
            // 
            this.ElementSizeLABEL.AutoSize = true;
            this.ElementSizeLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.ElementSizeLABEL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.ElementSizeLABEL.Location = new System.Drawing.Point(12, 451);
            this.ElementSizeLABEL.Name = "ElementSizeLABEL";
            this.ElementSizeLABEL.Size = new System.Drawing.Size(156, 18);
            this.ElementSizeLABEL.TabIndex = 2;
            this.ElementSizeLABEL.Text = "Матрица размеров";
            // 
            // AdjacencyBTN
            // 
            this.AdjacencyBTN.FlatAppearance.BorderSize = 0;
            this.AdjacencyBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdjacencyBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AdjacencyBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.AdjacencyBTN.Location = new System.Drawing.Point(182, 401);
            this.AdjacencyBTN.Name = "AdjacencyBTN";
            this.AdjacencyBTN.Size = new System.Drawing.Size(94, 27);
            this.AdjacencyBTN.TabIndex = 1;
            this.AdjacencyBTN.Text = "Обзор";
            this.AdjacencyBTN.UseVisualStyleBackColor = true;
            this.AdjacencyBTN.Click += new System.EventHandler(this.AdjacencyBTN_Click);
            // 
            // AdjacencyLABEL
            // 
            this.AdjacencyLABEL.AutoSize = true;
            this.AdjacencyLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.AdjacencyLABEL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.AdjacencyLABEL.Location = new System.Drawing.Point(12, 405);
            this.AdjacencyLABEL.Name = "AdjacencyLABEL";
            this.AdjacencyLABEL.Size = new System.Drawing.Size(167, 18);
            this.AdjacencyLABEL.TabIndex = 0;
            this.AdjacencyLABEL.Text = "Матрица смежности";
            // 
            // CloseBTN
            // 
            this.CloseBTN.FlatAppearance.BorderSize = 0;
            this.CloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CloseBTN.ForeColor = System.Drawing.Color.White;
            this.CloseBTN.Location = new System.Drawing.Point(917, 12);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(25, 25);
            this.CloseBTN.TabIndex = 1;
            this.CloseBTN.Text = "X";
            this.CloseBTN.UseVisualStyleBackColor = true;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // openAdjacencyFileDialog1
            // 
            this.openAdjacencyFileDialog1.FileName = "openFileDialog1";
            // 
            // openElementSizeFileDialog1
            // 
            this.openElementSizeFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(340, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 498);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openHeatFileDialog1
            // 
            this.openHeatFileDialog1.FileName = "openFileDialog1";
            // 
            // ProgramResultLABEL
            // 
            this.ProgramResultLABEL.AutoSize = true;
            this.ProgramResultLABEL.Location = new System.Drawing.Point(340, 561);
            this.ProgramResultLABEL.Name = "ProgramResultLABEL";
            this.ProgramResultLABEL.Size = new System.Drawing.Size(0, 13);
            this.ProgramResultLABEL.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(954, 627);
            this.Controls.Add(this.ProgramResultLABEL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.Button AdjacencyBTN;
        private System.Windows.Forms.Label AdjacencyLABEL;
        private System.Windows.Forms.Button ElementSizeBTN;
        private System.Windows.Forms.Label ElementSizeLABEL;
        private System.Windows.Forms.OpenFileDialog openAdjacencyFileDialog1;
        private System.Windows.Forms.OpenFileDialog openElementSizeFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button StartBTN;
        private System.Windows.Forms.TextBox NumOfSpeciesTEXTBOX;
        private System.Windows.Forms.Label NumOfSpeciesLABEL;
        private System.Windows.Forms.TextBox PCBheightTEXTBOX;
        private System.Windows.Forms.TextBox PCBwidthTEXTBOX;
        private System.Windows.Forms.Label PCBheightLABEL;
        private System.Windows.Forms.Label PCBwidthLABEL;
        private System.Windows.Forms.Label NumOfGensLABEL;
        private System.Windows.Forms.TextBox NumOfGensTEXTBOX;
        private System.Windows.Forms.TextBox MutationTEXTBOX;
        private System.Windows.Forms.Label MutationLABEL;
        private System.Windows.Forms.Button HeatBTN;
        private System.Windows.Forms.Label HeatLABEL;
        private System.Windows.Forms.OpenFileDialog openHeatFileDialog1;
        private System.Windows.Forms.Label ProgramResultLABEL;
    }
}

