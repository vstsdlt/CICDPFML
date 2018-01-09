using FACTS.Framework.Lookup;
using FACTS.Framework.Support;
using FACTS.Framework.Web;
using PFML.Shared.LookupTable;
using PFML.Shared.Model.DbDtos;

namespace PFML.Web.Controllers.Sample.Revenue.Search
{
    public class EmployerSearchController : Controller
	{
		public void MachineExecute()
		{ }
		public void ResultsNext()
		{
			Machine["ID"] = Machine["Employer[0].ID"];
		}
    }
}
