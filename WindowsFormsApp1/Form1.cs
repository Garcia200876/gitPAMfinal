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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void paresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPares pares = new frmPares();
            pares.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void programasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mediaDasNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            btnCalcular notas = new btnCalcular();
            notas.Show();
        }
    }
}
