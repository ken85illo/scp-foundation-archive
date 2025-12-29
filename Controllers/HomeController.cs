using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using SCPFoundation.Models;

namespace SCPFoundation.Controllers;

public class HomeController : Controller
{
    private readonly IWebHostEnvironment _env;
    private readonly Dictionary<string, SCPItem>? _scpLibrary;

    public HomeController(IWebHostEnvironment env)
    {
        _env = env;

        string projectRoot = _env.ContentRootPath;
        string jsonPath = Path.Combine(projectRoot, "Data", "scp_data.json");

        var json = System.IO.File.ReadAllText(jsonPath);
        _scpLibrary = JsonSerializer.Deserialize<Dictionary<string, SCPItem>>(json);

        foreach (var scp in _scpLibrary.Values) { }
    }

    public IActionResult Index()
    {
        return View(_scpLibrary);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(
            new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }
        );
    }
}
