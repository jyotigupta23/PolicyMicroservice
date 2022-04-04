using Policy_Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Services
{
    public interface IPolicyService
    {
        List<Policy> GetPolicies();

        void AddPolicy(Policy data);

        void UpdatePolicy(Policy data);

        void DeletePolicy(int id);

        Policy GetPolicyDataMethod(int id);

    }
}
