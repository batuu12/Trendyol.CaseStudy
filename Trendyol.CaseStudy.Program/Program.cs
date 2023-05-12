using Microsoft.Playwright;
using System.Security.Cryptography.X509Certificates;
using Trendyol.CaseStudy.Automation.Model;
using Trendyol.CaseStudy.Core.Factory;

public class Program
{
    private static async Task Main(string[] args)
    {

        TrendyolDriver driver = new TrendyolDriver();
        PageFactory factory = new PageFactory(driver.Page);

        await driver.Page.GotoAsync(UrlRepository.trendyolUrl);

        await factory.homePage.ClickLoginButton();
    }
}