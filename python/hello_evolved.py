"""Python code to demonstrate python features"""
import sys

# define the main function
def main():
    """The main function of the program."""
    print("Welcome to Hello Evolved.")
    demo_loops()
    print("The demonstration is complete. Thank you for using Hello Evolved.")

def demo_loops():
    """Demonstrates loops and array behavior."""
    print(("This program will demonstrate a loop. Please enter a string of characters and then"
    " press the 'enter' key. Alternatively, you can"
    " type 'stop' and then press the 'enter' key to end the loop demonstration."))
    loop_list = []
    while True:
        # use sys.stdin.write because print adds a newline that we don't want.
        sys.stdout.write(">")
        loop_input = input()
        if loop_input == "stop":
            print("The loop demonstration is over")
            break

        if loop_input == "":
            print("You did not enter a value.")
        elif loop_input.isprintable():
            loop_list.append(loop_input)
            print("You entered " + loop_input + "!")
        else:
            print("The input is not valid.")
        print("You have entered these values so far in the loop demonstration:")        
        for loop_item in loop_list:
            print(loop_item)
        print(("Continuing the loop demonstration. Please enter another string of characters and"
        " then press the 'enter' key. Alternatively, you can type 'stop' and then press the 'enter'"
        " key to end the loop demonstration."))

# call the main function
main()
