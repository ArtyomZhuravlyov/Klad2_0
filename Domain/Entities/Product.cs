
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
        ///// <summary>
        ///// Отображается ли в ТОП
        ///// </summary>
        //public bool Favourite { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }

        //[Display(Name = "Основная категория 1")]
        //public string MainCategory1 { get; set; }

        //[Display(Name = "Основная категория 2")]
        //public string MainCategory2 { get; set; }

        //[Display(Name = "Основная категория 3")]
        //public string MainCategory3 { get; set; }

        //[Display(Name = "Под Категория 1")]
        //public string SubCategory1 { get; set; }

        //[Display(Name = "Под Категория 2")]
        //public string SubCategory2 { get; set; }

        //[Display(Name = "Под Категория 3")]
        //public string SubCategory3 { get; set; }

        //[Display(Name = "Под Категория 4")]
        //public string SubCategory4 { get; set; }

        //[Display(Name = "Под Категория 5")]
        //public string SubCategory5 { get; set; }

        //[Display(Name = "Под Категория 6")]
        //public string SubCategory6 { get; set; }

        /// <summary>
        /// Состав
        /// </summary>
        [Display(Name = "Состав")]
        public string Composition { get; set; }

        /// <summary>
        /// Показания к применению
        /// </summary>
        [Display(Name = "Показания к применению")]
        public string IndicationsForUse { get; set; }

        /// <summary>
        /// Способ применения
        /// </summary>
        [Display(Name = "Способ применения")]
        public string MethodOfUse { get; set; }

        /// <summary>
        /// Противопоказания
        /// </summary>
        [Display(Name = "Противопоказания")]
        public string Contraindications { get; set; }

        /// <summary>
        /// Условия хранения
        /// </summary>
        [Display(Name = "Условия хранения")]
        public string StorageConditions { get; set; }

        /// <summary>
        /// Срок годности
        /// </summary>
        [Display(Name = "Срок годности")]
        public string ShelfLife { get; set; }

        /// <summary>
        /// Форма выпуска
        /// </summary>
        [Display(Name = "Форма выпуска")]
        public string FormRelease { get; set; }



        //[Display(Name = "Картинка")]
        //public byte[] Picture { get; set; }

    }
}
