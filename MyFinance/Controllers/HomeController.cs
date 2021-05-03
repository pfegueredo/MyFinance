﻿using Microsoft.AspNetCore.Mvc;
using MyFinance.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinance.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeModel objHomeModel = new HomeModel();
            string nome = objHomeModel.LerNomesUsuario();
            ViewData["Nome"] = nome;
            return View();
        }

        public IActionResult Ajuda()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Menu()
        {
            return View();
        }
    }
}
