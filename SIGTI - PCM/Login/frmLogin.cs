using MetroFramework.Components;
using SIGT___PCM.Conexoes;
using SIGT___PCM.Tema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            TemaGeralPrograma.SetPurpleStyle(metroStyleManagerLogin);
        }

        public bool FMP = false;
        int CounErro = 0;
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            LoginLogar loginLogar = new LoginLogar();
            loginLogar.LogarAcesso(txtUser.Text, txtSenha.Text);
            string salt = "randomsalt";
            if (ClassDadosGet.Senha == loginLogar.HashPassword(txtSenha.Text,salt))
            {
                if (ClassDadosGet.Status == 1)
                {
                    FMP = true;
                    this.Dispose();
                }
            }
            else
            {
                CounErro ++;
                lblErroChance.Visible = true;
                lblErroTentativas.Visible = true;
                int val = 5;
                int ContMenos =- CounErro + val;
                
                if (CounErro == 1)
                {
                    lblErroChance.Text = "Erro você ainda tem "+ ContMenos +" chances.";
                    lblErroTentativas.Text = "Você tem " + CounErro + " de 5 tentativas!";
                }
                else
                {
                    lblErroChance.Text = "Erro você ainda tem " + ContMenos + " chances.";
                    lblErroTentativas.Text = "Você tem " + CounErro + " de 5 tentativas!";
                }
                if (CounErro == 4)
                {
                    txtUser.Enabled = false;
                    MessageBox.Show("Em breve, o programa será fechado! n/ Última tantativa");
                }
                else if (CounErro >= 5)
                {
                    txtUser.Visible = false;
                    txtSenha.Visible = false;
                    MessageBox.Show("Muitas tentativas, o programa será fechado!");
                    Application.Exit();
                }
            }
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
