using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Policy_Microservice.Model;
using Policy_Microservice.Services;
using Policy_Microservice.Repository;
using Policy_Microservice.Controllers;
using Microsoft.AspNetCore.Http;

namespace Policy_Microservice.Testing
{
    public class AutomaticUnitTests
    {
        List<AvesMeta> aves = new List<AvesMeta>();
        readonly AutomaticController autoController;
        readonly AutomaticService autoService;
        private readonly Mock<IAutomaticService> mockService = new Mock<IAutomaticService>();
        private readonly Mock<IAutomaticRepository> mockRepository = new Mock<IAutomaticRepository>();

        public AutomaticUnitTests()
        {
            autoController = new AutomaticController(mockService.Object);
            autoService = new AutomaticService(mockRepository.Object);
        }
        [SetUp]
        public void Setup()
        {
            AvesMeta aves = new AvesMeta()
             {
                 CONSUMER_ID = 7,
                 PROPERTY_ID = 2,
                 POLICY_ID = 1,
                 AGENT = "Rahul",
                 STATUS = 6,
                 PROPERTY_TYPE = "Building",
                 BUSINESS_VALUE = 5,
                 PROPERTY_VALUE = 2


             };


            mockService.Setup(x => x.IssuePolicy(aves));
            mockRepository.Setup(x => x.IssuePolicy(aves));
        

            AvesMeta obj = new AvesMeta();
            obj.CONSUMER_ID = 3;
            obj.POLICY_ID = 1;
            obj.PROPERTY_ID = 2;
            obj.PROPERTY_TYPE = "";
            obj.PROPERTY_VALUE = 5; 
            obj.BUSINESS_VALUE = 5;
            obj.AGENT = "";
            obj.STATUS = 4;

        }

        //[Test]
        //public void returnIssuePolicy_Is_Valid()
        //{
        //    AvesMeta aves = new AvesMeta()
        //    {
        //        CONSUMER_ID = 7,
        //        PROPERTY_ID = 2,
        //        POLICY_ID = 1,
        //        AGENT = "Rahul",
        //        STATUS = 6,
        //        PROPERTY_TYPE = "Building",
        //        BUSINESS_VALUE = 5,
        //        PROPERTY_VALUE = 2
        //    };

        //     StatusCodeResult result = autoController.IssuePolicy(aves) as StatusCodeResult;
        //     Assert.AreEqual(200, result.StatusCode);

           
        //}

    }
}
