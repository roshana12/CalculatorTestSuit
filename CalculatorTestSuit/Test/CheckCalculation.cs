
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTestSuit.Test
{
    public class CheckCalculation
    {
       
       [Test]
        public void CheckAddition()
        {
            //This is for addition
            var driver = new ChromeDriver();
            driver.Url = "https://nuix.github.io/SDET/senior-sdet/productionCalc/index.html";
            var two = driver.FindElementByXPath("/html/body/div[2]/div[2]/div[3]/input[2]");
            var five = driver.FindElementByXPath("/html/body/div[2]/div[2]/div[2]/input[2]");
            var plus = driver.FindElementByXPath("/html/body/div[2]/div[3]/input[2]");
            for(int i=1;i<=5;i++)
            {
                two.Click();
                five.Click();
                plus.Click();
            }
            var result = driver.FindElementByXPath("/html/body/div[1]/div");
            Assert.That(result.Text.Contains("125"), "Addition was false");
            driver.Close();
        }
        [Test]
        public void CheckSubstraction()
        {
            //This is for substraction
            var driver = new ChromeDriver();
            driver.Url = "https://nuix.github.io/SDET/senior-sdet/productionCalc/index.html";
            var two = driver.FindElementByXPath("/html/body/div[2]/div[2]/div[3]/input[2]");
            var five = driver.FindElementByXPath("/html/body/div[2]/div[2]/div[2]/input[2]");
            var minus = driver.FindElementByXPath("/html/body/div[2]/div[3]/input[1]");
            for (int i = 1; i <= 5; i++)
            {
                two.Click();
                five.Click();
                minus.Click();
            }
            var result = driver.FindElementByXPath("/html/body/div[1]/div");
            Assert.That(result.Text.Contains("-75"), "Substraction was false");
            driver.Close();
        }
        [Test]
        public void CheckMultiply()
        {
            //This is for multiplication
            var driver = new ChromeDriver();
            driver.Url = "https://nuix.github.io/SDET/senior-sdet/productionCalc/index.html";
            var two = driver.FindElementByXPath("/html/body/div[2]/div[2]/div[3]/input[2]");
            var five = driver.FindElementByXPath("/html/body/div[2]/div[2]/div[2]/input[2]");
            var mult = driver.FindElementByXPath("/html/body/div[2]/div[1]/input[3]");
            for (int i = 1; i <= 5; i++)
            {
                two.Click();
                five.Click();
                mult.Click();
            }
            var result = driver.FindElementByXPath("/html/body/div[1]/div");
            Assert.That(result.Text.Contains("9765625"), "Either Multiplication was false or result is bounded");
            driver.Close();
        }
        [Test]
        public void CheckDivide()
        {
            //For division
            var driver = new ChromeDriver();
            driver.Url = "https://nuix.github.io/SDET/senior-sdet/productionCalc/index.html";
            var two = driver.FindElementByXPath("/html/body/div[2]/div[2]/div[3]/input[2]");
            var six = driver.FindElementByXPath("/html/body/div[2]/div[2]/div[2]/input[3]");
            var div = driver.FindElementByXPath("/html/body/div[2]/div[1]/input[2]");
            six.Click();
            div.Click();
            two.Click();
            var equals = driver.FindElementByXPath("/html/body/div[2]/div[3]/input[3]");
            equals.Click();
            var result = driver.FindElementByXPath("/html/body/div[1]/div");
            Assert.That(result.Text.Contains("3"), "Divison was false");
            driver.Close();
        }
        [Test]
        public void DecimalCheck()
        {
            //For decimal check
            var driver = new ChromeDriver();
            driver.Url = "https://nuix.github.io/SDET/senior-sdet/productionCalc/index.html";
            var two = driver.FindElementByXPath("/html/body/div[2]/div[2]/div[3]/input[2]");
            var five = driver.FindElementByXPath("/html/body/div[2]/div[2]/div[2]/input[2]");
            var div = driver.FindElementByXPath("/html/body/div[2]/div[1]/input[2]");
            five.Click();
            div.Click();
            two.Click();
            var equals = driver.FindElementByXPath("/html/body/div[2]/div[3]/input[3]");
            equals.Click();
            var result = driver.FindElementByXPath("/html/body/div[1]/div");
            Assert.That(result.Text.Contains("2.5"), "Divison was false of decimal");
            var ce = driver.FindElementByXPath("/html/body/div[2]/div[1]/input[1]");
            ce.Click();
            var point = driver.FindElementByXPath("/html/body/div[2]/div[2]/div[4]/input[2]");
            var mul = driver.FindElementByXPath("/html/body/div[2]/div[1]/input[3]");
            two.Click();
            point.Click();
            five.Click();
            mul.Click();
            two.Click();
            point.Click();
            five.Click();
            equals.Click();
            result = driver.FindElementByXPath("/html/body/div[1]/div");
            Assert.That(result.Text.Contains("6.25"), "Multiplication was false of decimal");
            driver.Close();
        }
        [Test]
        public void DivisibleByZero()
        {
            //Error check
            var driver = new ChromeDriver();
            driver.Url = "https://nuix.github.io/SDET/senior-sdet/productionCalc/index.html";
            var two = driver.FindElementByXPath("/html/body/div[2]/div[2]/div[3]/input[2]");
            var zero = driver.FindElementByXPath("/html/body/div[2]/div[2]/div[4]/input[1]");
            var div= driver.FindElementByXPath("/html/body/div[2]/div[1]/input[2]");
            two.Click();
            div.Click();
            zero.Click();
            var equals = driver.FindElementByXPath("/html/body/div[2]/div[3]/input[3]");
            equals.Click();
            var result = driver.FindElementByXPath("/html/body/div[1]/div");
            Assert.That(result.Text.Contains("Error"), "Divisible by zero exception is there");
            driver.Close();




        }
    }
}
