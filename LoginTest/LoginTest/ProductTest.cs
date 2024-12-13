using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginTest
{
    internal class ProductTest
    {
        public IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();

        }



        [Test]
        public void SuccessfulProductTest()
        {

            Driver.Navigate().GoToUrl("https://turing-clothes.vercel.app/product-details/1");

            //Locators



            Assert.Pass();
        }


        [Test]
        public void ProductNotFoundTest()
        {
            //Locators
           


            Assert.Pass();
        }







    }
}
