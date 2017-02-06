using System;
using System.Collections.Generic;
using System.Linq;

namespace PosBusiness
{
    [Serializable]
    public class Config : EntityBase
    {
        #region Members

        private const string COST = "alta";

        private const string MENSUALIDAD = "mensualidad";

        private const string PRINTER = "printer";

        private const string TESORERO = "tesorero";

        private const string PRESIDENTE = "presidente";

        #endregion

        #region Properties

        public string Key { get; set; }

        public string Value { get; set; }

        #endregion

        #region Builder

        public Config()
        {
        }

        #endregion

        #region Methods

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public decimal Alta(string Value = "")
        {
            if (string.IsNullOrEmpty(Value))
            {

                var value = this.AccessMsSql.Sicap.Configget.ExeScalar<string>(COST);

                return decimal.Parse(value);
            }
            else
            {
                this.AccessMsSql.Sicap.Configset.ExeNonQuery(COST, Value);

                return 0;
            }
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public decimal Mensualidad(string Value = "")
        {
            if (string.IsNullOrEmpty(Value))
            {

                var value = this.AccessMsSql.Sicap.Configget.ExeScalar<string>(MENSUALIDAD);

                return decimal.Parse(value);
            }
            else
            {
                this.AccessMsSql.Sicap.Configset.ExeNonQuery(MENSUALIDAD, Value);

                return 0;
            }
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public string Printer(string Value = "")
        {
            if (string.IsNullOrEmpty(Value))
            {

                var value = this.AccessMsSql.Sicap.Configget.ExeScalar<string>(PRINTER);

                return value;
            }
            else
            {
                this.AccessMsSql.Sicap.Configset.ExeNonQuery(PRINTER, Value);

                return string.Empty;
            }
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public string Tesorero(string Value = "")
        {
            if (string.IsNullOrEmpty(Value))
            {

                var value = this.AccessMsSql.Sicap.Configget.ExeScalar<string>(TESORERO);

                return value;
            }
            else
            {
                this.AccessMsSql.Sicap.Configset.ExeNonQuery(TESORERO, Value);

                return string.Empty;
            }
        }

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public string Presidente(string Value = "")
        {
            if (string.IsNullOrEmpty(Value))
            {

                var value = this.AccessMsSql.Sicap.Configget.ExeScalar<string>(PRESIDENTE);

                return value;
            }
            else
            {
                this.AccessMsSql.Sicap.Configset.ExeNonQuery(PRESIDENTE, Value);

                return string.Empty;
            }
        }


        #endregion
    }
}
