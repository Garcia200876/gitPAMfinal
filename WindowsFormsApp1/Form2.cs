using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WindowsFormsApp1
{
    public partial class frmPares : Form
    {
        public frmPares()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] vetorA = new int[15];// declara o vetor 
            int i;
            Random media = new Random(); // adiciona o random para sorteio 

            for (i = 0; i < 15; i++)
            {
                vetorA[i] = media.Next(1, 20);// Gera números aleatórios entre 1 e 20

                if (i % 2 == 0) 
                { 
                    txtResult.Text += vetorA[i].ToString() + " ";
                    //"Posição ", i, ": ", vetorA[i], "\n"
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
