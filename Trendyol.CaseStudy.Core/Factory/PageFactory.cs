using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.CaseStudy.Automation.Business.Operations;

namespace Trendyol.CaseStudy.Core.Factory
{
    public class PageFactory
    {
        public HomePage homePage;
        public LoginPage loginPage;

        public PageFactory(IPage page)
        {
            homePage = new HomePage(page);
            loginPage = new LoginPage(page);
        }
    }
}
