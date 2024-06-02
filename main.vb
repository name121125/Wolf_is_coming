Imports System.ComponentModel


Public Class main
    Dim music_choose As Integer = 0
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

    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        back_music.URL = My.Application.Info.DirectoryPath & "\Default - Hold it down.mp3"
        back_music.settings.setMode("loop", True)
        back_music.controls.play()


    End Sub

    Private Sub setting_btn_Click(sender As Object, e As EventArgs) Handles setting_btn.Click
        intro_button.Visible = False
        start_button.Visible = False
        close_form.Visible = False
        setting_btn.Visible = False
        Credits_btn.Visible = False
        volume.Visible = True
        music_value.Visible = True
        volume_bar.Visible = True
        setting_back_btn.Visible = True
        Label_music.Visible = True
        music_name.Visible = True
        Change_music.Visible = True

    End Sub

    Private Sub setting_back_btn_Click(sender As Object, e As EventArgs) Handles setting_back_btn.Click
        volume.Visible = False
        music_value.Visible = False
        volume_bar.Visible = False
        setting_back_btn.Visible = False
        Label_music.Visible = False
        music_name.Visible = False
        Change_music.Visible = False
        intro_button.Visible = True
        start_button.Visible = True
        close_form.Visible = True
        Credits_btn.Visible = True
        setting_btn.Visible = True
    End Sub

    Private Sub volume_bar_Scroll(sender As Object, e As EventArgs) Handles volume_bar.Scroll
        back_music.settings.volume = volume_bar.Value
        music_value.Text = volume_bar.Value
    End Sub

    Private Sub Change_music_Click(sender As Object, e As EventArgs) Handles Change_music.Click
        'back_music.URL = 
        If music_name.Visible = True Then
            music_choose += 1
            Select Case music_choose
                Case 0
                    back_music.URL = My.Application.Info.DirectoryPath & "\Default - Hold it down.mp3"
                    music_name.Text = "Default - Hold it down"
                Case 1
                    back_music.URL = My.Application.Info.DirectoryPath & "\Black Out.mp3"
                    music_name.Text = "Black Out"
                Case 2
                    back_music.URL = My.Application.Info.DirectoryPath & "\Diamond City Lights.mp3"
                    music_name.Text = "Diamond City Lights"
                Case 3
                    back_music.URL = My.Application.Info.DirectoryPath & "\God Sees All.mp3"
                    music_name.Text = "God Sees All"
                Case 4
                    back_music.URL = My.Application.Info.DirectoryPath & "\Hope in the Dark.mp3"
                    music_name.Text = "Hope in the Dark"
                Case 5
                    back_music.URL = My.Application.Info.DirectoryPath & "\Let's Get It Started.mp3"
                    music_name.Text = "Let's Get It Started"
            End Select
            If music_choose = 6 Then
                music_choose = 0
                back_music.URL = My.Application.Info.DirectoryPath & "\Default - Hold it down.mp3"
                music_name.Text = "Default - Hold it down"
            End If
        End If

    End Sub

    Private Sub Credits_btn_Click(sender As Object, e As EventArgs) Handles Credits_btn.Click
        intro_button.Visible = False
        start_button.Visible = False
        close_form.Visible = False
        setting_btn.Visible = False
        Credits_btn.Visible = False

        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Credits_back_btn.Visible = True
    End Sub

    Private Sub Credits_back_btn_Click(sender As Object, e As EventArgs) Handles Credits_back_btn.Click
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Credits_back_btn.Visible = False
        setting_btn.Visible = True
        intro_button.Visible = True
        start_button.Visible = True
        close_form.Visible = True
        Credits_btn.Visible = True
    End Sub
End Class