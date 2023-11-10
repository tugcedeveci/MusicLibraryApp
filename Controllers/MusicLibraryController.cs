using Microsoft.AspNetCore.Mvc;
using MusicLibraryApp.Models;


namespace MusicLibraryApp.Controllers
{
   
    public class MusicLibraryController : Controller
    {
       
       public IActionResult Music(){
        return View("Music",Repository.Musics);
       }
      public IActionResult Details(int? id){

        if(id==null){
          return Redirect("/musiclibrary/music");
        }

        var music = Repository.GetById(id);
        return View(music);
       }
    }
}