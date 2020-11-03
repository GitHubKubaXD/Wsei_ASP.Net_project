﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WseiZadanko.Models;

namespace WseiZadanko.Controllers
{
    public class ExchangesController : Controller
    {
        public IActionResult Show(string id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ItemModel item)
        {
            // TODO add to database

            var viewModel = new AddNewItemConfirmationViewModel
            {
                Id = 1,
                Name = item.Name,
            };

            //return View("AddConfirmation", viewModel);
            return RedirectToAction("AddConfirmation", new { itemId = 1 });
        }

        [HttpGet]
        public IActionResult AddConfirmation(int itemId)
        {
            return View(itemId);
        }
    }
}
