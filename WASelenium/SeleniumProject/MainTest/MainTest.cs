using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;


namespace SeleniumProject
{
    //Local Browsers
    [TestFixture("Chrome_Local")]
    [TestFixture("IE_Local")]
    [TestFixture("Firefox_Local")]

    /*
    [TestFixture("IE11_Browser")]
    [TestFixture("Chrome_Browser")]
    [TestFixture("Firefox_Browser")]
    [TestFixture("Safari_Browser")]
    
    //Iphone and Ipad
    [TestFixture("Iphone6SPlus_Mobile_Portrait")]
    [TestFixture("Iphone6SPlus_Mobile_Landscape")]
    [TestFixture("Iphone6S_Mobile_Portrait")]
    [TestFixture("Iphone6S_Mobile_Landscape")]
    [TestFixture("IpadMini4_Tab_Portrait")]
    [TestFixture("IpadMini4_Tab_Landscape")]
    [TestFixture("IpadAir_Tab_Portrait")]
    [TestFixture("IpadAir_Tab_Landscape")]

    //Android Devices
    [TestFixture("HTCOneM8_Mobile_Portrait")]
    [TestFixture("HTCOneM8_Mobile_Landscape")]
    [TestFixture("GooglePixel_Mobile_Portrait")]
    [TestFixture("GooglePixel_Mobile_Landscape")]
    [TestFixture("SamsungGalaxyS7_Mobile_Portrait")]
    [TestFixture("SamsungGalaxyS7_Mobile_Landscape")]
    [TestFixture("SamsungGalaxyNote4_Tab_Portrait")]
    [TestFixture("SamsungGalaxyNote4_Tab_Landscape")]
    [TestFixture("GoogleNexus9_Tab_Portrait")]
    [TestFixture("GoogleNexus9_Tab_Landscape")]
    */
    public class MainTest
    {
        #region Private variables

        private IWebDriver driver;
        public string inputDriverName = string.Empty;
        private string screenShotPath = string.Empty;
        private string loggedInUserName = string.Empty;

        #endregion Private variables


        #region Test Settings

        public MainTest(string inputDriver)
        {
            inputDriverName = inputDriver;
        }


        [TestFixtureSetUp]
        public void Init()
        {

            screenShotPath = TestDataParameter.testDateTimePath;
            SeleniumEvent.EventDataParameter.deviceOS = string.Empty;
            SeleniumEvent.EventDataParameter.deviceTestSessionID = string.Empty;
        }

        [TestFixtureTearDown]
        public void TeardownFixture()
        {
        }

        [SetUp]
        public void SetupTest()
        {

            if (inputDriverName != string.Empty)
            {
                driver = TestDataParameter.GetDriverNameFromXML(inputDriverName, TestContext.CurrentContext.Test.Name);

                if (driver == null)
                {
                    Assert.Ignore("Fixture doesn't exist in the list");
                }
            }
            else
            {
                Assert.Ignore("Parameters are not provided for Fixture");
            }

        }

        [TearDown]
        public void TeardownTest()
        {

            driver.Quit();
            
        }

        #endregion Test Settings

        #region Test methods

        private void ValidateFixtureTestData(Dictionary<string, string> inputDataCollection, string inputDriverName)
        {
            if (!Helper.ValidateFixtureTestData(inputDataCollection, inputDriverName))
            {
                Assert.Ignore(string.Format("Fixture:{0}  does not match input data", inputDriverName));
            }

        }

        
        [Test, TestCaseSource(typeof(TestDataConstructors), "GetuFACTS_SearchData")]
        public void UFACTS_Search(Dictionary<string, string> inputDataCollection)
        {
            string testCasePath = string.Empty;
            Helper.CreateFolder(screenShotPath, "uFACTS_Search/" + inputDriverName, out testCasePath);
            SeleniumDriverObject.currentTestCasePath = testCasePath;
            UFACTS_Search ObjuFACTS_Search = new UFACTS_Search();

            ObjuFACTS_Search.UFACTS_SearchTest(driver, inputDataCollection, testCasePath, inputDriverName);
        }

        #endregion Test methods
    }
}