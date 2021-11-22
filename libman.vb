Public Class frmLibman
    ' VIEW
    Private Sub miBook_Click(sender As Object, e As EventArgs) Handles miBook.Click
        Dim frmViewBook As New frmViewBook
        frmViewBook.MdiParent = Me
        frmViewBook.Show()
    End Sub

    Private Sub miAuthorView_Click(sender As Object, e As EventArgs) Handles miAuthorView.Click
        Dim frmViewAuthor As New frmViewAuthor
        frmViewAuthor.MdiParent = Me
        frmViewAuthor.Show()
    End Sub

    Private Sub miPhieuMuon_Click(sender As Object, e As EventArgs) Handles miPhieuMuon.Click
        Dim frmViewRent As New frmViewRent
        frmViewRent.MdiParent = Me
        frmViewRent.Show()
    End Sub

    Private Sub miNXB_Click(sender As Object, e As EventArgs) Handles miNXB.Click
        Dim frmViewPubs As New frmViewPubs
        frmViewPubs.MdiParent = Me
        frmViewPubs.Show()
    End Sub

    Private Sub miViewStus_Click(sender As Object, e As EventArgs) Handles miViewStus.Click
        Dim frmViewStus As New frmViewStus
        frmViewStus.MdiParent = Me
        frmViewStus.Show()
    End Sub

    ' ADD
    Private Sub SáchToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Dim chiTietSach = New frmChiTietSach()
        chiTietSach.Show()
    End Sub

    Private Sub TácGiảToolStripMenuItem1_Click(sender As Object, e As EventArgs) 
        Dim tacGia = New frmTacGia()
        tacGia.Show()
    End Sub

    Private Sub SinhViênToolStripMenuItem1_Click(sender As Object, e As EventArgs) 
        Dim sinhVien = New frmAddStudent()
        sinhVien.Show()
    End Sub

    Private Sub PhiếuMượnToolStripMenuItem1_Click(sender As Object, e As EventArgs) 
        Dim phieuMuon = New phieumuonsach()
        phieuMuon.Show()
    End Sub

    Private Sub NhàXuấtBảnToolStripMenuItem1_Click(sender As Object, e As EventArgs) 
        Dim nhaXuatBan = New nhaxuatban()
        nhaXuatBan.Show()
    End Sub

    Private Sub frmLibman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frmViewBook As New frmViewBook
        frmViewBook.MdiParent = Me
        frmViewBook.Show()
    End Sub

    Private Sub miAbout_Click(sender As Object, e As EventArgs) Handles miAbout.Click
        Dim frmAbout As New frmAbout
        frmAbout.Show()
    End Sub
End Class
