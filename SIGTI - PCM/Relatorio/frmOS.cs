﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using SIGT___PCM.Relatorio;
using MetroFramework.Components;
using SIGT___PCM.Tema;

namespace SIGT___PCM
{
    public partial class frmOS : MetroFramework.Forms.MetroForm
    {
        public frmOS()
        {
            InitializeComponent();
            TemaGeralPrograma.SetPurpleStyle(metroStyleManagerOrdemServico);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            relatorioOS relatorioOS = new relatorioOS();
            relatorioOS.GerarRelatorioPDF();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 menuIni = new Form1();
            menuIni.Show();
            this.Visible = false;
        }
    }
}
