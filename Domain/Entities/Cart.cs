﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Domain.Entities
{
    public class Cart
    {
        
        private List<CartLine> lineCollection = new List<CartLine>();

        public int TotalQuantity { get { return lineCollection.Count(); } }

        /// <summary>
        /// to do Скидка по всем товарам
        /// </summary>
        public long Discount { get; set; }

        /// <summary>
        /// Значение суммы товаров, после которой доставка будет бесплатной
        /// </summary>
        public const int SUMM_FOR_SALE = 3;//000;

        public const int DELIVERY_PRICE = 350;//000;

        public int DeliveryPrice
        {
            get
            {
                if (ComputeTotalValue() > SUMM_FOR_SALE)
                    return 0;
                else return DELIVERY_PRICE;
            }
        }

        public void AddItem(Product product, int quantity)
        {
            CartLine line = lineCollection
                .Where(g => g.productCart.Id == product.Id)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    productCart = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        /// <summary>
        /// Удаляет только одну штуку выбранного товара
        /// </summary>
        /// <param name="product"></param>
        /// <param name="quantity"></param>
        public void RemoveItem(Product product, int quantity)
        {
            CartLine line = lineCollection
                .Where(g => g.productCart.Id == product.Id)
                .FirstOrDefault();

            if (line != null)
            {
                line.Quantity -= quantity; 

            }
            else
            {
                //такое не должно произойти
            }
        }

        /// <summary>
        /// Удаляет полностью товар из корзины (неважно какое количество этого товара было)
        /// </summary>
        /// <param name="product"></param>
        public void RemoveLine(Product product)
        {
            lineCollection.RemoveAll(l => l.productCart.Id == product.Id);
        }

        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.productCart.Price * e.Quantity);

        }

        public decimal ComputeTotalValueWithDelivery()
        {
            return lineCollection.Sum(e => e.productCart.Price * e.Quantity) + DeliveryPrice;

        }
        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return lineCollection; }
        }

        public CartLine GetCartLine(int number)
        {
            return lineCollection[number];
        }


        /// <summary>
        /// Получаем Приобретённые товары пользователем в xml формате
        /// </summary>
        /// <returns></returns>
        public string GetXmlLineCollection()
        {
            List<XmlCartLine> xmlCartLines = new List<XmlCartLine>();

            foreach(var Line in this.lineCollection)
            {
                xmlCartLines.Add(new XmlCartLine()
                {
                    ProductName = Line.productCart.Name,
                    Quantity = Line.Quantity,
                    Price = Line.productCart.Price,
                    Id = Line.productCart.Id,
                    PictureAddress = Line.productCart.Address
                });
            }
            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(List<XmlCartLine>));

            string xml;
            using (StringWriter sw = new StringWriter())
            {
                formatter.Serialize(sw, xmlCartLines);
                xml = sw.ToString();
            }
            return xml;
        }
    }



    public class CartLine
    {
        public Product productCart { get; set; }
        public int Quantity { get; set; }

        public long LineAmount
        {
            get
            {
                return Quantity * productCart.Price;
            }

        }
    }

    [Serializable]
    public class XmlCartLine
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }

        public int Price { get; set; }

        public int PriceTotal { get { return Quantity * Price; } }

        public string PictureAddress { get; set; }

    }
        
}
