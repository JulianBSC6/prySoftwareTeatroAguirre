using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySoftwareTeatroAguirre
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnQuenaken_Click(object sender, EventArgs e)
        {
            quenaken panel = new quenaken();
            panel2.Controls.Clear();
            panel2.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
            lblLocal.Controls.Clear();
            lblLocal.Text = "QUENAKEN";
            
        }

        private void btnOnas_Click(object sender, EventArgs e)
        {
            onas panel = new onas();
            panel2.Controls.Clear();
            panel2.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
            lblLocal.Controls.Clear();
            lblLocal.Text = "ONAS";
        }

        private void btnTobas_Click(object sender, EventArgs e)
        {
            lblLocal.Controls.Clear();
            lblLocal.Text = "TOBAS";
        }
    }
}
