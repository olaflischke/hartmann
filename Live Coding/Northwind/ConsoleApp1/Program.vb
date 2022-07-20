Imports System
Imports NorthwindDal.Model

Module Program
    Sub Main(args As String())

        Dim context As New NorthwindContext

        For Each cu In context.Customers

            Console.WriteLine($"{cu.CompanyName} ({cu.CustomerId})")

        Next

    End Sub
End Module
