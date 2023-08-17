using SIGT___PCM.Conexoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGT___PCM.Login
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
            label3.Text = ProductVersion;
        }

        public bool FMP = false;

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            LoginLogar loginLogar = new LoginLogar();
            loginLogar.LogarAcesso(txtUser.Text, txtSenha.Text);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                if (DatabaseConnection.DB_SIGT().State == ConnectionState.Open)
                {

                }
            }catch (OleDbException)
            {
                frmConfConexao frmConfConexao = new frmConfConexao();
                frmConfConexao.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
