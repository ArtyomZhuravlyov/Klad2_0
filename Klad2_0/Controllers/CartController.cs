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



        public int GetQuantity()
        {
            return GetCart().Lines.Sum(x => x.Quantity);
        }

        public void/*ActionResult*/ AddToCart(int id, int l = 50)
        {
            // Product product = (Product)db.Products.FirstOrDefault(x => x.Id == id);
            if (id > 0)
            {
                Product product = db.Products
                 .FirstOrDefault(g => g.Id == id);

                Cart cart = GetCart();
                cart.AddItem(product, 1);
                HttpContext.Session.SetString("Cart", JsonConvert.SerializeObject(cart));
                cart = GetCart();

                //return PartialView(cart);
            }
            else //если отрицательное значение (-1), то нужно просто получить Корзину
            {
                Cart cart = GetCart();
                //return PartialView(cart);
            }
        }


        /// <summary>
        /// Удаляет только одно кол-во выбранного товара (1 штуку)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="l"></param>
        /// <returns></returns>
        public RedirectResult RemoveOneProductToCart(int id, int l = 50)
        {
            // Product product = (Product)db.Products.FirstOrDefault(x => x.Id == id);
            //if (id > 0)
            //{
            Product product = db.Products
             .FirstOrDefault(g => g.Id == id);

            Cart cart = GetCart();
            cart.RemoveItem(product, 1);
            HttpContext.Session.SetString("Cart", JsonConvert.SerializeObject(cart));
            cart = GetCart();

            return Redirect("/Cart/AddToCart/-1");
            //}
            //else //если отрицательное значение (-1), то нужно просто получить Корзину
            //{
            //    Cart cart = GetCart();
            //    return Redirect("/Home/AddToCart/-1");
            //}
        }

        public ActionResult /*PartialViewResult*/ SummaryPart(Cart cart)
        {
            cart = GetCart();
            //string value = HttpContext.Session.GetString("Cart");
            //cart = JsonConvert.DeserializeObject<Cart>(value);
            return PartialView(cart);
        }

        public RedirectToActionResult RemoveLine(int id, string returnUrl="")
        {

            Product product = db.Products
                .FirstOrDefault(g => g.Id == id);

            Cart cart = GetCart();
            cart.RemoveLine(product);
            HttpContext.Session.SetString("Cart", JsonConvert.SerializeObject(cart));
            cart = GetCart();

            //  return Redirect($"/Cart/Summary/{returnUrl}/");
            return RedirectToAction("Summary","Cart", new { returnUrl});
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

        public ViewResult/*PartialViewResult*/ Summary(string returnUrl="")
        {
            
            string value = HttpContext.Session.GetString("Cart");
            if (!string.IsNullOrEmpty(value))
            {
                Cart cart = JsonConvert.DeserializeObject<Cart>(value);
                if (cart.Lines.Count() == 0)
                    return View(new CartIndexViewModel { Cart = cart, ReturnUrl = returnUrl, Products = db.GetFavoutiteProducts()}); 
                else
                    return View(new CartIndexViewModel { Cart = cart, ReturnUrl = returnUrl });
            }
            else return View(null);
        }

        public ViewResult Checkout()
        {
            return View(new ShippingDetails());
        }

        [HttpPost]
        public ViewResult Checkout( ShippingDetails shippingDetails)
        {

            if (GetCart().Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Извините, ваша корзина пуста!");
            }

            if (ModelState.IsValid)
            {
                //orderProcessor.ProcessOrder(cart, shippingDetails);
                //cart.Clear();
                //to do wcf 

                return View("CompletedOrder");
            }
            else
            {
                return View(shippingDetails);
            }
        }

    }
}