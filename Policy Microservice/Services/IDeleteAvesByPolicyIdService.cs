using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Services
{
    public interface IDeleteAvesByPolicyIdService
    {
        void DeleteAves(int Policy_Id);
    }
}
