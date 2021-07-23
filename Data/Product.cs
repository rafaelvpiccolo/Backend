using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Data
{
    public class Product
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
