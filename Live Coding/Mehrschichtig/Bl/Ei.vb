Public Class Ei
    Public Sub New()
        Me.Gewicht = (New Random()).Next(45, 81)
    End Sub


    ' Kurzschreibweise für eine Property
    ' Compiler kümmert sich um Backing Field
    Public Property Gewicht As Double
End Class
