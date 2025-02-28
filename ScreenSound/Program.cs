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
            Console.WriteLine("Register Band");
            break;
        case 2:
            Console.WriteLine("Display Bands");
            break;
        case 3:
            Console.WriteLine("Rate Band");
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

Menu();