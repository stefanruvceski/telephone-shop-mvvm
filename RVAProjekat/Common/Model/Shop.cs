using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    [DataContract]
    public class Shop : Validation
    {
        #region Fields
        [DataMember]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [DataMember]
        public String Name { get; set; }

        [DataMember]
        public String Address { get; set; }

        [DataMember]
        public String PhoneNumber { get; set; }
        #endregion

        #region Constructor
        public Shop() { }
        #endregion

        #region Strategy Pattern
        public override bool Validate()
        {
            return !String.IsNullOrWhiteSpace(Name);
        }
        #endregion
    }
}
