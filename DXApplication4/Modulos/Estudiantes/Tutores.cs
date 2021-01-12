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
    public partial class Tutores : Form
    {
        public string nombre;
        public string telefono;
        public string operador;
        public string email;
        public string parentesco;
        public Tutores()
        {
            InitializeComponent();
            DataTable dt= ConexionBD.ExtraeDatos("SELECT T.NOMBRES AS TUTOR, T.TELEFONO, T.OPERADOR,T.EMAIL FROM TUTOR T");
            gridTutor.DataSource = dt;
            comboParentesco.Properties.DataSource = ConexionBD.ExtraeDatos("select T.TIPO from TP_TUTOR T where T.ACTIVO=1");
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRow() != null && comboParentesco.EditValue!=null)
            {
                var nombre = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
                var telefono = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
                var operador = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
                var email = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]).ToString();

                this.nombre = nombre;
                this.telefono = telefono;
                this.operador = operador;
                this.email = email;
                this.parentesco = comboParentesco.EditValue.ToString();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
