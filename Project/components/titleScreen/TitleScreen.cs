/// <summary>
/// Class <c>TitleScreen</c> Component of code which renders the title screen to the user on game boot.
/// </summary>
class TitleScreen
{

    //fields
    /// <summary>
    /// Title text to display to the user on game boot.
    /// </summary>
    public string TitleText = @"   _____                          ______      __            _            __  _                _____ _         
  / ___/____  ____ _________     / ____/___  / /___  ____  (_)________ _/ /_(_)___  ____     / ___/(_)___ ___ 
  \__ \/ __ \/ __ `/ ___/ _ \   / /   / __ \/ / __ \/ __ \/ / ___/ __ `/ __/ / __ \/ __ \    \__ \/ / __ `__ \
 ___/ / /_/ / /_/ / /__/  __/  / /___/ /_/ / / /_/ / / / / (__  ) /_/ / /_/ / /_/ / / / /   ___/ / / / / / / /
/____/ .___/\__,_/\___/\___/   \____/\____/_/\____/_/ /_/_/____/\__,_/\__/_/\____/_/ /_/   /____/_/_/ /_/ /_/ 
    /_/                                                                                                       
    
    A video game by Joe Gilbert
    Find me at: https://github.com/joeglDev
    
    This text based adventure will (eventually) simulate the progression of
    space-fairing civilisations from their home planet to the stars.
    Enjoy!
    
    Please select an option: (n = start a new game, l = load a game from file)";

    //methods
    /// <summary>
    /// Method <c>runTitle</c> Displays title text to the suer on game boot and asks if user will load a game or start a new game.
    /// </summary>
    public void runTitle()
    {
        Console.WriteLine(this.TitleText);
        string? selectOption = Console.ReadLine();
        if (selectOption == "n" || selectOption == "N")
        {
            NewGame startNewGame = new NewGame();
            startNewGame.createNewGame();


            //init save log
            //move to select civ options
        }
        else if (selectOption == "l" || selectOption == "L")
        {
            Console.WriteLine("IMPLEMENT LOAD FROM FILE HERE");
        }
    }
}