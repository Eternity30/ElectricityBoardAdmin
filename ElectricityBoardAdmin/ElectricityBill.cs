using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace ElectricityBoardAdmin
{
    public class ElectricityBill
    {
        String consumerNumber;
        String consumerName;
        int unitsConsumed;
        double billAmount;

        public ElectricityBill()
        {

        }
        public ElectricityBill(String cnum,string cname,int unco,double biam)
        {
            consumerNumber = cnum;
            consumerName = cname;
            unitsConsumed = unco;
            billAmount = biam;

        }
        public String ConsumerNumber
            {
            get
            {
                return consumerNumber;
            }
            set {
                
                
                consumerNumber = value;
                var match = Regex.Match(consumerNumber, @"^[E+B]{2}\d{5}");
              
                    if (!match.Success && consumerNumber != "")
                    {
                        throw new FormatException();
                    }
            }

            }
        public String ConsumerName
        {
            get
            {
                return consumerName;
            }
            set {
                consumerName = value;
            }

        }
        public int UnitsConsumed
        {
            get
            {
                return unitsConsumed;
            }
            set {
                unitsConsumed = value;
            }

        }
        public double BillAmount
        {
            get
            {
                return billAmount;
            }
            set {
                billAmount = value;
                }

        }

    }
}