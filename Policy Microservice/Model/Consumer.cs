using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Model
{
    public class Consumer
    {
        public int ID { get; set; }
        public string CONSUMER_NAME { get; set; }
        public DateTime DATE_OF_BIRTH { get; set; }
        public string EMAIL { get; set; }
        public string PAN { get; set; }
        public string BUSINESS_TYPE { get; set; }
        public float ANNUAL_TURNOVER { get; set; }
        public int TOTAL_EMPLOYEES { get; set; }
        public string AGENT_NAME { get; set; }
        public string AGENT_COMPANY { get; set; }
    }
}
