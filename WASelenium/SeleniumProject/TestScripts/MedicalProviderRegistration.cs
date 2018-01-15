using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumProject
{
    class MedicalProviderRegistration
    {
        public void MedicalProviderRegistrationTest(IWebDriver driver, Dictionary<string, string> inputDataCollection, string testCasePath, string inputDriverName)
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            //-----------------Registration Option(s)---------------------------


            SeleniumDriverObject.SaveScreenShot(inputDriverName, driver, testCasePath, "Registration Option.jpg");
            //Click Physician/Practitioner Registration
            driver.FindElement(By.Id("C_P")).Click();

            //-----------------Physician / Practitioner: Account Verification Information-----------------------------
            SeleniumDriverObject.ExplicitWaitForPageLoad(driver, By.Id("D_K"), TimeSpan.FromSeconds(30));

            //Enter FirstName
            driver.FindElement(By.Id("D_K")).Clear();
            driver.FindElement(By.Id("D_K")).SendKeys(inputDataCollection["FirstName"]);

            //Enter LastName
            driver.FindElement(By.Id("D_P")).Clear();
            driver.FindElement(By.Id("D_P")).SendKeys(inputDataCollection["LastName"]);

            //Enter DateOfBirth
            driver.FindElement(By.Id("D_T")).Clear();
            driver.FindElement(By.Id("D_T")).SendKeys(inputDataCollection["DateOfBirth"]);

            //Enter Last Four Digits of Social Security Number
            driver.FindElement(By.Id("D_W")).Clear();
            driver.FindElement(By.Id("D_W")).SendKeys(inputDataCollection["Last Four Digits of SSN"]);

            //Enter Driver License Number
            driver.FindElement(By.Id("D_Z")).Clear();
            driver.FindElement(By.Id("D_Z")).SendKeys(inputDataCollection["Driver License Number"]);

            //Enter Re-type Driver License Number
            driver.FindElement(By.Id("D_c")).Clear();
            driver.FindElement(By.Id("D_c")).SendKeys(inputDataCollection["Driver License Number"]);

            //Select Issued By State
            new SelectElement(driver.FindElement(By.Id("D_f"))).SelectByText(inputDataCollection["Issued By State"]);

            //Select License Type
            new SelectElement(driver.FindElement(By.Id("D_h"))).SelectByText(inputDataCollection["License Type"]);

            //Enter Physician/Practitioner License Number
            driver.FindElement(By.Id("D_k")).Clear();
            driver.FindElement(By.Id("D_k")).SendKeys(inputDataCollection["Physician/Practitioner License Number"]);

            //Enter License Expiration Date
            driver.FindElement(By.Id("D_m")).Clear();
            driver.FindElement(By.Id("D_m")).SendKeys(inputDataCollection["License Expiration Date"]);

            //Enter Address Line 1
            driver.FindElement(By.Id("D_w")).Clear();
            driver.FindElement(By.Id("D_w")).SendKeys(inputDataCollection["Address Line 1"]);

            //Enter City
            driver.FindElement(By.Id("D_BC")).Clear();
            driver.FindElement(By.Id("D_BC")).SendKeys(inputDataCollection["City"]);

            //Select State
            new SelectElement(driver.FindElement(By.Id("D_BF"))).SelectByText(inputDataCollection["State"]);

            //Enter Zip/Postal Code
            driver.FindElement(By.Id("D_BH")).Clear();
            driver.FindElement(By.Id("D_BH")).SendKeys(inputDataCollection["Zip/Postal Code"]);

            //Select Country
            //new SelectElement(driver.FindElement(By.Id("D_BK"))).SelectByText(inputDataCollection["Country"]);

            //Enter Phone
            driver.FindElement(By.Id("D_BM")).Clear();
            driver.FindElement(By.Id("D_BM")).SendKeys(inputDataCollection["Phone"]);

            //Select Yes - When possible, would you like to receive message from us electronically?
            driver.FindElement(By.XPath("/html/body/div[1]/div[2]/form/div/div/div/div/div[2]/div[5]/div/div/div/div[2]/div[1]/div/div/div/div/div[2]/label/span")).Click();

            //Enter E-mail Address
            driver.FindElement(By.Id("D_BS")).Clear();
            driver.FindElement(By.Id("D_BS")).SendKeys(inputDataCollection["E-mail Address"]);

            //Enter Re-type E-mail Address
            driver.FindElement(By.Id("D_BT")).Clear();
            driver.FindElement(By.Id("D_BT")).SendKeys(inputDataCollection["E-mail Address"]);

            SeleniumDriverObject.SaveScreenShot(inputDriverName, driver, testCasePath, "Ref1 Physician Practitioner Account Verification Information.jpg");

            //Click Next
            driver.FindElement(By.Id("D_BX")).Click();

            //------------------------Set Password-------------------------------------
            SeleniumDriverObject.ExplicitWaitForPageLoad(driver, By.Id("D_F"), TimeSpan.FromSeconds(30));

            //Enter New Password
            driver.FindElement(By.Id("D_F")).Clear();
            driver.FindElement(By.Id("D_F")).SendKeys(inputDataCollection["New Password"]);

            //Enter Confirm Password
            driver.FindElement(By.Id("D_G")).Clear();
            driver.FindElement(By.Id("D_G")).SendKeys(inputDataCollection["New Password"]);

            //Select Security Question
            new SelectElement(driver.FindElement(By.Id("D_H"))).SelectByText(inputDataCollection["Security Question"]);

            //Enter Security Answer
            driver.FindElement(By.Id("D_J")).Clear();
            driver.FindElement(By.Id("D_J")).SendKeys(inputDataCollection["Security Answer"]);

            //Enter Confirm Security Answer
            driver.FindElement(By.Id("D_K")).Clear();
            driver.FindElement(By.Id("D_K")).SendKeys(inputDataCollection["Security Answer"]);

            SeleniumDriverObject.SaveScreenShot(inputDriverName, driver, testCasePath, "Ref2 Set Password.jpg");

            //Click Submit
            driver.FindElement(By.Id("D_N")).Click();

            //-------------------------Account Setup Confirmation---------------------------------
            SeleniumDriverObject.ExplicitWaitForPageLoad(driver, By.Id("D_G"), TimeSpan.FromSeconds(30));

            SeleniumDriverObject.SaveScreenShot(inputDriverName, driver, testCasePath, "Ref3 Account Setup Confirmation.jpg");
            //Click Login
            driver.FindElement(By.Id("D_G")).Click();

        }
    }
}
