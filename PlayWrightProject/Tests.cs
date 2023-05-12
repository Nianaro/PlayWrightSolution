using Microsoft.Playwright;
using NUnit.Framework;

namespace PlayWrightProject;

[Parallelizable(ParallelScope.All)]
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

    [Test]
    public async Task TestDuplicationOne()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{ Headless = false });
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://www.heroeswm.ru/");
        Thread.Sleep(1000);       
    }

    [Test]
    public async Task TestDuplicationTwo()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{ Headless = false });
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://www.heroeswm.ru/");
        Thread.Sleep(1000);       
    }

    [Test]
    public async Task TestDuplicationThree()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{ Headless = false });
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://www.heroeswm.ru/");
        Thread.Sleep(1000);       
    }

    [Test]
    public async Task TestDuplicationFoure()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{ Headless = false });
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://www.heroeswm.ru/");
        Thread.Sleep(1000);       
    }

    [Test]
    public async Task TestDuplicationFive()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{ Headless = false });
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://www.heroeswm.ru/");
        Thread.Sleep(1000);       
    }

    [Test]
    public async Task TestDuplicationSix()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{ Headless = false });
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://www.heroeswm.ru/");
        Thread.Sleep(1000);       
    }

    [Test]
    public async Task TestDuplicationSeven()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{ Headless = false });
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://www.heroeswm.ru/");
        Thread.Sleep(1000);       
    }

    [Test]
    public async Task TestDuplicationEight()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{ Headless = false });
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://www.heroeswm.ru/");
        Thread.Sleep(1000);       
    }

    [Test]
    public async Task TestDuplicationNine()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{ Headless = false });
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://www.heroeswm.ru/");
        Thread.Sleep(1000);       
    }

    /* [Test]
    public async Task TestRunInEdge()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{ Headless = false, Channel = "msedge"});
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://www.heroeswm.ru/");
        Thread.Sleep(2000);
    } */
}