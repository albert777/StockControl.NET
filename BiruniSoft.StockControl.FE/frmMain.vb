Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Top = 0
        Me.Left = 0
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
    End Sub
End Class
