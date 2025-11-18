using System.Diagnostics;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc;
using AnimeProject.Models;

namespace AnimeProject.Controllers;

public class HomeController : Controller
{
    public async Task<IActionResult> Index()
    {
        using var http = new HttpClient();

        var response = await http.GetFromJsonAsync<JikanResponse>(
            "https://api.jikan.moe/v4/top/anime"
        );

        var animeList = response?.Data ?? new List<AnimeDTO>();

        return View(animeList);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel 
        { 
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier 
        });
    }
}
