using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class EjemploMDI : Form
    {
        public EjemploMDI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MnuManUsuario_Click(object sender, EventArgs e)
        {
            ManUsuario frm = new ManUsuario();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
