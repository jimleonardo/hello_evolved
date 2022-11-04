/* JavaScript doesn't have a very simple console like other languages. We need to use the readline module to get input from the user.
Explanation courtesy of CoPilot and Aaron Smith https://aaronsmith.online/read-console-input-with-node-js/
1. Imports the readline module which is a part of the Node.js standard library.
2. Creates an interface that can be used to read data from a readable stream line by line.
3. The interface has two properties: input and output.
4. The input property is used to read data from the standard input stream, which is the keyboard.
5. The output property is used to write data to the standard output stream, which is the terminal. 

see also // https://nodejs.org/api/readline.html#readline_readline
*/

const readline = require('readline')
const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
})


// define the main function
async function main(){
    /* The main function of the program. */
    console.log("Welcome to Hello Evolved.");
    await demoLoops();
    console.log("The demonstration is complete. Thank you for using Hello Evolved.");
}

const question = prompt => {
    return new Promise((resolve, reject) => {
      rl.question(prompt, resolve)
    })
  }

async function demoLoops(){
    /* Demonstrates loops and array behavior. */
    console.log("This program will demonstrate a loop. Please enter a string of characters and then"
    + " press the 'enter' key. Alternatively, you can"
    + " type 'stop' and then press the 'enter' key to end the loop demonstration.");
    var loopList = [];
    while (true) {
        var loopInput = await question(">");       
        console.log(loopInput); 
        if (loopInput === "stop") {
            console.log("The loop demonstration is over");
            break;
        }

        if (loopInput === "") {
            console.log("You did not enter a value.");
        } else if (loopInput) {
            loopList.push(loopInput);
            console.log("You entered " + loopInput + "!");
        } else {
            console.log("The input is not valid.");
        }
        console.log("You have entered these values so far in the loop demonstration:");
        loopList.forEach(loopItem => {
            console.log(loopItem);
        }
        );
        console.log("Continuing the loop demonstration. Please enter another string of characters and"
        + " then press the 'enter' key. Alternatively, you can type 'stop' and then press the 'enter'"
        + " key to end the loop demonstration.");        
    }
    rl.close();
}

// call the main function
(async () => {main();})();