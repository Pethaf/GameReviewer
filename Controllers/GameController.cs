using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using GameReviewer.Models;

namespace GameReviewer.Controllers
{
    public class GameController : Controller
    {

        public IActionResult Index()
        {
            return View(Game.ReadAll());
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Game game)
        {
            Game.Create(game);
            return RedirectToAction("Index");
        }
    }
}