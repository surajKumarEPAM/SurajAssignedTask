using Reqnroll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FremeworkFile
{
    [Binding]
    internal class StepDef
    {
        DriverContext _driverContext;
        
        Navigation navigation;
        public StepDef(DriverContext drivercontext)
        {
            _driverContext = drivercontext;
            navigation=new Navigation(_driverContext.driver);
        }


        [Given("Browser is launched")]
        public void GivenBrowserIsLaunched()
        {
            navigation.Lauching();
        }

        [When("Click on the Search")]
        public void WhenClickOnTheSearch()
        {
           navigation.ClickOnSeachTab();
        }

        [Then("Search page will be loaded")]
        public void ThenSearchPageWillBeLoaded()
        {
            
        }

    }
}
