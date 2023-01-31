//add additional classes e.g moons, asteroids etc
//classes should create random objects and 
//consider making unique classes for homeworlds e.g. earth constructor extends planets

namespace StellarObjectConstructors
{

    /// <summary>
    /// Class <c>SolarSystem</c> Models a solar system.
    /// </summary>
    public class SolarSystem
    {

        /// <summary>
        /// Private field- a list containing each object within the solar system.
        /// </summary>
        private List<StellarObject>? systemContents = new List<StellarObject>();
        /// <summary>
        /// Gets and sets a list containing each object within the solar system.
        /// </summary>
        public List<StellarObject>? SystemContents  // property
        {
            get { return systemContents; }
            set { systemContents = value; }
        }

        //methods
        /// <summary>
        /// Method <c>AddStellarObject</c> adds a StellarObject type object to the SystemContents list.
        /// </summary>
        public void AddStellarObject(StellarObject obj)
        {
            this.SystemContents!.Add(obj);
        }

        /// <summary>
        /// Method <c>GetSystemContents</c> writes the contents of the SolarSystem instance to the console. 
        /// </summary>
        public void GetSystemContents()
        {

            //organise by type and get number of each
            foreach (var obj in this.SystemContents!)
            {
                string name = obj.Name;
                string type = obj.GetType().ToString()[26..];
                Console.WriteLine($"{type}: {name}");
            }
        }
    }

    /// <summary>
    /// Class <c>StellarObject</c> Models a stellar object.
    /// </summary>
    public class StellarObject
    {
        /// <summary>
        /// Gets and sets the name of the object.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets and sets the mass/ solar mass (1 M = 2 * 10**30 Kg) of the object.
        /// </summary>
        public double Mass { get; set; }
        /// <summary>
        /// Gets and sets the radius/ solar radius (1 R = 695,700 Km) of the object.
        /// </summary>
        public double Radius { get; set; }

        //constructor
        public StellarObject(string nameString, double massDouble, double radiusDouble)
        {
            Name = nameString; // Set the initial value for model
            Mass = massDouble;
            Radius = radiusDouble;
        }

        //methods 
        //methods
        /// <summary>
        /// Method <c>calculateGravity</c> calculates gravity of a object in m/s^2 from M and R.
        /// <remarks>Note- method is not very accurate. Seems to have small errors.</remarks>
        /// </summary>
        public double calculateGravity()
        {
            //calculate gravity from mass and radius
            //convert to SOLAR MASS
            double G = 6.67 * (Math.Pow(10, -11));
            double M = this.Mass * (2.000 * Math.Pow(10, 30));
            double R = this.Radius * (6.957 * Math.Pow(10, 8));
            double Gravity = Math.Round(G * M / (R * R), 3);
            return Gravity;
        }
    }

    /// <summary>
    /// Class <c>Star</c> An object which models a star.
    /// <seealso> Inherits from base: <c> StellarObject</c> </seealso>
    /// </summary>
    public class Star : StellarObject
    {
        //properties

        /// <summary>
        ///enum constants which correspond to the main sequence stage of the star.
        /// Note- get by double value 0= White Dwarf, 1= Main Sequence Star, 2= Red Giant 3= Blue Giant
        /// </summary>
        public enum MainSequenceStage
        {
            WhiteDwarf,
            MainSequence,
            RedGiant,
            BlueGiant,
        }

        public MainSequenceStage Stage { get; set; }

        /// <summary>
        /// Boolean value to state if the star is solar active ie more than twice as likely to pose a risk to terrestial life vs a Sol class Star.
        /// </summary>
        public bool isSolarActive { get; set; }

        //constructor
        public Star(string nameString, double massDouble, double radiusDouble, int stageInt, bool isSolarActiveBool) : base(nameString, massDouble, radiusDouble)
        {
            //add properties unique to stars
            this.Stage = (MainSequenceStage)Enum.ToObject(typeof(MainSequenceStage), stageInt);
            this.isSolarActive = isSolarActiveBool;
        }
    }

    /// <summary>
    /// Class <c>Sol</c> An object which models the start Sol.
    /// <seealso> Inherits from base: <c> Star</c> </seealso>
    /// </summary>
    public class Sol : Star
    {
        /// <summary>
        /// Gets and sets the name of the object.
        /// </summary>
        public new string Name { get; set; } = "Sol";
        /// <summary>
        /// Gets and sets the mass/ solar mass (1 M = 2 * 10**30 Kg) of the object.
        /// </summary>
        public new double Mass { get; set; } = 1;
        /// <summary>
        /// Gets and sets the radius/ solar radius (1 R = 695,700 Km) of the object.
        /// </summary>
        public new double Radius { get; set; } = 1;

        /// <summary>
        ///enum constants which correspond to the main sequence stage of the star.
        /// Note- get by double value 0= White Dwarf, 1= Main Sequence Star, 2= Red Giant 3= Blue Giant
        /// </summary>
        public new MainSequenceStage Stage { get; set; } = MainSequenceStage.MainSequence;

        /// <summary>
        /// Boolean value to state if the star is solar active ie more than twice as likely to pose a risk to terrestial life vs a Sol class Star.
        /// </summary>
        bool isSolarActiveBool = false;

        //constructor
        public Sol(string nameString = "Sol", double massDouble = 1, double radiusDouble = 1, int stageInt = 1, bool isSolarActiveBool = false) : base(nameString, massDouble, radiusDouble, stageInt, isSolarActiveBool)
        {
            //add properties unique to Sol

        }

    }

    /// <summary>
    /// Class <c>Vilous</c> An object which models the start Vilous.
    /// <seealso> Inherits from base: <c> Star </c> </seealso>
    /// </summary>
    public class Vilous : Star
    {
        /// <summary>
        /// Gets and sets the name of the object.
        /// </summary>
        public new string Name = "Vilous";
        /// <summary>
        /// Gets and sets the mass/ solar mass (1 M = 2 * 10**30 Kg) of the object.
        /// </summary>
        public new double Mass = 2;
        /// <summary>
        /// Gets and sets the radius/ solar radius (1 R = 695,700 Km) of the object.
        /// </summary>
        public new double Radius = 1.75;

        /// <summary>
        ///enum constants which correspond to the main sequence stage of the star.
        /// Note- get by double value 0= White Dwarf, 1= Main Sequence Star, 2= Red Giant 3= Blue Giant
        /// </summary>
        public new MainSequenceStage Stage { get; set; } = MainSequenceStage.MainSequence;

        /// <summary>
        /// Boolean value to state if the star is solar active ie more than twice as likely to pose a risk to terrestial life vs a Sol class Star.
        /// </summary>
        bool isSolarActiveBool = true;

        //constructor
        public Vilous(string nameString = "Vilous", double massDouble = 1, double radiusDouble = 1, int stageInt = 1, bool isSolarActiveBool = true) : base(nameString, massDouble, radiusDouble, stageInt, isSolarActiveBool)
        {
            //add properties unique to Sol

        }

    }


    /// <summary>
    /// Class <c>Planet</c> An object which models a Planet.
    /// <seealso> Inherits from base: <c> StellarObject</c> </seealso>
    /// </summary>
    public class Planet : StellarObject
    {



        /// <summary>
        /// Enum value which models the classification of a planet by composition.
        /// </summary>
        public enum PlanetComposition
        {
            Rocky,
            Earth_like,
            SuperEarth,
            GasGiant,
            IceGiant,
            BrownDwarf
        }

        /// <summary>
        ///Gets and sets the PlanetComposition of the object.
        /// </summary>
        public PlanetComposition Composition { get; set; }

        /// <summary>
        ///Gets and sets a boolean value representing the habitability of the planet.
        /// </summary>
        public bool IsHabitable { get; set; }

        //constructor
        public Planet(string nameString, double massDouble, double radiusDouble, int compositionInt, bool isHabitableBool) : base(nameString, massDouble, radiusDouble)
        {
            //add properties unique to planets
            this.Composition = (PlanetComposition)Enum.ToObject(typeof(PlanetComposition), compositionInt);
            this.IsHabitable = isHabitableBool;
        }
    }

    /// <summary>
    /// Class <c>Earth</c> An object which models the planet Earth.
    /// <seealso> Inherits from base: <c> Planet</c> </seealso>
    /// </summary>
    public class Earth : Planet
    {

        /// <summary>
        /// Gets and sets the name of the object.
        /// </summary>
        public new string Name { get; set; } = "Earth";
        /// <summary>
        /// Gets and sets the mass/ solar mass (1 M = 2 * 10**30 Kg) of the object.
        /// </summary>
        public new double Mass { get; set; } = 0.00000300273;
        /// <summary>
        /// Gets and sets the radius/ solar radius (1 R = 695,700 Km) of the object.
        /// </summary>
        public new double Radius { get; set; } = 0.00916794;

        /// <summary>
        /// Enum value which models the classification of a planet by composition.
        /// </summary>


        /// <summary>
        ///Gets and sets the PlanetComposition of the object.
        /// </summary>
        public new PlanetComposition Composition = PlanetComposition.Earth_like;

        /// <summary>
        ///Gets and sets a boolean value representing the habitability of the planet.
        /// </summary>
        public new bool IsHabitable = true;

        //constructor
        public Earth(string nameString = "Earth", double massDouble = 0.00000300273, double radiusDouble = 0.00916794, int compositionInt = 1, bool isHabitableBool = true) : base(nameString, massDouble, radiusDouble, compositionInt, isHabitableBool)
        {
            //add properties unique to planets

        }
    }

    /// <summary>
    /// Class <c>Tal</c> An object which models the planet Tal.
    /// <seealso> Inherits from base: <c> Planet</c> </seealso>
    /// </summary>
    public class Tal : Planet
    {

        /// <summary>
        /// Gets and sets the name of the object.
        /// </summary>
        public new string Name { get; set; } = "Tal";
        /// <summary>
        /// Gets and sets the mass/ solar mass (1 M = 2 * 10**30 Kg) of the object.
        /// </summary>
        public new double Mass { get; set; } = 0.0000065;
        /// <summary>
        /// Gets and sets the radius/ solar radius (1 R = 695,700 Km) of the object.
        /// </summary>
        public new double Radius { get; set; } = 0.0185;



        /// <summary>
        ///Gets and sets the PlanetComposition of the object.
        /// </summary>
        public new PlanetComposition Composition = PlanetComposition.SuperEarth;

        /// <summary>
        ///Gets and sets a boolean value representing the habitability of the planet.
        /// </summary>
        public new bool IsHabitable = true;

        //constructor
        public Tal(string nameString = "Tal", double massDouble = 0.0000065, double radiusDouble = 0.0185, int compositionInt = 1, bool isHabitableBool = true) : base(nameString, massDouble, radiusDouble, compositionInt, isHabitableBool)
        {
            //add properties unique to planets

        }



    }

}