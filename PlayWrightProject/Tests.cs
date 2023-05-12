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
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
        var page = await browser.NewPageAsync();
        await page.SetViewportSizeAsync(1920, 1080);

        await page.GotoAsync("https://www.heroeswm.ru/");

        await page.Locator("[name=login]").FillAsync("");
        await page.Locator("[name=pass]").FillAsync("");
        await page.Locator("div.entergame").ClickAsync();

        await page.Locator("#MenuMap").ClickAsync();
        await page.WaitForLoadStateAsync();

        var arrows = await page.QuerySelectorAllAsync("#hwm_map_objects_and_buttons .map_obj_table_hover td:nth-child(5)");
        foreach (var arrow in arrows)
        {
            var text = await arrow.InnerTextAsync();
            if (text.Contains("»»»"))
            {
                await arrow.ClickAsync();
                Thread.Sleep(3000);
                //await page.WaitForLoadStateAsync(LoadState.DOMContentLoaded);
                return;
            }
        }

        await page.Locator(".getjob_submitBtn").ClearAsync();
        await page.WaitForLoadStateAsync(LoadState.DOMContentLoaded);
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