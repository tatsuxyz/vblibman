<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewBook
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
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.cbxItems = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtSelectedBookId = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtSelectedBookName = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnModify = New System.Windows.Forms.Button()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSearch
        '
        Me.cmdSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdSearch.Location = New System.Drawing.Point(754, 12)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(94, 29)
        Me.cmdSearch.TabIndex = 0
        Me.cmdSearch.Text = "Tìm kiếm"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Location = New System.Drawing.Point(363, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(385, 27)
        Me.txtSearch.TabIndex = 1
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(13, 52)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.RowHeadersWidth = 51
        Me.dgvData.RowTemplate.Height = 29
        Me.dgvData.Size = New System.Drawing.Size(1335, 657)
        Me.dgvData.TabIndex = 2
        '
        'cbxItems
        '
        Me.cbxItems.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbxItems.FormattingEnabled = True
        Me.cbxItems.Location = New System.Drawing.Point(877, 11)
        Me.cbxItems.Name = "cbxItems"
        Me.cbxItems.Size = New System.Drawing.Size(151, 28)
        Me.cbxItems.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(13, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(94, 29)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Thêm"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.Location = New System.Drawing.Point(1216, 10)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(132, 29)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "Tải dữ liệu mới"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'lblId
        '
        Me.lblId.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(902, 716)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(31, 20)
        Me.lblId.TabIndex = 6
        Me.lblId.Text = "ID: "
        '
        'txtSelectedBookId
        '
        Me.txtSelectedBookId.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedBookId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSelectedBookId.Location = New System.Drawing.Point(938, 713)
        Me.txtSelectedBookId.Name = "txtSelectedBookId"
        Me.txtSelectedBookId.ReadOnly = True
        Me.txtSelectedBookId.Size = New System.Drawing.Size(78, 27)
        Me.txtSelectedBookId.TabIndex = 7
        '
        'lblName
        '
        Me.lblName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(1023, 716)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(72, 20)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Tên sách: "
        '
        'txtSelectedBookName
        '
        Me.txtSelectedBookName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedBookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSelectedBookName.Location = New System.Drawing.Point(1099, 713)
        Me.txtSelectedBookName.Name = "txtSelectedBookName"
        Me.txtSelectedBookName.ReadOnly = True
        Me.txtSelectedBookName.Size = New System.Drawing.Size(223, 27)
        Me.txtSelectedBookName.TabIndex = 7
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(113, 12)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(94, 29)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Xoá"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(40, 716)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(242, 20)
        Me.lblInfo.TabIndex = 9
        Me.lblInfo.Text = "NGUYỄN HOÀNG LONG | 19172133"
        '
        'btnModify
        '
        Me.btnModify.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModify.Location = New System.Drawing.Point(1116, 10)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(94, 29)
        Me.btnModify.TabIndex = 10
        Me.btnModify.Text = "Sửa"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'frmViewBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1361, 746)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtSelectedBookName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtSelectedBookId)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cbxItems)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmdSearch)
        Me.Name = "frmViewBook"
        Me.Text = "Sách"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents cbxItems As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents lblId As Label
    Friend WithEvents txtSelectedBookId As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtSelectedBookName As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents btnModify As Button
End Class
