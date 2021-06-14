Public Class Base
    Private _id As Integer
    Private _contacto As String
    Private _nome As String
    Private _maxMilitares As Integer
    Private _morada As String
    Private _data_inicio As Date
    Private _data_fim As Date

    Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Property contacto() As String
        Get
            Return _contacto

        End Get

        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("This field can’t be empty")
                Exit Property
            End If
            _contacto = value
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
    Property morada() As String
        Get
            Return _morada
        End Get

        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("This field can’t be empty")
                Exit Property
            End If
            _morada = value
        End Set
    End Property

    Property maxMilitares() As Integer
        Get
            Return _maxMilitares
        End Get

        Set(ByVal value As Integer)
            _maxMilitares = value
        End Set
    End Property
    Property data_inicio() As Date
        Get
            Return _data_inicio
        End Get

        Set(ByVal value As Date)
            _data_inicio = value
        End Set
    End Property

    Property data_fim() As Date
        Get
            Return _data_fim
        End Get

        Set(ByVal value As Date)
            _data_fim = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return String.Format("{0, -10}| {1, 10}", _id, _nome)
    End Function
End Class
