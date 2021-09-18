using System;
using FluentAssertions;
using Xunit;

namespace StringCalculator.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData("", 0)]     // empty string return 0
        [InlineData("1", 1)]    // string 1 return 1
        [InlineData("1,2", 3)]  // string 1,2 return their sum
        public void Add_AddsUpToTwoNumber_WhenStringIsValid(string calculation, int random_value) // sum of the number added in random_value
        {
            // we made a calculator class 
            var System_On_The_Test = new Calculator(); 
            
            // using Add method 
            var result = System_On_The_Test.Add(calculation);

            // result should be same as awaited_value
            result.Should().Be(awated_value);
        }
        
       
    }
}