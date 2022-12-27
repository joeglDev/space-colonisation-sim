class TitleScreen {

    //fields
public string TitleText = @"   _____                          ______      __            _            __  _                _____ _         
  / ___/____  ____ _________     / ____/___  / /___  ____  (_)________ _/ /_(_)___  ____     / ___/(_)___ ___ 
  \__ \/ __ \/ __ `/ ___/ _ \   / /   / __ \/ / __ \/ __ \/ / ___/ __ `/ __/ / __ \/ __ \    \__ \/ / __ `__ \
 ___/ / /_/ / /_/ / /__/  __/  / /___/ /_/ / / /_/ / / / / (__  ) /_/ / /_/ / /_/ / / / /   ___/ / / / / / / /
/____/ .___/\__,_/\___/\___/   \____/\____/_/\____/_/ /_/_/____/\__,_/\__/_/\____/_/ /_/   /____/_/_/ /_/ /_/ 
    /_/                                                                                                       
    
    A video game by Joe Gilbert
    Find me at: https://github.com/joeglDev
    
    This text based adventure will (eventually) simulate the progression of
    space-fairing civilisation from their home planet to the stars.
    Enjoy!";

    //methods
     public void runTitle() {
        Console.WriteLine(this.TitleText);
    }
}