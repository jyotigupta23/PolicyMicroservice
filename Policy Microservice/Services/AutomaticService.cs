using Policy_Microservice.Model;
using Policy_Microservice.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Services
{
    public class AutomaticService : IAutomaticService
    {
        public readonly IAutomaticRepository repository;
        public AutomaticService(IAutomaticRepository Qrepository)
        {
            repository = Qrepository;
        }
        public void IssuePolicy(AvesMeta data)
        {
            repository.IssuePolicy(data);
            return;
        }

        public void DeletePoliciesByConsumerId(int Consumer_Id)
        {
            repository.DeletePoliciesByConsumerId(Consumer_Id);
        }
    }
}

