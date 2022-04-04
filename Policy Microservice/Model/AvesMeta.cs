using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Model
{
    public class AvesMeta
    {
        public int CONSUMER_ID { get; set; }
        public int PROPERTY_ID { get; set; }
        public int POLICY_ID { get; set; }
        public string AGENT { get; set; }
        public int STATUS { get; set; }
        public string PROPERTY_TYPE { get; set; }
        public int BUSINESS_VALUE { get; set; }
        public int PROPERTY_VALUE { get; set; }
    }
}
