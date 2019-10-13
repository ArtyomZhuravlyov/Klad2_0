using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Klad.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Domain.Entities;
using Klad.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Domain.Entities;
using Newtonsoft.Json;
using Klad2_0.Models;
using Klad.Models;
using Domain.Concrete;

namespace Klad.Controllers
{
    public class CartController : Controller
    {
        ProductContext db;
        

        public CartController(ProductContext context)
        {
            db = context;
            //if (OrderProcessor == null)
            //    orderProcessor = new EmailOrderProcessor(new EmailSettings()); //базовые настройки для админа
            //else
            //    orderProcessor = OrderProcessor;
        }



        public RedirectResult /*ViewResult*/ Index(string returnUrl)
        {
            //return View(new CartIndexViewModel
            //{
            //    Cart = GetCart(),
            //    ReturnUrl = returnUrl
            //});
            return Redirect(returnUrl);
        }

        //public/* void *//*RedirectToActionResult*/ RedirectResult AddToCart(int productId, string returnUrl)
        //{
        //    Product product = db.Products
        //        .FirstOrDefault(g => g.Id == productId);

        //    if (product != null)
        //    {
        //        Cart cart = GetCart();
        //        cart.AddItem(product, 1);
        //        HttpContext.Session.SetString("Cart", JsonConvert.SerializeObject(cart));
        //    }
        //    return Redirect(returnUrl);
        //    //return RedirectToAction("Index", new { returnUrl });
        //}

        public RedirectToActionResult RemoveFromCart(int productId, string returnUrl)
        {
            Product product = db.Products
                .FirstOrDefault(g => g.Id == productId);

            if (product != null)
            {
                Cart cart = GetCart();
                cart.RemoveLine(product);
                HttpContext.Session.SetString("Cart", JsonConvert.SerializeObject(cart));
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public Cart GetCart()
        {
            Cart cart;
            //Cart cart = (Cart)HttpContext.Session.Get("Cart"); //["Cart"];
            if (HttpContext.Session.Keys.Contains("Cart"))
            {
                string value = HttpContext.Session.GetString("Cart");
                cart = JsonConvert.DeserializeObject<Cart>(value);
            }
            else
            {
                 cart = new Cart();
                HttpContext.Session.SetString("Cart", JsonConvert.SerializeObject(cart));
                // Session["Cart"] = cart;
            }
            return cart;
        }

        public ViewResult/*PartialViewResult*/ Summary()
        {
            string value = HttpContext.Session.GetString("Cart");
            if (!string.IsNullOrEmpty(value))
            {
                Cart cart = JsonConvert.DeserializeObject<Cart>(value);
                return View(new CartIndexViewModel { Cart = cart, ReturnUrl = "" });
            }
            else return View(null);
        }

        public ViewResult Checkout()
        {
            return View(new ShippingDetails());
        }

        [HttpPost]
        public ViewResult Checkout(Cart cart, ShippingDetails shippingDetails)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Извините, ваша корзина пуста!");
            }

            if (ModelState.IsValid)
            {
                //orderProcessor.ProcessOrder(cart, shippingDetails);
                cart.Clear();
                return View("CompletedOrder");
            }
            else
            {
                return View(shippingDetails);
            }
        }
    }
}