using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercícios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[15];
            int i;
            Random Num = new Random();

            for (i = 0; i < 15; i++) 
            {
                vetor[i] = Num.Next(0,50);
            }

            for (i = 0; i < 15; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    rtxt1.Text += vetor[i].ToString() + Environment.NewLine;
                }
            }
        }
    }
}
