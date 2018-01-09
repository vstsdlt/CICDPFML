using System;
using System.Collections.Generic;
using FACTS.Framework.Web;
using FACTS.Framework.Lookup;
using FACTS.Framework.Support;
using PFML.Shared.LookupTable;
using PFML.Shared.Model.DbDtos;

namespace PFML.Web.Controllers.Sample.ExampleScreen
{

    public class ExampleScreenController : Controller
    {

        public void SearchNewExecute()
        {
            Machine["SecurityPermission"] = new SecurityPermissionDto();
        }

        public void ResultsNewExecute()
        {
            Machine["SecurityPermission"] = new SecurityPermissionDto();
        }

    }

}