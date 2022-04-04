using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Model
{
    public class Policy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string PROPERTY_TYPE { get; set; }
        public string CONSUMER_TYPE { get; set; }
        public float ASSURED_SUM { get; set; }
        public int TENURE { get; set; }
        public int BUSINESS_VALUE { get; set; }
        public int PROPERTY_VALUE { get; set; }
        public string BASE_LOCATION { get; set; }
        public string TYPE { get; set; }
    }
}
