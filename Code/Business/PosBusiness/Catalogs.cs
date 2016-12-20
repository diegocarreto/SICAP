using System;
using System.Collections.Generic;
using System.Linq;

namespace PosBusiness
{
    [Serializable]
    public class Catalogs : EntityBase
    {
        #region Members
        #endregion

        #region Properties
        #endregion

        #region Builder

        public Catalogs()
        {
        }

        #endregion

        #region Methods

        // <summary>
        // 
        // </summary>
        // <returns></returns>
        public List<Catalogs> List(string Type)
        {
            return this.AccessMsSql.Sicap.Cataloglist.ExeList<Catalogs>(Type);
        }

        #endregion
    }
}
