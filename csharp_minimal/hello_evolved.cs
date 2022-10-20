Console.WriteLine("Welcome to Hello Evolved.");        
demo_loops();
Console.WriteLine("The demonstration is complete. Thank you for using Hello Evolved.");

static void demo_loops()
{
    Console.WriteLine("This program will demonstrate a loop. Please enter a string of characters and then press the 'enter' key. Alternatively, you can type 'stop' and then press the 'enter' key to end the loop demonstration.");
    List<string> loop_list = new List<string>();
    while (true)
    {
        Console.Write(">");
        string? loop_input = Console.ReadLine();
        if (loop_input == "stop")
        {
            break;
        }
        
        if (string.IsNullOrEmpty(loop_input))
        {
            Console.WriteLine("You did not enter a value.");
        }
        else
        {
            Console.WriteLine("You entered {0}!", loop_input);
            loop_list.Add(loop_input);
        }
        Console.WriteLine("You have entered these values so far in the loop demonstration:");
        foreach (string loop_item in loop_list)
        {
            Console.WriteLine(loop_item);
        }
        Console.WriteLine("Please enter another string of characters and then press the 'enter' key. Alternatively, you can type 'stop' and then press the 'enter' key to end the loop demonstration.");
    }
}