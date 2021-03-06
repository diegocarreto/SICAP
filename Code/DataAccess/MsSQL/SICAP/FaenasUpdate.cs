namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Faenasupdate.
	/// </summary>
	public partial class Faenasupdate : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(int? idUser = null, int? id = null, String name = null, String description = null, Decimal? amount = null, int? month = null, int? year = null, Boolean? always = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@id", SqlDbType.Int, id, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@description", SqlDbType.VarChar, description, 2000).Add("@amount", SqlDbType.Money, amount, null).Add("@month", SqlDbType.TinyInt, month, null).Add("@year", SqlDbType.TinyInt, year, null).Add("@always", SqlDbType.Bit, always, null);

        	return this.GetListBase<T>("SICAP", "FaenasUpdate",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(int? idUser = null, int? id = null, String name = null, String description = null, Decimal? amount = null, int? month = null, int? year = null, Boolean? always = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@id", SqlDbType.Int, id, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@description", SqlDbType.VarChar, description, 2000).Add("@amount", SqlDbType.Money, amount, null).Add("@month", SqlDbType.TinyInt, month, null).Add("@year", SqlDbType.TinyInt, year, null).Add("@always", SqlDbType.Bit, always, null);

        	return this.ExecuteScalar<T>("SICAP", "FaenasUpdate",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(int? idUser = null, int? id = null, String name = null, String description = null, Decimal? amount = null, int? month = null, int? year = null, Boolean? always = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@id", SqlDbType.Int, id, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@description", SqlDbType.VarChar, description, 2000).Add("@amount", SqlDbType.Money, amount, null).Add("@month", SqlDbType.TinyInt, month, null).Add("@year", SqlDbType.TinyInt, year, null).Add("@always", SqlDbType.Bit, always, null);

        	return this.ExecuteNonQuery("SICAP", "FaenasUpdate",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(int? idUser = null, int? id = null, String name = null, String description = null, Decimal? amount = null, int? month = null, int? year = null, Boolean? always = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idUser", SqlDbType.Int, idUser, null).Add("@id", SqlDbType.Int, id, null).Add("@name", SqlDbType.VarChar, name, 100).Add("@description", SqlDbType.VarChar, description, 2000).Add("@amount", SqlDbType.Money, amount, null).Add("@month", SqlDbType.TinyInt, month, null).Add("@year", SqlDbType.TinyInt, year, null).Add("@always", SqlDbType.Bit, always, null);

        	return this.GetReader("SICAP", "FaenasUpdate",parameters.ToArray());
        }

	#endregion
	}
}