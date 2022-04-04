using Policy_Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Services
{
    public interface IPolicy_List_By_Consumer_IdService
    {
        List<Aves> GetAves(int Property_Id);
        void DeleteAvesByPropertyId(int Property_Id);
    }
}
