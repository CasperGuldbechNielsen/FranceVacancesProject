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
            
        }

        [TestMethod]

        public void ApartmentRegionIsEmpty()
        {
            
        }

        [TestMethod]

        public void ApartmentCityIsNull()
        {
            
        }

        [TestMethod]

        public void ApartmentCityIsEmpty()
        {
            
        }

        [TestMethod]

        public void ApartmentRoomNumberIsNull()
        {
            
        }

        [TestMethod]

        public void ApartmentRoomNumberIsEmpty()
        {
            
        }

        [TestMethod]

        public void ApartmentCoverImageIsNull()
        {
            
        }

        [TestMethod]

        public void ApartmentCoverImageIsEmpty()
        {
            
        }

        [TestMethod]

        public void ApartmentInsideImageIsNull()
        {
            
        }

        [TestMethod]

        public void ApartmentInsideImageIsEmpty()
        {
            
        }

        [TestMethod]

        public void ApartmentRatingIsNull()
        {
            
        }

        [TestMethod]

        public void ApartmentRatingIsEmpty()
        {
            
        }

        [TestMethod]
        public void IsApartmentAvailableIsNull()
        {
            
        }

        [TestMethod]
        public void IsApartmentAvailableIsEmpty()
        {
            
        }

        [TestMethod]

        public void ApartmentPriceByNightIsNull()
        {
            
        }

        [TestMethod]
        public void ApartmentPriceByNightIsEmpty()
        {
            
        }

        [TestMethod]
        public void NumberOfNightSpentIsNull()
        {
            
        }

        [TestMethod]
        public void NumberOfNightSpentIsEmpty()
        {
            
        }

        [TestMethod]
        public void ApartmentPriceTotalIsNull()
        {
            
        }

        [TestMethod]
        public void ApartmentPriceTotalIsEmpty()
        {
            
        }
    }
}
