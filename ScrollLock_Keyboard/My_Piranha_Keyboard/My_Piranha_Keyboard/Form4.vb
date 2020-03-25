Imports System.Runtime.InteropServices
Public Class Form4
    Private Const KEYEVENTF_EXTENDEDKEY As Long = &H1
    Private Const KEYEVENTF_KEYUP As Long = &H2
    Private Const VK_LWIN As Byte = &H5B
    Private Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte, _
    ByVal bScan As Byte, ByVal dwFlags As Long, ByVal dwExtraInfo As Long)

    Private Const WH_KEYBOARD_LL As Integer = 13
    Private Const WM_KEYUP As Integer = &H101
    Private Shared _proc As LowLevelKeyboardProc = AddressOf HookCallback
    Private Shared _hookID As IntPtr = IntPtr.Zero

    Public Declare Auto Function SetWindowsHookEx Lib "user32.dll" ( _
        ByVal idHook As Integer, ByVal lpfn As LowLevelKeyboardProc, _
        ByVal hMod As IntPtr, ByVal dwThreadId As UInteger) As IntPtr

    Public Declare Auto Function UnhookWindowsHookEx _
    Lib "user32.dll" (ByVal hhk As IntPtr) As IntPtr

    Public Declare Auto Function CallNextHookEx _
    Lib "user32.dll" (ByVal hhk As IntPtr, ByVal nCode As Integer, _
                      ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Public Declare Auto Function GetModuleHandle Lib "kernel32.dll" ( _
    ByVal lpModuleName As String) As IntPtr


    Private Shared Function SetHook( _
        ByVal proc As LowLevelKeyboardProc) As IntPtr

        Dim curProcess As Process = Process.GetCurrentProcess()
        Dim curModule As ProcessModule = curProcess.MainModule

        Return SetWindowsHookEx(WH_KEYBOARD_LL, proc, _
                GetModuleHandle(curModule.ModuleName), 0)

    End Function

    Public Delegate Function LowLevelKeyboardProc( _
         ByVal nCode As Integer, ByVal wParam As IntPtr, _
         ByVal lParam As IntPtr) As IntPtr

    Public Shared Function HookCallback( _
        ByVal nCode As Integer, _
        ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

        If nCode >= 0 And wParam = CType(WM_KEYUP, IntPtr) Then
            Dim vkCode As Keys = CType(Marshal.ReadInt32(lParam), Keys)
            If vkCode = Keys.LWin Or vkCode = Keys.RWin Then
                keybd_event(CByte(Keys.Zoom), 0, KEYEVENTF_EXTENDEDKEY, 0)
            End If
        End If

        Return CallNextHookEx(_hookID, nCode, wParam, lParam)
    End Function

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.winlock = False Then
            CheckBox1.Checked = False
        End If
        If My.Settings.winlock = True Then
            CheckBox1.Checked = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            _hookID = SetHook(_proc)
            My.Settings.winlock = False
        End If

        If CheckBox1.Checked = False Then
            UnhookWindowsHookEx(_hookID)
            My.Settings.winlock = True

        End If
    End Sub
End Class