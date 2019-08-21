using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Klad.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

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
        /// Запрос в поисковике сбрасыватся в индексе если следующим действием было нажатие на категорию
        /// </summary>
        private string textSearch;
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
            if(!string.IsNullOrEmpty(search)) //если нажали на поиск
            {
                //source = db.Products.Where(x => x.Name.Contains(search)).Distinct().ToList();
                //потом обязательно переделать
                 source = db.Products.Where(x => x.Name.Contains(search));
               
                var source2 = source.Select(m => new { m.Name }).Distinct();

                List<Product> products = new List<Product>();

                foreach(var product2 in source2 )
                {
                    foreach(Product product in source)
                    {
                        if (product.Name == product2.Name)
                        {
                            products.Add(product);
                            break;
                        }
                    }
                }
                

                // source.Distinct(); //delete duplicate
                //  var count = await source.CountAsync();
                var count = products.Count();
                //  var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
                var items = products.Skip((page - 1) * pageSize).Take(pageSize);
                PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
                PagesLink pagesLink = new PagesLink(pageViewModel);

                IndexViewModel viewModel = new IndexViewModel
                {
                    //PageViewModel = pageViewModel,
                    Products = (IEnumerable<Product>)items,
                    CurrentCategory = textSearch,
                    Pages = pagesLink,
                    DiscriptionCatalog = DescriptionCatalog.DiscriptionCatalog
                };
                return View(viewModel);

            }
            else
            {
                textSearch = ""; //сбрасываем результаты поиска
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
            }//else
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

            source = db.Products.Where(x => x.Favourite == true);  //.Include(x => x.Company);
            var items = await source.ToListAsync();

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
