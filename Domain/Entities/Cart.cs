using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Entities
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public int TotalQuantity { get { return lineCollection.Count(); } }

        public const int SUMM_FOR_SALE = 3;//000;

        public const int DELIVERY = 350;//000;

        public int Delivery
        {
            get
            {
                if (ComputeTotalValue() > SUMM_FOR_SALE)
                    return 0;
                else return DELIVERY;
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
        /// Удаляет полностью товар из коризины (неважно какое количество этого товара было)
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
            return lineCollection.Sum(e => e.productCart.Price * e.Quantity) + Delivery;

        }
        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return lineCollection; }
        }
    }

    public class CartLine
    {
        public Product productCart { get; set; }
        public int Quantity { get; set; }
    }
}
