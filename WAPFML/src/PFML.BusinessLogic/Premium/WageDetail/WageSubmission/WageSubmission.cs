using System;
using System.Collections.Generic;
using System.Linq;
using FACTS.Framework.DAL;
using FACTS.Framework.Service;
using PFML.DAL.Model.DbEntities;
using PFML.Shared.Model.DbDtos;
using DbContext = PFML.DAL.Model.DbContext;
using PFML.Shared.ViewModels.Revenue;
using PFML.Shared.LookupTable;
using PFML.Shared.ViewModels.Premium.WageDetail.WageSubmission;
using FACTS.Framework.Lookup;
using FACTS.Framework.Support;

namespace PFML.BusinessLogic.Premium.WageDetail
{

    public static class WageSubmission
    {

        [OperationMethod]
        public static WageSubmissionViewModel GetEmpWageDetails()
        {
            WageSubmissionViewModel wage = new WageSubmissionViewModel();

            return wage;
        }

        [OperationMethod]
        public static WageSubmissionViewModel GetWagePeriod()
        {
            WageSubmissionViewModel wage = new WageSubmissionViewModel();
          
            return wage;
        }

        [OperationMethod]
        public static WageSubmissionViewModel ValidateSelectionMethod(WageSubmissionViewModel wageDetail)
        {
            wageDetail.ListWageUnitDetailDto= Enumerable.Range(1, 25).Select(x => new Shared.ViewModels.Premium.WageDetail.WageSubmission.WageSubmissionViewModel.WageUnitDetailCutomDto { SrNo = x }).ToList();
            FACTS.Framework.Lookup.LookupValue item = LookupUtil.GetLookupValue(LookupTable.WageDetailAdjReasonCode, LookupTable_WageDetailAdjReasonCode.Original, "Display");
            wageDetail.AdjReasonDisplay = item.Value;
            wageDetail.AdjReasonCode = LookupTable_WageDetailAdjReasonCode.Original;
            return wageDetail;
        }

        [OperationMethod]
        public static WageSubmissionViewModel ValidateManualEntrySubmission(WageSubmissionViewModel wageDetail)
        {
            wageDetail.ListWageEmployerUnitSummary = new List<WageSubmissionViewModel.WageDetailSummary>();
            wageDetail.ListWageEmployerUnitSummary.Add(new WageSubmissionViewModel.WageDetailSummary { EmployerUnitNo = 1, EntityName = "MARCON EXCAVATING INC", NumberofRecords = 4, GrossWage = 155000, QtrMonth1RecordsCount = 4, QtrMonth2RecordsCount = 4, QtrMonth3RecordsCount = 4 });
            return wageDetail;
        }

        [OperationMethod]
        public static WageSubmissionViewModel ValidateTax(WageSubmissionViewModel wageDetail)
        {
            return wageDetail;
        }


    }


}

