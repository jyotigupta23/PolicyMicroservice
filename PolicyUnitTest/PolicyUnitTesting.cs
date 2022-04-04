using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using Policy_Microservice.Controllers;
using Policy_Microservice.Model;
using Policy_Microservice.Repository;
using Policy_Microservice.Services;
using System.Collections.Generic;
using System.Linq;



namespace PolicyTest
{
    public class PolicyControllerTest
    {
        List<Policy> policy = new List<Policy>();
        readonly PolicyController policyController;
        readonly PolicyService policyService;
        private readonly Mock<IPolicyService> mockService = new Mock<IPolicyService>();
        private readonly Mock<IPolicyRepository> mockRepository = new Mock<IPolicyRepository>();



        public PolicyControllerTest()
        {
            policyController = new PolicyController(mockService.Object);
            policyService = new PolicyService(mockRepository.Object);
        }
        [SetUp]
        public void Setup()
        {
            policy = new List<Policy>()
            {
             new Policy{ID = 7,
                PROPERTY_TYPE = "Building",
                CONSUMER_TYPE = "Owner",
                ASSURED_SUM = 20000000,
                TENURE = 36,
                BUSINESS_VALUE = 8,
                PROPERTY_VALUE = 5,
                BASE_LOCATION = "Chennai",
                TYPE = "Replacement"},
             new Policy{ ID = 7,
                PROPERTY_TYPE = "Factory Equipment",
                CONSUMER_TYPE = "Owner",
                ASSURED_SUM = 40000,
                TENURE = 12,
                BUSINESS_VALUE = 9,
                PROPERTY_VALUE = 10,
                BASE_LOCATION = "Chennai",
                TYPE = "Replacement"}

            };
                

        mockService.Setup(x => x.GetPolicies()).Returns(policy.ToList);



        mockRepository.Setup(x => x.GetPolicies()).Returns(policy.ToList);

        Policy obj = new Policy();
            obj.ID = 1;
            obj.PROPERTY_TYPE = "";
            obj.PROPERTY_VALUE = 5;
            obj.TENURE = 100;
            obj.TYPE = "";
        
            
        }

        /// <summary>
        /// Testing the Repository.
        /// </summary>
        [Test]
        public void GetRepositoryCase()
        {
            Mock<IPolicyRepository> mock = new Mock<IPolicyRepository>();
            mock.Setup(m => m.GetPolicies()).Returns(policy.ToList);
            List<Policy> p = mock.Object.GetPolicies();
            Assert.AreEqual(p, policy);
        }
        
       
        [Test]
        public void DeleteRepositoryCase()
        {
            Mock<IPolicyRepository> mock = new Mock<IPolicyRepository>();
            mock.Setup(m => m.DeletePolicy(2));
            List<Policy> p = mock.Object.GetPolicies();
            Assert.AreEqual(p, null);
        }
        [Test]
        public void GetByIdRepo()
        {
            Mock<IPolicyRepository> mock = new Mock<IPolicyRepository>();
            mock.Setup(m => m.GetPolicyDataMethod(1)).Returns(policy[0]);
            Policy p = mock.Object.GetPolicyDataMethod(1);
            Assert.AreEqual(p, policy[0]);
        }
        [Test]
        public void GetByIdService()
        {
            Mock<IPolicyService> mock = new Mock<IPolicyService>();
            mock.Setup(m => m.GetPolicyDataMethod(1)).Returns(policy[0]);
            Policy p = mock.Object.GetPolicyDataMethod(1);
            Assert.AreEqual(p, policy[0]);
        }        
        [Test]
        public void AddPolicyIsValid()
        {
        Policy policy = new Policy()
        {
            ID = 7,
            PROPERTY_TYPE = "Building",
            CONSUMER_TYPE = "Owner",
            ASSURED_SUM = 20000000,
            TENURE = 36,
            BUSINESS_VALUE = 8,
            PROPERTY_VALUE = 5,
            BASE_LOCATION = "Chennai",
            TYPE = "Replacement"
        };

            StatusCodeResult result = policyController.AddPolicy(policy) as StatusCodeResult;
            Assert.AreEqual(200, result.StatusCode);
           
            }
        [Test]
        public void UpdatePolicyIsValid()
        {
            Policy policy = new Policy()
            {
                ID = 7,
                PROPERTY_TYPE = "Building",
                CONSUMER_TYPE = "Owner",
                ASSURED_SUM = 20000000,
                TENURE = 36,
                BUSINESS_VALUE = 8,
                PROPERTY_VALUE = 5,
                BASE_LOCATION = "Chennai",
                TYPE = "Replacement"
            };
            StatusCodeResult result = policyController.UpdatePolicy(policy) as StatusCodeResult;
            Assert.AreEqual(200, result.StatusCode);

             }

        [Test]
        public void DeletePolicyIsValid()
        {
            Policy policy = new Policy()
            {
                ID = 7,
                PROPERTY_TYPE = "Building",
                CONSUMER_TYPE = "Owner",
                ASSURED_SUM = 20000000,
                TENURE = 36,
                BUSINESS_VALUE = 8,
                PROPERTY_VALUE = 5,
                BASE_LOCATION = "Chennai",
                TYPE = "Replacement"
            };
            StatusCodeResult result = policyController.DeletePolicy(policy.ID) as StatusCodeResult;
            Assert.AreEqual(200, result.StatusCode);
        }
       


    }
}