using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


    public class loginpage
    {
        IWebDriver driver;
        By username = By.Name("Username");
        By passwordwrite = By.Name("Password");
        By passwordclick = By.XPath("//*[@id=\"mockpass\"]/td/input");
        By Loginclick = By.Name("login");

        public loginpage (IWebDriver driver)
        {
            this.driver = driver;
        }
        public void typeusername ()
        {
            driver.FindElement(username).SendKeys("noamkonig@gmail.com");
        }
        public void typepassword ()
        {
            driver.FindElement(passwordclick).Click();
            driver.FindElement(passwordwrite).SendKeys("noam4166");
        }
        public void clickonlogin ()
        {
            driver.FindElement(Loginclick).Click();
        }
    }

