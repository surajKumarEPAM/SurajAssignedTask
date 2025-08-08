using OpenQA.Selenium.Chrome;
using Reqnroll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FremeworkFile
{
    [Binding]
    internal class BrowserSetUp
    {
        DriverContext _driverContext;
        public BrowserSetUp(DriverContext driverContext)
        {
            _driverContext = driverContext;
        }
        //[BeforeScenario]
        public void SetBrowser()
        {
            string currentFolder=AppContext.BaseDirectory;
            string Driverpath = Path.GetFullPath(currentFolder + @"..\..\..\Driver");
            //string Driverpath = Path.GetFullPath(Path.Combine(currentFolder + @"..\..\..\Driver"));
            _driverContext.driver=new ChromeDriver(Driverpath);

        }
        //[AfterScenario] 
        public void CloseDriver()
        {
            _driverContext.driver.Close();
        }
    }
}
