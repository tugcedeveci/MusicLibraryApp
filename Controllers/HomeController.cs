using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MusicLibraryApp.Models;

namespace MusicLibraryApp.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View(Repository.Musics);
    }

    public IActionResult About()
    {
         return View();
    }

}
