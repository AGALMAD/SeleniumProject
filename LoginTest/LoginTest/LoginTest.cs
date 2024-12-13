using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LoginTest
{
    public class Tests
    {
        public IWebDriver Driver;


        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://turing-clothes.vercel.app/login");


        }

        [Test]
        public void SuccessfulTest()
        {
            //Locators
            Driver.FindElement(By.Id("email")).SendKeys("ale@gmail.com");
            Driver.FindElement(By.Id("password")).SendKeys("123456");

            Driver.FindElement(By.ClassName("btn-outline-light")).Click();


            Assert.Pass();
        }

        [Test]
        public void NotSuccessfulTest()
        {
            //Locators
            Driver.FindElement(By.Id("email")).SendKeys("notregister@gmail.com");
            Driver.FindElement(By.Id("password")).SendKeys("123456");

            Driver.FindElement(By.ClassName("btn-outline-light")).Click();

            Assert.Pass();
        }
    }
}