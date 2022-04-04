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
    public class AvesControllerTest
    {
        List<Aves> aves = new List<Aves>();
        readonly AvesController avesController;
        readonly AvesService avesService;
        private readonly Mock<IAvesService> mockService = new Mock<IAvesService>();
        private readonly Mock<IAvesRepository> mockRepository = new Mock<IAvesRepository>();



        public AvesControllerTest()
        {
            avesController = new AvesController(mockService.Object);
            avesService = new AvesService(mockRepository.Object);
        }
        [SetUp]
        public void Setup()
        {
                aves = new List<Aves>()
            {
                new Aves {
                ID = 7,
                CONSUMER_ID = 5,
                PROPERTY_ID = 2,
                POLICY_ID = 2,
                QUOTE = 6,
                AGENT = "Rohan",
                STATUS = 5},

                new Aves {
                ID = 2,
                CONSUMER_ID = 15,
                PROPERTY_ID = 5,
                POLICY_ID = 3,
                QUOTE = 36,
                AGENT = "Ranjan",
                STATUS = 2},
            };


            mockService.Setup(x => x.Get()).Returns(aves.ToList);



            mockRepository.Setup(x => x.Get()).Returns(aves.ToList);

            Aves obj = new Aves();
            obj.ID = 1;
            obj.POLICY_ID = 2;
            obj.PROPERTY_ID = 5;
            obj.QUOTE = 3;
            obj.STATUS = 5;

        }

        /// <summary>
        /// Testing the Repository
        /// </summary>
        [Test]
        public void GetRepositoryCase()
        {
            Mock<IAvesRepository> mock = new Mock<IAvesRepository>();
            mock.Setup(m => m.Get()).Returns(aves.ToList);
            List<Aves> p = mock.Object.Get();
            Assert.AreEqual(p, aves);
        }
        [Test]
        public void DeleteRepositoryCase()
        {
            Mock<IAvesRepository> mock = new Mock<IAvesRepository>();
            mock.Setup(m => m.DeleteAves(2));
            List<Aves> p = mock.Object.Get();
            Assert.AreEqual(p, null);
        }

        [Test]
        public void GetServiceCase()
        {
            Mock<IAvesService> mock = new Mock<IAvesService>();
            mock.Setup(m => m.Get()).Returns(aves.ToList);
            List<Aves> p = mock.Object.Get();
            Assert.AreEqual(p, aves);
        }
        [Test]
        public void DeleteServiceCase()
        {
            Mock<IAvesService> mock = new Mock<IAvesService>();
            mock.Setup(m => m.DeleteAves(1));
            List<Aves> p = mock.Object.Get();
            Assert.AreEqual(p, null);
        }
        [Test]
        public void GetById()
        {
            Mock<IAvesService> mock = new Mock<IAvesService>();
            mock.Setup(m => m.GetAvesDataMethod(1)).Returns(aves[0]);
            Aves p = mock.Object.GetAvesDataMethod(1);
            Assert.AreEqual(p, aves[0]);
        }

        /// <summary>
        /// Testing the Controllers 
        /// </summary>

        [Test]
        public void ReturnValidAvesAdded_Is_Valid()
        {
            Aves aves = new Aves()
            {
                ID = 2,
                CONSUMER_ID = 15,
                PROPERTY_ID = 5,
                POLICY_ID = 3,
                QUOTE = 36,
                AGENT = "Ranjan",
                STATUS = 2
            
            };

            StatusCodeResult result = avesController.AddAves(aves) as StatusCodeResult;
            Assert.AreEqual(200, result.StatusCode);

        }



        [Test]
        public void UpdateTest()
        {
            Aves aves = new Aves()
            {
                ID = 2,
                CONSUMER_ID = 15,
                PROPERTY_ID = 5,
                POLICY_ID = 3,
                QUOTE = 36,
                AGENT = "Ranjan",
                STATUS = 2
            };
            StatusCodeResult result = avesController.UpdateAves(aves) as StatusCodeResult;
            Assert.AreEqual(200, result.StatusCode);
        }

        public void DeleteAvesTest()
        {
            List<Aves> aves = new List<Aves>()
            {
                new Aves {
                ID = 7,
                CONSUMER_ID = 5,
                PROPERTY_ID = 2,
                POLICY_ID = 2,
                QUOTE = 6,
                AGENT = "Rohan",
                STATUS = 5}
            };
            StatusCodeResult result = avesController.DeleteAves(7) as StatusCodeResult;
            Assert.AreEqual(200, result.StatusCode);
        }

    }
}