namespace DXApplication4.Modulos.Estudiantes
{
    partial class Tutores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutores));
            this.gridTutor = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.comboParentesco = new DevExpress.XtraEditors.LookUpEdit();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridTutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboParentesco.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTutor
            // 
            this.gridTutor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridTutor.Location = new System.Drawing.Point(0, 47);
            this.gridTutor.MainView = this.gridView1;
            this.gridTutor.Name = "gridTutor";
            this.gridTutor.Size = new System.Drawing.Size(800, 403);
            this.gridTutor.TabIndex = 0;
            this.gridTutor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridTutor;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // labelControl32
            // 
            this.labelControl32.Location = new System.Drawing.Point(32, 17);
            this.labelControl32.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl32.Name = "labelControl32";
            this.labelControl32.Size = new System.Drawing.Size(63, 16);
            this.labelControl32.TabIndex = 57;
            this.labelControl32.Text = "Parentesco";
            // 
            // comboParentesco
            // 
            this.comboParentesco.Location = new System.Drawing.Point(105, 14);
            this.comboParentesco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboParentesco.Name = "comboParentesco";
            this.comboParentesco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboParentesco.Properties.DisplayMember = "TIPO";
            this.comboParentesco.Properties.NullText = "";
            this.comboParentesco.Properties.PopupSizeable = false;
            this.comboParentesco.Properties.ValueMember = "TIPO";
            this.comboParentesco.Size = new System.Drawing.Size(165, 22);
            this.comboParentesco.TabIndex = 56;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(676, 10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 29);
            this.btnCancelar.TabIndex = 58;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Tutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.labelControl32);
            this.Controls.Add(this.comboParentesco);
            this.Controls.Add(this.gridTutor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tutores";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutores";
            ((System.ComponentModel.ISupportInitialize)(this.gridTutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboParentesco.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridTutor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl32;
        private DevExpress.XtraEditors.LookUpEdit comboParentesco;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
    }
}