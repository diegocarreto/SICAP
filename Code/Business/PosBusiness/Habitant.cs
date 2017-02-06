﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PosBusiness
{
    [Serializable]
    public class Habitant : EntityBase
    {
        #region Members
        #endregion

        #region Properties

        public string Nombre { get; set; }

        public string Paterno { get; set; }

        public string Materno { get; set; }

        public string observations { get; set; }

        public int? Year { get; set; }

        public int? Month { get; set; }

        public string MonthName { get; set; }

        #endregion

        #region Builder

        public Habitant()
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Get()
        {
            try
            {
                var e = this.List().First();

                this.Nombre = e.Nombre;
                this.Name = e.Name;
                this.Paterno = e.Paterno;
                this.Materno = e.Materno;
                this.observations = e.observations;
                this.Active = e.Active;
                this.Year = e.Year;
                this.Month = e.Month;

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
        public List<Habitant> List(int Type = 1)
        {
            return this.AccessMsSql.Sicap.Habitantlist.ExeList<Habitant>(Type, this.Id, this.Find);
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
                    this.AccessMsSql.Sicap.Habitantadd.ExeScalar<int>(this.UserId, this.Name, this.Paterno, this.Materno, this.observations, this.Year, this.Month, this.Active);
                }
                else
                {
                    this.Id = this.AccessMsSql.Sicap.Habitantupdate.ExeScalar<int>(this.UserId, this.Id, this.Name, this.Paterno, this.Materno, this.observations, this.Active, this.Year, this.Month);
                }

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
        public bool Delete()
        {
            try
            {
                this.AccessMsSql.Sicap.Habitantdelete.ExeNonQuery(this.UserId, this.Id);

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
