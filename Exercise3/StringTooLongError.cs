using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class StringTooLongError : UserError
    {
        public override string UEMessage()
        {
            return "The string has too many characters. This has filed an error!";
        }
    }
}
