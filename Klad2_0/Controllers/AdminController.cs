using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Klad2_0.Models;
using Klad.Models;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.IO;

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

        public ViewResult Edit(int id)
        {
            Product product = db.Products
                .FirstOrDefault(g => g.Id == id);
            return View(product);
        }

        // Перегруженная версия Edit() для сохранения изменений
        [HttpPost]
        public ActionResult Edit(Product product, IFormFile Image)
        {
            if (ModelState.IsValid)
            {
                if (Image != null)
                {
                    using (var binaryReader = new BinaryReader(Image.OpenReadStream()))
                    {
                        product.ImageData = binaryReader.ReadBytes((int)Image.Length);
                        product.ImageMimeType = Image.ContentType;
                    }
                }
                db.SaveProduct(product);
                TempData["message"] = string.Format("Изменения \"{0}\" были сохранены", product.Name);
                return RedirectToAction("Index");
            }
            else
            {
                // Что-то не так со значениями данных
                return View(product);
            }
        }

        // Перегруженная версия Edit() для сохранения изменений
        [HttpPost]
        public ActionResult SavePicture(Product product, IFormFile Image)
        {
            //if (pvm.Avatar != null)
            //{
            //    byte[] imageData = null;
            //    // считываем переданный файл в массив байтов
            //    using (var binaryReader = new BinaryReader(pvm.Avatar.OpenReadStream()))
            //    {
            //        imageData = binaryReader.ReadBytes((int)pvm.Avatar.Length);
            //    }
            //    // установка массива байтов
            //    person.Avatar = imageData;
            //}
            return RedirectToAction("Edit", product);
        }
        //, IFormFile Image = null

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
                TempData["message"] = string.Format("Продукт \"{0}\" был удалён",
                    deletedProduct.Name);
            }
            return RedirectToAction("Index");
        }
    }
}