using Moq;
using NUnit.Framework;
using PackagingAndDelivery_Microservise;
using PackagingAndDelivery_Microservise.Controllers;
using PackagingAndDelivery_Microservise.Repositories;

namespace PackageAndDeliveryTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCaseForImplementedMethod()
        {
            var mock = new Mock<PackageAndDeliveryRepositry>();
            PackageAndDeliveryController packingdelivering = new PackageAndDeliveryController(mock.Object);
            Assert.AreEqual(6000, packingdelivering.PackagingAndDeliveryCharge("Integral", 20));
        }
        [Test]
        public void TestCaseForImplementedMetho()
        {
            var mock = new Mock<PackageAndDeliveryRepositry>();
            PackageAndDeliveryController packingdelivering = new PackageAndDeliveryController(mock.Object);
            Assert.AreEqual(300, packingdelivering.PackagingAndDeliveryCharge("Accessory", 2));
        }
        [Test]
        public void TestCaseForImplementedMeth()
        {
            var mock = new Mock<PackageAndDeliveryRepositry>();
            PackageAndDeliveryController packingdelivering = new PackageAndDeliveryController(mock.Object);
            Assert.AreEqual(50000, packingdelivering.PackagingAndDeliveryCharge("Protective sheath", 1000));
        }
    }
}