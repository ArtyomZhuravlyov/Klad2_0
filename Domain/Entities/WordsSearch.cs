using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
  public class WordsSearch
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Слова")]
        public string Word { get; set; }
    }
}
