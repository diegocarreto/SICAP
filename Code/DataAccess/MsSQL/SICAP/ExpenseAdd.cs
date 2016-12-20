namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Expenseadd.
	/// </summary>
	public partial class Expenseadd : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(String name = null, String description = null, Decimal? amount = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@name", SqlDbType.VarChar, name, 100).Add("@description", SqlDbType.VarChar, description, 2000).Add("@amount", SqlDbType.Money, amount, null);

        	return this.GetListBase<T>("SICAP", "ExpenseAdd",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(String name = null, String description = null, Decimal? amount = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@name", SqlDbType.VarChar, name, 100).Add("@description", SqlDbType.VarChar, description, 2000).Add("@amount", SqlDbType.Money, amount, null);

        	return this.ExecuteScalar<T>("SICAP", "ExpenseAdd",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(String name = null, String description = null, Decimal? amount = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@name", SqlDbType.VarChar, name, 100).Add("@description", SqlDbType.VarChar, description, 2000).Add("@amount", SqlDbType.Money, amount, null);

        	return this.ExecuteNonQuery("SICAP", "ExpenseAdd",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(String name = null, String description = null, Decimal? amount = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@name", SqlDbType.VarChar, name, 100).Add("@description", SqlDbType.VarChar, description, 2000).Add("@amount", SqlDbType.Money, amount, null);

        	return this.GetReader("SICAP", "ExpenseAdd",parameters.ToArray());
        }

	#endregion
	}
}