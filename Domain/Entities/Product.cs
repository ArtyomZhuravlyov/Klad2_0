
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Domain.Entities
{
    public class Product
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name = "Название")]
        public string Name { get; set; }

        [Display(Name = "Описание")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Категория1")]
        public string Category { get; set; }

        //один товар может принадлежать нескольким категориям
        [Display(Name = "Категория2")]
        public string Category2 { get; set; }
        [Display(Name = "Категория3")]
        public string Category3 { get; set; }
        [Display(Name = "Категория4")]
        public string Category4 { get; set; }
        [Display(Name = "Категория5")]
        public string Category5 { get; set; }

        [Display(Name = "Цена")]
        // public string Company { get; set; }
        public int Price { get; set; }

        [Display(Name = "Адрес картинки")]
        /// <summary>
        /// Адрес картинки (формируется по ID)
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Отображается ли в ТОП
        /// </summary>
        //public bool Favourite { get; set; }
    }
}
