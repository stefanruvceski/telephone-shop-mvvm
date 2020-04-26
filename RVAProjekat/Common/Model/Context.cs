using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class Context
    {
        #region Fields
        private Validation validation;
        #endregion

        #region Strategy Pattern/Constructor
        public Context(Validation validation)
        {
            this.validation = validation;
        }

        public bool ChackValidation()
        {
            return validation.Validate();
        }
        #endregion
    }
}
