using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    [DataContract]
    public class ShopTelephone : Telephone
    {
        #region Prototype Pattern
        public override Telephone Clone()
        {
            return (ShopTelephone)this.MemberwiseClone();
        }
        #endregion

        #region Constructor
        public ShopTelephone() { }
        #endregion
    }
}
