<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChiTietSach
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPubYear = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGenre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPubCode = New System.Windows.Forms.TextBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(204, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 59)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Chi tiết sách"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(48, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "TÊN SÁCH"
        '
        'txtBookName
        '
        Me.txtBookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBookName.Location = New System.Drawing.Point(233, 124)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(370, 27)
        Me.txtBookName.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(48, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 28)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "NĂM XUẤT BẢN"
        '
        'txtPubYear
        '
        Me.txtPubYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPubYear.Location = New System.Drawing.Point(233, 165)
        Me.txtPubYear.Name = "txtPubYear"
        Me.txtPubYear.Size = New System.Drawing.Size(370, 27)
        Me.txtPubYear.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(49, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 28)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "THỂ LOẠI"
        '
        'txtGenre
        '
        Me.txtGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGenre.Location = New System.Drawing.Point(234, 207)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(370, 27)
        Me.txtGenre.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(48, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 28)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "MÃ NXB"
        '
        'txtPubCode
        '
        Me.txtPubCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPubCode.Location = New System.Drawing.Point(233, 251)
        Me.txtPubCode.Name = "txtPubCode"
        Me.txtPubCode.Size = New System.Drawing.Size(370, 27)
        Me.txtPubCode.TabIndex = 3
        '
        'cmdSave
        '
        Me.cmdSave.Enabled = False
        Me.cmdSave.Location = New System.Drawing.Point(194, 341)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(130, 38)
        Me.cmdSave.TabIndex = 4
        Me.cmdSave.Text = "Lưu"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(330, 341)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(130, 38)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Thoát"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'frmChiTietSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 408)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.txtPubCode)
        Me.Controls.Add(Me.txtGenre)
        Me.Controls.Add(Me.txtPubYear)
        Me.Controls.Add(Me.txtBookName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmChiTietSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBookName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPubYear As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPubCode As TextBox
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdCancel As Button
End Class
