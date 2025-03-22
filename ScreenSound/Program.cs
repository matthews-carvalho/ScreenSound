Dictionary<String, List<int>> registeredBands = new();

void Menu()
{
    Console.WriteLine("1. Register Band");
    Console.WriteLine("2. Display Bands");
    Console.WriteLine("3. Rate Band");
    Console.WriteLine("4. Display Band Details");
    Console.WriteLine("0. Exit");

    Console.Write("Choose an option: ");
    string option = Console.ReadLine()!;
    int intOption = int.Parse(option);

    switch (intOption)
    {
        case 1:
            RegisterBand();
            break;
        case 2:
            DisplayBands();
            break;
        case 3:
            RateBand();
            break;
        case 4:
            Console.WriteLine("Display Band Details");
            break;
        case 0:
            return;
        default:
            Console.WriteLine("Invalid option");
            break;
    }
}

void RegisterBand()
{
    Console.Clear();
    Console.WriteLine("*************");
    Console.WriteLine("Register Band");
    Console.WriteLine("*************");
    Console.Write("\nEnter the band's name: ");
    string bandName = Console.ReadLine()!;
    registeredBands.Add(bandName, new List<int>());
    Console.WriteLine($"\nBand {bandName} has been registered successfully");
    Thread.Sleep(3000);
    Console.Clear();
    Menu();
}

void DisplayBands()
{
    Console.Clear();
    Console.WriteLine("*************");
    Console.WriteLine("Display Bands");
    Console.WriteLine("*************");
    for (int i = 0; i < registeredBands.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {registeredBands.Keys.ElementAt(i)}");
    }
    Console.WriteLine("\nPress any key to return to the menu...");
    Console.ReadKey();
    Console.Clear();
    Menu();
}

void RateBand()
{
    Console.Clear();
    Console.WriteLine("*************");
    Console.WriteLine("Rate Band");
    Console.WriteLine("*************");
    Console.WriteLine("Enter the band's name: ");
    string bandName = Console.ReadLine()!;
    if (registeredBands.ContainsKey(bandName))
    {
        Console.WriteLine("Enter the rating: ");
        int rating = int.Parse(Console.ReadLine()!);
        registeredBands[bandName].Add(rating);
        Console.WriteLine("Rating added successfully");
    }
    else
    {
        Console.WriteLine("Band not found");
    }
    Thread.Sleep(3000);
    Console.Clear();
    Menu();
}

void DisplayBandDetails()
{
    Console.Clear();
    Console.WriteLine("********************");
    Console.WriteLine("Display Band Details");
    Console.WriteLine("********************");
    Console.Write("Enter the band's name: ");
    string bandName = Console.ReadLine()!;
    if (registeredBands.ContainsKey(bandName))
    {
        List<int> ratings = registeredBands[bandName];
        Console.WriteLine($"Band: {bandName}");
        Console.WriteLine($"Ratings: {string.Join(", ", ratings)}");
        Console.WriteLine($"Average rating: {ratings.Average()}");
    }
    else
    {
        Console.WriteLine("Band not found");
    }
    Thread.Sleep(3000);
    Console.Clear();
    Menu();
}

Menu();