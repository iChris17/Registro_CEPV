﻿using DXApplication4.Modulos.Estudiantes;
using DXApplication4.Modulos.Matricula;
using DXApplication4.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication4
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            Login login = new Login();
            var validateUser = login.ShowDialog();
            this.Hide();

            if (validateUser==DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Show();
                this.Dispose();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ListaEstudiantes);
            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }
            var FrmBod = new ListaEstudiantes();
            FrmBod.MdiParent = this;
            FrmBod.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Matricula);
            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }
            var FrmBod = new Matricula();
            FrmBod.MdiParent = this;
            FrmBod.Show();
        }

        private void backstageViewTabItem2_SelectedChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            Application.Exit();
        }

        private void backstageViewTabItem1_SelectedChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

        }

        private void bvInfoUsuario_Load(object sender, EventArgs e)
        {
            txtBVInfo_Usuario.Text = Usuario.User;
            txtBVInfo_Nombre.Text = Usuario.Nombre + " " + Usuario.Apellido;
            txtBVInfo_Correo.Text = Usuario.Email;
            txtBVInfo_Rol.Text = Usuario.Rol;
        }
    }
}
