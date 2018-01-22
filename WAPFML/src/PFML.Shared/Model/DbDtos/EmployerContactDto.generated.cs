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

    /// <summary>DTO object: [EmployerContact]</summary>
    [Serializable]
    public class EmployerContactDto : BaseDto
    {

        /// <summary>[ContactSeqNo]</summary>
        public int ContactSeqNo { get; set; }

        /// <summary>[ContactTypeCode]</summary>
        public string ContactTypeCode { get; set; }

        /// <summary>[CreateDateTime]</summary>
        public DateTime CreateDateTime { get; set; }

        /// <summary>[CreateUserId]</summary>
        public string CreateUserId { get; set; }

        /// <summary>[EmailAddress]</summary>
        public string EmailAddress { get; set; }

        /// <summary>[EmployerId]</summary>
        public int EmployerId { get; set; }

        /// <summary>[FirstName]</summary>
        public string FirstName { get; set; }

        /// <summary>[LastName]</summary>
        public string LastName { get; set; }

        /// <summary>[MiddleInitial]</summary>
        public string MiddleInitial { get; set; }

        /// <summary>[PhoneNumber]</summary>
        public string PhoneNumber { get; set; }

        /// <summary>[PhoneNumberExtn]</summary>
        public string PhoneNumberExtn { get; set; }

        /// <summary>[SecondaryPhoneNumber]</summary>
        public string SecondaryPhoneNumber { get; set; }

        /// <summary>[SecondaryPhoneNumberExtn]</summary>
        public string SecondaryPhoneNumberExtn { get; set; }

        /// <summary>[StatusCode]</summary>
        public string StatusCode { get; set; }

        /// <summary>[Title]</summary>
        public string Title { get; set; }

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