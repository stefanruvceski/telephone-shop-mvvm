using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ServerContracts
{
    public interface ITelephoneServerExtension : ITelephoneServer
    {
        bool CheckExisting();
    }
}
