Imports System.ComponentModel

Public Class finish_screen
    Private Sub finish_screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Dispose()
        Form2.Dispose()
        Form3.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        main.Show()
        Hide()

    End Sub

    Private Sub finish_screen_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        main.Close()

    End Sub
End Class