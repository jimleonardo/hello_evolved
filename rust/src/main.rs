use std::io;
use std::io::Write;
use std::collections::LinkedList;

fn main() {
    println!("Welcome to Hello Evolved.");
    demo_loops();
    println!("The demonstration is complete. Thank you for using Hello Evolved.");
}

fn demo_loops() {
    println!("This program will demonstrate a loop. Please enter a string of characters and then press the 'enter' key. Alternatively, you can type 'stop' and then press the 'enter' key to end the loop demonstration.");
    let mut loop_list: LinkedList<String> = LinkedList::new();
    loop {
        print!(">");
        io::stdout().flush().unwrap();
        let mut loop_input = String::new();
        io::stdin().read_line(&mut loop_input).expect("The input is not valid."); // 
        loop_input = loop_input.trim().to_string(); // Remove the newline character.
        if loop_input == "stop" {
            break;
        }
        if loop_input.is_empty() {
            println!("You did not enter a value.");
        } else {
            println!("You entered {}!", loop_input);
            loop_list.push_back(loop_input);
        }
        println!("You have entered these values so far in the loop demonstration:");
        for loop_item in loop_list.iter() {
            println!("{}", loop_item);
        }
        println!("Please enter another string of characters and then press the 'enter' key. Alternatively, you can type 'stop' and then press the 'enter' key to end the loop demonstration.");
    }
}