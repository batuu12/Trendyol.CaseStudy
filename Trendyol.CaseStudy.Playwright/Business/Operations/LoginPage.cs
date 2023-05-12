using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.CaseStudy.Automation.Data.PageObjects;

namespace Trendyol.CaseStudy.Automation.Business.Operations
{
    public class LoginPage
    {
        public readonly LoginPageObjects loginPage;
        public IPage page;
        public LoginPage(IPage page)
        {
            this.page = page;
            loginPage = new LoginPageObjects(page);
        }

        public async Task FillEmail(string email)
        {
            await loginPage.EmailInput.ClickAsync();
            await loginPage.EmailInput.FillAsync(email);
        }

        public async Task FillPassword(string password)
        {
            await loginPage.PasswordInput.ClickAsync();
            await loginPage.PasswordInput.FillAsync(password);
        }

        public async Task ClickLoginButton()
        {
            await loginPage.LoginButton.ClickAsync();
        }
    }
}
