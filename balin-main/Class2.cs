using DryIoc.FastExpressionCompiler.LightExpression;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class Matrix
    {
        int[,]? matrixarr;
        public void RandomCreate(int a,int b)
        {
                Random rnd = new Random();
            matrixarr = new int[a, b];  
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        matrixarr[i, j] = rnd.Next(1, 100);
                    }
                }
        }
        public void Print(RichTextBox text, int a, int b)
        {
            string s = "";
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    s = s + ($"{matrixarr[i, j],2:d} ");//, i, j, arr[i,j]);
                }
                s = s + ("\n");
                text.Text = s;
            }
        }

        public void CreateManual(int a,int b)
        {
            matrixarr = new int[a, b];
            return;
        }
        public void inputManual(int i, int j, int znach)
        {
            matrixarr[i, j] = znach;
        }

        public void plus(Matrix c,int a,int b,RichTextBox Otvet)
        {
            string s = "";
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    s = Convert.ToString(c.matrixarr[i, j] + matrixarr[i, j]);
                }
                s = s + ("\n");
                Otvet.Text = s;
            }
        }
    }
}


