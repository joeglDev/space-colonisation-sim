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
        public int Mass { get; set; }
        /// <summary>
        /// Gets and sets the radius/ solar radius (1 R = 695,700 Km) of the object.
        /// </summary>
        public int Radius { get; set; }

        //constructor
        public StellarObject(string nameString, int massInt, int radiusInt)
        {
            Name = nameString; // Set the initial value for model
            Mass = massInt;
            Radius = radiusInt;
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
        /// Note- get by int value 1= White Dwarf, 2= Main Sequence Star, 3= Red Giant 4= Blue Giant
        /// </summary>
        public enum MainSequenceStage
        {
            WhiteDwarf,
            MainSequence,
            RedGiant,
            BlueGiant,
        }

        public  MainSequenceStage Stage {get; set;}

        //constructor
        public Star(string nameString, int massInt, int radiusInt, MainSequenceStage stage) : base(nameString, massInt, radiusInt)
        {
            //add properties unique to stars
           // MainSequenceStage Stage = (MainSequenceStage) sequenceStageInt;
           this.Stage = stage;

           

        }
    }

    /// <summary>
    /// Class <c>Planet</c> An object which models a Planet.
    /// <seealso> Inherits from base: <c> StellarObject</c> </seealso>
    /// </summary>
    public class Planet : StellarObject
    {
        //constructor
        public Planet(string nameString, int massInt, int radiusInt) : base(nameString, massInt, radiusInt)
        {
            //add properties unique to planets


        }
    }



}