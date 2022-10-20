def demo_loops
    puts "This program will demonstrate a loop. Please enter a string of characters and then press the 'enter' key. Alternatively, you can type 'stop' and then press the 'enter' key to end the loop demonstration."
    loop_list = Array.new
    while true
        print ">"
        loop_input = gets.chomp

        if loop_input == "stop"
            break
        end
                
        if loop_input.nil? or loop_input.empty?
            puts "You did not enter a value."
        else
            puts "You entered #{loop_input}!"
            loop_list.push(loop_input)
        end
        puts "You have entered these values so far in the loop demonstration:"
        loop_list.each do |loop_item|
            puts loop_item
        end
        puts "Please enter another string of characters and then press the 'enter' key. Alternatively, you can type 'stop' and then press the 'enter' key to end the loop demonstration."
    end
end

puts "Welcome to Hello Evolved."
demo_loops
puts "The demonstration is complete. Thank you for using Hello Evolved."



