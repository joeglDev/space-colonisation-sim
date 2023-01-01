using Spectre.Console;
using System.Text.Json;







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

        public void createSaveData()
        {
            //if save file found then increment id and add
            //read id and increment 
            //save new
            if (File.Exists("./data/saveData.json"))
            {
                string text = File.ReadAllText("./data/saveData.json");
                saveDataModel[]? saveData = JsonSerializer.Deserialize<saveDataModel[]>(text);
                int numOfSaves = saveData!.Length;
                int newID = numOfSaves += 1;
                //add data to arr
                List<saveDataModel> newData = new List<saveDataModel>();
                newData.Add( new saveDataModel()
                {
                    Id = newID,
                    civ = this.selectedCiv
                });
                
                //concat new newData list to saveData list
                List<saveDataModel> combinedData = saveData.Concat(newData).ToList();
                string json = JsonSerializer.Serialize(combinedData);
                File.WriteAllText("./data/saveData.json", json); 
            }
            else
            {
                //create new file if not found
                List<saveDataModel> _data = new List<saveDataModel>();
                _data.Add(new saveDataModel()
                {
                    Id = 1,
                    civ = this.selectedCiv
                });

                string json = JsonSerializer.Serialize(_data);
                File.WriteAllText("./data/saveData.json", json);
            }
        }
    }

    public class saveDataModel
    {
        public int Id { get; set; }
        public string? civ { get; set; }
    }

