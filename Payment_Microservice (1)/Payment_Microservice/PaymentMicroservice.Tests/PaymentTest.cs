using Moq;
using NUnit.Framework;
using Payment_Microservice.Controllers;
using Payment_Microservice.Repositories;

namespace PaymentMicroservice.Tests
{
    public class PaymentTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PaymentTestPass1()
        {
            var mock = new Mock<PaymentRepository>();
            PaymentsController payments = new PaymentsController(mock.Object);
            Assert.AreEqual(1000, payments.GetpaymentDetails(1, 9876543210122334, 7000, 6000));
        }

        [Test]
        public void PaymentTestPass2()
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
        }
    }
}