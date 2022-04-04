using Policy_Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Repository
{
    public class PolicyRepository : IPolicyRepository
    {
        private readonly ApplicationDBContext _context;
        public PolicyRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public void AddPolicy(Policy data)
        {
            _context.Policies.Add(data);
            _context.SaveChanges();
            return;
        }

        public void DeletePolicy(int id)
        {
            var data = _context.Policies.Where(x => x.ID == id).FirstOrDefault();
            _context.Policies.Remove(data);
            _context.SaveChanges();
            return;
        }

        public List<Policy> GetPolicies()
        {
            return _context.Policies.ToList();
        }

        public Policy GetPolicyDataMethod(int id)
        {
            return _context.Policies.Where(x => x.ID == id).FirstOrDefault();
        }

        public void UpdatePolicy(Policy data)
        {
            _context.Entry(data).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return;
        }
    }
}
