using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MovieRate.Data;
using MovieRate.Models;

namespace MovieRate.Controllers;

public class MovieController : Controller
{
    private ApplicationDbContext _db;

    public MovieController(ApplicationDbContext db)
    {
        _db = db;
    }


    public IActionResult Index()
    {
        var movies =_db.Movie.ToList();
        return View(movies);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateMovie(MovieEntity movie)
    {
            _db.Movie.Add(movie);
            _db.SaveChanges();


            return RedirectToAction("Index");
    }
}