//add additional classes e.g moons, asteroids etc
//classes should create random objects and 
//consider making unique classes for homeworlds e.g. earth constructor extends planets

namespace StellarObjectConstructors
{

    class SolarSystem
    {
        private List<StellarObject>? systemContents = new List<StellarObject>();
        public List<StellarObject>? SystemContents  // property
        {
            get { return systemContents; }
            set { systemContents = value; }
        }

        /*
        //constructor
                public SolarSystem(List<StellarObject> systemContent)
                {
                    systemContents = systemContent;
                }
                */

        //methods
        public void AddStellarObject(StellarObject obj)
        {
            this.SystemContents!.Add(obj);
        }
    }

    class StellarObject
    {
        public string Name  // property
        { get; set; }

        //constructor
        public StellarObject(string nameString)
        {
            Name = nameString; // Set the initial value for model
        }
    }


    class Star : StellarObject
    {

        public Star(string nameString) : base(nameString)
        {
            //add properties unique to stars


        }
    }

    class Planet : StellarObject
    {

        public Planet(string nameString) : base(nameString)
        {
            //add properties unique to planets


        }
    }

}