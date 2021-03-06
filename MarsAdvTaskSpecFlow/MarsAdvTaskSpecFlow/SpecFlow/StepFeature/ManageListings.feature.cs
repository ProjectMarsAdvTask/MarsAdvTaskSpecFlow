// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MarsAdvTaskSpecFlow.SpecFlow.StepFeature
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ManageListings")]
    public partial class ManageListingsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "ManageListings.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SpecFlow/StepFeature", "ManageListings", null, ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("1. Adding of the Share Skill on Manage Listing Page")]
        [NUnit.Framework.CategoryAttribute("AddShareSkill")]
        [NUnit.Framework.TestCaseAttribute("Automation Tester", "Creating test cases and automate test cases.", "Programming & Tech", "QA", "Selenium", "15/12/2022", "15/12/2023", "9:30:00 AM", "5:00:00 PM", "Selenium", null)]
        public void _1_AddingOfTheShareSkillOnManageListingPage(string title, string description, string categoryId, string subCategoryId, string tagData, string startDate, string endDate, string startTime, string endTime, string skill, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "AddShareSkill"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Title", title);
            argumentsOfScenario.Add("Description", description);
            argumentsOfScenario.Add("CategoryId", categoryId);
            argumentsOfScenario.Add("subCategoryId", subCategoryId);
            argumentsOfScenario.Add("TagData", tagData);
            argumentsOfScenario.Add("StartDate", startDate);
            argumentsOfScenario.Add("EndDate", endDate);
            argumentsOfScenario.Add("StartTime", startTime);
            argumentsOfScenario.Add("EndTime", endTime);
            argumentsOfScenario.Add("Skill", skill);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("1. Adding of the Share Skill on Manage Listing Page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
 testRunner.Given("I login to the Trade Skills portal for Share Skill successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
 testRunner.And("the user clicks on the ShareSkill button for adding", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 7
 testRunner.When(string.Format("the user fills as \'{0}\', \'{1}\', \'{2}\', \'{3}\', \'{4}\', \'{5}\', \'{6}\', \'{7}\', \'{8}\', " +
                            "\'{9}\' the ShareSkill form", title, description, categoryId, subCategoryId, tagData, startDate, endDate, startTime, endTime, skill), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 8
 testRunner.Then("the User should be able to see the skill on the Manage Listing page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("2. Validate of the Share Skill on Manage Listing Page")]
        [NUnit.Framework.CategoryAttribute("ValidateShareSkill")]
        public void _2_ValidateOfTheShareSkillOnManageListingPage()
        {
            string[] tagsOfScenario = new string[] {
                    "ValidateShareSkill"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("2. Validate of the Share Skill on Manage Listing Page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 15
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 16
 testRunner.Given("I login to the Trade Skills portal for Share Skill successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 17
 testRunner.And("the User navigates to the Manage Listing Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.When("the user click on the view button for validation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.Then("the User should able to validate the skill on the Manage Listing page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("3. Edit of the Shared Skill on Manage Listing Page")]
        [NUnit.Framework.CategoryAttribute("EditShareSkill")]
        [NUnit.Framework.TestCaseAttribute("Software Test Engineer", "Manual and Automation Testing", "Business", "Other", "JavaScript", "22/12/2022", "22/12/2023", "10:00:00 AM", "5:30:00 PM", "7", null)]
        public void _3_EditOfTheSharedSkillOnManageListingPage(string title, string description, string categoryId, string subCategoryId, string tagData, string startDate, string endDate, string startTime, string endTime, string creditAmt, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "EditShareSkill"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Title", title);
            argumentsOfScenario.Add("Description", description);
            argumentsOfScenario.Add("CategoryId", categoryId);
            argumentsOfScenario.Add("subCategoryId", subCategoryId);
            argumentsOfScenario.Add("TagData", tagData);
            argumentsOfScenario.Add("StartDate", startDate);
            argumentsOfScenario.Add("EndDate", endDate);
            argumentsOfScenario.Add("StartTime", startTime);
            argumentsOfScenario.Add("EndTime", endTime);
            argumentsOfScenario.Add("CreditAmt", creditAmt);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("3. Edit of the Shared Skill on Manage Listing Page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 22
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 23
 testRunner.Given("I login to the Trade Skills portal for Share Skill successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 24
 testRunner.And("the user clicks on the ShareSkill button for editing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.When(string.Format("the User fills the ShareSkill form as \'{0}\', \'{1}\', \'{2}\', \'{3}\', \'{4}\', \'{5}\', \'" +
                            "{6}\', \'{7}\', \'{8}\', \'{9}\'", title, description, categoryId, subCategoryId, tagData, startDate, endDate, startTime, endTime, creditAmt), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
 testRunner.Then("the User should be able to see the edited Skill on the Manage Listing page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("4. Not Delete of the Shared Skill on Manage Listing Page")]
        [NUnit.Framework.CategoryAttribute("NotDeleteShareSkill")]
        public void _4_NotDeleteOfTheSharedSkillOnManageListingPage()
        {
            string[] tagsOfScenario = new string[] {
                    "NotDeleteShareSkill"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("4. Not Delete of the Shared Skill on Manage Listing Page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 33
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 34
 testRunner.Given("I login to the Trade Skills portal for Share Skill successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 35
 testRunner.And("the User navigates to the Manage Listing Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.When("the User clicks the Delete button of a Shared Skill", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 37
 testRunner.Then("the User should be able to see the deleted Skill on the Manage Listing page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("5. Delete of the Shared Skill on Manage Listing Page")]
        [NUnit.Framework.CategoryAttribute("DeleteShareSkill")]
        public void _5_DeleteOfTheSharedSkillOnManageListingPage()
        {
            string[] tagsOfScenario = new string[] {
                    "DeleteShareSkill"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("5. Delete of the Shared Skill on Manage Listing Page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 40
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 41
 testRunner.Given("I login to the Trade Skills portal for Share Skill successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 42
 testRunner.And("the User navigates to the Manage Listing Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
 testRunner.When("the user clicks on the Delete button of a Shared Skill", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
 testRunner.Then("the User shouldn\'t be able to see the deleted Skill on the Manage Listing page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
