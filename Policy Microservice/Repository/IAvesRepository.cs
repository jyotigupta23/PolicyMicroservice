using Policy_Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Repository
{
    public interface IAvesRepository
    {
        List<Aves> Get();

        void AddAves(Aves data);

        void UpdateAves(Aves data);

        void DeleteAves(int id);

        Aves GetAvesDataMethod(int id);
    }
}
