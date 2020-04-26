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
    public abstract class Telephone: Validation //Prototype pattern
    {
        #region Fields
        public Telephone() { }

        [DataMember]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DataMember]
        public String ShopName{get;set;}

        [DataMember]
        public String UserName { get; set; }

        [DataMember]
        public String Name { get; set; }

        [DataMember]
        public double Price { get; set; }

        [DataMember]
        public double Diagonal { get; set; }

        [DataMember]
        public int Year { get; set; }

        [DataMember]
        public String Description { get; set; }

        [DataMember]
        public DateTime LastModified { get; set; }
        #endregion

        #region Constructor
        public abstract Telephone Clone();//For duplicate
        #endregion

        #region Strategy Pattern
        public override bool Validate()
        {
            return !String.IsNullOrWhiteSpace(Name);
        }
        #endregion
    }
}
