using System;
using Hamburger_Heaven_Challenge.Models;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;


namespace UnitTestFranceVacances
{
    [TestClass]
    public class ApartmentClassTests
    {
        public Apartment TestApartment = new Apartment();
        

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
        public void ApartmentRegionIsNull()
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

        public void ApartmentRegionIsEmpty()
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

        public void ApartmentCityIsNull()
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

        public void ApartmentCityIsEmpty()
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

        public void ApartmentRoomNumberIsNull()
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

        public void ApartmentRoomNumberIsEmpty()
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

        public void ApartmentRatingIsNull()
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

        public void ApartmentRatingIsEmpty()
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
        public void IsApartmentAvailableIsNull()
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
        public void IsApartmentAvailableIsEmpty()
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

        public void ApartmentPriceByNightIsNull()
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
        public void ApartmentPriceByNightIsEmpty()
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
        public void NumberOfNightSpentIsNull()
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
        public void NumberOfNightSpentIsEmpty()
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
        public void ApartmentPriceTotalIsNull()
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
        public void ApartmentPriceTotalIsEmpty()
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
    }
}
