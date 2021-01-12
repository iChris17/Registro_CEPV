using DevExpress.XtraReports.UI;
using DXApplication4.Reports;
using DXApplication4.Utils;
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
    public partial class ListaEstudiantes : Form
    {
        public ListaEstudiantes()
        {
            InitializeComponent();
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO, E.FH_REGISTRO AS [FECHA DE MATRICULA] FROM ESTUDIANTE E order by E.FH_REGISTRO desc");
            if (gridViewLista.RowCount==0)
            {
                btnVerMatricula.Enabled = false;
            }
            string total = ConexionBD.ExtraeDatos("select count(*) as total from estudiante").Rows[0]["total"].ToString();
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + total;
           
        }

        private void btnNuevoEstudiante_Click(object sender, EventArgs e)
        {
            var frmNuev = new NuevoEstudiante();
            var result=frmNuev.ShowDialog();
            if (result==DialogResult.OK)
            {
                gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO, E.FH_REGISTRO AS [FECHA DE MATRICULA] FROM ESTUDIANTE E order by E.FH_REGISTRO desc");
                lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E ").Rows[0]["TOTAL"].ToString();
            }

        }

        private void gridViewLista_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridViewLista.GetFocusedRow() != null)
            {
                var nombre = gridViewLista.GetRowCellValue(gridViewLista.FocusedRowHandle, gridViewLista.Columns[0]).ToString();
                var email = gridViewLista.GetRowCellValue(gridViewLista.FocusedRowHandle, gridViewLista.Columns[3]).ToString();
                var grado = gridViewLista.GetRowCellValue(gridViewLista.FocusedRowHandle, gridViewLista.Columns[6]).ToString();
                var estado = gridViewLista.GetRowCellValue(gridViewLista.FocusedRowHandle, gridViewLista.Columns[5]).ToString();
                lblNbEstudiante.Text = nombre;
                lblCorreoEstudiante.Text = email;
                lblGradoEstudiante.Text = grado;
                lblEstadoEstudiante.Text = estado;
                btnVerMatricula.Enabled = true;
            }
        }

        private void navBarGroup1_ItemChanged(object sender, EventArgs e)
        {
           
        }

        private void ItemTodos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO, E.FH_REGISTRO AS [FECHA DE MATRICULA] FROM ESTUDIANTE E order by E.FH_REGISTRO desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E ").Rows[0]["TOTAL"].ToString();
        }

        private void itemPrimaria_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO, E.FH_REGISTRO AS [FECHA DE MATRICULA] FROM ESTUDIANTE E where E.MODALIDAD='PRIMARIA' order by E.FH_REGISTRO desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E where E.MODALIDAD='PRIMARIA' ").Rows[0]["TOTAL"].ToString();
        }

        private void itemSecundaria_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO, E.FH_REGISTRO AS [FECHA DE MATRICULA] FROM ESTUDIANTE E where E.MODALIDAD='SECUNDARIA' order by E.FH_REGISTRO desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E where E.MODALIDAD='SECUNDARIA' ").Rows[0]["TOTAL"].ToString();
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void itemPrimerGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO, E.FH_REGISTRO AS [FECHA DE MATRICULA] FROM ESTUDIANTE E where E.GRADO='PRIMER GRADO' order by E.FH_REGISTRO desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E where E.GRADO='PRIMER GRADO' ").Rows[0]["TOTAL"].ToString();
        }

        private void itemSegundoGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO, E.FH_REGISTRO AS [FECHA DE MATRICULA] FROM ESTUDIANTE E where E.GRADO='SEGUNDO GRADO' order by E.FH_REGISTRO desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E where E.GRADO='SEGUNDO GRADO' ").Rows[0]["TOTAL"].ToString();
        }

        private void itemTercerGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO, E.FH_REGISTRO AS [FECHA DE MATRICULA] FROM ESTUDIANTE E where E.GRADO='TERCER GRADO' order by E.FH_REGISTRO desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E where E.GRADO='TERCER GRADO' ").Rows[0]["TOTAL"].ToString();
        }

        private void itemCuartoGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO, E.FH_REGISTRO AS [FECHA DE MATRICULA] FROM ESTUDIANTE E where E.GRADO='CUARTO GRADO' order by E.FH_REGISTRO desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E where E.GRADO='CUARTO GRADO' ").Rows[0]["TOTAL"].ToString();
        }

        private void itemQuintoGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO, E.FH_REGISTRO AS [FECHA DE MATRICULA] FROM ESTUDIANTE E where E.GRADO='QUINTO GRADO' order by E.FH_REGISTRO desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E where E.GRADO='QUINTO GRADO' ").Rows[0]["TOTAL"].ToString();
        }

        private void itemSextoGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO, E.FH_REGISTRO AS [FECHA DE MATRICULA] FROM ESTUDIANTE E where E.GRADO='SEXTO GRADO' order by E.FH_REGISTRO desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E where E.GRADO='SEXTO GRADO' ").Rows[0]["TOTAL"].ToString();
        }

        private void itemSeptimoGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO, E.FH_REGISTRO AS [FECHA DE MATRICULA] FROM ESTUDIANTE E where E.GRADO='SEPTIMO GRADO' order by E.FH_REGISTRO desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E where E.GRADO='SEPTIMO GRADO' ").Rows[0]["TOTAL"].ToString();
        }

        private void itemOctavoGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO, E.FH_REGISTRO AS [FECHA DE MATRICULA] FROM ESTUDIANTE E where E.GRADO='OCTAVO GRADO' order by E.FH_REGISTRO desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E where E.GRADO='OCTAVO GRADO' ").Rows[0]["TOTAL"].ToString();
        }

        private void itemNovenoGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO, E.FH_REGISTRO AS [FECHA DE MATRICULA] FROM ESTUDIANTE E where E.GRADO='NOVENO GRADO' order by E.FH_REGISTRO desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E where E.GRADO='NOVENO GRADO' ").Rows[0]["TOTAL"].ToString();
        }

        private void itemDecimoGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO, E.FH_REGISTRO AS [FECHA DE MATRICULA] FROM ESTUDIANTE E where E.GRADO='DECIMO GRADO' order by E.FH_REGISTRO desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E where E.GRADO='DECIMO GRADO' ").Rows[0]["TOTAL"].ToString();
        }

        private void itemUndecimoGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO, E.FH_REGISTRO AS [FECHA DE MATRICULA] FROM ESTUDIANTE E where E.GRADO='UNDECIMO GRADO' order by E.FH_REGISTRO desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E where E.GRADO='UNDECIMO GRADO' ").Rows[0]["TOTAL"].ToString();
        }

        private void btnVerMatricula_Click(object sender, EventArgs e)
        {
            /* HojaDeMatricula report = new HojaDeMatricula();
             report.Parameters[0].Value = "SH-181096PV";
             ReportPrintTool printTool = new ReportPrintTool(report);
     // Invoke the Print dialog.
     printTool.PrintDialog();*/
            int carne = gridViewLista.GetSelectedRows()[0];
            var b = gridViewLista.GetFocusedDataRow()["CARNET"];
            HojaMatricula frmPrint = new HojaMatricula(b.ToString());
            frmPrint.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DataTable dt = ConexionBD.ExtraeDatos("SELECT  E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE+' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO AS ESTUDIANTE,E.FECHA_NACIMIENTO, E.TELEFONO, E.EMAIL,E.DIRECCION,E.Modalidad AS MODALIDAD,E.GRADO,UPPER(E.TURNO) AS TURNO,CONVERT(DECIMAL(16,2),M.VL_MENSUALIDAD) AS MENSUALIDAD,CONVERT(DECIMAL(16, 2), M.VL_MATRICULA) AS MATRICULA, E.COD_CARNE,CONVERT(DATE, M.FH_REGISTRO) AS FECHA_MATRICULA FROM ESTUDIANTE E INNER JOIN MATRICULA M ON E.COD_CARNE = M.COD_CARNE");
            dt.ExportToExcel(null);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = ConexionBD.ExtraeDatos("SELECT E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE+' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO AS ESTUDIANTE,T.NOMBRES+' '+T.APELLIDOS AS TUTOR, T.TELEFONO, T.OPERADOR ,T.EMAIL,E.COD_CARNE FROM ESTUDIANTE_TUTOR ET INNER JOIN TUTOR T ON T.CODIGO=ET.CODTUTOR INNER JOIN ESTUDIANTE E ON E.COD_CARNE=ET.CODCARNE");
            dt.ExportToExcel(null);
        }

        private void lblTotalEstudiantes_Click(object sender, EventArgs e)
        {

        }
    }
}
