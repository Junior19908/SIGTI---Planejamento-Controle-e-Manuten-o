using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGTI___PCM
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOS_Click(object sender, EventArgs e)
        {
            frmOS frmOS = new frmOS();
            frmOS.Show();
            this.Visible = false;
        }

        private void btnOS_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
