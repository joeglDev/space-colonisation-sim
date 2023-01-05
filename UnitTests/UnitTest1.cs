using Xunit;
using StellarObjectConstructors;

//Assert.Equal(4, Add(2, 2)); // Asser.Equal(expected ans, func())

namespace UnitTests
{
    /// <summary>
    /// Class <c> StarObjectFactoriesUnitTests</c> xunit unit testing class to test properties of class Star.
    /// </summary>
    public class StarObjectFactoriesUnitTests
    {
        [Fact]
         /// <summary>
    /// Method <c>NamePropertyTest</c> tests properties of namespace StarObject class properties.
    /// </summary>
        public void PropertyTestStellarObject()
        {
            //passed constructor properties of StellarObject
            Assert.Equal("name", TestStar.Name);
            Assert.Equal(2, TestStar.Mass);
            Assert.Equal(3,TestStar.Radius);
             Assert.Equal(Star.MainSequenceStage.MainSequence, TestStar.Stage);
           
        }

        //setup
        Star TestStar = new Star("name", 2, 3, Star.MainSequenceStage.MainSequence);  
        
    }

     /// <summary>
    /// Class <c> StellarObjectFactoriesUnitTests</c> xunit unit testing class to test properties of namespace StellarObjectConstructors.
    /// </summary>
    public class StellarObjectFactoriesUnitTests
    {
        [Fact]
         /// <summary>
    /// Method <c>NamePropertyTest</c> tests properties of namespace StellarObject class properties.
    /// </summary>
        public void PropertyTestStellarObject()
        {
            //passed constructor properties of StellarObject
            Assert.Equal("name", TestStellarObject.Name);
            Assert.Equal(1, TestStellarObject.Mass);
            Assert.Equal(3, TestStellarObject.Radius);
            //randomely assigned properties
        }

        //setup
        StellarObject TestStellarObject = new StellarObject("name", 1, 3);   
    }

    /* Theories take multiple runs of tests and are sometimes exoected to sometimes return false
[Theory]
[InlineData(3)]
[InlineData(5)]
[InlineData(6)]
public void MyFirstTheory(int value)
{
    Assert.True(IsOdd(value));
}

bool IsOdd(int value)
{
    return value % 2 == 1;
}
    */
}