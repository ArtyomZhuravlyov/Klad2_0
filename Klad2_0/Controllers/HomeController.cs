﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Klad.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Domain.Entities;
using Newtonsoft.Json;

namespace Klad.Controllers
{
    public class HomeController : Controller
    {
        ProductContext db;
        public HomeController(ProductContext context)
        {
            db = context;
        }

        /// <summary>
        /// Каталог товаров
        /// </summary>
        /// <param name="category"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public async Task<IActionResult> Index( string category = null,  int page = 1, string search = null)
        {
            int pageSize;
            IQueryable<Product> source;
          //  IQueryable<Product> source2;
            pageSize = 18; 

                // несколько категорий
                source = db.Products.Where(x => x.Category == category || x.Category2 == category /*|| x.Category3 == category || x.Category4 == category*/);

                var count = await source.CountAsync();
                var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

                PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
                PagesLink pagesLink = new PagesLink(pageViewModel);

                IndexViewModel viewModel = new IndexViewModel
                {
                    //PageViewModel = pageViewModel,
                    Products = items,
                    CurrentCategory = category,
                    Pages = pagesLink,
                    DiscriptionCatalog = DescriptionCatalog.DiscriptionCatalog
                };
                return View(viewModel);
            
        }

        /// <summary>
        /// Каталог товаров по поиску
        /// </summary>
        /// <param name="category"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public async Task<IActionResult> IndexSearch(string search, int page = 1 )
        {
            int pageSize;
            IQueryable<Product> source;
            //  IQueryable<Product> source2;
            pageSize = 18;
            //source = db.Products.Where(x => x.Name.Contains(search)).Distinct().ToList();
            //потом обязательно переделать
            source = db.Products.Where(x => x.Name.Contains(search));

            var source2 = source.Select(m => new { m.Name }).Distinct();

            List<Product> productsSearch = new List<Product>();
            var source22 = source2.ToArray();
            var source11 = source.ToArray();
            source.ToArray();
            int count2 = source22.Count();
            int count1 = source11.Count();
            for (int i = 0; i < count2; i++)
            {
                for (int j = 0; j < count1; j++)
                {
                    if (source11[j].Name == source22[i].Name)
                    {
                        productsSearch.Add(source11[j]);
                        break;
                    }
                }
            }
            var count = productsSearch.Count();
            var items = productsSearch.Skip((page - 1) * pageSize).Take(pageSize);
            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            PagesLink pagesLink = new PagesLink(pageViewModel);

            IndexViewModel viewModel = new IndexViewModel
            {
                //PageViewModel = pageViewModel,
                Products = items,
                CurrentCategory = search,
                Pages = pagesLink,
                DiscriptionCatalog = DescriptionCatalog.DiscriptionCatalog
            };
            return View(viewModel);

        }

        public ActionResult Details(int id, int l = 50)
        {
            Product product = (Product)db.Products.FirstOrDefault(x => x.Id == id);
            //Computer c = comps.FirstOrDefault(com => com.Id == id);
            //if (c != null)
            //    return PartialView(c);
            return PartialView(product);
        }

        /// <summary>
        /// Главная страница
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Main()
        {
            IQueryable<Product> source;

            //source = db.Products.Where(x => x.Favourite == true);  //.Include(x => x.Company);
            //var items = await source.ToListAsync();
            List<Product> items = null;

            IndexViewModel viewModel = new IndexViewModel
            {
                Products = items,
            };

            return View(viewModel);
        }

        /// <summary>
        /// Подробный просмотр товара
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult ViewProduct(int id)
        {
            IQueryable<Product> source;
            source = db.Products.Where(x => x.Id == id);
            var items = source.ToList(); //возможно потом переделать в асинх как в примерах выше

            IndexViewModel viewModel = new IndexViewModel
            {
                Products = items,
            };

           // ViewBag.ProductId = id;
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Buy(int id)
        {
            
            ViewBag.ProductId = id;
            return View();

        }

        [HttpPost]
        public string Buy(Order order)
        {
            db.Orders.Add(order);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Спасибо, " + order.User + ", за покупку!";
        }

        public  /*ActionResult*/ PartialViewResult Summary(Cart cart)
        {
            cart = GetCart();
            //string value = HttpContext.Session.GetString("Cart");
            //cart = JsonConvert.DeserializeObject<Cart>(value);
            return PartialView(cart);
        }

        public/* void */RedirectToActionResult/* RedirectResult*/ AddToCart(int productId, string returnUrl)
        {
            Product product = db.Products
                .FirstOrDefault(g => g.Id == productId);

               Cart cart = GetCart();
               cart.AddItem(product, 1);
               HttpContext.Session.SetString("Cart", JsonConvert.SerializeObject(cart));
            
            //return Redirect(returnUrl);
            return RedirectToAction("Summary", cart);
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

        //public IActionResult Index()
        //{
        //    // return View();
        //    return View(db.Products.ToList());
        //}

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


    }
}
