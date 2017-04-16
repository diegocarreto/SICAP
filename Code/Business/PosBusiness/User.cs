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

        public string RolName { get; set; }

        public string Password { get; set; }

        public bool? Menu_Opciones { get; set; }

        public bool? Menu_Habitantes { get; set; }

        public bool? Menu_Pagos { get; set; }

        public bool? Menu_IngresosEgresos { get; set; }

        public bool? Menu_Concentrado { get; set; }

        public bool? Menu_Cooperaciones { get; set; }

        public bool? Menu_PagosCooperaciones { get; set; }

        public bool? Menu_Calles { get; set; }

        public bool? New { get; set; }

        public bool? Update { get; set; }

        public bool? Erase { get; set; }

        public int? IdRol { get; set; }

        public bool? menu_Usuarios { get; set; }

        public bool? menu_Contrasena { get; set; }

        public bool? menu_UsuariosEdit { get; set; }

        #endregion

        #region Builder

        public User()
        {
        }

        #endregion

        #region Methods

        public bool Get()
        {
            try
            {
                var e = this.List(1).First();

                this.Name = e.Name;
                this.Alias = e.Alias;
                this.IdRol = e.IdRol;
                this.Password = e.Password;
                this.Id = e.Id;
                this.Active = e.Active;

                return true;
            }
            catch (Exception ex)
            {
                this.SetError(ex);

                return false;
            }
        }

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
            this.Menu_Calles = e.Menu_Calles;
            this.menu_Usuarios = e.menu_Usuarios;
            this.menu_Contrasena = e.menu_Contrasena;
            this.menu_UsuariosEdit = e.menu_UsuariosEdit;
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

        public bool ChangePassword(int Id, string Password)
        {
            try
            {
                this.AccessMsSql.Sicap.Changepassword.ExeNonQuery(Id, Password);

                return true;
            }
            catch (Exception ex)
            {
                this.SetError(ex);

                return false;
            }
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public List<User> List(int Type = 2)
        {
            return this.AccessMsSql.Sicap.Userlist.ExeList<User>(Type, this.Id, this.Find, this.Page, this.Rows, this.SortName, this.Order);
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public List<User> RolList(int Type = 2)
        {
            return this.AccessMsSql.Sicap.Rollist.ExeList<User>();
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public bool UpdateRoleMenuDelete(int IdRole)
        {
            try
            {
                this.AccessMsSql.Sicap.Updaterolemenudelete.ExeNonQuery(IdRole);

                return true;
            }
            catch (Exception ex)
            {
                this.SetError(ex);

                return false;
            }
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public bool UpdateRoleMenu(int IdRole, string Menu)
        {
            try
            {
                this.AccessMsSql.Sicap.Updaterolemenu.ExeNonQuery(IdRole, Menu);

                return true;
            }
            catch (Exception ex)
            {
                this.SetError(ex);

                return false;
            }
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public List<User> MenuList(int IdRole)
        {
            return this.AccessMsSql.Sicap.Menulist.ExeList<User>(IdRole);
        }


        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public bool Delete()
        {
            try
            {
                this.AccessMsSql.Sicap.Userdelete.ExeNonQuery(this.UserId, this.Id);

                return true;
            }
            catch (Exception ex)
            {
                this.SetError(ex);

                return false;
            }
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public bool DeleteRole()
        {
            try
            {
                this.AccessMsSql.Sicap.Roledelete.ExeNonQuery(this.UserId, this.IdRol);

                return true;
            }
            catch (Exception ex)
            {
                this.SetError(ex);

                return false;
            }
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public bool Save()
        {
            try
            {
                if (!this.Id.HasValue)
                {
                    this.Id = this.AccessMsSql.Sicap.Useradd.ExeScalar<int>(this.UserId, this.IdRol, this.Name, this.Alias, this.Password, this.Active);
                }
                else
                {
                    this.AccessMsSql.Sicap.Userupdate.ExeNonQuery(this.UserId, this.Id, this.IdRol, this.Name, this.Alias, this.Active);
                }

                return true;
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
