Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        ' Check if the radio button is checked
        If RadioButton4.Checked Then
            ' Change the font of the text in TextBox1 to Garamond
            TextBox1.Font = New Font("Garamond", 12, FontStyle.Regular) ' Change the font to Garamond with size 12 and regular style
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles MagnetoRadioBtn.CheckedChanged
        ' Check if the radio button is checked
        If MagnetoRadioBtn.Checked Then
            ' Change the font of the text in TextBox1 to Magneto
            TextBox1.Font = New Font("Magneto", 12, FontStyle.Regular) ' Change the font to Magneto with size 12 and regular style
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles MagnetoRadioBtn.CheckedChanged
        ' Check if the radio button is checked
        If MagnetoRadioBtn.Checked Then
            ' Change the font of the text in TextBox1 to Tahoma
            TextBox1.Font = New Font("Tahoma", 12, FontStyle.Regular) ' Change the font to Tahoma with size 12 and regular style
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ' Check if the checkbox is checked
        If CheckBox1.Checked Then
            ' Apply italic style to the text in TextBox1
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Italic)
        Else
            ' Remove italic style if the checkbox is unchecked
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        ' Check if the checkbox is checked
        If CheckBox2.Checked Then
            ' Apply bold style to the text in TextBox1
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Bold)
        Else
            ' Remove bold style if the checkbox is unchecked
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        ' Check if the checkbox is checked
        If CheckBox3.Checked Then
            ' Apply bold italic style to the text in TextBox1
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Bold Or FontStyle.Italic)
        Else
            ' Remove bold italic style if the checkbox is unchecked
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        ' Check if the radio button is checked
        If RadioButton1.Checked Then
            ' Change the font color of the text in TextBox1 to green
            TextBox1.ForeColor = Color.Green
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        ' Check if the radio button is checked
        If RadioButton2.Checked Then
            ' Change the font color of the text in TextBox1 to blue
            TextBox1.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        ' Check if the radio button is checked
        If RadioButton3.Checked Then
            ' Change the font color of the text in TextBox1 to red
            TextBox1.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Close the current form
        Me.Close()

        ' Show the previous form (Form1)
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Create an instance of OpenFileDialog
        Dim openFileDialog As New OpenFileDialog()

        ' Set properties of the dialog
        openFileDialog.Title = "Select a Picture"
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"

        ' Show the dialog and check if the user selected a file
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Load the selected image into PictureBox1
            PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub


End Class