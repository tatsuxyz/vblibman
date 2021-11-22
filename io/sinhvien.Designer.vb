<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddStudent
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtMSV = New System.Windows.Forms.TextBox()
        Me.lblMSV = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtBirth = New System.Windows.Forms.TextBox()
        Me.lblBirth = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.cbxGender = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(184, 54)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Sinh viên"
        '
        'txtMSV
        '
        Me.txtMSV.Location = New System.Drawing.Point(109, 82)
        Me.txtMSV.Name = "txtMSV"
        Me.txtMSV.Size = New System.Drawing.Size(332, 27)
        Me.txtMSV.TabIndex = 1
        '
        'lblMSV
        '
        Me.lblMSV.AutoSize = True
        Me.lblMSV.Location = New System.Drawing.Point(12, 85)
        Me.lblMSV.Name = "lblMSV"
        Me.lblMSV.Size = New System.Drawing.Size(91, 20)
        Me.lblMSV.TabIndex = 2
        Me.lblMSV.Text = "Mã sinh viên"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(109, 115)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(332, 27)
        Me.txtName.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 118)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(73, 20)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Họ và tên"
        '
        'txtBirth
        '
        Me.txtBirth.Location = New System.Drawing.Point(109, 148)
        Me.txtBirth.Name = "txtBirth"
        Me.txtBirth.Size = New System.Drawing.Size(332, 27)
        Me.txtBirth.TabIndex = 1
        '
        'lblBirth
        '
        Me.lblBirth.AutoSize = True
        Me.lblBirth.Location = New System.Drawing.Point(12, 151)
        Me.lblBirth.Name = "lblBirth"
        Me.lblBirth.Size = New System.Drawing.Size(74, 20)
        Me.lblBirth.TabIndex = 2
        Me.lblBirth.Text = "Ngày sinh"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(12, 184)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(65, 20)
        Me.lblGender.TabIndex = 2
        Me.lblGender.Text = "Giới tính"
        '
        'cbxGender
        '
        Me.cbxGender.FormattingEnabled = True
        Me.cbxGender.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.cbxGender.Location = New System.Drawing.Point(109, 184)
        Me.cbxGender.Name = "cbxGender"
        Me.cbxGender.Size = New System.Drawing.Size(332, 28)
        Me.cbxGender.TabIndex = 3
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(346, 236)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(72, 43)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Sửa"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(268, 236)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 43)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Xoá"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(190, 236)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 43)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Thêm"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(112, 236)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 43)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = ">"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(34, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 43)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmAddStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 299)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbxGender)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblBirth)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblMSV)
        Me.Controls.Add(Me.txtBirth)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtMSV)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmAddStudent"
        Me.Text = "Thêm sinh viên"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtMSV As TextBox
    Friend WithEvents lblMSV As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtBirth As TextBox
    Friend WithEvents lblBirth As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents cbxGender As ComboBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
