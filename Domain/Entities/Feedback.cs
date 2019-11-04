using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
   public class Feedback
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Display(Name = "Город")]
        public string City { get; set; }

        [Display(Name = "Адрес картинки")]
        public string AdressPicture { get; set; }

        [Display(Name = "Текст")]
        public string Text { get; set; }

        [Display(Name = "Показывать")]
        public bool Show { get; set; }
    }
}
