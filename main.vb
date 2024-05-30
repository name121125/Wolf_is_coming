Imports System.ComponentModel

Public Class main
    Private Sub intro_button__Click(sender As Object, e As EventArgs) Handles intro_button.Click
        intro.Show()
        Hide()


    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles close_form.Click
        Me.Close()

    End Sub

    Private Sub start_Click(sender As Object, e As EventArgs) Handles start_button.Click
        Form1.Show()
        Hide()
        'back_music.controls.pause()
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        back_music.URL = My.Application.Info.DirectoryPath & "\Hold it down.mp3"
        back_music.settings.setMode("loop", True)
        back_music.controls.play()
    End Sub
End Class