import java.util.ArrayList;
import java.util.List;

public class hello_evolved
{
    public static void main(String[] args)
    {
        System.out.println("Welcome to Hello Evolved.");        
        demo_loops();
        System.out.println("The demonstration is complete. Thank you for using Hello Evolved.");
    }

    public static void demo_loops()
    {
        System.out.println("This program will demonstrate a loop. Please enter a string of characters and then press the 'enter' key. Alternatively, you can type 'stop' and then press the 'enter' key to end the loop demonstration.");
        List<String> loop_list = new ArrayList<String>();
        while (true)
        {
            System.out.print(">");
            String loop_input = System.console().readLine();
            if ("stop".equals(loop_input))
            {
                break;
            }
            
            if (loop_input == null || loop_input.isEmpty())
            {
                System.out.println("You did not enter a value.");
            }
            else
            {
                System.out.println("You entered " + loop_input + "!");
                loop_list.add(loop_input);
            }
            System.out.println("You have entered these values so far in the loop demonstration:");
            for (String loop_item : loop_list)
            {
                System.out.println(loop_item);
            }
            System.out.println("Please enter another string of characters and then press the 'enter' key. Alternatively, you can type 'stop' and then press the 'enter' key to end the loop demonstration.");
        }
    }
}
