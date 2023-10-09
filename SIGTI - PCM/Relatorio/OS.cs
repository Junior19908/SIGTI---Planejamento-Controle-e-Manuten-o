using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGT___PCM.Relatorio
{
    public partial class OS : Form
    {
        public OS()
        {
            InitializeComponent();
        }

        private void OS_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "C:\\Users\\junio\\source\\repos\\SIGTI - Planejamento Controle e Manutenção\\SIGTI - PCM\\Relatorio\\RelatorioOS.rdlc";
            this.reportViewer1.RefreshReport();
        }
    }
}
