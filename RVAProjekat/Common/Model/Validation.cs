using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    [DataContract]
    //Strategy
    public abstract class Validation
    {
        public abstract bool Validate();
    }
}
