using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Model
{
    public class ReturnAvesWithConsumer
    {
        public Consumer consumer { get; set; }
        public List<Aves> policies { get; set; }
    }
}
