using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Klad.Models
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public void SaveGame(Product product)
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
