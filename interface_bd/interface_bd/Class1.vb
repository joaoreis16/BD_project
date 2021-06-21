Public Class Missoes
    Private _id As Integer
    Private _nome As String
    Private _tipo As String
    Private _pais As String
    Private _brief As String
    Private _estado As String

    Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Property nome() As String
        Get
            Return _nome
        End Get

        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("This field can’t be empty")
                Exit Property
            End If
            _nome = value
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

    Property pais() As String
        Get
            Return _pais
        End Get

        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("This field can’t be empty")
                Exit Property
            End If
            _pais = value
        End Set
    End Property

    Property brief() As String
        Get
            Return _brief
        End Get

        Set(ByVal value As String)
            _brief = value
        End Set
    End Property
    Property estado() As String
        Get
            Return _estado
        End Get

        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("This field can’t be empty")
                Exit Property
            End If
            _estado = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return _id & "     |     " & _nome
    End Function

End Class
