namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Userlist.
	/// </summary>
	public partial class Userlist : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(int? type = null, int? id = null, String find = null, int? Page = null, int? Rows = null, String sortName = null, String Order = null, int? IdUser = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@type", SqlDbType.Int, type, null).Add("@id", SqlDbType.Int, id, null).Add("@find", SqlDbType.VarChar, find, 100).Add("@Page", SqlDbType.Int, Page, null).Add("@Rows", SqlDbType.Int, Rows, null).Add("@sortName", SqlDbType.VarChar, sortName, 10).Add("@Order", SqlDbType.VarChar, Order, 4).Add("@IdUser", SqlDbType.Int, IdUser, null);

        	return this.GetListBase<T>("SICAP", "UserList",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(int? type = null, int? id = null, String find = null, int? Page = null, int? Rows = null, String sortName = null, String Order = null, int? IdUser = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@type", SqlDbType.Int, type, null).Add("@id", SqlDbType.Int, id, null).Add("@find", SqlDbType.VarChar, find, 100).Add("@Page", SqlDbType.Int, Page, null).Add("@Rows", SqlDbType.Int, Rows, null).Add("@sortName", SqlDbType.VarChar, sortName, 10).Add("@Order", SqlDbType.VarChar, Order, 4).Add("@IdUser", SqlDbType.Int, IdUser, null);

        	return this.ExecuteScalar<T>("SICAP", "UserList",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(int? type = null, int? id = null, String find = null, int? Page = null, int? Rows = null, String sortName = null, String Order = null, int? IdUser = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@type", SqlDbType.Int, type, null).Add("@id", SqlDbType.Int, id, null).Add("@find", SqlDbType.VarChar, find, 100).Add("@Page", SqlDbType.Int, Page, null).Add("@Rows", SqlDbType.Int, Rows, null).Add("@sortName", SqlDbType.VarChar, sortName, 10).Add("@Order", SqlDbType.VarChar, Order, 4).Add("@IdUser", SqlDbType.Int, IdUser, null);

        	return this.ExecuteNonQuery("SICAP", "UserList",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(int? type = null, int? id = null, String find = null, int? Page = null, int? Rows = null, String sortName = null, String Order = null, int? IdUser = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@type", SqlDbType.Int, type, null).Add("@id", SqlDbType.Int, id, null).Add("@find", SqlDbType.VarChar, find, 100).Add("@Page", SqlDbType.Int, Page, null).Add("@Rows", SqlDbType.Int, Rows, null).Add("@sortName", SqlDbType.VarChar, sortName, 10).Add("@Order", SqlDbType.VarChar, Order, 4).Add("@IdUser", SqlDbType.Int, IdUser, null);

        	return this.GetReader("SICAP", "UserList",parameters.ToArray());
        }

	#endregion
	}
}