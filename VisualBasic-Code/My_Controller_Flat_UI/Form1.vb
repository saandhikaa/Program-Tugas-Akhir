Imports System
Imports System.IO.Ports

Public Class Form
    Dim Port As String = " "                                'nama port
    Dim ConnectedString As String
    Dim DataString As String                                'tampilan text pada tombol data1 - data10               
    Dim Data0, Action0 As String                            'data sementara untuk pertukan data
    Dim DataIn(4) As String                                 'data servo 1, 2, 3, 4

    Dim increase As Integer = 1                             'untuk mendapatkan DataIn servo 1, 2, 3, 4 (timer1)
    Dim NewLine As Integer = 1                              'data saat ini
    Dim LastData As Integer = 1                             'jumlah data + 1
    Dim TotalData As Integer = 0                            'total data angular
    Dim PositionD As Integer = 0                            'posisi data yg akan di palletizing 1 - 10
    Dim StackD As Integer = 0                               'jumlah tumpukan 1 - 5

    Dim Logging As Boolean = False
    Dim SlideUI As Integer = 0

    Dim SendCount As Integer
    Dim SendAngles(75) As String
    Dim AngleSaved(10, 4) As Double

    Dim ReadDataAxisS As Integer = 125
    Dim DataConfigS As Integer = 100
    Dim DataNumArduinoS As Integer = 150
    Dim DataArrangeS As Integer = 200

    Dim Arm1 As Integer = 135                               'panjang lengan 1
    Dim Arm2 As Integer = 147                               'panjang lengan 2
    Dim Arm3 As Integer = 67                                'panjang lengan 3 (distance to end effector)
    Dim Arm4 As Integer = 36                                'tinggi end effector
    Dim BaseH As Integer = 99                               'jarak lantai ke titik alpha

    Dim alpha, beta, gamma, gripper As Double             'sudut motor axis 1, 2, 3, 4
    Dim Xposition, Yposition, Zposition As Double         'koordinat x, y, z
    'Dim L1, L2 As Double                                    'garis bantu 

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ScreenLayout("Home")

        InputNotif.Visible = False

        Timer1.Enabled = False

        For stack As Integer = 1 To 4                       'fill stack combo box
            PlayControlStack.Items.Add(stack)
        Next

        Reload()

        InputGripperAngel.Items.Add("Default")
        InputGripperAngel.Items.Add("Facing X")
        InputGripperAngel.Items.Add("Facing Y")
        InputGripperAngel.Items.Add("Custom")

        InputGripperAngel.SelectedIndex = 0

    End Sub

    Private Sub SideBack_Click(sender As Object, e As EventArgs) Handles SideBack.Click
        If SideConnect.Text = "Disconnect" Then
            ScreenLayout("Main")
        End If
    End Sub

    Private Sub SideExit_Click(sender As Object, e As EventArgs) Handles SideExit.Click
        Me.Close()
    End Sub

    Private Sub ConnectPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ConnectPort.SelectedIndexChanged
        If ConnectPort.SelectedItem <> " " Then
            Port = ConnectPort.SelectedItem
            NotifPort.Visible = False

            If SideConnect.Text = "Disconnect" Then
                SideConnect.Text = "Connect"
                If SideBack.Visible = True Then
                    SideBack.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub SideRefresh_Click(sender As Object, e As EventArgs) Handles SideRefresh.Click
        Reload()

        If SideConnect.Text = "Disconnect" Then
            SideConnect.Text = "Connect"
            If SideBack.Visible = True Then
                SideBack.Visible = False
            End If
        End If
    End Sub

    Public Sub Reload()                                          'Re-scan my serial port on PC
        ConnectPort.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ConnectPort.Items.Add(sp)
        Next
    End Sub

    Private Sub SideConnect_Click(sender As Object, e As EventArgs) Handles SideConnect.Click
        If PlaySend.Text = "Play" Then
            PlaySend.Text = "Send to Arduino"
        End If

        If SideConnect.Text = "Connect" Then        'connecting to arduino_____________________________
            If Port <> " " Then
                MyPort.Close()
                MyPort.PortName = Port
                MyPort.BaudRate = 9600
                MyPort.DataBits = 8
                MyPort.StopBits = StopBits.One
                MyPort.Parity = Parity.None
                MyPort.Encoding = System.Text.Encoding.Default
                MyPort.Handshake = Handshake.None
                MyPort.ReadTimeout = 10000

                MyPort.Open()
                MyPort.WriteLine("1")                   'send info: connected
                MyPort.Close()

                SideConnect.Font = New Font(SideConnect.Font.FontFamily, 12.5, FontStyle.Bold)
                ScreenLayout("Main")

            Else
                NotifPort.Text = "Select Port first, please..."
                NotifPort.Visible = True
            End If

        ElseIf SideConnect.Text = ConnectedString Then      'back to home screen_______________________
            SideConnect.Text = "Disconnect"
            SideConnect.Font = New Font(SideConnect.Font.FontFamily, 12, FontStyle.Regular)
            If SideRecord.BaseColor = Color.White Then
                MyPort.Open()
                MyPort.WriteLine("4")  '''' get out from recording() loop arduino
                MyPort.Close()
            End If
            ScreenLayout("Home")

        ElseIf SideConnect.Text = "Disconnect" Then     'Disconnecting________________________________
            MyPort.Close()
            SideConnect.Text = "Connect"
            Port = " "
            Reload()
            SideBack.Visible = False

        End If

    End Sub

    Private Sub SideRecord_Click(sender As Object, e As EventArgs) Handles SideRecord.Click
        If SideRecord.BaseColor = Color.DodgerBlue Then
            ScreenLayout("Record")
            ShowDataBorder()

            MyPort.Open()
            MyPort.WriteLine("2")
            MyPort.Close()

        End If
    End Sub

    Private Sub SideInput_Click(sender As Object, e As EventArgs) Handles SideInput.Click
        If SideInput.BaseColor = Color.DodgerBlue Then
            If SideRecord.BaseColor = Color.White Then
                MyPort.Open()
                MyPort.WriteLine("2")          'kirim data 8 untuk keluar dari record loop / tetap berada di main loop
                MyPort.Close()
            End If

            ScreenLayout("Input")
            ShowDataBorder()

            InputX.Clear()
            InputY.Clear()
            InputZ.Clear()
            InputGripper.Clear()

            InputX.Select()
        End If
    End Sub

    Private Sub SidePlay_Click(sender As Object, e As EventArgs) Handles SidePlay.Click
        If SidePlay.BaseColor = Color.DodgerBlue Then
            If SideRecord.BaseColor = Color.White Then
                MyPort.Open()
                MyPort.WriteLine("3")          'kirim data 8 untuk keluar dari record loop / tetap berada di main loop
                MyPort.Close()
            End If

            ScreenLayout("Play")

            PlayControlPosition.Items.Clear()
            For stack As Integer = 1 To LastData - 1
                PlayControlPosition.Items.Add(stack)
            Next

            If PlayControlArrange.ImageAlign = HorizontalAlignment.Right Then
                PlayControlPosition.SelectedIndex = LastData - 2
            End If

        End If

    End Sub

    Private Sub DataLogButton_Click(sender As Object, e As EventArgs) Handles DataLogButton.Click
        If DataLogButton.BorderColor = Color.DarkGray Then
            DataLogButton.BorderColor = Color.DodgerBlue
            DataLogButton.OnHoverBorderColor = Color.DarkGray

            Logging = True
            Me.Size = New Size(SidePanel.Width * 2 + 45, 623)
        Else
            DataLogButton.BorderColor = Color.DarkGray
            DataLogButton.OnHoverBorderColor = Color.DodgerBlue

            Logging = False
            Me.Size = New Size(SidePanel.Width + 30, 623)
        End If
    End Sub

    Private Sub BoxLength_TextChanged(sender As Object, e As EventArgs) Handles BoxLength.TextChanged
        If PlaySend.Text = "Play" Then
            PlaySend.Text = "Send to Arduino"
        End If
    End Sub

    Private Sub BoxWidth_TextChanged(sender As Object, e As EventArgs) Handles BoxWidth.TextChanged
        If PlaySend.Text = "Play" Then
            PlaySend.Text = "Send to Arduino"
        End If
    End Sub

    Private Sub BoxHeight_TextChanged(sender As Object, e As EventArgs) Handles BoxHeight.TextChanged
        If PlaySend.Text = "Play" Then
            PlaySend.Text = "Send to Arduino"
        End If
    End Sub

    Private Sub SideAbout_Click(sender As Object, e As EventArgs) Handles SideAbout.Click
        ScreenLayout("About")

    End Sub

    Private Sub RecordGetData_Click(sender As Object, e As EventArgs) Handles RecordGetData.Click
        If Timer1.Enabled = False Then
            If PlaySend.Text = "Play" Then
                PlaySend.Text = "Send to Arduino"
            End If

            RecordGetData.Visible = False

            MyPort.Open()
            MyPort.WriteLine("1")
            MyPort.Close()

            increase = 1
            Timer1.Interval = ReadDataAxisS
            Timer1.Enabled = True
        End If
    End Sub

    Function GettingData() As String                             'Function to receive data from Arduino
        Try
            Dim incoming As String = MyPort.ReadLine

            If incoming Is Nothing Then
                Return "Notrhing" & vbCrLf
            Else
                Return incoming
            End If

        Catch ex As Exception
            Return "Error"
        End Try
    End Function

    Private Sub InputX_KeyPress(sender As Object, e As KeyPressEventArgs) Handles InputX.KeyPress
        If e.KeyChar = Chr(13) Then
            InputConvert_Click(Me, EventArgs.Empty)
        End If

        If e.KeyChar = "-" Then
            InputX.Clear()
        End If

        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "-" Then
            e.Handled = True
        End If
    End Sub

    Private Sub InputY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles InputY.KeyPress
        If e.KeyChar = Chr(13) Then
            InputConvert_Click(Me, EventArgs.Empty)
        End If

        If e.KeyChar = "-" Then
            InputY.Clear()
        End If

        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "-" Then
            e.Handled = True
        End If
    End Sub

    Private Sub InputZ_KeyPress(sender As Object, e As KeyPressEventArgs) Handles InputZ.KeyPress
        If e.KeyChar = Chr(13) Then
            InputConvert_Click(Me, EventArgs.Empty)
        End If

        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub InputGripper_KeyPress(sender As Object, e As KeyPressEventArgs) Handles InputGripper.KeyPress
        If e.KeyChar = Chr(13) Then
            InputConvert_Click(Me, EventArgs.Empty)
        End If

        If e.KeyChar = "-" Then
            InputGripper.Clear()
        End If

        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "-" Then
            e.Handled = True
        End If
    End Sub

    Private Sub InputGripperAngel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InputGripperAngel.SelectedIndexChanged
        If InputGripperAngel.SelectedItem = "Custom" Then
            InputGripper.Visible = True
            InputGripperClear.Visible = True
            InputGripperAngel.Visible = False
            InputGripper.Focus()
        End If
    End Sub

    Private Sub InputGripperAngel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles InputGripperAngel.KeyPress
        If e.KeyChar = Chr(13) Then
            InputConvert_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub InputGripperClear_Click(sender As Object, e As EventArgs) Handles InputGripperClear.Click
        InputGripper.Clear()
        InputGripper.Visible = False
        InputGripperClear.Visible = False
        InputGripperAngel.Visible = True
        InputGripperAngel.SelectedIndex = 0
    End Sub

    Private Sub InputConvert_Click(sender As Object, e As EventArgs) Handles InputConvert.Click
        If PlaySend.Text = "Play" Then
            PlaySend.Text = "Send to Arduino"
        End If

        If InputX.Text <> "" And InputY.Text <> "" And InputZ.Text <> "" Then
            Xposition = Convert.ToDouble(InputX.Text)
            Yposition = Convert.ToDouble(InputY.Text)
            Zposition = Convert.ToDouble(InputZ.Text)

            GetInverse(Xposition, Yposition, Zposition) 'input text

            Dim grips As String = ""

            Select Case InputGripperAngel.SelectedItem
                Case "Default"
                    gripper = 0
                    grips = "Default"
                Case "Facing X"
                    GetGripperAngle(90)
                    grips = "Facing X"
                Case "Facing Y"
                    GetGripperAngle(0)
                    grips = "Facing Y"
                Case "Custom"
                    GetGripperAngle(Convert.ToInt32(InputGripper.Text))
                    grips = InputGripper.Text
            End Select

            If Math.Abs(alpha - beta) > 37 And 30 <= alpha <= 140 And 105 <= beta <= 180 Then
                DataIn(1) = Math.Round(gamma, 0)
                DataIn(2) = Math.Round(alpha, 0)
                DataIn(3) = Math.Round(beta, 0)
                DataIn(4) = Math.Round(gripper, 0)

                DataShow()

                InputX.Clear()
                InputY.Clear()
                InputZ.Clear()
                InputGripper.Clear()

                DataLogging.Text += Environment.NewLine & "Position : " & Xposition & ", " & Yposition & ", " & Zposition
                DataLogging.Text += "  |  " & grips & Environment.NewLine
                DataLogging.Text += "Joint    : " & DataIn(1) & ", " & DataIn(2) & ", " & DataIn(3) & Environment.NewLine

                DataLogging.SelectionStart = DataLogging.Text.Length
                DataLogging.ScrollToCaret()

                InputNotif.Visible = False
                InputGripper.Visible = False
                InputGripperClear.Visible = False
                InputGripperAngel.Visible = True
                InputGripperAngel.SelectedIndex = 0

                InputX.Select()
            Else
                'DataLogging.Text += Environment.NewLine & gamma & " | " & alpha & " | " & beta & Environment.NewLine
                InputNotif.Text = "*Robot can't reach this position"
                InputNotif.Visible = True
            End If

        Else
            InputNotif.Text = "*Fill the empty form please.."
            InputNotif.Visible = True
        End If

    End Sub

    Private Sub PlayConfiguration_Click(sender As Object, e As EventArgs) Handles PlayConfiguration.Click
        If PlayPanel.Height = 215 Then
            SlideUI = 11
            ScreenLayout("Play")
            PlayConfiguration.Image = My_Controller_Flat_UI.My.Resources.UpX
            PlayConfiguration.OnHoverImage = My_Controller_Flat_UI.My.Resources.UpX

        ElseIf PlayPanel.Height = 90 Then
            SlideUI = 10
            ScreenLayout("Play")
            PlayConfiguration.Image = My_Controller_Flat_UI.My.Resources.DownX
            PlayConfiguration.OnHoverImage = My_Controller_Flat_UI.My.Resources.DownX

        End If
    End Sub

    Private Sub BoxLength_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BoxLength.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BoxWidth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BoxWidth.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BoxHeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BoxHeight.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub PlayControlArrange_Click(sender As Object, e As EventArgs) Handles PlayControlArrange.Click

        If PlaySend.Text = "Play" Then
            PlaySend.Text = "Send to Arduino"
        End If

        If PlayControlArrange.ImageAlign = HorizontalAlignment.Left Then            'while off to on
            PlayControlArrange.ImageAlign = HorizontalAlignment.Right
            PlayControlArrange.BaseColor = Color.DodgerBlue
            PlayControlArrange.BorderColor = Color.DodgerBlue
            PlayControlArrange.OnHoverBaseColor = Color.DodgerBlue
            PlayControlPosition.Enabled = True
            PlayControlStack.Enabled = True
            PlayControlPosition.SelectedIndex = LastData - 2
            PlayControlStack.SelectedIndex = 2

        ElseIf PlayControlArrange.ImageAlign = HorizontalAlignment.Right Then       'while on to off
            PlayControlArrange.ImageAlign = HorizontalAlignment.Left
            PlayControlArrange.BaseColor = Color.Gainsboro
            PlayControlArrange.BorderColor = Color.DarkGray
            PlayControlArrange.OnHoverBaseColor = Color.Gainsboro
            PlayControlPosition.Enabled = False
            PlayControlStack.Enabled = False
            PlayControlPosition.SelectedIndex = -1
            PlayControlStack.SelectedIndex = -1

        End If
    End Sub

    Private Sub PlayControlPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PlayControlPosition.SelectedIndexChanged
        If PlaySend.Text = "Play" Then
            PlaySend.Text = "Send to Arduino"
        End If
    End Sub

    Private Sub PlayControlStack_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PlayControlStack.SelectedIndexChanged
        If PlaySend.Text = "Play" Then
            PlaySend.Text = "Send to Arduino"
        End If
    End Sub

    Private Sub PlaySend_Click(sender As Object, e As EventArgs) Handles PlaySend.Click
        If PlaySend.Text = "Send to Arduino" Then

            PlaySend.Visible = False
            PlaySend.Text = "Play"
            PlayLoading.Visible = True
            'DataLogging.Clear()
            DataLogging.Text += Environment.NewLine & Environment.NewLine & "========================================" & Environment.NewLine

            If PlayControlArrange.ImageAlign = HorizontalAlignment.Right Then
                ArrangeLayout()
            End If

            MyPort.Open()
            MyPort.WriteLine("3")                       'send command to send total data
            MyPort.Close()

            Timer1.Interval = DataConfigS
            Timer1.Enabled = True
            HideDataBorder()

        ElseIf PlaySend.Text = "Play" Then
            MyPort.Open()
            MyPort.WriteLine("4")
            MyPort.Close()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case Timer1.Interval

            Case ReadDataAxisS
                MyPort.Open()
                MyPort.WriteLine(increase)
                DataIn(increase) = GettingData()
                increase += 1

                If increase >= 5 Then
                    increase = 1
                    Timer1.Enabled = False
                    DataShow()
                    RecordGetData.Visible = True
                End If

            Case DataConfigS
                Dim ArrangeSwitch As Integer
                TotalData = LastData - 1

                If PlayControlArrange.ImageAlign = HorizontalAlignment.Left Then
                    ArrangeSwitch = 0
                    PositionD = 0
                    StackD = 0
                Else
                    ArrangeSwitch = 1
                End If

                DataString = TotalData & ", " & BoxLength.Text & ", " & BoxWidth.Text & ", " & BoxHeight.Text & ", " & ArrangeSwitch & ", " & PositionD & ", " & StackD & ", M"
                MyPort.Open()
                MyPort.WriteLine(DataString)

                DataLogging.Text += Environment.NewLine & "Data Configuration______________________" & Environment.NewLine & Environment.NewLine
                DataLogging.Text += " " & DataString & Environment.NewLine & Environment.NewLine
                DataLogging.Text += " Total Data : " & TotalData & Environment.NewLine
                DataLogging.Text += " Box Length : " & BoxLength.Text & Environment.NewLine
                DataLogging.Text += " Box Width  : " & BoxWidth.Text & Environment.NewLine
                DataLogging.Text += " Box Height : " & BoxHeight.Text & Environment.NewLine
                DataLogging.Text += " Arranged   : " & ArrangeSwitch & Environment.NewLine
                DataLogging.Text += " Position   : " & PositionD & Environment.NewLine
                DataLogging.Text += " Stack      : " & StackD & Environment.NewLine & Environment.NewLine
                DataLogging.Text += Environment.NewLine & Environment.NewLine & "Angular Data____________________________" & Environment.NewLine & Environment.NewLine

                DataLogging.SelectionStart = DataLogging.Text.Length
                DataLogging.ScrollToCaret()

                increase = 1
                Timer1.Interval = DataNumArduinoS

            Case DataNumArduinoS
                MyPort.Open()

                If increase < LastData Then
                    Select Case increase
                        Case 1
                            If Action1.Text = "-" Then
                                DataString = Data1.Text + ", 0" + ", M"
                            ElseIf Action1.Text = "Hold" Then
                                DataString = Data1.Text + ", 1" + ", M"
                            ElseIf Action1.Text = "Release" Then
                                DataString = Data1.Text + ", 2" + ", M"
                            End If

                        Case 2
                            If Action2.Text = "-" Then
                                DataString = Data2.Text + ", 0" + ", M"
                            ElseIf Action2.Text = "Hold" Then
                                DataString = Data2.Text + ", 1" + ", M"
                            ElseIf Action2.Text = "Release" Then
                                DataString = Data2.Text + ", 2" + ", M"
                            End If

                        Case 3
                            If Action3.Text = "-" Then
                                DataString = Data3.Text + ", 0" + ", M"
                            ElseIf Action3.Text = "Hold" Then
                                DataString = Data3.Text + ", 1" + ", M"
                            ElseIf Action3.Text = "Release" Then
                                DataString = Data3.Text + ", 2" + ", M"
                            End If

                        Case 4
                            If Action4.Text = "-" Then
                                DataString = Data4.Text + ", 0" + ", M"
                            ElseIf Action4.Text = "Hold" Then
                                DataString = Data4.Text + ", 1" + ", M"
                            ElseIf Action4.Text = "Release" Then
                                DataString = Data4.Text + ", 2" + ", M"
                            End If

                        Case 5
                            If Action5.Text = "-" Then
                                DataString = Data5.Text + ", 0" + ", M"
                            ElseIf Action5.Text = "Hold" Then
                                DataString = Data5.Text + ", 1" + ", M"
                            ElseIf Action5.Text = "Release" Then
                                DataString = Data5.Text + ", 2" + ", M"
                            End If

                        Case 6
                            If Action6.Text = "-" Then
                                DataString = Data6.Text + ", 0" + ", M"
                            ElseIf Action6.Text = "Hold" Then
                                DataString = Data6.Text + ", 1" + ", M"
                            ElseIf Action6.Text = "Release" Then
                                DataString = Data6.Text + ", 2" + ", M"
                            End If

                        Case 7
                            If Action7.Text = "-" Then
                                DataString = Data7.Text + ", 0" + ", M"
                            ElseIf Action7.Text = "Hold" Then
                                DataString = Data7.Text + ", 1" + ", M"
                            ElseIf Action7.Text = "Release" Then
                                DataString = Data7.Text + ", 2" + ", M"
                            End If

                        Case 8
                            If Action8.Text = "-" Then
                                DataString = Data8.Text + ", 0" + ", M"
                            ElseIf Action8.Text = "Hold" Then
                                DataString = Data8.Text + ", 1" + ", M"
                            ElseIf Action8.Text = "Release" Then
                                DataString = Data8.Text + ", 2" + ", M"
                            End If

                        Case 9
                            If Action9.Text = "-" Then
                                DataString = Data9.Text + ", 0" + ", M"
                            ElseIf Action9.Text = "Hold" Then
                                DataString = Data9.Text + ", 1" + ", M"
                            ElseIf Action9.Text = "Release" Then
                                DataString = Data9.Text + ", 2" + ", M"
                            End If

                        Case 10
                            If Action10.Text = "-" Then
                                DataString = Data10.Text + ", 0" + ", M"
                            ElseIf Action10.Text = "Hold" Then
                                DataString = Data10.Text + ", 1" + ", M"
                            ElseIf Action10.Text = "Release" Then
                                DataString = Data10.Text + ", 2" + ", M"
                            End If
                    End Select

                    If increase < 10 Then
                        DataLogging.Text += " "
                    End If

                    DataLogging.Text += "  " & increase & ". "
                    DataLogging.Text += DataString & Environment.NewLine

                    DataLogging.SelectionStart = DataLogging.Text.Length
                    DataLogging.ScrollToCaret()

                    increase += 1

                    MyPort.WriteLine(DataString)

                Else 'ketika semua data angular telah terkirim
                    If PlayControlArrange.ImageAlign = HorizontalAlignment.Right Then
                        increase = 0
                        Timer1.Interval = DataArrangeS
                        DataLogging.Text += Environment.NewLine & Environment.NewLine & Environment.NewLine & "Palletize Angular Data__________________" & Environment.NewLine & Environment.NewLine

                    Else
                        Timer1.Enabled = False
                        PlayLoading.Visible = False
                        PlaySend.Visible = True

                        DataLogging.Text += Environment.NewLine & Environment.NewLine & "========================================" & Environment.NewLine
                    End If

                    DataLogging.SelectionStart = DataLogging.Text.Length
                    DataLogging.ScrollToCaret()

                End If

            Case DataArrangeS
                MyPort.Open()

                If increase < SendCount Then
                    MyPort.WriteLine(SendAngles(increase))
                    increase += 1

                    If increase Mod 3 = 1 Then
                        DataLogging.Text += Environment.NewLine & " "
                        DataLogging.Text += Math.Floor(increase / 15) & "." & Math.Floor((increase Mod 15) / 3)
                    Else
                        DataLogging.Text += "    "
                    End If

                    DataLogging.Text += "  " & SendAngles(increase - 1) & Environment.NewLine

                    If increase Mod 15 = 0 Then
                        DataLogging.Text += Environment.NewLine & Environment.NewLine
                    End If

                    DataLogging.SelectionStart = DataLogging.Text.Length
                    DataLogging.ScrollToCaret()

                Else
                    Timer1.Enabled = False
                    PlayLoading.Visible = False
                    PlaySend.Visible = True
                End If

        End Select
        MyPort.Close()
    End Sub

    Private Sub GetGripperAngle(ByVal angle As Integer)                'calculation for gripper angle refers to gamma angle

        angle = angle Mod 360

        If angle > 180 Then
            angle -= 360
        End If

        gripper = angle - gamma

        If gripper > 180 Then
            gripper -= 180
        ElseIf gripper < -180 Then
            gripper += 180
        End If

        If gripper > 90 Then
            gripper -= 180
        ElseIf gripper < -90 Then
            gripper += 180
        End If
    End Sub

    Public Sub GetInverse(ByVal LocX As Integer, ByVal LocY As Integer, ByVal LocZ As Integer)
        Dim alpha1, alpha2, beta1, beta2, L1, L2, C As Double

        LocZ += Arm4 - BaseH

        L1 = Math.Sqrt(LocX ^ 2 + LocY ^ 2) - Arm3
        L2 = Math.Sqrt(L1 ^ 2 + LocZ ^ 2)

        alpha1 = ATAN(LocZ / L1)
        alpha2 = ACOS((Arm1 ^ 2 + L2 ^ 2 - Arm2 ^ 2) / (2 * Arm1 * L2))
        alpha = alpha1 + alpha2

        beta1 = alpha
        beta2 = ACOS((Arm1 ^ 2 + Arm2 ^ 2 - L2 ^ 2) / (2 * Arm1 * Arm2))
        beta = beta1 + beta2

        C = 180 * Math.Round((LocY - Math.Abs(LocY)) / (2 * LocY + 0.001)) * Math.Round(-Math.Abs(LocX) / (LocX + 0.001))
        gamma = -ATAN(LocX / (LocY + 0.001)) + C

    End Sub

    Public Sub GetForward()
        Dim alpha1, alpha2, L2, C1, C2 As Double

        L2 = Math.Sqrt((Arm1 ^ 2) + (Arm2 ^ 2) - (2 * Arm1 * Arm2 * COS(beta - alpha)))

        alpha2 = ACOS((Arm1 ^ 2 + L2 ^ 2 - Arm2 ^ 2) / (2 * Arm1 * L2))
        alpha1 = alpha - alpha2

        If gamma > 180 And gamma < -180 Then
            gamma = (360 - Math.Abs(gamma)) * (-Math.Abs(gamma) / gamma)
        End If

        C1 = SIN(90 - Math.Abs(alpha1)) * L2 + Arm3
        C2 = (1 - Math.Abs(Math.Ceiling(Math.Abs(gamma) / 90) * Math.Floor(Math.Abs(gamma) / 90))) * C1

        Xposition = -SIN(gamma) * C1
        Yposition = SIN(Math.Abs(Math.Abs(gamma) - 90)) * C2
        Zposition = SIN(alpha1) * L2 - Arm4 + BaseH

    End Sub

    Public Sub ArrangeLayout()
        PositionD = Convert.ToInt32(PlayControlPosition.SelectedItem)
        StackD = Convert.ToInt32(PlayControlStack.SelectedItem)

        gamma = AngleSaved(PositionD, 1)
        alpha = AngleSaved(PositionD, 2)
        beta = AngleSaved(PositionD, 3)
        gripper = AngleSaved(PositionD, 4)

        DataLogging.Text += Environment.NewLine & "Selected Position: " & PositionD & ": "
        DataLogging.Text += Math.Round(gamma, 0) & " " & Math.Round(alpha, 0) & " " & Math.Round(beta, 0) & Environment.NewLine

        GetForward()

        DataLogging.Text += " >>  " & Math.Round(Xposition, 0) & "  " & Math.Round(Yposition, 0) & "  " & Math.Round(Zposition, 0) & Environment.NewLine & Environment.NewLine

        SendCount = 0
        For Layer As Integer = 1 To StackD                          'layer
            For Pallet As Integer = 1 To 5                          'box position
                For OneBox As Integer = 1 To 3                      '3 coordinate each box
                    Dim CoorX, CoorY, CoorZ As Double
                    Dim GripStatus As Integer
                    Dim GripperAngle As Integer

                    Dim Xinverse As Integer = 0
                    Dim Yinverse As Integer = 0

                    Dim ReNewX(,) As Integer = New Integer(,) {{0, 1, 2, 3, 4}, {2, 3, 4, 0, 1}, {1, 0, 4, 3, 2}, {4, 3, 2, 1, 0}}
                    Dim ReNewY(,) As Integer = New Integer(,) {{0, 0, 1, 1, 1}, {3, 3, 3, 2, 2}}

                    Dim W As Integer = Convert.ToInt32(BoxWidth.Text)
                    Dim L As Integer = Convert.ToInt32(BoxLength.Text)

                    If (Xposition < 0) Then
                        Xinverse = 2
                    End If
                    If (Layer - 1) Mod 2 = 1 Then
                        Yinverse = 1
                    End If

                    Select Case ReNewX(((Layer - 1) Mod 2) + Xinverse, Pallet - 1)
                        Case 0
                            CoorX = Xposition + (1 / 2 * L)
                        Case 1
                            CoorX = Xposition + (1 / 2 * L * -1)
                        Case 2
                            CoorX = Xposition + W
                        Case 3
                            CoorX = Xposition
                        Case 4
                            CoorX = Xposition + (W * -1)
                    End Select

                    Select Case ReNewY(Yinverse, Pallet - 1)
                        Case 0
                            CoorY = Yposition + ((((L + W) / 2) - (1 / 2 * W)) * -1)
                            GripperAngle = 0    'facing Y
                        Case 1
                            CoorY = Yposition + (((L + W) / 2) - (1 / 2 * L))
                            GripperAngle = 90   'facing X
                        Case 2
                            CoorY = Yposition + (((L + W) / 2) - (1 / 2 * W))
                            GripperAngle = 0    'facing Y
                        Case 3
                            CoorY = Yposition + ((((L + W) / 2) - (1 / 2 * L)) * -1)
                            GripperAngle = 90   'facing X
                    End Select

                    If OneBox = 2 Then
                        GripStatus = 2
                        CoorZ = Zposition + (Convert.ToInt32(BoxHeight.Text) * Layer)
                    Else
                        CoorZ = Zposition + (Convert.ToInt32(BoxHeight.Text) * 4) '4 = max stack height
                        GripStatus = 0
                    End If

                    GetInverse(CoorX, CoorY, CoorZ)
                    GetGripperAngle(GripperAngle)

                    SendAngles(SendCount) = Math.Round(gamma, 0) & ", " & Math.Round(alpha, 0) & ", " & Math.Round(beta, 0) & ", " & Math.Round(gripper, 0) & ", " & GripStatus & ", M"
                    SendCount += 1

                    If OneBox = 1 Then
                        DataLogging.Text += Environment.NewLine & " "
                        DataLogging.Text += Layer - 1 & "." & Pallet - 1 & "  "
                    Else
                        DataLogging.Text += "      "
                    End If

                    DataLogging.Text += " " & Math.Round(CoorX, 0)
                    If Math.Round(CoorX, 0) < 10 Then
                        DataLogging.Text += "   "
                    ElseIf Math.Round(CoorX, 0) < 100 Then
                        DataLogging.Text += "  "
                    Else
                        DataLogging.Text += " "
                    End If

                    DataLogging.Text += " " & Math.Round(CoorY, 0)
                    If Math.Round(CoorY, 0) < 10 Then
                        DataLogging.Text += "   "
                    ElseIf Math.Round(CoorY, 0) < 100 Then
                        DataLogging.Text += "  "
                    Else
                        DataLogging.Text += " "
                    End If

                    DataLogging.Text += " " & Math.Round(CoorZ, 0) & Environment.NewLine
                    If Pallet = 5 And OneBox = 3 Then
                        DataLogging.Text += Environment.NewLine & Environment.NewLine
                    End If

                    DataLogging.SelectionStart = DataLogging.Text.Length
                    DataLogging.ScrollToCaret()

                Next
            Next
        Next
    End Sub

    Public Sub HideDataBorder()         'hide all borders data
        Data1.BorderSize = 0
        Data2.BorderSize = 0
        Data3.BorderSize = 0
        Data4.BorderSize = 0
        Data5.BorderSize = 0
        Data6.BorderSize = 0
        Data7.BorderSize = 0
        Data8.BorderSize = 0
        Data9.BorderSize = 0
        Data10.BorderSize = 0
    End Sub


    Public Sub ShowDataBorder()

        Select Case NewLine
            Case 1
                Data1.BorderSize = 2

            Case 2
                Data2.BorderSize = 2

            Case 3
                Data3.BorderSize = 2

            Case 4
                Data4.BorderSize = 2

            Case 5
                Data5.BorderSize = 2

            Case 6
                Data6.BorderSize = 2

            Case 7
                Data7.BorderSize = 2

            Case 8
                Data8.BorderSize = 2

            Case 9
                Data9.BorderSize = 2

            Case 10
                Data10.BorderSize = 2

        End Select
    End Sub

    Public Sub DataShow()                               'combine servo1,2,3,4 data to single data
        Select Case NewLine
            Case 1
                Data1.Text = DataIn(1) + ", " + DataIn(2) + ", " + DataIn(3) + ", " + DataIn(4)
                Data1.ForeColor = Color.White
                Data1.BorderSize = 0
                Data2.ForeColor = Color.White
                Data2.BorderSize = 2

                Action1.ForeColor = Color.White

                DataNumber1.Visible = True

            Case 2
                Data2.Text = DataIn(1) + ", " + DataIn(2) + ", " + DataIn(3) + ", " + DataIn(4)
                Data2.ForeColor = Color.White
                Data2.BorderSize = 0
                Data3.ForeColor = Color.White
                Data3.BorderSize = 2

                Action2.ForeColor = Color.White

                DataNumber2.Visible = True

            Case 3
                Data3.Text = DataIn(1) + ", " + DataIn(2) + ", " + DataIn(3) + ", " + DataIn(4)
                Data3.ForeColor = Color.White
                Data3.BorderSize = 0
                Data4.ForeColor = Color.White
                Data4.BorderSize = 2

                Action3.ForeColor = Color.White

                DataNumber3.Visible = True

            Case 4
                Data4.Text = DataIn(1) + ", " + DataIn(2) + ", " + DataIn(3) + ", " + DataIn(4)
                Data4.ForeColor = Color.White
                Data4.BorderSize = 0
                Data5.ForeColor = Color.White
                Data5.BorderSize = 2

                Action4.ForeColor = Color.White

                DataNumber4.Visible = True

            Case 5
                Data5.Text = DataIn(1) + ", " + DataIn(2) + ", " + DataIn(3) + ", " + DataIn(4)
                Data5.ForeColor = Color.White
                Data5.BorderSize = 0
                Data6.ForeColor = Color.White
                Data6.BorderSize = 2

                Action5.ForeColor = Color.White

                DataNumber5.Visible = True

            Case 6
                Data6.Text = DataIn(1) + ", " + DataIn(2) + ", " + DataIn(3) + ", " + DataIn(4)
                Data6.ForeColor = Color.White
                Data6.BorderSize = 0
                Data7.ForeColor = Color.White
                Data7.BorderSize = 2

                Action6.ForeColor = Color.White

                DataNumber6.Visible = True

            Case 7
                Data7.Text = DataIn(1) + ", " + DataIn(2) + ", " + DataIn(3) + ", " + DataIn(4)
                Data7.ForeColor = Color.White
                Data7.BorderSize = 0
                Data8.ForeColor = Color.White
                Data8.BorderSize = 2

                Action7.ForeColor = Color.White

                DataNumber7.Visible = True

            Case 8
                Data8.Text = DataIn(1) + ", " + DataIn(2) + ", " + DataIn(3) + ", " + DataIn(4)
                Data8.ForeColor = Color.White
                Data8.BorderSize = 0
                Data9.ForeColor = Color.White
                Data9.BorderSize = 2

                Action8.ForeColor = Color.White

                DataNumber8.Visible = True

            Case 9
                Data9.Text = DataIn(1) + ", " + DataIn(2) + ", " + DataIn(3) + ", " + DataIn(4)
                Data9.ForeColor = Color.White
                Data9.BorderSize = 0
                Data10.ForeColor = Color.White
                Data10.BorderSize = 2

                Action9.ForeColor = Color.White

                DataNumber9.Visible = True

            Case 10
                Data10.Text = DataIn(1) + ", " + DataIn(2) + ", " + DataIn(3) + ", " + DataIn(4)
                Data10.ForeColor = Color.White

                Action10.ForeColor = Color.White

                DataNumber10.Visible = True

        End Select

        AngleSaved(NewLine, 1) = DataIn(1)
        AngleSaved(NewLine, 2) = DataIn(2)
        AngleSaved(NewLine, 3) = DataIn(3)
        AngleSaved(NewLine, 4) = DataIn(4)

        NewLine += 1
        If LastData < NewLine Then
            LastData = NewLine
        End If

    End Sub

    Private Sub DataErase_Click(sender As Object, e As EventArgs) Handles DataControlErase.Click
        If PlaySend.Text = "Play" Then
            PlaySend.Text = "Send to Arduino"
        End If

        Select Case NewLine                     'newLine refers to: bordered data
            Case 1                              'remove bordered data then move up all data bellow
                Data1.Text = Data2.Text
                Data2.Text = Data3.Text
                Data3.Text = Data4.Text
                Data4.Text = Data5.Text
                Data5.Text = Data6.Text
                Data6.Text = Data7.Text
                Data7.Text = Data8.Text
                Data8.Text = Data9.Text
                Data9.Text = Data10.Text
                Data10.Text = "No data"

                Action1.Text = Action2.Text
                Action2.Text = Action3.Text
                Action3.Text = Action4.Text
                Action4.Text = Action5.Text
                Action5.Text = Action6.Text
                Action6.Text = Action7.Text
                Action7.Text = Action8.Text
                Action8.Text = Action9.Text
                Action9.Text = Action10.Text
                Action10.Text = "-"

            Case 2
                Data2.Text = Data3.Text
                Data3.Text = Data4.Text
                Data4.Text = Data5.Text
                Data5.Text = Data6.Text
                Data6.Text = Data7.Text
                Data7.Text = Data8.Text
                Data8.Text = Data9.Text
                Data9.Text = Data10.Text
                Data10.Text = "No data"

                Action2.Text = Action3.Text
                Action3.Text = Action4.Text
                Action4.Text = Action5.Text
                Action5.Text = Action6.Text
                Action6.Text = Action7.Text
                Action7.Text = Action8.Text
                Action8.Text = Action9.Text
                Action9.Text = Action10.Text
                Action10.Text = "-"

            Case 3
                Data3.Text = Data4.Text
                Data4.Text = Data5.Text
                Data5.Text = Data6.Text
                Data6.Text = Data7.Text
                Data7.Text = Data8.Text
                Data8.Text = Data9.Text
                Data9.Text = Data10.Text
                Data10.Text = "No data"

                Action3.Text = Action4.Text
                Action4.Text = Action5.Text
                Action5.Text = Action6.Text
                Action6.Text = Action7.Text
                Action7.Text = Action8.Text
                Action8.Text = Action9.Text
                Action9.Text = Action10.Text
                Action10.Text = "-"

            Case 4
                Data4.Text = Data5.Text
                Data5.Text = Data6.Text
                Data6.Text = Data7.Text
                Data7.Text = Data8.Text
                Data8.Text = Data9.Text
                Data9.Text = Data10.Text
                Data10.Text = "No data"

                Action4.Text = Action5.Text
                Action5.Text = Action6.Text
                Action6.Text = Action7.Text
                Action7.Text = Action8.Text
                Action8.Text = Action9.Text
                Action9.Text = Action10.Text
                Action10.Text = "-"

            Case 5
                Data5.Text = Data6.Text
                Data6.Text = Data7.Text
                Data7.Text = Data8.Text
                Data8.Text = Data9.Text
                Data9.Text = Data10.Text
                Data10.Text = "No data"

                Action5.Text = Action6.Text
                Action6.Text = Action7.Text
                Action7.Text = Action8.Text
                Action8.Text = Action9.Text
                Action9.Text = Action10.Text
                Action10.Text = "-"

            Case 6
                Data6.Text = Data7.Text
                Data7.Text = Data8.Text
                Data8.Text = Data9.Text
                Data9.Text = Data10.Text
                Data10.Text = "No data"

                Action6.Text = Action7.Text
                Action7.Text = Action8.Text
                Action8.Text = Action9.Text
                Action9.Text = Action10.Text
                Action10.Text = "-"

            Case 7
                Data7.Text = Data8.Text
                Data8.Text = Data9.Text
                Data9.Text = Data10.Text
                Data10.Text = "No data"

                Action7.Text = Action8.Text
                Action8.Text = Action9.Text
                Action9.Text = Action10.Text
                Action10.Text = "-"

            Case 8
                Data8.Text = Data9.Text
                Data9.Text = Data10.Text
                Data10.Text = "No data"

                Action8.Text = Action9.Text
                Action9.Text = Action10.Text
                Action10.Text = "-"

            Case 9
                Data9.Text = Data10.Text
                Data10.Text = "No data"

                Action9.Text = Action10.Text
                Action10.Text = "-"

            Case 10
                Data10.Text = "No data"

                Action10.Text = "-"

        End Select

        Select Case LastData                    'decrease position of "No data" / reset total numb of data
            Case 2
                If LastData > NewLine Then
                    Data2.ForeColor = Color.Transparent
                    Action1.ForeColor = Color.Transparent
                    DataNumber1.Visible = False
                    LastData = 1
                End If

            Case 3
                If LastData > NewLine Then
                    Data3.ForeColor = Color.Transparent
                    Action2.ForeColor = Color.Transparent
                    DataNumber2.Visible = False
                    LastData = 2
                End If

            Case 4
                If LastData > NewLine Then
                    Data4.ForeColor = Color.Transparent
                    Action3.ForeColor = Color.Transparent
                    DataNumber3.Visible = False
                    LastData = 3
                End If

            Case 5
                If LastData > NewLine Then
                    Data5.ForeColor = Color.Transparent
                    Action4.ForeColor = Color.Transparent
                    DataNumber4.Visible = False
                    LastData = 4
                End If

            Case 6
                If LastData > NewLine Then
                    Data6.ForeColor = Color.Transparent
                    Action5.ForeColor = Color.Transparent
                    DataNumber5.Visible = False
                    LastData = 5
                End If

            Case 7
                If LastData > NewLine Then
                    Data7.ForeColor = Color.Transparent
                    Action6.ForeColor = Color.Transparent
                    DataNumber6.Visible = False
                    LastData = 6
                End If

            Case 8
                If LastData > NewLine Then
                    Data8.ForeColor = Color.Transparent
                    Action7.ForeColor = Color.Transparent
                    DataNumber7.Visible = False
                    LastData = 7
                End If

            Case 9
                If LastData > NewLine Then
                    Data9.ForeColor = Color.Transparent
                    Action8.ForeColor = Color.Transparent
                    DataNumber8.Visible = False
                    LastData = 8
                End If

            Case 10
                If LastData > NewLine Then
                    Data10.ForeColor = Color.Transparent
                    Action9.ForeColor = Color.Transparent
                    DataNumber9.Visible = False
                    LastData = 9
                End If

            Case 11
                Action10.ForeColor = Color.Transparent
                DataNumber10.Visible = False
                LastData = 10
        End Select
    End Sub

    Private Sub DataUp_Click(sender As Object, e As EventArgs) Handles DataControlUp.Click
        If PlaySend.Text = "Play" Then
            PlaySend.Text = "Send to Arduino"
        End If

        Select Case NewLine
            Case 2
                If Data2.Text <> "No data" Then
                    Data0 = Data1.Text
                    Data1.Text = Data2.Text
                    Data2.Text = Data0

                    Action0 = Action1.Text
                    Action1.Text = Action2.Text
                    Action2.Text = Action0

                    NewLine = 1
                    HideDataBorder()
                    Data1.BorderSize = 2
                End If

            Case 3
                If Data3.Text <> "No data" Then
                    Data0 = Data2.Text
                    Data2.Text = Data3.Text
                    Data3.Text = Data0

                    Action0 = Action2.Text
                    Action2.Text = Action3.Text
                    Action3.Text = Action0

                    NewLine = 2
                    HideDataBorder()
                    Data2.BorderSize = 2
                End If

            Case 4
                If Data4.Text <> "No data" Then
                    Data0 = Data3.Text
                    Data3.Text = Data4.Text
                    Data4.Text = Data0

                    Action0 = Action3.Text
                    Action3.Text = Action4.Text
                    Action4.Text = Action0

                    NewLine = 3
                    HideDataBorder()
                    Data3.BorderSize = 2
                End If

            Case 5
                If Data5.Text <> "No data" Then
                    Data0 = Data4.Text
                    Data4.Text = Data5.Text
                    Data5.Text = Data0

                    Action0 = Action4.Text
                    Action4.Text = Action5.Text
                    Action5.Text = Action0

                    NewLine = 4
                    HideDataBorder()
                    Data4.BorderSize = 2
                End If

            Case 6
                If Data6.Text <> "No data" Then
                    Data0 = Data5.Text
                    Data5.Text = Data6.Text
                    Data6.Text = Data0

                    Action0 = Action5.Text
                    Action5.Text = Action6.Text
                    Action6.Text = Action0

                    NewLine = 5
                    HideDataBorder()
                    Data5.BorderSize = 2
                End If

            Case 7
                If Data7.Text <> "No data" Then
                    Data0 = Data6.Text
                    Data6.Text = Data7.Text
                    Data7.Text = Data0

                    Action0 = Action6.Text
                    Action6.Text = Action7.Text
                    Action7.Text = Action0

                    NewLine = 6
                    HideDataBorder()
                    Data6.BorderSize = 2
                End If

            Case 8
                If Data8.Text <> "No data" Then
                    Data0 = Data7.Text
                    Data7.Text = Data8.Text
                    Data8.Text = Data0

                    Action0 = Action7.Text
                    Action7.Text = Action8.Text
                    Action8.Text = Action0

                    NewLine = 7
                    HideDataBorder()
                    Data7.BorderSize = 2
                End If

            Case 9
                If Data9.Text <> "No data" Then
                    Data0 = Data8.Text
                    Data8.Text = Data9.Text
                    Data9.Text = Data0

                    Action0 = Action8.Text
                    Action8.Text = Action9.Text
                    Action9.Text = Action0

                    NewLine = 8
                    HideDataBorder()
                    Data8.BorderSize = 2
                End If

            Case 10
                If Data10.Text <> "No data" Then
                    Data0 = Data9.Text
                    Data9.Text = Data10.Text
                    Data10.Text = Data0

                    Action0 = Action9.Text
                    Action9.Text = Action10.Text
                    Action10.Text = Action0

                    NewLine = 9
                    HideDataBorder()
                    Data9.BorderSize = 2
                End If

        End Select
    End Sub

    Private Sub DataDown_Click(sender As Object, e As EventArgs) Handles DataControlDown.Click
        If PlaySend.Text = "Play" Then
            PlaySend.Text = "Send to Arduino"
        End If

        Select Case NewLine
            Case 1
                If Data1.Text <> "No data" And Data2.Text <> "No data" Then
                    Data0 = Data1.Text
                    Data1.Text = Data2.Text
                    Data2.Text = Data0

                    Action0 = Action1.Text
                    Action1.Text = Action2.Text
                    Action2.Text = Action0

                    NewLine = 2
                    HideDataBorder()
                    Data2.BorderSize = 2
                End If

            Case 2
                If Data2.Text <> "No data" And Data3.Text <> "No data" Then
                    Data0 = Data2.Text
                    Data2.Text = Data3.Text
                    Data3.Text = Data0

                    Action0 = Action2.Text
                    Action2.Text = Action3.Text
                    Action3.Text = Action0

                    NewLine = 3
                    HideDataBorder()
                    Data3.BorderSize = 2
                End If

            Case 3
                If Data3.Text <> "No data" And Data4.Text <> "No data" Then
                    Data0 = Data3.Text
                    Data3.Text = Data4.Text
                    Data4.Text = Data0

                    Action0 = Action3.Text
                    Action3.Text = Action4.Text
                    Action4.Text = Action0

                    NewLine = 4
                    HideDataBorder()
                    Data4.BorderSize = 2
                End If

            Case 4
                If Data4.Text <> "No data" And Data5.Text <> "No data" Then
                    Data0 = Data4.Text
                    Data4.Text = Data5.Text
                    Data5.Text = Data0

                    Action0 = Action4.Text
                    Action4.Text = Action5.Text
                    Action5.Text = Action0

                    NewLine = 5
                    HideDataBorder()
                    Data5.BorderSize = 2
                End If

            Case 5
                If Data5.Text <> "No data" And Data6.Text <> "No data" Then
                    Data0 = Data5.Text
                    Data5.Text = Data6.Text
                    Data6.Text = Data0

                    Action0 = Action5.Text
                    Action5.Text = Action6.Text
                    Action6.Text = Action0

                    NewLine = 6
                    HideDataBorder()
                    Data6.BorderSize = 2
                End If

            Case 6
                If Data6.Text <> "No data" And Data7.Text <> "No data" Then
                    Data0 = Data6.Text
                    Data6.Text = Data7.Text
                    Data7.Text = Data0

                    Action0 = Action6.Text
                    Action6.Text = Action7.Text
                    Action7.Text = Action0

                    NewLine = 7
                    HideDataBorder()
                    Data7.BorderSize = 2
                End If

            Case 7
                If Data7.Text <> "No data" And Data8.Text <> "No data" Then
                    Data0 = Data7.Text
                    Data7.Text = Data8.Text
                    Data8.Text = Data0

                    Action0 = Action7.Text
                    Action7.Text = Action8.Text
                    Action8.Text = Action0

                    NewLine = 8
                    HideDataBorder()
                    Data8.BorderSize = 2
                End If

            Case 8
                If Data8.Text <> "No data" And Data9.Text <> "No data" Then
                    Data0 = Data8.Text
                    Data8.Text = Data9.Text
                    Data9.Text = Data0

                    Action0 = Action8.Text
                    Action8.Text = Action9.Text
                    Action9.Text = Action0

                    NewLine = 9
                    HideDataBorder()
                    Data9.BorderSize = 2
                End If

            Case 9
                If Data9.Text <> "No data" And Data10.Text <> "No data" Then
                    Data0 = Data9.Text
                    Data9.Text = Data10.Text
                    Data10.Text = Data0

                    Action0 = Action9.Text
                    Action9.Text = Action10.Text
                    Action10.Text = Action0

                    NewLine = 10
                    HideDataBorder()
                    Data10.BorderSize = 2
                End If

        End Select
    End Sub

    Private Sub Data1_Click(sender As Object, e As EventArgs) Handles Data1.Click
        NewLine = 1
        HideDataBorder()
        Data1.BorderSize = 2
    End Sub

    Private Sub Data2_Click(sender As Object, e As EventArgs) Handles Data2.Click
        If LastData > 1 Then
            NewLine = 2
            HideDataBorder()
            Data2.BorderSize = 2
        End If
    End Sub

    Private Sub Data3_Click(sender As Object, e As EventArgs) Handles Data3.Click
        If LastData > 2 Then
            NewLine = 3
            HideDataBorder()
            Data3.BorderSize = 2
        End If
    End Sub

    Private Sub Data4_Click(sender As Object, e As EventArgs) Handles Data4.Click
        If LastData > 3 Then
            NewLine = 4
            HideDataBorder()
            Data4.BorderSize = 2
        End If
    End Sub

    Private Sub Data5_Click(sender As Object, e As EventArgs) Handles Data5.Click
        If LastData > 4 Then
            NewLine = 5
            HideDataBorder()
            Data5.BorderSize = 2
        End If
    End Sub

    Private Sub Data6_Click(sender As Object, e As EventArgs) Handles Data6.Click
        If LastData > 5 Then
            NewLine = 6
            HideDataBorder()
            Data6.BorderSize = 2
        End If
    End Sub

    Private Sub Data7_Click(sender As Object, e As EventArgs) Handles Data7.Click
        If LastData > 6 Then
            NewLine = 7
            HideDataBorder()
            Data7.BorderSize = 2
        End If
    End Sub

    Private Sub Data8_Click(sender As Object, e As EventArgs) Handles Data8.Click
        If LastData > 7 Then
            NewLine = 8
            HideDataBorder()
            Data8.BorderSize = 2
        End If
    End Sub

    Private Sub Data9_Click(sender As Object, e As EventArgs) Handles Data9.Click
        If LastData > 8 Then
            NewLine = 9
            HideDataBorder()
            Data9.BorderSize = 2
        End If
    End Sub

    Private Sub Data10_Click(sender As Object, e As EventArgs) Handles Data10.Click
        If LastData > 9 Then
            NewLine = 10
            HideDataBorder()
            Data10.BorderSize = 2
        End If
    End Sub

    Private Sub Action1_Click(sender As Object, e As EventArgs) Handles Action1.Click
        If PlaySend.Text = "Play" Then
            PlaySend.Text = "Send to Arduino"
        End If

        If Data1.Text <> "No data" Then
            If Action1.Text = "-" Then
                Action1.Text = "Hold"
            ElseIf Action1.Text = "Hold" Then
                Action1.Text = "Release"
            ElseIf Action1.Text = "Release" Then
                Action1.Text = "-"
            End If
        End If

    End Sub

    Private Sub Action2_Click(sender As Object, e As EventArgs) Handles Action2.Click
        If PlaySend.Text = "Play" Then
            PlaySend.Text = "Send to Arduino"
        End If

        If Data2.Text <> "No data" Then
            If Action2.BorderSize = 2 Then
                If Action2.Text = "-" Then
                    Action2.Text = "Hold"
                ElseIf Action2.Text = "Hold" Then
                    Action2.Text = "Release"
                ElseIf Action2.Text = "Release" Then
                    Action2.Text = "-"
                End If
            End If
        End If

    End Sub

    Private Sub Action3_Click(sender As Object, e As EventArgs) Handles Action3.Click
        If PlaySend.Text = "Play" Then
            PlaySend.Text = "Send to Arduino"
        End If

        If Data3.Text <> "No data" Then
            If Action3.BorderSize = 2 Then
                If Action3.Text = "-" Then
                    Action3.Text = "Hold"
                ElseIf Action3.Text = "Hold" Then
                    Action3.Text = "Release"
                ElseIf Action3.Text = "Release" Then
                    Action3.Text = "-"
                End If
            End If
        End If

    End Sub

    Private Sub Action4_Click(sender As Object, e As EventArgs) Handles Action4.Click
        If PlaySend.Text = "Play" Then
            PlaySend.Text = "Send to Arduino"
        End If

        If Data4.Text <> "No data" Then
            If Action4.BorderSize = 2 Then
                If Action4.Text = "-" Then
                    Action4.Text = "Hold"
                ElseIf Action4.Text = "Hold" Then
                    Action4.Text = "Release"
                ElseIf Action4.Text = "Release" Then
                    Action4.Text = "-"
                End If
            End If
        End If

    End Sub

    Private Sub Action5_Click(sender As Object, e As EventArgs) Handles Action5.Click
        If PlaySend.Text = "Play" Then
            PlaySend.Text = "Send to Arduino"
        End If

        If Data5.Text <> "No data" Then
            If Action5.BorderSize = 2 Then
                If Action5.Text = "-" Then
                    Action5.Text = "Hold"
                ElseIf Action5.Text = "Hold" Then
                    Action5.Text = "Release"
                ElseIf Action5.Text = "Release" Then
                    Action5.Text = "-"
                End If
            End If
        End If

    End Sub

    Private Sub Action6_Click(sender As Object, e As EventArgs) Handles Action6.Click
        If PlaySend.Text = "Play" Then
            PlaySend.Text = "Send to Arduino"
        End If

        If Data6.Text <> "No data" Then
            If Action6.BorderSize = 2 Then
                If Action6.Text = "-" Then
                    Action6.Text = "Hold"
                ElseIf Action6.Text = "Hold" Then
                    Action6.Text = "Release"
                ElseIf Action6.Text = "Release" Then
                    Action6.Text = "-"
                End If
            End If
        End If

    End Sub

    Private Sub Action7_Click(sender As Object, e As EventArgs) Handles Action7.Click
        If PlaySend.Text = "Play" Then
            PlaySend.Text = "Send to Arduino"
        End If

        If Data7.Text <> "No data" Then
            If Action7.BorderSize = 2 Then
                If Action7.Text = "-" Then
                    Action7.Text = "Hold"
                ElseIf Action7.Text = "Hold" Then
                    Action7.Text = "Release"
                ElseIf Action7.Text = "Release" Then
                    Action7.Text = "-"
                End If
            End If
        End If

    End Sub

    Private Sub Action8_Click(sender As Object, e As EventArgs) Handles Action8.Click
        If PlaySend.Text = "Play" Then
            PlaySend.Text = "Send to Arduino"
        End If

        If Data8.Text <> "No data" Then
            If Action8.BorderSize = 2 Then
                If Action8.Text = "-" Then
                    Action8.Text = "Hold"
                ElseIf Action8.Text = "Hold" Then
                    Action8.Text = "Release"
                ElseIf Action8.Text = "Release" Then
                    Action8.Text = "-"
                End If
            End If
        End If

    End Sub

    Private Sub Action9_Click(sender As Object, e As EventArgs) Handles Action9.Click
        If PlaySend.Text = "Play" Then
            PlaySend.Text = "Send to Arduino"
        End If

        If Data9.Text <> "No data" Then
            If Action9.BorderSize = 2 Then
                If Action9.Text = "-" Then
                    Action9.Text = "Hold"
                ElseIf Action9.Text = "Hold" Then
                    Action9.Text = "Release"
                ElseIf Action9.Text = "Release" Then
                    Action9.Text = "-"
                End If
            End If
        End If

    End Sub

    Private Sub Action10_Click(sender As Object, e As EventArgs) Handles Action10.Click
        If PlaySend.Text = "Play" Then
            PlaySend.Text = "Send to Arduino"
        End If

        If Data10.Text <> "No data" Then
            If Action10.BorderSize = 2 Then
                If Action10.Text = "-" Then
                    Action10.Text = "Hold"
                ElseIf Action10.Text = "Hold" Then
                    Action10.Text = "Release"
                ElseIf Action10.Text = "Release" Then
                    Action10.Text = "-"
                End If
            End If
        End If

    End Sub

    Private Sub Action1_MouseHover(sender As Object, e As EventArgs) Handles Action1.MouseHover
        If Data1.Text <> "No data" Then
            Action1.BorderSize = 2
        End If
    End Sub

    Private Sub Action1_MouseLeave(sender As Object, e As EventArgs) Handles Action1.MouseLeave
        Action1.BorderSize = 0
    End Sub

    Private Sub Action2_MouseHover(sender As Object, e As EventArgs) Handles Action2.MouseHover
        If Data2.Text <> "No data" Then
            Action2.BorderSize = 2
        End If
    End Sub

    Private Sub Action2_MouseLeave(sender As Object, e As EventArgs) Handles Action2.MouseLeave
        Action2.BorderSize = 0
    End Sub

    Private Sub Action3_MouseHover(sender As Object, e As EventArgs) Handles Action3.MouseHover
        If Data3.Text <> "No data" Then
            Action3.BorderSize = 2
        End If
    End Sub

    Private Sub Action3_MouseLeave(sender As Object, e As EventArgs) Handles Action3.MouseLeave
        Action3.BorderSize = 0
    End Sub

    Private Sub Action4_MouseHover(sender As Object, e As EventArgs) Handles Action4.MouseHover
        If Data4.Text <> "No data" Then
            Action4.BorderSize = 2
        End If
    End Sub

    Private Sub Action4_MouseLeave(sender As Object, e As EventArgs) Handles Action4.MouseLeave
        Action4.BorderSize = 0
    End Sub

    Private Sub Action5_MouseHover(sender As Object, e As EventArgs) Handles Action5.MouseHover
        If Data5.Text <> "No data" Then
            Action5.BorderSize = 2
        End If
    End Sub

    Private Sub Action5_MouseLeave(sender As Object, e As EventArgs) Handles Action5.MouseLeave
        Action5.BorderSize = 0
    End Sub

    Private Sub Action6_MouseHover(sender As Object, e As EventArgs) Handles Action6.MouseHover
        If Data6.Text <> "No data" Then
            Action6.BorderSize = 2
        End If
    End Sub

    Private Sub Action6_MouseLeave(sender As Object, e As EventArgs) Handles Action6.MouseLeave
        Action6.BorderSize = 0
    End Sub

    Private Sub Action7_MouseHover(sender As Object, e As EventArgs) Handles Action7.MouseHover
        If Data7.Text <> "No data" Then
            Action7.BorderSize = 2
        End If
    End Sub

    Private Sub Action7_MouseLeave(sender As Object, e As EventArgs) Handles Action7.MouseLeave
        Action7.BorderSize = 0
    End Sub

    Private Sub Action8_MouseHover(sender As Object, e As EventArgs) Handles Action8.MouseHover
        If Data8.Text <> "No data" Then
            Action8.BorderSize = 2
        End If
    End Sub

    Private Sub Action8_MouseLeave(sender As Object, e As EventArgs) Handles Action8.MouseLeave
        Action8.BorderSize = 0
    End Sub

    Private Sub Action9_MouseHover(sender As Object, e As EventArgs) Handles Action9.MouseHover
        If Data9.Text <> "No data" Then
            Action9.BorderSize = 2
        End If
    End Sub

    Private Sub Action9_MouseLeave(sender As Object, e As EventArgs) Handles Action9.MouseLeave
        Action9.BorderSize = 0
    End Sub

    Private Sub Action10_MouseHover(sender As Object, e As EventArgs) Handles Action10.MouseHover
        If Data10.Text <> "No data" Then
            Action10.BorderSize = 2
        End If
    End Sub

    Private Sub Action10_MouseLeave(sender As Object, e As EventArgs) Handles Action10.MouseLeave
        Action10.BorderSize = 0
    End Sub

    Public Function SIN(ByVal InValue As Double)
        Dim value As Double
        value = Math.Sin(InValue * (Math.PI / 180))
        Return value
    End Function

    Public Function COS(ByVal InValue As Double)
        Dim value As Double
        value = Math.Cos(InValue * (Math.PI / 180))
        Return value
    End Function

    Public Function TAN(ByVal InValue As Double)
        Dim value As Double
        value = Math.Tan(InValue * (Math.PI / 180))
        Return value
    End Function

    Public Function ASIN(ByVal InValue As Double)
        Dim value As Double
        value = Math.Asin(InValue) * (180 / Math.PI)
        Return value
    End Function

    Public Function ACOS(ByVal InValue As Double)
        Dim value As Double
        value = Math.Acos(InValue) * (180 / Math.PI)
        Return value
    End Function

    Public Function ATAN(ByVal InValue As Double)
        Dim value As Double
        value = Math.Atan(InValue) * (180 / Math.PI)
        Return value
    End Function

    Public Sub ScreenLayout(ByVal screen As String)         'Setup layout 
        Select Case screen
            Case "Home"
                'menu visible =================================================================================================
                PortPanel.Visible = True
                SideConnect.Visible = True
                NotifPort.Visible = False
                DataControlPanel.Visible = False
                PlaySend.Visible = False
                SideMenu.Visible = False
                SideAbout.Visible = True

                'back to Main__________________________________________________________________________________________________
                If SideConnect.Text = "Disconnect" Then
                    SideBack.Visible = True
                Else
                    SideBack.Visible = False
                End If

                'only show side panel__________________________________________________________________________________________
                RecordGetData.Visible = False
                InputPanel.Visible = False
                PlayPanel.Visible = False
                DataPanel.Visible = False

                'change Main menu color to no selected_________________________________________________________________________
                SideRecord.BaseColor = Color.DodgerBlue
                SideRecord.ForeColor = Color.White
                SideInput.BaseColor = Color.DodgerBlue
                SideInput.ForeColor = Color.White
                SidePlay.BaseColor = Color.DodgerBlue
                SidePlay.ForeColor = Color.White

                'Home layout___________________________________________________________________________
                SideConnect.Height = 42
                SideConnect.Width = 168
                SideConnect.Radius = 20
                SideConnect.BorderColor = Color.White

                SidePanel.Width = 320
                SidePanel.Height = 50 + PortPanel.Height + 5 + SideConnect.Height + 50 + SideAbout.Height + 15
                SideConnect.Width = 168
                SideAbout.Width = 168

                SideBack.Location = New Point(5, 5)
                SideExit.Location = New Point(SidePanel.Width - SideExit.Width - 5, 5)
                PortPanel.Location = New Point(5, 50)
                SideConnect.Location = New Point(SidePanel.Width / 2 - SideConnect.Width / 2, 50 + PortPanel.Height + 5)
                SideAbout.Location = New Point(SidePanel.Width / 2 - SideAbout.Width / 2, 50 + PortPanel.Height + 5 + SideConnect.Height + 50)
                NotifPort.Location = New Point(SidePanel.Width / 2 - SideConnect.Width / 2, 50 + PortPanel.Height + 5 + SideConnect.Height + 5)

                Me.Size = New Size(SidePanel.Width + 30, SidePanel.Height + 30)

            Case "Main"
                'remove unuse items from Home layout ==========================================================================
                PortPanel.Visible = False
                NotifPort.Visible = False
                SideConnect.Visible = True
                SideMenu.Visible = True
                SideAbout.Visible = False
                SideBack.Visible = False

                'only show side panel__________________________________________________________________________________________
                RecordGetData.Visible = False
                InputPanel.Visible = False
                PlayPanel.Visible = False
                DataPanel.Visible = True
                DataLogging.Visible = True
                DataLogButton.Visible = True

                'Side Panel layout_____________________________________________________________________________________________
                SideConnect.Height = 30
                SideConnect.Width = 170
                SideConnect.Radius = 5
                SideConnect.BorderColor = Color.DodgerBlue
                SideConnect.Location = New Point(SidePanel.Width / 2 - SideConnect.Width / 2, 5)

                SidePanel.Height = 5 + SideConnect.Height + 5
                SidePanel.Width = 320

                ConnectedString = "Connected to " + Port
                SideConnect.Text = ConnectedString

                SideExit.Location = New Point(SidePanel.Width - SideExit.Width - 5, SidePanel.Height / 2 - SideExit.Height / 2)

                'Data Panel layout size________________________________________________________________________________________
                DataListPanel.Height = 340

                DataControlPanel.Location = New Point(5, 35 + DataListPanel.Height + 10)
                SideMenu.Location = New Point(5, 35 + DataListPanel.Height + 10 + DataControlPanel.Height + 8)

                DataPanel.Width = 320
                DataPanel.Height = 35 + DataListPanel.Height + 10 + DataControlPanel.Height + 8 + SideMenu.Height + 8
                DataPanel.Location = New Point(15, 15 + SidePanel.Height + 15)

                'data logging layout___________________________________________________________________________________________
                DataLogButton.Location = New Point(296, 15 + SidePanel.Height + 15 + DataPanel.Height + 15 + 8)

                LabelLogging.Location = New Point(SidePanel.Width + 35, 20)
                DataLogging.Width = SidePanel.Width - 10
                DataLogging.Height = 593 - 25 - 15
                DataLogging.Location = New Point(SidePanel.Width + 40, 15 + 20 + 15)

                Me.Size = New Size(SidePanel.Width + 30, 15 + SidePanel.Height + 15 + DataPanel.Height + 15)

            Case "Record"
                'color select for side record menu ============================================================================
                SideRecord.BaseColor = Color.White
                SideRecord.ForeColor = Color.DodgerBlue
                SideInput.BaseColor = Color.DodgerBlue
                SideInput.ForeColor = Color.White
                SidePlay.BaseColor = Color.DodgerBlue
                SidePlay.ForeColor = Color.White

                'show record and data panel____________________________________________________________________________________
                RecordGetData.Visible = True
                InputPanel.Visible = False
                PlayPanel.Visible = False
                DataPanel.Visible = True

                'Side Panel layout_____________________________________________________________________________________________
                SideConnect.Height = 30
                SideConnect.Width = 170
                SideConnect.Radius = 5
                SideConnect.BorderColor = Color.DodgerBlue
                SideConnect.Location = New Point(SidePanel.Width / 2 - SideConnect.Width / 2, 5)

                ConnectedString = "Connected to " + Port
                SideConnect.Text = ConnectedString

                SidePanel.Width = 320
                SidePanel.Height = 5 + SideConnect.Height + 5

                SideExit.Location = New Point(SidePanel.Width - SideExit.Width - 5, SidePanel.Height / 2 - SideExit.Height / 2)

                'Data Panel layout size________________________________________________________________________________________
                DataListPanel.Height = 340

                DataControlPanel.Visible = True
                DataControlPanel.Location = New Point(5, 35 + DataListPanel.Height + 10)
                SideMenu.Location = New Point(5, 35 + DataListPanel.Height + 10 + DataControlPanel.Height + 8)

                DataPanel.Width = 320
                DataPanel.Height = 35 + DataListPanel.Height + 10 + DataControlPanel.Height + 8 + SideMenu.Height + 8
                DataPanel.Location = New Point(15, 15 + SidePanel.Height + 15)

                'record panel layout___________________________________________________________________________________________
                RecordGetData.Location = New Point(DataPanel.Width / 2 - RecordGetData.Width / 2 + 15, 15 + SidePanel.Height + 15 + DataPanel.Height + 15)

                If Logging Then
                    Me.Size = New Size(SidePanel.Width * 2 + 45, 623)
                Else
                    Me.Size = New Size(SidePanel.Width + 30, 15 + SidePanel.Height + 15 + DataPanel.Height + 15 + RecordGetData.Height + 15)
                End If

            Case "Input"
                'color select for side Input menu =============================================================================
                SideRecord.BaseColor = Color.DodgerBlue
                SideRecord.ForeColor = Color.White
                SideInput.BaseColor = Color.White
                SideInput.ForeColor = Color.DodgerBlue
                SidePlay.BaseColor = Color.DodgerBlue
                SidePlay.ForeColor = Color.White

                'show input and data panel_____________________________________________________________________________________
                InputPanel.Visible = True
                PlayPanel.Visible = False
                DataPanel.Visible = True
                RecordGetData.Visible = False

                'Side Panel layout_____________________________________________________________________________________________
                SideConnect.Height = 30
                SideConnect.Width = 170
                SideConnect.Radius = 5
                SideConnect.BorderColor = Color.DodgerBlue
                SideConnect.Location = New Point(SidePanel.Width / 2 - SideConnect.Width / 2, 5)

                ConnectedString = "Connected to " + Port
                SideConnect.Text = ConnectedString

                SidePanel.Width = 320
                SidePanel.Height = 5 + SideConnect.Height + 5

                SideExit.Location = New Point(SidePanel.Width - SideExit.Width - 5, SidePanel.Height / 2 - SideExit.Height / 2)

                'Data panel layout_____________________________________________________________________________________________
                DataListPanel.Height = 340 + 5 + RecordGetData.Height - InputPanel.Height

                DataPanel.Width = 320
                DataPanel.Height = 35 + DataListPanel.Height + 10 + DataControlPanel.Height + 8 + SideMenu.Height + 8
                DataPanel.Location = New Point(15, 15 + SidePanel.Height + 15)

                DataControlPanel.Visible = True
                DataControlPanel.Location = New Point(5, 35 + DataListPanel.Height + 10)
                SideMenu.Location = New Point(5, 35 + DataListPanel.Height + 10 + DataControlPanel.Height + 8)

                'input panel layout____________________________________________________________________________________________
                InputGripper.Visible = False
                InputGripperClear.Visible = False
                InputGripperAngel.Visible = True

                InputPanel.Width = SidePanel.Width
                InputPanel.Height = 190

                InputPanel.Location = New Point(15, 15 + SidePanel.Height + 15 + DataPanel.Height + 10)
                InputConvert.Location = New Point(InputPanel.Width / 2 - InputConvert.Width / 2, 148)
                InputNotif.Location = New Point(InputPanel.Width / 2 - InputConvert.Width / 2, 130)

                If Logging Then
                    Me.Size = New Size(SidePanel.Width * 2 + 45, 623)
                Else
                    Me.Size = New Size(SidePanel.Width + 30, 15 + SidePanel.Height + 15 + DataPanel.Height + 10 + InputPanel.Height + 15)
                End If

            Case "Play"
                'color select for side Play menu ==============================================================================
                SideRecord.BaseColor = Color.DodgerBlue
                SideRecord.ForeColor = Color.White
                SideInput.BaseColor = Color.DodgerBlue
                SideInput.ForeColor = Color.White
                SidePlay.BaseColor = Color.White
                SidePlay.ForeColor = Color.DodgerBlue

                'select play panel_____________________________________________________________________________________________
                InputPanel.Visible = False
                PlayPanel.Visible = True
                DataPanel.Visible = True
                RecordGetData.Visible = False

                'play panel set up
                If SlideUI = 11 Then
                    PlayPanel.Height = 90
                ElseIf SlideUI = 10 Then
                    PlayPanel.Height = 215
                End If

                PlayPanel.Width = SidePanel.Width
                PlayLoading.Location = New Point(GunaElipsePanel3.Width / 2 - PlayLoading.Width / 2, 1)
                PlaySend.Location = New Point(GunaElipsePanel3.Width / 2 - PlaySend.Width / 2, 5)

                'Side Panel layout_____________________________________________________________________________________________
                SideConnect.Height = 30
                SideConnect.Width = 170
                SideConnect.Radius = 5
                SideConnect.BorderColor = Color.DodgerBlue
                SideConnect.Location = New Point(SidePanel.Width / 2 - SideConnect.Width / 2, 5)

                ConnectedString = "Connected to " + Port
                SideConnect.Text = ConnectedString

                SidePanel.Width = 320
                SidePanel.Height = 5 + SideConnect.Height + 5

                SideExit.Location = New Point(SidePanel.Width - SideExit.Width - 5, SidePanel.Height / 2 - SideExit.Height / 2)

                'Data panel layout_____________________________________________________________________________________________
                DataListPanel.Height = 340 + 10 + RecordGetData.Height - PlayPanel.Height

                DataPanel.Width = 320
                DataPanel.Height = 35 + DataListPanel.Height + 10 + DataControlPanel.Height + 8 + SideMenu.Height + 8
                DataPanel.Location = New Point(15, 15 + SidePanel.Height + 15)

                DataControlPanel.Location = New Point(5, 35 + DataListPanel.Height + 10)
                SideMenu.Location = New Point(5, 35 + DataListPanel.Height + 10 + DataControlPanel.Height + 8)

                'play panel layout_____________________________________________________________________________________________
                PlaySend.Visible = True
                PlayLoading.Visible = False
                PlayPanel.Location = New Point(15, 15 + SidePanel.Height + 15 + DataPanel.Height + 13)

                If Logging Then
                    Me.Size = New Size(SidePanel.Width * 2 + 45, 623)
                Else
                    Me.Size = New Size(SidePanel.Width + 30, 623)
                End If

            Case "About"
                SideRecord.BaseColor = Color.DodgerBlue
                SideRecord.ForeColor = Color.White
                SideInput.BaseColor = Color.DodgerBlue
                SideInput.ForeColor = Color.White
                SidePlay.BaseColor = Color.DodgerBlue
                SidePlay.ForeColor = Color.White

                InputPanel.Visible = False
                PlayPanel.Visible = False
                DataPanel.Visible = False

                Me.Size = New Size(15 + SidePanel.Width + 15, 15 + SidePanel.Height + 15)
        End Select
    End Sub

End Class