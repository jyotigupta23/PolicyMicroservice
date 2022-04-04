
using Policy_Microservice.Model;
using Policy_Microservice.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Services
{
    public class PolicyService : IPolicyService
    {
        public readonly IPolicyRepository repository;
        public PolicyService(IPolicyRepository Qrepository)
        {
            repository = Qrepository;
        }

        public void AddPolicy(Policy data)
        {
            repository.AddPolicy(data);
            return;
        }

        public void DeletePolicy(int id)
        {
            repository.DeletePolicy(id);
            return;
        }

        public List<Policy> GetPolicies()
        {
            return repository.GetPolicies();
        }

        public Policy GetPolicyDataMethod(int id)
        {
            return repository.GetPolicyDataMethod(id);
        }

        public void UpdatePolicy(Policy data)
        {
            repository.UpdatePolicy(data);
        }
    }
}
