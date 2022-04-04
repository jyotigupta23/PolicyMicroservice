using Policy_Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Repository
{
    public interface IAutomaticRepository
    {
        void IssuePolicy(AvesMeta data);
        void DeletePoliciesByConsumerId(int Consumer_Id);
    }
}
