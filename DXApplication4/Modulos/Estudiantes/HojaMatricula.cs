using DevExpress.XtraReports.UI;
using DXApplication4.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication4.Modulos.Estudiantes
{
    public partial class HojaMatricula : Form
    {
        string codCarnet;
        public HojaMatricula(string CodCarnet="")
        {
            this.codCarnet = CodCarnet;
            InitializeComponent();

            HojaDeMatricula report = new HojaDeMatricula();
            report.Parameters[0].Value = this.codCarnet;
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        private void HojaMatricula_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
