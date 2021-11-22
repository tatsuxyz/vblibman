<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLibman
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
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.miEditView = New System.Windows.Forms.ToolStripMenuItem()
        Me.miBook = New System.Windows.Forms.ToolStripMenuItem()
        Me.miAuthorView = New System.Windows.Forms.ToolStripMenuItem()
        Me.miPhieuMuon = New System.Windows.Forms.ToolStripMenuItem()
        Me.miViewStus = New System.Windows.Forms.ToolStripMenuItem()
        Me.miNXB = New System.Windows.Forms.ToolStripMenuItem()
        Me.miAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.msMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMain
        '
        Me.msMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miEditView, Me.miAbout})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(1120, 28)
        Me.msMain.TabIndex = 4
        Me.msMain.Text = "MenuStrip1"
        '
        'miEditView
        '
        Me.miEditView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miBook, Me.miAuthorView, Me.miPhieuMuon, Me.miViewStus, Me.miNXB})
        Me.miEditView.Name = "miEditView"
        Me.miEditView.Size = New System.Drawing.Size(84, 24)
        Me.miEditView.Text = "Xem/Sửa"
        '
        'miBook
        '
        Me.miBook.Name = "miBook"
        Me.miBook.Size = New System.Drawing.Size(180, 26)
        Me.miBook.Text = "Sách"
        '
        'miAuthorView
        '
        Me.miAuthorView.Name = "miAuthorView"
        Me.miAuthorView.Size = New System.Drawing.Size(180, 26)
        Me.miAuthorView.Text = "Tác giả"
        '
        'miPhieuMuon
        '
        Me.miPhieuMuon.Name = "miPhieuMuon"
        Me.miPhieuMuon.Size = New System.Drawing.Size(180, 26)
        Me.miPhieuMuon.Text = "Phiếu Mượn"
        '
        'miViewStus
        '
        Me.miViewStus.Name = "miViewStus"
        Me.miViewStus.Size = New System.Drawing.Size(180, 26)
        Me.miViewStus.Text = "Sinh viên"
        '
        'miNXB
        '
        Me.miNXB.Name = "miNXB"
        Me.miNXB.Size = New System.Drawing.Size(180, 26)
        Me.miNXB.Text = "Nhà xuất bản"
        '
        'miAbout
        '
        Me.miAbout.Name = "miAbout"
        Me.miAbout.Size = New System.Drawing.Size(87, 24)
        Me.miAbout.Text = "Giới thiệu"
        '
        'frmLibman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 674)
        Me.Controls.Add(Me.msMain)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.msMain
        Me.Name = "frmLibman"
        Me.Text = "Quản lý thư viện"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msMain As MenuStrip
    Friend WithEvents miEditView As ToolStripMenuItem
    Friend WithEvents miBook As ToolStripMenuItem
    Friend WithEvents miAuthorView As ToolStripMenuItem
    Friend WithEvents miPhieuMuon As ToolStripMenuItem
    Friend WithEvents miViewStus As ToolStripMenuItem
    Friend WithEvents miNXB As ToolStripMenuItem
    Friend WithEvents miAbout As ToolStripMenuItem
End Class
