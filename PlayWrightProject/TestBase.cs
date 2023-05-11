using NUnit.Framework;
using Microsoft.Extensions.Configuration;

namespace PlayWrightProject;

public class TestBase
{
    private static string env = "";

    static TestBase()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        IConfiguration config = builder.Build();
        env = config["ApplicationSetting:Environment"] ?? "";

        if (env == "Remote")
        {
            Environment.SetEnvironmentVariable("SELENIUM_REMOTE_URL", "http://localhost:4444/wd/hub");
        }
    }

    [OneTimeTearDown]
    public void OneTimeTearDown() 
    {
        if (env == "Remote")
        {
            Environment.SetEnvironmentVariable("SELENIUM_REMOTE_URL", null);
        }
    }
}