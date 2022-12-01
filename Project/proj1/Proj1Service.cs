using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proj1
{
    public static class Proj1Service
    {
        //Take the user's string choice and returns 1 if Manager or returns 2 if Staff; otherwise -1.
        public static int ValidateUserChoice(string choice)
        {
            //check choice mathes either Manager or Staff
            if(choice.Equals("MANAGER", StringComparison.CurrentCultureIgnoreCase))
                {return 1; }
            else if(choice.Equals("STAFF", StringComparison.CurrentCultureIgnoreCase))
                 {return 2;}
            else  return -1;
        }
    }
}