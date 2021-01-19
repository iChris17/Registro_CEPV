using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXApplication4.Utils;

namespace DXApplication4
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            checkLogin();       
        }

        private void checkLogin()
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            DataTable dt = ConexionBD.ExtraeDatos($"select u.CODIGO,u.usuario as USUARIO,u.NOMBRE,u.APELLIDO,u.EMAIL,r.ROL as ROL, CONVERT(VARCHAR(MAX), DECRYPTBYPASSPHRASE('{password}', u.contrasenia)) as PASSWORD from usuarios u inner join roles r on r.codigo=u.cod_rol where u.usuario='{usuario}'");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontro ningún usuario");
            }
            else
            {
                string pass = dt.Rows[0]["PASSWORD"].ToString();
                string user = dt.Rows[0]["USUARIO"].ToString();
                string nombre = dt.Rows[0]["NOMBRE"].ToString();
                string apellido = dt.Rows[0]["APELLIDO"].ToString();
                string email = dt.Rows[0]["EMAIL"].ToString();
                string rol = dt.Rows[0]["ROL"].ToString();
                int cod = Convert.ToInt32(dt.Rows[0]["CODIGO"].ToString());
                if (pass == password)
                {
                    Usuario.User = user;
                    Usuario.Nombre = nombre;
                    Usuario.Apellido = apellido;
                    Usuario.Email = email;
                    Usuario.Rol = rol;
                    Usuario.CodUser = cod;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == System.Windows.Forms.CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkLogin();
            }
        }
    }
}
