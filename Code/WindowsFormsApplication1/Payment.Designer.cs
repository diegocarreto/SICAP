namespace WindowsFormsApplication1
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbWaterIntake = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbHabitant = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbval_cmbHabitant = new System.Windows.Forms.PictureBox();
            this.pbval_cmbWaterIntake = new System.Windows.Forms.PictureBox();
            this.pbVal_cmbYear = new System.Windows.Forms.PictureBox();
            this.pbVal_cmbMonth = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtObservations = new System.Windows.Forms.TextBox();
            this.pbVal_cmbMonthEnd = new System.Windows.Forms.PictureBox();
            this.pbVal_cmbYearEnd = new System.Windows.Forms.PictureBox();
            this.cmbMonthEnd = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbYearEnd = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_cmbHabitant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_cmbWaterIntake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbMonthEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbYearEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(356, 301);
            this.txtTotal.MaxLength = 10;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(92, 26);
            this.txtTotal.TabIndex = 31;
            // 
            // cmbMonth
            // 
            this.cmbMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(90, 98);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(360, 21);
            this.cmbMonth.TabIndex = 30;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mes Inicial:";
            // 
            // cmbYear
            // 
            this.cmbYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(90, 71);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(359, 21);
            this.cmbYear.TabIndex = 28;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Año Inicial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Toma de agua:";
            // 
            // cmbWaterIntake
            // 
            this.cmbWaterIntake.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbWaterIntake.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWaterIntake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWaterIntake.FormattingEnabled = true;
            this.cmbWaterIntake.Location = new System.Drawing.Point(90, 33);
            this.cmbWaterIntake.Name = "cmbWaterIntake";
            this.cmbWaterIntake.Size = new System.Drawing.Size(359, 21);
            this.cmbWaterIntake.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mensualidad:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(88, 301);
            this.txtAmount.MaxLength = 10;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(92, 26);
            this.txtAmount.TabIndex = 22;
            // 
            // btnAccept
            // 
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.Location = new System.Drawing.Point(260, 334);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(91, 23);
            this.btnAccept.TabIndex = 24;
            this.btnAccept.Text = "    Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(357, 334);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 23);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "    Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbHabitant
            // 
            this.cmbHabitant.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbHabitant.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbHabitant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHabitant.FormattingEnabled = true;
            this.cmbHabitant.Location = new System.Drawing.Point(91, 6);
            this.cmbHabitant.Name = "cmbHabitant";
            this.cmbHabitant.Size = new System.Drawing.Size(359, 21);
            this.cmbHabitant.TabIndex = 33;
            this.cmbHabitant.SelectedIndexChanged += new System.EventHandler(this.cmbHabitant_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Habitante:";
            // 
            // pbval_cmbHabitant
            // 
            this.pbval_cmbHabitant.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_cmbHabitant.Image = ((System.Drawing.Image)(resources.GetObject("pbval_cmbHabitant.Image")));
            this.pbval_cmbHabitant.InitialImage = null;
            this.pbval_cmbHabitant.Location = new System.Drawing.Point(456, 9);
            this.pbval_cmbHabitant.Name = "pbval_cmbHabitant";
            this.pbval_cmbHabitant.Size = new System.Drawing.Size(18, 17);
            this.pbval_cmbHabitant.TabIndex = 35;
            this.pbval_cmbHabitant.TabStop = false;
            this.pbval_cmbHabitant.Tag = "Indique el habitante";
            this.pbval_cmbHabitant.Visible = false;
            // 
            // pbval_cmbWaterIntake
            // 
            this.pbval_cmbWaterIntake.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_cmbWaterIntake.Image = ((System.Drawing.Image)(resources.GetObject("pbval_cmbWaterIntake.Image")));
            this.pbval_cmbWaterIntake.InitialImage = null;
            this.pbval_cmbWaterIntake.Location = new System.Drawing.Point(455, 36);
            this.pbval_cmbWaterIntake.Name = "pbval_cmbWaterIntake";
            this.pbval_cmbWaterIntake.Size = new System.Drawing.Size(18, 17);
            this.pbval_cmbWaterIntake.TabIndex = 36;
            this.pbval_cmbWaterIntake.TabStop = false;
            this.pbval_cmbWaterIntake.Tag = "Indique la toma de agua";
            this.pbval_cmbWaterIntake.Visible = false;
            // 
            // pbVal_cmbYear
            // 
            this.pbVal_cmbYear.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbVal_cmbYear.Image = ((System.Drawing.Image)(resources.GetObject("pbVal_cmbYear.Image")));
            this.pbVal_cmbYear.InitialImage = null;
            this.pbVal_cmbYear.Location = new System.Drawing.Point(455, 74);
            this.pbVal_cmbYear.Name = "pbVal_cmbYear";
            this.pbVal_cmbYear.Size = new System.Drawing.Size(18, 17);
            this.pbVal_cmbYear.TabIndex = 106;
            this.pbVal_cmbYear.TabStop = false;
            this.pbVal_cmbYear.Tag = "Indique el año inicial";
            this.pbVal_cmbYear.Visible = false;
            // 
            // pbVal_cmbMonth
            // 
            this.pbVal_cmbMonth.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbVal_cmbMonth.Image = ((System.Drawing.Image)(resources.GetObject("pbVal_cmbMonth.Image")));
            this.pbVal_cmbMonth.InitialImage = null;
            this.pbVal_cmbMonth.Location = new System.Drawing.Point(455, 101);
            this.pbVal_cmbMonth.Name = "pbVal_cmbMonth";
            this.pbVal_cmbMonth.Size = new System.Drawing.Size(18, 17);
            this.pbVal_cmbMonth.TabIndex = 107;
            this.pbVal_cmbMonth.TabStop = false;
            this.pbVal_cmbMonth.Tag = "Indique el mes inicial";
            this.pbVal_cmbMonth.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 109;
            this.label7.Text = "Observaciones:";
            // 
            // txtObservations
            // 
            this.txtObservations.Location = new System.Drawing.Point(90, 191);
            this.txtObservations.MaxLength = 2000;
            this.txtObservations.Multiline = true;
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservations.Size = new System.Drawing.Size(358, 104);
            this.txtObservations.TabIndex = 108;
            // 
            // pbVal_cmbMonthEnd
            // 
            this.pbVal_cmbMonthEnd.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbVal_cmbMonthEnd.Image = ((System.Drawing.Image)(resources.GetObject("pbVal_cmbMonthEnd.Image")));
            this.pbVal_cmbMonthEnd.InitialImage = null;
            this.pbVal_cmbMonthEnd.Location = new System.Drawing.Point(456, 155);
            this.pbVal_cmbMonthEnd.Name = "pbVal_cmbMonthEnd";
            this.pbVal_cmbMonthEnd.Size = new System.Drawing.Size(18, 17);
            this.pbVal_cmbMonthEnd.TabIndex = 115;
            this.pbVal_cmbMonthEnd.TabStop = false;
            this.pbVal_cmbMonthEnd.Tag = "Indique el mes final";
            this.pbVal_cmbMonthEnd.Visible = false;
            // 
            // pbVal_cmbYearEnd
            // 
            this.pbVal_cmbYearEnd.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbVal_cmbYearEnd.Image = ((System.Drawing.Image)(resources.GetObject("pbVal_cmbYearEnd.Image")));
            this.pbVal_cmbYearEnd.InitialImage = null;
            this.pbVal_cmbYearEnd.Location = new System.Drawing.Point(456, 128);
            this.pbVal_cmbYearEnd.Name = "pbVal_cmbYearEnd";
            this.pbVal_cmbYearEnd.Size = new System.Drawing.Size(18, 17);
            this.pbVal_cmbYearEnd.TabIndex = 114;
            this.pbVal_cmbYearEnd.TabStop = false;
            this.pbVal_cmbYearEnd.Tag = "Indique el año final";
            this.pbVal_cmbYearEnd.Visible = false;
            // 
            // cmbMonthEnd
            // 
            this.cmbMonthEnd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMonthEnd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMonthEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonthEnd.FormattingEnabled = true;
            this.cmbMonthEnd.Location = new System.Drawing.Point(91, 152);
            this.cmbMonthEnd.Name = "cmbMonthEnd";
            this.cmbMonthEnd.Size = new System.Drawing.Size(360, 21);
            this.cmbMonthEnd.TabIndex = 113;
            this.cmbMonthEnd.SelectedIndexChanged += new System.EventHandler(this.cmbMonthEnd_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 112;
            this.label8.Text = "Mes Final:";
            // 
            // cmbYearEnd
            // 
            this.cmbYearEnd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbYearEnd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbYearEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYearEnd.FormattingEnabled = true;
            this.cmbYearEnd.Location = new System.Drawing.Point(91, 125);
            this.cmbYearEnd.Name = "cmbYearEnd";
            this.cmbYearEnd.Size = new System.Drawing.Size(359, 21);
            this.cmbYearEnd.TabIndex = 111;
            this.cmbYearEnd.SelectedIndexChanged += new System.EventHandler(this.cmbYearEnd_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 110;
            this.label9.Text = "Año Final:";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 363);
            this.Controls.Add(this.pbVal_cmbMonthEnd);
            this.Controls.Add(this.pbVal_cmbYearEnd);
            this.Controls.Add(this.cmbMonthEnd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbYearEnd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtObservations);
            this.Controls.Add(this.pbVal_cmbMonth);
            this.Controls.Add(this.pbVal_cmbYear);
            this.Controls.Add(this.pbval_cmbWaterIntake);
            this.Controls.Add(this.pbval_cmbHabitant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbHabitant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbWaterIntake);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbval_cmbHabitant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_cmbWaterIntake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbMonthEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVal_cmbYearEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbWaterIntake;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbHabitant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbval_cmbHabitant;
        private System.Windows.Forms.PictureBox pbval_cmbWaterIntake;
        private System.Windows.Forms.PictureBox pbVal_cmbYear;
        private System.Windows.Forms.PictureBox pbVal_cmbMonth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtObservations;
        private System.Windows.Forms.PictureBox pbVal_cmbMonthEnd;
        private System.Windows.Forms.PictureBox pbVal_cmbYearEnd;
        private System.Windows.Forms.ComboBox cmbMonthEnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbYearEnd;
        private System.Windows.Forms.Label label9;
    }
}