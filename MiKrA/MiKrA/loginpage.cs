using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


public class LoginPage
{
    IWebDriver driver;
    By usernameTxb = By.Name("Username");
    By passwordwriteTxb = By.Name("Password");
    By passwordclick = By.XPath("//*[@id=\"mockpass\"]/td/input");
    By LoginBtn = By.Name("login");

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
    }
    public LoginPage TypeUserName(string user_name)
    {
        driver.FindElement(usernameTxb).SendKeys(user_name);
        return this;
    }
    public LoginPage TypePassword(string sysma)
    {
        driver.FindElement(passwordclick).Click();
        driver.FindElement(passwordwriteTxb).SendKeys(sysma);
        return this;
    }
    public MyPersonalAreaPage ClickOnLogin()
    {
        driver.FindElement(LoginBtn).Click();
        return new MyPersonalAreaPage(driver);
    }
}