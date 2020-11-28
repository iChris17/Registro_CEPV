using DevExpress.Utils.MVVM;
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
    public partial class NuevoEstudiante : Form
    {
        DataTable dtTutores = new DataTable();
        DataTable dtGradosPrimaria = new DataTable();
        DataTable dtGradosSecundaria = new DataTable();

        public NuevoEstudiante()
        {
            InitializeComponent();
            habilitarTraslado();
            comboTpBeca.Enabled = false;
            txtMontoPor.Enabled = false;
            txtMonedaCor.Enabled = false;
            txtCorreo.Enabled = false;
            txtCarnet.Enabled = false;
            checkCedula.Checked = true;
            dtTutores.Columns.Add("Nombre");
            dtTutores.Columns.Add("Parentesco");
            dtTutores.Columns.Add("Telefono");
            dtTutores.Columns.Add("Correo");
            dtTutores.Columns.Add("Operador");
            comboTutorParentesco.Properties.DataSource = ConexionBD.ExtraeDatos("select T.TIPO from TP_TUTOR T where T.ACTIVO=1");
            rellenarDataGrados();

        }

        private void rellenarDataGrados()
        {
            string[] primaria = { "PRIMER GRADO","SEGUNDO GRADO","TERCER GRADO","CUARTO GRADO","QUINTO GRADO","SEXTO GRADO"};
            string[] secundaria = { "SEPTIMO GRADO", "OCTAVO GRADO", "NOVENO GRADO", "DECIMO GRADO", "UNDECIMO GRADO" };
            dtGradosPrimaria.Columns.Add("GRADO");
            dtGradosSecundaria.Columns.Add("GRADO");

            for (int i = 0; i < primaria.Length; i++)
            {
                DataRow row = dtGradosPrimaria.NewRow();
                row["GRADO"] = primaria[i];
                dtGradosPrimaria.Rows.Add(row);
            }

            for (int i = 0; i < secundaria.Length; i++)
            {
                DataRow row = dtGradosSecundaria.NewRow();
                row["GRADO"] = secundaria[i];
                dtGradosSecundaria.Rows.Add(row);
            }
        }

        private void habilitarTraslado(bool estado=false) {
            txtTrasladoCodCentro.Enabled = estado;
            txtTrasladoCodEstabl.Enabled = estado;
            txtTrasladoGrado.Enabled = estado;
            txtTrasladoModalidad.Enabled = estado;
            txtTrasladoNombre.Enabled = estado;
            txtTrasladoPrograma.Enabled = estado;
            comboTrasladoPeriodo.Enabled = estado;
        }

        private void guardarEstudiante()
        {
            var pnombre = txtPrimerNombre.Text;
            var snombre = txtSegundoNombre.Text;
            var papellido = txtPrimerApellido.Text;
            var sapellido = txtSegundoApellido.Text;
            var codMined = txtCodMINED.Text;
            var carnet = txtCarnet.Text;
            var cedula = txtCedula.Text;
            var fnacimiento = Convert.ToDateTime(dateFechaNacimiento.EditValue);
            var departamento = comboDepartamento.EditValue;
            var municipio = txtMunicipio.Text;
            var barrio = "";
            var direccion = txtDireccion.Text.ToUpper();
            var partida = true;
            var sexo = checkMasculino.Checked ? "M" : "F";
            var telefono = txtTelefono.Text;
            var nacionalidad = txtNacionalidad.Text.ToUpper();
            var discapacidad = txtPadecimientos.Text.ToUpper();
            var modalidad = txtPrograma.EditValue;
            var grado = txtGrado.EditValue;
            var turno = txtTurno.EditValue;
            var email = txtCorreo.Text;
            if (pnombre.Trim()==string.Empty)
            {
                MessageBox.Show("Error al guardar");
                return;
            }
            var result = ConexionBD.EjecutarPro("sp_INSERTARESTUDIANTE", codMined, carnet, cedula, pnombre, snombre, papellido, sapellido, fnacimiento,
                departamento, municipio, barrio, direccion, partida, sexo, telefono, nacionalidad, discapacidad, modalidad, grado, turno, email
                );

            for (int i = 0; i < dtTutores.Rows.Count; i++)
            {
                var nbtutor = dtTutores.Rows[i]["Nombre"].ToString().ToUpper();
                var parentescotutor = dtTutores.Rows[i]["Parentesco"].ToString();
                var telefonotutor = dtTutores.Rows[i]["Telefono"].ToString();
                var operadortutor = dtTutores.Rows[i]["Operador"].ToString();
                var correotutor = dtTutores.Rows[i]["Correo"].ToString();
                var resultTutores = ConexionBD.EjecutarPro("sp_AGREGARTUTOR",carnet,nbtutor,telefonotutor,operadortutor,correotutor, parentescotutor);
            }

            if (checkTraslado.Checked)
            {
                var trasladocodestable = txtTrasladoCodEstabl.Text;
                var trascodcentro = txtTrasladoCodCentro.Text;
                var trasnbcentro = txtTrasladoNombre.Text;
                var trasprograma = txtTrasladoPrograma.Text;
                var trasmodalidad = txtTrasladoModalidad.Text;
                var trasgrado = txtTrasladoGrado.Text;
                var trasperiodo = comboTrasladoPeriodo.Text;

                var resulttraslado = ConexionBD.EjecutarPro("sp_INSERTARTRASLADO", carnet, trasladocodestable, trascodcentro, trasnbcentro, trasprograma, trasmodalidad, trasgrado, trasperiodo);
            }

            var programa = txtPrograma.EditValue;
            var vlmatricula = Convert.ToDouble(txtMatricula.EditValue);
            var vlmensualidad = Convert.ToDouble(txtMensualidadTotal.EditValue);
            var fhmatricula = DateTime.Now;

            var resultmatricula = ConexionBD.EjecutarPro("sp_INSERTARMATRICULA",carnet,programa,modalidad,grado,turno,vlmatricula,vlmensualidad,fhmatricula);

            if (checkBeca.Checked)
            {
                var porcentaje = Convert.ToDouble(txtMontoPor.EditValue);
                var montocordobas = Convert.ToDouble(txtMonedaCor.EditValue);
                var mensualidadtotal = Convert.ToDouble(txtMensualidadTotal.EditValue);

                var resultbeca = ConexionBD.EjecutarPro("sp_INSERTARBECA",porcentaje,montocordobas,mensualidadtotal,DateTime.Now);
            }

            if (result&&resultmatricula)
            {
                HojaMatricula print = new HojaMatricula(carnet);
                var dialog=print.ShowDialog();
                if (dialog==DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                }
                
            }
            else
            {
                MessageBox.Show("Error al guardar");
            }
        }

        private void officeNavigationBar1_ItemClick(object sender, DevExpress.XtraBars.Navigation.NavigationBarItemEventArgs e)
        {
            if (e.Item.Text=="Cerrar")
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            } else if (e.Item.Text == "Guardar (F10)")
            {

                guardarEstudiante();
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkTraslado_CheckedChanged(object sender, EventArgs e)
        {
            habilitarTraslado(checkTraslado.Checked);
        }

        private void officeNavigationBar1_Click(object sender, EventArgs e)
        {

        }

        private void checkMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMasculino.Checked)
            {
                checkFemenino.Checked = false;
            }
        }

        private void checkFemenino_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFemenino.Checked)
            {
                checkMasculino.Checked = false;
            }
        }

        private void checkPartida_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void checkPartidaNo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBeca_CheckedChanged(object sender, EventArgs e)
        {
            comboTpBeca.Enabled = checkBeca.Checked;
            txtMontoPor.Enabled = checkBeca.Checked;
            txtMonedaCor.Enabled = checkBeca.Checked;
        }

        private void checkCedula_CheckedChanged(object sender, EventArgs e)
        {
            txtCedula.Enabled = !checkCedula.Checked;
        }

        private void dateFechaNacimiento_EditValueChanged(object sender, EventArgs e)
        {
            if (txtPrimerNombre.Text.Trim()==string.Empty||txtPrimerApellido.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Debe rellenar el primer nombre o primer apellido del estudiante para continuar");
                txtPrimerNombre.Focus();
                return;
            }
            DateTime fecha = Convert.ToDateTime(dateFechaNacimiento.EditValue);
            string mes = "";
            string year = "";
            string dia = "";
            if (fecha.Month<=9)
            {
                mes = "0" + fecha.Month.ToString();
            }
            else
            {
                mes = fecha.Month.ToString();
            }
            if (fecha.Day <= 9)
            {
                dia = "0" + fecha.Day.ToString();
            }
            else
            {
                dia = fecha.Day.ToString();
            }
            year = fecha.Year.ToString().Substring(2, 2);
            string nombre = txtPrimerNombre.Text;
            string apellido = txtPrimerApellido.Text;
            string carnet = $"{nombre.Substring(0,1).ToUpper()}{apellido.Substring(0, 1).ToUpper()}-{dia}{mes}{year}PV";
            txtCarnet.Text = carnet;
            txtCorreo.Text = $"{nombre.Substring(0, 1).ToLower()}{apellido.Substring(0, 1).ToLower()}{dia}{mes}{year}pv@planetaverde.edu.ni";
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMontoPor_EditValueChanged(object sender, EventArgs e)
        {
            if (txtMontoPor.Text.Trim()==string.Empty)
            {
                txtMontoPor.Text = "0";
                return;
            }
            double mensualidad = Convert.ToDouble(txtMensualidad.Text);
            double porcentaje = Convert.ToDouble(txtMontoPor.Text)/100;
            double descuento = mensualidad * porcentaje;
            double valor = mensualidad - descuento;
            txtMensualidadTotal.Text = valor.ToString();
            txtMonedaCor.Text = descuento.ToString();
        }

        private void txtMonedaCor_EditValueChanged(object sender, EventArgs e)
        {
            if (txtMonedaCor.Text.Trim() == string.Empty)
            {
                txtMonedaCor.Text = "0";
                return;
            }
            double mensualidad = Convert.ToDouble(txtMensualidad.Text);
            double descuento = Convert.ToDouble(txtMonedaCor.Text);
            double porcentaje = descuento/mensualidad;
            double valor = mensualidad - descuento;
            txtMensualidadTotal.Text = valor.ToString();
            txtMontoPor.Text = (porcentaje*100).ToString();
        }

        private void txtTrasladoPrograma_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTrasladoPrograma.EditValue.ToString() == "PRIMARIA")
            {
                txtTrasladoGrado.Properties.DataSource = dtGradosPrimaria;
            }
            else
            {
                txtTrasladoGrado.Properties.DataSource = dtGradosSecundaria;
            }
        }

        private void btnTutorGuardar_Click(object sender, EventArgs e)
        {
            DataRow row=dtTutores.NewRow();
            row["Nombre"] = txtTutorNombre.Text;
            row["Parentesco"] = comboTutorParentesco.EditValue;
            row["Telefono"] = txtTutorTelefono.Text;
            row["Correo"] = txtTutorCorreo.Text;
            row["Operador"] = comboOperador.Text;
            dtTutores.Rows.Add(row);

            gridTutores.DataSource = null;
            gridTutores.DataSource = dtTutores;

            txtTutorNombre.Text = "";
            comboTutorParentesco.Text="";
            txtTutorTelefono.Text = "";
            txtTutorCorreo.Text = "";
            comboOperador.Text = "";
        }

        private void txtPrograma_EditValueChanged(object sender, EventArgs e)
        {
            if (txtPrograma.EditValue.ToString()=="PRIMARIA")
            {
                txtGrado.Properties.DataSource = dtGradosPrimaria;
            }
            else
            {
                txtGrado.Properties.DataSource = dtGradosSecundaria;
            }
        }

        private void NuevoEstudiante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                guardarEstudiante();
            }
        }

        private void txtMensualidad_EditValueChanged(object sender, EventArgs e)
        {
            txtMensualidadTotal.Text = txtMensualidad.Text;
        }

        private void txtTurno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
