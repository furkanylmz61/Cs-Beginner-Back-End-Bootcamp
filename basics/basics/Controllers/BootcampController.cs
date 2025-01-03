using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class BootcampController : Controller{

    public IActionResult Index(){
        var bootcamp = new Bootcamp();
        bootcamp.id = 1;
        bootcamp.Title = "Beginner Back-end Bootcamp";
        bootcamp.Description = "2 Ocak'ta başiladık. 20 kişi ile başladık.";
        bootcamp.Image = "1.jpeg";
        return View(bootcamp);
    }
    public IActionResult Details(int id){
        var bootcamp = Repository.GetById(id);

        return View(bootcamp);
    }
    public IActionResult List(){ 
        return View(Repository.Bootcamps);
    }
}