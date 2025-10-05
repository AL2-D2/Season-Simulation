

string? menuSelection;
string team = "Team";
string points = "Points";
do
{
    Console.ForegroundColor = ConsoleColor.Black;
    System.Console.WriteLine("\nWelcome to Turkish Super League season simulation!\n");
    Console.ResetColor();
    System.Console.WriteLine("Select an option: ");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    System.Console.WriteLine("New Simulation");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.DarkRed;
    System.Console.WriteLine("Exit");
    Console.ResetColor();


    menuSelection = Console.ReadLine();

    
} while (menuSelection?.ToLower().Trim() != "exit" && menuSelection.ToLower().Trim() != "new simulation");

if (menuSelection.ToLower().Trim() == "new simulation")
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    System.Console.Write("\nYou selected:");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    System.Console.WriteLine(" 'New Simulation'\n");
    Console.ResetColor();
    System.Console.WriteLine("New season begins!\n\n");
    Console.ReadLine();
    System.Console.WriteLine("First week table: \n");
    System.Console.WriteLine($"{team}\t\t {points}");
}
