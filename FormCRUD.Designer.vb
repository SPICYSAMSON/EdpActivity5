<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCRUD
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
        Me.addBtn = New System.Windows.Forms.Button()
        Me.updateButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.clientFirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.clientIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.programIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.clientLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ageTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.sexTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'addBtn
        '
        Me.addBtn.Location = New System.Drawing.Point(73, 252)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(154, 30)
        Me.addBtn.TabIndex = 0
        Me.addBtn.Text = "Add Record"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'updateButton
        '
        Me.updateButton.Location = New System.Drawing.Point(255, 252)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Size = New System.Drawing.Size(154, 30)
        Me.updateButton.TabIndex = 1
        Me.updateButton.Text = "Update Record"
        Me.updateButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.Location = New System.Drawing.Point(457, 252)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(154, 30)
        Me.deleteButton.TabIndex = 2
        Me.deleteButton.Text = "Delete Record"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'searchBtn
        '
        Me.searchBtn.Location = New System.Drawing.Point(580, 22)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(74, 30)
        Me.searchBtn.TabIndex = 3
        Me.searchBtn.Text = "Search"
        Me.searchBtn.UseVisualStyleBackColor = True
        '
        'clientFirstNameTextBox
        '
        Me.clientFirstNameTextBox.Location = New System.Drawing.Point(224, 95)
        Me.clientFirstNameTextBox.Multiline = True
        Me.clientFirstNameTextBox.Name = "clientFirstNameTextBox"
        Me.clientFirstNameTextBox.Size = New System.Drawing.Size(114, 29)
        Me.clientFirstNameTextBox.TabIndex = 4
        '
        'clientIdTextBox
        '
        Me.clientIdTextBox.Location = New System.Drawing.Point(224, 137)
        Me.clientIdTextBox.Multiline = True
        Me.clientIdTextBox.Name = "clientIdTextBox"
        Me.clientIdTextBox.Size = New System.Drawing.Size(77, 26)
        Me.clientIdTextBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(96, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Client ID"
        '
        'searchTextBox
        '
        Me.searchTextBox.Location = New System.Drawing.Point(420, 22)
        Me.searchTextBox.Multiline = True
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(151, 29)
        Me.searchTextBox.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(96, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Program ID"
        '
        'programIdTextBox
        '
        Me.programIdTextBox.Location = New System.Drawing.Point(224, 169)
        Me.programIdTextBox.Multiline = True
        Me.programIdTextBox.Name = "programIdTextBox"
        Me.programIdTextBox.Size = New System.Drawing.Size(77, 26)
        Me.programIdTextBox.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(356, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Last Name"
        '
        'clientLastNameTextBox
        '
        Me.clientLastNameTextBox.Location = New System.Drawing.Point(457, 95)
        Me.clientLastNameTextBox.Multiline = True
        Me.clientLastNameTextBox.Name = "clientLastNameTextBox"
        Me.clientLastNameTextBox.Size = New System.Drawing.Size(114, 29)
        Me.clientLastNameTextBox.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(356, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Age"
        '
        'ageTextBox
        '
        Me.ageTextBox.Location = New System.Drawing.Point(420, 137)
        Me.ageTextBox.Multiline = True
        Me.ageTextBox.Name = "ageTextBox"
        Me.ageTextBox.Size = New System.Drawing.Size(77, 26)
        Me.ageTextBox.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(356, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Sex"
        '
        'sexTextBox
        '
        Me.sexTextBox.Location = New System.Drawing.Point(420, 172)
        Me.sexTextBox.Multiline = True
        Me.sexTextBox.Name = "sexTextBox"
        Me.sexTextBox.Size = New System.Drawing.Size(32, 26)
        Me.sexTextBox.TabIndex = 17
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(73, 312)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(538, 170)
        Me.DataGridView1.TabIndex = 18
        '
        'FormCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EdpActivity4.My.Resources.Resources.mma_labels_vector_mixed_martial_arts_design_fight_clib_49784806
        Me.ClientSize = New System.Drawing.Size(707, 506)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.sexTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ageTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.clientLastNameTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.programIdTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.searchTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.clientIdTextBox)
        Me.Controls.Add(Me.clientFirstNameTextBox)
        Me.Controls.Add(Me.searchBtn)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.updateButton)
        Me.Controls.Add(Me.addBtn)
        Me.Name = "FormCRUD"
        Me.Text = "FormCRUD"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents addBtn As Button
    Friend WithEvents updateButton As Button
    Friend WithEvents deleteButton As Button
    Friend WithEvents searchBtn As Button
    Friend WithEvents clientFirstNameTextBox As TextBox
    Friend WithEvents clientIdTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents programIdTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents clientLastNameTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ageTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents sexTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
