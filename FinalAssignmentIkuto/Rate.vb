Public Class Rate
    Property ID As Integer
    Property Country As String
    Property Rate As Integer

    Shared Function findAll() As ArrayList
        Dim npgsqlConnection As New Npgsql.NpgsqlConnection
        npgsqlConnection.ConnectionString = System.Environment.GetEnvironmentVariable("CONNECT_STRING")
        npgsqlConnection.Open()

        Dim command As New Npgsql.NpgsqlCommand
        command.Connection = npgsqlConnection
        command.CommandText = "select * from rates order by id asc;"
        command.ExecuteNonQuery()
        Dim reader = command.ExecuteReader()

        Dim rates As New ArrayList
        While reader.Read()
            Dim rate As New Rate
            rate.ID = reader.GetString(0)
            rate.Country = reader.GetString(1)
            rate.Rate = reader.GetString(2)

            rates.Add(rate)
        End While

        Return rates
    End Function

    Shared Function findByID(ByVal id) As Rate
        Dim npgsqlConnection As New Npgsql.NpgsqlConnection
        npgsqlConnection.ConnectionString = System.Environment.GetEnvironmentVariable("CONNECT_STRING")
        npgsqlConnection.Open()

        Dim command As New Npgsql.NpgsqlCommand
        command.Connection = npgsqlConnection
        command.CommandText = "select * from rates where id=" & id & ";"
        command.ExecuteNonQuery()
        Dim reader = command.ExecuteReader()

        Dim rate As New Rate
        While reader.Read()
            rate.ID = reader.GetString(0)
            rate.Country = reader.GetString(1)
            rate.Rate = reader.GetString(2)
        End While

        Return rate
    End Function

    Shared Function where(ByVal keyword As String) As ArrayList
        Dim npgsqlConnection As New Npgsql.NpgsqlConnection
        npgsqlConnection.ConnectionString = System.Environment.GetEnvironmentVariable("CONNECT_STRING")
        npgsqlConnection.Open()

        Dim command As New Npgsql.NpgsqlCommand
        command.Connection = npgsqlConnection
        command.CommandText = "select * from rates where country='" & keyword & "';"
        command.ExecuteNonQuery()
        Dim reader = command.ExecuteReader()

        Dim rates As New ArrayList
        While reader.Read()
            Dim rate As New Rate
            rate.ID = reader.GetString(0)
            rate.Country = reader.GetString(1)
            rate.Rate = reader.GetString(2)

            rates.Add(rate)
        End While

        Return rates
    End Function

    Function save() As Boolean
        Dim npgsqlConnection As New Npgsql.NpgsqlConnection
        npgsqlConnection.ConnectionString = System.Environment.GetEnvironmentVariable("CONNECT_STRING")
        npgsqlConnection.Open()

        Dim command As New Npgsql.NpgsqlCommand
        command.Connection = npgsqlConnection
        command.CommandText = "UPDATE rates Set country = '" & Me.Country & "', rate = " & Me.Rate & " where id = " & Me.ID & ";"
        command.ExecuteNonQuery()

        Return True
    End Function

    Function create() As Boolean
        Dim npgsqlConnection As New Npgsql.NpgsqlConnection
        npgsqlConnection.ConnectionString = System.Environment.GetEnvironmentVariable("CONNECT_STRING")
        npgsqlConnection.Open()

        Dim command As New Npgsql.NpgsqlCommand
        command.Connection = npgsqlConnection
        command.CommandText = "INSERT into rates (country, rate) values ('" & Me.Country & "', " & Me.Rate & ");"
        command.ExecuteNonQuery()

        Return True
    End Function

    Function destroy() As Boolean
        Dim npgsqlConnection As New Npgsql.NpgsqlConnection
        npgsqlConnection.ConnectionString = System.Environment.GetEnvironmentVariable("CONNECT_STRING")
        npgsqlConnection.Open()

        Dim command As New Npgsql.NpgsqlCommand
        command.Connection = npgsqlConnection
        command.CommandText = "DELETE from rates where id=" & Me.ID & ";"
        command.ExecuteNonQuery()

        Return True
    End Function
End Class
