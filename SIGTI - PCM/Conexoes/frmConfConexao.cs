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

namespace SIGT___PCM.Conexoes
{
    public partial class frmConfConexao : MetroFramework.Forms.MetroForm
    {
        public frmConfConexao()
        {
            InitializeComponent();
        }
        string connectionString;

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivos de Dados (*.accdb)|*.ACCDB";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtCaminho.Text = ofd.FileName;
            }
        }

        private void btnVisualizarSenha_Click(object sender, EventArgs e)
        {
            if (txtSenhaDB.PasswordChar == '*')
            {
                txtSenhaDB.PasswordChar = default;
            }
            else
            {
                txtSenhaDB.PasswordChar = '*';
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Jet OLEDB:Database Password={1};", txtCaminho.Text, txtSenhaDB.Text);
                if (string.IsNullOrEmpty(txtCaminho.Text))
                {

                }
                else
                {
                    AppSetting setting = new AppSetting();
                    setting.SaveConnectionString("DB_SIGT", connectionString);
                    if (MessageBox.Show("Sua conexão foi salva com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Application.Restart();
                        //Environment.Exit(0);
                    }
                }
            }
            catch (OleDbException eRR)
            {
                MessageBox.Show(eRR.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
