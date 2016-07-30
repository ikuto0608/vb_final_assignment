Public Class Customer
    Property ID As Integer
    Property FirstName As String
    Property LastName As String
    Property Bank As String
    Property BankAccount As String
    Property Address As String
    Property Email As String
    Const CONNECT_STRING = ""

    Shared Function findAll() As ArrayList
        Dim npgsqlConnection As New Npgsql.NpgsqlConnection
        npgsqlConnection.ConnectionString = CONNECT_STRING
        npgsqlConnection.Open()

        Dim command As New Npgsql.NpgsqlCommand
        command.Connection = npgsqlConnection
        command.CommandText = "select * from customers order by id asc;"
        command.ExecuteNonQuery()
        Dim reader = command.ExecuteReader()

        Dim customers As New ArrayList
        While reader.Read()
            Dim customer As New Customer
            customer.ID = reader.GetString(0)
            customer.FirstName = reader.GetString(1)
            customer.LastName = reader.GetString(2)
            customer.Bank = reader.GetString(3)
            customer.BankAccount = reader.GetString(4)
            customer.Address = reader.GetString(5)
            customer.Email = reader.GetString(6)

            customers.Add(customer)
        End While

        Return customers
    End Function

    Shared Function findByID(ByVal id) As Customer
        Dim npgsqlConnection As New Npgsql.NpgsqlConnection
        npgsqlConnection.ConnectionString = CONNECT_STRING
        npgsqlConnection.Open()

        Dim command As New Npgsql.NpgsqlCommand
        command.Connection = npgsqlConnection
        command.CommandText = "select * from customers where id=" & id & ";"
        command.ExecuteNonQuery()
        Dim reader = command.ExecuteReader()

        Dim customer As New Customer
        While reader.Read()
            customer.ID = reader.GetString(0)
            customer.FirstName = reader.GetString(1)
            customer.LastName = reader.GetString(2)
            customer.Bank = reader.GetString(3)
            customer.BankAccount = reader.GetString(4)
            customer.Address = reader.GetString(5)
            customer.Email = reader.GetString(6)
        End While

        Return customer
    End Function

    Shared Function where(ByVal keyword As String) As ArrayList
        Dim npgsqlConnection As New Npgsql.NpgsqlConnection
        npgsqlConnection.ConnectionString = CONNECT_STRING
        npgsqlConnection.Open()

        Dim command As New Npgsql.NpgsqlCommand
        command.Connection = npgsqlConnection
        command.CommandText = "select * from customers where first_name='" & keyword & "';"
        command.ExecuteNonQuery()
        Dim reader = command.ExecuteReader()

        Dim customers As New ArrayList
        While reader.Read()
            Dim customer As New Customer
            customer.ID = reader.GetString(0)
            customer.FirstName = reader.GetString(1)
            customer.LastName = reader.GetString(2)
            customer.Bank = reader.GetString(3)
            customer.BankAccount = reader.GetString(4)
            customer.Address = reader.GetString(5)
            customer.Email = reader.GetString(6)

            customers.Add(customer)
        End While

        Return customers
    End Function

    Function save() As Boolean
        Dim npgsqlConnection As New Npgsql.NpgsqlConnection
        npgsqlConnection.ConnectionString = CONNECT_STRING
        npgsqlConnection.Open()

        Dim command As New Npgsql.NpgsqlCommand
        command.Connection = npgsqlConnection
        command.CommandText = "UPDATE customers Set first_name = '" & Me.FirstName & "', last_name = '" & Me.LastName & "', bank = '" & Me.Bank & "', bank_account = " & Me.BankAccount & ", address = '" & Me.Address & "', email = '" & Me.Email & "' where id = " & Me.ID & ";"
        command.ExecuteNonQuery()

        Return True
    End Function

    Function create() As Boolean
        Dim npgsqlConnection As New Npgsql.NpgsqlConnection
        npgsqlConnection.ConnectionString = CONNECT_STRING
        npgsqlConnection.Open()

        Dim command As New Npgsql.NpgsqlCommand
        command.Connection = npgsqlConnection
        command.CommandText = "INSERT into customers (first_name, last_name, bank, bank_account, address, email) values ('" & Me.LastName & "', '" & Me.FirstName & "', '" & Me.Bank & "', " & Me.BankAccount & ", '" & Me.Address & "', '" & Me.Email & "');"
        command.ExecuteNonQuery()

        Return True
    End Function

    Function destroy() As Boolean
        Dim npgsqlConnection As New Npgsql.NpgsqlConnection
        npgsqlConnection.ConnectionString = CONNECT_STRING
        npgsqlConnection.Open()

        Dim command As New Npgsql.NpgsqlCommand
        command.Connection = npgsqlConnection
        command.CommandText = "DELETE from customers where id=" & Me.ID & ";"
        command.ExecuteNonQuery()

        Return True
    End Function

End Class
