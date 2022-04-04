using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Repository
{
    public interface IDeleteAvesByPolicyIdRepository
    {
        void DeleteAves(int Policy_Id);
    }
}
