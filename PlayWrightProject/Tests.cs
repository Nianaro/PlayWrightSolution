using Microsoft.Playwright;
using NUnit.Framework;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests
{
    [OneTimeSetUp]
    public void OneTimeSetUp() => Environment.SetEnvironmentVariable("SELENIUM_REMOTE_URL", "http://localhost:4444/wd/hub");

    [Test]
    public async Task Test()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{ Headless = false });
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://www.heroeswm.ru/");
        Thread.Sleep(1000);       
    }

    [OneTimeTearDown]
    public void TearDown() => Environment.SetEnvironmentVariable("SELENIUM_REMOTE_URL", null);
}