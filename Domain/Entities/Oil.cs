using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Oil
    {
        public int OilId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
    }
}
