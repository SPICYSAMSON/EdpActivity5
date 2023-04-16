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
        Me.deleteRecord = New System.Windows.Forms.Button()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'addBtn
        '
        Me.addBtn.Location = New System.Drawing.Point(63, 231)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(154, 30)
        Me.addBtn.TabIndex = 0
        Me.addBtn.Text = "Add Record"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'updateButton
        '
        Me.updateButton.Location = New System.Drawing.Point(233, 231)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Size = New System.Drawing.Size(154, 30)
        Me.updateButton.TabIndex = 1
        Me.updateButton.Text = "Update Record"
        Me.updateButton.UseVisualStyleBackColor = True
        '
        'deleteRecord
        '
        Me.deleteRecord.Location = New System.Drawing.Point(420, 231)
        Me.deleteRecord.Name = "deleteRecord"
        Me.deleteRecord.Size = New System.Drawing.Size(154, 30)
        Me.deleteRecord.TabIndex = 2
        Me.deleteRecord.Text = "Delete Record"
        Me.deleteRecord.UseVisualStyleBackColor = True
        '
        'searchBtn
        '
        Me.searchBtn.Location = New System.Drawing.Point(500, 21)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(74, 30)
        Me.searchBtn.TabIndex = 3
        Me.searchBtn.Text = "Search"
        Me.searchBtn.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(233, 104)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(270, 29)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(233, 154)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(270, 26)
        Me.TextBox2.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Client"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(96, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Program"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(343, 22)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(151, 29)
        Me.TextBox3.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(29, 284)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(625, 224)
        Me.DataGridView1.TabIndex = 9
        '
        'FormCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EdpActivity4.My.Resources.Resources.mma_labels_vector_mixed_martial_arts_design_fight_clib_49784806
        Me.ClientSize = New System.Drawing.Size(681, 520)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.searchBtn)
        Me.Controls.Add(Me.deleteRecord)
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
    Friend WithEvents deleteRecord As Button
    Friend WithEvents searchBtn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
