namespace DXApplication4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.bv_InfoGeneral = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.txtRazonSocial = new DevExpress.XtraEditors.TextEdit();
            this.txtDireccion = new DevExpress.XtraEditors.TextEdit();
            this.txtAnioLectivo = new DevExpress.XtraEditors.TextEdit();
            this.txtNbCentro = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.bvInfoUsuario = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.txtBVInfo_Rol = new DevExpress.XtraEditors.TextEdit();
            this.txtBVInfo_Correo = new DevExpress.XtraEditors.TextEdit();
            this.txtBVInfo_Nombre = new DevExpress.XtraEditors.TextEdit();
            this.txtBVInfo_Usuario = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.backstageViewClientControl2 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.tabInfoGeneral = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.backstageViewTabItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.backstageViewTabItem2 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            this.backstageViewControl1.SuspendLayout();
            this.bv_InfoGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazonSocial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnioLectivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNbCentro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.bvInfoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBVInfo_Rol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBVInfo_Correo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBVInfo_Nombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBVInfo_Usuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonDropDownControl = this.backstageViewControl1;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.barButtonItem4});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1442, 193);
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.Controls.Add(this.bv_InfoGeneral);
            this.backstageViewControl1.Items.Add(this.tabInfoGeneral);
            this.backstageViewControl1.Items.Add(this.backstageViewTabItem1);
            this.backstageViewControl1.Items.Add(this.backstageViewTabItem2);
            this.backstageViewControl1.Location = new System.Drawing.Point(0, 226);
            this.backstageViewControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.OwnerControl = this.ribbonControl1;
            this.backstageViewControl1.SelectedTab = this.tabInfoGeneral;
            this.backstageViewControl1.SelectedTabIndex = 0;
            this.backstageViewControl1.Size = new System.Drawing.Size(1410, 491);
            this.backstageViewControl1.TabIndex = 1;
            this.backstageViewControl1.VisibleInDesignTime = true;
            // 
            // bv_InfoGeneral
            // 
            this.bv_InfoGeneral.Controls.Add(this.txtRazonSocial);
            this.bv_InfoGeneral.Controls.Add(this.txtDireccion);
            this.bv_InfoGeneral.Controls.Add(this.txtAnioLectivo);
            this.bv_InfoGeneral.Controls.Add(this.txtNbCentro);
            this.bv_InfoGeneral.Controls.Add(this.labelControl4);
            this.bv_InfoGeneral.Controls.Add(this.labelControl3);
            this.bv_InfoGeneral.Controls.Add(this.labelControl2);
            this.bv_InfoGeneral.Controls.Add(this.labelControl1);
            this.bv_InfoGeneral.Controls.Add(this.pictureEdit1);
            this.bv_InfoGeneral.Location = new System.Drawing.Point(225, 78);
            this.bv_InfoGeneral.Name = "bv_InfoGeneral";
            this.bv_InfoGeneral.Size = new System.Drawing.Size(1184, 412);
            this.bv_InfoGeneral.TabIndex = 3;
            this.bv_InfoGeneral.Load += new System.EventHandler(this.bv_InfoGeneral_Load);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Enabled = false;
            this.txtRazonSocial.Location = new System.Drawing.Point(185, 279);
            this.txtRazonSocial.MenuManager = this.ribbonControl1;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(271, 22);
            this.txtRazonSocial.TabIndex = 8;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(185, 329);
            this.txtDireccion.MenuManager = this.ribbonControl1;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(271, 22);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtAnioLectivo
            // 
            this.txtAnioLectivo.Enabled = false;
            this.txtAnioLectivo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtAnioLectivo.Location = new System.Drawing.Point(185, 379);
            this.txtAnioLectivo.MenuManager = this.ribbonControl1;
            this.txtAnioLectivo.Name = "txtAnioLectivo";
            this.txtAnioLectivo.Size = new System.Drawing.Size(77, 22);
            this.txtAnioLectivo.TabIndex = 6;
            // 
            // txtNbCentro
            // 
            this.txtNbCentro.Enabled = false;
            this.txtNbCentro.Location = new System.Drawing.Point(185, 231);
            this.txtNbCentro.MenuManager = this.ribbonControl1;
            this.txtNbCentro.Name = "txtNbCentro";
            this.txtNbCentro.Size = new System.Drawing.Size(271, 22);
            this.txtNbCentro.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(64, 385);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 16);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Año lectivo: ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(64, 285);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 16);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Razón social";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(64, 335);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Dirección: ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(64, 237);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(115, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Nombre del centro: ";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(64, 13);
            this.pictureEdit1.MenuManager = this.ribbonControl1;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(189, 177);
            this.pictureEdit1.TabIndex = 0;
            // 
            // bvInfoUsuario
            // 
            this.bvInfoUsuario.Controls.Add(this.txtBVInfo_Rol);
            this.bvInfoUsuario.Controls.Add(this.txtBVInfo_Correo);
            this.bvInfoUsuario.Controls.Add(this.txtBVInfo_Nombre);
            this.bvInfoUsuario.Controls.Add(this.txtBVInfo_Usuario);
            this.bvInfoUsuario.Controls.Add(this.label4);
            this.bvInfoUsuario.Controls.Add(this.label3);
            this.bvInfoUsuario.Controls.Add(this.label2);
            this.bvInfoUsuario.Controls.Add(this.Label1);
            this.bvInfoUsuario.Location = new System.Drawing.Point(225, 78);
            this.bvInfoUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bvInfoUsuario.Name = "bvInfoUsuario";
            this.bvInfoUsuario.Size = new System.Drawing.Size(1184, 412);
            this.bvInfoUsuario.TabIndex = 1;
            this.bvInfoUsuario.Load += new System.EventHandler(this.bvInfoUsuario_Load);
            // 
            // txtBVInfo_Rol
            // 
            this.txtBVInfo_Rol.Location = new System.Drawing.Point(358, 69);
            this.txtBVInfo_Rol.MenuManager = this.ribbonControl1;
            this.txtBVInfo_Rol.Name = "txtBVInfo_Rol";
            this.txtBVInfo_Rol.Size = new System.Drawing.Size(247, 22);
            this.txtBVInfo_Rol.TabIndex = 7;
            // 
            // txtBVInfo_Correo
            // 
            this.txtBVInfo_Correo.Location = new System.Drawing.Point(358, 19);
            this.txtBVInfo_Correo.MenuManager = this.ribbonControl1;
            this.txtBVInfo_Correo.Name = "txtBVInfo_Correo";
            this.txtBVInfo_Correo.Size = new System.Drawing.Size(247, 22);
            this.txtBVInfo_Correo.TabIndex = 6;
            // 
            // txtBVInfo_Nombre
            // 
            this.txtBVInfo_Nombre.Location = new System.Drawing.Point(83, 69);
            this.txtBVInfo_Nombre.MenuManager = this.ribbonControl1;
            this.txtBVInfo_Nombre.Name = "txtBVInfo_Nombre";
            this.txtBVInfo_Nombre.Size = new System.Drawing.Size(187, 22);
            this.txtBVInfo_Nombre.TabIndex = 5;
            // 
            // txtBVInfo_Usuario
            // 
            this.txtBVInfo_Usuario.Location = new System.Drawing.Point(83, 19);
            this.txtBVInfo_Usuario.MenuManager = this.ribbonControl1;
            this.txtBVInfo_Usuario.Name = "txtBVInfo_Usuario";
            this.txtBVInfo_Usuario.Size = new System.Drawing.Size(187, 22);
            this.txtBVInfo_Usuario.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(24, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(53, 17);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Usuario";
            // 
            // backstageViewClientControl2
            // 
            this.backstageViewClientControl2.Location = new System.Drawing.Point(225, 78);
            this.backstageViewClientControl2.Name = "backstageViewClientControl2";
            this.backstageViewClientControl2.Size = new System.Drawing.Size(1184, 412);
            this.backstageViewClientControl2.TabIndex = 2;
            // 
            // tabInfoGeneral
            // 
            this.tabInfoGeneral.Caption = "Información general";
            this.tabInfoGeneral.ContentControl = this.bv_InfoGeneral;
            this.tabInfoGeneral.Name = "tabInfoGeneral";
            this.tabInfoGeneral.Selected = true;
            this.tabInfoGeneral.SelectedChanged += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.tabInfoGeneral_SelectedChanged);
            // 
            // backstageViewTabItem1
            // 
            this.backstageViewTabItem1.Caption = "Cuenta";
            this.backstageViewTabItem1.ContentControl = this.bvInfoUsuario;
            this.backstageViewTabItem1.Name = "backstageViewTabItem1";
            this.backstageViewTabItem1.SelectedChanged += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.backstageViewTabItem1_SelectedChanged);
            // 
            // backstageViewTabItem2
            // 
            this.backstageViewTabItem2.Caption = "Cerrar sesión";
            this.backstageViewTabItem2.ContentControl = this.backstageViewClientControl2;
            this.backstageViewTabItem2.Name = "backstageViewTabItem2";
            this.backstageViewTabItem2.SelectedChanged += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.backstageViewTabItem2_SelectedChanged);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Estudiantes";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Matricula";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Estudiantes";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            this.ribbonPageGroup1.Text = "Inicio";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Gestión";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 716);
            this.Controls.Add(this.backstageViewControl1);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Form1.IconOptions.Icon")));
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Form1.IconOptions.Image")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Registro Académico CEPV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            this.backstageViewControl1.ResumeLayout(false);
            this.bv_InfoGeneral.ResumeLayout(false);
            this.bv_InfoGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazonSocial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnioLectivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNbCentro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.bvInfoUsuario.ResumeLayout(false);
            this.bvInfoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBVInfo_Rol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBVInfo_Correo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBVInfo_Nombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBVInfo_Usuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl bvInfoUsuario;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl2;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label1;
        private DevExpress.XtraEditors.TextEdit txtBVInfo_Rol;
        private DevExpress.XtraEditors.TextEdit txtBVInfo_Correo;
        private DevExpress.XtraEditors.TextEdit txtBVInfo_Nombre;
        private DevExpress.XtraEditors.TextEdit txtBVInfo_Usuario;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl bv_InfoGeneral;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem tabInfoGeneral;
        private DevExpress.XtraEditors.TextEdit txtRazonSocial;
        private DevExpress.XtraEditors.TextEdit txtDireccion;
        private DevExpress.XtraEditors.TextEdit txtAnioLectivo;
        private DevExpress.XtraEditors.TextEdit txtNbCentro;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}

