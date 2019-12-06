using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Klad2_0.Models;

namespace Klad.Models
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Feedback> Feedback { get; set; }

        public DbSet<WordsSearch> WordsSearch { get; set; }

        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        /// <summary>
        /// Отдаёт товары по второй категории(первые 10), если нет ни одного, то отдаёт товары по первой категории
        /// </summary>
        /// <param name="category2"></param>
        /// <returns></returns>
        public List<Product> GetCategory2Products(string category2)
        {
            List<Product> items = Products.Where(x => x.Category2 == category2).Take(10).ToList();
            if (items.Count == 0)
                return GetCategory1Products(category2);
            return items;
        }

        /// <summary>
        /// Отдаёт товары по первой категории (первые 10)
        /// </summary>
        /// <param name="category1"></param>
        /// <returns></returns>
        public List<Product> GetCategory1Products(string category1)
        {
            List<Product> items = Products.Where(x => x.Category == category1).Take(10).ToList();
            return items;
        }

        /// <summary>
        /// Отдаёт самые популярые товары
        /// </summary>
        /// <returns></returns>
        public List<Product> GetFavoutiteProducts()
        {
            List<Product> items = Products.Where(x => x.Favourite == true).ToList();
            return items;
        }

        #region save
        public void SaveProduct(Product product)
        {
            if (product.Id == 0)
                this.Products.Add(product);
            else
            {
                Product dbEntry = this.Products.Find(product.Id);
                if (CheckChange(dbEntry, product))
                {
                    #region сохранение свойств
                    if (dbEntry != null)
                    {
                        dbEntry.Name = product.Name;
                        dbEntry.Favourite = product.Favourite;
                        dbEntry.Description = product.Description;
                        dbEntry.Price = product.Price;
                        dbEntry.PriceWithoutSales = product.PriceWithoutSales;
                        dbEntry.Category = product.Category;
                        dbEntry.Category2 = product.Category2;
                        dbEntry.Category3 = product.Category3;
                        dbEntry.Category4 = product.Category4;
                        dbEntry.Category5 = product.Category5;
                        dbEntry.Category6 = product.Category6;
                        dbEntry.Address = product.Address;
                        dbEntry.Weight = product.Weight;
                        dbEntry.Composition = product.Composition;
                        dbEntry.Contraindications = product.Contraindications;
                        dbEntry.FormRelease = product.FormRelease;
                        dbEntry.IndicationsForUse = product.IndicationsForUse;
                        dbEntry.StorageConditions = product.StorageConditions;
                        dbEntry.FullDescription = product.FullDescription;
                        dbEntry.ShelfLife = product.ShelfLife;
                        dbEntry.MethodOfUse = product.MethodOfUse;
                        dbEntry.ImageData = product.ImageData;
                        dbEntry.ImageMimeType = product.ImageMimeType;
                        dbEntry.CompositionEvening = product.CompositionEvening;
                        dbEntry.CompositionMorning = product.CompositionMorning;
                        //dbEntry.MainCategory1 = product.MainCategory1;
                        //dbEntry.MainCategory2 = product.MainCategory2;
                        //dbEntry.MainCategory3 = product.MainCategory3;
                        //dbEntry.SubCategory1 = product.SubCategory1;
                        //dbEntry.SubCategory2 = product.SubCategory2;
                        //dbEntry.SubCategory3 = product.SubCategory3;
                        //dbEntry.SubCategory4 = product.SubCategory4;
                        //dbEntry.SubCategory5 = product.SubCategory5;
                        //dbEntry.SubCategory6 = product.SubCategory6;
                    }
                    #endregion
                    IterativProductSave(dbEntry);
                }
            }
            this.SaveChanges();
        }

        public int FindNextId(int Id)
        {
            try
            {
                int LastId = this.Products.Last().Id;
               for (int i=Id+1;i<= LastId; i++)
                {
                    if (Products.Find(i) != null)
                        return i;
                }
                return 0;
            }
            catch(Exception ex)
            {
                return 0;
            }
        }

        /// <summary>
        /// проверяет изменён ли продукт(сделано только из-за IterativProductSave) не проверяется ид и имя
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <returns></returns>
        private bool CheckChange(Product DBproduct, Product changeProduct)
        {
            if (
            DBproduct.Favourite != changeProduct.Favourite ||
            DBproduct.Description != changeProduct.Description ||
            DBproduct.Price != changeProduct.Price ||
            DBproduct.PriceWithoutSales != changeProduct.PriceWithoutSales ||
            DBproduct.Category  != changeProduct.Category  ||
            DBproduct.Category2 != changeProduct.Category2 ||
            DBproduct.Category3 != changeProduct.Category3 ||
            DBproduct.Category4 != changeProduct.Category4 ||
            DBproduct.Category5 != changeProduct.Category5 ||
            DBproduct.Category6 != changeProduct.Category6 ||
            DBproduct.Address != changeProduct.Address     ||
            DBproduct.Weight != changeProduct.Weight       ||
            DBproduct.Composition != changeProduct.Composition ||
            DBproduct.Contraindications != changeProduct.Contraindications ||
            DBproduct.FormRelease != changeProduct.FormRelease ||
            DBproduct.IndicationsForUse != changeProduct.IndicationsForUse ||
            DBproduct.StorageConditions != changeProduct.StorageConditions ||
            DBproduct.FullDescription != changeProduct.FullDescription ||
            DBproduct.ShelfLife != changeProduct.ShelfLife ||
            DBproduct.MethodOfUse != changeProduct.MethodOfUse ||
            DBproduct.ImageData != changeProduct.ImageData ||
            DBproduct.ImageMimeType != changeProduct.ImageMimeType ||
            DBproduct.CompositionEvening != changeProduct.CompositionEvening ||
            DBproduct.CompositionMorning != changeProduct.CompositionMorning
               )
                return true;

            else return false;
        }
        /// <summary>
        /// Сохраняем продукты с таким же названием дав им свойства переданного продукта(для повторяющихся продуктов)
        /// </summary>
        /// <param name="product"></param>
        private void IterativProductSave(Product product)
        {
            /*IQueryable<Product>*/
            List<Product> listProducts = this.Products.Where(t => t.Name == product.Name).ToList();
            listProducts.Remove(listProducts.FirstOrDefault(t => t.Id == product.Id));
            if (listProducts.Count > 0)
            {
                foreach (var prodBD in listProducts)
                {
                   // Product prodBD = this.Products.Find(prod.Id);
                    prodBD.Description = product.Description;
                    prodBD.Price = product.Price;
                    prodBD.PriceWithoutSales = product.PriceWithoutSales;
                    prodBD.Address = product.Address;
                    prodBD.Weight = product.Weight;
                    prodBD.Composition = product.Composition;
                    prodBD.Contraindications = product.Contraindications;
                    prodBD.FormRelease = product.FormRelease;
                    prodBD.IndicationsForUse = product.IndicationsForUse;
                    prodBD.StorageConditions = product.StorageConditions;
                    prodBD.FullDescription = product.FullDescription;
                    prodBD.ShelfLife = product.ShelfLife;
                    prodBD.MethodOfUse = product.MethodOfUse;
                    prodBD.ImageData = product.ImageData;
                    prodBD.ImageMimeType = product.ImageMimeType;
                    prodBD.CompositionEvening = product.CompositionEvening;
                    prodBD.CompositionMorning = product.CompositionMorning;
                    
                }
            }
        }
        public void SaveFeedback(Feedback feedback)
        {
            if (feedback.Id == 0)
                this.Feedback.Add(feedback);
            else
            {
                Feedback dbEntry = this.Feedback.Find(feedback.Id);
                if (dbEntry != null)
                {
                    dbEntry.Name = feedback.Name;
                    dbEntry.AdressPicture = feedback.AdressPicture;
                    dbEntry.Answer = feedback.Answer;
                    dbEntry.City = feedback.City;
                    dbEntry.Text = feedback.Text;
                    dbEntry.Show = feedback.Show;
                }
            }
            this.SaveChanges();
        }
        #endregion
        public void AddWordsSearch(string word)
        {
            this.WordsSearch.Add(new WordsSearch {Word=word });
            this.SaveChanges();
        }



        public Product DeleteProduct(int productId)
        {
            Product dbEntry = this.Products.Find(productId);
            if (dbEntry != null)
            {
                this.Products.Remove(dbEntry);
                this.SaveChanges();
            }
            return dbEntry;
        }
    }
}
