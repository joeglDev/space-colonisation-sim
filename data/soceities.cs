/*{
    "solUN": {"fullName": "The Re-United Nations of Earth", "flavourText": ""},
    "vilousShigu": {"fullName": "The Shigu Imperium", "flavourText": ""},
    "vilousGold": {"fullName": "The Enlightened Kingdom of Gold Ring", "flavourText": ""}
}
*/
class civData
{


    public Dictionary<string, Dictionary<string, string>> civsDict =
        new Dictionary<string, Dictionary<string, string>>
        {
        {
            "solUN",
            new Dictionary<string, string>
            {
                {"fullName", "The Re-United Nations of Earth"},
                {"flvourText", "By the late 23rd century humanity has weathered climate change, wars and Kessler syndrome and emerged stronger. The many peoples of the Planet Earth have united and ventured forth to explore their native Sol system."}
            }
        },
        {
             "vilousShigu",
            new Dictionary<string, string>
            {
                {"fullName", "The Shigu Imperium"},
                {"flvourText", "Consisting predominantly Northern Sergals hailing from the Vilous system; the Shigu Imperium has risen from the collapse of world peace on the planet Tal. Having reached its limits on its hostile homeworld the empire looks to the stars for further expansion plans."}
            }
        },
         {
             "vilousGold",
            new Dictionary<string, string>
            {
                {"fullName", "The Enlightened Kingdom of Gold Ring"},
                {"flvourText", "Lying across the wastes of Southern Deserts lies the prosperous mega city of Gold Ring. Made up of the Sergals, Agudner and Nevreans hailing from the Planet Tal the Kingdom's current ruler has experienced a divine revalation and seeks to head towards the brightest starts in search of revelation."}
            }
        }
        };

}