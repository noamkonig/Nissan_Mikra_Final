using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


public class LoginPage : PageObject
{
    By usernameTxb = By.Name("Username");
    By passwordwriteTxb = By.Name("Password");
    By passwordclick = By.XPath("//*[@id=\"mockpass\"]/td/input");
    By LoginBtn = By.Name("login");

    public LoginPage(IWebDriver driver) : base(driver)
    {
    }
    public LoginPage TypeUserName(string user_name)
    {
        //stale element reference exception 
        WaitForElement(usernameTxb,30).SendKeys(user_name);
        return this;
    }
    public LoginPage TypePassword(string sysma)
    {
        WaitForElement(passwordclick,30).Click();
        WaitForElement(passwordwriteTxb,30).SendKeys(sysma);
        return this;
    }
    public MyPersonalAreaPage ClickOnLogin()
    {
        WaitForElement(LoginBtn,30).Click();
        return new MyPersonalAreaPage(driver);
    }
}