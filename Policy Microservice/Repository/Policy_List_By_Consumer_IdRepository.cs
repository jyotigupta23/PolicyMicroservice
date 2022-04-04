using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Policy_Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Policy_Microservice.Repository
{
    public class Policy_List_By_Consumer_IdRepository : IPolicy_List_By_Consumer_IdRepository
    {
        private readonly ApplicationDBContext _context;
       
        public Policy_List_By_Consumer_IdRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public List<Aves> GetAves(int Property_Id)
        {
            /*
             var aves = _context.Aves.Where(x => x.PROPERTY_ID == Property_Id).ToList();
             List<Property> properties = new List<Property>();
             using (var client = new HttpClient())
             {
                 client.BaseAddress = new Uri("https://localhost:44360/api/");
                 var responseTask = client.GetAsync("Property");
                 responseTask.Wait();
                 var result = responseTask.Result;
                 if (result.IsSuccessStatusCode)
                 {
                     var reader = result.Content.ReadAsAsync<List<Property>>();
                     reader.Wait();
                     properties = reader.Result;
                 }
             }

             var consumer_id = properties.Where(x => x.ID == Property_Id).FirstOrDefault().CONSUMER_ID;

             var consumer = new Consumer();
             using (var client = new HttpClient())
             {
                 client.BaseAddress = new Uri("https://localhost:44360/api/");
                 var responseTask = client.GetAsync("Consumer/" + consumer_id);
                 responseTask.Wait();
                 var result = responseTask.Result;
                 if (result.IsSuccessStatusCode)
                 {
                     var reader = result.Content.ReadAsAsync<Consumer>();
                     reader.Wait();
                     consumer = reader.Result;
                 }
             }
             ReturnAvesWithConsumer data = new ReturnAvesWithConsumer();
             data.consumer = consumer;
             data.policies = aves;
             return data;
            */
            return _context.Aves.Where(x => x.PROPERTY_ID == Property_Id).ToList();
        }

        public void DeleteAvesByPropertyId(int Property_Id)
        {
            var aves = _context.Aves.Where(x => x.PROPERTY_ID == Property_Id).ToList();
            foreach (var data in aves)
            {
                _context.Aves.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
