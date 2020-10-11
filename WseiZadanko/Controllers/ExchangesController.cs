using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WseiZadanko.Models;

namespace WseiZadanko.Controllers
{
    public class ExchangesController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ExchangeModel exchange)
        {
            var viewModel = new ExchangeAddedViewModel
            {
                NumberOfCharsInName = exchange.Name.Length,
                NumberOfCharsInDescription = exchange.Description.Length,
                IsHidden = !exchange.IsVisible
            };

            return View("ExchangeAdded", viewModel);
        }
    }
}
