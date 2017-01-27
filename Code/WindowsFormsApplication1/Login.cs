using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Base;
using UtilitiesForm.Extensions;
using Utilities;

namespace WindowsFormsApplication1
{
    public partial class Login : BaseForm
    {
        #region Memebers
        #endregion

        #region Properties
        #endregion

        #region Builder

        public Login()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private bool Cookie(int Id, string name)
        {
            var nameFile = System.AppDomain.CurrentDomain.BaseDirectory + "Cookie.dll";

            return TxtHandler.Write(nameFile, Id.ToString() + "|" + name);
        }

        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                using (var user = new PosBusiness.User
                {
                    Alias = this.txtUser.Text,
                    Password = this.txtPassword.Text
                })
                {
                    if (user.Login())
                    {
                        Sicap ms = new Sicap();

                        if (this.Cookie(user.UserId.Value, user.UserName))
                        {
                            ms.UserName = user.UserName;

                            ms.Show();

                            this.Hide();

                            this.txtUser.Clear();
                            this.txtPassword.Clear();

                            ms.Login = this;
                        }
                        else
                        {
                            this.Alert("Ocurrió un error al intentar guardar la cookie de sesión, contacte al administrador", eForm.TypeError.Exclamation);
                            this.txtUser.Focus();
                        }
                    }
                    else
                    {
                        this.Alert("El usuario o la contraseña son incorrectos", eForm.TypeError.Exclamation);

                        this.txtPassword.Clear();

                        this.txtUser.SelectAll();
                        this.txtUser.Focus();
                    }
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
