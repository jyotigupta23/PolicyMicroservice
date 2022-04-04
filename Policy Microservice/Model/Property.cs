using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Model
{
    public class Property
    {
        public int ID { get; set; }
        public int CONSUMER_ID { get; set; }
        public string BUILDING_TYPE { get; set; }
        public int BUILDING_AGE { get; set; }
        public int STOREYS { get; set; }
        public float AREA { get; set; }
    }
}
