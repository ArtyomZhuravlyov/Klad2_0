using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WCF_Sber;
namespace Klad2_0.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult GetFormOrder()
        {
            return View();
        }

        /// <summary>
        /// Передаём данные для оплаты и получаем форму для оплаты с уже забитыми данными
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult GetFormBuy(string returnUrl, string merchantOrderNumber, long amount, string description = null)
        {
            WcfSberbank wcfSberbank = new WcfSberbank();
           string formUrl = wcfSberbank.SendOrder(returnUrl, merchantOrderNumber, amount, description);
            if(!string.IsNullOrEmpty(formUrl))
                return View();
            else

            return View();
        }
    }
}