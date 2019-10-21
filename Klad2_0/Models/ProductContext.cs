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

        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public void SaveProduct(Product product)
        {
            if (product.Id == 0)
                this.Products.Add(product);
            else
            {
                Product dbEntry = this.Products.Find(product.Id);
                if (dbEntry != null)
                {
                    dbEntry.Name = product.Name;
                    dbEntry.Description = product.Description;
                    dbEntry.Price = product.Price;
                    dbEntry.Category = product.Category;
                    dbEntry.Category2 = product.Category2;
                    dbEntry.Category3 = product.Category3;
                    dbEntry.Category4 = product.Category4;
                    dbEntry.Category5 = product.Category5;
                    dbEntry.Address = product.Address;
                    dbEntry.Composition = product.Composition;
                    dbEntry.Contraindications = product.Contraindications;
                    dbEntry.FormRelease = product.FormRelease;
                    dbEntry.IndicationsForUse = product.IndicationsForUse;
                    //dbEntry.MainCategory1 = product.MainCategory1;
                    //dbEntry.MainCategory2 = product.MainCategory2;
                    //dbEntry.MainCategory3 = product.MainCategory3;
                    //dbEntry.SubCategory1 = product.SubCategory1;
                    //dbEntry.SubCategory2 = product.SubCategory2;
                    //dbEntry.SubCategory3 = product.SubCategory3;
                    //dbEntry.SubCategory4 = product.SubCategory4;
                    //dbEntry.SubCategory5 = product.SubCategory5;
                    //dbEntry.SubCategory6 = product.SubCategory6;
                    dbEntry.StorageConditions = product.StorageConditions;
                    dbEntry.FullDescription = product.FullDescription;
                    dbEntry.ShelfLife = product.ShelfLife;
                    dbEntry.MethodOfUse= product.MethodOfUse;
                    dbEntry.ImageData = product.ImageData;
                    dbEntry.ImageMimeType = product.ImageMimeType;
                    dbEntry.CompositionEvening = product.CompositionEvening;
                    dbEntry.CompositionMorning = product.CompositionMorning;

                    //todo
                    //dbEntry.ImageData = product.ImageData;
                    //dbEntry.ImageMimeType = product.ImageMimeType;
                }
            }
            this.SaveChanges();
        }


        public Product DeleteGame(int productId)
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
