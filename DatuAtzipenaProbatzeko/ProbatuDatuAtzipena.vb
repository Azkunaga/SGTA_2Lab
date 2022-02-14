Module ProbatuDatuAtzipena

    Sub Main()

        Console.WriteLine("Erabaki zer egin nahi duzun:")
        Console.WriteLine("(1) DB-ra konektatu,
(2) DB-a itxi, 
(3) Erabiltzailea txertatu,
(4) Erabiltzailea lortu, 
(5) Erabiltzailea egiaztatu")

        Dim num As Integer = Console.ReadLine()
        Select Case num
            Case 1
                Try
                    DatuAtzipenekoak.DatuAtzipena.Konektatu()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            Case 2
                DatuAtzipenekoak.DatuAtzipena.ItxiKonexioa()

            Case 3
            Case 4
            Case 5
        End Select



    End Sub

End Module
