using System;
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
    [Serializable]
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
#if DEBUG
        public const int SUMM_FOR_SALE = 10;//000;
#else
        public const int SUMM_FOR_SALE = 3000;//000;
#endif
        /// <summary>
        /// Изначальная Цена доставки
        /// </summary>
        public const int DELIVERY_PRICE = 350;//000;

        /// <summary>
        /// Минимальная сумма для покупки
        /// </summary>
        public const int LIMIT_AMOUNT = 500;//000;

        /// <summary>
        /// Стоимость доствкпи (зависит от общей стоимости)
        /// </summary>
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

        public int ComputeTotalValueWithDelivery()
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

            xmlCartLines.Add(new XmlCartLine()
            {
                ProductName = "Доставка",
                Quantity = 1,
                Price = DeliveryPrice,
                Id = 0001,
                PictureAddress = "cart.png"
            });
            
            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(List<XmlCartLine>));

            string xml;
            using (StringWriter sw = new StringWriter())
            {
                formatter.Serialize(sw, xmlCartLines);
                xml = sw.ToString();
            }
#if DEBUG
            XmlSerializer formatter2 = new XmlSerializer(typeof(List<XmlCartLine>));
            byte[] s = System.Text.Encoding.Unicode.GetBytes(xml);
            using (MemoryStream sw = new MemoryStream(s))
            { 
                List<XmlCartLine> XmlCartLines = (List<XmlCartLine>)formatter2.Deserialize(sw);
                var test = XmlCartLines;// xml = sw.ToString();
            }
#endif
            return xml;
        }


        /// <summary>
        /// Переводим из базы xml формат в обычный класс
        /// </summary>
        /// <param name="xmlCartLines">берём строку хмл формата из базы</param>
        /// <returns></returns>
        static public List<XmlCartLine> GetLineCollecionFromXML(string xmlCartLines)
        {
            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(List<XmlCartLine>));
            byte[] s = System.Text.Encoding.Unicode.GetBytes(xmlCartLines);
            using (MemoryStream sw = new MemoryStream(s))
            {
                List<XmlCartLine> XmlCartLines = (List<XmlCartLine>)formatter.Deserialize(sw);
                return XmlCartLines;// xml = sw.ToString();
            }
        }

    }


    [Serializable]
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

        /// <summary>
        /// Всего по одному типутоваров
        /// </summary>
        public int PriceTotal { get { return Quantity * Price; } }

        public string PictureAddress { get; set; }

    }
        
}
