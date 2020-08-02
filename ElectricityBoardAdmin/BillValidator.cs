using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectricityBoardAdmin
{
    public class BillValidator
    {
        //Validation for the Units Consumed
        public String ValidateUnitsConsumed(int UnitsConsumed)
        {
            if(UnitsConsumed<0)
            {
                return "Given Units Is Invalid";
            }

            return "";
        }




    }
}