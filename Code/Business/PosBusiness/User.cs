using System;
using System.Collections.Generic;
using System.Linq;

namespace PosBusiness
{
    [Serializable]
    public class User : EntityBase
    {
        #region Members
        #endregion

        #region Properties

        public string Alias { get; set; }

        public string Password { get; set; }

        public bool? Menu_Opciones { get; set; }

        public bool? Menu_Habitantes { get; set; }

        public bool? Menu_Pagos { get; set; }

        public bool? Menu_IngresosEgresos { get; set; }

        public bool? Menu_Concentrado { get; set; }

        public bool? Menu_Cooperaciones { get; set; }

        public bool? Menu_PagosCooperaciones { get; set; }

        public bool? New { get; set; }

        public bool? Update { get; set; }

        public bool? Erase { get; set; }

        #endregion

        #region Builder

        public User()
        {
        }

        #endregion

        #region Methods

        public void Rol()
        {
            var e = this.AccessMsSql.Sicap.Rolget.ExeList<User>(this.UserId).First();

            this.Menu_Habitantes = e.Menu_Habitantes;
            this.Menu_Opciones = e.Menu_Opciones;
            this.Menu_Pagos = e.Menu_Pagos;
            this.Menu_IngresosEgresos = e.Menu_IngresosEgresos;
            this.Menu_Concentrado = e.Menu_Concentrado;
            this.Menu_Cooperaciones = e.Menu_Cooperaciones;
            this.Menu_PagosCooperaciones = e.Menu_PagosCooperaciones;
            this.Update = e.Update;
            this.New = e.New;
            this.Erase = e.Erase;
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public bool Login()
        {
            try
            {
                var lst = this.AccessMsSql.Sicap.Userlogin.ExeList<User>(this.Alias, this.Password);

                if (lst.Count > 0)
                {
                    var usr = lst.First();

                    if (usr != null)
                    {
                        this.UserId = usr.Id;
                        this.UserName = usr.Name;

                        return (usr.Alias.Equals(this.Alias) && usr.Password.Equals(this.Password));
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                this.SetError(ex);

                return false;
            }
        }

        #endregion
    }
}
