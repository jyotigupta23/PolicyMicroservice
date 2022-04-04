using Policy_Microservice.Model;
using Policy_Microservice.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Services
{
    public class AvesService : IAvesService
    {
        public readonly IAvesRepository repository;
        public AvesService(IAvesRepository Qrepository)
        {
            repository = Qrepository;
        }

        public void AddAves(Aves data)
        {
            repository.AddAves(data);
        }

        public void DeleteAves(int id)
        {
            repository.DeleteAves(id);
        }

        public List<Aves> Get()
        {
            return repository.Get();
        }

        public Aves GetAvesDataMethod(int id)
        {
            return repository.GetAvesDataMethod(id);
        }

        public void UpdateAves(Aves data)
        {
            repository.UpdateAves(data);
        }
    }
}
