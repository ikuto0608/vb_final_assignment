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
        Me.lvCustomer = New System.Windows.Forms.ListView()
        Me.tabRate = New System.Windows.Forms.TabPage()
        Me.tabTransaction = New System.Windows.Forms.TabPage()
        Me.tbxCustomerID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxCustomerFirstName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxCustomerLastName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxCustomerBank = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbxCustomerBankAccount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbxCustomerAddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbxCustomerEmail = New System.Windows.Forms.TextBox()
        Me.btnCreateCustomer = New System.Windows.Forms.Button()
        Me.btnCustomerModify = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbxSearchCustomer = New System.Windows.Forms.TextBox()
        Me.btnSearchCustomer = New System.Windows.Forms.Button()
        Me.btnCustomerDelete = New System.Windows.Forms.Button()
        Me.btnCustomerSearch = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tabCustomer.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabCustomer)
        Me.TabControl1.Controls.Add(Me.tabRate)
        Me.TabControl1.Controls.Add(Me.tabTransaction)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
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
        Me.tabTransaction.Location = New System.Drawing.Point(4, 22)
        Me.tabTransaction.Name = "tabTransaction"
        Me.tabTransaction.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTransaction.Size = New System.Drawing.Size(738, 364)
        Me.tabTransaction.TabIndex = 2
        Me.tabTransaction.Text = "Transaction"
        Me.tabTransaction.UseVisualStyleBackColor = True
        '
        'tbxCustomerID
        '
        Me.tbxCustomerID.Location = New System.Drawing.Point(632, 6)
        Me.tbxCustomerID.Name = "tbxCustomerID"
        Me.tbxCustomerID.Size = New System.Drawing.Size(100, 20)
        Me.tbxCustomerID.TabIndex = 1
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
        'btnCreateCustomer
        '
        Me.btnCreateCustomer.Location = New System.Drawing.Point(534, 195)
        Me.btnCreateCustomer.Name = "btnCreateCustomer"
        Me.btnCreateCustomer.Size = New System.Drawing.Size(92, 23)
        Me.btnCreateCustomer.TabIndex = 15
        Me.btnCreateCustomer.Text = "Create"
        Me.btnCreateCustomer.UseVisualStyleBackColor = True
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
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.Location = New System.Drawing.Point(534, 299)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Size = New System.Drawing.Size(92, 23)
        Me.btnSearchCustomer.TabIndex = 19
        Me.btnSearchCustomer.Text = "Search"
        Me.btnSearchCustomer.UseVisualStyleBackColor = True
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
        'btnCustomerSearch
        '
        Me.btnCustomerSearch.Location = New System.Drawing.Point(640, 299)
        Me.btnCustomerSearch.Name = "btnCustomerSearch"
        Me.btnCustomerSearch.Size = New System.Drawing.Size(92, 23)
        Me.btnCustomerSearch.TabIndex = 21
        Me.btnCustomerSearch.Text = "Clear"
        Me.btnCustomerSearch.UseVisualStyleBackColor = True
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
End Class
