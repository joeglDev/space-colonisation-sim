//add additional classes e.g moons, asteroids etc
//classes should create random objects and 
//consider making unique classes for homeworlds e.g. earth constructor extends planets

namespace StellarObjectConstructors
{

    /// <summary>
    /// Class <c>SolarSystem</c> Models a solar system.
    /// </summary>
    class SolarSystem
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
    class StellarObject
    {
        /// <summary>
        /// Gets and sets the name of the object.
        /// </summary>
        public string Name  // property
        { get; set; }

        //constructor
        public StellarObject(string nameString)
        {
            Name = nameString; // Set the initial value for model
        }
    }

    /// <summary>
    /// Class <c>Star</c> An object which models a star.
    /// <seealso> Inherits from base: <c> StellarObject</c> </seealso>
    /// </summary>
    class Star : StellarObject
    {
        //constructor
        public Star(string nameString) : base(nameString)
        {
            //add properties unique to stars


        }
    }

    /// <summary>
    /// Class <c>Planet</c> An object which models a Planet.
    /// <seealso> Inherits from base: <c> StellarObject</c> </seealso>
    /// </summary>
    class Planet : StellarObject
    {
        //constructor
        public Planet(string nameString) : base(nameString)
        {
            //add properties unique to planets


        }
    }

}