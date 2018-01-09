using System;
using System.Collections.Generic;
using System.Linq;
using FACTS.Framework.DAL;
using FACTS.Framework.Service;
using PFML.DAL.Model.DbEntities;
using PFML.Shared.Model.DbDtos;
using PFML.Shared.ViewModels.Core.Headers.Agency;
using PFML.Shared.ViewModels.Revenue;
using DbContext = PFML.DAL.Model.DbContext;

namespace PFML.BusinessLogic.Sample.Revenue.Search
{

	public static class EmployerSearchLogic
	{
		/// <summary>Return a blank copy of search criteria</summary>
		/// <returns>New copy of search critiera object</returns>
		[OperationMethod]
		public static SearchCriteria BlankSearchCriteria()
		{
			return new SearchCriteria();
		}

		[OperationMethod]
		public static List<Employer> Search(string name)
		{
			using (DbContext dbContext = new DbContext())
			{
				return new List<Employer>() {
					new Employer(){ AccountNumber="EMP001", ID=1, Name="Deloitte", AccountProfile="Active" },
				new Employer(){ AccountNumber="EMP002", ID=2, Name="Deloitte2", AccountProfile="Active" } ,
				new Employer(){ AccountNumber="EMP003", ID=3, Name="Deloitte3", AccountProfile="Active" } ,
				new Employer(){ AccountNumber="EMP004", ID=4, Name="Deloitte4", AccountProfile="Active" } };
				
			}
		}


		[OperationMethod]
		public static Employer GetEmployer(int ID)
		{
			using (DbContext dbContext = new DbContext())
			{

				List<Employer> obj = new List<Employer>() {
					new Employer(){ AccountNumber="EMP001", ID=1, Name="Deloitte", AccountProfile="Active", EAN="EAN10010", FEIN="FEIN3002", LiabilityDate= DateTime.Now, LiabilityIncurred=DateTime.Now.AddDays(10), PaymentMethodType="Contributory", ChangePaymentMethod= false, HistoryTransfer=true, Successor=false, InitiatedExistingSelfService=false, InitiatedForWageClaim=true,NMPRC="NMPRC01002", CRS="CRS0100" },
				new Employer(){ AccountNumber="EMP002", ID=2, Name="Deloitte2", AccountProfile="Active" } ,
				new Employer(){ AccountNumber="EMP003", ID=3, Name="Deloitte3", AccountProfile="Active" } ,
				new Employer(){ AccountNumber="EMP004", ID=4, Name="Deloitte4", AccountProfile="Active" } };

				return obj.Where(i => i.ID == ID).FirstOrDefault();
			}
		}
	}
}
