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
            //explicitly wait
            //page factory
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            driver.Navigate().GoToUrl("http://www.yad2.co.il/");
            driver.Manage().Window.Maximize();
            LoginPage loginPage = new LoginPage(driver);
            loginPage.TypeUserName("noamkonig@gmail.com");
            loginPage.TypePassword("noam4166");
            loginPage.ClickOnLogin().ClickOnCar();
            driver.FindElements(By.XPath("//div[@id='personalAreaFeed']//tr[@data-orderid]"))[0].Click();
            driver.FindElement(By.XPath(" //*[@id='bounceRatingOrderBtn']/span")).Click();
            Thread.Sleep(2500);
            
        }
       
    }

}
