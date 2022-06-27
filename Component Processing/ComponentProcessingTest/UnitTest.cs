using Component_Processing.Controllers;
using Component_Processing.Models;
using Component_Processing.Repositry;
using Moq;
using NUnit.Framework;
using System;

namespace ComponentProcessingTest
{
    public class UnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var mock = new Mock<ComponentRepo>();
            ComponentProcessingController component = new ComponentProcessingController(mock.Object);
            ProcessResponse r = new ProcessResponse();
            ProcessRequest p = new ProcessRequest();
            p.Name = "Harsh";
            p.ContactNumber = 7894561230;
            p.CreditCardNumber = 1111444477778888;
            p.ComponentType = "Integral";
            p.ComponentName = "IC";
            p.Quantity = 2;
            p.IsPriorityRequest = true;
            Assert.NotNull(component.ComponentProcessing(p));
        }

        /*[Test]
        public void Test2()
        {
            var mock = new Mock<PaymentRepository>();
            PaymentsController payments = new PaymentsController(mock.Object);
            Assert.AreEqual(0, payments.GetpaymentDetails(2, 12345678, 6000, 6000));
        }

        [Test]
        public void PaymentTestPass3()
        {
            var mock = new Mock<PaymentRepository>();
            PaymentsController payments = new PaymentsController(mock.Object);
            Assert.AreEqual(-1, payments.GetpaymentDetails(3, 12345678, 5000, 6000));
        }*/
    }
}
