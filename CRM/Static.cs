using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    class Static
    {
        public static int price = 15;

        public static bool Validation(string pesel)
        {

            bool success = Int64.TryParse(pesel, out long number);
            if (success && number > 9999999999 && number < 100000000000)
            {
               return true;
            }
            else
            {
                return false;
            }
        }


    }

}
