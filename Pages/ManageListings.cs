using MarsFramework.Config;
using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using static MarsFramework.Global.GlobalDefinitions;
using static MarsFramework.Global.Base;
using System.Threading;

namespace MarsFramework.Pages
{
    internal class ManageListings
    {
        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement ManageListingsTab { get; set; }

        //View the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        private IWebElement View { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "//tr[1]//td[8]//i[@class='remove icon'][1]")]
        private IWebElement Delete { get; set; }

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "//tr[1]//td[8]//i[@class='outline write icon'][1]")]
        private IWebElement Edit { get; set; }

        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "//div[@class='actions']")]
        private IWebElement ClickActionsButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[normalize-space()='Request Skill Trade']")]
        private IWebElement ViewTitle { get; set; }
                
        [FindsBy(How = How.XPath, Using = "//button[@class='ui icon positive right labeled button']")]
        private IWebElement YesAction { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='ui negative button']")]
        private IWebElement NoAction { get; set; }
                
        [FindsBy(How = How.XPath, Using = "//tbody//tr[1]//td[2][@class='one wide']")]
        private IWebElement Category_ML { get; set; }

        internal void ViewManageListing()
        {
            test = extent.StartTest("View added ServiceListing");
            try
            {
                wait(5);
                ManageListingsTab.Click();
                wait(5);
                View.Click();
            }
            catch
            {
                Assert.Fail("Record adding FAILED");
            }
            wait(3);

            ExcelLib.PopulateInCollection(MarsResource.ExcelPath, "ShareSkill");

            if (ViewTitle.Text=="Request Skill Trade")
            {
                Assert.Pass("Record can be viewed");
                test.Log(LogStatus.Pass, "Test Pass");
            }
            else
            {
                Assert.Fail("Record cannot be viewed");
                test.Log(LogStatus.Fail, "Test Fail");
            }
            wait(3);

        }
        
        internal void EditManageListing()
        {
            wait(5);
            ManageListingsTab.Click();
            wait(5);
            Edit.Click();
            wait(5);

            ShareSkill editSkillobj = new ShareSkill();
            editSkillobj.EditShareSkill();
        }

        internal void DeleteManageListing()
        {  
            test = extent.StartTest("Delete ServiceListing");
            Thread.Sleep(1000);

            // Sheet Name of the excel file
            ExcelLib.PopulateInCollection(MarsResource.ExcelPath, "ManageListings");

            ManageListingsTab.Click();
            Thread.Sleep(500);

            Delete.Click();
            Thread.Sleep(1000);

            if (ExcelLib.ReadData(2, "DeleteAction") == "Yes")
            {
                YesAction.Click();
            }
            else
            {
                NoAction.Click();
            }

            Thread.Sleep(2000);
            Assert.Pass();
            test.Log(LogStatus.Pass, "Test Pass");
  
        }
    }
}
