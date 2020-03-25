Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        TextBox1.Text = My.Settings.sound1
        If My.Settings.switch = True Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If

       
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            My.Settings.switch = True
        End If
        If CheckBox1.Checked = False Then

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If My.Settings.ackap = True Then
            Me.BackgroundImage = (My.Resources.gok)
        End If
        If My.Settings.ackap = False Then
            Me.BackgroundImage = (My.Resources.siy)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.sound1 = TextBox1.Text
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        TextBox1.Text = OpenFileDialog1.FileName
    End Sub
End Class