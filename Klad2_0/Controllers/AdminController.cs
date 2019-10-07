﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Klad2_0.Models;
using Klad.Models;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;

namespace Klad.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        ProductContext db;

        public AdminController(ProductContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View(db.Products);
        }

        public ViewResult Edit(int productId)
        {
            Product product = db.Products
                .FirstOrDefault(g => g.Id == productId);
            return View(product);
        }

        // Перегруженная версия Edit() для сохранения изменений
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                db.SaveGame(product);
                TempData["message"] = string.Format("Изменения в игре \"{0}\" были сохранены", product.Name);
                return RedirectToAction("Index");
            }
            else
            {
                // Что-то не так со значениями данных
                return View(product);
            }
        }

        public ViewResult Create()
        {
            return View("Edit", new Product());
        }

        [HttpPost]
        public ActionResult Delete(int productId)
        {
            Product deletedProduct = db.DeleteGame(productId);
            if (deletedProduct != null)
            {
                TempData["message"] = string.Format("Игра \"{0}\" была удалена",
                    deletedProduct.Name);
            }
            return RedirectToAction("Index");
        }
    }
}