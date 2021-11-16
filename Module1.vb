Module Module1

    Sub Main()
        Dim Str1, FirstChars, LastChars As String
        
        Console.Write(" Enter string to be processed: ")
        Str1 = Console.ReadLine

        If Len(Str1) <= 2 Then
            Console.WriteLine(Str1)
            Console.ReadKey()
            End
        End If


        FirstChars = Left(Str1, 2)
        LastChars = Right(Str1, 2)



        Console.WriteLine("Processed string is: " & FirstChars & LastChars)
        Console.ReadKey()
    End Sub

End Module
