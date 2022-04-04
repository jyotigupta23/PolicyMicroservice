using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Model
{
    public class QuoteView
    {
        public int ID { get; set; }
        public int MaxBusinessValue { get; set; }
        public int MinBusinessValue { get; set; }
        public int MaxPropertyValue { get; set; }
        public int MinPropertyValue { get; set; }
        public string PropertyType { get; set; }
        public float QuoteValue { get; set; }
    }
}
