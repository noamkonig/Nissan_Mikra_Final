
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

public class PageObject
{
    public PageObject(IWebDriver driver)
    {
        this.driver = driver;
    }

    protected IWebDriver driver;
    protected IWebElement WaitForElement(By by,int numOfSecondsToWait)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(numOfSecondsToWait));
        wait.IgnoreExceptionTypes(typeof(Exception));
        return wait.Until(ExpectedConditions.ElementIsVisible(by));
    }
}