Public Class HelloEvolved
    Public Shared Sub Main()
        Console.WriteLine("Welcome to Hello Evolved.")        
        demo_loops()
        Console.WriteLine("The demonstration is complete. Thank you for using Hello Evolved.")
    End Sub

    Public Shared Sub demo_loops()
        Console.WriteLine("This program will demonstrate a loop. Please enter a string of characters and then press the 'enter' key. Alternatively, you can type 'stop' and then press the 'enter' key to end the loop demonstration.")
        Dim loop_list As New List(Of String)()
        While True
            Console.Write(">")
            Dim loop_input As String = Console.ReadLine()
            If loop_input = "stop" Then
                Exit While
            End If
            
            If String.IsNullOrEmpty(loop_input) Then
                Console.WriteLine("You did not enter a value.")
            Else
                Console.WriteLine("You entered {0}!", loop_input)
                loop_list.Add(loop_input)
            End If
            Console.WriteLine("You have entered these values so far in the loop demonstration:")
            For Each loop_item As String In loop_list
                Console.WriteLine(loop_item)
            Next
            Console.WriteLine("Please enter another string of characters and then press the 'enter' key. Alternatively, you can type 'stop' and then press the 'enter' key to end the loop demonstration.")
        End While
    End Sub
End Class