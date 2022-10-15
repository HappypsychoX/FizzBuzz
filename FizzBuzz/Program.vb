Imports System
'Fizz Buzz - Write a program that prints the numbers from 1 to 100.
'But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”.
'For numbers which are multiples of both three and five print “FizzBuzz”.

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        For i As Integer = 1 To 100
            If IsMultipleOfThree(i) Then
                Console.Write("Fizz, ")
            ElseIf IsMultipleOfFive(i) Then
                Console.Write("Buzz, ")
            Else console.Write(i & ", ")
            End If
        Next
        Console.ReadLine()
    End Sub

    Private Function IsMultipleOfThree(value As Integer) As Boolean
        Dim number As Object = value / 3
        If number = Int(number) Then
            Return True
        Else Return False
        End If
    End Function

    Private Function IsMultipleOfFive(value As Integer) As Boolean
        Dim number As Object = value / 5
        If number = Int(number) Then
            Return True
        Else Return False
        End If
    End Function
End Module
