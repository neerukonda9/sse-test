using System;
using OpenQA.Selenium;
using Test.utils;

namespace Test.pages
{
    public class Homepage
    {
        By tariffSelector = By.CssSelector(".s__p.s__p--clear-list.s__p--one-third a[href*='enter-postcode']");
        By acceptCookiesSelector = By.Id("accept-cookie");

        public void navigateToHomePage(String url )
        {
            DriverHelper.NavigateToUlr(url);
        }
        public void acceptCookies()
            
        {
          DriverHelper.ClickOnElement(acceptCookiesSelector);
        }

        public void clickOnTariffsAndPrices()
        {
            DriverHelper.SetText(tariffSelector,"");
            DriverHelper.ClickOnElement(tariffSelector);

        }

        

    }
}
