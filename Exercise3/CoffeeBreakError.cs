using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class CoffeeBreakError : UserError
    {
        public override string UEMessage()
        {
            return "Someone has sold the coffee machine. That means we have to make due with tea!";
        }
    }
}
