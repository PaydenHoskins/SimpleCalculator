'Payden Hoskins
'Spring 2025
'RCET2265
'OperatorsExample
'https://github.com/PaydenHoskins/SimpleCalculator.git

Option Strict On
Option Explicit On

Imports System.IO

Module SimpleCalculator

    Sub Main()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim operation As String
        Console.WriteLine("Choose your first number")
        operation = Console.ReadLine()
        firstNumber = CInt(operation)
        Console.WriteLine("Choose your second number")
        operation = Console.ReadLine()
        secondNumber = CInt(operation)

        Console.WriteLine("Please make a selection:" & vbNewLine _
                          & "1. subtract" & vbNewLine _
                          & "2. add")
        operation = Console.ReadLine()

        Console.WriteLine($"you have selecter {operation}")
        If operation = "1" Then
            Console.WriteLine("Let's subtract!")
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}")
        ElseIf operation = "2" Then
            Console.WriteLine("Let's Add!")
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}")
        Else
            Console.WriteLine("INVALID, Try again later!")
        End If
    End Sub

End Module
