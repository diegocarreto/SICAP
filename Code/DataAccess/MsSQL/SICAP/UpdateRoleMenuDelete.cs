namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Updaterolemenudelete.
	/// </summary>
	public partial class Updaterolemenudelete : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(int? idRole = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idRole", SqlDbType.Int, idRole, null);

        	return this.GetListBase<T>("SICAP", "UpdateRoleMenuDelete",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(int? idRole = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idRole", SqlDbType.Int, idRole, null);

        	return this.ExecuteScalar<T>("SICAP", "UpdateRoleMenuDelete",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(int? idRole = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idRole", SqlDbType.Int, idRole, null);

        	return this.ExecuteNonQuery("SICAP", "UpdateRoleMenuDelete",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(int? idRole = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idRole", SqlDbType.Int, idRole, null);

        	return this.GetReader("SICAP", "UpdateRoleMenuDelete",parameters.ToArray());
        }

	#endregion
	}
}