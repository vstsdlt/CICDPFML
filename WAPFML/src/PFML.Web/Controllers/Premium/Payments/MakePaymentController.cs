using FACTS.Framework.Lookup;
using FACTS.Framework.Web;
using PFML.Shared.LookupTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFML.Web.Controllers.Premium.Payments
{
    public class MakePaymentController : Controller
    {
        public void MachineExecute()
        {
            Machine["emprAccountID"] = 10010110;
            Machine["emprName"] = "Test Employer";
            Machine["dbaName"] = "Test DBA";
            Machine["ListSection"] = LookupUtil.GetValues(LookupTable.MakePaymentWizardFlow, null, "{DisplaySortOrder}", null);
            Machine["CurrentSection"] = LookupUtil.GetLookupCode(LookupTable.MakePaymentWizardFlow, LookupTable_MakePaymentWizardFlow.SelectPaymentMethod);
            Machine["ShowHeader"] = true;
            Machine["SaveBankInformation"] = "N";
        }

        public void SelectPaymentMethodStart()
        {
            Machine["CurrentSection"] = LookupUtil.GetLookupCode(LookupTable.MakePaymentWizardFlow, LookupTable_MakePaymentWizardFlow.SelectPaymentMethod);
        }

        public void SelectPaymentMethodExecute()
        {
            decimal prePaymentAmount = 16;//This should be calculated with proper service method.
            decimal amountDue = 987;
            Machine["PaymentDueDates"] = "<b>Quarter 1 - April 30<br/>Quarter 2 - July 31<br/>Quarter 3 - October 31<br/>Quarter 4 - January 31</b>";
            Machine["PrepaymentDueDates"] = "<b>10 calendar days after the start of the quarter</b>";
            Machine["ActualDueDate"] = DateTime.Today;
            Machine["AmountDue"] = amountDue;
            Machine["TotalAmount"] = amountDue + prePaymentAmount;

            Machine["CurrentSection"] = LookupUtil.GetLookupCode(LookupTable.MakePaymentWizardFlow, LookupTable_MakePaymentWizardFlow.SelectPaymentMethod);
            Machine["CheckPayment"] = Machine["SearchType"];
        }

        public void SelectPaymentMethodNext()
        {
            decimal pmtAmount = Convert.ToDecimal(Machine["PmtAmount"]);
            decimal totalAmountDue = Convert.ToDecimal(Machine["TotalAmount"]);
            string pmtMethod = Machine["CheckPaymentMethodType"].ToString();
            string OnlinePaymentMthod = LookupUtil.GetLookupCode(LookupTable.PaymentMethodType, LookupTable_PaymentMethodType.ACHDebit).Code;

            Machine["CheckPayment"] = ((totalAmountDue - pmtAmount) > 0) ? "Partial" : "Full";
            Machine["CheckPaymentMethodType"] = (pmtMethod.Equals(OnlinePaymentMthod, StringComparison.InvariantCultureIgnoreCase)) ? "Online" : "Paper";
        }


        public void PartialPaymentEnd()
        {

        }

        public void CheckPaymentExecute()
        {

        }

        public void CheckPaymentMethodTypeExecute()
        {

        }

        public void CheckPaymentMethodTypeEnd()
        {

        }

        public void PaperCheckStart()
        {

        }

        public void OnlinePaymentStart()
        {
            Machine["CurrentSection"] = LookupUtil.GetLookupCode(LookupTable.MakePaymentWizardFlow, LookupTable_MakePaymentWizardFlow.SubmitPaymentDetails);
        }

        public void PaymentDetailsExecute()
        {
            List<AccountType> listAccountType = new List<AccountType>();
            AccountType actype = new AccountType
            {
                AccountTypeName = "Savings"
            };
            listAccountType.Add(actype);
            actype.AccountTypeName = "Checking";
            listAccountType.Add(actype);

            Machine["AccountTypeDDL"] = string.Empty;

        }
        public void PaymentDetailsNext()
        {
            Machine["CurrentSection"] = LookupUtil.GetLookupCode(LookupTable.MakePaymentWizardFlow, LookupTable_MakePaymentWizardFlow.SubmitPaymentDetails);
            if (Machine["SaveBankInformation"] != null && Machine["SaveBankInformation"].ToString().Equals("selected", StringComparison.InvariantCultureIgnoreCase))
            {
                Machine["SaveBankInformation"] = "Yes";
            }
            else
            {
                Machine["SaveBankInformation"] = "No";
            }
            Machine["PaymentEffectiveDate"] = DateTime.Today;
            Machine["AccountType"] = Machine["AccountTypeDDL"].ToString().Equals(LookupTable_BankAccountType.Savings, StringComparison.InvariantCultureIgnoreCase) ? "Savings" : "Checking";
            Machine["PmtVerificationMsg"] = String.Format("By paying your New Mexico Department of Workforce Solutions bill by way of this online service, you are authorizing NMDWS to charge your {0} account for the amount you submitted.", Machine["AccountType"]);
        }
        public void PaymentVerificationSubmit()
        {

        }
        public void PaymentConfirmationExecute()
        {
            Machine["CurrentSection"] = LookupUtil.GetLookupCode(LookupTable.MakePaymentWizardFlow, LookupTable_MakePaymentWizardFlow.Complete);
            decimal pmtAmount = Convert.ToDecimal(Machine["PmtAmount"]);
            decimal totalAmountDue = Convert.ToDecimal(Machine["TotalAmount"]);
            Machine["BalanceAmount"] = (totalAmountDue - pmtAmount);
        }
        public void PaperCheckVoucherExecute()
        {
            Machine["PmtAmountPaperVoucher"] = "XXX,XXX.XX";
            Machine["emprAccountIDPaperVoucher"] = "XXXXXXX (must be written on check)";
            Machine["ChecksPayableAt"] = "NM Department of Workforce Solutions";
            Machine["MailingAddress"] = "PO BOX 2281 AlbuQuerque, NM 87103";
        }
    }
    [Serializable]
    public class AccountType
    {
        public string AccountTypeName { get; set; }
    }
}
