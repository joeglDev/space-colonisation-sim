using Spectre.Console;
using System.Text.Json;






/// <summary>
/// Class <c>NewGame</c> components of code which process starting a new game file..
/// </summary>
class NewGame
{
    /// <summary>
    /// holds the short name of the civilisation that the player has chosen to play as.
    /// </summary>
    private string? selectedCiv;

    //methods
    /// <summary>
    /// Method <c>createNewGame</c> summarises the game and asks player questions to set up new game save data.
    /// </summary>
    public void createNewGame()
    {
        //access civilisation Data
        CivData civs = new CivData();

        //console text
        Console.WriteLine(@"
        Hello, you are spark from which trillions will emerge,
        In order to start your journey we will need to ask you some questions.
        
        Please press any key to continue
        ");

        //wait
        Console.ReadLine();

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

    /// <summary>
    /// Method <c>createSaveData</c> uses class properties to save player game setup data to a .json file.
    /// </summary>
    public void createSaveData()
    {
        //if save file found then increment id and add
        //read id and increment 
        //save new
        try
        {
            if (File.Exists("./data/saveData.json"))
            {
                string text = File.ReadAllText("./data/saveData.json");
                SaveDataModel[]? saveData = JsonSerializer.Deserialize<SaveDataModel[]>(text);
                int numOfSaves = saveData!.Length;
                int newID = numOfSaves += 1;
                //add data to arr
                List<SaveDataModel> newData = new List<SaveDataModel>();
                newData.Add(new SaveDataModel()
                {
                    Id = newID,
                    civ = this.selectedCiv
                });

                //concat new newData list to saveData list
                List<SaveDataModel> combinedData = saveData.Concat(newData).ToList();
                string json = JsonSerializer.Serialize(combinedData);
                File.WriteAllText("./data/saveData.json", json);
            }
            else
            {
                //create new file if not found
                List<SaveDataModel> _data = new List<SaveDataModel>();
                _data.Add(new SaveDataModel()
                {
                    Id = 1,
                    civ = this.selectedCiv
                });

                string json = JsonSerializer.Serialize(_data);
                File.WriteAllText("./data/saveData.json", json);
            }
            Console.WriteLine(@"Save data successfully created. 

        Press any key to continue:
        ");
            Console.ReadLine();
        }
        catch
        {
            Console.WriteLine("Sorry an error occured please try again.");
        }
    }
}



