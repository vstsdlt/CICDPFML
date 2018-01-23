// ----------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a compiler emitter: FACTS.Framework.Analysis.Generators.DAL.DtoEmitter
//
// Changes to this file may cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
// ----------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using FACTS.Framework.Dto;

namespace PFML.Shared.Model.DbDtos
{

    /// <summary>DTO object: [TaxableAmountSum]</summary>
    [Serializable]
    public class TaxableAmountSumDto : BaseDto
    {

        /// <summary>[CreateDateTime]</summary>
        public DateTime CreateDateTime { get; set; }

        /// <summary>[CreateUserId]</summary>
        public string CreateUserId { get; set; }

        /// <summary>[EmployerId]</summary>
        public int EmployerId { get; set; }

        /// <summary>[Quarter1GrossAmt]</summary>
        public decimal Quarter1GrossAmt { get; set; }

        /// <summary>[Quarter1TaxableAmt]</summary>
        public decimal Quarter1TaxableAmt { get; set; }

        /// <summary>[Quarter2GrossAmt]</summary>
        public decimal Quarter2GrossAmt { get; set; }

        /// <summary>[Quarter2TaxableAmt]</summary>
        public decimal Quarter2TaxableAmt { get; set; }

        /// <summary>[Quarter3GrossAmt]</summary>
        public decimal Quarter3GrossAmt { get; set; }

        /// <summary>[Quarter3TaxableAmt]</summary>
        public decimal Quarter3TaxableAmt { get; set; }

        /// <summary>[Quarter4GrossAmt]</summary>
        public decimal Quarter4GrossAmt { get; set; }

        /// <summary>[Quarter4TaxableAmt]</summary>
        public decimal Quarter4TaxableAmt { get; set; }

        /// <summary>[ReportingQuarter]</summary>
        public string ReportingQuarter { get; set; }

        /// <summary>[ReportingYear]</summary>
        public short ReportingYear { get; set; }

        /// <summary>[StatusCode]</summary>
        public string StatusCode { get; set; }

        /// <summary>[TaxableAmountSeqNo]</summary>
        public short TaxableAmountSeqNo { get; set; }

        /// <summary>[UpdateDateTime]</summary>
        public DateTime UpdateDateTime { get; set; }

        /// <summary>[UpdateNumber]</summary>
        public int? UpdateNumber { get; set; }

        /// <summary>[UpdateProcess]</summary>
        public string UpdateProcess { get; set; }

        /// <summary>[UpdateUserId]</summary>
        public string UpdateUserId { get; set; }

        //Navigational properties
        public virtual EmployerDto Employer { get; set; }

    }

}
