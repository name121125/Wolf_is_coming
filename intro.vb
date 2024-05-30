Public Class intro
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub intro_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        main.Show()
    End Sub
End Class