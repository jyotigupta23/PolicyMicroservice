using Policy_Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Repository
{
    public class AvesRepository : IAvesRepository
    {
        private readonly ApplicationDBContext _context;
        public AvesRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public void AddAves(Aves data)
        {
            _context.Aves.Add(data);
            _context.SaveChanges();
            return;
        }

        public void DeleteAves(int id)
        {
            var data = _context.Aves.Where(x => x.ID == id).FirstOrDefault();
            _context.Aves.Remove(data);
            _context.SaveChanges();
            return;
        }

        public List<Aves> Get()
        {
            return _context.Aves.ToList();
        }

        public Aves GetAvesDataMethod(int id)
        {
            return _context.Aves.Where(x => x.ID == id).FirstOrDefault();
        }

        public void UpdateAves(Aves data)
        {
            _context.Entry(data).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return;
        }
    }
}
