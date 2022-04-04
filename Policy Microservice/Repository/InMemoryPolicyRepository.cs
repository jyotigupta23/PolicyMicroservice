using Policy_Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Repository
{
    public class InMemoryPolicyRepository : IPolicyRepository
    {
        private static List<Policy> policies = new List<Policy>();
        public InMemoryPolicyRepository()
        {
            
        }

        public void AddPolicy(Policy data)
        {
            if (policies.Count > 0)
            {
                var maxPolicyId = policies.Max(x => x.ID);
                data.ID = maxPolicyId + 1;
            }
            else
            {
                data.ID = 1;
            }
            policies.Add(data);
            return;
        }

        public void DeletePolicy(int id)
        {
            var policy = policies.FirstOrDefault(x => x.ID == id);
            if(policy != null)
                policies.Remove(policy);
            return;
        }

        public List<Policy> GetPolicies()
        {
            return policies;
        }

        public Policy GetPolicyDataMethod(int id)
        {
            return policies.FirstOrDefault(x => x.ID == id);
        }

        public void UpdatePolicy(Policy data)
        {
            var policy = policies.FirstOrDefault(x => x.ID == data.ID);
            if (policy != null)
            {
                policy.ASSURED_SUM = data.ASSURED_SUM;
                policy.BASE_LOCATION = data.BASE_LOCATION;
                policy.BUSINESS_VALUE = data.BUSINESS_VALUE;
                policy.CONSUMER_TYPE = data.CONSUMER_TYPE;
                policy.PROPERTY_TYPE = data.PROPERTY_TYPE;
                policy.PROPERTY_VALUE = data.PROPERTY_VALUE;
                policy.TENURE = data.TENURE;
                policy.TYPE = data.TYPE;
            }
            return;
        }
    }
}
