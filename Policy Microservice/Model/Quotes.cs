using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Model
{
    public class Quotes
    {
        public float BusinessValue { get; set; }
        public float PropertyValue { get; set; }
        public string PropertyType { get; set; }
        public float QuoteValue { get; set; }
    }
}
