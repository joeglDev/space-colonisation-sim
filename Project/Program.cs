// See https://aka.ms/new-console-template for more information
using StellarObjectConstructors;
//run title screen
TitleScreen initTitle = new TitleScreen();
initTitle.runTitle();


//testing init objects then feed into SolarSystemConstructor

//create star Sol
Sol Sol = new Sol();
Console.WriteLine($"The life stage of the Star {Sol.Name} is {Sol.Stage}.");
//create solar system
SolarSystem SolSystem = new SolarSystem();
SolSystem.AddStellarObject(Sol);
SolSystem.GetSystemContents();
Console.WriteLine(Sol.calculateGravity());

Earth Earth = new Earth();
Tal Tal = new Tal();
Console.WriteLine(Earth.calculateGravity());
Console.WriteLine(Tal.calculateGravity());









