Public Class Pelotoes
    Private _id As Integer
    Private _nome As String
    Private _general As String
    Private _general_id As Integer
    Private _idMissao As Integer

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

    Property general() As String
        Get
            Return _general
        End Get

        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("This field can’t be empty")
                Exit Property
            End If
            _general = value
        End Set
    End Property

    Property general_id() As Integer
        Get
            Return _general_id
        End Get
        Set(ByVal value As Integer)
            _general_id = value
        End Set
    End Property

    Property idMissao() As Integer
        Get
            Return _idMissao
        End Get
        Set(ByVal value As Integer)
            _idMissao = value
        End Set
    End Property


    Overrides Function ToString() As String
        Return _id & "     |     " & _nome
    End Function
End Class
