using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using static Common.Model.Enums;

namespace Common.Model
{
    [DataContract]
    public class User : Validation
    {
        #region Fields
        [DataMember]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DataMember]
        [Key]
        public String Username { get; set; }
        [DataMember]
        public String Password { get; set; }
        [DataMember]
        public String Name { get; set; }
        [DataMember]
        public String LastName { get; set; }
        [DataMember]
        public TYPE Type { get; set; }
        #endregion

        #region Constructor
        public User() { }
        public User(String userName, String password)
        {
            Username = userName;
            Password = password;
        }
        #endregion

        #region Strategy pattern
        public override bool Validate()
        {
            return !String.IsNullOrWhiteSpace(Username) && !String.IsNullOrWhiteSpace(Password) && !String.IsNullOrWhiteSpace(Name) && !String.IsNullOrWhiteSpace(LastName);
        }
        #endregion
    }
}
