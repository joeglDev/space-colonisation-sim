using Spectre.Console;

class NewGame
{
    private string? soceity;

    //methods
    public void createNewGame()
    {
        Console.WriteLine(@"
        Hello, you are spark from which trillions will emerge,
        In order to start your journey we will need to ask you some questions.");



        //console choices
        string soceityChoice = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("Please select your [green]home star system:[/]")
            .PageSize(10)
            .AddChoices(new[] {
            "The Re-United Nations of Earth", "The Shigu Imperium", "The Enlightened Kingdom of Gold Ring"
            }));

        //convert text into var name
        switch (soceityChoice)
        {
            case "The Re-United Nations of Earth":
                this.soceity = soceityChoice;
                break;
            case "The Shigu Imperium":
                this.soceity = soceityChoice;
                break;
            case "The Enlightened Kingdom of Gold Ring":
            this.soceity = soceityChoice;
            break;
        }

        // Echo 
        Console.WriteLine($"You choose to play as {this.soceity}.");
        //add civ bios
        //recrd new game to json






    }

}