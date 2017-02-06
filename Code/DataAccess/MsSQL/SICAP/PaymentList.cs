namespace DataAccess.MsSqlCommands.Sicap
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using DataAccess.MSSQL;
	using DataAccess.Utilities;

	/// <summary>
	/// Controla la ejecucion del procedimientos almacenados Paymentlist.
	/// </summary>
	public partial class Paymentlist : AccessMsSQL
	{
        #region Methods

        /// <summary>
        /// Obtiene una lista del tipo de objectos indicado con el merge entre las propiedades del objeto y el resulset obtenido de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public List<T> ExeList<T>(String nameHabitant = null, int? idHabitant = null, int? idWaterIntake = null, int? month = null, int? year = null, int? monthEnd = null, int? yearEnd = null, DateTime? startDate = null, DateTime? finishDate = null) where T : new()
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@nameHabitant", SqlDbType.VarChar, nameHabitant, 200).Add("@idHabitant", SqlDbType.Int, idHabitant, null).Add("@idWaterIntake", SqlDbType.Int, idWaterIntake, null).Add("@month", SqlDbType.Int, month, null).Add("@year", SqlDbType.Int, year, null).Add("@monthEnd", SqlDbType.Int, monthEnd, null).Add("@yearEnd", SqlDbType.Int, yearEnd, null).Add("@startDate", SqlDbType.Date, startDate, null).Add("@finishDate", SqlDbType.Date, finishDate, null);

        	return this.GetListBase<T>("SICAP", "PaymentList",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene el scalar resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public T ExeScalar<T>(String nameHabitant = null, int? idHabitant = null, int? idWaterIntake = null, int? month = null, int? year = null, int? monthEnd = null, int? yearEnd = null, DateTime? startDate = null, DateTime? finishDate = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@nameHabitant", SqlDbType.VarChar, nameHabitant, 200).Add("@idHabitant", SqlDbType.Int, idHabitant, null).Add("@idWaterIntake", SqlDbType.Int, idWaterIntake, null).Add("@month", SqlDbType.Int, month, null).Add("@year", SqlDbType.Int, year, null).Add("@monthEnd", SqlDbType.Int, monthEnd, null).Add("@yearEnd", SqlDbType.Int, yearEnd, null).Add("@startDate", SqlDbType.Date, startDate, null).Add("@finishDate", SqlDbType.Date, finishDate, null);

        	return this.ExecuteScalar<T>("SICAP", "PaymentList",parameters.ToArray());
        }

        /// <summary>
        /// Ejecuta el procedimiento almacenado.
        /// </summary>
        /// <returns></returns>
        public int ExeNonQuery(String nameHabitant = null, int? idHabitant = null, int? idWaterIntake = null, int? month = null, int? year = null, int? monthEnd = null, int? yearEnd = null, DateTime? startDate = null, DateTime? finishDate = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@nameHabitant", SqlDbType.VarChar, nameHabitant, 200).Add("@idHabitant", SqlDbType.Int, idHabitant, null).Add("@idWaterIntake", SqlDbType.Int, idWaterIntake, null).Add("@month", SqlDbType.Int, month, null).Add("@year", SqlDbType.Int, year, null).Add("@monthEnd", SqlDbType.Int, monthEnd, null).Add("@yearEnd", SqlDbType.Int, yearEnd, null).Add("@startDate", SqlDbType.Date, startDate, null).Add("@finishDate", SqlDbType.Date, finishDate, null);

        	return this.ExecuteNonQuery("SICAP", "PaymentList",parameters.ToArray());
        }

        /// <summary>
        /// Obtiene un objeto IDataReader resultante de la ejecucion.
        /// </summary>
        /// <returns></returns>
        public IDataReader ExeReader(String nameHabitant = null, int? idHabitant = null, int? idWaterIntake = null, int? month = null, int? year = null, int? monthEnd = null, int? yearEnd = null, DateTime? startDate = null, DateTime? finishDate = null)
        {
        	List<SqlParameter> parameters = new List<SqlParameter>();

        	parameters.Add("@nameHabitant", SqlDbType.VarChar, nameHabitant, 200).Add("@idHabitant", SqlDbType.Int, idHabitant, null).Add("@idWaterIntake", SqlDbType.Int, idWaterIntake, null).Add("@month", SqlDbType.Int, month, null).Add("@year", SqlDbType.Int, year, null).Add("@monthEnd", SqlDbType.Int, monthEnd, null).Add("@yearEnd", SqlDbType.Int, yearEnd, null).Add("@startDate", SqlDbType.Date, startDate, null).Add("@finishDate", SqlDbType.Date, finishDate, null);

        	return this.GetReader("SICAP", "PaymentList",parameters.ToArray());
        }

	#endregion
	}
}