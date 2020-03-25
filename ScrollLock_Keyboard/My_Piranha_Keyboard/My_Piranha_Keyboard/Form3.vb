Public Class Form3

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            My.Settings.keyshowmode = True
            My.Settings.openclosemode = False

        Else
            My.Settings.keyshowmode = False
            My.Settings.openclosemode = True

        End If


        If My.Settings.openclosemode = True Then
          
        Else
           
        End If





    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.keyshowmode = True Then
            CheckBox3.Checked = True
        Else
            CheckBox3.Checked = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Restart Your Application!", vbInformation, "OK!")
    End Sub
End Class