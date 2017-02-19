namespace WindowsFormsApplication1
{
    partial class Habitant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Habitant));
            this.label5 = new System.Windows.Forms.Label();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObservations = new System.Windows.Forms.TextBox();
            this.txtMotherLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnWaterIntake = new System.Windows.Forms.Button();
            this.pbval_txtName = new System.Windows.Forms.PictureBox();
            this.pbval_txtLastName = new System.Windows.Forms.PictureBox();
            this.pbVal_cmbMonth = new System.Windows.Forms.PictureBox();
            this.pbVal_cmbYear = new System.Windows.Forms.PictureBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pbval_txtTotal = new System.Windows.Forms.PictureBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pbSICAP = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSICAP)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Activo:";
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Checked = true;
            this.cbActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbActive.Location = new System.Drawing.Point(93, 283);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(15, 14);
            this.cbActive.TabIndex = 17;
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Observaciones:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Apellido materno:";
            // 
            // txtObservations
            // 
            this.txtObservations.Location = new System.Drawing.Point(93, 173);
            this.txtObservations.MaxLength = 2000;
            this.txtObservations.Multiline = true;
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservations.Size = new System.Drawing.Size(195, 104);
            this.txtObservations.TabIndex = 16;
            // 
            // txtMotherLastName
            // 
            this.txtMotherLastName.Location = new System.Drawing.Point(93, 60);
            this.txtMotherLastName.MaxLength = 50;
            this.txtMotherLastName.Name = "txtMotherLastName";
            this.txtMotherLastName.Size = new System.Drawing.Size(195, 20);
            this.txtMotherLastName.TabIndex = 14;
            this.txtMotherLastName.Tag = "txtText";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Apellido paterno:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(93, 35);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(195, 20);
            this.txtLastName.TabIndex = 13;
            this.txtLastName.Tag = "txtText";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 12);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 20);
            this.txtName.TabIndex = 12;
            this.txtName.Tag = "txtText";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre:";
            // 
            // btnAccept
            // 
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.Location = new System.Drawing.Point(132, 312);
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
            this.btnExit.Location = new System.Drawing.Point(213, 312);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "    Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnWaterIntake
            // 
            this.btnWaterIntake.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWaterIntake.Image = ((System.Drawing.Image)(resources.GetObject("btnWaterIntake.Image")));
            this.btnWaterIntake.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWaterIntake.Location = new System.Drawing.Point(51, 312);
            this.btnWaterIntake.Name = "btnWaterIntake";
            this.btnWaterIntake.Size = new System.Drawing.Size(75, 23);
            this.btnWaterIntake.TabIndex = 24;
            this.btnWaterIntake.Text = "    Tomas";
            this.btnWaterIntake.UseVisualStyleBackColor = true;
            this.btnWaterIntake.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbval_txtName
            // 
            this.pbval_txtName.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtName.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtName.Image")));
            this.pbval_txtName.InitialImage = null;
            this.pbval_txtName.Location = new System.Drawing.Point(294, 15);
            this.pbval_txtName.Name = "pbval_txtName";
            this.pbval_txtName.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtName.TabIndex = 25;
            this.pbval_txtName.TabStop = false;
            this.pbval_txtName.Tag = "Ingrese el nombre";
            this.pbval_txtName.Visible = false;
            // 
            // pbval_txtLastName
            // 
            this.pbval_txtLastName.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtLastName.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtLastName.Image")));
            this.pbval_txtLastName.InitialImage = null;
            this.pbval_txtLastName.Location = new System.Drawing.Point(294, 38);
            this.pbval_txtLastName.Name = "pbval_txtLastName";
            this.pbval_txtLastName.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtLastName.TabIndex = 26;
            this.pbval_txtLastName.TabStop = false;
            this.pbval_txtLastName.Tag = "Ingrese el apellido paterno";
            this.pbval_txtLastName.Visible = false;
            // 
            // pbVal_cmbMonth
            // 
            this.pbVal_cmbMonth.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbVal_cmbMonth.Image = ((System.Drawing.Image)(resources.GetObject("pbVal_cmbMonth.Image")));
            this.pbVal_cmbMonth.InitialImage = null;
            this.pbVal_cmbMonth.Location = new System.Drawing.Point(294, 141);
            this.pbVal_cmbMonth.Name = "pbVal_cmbMonth";
            this.pbVal_cmbMonth.Size = new System.Drawing.Size(18, 17);
            this.pbVal_cmbMonth.TabIndex = 106;
            this.pbVal_cmbMonth.TabStop = false;
            this.pbVal_cmbMonth.Tag = "Indique el mes";
            this.pbVal_cmbMonth.Visible = false;
            // 
            // pbVal_cmbYear
            // 
            this.pbVal_cmbYear.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbVal_cmbYear.Image = ((System.Drawing.Image)(resources.GetObject("pbVal_cmbYear.Image")));
            this.pbVal_cmbYear.InitialImage = null;
            this.pbVal_cmbYear.Location = new System.Drawing.Point(294, 118);
            this.pbVal_cmbYear.Name = "pbVal_cmbYear";
            this.pbVal_cmbYear.Size = new System.Drawing.Size(18, 17);
            this.pbVal_cmbYear.TabIndex = 105;
            this.pbVal_cmbYear.TabStop = false;
            this.pbVal_cmbYear.Tag = "Indique el año";
            this.pbVal_cmbYear.Visible = false;
            // 
            // cmbMonth
            // 
            this.cmbMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(93, 142);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(195, 21);
            this.cmbMonth.TabIndex = 102;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 104;
            this.label6.Text = "Mes:";
            // 
            // cmbYear
            // 
            this.cmbYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(93, 115);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(195, 21);
            this.cmbYear.TabIndex = 108;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 103;
            this.label7.Text = "Año:";
            // 
            // pbval_txtTotal
            // 
            this.pbval_txtTotal.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtTotal.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtTotal.Image")));
            this.pbval_txtTotal.InitialImage = null;
            this.pbval_txtTotal.Location = new System.Drawing.Point(295, 86);
            this.pbval_txtTotal.Name = "pbval_txtTotal";
            this.pbval_txtTotal.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtTotal.TabIndex = 109;
            this.pbval_txtTotal.TabStop = false;
            this.pbval_txtTotal.Tag = "Ingrese el total";
            this.pbval_txtTotal.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(94, 86);
            this.txtTotal.MaxLength = 10;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(194, 20);
            this.txtTotal.TabIndex = 107;
            this.txtTotal.Tag = "txtMoney";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 108;
            this.label8.Text = "Total:";
            // 
            // pbSICAP
            // 
            this.pbSICAP.Image = ((System.Drawing.Image)(resources.GetObject("pbSICAP.Image")));
            this.pbSICAP.Location = new System.Drawing.Point(7, 303);
            this.pbSICAP.Name = "pbSICAP";
            this.pbSICAP.Size = new System.Drawing.Size(25, 32);
            this.pbSICAP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSICAP.TabIndex = 110;
            this.pbSICAP.TabStop = false;
            this.pbSICAP.Tag = "Permite editar habitantes en el sistema";
            // 
            // Habitant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 339);
            this.Controls.Add(this.pbSICAP);
            this.Controls.Add(this.pbval_txtTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pbVal_cmbMonth);
            this.Controls.Add(this.pbVal_cmbYear);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbval_txtLastName);
            this.Controls.Add(this.pbval_txtName);
            this.Controls.Add(this.btnWaterIntake);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbActive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtObservations);
            this.Controls.Add(this.txtMotherLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Habitant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SICAP - Habitante";
            this.Load += new System.EventHandler(this.Habitant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSICAP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObservations;
        private System.Windows.Forms.TextBox txtMotherLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnWaterIntake;
        private System.Windows.Forms.PictureBox pbval_txtName;
        private System.Windows.Forms.PictureBox pbval_txtLastName;
        private System.Windows.Forms.PictureBox pbVal_cmbMonth;
        private System.Windows.Forms.PictureBox pbVal_cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbval_txtTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbSICAP;
    }
}