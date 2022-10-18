/*
1. Basic input/output and decisions
    1. The program will present a message to the user with the text "Welcome to Hello Evolved. Please type your name and then press the 'enter' key on your keyboard. Alternatively, you can type 'exit' and then press the 'enter' key on your keyboard to quit."
    2. The program will read a line of text from the user. This will be the user's name or "exit".
    3. The program will need to decide what to do with the input.
        1. If the input is "exit", the program will output "Thank You" and then terminate with an exit code of -101.
        2. If the input is any other valid string of characters, the program will output "Your name is not Iningo Montoya. It is `name`!" where `name` is the input from the user.
        3. If the input is empty (zero length), the program will output "You did not enter a name. You must be Iningo Montoya! I am not prepared to die!"
        4. If the input is not a valid string or zero length, the program will output "The input is not valid. You must be Kenny!" and then terminate with an exit code of -401
2. Math
    1. The program then outputs "Demonstrating math. Please enter a number between -100 and 100. This can be a decimal number. Alternatively, you can type 'exit' and then press the 'enter' key on your keyboard to quit."
    2. The program will read a line of text from the user. This will be the first number or "exit".
        1. If the input is "exit", the program will output "Thank You" and then terminate with an exit code of -102.
        2. If the input is not a valid number between -100 and 100, the program will output "The input is not a valid number." and then terminate with an exit code of -402.
    3. The program then outputs "Please enter another number between -100 and 100. This can be a decimal number. Alternatively, you can type 'exit' and then press the 'enter' key on your keyboard to quit."
    4. The program will read a line of text from the user. This will be the second number or "exit".
        1. If the input is "exit", the program will output "Thank You" and then terminate with an exit code of -103.
        2. If the input is not a valid number between -100 and 100, the program will output "The input is not a valid number." and then terminate with an exit code of -403.
    5. The program calculates the sum of the first number and second number. It then squares this result. It outputs "The sum of the two numbers squared is `result`" where `result` is the result of the calculation.
3. Loops and array behavior
    1. The program then outputs "Demonstrating loops. Please enter another string of characters. Alternatively, you can type 'stop' and then press the 'enter' key to end the loop demonstration."
    2. The program will read a line of text from the user. This is the beginning of the loop.
    3. The program will need to decide what to do with the input.
        1. If the input is "stop", the program will output "The loop demonstration is over" and then exit the loop, but not the program.
        2. If the input is any other valid string of characters, the program will output "You entered `text`!" where `text` is the input from the user.
        3. If the input is empty (zero length), the program will output "You did not enter a value."
        4. If the input is not a valid string, the program will output "The input is not valid." - some languages may skip this.
    4. The program outputs "You have entered these values so far in the loop demonstration:"
    5. The program will output each value collected so far in the loop demonstration, one to a line.
    6. The program will output "Continuing the loop demonstration. Please enter another string of characters. Alternatively, you can type 'stop' and then press the 'enter' key to end the loop demonstration."
    7. The program goes back to the beginning of the loop.
4. The program outputs "All demonstrations are complete. Thank you for using Hello Evolved."
5. The program terminates with an exit code of 0.
*/
using System;
public class HelloEvolved
{
    public static void Main()
    {
        demo_input_output();
        demo_math();
        demo_loops();
    }

    public static void demo_input_output()
    {
        Console.WriteLine("Welcome to Hello Evolved. Please type your name and then press the 'enter' key on your keyboard. Alternatively, you can type 'exit' and then press the 'enter' key on your keyboard to quit.");
        string? name = Console.ReadLine();
        if (name == "exit")
        {
            Console.WriteLine("Thank You");
            Environment.Exit(-101);
        }
        else if (name == "")
        {
            Console.WriteLine("You did not enter a name. You must be Iningo Montoya! I am not prepared to die!");
        }
        else if(string.IsNullOrEmpty(name))
        {
            Console.WriteLine("The input is not valid. You must be Kenny!");
            Environment.Exit(-401);
        }
        else
        {
            Console.WriteLine("Your name is not Iningo Montoya. It is " + name + "!");
        }
    }

    public static void demo_math()
    {
        Console.WriteLine("Demonstrating math. Please enter a number between -100 and 100. This can be a decimal number. Alternatively, you can type 'exit' and then press the 'enter' key on your keyboard to quit.");
        string? first_number = Console.ReadLine();
        if (first_number == "exit")
        {
            Console.WriteLine("Thank You");
            Environment.Exit(-102);
        }
        double first_number_float = 0.0f;
        try
        {
            first_number_float = double.Parse(first_number);
        }
        catch (FormatException)
        {
            Console.WriteLine("The input is not a valid number.");
            Environment.Exit(-402);
        }

        if (-100 <= first_number_float && first_number_float <= 100)
        {
            Console.WriteLine(("Please enter another number between -100 and 100. This can be a decimal number. Alternatively, you can type 'exit' and then press the 'enter' key on your keyboard to quit."));
            string? second_number = Console.ReadLine();
            if (second_number == "exit")
            {
                Console.WriteLine("Thank You");
                Environment.Exit(-103);
            }
            double second_number_float = 0.0f;
            try
            {
                second_number_float = double.Parse(second_number);
            }
            catch (FormatException)
            {
                Console.WriteLine("The input is not a valid number.");
                Environment.Exit(-403);
            }

            if (-100 <= second_number_float && second_number_float <= 100)
            {
                double result = Math.Pow((first_number_float + second_number_float), 2.0f);
                Console.WriteLine("The sum of the two numbers squared is " + result);
            }
            else
            {
                Console.WriteLine("The input is not a valid number between -100 and 100.");
                Environment.Exit(-403);
            }
        }
        else
        {
            Console.WriteLine("The input is not a valid number between -100 and 100.");
            Environment.Exit(-402);
        }
    }

    public static void demo_loops()
    {
        Console.WriteLine("Demonstrating loops. Please enter another string of characters. Alternatively, you can type 'stop' and then press the 'enter' key to end the loop demonstration.");
        List<string> loop_list = new List<string>();
        while (true)
        {
            string? loop_input = Console.ReadLine();
            if (loop_input == "stop")
            {
                break;
            }
            else if (string.IsNullOrEmpty(loop_input))
            {
                Console.WriteLine("You did not enter a value.");
            }
            else
            {
                loop_list.Add(loop_input);
            }
            foreach (string loop_item in loop_list)
            {
                Console.WriteLine(loop_item);
            }
            Console.WriteLine("Please enter another string of characters. Alternatively, you can type 'stop' and then press the 'enter' key to end the loop demonstration.");
        }
    }
}