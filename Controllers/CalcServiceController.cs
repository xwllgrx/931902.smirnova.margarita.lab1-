﻿using Web1_lab.Models;
using Web1_lab.Services;
using Microsoft.AspNetCore.Mvc;

namespace Web1_lab.Controllers {
    public class CalcServiceController : Controller
    {
        private readonly CalcService _service;

        public CalcServiceController(CalcService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PassUsingModel()
        {
            return View(_service.GetCalcModel());
        }

        public IActionResult PassUsingViewData()
        {
            var model = _service.GetCalcModel();
            ViewData["X"] = model.X;
            ViewData["Y"] = model.Y;
            ViewData["Sum"] = model.Sum;
            ViewData["Dif"] = model.Dif;
            ViewData["Mult"] = model.Mult;
            ViewData["Div"] = model.Div;
            return View();
        }

        public IActionResult PassUsingViewBag()
        {
            var model = _service.GetCalcModel();
            ViewBag.X = model.X;
            ViewBag.Y = model.Y;
            ViewBag.Sum = model.Sum;
            ViewBag.Dif = model.Dif;
            ViewBag.Mult = model.Mult;
            ViewBag.Div = model.Div;
            return View();
        }

        public IActionResult AccessServiceDirectly()
        {
            return View();
        }
    }
}