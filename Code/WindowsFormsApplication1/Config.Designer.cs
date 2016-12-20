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
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtAlta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtMensualidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_cmbPrinter)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Impresora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mensualidad:";
            // 
            // txtMensualidad
            // 
            this.txtMensualidad.Location = new System.Drawing.Point(75, 38);
            this.txtMensualidad.MaxLength = 50;
            this.txtMensualidad.Name = "txtMensualidad";
            this.txtMensualidad.Size = new System.Drawing.Size(195, 20);
            this.txtMensualidad.TabIndex = 13;
            this.txtMensualidad.Tag = "txtMoney";
            // 
            // txtAlta
            // 
            this.txtAlta.Location = new System.Drawing.Point(75, 12);
            this.txtAlta.MaxLength = 100;
            this.txtAlta.Name = "txtAlta";
            this.txtAlta.Size = new System.Drawing.Size(195, 20);
            this.txtAlta.TabIndex = 12;
            this.txtAlta.Tag = "txtMoney";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Alta:";
            // 
            // btnAccept
            // 
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.Location = new System.Drawing.Point(114, 91);
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
            this.btnExit.Location = new System.Drawing.Point(195, 91);
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
            this.pbval_txtAlta.Location = new System.Drawing.Point(276, 15);
            this.pbval_txtAlta.Name = "pbval_txtAlta";
            this.pbval_txtAlta.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtAlta.TabIndex = 25;
            this.pbval_txtAlta.TabStop = false;
            this.pbval_txtAlta.Tag = "Ingrese el alta";
            this.pbval_txtAlta.Visible = false;
            // 
            // pbval_txtMensualidad
            // 
            this.pbval_txtMensualidad.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtMensualidad.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtMensualidad.Image")));
            this.pbval_txtMensualidad.InitialImage = null;
            this.pbval_txtMensualidad.Location = new System.Drawing.Point(276, 41);
            this.pbval_txtMensualidad.Name = "pbval_txtMensualidad";
            this.pbval_txtMensualidad.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtMensualidad.TabIndex = 26;
            this.pbval_txtMensualidad.TabStop = false;
            this.pbval_txtMensualidad.Tag = "Ingrese la mensualidad";
            this.pbval_txtMensualidad.Visible = false;
            // 
            // cmbPrinter
            // 
            this.cmbPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrinter.FormattingEnabled = true;
            this.cmbPrinter.Location = new System.Drawing.Point(75, 64);
            this.cmbPrinter.Name = "cmbPrinter";
            this.cmbPrinter.Size = new System.Drawing.Size(195, 21);
            this.cmbPrinter.TabIndex = 14;
            // 
            // pbval_cmbPrinter
            // 
            this.pbval_cmbPrinter.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_cmbPrinter.Image = ((System.Drawing.Image)(resources.GetObject("pbval_cmbPrinter.Image")));
            this.pbval_cmbPrinter.InitialImage = null;
            this.pbval_cmbPrinter.Location = new System.Drawing.Point(276, 68);
            this.pbval_cmbPrinter.Name = "pbval_cmbPrinter";
            this.pbval_cmbPrinter.Size = new System.Drawing.Size(18, 17);
            this.pbval_cmbPrinter.TabIndex = 30;
            this.pbval_cmbPrinter.TabStop = false;
            this.pbval_cmbPrinter.Tag = "Indique la impresora";
            this.pbval_cmbPrinter.Visible = false;
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 118);
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
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.Config_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtAlta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtMensualidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_cmbPrinter)).EndInit();
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
    }
}