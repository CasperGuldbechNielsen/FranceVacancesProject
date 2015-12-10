using System;
using Hamburger_Heaven_Challenge.Models;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;


namespace UnitTestFranceVacances
{
    [TestClass]
    public class ApartmentClassTests
    {
        public Apartment TestApartment = new Apartment();

        private double MinRating = 0;
        private double MaxRating = 5;

        private double MinPrice = 0;
        private double MaxPrice = 500;

        private double MinTotalPrice = 0;

        

        [TestMethod]

        public void ApartmentIdIsNull()
        {
            Exception caughtException = null;
            try
            {
                TestApartment.ApartmentId = null;
            }  
            catch (Exception exceptionThrown)
            {
                caughtException = exceptionThrown;
            }
            Assert.IsNotNull(caughtException);

        }

        [TestMethod]

        public void ApartmentIdIsEmpty()
        {

            Exception caughtException = null;
            try
            {
                TestApartment.ApartmentId = "";
            }
            catch (Exception exceptionThrown)
            {
                caughtException = exceptionThrown;
            }
            Assert.IsNotNull(caughtException);
        }
        
        [TestMethod]

        public void ApartmentCoverImageIsNull()
        {
            Exception caughtException = null;
            try
            {
                TestApartment.ApartmentCoverImage = null;
            }
            catch (Exception exceptionThrown)
            {
                caughtException = exceptionThrown;
            }
            Assert.IsNotNull(caughtException);
        }

        [TestMethod]

        public void ApartmentCoverImageIsEmpty()
        {
            Exception caughtException = null;
            try
            {
                TestApartment.ApartmentId = "";
            }
            catch (Exception exceptionThrown)
            {
                caughtException = exceptionThrown;
            }
            Assert.IsNotNull(caughtException);
        }

        [TestMethod]

        public void ApartmentInsideImageIsNull()
        {
            Exception caughtException = null;
            try
            {
                TestApartment.ApartmentInsideImage = null;
            }
            catch (Exception exceptionThrown)
            {
                caughtException = exceptionThrown;
            }
            Assert.IsNotNull(caughtException);
        }

        [TestMethod]

        public void ApartmentInsideImageIsEmpty()
        {
            Exception caughtException = null;
            try
            {
                TestApartment.ApartmentId = "";
            }
            catch (Exception exceptionThrown)
            {
                caughtException = exceptionThrown;
            }
            Assert.IsNotNull(caughtException);
        }

        [TestMethod]

        public void TestMinRating()
        {
            TestApartment.ApartmentRating = MinRating;
            Assert.AreEqual(MinRating, TestApartment.ApartmentRating);
        }

        [TestMethod]
        
        public void TestLessMinRating()
        {
            Exception caughtException = null;
            try
            {
                TestApartment.ApartmentRating = MinRating - 1;
            }
            catch (Exception exceptionThrown)
            {
                caughtException = exceptionThrown;
            }
            Assert.IsNotNull(caughtException);
        }


        [TestMethod]

        public void TestMaxRating()
        {
            TestApartment.ApartmentRating = MaxRating;
            Assert.AreEqual(MaxRating, TestApartment.ApartmentRating);
        }

        [TestMethod]

        public void TestMoreMaxRating()
        {
            Exception caughtException = null;
            try
            {
                TestApartment.ApartmentRating = MaxRating + 1;
            }
            catch (Exception exceptionThrown)
            {
                caughtException = exceptionThrown;
            }
            Assert.IsNotNull(caughtException);
        }

        
        [TestMethod]

        public void TestMinPrice()
        {
            TestApartment.ApartmentPriceByNight = MinPrice;
            Assert.AreEqual(MinPrice, TestApartment.ApartmentPriceByNight);
        }

        [TestMethod]
        public void TestLessMinPrice()
        {
            Exception caughtException = null;
            try
            {
                TestApartment.ApartmentPriceByNight = MinPrice - 1;
            }
            catch (Exception exceptionThrown)
            {
                caughtException = exceptionThrown;
            }
            Assert.IsNotNull(caughtException);
        }

        [TestMethod]
        public void TestMaxPrice()
        {
            TestApartment.ApartmentPriceByNight = MaxPrice;
            Assert.AreEqual(MaxPrice, TestApartment.ApartmentPriceByNight);
        }

        [TestMethod]
        public void TestMoreMaxPrice()
        {
            Exception caughtException = null;
            try
            {
                TestApartment.ApartmentPriceByNight = MaxPrice + 1;
            }
            catch (Exception exceptionThrown)
            {
                caughtException = exceptionThrown;
            }
            Assert.IsNotNull(caughtException);
        }

        [TestMethod]
        public void TestTotalPriceMin()
        {
            TestApartment.ApartmentPriceTotal = MinTotalPrice;
            Assert.AreEqual(MinTotalPrice, TestApartment.ApartmentPriceTotal);
        }

        [TestMethod]
        public void TestTotalPriceLessMin()
        {
            Exception caughtException = null;
            try
            {
                TestApartment.ApartmentPriceTotal = MinTotalPrice - 1;
            }
            catch (Exception exceptionThrown)
            {
                caughtException = exceptionThrown;
            }
            Assert.IsNotNull(caughtException);
        }
    }
}
