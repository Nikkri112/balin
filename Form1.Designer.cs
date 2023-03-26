using System.Windows.Forms;
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.elemnum = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.manualinput = new System.Windows.Forms.TextBox();
            this.Width = new System.Windows.Forms.NumericUpDown();
            this.Height = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.random = new System.Windows.Forms.Button();
            this.manual = new System.Windows.Forms.Button();
            this.matrix1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.matrix2 = new System.Windows.Forms.RichTextBox();
            this.clearmatrix2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.summ = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.outputer = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.random1 = new System.Windows.Forms.Button();
            this.manual1 = new System.Windows.Forms.Button();
            this.random2 = new System.Windows.Forms.Button();
            this.manual2 = new System.Windows.Forms.Button();
            this.manualinput1 = new System.Windows.Forms.TextBox();
            this.manualinput2 = new System.Windows.Forms.TextBox();
            this.clearoutputer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.elemnum);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.manualinput);
            this.panel1.Controls.Add(this.Width);
            this.panel1.Controls.Add(this.Height);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.random);
            this.panel1.Controls.Add(this.manual);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 148);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(856, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(10, 10);
            this.button3.TabIndex = 13;
            this.button3.Text = "СТАРТ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // elemnum
            // 
            this.elemnum.AutoSize = true;
            this.elemnum.Location = new System.Drawing.Point(375, 62);
            this.elemnum.Name = "elemnum";
            this.elemnum.Size = new System.Drawing.Size(0, 15);
            this.elemnum.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(856, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(10, 10);
            this.button2.TabIndex = 10;
            this.button2.Text = "Ок";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // manualinput
            // 
            this.manualinput.Enabled = false;
            this.manualinput.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manualinput.Location = new System.Drawing.Point(712, 30);
            this.manualinput.Name = "manualinput";
            this.manualinput.Size = new System.Drawing.Size(10, 35);
            this.manualinput.TabIndex = 9;
            this.manualinput.Visible = false;
            this.manualinput.TextChanged += new System.EventHandler(this.manualinput_TextChanged);
            this.manualinput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.manualinput_KeyDown);
            this.manualinput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.manualinput_KeyPress);
            // 
            // Width
            // 
            this.Width.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Width.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Width.Location = new System.Drawing.Point(105, 94);
            this.Width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(37, 31);
            this.Width.TabIndex = 8;
            this.Width.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Width.ValueChanged += new System.EventHandler(this.width_ValueChanged);
            // 
            // Height
            // 
            this.Height.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Height.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Height.Location = new System.Drawing.Point(105, 42);
            this.Height.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(37, 31);
            this.Height.TabIndex = 7;
            this.Height.Tag = "";
            this.Height.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Height.ValueChanged += new System.EventHandler(this.height_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ширина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Высота";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Задайте размерность матрицы";
            // 
            // random
            // 
            this.random.BackColor = System.Drawing.Color.SeaShell;
            this.random.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.random.Location = new System.Drawing.Point(856, 0);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(10, 10);
            this.random.TabIndex = 1;
            this.random.Text = "Случайно";
            this.random.UseVisualStyleBackColor = false;
            this.random.Visible = false;
            this.random.Click += new System.EventHandler(this.random_Click);
            // 
            // manual
            // 
            this.manual.BackColor = System.Drawing.Color.Tomato;
            this.manual.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manual.Location = new System.Drawing.Point(558, 30);
            this.manual.Name = "manual";
            this.manual.Size = new System.Drawing.Size(39, 48);
            this.manual.TabIndex = 0;
            this.manual.Text = "Вручную";
            this.manual.UseVisualStyleBackColor = false;
            this.manual.Visible = false;
            this.manual.Click += new System.EventHandler(this.manual_Click);
            // 
            // matrix1
            // 
            this.matrix1.Enabled = false;
            this.matrix1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.matrix1.Location = new System.Drawing.Point(12, 154);
            this.matrix1.Name = "matrix1";
            this.matrix1.Size = new System.Drawing.Size(235, 236);
            this.matrix1.TabIndex = 1;
            this.matrix1.Text = "";
            this.matrix1.TextChanged += new System.EventHandler(this.matrix1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // matrix2
            // 
            this.matrix2.Enabled = false;
            this.matrix2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.matrix2.Location = new System.Drawing.Point(329, 154);
            this.matrix2.Name = "matrix2";
            this.matrix2.Size = new System.Drawing.Size(239, 236);
            this.matrix2.TabIndex = 3;
            this.matrix2.Text = "";
            // 
            // clearmatrix2
            // 
            this.clearmatrix2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearmatrix2.Location = new System.Drawing.Point(329, 401);
            this.clearmatrix2.Name = "clearmatrix2";
            this.clearmatrix2.Size = new System.Drawing.Size(84, 52);
            this.clearmatrix2.TabIndex = 4;
            this.clearmatrix2.Text = "Очистить";
            this.clearmatrix2.UseVisualStyleBackColor = true;
            this.clearmatrix2.Click += new System.EventHandler(this.clearmatrix2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            // 
            // summ
            // 
            this.summ.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.summ.Location = new System.Drawing.Point(253, 154);
            this.summ.Name = "summ";
            this.summ.Size = new System.Drawing.Size(70, 59);
            this.summ.TabIndex = 5;
            this.summ.Text = "+";
            this.summ.UseVisualStyleBackColor = true;
            this.summ.Click += new System.EventHandler(this.button3_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minus.Location = new System.Drawing.Point(253, 330);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(70, 60);
            this.minus.TabIndex = 6;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.button4_Click);
            // 
            // outputer
            // 
            this.outputer.Enabled = false;
            this.outputer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.outputer.Location = new System.Drawing.Point(603, 154);
            this.outputer.Name = "outputer";
            this.outputer.Size = new System.Drawing.Size(197, 236);
            this.outputer.TabIndex = 7;
            this.outputer.Text = "";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(105, 401);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 52);
            this.button4.TabIndex = 8;
            this.button4.Text = "T";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(419, 401);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 52);
            this.button5.TabIndex = 9;
            this.button5.Text = "T";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // random1
            // 
            this.random1.Location = new System.Drawing.Point(163, 401);
            this.random1.Name = "random1";
            this.random1.Size = new System.Drawing.Size(84, 23);
            this.random1.TabIndex = 10;
            this.random1.Text = "Случайно";
            this.random1.UseVisualStyleBackColor = true;
            this.random1.Click += new System.EventHandler(this.button6_Click);
            // 
            // manual1
            // 
            this.manual1.Location = new System.Drawing.Point(163, 430);
            this.manual1.Name = "manual1";
            this.manual1.Size = new System.Drawing.Size(84, 23);
            this.manual1.TabIndex = 11;
            this.manual1.Text = "Вручную";
            this.manual1.UseVisualStyleBackColor = true;
            this.manual1.Click += new System.EventHandler(this.manual1_Click);
            // 
            // random2
            // 
            this.random2.Location = new System.Drawing.Point(475, 401);
            this.random2.Name = "random2";
            this.random2.Size = new System.Drawing.Size(84, 23);
            this.random2.TabIndex = 12;
            this.random2.Text = "Случайно";
            this.random2.UseVisualStyleBackColor = true;
            this.random2.Click += new System.EventHandler(this.random2_Click);
            // 
            // manual2
            // 
            this.manual2.Location = new System.Drawing.Point(475, 430);
            this.manual2.Name = "manual2";
            this.manual2.Size = new System.Drawing.Size(84, 23);
            this.manual2.TabIndex = 13;
            this.manual2.Text = "Вручную";
            this.manual2.UseVisualStyleBackColor = true;
            this.manual2.Click += new System.EventHandler(this.manual2_Click);
            // 
            // manualinput1
            // 
            this.manualinput1.Enabled = false;
            this.manualinput1.Location = new System.Drawing.Point(12, 459);
            this.manualinput1.Name = "manualinput1";
            this.manualinput1.Size = new System.Drawing.Size(235, 23);
            this.manualinput1.TabIndex = 14;
            this.manualinput1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.manualinput1_KeyDown);
            // 
            // manualinput2
            // 
            this.manualinput2.Enabled = false;
            this.manualinput2.Location = new System.Drawing.Point(329, 459);
            this.manualinput2.Name = "manualinput2";
            this.manualinput2.Size = new System.Drawing.Size(239, 23);
            this.manualinput2.TabIndex = 15;
            this.manualinput2.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.manualinput2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // clearoutputer
            // 
            this.clearoutputer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearoutputer.Location = new System.Drawing.Point(603, 401);
            this.clearoutputer.Name = "clearoutputer";
            this.clearoutputer.Size = new System.Drawing.Size(197, 52);
            this.clearoutputer.TabIndex = 16;
            this.clearoutputer.Text = "Очистить";
            this.clearoutputer.UseVisualStyleBackColor = true;
            this.clearoutputer.Click += new System.EventHandler(this.clearoutputer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 506);
            this.Controls.Add(this.clearoutputer);
            this.Controls.Add(this.manualinput2);
            this.Controls.Add(this.manualinput1);
            this.Controls.Add(this.manual2);
            this.Controls.Add(this.random2);
            this.Controls.Add(this.manual1);
            this.Controls.Add(this.random1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.outputer);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.summ);
            this.Controls.Add(this.clearmatrix2);
            this.Controls.Add(this.matrix2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.matrix1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Прямоугольная матрица";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SaveFileDialog saveFileDialog1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        public RichTextBox matrix1;
        public NumericUpDown Height;
        private NumericUpDown Width;
        private Button button1;
        private RichTextBox matrix2;
        private Label elemnum;
        private Button clearmatrix2;
        private System.Windows.Forms.Timer timer1;
        private Button summ;
        private Button minus;
        private RichTextBox outputer;
        private Button button4;
        private Button button5;
        private Button random1;
        private Button manual1;
        private Button random2;
        private Button manual2;
        private TextBox manualinput1;
        private TextBox manualinput2;
        private Button button3;
        private Button button2;
        public TextBox manualinput;
        private Button random;
        private Button manual;
        private Button clearoutputer;
    }
}