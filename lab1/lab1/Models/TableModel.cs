using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab1.Models
{
    public class TableModel
    {
        public string Name { get; set; }
        public int NumberOfAttributes { get; set; }
        public IEnumerable<Attribute> Attributes { get; set; }
    }
}
