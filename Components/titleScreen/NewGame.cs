using Spectre.Console;
using System.Text.Json;
using System;
using System.IO;

namespace makeNewGame
{




    class NewGame
    {

        private string? selectedCiv;

        //methods
        public void createNewGame()
        {
            //access civilisation Data
            civData civs = new civData();

            //console text
            Console.WriteLine(@"
        Hello, you are spark from which trillions will emerge,
        In order to start your journey we will need to ask you some questions.");

            //console choices
            string civChoice = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Please select your [green]home star system:[/]")
                .PageSize(10)
                .AddChoices(new[] {
            civs.civsDict["solUN"]["fullName"], civs.civsDict["vilousShigu"]["fullName"], civs.civsDict["vilousGold"]["fullName"]
                }));

            //convert text into var name
            //soceity is stored as a string: SystemSoceity
            if (civChoice == civs.civsDict["solUN"]["fullName"])
            {
                this.selectedCiv = "solUN";
            }
            else if (civChoice == civs.civsDict["vilousShigu"]["fullName"])
            {
                this.selectedCiv = "vilousShigu";
            }
            else if (civChoice == civs.civsDict["vilousGold"]["fullName"])
            {
                this.selectedCiv = "vilousGold";
            }
        
            // Echo 
            Console.WriteLine($"You choose to play as {civChoice}.");
            this.createSaveData();
        
        }

public void createSaveData() {
    //if save file found then increment id and add
        //read id and increment 
        //save new
if (File.Exists("./data/saveData.json")) {
    string text = File.ReadAllText("./data/saveData.json");
         data[]? saveData = JsonSerializer.Deserialize<data[]>(text);
        int numOfSaves = saveData.Length;
        int newID = numOfSaves += 1;
        //add data to arr
        
   // string newID = 
} else {
    //create new file if not found
List<data> _data = new List<data>();
_data.Add(new data()
{
    Id = 1,
    civ = this.selectedCiv
});

string json = JsonSerializer.Serialize(_data);
File.WriteAllText("./data/saveData.json", json);
}
}
    }

    public class data
{
    public int Id { get; set; }
    public string? civ {get; set;}
}
}
