using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.CaseStudy.Automation.Data.PageObjects;

namespace Trendyol.CaseStudy.Automation.Business.Operations
{
    public class HomePage
    {
        public readonly HomePageObjects homePage;
        public IPage page;
        public HomePage(IPage page)
        {
            this.page = page;
            homePage = new HomePageObjects(page);
        }

        public async Task ClickLoginButton()
        {
            await homePage.HomePageButton.ClickAsync();
            await homePage.LoginButton.ClickAsync();
        }

    }
}
