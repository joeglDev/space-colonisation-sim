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
        /// Method <c>PropertyTestStar</c> tests properties of namespace StarObject class properties.
        /// </summary>
        public void PropertyTestStar()
        {
            //passed constructor properties of StellarObject
            Assert.Equal("name", TestStar.Name);
            Assert.Equal(2, TestStar.Mass);
            Assert.Equal(3, TestStar.Radius);
            Assert.Equal(Star.MainSequenceStage.MainSequence, TestStar.Stage);

        }

        [Fact]
        /// <summary>
        /// Method <c>PropertyTestSolVilous</c> tests properties of namespace Sol and Vilous class properties.
        /// </summary>
        public void PropertyTestSolVilous()
        {
            //passed constructor properties of StellarObject
            Assert.Equal("Sol", TestSol.Name);
            Assert.Equal(1, TestSol.Mass);
            Assert.Equal(1, TestSol.Radius);
            Assert.Equal(Star.MainSequenceStage.MainSequence, TestSol.Stage);
            Assert.Equal(false, TestSol.isSolarActive);

              Assert.Equal("Vilous", Vilous.Name);
            Assert.Equal(2, Vilous.Mass);
            Assert.Equal(1.75, Vilous.Radius);
            Assert.Equal(Star.MainSequenceStage.MainSequence, Vilous.Stage);
            Assert.Equal(true, Vilous.isSolarActive);

        }

        //setup
        Star TestStar = new Star("name", 2, 3, 1, true);
        Sol TestSol = new Sol();

        Vilous Vilous = new Vilous();

    }

    /// <summary>
    /// Class <c> StellarObjectFactoriesUnitTests</c> xunit unit testing class to test properties of namespace StellarObjectConstructors.
    /// </summary>
    public class StellarObjectFactoriesUnitTests
    {
        [Fact]
        /// <summary>
        /// Method <c>calculateGravityTest</c> tests properties of namespace StellarObject class properties.
        /// </summary>
        public void calculateGravityTest()
        {
            //passed constructor properties of StellarObject
            Assert.Equal(275.621, Sol.calculateGravity());
             Assert.Equal(9.847, X.calculateGravity());
            
            //randomely assigned properties
        }

        //setup
        Sol Sol = new Sol();
        Planet X= new Planet("Earth", 0.00000300273, 0.00916794, 0, true);
       
        [Fact]
        /// <summary>
        /// Method <c>PropertyTestStellarObject</c> tests properties of namespace StellarObject class properties.
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


     /// <summary>
    /// Class <c> PlanetFactoriesUnitTests</c> xunit unit testing class to test properties of class Planet.
    /// </summary>
    public class PlanetFactoriesUnitTests
    {
        [Fact]
        /// <summary>
        /// Method <c>PropertyTestPlanet</c> tests properties of class Planet class properties.
        /// </summary>
        public void PropertyTestPlanet()
        {
            //passed constructor properties of StellarObject
            Assert.Equal("name", TestPlanet.Name);
            Assert.Equal(1, TestPlanet.Mass);
            Assert.Equal(3, TestPlanet.Radius);
            Assert.Equal(Planet.PlanetComposition.SuperEarth, TestPlanet.Composition);
            Assert.Equal(false, TestPlanet.IsHabitable);
            //randomely assigned properties
        }

          [Fact]
        /// <summary>
        /// Method <c>PropertyTestUniquePlanets</c> tests properties of class Earth and Tal class properties.
        /// </summary>
        public void PropertyTestUniquePlanets()
        {
            //passed constructor properties of Earth
            Assert.Equal("Earth", Earth.Name);
            Assert.Equal(0.00000300273, Earth.Mass);
            Assert.Equal(0.00916794, Earth.Radius);
            Assert.Equal(Earth.PlanetComposition.Earth_like, Earth.Composition);
            Assert.Equal(true, Earth.IsHabitable);

             //passed constructor properties of Tal
            Assert.Equal("Tal", Tal.Name);
            Assert.Equal(0.0000065, Tal.Mass);
            Assert.Equal(0.0185, Tal.Radius);
            Assert.Equal(Tal.PlanetComposition.SuperEarth,Tal.Composition);
            Assert.Equal(true, Tal.IsHabitable);
          
        }

        //setup
        Planet TestPlanet = new Planet("name", 1, 3, 2, false);

        Planet X = new Planet("Earth", 0.00000300273, 0.00916794, 0, true);

        //unique planets
        Earth Earth = new Earth();
        Tal Tal = new Tal();
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


//various planet instances 