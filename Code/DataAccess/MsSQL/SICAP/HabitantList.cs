namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Habitantlist.
	/// </summary>
	public partial class Habitantlist : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(int? type = null, int? id = null, String find = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@type", SqlDbType.Int, type, null).Add("@id", SqlDbType.Int, id, null).Add("@find", SqlDbType.VarChar, find, 100);

        	return this.GetListBase<T>("SICAP", "HabitantList",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(int? type = null, int? id = null, String find = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@type", SqlDbType.Int, type, null).Add("@id", SqlDbType.Int, id, null).Add("@find", SqlDbType.VarChar, find, 100);

        	return this.ExecuteScalar<T>("SICAP", "HabitantList",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(int? type = null, int? id = null, String find = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@type", SqlDbType.Int, type, null).Add("@id", SqlDbType.Int, id, null).Add("@find", SqlDbType.VarChar, find, 100);

        	return this.ExecuteNonQuery("SICAP", "HabitantList",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(int? type = null, int? id = null, String find = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@type", SqlDbType.Int, type, null).Add("@id", SqlDbType.Int, id, null).Add("@find", SqlDbType.VarChar, find, 100);

        	return this.GetReader("SICAP", "HabitantList",parameters.ToArray());
        }

	#endregion
	}
}