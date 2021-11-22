Public Class frmViewAuthor
    Public Access As New AccessControl

    Private Function NoErrors(Optional Report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(Access.Exception) Then
            If Report = True Then MessageBox.Show(Access.Exception) ' Report errors
            Return False
        Else
            Return True
        End If
    End Function

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub frmViewBook_Shown(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    Public Sub RefreshGrid()
        ' RUN A QUERY
        Access.ExecQuery("SELECT * FROM tacGia ORDER BY matg ASC")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub

        ' FILL DATAGRID
        dgvData.DataSource = Access.DBDT

        ' CLEAR COMBOBOX
        cbxItems.Items.Clear()

        ' FILL COMBOBOX
        For Each R As DataRow In Access.DBDT.Rows
            cbxItems.Items.Add(R("tentg"))
        Next

        '
        If Access.RecordCount > 0 Then cbxItems.SelectedIndex = 0
    End Sub

    Private Sub SearchBook(Name As String)
        ' ADD PARAMETERS AND RUN QUERY
        Access.AddParam("@tentg", "%" & Name & "%")
        Access.ExecQuery("SELECT * " &
                         "FROM tacGia " &
                         "WHERE tentg LIKE @tentg")

        ' REPORT AND ABORT ON ERROR
        ' If NoErrors(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub
        If NotEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub

        ' FILL COMBOBOX
        dgvData.DataSource = Access.DBDT
    End Sub

    Private Sub DeleteBook()
        ' CONFIRM DELETE
        If MessageBox.Show("Bạn có muốn xoá phần tử?", "Xác nhận xoá", MessageBoxButtons.YesNo) = DialogResult.No Then Exit Sub

        ' DELETE SELECTED USER
        Access.AddParam("@masach", txtSelectedBookId.Text)
        Access.ExecQuery("DELETE FROM tacGia WHERE masach=@masach")

        ' REPORT AND ABORT ON ERRORS
        If NoErrors(True) = False Then Exit Sub

        ' CLEANUP AND REFRESH
        txtSelectedBookId.Clear()
        txtSelectedBookName.Clear()
        btnDelete.Enabled = False
        RefreshGrid()
    End Sub

    Private Sub SelectedBook(tentg As String)
        '   QUERY USER
        Access.AddParam("@tentg", tentg)
        Access.ExecQuery("SELECT TOP 1 masach, tentg FROM tacGia WHERE tentg = @tentg")

        ' REPORT AND ABORT ON ERROR OR NO RECORD WAS FOUND
        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub

        ' GET FIRST ROW ROUND
        Dim r As DataRow = Access.DBDT.Rows(0)

        ' POPULATE TEXTBOXES WITH DATA
        txtSelectedBookId.Text = r("masach").ToString
        txtSelectedBookName.Text = r("tentg").ToString

        ' ENABLE DELETE
        btnDelete.Enabled = True
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        SearchBook(txtSearch.Text)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frmtacGia As New frmtacGia
        frmtacGia.Show()
        RefreshGrid()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshGrid()
    End Sub

    Private Sub cbxItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxItems.SelectedIndexChanged
        If Not String.IsNullOrEmpty(cbxItems.Text) Then SelectedBook(cbxItems.Text)
    End Sub

    Private Sub dgvData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellClick
        ' PREVENT OUT OF INDEX RANGE ERRORS
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

        ' SELECT MY BOOK FROM COLUMN 1 OF ROW CLICKED
        SelectedBook(dgvData.Item(1, e.RowIndex).Value)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteBook()
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Dim frmModifyBook As New frmModifyBook
        frmModifyBook.Show()
    End Sub
End Class