using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target
{
     class Utilities
    {
       static public bool IsNotSetCorrect(String str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return true;
            }
            if (String.IsNullOrWhiteSpace(str))
            {
                return true;
            }
            return false;
        }
    }
}
