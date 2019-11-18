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

        public IActionResult FeedbackAdmin()
        {
            return View(db.Feedback);
        }

        public ViewResult FeedbackEdit(int id)
        {
            Feedback feedback  = db.Feedback
                .FirstOrDefault(g => g.Id == id);
            return View(feedback);
        }

        // Перегруженная версия Edit() для сохранения изменений
        [HttpPost]
        public ActionResult FeedbackEdit(Feedback feedback)
        {
 
                db.SaveFeedback(feedback);
                TempData["message"] = string.Format("Изменения были сохранены");
                return RedirectToAction("FeedbackAdmin");
        }

        public IActionResult Index()
        {
            return View(db.Products);
        }
        public IActionResult WordsAdmin()
        {
            return View(db.WordsSearch);
        }

        public IActionResult PriceAdmin()
        {
            //return View(db.Products);
            return View(db.Products.ToList());
        }

        //[HttpPost]
        //public/* PartialViewResult*/IActionResult PriceAdmin(/*Product product*/int id, int Price, int Weight) /*Так и не удалось передать product2*/
        //{
        //    Product product = db.Products.Where(x=>x.Id==id).FirstOrDefault();
        //    product.Price = Price;
        //    product.Weight = Weight;
        //    db.SaveProduct(product);
        //    return View();
        //   // return PartialView("Message", $" {product.Name} Изменён");

        //  }



        [HttpPost]
        public/* PartialViewResult*/IActionResult PriceAdmin(List<Product> products) /*Так и не удалось передать product2*/
        {
            foreach(var product in products)
            {
                Product productNew = db.Products.Where(x => x.Id == product.Id).FirstOrDefault();
                productNew.Price = product.Price;
                productNew.Weight = product.Weight;
                db.SaveProduct(productNew);
            }
            //Product product = db.Products.Where(x => x.Id == id).FirstOrDefault();
            //product.Price = Price;
            //product.Weight = Weight;
            //db.SaveProduct(product);
            TempData["message"] = string.Format("Изменения  были сохранены");
            return View(db.Products.ToList());
            // return PartialView("Message", $" {product.Name} Изменён");

        }


        public ViewResult Edit(int id)
        {
            Product product = db.Products
                .FirstOrDefault(g => g.Id == id);
            return View(product);
        }

        
        /// <summary>
        /// Перегруженная версия Edit() для сохранения изменений
        /// </summary>
        /// <param name="product">Продукт который отредактировали</param>
        /// <param name="Image"></param>
        /// <param name="action">Определяет нужно ли перейти к редактированию следующего продукта</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Edit(Product product, IFormFile Image, string action)
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
                if (action== "SaveAndNextProduct")
                    return RedirectToAction("Edit", new { id=++product.Id});
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
            Product deletedProduct = db.DeleteProduct(productId);
            if (deletedProduct != null)
            {
                TempData["message"] = string.Format("Продукт \"{0}\" был удалён",
                    deletedProduct.Name);
            }
            return RedirectToAction("Index");
        }
    }
}