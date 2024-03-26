using Microsoft.AspNetCore.Mvc.Testing;
using Rockaway.WebApp;
namespace Rockaway.WebApp.Tests;

public class PageTests
{
    [Fact]
    public async Task Index_Page_Returns_Success()
    {
        await using var factory = new WebApplicationFactory<Program>();
        using var client = factory.CreateClient();
        using var response = await client.GetAsync("/");
        response.EnsureSuccessStatusCode();
    }
    [Fact]
    public async Task Privacy_Page_Returns_Success()
    {
        await using var factory = new WebApplicationFactory<Program>();
        using var client = factory.CreateClient();
        using var response = await client.GetAsync("/privacy");
        response.EnsureSuccessStatusCode();
    }
}