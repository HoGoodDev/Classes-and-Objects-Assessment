Public Class Sandwich
    Private _mainIngredients As String
    Private _breadType As String
    Private _price As Double

    Public Property MainIngredients As String

        Get
            Return _mainIngredients
        End Get
        Set(value As String)
            _mainIngredients = value
        End Set

    End Property

    Public Property BreadType As String

        Get
            Return _breadType
        End Get
        Set(value As String)
            _breadType = value
        End Set
    End Property

    Public Property Price As Double
        Get
            Return _price
        End Get
        Set(value As Double)
            If value < 0.5 OrElse value > 9.5 Then
                _price = 10
            Else
                _price = value
            End If

        End Set

    End Property

    Public Sub New()

        MainIngredients = "tuna"

        BreadType = "wheat"

        Price = "4.99"

    End Sub

    Public Sub New(breadtype As String, ingredient As String, price As Double)

        Me.BreadType = breadtype
        Me.Price = price
        Me.MainIngredients = ingredient

    End Sub

    Public Overrides Function ToString() As String

        Return $"A {MainIngredients} sandwich on {BreadType} bread costs {Price}$"

    End Function

End Class
