﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace QASandbox.Playground
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Playground")]
    public partial class PlaygroundFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Playground.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Playground", "\tIn order to work with People section\r\n\tAs a user\r\n\tI want to be able to create, " +
                    "edit and delete a person", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line 7
 testRunner.Given("user is logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And("playground section is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Person can be created")]
        [NUnit.Framework.CategoryAttribute("Playground")]
        public virtual void PersonCanBeCreated()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Person can be created", new string[] {
                        "Playground"});
#line 11
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 12
 testRunner.Given("user clicks on People tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
  testRunner.And("clicks on \'CREATE PERSON\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
  testRunner.And("enters any value in the Full Name field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
  testRunner.And("selects any option under technlogies dropdown menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
  testRunner.And("selects any option under seniority dropdown menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.When("user clicks on Submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then("person is created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Person\'s first and last name can switch places")]
        [NUnit.Framework.CategoryAttribute("Playground")]
        public virtual void PersonsFirstAndLastNameCanSwitchPlaces()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Person\'s first and last name can switch places", new string[] {
                        "Playground"});
#line 21
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 22
 testRunner.Given("user clicks on People tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
  testRunner.And("opens first person from the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
  testRunner.And("switch first and last name\'s places", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.When("user clicks on Submit button to save changes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.Then("updated full name with switched first and last name\'s places is displayed in the " +
                    "people list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("People can be removed from the list")]
        [NUnit.Framework.CategoryAttribute("Playground")]
        public virtual void PeopleCanBeRemovedFromTheList()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("People can be removed from the list", new string[] {
                        "Playground"});
#line 29
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 30
 testRunner.Given("user clicks on People tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 31
  testRunner.And("opens first person from the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.When("user clicks on Delete icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
  testRunner.And("confirms deletion by clicking on Delete button on the pop-up", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.Then("user is removed from the system and people list is empty with \'No people added ye" +
                    "t. Click on CREATE PERSON to add some.\' message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Technology can be created")]
        [NUnit.Framework.CategoryAttribute("Playground")]
        public virtual void TechnologyCanBeCreated()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Technology can be created", new string[] {
                        "Playground"});
#line 37
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 38
 testRunner.Given("user clicks on Technology tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 39
  testRunner.And("clicks on \'CREATE TECHNOLOGY\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
  testRunner.And("enters any value in the Technology Title field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.When("user clicks on Submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
 testRunner.Then("technology is created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Seniority can be created")]
        [NUnit.Framework.CategoryAttribute("Playground")]
        public virtual void SeniorityCanBeCreated()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Seniority can be created", new string[] {
                        "Playground"});
#line 45
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 46
 testRunner.Given("user clicks on Seniority tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 47
  testRunner.And("clicks on \'CREATE SENIORITY\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
  testRunner.And("enters any value in the Seniority Title field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.When("user clicks on Submit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.Then("seniority is created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
