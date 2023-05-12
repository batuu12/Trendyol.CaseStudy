## First need to install playwright browsers.
(https://playwright.dev/docs/browsers) 

Install browsers
Playwright can install supported browsers. Running the command without arguments will install the default browsers.

-npx playwright install

You can also install specific browsers by providing an argument:

-npx playwright install webkit

See all supported browsers:

-npx playwright install --help