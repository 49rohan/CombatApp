using CombatApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CombatApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var protag = new Character();
            ViewBag.Win = true;
            protag.HP = 20;
            protag.SkillPoints = 10;
            return View(protag);
        }
        [HttpPost]
        public IActionResult Index(Character protag)
        {
            protag.SkillPoints += 1;
            protag.Level += 1;

            var Enemy = new Character();
            Enemy.HP = 100;
            Enemy.Attack = 100;
            Enemy.Defense = 1;
            if (protag.Combat(Enemy) == 0)
            {
                ViewBag.Win = true;
            }
            else
            {
                ViewBag.Win = false;
            }
            return View(protag);
        }


    }


}
