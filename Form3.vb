Imports System.ComponentModel


Public Class Form3
    Dim move_speed_up As Integer = -10
    Dim move_speed_down As Integer = 10
    Dim move_speed_left As Integer = -10
    Dim move_speed_right As Integer = 10
    Dim walls(65) As Label
    Dim timer As Integer = 33
    Dim dino_can_move As Boolean = False
    Dim sub_pos As New Point
    Dim dino_pos As New Point
    Dim sub_can_move As Boolean = False


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For add_pic As Integer = 0 To 64
            walls(add_pic) = CType(Me.Controls("Label" & (add_pic + 1)), Label)
        Next
        PictureBox0.BringToFront()
        Init_subject(PictureBox0, PictureBox1)



    End Sub
    Sub Init_subject(player As PictureBox, dino As PictureBox)

        player.Location = New Point(427, 85)
        dino.Location = New Point(493, 44)
        timer = 33
        player.BringToFront()
        dino.BringToFront()

        Label_timer.Text = 30

        Timer1.Enabled = True
        dino_move_timer.Enabled = False


    End Sub
    Sub dino_move()
        sub_pos.X = PictureBox0.Left
        sub_pos.Y = PictureBox0.Top
        dino_pos.X = PictureBox1.Left
        dino_pos.Y = PictureBox1.Top
        If dino_pos.X > sub_pos.X + PictureBox0.Width Then
            PictureBox1.Left += move_speed_left - 8
        ElseIf dino_pos.X + PictureBox1.Width < sub_pos.X Then
            PictureBox1.Left += move_speed_right - 8
        End If
        If sub_pos.Y > dino_pos.Y + PictureBox1.Height Then
            PictureBox1.Top += move_speed_down - 8
        ElseIf sub_pos.Y + PictureBox0.Height < dino_pos.Y Then
            PictureBox1.Top += move_speed_up - 8
        End If





    End Sub

    Sub Detect(newX As Integer, newY As Integer, dino_detect As Boolean, timer As Integer)
        Dim playerBounds As New Rectangle(newX, newY, PictureBox0.Width, PictureBox0.Height)
        For wall As Integer = 0 To 64
            If playerBounds.IntersectsWith(walls(wall).Bounds) Then
                ' Player hits a wall, don't move
                Select Case timer
                    Case 1 ' Moving left
                        PictureBox0.Left -= move_speed_left
                        left_timer.Enabled = False
                    Case 2 ' Moving right
                        PictureBox0.Left -= move_speed_right
                        right_timer.Enabled = False
                    Case 3 ' Moving down
                        PictureBox0.Top -= move_speed_down
                        down_timer.Enabled = False
                    Case 4 ' Moving up
                        PictureBox0.Top -= move_speed_up
                        up_timer.Enabled = False
                End Select
                Return
            End If
        Next


        ' Move the player to the new position
        PictureBox0.Location = New Point(newX, newY)

        If dino_detect = True Then

            If playerBounds.IntersectsWith(PictureBox1.Bounds) Then
                Dim player_report As Integer
                Timer1.Enabled = False
                left_timer.Enabled = False
                right_timer.Enabled = False
                up_timer.Enabled = False
                down_timer.Enabled = False
                dino_move_timer.Enabled = False
                sub_can_move = False
                player_report = MsgBox("You hit the dino ! Do you need to restart ?", 53, "Times up")
                If player_report = 4 Then
                    Init_subject(PictureBox0, PictureBox1)

                ElseIf player_report = 2 Then
                    Me.Close()
                End If
            End If
        End If

        If playerBounds.IntersectsWith(Label66.Bounds) Then
            Dim player_report As Integer
            Timer1.Enabled = False
            left_timer.Enabled = False
            right_timer.Enabled = False
            up_timer.Enabled = False
            down_timer.Enabled = False
            dino_move_timer.Enabled = False
            sub_can_move = False

            player_report = MsgBox("you finish ! ", 68, "Finish")
            If player_report = 6 Then
                finish_screen.Show()
                Hide()
                Init_subject(PictureBox0, PictureBox1)

            ElseIf player_report = 7 Then
                main.Show()
                Hide()
            End If
        End If

    End Sub


    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Dim newX As Integer = PictureBox0.Left ' New X position of the player
        Dim newY As Integer = PictureBox0.Top ' New Y position of the player

        If sub_can_move = True Then
            If e.KeyCode = Keys.A Or e.KeyCode = Keys.Left Then
                left_timer.Enabled = True
            ElseIf e.KeyCode = Keys.D Or e.KeyCode = Keys.Right Then
                right_timer.Enabled = True
            ElseIf e.KeyCode = Keys.S Or e.KeyCode = Keys.Down Then
                down_timer.Enabled = True
            ElseIf e.KeyCode = Keys.W Or e.KeyCode = Keys.Up Then
                up_timer.Enabled = True
            End If
        End If





    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        If timer >= 30 Then
            see_maze_time.Visible = True
            see_maze_value.Visible = True
            see_maze_time.ForeColor = Color.Black
            see_maze_value.ForeColor = Color.Black
            see_maze_time.Text = "觀察時間："
            see_maze_value.Text = timer - 30

        End If

        timer -= 1

        If timer < 30 And timer >= 27 Then
            Label_timer.Text = timer

            sub_can_move = True
            see_maze_value.Text = 3
            see_maze_time.Text = "龍來了！"
            see_maze_time.ForeColor = Color.Red
            see_maze_value.ForeColor = Color.Red
            see_maze_value.Text = timer - 26
        End If




        If timer < 27 Then
            Label_timer.Text = timer
            dino_can_move = True
            dino_move_timer.Enabled = True
            see_maze_time.Visible = False
            see_maze_value.Visible = False

            see_maze_value.ForeColor = Color.Black
            see_maze_time.ForeColor = Color.Black
        End If

        If timer = 0 Then
            Dim player_report As Integer
            Timer1.Enabled = False
            left_timer.Enabled = False
            right_timer.Enabled = False
            up_timer.Enabled = False
            down_timer.Enabled = False
            dino_can_move = False
            sub_can_move = False
            dino_move_timer.Enabled = False
            player_report = MsgBox("Times up ! Do you need to restart ?", 53, "Times up")
            If player_report = 4 Then
                Init_subject(PictureBox0, PictureBox1)
                timer = 35
            ElseIf player_report = 2 Then
                Me.Close()



            End If
        End If

    End Sub

    Private Sub Left_Tick(sender As Object, e As EventArgs) Handles left_timer.Tick
        PictureBox0.Left += move_speed_left
        Detect(PictureBox0.Left, PictureBox0.Top, dino_can_move, 1)
    End Sub

    Private Sub Right_Tick(sender As Object, e As EventArgs) Handles right_timer.Tick
        PictureBox0.Left += move_speed_right
        Detect(PictureBox0.Left, PictureBox0.Top, dino_can_move, 2)
    End Sub

    Private Sub Down_Tick(sender As Object, e As EventArgs) Handles down_timer.Tick
        PictureBox0.Top += move_speed_down
        Detect(PictureBox0.Left, PictureBox0.Top, dino_can_move, 3)
    End Sub

    Private Sub Up_Tick(sender As Object, e As EventArgs) Handles up_timer.Tick
        PictureBox0.Top += move_speed_up
        Detect(PictureBox0.Left, PictureBox0.Top, dino_can_move, 4)
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

    Private Sub Form3_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        back_music.close()
        main.Close()
    End Sub

    Private Sub dino_move_timer_Tick(sender As Object, e As EventArgs) Handles dino_move_timer.Tick
        dino_move()
    End Sub



End Class

