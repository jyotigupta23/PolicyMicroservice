using Policy_Microservice.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Services
{
    public class DeleteAvesByPolicyIdService : IDeleteAvesByPolicyIdService
    {
        private readonly IDeleteAvesByPolicyIdRepository repository;
        public DeleteAvesByPolicyIdService(IDeleteAvesByPolicyIdRepository Qrepository)
        {
            repository = Qrepository;
        }
        public void DeleteAves(int Policy_Id) 
        {
            repository.DeleteAves(Policy_Id);
        }
    }
}
