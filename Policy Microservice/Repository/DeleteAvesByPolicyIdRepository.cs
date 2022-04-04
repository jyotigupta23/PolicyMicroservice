using Policy_Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Repository
{
    public class DeleteAvesByPolicyIdRepository : IDeleteAvesByPolicyIdRepository
    {
        private readonly ApplicationDBContext _context;
        public DeleteAvesByPolicyIdRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public void DeleteAves(int Policy_Id)
        {
            var aves = _context.Aves.Where(x => x.POLICY_ID == Policy_Id).ToList();
            foreach (var d in aves)
            {
                _context.Aves.Remove(d);
                _context.SaveChanges();
            }
        }
    }
}
