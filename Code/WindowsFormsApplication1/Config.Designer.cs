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
            this.nudTomas = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pbPhoto2 = new System.Windows.Forms.PictureBox();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbAddNames = new System.Windows.Forms.CheckBox();
            this.txtPresidente = new MetroFramework.Controls.MetroTextBox();
            this.txtTesorero = new MetroFramework.Controls.MetroTextBox();
            this.txtMensualidad = new MetroFramework.Controls.MetroTextBox();
            this.txtAlta = new MetroFramework.Controls.MetroTextBox();
            this.txtAltaH = new MetroFramework.Controls.MetroTextBox();
            this.pbval_txtAltaH = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbval_txtPresidente = new System.Windows.Forms.PictureBox();
            this.pbval_txtTesorero = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbval_cmbPrinter = new System.Windows.Forms.PictureBox();
            this.cmbPrinter = new System.Windows.Forms.ComboBox();
            this.pbval_txtMensualidad = new System.Windows.Forms.PictureBox();
            this.pbval_txtAlta = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTomas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtAltaH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtPresidente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtTesorero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_cmbPrinter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtMensualidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtAlta)).BeginInit();
            this.SuspendLayout();
            // 
            // nudTomas
            // 
            this.nudTomas.Location = new System.Drawing.Point(116, 184);
            this.nudTomas.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudTomas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTomas.Name = "nudTomas";
            this.nudTomas.Size = new System.Drawing.Size(260, 20);
            this.nudTomas.TabIndex = 50;
            this.nudTomas.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Tomas por habitantes:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Imagen 2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Imagen 1:";
            // 
            // pbPhoto2
            // 
            this.pbPhoto2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPhoto2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPhoto2.Location = new System.Drawing.Point(292, 289);
            this.pbPhoto2.Name = "pbPhoto2";
            this.pbPhoto2.Size = new System.Drawing.Size(84, 87);
            this.pbPhoto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto2.TabIndex = 46;
            this.pbPhoto2.TabStop = false;
            this.pbPhoto2.Click += new System.EventHandler(this.pbPhoto2_Click);
            // 
            // pbPhoto
            // 
            this.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPhoto.Location = new System.Drawing.Point(116, 289);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(84, 87);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 45;
            this.pbPhoto.TabStop = false;
            this.pbPhoto.Click += new System.EventHandler(this.pbPhoto_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Incluir Nombres:";
            // 
            // cbAddNames
            // 
            this.cbAddNames.AutoSize = true;
            this.cbAddNames.Checked = true;
            this.cbAddNames.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAddNames.Location = new System.Drawing.Point(116, 211);
            this.cbAddNames.Name = "cbAddNames";
            this.cbAddNames.Size = new System.Drawing.Size(15, 14);
            this.cbAddNames.TabIndex = 5;
            this.cbAddNames.UseVisualStyleBackColor = true;
            this.cbAddNames.CheckedChanged += new System.EventHandler(this.cbActive_CheckedChanged);
            // 
            // txtPresidente
            // 
            // 
            // 
            // 
            this.txtPresidente.CustomButton.Image = null;
            this.txtPresidente.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.txtPresidente.CustomButton.Name = "";
            this.txtPresidente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPresidente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPresidente.CustomButton.TabIndex = 1;
            this.txtPresidente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPresidente.CustomButton.UseSelectable = true;
            this.txtPresidente.CustomButton.Visible = false;
            this.txtPresidente.DisplayIcon = true;
            this.txtPresidente.Icon = ((System.Drawing.Image)(resources.GetObject("txtPresidente.Icon")));
            this.txtPresidente.Lines = new string[0];
            this.txtPresidente.Location = new System.Drawing.Point(116, 260);
            this.txtPresidente.MaxLength = 32767;
            this.txtPresidente.Name = "txtPresidente";
            this.txtPresidente.PasswordChar = '\0';
            this.txtPresidente.PromptText = "Introduzca el nombre del presidente";
            this.txtPresidente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPresidente.SelectedText = "";
            this.txtPresidente.SelectionLength = 0;
            this.txtPresidente.SelectionStart = 0;
            this.txtPresidente.ShortcutsEnabled = true;
            this.txtPresidente.ShowClearButton = true;
            this.txtPresidente.Size = new System.Drawing.Size(260, 23);
            this.txtPresidente.TabIndex = 7;
            this.txtPresidente.UseSelectable = true;
            this.txtPresidente.WaterMark = "Introduzca el nombre del presidente";
            this.txtPresidente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPresidente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTesorero
            // 
            // 
            // 
            // 
            this.txtTesorero.CustomButton.Image = null;
            this.txtTesorero.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.txtTesorero.CustomButton.Name = "";
            this.txtTesorero.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTesorero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTesorero.CustomButton.TabIndex = 1;
            this.txtTesorero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTesorero.CustomButton.UseSelectable = true;
            this.txtTesorero.CustomButton.Visible = false;
            this.txtTesorero.DisplayIcon = true;
            this.txtTesorero.Icon = ((System.Drawing.Image)(resources.GetObject("txtTesorero.Icon")));
            this.txtTesorero.Lines = new string[0];
            this.txtTesorero.Location = new System.Drawing.Point(116, 231);
            this.txtTesorero.MaxLength = 32767;
            this.txtTesorero.Name = "txtTesorero";
            this.txtTesorero.PasswordChar = '\0';
            this.txtTesorero.PromptText = "Introduzca el nombre del tesorero";
            this.txtTesorero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTesorero.SelectedText = "";
            this.txtTesorero.SelectionLength = 0;
            this.txtTesorero.SelectionStart = 0;
            this.txtTesorero.ShortcutsEnabled = true;
            this.txtTesorero.ShowClearButton = true;
            this.txtTesorero.Size = new System.Drawing.Size(260, 23);
            this.txtTesorero.TabIndex = 6;
            this.txtTesorero.UseSelectable = true;
            this.txtTesorero.WaterMark = "Introduzca el nombre del tesorero";
            this.txtTesorero.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTesorero.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMensualidad
            // 
            // 
            // 
            // 
            this.txtMensualidad.CustomButton.Image = null;
            this.txtMensualidad.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.txtMensualidad.CustomButton.Name = "";
            this.txtMensualidad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMensualidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMensualidad.CustomButton.TabIndex = 1;
            this.txtMensualidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMensualidad.CustomButton.UseSelectable = true;
            this.txtMensualidad.CustomButton.Visible = false;
            this.txtMensualidad.DisplayIcon = true;
            this.txtMensualidad.Icon = ((System.Drawing.Image)(resources.GetObject("txtMensualidad.Icon")));
            this.txtMensualidad.Lines = new string[0];
            this.txtMensualidad.Location = new System.Drawing.Point(116, 128);
            this.txtMensualidad.MaxLength = 32767;
            this.txtMensualidad.Name = "txtMensualidad";
            this.txtMensualidad.PasswordChar = '\0';
            this.txtMensualidad.PromptText = "Introduzca el monto";
            this.txtMensualidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMensualidad.SelectedText = "";
            this.txtMensualidad.SelectionLength = 0;
            this.txtMensualidad.SelectionStart = 0;
            this.txtMensualidad.ShortcutsEnabled = true;
            this.txtMensualidad.ShowClearButton = true;
            this.txtMensualidad.Size = new System.Drawing.Size(260, 23);
            this.txtMensualidad.TabIndex = 2;
            this.txtMensualidad.Tag = "txtMoney";
            this.txtMensualidad.UseSelectable = true;
            this.txtMensualidad.WaterMark = "Introduzca el monto";
            this.txtMensualidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMensualidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAlta
            // 
            // 
            // 
            // 
            this.txtAlta.CustomButton.Image = null;
            this.txtAlta.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.txtAlta.CustomButton.Name = "";
            this.txtAlta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAlta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAlta.CustomButton.TabIndex = 1;
            this.txtAlta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAlta.CustomButton.UseSelectable = true;
            this.txtAlta.CustomButton.Visible = false;
            this.txtAlta.DisplayIcon = true;
            this.txtAlta.Icon = ((System.Drawing.Image)(resources.GetObject("txtAlta.Icon")));
            this.txtAlta.Lines = new string[0];
            this.txtAlta.Location = new System.Drawing.Point(116, 99);
            this.txtAlta.MaxLength = 32767;
            this.txtAlta.Name = "txtAlta";
            this.txtAlta.PasswordChar = '\0';
            this.txtAlta.PromptText = "Introduzca el monto";
            this.txtAlta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAlta.SelectedText = "";
            this.txtAlta.SelectionLength = 0;
            this.txtAlta.SelectionStart = 0;
            this.txtAlta.ShortcutsEnabled = true;
            this.txtAlta.ShowClearButton = true;
            this.txtAlta.Size = new System.Drawing.Size(260, 23);
            this.txtAlta.TabIndex = 1;
            this.txtAlta.Tag = "txtMoney";
            this.txtAlta.UseSelectable = true;
            this.txtAlta.WaterMark = "Introduzca el monto";
            this.txtAlta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAlta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAltaH
            // 
            // 
            // 
            // 
            this.txtAltaH.CustomButton.Image = null;
            this.txtAltaH.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.txtAltaH.CustomButton.Name = "";
            this.txtAltaH.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAltaH.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAltaH.CustomButton.TabIndex = 1;
            this.txtAltaH.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAltaH.CustomButton.UseSelectable = true;
            this.txtAltaH.CustomButton.Visible = false;
            this.txtAltaH.DisplayIcon = true;
            this.txtAltaH.Icon = ((System.Drawing.Image)(resources.GetObject("txtAltaH.Icon")));
            this.txtAltaH.Lines = new string[0];
            this.txtAltaH.Location = new System.Drawing.Point(116, 70);
            this.txtAltaH.MaxLength = 32767;
            this.txtAltaH.Name = "txtAltaH";
            this.txtAltaH.PasswordChar = '\0';
            this.txtAltaH.PromptText = "Introduzca el monto";
            this.txtAltaH.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAltaH.SelectedText = "";
            this.txtAltaH.SelectionLength = 0;
            this.txtAltaH.SelectionStart = 0;
            this.txtAltaH.ShortcutsEnabled = true;
            this.txtAltaH.ShowClearButton = true;
            this.txtAltaH.Size = new System.Drawing.Size(260, 23);
            this.txtAltaH.TabIndex = 0;
            this.txtAltaH.Tag = "txtMoney";
            this.txtAltaH.UseSelectable = true;
            this.txtAltaH.WaterMark = "Introduzca el monto";
            this.txtAltaH.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAltaH.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pbval_txtAltaH
            // 
            this.pbval_txtAltaH.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtAltaH.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtAltaH.Image")));
            this.pbval_txtAltaH.InitialImage = null;
            this.pbval_txtAltaH.Location = new System.Drawing.Point(382, 76);
            this.pbval_txtAltaH.Name = "pbval_txtAltaH";
            this.pbval_txtAltaH.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtAltaH.TabIndex = 39;
            this.pbval_txtAltaH.TabStop = false;
            this.pbval_txtAltaH.Tag = "Ingrese el monto del alta del habitante";
            this.pbval_txtAltaH.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Alta Habitante:";
            // 
            // pbval_txtPresidente
            // 
            this.pbval_txtPresidente.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtPresidente.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtPresidente.Image")));
            this.pbval_txtPresidente.InitialImage = null;
            this.pbval_txtPresidente.Location = new System.Drawing.Point(382, 266);
            this.pbval_txtPresidente.Name = "pbval_txtPresidente";
            this.pbval_txtPresidente.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtPresidente.TabIndex = 36;
            this.pbval_txtPresidente.TabStop = false;
            this.pbval_txtPresidente.Tag = "Ingrese el presidente";
            this.pbval_txtPresidente.Visible = false;
            // 
            // pbval_txtTesorero
            // 
            this.pbval_txtTesorero.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtTesorero.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtTesorero.Image")));
            this.pbval_txtTesorero.InitialImage = null;
            this.pbval_txtTesorero.Location = new System.Drawing.Point(382, 237);
            this.pbval_txtTesorero.Name = "pbval_txtTesorero";
            this.pbval_txtTesorero.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtTesorero.TabIndex = 35;
            this.pbval_txtTesorero.TabStop = false;
            this.pbval_txtTesorero.Tag = "Ingrese el tesorero";
            this.pbval_txtTesorero.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Presidente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tesorero:";
            // 
            // pbval_cmbPrinter
            // 
            this.pbval_cmbPrinter.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_cmbPrinter.Image = ((System.Drawing.Image)(resources.GetObject("pbval_cmbPrinter.Image")));
            this.pbval_cmbPrinter.InitialImage = null;
            this.pbval_cmbPrinter.Location = new System.Drawing.Point(382, 161);
            this.pbval_cmbPrinter.Name = "pbval_cmbPrinter";
            this.pbval_cmbPrinter.Size = new System.Drawing.Size(18, 17);
            this.pbval_cmbPrinter.TabIndex = 30;
            this.pbval_cmbPrinter.TabStop = false;
            this.pbval_cmbPrinter.Tag = "Indique la impresora";
            this.pbval_cmbPrinter.Visible = false;
            // 
            // cmbPrinter
            // 
            this.cmbPrinter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPrinter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrinter.FormattingEnabled = true;
            this.cmbPrinter.Location = new System.Drawing.Point(116, 157);
            this.cmbPrinter.Name = "cmbPrinter";
            this.cmbPrinter.Size = new System.Drawing.Size(260, 21);
            this.cmbPrinter.TabIndex = 3;
            // 
            // pbval_txtMensualidad
            // 
            this.pbval_txtMensualidad.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtMensualidad.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtMensualidad.Image")));
            this.pbval_txtMensualidad.InitialImage = null;
            this.pbval_txtMensualidad.Location = new System.Drawing.Point(382, 134);
            this.pbval_txtMensualidad.Name = "pbval_txtMensualidad";
            this.pbval_txtMensualidad.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtMensualidad.TabIndex = 26;
            this.pbval_txtMensualidad.TabStop = false;
            this.pbval_txtMensualidad.Tag = "Ingrese el monto de la mensualidad";
            this.pbval_txtMensualidad.Visible = false;
            // 
            // pbval_txtAlta
            // 
            this.pbval_txtAlta.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtAlta.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtAlta.Image")));
            this.pbval_txtAlta.InitialImage = null;
            this.pbval_txtAlta.Location = new System.Drawing.Point(382, 105);
            this.pbval_txtAlta.Name = "pbval_txtAlta";
            this.pbval_txtAlta.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtAlta.TabIndex = 25;
            this.pbval_txtAlta.TabStop = false;
            this.pbval_txtAlta.Tag = "Ingrese el monto del alta de la toma";
            this.pbval_txtAlta.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Impresora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mensualidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 105);
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
            this.btnAccept.Location = new System.Drawing.Point(220, 384);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "    Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(301, 384);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "    Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 419);
            this.Controls.Add(this.nudTomas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pbPhoto2);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbAddNames);
            this.Controls.Add(this.txtPresidente);
            this.Controls.Add(this.txtTesorero);
            this.Controls.Add(this.txtMensualidad);
            this.Controls.Add(this.txtAlta);
            this.Controls.Add(this.txtAltaH);
            this.Controls.Add(this.pbval_txtAltaH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbval_txtPresidente);
            this.Controls.Add(this.pbval_txtTesorero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbval_cmbPrinter);
            this.Controls.Add(this.cmbPrinter);
            this.Controls.Add(this.pbval_txtMensualidad);
            this.Controls.Add(this.pbval_txtAlta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Config";
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.Config_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTomas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtAltaH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtPresidente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtTesorero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_cmbPrinter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtMensualidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtAlta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbval_txtAlta;
        private System.Windows.Forms.PictureBox pbval_txtMensualidad;
        private System.Windows.Forms.ComboBox cmbPrinter;
        private System.Windows.Forms.PictureBox pbval_cmbPrinter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbval_txtTesorero;
        private System.Windows.Forms.PictureBox pbval_txtPresidente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbval_txtAltaH;
        private MetroFramework.Controls.MetroTextBox txtAltaH;
        private MetroFramework.Controls.MetroTextBox txtAlta;
        private MetroFramework.Controls.MetroTextBox txtMensualidad;
        private MetroFramework.Controls.MetroTextBox txtTesorero;
        private MetroFramework.Controls.MetroTextBox txtPresidente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbAddNames;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.PictureBox pbPhoto2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudTomas;
    }
}