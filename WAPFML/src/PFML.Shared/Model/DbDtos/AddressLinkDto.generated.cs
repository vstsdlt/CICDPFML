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

    /// <summary>DTO object: [AddressLink]</summary>
    [Serializable]
    public class AddressLinkDto : BaseDto
    {

        /// <summary>[AddressId]</summary>
        public int AddressId { get; set; }

        /// <summary>[AddressLinkId]</summary>
        public int AddressLinkId { get; set; }

        /// <summary>[AddressTypeCode]</summary>
        public string AddressTypeCode { get; set; }

        /// <summary>[AgentId]</summary>
        public int? AgentId { get; set; }

        /// <summary>[CreateDateTime]</summary>
        public DateTime CreateDateTime { get; set; }

        /// <summary>[CreateUserId]</summary>
        public string CreateUserId { get; set; }

        /// <summary>[EmployerId]</summary>
        public int? EmployerId { get; set; }

        /// <summary>[EmployerUnitSeqNo]</summary>
        public int? EmployerUnitSeqNo { get; set; }

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

        //Navigational properties
        public virtual AddressDto Address { get; set; }
        public virtual EmployerDto Employer { get; set; }
        public virtual EmployerUnitDto EmployerUnit { get; set; }

    }

}
