using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class MyPersonalAreaPage
{
    IWebDriver driver;
    By car = By.XPath("//img[contains(@src,'rechev.png')]");
    public MyPersonalAreaPage(IWebDriver driver)
    {
        this.driver = driver;
    }
    public void ClickOnCar()
    {
        driver.FindElement(car).Click();
    }
}


