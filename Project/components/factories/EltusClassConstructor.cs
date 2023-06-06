namespace CharacterConstructor {
    
    /// <summary>
    /// Class <c>Factions</c> Global class for character factions
    /// </summary>
    public class Factions {
        public static string SOLUN = "The Re-United Nations of Earth";
        public static string VILOUSSHIGU = "The Shigu Imperium";
        public static string VILOUSGR = "The Enlightened Kingdom of Gold Ring";
    }

    /// <summary>
    /// Class <c>Dispositions</c> Global class for character personality type
    /// </summary>
    public class Dispositions {
        public static string UPBEAT  = "Upbeat";
         public static string MELANCHOLIC = "Melancholic";
          public static string CURIOUS  = "Curious";
           public static string JOCK  = "Jock";
            public static string  SAINT = "Saint";
             public static string NEUROTIC  = "Neurotic";
    }


    /// <summary>
    /// Class <c>Person</c> Models a sapiant
    /// </summary>
    public class Person {

    public bool IsAlive { get; set; }
    public string Name { get; set; }
    public string? Faction { get; set; }
    public string? Disposition {get; set;}
    public string? Gender { get; set; }

     //constructor
        public Person(bool AliveBool, string NameString, string FactionString, string DispositionString, string GenderString)
        {
            IsAlive = AliveBool;
            Name = NameString;
            Faction = FactionString;
            Disposition = DispositionString;
            Gender = GenderString;
        }
    }
}