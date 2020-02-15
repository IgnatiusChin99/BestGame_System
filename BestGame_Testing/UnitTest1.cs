using System;
using BestGame_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BestGame_Testing
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(Order);
        }

        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            Order.Status = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Order.Status, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            Order.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Order.DateAdded, TestData);
        }


        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            Order.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Order.OrderID, TestData);
        }


        [TestMethod]
        public void OrderInformationPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            Order.Info = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Order.Info, TestData);
        }

    }
}
