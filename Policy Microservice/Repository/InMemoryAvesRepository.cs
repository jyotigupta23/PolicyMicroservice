using Policy_Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Repository
{
    public class InMemoryAvesRepository : IAvesRepository
    {
        private static List<Aves> assignedData = new List<Aves>();
        public void AddAves(Aves data)
        {
            if(assignedData.Count > 0)
            {
                data.ID = assignedData.Max(x => x.ID) + 1;
            }
            else
            {
                data.ID = 1;
            }
            assignedData.Add(data);
            return;
        }

        public void DeleteAves(int id)
        {
            var data = assignedData.FirstOrDefault(x => x.ID == id);
            if (data != null)
            {
                assignedData.Remove(data);
            }
            return;
        }

        public List<Aves> Get()
        {
            return assignedData;
        }

        public Aves GetAvesDataMethod(int id)
        {
            return assignedData.FirstOrDefault(x => x.ID == id);
        }

        public void UpdateAves(Aves data)
        {
            var element = assignedData.FirstOrDefault(x => x.ID == data.ID);
            if (element != null)
            {
                element.AGENT = data.AGENT;
                element.CONSUMER_ID = data.CONSUMER_ID;
                element.POLICY_ID = data.POLICY_ID;
                element.PROPERTY_ID = data.PROPERTY_ID;
                element.QUOTE = data.QUOTE;
                element.STATUS = data.STATUS;
            }
            return;
        }
    }
}
