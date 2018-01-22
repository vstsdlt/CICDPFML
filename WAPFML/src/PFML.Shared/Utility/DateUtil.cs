using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFML.Shared.Utility
{
    public static class DateUtil
    {
        /// <summary>Returns the quarter of the year based on the month. Three months constitute a quarter.</summary>
        /// <param name="month">The month of an year.</param>
        /// <returns>The quarter of the month. If the month is an invalid month it returns 0.</returns>
        public static string GetQuarter(int month)
        {
            string quarter="";

            if (month >= (int)Constants.Months.January && month <= (int)Constants.Months.March)
            {
                quarter = LookupTable.LookupTable_Quarter.JanuaryFebruaryMarchQ1;
            }
            else if (month >= (int)Constants.Months.April && month <= (int)Constants.Months.June)
            {
                quarter = LookupTable.LookupTable_Quarter.AprilMayJuneQ2;
            }
            else if (month >= (int)Constants.Months.July && month <= (int)Constants.Months.September)
            {
                quarter = LookupTable.LookupTable_Quarter.JulyAugustSeptemberQ3;
            }
            else if (month >= (int)Constants.Months.October && month <= (int)Constants.Months.December)
            {
                quarter = LookupTable.LookupTable_Quarter.OctoberNovemberDecemberQ4;
            }
            return quarter;
        }

    }
}
