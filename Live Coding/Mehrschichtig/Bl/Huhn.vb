Public Class Huhn
    Public Sub New()
        Me.Name = "Neues Huhn"
        Me.Gewicht = 1000
    End Sub


    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _gewicht As Double
    Public Property Gewicht() As Double
        Get
            Return _gewicht ' dim g = meinHuhn.Gewicht
        End Get
        Set(ByVal value As Double)
            _gewicht = value ' meinHuhn.Gewicht = 1234
        End Set
    End Property

    Public Property Eier As New List(Of Ei) '= New List(Of Ei)

    Public Sub Fressen()
        Me.Gewicht += 200
    End Sub

    Public Sub Eilegen()
        If Me.Gewicht > 2000 Then
            Dim ei As New Ei()
            Me.Eier.Add(ei)
            Me.Gewicht -= ei.Gewicht
        End If
    End Sub

End Class
