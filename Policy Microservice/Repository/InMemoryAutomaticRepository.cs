using Policy_Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Policy_Microservice.Repository
{
    public class InMemoryAutomaticRepository : IAutomaticRepository
    {
        private static List<AvesMeta> list = new List<AvesMeta>();
        public void IssuePolicy(AvesMeta data)
        {
            list.Add(data);
        }

        public void DeletePoliciesByConsumerId(int Consumer_Id)
        {
            var data = list.FirstOrDefault(x => x.CONSUMER_ID == Consumer_Id);
            list.Remove(data);
        }
    }
}
