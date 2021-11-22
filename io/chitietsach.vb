Public Class frmChiTietSach
    Private Access As New AccessControl

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub TextBox_Validate(sender As Object, e As EventArgs) Handles txtBookName.TextAlignChanged, txtPubYear.TextChanged, txtGenre.TextChanged, txtPubCode.TextChanged
        If Not String.IsNullOrWhiteSpace(txtBookName.Text) AndAlso Not String.IsNullOrWhiteSpace(txtPubYear.Text) AndAlso Not String.IsNullOrWhiteSpace(txtPubYear.Text) AndAlso Not String.IsNullOrWhiteSpace(txtGenre.Text) AndAlso Not String.IsNullOrWhiteSpace(txtPubCode.Text) Then
            cmdSave.Enabled = True
        End If
    End Sub

    Private Sub AddUser()
        ' ADD PARAMETERS
        Access.AddParam("@tensach", txtBookName.Text)
        Access.AddParam("@namxb", txtPubYear.Text)
        Access.AddParam("@theloai", txtGenre.Text)
        Access.AddParam("@manxb", txtPubCode.Text)

        ' EXCUTE INSERT COMMAND
        Access.ExecQuery("INSERT INTO chiTietSach (tensach, namxb, theloai, manxb) " &
                         "VALUES (@tensach, @namxb, @theloai, @mamxb);")

        ' REPORT & ABORT ON ERROR
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub

        ' SUCCESS
        MessageBox.Show("Nhập dữ liệu thành công!")
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        AddUser()
        txtBookName.Clear()
        txtPubYear.Clear()
        txtGenre.Clear()
        txtPubCode.Clear()
    End Sub
End Class