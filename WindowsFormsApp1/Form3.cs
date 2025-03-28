using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class btnCalcular : Form
    {
        int i, soma = 0, x, contador = 30;
        int[] vetorNotas = new int[30];
        public btnCalcular()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (contador != 0)
            {
                contador = contador - 1;
                for (i = 0; i < 30; i++)
                {
                    x = Convert.ToInt32(txtnota.Text);
                    vetorNotas[i] = x;
                    soma = soma + vetorNotas[i];
                    txtnota.Clear();
                    txtnota.Focus();
                    break;
                }
                txtmedia.Text = "(" + contador.ToString() + ")";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            soma = 0;
            txtmedia.Clear();
            txtnota.Clear();    
            txtnota.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtmedia.Text = (soma / 30).ToString();
        }

        private void btnCalcular_Load(object sender, EventArgs e)
        {
        }
    }
}
