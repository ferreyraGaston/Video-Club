using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Video_Club
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PicSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PicMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            PicMax.Visible = false;
            PicRestaurar.Visible = true;
        }

        private void PicMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void PicRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            PicMax.Visible = true;
            PicRestaurar.Visible = false;
        }
    }
}
