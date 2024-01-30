Module module1
    Dim totalSandwich As New List(Of Sandwich)

    Sub Main()

        Dim sandwich1 As New Sandwich()
        Dim sandwich2 As New Sandwich(“peanut butter and jelly”, “white”, 1.0)
        Dim sandwich3 As New Sandwich()
        Dim sandwich4 As New Sandwich("Roast Beef”, “Rye”, 15.0)

        sandwich3.MainIngredients = "chicken"
        sandwich3.Price = 6.99
        totalSandwich.Add(sandwich1)
        totalSandwich.Add(sandwich2)
        totalSandwich.Add(sandwich3)
        totalSandwich.Add(sandwich4)

        For i As Integer = 0 To totalSandwich.Count - 1
            Console.WriteLine(totalSandwich(i))
        Next

        'Dim obj1, obj2, obj3 As New Sandwich
        'Dim obj1 As New 

    End Sub

End Module
