using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Model
{
    public class Aves
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int CONSUMER_ID { get; set; }
        public int PROPERTY_ID { get; set; }
        public int POLICY_ID { get; set; }
        public float QUOTE { get; set; }
        public string AGENT { get; set; }
        public int STATUS { get; set; }
    }
}
