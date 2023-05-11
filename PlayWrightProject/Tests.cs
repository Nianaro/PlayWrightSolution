using Microsoft.Playwright;
using NUnit.Framework;

namespace PlayWrightProject;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : TestBase
{
    [Test]
    public async Task Test()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{ Headless = false });
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://www.heroeswm.ru/");
        Thread.Sleep(1000);       
    }
}