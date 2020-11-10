using DXApplication4.Modulos.Estudiantes;
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
    }
}
