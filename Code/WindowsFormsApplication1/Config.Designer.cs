namespace WindowsFormsApplication1
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMensualidad = new System.Windows.Forms.TextBox();
            this.txtAlta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbval_txtAlta = new System.Windows.Forms.PictureBox();
            this.pbval_txtMensualidad = new System.Windows.Forms.PictureBox();
            this.cmbPrinter = new System.Windows.Forms.ComboBox();
            this.pbval_cmbPrinter = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTesorero = new System.Windows.Forms.TextBox();
            this.txtPresidente = new System.Windows.Forms.TextBox();
            this.pbval_txtTesorero = new System.Windows.Forms.PictureBox();
            this.pbval_txtPresidente = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAltaH = new System.Windows.Forms.TextBox();
            this.pbval_txtAltaH = new System.Windows.Forms.PictureBox();
            this.pbSICAP = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtAlta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtMensualidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_cmbPrinter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtTesorero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtPresidente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtAltaH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSICAP)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Impresora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mensualidad:";
            // 
            // txtMensualidad
            // 
            this.txtMensualidad.Location = new System.Drawing.Point(84, 59);
            this.txtMensualidad.MaxLength = 50;
            this.txtMensualidad.Name = "txtMensualidad";
            this.txtMensualidad.Size = new System.Drawing.Size(260, 20);
            this.txtMensualidad.TabIndex = 13;
            this.txtMensualidad.Tag = "txtMoney";
            // 
            // txtAlta
            // 
            this.txtAlta.Location = new System.Drawing.Point(84, 33);
            this.txtAlta.MaxLength = 100;
            this.txtAlta.Name = "txtAlta";
            this.txtAlta.Size = new System.Drawing.Size(260, 20);
            this.txtAlta.TabIndex = 12;
            this.txtAlta.Tag = "txtMoney";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Alta Toma:";
            // 
            // btnAccept
            // 
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.Location = new System.Drawing.Point(188, 175);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 19;
            this.btnAccept.Text = "    Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(269, 175);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "    Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbval_txtAlta
            // 
            this.pbval_txtAlta.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtAlta.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtAlta.Image")));
            this.pbval_txtAlta.InitialImage = null;
            this.pbval_txtAlta.Location = new System.Drawing.Point(350, 33);
            this.pbval_txtAlta.Name = "pbval_txtAlta";
            this.pbval_txtAlta.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtAlta.TabIndex = 25;
            this.pbval_txtAlta.TabStop = false;
            this.pbval_txtAlta.Tag = "Ingrese el alta de la toma";
            this.pbval_txtAlta.Visible = false;
            // 
            // pbval_txtMensualidad
            // 
            this.pbval_txtMensualidad.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtMensualidad.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtMensualidad.Image")));
            this.pbval_txtMensualidad.InitialImage = null;
            this.pbval_txtMensualidad.Location = new System.Drawing.Point(350, 59);
            this.pbval_txtMensualidad.Name = "pbval_txtMensualidad";
            this.pbval_txtMensualidad.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtMensualidad.TabIndex = 26;
            this.pbval_txtMensualidad.TabStop = false;
            this.pbval_txtMensualidad.Tag = "Ingrese la mensualidad";
            this.pbval_txtMensualidad.Visible = false;
            // 
            // cmbPrinter
            // 
            this.cmbPrinter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPrinter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrinter.FormattingEnabled = true;
            this.cmbPrinter.Location = new System.Drawing.Point(84, 139);
            this.cmbPrinter.Name = "cmbPrinter";
            this.cmbPrinter.Size = new System.Drawing.Size(260, 21);
            this.cmbPrinter.TabIndex = 14;
            // 
            // pbval_cmbPrinter
            // 
            this.pbval_cmbPrinter.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_cmbPrinter.Image = ((System.Drawing.Image)(resources.GetObject("pbval_cmbPrinter.Image")));
            this.pbval_cmbPrinter.InitialImage = null;
            this.pbval_cmbPrinter.Location = new System.Drawing.Point(350, 142);
            this.pbval_cmbPrinter.Name = "pbval_cmbPrinter";
            this.pbval_cmbPrinter.Size = new System.Drawing.Size(18, 17);
            this.pbval_cmbPrinter.TabIndex = 30;
            this.pbval_cmbPrinter.TabStop = false;
            this.pbval_cmbPrinter.Tag = "Indique la impresora";
            this.pbval_cmbPrinter.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tesorero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Presidente:";
            // 
            // txtTesorero
            // 
            this.txtTesorero.Location = new System.Drawing.Point(84, 85);
            this.txtTesorero.MaxLength = 50;
            this.txtTesorero.Name = "txtTesorero";
            this.txtTesorero.Size = new System.Drawing.Size(260, 20);
            this.txtTesorero.TabIndex = 33;
            this.txtTesorero.Tag = "";
            // 
            // txtPresidente
            // 
            this.txtPresidente.Location = new System.Drawing.Point(84, 113);
            this.txtPresidente.MaxLength = 50;
            this.txtPresidente.Name = "txtPresidente";
            this.txtPresidente.Size = new System.Drawing.Size(260, 20);
            this.txtPresidente.TabIndex = 34;
            this.txtPresidente.Tag = "";
            // 
            // pbval_txtTesorero
            // 
            this.pbval_txtTesorero.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtTesorero.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtTesorero.Image")));
            this.pbval_txtTesorero.InitialImage = null;
            this.pbval_txtTesorero.Location = new System.Drawing.Point(350, 85);
            this.pbval_txtTesorero.Name = "pbval_txtTesorero";
            this.pbval_txtTesorero.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtTesorero.TabIndex = 35;
            this.pbval_txtTesorero.TabStop = false;
            this.pbval_txtTesorero.Tag = "Ingrese el tesorero";
            this.pbval_txtTesorero.Visible = false;
            // 
            // pbval_txtPresidente
            // 
            this.pbval_txtPresidente.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtPresidente.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtPresidente.Image")));
            this.pbval_txtPresidente.InitialImage = null;
            this.pbval_txtPresidente.Location = new System.Drawing.Point(350, 112);
            this.pbval_txtPresidente.Name = "pbval_txtPresidente";
            this.pbval_txtPresidente.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtPresidente.TabIndex = 36;
            this.pbval_txtPresidente.TabStop = false;
            this.pbval_txtPresidente.Tag = "Ingrese el presidente";
            this.pbval_txtPresidente.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Alta Habitante:";
            // 
            // txtAltaH
            // 
            this.txtAltaH.Location = new System.Drawing.Point(84, 6);
            this.txtAltaH.MaxLength = 100;
            this.txtAltaH.Name = "txtAltaH";
            this.txtAltaH.Size = new System.Drawing.Size(260, 20);
            this.txtAltaH.TabIndex = 38;
            this.txtAltaH.Tag = "txtMoney";
            // 
            // pbval_txtAltaH
            // 
            this.pbval_txtAltaH.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtAltaH.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtAltaH.Image")));
            this.pbval_txtAltaH.InitialImage = null;
            this.pbval_txtAltaH.Location = new System.Drawing.Point(350, 6);
            this.pbval_txtAltaH.Name = "pbval_txtAltaH";
            this.pbval_txtAltaH.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtAltaH.TabIndex = 39;
            this.pbval_txtAltaH.TabStop = false;
            this.pbval_txtAltaH.Tag = "Ingrese el alta del habitante";
            this.pbval_txtAltaH.Visible = false;
            // 
            // pbSICAP
            // 
            this.pbSICAP.Image = ((System.Drawing.Image)(resources.GetObject("pbSICAP.Image")));
            this.pbSICAP.Location = new System.Drawing.Point(4, 166);
            this.pbSICAP.Name = "pbSICAP";
            this.pbSICAP.Size = new System.Drawing.Size(25, 32);
            this.pbSICAP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSICAP.TabIndex = 40;
            this.pbSICAP.TabStop = false;
            this.pbSICAP.Tag = "Permite configurar el sistema";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 206);
            this.Controls.Add(this.pbSICAP);
            this.Controls.Add(this.pbval_txtAltaH);
            this.Controls.Add(this.txtAltaH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbval_txtPresidente);
            this.Controls.Add(this.pbval_txtTesorero);
            this.Controls.Add(this.txtPresidente);
            this.Controls.Add(this.txtTesorero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbval_cmbPrinter);
            this.Controls.Add(this.cmbPrinter);
            this.Controls.Add(this.pbval_txtMensualidad);
            this.Controls.Add(this.pbval_txtAlta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMensualidad);
            this.Controls.Add(this.txtAlta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SICAP - Configuracion";
            this.Load += new System.EventHandler(this.Config_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtAlta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtMensualidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_cmbPrinter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtTesorero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtPresidente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtAltaH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSICAP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMensualidad;
        private System.Windows.Forms.TextBox txtAlta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbval_txtAlta;
        private System.Windows.Forms.PictureBox pbval_txtMensualidad;
        private System.Windows.Forms.ComboBox cmbPrinter;
        private System.Windows.Forms.PictureBox pbval_cmbPrinter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTesorero;
        private System.Windows.Forms.TextBox txtPresidente;
        private System.Windows.Forms.PictureBox pbval_txtTesorero;
        private System.Windows.Forms.PictureBox pbval_txtPresidente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAltaH;
        private System.Windows.Forms.PictureBox pbval_txtAltaH;
        private System.Windows.Forms.PictureBox pbSICAP;
    }
}