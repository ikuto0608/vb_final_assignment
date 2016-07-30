Public Class Transaction
    Property ID As Integer
    Property CustomerID As Integer
    Property FromRateID As Integer
    Property ToRateID As Integer
    Property Amount As Integer
    Property Rate As Integer
    Property TransactionAt As String
    Const CONNECT_STRING = ""

    Shared Function findAll() As ArrayList
        Dim npgsqlConnection As New Npgsql.NpgsqlConnection
        npgsqlConnection.ConnectionString = CONNECT_STRING
        npgsqlConnection.Open()

        Dim command As New Npgsql.NpgsqlCommand
        command.Connection = npgsqlConnection
        command.CommandText = "select * from transactions order by id asc;"
        command.ExecuteNonQuery()
        Dim reader = command.ExecuteReader()

        Dim transactions As New ArrayList
        While reader.Read()
            Dim transaction As New Transaction
            transaction.ID = reader.GetString(0)
            transaction.CustomerID = reader.GetString(1)
            transaction.FromRateID = reader.GetString(2)
            transaction.ToRateID = reader.GetString(3)
            transaction.Amount = reader.GetString(4)
            transaction.Rate = reader.GetString(5)
            transaction.TransactionAt = reader.GetString(6)

            transactions.Add(transaction)
        End While

        Return transactions
    End Function

    Shared Function findByID(ByVal id) As Transaction
        Dim npgsqlConnection As New Npgsql.NpgsqlConnection
        npgsqlConnection.ConnectionString = CONNECT_STRING
        npgsqlConnection.Open()

        Dim command As New Npgsql.NpgsqlCommand
        command.Connection = npgsqlConnection
        command.CommandText = "select * from transactions where id=" & id & ";"
        command.ExecuteNonQuery()
        Dim reader = command.ExecuteReader()

        Dim transaction As New Transaction
        While reader.Read()
            transaction.ID = reader.GetString(0)
            transaction.CustomerID = reader.GetString(1)
            transaction.FromRateID = reader.GetString(2)
            transaction.ToRateID = reader.GetString(3)
            transaction.Amount = reader.GetString(4)
            transaction.Rate = reader.GetString(5)
            transaction.TransactionAt = reader.GetString(6)
        End While

        Return transaction
    End Function

    Shared Function where(ByVal keyword As String) As ArrayList
        Dim npgsqlConnection As New Npgsql.NpgsqlConnection
        npgsqlConnection.ConnectionString = CONNECT_STRING
        npgsqlConnection.Open()

        Dim command As New Npgsql.NpgsqlCommand
        command.Connection = npgsqlConnection
        command.CommandText = "select * from transactions where customer_id='" & keyword & "';"
        command.ExecuteNonQuery()
        Dim reader = command.ExecuteReader()

        Dim transactions As New ArrayList
        While reader.Read()
            Dim transaction As New Transaction
            transaction.ID = reader.GetString(0)
            transaction.CustomerID = reader.GetString(1)
            transaction.FromRateID = reader.GetString(2)
            transaction.ToRateID = reader.GetString(3)
            transaction.Amount = reader.GetString(4)
            transaction.Rate = reader.GetString(5)
            transaction.TransactionAt = reader.GetString(6)

            transactions.Add(transaction)
        End While

        Return transactions
    End Function

    Function save() As Boolean
        Dim npgsqlConnection As New Npgsql.NpgsqlConnection
        npgsqlConnection.ConnectionString = CONNECT_STRING
        npgsqlConnection.Open()

        Dim command As New Npgsql.NpgsqlCommand
        command.Connection = npgsqlConnection
        command.CommandText = "UPDATE transactions Set customer_id = '" & Me.CustomerID & "', from_rate_id = '" & Me.FromRateID & "', to_rate_id = '" & Me.ToRateID & "', amount = " & Me.Amount & ", rate = '" & Me.Rate & "', transaction_at = '" & Me.TransactionAt & "' where id = " & Me.ID & ";"
        command.ExecuteNonQuery()

        Return True
    End Function

    Function create() As Boolean
        Dim npgsqlConnection As New Npgsql.NpgsqlConnection
        npgsqlConnection.ConnectionString = CONNECT_STRING
        npgsqlConnection.Open()

        Dim command As New Npgsql.NpgsqlCommand
        command.Connection = npgsqlConnection
        command.CommandText = "INSERT into transactions (customer_id, from_rate_id, to_rate_id, amount, rate, transaction_at) values ('" & Me.CustomerID & "', '" & Me.FromRateID & "', '" & Me.ToRateID & "', " & Me.Amount & ", '" & Me.Rate & "', '" & Me.TransactionAt & "');"
        command.ExecuteNonQuery()

        Return True
    End Function

    Function destroy() As Boolean
        Dim npgsqlConnection As New Npgsql.NpgsqlConnection
        npgsqlConnection.ConnectionString = CONNECT_STRING
        npgsqlConnection.Open()

        Dim command As New Npgsql.NpgsqlCommand
        command.Connection = npgsqlConnection
        command.CommandText = "DELETE from transactions where id=" & Me.ID & ";"
        command.ExecuteNonQuery()

        Return True
    End Function
End Class
