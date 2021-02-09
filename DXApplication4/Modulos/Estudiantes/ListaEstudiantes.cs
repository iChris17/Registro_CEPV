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
            DataTable dtPolitica = ConexionBD.Leer("sp_VerificarPermiso", "ESTUDIANTES", Usuario.CodUser);
            int PoliticaVisualizar = Convert.ToInt32(dtPolitica.Rows[0]["VISUALIZAR"].ToString());
            if (PoliticaVisualizar==1)
            {
                gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT E.* FROM VW_LISTAESTUDIANTES_PRINCIPAL E order by [FECHA DE MATRICULA] desc");
                if (gridViewLista.RowCount == 0)
                {
                    btnVerMatricula.Enabled = false;
                }
                else
                {
                    btnVerMatricula.Enabled = true;
                }
                string total = ConexionBD.ExtraeDatos("select count(*) as total from estudiante").Rows[0]["total"].ToString();
                lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + total;
            }
            else
            {
                btnVerMatricula.Enabled = false;
                gridListaEstudiante.DataSource = null;
                lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + 0;
                navBarFiltros.Enabled = false;

                lblNbEstudiante.Text = string.Empty;
                lblCorreoEstudiante.Text = string.Empty;
                lblGradoEstudiante.Text = string.Empty;
                lblEstadoEstudiante.Text = string.Empty;
            }
                    
        }

        private void btnNuevoEstudiante_Click(object sender, EventArgs e)
        {
            DataTable dtPolitica = ConexionBD.Leer("sp_VerificarPermiso", "ESTUDIANTES", Usuario.CodUser);
            int PoliticaCrear = Convert.ToInt32(dtPolitica.Rows[0]["CREAR"].ToString());
            if (PoliticaCrear==1)
            {
                var frmNuev = new NuevoEstudiante();
                var result = frmNuev.ShowDialog();
                if (result == DialogResult.OK)
                {
                    gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT E.* FROM VW_LISTAESTUDIANTES_PRINCIPAL E order by [FECHA DE MATRICULA] desc");
                    lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E ").Rows[0]["TOTAL"].ToString();
                }
            } else
            {
                MessageBox.Show("No tiene permisos necesarios. Consulte al administrador del sistema.");
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
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT E.* FROM VW_LISTAESTUDIANTES_PRINCIPAL E order by [FECHA DE MATRICULA] desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E ").Rows[0]["TOTAL"].ToString();
        }

        private void itemPrimaria_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT E.* FROM VW_LISTAESTUDIANTES_PRINCIPAL E where MODALIDAD='PRIMARIA' order by [FECHA DE MATRICULA] desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E where E.MODALIDAD='PRIMARIA' ").Rows[0]["TOTAL"].ToString();
        }

        private void itemSecundaria_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT E.* FROM VW_LISTAESTUDIANTES_PRINCIPAL E where MODALIDAD='SECUNDARIA' order by [FECHA DE MATRICULA] desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E where E.MODALIDAD='SECUNDARIA' ").Rows[0]["TOTAL"].ToString();
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void itemPrimerGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT E.* FROM VW_LISTAESTUDIANTES_PRINCIPAL E where GRADO='PRIMER GRADO' order by [FECHA DE MATRICULA] desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E where E.GRADO='PRIMER GRADO' ").Rows[0]["TOTAL"].ToString();
        }

        private void itemSegundoGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT E.* FROM VW_LISTAESTUDIANTES_PRINCIPAL E where GRADO='SEGUNDO GRADO' order by [FECHA DE MATRICULA] desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E where E.GRADO='SEGUNDO GRADO' ").Rows[0]["TOTAL"].ToString();
        }

        private void itemTercerGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT E.* FROM VW_LISTAESTUDIANTES_PRINCIPAL E where GRADO='TERCER GRADO' order by [FECHA DE MATRICULA] desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E where E.GRADO='TERCER GRADO' ").Rows[0]["TOTAL"].ToString();
        }

        private void itemCuartoGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT E.* FROM VW_LISTAESTUDIANTES_PRINCIPAL E where GRADO='CUARTO GRADO' order by [FECHA DE MATRICULA] desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E where E.GRADO='CUARTO GRADO' ").Rows[0]["TOTAL"].ToString();
        }

        private void itemQuintoGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT E.* FROM VW_LISTAESTUDIANTES_PRINCIPAL E where GRADO='QUINTO GRADO' order by [FECHA DE MATRICULA] desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E where E.GRADO='QUINTO GRADO' ").Rows[0]["TOTAL"].ToString();
        }

        private void itemSextoGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT E.* FROM VW_LISTAESTUDIANTES_PRINCIPAL E where GRADO='SEXTO GRADO' order by [FECHA DE MATRICULA] desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E where E.GRADO='SEXTO GRADO' ").Rows[0]["TOTAL"].ToString();
        }

        private void itemSeptimoGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT E.* FROM VW_LISTAESTUDIANTES_PRINCIPAL E where GRADO='SEPTIMO GRADO' order by [FECHA DE MATRICULA] desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E where E.GRADO='SEPTIMO GRADO' ").Rows[0]["TOTAL"].ToString();
        }

        private void itemOctavoGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT E.* FROM VW_LISTAESTUDIANTES_PRINCIPAL E where GRADO='OCTAVO GRADO' order by [FECHA DE MATRICULA] desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E where E.GRADO='OCTAVO GRADO' ").Rows[0]["TOTAL"].ToString();
        }

        private void itemNovenoGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT E.* FROM VW_LISTAESTUDIANTES_PRINCIPAL E where GRADO='NOVENO GRADO' order by [FECHA DE MATRICULA] desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E where E.GRADO='NOVENO GRADO' ").Rows[0]["TOTAL"].ToString();
        }

        private void itemDecimoGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT E.* FROM VW_LISTAESTUDIANTES_PRINCIPAL E where GRADO='DECIMO GRADO' order by [FECHA DE MATRICULA] desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E where E.GRADO='DECIMO GRADO' ").Rows[0]["TOTAL"].ToString();
        }

        private void itemUndecimoGrado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridListaEstudiante.DataSource = ConexionBD.ExtraeDatos("SELECT E.* FROM VW_LISTAESTUDIANTES_PRINCIPAL E where GRADO='UNDECIMO GRADO' order by [FECHA DE MATRICULA] desc");
            lblTotalEstudiantes.Text = "Número de estudiantes matriculados: " + ConexionBD.ExtraeDatos("SELECT COUNT(*) as TOTAL FROM ESTUDIANTE E where E.GRADO='UNDECIMO GRADO' ").Rows[0]["TOTAL"].ToString();
        }

        private void btnVerMatricula_Click(object sender, EventArgs e)
        {
            DataTable dtPolitica = ConexionBD.Leer("sp_VerificarPermiso", "ESTUDIANTES", Usuario.CodUser);
            int PoliticaReporte = Convert.ToInt32(dtPolitica.Rows[0]["REPORTE"].ToString());
            if (PoliticaReporte == 1)
            {
                int carne = gridViewLista.GetSelectedRows()[0];
                var b = gridViewLista.GetFocusedDataRow()["CARNET"];
                HojaMatricula frmPrint = new HojaMatricula(b.ToString());
                frmPrint.Show();
            }
            else
            {
                MessageBox.Show("No tiene permisos necesarios. Consulte al administrador del sistema.");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DataTable dtPolitica = ConexionBD.Leer("sp_VerificarPermiso", "ESTUDIANTES", Usuario.CodUser);
            int PoliticaExportar = Convert.ToInt32(dtPolitica.Rows[0]["EXPORTAR"].ToString());
            if (PoliticaExportar == 1)
            {
                DataTable dt = ConexionBD.ExtraeDatos("SELECT * FROM VW_EXPORTAR_ESTUDIANTES_EXCEL");
                dt.ExportToExcel(null);
            }
            else
            {
                MessageBox.Show("No tiene permisos necesarios. Consulte al administrador del sistema.");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataTable dtPolitica = ConexionBD.Leer("sp_VerificarPermiso", "ESTUDIANTES", Usuario.CodUser);
            int PoliticaExportar = Convert.ToInt32(dtPolitica.Rows[0]["EXPORTAR"].ToString());
            if (PoliticaExportar == 1)
            {
                DataTable dt = ConexionBD.ExtraeDatos("SELECT * FROM VW_TUTORES_EXPORTAR_EXCEL");
                dt.ExportToExcel(null);
            }
            else
            {
                MessageBox.Show("No tiene permisos necesarios. Consulte al administrador del sistema.");
            }
        }

        private void lblTotalEstudiantes_Click(object sender, EventArgs e)
        {

        }
    }
}
