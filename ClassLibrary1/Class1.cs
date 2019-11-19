using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class Test1
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.katalon.com/";
            verificationErrors = new StringBuilder(); 
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void LocalhostTestInputFordMustang2012ReturnsOutputJDPowerCarInformationPage()
        {
            driver.Navigate().GoToUrl("http://localhost/");
            driver.FindElement(By.LinkText("Assignment/")).Click();
            driver.FindElement(By.LinkText("Home.html")).Click();
            driver.FindElement(By.LinkText("New")).Click();
            driver.FindElement(By.Id("sellerName")).Click();
            driver.FindElement(By.Id("sellerName")).Clear();
            driver.FindElement(By.Id("sellerName")).SendKeys("abcd");
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("abcd");
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("abcd");
            driver.FindElement(By.Id("mobileNumber")).Clear();
            driver.FindElement(By.Id("mobileNumber")).SendKeys("123-123-1231");
            driver.FindElement(By.Id("emailAddress")).Clear();
            driver.FindElement(By.Id("emailAddress")).SendKeys("abcd@gmail.com");
            driver.FindElement(By.Id("vehicalMake")).Clear();
            driver.FindElement(By.Id("vehicalMake")).SendKeys("ford");
            driver.FindElement(By.Id("vehicalModel")).Clear();
            driver.FindElement(By.Id("vehicalModel")).SendKeys("mustang");
            driver.FindElement(By.Id("vehicalYear")).Clear();
            driver.FindElement(By.Id("vehicalYear")).SendKeys("2012");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehical Year'])[1]/following::input[2]")).Click();
            driver.FindElement(By.Id("url")).Click();
            Assert.AreEqual("$31,494", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='/100'])[1]/following::p[2]")).Text);
        }

        [Test]
        public void LocalhostTestInputInvalidCarDataReturnsInternalServerErrorAsOutput()
        {
            driver.Navigate().GoToUrl("http://localhost/");
            driver.FindElement(By.LinkText("Assignment/")).Click();
            driver.FindElement(By.LinkText("Home.html")).Click();
            driver.FindElement(By.LinkText("New")).Click();
            driver.FindElement(By.Id("sellerName")).Click();
            driver.FindElement(By.Id("sellerName")).Clear();
            driver.FindElement(By.Id("sellerName")).SendKeys("abcd");
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("abcd");
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("abcd");
            driver.FindElement(By.Id("mobileNumber")).Clear();
            driver.FindElement(By.Id("mobileNumber")).SendKeys("123-123-1231");
            driver.FindElement(By.Id("emailAddress")).Clear();
            driver.FindElement(By.Id("emailAddress")).SendKeys("abcd@gmail.com");
            driver.FindElement(By.Id("vehicalMake")).Clear();
            driver.FindElement(By.Id("vehicalMake")).SendKeys("abcd");
            driver.FindElement(By.Id("vehicalModel")).Click();
            driver.FindElement(By.Id("vehicalModel")).Clear();
            driver.FindElement(By.Id("vehicalModel")).SendKeys("ABCD");
            driver.FindElement(By.Id("vehicalYear")).Clear();
            driver.FindElement(By.Id("vehicalYear")).SendKeys("2000");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehical Year'])[1]/following::input[2]")).Click();
            driver.FindElement(By.Id("url")).Click();
            Assert.AreEqual("Oops! Looks like we’re having engine trouble.", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Close navigation'])[1]/following::h1[1]")).Text);
        }

        [Test]
        public void LocalhostTestInputSearchButtonClickReturnsAllSavedDataAsOutput()
        {
            driver.Navigate().GoToUrl("http://localhost/");
            driver.FindElement(By.LinkText("Assignment/")).Click();
            driver.FindElement(By.LinkText("Home.html")).Click();
            driver.FindElement(By.LinkText("Search")).Click();
            Assert.AreEqual("Address", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Seller Name'])[1]/following::th[1]")).Text);
        }

        [Test]
        public void LocalhostTestInputJeepWrangler2019ReturnsOutputJDPowerCarInformationPage()
        {
            driver.Navigate().GoToUrl("http://localhost/");
            driver.FindElement(By.LinkText("Assignment/")).Click();
            driver.FindElement(By.LinkText("Home.html")).Click();
            driver.FindElement(By.LinkText("New")).Click();
            driver.FindElement(By.Id("sellerName")).Click();
            driver.FindElement(By.Id("sellerName")).Clear();
            driver.FindElement(By.Id("sellerName")).SendKeys("xyyz");
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("xyzz");
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("xyzz");
            driver.FindElement(By.Id("mobileNumber")).Clear();
            driver.FindElement(By.Id("mobileNumber")).SendKeys("(123)123-1231");
            driver.FindElement(By.Id("emailAddress")).Clear();
            driver.FindElement(By.Id("emailAddress")).SendKeys("ssss@gmail.com");
            driver.FindElement(By.Id("vehicalMake")).Clear();
            driver.FindElement(By.Id("vehicalMake")).SendKeys("Jeep");
            driver.FindElement(By.Id("vehicalModel")).Clear();
            driver.FindElement(By.Id("vehicalModel")).SendKeys("Wrangler");
            driver.FindElement(By.Id("vehicalYear")).Clear();
            driver.FindElement(By.Id("vehicalYear")).SendKeys("2019");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehical Year'])[1]/following::input[2]")).Click();
            driver.FindElement(By.Id("url")).Click();
            Assert.AreEqual("13", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='/100'])[1]/following::p[4]")).Text);
        }


        [Test]
        public void LocalhostTestInputSubmitButtonClickReturnsEnteredInformationAsOutput()
        {
            driver.Navigate().GoToUrl("http://localhost/");
            driver.FindElement(By.LinkText("Assignment/")).Click();
            driver.FindElement(By.LinkText("Home.html")).Click();
            driver.FindElement(By.LinkText("New")).Click();
            driver.FindElement(By.Id("sellerName")).Click();
            driver.FindElement(By.Id("sellerName")).Clear();
            driver.FindElement(By.Id("sellerName")).SendKeys("abbc");
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("abbc");
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("abbc");
            driver.FindElement(By.Id("mobileNumber")).Clear();
            driver.FindElement(By.Id("mobileNumber")).SendKeys("123-123-1231");
            driver.FindElement(By.Id("emailAddress")).Clear();
            driver.FindElement(By.Id("emailAddress")).SendKeys("abbc@gmail.com");
            driver.FindElement(By.Id("vehicalMake")).Clear();
            driver.FindElement(By.Id("vehicalMake")).SendKeys("Ford");
            driver.FindElement(By.Id("vehicalModel")).Clear();
            driver.FindElement(By.Id("vehicalModel")).SendKeys("Edge");
            driver.FindElement(By.Id("vehicalYear")).Clear();
            driver.FindElement(By.Id("vehicalYear")).SendKeys("2018");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehical Year'])[1]/following::input[2]")).Click();
            Assert.AreEqual("City", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Address'])[1]/following::th[1]")).Text);
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
