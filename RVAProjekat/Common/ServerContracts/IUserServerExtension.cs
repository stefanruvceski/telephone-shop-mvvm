using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ServerContracts
{
    public interface IUserServerExtension : IUserServer
    {
        bool CheckExisting();
    }
}
