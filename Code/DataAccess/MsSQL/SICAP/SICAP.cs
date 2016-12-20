using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.MsSqlCommands;

namespace DataAccess.MSSQL.Sicap
{
	/// <summary>
	/// Controla la ejecucion de los procedimientos almacenados de la conexion Sicap.
	/// </summary>
	public class Sicap : IDisposable
	{
		#region Properties

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Binnacleadd.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Binnacleadd Binnacleadd = new DataAccess.MsSqlCommands.Sicap.Binnacleadd();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Cataloglist.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Cataloglist Cataloglist = new DataAccess.MsSqlCommands.Sicap.Cataloglist();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Configget.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Configget Configget = new DataAccess.MsSqlCommands.Sicap.Configget();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Configset.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Configset Configset = new DataAccess.MsSqlCommands.Sicap.Configset();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Expenseadd.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Expenseadd Expenseadd = new DataAccess.MsSqlCommands.Sicap.Expenseadd();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Expensedelete.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Expensedelete Expensedelete = new DataAccess.MsSqlCommands.Sicap.Expensedelete();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Habitantadd.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Habitantadd Habitantadd = new DataAccess.MsSqlCommands.Sicap.Habitantadd();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Habitantdelete.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Habitantdelete Habitantdelete = new DataAccess.MsSqlCommands.Sicap.Habitantdelete();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Habitantlist.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Habitantlist Habitantlist = new DataAccess.MsSqlCommands.Sicap.Habitantlist();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Habitantupdate.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Habitantupdate Habitantupdate = new DataAccess.MsSqlCommands.Sicap.Habitantupdate();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Paymentadd.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Paymentadd Paymentadd = new DataAccess.MsSqlCommands.Sicap.Paymentadd();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Paymentdelete.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Paymentdelete Paymentdelete = new DataAccess.MsSqlCommands.Sicap.Paymentdelete();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Paymentlist.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Paymentlist Paymentlist = new DataAccess.MsSqlCommands.Sicap.Paymentlist();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Paymentperyear.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Paymentperyear Paymentperyear = new DataAccess.MsSqlCommands.Sicap.Paymentperyear();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Paymenttotalbyperiod.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Paymenttotalbyperiod Paymenttotalbyperiod = new DataAccess.MsSqlCommands.Sicap.Paymenttotalbyperiod();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Paymentupdate.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Paymentupdate Paymentupdate = new DataAccess.MsSqlCommands.Sicap.Paymentupdate();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Rolget.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Rolget Rolget = new DataAccess.MsSqlCommands.Sicap.Rolget();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Userlogin.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Userlogin Userlogin = new DataAccess.MsSqlCommands.Sicap.Userlogin();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Waterintakeadd.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Waterintakeadd Waterintakeadd = new DataAccess.MsSqlCommands.Sicap.Waterintakeadd();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Waterintakedelete.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Waterintakedelete Waterintakedelete = new DataAccess.MsSqlCommands.Sicap.Waterintakedelete();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Waterintakelist.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Waterintakelist Waterintakelist = new DataAccess.MsSqlCommands.Sicap.Waterintakelist();

		/// <summary>
		/// Controla la ejecucion del procedimiento almacenado Waterintakeupdate.
		///</summary>
		public DataAccess.MsSqlCommands.Sicap.Waterintakeupdate Waterintakeupdate = new DataAccess.MsSqlCommands.Sicap.Waterintakeupdate();


		#endregion

		#region Methods

		public void Dispose()
		{
			if (this.Binnacleadd != null)
				this.Binnacleadd.Dispose();

			if (this.Cataloglist != null)
				this.Cataloglist.Dispose();

			if (this.Configget != null)
				this.Configget.Dispose();

			if (this.Configset != null)
				this.Configset.Dispose();

			if (this.Expenseadd != null)
				this.Expenseadd.Dispose();

			if (this.Expensedelete != null)
				this.Expensedelete.Dispose();

			if (this.Habitantadd != null)
				this.Habitantadd.Dispose();

			if (this.Habitantdelete != null)
				this.Habitantdelete.Dispose();

			if (this.Habitantlist != null)
				this.Habitantlist.Dispose();

			if (this.Habitantupdate != null)
				this.Habitantupdate.Dispose();

			if (this.Paymentadd != null)
				this.Paymentadd.Dispose();

			if (this.Paymentdelete != null)
				this.Paymentdelete.Dispose();

			if (this.Paymentlist != null)
				this.Paymentlist.Dispose();

			if (this.Paymentperyear != null)
				this.Paymentperyear.Dispose();

			if (this.Paymenttotalbyperiod != null)
				this.Paymenttotalbyperiod.Dispose();

			if (this.Paymentupdate != null)
				this.Paymentupdate.Dispose();

			if (this.Rolget != null)
				this.Rolget.Dispose();

			if (this.Userlogin != null)
				this.Userlogin.Dispose();

			if (this.Waterintakeadd != null)
				this.Waterintakeadd.Dispose();

			if (this.Waterintakedelete != null)
				this.Waterintakedelete.Dispose();

			if (this.Waterintakelist != null)
				this.Waterintakelist.Dispose();

			if (this.Waterintakeupdate != null)
				this.Waterintakeupdate.Dispose();


		}

		#endregion
	}
}