# Hello Evolved

Hello Evolved is a collection of code samples that demonstrate basic language features for a variety of languages. It is traditional for a language to have a "Hello World" program that demonstrates the basic syntax of the language, but once you've learned your first programming language, Hello World doesn't tell you very much. For an experienced developer, a slightly more complex program can demonstrate more of a language's features in a few lines of code and avoid boredom.

## Hello World and the reason for Hello Evolved

Hello world got started back when fewer people even knew what code was and even a simple program usually had many parts. An example that could demonstrate *something* functioning was needed to explain all the parts of a minimal program. An example in C sheds quite a bit of information what makes up a minimum program:

```c
    #include <stdio.h>
    int main() {
        printf("Hello World/n");
        return 0;
    }
```

Each of those 5 lines does something different and each is needed to form a functioning program even though the program only does one thing: put "Hello World" on the screen. 

1. Include the standard input/output library. This is needed to use the `printf` function.
1. Declare the entry point of the program. This is needed to tell the operating system where to start executing the program.
1. Output (`printf`) the string "Hello World" to the screen.
1. Return a value to the operating system. This is needed to tell the operating system that the program has finished executing. 0 means success.
1. Close the program with '}'.

That's a lot to put 11 characters on the screen. Other languages can be far simpler. In Python, the following code will print "Hello World":

```python
    print("Hello World")
```

And compare that to Ruby:

```ruby
    puts "Hello World"
```

As an experienced developer, I can see there is an output command (`print` and `puts`) and a parameter ("Hello World"). I can tell that strings of characters appear in between double quotes (") and that I don't need a lot of ceremony just to create a simple bit output. While both are complete programs, they are not terribly useful. They tell me how to call a single method, that's it.

This approach of introducing only a single "useful" line of code inevitably translates to multiple pages of documentation just to get to a point where the learner can do something that is also useful. While a complete novice may need that level of explanation, it's probably overkill even for someone who has written an Excel formula. Hello World doesn't even tell the reader how to add two numbers together! That's where Hello Evolved comes in. Hello Evolved is a specification for a program that will do a few, small, things that can help an experienced developer understand a language they're looking at for the first time. To that end, the spec needs to be rich enough to demonstrate a few features, but not so exhaustive that it won't be relevant to more than a few languages. It also has to be simple enough that it can be implemented in a few lines of code.

## The Spec

To ensure compatibility with the largest number of programs, the spec assumes standard input and output are used. This may not work for some special purpose or older languages, so examples in those languages will need to adapted to their own capabilities. The spec assumes English because I suck and don't speak anything else. If you want to translate it into another language, please submit an issue and we can talk about it!

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
