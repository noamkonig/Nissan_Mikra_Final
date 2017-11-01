using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class MyPersonalAreaPage : PageObject
{
    By car = By.XPath("//img[contains(@src,'rechev.png')]");
    public MyPersonalAreaPage(IWebDriver driver) : base(driver)
    {
    }
    public void ClickOnCar()
    {
        WaitForElement(car,30).Click();
    }
}


