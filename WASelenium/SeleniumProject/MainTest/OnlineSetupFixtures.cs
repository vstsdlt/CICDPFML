using System;
using NUnit.Framework;
using NUnit.Core;
using System.Configuration;

namespace SeleniumProject
{
    [SetUpFixture]
    public class OnlineSetUpFixture
    {
        [SetUp]
        public void Init()
        {

            string strDate = string.Empty;
            strDate = DateTime.Now.ToString("ddMMMyyyy hhmmss").ToUpper();
            Helper.CreateFolder(ConfigurationManager.AppSettings["ScreenShotPath"], strDate, out TestDataParameter.testDateTimePath);
            SeleniumEvent.EventDataParameter.screenShotParentPath = TestDataParameter.testDateTimePath;
        }
        [TearDown]
        public void End()
        {

        }

    }

}

