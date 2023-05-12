using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trendyol.CaseStudy.Automation.Data.PageObjects
{
    public class HomePageObjects
    {
        private static IPage _page;

        public HomePageObjects(IPage page) => _page = page;

        public ILocator HomePageButton => _page.Locator("xpath=//a[@id='logo']");
        public ILocator SearchInput => _page.Locator("xpath=//input[@data-testid='suggestion']");
        public ILocator SearchButton => _page.Locator("xpath=//i[@data-testid='search-icon']");
        public ILocator LoginButton => _page.Locator("xpath=//p[text()='Giriş Yap']");

    }
}
