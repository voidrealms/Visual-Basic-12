Module Module1

    Sub Main()

        'Arrays

        Dim plate(3) As Integer

        plate(0) = 100 'lower bound (zero based)
        plate(1) = 200
        plate(2) = 300
        plate(3) = 400 'upperbound
        plate(4) = 500 'one that doesnt exist (like having an imaginary freind at dinner table. theyre realy cant eat.)
        Dim index As Integer

        For index = LBound(plate) To UBound(plate)
            Console.WriteLine("plate" & index & "is" & plate(index))

        Next
        Console.Read()

      
    End Sub

End Module
