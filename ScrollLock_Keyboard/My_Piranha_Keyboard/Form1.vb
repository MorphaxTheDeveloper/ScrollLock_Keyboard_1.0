Public Class Form1
    Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Integer) As Short

    Private Declare Sub keybd_event Lib "user32" ( _
  ByVal bVk As Byte, _
  ByVal bScan As Byte, _
  ByVal dwFlags As Integer, _
  ByVal dwExtraInfo As Integer _
)

    Private Const VK_CAPITAL As Integer = 20
    Private Const VK_NUMLOCK As Integer = 144
    Private Const VK_SCROLL As Integer = 145
    Private Const KEYEVENTF_EXTENDEDKEY As Integer = &H1
    Private Const KEYEVENTF_KEYUP As Integer = &H2
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.keyshowmode = True Then
            Timer6.Start()
        Else
        End If
       
        Button4.BackColor = Color.White
        Timer1.Start()
        Timer2.Start()
        If My.Settings.senkron = True Then
            If My.Settings.openclosemode = True Then
                Timer4.Interval = (My.Settings.opclmdsc)
                Timer5.Interval = (My.Settings.opclmdsc)
                Timer4.Start()
                Timer5.Start()
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        keybd_event(VK_SCROLL, &H45, KEYEVENTF_EXTENDEDKEY Or 0, 0)
        keybd_event(VK_SCROLL, &H45, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        My.Settings.ackap = My.Computer.Keyboard.ScrollLock
        Label1.Text = My.Settings.ackap
        If My.Settings.ackap = True Then
            Button1.Text = ("Lights On")
            Label1.Text = ("İf You Want To Turn Off The Lights,Touch The Button")
            PictureBox1.Image = (My.Resources.isikli)
            Button1.BackColor = Color.Chartreuse
            Me.BackgroundImage = (My.Resources.gok)
            Form2.BackgroundImage = (My.Resources.gok)
            Form3.BackgroundImage = (My.Resources.gok)
            Form4.BackgroundImage = (My.Resources.gok)
            Button2.BackColor = Color.Chartreuse
            Button3.BackColor = Color.Chartreuse
            Button4.BackColor = Color.Chartreuse
            PictureBox1.BackgroundImage = (My.Resources.gok)
        End If
        If My.Settings.ackap = False Then
            Button1.Text = ("Lights Off")
            Label1.Text = ("İf You Want To Turn On The Lights,Touch The Button")
            PictureBox1.Image = (My.Resources.isiksiz)
            Me.BackgroundImage = (My.Resources.siy)
            Button1.BackColor = Color.Firebrick
            Button2.BackColor = Color.Firebrick
            Button3.BackColor = Color.Firebrick
            Button4.BackColor = Color.Firebrick
            Form2.BackgroundImage = (My.Resources.siy)
            Form4.BackgroundImage = (My.Resources.siy)
            Form3.BackgroundImage = (My.Resources.siy)
            PictureBox1.BackgroundImage = (My.Resources.siy)
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If My.Settings.soundboo = True Then
            If GetAsyncKeyState(Keys.Escape) Or GetAsyncKeyState(Keys.F1) Or GetAsyncKeyState(Keys.F2) Or GetAsyncKeyState(Keys.F3) Or GetAsyncKeyState(Keys.F4) Or GetAsyncKeyState(Keys.F5) Or GetAsyncKeyState(Keys.F6) Or GetAsyncKeyState(Keys.F6) Or GetAsyncKeyState(Keys.F7) Or GetAsyncKeyState(Keys.F8) Or GetAsyncKeyState(Keys.F9) Or GetAsyncKeyState(Keys.F10) Or GetAsyncKeyState(Keys.F11) Or GetAsyncKeyState(Keys.F12) Or GetAsyncKeyState(Keys.PrintScreen) Or GetAsyncKeyState(Keys.Pause) Or GetAsyncKeyState(Keys.D1) Or GetAsyncKeyState(Keys.D2) Or GetAsyncKeyState(Keys.D3) Or GetAsyncKeyState(Keys.D4) Or GetAsyncKeyState(Keys.D5) Or GetAsyncKeyState(Keys.D6) Or GetAsyncKeyState(Keys.D7) Or GetAsyncKeyState(Keys.D8) Or GetAsyncKeyState(Keys.D9) Or GetAsyncKeyState(Keys.D0) Or GetAsyncKeyState(Keys.Back) Or GetAsyncKeyState(Keys.Tab) Or GetAsyncKeyState(Keys.Q) Or GetAsyncKeyState(Keys.W) Or GetAsyncKeyState(Keys.E) Or GetAsyncKeyState(Keys.R) Or GetAsyncKeyState(Keys.T) Or GetAsyncKeyState(Keys.Y) Or GetAsyncKeyState(Keys.U) Or GetAsyncKeyState(Keys.I) Or GetAsyncKeyState(Keys.O) Or GetAsyncKeyState(Keys.P) Or GetAsyncKeyState(Keys.G) Or GetAsyncKeyState(Keys.U) Or GetAsyncKeyState(Keys.CapsLock) Or GetAsyncKeyState(Keys.A) Or GetAsyncKeyState(Keys.CapsLock) Or GetAsyncKeyState(Keys.A) Or GetAsyncKeyState(Keys.S) Or GetAsyncKeyState(Keys.D) Or GetAsyncKeyState(Keys.F) Or GetAsyncKeyState(Keys.G) Or GetAsyncKeyState(Keys.H) Or GetAsyncKeyState(Keys.J) Or GetAsyncKeyState(Keys.K) Or GetAsyncKeyState(Keys.L) Or GetAsyncKeyState(Keys.S) Or GetAsyncKeyState(Keys.I) Or GetAsyncKeyState(Keys.Enter) Or GetAsyncKeyState(Keys.Shift) Or GetAsyncKeyState(Keys.Z) Or GetAsyncKeyState(Keys.X) Or GetAsyncKeyState(Keys.C) Or GetAsyncKeyState(Keys.V) Or GetAsyncKeyState(Keys.B) Or GetAsyncKeyState(Keys.N) Or GetAsyncKeyState(Keys.M) Or GetAsyncKeyState(Keys.O) Or GetAsyncKeyState(Keys.C) Or GetAsyncKeyState(Keys.Control) Or GetAsyncKeyState(Keys.Alt) Or GetAsyncKeyState(Keys.Space) Or GetAsyncKeyState(Keys.F) Or GetAsyncKeyState(Keys.Insert) Or GetAsyncKeyState(Keys.Home) Or GetAsyncKeyState(Keys.PageUp) Or GetAsyncKeyState(Keys.Delete) Or GetAsyncKeyState(Keys.End) Or GetAsyncKeyState(Keys.PageDown) Then
                AxWindowsMediaPlayer1.URL = (My.Settings.sound1)
            Else

                If GetAsyncKeyState(Keys.Escape) Or GetAsyncKeyState(Keys.F1) Or GetAsyncKeyState(Keys.F2) Or GetAsyncKeyState(Keys.F3) Or GetAsyncKeyState(Keys.F4) Or GetAsyncKeyState(Keys.F5) Or GetAsyncKeyState(Keys.F6) Or GetAsyncKeyState(Keys.F6) Or GetAsyncKeyState(Keys.F7) Or GetAsyncKeyState(Keys.F8) Or GetAsyncKeyState(Keys.F9) Or GetAsyncKeyState(Keys.F10) Or GetAsyncKeyState(Keys.F11) Or GetAsyncKeyState(Keys.F12) Or GetAsyncKeyState(Keys.PrintScreen) Or GetAsyncKeyState(Keys.Pause) Or GetAsyncKeyState(Keys.D1) Or GetAsyncKeyState(Keys.D2) Or GetAsyncKeyState(Keys.D3) Or GetAsyncKeyState(Keys.D4) Or GetAsyncKeyState(Keys.D5) Or GetAsyncKeyState(Keys.D6) Or GetAsyncKeyState(Keys.D7) Or GetAsyncKeyState(Keys.D8) Or GetAsyncKeyState(Keys.D9) Or GetAsyncKeyState(Keys.D0) Or GetAsyncKeyState(Keys.Back) Or GetAsyncKeyState(Keys.Tab) Or GetAsyncKeyState(Keys.Q) Or GetAsyncKeyState(Keys.W) Or GetAsyncKeyState(Keys.E) Or GetAsyncKeyState(Keys.R) Or GetAsyncKeyState(Keys.T) Or GetAsyncKeyState(Keys.Y) Or GetAsyncKeyState(Keys.U) Or GetAsyncKeyState(Keys.I) Or GetAsyncKeyState(Keys.O) Or GetAsyncKeyState(Keys.P) Or GetAsyncKeyState(Keys.G) Or GetAsyncKeyState(Keys.U) Or GetAsyncKeyState(Keys.CapsLock) Or GetAsyncKeyState(Keys.A) Or GetAsyncKeyState(Keys.CapsLock) Or GetAsyncKeyState(Keys.A) Or GetAsyncKeyState(Keys.S) Or GetAsyncKeyState(Keys.D) Or GetAsyncKeyState(Keys.F) Or GetAsyncKeyState(Keys.G) Or GetAsyncKeyState(Keys.H) Or GetAsyncKeyState(Keys.J) Or GetAsyncKeyState(Keys.K) Or GetAsyncKeyState(Keys.L) Or GetAsyncKeyState(Keys.S) Or GetAsyncKeyState(Keys.I) Or GetAsyncKeyState(Keys.Enter) Or GetAsyncKeyState(Keys.Shift) Or GetAsyncKeyState(Keys.Z) Or GetAsyncKeyState(Keys.X) Or GetAsyncKeyState(Keys.C) Or GetAsyncKeyState(Keys.V) Or GetAsyncKeyState(Keys.B) Or GetAsyncKeyState(Keys.N) Or GetAsyncKeyState(Keys.M) Or GetAsyncKeyState(Keys.O) Or GetAsyncKeyState(Keys.C) Or GetAsyncKeyState(Keys.Control) Or GetAsyncKeyState(Keys.Alt) Or GetAsyncKeyState(Keys.Space) Or GetAsyncKeyState(Keys.F) Or GetAsyncKeyState(Keys.Insert) Or GetAsyncKeyState(Keys.Home) Or GetAsyncKeyState(Keys.PageUp) Or GetAsyncKeyState(Keys.Delete) Or GetAsyncKeyState(Keys.End) Or GetAsyncKeyState(Keys.PageDown) Then
                    AxWindowsMediaPlayer1.URL = (My.Settings.sound1)

                End If
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form4.Show()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        keybd_event(VK_SCROLL, &H45, KEYEVENTF_EXTENDEDKEY Or 0, 0)
        keybd_event(VK_SCROLL, &H45, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
        Timer5.Start()
        Timer4.Stop()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        keybd_event(VK_SCROLL, &H45, KEYEVENTF_EXTENDEDKEY Or 0, 0)
        keybd_event(VK_SCROLL, &H45, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
        Timer5.Stop()
        Timer4.Start()
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick

        If GetAsyncKeyState(Keys.Escape) Or GetAsyncKeyState(Keys.F1) Or GetAsyncKeyState(Keys.F2) Or GetAsyncKeyState(Keys.F3) Or GetAsyncKeyState(Keys.F4) Or GetAsyncKeyState(Keys.F5) Or GetAsyncKeyState(Keys.F6) Or GetAsyncKeyState(Keys.F6) Or GetAsyncKeyState(Keys.F7) Or GetAsyncKeyState(Keys.F8) Or GetAsyncKeyState(Keys.F9) Or GetAsyncKeyState(Keys.F10) Or GetAsyncKeyState(Keys.F11) Or GetAsyncKeyState(Keys.F12) Or GetAsyncKeyState(Keys.PrintScreen) Or GetAsyncKeyState(Keys.Pause) Or GetAsyncKeyState(Keys.D1) Or GetAsyncKeyState(Keys.D2) Or GetAsyncKeyState(Keys.D3) Or GetAsyncKeyState(Keys.D4) Or GetAsyncKeyState(Keys.D5) Or GetAsyncKeyState(Keys.D6) Or GetAsyncKeyState(Keys.D7) Or GetAsyncKeyState(Keys.D8) Or GetAsyncKeyState(Keys.D9) Or GetAsyncKeyState(Keys.D0) Or GetAsyncKeyState(Keys.Back) Or GetAsyncKeyState(Keys.Tab) Or GetAsyncKeyState(Keys.Q) Or GetAsyncKeyState(Keys.W) Or GetAsyncKeyState(Keys.E) Or GetAsyncKeyState(Keys.R) Or GetAsyncKeyState(Keys.T) Or GetAsyncKeyState(Keys.Y) Or GetAsyncKeyState(Keys.U) Or GetAsyncKeyState(Keys.I) Or GetAsyncKeyState(Keys.O) Or GetAsyncKeyState(Keys.P) Or GetAsyncKeyState(Keys.G) Or GetAsyncKeyState(Keys.U) Or GetAsyncKeyState(Keys.CapsLock) Or GetAsyncKeyState(Keys.A) Or GetAsyncKeyState(Keys.CapsLock) Or GetAsyncKeyState(Keys.A) Or GetAsyncKeyState(Keys.S) Or GetAsyncKeyState(Keys.D) Or GetAsyncKeyState(Keys.F) Or GetAsyncKeyState(Keys.G) Or GetAsyncKeyState(Keys.H) Or GetAsyncKeyState(Keys.J) Or GetAsyncKeyState(Keys.K) Or GetAsyncKeyState(Keys.L) Or GetAsyncKeyState(Keys.S) Or GetAsyncKeyState(Keys.I) Or GetAsyncKeyState(Keys.Enter) Or GetAsyncKeyState(Keys.Shift) Or GetAsyncKeyState(Keys.Z) Or GetAsyncKeyState(Keys.X) Or GetAsyncKeyState(Keys.C) Or GetAsyncKeyState(Keys.V) Or GetAsyncKeyState(Keys.B) Or GetAsyncKeyState(Keys.N) Or GetAsyncKeyState(Keys.M) Or GetAsyncKeyState(Keys.O) Or GetAsyncKeyState(Keys.C) Or GetAsyncKeyState(Keys.Control) Or GetAsyncKeyState(Keys.Alt) Or GetAsyncKeyState(Keys.Space) Or GetAsyncKeyState(Keys.F) Or GetAsyncKeyState(Keys.Insert) Or GetAsyncKeyState(Keys.Home) Or GetAsyncKeyState(Keys.PageUp) Or GetAsyncKeyState(Keys.Delete) Or GetAsyncKeyState(Keys.End) Or GetAsyncKeyState(Keys.PageDown) Then
            keybd_event(VK_SCROLL, &H45, KEYEVENTF_EXTENDEDKEY Or 0, 0)
            keybd_event(VK_SCROLL, &H45, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
            Timer7.Start()
            Timer6.Stop()
        Else
        End If

    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        keybd_event(VK_SCROLL, &H45, KEYEVENTF_EXTENDEDKEY Or 0, 0)
        keybd_event(VK_SCROLL, &H45, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
        Timer6.Start()
        Timer7.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

    End Sub
End Class
