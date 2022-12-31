using Spectre.Console;

class NewGame
{

    //methods
    public void createNewGame()
    {
        Console.WriteLine(@"
        Hello, you are spark from which trillions will emerge,
        In order to start your journey we will need to ask you some questions.");

        //console choices
        string homeStar = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("Please select your [green]home star system:[/]")
            .PageSize(10)
            .AddChoices(new[] {
            "Sol", "Vilous"
            }));

        // Echo 
        Console.WriteLine($"Your soceity was founded in the {homeStar} system.");
        //add civ bios
        //recrd new game to json
        





    }

}