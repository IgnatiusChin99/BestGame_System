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


        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 Order_ID = 1;
            //invoke the method
            Found = Order.Find(Order_ID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }



        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 21;
            //invoke the method
            Found = Order.Find(OrderID);
            //check the address no
            if (Order.OrderID != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestDateAddedFound()
        {
            clsOrder Order = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 21;
            Found = Order.Find(OrderID);

            if(Order.DateAdded != Convert.ToDateTime("16/09/2019"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestStatusFound()
        {
            clsOrder Order = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 21;
            Found = Order.Find(OrderID);

            if (Order.Status != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestInformationFound()
        {
            clsOrder Order = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 21;
            Found = Order.Find(OrderID);
            if (Order.Info != "as")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }


    }
}
