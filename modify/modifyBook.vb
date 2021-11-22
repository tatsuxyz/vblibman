Public Class frmModifyBook
    Private Access As New AccessControl

    Private CurrentRecord As Integer = 0

    ' ERROR CHECKING AND REPORTING
    Private Function NoErrors(Optional Report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(Access.Exception) Then
            If Report = True Then MessageBox.Show(Access.Exception) ' Report errors
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub GetBooks()
        ' QUERY BOOK TO FILL DATATABLE
        Access.ExecQuery("SELECT * FROM chiTietSach ORDER BY masach ASC")

        ' REPORT AND ABORT ON ERRORS
        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub

        ' GET FIRST RECORD
        GetRecord()


    End Sub

    Private Sub GetRecord()
        ' FAIL IF NO RECORD FOUND OR POSITION IS OUT OF RANGE
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        ' RETURN FIRST USER FOUND
        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        ' POPULATE FIELDS
        txtId.Text = r("masach").ToString
        txtName.Text = r("tensach").ToString
        txtPubYear.Text = r("namxb").ToString
        txtGenre.Text = r("theloai").ToString
        txtPubCode.Text = r("manxb").ToString

        ' If r("Active") IsNot Nothing Then cbActive.Checked = r("Active")
    End Sub

    Private Sub NextRecord(AddVal As Integer)
        CurrentRecord += AddVal ' Advance position by AddVal
        If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0 ' Loop to first record
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1 ' Loop to last record

        ' Update form 
        GetRecord()
    End Sub

    Private Sub UpdateRecord()
        ' FAIL IF NO USER SELECED
        If String.IsNullOrEmpty(txtId.Text) Then Exit Sub

        ' ADD PARAMS - ORDER MATTERS!
        Access.AddParam("@tensach", txtName.Text)
        Access.AddParam("@namxb", txtPubYear.Text)
        Access.AddParam("@theloai", txtGenre.Text)
        Access.AddParam("@manxb", txtPubCode.Text)
        Access.AddParam("@masach", txtId.Text)

        ' RUN COMMAND
        Access.ExecQuery("UPDATE chiTietSach " &
                         "SET tensach=@tensach, namxb=@namxb, theloai=@theloai, manxb=@manxb " &
                         "WHERE masach=@masach")

        ' REPORT AND ABORT ON ERRORS
        If NoErrors(True) = False Then Exit Sub

        ' REFRESH THE USERS DATATABLE AND FETCH THE CURRENT RECORD
        GetBooks()
        Me.Text = Me.Text & " - " & " (Đã lưu)"
    End Sub

    Private Sub modifyBook_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        GetBooks()
    End Sub

    Private Sub cmdPrev_Click(sender As Object, e As EventArgs) Handles cmdPrev.Click
        NextRecord(-1)
    End Sub

    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        NextRecord(1)
    End Sub

    Private Sub cmdFirst_Click(sender As Object, e As EventArgs) Handles cmdFirst.Click
        CurrentRecord = 0
        GetRecord()
    End Sub

    Private Sub cmdLast_Click(sender As Object, e As EventArgs) Handles cmdLast.Click
        CurrentRecord = Access.DBDT.Rows.Count - 1
        GetRecord()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        UpdateRecord()
    End Sub
End Class