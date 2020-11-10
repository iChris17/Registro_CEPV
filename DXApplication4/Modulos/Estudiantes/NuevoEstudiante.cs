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
        public NuevoEstudiante()
        {
            InitializeComponent();
            habilitarTraslado();
            comboTpBeca.Enabled = false;
            txtMontoPor.Enabled = false;
            txtMonedaCor.Enabled = false;
            txtCorreo.Enabled = false;
            txtCarnet.Enabled = false;
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

        private void officeNavigationBar1_ItemClick(object sender, DevExpress.XtraBars.Navigation.NavigationBarItemEventArgs e)
        {
            if (e.Item.Text=="Cerrar")
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            } else if (e.Item.Text == "Guardar")
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
                var direccion = txtDireccion.Text;
                var partida = checkPartida.Checked;
                var sexo = checkMasculino.Checked ? "M" : "F";
                var telefono = txtTelefono.Text;
                var nacionalidad = txtNacionalidad.Text;
                var discapacidad = txtPadecimientos.Text;
                var modalidad = txtPrograma.Text;
                var grado = txtGrado.Text;
                var turno = txtTurno.Text;
                var email = txtCorreo.Text;
                var result = ConexionBD.EjecutarPro("sp_INSERTARESTUDIANTE",codMined,carnet,cedula,pnombre,snombre,papellido,sapellido,fnacimiento,
                    departamento,municipio,barrio,direccion,partida,sexo,telefono,nacionalidad,discapacidad,modalidad,grado,turno,email
                    );
                if (result)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al guardar");
                }
                
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
            if (checkPartida.Checked)
            {
                checkPartidaNo.Checked = false;
            }
        }

        private void checkPartidaNo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPartidaNo.Checked)
            {
                checkPartida.Checked = false;
            }
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
            txtCorreo.Text = $"{nombre.Substring(0, 1).ToLower()}{apellido.Substring(0, 1).ToLower()}{dia}{mes}{year}PV@planetaverde.edu.ni";
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMontoPor_EditValueChanged(object sender, EventArgs e)
        {
            double mensualidad = Convert.ToDouble(txtMensualidad.Text);
            double porcentaje = Convert.ToDouble(txtMontoPor.Text);
            double descuento = mensualidad * (porcentaje / 100);
            double valor = mensualidad - descuento;
            txtMensualidad.Text = valor.ToString();
            txtMonedaCor.Text = descuento.ToString();
        }

        private void txtMonedaCor_EditValueChanged(object sender, EventArgs e)
        {
            double mensualidad = Convert.ToDouble(txtMensualidad.Text);
            double descuento = Convert.ToDouble(txtMonedaCor.Text);
            double porcentaje = descuento/mensualidad;
            double valor = mensualidad - descuento;
            txtMensualidad.Text = valor.ToString();
            txtMontoPor.Text = porcentaje.ToString();
        }
    }
}
