using POO_C_.Models;

namespace POO_C_.Menus;

internal class RateBandMenu : Menu
{
    public override void Exe(Dictionary<string, Band> bandsList)
    {
        base.Exe(bandsList);
        DisplayOptionTitle("Rate a band");
        Console.Write("Enter the band you want to rate: ");
        string bandName = Console.ReadLine()!;
        if (bandsList.ContainsKey(bandName))
        {
            Band band = bandsList[bandName];
            Console.Write("\nEnter the band's rating: ");
            Evaluation rate = Evaluation.Parse(Console.ReadLine()!);
            if (rate.Rate >= 0 && rate.Rate <= 10)
            {
                band.Rate(rate);
                Thread.Sleep(2000);
                Console.WriteLine($"\nNote {rate.Rate} has been successfully registered for the {bandName} band!");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nInvalid grade. Grade must be between 0 and 10.\n");
                Console.Write("Press a key to try again\n");
                Console.ReadKey();
                Console.Clear();
                return;
            }
        }
        else
        {
            Console.WriteLine($"\nThe band {bandName} is not registered.\n");
            Console.Write("Press a key to return to the menu\n");
            Console.ReadKey();
            Console.Clear();
        }
    }
}