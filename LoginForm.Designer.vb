<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Admin = New System.Windows.Forms.Label()
        Me.Admin_username = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.Label()
        Me.Pass_word = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Admin
        '
        Me.Admin.AutoSize = True
        Me.Admin.BackColor = System.Drawing.Color.Gainsboro
        Me.Admin.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Admin.Location = New System.Drawing.Point(552, 127)
        Me.Admin.Name = "Admin"
        Me.Admin.Size = New System.Drawing.Size(60, 22)
        Me.Admin.TabIndex = 0
        Me.Admin.Text = "Admin"
        '
        'Admin_username
        '
        Me.Admin_username.Location = New System.Drawing.Point(556, 152)
        Me.Admin_username.Name = "Admin_username"
        Me.Admin_username.Size = New System.Drawing.Size(174, 20)
        Me.Admin_username.TabIndex = 1
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.BackColor = System.Drawing.Color.LightGray
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(552, 202)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(89, 22)
        Me.Password.TabIndex = 2
        Me.Password.Text = "Password"
        '
        'Pass_word
        '
        Me.Pass_word.Location = New System.Drawing.Point(556, 227)
        Me.Pass_word.Name = "Pass_word"
        Me.Pass_word.Size = New System.Drawing.Size(174, 20)
        Me.Pass_word.TabIndex = 3
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(556, 280)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(73, 41)
        Me.OK.TabIndex = 4
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(658, 280)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(72, 41)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(522, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 26)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "LION'S DEN MMA LOGIN"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.EdpActivity4.My.Resources.Resources.images
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-8, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(474, 468)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'LoginForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSalmon
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(842, 464)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Pass_word)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Admin_username)
        Me.Controls.Add(Me.Admin)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Admin As Label
    Friend WithEvents Admin_username As TextBox
    Friend WithEvents Password As Label
    Friend WithEvents Pass_word As TextBox
    Friend WithEvents OK As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
