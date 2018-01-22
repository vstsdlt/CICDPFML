using System;
using System.Collections.Generic;
using FACTS.Framework.Web;
using FACTS.Framework.Lookup;
using FACTS.Framework.Support;
using PFML.Shared.LookupTable;
using PFML.Shared.Model.DbDtos;


namespace PFML.Web.Controllers.Premium.WageDetail.WageSubmission
{
    public class WageSubmissionController : Controller
    {

        public void MachineExecute()
        {
            Machine["ListSection"] = LookupUtil.GetValues(LookupTable.WizEmployerWageFiling, null, "{DisplaySortOrder}", null);
            Machine["CurrentSection"] = LookupUtil.GetLookupCode(LookupTable.WizEmployerWageFiling, LookupTable_WizEmployerWageFiling.SelectFilingMethod);

            Machine["ShowHeader"] = true;
            List<HtmlValueText> yearlist = new List<HtmlValueText>();
            int yearsToGoBack= Convert.ToInt16(LookupTable_WageDetailUnitYears.Yearsforwagefiling);
            PopulateYears(yearlist, yearsToGoBack, 0, false, true);
            Machine["ReportingYearList"] = yearlist;
            
        }


        /// <summary>
        /// Populates the dropdown list with all the years that come in the specified category or range.
        /// </summary>
        /// <param name="goBackYears">The number of years to go back from the current year.</param>
        /// <param name="goForwardYears">The number of years to go forward from the current year.</param>
        /// <param name="sortAscending">A boolean value if, true: sorts the list in ascending order; false: in descending order.</param>

        public static void PopulateYears(List<HtmlValueText> yearlist, int goBackYears, int goForwardYears, bool sortAscending, bool overwrite)
        {
            if ((overwrite) || (!overwrite && yearlist.Count <= 0))
            {
                // clean up the existing data in the list
                yearlist.Clear();
                if (sortAscending)
                {
                    for (int year = DateTime.Now.Year - goBackYears; year <= DateTime.Now.Year + goForwardYears; year++)
                    {
                        PopulateYears(yearlist, year);
                    }
                }
                else
                {
                    for (int year = DateTime.Now.Year + goForwardYears; year >= DateTime.Now.Year - goBackYears; year--)
                    {
                        PopulateYears(yearlist, year);
                    }
                }
            }
        }

        private static void PopulateYears(List<HtmlValueText> yearlist, int year)
        {
            HtmlValueText item = new HtmlValueText(year.ToString(), year.ToString());
            yearlist.Add(item);
        }

        public void DetailedSummaryExecute()
        {
            Machine["NumberofRecords"] = 10;
            Machine["TotalUIGrossWages"] = 155000;
           
        }
        public void DetailedSummaryEnd()
        {
           

        }
        public void ValidateManualEntrySubmissionEnd()
        {
           
        }

        public void DetailedSummaryNext()
        {
            
            Machine["CurrentSection"] = LookupUtil.GetLookupCode(LookupTable.WizEmployerWageFiling, LookupTable_WizEmployerWageFiling.ProcessandCalculate);

        }

        public void DetailedSummaryPrevious()
        {
          
            Machine["CurrentSection"] = LookupUtil.GetLookupCode(LookupTable.WizEmployerWageFiling, LookupTable_WizEmployerWageFiling.SubmitWageInformation);

        }

        public void ProcessAndCalculateTaxExecute()
        {
            Machine["UIContributionRate"] = 6.8;
            Machine["TaxableWageBase"] = 24100;
            Machine["TotalUIGrossWages"] = 155000;
            Machine["TotalExcessWages"] = 58600;
            Machine["TotalTaxableWages"] = 96400;
            Machine["UIContribution"] = 6169.60;
            Machine["QuaterlyAmountDue"] = 6169.60;
           
        }


        public void ProcessAndCalculateTaxSubmit()
        {
            Machine["CurrentSection"] = LookupUtil.GetLookupCode(LookupTable.WizEmployerWageFiling,string.Empty);


        }


        public void ProcessAndCalculateTaxPrevious()
        {
           
            Machine["CurrentSection"] = LookupUtil.GetLookupCode(LookupTable.WizEmployerWageFiling, LookupTable_WizEmployerWageFiling.ConfirmSubmission);

        }


        public void SelectFilingMethodNext()
        {
           
            Machine["CurrentSection"] = LookupUtil.GetLookupCode(LookupTable.WizEmployerWageFiling, LookupTable_WizEmployerWageFiling.SubmitWageInformation);

        }


        public void ManualEntryNext()
        {
           
            Machine["CurrentSection"] = LookupUtil.GetLookupCode(LookupTable.WizEmployerWageFiling, LookupTable_WizEmployerWageFiling.ConfirmSubmission);

        }

        public void ManualEntryPrevious()
        {
            
            Machine["CurrentSection"] = LookupUtil.GetLookupCode(LookupTable.WizEmployerWageFiling, LookupTable_WizEmployerWageFiling.SelectFilingMethod);

        }


    }
}
