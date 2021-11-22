Public Class frmViewPubs
    Public Access As New AccessControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub frmViewBook_Shown(sender As Object, e As EventArgs) Handles MyBase.Load
        ' RUN A QUERY
        Access.ExecQuery("SELECT * FROM NXB ORDER BY tennxb ASC")
        If Not String.IsNullOrEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub

        ' FILL DATAGRID
        dgvData.DataSource = Access.DBDT

        ' FILL COMBOBOX
        For Each R As DataRow In Access.DBDT.Rows
            cbxItems.Items.Add(R("tennxb"))
        Next

        '
        If Access.RecordCount > 0 Then cbxItems.SelectedIndex = 0
    End Sub

    Private Sub SearchBook(Name As String)
        ' ADD PARAMETERS AND RUN QUERY
        Access.AddParam("@tennxb", "%" & Name & "%")
        Access.ExecQuery("SELECT * " &
                         "FROM NXB " &
                         "WHERE tennxb LIKE @tennxb")

        ' REPORT AND ABORT ON ERROR
        If NotEmpty(Access.Exception) Then MessageBox.Show(Access.Exception) : Exit Sub

        ' FILL COMBOBOX
        dgvData.DataSource = Access.DBDT
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs)
        SearchBook(txtSearch.Text)
    End Sub
End Class