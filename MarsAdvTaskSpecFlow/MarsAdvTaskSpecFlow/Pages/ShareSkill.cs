using MarsAdvTaskSpecFlow.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MarsAdvTaskSpecFlow.Pages
{
    class ShareSkill
    {
        private IWebDriver testDriver;
        private IWebElement title => testDriver.FindElement(By.Name("title"));
        private IWebElement description => testDriver.FindElement(By.Name("description"));
        private IWebElement categoryIDLvlDDList => testDriver.FindElement(By.Name("categoryId"));
        private IWebElement subCategoryIDLvlDDList => testDriver.FindElement(By.Name("subcategoryId"));
        private IWebElement tags => testDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
        private IWebElement serviceTypeHourly => testDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));
        private IWebElement serviceTypeOneoff => testDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));
        private IWebElement locationTypeOnSite => testDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input"));
        private IWebElement locationTypeOnline => testDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
        private IWebElement startDate => testDriver.FindElement(By.Name("startDate"));
        private IWebElement endDate => testDriver.FindElement(By.Name("endDate"));
        private IWebElement sunday => testDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]/div[1]/div/input"));
        private IWebElement monday => testDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input"));
        private IWebElement tuesday => testDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[1]/div/input"));
        private IWebElement wednesday => testDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[1]/div/input"));
        private IWebElement thursday => testDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[6]/div[1]/div/input"));
        private IWebElement friday => testDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[7]/div[1]/div/input"));
        private IWebElement saturday => testDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[8]/div[1]/div/input"));
        private IWebElement startTime1 => testDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input"));
        private IWebElement endTime1 => testDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input"));
        private IWebElement skillTradeExchange => testDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));
        private IWebElement skill_Exchange => testDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
        private IWebElement skillTradeCredit => testDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input"));
        private IWebElement credit => testDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/input"));
        private IWebElement active => testDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input"));
        private IWebElement hidden => testDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input"));
        private IWebElement saveBtn => testDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]"));
        private IWebElement deleteTag1 => testDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/span[1]/a"));
        private IWebElement Tags => testDriver.FindElement(By.XPath("//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]"));

        // Create Skill Share Page & add the title
        public void AddTitle(IWebDriver testDriver, string Title)
        {
            this.testDriver = testDriver;
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "title", 2);
            title.SendKeys(Title);
        }

        // Add the description
        public void AddDescription(IWebDriver testDriver, string Description)
        {
            this.testDriver = testDriver;
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "description", 2);
            description.SendKeys(Description);
        }

        // Select the category
        public void SelectAddCategory(IWebDriver testDriver, string CategoryId)
        {
            this.testDriver = testDriver;
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "categoryId", 2);
            categoryIDLvlDDList.Click();
            categoryIDLvlDDList.SendKeys(Keys.ArrowDown + Keys.Enter + CategoryId);
        }

        //Select Sub Category
        public void SelectAddSubCategory(IWebDriver testDriver, string subCategoryId)
        {
            this.testDriver = testDriver;
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "subcategoryId", 2);
            subCategoryIDLvlDDList.Click();
            subCategoryIDLvlDDList.SendKeys(Keys.ArrowDown + Keys.Enter + subCategoryId);
        }

        // Add the Tags on Share skill
        public void AddEnterTags(IWebDriver testDriver, string TagData)
        {
            this.testDriver = testDriver;
            tags.SendKeys(TagData);
            tags.SendKeys(Keys.Enter);
        }

        public void ServiceTypeHourly()
        {
            serviceTypeHourly.Click();
        }

        public void ServiceTypeOne_off()
        {
            serviceTypeOneoff.Click();
        }

        public void LocationTypeOnsite()
        {
            locationTypeOnSite.Click();
        }

        public void LocationTypeOnline()
        {
            locationTypeOnline.Click();
        }

        public void AddAvailableDays(IWebDriver testDriver, string StartDate, string EndDate, string StartTime, string EndTime)
        {
            this.testDriver = testDriver;
            startDate.SendKeys(StartDate);
            endDate.SendKeys(EndDate);
            sunday.Click();
            startTime1.Click();
            startTime1.SendKeys(StartTime);
            endTime1.Click();
            endTime1.SendKeys(EndTime);
        }

        public void SkillExchange(IWebDriver testDriver, string Skill)
        {
            this.testDriver = testDriver;
            skillTradeExchange.Click();
            skill_Exchange.SendKeys(Skill);
            skill_Exchange.SendKeys(Keys.Enter);
        }

        public void EditCreditExchange(IWebDriver testDriver, string CreditAmt)
        {
            this.testDriver = testDriver;
            skillTradeCredit.Click();
            credit.SendKeys(CreditAmt);
        }

        public void ActiveShareSkill()
        {
            active.Click();
        }

        public void HiddenShareSkill()
        {
            hidden.Click();
        }

        public void SaveShareSkill()
        {
            saveBtn.Click();
        }

        // Edit Skill Share Page & the title
        public void EditTitle(IWebDriver testDriver, string Title)
        {
            this.testDriver = testDriver;
            title.Clear();
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "title", 3);
            title.SendKeys(Title);
        }

        // Edit the description
        public void EditDescription(IWebDriver testDriver, string Description)
        {
            this.testDriver = testDriver;
            description.Clear();
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "description", 3);
            description.SendKeys(Description);
        }

        // Edit the category
        public void SelectEditCategory(IWebDriver testDriver, string CategoryId)
        {
            this.testDriver = testDriver;
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "categoryId", 2);
            categoryIDLvlDDList.Click();
            categoryIDLvlDDList.SendKeys(Keys.ArrowDown + Keys.Enter + CategoryId);
        }

        //Edit Sub Category
        public void SelectEditSubCategory(IWebDriver testDriver, string subCategoryId)
        {
            this.testDriver = testDriver;
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "subcategoryId", 2);
            subCategoryIDLvlDDList.Click();
            subCategoryIDLvlDDList.SendKeys(Keys.ArrowDown + Keys.Enter + subCategoryId);
        }

        // Edit the Tags on Share skill
        public void EditTags(IWebDriver testDriver, string TagData)
        {
            this.testDriver = testDriver;
            deleteTag1.Click();
            tags.SendKeys(TagData);
            tags.SendKeys(Keys.Enter);
        }

        public void EditAvailableDays(IWebDriver testDriver, string StartDate, string EndDate, string startTime, string EndTime)
        {
            this.testDriver = testDriver;
            startDate.SendKeys(StartDate);
            endDate.SendKeys(EndDate);
            sunday.Click();
            startTime1.Click();
            startTime1.SendKeys(startTime);
            endTime1.Click();
            endTime1.SendKeys(EndTime);
        }
    }
}
