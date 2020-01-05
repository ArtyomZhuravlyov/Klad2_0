using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Klad.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WCF_Sber;
namespace Klad2_0.Controllers
{
    public class OrderController : Controller
    {

        ProductContext db;

        public OrderController(ProductContext context)
        {
            db = context;
            //if (OrderProcessor == null)
            //    orderProcessor = new EmailOrderProcessor(new EmailSettings()); //базовые настройки для админа
            //else
            //    orderProcessor = OrderProcessor;
        }

        public IActionResult GetFormOrder()
        {
            return View();
        }

       // /// <summary>
       // /// Передаём данные для оплаты и получаем форму для оплаты с уже забитыми данными
       // /// </summary>
       // /// <returns></returns>
       // [HttpPost]
       // public async Task<IActionResult> GetFormBuy(string returnUrl, string merchantOrderNumber, long amount, string description = null)
       // {
            
       //     string value = HttpContext.Session.GetString("Cart");
       //     Cart cart = JsonConvert.DeserializeObject<Cart>(value);

       //     var testThemDel = cart.GetXmlLineCollection();
       //     //   db.Orders.LastOrDefault().TimeOrder = DateTime.Now.ToUniversalTime();

       ////     WcfSberbank wcfSberbank = new WcfSberbank((db.Orders.LastOrDefault()?.Id + 1).ToString());
       //     var task =  await WcfSberbank.Test();
       //   // string formUrl = wcfSberbank.SendOrder(returnUrl, merchantOrderNumber, amount, cart, description );
       //     //if(!string.IsNullOrEmpty(formUrl))
       //     //    return View();
       //     //else

       //     return View(task);
       // }
    }
}