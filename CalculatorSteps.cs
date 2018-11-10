using System;
using TechTalk.SpecFlow;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ejercicio
{
    [Binding]
    public class CalculatorSteps
    {
        private int result;
        private Calculator.Calculator calculator = new Calculator.Calculator();
        [Given(@"I have entered (.*) into the calculator to add")]
        public void GivenIHaveEnteredIntoTheCalculatorToAdd(int term1)
        {
            calculator.FirstNumber = term1;
        }
        
        [Given(@"I have also entered (.*) into the calculator to add")]
        public void GivenIHaveAlsoEnteredIntoTheCalculatorToAdd(int term2)
        {
            calculator.SecondNumber = term2;
        }
        
        [Given(@"I have entered (.*) into the calculator to be substracted")]
        public void GivenIHaveEnteredIntoTheCalculatorToBeSubstracted(int term1)
        {
            calculator.FirstNumber = term1;
        }
        
        [Given(@"I have also entered (.*) into the calculator to substract")]
        public void GivenIHaveAlsoEnteredIntoTheCalculatorToSubstract(int term2)
        {
            calculator.SecondNumber = term2;
        }
        
        [Given(@"I have entered (.*) into the calculator to multiply")]
        public void GivenIHaveEnteredIntoTheCalculatorToMultiply(int term1)
        {
            calculator.FirstNumber = term1;
        }
        
        [Given(@"I have also entered (.*) into the calculator to multiply")]
        public void GivenIHaveAlsoEnteredIntoTheCalculatorToMultiply(int term2)
        {
            calculator.SecondNumber = term2;
        }
        
        [Given(@"I have entered (.*) into the calculator to be divided")]
        public void GivenIHaveEnteredIntoTheCalculatorToBeDivided(int term1)
        {
            calculator.FirstNumber = term1;
        }
        
        [Given(@"I have also entered (.*) into the calculator to divide")]
        public void GivenIHaveAlsoEnteredIntoTheCalculatorToDivide(int term2)
        {
            calculator.SecondNumber = term2;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = calculator.Add();
        }
        
        [When(@"I press substract")]
        public void WhenIPressSubstract()
        {
            result = calculator.Substract();
        }
        
        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            result = calculator.Multiply();
        }
        
        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            result = calculator.Divide();
        }
        
        [Then(@"the result should be (.*) on the screen when adding")]
        public void ThenTheResultShouldBeOnTheScreenWhenAdding(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
        
        [Then(@"the result should be (.*) on the screen when substracting")]
        public void ThenTheResultShouldBeOnTheScreenWhenSubstracting(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
        
        [Then(@"the result should be (.*) on the screen when multiplying")]
        public void ThenTheResultShouldBeOnTheScreenWhenMultiplying(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
        
        [Then(@"the result should be (.*) on the screen when dividing")]
        public void ThenTheResultShouldBeOnTheScreenWhenDividing(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
    }
}
