using FACTS.Framework.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFML.Web.Controllers.Revenue.Payments
{
    public class MakePaymentController: Controller
    {
        public void MachineExecute()
        {
            Machine["emprAccountID"] = 1;
        }
    }
}
