Public Class Militar
    Private _nCC As Integer
    Private _Pnome As String
    Private _Unome As String
    Private _morada As String
    Private _email As String
    Private _dNasc As Date
    Private _dInsc As Date
    Private _tel As String
    Private _nacionalidade As String
    Private _nMissoes As Integer
    Private _ramo As Integer
    Private _base As Integer
    Private _pelotao As Integer
    Private _cargo As String
    Private _missao As Integer
    Private _tipo As String

    Property nCC() As Integer
        Get
            Return _nCC
        End Get
        Set(ByVal value As Integer)
            _nCC = value
        End Set
    End Property

    Property Pnome() As String
        Get
            Return _Pnome
        End Get

        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("This field can’t be empty")
                Exit Property
            End If
            _Pnome = value
        End Set
    End Property

    Property Unome() As String
        Get
            Return _Unome
        End Get

        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("This field can’t be empty")
                Exit Property
            End If
            _Unome = value
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
    Property email() As String
        Get
            Return _email
        End Get

        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("This field can’t be empty")
                Exit Property
            End If
            _email = value
        End Set
    End Property

    Property dNasc() As Date
        Get
            Return _dNasc
        End Get

        Set(ByVal value As Date)
            _dNasc = value
        End Set
    End Property

    Property dInsc() As Date
        Get
            Return _dInsc
        End Get

        Set(ByVal value As Date)
            _dInsc = value
        End Set
    End Property

    Property tel() As String
        Get
            Return _tel
        End Get

        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("This field can’t be empty")
                Exit Property
            End If
            _tel = value
        End Set
    End Property
    Property nacionalidade() As String
        Get
            Return _nacionalidade
        End Get

        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("This field can’t be empty")
                Exit Property
            End If
            _nacionalidade = value
        End Set
    End Property

    Property nMissoes() As Integer
        Get
            Return _nMissoes
        End Get

        Set(ByVal value As Integer)
            _nMissoes = value
        End Set
    End Property

    Property ramo() As Integer
        Get
            Return _ramo
        End Get

        Set(ByVal value As Integer)
            _ramo = value
        End Set
    End Property

    Property base() As Integer
        Get
            Return _base
        End Get

        Set(ByVal value As Integer)
            _base = value
        End Set
    End Property

    Property pelotao() As Integer
        Get
            Return _pelotao
        End Get

        Set(ByVal value As Integer)
            _pelotao = value
        End Set
    End Property

    Property cargo() As String
        Get
            Return _cargo
        End Get

        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("This field can’t be empty")
                Exit Property
            End If
            _cargo = value
        End Set
    End Property


    Property missao() As Integer
        Get
            Return _missao
        End Get

        Set(ByVal value As Integer)
            _missao = value
        End Set
    End Property

    Property tipo() As String
        Get
            Return _tipo
        End Get

        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property
    Overrides Function ToString() As String
        Return _nCC & "     |     " & _Pnome & " " & _Unome
    End Function
End Class
