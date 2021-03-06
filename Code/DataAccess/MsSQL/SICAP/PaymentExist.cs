namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Paymentexist.
	/// </summary>
	public partial class Paymentexist : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(int? idWaterIntake = null, int? year = null, int? month = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idWaterIntake", SqlDbType.Int, idWaterIntake, null).Add("@year", SqlDbType.Int, year, null).Add("@month", SqlDbType.Int, month, null);

        	return this.GetListBase<T>("SICAP", "PaymentExist",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(int? idWaterIntake = null, int? year = null, int? month = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idWaterIntake", SqlDbType.Int, idWaterIntake, null).Add("@year", SqlDbType.Int, year, null).Add("@month", SqlDbType.Int, month, null);

        	return this.ExecuteScalar<T>("SICAP", "PaymentExist",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(int? idWaterIntake = null, int? year = null, int? month = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idWaterIntake", SqlDbType.Int, idWaterIntake, null).Add("@year", SqlDbType.Int, year, null).Add("@month", SqlDbType.Int, month, null);

        	return this.ExecuteNonQuery("SICAP", "PaymentExist",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(int? idWaterIntake = null, int? year = null, int? month = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@idWaterIntake", SqlDbType.Int, idWaterIntake, null).Add("@year", SqlDbType.Int, year, null).Add("@month", SqlDbType.Int, month, null);

        	return this.GetReader("SICAP", "PaymentExist",parameters.ToArray());
        }

	#endregion
	}
}