using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Policy_Microservice.Model;
using Policy_Microservice.Repository;

namespace Policy_Microservice.Services
{
    public class Policy_List_By_Consumer_IdService : IPolicy_List_By_Consumer_IdService
    {
        public readonly IPolicy_List_By_Consumer_IdRepository repository;
        public Policy_List_By_Consumer_IdService(IPolicy_List_By_Consumer_IdRepository Qrepository) 
        {
            repository = Qrepository;
        }
        public List<Aves> GetAves(int Property_Id) 
        {
            return repository.GetAves(Property_Id);
        }
        public void DeleteAvesByPropertyId(int Property_Id) 
        {
            repository.DeleteAvesByPropertyId(Property_Id);
        }

    }
}
