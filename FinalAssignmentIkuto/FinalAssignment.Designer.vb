<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinalAssignment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabCustomer = New System.Windows.Forms.TabPage()
        Me.btnCustomerSearch = New System.Windows.Forms.Button()
        Me.btnCustomerDelete = New System.Windows.Forms.Button()
        Me.btnSearchCustomer = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbxSearchCustomer = New System.Windows.Forms.TextBox()
        Me.btnCustomerModify = New System.Windows.Forms.Button()
        Me.btnCreateCustomer = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbxCustomerEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbxCustomerAddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbxCustomerBankAccount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxCustomerBank = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxCustomerLastName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxCustomerFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxCustomerID = New System.Windows.Forms.TextBox()
        Me.lvCustomer = New System.Windows.Forms.ListView()
        Me.tabRate = New System.Windows.Forms.TabPage()
        Me.tabTransaction = New System.Windows.Forms.TabPage()
        Me.btnClearRate = New System.Windows.Forms.Button()
        Me.btnDeleteRate = New System.Windows.Forms.Button()
        Me.btnSearchRate = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbxSearchRate = New System.Windows.Forms.TextBox()
        Me.btnModifyRate = New System.Windows.Forms.Button()
        Me.btnCreateRate = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbxRateRate = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbxRateCountry = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbxRateID = New System.Windows.Forms.TextBox()
        Me.lvRate = New System.Windows.Forms.ListView()
        Me.btnClearTransation = New System.Windows.Forms.Button()
        Me.btnDeleteTransaction = New System.Windows.Forms.Button()
        Me.btnSearchTransaction = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbxSearchTransaction = New System.Windows.Forms.TextBox()
        Me.btnModifyTransaction = New System.Windows.Forms.Button()
        Me.btnCreateTransaction = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbxTransactionAt = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbxTransactionRate = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbxTransactionAmout = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tbxTransactionToRateID = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tbxTransactionFromRateID = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tbxTransactionCustomerID = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tbxTransactionID = New System.Windows.Forms.TextBox()
        Me.lvTransaction = New System.Windows.Forms.ListView()
        Me.TabControl1.SuspendLayout()
        Me.tabCustomer.SuspendLayout()
        Me.tabRate.SuspendLayout()
        Me.tabTransaction.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabCustomer)
        Me.TabControl1.Controls.Add(Me.tabRate)
        Me.TabControl1.Controls.Add(Me.tabTransaction)
        Me.TabControl1.Location = New System.Drawing.Point(13, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(746, 390)
        Me.TabControl1.TabIndex = 0
        '
        'tabCustomer
        '
        Me.tabCustomer.Controls.Add(Me.btnCustomerSearch)
        Me.tabCustomer.Controls.Add(Me.btnCustomerDelete)
        Me.tabCustomer.Controls.Add(Me.btnSearchCustomer)
        Me.tabCustomer.Controls.Add(Me.Label8)
        Me.tabCustomer.Controls.Add(Me.tbxSearchCustomer)
        Me.tabCustomer.Controls.Add(Me.btnCustomerModify)
        Me.tabCustomer.Controls.Add(Me.btnCreateCustomer)
        Me.tabCustomer.Controls.Add(Me.Label7)
        Me.tabCustomer.Controls.Add(Me.tbxCustomerEmail)
        Me.tabCustomer.Controls.Add(Me.Label6)
        Me.tabCustomer.Controls.Add(Me.tbxCustomerAddress)
        Me.tabCustomer.Controls.Add(Me.Label5)
        Me.tabCustomer.Controls.Add(Me.tbxCustomerBankAccount)
        Me.tabCustomer.Controls.Add(Me.Label4)
        Me.tabCustomer.Controls.Add(Me.tbxCustomerBank)
        Me.tabCustomer.Controls.Add(Me.Label3)
        Me.tabCustomer.Controls.Add(Me.tbxCustomerLastName)
        Me.tabCustomer.Controls.Add(Me.Label2)
        Me.tabCustomer.Controls.Add(Me.tbxCustomerFirstName)
        Me.tabCustomer.Controls.Add(Me.Label1)
        Me.tabCustomer.Controls.Add(Me.tbxCustomerID)
        Me.tabCustomer.Controls.Add(Me.lvCustomer)
        Me.tabCustomer.Location = New System.Drawing.Point(4, 22)
        Me.tabCustomer.Name = "tabCustomer"
        Me.tabCustomer.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCustomer.Size = New System.Drawing.Size(738, 364)
        Me.tabCustomer.TabIndex = 0
        Me.tabCustomer.Text = "Customer"
        Me.tabCustomer.UseVisualStyleBackColor = True
        '
        'btnCustomerSearch
        '
        Me.btnCustomerSearch.Location = New System.Drawing.Point(640, 299)
        Me.btnCustomerSearch.Name = "btnCustomerSearch"
        Me.btnCustomerSearch.Size = New System.Drawing.Size(92, 23)
        Me.btnCustomerSearch.TabIndex = 21
        Me.btnCustomerSearch.Text = "Clear"
        Me.btnCustomerSearch.UseVisualStyleBackColor = True
        '
        'btnCustomerDelete
        '
        Me.btnCustomerDelete.Location = New System.Drawing.Point(534, 227)
        Me.btnCustomerDelete.Name = "btnCustomerDelete"
        Me.btnCustomerDelete.Size = New System.Drawing.Size(92, 23)
        Me.btnCustomerDelete.TabIndex = 20
        Me.btnCustomerDelete.Text = "Delete"
        Me.btnCustomerDelete.UseVisualStyleBackColor = True
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.Location = New System.Drawing.Point(534, 299)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Size = New System.Drawing.Size(92, 23)
        Me.btnSearchCustomer.TabIndex = 19
        Me.btnSearchCustomer.Text = "Search"
        Me.btnSearchCustomer.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(531, 268)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Search FirstName"
        '
        'tbxSearchCustomer
        '
        Me.tbxSearchCustomer.Location = New System.Drawing.Point(632, 264)
        Me.tbxSearchCustomer.Name = "tbxSearchCustomer"
        Me.tbxSearchCustomer.Size = New System.Drawing.Size(100, 20)
        Me.tbxSearchCustomer.TabIndex = 17
        '
        'btnCustomerModify
        '
        Me.btnCustomerModify.Location = New System.Drawing.Point(640, 195)
        Me.btnCustomerModify.Name = "btnCustomerModify"
        Me.btnCustomerModify.Size = New System.Drawing.Size(92, 23)
        Me.btnCustomerModify.TabIndex = 16
        Me.btnCustomerModify.Text = "Modify"
        Me.btnCustomerModify.UseVisualStyleBackColor = True
        '
        'btnCreateCustomer
        '
        Me.btnCreateCustomer.Location = New System.Drawing.Point(534, 195)
        Me.btnCreateCustomer.Name = "btnCreateCustomer"
        Me.btnCreateCustomer.Size = New System.Drawing.Size(92, 23)
        Me.btnCreateCustomer.TabIndex = 15
        Me.btnCreateCustomer.Text = "Create"
        Me.btnCreateCustomer.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(531, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Email"
        '
        'tbxCustomerEmail
        '
        Me.tbxCustomerEmail.Location = New System.Drawing.Point(632, 162)
        Me.tbxCustomerEmail.Name = "tbxCustomerEmail"
        Me.tbxCustomerEmail.Size = New System.Drawing.Size(100, 20)
        Me.tbxCustomerEmail.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(531, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Address"
        '
        'tbxCustomerAddress
        '
        Me.tbxCustomerAddress.Location = New System.Drawing.Point(632, 136)
        Me.tbxCustomerAddress.Name = "tbxCustomerAddress"
        Me.tbxCustomerAddress.Size = New System.Drawing.Size(100, 20)
        Me.tbxCustomerAddress.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(531, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "BankAccount"
        '
        'tbxCustomerBankAccount
        '
        Me.tbxCustomerBankAccount.Location = New System.Drawing.Point(632, 110)
        Me.tbxCustomerBankAccount.Name = "tbxCustomerBankAccount"
        Me.tbxCustomerBankAccount.Size = New System.Drawing.Size(100, 20)
        Me.tbxCustomerBankAccount.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(531, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Bank"
        '
        'tbxCustomerBank
        '
        Me.tbxCustomerBank.Location = New System.Drawing.Point(632, 84)
        Me.tbxCustomerBank.Name = "tbxCustomerBank"
        Me.tbxCustomerBank.Size = New System.Drawing.Size(100, 20)
        Me.tbxCustomerBank.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(531, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "LastName"
        '
        'tbxCustomerLastName
        '
        Me.tbxCustomerLastName.Location = New System.Drawing.Point(632, 58)
        Me.tbxCustomerLastName.Name = "tbxCustomerLastName"
        Me.tbxCustomerLastName.Size = New System.Drawing.Size(100, 20)
        Me.tbxCustomerLastName.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(531, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "FirstName"
        '
        'tbxCustomerFirstName
        '
        Me.tbxCustomerFirstName.Location = New System.Drawing.Point(632, 32)
        Me.tbxCustomerFirstName.Name = "tbxCustomerFirstName"
        Me.tbxCustomerFirstName.Size = New System.Drawing.Size(100, 20)
        Me.tbxCustomerFirstName.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(531, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID"
        '
        'tbxCustomerID
        '
        Me.tbxCustomerID.Location = New System.Drawing.Point(632, 6)
        Me.tbxCustomerID.Name = "tbxCustomerID"
        Me.tbxCustomerID.Size = New System.Drawing.Size(100, 20)
        Me.tbxCustomerID.TabIndex = 1
        '
        'lvCustomer
        '
        Me.lvCustomer.Location = New System.Drawing.Point(6, 6)
        Me.lvCustomer.Name = "lvCustomer"
        Me.lvCustomer.Size = New System.Drawing.Size(518, 352)
        Me.lvCustomer.TabIndex = 0
        Me.lvCustomer.UseCompatibleStateImageBehavior = False
        Me.lvCustomer.View = System.Windows.Forms.View.Details
        '
        'tabRate
        '
        Me.tabRate.Controls.Add(Me.btnClearRate)
        Me.tabRate.Controls.Add(Me.btnDeleteRate)
        Me.tabRate.Controls.Add(Me.btnSearchRate)
        Me.tabRate.Controls.Add(Me.Label9)
        Me.tabRate.Controls.Add(Me.tbxSearchRate)
        Me.tabRate.Controls.Add(Me.btnModifyRate)
        Me.tabRate.Controls.Add(Me.btnCreateRate)
        Me.tabRate.Controls.Add(Me.Label14)
        Me.tabRate.Controls.Add(Me.tbxRateRate)
        Me.tabRate.Controls.Add(Me.Label15)
        Me.tabRate.Controls.Add(Me.tbxRateCountry)
        Me.tabRate.Controls.Add(Me.Label16)
        Me.tabRate.Controls.Add(Me.tbxRateID)
        Me.tabRate.Controls.Add(Me.lvRate)
        Me.tabRate.Location = New System.Drawing.Point(4, 22)
        Me.tabRate.Name = "tabRate"
        Me.tabRate.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRate.Size = New System.Drawing.Size(738, 364)
        Me.tabRate.TabIndex = 1
        Me.tabRate.Text = "Rate"
        Me.tabRate.UseVisualStyleBackColor = True
        '
        'tabTransaction
        '
        Me.tabTransaction.Controls.Add(Me.btnClearTransation)
        Me.tabTransaction.Controls.Add(Me.btnDeleteTransaction)
        Me.tabTransaction.Controls.Add(Me.btnSearchTransaction)
        Me.tabTransaction.Controls.Add(Me.Label17)
        Me.tabTransaction.Controls.Add(Me.tbxSearchTransaction)
        Me.tabTransaction.Controls.Add(Me.btnModifyTransaction)
        Me.tabTransaction.Controls.Add(Me.btnCreateTransaction)
        Me.tabTransaction.Controls.Add(Me.Label18)
        Me.tabTransaction.Controls.Add(Me.tbxTransactionAt)
        Me.tabTransaction.Controls.Add(Me.Label19)
        Me.tabTransaction.Controls.Add(Me.tbxTransactionRate)
        Me.tabTransaction.Controls.Add(Me.Label20)
        Me.tabTransaction.Controls.Add(Me.tbxTransactionAmout)
        Me.tabTransaction.Controls.Add(Me.Label21)
        Me.tabTransaction.Controls.Add(Me.tbxTransactionToRateID)
        Me.tabTransaction.Controls.Add(Me.Label22)
        Me.tabTransaction.Controls.Add(Me.tbxTransactionFromRateID)
        Me.tabTransaction.Controls.Add(Me.Label23)
        Me.tabTransaction.Controls.Add(Me.tbxTransactionCustomerID)
        Me.tabTransaction.Controls.Add(Me.Label24)
        Me.tabTransaction.Controls.Add(Me.tbxTransactionID)
        Me.tabTransaction.Controls.Add(Me.lvTransaction)
        Me.tabTransaction.Location = New System.Drawing.Point(4, 22)
        Me.tabTransaction.Name = "tabTransaction"
        Me.tabTransaction.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTransaction.Size = New System.Drawing.Size(738, 364)
        Me.tabTransaction.TabIndex = 2
        Me.tabTransaction.Text = "Transaction"
        Me.tabTransaction.UseVisualStyleBackColor = True
        '
        'btnClearRate
        '
        Me.btnClearRate.Location = New System.Drawing.Point(640, 196)
        Me.btnClearRate.Name = "btnClearRate"
        Me.btnClearRate.Size = New System.Drawing.Size(92, 23)
        Me.btnClearRate.TabIndex = 43
        Me.btnClearRate.Text = "Clear"
        Me.btnClearRate.UseVisualStyleBackColor = True
        '
        'btnDeleteRate
        '
        Me.btnDeleteRate.Location = New System.Drawing.Point(530, 126)
        Me.btnDeleteRate.Name = "btnDeleteRate"
        Me.btnDeleteRate.Size = New System.Drawing.Size(92, 23)
        Me.btnDeleteRate.TabIndex = 42
        Me.btnDeleteRate.Text = "Delete"
        Me.btnDeleteRate.UseVisualStyleBackColor = True
        '
        'btnSearchRate
        '
        Me.btnSearchRate.Location = New System.Drawing.Point(534, 196)
        Me.btnSearchRate.Name = "btnSearchRate"
        Me.btnSearchRate.Size = New System.Drawing.Size(92, 23)
        Me.btnSearchRate.TabIndex = 41
        Me.btnSearchRate.Text = "Search"
        Me.btnSearchRate.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(531, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Search Country"
        '
        'tbxSearchRate
        '
        Me.tbxSearchRate.Location = New System.Drawing.Point(632, 161)
        Me.tbxSearchRate.Name = "tbxSearchRate"
        Me.tbxSearchRate.Size = New System.Drawing.Size(100, 20)
        Me.tbxSearchRate.TabIndex = 39
        '
        'btnModifyRate
        '
        Me.btnModifyRate.Location = New System.Drawing.Point(636, 94)
        Me.btnModifyRate.Name = "btnModifyRate"
        Me.btnModifyRate.Size = New System.Drawing.Size(92, 23)
        Me.btnModifyRate.TabIndex = 38
        Me.btnModifyRate.Text = "Modify"
        Me.btnModifyRate.UseVisualStyleBackColor = True
        '
        'btnCreateRate
        '
        Me.btnCreateRate.Location = New System.Drawing.Point(530, 94)
        Me.btnCreateRate.Name = "btnCreateRate"
        Me.btnCreateRate.Size = New System.Drawing.Size(92, 23)
        Me.btnCreateRate.TabIndex = 37
        Me.btnCreateRate.Text = "Create"
        Me.btnCreateRate.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(531, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Rate"
        '
        'tbxRateRate
        '
        Me.tbxRateRate.Location = New System.Drawing.Point(632, 58)
        Me.tbxRateRate.Name = "tbxRateRate"
        Me.tbxRateRate.Size = New System.Drawing.Size(100, 20)
        Me.tbxRateRate.TabIndex = 27
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(531, 36)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Country"
        '
        'tbxRateCountry
        '
        Me.tbxRateCountry.Location = New System.Drawing.Point(632, 32)
        Me.tbxRateCountry.Name = "tbxRateCountry"
        Me.tbxRateCountry.Size = New System.Drawing.Size(100, 20)
        Me.tbxRateCountry.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(531, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 13)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "ID"
        '
        'tbxRateID
        '
        Me.tbxRateID.Location = New System.Drawing.Point(632, 6)
        Me.tbxRateID.Name = "tbxRateID"
        Me.tbxRateID.Size = New System.Drawing.Size(100, 20)
        Me.tbxRateID.TabIndex = 23
        '
        'lvRate
        '
        Me.lvRate.Location = New System.Drawing.Point(6, 6)
        Me.lvRate.Name = "lvRate"
        Me.lvRate.Size = New System.Drawing.Size(518, 352)
        Me.lvRate.TabIndex = 22
        Me.lvRate.UseCompatibleStateImageBehavior = False
        Me.lvRate.View = System.Windows.Forms.View.Details
        '
        'btnClearTransation
        '
        Me.btnClearTransation.Location = New System.Drawing.Point(640, 299)
        Me.btnClearTransation.Name = "btnClearTransation"
        Me.btnClearTransation.Size = New System.Drawing.Size(92, 23)
        Me.btnClearTransation.TabIndex = 43
        Me.btnClearTransation.Text = "Clear"
        Me.btnClearTransation.UseVisualStyleBackColor = True
        '
        'btnDeleteTransaction
        '
        Me.btnDeleteTransaction.Location = New System.Drawing.Point(534, 227)
        Me.btnDeleteTransaction.Name = "btnDeleteTransaction"
        Me.btnDeleteTransaction.Size = New System.Drawing.Size(92, 23)
        Me.btnDeleteTransaction.TabIndex = 42
        Me.btnDeleteTransaction.Text = "Delete"
        Me.btnDeleteTransaction.UseVisualStyleBackColor = True
        '
        'btnSearchTransaction
        '
        Me.btnSearchTransaction.Location = New System.Drawing.Point(534, 299)
        Me.btnSearchTransaction.Name = "btnSearchTransaction"
        Me.btnSearchTransaction.Size = New System.Drawing.Size(92, 23)
        Me.btnSearchTransaction.TabIndex = 41
        Me.btnSearchTransaction.Text = "Search"
        Me.btnSearchTransaction.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(531, 268)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(99, 13)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Search CustomerID"
        '
        'tbxSearchTransaction
        '
        Me.tbxSearchTransaction.Location = New System.Drawing.Point(632, 264)
        Me.tbxSearchTransaction.Name = "tbxSearchTransaction"
        Me.tbxSearchTransaction.Size = New System.Drawing.Size(100, 20)
        Me.tbxSearchTransaction.TabIndex = 39
        '
        'btnModifyTransaction
        '
        Me.btnModifyTransaction.Location = New System.Drawing.Point(640, 195)
        Me.btnModifyTransaction.Name = "btnModifyTransaction"
        Me.btnModifyTransaction.Size = New System.Drawing.Size(92, 23)
        Me.btnModifyTransaction.TabIndex = 38
        Me.btnModifyTransaction.Text = "Modify"
        Me.btnModifyTransaction.UseVisualStyleBackColor = True
        '
        'btnCreateTransaction
        '
        Me.btnCreateTransaction.Location = New System.Drawing.Point(534, 195)
        Me.btnCreateTransaction.Name = "btnCreateTransaction"
        Me.btnCreateTransaction.Size = New System.Drawing.Size(92, 23)
        Me.btnCreateTransaction.TabIndex = 37
        Me.btnCreateTransaction.Text = "Create"
        Me.btnCreateTransaction.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(531, 166)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 13)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "TransactionAt"
        '
        'tbxTransactionAt
        '
        Me.tbxTransactionAt.Location = New System.Drawing.Point(632, 162)
        Me.tbxTransactionAt.Name = "tbxTransactionAt"
        Me.tbxTransactionAt.Size = New System.Drawing.Size(100, 20)
        Me.tbxTransactionAt.TabIndex = 35
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(531, 140)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(30, 13)
        Me.Label19.TabIndex = 34
        Me.Label19.Text = "Rate"
        '
        'tbxTransactionRate
        '
        Me.tbxTransactionRate.Location = New System.Drawing.Point(632, 136)
        Me.tbxTransactionRate.Name = "tbxTransactionRate"
        Me.tbxTransactionRate.Size = New System.Drawing.Size(100, 20)
        Me.tbxTransactionRate.TabIndex = 33
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(531, 114)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(37, 13)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "Amout"
        '
        'tbxTransactionAmout
        '
        Me.tbxTransactionAmout.Location = New System.Drawing.Point(632, 110)
        Me.tbxTransactionAmout.Name = "tbxTransactionAmout"
        Me.tbxTransactionAmout.Size = New System.Drawing.Size(100, 20)
        Me.tbxTransactionAmout.TabIndex = 31
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(531, 88)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(54, 13)
        Me.Label21.TabIndex = 30
        Me.Label21.Text = "ToRateID"
        '
        'tbxTransactionToRateID
        '
        Me.tbxTransactionToRateID.Location = New System.Drawing.Point(632, 84)
        Me.tbxTransactionToRateID.Name = "tbxTransactionToRateID"
        Me.tbxTransactionToRateID.Size = New System.Drawing.Size(100, 20)
        Me.tbxTransactionToRateID.TabIndex = 29
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(531, 62)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 13)
        Me.Label22.TabIndex = 28
        Me.Label22.Text = "FromRateID"
        '
        'tbxTransactionFromRateID
        '
        Me.tbxTransactionFromRateID.Location = New System.Drawing.Point(632, 58)
        Me.tbxTransactionFromRateID.Name = "tbxTransactionFromRateID"
        Me.tbxTransactionFromRateID.Size = New System.Drawing.Size(100, 20)
        Me.tbxTransactionFromRateID.TabIndex = 27
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(531, 36)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(62, 13)
        Me.Label23.TabIndex = 26
        Me.Label23.Text = "CustomerID"
        '
        'tbxTransactionCustomerID
        '
        Me.tbxTransactionCustomerID.Location = New System.Drawing.Point(632, 32)
        Me.tbxTransactionCustomerID.Name = "tbxTransactionCustomerID"
        Me.tbxTransactionCustomerID.Size = New System.Drawing.Size(100, 20)
        Me.tbxTransactionCustomerID.TabIndex = 25
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(531, 10)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(18, 13)
        Me.Label24.TabIndex = 24
        Me.Label24.Text = "ID"
        '
        'tbxTransactionID
        '
        Me.tbxTransactionID.Location = New System.Drawing.Point(632, 6)
        Me.tbxTransactionID.Name = "tbxTransactionID"
        Me.tbxTransactionID.Size = New System.Drawing.Size(100, 20)
        Me.tbxTransactionID.TabIndex = 23
        '
        'lvTransaction
        '
        Me.lvTransaction.Location = New System.Drawing.Point(6, 6)
        Me.lvTransaction.Name = "lvTransaction"
        Me.lvTransaction.Size = New System.Drawing.Size(518, 352)
        Me.lvTransaction.TabIndex = 22
        Me.lvTransaction.UseCompatibleStateImageBehavior = False
        Me.lvTransaction.View = System.Windows.Forms.View.Details
        '
        'FinalAssignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 414)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FinalAssignment"
        Me.Text = "FinalAssignment"
        Me.TabControl1.ResumeLayout(False)
        Me.tabCustomer.ResumeLayout(False)
        Me.tabCustomer.PerformLayout()
        Me.tabRate.ResumeLayout(False)
        Me.tabRate.PerformLayout()
        Me.tabTransaction.ResumeLayout(False)
        Me.tabTransaction.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabCustomer As TabPage
    Friend WithEvents tabRate As TabPage
    Friend WithEvents tabTransaction As TabPage
    Friend WithEvents lvCustomer As ListView
    Friend WithEvents btnCustomerModify As Button
    Friend WithEvents btnCreateCustomer As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents tbxCustomerEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbxCustomerAddress As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbxCustomerBankAccount As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbxCustomerBank As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxCustomerLastName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxCustomerFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxCustomerID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbxSearchCustomer As TextBox
    Friend WithEvents btnSearchCustomer As Button
    Friend WithEvents btnCustomerDelete As Button
    Friend WithEvents btnCustomerSearch As Button
    Friend WithEvents btnClearRate As Button
    Friend WithEvents btnDeleteRate As Button
    Friend WithEvents btnSearchRate As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents tbxSearchRate As TextBox
    Friend WithEvents btnModifyRate As Button
    Friend WithEvents btnCreateRate As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents tbxRateRate As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents tbxRateCountry As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents tbxRateID As TextBox
    Friend WithEvents lvRate As ListView
    Friend WithEvents btnClearTransation As Button
    Friend WithEvents btnDeleteTransaction As Button
    Friend WithEvents btnSearchTransaction As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents tbxSearchTransaction As TextBox
    Friend WithEvents btnModifyTransaction As Button
    Friend WithEvents btnCreateTransaction As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents tbxTransactionAt As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents tbxTransactionRate As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents tbxTransactionAmout As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents tbxTransactionToRateID As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents tbxTransactionFromRateID As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents tbxTransactionCustomerID As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents tbxTransactionID As TextBox
    Friend WithEvents lvTransaction As ListView
End Class
