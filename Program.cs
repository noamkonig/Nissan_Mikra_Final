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
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("http://www.yad2.co.il/");
            loginpage validation = new loginpage(driver);
            validation.typeusername("noamkonig@gmail.com");
            validation.typepassword("noam4166");
            validation.clickonlogin();
            driver.FindElement(By.XPath(" //img[contains(@src,'rechev.png')]")).Click();
            driver.FindElement(By.XPath(" //div[contains(text(),'השרון')]")).Click();
            driver.FindElement(By.XPath(" //*[@id='bounceRatingOrderBtn']/span")).Click();
            Thread.Sleep(2500);
            
        }
       
    }

}
