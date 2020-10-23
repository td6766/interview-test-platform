using NUnit.Framework;

namespace Checkout.Tests
{
    public class ExampleTests
    {

        [Test]
        public void Test0()
        {
            // Arrange
            Till till = new Till();
            
            // Act
            // Scan nothing
            
            // 
            NUnit.Framework.Assert.AreEqual(0, till.Total());
        }

        
        [Test]
        public void Given_A_TotalPrice_ShouldBe_50()
        {
            // Arrange
            var till = new Till();
            
            // Act
            till.Scan("A");
            
            // NUnit.Framework.Assert
            NUnit.Framework.Assert.AreEqual(50.0, till.Total());
        }
    
        [Test]
        public void Given_AB_TotalPrice_ShouldBe_80()
        {
            // Arrange
            var till = new Till();

            // Act
            till.Scan("AB");
            
            // Assert
            Assert.AreEqual(80.0, till.Total());
        }    

        [Test]
        public void Given_CDBA_TotalPrice_ShouldBe_115()
        {
            Till till = new Till();
            till.Scan("CDBA");
            NUnit.Framework.Assert.AreEqual(115.0, till.Total());
        }

        [Test]
        public void Given_TwoItemsOfTypeA_TotalPrice_ShouldBe_100()
        {
            // Arrange
            Till till = new Till();
            
            // Act
            till.Scan("AA");
            
            Assert.AreEqual(100, till.Total());
        }

        [Test]
        public void Given_TwoItemsOfTypeB_TotalPrice_ShouldBe_45()
        {
            // Arrange
            Till till = new Till();
            
            // Act
            till.Scan("BB");
            
            // Assert
            Assert.AreEqual(45, till.Total());
        }
        [Test]
        public void Given_ThreeItemsOfTypeA_TotalPrice_ShouldBe_130()
        {
            // Arrange
            Till till = new Till();
            
            // Act
            till.Scan("AAA");
            
            // Assert
            Assert.AreEqual(130, till.Total());
        }

        [Test]
        public void Given_TwoAAItems_TotalPrice_ShouldBe_180()// This is wrong so I changed it to be two AA items test should be
        {
            // Arrange
            Till till = new Till();
            
            // Act
            till.Scan("AAAA");
            
            // Assert
            Assert.AreEqual(180, till.Total());
        }

        [Test]
        public void Given_7CItems_TotalPrice_ShouldBe_120()// Added an extra test to check the Max of 6 items
        {
            // Arrange
            Till till = new Till();
            
            // Act
            till.Scan("CCCCCCC");
            
            // Assert
            Assert.AreEqual(120, till.Total());
        }
        
    }
}