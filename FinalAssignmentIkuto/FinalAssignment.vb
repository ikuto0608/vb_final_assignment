Public Class FinalAssignment
    Private Sub FinalAssignment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayCustomers()
        displayRates()
        displayTransactions()
    End Sub

    '----------Customers----------
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


    '--------------------
    '---------------Rates
    Private Sub btnCreateRate_Click(sender As Object, e As EventArgs) Handles btnCreateRate.Click
        Dim r As New Rate
        r.Country = tbxRateCountry.Text
        r.Rate = Val(tbxRateRate.Text)
        r.create()

        displayRates()
    End Sub

    Private Sub lvRate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvRate.SelectedIndexChanged
        If lvRate.SelectedItems.Count < 1 Then
            Exit Sub
        End If

        Dim id = Val(lvRate.SelectedItems.Item(0).Text)
        If id = 0 Then
            Exit Sub
        End If
        Dim r = Rate.findByID(id)
        tbxRateID.Text = r.ID
        tbxRateCountry.Text = r.Country
        tbxRateRate.Text = r.Rate
    End Sub

    Private Sub btnModifyRate_Click(sender As Object, e As EventArgs) Handles btnModifyRate.Click
        Dim r = Rate.findByID(Val(tbxRateID.Text))
        r.Country = tbxRateCountry.Text
        r.Rate = Val(tbxRateRate.Text)
        r.save()

        displayRates()
    End Sub

    Private Sub btnDeleteRate_Click(sender As Object, e As EventArgs) Handles btnDeleteRate.Click
        Dim r = Rate.findByID(Val(tbxRateID.Text))
        r.destroy()

        displayRates()
    End Sub

    Private Sub btnSearchRate_Click(sender As Object, e As EventArgs) Handles btnSearchRate.Click
        Dim searchWord = tbxSearchRate.Text
        Dim rates = Rate.where(searchWord)

        lvRate.Clear()

        lvRate.Columns.Add("ID", 50, HorizontalAlignment.Left)
        lvRate.Columns.Add("Country", 70, HorizontalAlignment.Left)
        lvRate.Columns.Add("Rate", 70, HorizontalAlignment.Left)

        For Each rate In rates
            Dim item As ListViewItem
            Dim str(6) As String
            str(0) = rate.ID
            str(1) = rate.Country
            str(2) = rate.Rate

            item = New ListViewItem(str)
            lvRate.Items.Add(item)
        Next
    End Sub

    Private Sub btnClearRate_Click(sender As Object, e As EventArgs) Handles btnClearRate.Click
        displayRates()
    End Sub

    Private Sub displayRates()
        Dim rates = Rate.findAll
        lvRate.Clear()

        lvRate.Columns.Add("ID", 50, HorizontalAlignment.Left)
        lvRate.Columns.Add("Country", 70, HorizontalAlignment.Left)
        lvRate.Columns.Add("Rate", 70, HorizontalAlignment.Left)

        For Each rate In rates
            Dim item As ListViewItem
            Dim str(6) As String
            str(0) = rate.ID
            str(1) = rate.Country
            str(2) = rate.Rate

            item = New ListViewItem(str)
            lvRate.Items.Add(item)
        Next
    End Sub


    '-------------------------------
    '------Transaction--------------
    Private Sub btnCreateTransaction_Click(sender As Object, e As EventArgs) Handles btnCreateTransaction.Click
        Dim t As New Transaction
        t.CustomerID = Val(tbxTransactionCustomerID.Text)
        t.FromRateID = Val(tbxTransactionFromRateID.Text)
        t.ToRateID = Val(tbxTransactionToRateID.Text)
        t.Amount = Val(tbxTransactionAmout.Text)
        t.Rate = Val(tbxTransactionRate.Text)
        t.TransactionAt = tbxTransactionAt.Text
        t.create()

        displayTransactions()
    End Sub

    Private Sub btnModifyTransaction_Click(sender As Object, e As EventArgs) Handles btnModifyTransaction.Click
        Dim t = Transaction.findByID(Val(tbxTransactionID.Text))
        t.CustomerID = Val(tbxTransactionCustomerID.Text)
        t.FromRateID = Val(tbxTransactionFromRateID.Text)
        t.ToRateID = Val(tbxTransactionToRateID.Text)
        t.Amount = Val(tbxTransactionAmout.Text)
        t.Rate = Val(tbxTransactionRate.Text)
        t.TransactionAt = tbxTransactionAt.Text
        t.save()

        displayTransactions()
    End Sub

    Private Sub btnDeleteTransaction_Click(sender As Object, e As EventArgs) Handles btnDeleteTransaction.Click
        Dim t = Transaction.findByID(Val(tbxTransactionID.Text))
        t.destroy()

        displayTransactions()
    End Sub

    Private Sub btnSearchTransaction_Click(sender As Object, e As EventArgs) Handles btnSearchTransaction.Click
        Dim searchWord = tbxSearchTransaction.Text
        Dim transactions = Transaction.where(searchWord)

        lvTransaction.Clear()

        lvTransaction.Columns.Add("ID", 50, HorizontalAlignment.Left)
        lvTransaction.Columns.Add("CustomerID", 70, HorizontalAlignment.Left)
        lvTransaction.Columns.Add("FromRateID", 70, HorizontalAlignment.Left)
        lvTransaction.Columns.Add("ToRateID", 70, HorizontalAlignment.Left)
        lvTransaction.Columns.Add("Amount", 70, HorizontalAlignment.Left)
        lvTransaction.Columns.Add("Rate", 70, HorizontalAlignment.Left)
        lvTransaction.Columns.Add("TransactionAt", 70, HorizontalAlignment.Left)

        For Each transaction In transactions
            Dim item As ListViewItem
            Dim str(6) As String
            str(0) = transaction.ID
            str(1) = transaction.CustomerID
            str(2) = transaction.FromRateID
            str(3) = transaction.ToRateID
            str(4) = transaction.Amount
            str(5) = transaction.Rate
            str(6) = transaction.TransactionAt

            item = New ListViewItem(str)
            lvTransaction.Items.Add(item)
        Next
    End Sub

    Private Sub btnClearTransation_Click(sender As Object, e As EventArgs) Handles btnClearTransation.Click
        displayTransactions()
    End Sub

    Private Sub displayTransactions()
        Dim transactions = Transaction.findAll
        lvTransaction.Clear()

        lvTransaction.Columns.Add("ID", 50, HorizontalAlignment.Left)
        lvTransaction.Columns.Add("CustomerID", 70, HorizontalAlignment.Left)
        lvTransaction.Columns.Add("FromRateID", 70, HorizontalAlignment.Left)
        lvTransaction.Columns.Add("ToRateID", 70, HorizontalAlignment.Left)
        lvTransaction.Columns.Add("Amount", 70, HorizontalAlignment.Left)
        lvTransaction.Columns.Add("Rate", 70, HorizontalAlignment.Left)
        lvTransaction.Columns.Add("TransactionAt", 70, HorizontalAlignment.Left)

        For Each transaction In transactions
            Dim item As ListViewItem
            Dim str(6) As String
            str(0) = transaction.ID
            str(1) = transaction.CustomerID
            str(2) = transaction.FromRateID
            str(3) = transaction.ToRateID
            str(4) = transaction.Amount
            str(5) = transaction.Rate
            str(6) = transaction.TransactionAt

            item = New ListViewItem(str)
            lvTransaction.Items.Add(item)
        Next
    End Sub

    Private Sub lvTransaction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvTransaction.SelectedIndexChanged
        If lvTransaction.SelectedItems.Count < 1 Then
            Exit Sub
        End If

        Dim id = Val(lvTransaction.SelectedItems.Item(0).Text)
        If id = 0 Then
            Exit Sub
        End If
        Dim t = Transaction.findByID(id)
        tbxTransactionID.Text = t.ID
        tbxTransactionCustomerID.Text = t.CustomerID
        tbxTransactionFromRateID.Text = t.FromRateID
        tbxTransactionToRateID.Text = t.ToRateID
        tbxTransactionAmout.Text = t.Amount
        tbxTransactionRate.Text = t.Rate
        tbxTransactionAt.Text = t.TransactionAt
    End Sub
End Class
