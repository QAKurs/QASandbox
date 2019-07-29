using NUnit.Framework;
using QASandbox.Helpers;
using QASandbox.Pages;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace QASandbox.Steps
{
    [Binding]
    public class PlaygroundSteps : Base
    {
        Utilities ut = new Utilities(Driver);

        [Given(@"user is logged in")]
        public void GivenUserIsLoggedIn()
        {
            Homepage hp = new Homepage(Driver);
            ut.ClickOnElement(hp.loginBtn);
            LoginPage lp = new LoginPage(Driver);
            ut.EnterTextInElement(lp.email, TestConstants.Email);
            ut.EnterTextInElement(lp.password, TestConstants.Password);
            ut.ClickOnElement(lp.submit);
        }
        
        [Given(@"playground section is opened")]
        public void GivenPlaygroundSectionIsOpened()
        {
            DashboardPage dp = new DashboardPage(Driver);
            ut.ClickOnElement(dp.playground);
        }
        
        [Given(@"user clicks on People tab")]
        public void GivenUserClicksOnPeopleTab()
        {
            PlaygroundPage pp = new PlaygroundPage(Driver);
            ut.ClickOnElement(pp.peopleTab);
        }
        
        [Given(@"clicks on '(.*)' button")]
        public void GivenClicksOnButton(string btnLabel)
        {
            ut.TextPresentInElement(btnLabel).Click();
        }
        
        [Given(@"enters any value in the Full Name field")]
        public void GivenEntersAnyValueInTheFullNameField()
        {
            NewPersonPage np = new NewPersonPage(Driver);
            ut.EnterTextInElement(np.fullName, TestConstants.FullName);
        }
        
        [Given(@"selects any option under technlogies dropdown menu")]
        public void GivenSelectsAnyOptionUnderDropdownMenu()
        {
            NewPersonPage np = new NewPersonPage(Driver);
            ut.ClickOnElement(np.technology);
            ut.ClickOnElement(np.specTech);
            ut.ClickOnElement(np.technology);
        }

        [Given(@"selects any option under seniority dropdown menu")]
        public void GivenSelectsAnyOptionUnderSeniorityDropdownMenu()
        {
            NewPersonPage np = new NewPersonPage(Driver);
            ut.ClickOnElement(np.seniority);
            ut.ClickOnElement(np.specSen);
        }

        [Given(@"opens first person from the list")]
        public void GivenOpensFirstPersonFromTheList()
        {
            PlaygroundPage pp = new PlaygroundPage(Driver);
            ut.ClickOnElement(pp.person);
        }
        
        [Given(@"switch first and last name's places")]
        public void GivenSwitchFirstAndLastNameSPlaces()
        {
            EditPersonPage np = new EditPersonPage(Driver);
            string fullName = Driver.FindElement(np.fullName).GetAttribute("value");
            string revertedName = ut.ReverseWords(fullName);
            ScenarioContext.Current.Add(TestConstants.RevertedName, revertedName);
            ut.ClearTextFromElement(np.fullName);
            ut.EnterTextInElement(np.fullName, revertedName);
        }

        [Given(@"user clicks on Technology tab")]
        public void GivenUserClicksOnTechnologyTab()
        {
            PlaygroundPage pp = new PlaygroundPage(Driver);
            ut.ClickOnElement(pp.techTab);
        }
        [Given(@"user clicks on Seniority tab")]
        public void GivenUserClicksOnSeniorityTab()
        {
            PlaygroundPage pp = new PlaygroundPage(Driver);
            ut.ClickOnElement(pp.senTab);
        }

        [Given(@"enters any value in the Technology Title field")]
        public void GivenEntersAnyValueInTheTechnologyTitleField()
        {
            NewPersonPage np = new NewPersonPage(Driver);
            string randomString = "TECH-" + ut.GenerateRandomName();
            ut.EnterTextInElement(np.techName, randomString);
            ScenarioContext.Current.Add(TestConstants.RevertedName, randomString);
        }

        [Given(@"enters any value in the Seniority Title field")]
        public void GivenEntersAnyValueInTheSeniorityTitleField()
        {
            NewPersonPage np = new NewPersonPage(Driver);
            string randomString = "SEN-" + ut.GenerateRandomName();
            ut.EnterTextInElement(np.seniorityName, randomString);
            ScenarioContext.Current.Add(TestConstants.RevertedName, randomString);
        }

        [When(@"user clicks on Submit button")]
        public void WhenUserClicksOnButton()
        {
            NewPersonPage np = new NewPersonPage(Driver);
            ut.ClickOnElement(np.submitBtn);
        }

        [When(@"user clicks on Submit button to save changes")]
        public void WhenUserClicksOnButtonToSaveChanges()
        {
            EditPersonPage np = new EditPersonPage(Driver);
            ut.ClickOnElement(np.submitBtn);
        }


        [When(@"user clicks on Delete icon")]
        public void WhenUserClicksOnDeleteIcon()
        {
            EditPersonPage np = new EditPersonPage(Driver);
            //ut.ClickOnElement(np.deleteIcon);
        }
        
        [When(@"confirms deletion by clicking on Delete button on the pop-up")]
        public void WhenConfirmsDeletionByClickingOnButtonOnThePop_Up()
        {
            EditPersonPage np = new EditPersonPage(Driver);
            //ut.ClickOnElement(np.deleteBtn);
        }
        
        [Then(@"person is created")]
        public void ThenPersonIsCreated()
        {
            PlaygroundPage pp = new PlaygroundPage(Driver);
            string name = ut.ReturnTextFromElement(pp.person);
            Assert.That(TestConstants.FullName, Is.EqualTo(name), "Required person is not on the list");
        }

        [Then(@"technology is created")]
        public void ThenTechnologyIsCreated()
        {
            PlaygroundPage pp = new PlaygroundPage(Driver);
            string name = ut.ReturnTextFromElement(pp.person);
            string storedTech = ScenarioContext.Current.Get<string>(TestConstants.RevertedName);
            Assert.That(storedTech, Is.EqualTo(name), "Created technology is not on the list");
        }

        [Then(@"seniority is created")]
        public void ThenSeniorityIsCreated()
        {
            PlaygroundPage pp = new PlaygroundPage(Driver);
            string name = ut.ReturnTextFromElement(pp.person);
            string storedSen = ScenarioContext.Current.Get<string>(TestConstants.RevertedName);
            Assert.That(storedSen, Is.EqualTo(name), "Created seniority is not on the list");
        }

        [Then(@"updated full name with switched first and last name's places is displayed in the people list")]
        public void ThenUpdatedFullNameWithSwitchedFirstAndLastNameSPlacesIsDisplayedInThePeopleList()
        {
            PlaygroundPage pp = new PlaygroundPage(Driver);
            string name = ut.ReturnTextFromElement(pp.person);
            string storedName = ScenarioContext.Current.Get<string>(TestConstants.RevertedName);
            Assert.That(storedName, Is.EqualTo(name), "First and last name are not properly switched");
        }

        [Then(@"user is removed from the system and people list is empty with '(.*)' message")]
        public void ThenUserIsRemovedFromTheSystemAndPeopleListIsEmptyWithMessage(string message)
        {
            //PlaygroundPage pp = new PlaygroundPage(Driver);
            //string text = ut.ReturnTextFromElement(pp.defaultMsg);
            //Assert.That(text, Is.EqualTo(message), "User is not removed from the list");
        }

    }
}
