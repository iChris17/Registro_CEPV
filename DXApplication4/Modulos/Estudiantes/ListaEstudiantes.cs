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
    public partial class ListaEstudiantes : Form
    {
        public ListaEstudiantes()
        {
            InitializeComponent();
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO FROM ESTUDIANTE E");
            
        }

        private void btnNuevoEstudiante_Click(object sender, EventArgs e)
        {
            var frmNuev = new NuevoEstudiante();
            var result=frmNuev.ShowDialog();
            if (result==DialogResult.OK)
            {
                gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO FROM ESTUDIANTE E");
            }
                
        }

        private void gridViewLista_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var obj = gridViewLista.GetFocusedRow();
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
            }
        }

        private void navBarGroup1_ItemChanged(object sender, EventArgs e)
        {
           
        }

        private void ItemTodos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO FROM ESTUDIANTE E");
        }

        private void itemPrimaria_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO FROM ESTUDIANTE E where E.MODALIDAD='PRIMARIA'");

        }

        private void itemSecundaria_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO FROM ESTUDIANTE E where E.MODALIDAD='SECUNDARIA'");

        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void itemPrimerGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO FROM ESTUDIANTE E where E.GRADO='PRIMER GRADO'");

        }

        private void itemSegundoGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO FROM ESTUDIANTE E where E.GRADO='SEGUNDO GRADO'");

        }

        private void itemTercerGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO FROM ESTUDIANTE E where E.GRADO='TERCER GRADO'");

        }

        private void itemCuartoGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO FROM ESTUDIANTE E where E.GRADO='CUARTO GRADO'");

        }

        private void itemQuintoGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO FROM ESTUDIANTE E where E.GRADO='QUINTO GRADO'");

        }

        private void itemSextoGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO FROM ESTUDIANTE E where E.GRADO='SEXTO GRADO'");

        }

        private void itemSeptimoGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO FROM ESTUDIANTE E where E.GRADO='SEPTIMO GRADO'");

        }

        private void itemOctavoGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO FROM ESTUDIANTE E where E.GRADO='OCTAVO GRADO'");

        }

        private void itemNovenoGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO FROM ESTUDIANTE E where E.GRADO='NOVENO GRADO'");

        }

        private void itemDecimoGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO FROM ESTUDIANTE E where E.GRADO='DECIMO GRADO'");

        }

        private void itemUndecimoGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT (E.PRIMER_NOMBRE+' '+E.SEGUNDO_NOMBRE + ' '+E.PRIMER_APELLIDO+' '+E.SEGUNDO_APELLIDO) AS [Nombre Completo], E.COD_CARNE AS CARNET, E.FECHA_NACIMIENTO AS [Fecha de Nacimiento] ,E.EMAIL AS [Correo Institucional], e.TELEFONO, E.MODALIDAD,E.GRADO FROM ESTUDIANTE E where E.GRADO='UNDECIMO GRADO'");

        }

        private void btnVerMatricula_Click(object sender, EventArgs e)
        {
            /* HojaDeMatricula report = new HojaDeMatricula();
             report.Parameters[0].Value = "SH-181096PV";
             ReportPrintTool printTool = new ReportPrintTool(report);
     // Invoke the Print dialog.
     printTool.PrintDialog();*/

            HojaMatricula frmPrint = new HojaMatricula("SH-181096PV");
            frmPrint.Show();
        }
    }
}
