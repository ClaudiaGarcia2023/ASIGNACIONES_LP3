using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_PARCIAL_LP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
            private void button1_Click(object sender, EventArgs e)

            {
                int Num = Convert.ToInt16(txb1.Text);

                if (Num % 2 == 0 & Num >= 0)
                {
                    MessageBox.Show("Numero " + Num + " ingresado es par y positivo");

                }
                else if (Num % 2 == 0 & Num <= 0)
                {
                    MessageBox.Show("Numero " + Num + " ingresado es par y negativo");

                }
                else if (Num % 2 != 0 & Num >= 0)
                {
                    MessageBox.Show("Numero " + Num + " ingresado es impar y positivo");

                }
                else
                    MessageBox.Show("Numero " + Num + " ingresado es impar y negativo");

            }
        }
    }
