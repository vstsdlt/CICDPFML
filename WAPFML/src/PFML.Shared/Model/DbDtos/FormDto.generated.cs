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

    /// <summary>DTO object: [Form]</summary>
    [Serializable]
    public class FormDto : BaseDto
    {

        /// <summary>[CreateDateTime]</summary>
        public DateTime CreateDateTime { get; set; }

        /// <summary>[CreateUserId]</summary>
        public string CreateUserId { get; set; }

        /// <summary>[FormId]</summary>
        public int FormId { get; set; }

        /// <summary>[FormTypeCode]</summary>
        public string FormTypeCode { get; set; }

        /// <summary>[StatusCode]</summary>
        public string StatusCode { get; set; }

        /// <summary>[UpdateDateTime]</summary>
        public DateTime UpdateDateTime { get; set; }

        /// <summary>[UpdateNumber]</summary>
        public int? UpdateNumber { get; set; }

        /// <summary>[UpdateProcess]</summary>
        public string UpdateProcess { get; set; }

        /// <summary>[UpdateUserId]</summary>
        public string UpdateUserId { get; set; }

        //Reverse navigational properties
        public virtual List<FormAttachmentDto> FormAttachments { get; private set; } = new List<FormAttachmentDto>();
        public virtual List<VoluntaryPlanWaiverRequestDto> VoluntaryPlanWaiverRequests { get; private set; } = new List<VoluntaryPlanWaiverRequestDto>();

    }

}
