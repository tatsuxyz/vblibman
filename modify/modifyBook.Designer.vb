<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModifyBook
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
        Me.cmdFirst = New System.Windows.Forms.Button()
        Me.cmdPrev = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.cmdLast = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPubCode = New System.Windows.Forms.Label()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.lblPubYear = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtPubCode = New System.Windows.Forms.TextBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.txtGenre = New System.Windows.Forms.TextBox()
        Me.txtPubYear = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdFirst
        '
        Me.cmdFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFirst.Location = New System.Drawing.Point(12, 12)
        Me.cmdFirst.Name = "cmdFirst"
        Me.cmdFirst.Size = New System.Drawing.Size(44, 29)
        Me.cmdFirst.TabIndex = 0
        Me.cmdFirst.Text = "<<"
        Me.cmdFirst.UseVisualStyleBackColor = True
        '
        'cmdPrev
        '
        Me.cmdPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrev.Location = New System.Drawing.Point(62, 12)
        Me.cmdPrev.Name = "cmdPrev"
        Me.cmdPrev.Size = New System.Drawing.Size(44, 29)
        Me.cmdPrev.TabIndex = 0
        Me.cmdPrev.Text = "<"
        Me.cmdPrev.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNext.Location = New System.Drawing.Point(375, 12)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(44, 29)
        Me.cmdNext.TabIndex = 0
        Me.cmdNext.Text = ">"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'cmdLast
        '
        Me.cmdLast.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLast.Location = New System.Drawing.Point(425, 12)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.Size = New System.Drawing.Size(44, 29)
        Me.cmdLast.TabIndex = 0
        Me.cmdLast.Text = ">>"
        Me.cmdLast.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblPubCode)
        Me.GroupBox1.Controls.Add(Me.lblGenre)
        Me.GroupBox1.Controls.Add(Me.lblPubYear)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.txtPubCode)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.txtGenre)
        Me.GroupBox1.Controls.Add(Me.txtPubYear)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 289)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chỉnh sửa nội dung"
        '
        'lblPubCode
        '
        Me.lblPubCode.AutoSize = True
        Me.lblPubCode.Location = New System.Drawing.Point(20, 187)
        Me.lblPubCode.Name = "lblPubCode"
        Me.lblPubCode.Size = New System.Drawing.Size(126, 20)
        Me.lblPubCode.TabIndex = 1
        Me.lblPubCode.Text = "Mã nhà xuất bản: "
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Location = New System.Drawing.Point(20, 154)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(69, 20)
        Me.lblGenre.TabIndex = 1
        Me.lblGenre.Text = "Thể loại: "
        '
        'lblPubYear
        '
        Me.lblPubYear.AutoSize = True
        Me.lblPubYear.Location = New System.Drawing.Point(20, 121)
        Me.lblPubYear.Name = "lblPubYear"
        Me.lblPubYear.Size = New System.Drawing.Size(109, 20)
        Me.lblPubYear.TabIndex = 1
        Me.lblPubYear.Text = "Năm xuất bản: "
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(20, 88)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(72, 20)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Tên sách: "
        '
        'txtPubCode
        '
        Me.txtPubCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPubCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPubCode.Location = New System.Drawing.Point(170, 185)
        Me.txtPubCode.Name = "txtPubCode"
        Me.txtPubCode.Size = New System.Drawing.Size(261, 27)
        Me.txtPubCode.TabIndex = 0
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Location = New System.Drawing.Point(160, 238)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(128, 29)
        Me.cmdSave.TabIndex = 0
        Me.cmdSave.Text = "Lưu"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'txtGenre
        '
        Me.txtGenre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGenre.Location = New System.Drawing.Point(170, 152)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(261, 27)
        Me.txtGenre.TabIndex = 0
        '
        'txtPubYear
        '
        Me.txtPubYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPubYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPubYear.Location = New System.Drawing.Point(170, 119)
        Me.txtPubYear.Name = "txtPubYear"
        Me.txtPubYear.Size = New System.Drawing.Size(261, 27)
        Me.txtPubYear.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(170, 86)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(261, 27)
        Me.txtName.TabIndex = 0
        '
        'txtId
        '
        Me.txtId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtId.Location = New System.Drawing.Point(306, 44)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(125, 27)
        Me.txtId.TabIndex = 0
        Me.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmModifyBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 348)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdLast)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.cmdPrev)
        Me.Controls.Add(Me.cmdFirst)
        Me.KeyPreview = True
        Me.Name = "frmModifyBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sửa Dữ liệu về Sách"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdFirst As Button
    Friend WithEvents cmdPrev As Button
    Friend WithEvents cmdNext As Button
    Friend WithEvents cmdLast As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtPubYear As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtPubCode As TextBox
    Friend WithEvents cmdSave As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblPubCode As Label
    Friend WithEvents lblGenre As Label
    Friend WithEvents lblPubYear As Label
End Class
