namespace WindowsFormsApplication1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbSICAP = new System.Windows.Forms.PictureBox();
            this.pbval_txtPassword = new System.Windows.Forms.PictureBox();
            this.pbval_txtUser = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSICAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.Location = new System.Drawing.Point(75, 69);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 9;
            this.btnAccept.Text = "    Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(156, 69);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "    Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbSICAP
            // 
            this.pbSICAP.Image = ((System.Drawing.Image)(resources.GetObject("pbSICAP.Image")));
            this.pbSICAP.Location = new System.Drawing.Point(8, 60);
            this.pbSICAP.Name = "pbSICAP";
            this.pbSICAP.Size = new System.Drawing.Size(25, 32);
            this.pbSICAP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSICAP.TabIndex = 23;
            this.pbSICAP.TabStop = false;
            this.pbSICAP.Tag = "Permite ingresar al sistema con un usuario y contraseñas correctas";
            // 
            // pbval_txtPassword
            // 
            this.pbval_txtPassword.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtPassword.Image")));
            this.pbval_txtPassword.InitialImage = null;
            this.pbval_txtPassword.Location = new System.Drawing.Point(237, 37);
            this.pbval_txtPassword.Name = "pbval_txtPassword";
            this.pbval_txtPassword.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtPassword.TabIndex = 13;
            this.pbval_txtPassword.TabStop = false;
            this.pbval_txtPassword.Tag = "Ingrese la contraseña";
            this.pbval_txtPassword.Visible = false;
            // 
            // pbval_txtUser
            // 
            this.pbval_txtUser.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbval_txtUser.Image = ((System.Drawing.Image)(resources.GetObject("pbval_txtUser.Image")));
            this.pbval_txtUser.InitialImage = null;
            this.pbval_txtUser.Location = new System.Drawing.Point(237, 12);
            this.pbval_txtUser.Name = "pbval_txtUser";
            this.pbval_txtUser.Size = new System.Drawing.Size(18, 17);
            this.pbval_txtUser.TabIndex = 12;
            this.pbval_txtUser.TabStop = false;
            this.pbval_txtUser.Tag = "Ingrese el usuario";
            this.pbval_txtUser.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(75, 34);
            this.txtPassword.MaxLength = 12;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(156, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Tag = "";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(75, 12);
            this.txtUser.MaxLength = 20;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(156, 20);
            this.txtUser.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuario:";
            // 
            // Login
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(258, 96);
            this.Controls.Add(this.pbSICAP);
            this.Controls.Add(this.pbval_txtPassword);
            this.Controls.Add(this.pbval_txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SICAP - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSICAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbval_txtUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbval_txtUser;
        private System.Windows.Forms.PictureBox pbval_txtPassword;
        private System.Windows.Forms.PictureBox pbSICAP;
    }
}