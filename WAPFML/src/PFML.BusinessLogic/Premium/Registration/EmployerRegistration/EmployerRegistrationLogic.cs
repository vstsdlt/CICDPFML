using System;
using System.Collections.Generic;
using System.Linq;
using FACTS.Framework.DAL;
using FACTS.Framework.Service;
using PFML.DAL.Model.DbEntities;
using PFML.Shared.Model.DbDtos;
using DbContext = PFML.DAL.Model.DbContext;
using PFML.Shared.ViewModels.Premium.Registration;

namespace PFML.BusinessLogic.Premium.Registration
{

    public static class EmployerRegistrationLogic
    {
        [OperationMethod]
        public static EmployerRegistrationViewModel ValidateIntroduction(EmployerRegistrationViewModel employerRegistrationViewModel)
        {
            //check if Fein already exist under UiRgstEmpr and UiEmployer table. if yes, raise validation error: Duplicate FEIN
            using (DbContext context = new DbContext())
            {
                if(context.Employers.Any(emp=>emp.Fein== employerRegistrationViewModel.EmployerDto.Fein))
                {
                    Context.ValidationMessages.AddError("The FEIN entered already exists in the system for another employer account. Verify your records to ensure the information you entered is correct and re-enter the FEIN.");
                }
            }
            return employerRegistrationViewModel;
        }

        [OperationMethod]
        public static EmployerRegistrationViewModel ValidateLiabilityWeeks(EmployerRegistrationViewModel employerRegistrationViewModel)
        {
            return employerRegistrationViewModel;
        }

        [OperationMethod]
        public static EmployerRegistrationViewModel ValidateEnterPhysicalAddr(EmployerRegistrationViewModel employerRegistrationViewModel)
        {
            return employerRegistrationViewModel;
        }

        [OperationMethod]
        public static EmployerRegistrationViewModel ValidateEnterBusiRcdsAddr(EmployerRegistrationViewModel employerRegistrationViewModel)
        {
            return employerRegistrationViewModel;
        }

        [OperationMethod]
        public static EmployerRegistrationViewModel SubmitRegistration(EmployerRegistrationViewModel employerRegistrationViewModel)
        {
            return employerRegistrationViewModel;
        }

        [OperationMethod]
        public static EmployerRegistrationViewModel ValidateEnterBusinessInfoCont(EmployerRegistrationViewModel employerRegistrationViewModel)
        {
            return employerRegistrationViewModel;
        }

        [OperationMethod]
        public static EmployerRegistrationViewModel ValidateEnterBusinessInfo(EmployerRegistrationViewModel employerRegistrationViewModel)
        {
            return employerRegistrationViewModel;
        }

        [OperationMethod]
        public static EmployerRegistrationViewModel ValidateEmpIdentification(EmployerRegistrationViewModel employerRegistrationViewModel)
        {
            return employerRegistrationViewModel;
        }

        [OperationMethod]
        public static EmployerRegistrationViewModel ValidateAdminInfo(EmployerRegistrationViewModel employerRegistrationViewModel)
        {
            return employerRegistrationViewModel;
        }
    
    }
}
