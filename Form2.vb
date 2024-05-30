Imports System.ComponentModel

Public Class Form2
    Dim move_speed_up As Integer = -10
    Dim move_speed_down As Integer = 10
    Dim move_speed_left As Integer = -10
    Dim move_speed_right As Integer = 10
    Dim walls(66) As Label
    Dim timer As Integer = 30
    Dim dino_set As Boolean = False
    Dim dino_pos As Point


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For add_pic As Integer = 0 To 64
            walls(add_pic) = CType(Me.Controls("Label" & (add_pic + 1)), Label)
        Next
        PictureBox.BringToFront()
        Init_subject(PictureBox)



    End Sub
    Sub Init_subject(player As PictureBox)

        player.Location = New Point(443, 80)

        player.BringToFront()
        timer = 30
        Label_timer.Text = timer


        'back_music.URL = My.Application.Info.DirectoryPath & "\tsunami.mp3"
        'back_music.settings.setMode("loop", True)
        'back_music.controls.play()



    End Sub

    Sub dino_move()



    End Sub
    Sub Detect(newX As Integer, newY As Integer, dino_detect As Boolean, timer As Integer)
        Dim playerBounds As New Rectangle(newX, newY, PictureBox.Width, PictureBox.Height)
        For wall As Integer = 0 To 64
            If playerBounds.IntersectsWith(walls(wall).Bounds) Then
                ' Player hits a wall, don't move
                Select Case timer
                    Case 1 ' Moving left
                        PictureBox.Left -= move_speed_left
                        left_timer.Enabled = False
                    Case 2 ' Moving right
                        PictureBox.Left -= move_speed_right
                        right_timer.Enabled = False
                    Case 3 ' Moving down
                        PictureBox.Top -= move_speed_down
                        down_timer.Enabled = False
                    Case 4 ' Moving up
                        PictureBox.Top -= move_speed_up
                        up_timer.Enabled = False
                End Select
                Return
            End If
        Next


        ' Move the player to the new position
        PictureBox.Location = New Point(newX, newY)
        If dino_detect = True Then
            If playerBounds.IntersectsWith(PictureBox1.Bounds) Then
                Dim player_report As Integer
                Timer1.Enabled = False
                left_timer.Enabled = False
                right_timer.Enabled = False
                up_timer.Enabled = False
                down_timer.Enabled = False
                player_report = MsgBox("You hit the dino ! Do you need to restart ?", 53, "Times up")
                If player_report = 4 Then
                    Init_subject(PictureBox)
                ElseIf player_report = 2 Then
                    Me.Close()
                    back_music.close()
                End If
            End If
        End If


        If playerBounds.IntersectsWith(Label67.Bounds) Then
            Dim player_report As Integer
            Timer1.Enabled = False
            left_timer.Enabled = False
            right_timer.Enabled = False
            up_timer.Enabled = False
            down_timer.Enabled = False
            player_report = MsgBox("you finish ! Go to next level ?", 68, "Finish")
            If player_report = 6 Then
                Init_subject(PictureBox)
            ElseIf player_report = 7 Then
                back_music.close()
                Me.Close()
                Form1.Close()


            End If
        End If

    End Sub


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim newX As Integer = PictureBox.Left ' New X position of the player
        Dim newY As Integer = PictureBox.Top ' New Y position of the player



        If e.KeyCode = Keys.A Or e.KeyCode = Keys.Left Then
            left_timer.Enabled = True
        ElseIf e.KeyCode = Keys.D Or e.KeyCode = Keys.Right Then
            right_timer.Enabled = True
        ElseIf e.KeyCode = Keys.S Or e.KeyCode = Keys.Down Then
            down_timer.Enabled = True
        ElseIf e.KeyCode = Keys.W Or e.KeyCode = Keys.Up Then
            up_timer.Enabled = True
        End If

        Timer1.Enabled = True



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timer -= 1
        Label_timer.Text = timer

        If timer = 25 Then
            dino_set = True
        End If

        If timer = 0 Then
            Dim player_report As Integer
            Timer1.Enabled = False
            left_timer.Enabled = False
            right_timer.Enabled = False
            up_timer.Enabled = False
            down_timer.Enabled = False
            player_report = MsgBox("Times up ! Do you need to restart ?", 53, "Times up")
            If player_report = 4 Then
                Init_subject(PictureBox)
            ElseIf player_report = 2 Then
                Me.Close()
                back_music.close()


            End If
        End If

    End Sub
    Private Sub Left_Tick(sender As Object, e As EventArgs) Handles left_timer.Tick
        PictureBox.Left += move_speed_left
        Detect(PictureBox.Left, PictureBox.Top, dino_set, 1)
    End Sub

    Private Sub Right_Tick(sender As Object, e As EventArgs) Handles right_timer.Tick
        PictureBox.Left += move_speed_right
        Detect(PictureBox.Left, PictureBox.Top, dino_set, 2)
    End Sub

    Private Sub Down_Tick(sender As Object, e As EventArgs) Handles down_timer.Tick
        PictureBox.Top += move_speed_down
        Detect(PictureBox.Left, PictureBox.Top, dino_set, 3)
    End Sub

    Private Sub Up_Tick(sender As Object, e As EventArgs) Handles up_timer.Tick
        PictureBox.Top += move_speed_up
        Detect(PictureBox.Left, PictureBox.Top, dino_set, 4)
    End Sub
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.A Or e.KeyCode = Keys.Left Then
            left_timer.Enabled = False
        ElseIf e.KeyCode = Keys.D Or e.KeyCode = Keys.Right Then
            right_timer.Enabled = False
        ElseIf e.KeyCode = Keys.S Or e.KeyCode = Keys.Down Then
            down_timer.Enabled = False
        ElseIf e.KeyCode = Keys.W Or e.KeyCode = Keys.Up Then
            up_timer.Enabled = False
        End If
    End Sub

    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        back_music.close()
        main.Close()
    End Sub
End Class