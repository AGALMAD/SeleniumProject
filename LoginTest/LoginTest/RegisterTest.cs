using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginTest
{
    internal class RegisterTest
    {
        public IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://turing-clothes.vercel.app/register");


        }


    }
}
