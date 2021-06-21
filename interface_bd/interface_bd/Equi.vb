Public Class Equi
    Private _nSerie_matricula As Integer
    Private _id As Integer
    Private _tipo As String
    Private _modelo As String
    Private _missao As String
    Private _matricula As Integer

    Property nSerie_matricula() As Integer
        Get
            Return _nSerie_matricula
        End Get
        Set(ByVal value As Integer)
            _nSerie_matricula = value
        End Set
    End Property

    Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Property tipo() As String
        Get
            Return _tipo
        End Get

        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("This field can’t be empty")
                Exit Property
            End If
            _tipo = value
        End Set
    End Property

    Property modelo() As String
        Get
            Return _modelo
        End Get

        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("This field can’t be empty")
                Exit Property
            End If
            _modelo = value
        End Set
    End Property

    Property missao() As String
        Get
            Return _missao
        End Get

        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("This field can’t be empty")
                Exit Property
            End If
            _missao = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return _nSerie_matricula & "   |   " & _modelo
    End Function
End Class

