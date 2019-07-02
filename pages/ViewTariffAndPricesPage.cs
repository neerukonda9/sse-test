using System;
using OpenQA.Selenium;
using Test.utils;

namespace Test.pages

{
    public class ViewTariffAndPricesPage
    {
        By oneYearTariffSelector = By.XPath("//div[@id='products']//h2[text()='1 Year Fixed v16 ']/following-sibling::table//th[.='Direct Debit and Paperless Bills']//ancestor::tr/td[2]/span[@class='vat']");

        public String get1YearDirectDebitTariffValue()
        {
            return DriverHelper.getText(oneYearTariffSelector);
        }
        public void closeBrowser()
        {
            DriverHelper.quit();
        }
    }
    
}
