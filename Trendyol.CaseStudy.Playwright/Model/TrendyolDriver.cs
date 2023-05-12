using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trendyol.CaseStudy.Automation.Model
{
    public class TrendyolDriver
    {
        private readonly Task<IPage> _page;
        private IBrowser? _browser;

        public TrendyolDriver()
        {
            _page = InitializeDriver();
        }

        public IPage Page => _page.Result;


        private async Task<IPage> InitializeDriver()
        {
            //Playwright
            using var playwright = await Playwright.CreateAsync();

            //Browser
            _browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,

            });

            //Page
                        
            return await _browser.NewPageAsync();

        }


    }
}
