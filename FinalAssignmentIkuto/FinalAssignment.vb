Public Class FinalAssignment
    Const CONNECT_STRING = ""

    Private Sub FinalAssignment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayCustomers()
    End Sub

    Private Sub btnCreateCustomer_Click(sender As Object, e As EventArgs) Handles btnCreateCustomer.Click
        Dim c As New Customer
        c.FirstName = tbxCustomerFirstName.Text
        c.LastName = tbxCustomerLastName.Text
        c.Bank = tbxCustomerBank.Text
        c.BankAccount = Val(tbxCustomerBankAccount.Text)
        c.Address = tbxCustomerAddress.Text
        c.Email = tbxCustomerEmail.Text
        c.create()

        displayCustomers()
    End Sub

    Private Sub btnCustomerModify_Click(sender As Object, e As EventArgs) Handles btnCustomerModify.Click
        Dim c = Customer.findByID(Val(tbxCustomerID.Text))
        c.FirstName = tbxCustomerFirstName.Text
        c.LastName = tbxCustomerLastName.Text
        c.Bank = tbxCustomerBank.Text
        c.BankAccount = Val(tbxCustomerBankAccount.Text)
        c.Address = tbxCustomerAddress.Text
        c.Email = tbxCustomerEmail.Text
        c.save()

        displayCustomers()
    End Sub

    Private Sub btnCustomerDelete_Click(sender As Object, e As EventArgs) Handles btnCustomerDelete.Click
        Dim c = Customer.findByID(Val(tbxCustomerID.Text))
        c.destroy()

        displayCustomers()
    End Sub

    Private Sub lvCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvCustomer.SelectedIndexChanged
        If lvCustomer.SelectedItems.Count < 1 Then
            Exit Sub
        End If

        Dim id = Val(lvCustomer.SelectedItems.Item(0).Text)
        If id = 0 Then
            Exit Sub
        End If
        Dim c = Customer.findByID(id)
        tbxCustomerID.Text = c.ID
        tbxCustomerFirstName.Text = c.FirstName
        tbxCustomerLastName.Text = c.LastName
        tbxCustomerBank.Text = c.Bank
        tbxCustomerBankAccount.Text = c.BankAccount
        tbxCustomerAddress.Text = c.Address
        tbxCustomerEmail.Text = c.Email
    End Sub

    Private Sub displayCustomers()
        Dim customers = Customer.findAll
        lvCustomer.Clear()

        lvCustomer.Columns.Add("ID", 50, HorizontalAlignment.Left)
        lvCustomer.Columns.Add("FirstName", 70, HorizontalAlignment.Left)
        lvCustomer.Columns.Add("LastName", 70, HorizontalAlignment.Left)
        lvCustomer.Columns.Add("Bank", 70, HorizontalAlignment.Left)
        lvCustomer.Columns.Add("BankAccount", 70, HorizontalAlignment.Left)
        lvCustomer.Columns.Add("Address", 70, HorizontalAlignment.Left)
        lvCustomer.Columns.Add("Email", 70, HorizontalAlignment.Left)

        For Each customer In customers
            Dim item As ListViewItem
            Dim str(6) As String
            str(0) = customer.ID
            str(1) = customer.FirstName
            str(2) = customer.LastName
            str(3) = customer.Bank
            str(4) = customer.BankAccount
            str(5) = customer.Address
            str(6) = customer.Email

            item = New ListViewItem(str)
            lvCustomer.Items.Add(item)
        Next
    End Sub

    Private Sub btnSearchCustomer_Click(sender As Object, e As EventArgs) Handles btnSearchCustomer.Click
        Dim searchWord = tbxSearchCustomer.Text
        Dim customers = Customer.where(searchWord)

        lvCustomer.Clear()

        lvCustomer.Columns.Add("ID", 50, HorizontalAlignment.Left)
        lvCustomer.Columns.Add("FirstName", 70, HorizontalAlignment.Left)
        lvCustomer.Columns.Add("LastName", 70, HorizontalAlignment.Left)
        lvCustomer.Columns.Add("Bank", 70, HorizontalAlignment.Left)
        lvCustomer.Columns.Add("BankAccount", 70, HorizontalAlignment.Left)
        lvCustomer.Columns.Add("Address", 70, HorizontalAlignment.Left)
        lvCustomer.Columns.Add("Email", 70, HorizontalAlignment.Left)

        For Each customer In customers
            Dim item As ListViewItem
            Dim str(6) As String
            str(0) = customer.ID
            str(1) = customer.FirstName
            str(2) = customer.LastName
            str(3) = customer.Bank
            str(4) = customer.BankAccount
            str(5) = customer.Address
            str(6) = customer.Email

            item = New ListViewItem(str)
            lvCustomer.Items.Add(item)
        Next
    End Sub

    Private Sub btnCustomerSearch_Click(sender As Object, e As EventArgs) Handles btnCustomerSearch.Click
        displayCustomers()
    End Sub
End Class
