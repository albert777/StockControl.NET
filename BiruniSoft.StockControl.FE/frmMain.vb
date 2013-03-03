Imports BiruniSoft.StockControl.Master

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Top = 0
        Me.Left = 0
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
    End Sub

    Private Sub KeluarDariProgramToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KeluarDariProgramToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BarangToolStripMenuItem.Click
        Dim fx As New frmBarangList
        fx.MdiParent = Me
        fx.WindowState = FormWindowState.Maximized
        fx.Show()
    End Sub

    Private Sub KategoriBarangToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KategoriBarangToolStripMenuItem.Click
        Dim fx As New frmKategoriList
        fx.MdiParent = Me
        fx.WindowState = FormWindowState.Maximized
        fx.Show()
    End Sub

    Private Sub SatuanBarangToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SatuanBarangToolStripMenuItem.Click
        Dim fx As New frmSatuanList
        fx.MdiParent = Me
        fx.WindowState = FormWindowState.Maximized
        fx.Show()
    End Sub

    Private Sub GudangToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GudangToolStripMenuItem.Click
        Dim fx As New frmGudangList
        fx.MdiParent = Me
        fx.WindowState = FormWindowState.Maximized
        fx.Show()
    End Sub

    Private Sub TentangProgramIniToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TentangProgramIniToolStripMenuItem.Click
        Dim fx As New frmAbout
        fx.ShowDialog()
    End Sub
End Class
