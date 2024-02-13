Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Load and display form "Object Demonstrations"
        Dim objDemoForm As New Form2()
        objDemoForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Terminate the application
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Assign appropriate tooltips to the buttons
        ToolTip1.SetToolTip(Button1, "Load Object Demo")
        ToolTip1.SetToolTip(Button2, "Exit")
    End Sub
End Class
