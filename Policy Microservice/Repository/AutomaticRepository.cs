using Microsoft.AspNetCore.Http;
using Policy_Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Policy_Microservice.Repository
{
    public class AutomaticRepository : IAutomaticRepository
    {
        private readonly ApplicationDBContext _context;
        public AutomaticRepository(ApplicationDBContext context)
        {
            _context = context;

        }

        public void IssuePolicy(AvesMeta data)
        {
            


            List<QuoteView> list = new List<QuoteView>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44349/api/Quotes/"); // Quotes Microservice
                var responseTask = client.GetAsync("GetQuotes");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var reader = result.Content.ReadAsAsync<List<QuoteView>>();
                    reader.Wait();
                    list = reader.Result;
                }
            }
            var quote_view = list.Where(x => (x.MaxBusinessValue >= data.BUSINESS_VALUE && x.MinBusinessValue <= data.BUSINESS_VALUE) &&
            (x.MaxPropertyValue >= data.PROPERTY_VALUE && x.MinPropertyValue <= data.PROPERTY_VALUE) &&
            (x.PropertyType.ToUpper().Equals(data.PROPERTY_TYPE.ToUpper()))).FirstOrDefault();

            Aves aves = new Aves();
            aves.CONSUMER_ID = data.CONSUMER_ID;
            aves.PROPERTY_ID = data.PROPERTY_ID;
            aves.POLICY_ID = data.POLICY_ID;
            aves.QUOTE = quote_view.QuoteValue;
            aves.AGENT = data.AGENT;
            aves.STATUS = data.STATUS;

            _context.Aves.Add(aves);
            _context.SaveChanges();
        }

        public void DeletePoliciesByConsumerId(int Consumer_Id)
        {
            var policies = _context.Aves.Where(x => x.CONSUMER_ID == Consumer_Id).ToList();
            foreach (var d in policies)
            {
                _context.Aves.Remove(d);
                _context.SaveChanges();
            }
        }
    }
}

