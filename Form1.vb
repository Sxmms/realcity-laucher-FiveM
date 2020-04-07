Public Class Launcher
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Launcher_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Launcher_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Launcher_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Shell("Explorer.exe fivem://connect/play.realcity.fr:30120")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Shell("Explorer.exe https://discord.gg/6Z4dsFb")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Shell("Explorer.exe https://www.youtube.com/channel/UCYcKVFfcWClXOqrh7WiBieg")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Shell("Explorer.exe https://twitter.com/RealCity_")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Shell("Explorer.exe ")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Shell("Explorer.exe ")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        My.Computer.Network.DownloadFile("https://www.dropbox.com/sh/ajupahr83cuqlpu/AACWZKxJo45y-9or6aK18quea?dl=0", "C:\Users%username%\AppData\Local\FiveM\FiveM.app\citizen\common\data")
    End Sub
End Class
