"""Python code to demonstrate python features"""
# python code that will:
# 1. Basic input/output and decisions
#     1. The program will present a message to the user with the text "Welcome to Hello Evolved.
#       Please type your name and then press the 'enter' key on your keyboard. Alternatively,
#       you can type 'exit' and then press the 'enter' key on your keyboard to quit."
#     2. The program will read a line of text from the user. This will be the user's name or "exit".
#     3. The program will need to decide what to do with the input.
#         1. If the input is "exit", the program will output "Thank You" and then terminate with an
#           exit code of -101.
#         2. If the input is any other valid string of characters, the program will output "Your
#           name is not Iningo Montoya. It is `name`!" where `name` is the input from the user.
#         3. If the input is empty (zero length), the program will output "You did not enter a
#           name. You must be Iningo Montoya! I am not prepared to die!"
#         4. If the input is not a valid string or zero length, the program will output "The input
#           is not valid. You must be Kenny!" and then terminate with an exit code of -401
# 2. Math
#     1. The program then outputs "Demonstrating math. Please enter a number between -100 and 100.
#       This can be a decimal number. Alternatively, you can type 'exit' and then press the 'enter'
#       key on your keyboard to quit."
#     2. The program will read a line of text from the user. This will be the first number or
#       "exit".
#         1. If the input is "exit", the program will output "Thank You" and then terminate with an
#       exit code of -102.
#         2. If the input is not a valid number between -100 and 100, the program will output "The
#       input is not a valid number." and then terminate with an exit code of -402.
#     3. The program then outputs "Please enter another number between -100 and 100. This can be a
#       decimal number. Alternatively, you can type 'exit' and then press the 'enter' key on your
#       keyboard to quit."
#     4. The program will read a line of text from the user. This will be the second number or
#       "exit".
#         1. If the input is "exit", the program will output "Thank You" and then terminate with an
#       exit code of -103.
#         2. If the input is not a valid number between -100 and 100, the program will output "The
#        input is not a valid number." and then terminate with an exit code of -403.
#     5. The program calculates the sum of the first number and second number. It then squares this
#       result. It outputs "The sum of the two numbers squared is `result`" where `result` is the
#       result of the calculation.
# 3. Loops and array behavior
#     1. The program then outputs "Demonstrating loops. Please enter another string of characters.
#       Alternatively, you can type 'stop' and then press the 'enter' key to end the loop
#       demonstration."
#     2. The program will read a line of text from the user. This is the beginning of the loop.
#     3. The program will need to decide what to do with the input.
#         1. If the input is "stop", the program will output "The loop demonstration is over" and
#           then exit the loop, but not the program.
#         2. If the input is any other valid string of characters, the program will output "You
#           entered `text`!" where `text` is the input from the user.
#         3. If the input is empty (zero length), the program will output "You did not enter a
#           value."
#         4. If the input is not a valid string or zero length, the program will output "The input
#           is not valid."
#     4. The program outputs "You have entered these values so far in the loop demonstration:"
#     5. The program will output each value collected so far in the loop demonstration, one to a
#       line.
#     6. The program will output "Continuing the loop demonstration. Please enter another string of
#       characters. Alternatively, you can type 'stop' and then press the 'enter' key to end the
#       loop demonstration."
#     7. The program goes back to the beginning of the loop.
# 4. The program outputs "All demonstrations are complete. Thank you for using Hello Evolved."
# 5. The program terminates with an exit code of 0.

# import the sys module
import sys

# define the main function
def main():
    """The main function of the program."""
    demo_input_output()
    demo_math()
    demo_loops()

def demo_input_output():
    """Demonstrates input/output and decisions."""
    print(("Welcome to Hello Evolved. Please type your name and then press the 'enter' key on your"
     "keyboard. Alternatively, you can type 'exit' and then press the 'enter' key on your keyboard"
     " to quit."))
    name = input()
    if name == "exit":
        print("Thank You")
        sys.exit(-101)
    elif name == "":
        print("You did not enter a name. You must be Iningo Montoya! I am not prepared to die!")
    elif name.isprintable():
        print("Your name is not Iningo Montoya. It is " + name + "!")
    else:
        print("The input is not valid. You must be Kenny!")
        sys.exit(-401)

def demo_math():
    """Demonstrates math."""
    print(("Demonstrating math. Please enter a number between -100 and 100. This can be a decimal"
     " number. Alternatively, you can type 'exit' and then press the 'enter' key on your keyboard"
     " to quit."))
    first_number = input()
    if first_number == "exit":
        print("Thank You")
        sys.exit(-102)

    try :
        first_number = float(first_number)
    except ValueError:
        print("The input is not a valid number.")
        sys.exit(-402)

    if  -100 <= first_number <= 100:
        print(("Please enter another number between -100 and 100. This can be a decimal number."
        " Alternatively, you can type 'exit' and then press the 'enter' key on your keyboard"
        " to quit."))
        second_number = input()
        if second_number == "exit":
            print("Thank You")
            sys.exit(-103)

        try :
            second_number = float(second_number)
        except ValueError:
            print("The input is not a valid number.")
            sys.exit(-403)

        if -100 <= second_number <= 100:
            result = (first_number + second_number)**2
            print("The sum of the two numbers squared is " + str(result))
        else:
            print("The input is not a valid number between -100 and 100.")
            sys.exit(-403)
    else:
        print("The input is not a valid number between -100 and 100.")
        sys.exit(-402)

def demo_loops():
    """Demonstrates loops and array behavior."""
    print(("Demonstrating loops. Please enter another string of characters. Alternatively, you can"
    " type 'stop' and then press the 'enter' key to end the loop demonstration."))
    loop_list = []
    while True:
        loop_input = input()
        if loop_input == "stop":
            print("The loop demonstration is over")
            break
        elif loop_input == "":
            print("You did not enter a value.")
        elif loop_input.isprintable():
            loop_list.append(loop_input)
            print("You entered " + loop_input + "!")
        else:
            print("The input is not valid.")
        print("You have entered these values so far in the loop demonstration:")
        for loop_item in loop_list:
            print(loop_item)
        print(("Continuing the loop demonstration. Please enter another string of characters."
        " Alternatively, you can type 'stop' and then press the 'enter' key to end the loop"
        " demonstration."))
    print("All demonstrations are complete. Thank you for using Hello Evolved.")

# call the main function
main()
