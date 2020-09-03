using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class OverflowError : UserError
    {
        public override string UEMessage()
        {
            return "The value exceeds system limits. This has filed an error!";
        }
    }
}
