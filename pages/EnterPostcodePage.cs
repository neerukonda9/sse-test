using System;
using OpenQA.Selenium;
using Test.utils;

namespace Test.pages
{
    public class EnterPostcodePage
    {
        By postCodeSelector = By.Id("PostCode");
        By confirmPostcodeSelector = By.Id("confirmPostcode");

        

        public void viewTariffs(String postCode)
        {
            DriverHelper.SetText(postCodeSelector,postCode);
            DriverHelper.ClickOnElement(confirmPostcodeSelector);

        }
    }
}
