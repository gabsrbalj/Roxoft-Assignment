using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace DemositeSpecflow.StepBindings
{
    [Binding]
    public class DemositeFeatureSteps 
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"I have navigated to Demosite")]
        public void GivenIHaveNavigatedToDemosite()
        {
            driver.Navigate().GoToUrl("https://demosite.executeautomation.com/");
        }
        
        [Given(@"I have entered username")]
        public void GivenIHaveEnteredUsername()
        {
            IWebElement username = driver.FindElement(By.Name("UserName"));
            username.SendKeys("MyUsername");
        }
        
        [Given(@"I have entered password")]
        public void GivenIHaveEnteredPassword()
        {
            IWebElement password = driver.FindElement(By.Name("Password"));
            password.SendKeys("MyPassword");
        }
        
        [When(@"I press login button")]
        public void WhenIPressLoginButton()
        {
            IWebElement btnLogin = driver.FindElement(By.Name("Login"));
            btnLogin.Submit();
        }
        
        [Then(@"I should be navigated to index page")]
        public void ThenIShouldBeNavigatedToIndexPage()
        {
            Thread.Sleep(3000);
            Assert.IsTrue(driver.Url.ToLower().Contains("index"));
        }

        [When(@"I choose female button")]
        public void WhenIChooseFemaleButton()
        {
            driver.FindElement(By.Name("Female")).Click();
        }

        [When(@"I press save")]
        public void WhenIPressSave()
        {
            driver.FindElement(By.Name("Save")).Click();
        }

        [Then(@"I have entered inital")]
        public void ThenIHaveEnteredInital()
        {
            driver.FindElement(By.Name("Initial")).SendKeys("GS");
        }

        [Then(@"I have entered first name")]
        public void ThenIHaveEnteredFirstName()
        {
            driver.FindElement(By.Name("FirstName")).SendKeys("Gabrijela");
        }

        [Then(@"I have entered middle name")]
        public void ThenIHaveEnteredMiddleName()
        {
            driver.FindElement(By.Name("MiddleName")).SendKeys("Gabi");
        }

        [Then(@"I should stay on index page")]
        public void ThenIShouldStayOnIndexPage()
        {
            Thread.Sleep(3000);
            Assert.IsTrue(driver.Url.ToLower().Contains("index"));
        }
    }
}
