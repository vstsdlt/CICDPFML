// ----------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a compiler emitter: FACTS.Framework.Analysis.Generators.OperationMethod.ControllerEmitter
//
// Changes to this file may cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
// ----------------------------------------------------------------------------------------------------

using System;
using Microsoft.AspNetCore.Mvc;
using FACTS.Framework.Service;

namespace PFML.Service.Controllers.Core.Headers
{

    public class AgencyController : Controller
    {

        [HttpPost]
        [Route("Core/Headers/Agency/BlankSearchCriteria")]
        [OperationMethodFilter]
        public PFML.Shared.ViewModels.Core.Headers.Agency.SearchCriteria BlankSearchCriteria()
        {
            return PFML.BusinessLogic.Core.Headers.AgencyLogic.BlankSearchCriteria();
        }

        [HttpPost]
        [Route("Core/Headers/Agency/Search")]
        [OperationMethodFilter]
        public System.Collections.Generic.List<PFML.Shared.ViewModels.Core.Headers.Agency.ResultRecord> Search([FromBody]PFML.Shared.ViewModels.Core.Headers.Agency.SearchCriteria criteria)
        {
            return PFML.BusinessLogic.Core.Headers.AgencyLogic.Search(criteria);
        }

        [HttpPost]
        [Route("Core/Headers/Agency/Fetch")]
        [OperationMethodFilter]
        public PFML.Shared.ViewModels.Core.Headers.Agency.Record Fetch([FromBody]int id)
        {
            return PFML.BusinessLogic.Core.Headers.AgencyLogic.Fetch(id);
        }

    }

}
