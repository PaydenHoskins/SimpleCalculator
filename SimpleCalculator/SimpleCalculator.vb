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
        Dim JellyBeans As Integer
        Dim FootBall As Integer
        Dim operation As String
        Console.WriteLine(" number enter operation enter number enter ")
        JellyBeans = Console.Read()
        operation = Console.ReadLine()
        FootBall = Console.Read()
        Console.WriteLine()
        Console.Write(JellyBeans & operation & FootBall)
    End Sub

End Module
