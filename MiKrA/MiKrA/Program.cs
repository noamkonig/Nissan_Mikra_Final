using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace yad2_jump
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebElement emailfield;
            IWebElement passfield;
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("http://www.yad2.co.il/");
            emailfield = driver.FindElement(By.Name("Username"));
            emailfield.SendKeys("noamkonig@gmail.com");
            driver.FindElement(By.XPath("//*[@id=\"mockpass\"]/td/input")).Click();
            driver.FindElement(By.Name("Password")).SendKeys("noam4166");
            driver.FindElement(By.Name("login")).Click();
            driver.FindElement(By.XPath(" //img[contains(@src,'rechev.png')]")).Click();
            driver.FindElement(By.XPath(" //*[@id='feed']/tbody/tr[2]/td[1]/div")).Click();
            driver.FindElement(By.XPath(" //*[@id='bounceRatingOrderBtn']/span")).Click();
            Thread.Sleep(10000);
            driver.Quit();
        }
    }
}
