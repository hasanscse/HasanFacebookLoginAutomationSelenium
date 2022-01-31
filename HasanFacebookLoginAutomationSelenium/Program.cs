using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeleniumFirstHasanFacebookLoginAutomationSelenium
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver(@"F:\");
            driver.Navigate().GoToUrl("https://www.facebook.com/");

            driver.Manage().Window.Maximize();


            driver.FindElement(By.Id("email")).SendKeys("hasan.assignment@gmail.com");
            System.Threading.Thread.Sleep(4000);
            driver.FindElement(By.Id("pass")).SendKeys("123456" + Keys.Enter);
            System.Threading.Thread.Sleep(4000);

        }
    }
}

