string player;
int cpu;

string[] options = new string[] { "rock", "paper", "scissors" };

do
{
    Console.Write("Choose your play [ Rock, Paper, Scissors ]: ");
    player = Console.ReadLine().ToLower();
} while (!options.Contains(player));

Random rand = new Random();
cpu = rand.Next(0, 3);

switch (cpu)
{
    case 0:
        Console.WriteLine("\nCPU choose ROCK");
        if(player == "rock")
            Console.WriteLine("It's a draw!");
        else if(player == "paper")
            Console.WriteLine("Player wins!");
        else
            Console.WriteLine("CPU wins!");
        break;

    case 1:
        Console.WriteLine("\nCPU choose PAPER");
        if (player == "rock")
            Console.WriteLine("CPU wins!");
        else if (player == "paper")
            Console.WriteLine("It's a draw!");
        else
            Console.WriteLine("Player wins!");
        break;

    case 2:
        Console.WriteLine("\nCPU choose SCISSORS");
        if (player == "rock")
            Console.WriteLine("Player wins!");
        else if (player == "paper")
            Console.WriteLine("CPU wins!");
        else
            Console.WriteLine("It's a draw!");
        break;
}