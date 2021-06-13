<Serializable()> Public Class Ramo
    Private _id As Integer
    Private _sigla As String
    Private _tipo As Integer
    Private _mote As String
    Private _contacto As String
    Private _simbolo As String
    Private _morada As String
    Private _dia As Date
    Private _fax As String
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

    Property sigla() As String
        Get
            Return _sigla
        End Get

        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("This field can’t be empty")
                Exit Property
            End If
            _sigla = value
        End Set
    End Property

    Property mote() As String
        Get
            Return _mote
        End Get

        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("This field can’t be empty")
                Exit Property
            End If
            _mote = value
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

    Property dia() As Date
        Get
            Return _dia
        End Get

        Set(ByVal value As Date)
            _dia = value
        End Set
    End Property

    Property fax() As String
        Get
            Return _fax
        End Get

        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("This field can’t be empty")
                Exit Property
            End If
            _fax = value
        End Set
    End Property
End Class
