using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klad2_0.Domain.Entities
{
    class ShippingDetails
    {
        [Required]
        public string Name { get; set; }

        [Required(ErrorMessage = "Вставьте первый адрес доставки")]
        public string Line1 { get; set; }


        [Required(ErrorMessage = "Укажите город")]
        public string City { get; set; }

        public bool GiftWrap { get; set; }
    }
}
