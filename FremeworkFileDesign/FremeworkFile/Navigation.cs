using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FremeworkFile
{
    internal class Navigation
    {
        #region
        By SeachElement = By.XPath("//a[text()='Company']");
        #endregion
        IWebDriver driver;
        public Navigation(IWebDriver driver)
        { 
            this.driver = driver;
        }
        public void Lauching()
        {
            driver.Navigate().GoToUrl("https://www.orangehrm.com/");
            driver.Manage().Window.Maximize();
        }
        public void ClickOnSeachTab()
        {
            IWebElement searchElement=driver.FindElement(SeachElement);
            searchElement.Click();
        }
    }
}
