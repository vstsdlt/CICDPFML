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

    /// <summary>DTO object: [VoluntaryPlanWaiverRequestType]</summary>
    [Serializable]
    public class VoluntaryPlanWaiverRequestTypeDto : BaseDto
    {

        /// <summary>[CreateDateTime]</summary>
        public DateTime CreateDateTime { get; set; }

        /// <summary>[CreateUserId]</summary>
        public string CreateUserId { get; set; }

        /// <summary>[DurationInWeeksCode]</summary>
        public string DurationInWeeksCode { get; set; }

        /// <summary>[LeaveTypeCode]</summary>
        public string LeaveTypeCode { get; set; }

        /// <summary>[PercentagePaid]</summary>
        public decimal PercentagePaid { get; set; }

        /// <summary>[UpdateDateTime]</summary>
        public DateTime UpdateDateTime { get; set; }

        /// <summary>[UpdateNumber]</summary>
        public int? UpdateNumber { get; set; }

        /// <summary>[UpdateProcess]</summary>
        public string UpdateProcess { get; set; }

        /// <summary>[UpdateUserId]</summary>
        public string UpdateUserId { get; set; }

        /// <summary>[VoluntaryPlanWaiverRequestId]</summary>
        public int VoluntaryPlanWaiverRequestId { get; set; }

        /// <summary>[VoluntaryPlanWaiverRequestTypeId]</summary>
        public int VoluntaryPlanWaiverRequestTypeId { get; set; }

        //Navigational properties
        public virtual VoluntaryPlanWaiverRequestDto VoluntaryPlanWaiverRequest { get; set; }

    }

}
