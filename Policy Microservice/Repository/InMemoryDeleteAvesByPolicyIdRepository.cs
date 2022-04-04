using Policy_Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Repository
{
    public class InMemoryDeleteAvesByPolicyIdRepository : IDeleteAvesByPolicyIdRepository
    {
        private static List<Aves> list = new List<Aves>();
        public void DeleteAves(int Policy_Id)
        {
            var dataList = list.Where(x => x.POLICY_ID == Policy_Id).ToList();
            if (dataList != null)
            {
                foreach (var data in dataList)
                {
                    list.Remove(data);
                }
            }
        }
    }
}
