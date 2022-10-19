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

To ensure compatibility with the largest number of programs, the spec assumes standard input and output are used. This may not work for some special purpose or older languages, so examples in those languages will need to adapted to their own capabilities. The spec assumes English because that is, unfortunately, all I speak. If you want to translate it into another language, please submit an issue on GitHub and we can talk about it!

This specification assumes a console application is being used. For console applications, each output is assumed to be a full line of text including appropriate newline characters unless specified otherwise. For GUI applications, the output may be a single line of text or a single line of text followed by a newline. The spec does not specify how the output is displayed.

1. Basic output
    1. The program will present a message to the user with the text "Welcome to Hello Evolved."
2. Loops and array behavior
    1. The program then outputs "This program will demonstrate a loop. Please enter a string of characters and then press the 'enter' key. Alternatively, you can type 'stop' and then press the 'enter' key to end the loop demonstration."
    1. For console applications, the program will output a ">" character to the user and wait for input. The cursor should be next to the ">" character so that input appears next to the ">" character.
    1. The program will read a line of text from the user. This is the beginning of the loop.
    1. The program will need to decide what to do with the input.
        1. If the input is "stop", the program will output "The loop demonstration is over" and then exit the loop, but not the program.
        2. If the input is any other valid string of characters, the program will output "You entered `text`!" where `text` is the input from the user.
        3. If the input is empty (zero length), the program will output "You did not enter a value."
        4. If the input is not a valid string, the program will output "The input is not valid." - some languages may skip this.
    1. The program outputs "You have entered these values so far in the loop demonstration:"
    1. The program will output each value collected so far in the loop demonstration, one to a line.
    1. The program will output "Please enter another string of characters and then press the 'enter' key. Alternatively, you can type 'stop' and then press the 'enter' key to end the loop demonstration."
    1. The program goes back to the beginning of the loop.
3. The program outputs "The demonstration is complete. Thank you for using Hello Evolved."
4. The program terminates with an exit code of 0.
