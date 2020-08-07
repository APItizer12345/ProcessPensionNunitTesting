using NUnit.Framework;
using ProcessPension;
using ProcessPension.Controllers;
using System;

namespace ProcessPensionTest
{
    public class Tests
    {
        ProcessPensionController controller = new ProcessPensionController();

        ClientInput client1 = new ClientInput();
        ClientInput client2 = new ClientInput();

        [SetUp]
        public void Setup()
        {
            client1.name = "Surabhi";
            client1.dateOfBirth = Convert.ToDateTime("1998-08-01");
            client1.pan = "BCDVN1234F";
            client1.aadharNumber = "511122223331";
            client1.pensionType = 1;

            //client2.name = "Suraj";
            //client2.dateOfBirth = Convert.ToDateTime("1998-08-01");
            //client2.pan = "BCDVN1234F";
            //client2.aadharNumber = "511122223333";
            //client2.pensionType = 1;

            client2.name = "Surabhi";
            client2.dateOfBirth = Convert.ToDateTime("1998-08-01");
            client2.pan = "BCDVN1234F";
            client2.aadharNumber = "";
            client2.pensionType = 1;

        }

        [Test]
        public void Test1()
        {
            var result = controller.GetClient(client1);
            var type1 = result;
            //var type1 = 10;
            Assert.IsNotNull(type1);
        }

        [Test]
        public void Test2()
        {
            var result = controller.GetClient(client1);
            var type1 = result.status;
            //var type1 = 10;

            Assert.Positive(type1);
        }

        [Test]
        public void ProcessPension_Person_Valid()
        {
            var result = controller.GetClient(client1);
            int type = result.status;
            int statusCode = 20;
            Assert.AreEqual(type, statusCode);
        }

        [Test]
        public void ProcessPension_Person_Invalid()
        {
            var result = controller.GetClient(client1);
            var type = result.status;
            var statusCode = 10;
            //Assert.AreEqual(type, statusCode);
            Assert.AreNotEqual(type, statusCode);
        }
    }
}
