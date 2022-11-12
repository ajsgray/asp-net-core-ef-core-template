using AspNetCoreEfCoreTemplate.Data;
using AspNetCoreEfCoreTemplate.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreEfCoreTemplate.Controllers;

public class HomeController : ControllerBase
{
    private readonly AppDbContext db;
    private readonly IExampleService exampleService;

    public HomeController(AppDbContext db, IExampleService exampleService)
    {
        this.db = db;
        this.exampleService = exampleService;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }
}