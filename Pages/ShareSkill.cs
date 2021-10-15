using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using static MarsFramework.Global.GlobalDefinitions;
using MarsFramework.Config;
using MarsFramework.Pages;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using NUnit.Framework;
using System.Collections.Generic;
using System; 
using System.Linq;
using AutoItX3Lib;
using RelevantCodes.ExtentReports;
using static MarsFramework.Global.Base;
using MarsFramework.Global;

namespace MarsFramework.Pages
{
    public class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on ShareSkill Button
        [FindsBy(How = How.XPath, Using =  "//a[normalize-space()='Share Skill']")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
        private IWebElement Tags { get; set; }
        
        //Clear Tag names
        [FindsBy(How = How.XPath, Using = "//div[@id='service - listing - section']/div[2]/div/form/div[4]/div[2]/div/div/div/span[1]/a")]
        private IWebElement ClearTags { get; set; }

        //Select the Service type
        [FindsBy(How = How.XPath, Using = "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']")]
        private IWebElement ServiceTypeOptions { get; set; }

        //Select the Hourly Service type
        [FindsBy(How = How.XPath, Using = "(//input[@value='0'])[1]")]
        private IWebElement Hourly { get; set; }

        //Select the OneOff Service type
        [FindsBy(How = How.XPath, Using = "(//input[@name='serviceType'])[2]")]
        private IWebElement Oneoff { get; set; }

        //Select the Location Type
        [FindsBy(How = How.XPath, Using = "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement LocationTypeOption { get; set; }

        //Select the Onsite Location Type
        [FindsBy(How = How.XPath, Using = "(//input[@value='0'])[2]")]
        private IWebElement Onsite { get; set; }

        //Select the Online Location Type
        [FindsBy(How = How.XPath, Using = "(//input[@value='1'])[2]")]
        private IWebElement Online { get; set; }

        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//div[@class='ui checkbox']//input[@index='1']")]
        private IWebElement Days { get; set; }

        //Storing the starttime
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTime { get; set; }

        //Click on StartTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTimeDropDown { get; set; }

        //Click on EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[3]/input[1]")]
        private IWebElement EndTimeDropDown { get; set; }

        //Click on Skill Trade option
        [FindsBy(How = How.XPath, Using = "//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement SkillTradeOption { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }

        //Clear Skill Exchange Tag
        [FindsBy(How = How.XPath, Using = "//div[@id='service - listing - section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/span[1]/a")]
        private IWebElement ClearSkillTag { get; set; }

        //Click on Credit option
        [FindsBy(How = How.XPath, Using = "(//input[@value='false'])[1]")]
        private IWebElement Credit { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[@class='huge plus circle icon padding-25']")]
        private IWebElement WorkSample { get; set; }

        //Click on Hidden option
        [FindsBy(How = How.XPath, Using = "//input[@name='isActive'][@value='true']")]
        private IWebElement ActiveOption { get; set; }

        //Click on Hidden option
        [FindsBy(How = How.XPath, Using = "//input[@name='isActive'][@value='false']")]
        private IWebElement HiddenOption { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }

        //Click on Cancel button
        [FindsBy(How = How.XPath, Using = "//input[@value='Cancel']")]
        private IWebElement Cancel { get; set; }
              
        //Click on manage listing tab
        [FindsBy(How = How.XPath, Using = "//a[@href='/Home/ListingManagement']")]
        private IWebElement ManageListing { get; set; }

        //Category
        [FindsBy(How = How.XPath, Using = "//tbody//tr[1]//td[2][@class='one wide']")]
        private IWebElement Category_ML { get; set; }

        //Title
        [FindsBy(How = How.XPath, Using = "//tbody//tr[1]//td[3][@class='four wide']")]
        private IWebElement Title_ML { get; set; }

        internal void EnterShareSkill()
        {
            test = extent.StartTest("Adding ServiceListing Details");
            try
            {
                Thread.Sleep(3000);

                //Click on the Shareskill button
                ShareSkillButton.Click();
                
                // Sheet Name of the excel file
                ExcelLib.PopulateInCollection(MarsResource.ExcelPath, "ShareSkill");

                // Read the Title from excel and enter it in the title input
                Title.SendKeys(ExcelLib.ReadData(2, "Title"));
         
                // Read the Description from excel and enter it in the description input
                Description.SendKeys(ExcelLib.ReadData(2, "Description"));
               
                // Read the Category from excel and select it from the category dropdown 
                SelectElement category = new SelectElement(CategoryDropDown);
                category.SelectByText(ExcelLib.ReadData(2, "Category"));
           
                // Read the Subcategory from excel and select it from the subcategory dropdown 
                SelectElement subcategory = new SelectElement(SubCategoryDropDown);
                subcategory.SelectByText(ExcelLib.ReadData(2, "Subcategory"));

                // Screenshot
                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Sobitha_Screenshot");

                // Read the Tags from excel and enter it in the Tags input 
                Tags.SendKeys(ExcelLib.ReadData(2, "Tags"));
                Tags.SendKeys(Keys.Return);
                Thread.Sleep(500);

                //Read the ServiceType from excel and select the type 
                if (ExcelLib.ReadData(2, "ServiceType") == "Hourly basis service")
                {
                    Hourly.Click();
                }
                else
                {
                    Oneoff.Click();
                }

                //Read the LocationType from excel and select the type 
                if (ExcelLib.ReadData(2, "LocationType") == "On-site")
                {
                    Onsite.Click();
                }
                else
                {
                    Online.Click();
                }

                //Read the StartDate from excel and select the startdate 
                StartDateDropDown.SendKeys(ExcelLib.ReadData(2, "StartDate"));

                //Read the EndDate from excel and select the enddate
                EndDateDropDown.SendKeys(ExcelLib.ReadData(2, "EndDate"));

                //Select the Available Days
                Days.Click();

                //Read StartTime from excel and send the data
                StartTime.SendKeys(ExcelLib.ReadData(2, "StartTime"));

                //Read EndTime from excel and send the data
                EndTimeDropDown.SendKeys(ExcelLib.ReadData(2, "EndTime"));
                Thread.Sleep(1000);

                if (ExcelLib.ReadData(2, "SkillTrade") == "Skill-exchange")
                {
                    SkillTradeOption.Click();
                    SkillExchange.SendKeys(ExcelLib.ReadData(2, "SkillExchange"));
                    SkillExchange.SendKeys(Keys.Return);
                }
                else if (ExcelLib.ReadData(2, "SkillTrade") == "Credit")
                {
                    Credit.Click();
                    CreditAmount.SendKeys(ExcelLib.ReadData(2, "Credit"));
                    Credit.SendKeys(Keys.Enter);
                }
                Thread.Sleep(500);

                // Click on the WorkSample "+" Button
                WorkSample.Click();
                Thread.Sleep(3000);

                // Upload file using autoit
                AutoItX3 autoitedit = new AutoItX3();
                // Activate- so that next set of actions happen on this window window
                autoitedit.WinActivate("file upload");
                Thread.Sleep(3000);
                // Path
                autoitedit.Send(ExcelLib.ReadData(2, "Sample"));
                Thread.Sleep(2000);
                // Pressing Open button
                autoitedit.Send("{Enter}");
                Thread.Sleep(3000);

                //Read the ActiveType from excel and select the type 
                if (ExcelLib.ReadData(2, "Active") == "Active")
                {
                    ActiveOption.Click();
                }
                else
                {
                    HiddenOption.Click();
                }
                wait(3000);

                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Sobitha_Screenshot");
                //Click on Save button to save the listings
                Save.Click();

                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Sobitha_Screenshot");
                Thread.Sleep(3000);
            }
            catch
            {
                Assert.Fail("Record adding FAILED");
            }
            Thread.Sleep(2000);

            //After saving it will automatically naviagte to the Manage Listing Page
            //Validating the service details in manage listing page with the added details
            if (Category_ML.Text == ExcelLib.ReadData(2, "Category") && Title_ML.Text == ExcelLib.ReadData(2, "Title"))
            {
                Assert.Pass();
                test.Log(LogStatus.Pass, "Test Pass");
            }
            else
            {
                Assert.Fail();
                test.Log(LogStatus.Fail, "Test Fail");
            }
            Thread.Sleep(2000);
        }

        internal void EditShareSkill()
        {
            test = extent.StartTest("Editing ServiceListing Details");
            try
            {
                Thread.Sleep(2000);
           
                // Sheet Name of the excel file
                ExcelLib.PopulateInCollection(MarsResource.ExcelPath, "ShareSkill");

                // Read the Title from excel and enter it in the title input
                Title.Clear();
                Title.SendKeys(ExcelLib.ReadData(6, "Title"));

                // Read the Description from excel and enter it in the description input
                Description.Clear();
                Description.SendKeys(ExcelLib.ReadData(6, "Description"));

                // Read the Category from excel and select it from the category dropdown 
                SelectElement category = new SelectElement(CategoryDropDown);
                category.SelectByText(ExcelLib.ReadData(6, "Category"));

                // Read the Subcategory from excel and select it from the subcategory dropdown 
                SelectElement subcategory = new SelectElement(SubCategoryDropDown);
                subcategory.SelectByText(ExcelLib.ReadData(6, "Subcategory"));
     
                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Sobitha_Screenshot");
                // Read the Tags from excel and enter it in the Tags input 
                //ClearTags.Click();
                Thread.Sleep(1000);
                Tags.SendKeys(ExcelLib.ReadData(6, "Tags"));
                Tags.SendKeys(Keys.Return);

                //Read the ServiceType from excel and select the type 
                if (ExcelLib.ReadData(6, "ServiceType") == "Hourly basis service")
                {
                    Hourly.Click();
                }
                else
                {
                    Oneoff.Click();
                }

                //Read the LocationType from excel and select the type 
                if (ExcelLib.ReadData(6, "LocationType") == "On-site")
                {
                    Onsite.Click();
                }
                else
                {
                    Online.Click();
                }

                //Read the StartDate from excel and select the startdate 
                StartDateDropDown.SendKeys(ExcelLib.ReadData(6, "StartDate"));

                //Read the EndDate from excel and select the enddate
                EndDateDropDown.SendKeys(ExcelLib.ReadData(6, "EndDate"));
    
                //Select the Available Days
                Days.Click();

                //Read StartTime from excel and send the data
                StartTime.SendKeys(ExcelLib.ReadData(6, "StartTime"));

                //Read EndTime from excel and send the data
                EndTimeDropDown.SendKeys(ExcelLib.ReadData(6, "EndTime"));

                if (ExcelLib.ReadData(2, "SkillTrade") == "Skill-exchange")
                {
                    //ClearSkillTag.Click();
                    SkillTradeOption.Click();
                    SkillExchange.SendKeys(ExcelLib.ReadData(6, "SkillExchange"));
                    SkillExchange.SendKeys(Keys.Return);
                }
                else if (ExcelLib.ReadData(2, "SkillTrade") == "Credit")
                {
                    Credit.Click();
                    CreditAmount.Clear();
                    CreditAmount.SendKeys(ExcelLib.ReadData(6, "Credit"));
                    Credit.SendKeys(Keys.Enter);
                }

                // Click on the WorkSample "+" Button
                WorkSample.Click();

                // Upload file using autoit
                AutoItX3 autoitedit = new AutoItX3();
                // Activate- so that next set of actions happen on this window window
                autoitedit.WinActivate("file upload");
                Thread.Sleep(3000);
                // Path
                autoitedit.Send(ExcelLib.ReadData(6, "Sample"));
                Thread.Sleep(2000);
                // Pressing Open button
                autoitedit.Send("{enter}");
                Thread.Sleep(2000);

                //Read the ActiveType from excel and select the type 
                if (ExcelLib.ReadData(6, "Active") == "Active")
                {
                    ActiveOption.Click();
                }
                else
                {
                    HiddenOption.Click();
                }
                wait(3000);
        
                // Screenshot
                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Sobitha_Screenshot");
                
                //Click on Save button to save the listings
                Save.Click();
                Thread.Sleep(2000);

                // Screenshot
                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Sobitha_Screenshot");
                Thread.Sleep(2000);
            }
             catch
            {
                Assert.Fail("Record editing FAILED");
            }
            Thread.Sleep(2000);

            //After saving it will automatically naviagte to the Manage Listing Page
            //Validating the service details in manage listing page with the added details
            if (Category_ML.Text == ExcelLib.ReadData(6, "Category") && Title_ML.Text == ExcelLib.ReadData(6, "Title"))
            {
                Assert.Pass();
                test.Log(LogStatus.Pass, "Test Pass");
            }
            else
            {
                Assert.Fail();
                test.Log(LogStatus.Fail, "Test Fail");
            }
            Thread.Sleep(2000);
        }
    }
}
