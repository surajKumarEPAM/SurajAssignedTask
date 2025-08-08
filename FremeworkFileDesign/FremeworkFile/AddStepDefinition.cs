using Reqnroll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FremeworkFile
{
    [Binding]
    internal class AddStepDefinition
    {
        AdditionBuisness ab = new AdditionBuisness();
        int sum;
        [Given("First numebr is {int}")]
        public void GivenFirstNumebrIs(int firstNumeber)
        {
            ab.SetFirstNumebr(firstNumeber);
        }

        [Given("Second numebr is {int}")]
        public void GivenSecondNumebrIs(int secondNumber)
        {
            ab.SetSecondNumebr(secondNumber);
        }

        [When("We perform additon")]
        public void WhenWePerformAdditon()
        {
            sum=ab.Additon();
        }

        [Then("Resule should be {int}")]
        public void ThenResuleShouldBe(int result)
        {
            Assert.AreEqual(result, sum);
        }

    }
}
