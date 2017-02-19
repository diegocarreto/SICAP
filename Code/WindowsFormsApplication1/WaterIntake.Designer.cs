namespace WindowsFormsApplication1
{
    partial class WaterIntake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaterIntake));
            this.pbval_txtExteriorNumber = new System.Windows.Forms.PictureBox();
            this.pbval_cmbStreet = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbStreet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColony = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInteriorNumber = new System.Windows.Forms.TextBox();
            this.txtExteriorNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.pbval_txtTotal = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbHabitant = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbPrincipal = new System.Windows.Forms.CheckBox();
            this.pbSICAP = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtExteriorNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_cmbStreet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSICAP)).BeginInit();
            this.SuspendLayout();
            // 
            // pbval_txtExteriorNumber
            // 
            this.pbval_txtExteriorNumber.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtExteriorNumber.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtExteriorNumber.Image")));
            this.pbval_txtExteriorNumber.InitialImage = null;
            this.pbval_txtExteriorNumber.Location = new System.Drawing.Point(144, 61);
            this.pbval_txtExteriorNumber.Name = "pbval_txtExteriorNumber";
            this.pbval_txtExteriorNumber.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtExteriorNumber.TabIndex = 28;
            this.pbval_txtExteriorNumber.TabStop = false;
            this.pbval_txtExteriorNumber.Tag = "Ingrese el numero exterior";
            this.pbval_txtExteriorNumber.Visible = false;
            // 
            // pbval_cmbStreet
            // 
            this.pbval_cmbStreet.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_cmbStreet.Image = ((System.Drawing.Image)(resources.GetObject("pbval_cmbStreet.Image")));
            this.pbval_cmbStreet.InitialImage = null;
            this.pbval_cmbStreet.Location = new System.Drawing.Point(301, 37);
            this.pbval_cmbStreet.Name = "pbval_cmbStreet";
            this.pbval_cmbStreet.Size = new System.Drawing.Size(18, 17);
            this.pbval_cmbStreet.TabIndex = 27;
            this.pbval_cmbStreet.TabStop = false;
            this.pbval_cmbStreet.Tag = "Indique la calle";
            this.pbval_cmbStreet.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Calle:";
            // 
            // cmbStreet
            // 
            this.cmbStreet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbStreet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStreet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStreet.FormattingEnabled = true;
            this.cmbStreet.Location = new System.Drawing.Point(63, 34);
            this.cmbStreet.Name = "cmbStreet";
            this.cmbStreet.Size = new System.Drawing.Size(232, 21);
            this.cmbStreet.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Activo:";
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Checked = true;
            this.cbActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbActive.Location = new System.Drawing.Point(63, 113);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(15, 14);
            this.cbActive.TabIndex = 20;
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Barrio:";
            // 
            // txtColony
            // 
            this.txtColony.Location = new System.Drawing.Point(63, 87);
            this.txtColony.MaxLength = 50;
            this.txtColony.Name = "txtColony";
            this.txtColony.Size = new System.Drawing.Size(232, 20);
            this.txtColony.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "# exterior:";
            // 
            // txtInteriorNumber
            // 
            this.txtInteriorNumber.Location = new System.Drawing.Point(220, 62);
            this.txtInteriorNumber.MaxLength = 10;
            this.txtInteriorNumber.Name = "txtInteriorNumber";
            this.txtInteriorNumber.Size = new System.Drawing.Size(75, 20);
            this.txtInteriorNumber.TabIndex = 17;
            // 
            // txtExteriorNumber
            // 
            this.txtExteriorNumber.Location = new System.Drawing.Point(63, 61);
            this.txtExteriorNumber.MaxLength = 10;
            this.txtExteriorNumber.Name = "txtExteriorNumber";
            this.txtExteriorNumber.Size = new System.Drawing.Size(75, 20);
            this.txtExteriorNumber.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "# interior:";
            // 
            // btnAccept
            // 
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.Location = new System.Drawing.Point(139, 152);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 22;
            this.btnAccept.Text = "    Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(220, 152);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "    Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(220, 110);
            this.txtTotal.MaxLength = 10;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(75, 20);
            this.txtTotal.TabIndex = 20;
            this.txtTotal.Tag = "txtMoney";
            // 
            // pbval_txtTotal
            // 
            this.pbval_txtTotal.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtTotal.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtTotal.Image")));
            this.pbval_txtTotal.InitialImage = null;
            this.pbval_txtTotal.Location = new System.Drawing.Point(301, 114);
            this.pbval_txtTotal.Name = "pbval_txtTotal";
            this.pbval_txtTotal.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtTotal.TabIndex = 31;
            this.pbval_txtTotal.TabStop = false;
            this.pbval_txtTotal.Tag = "Ingrese el total";
            this.pbval_txtTotal.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Inquilino:";
            // 
            // cmbHabitant
            // 
            this.cmbHabitant.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbHabitant.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbHabitant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHabitant.FormattingEnabled = true;
            this.cmbHabitant.Location = new System.Drawing.Point(63, 7);
            this.cmbHabitant.Name = "cmbHabitant";
            this.cmbHabitant.Size = new System.Drawing.Size(232, 21);
            this.cmbHabitant.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Principal:";
            // 
            // cbPrincipal
            // 
            this.cbPrincipal.AutoSize = true;
            this.cbPrincipal.Checked = true;
            this.cbPrincipal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPrincipal.Location = new System.Drawing.Point(144, 114);
            this.cbPrincipal.Name = "cbPrincipal";
            this.cbPrincipal.Size = new System.Drawing.Size(15, 14);
            this.cbPrincipal.TabIndex = 37;
            this.cbPrincipal.UseVisualStyleBackColor = true;
            // 
            // pbSICAP
            // 
            this.pbSICAP.Image = ((System.Drawing.Image)(resources.GetObject("pbSICAP.Image")));
            this.pbSICAP.Location = new System.Drawing.Point(11, 143);
            this.pbSICAP.Name = "pbSICAP";
            this.pbSICAP.Size = new System.Drawing.Size(25, 32);
            this.pbSICAP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSICAP.TabIndex = 111;
            this.pbSICAP.TabStop = false;
            this.pbSICAP.Tag = "Permite editar tomas de agua en el sistema";
            // 
            // WaterIntake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 179);
            this.Controls.Add(this.pbSICAP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbPrincipal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbHabitant);
            this.Controls.Add(this.pbval_txtTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbval_txtExteriorNumber);
            this.Controls.Add(this.pbval_cmbStreet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbStreet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbActive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtColony);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInteriorNumber);
            this.Controls.Add(this.txtExteriorNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WaterIntake";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SICAP - Toma de agua";
            this.Load += new System.EventHandler(this.WaterIntake_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtExteriorNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_cmbStreet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSICAP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbStreet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtColony;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInteriorNumber;
        private System.Windows.Forms.TextBox txtExteriorNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbval_cmbStreet;
        private System.Windows.Forms.PictureBox pbval_txtExteriorNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.PictureBox pbval_txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbHabitant;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbPrincipal;
        private System.Windows.Forms.PictureBox pbSICAP;
    }
}