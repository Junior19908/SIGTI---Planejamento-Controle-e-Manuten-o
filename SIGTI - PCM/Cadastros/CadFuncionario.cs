using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGT___PCM.Cadastros
{
    public partial class CadFuncionario : MetroFramework.Forms.MetroForm
    {
        public CadFuncionario()
        {
            InitializeComponent();
        }

        private void CadFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Visible = false;
        }
    }
}
