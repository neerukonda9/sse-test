using System;
using NUnit.Framework;
using Test.testdata;
using Test.pages;
using System.Collections.Generic;

namespace Test
{
    class MainClass
    {
        static String url = "https://sse.co.uk";

        public static void Main(string[] args)
        {
            bool acceptcookies = true;
            PostCode postCodeCls = new PostCode();
            List<string>  postCodes = postCodeCls.loadCsvFile();
            ViewTariffAndPricesPage viewTariffAndPricesPage = new ViewTariffAndPricesPage();
            Homepage homepage = new Homepage();
            EnterPostcodePage enterPostcodePage = new EnterPostcodePage();
            foreach (string postcode in postCodes)
            {
                homepage.navigateToHomePage(url);
                if (acceptcookies){
                    homepage.acceptCookies();
                    acceptcookies = false;
                }
                
                homepage.clickOnTariffsAndPrices();
                enterPostcodePage.viewTariffs(postcode);
                String actualStandingCharge = viewTariffAndPricesPage.get1YearDirectDebitTariffValue();
                Assert.AreEqual("21.04", actualStandingCharge);
                
            }
            viewTariffAndPricesPage.closeBrowser();


        }
    }
}
