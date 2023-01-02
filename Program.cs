// See https://aka.ms/new-console-template for more information
using StellarObjectConstructors;
//run title screen
TitleScreen initTitle = new TitleScreen();
//initTitle.runTitle();

//testing init objects then feed into SolarSystemConstructot
Star Sol = new Star("Sol");
Planet Earth = new Planet("Earth");
SolarSystem SolSystem = new SolarSystem();
SolSystem.AddStellarObject(Sol);
SolSystem.AddStellarObject(Earth);







