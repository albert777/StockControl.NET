Public Class frmGudangList

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim fx = New frmGudangEntry()
        fx.ShowDialog()
    End Sub
End Class