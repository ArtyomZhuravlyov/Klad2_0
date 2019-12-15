using Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Klad2_0.Models
{
    public class OrderEditViewModal
    {
       public Order order { get; set; }

        public List<XmlCartLine> XmlCartLineList { get; set; }


    }
}
