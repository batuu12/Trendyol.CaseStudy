using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trendyol.CaseStudy.Automation.Data.PageObjects
{
    public class LoginPageObjects
    {
        private static IPage _page;

        public LoginPageObjects(IPage page)
        {
            _page = page;
        }

        public ILocator EmailInput => _page.Locator("xpath=//input[@id='login-email']");
        public ILocator PasswordInput => _page.Locator("xpath=//input[@id='login-password-input']");
        public ILocator LoginButton => _page.Locator("xpath=//button[@type='submit']");
    }
}
