using System;
using Reqnroll;

namespace FremeworkFile
{
    [Binding]
    public class ArthematicFeatureStepDefinitions
    {
        SubLogic sub=new SubLogic();
        int subAns;
        [Given("First number is {int}")]
        public void GivenFirstNumberIs(int firstNumber)
        {
            sub.SetFirstNumebr(firstNumber);
        }

        [Given("Second number is {int}")]
        public void GivenSecondNumberIs(int SecondNumber)
        {
            sub.SetSecondNumebr(SecondNumber);
        }

        [When("we perform subtraction")]
        public void WhenWePerformSubtraction()
        {
            subAns=sub.Subtraction();
        }

        [Then("Result should be {int}")]
        public void ThenResultShouldBe(int Result)
        {
            Assert.AreEqual(Result, subAns);
        }
    }
}
