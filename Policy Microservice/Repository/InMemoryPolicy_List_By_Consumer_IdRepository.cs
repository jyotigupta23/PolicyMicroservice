using Policy_Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Repository
{
    public class InMemoryPolicy_List_By_Consumer_IdRepository : IPolicy_List_By_Consumer_IdRepository
    {
        private List<Aves> list = new List<Aves>();
        public List<Aves> GetAves(int Property_Id)
        {
            return list.Where(x => x.PROPERTY_ID == Property_Id).ToList();
        }

        public void DeleteAvesByPropertyId(int Property_Id)
        {
            var dataList = list.Where(x => x.ID == Property_Id).ToList();
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
