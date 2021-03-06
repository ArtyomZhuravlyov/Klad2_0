﻿using System;
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
using WCF_Sber;
using System.Text.RegularExpressions;
using System.Globalization;

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

        public RedirectToActionResult/*ActionResult*/ AddToCart(int id, int l = 50)
        {
            // Product product = (Product)db.Products.FirstOrDefault(x => x.Id == id);
            //if (id > 0)
            //{
                Product product = db.Products
                 .FirstOrDefault(g => g.Id == id);

                Cart cart = GetCart();
                cart.AddItem(product, 1);
                HttpContext.Session.SetString("Cart", JsonConvert.SerializeObject(cart));
                //cart = GetCart();

                return RedirectToAction("Summary","Cart");
          
        }


        /// <summary>
        /// Удаляет только одно кол-во выбранного товара (1 штуку)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="l"></param>
        /// <returns></returns>
        public RedirectToActionResult RemoveOneProductToCart(int id, int l = 50)
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

            return RedirectToAction("Summary", "Cart");
            //}
            //else //если отрицательное значение (-1), то нужно просто получить Корзину
            //{
            //    Cart cart = GetCart();
            //    return Redirect("/Home/AddToCart/-1");
            //}
        }

       
        public ActionResult ModalText(string text)
        {
            return PartialView("ModalText", text);
        }

        public ActionResult /*PartialViewResult*/ SummaryPart(Cart cart)
        {
            cart = GetCart();
            //string value = HttpContext.Session.GetString("Cart");
            //cart = JsonConvert.DeserializeObject<Cart>(value);
            return PartialView(cart);
        }

        /// <summary>
        /// Удаляет полностью товар из корзины (неважно какое количество этого товара было)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="returnUrl"></param>
        /// <returns></returns>
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

        public ActionResult Details(int id, string returnUrl = null)
        {
            Product product = db.Products.FirstOrDefault(x => x.Id == id);
            if (!string.IsNullOrEmpty(returnUrl))
                HttpContext.Session.SetString("ReturnUrl", returnUrl);

            return PartialView(product);
        }

        public ViewResult/*PartialViewResult*/ Summary(string returnUrl="")
        {
            
            string value = HttpContext.Session.GetString("Cart");
            if (!string.IsNullOrEmpty(value))
            {
                Cart cart = JsonConvert.DeserializeObject<Cart>(value);
                if (cart.Lines ==null || cart.Lines.Count() == 0)
                    return View(new CartIndexViewModel { Cart = cart, ReturnUrl = returnUrl, Products = db.GetFavoutiteProducts() });
                else
                {

                    if (string.IsNullOrEmpty(returnUrl)) //если мы добавили товар находясь в корзине то забываем где находились ранее и берём категорию последнего товара (только добавленгго из корзины)
                        returnUrl = HttpContext.Session.GetString("ReturnUrl");
                    else                   
                        HttpContext.Session.SetString("ReturnUrl", returnUrl);

                
                    string Category = cart.Lines.Last().productCart.Category2;

                    //if (string.IsNullOrEmpty(Category)) //если товар по категории Дети, онкология
                    //{
                    //    Category = cart.GetCartLine(0).productCart.Category;
                    //    return View(new CartIndexViewModel { Cart = cart, ReturnUrl = returnUrl, Products = db.GetCategory1Products(Category) });
                    //}
                    return View(new CartIndexViewModel { Cart = cart, ReturnUrl = returnUrl, Products = db.GetCategory2Products(Category) }); 
                }
            }
            else return View(new CartIndexViewModel { Cart = null, ReturnUrl = returnUrl, Products = db.GetFavoutiteProducts() });
        }

        public ViewResult Checkout()
        {
            ShippingDetails shippingDetails = new ShippingDetails();
            if (HttpContext.Session.Keys.Contains("shippingDetails"))
            {
                string value = HttpContext.Session.GetString("shippingDetails");
                shippingDetails = JsonConvert.DeserializeObject<ShippingDetails>(value);
            }
            return View(shippingDetails/*new ShippingDetails()*/);
        }

        //public ViewResult FillCheckout(ShippingDetails shippingDetails)
        //{
        //    return View(shippingDetails);
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="shippingDetails"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Checkout( ShippingDetails shippingDetails)
        {
            string value = HttpContext.Session.GetString("Cart");
            Cart cart = JsonConvert.DeserializeObject<Cart>(value);

            if (cart==null || cart.Lines==null)
                return RedirectToAction("Cart","Summary");
            if(!IsValidEmail(shippingDetails.Mail))
                ModelState.AddModelError("Mail", " указана некорректно почта"); ;

            if(CheckPhone(shippingDetails.Phone, out string Phone)) 
                shippingDetails.Phone = Phone;

            if (ModelState.IsValid && shippingDetails.UserAccess /*&& CheckPhone(shippingDetails.Phone)*/)
            {
                //try
                //{
                var order = CreateAndFillOrder(shippingDetails, cart); //добавляем в базу заказ
#if DEBUG
                WcfSberbank wcfSberbank = new WcfSberbank((order.Id).ToString() + "testLocal", cart, shippingDetails);
#else
                WcfSberbank wcfSberbank = new WcfSberbank("Order" + (order.Id).ToString(), cart, shippingDetails);
#endif
                string url = wcfSberbank.GetResponseSoap();

                if (!string.IsNullOrEmpty(url))
                    return Redirect(url);
                else
                {
                    ModelState.AddModelError("Mail", "Проверьте правильность введённых данных");
                    return View(shippingDetails);
                }
                //}
                //catch(Exception ex)
                //{
                //    //to do
                //    return Redirect("");
                //}


            }
            else
            {
                if (!shippingDetails.UserAccess)                    
                        ModelState.AddModelError("UserAccess", "Примите пользовательское соглашение");                                  
                HttpContext.Session.SetString("shippingDetails", JsonConvert.SerializeObject(shippingDetails));
                return View(shippingDetails);
            }

        }

        private bool CheckPhone(string Phone, out string phone)
        {
            phone = Phone;
            //if(Phone.Length!=11 || !long.TryParse(Phone, out long empty))
            if(!Regex.IsMatch(phone,@"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$"))
            {
                ModelState.AddModelError("Phone", "Неверный формат номера телефона");
                return false;
            }
            phone = phone.Replace(" ", "").Replace("(", "").Replace(")", "");
            return true;
                
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public Order CreateAndFillOrder(ShippingDetails shippingDetails, Cart cart)
        {
            Order order = new Order()
            {
                Received = false,
                Delivered = false,
                Shipped = false,
                Adress = shippingDetails.Adress,
                Name = shippingDetails.Name,
                Mail = shippingDetails.Mail,
                City = shippingDetails.City,
                MiddleName = shippingDetails.MiddleName,
                Surname = shippingDetails.Surname,
                TimeOrder = DateTime.Now.ToUniversalTime(),
                Phone = shippingDetails.Phone,
                Comment = shippingDetails.Comment,
                OrdersAndQuantity = cart.GetXmlLineCollection(),
                Amount = cart.ComputeTotalValueWithDelivery()
                //to do
            };
            db.Orders.Add(order);
            db.SaveChanges();
            return order;
        }

    }
}