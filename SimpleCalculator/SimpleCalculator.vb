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

    End Sub

End Module
