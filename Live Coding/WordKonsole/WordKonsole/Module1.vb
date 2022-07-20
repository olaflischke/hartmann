Imports wd = Microsoft.Office.Interop.Word
Imports xl = Microsoft.Office.Interop.Excel

Module Module1

    Sub Main()
        ' Deklaration mit Wertzuweisung
        Dim text = "Hello Word" ' Type-Inference: Implizite Typisierung

        Console.WriteLine(text)

        Dim word As wd.Application '= New Microsoft.Office.Interop.Word.Application
        word = New wd.Application

        word.Visible = True

        Dim excel As xl.Application
        excel = New xl.Application

        excel.Visible = True

        Console.ReadKey()

        word.Quit()
        excel.Quit()

    End Sub

End Module
