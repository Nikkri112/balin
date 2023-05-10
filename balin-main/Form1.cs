using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int i=0, j=0;
        string? s = "";
        int m, n;
        int[,]? arr1, arr2,arr3,arr4,arr5;
        Matrix Gmatrix1 = new Matrix();
        Matrix Gmatrix = new Matrix();
        public char KeyChar { get; set; }
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public async void manual_Click(object sender, EventArgs e)
        {
        }

        public void random_Click(object sender, EventArgs e)
        {
        }

        private void height_ValueChanged(object sender, EventArgs e)
        {

        }

        private void width_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            matrix1.Text = "";
            s = "";
            arr1 = new int[m, n];

        }

        private void matrix1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void manualinput_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void manualinput_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            arr3 = new int[m, n];
            s = "";
            for (i=0; i<m; i++)
            {
                for(j=0; j<n; j++)
                {
                    arr3[i,j] = arr1[i,j]+arr2[i,j];
                    s = s + ($"{arr3[i, j],2:d} ");
                }
                s= s + ("\n");
            }
            outputer.Text= s;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            m = Convert.ToInt32(Height.Value);
            n = Convert.ToInt32(Width.Value);
            //arr1 = new int[m, n];
            ////arr1 = new int[m, n];
            ////arr2 = new int[m, n];
            ////arr3 = new int[m, n];
            //s = "";
            //for (i = 0; i < m; i++)
            //{
            //    for (j = 0; j < n; j++)
            //    {
            //        arr1[i, j] = rnd.Next(1, 100);
            //        s = s + ($"{arr1[i, j],2:d} ");//, i, j, arr[i,j]);

            //    }
            //    s = s + ("\n");
            //    matrix1.Text = s;
            //}
            Matrix Gmatrix = new Matrix();
            Gmatrix.RandomCreate(n, m);
            Gmatrix.Print(matrix1, n, m);
        }

        private void random2_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            m = Convert.ToInt32(Height.Value);
            n = Convert.ToInt32(Width.Value);
            //arr2 = new int[m, n];
            ////arr1 = new int[m, n];
            ////arr2 = new int[m, n];
            ////arr3 = new int[m, n];
            //s = "";
            //for (i = 0; i < m; i++)
            //{
            //    for (j = 0; j < n; j++)
            //    {
            //        arr2[i, j] = rnd.Next(1, 100);
            //        s = s + ($"{arr2[i, j],2:d} ");//, i, j, arr[i,j]);

            //    }
            //    s = s + ("\n");
            //    matrix2.Text = s;
            //}
            Matrix Gmatrix1 = new Matrix();
            Gmatrix1.RandomCreate(n, m);
            Gmatrix1.Print(matrix2, n, m);
        }

        public void manual1_Click(object sender, EventArgs e)
        {
            s = "";
            matrix1.Text = "";
            i = 0; j = 0;
            m = Convert.ToInt32(Height.Value);
            n = Convert.ToInt32(Width.Value);
            Gmatrix = new Matrix();
            manualinput1.Enabled = true;
            Gmatrix.CreateManual(n, m);
        }

        public void manualinput1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (i < m)
                {
                    if (j < n)
                    {
                        Gmatrix.inputManual(i, j, Convert.ToInt32(manualinput1.Text));
                        //arr1[i, j] = Convert.ToInt32(manualinput1.Text);
                        manualinput1.Text = "";
                        //s = s + ($"{arr1[i, j],2:d} ");
                        j++;
                    }
                    else
                    {
                        //s = s + ("\n");
                        j = 0;
                        i++;
                    }
                }
                else
                {
                    manualinput1.Text = "";
                    //matrix1.Text = s;
                    Gmatrix.Print(matrix1, n, m);
                    manualinput1.Enabled = false;
                    s = "";
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (i < m)
                {
                    if (j < n)
                    {
                        //arr2[i, j] = Convert.ToInt32(manualinput2.Text);
                        //manualinput2.Text = "";
                        //s = s + ($"{arr2[i, j],2:d} ");
                        Gmatrix1.inputManual(i, j, Convert.ToInt32(manualinput2.Text));
                        j++;
                    }
                    else
                    {
                        //s = s + ("\n");
                        j = 0;
                        i++; 
                    }
                }
                else
                {
                    manualinput2.Text = "";
                    Gmatrix1.Print(matrix2, n, m);
                    manualinput2.Enabled = false;
                    //s = "";
                }
            }
        }

        private void manual2_Click(object sender, EventArgs e)
        {
            s = "";
            matrix2.Text = "";
            i = 0; j = 0;
            m = Convert.ToInt32(Height.Value);
            n = Convert.ToInt32(Width.Value);
            Matrix Gmatrix1 = new Matrix();
            manualinput2.Enabled = true;
            Gmatrix1.CreateManual(n, m);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void clearoutputer_Click(object sender, EventArgs e)
        {
            outputer.Text = "";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            arr4 = new int[m, n];
            s = "";
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr4[i, j] = arr1[j, i];
                }
            }
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr1[i, j] = arr4[i, j];
                    s = s + ($"{arr1[i, j],2:d} ");
                }
                s = s + ("\n");
            }
            matrix1.Text = s;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            arr5= new int[m, n];
            s = "";
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr5[i, j] = arr2[j, i];
                }
            }
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr2[i, j] = arr5[i,j];
                    s = s + ($"{arr2[i, j],2:d} ");
                }
                s = s + ("\n");
            }
            matrix2.Text = s;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            s = "";
            arr3 = new int[m, n];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr3[i, j] = arr1[i, j] - arr2[i, j];
                    s = s + ($"{arr3[i, j],2:d} ");
                }
                s = s + ("\n");
            }
            outputer.Text = s;
        }

        private void manualinput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void clearmatrix2_Click(object sender, EventArgs e)
        {
            matrix2.Text = "";
            s = "";
            arr2 = new int[m, n];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m = Convert.ToInt32(Height.Value);
            n = Convert.ToInt32(Width.Value);
            arr1 = new int[m, n];   
        }
        }
}