<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.NotifPort = New System.Windows.Forms.Label()
        Me.SideMenu = New System.Windows.Forms.Panel()
        Me.SidePlay = New Guna.UI.WinForms.GunaButton()
        Me.SideInput = New Guna.UI.WinForms.GunaButton()
        Me.SideRecord = New Guna.UI.WinForms.GunaButton()
        Me.PortPanel = New System.Windows.Forms.Panel()
        Me.ConnectPort = New Guna.UI.WinForms.GunaComboBox()
        Me.SideRefresh = New Guna.UI.WinForms.GunaCircleButton()
        Me.PortLabel = New System.Windows.Forms.Label()
        Me.SideAbout = New Guna.UI.WinForms.GunaButton()
        Me.SideConnect = New Guna.UI.WinForms.GunaButton()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.SidePanel = New Guna.UI.WinForms.GunaElipsePanel()
        Me.SideBack = New Guna.UI.WinForms.GunaButton()
        Me.SideExit = New Guna.UI.WinForms.GunaButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MyPort = New System.IO.Ports.SerialPort(Me.components)
        Me.Data1 = New Guna.UI.WinForms.GunaButton()
        Me.RecordGetData = New Guna.UI.WinForms.GunaButton()
        Me.DataPanel = New Guna.UI.WinForms.GunaElipsePanel()
        Me.DataControlPanel = New Guna.UI.WinForms.GunaElipsePanel()
        Me.DataControlUp = New Guna.UI.WinForms.GunaCircleButton()
        Me.DataControlDown = New Guna.UI.WinForms.GunaCircleButton()
        Me.DataControlErase = New Guna.UI.WinForms.GunaButton()
        Me.ActionLabel = New System.Windows.Forms.Label()
        Me.DataListPanel = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.Action10 = New Guna.UI.WinForms.GunaButton()
        Me.Action9 = New Guna.UI.WinForms.GunaButton()
        Me.Action8 = New Guna.UI.WinForms.GunaButton()
        Me.Action7 = New Guna.UI.WinForms.GunaButton()
        Me.Action6 = New Guna.UI.WinForms.GunaButton()
        Me.Action5 = New Guna.UI.WinForms.GunaButton()
        Me.Action4 = New Guna.UI.WinForms.GunaButton()
        Me.Action3 = New Guna.UI.WinForms.GunaButton()
        Me.Action2 = New Guna.UI.WinForms.GunaButton()
        Me.Action1 = New Guna.UI.WinForms.GunaButton()
        Me.Data10 = New Guna.UI.WinForms.GunaButton()
        Me.Data9 = New Guna.UI.WinForms.GunaButton()
        Me.Data8 = New Guna.UI.WinForms.GunaButton()
        Me.Data7 = New Guna.UI.WinForms.GunaButton()
        Me.Data6 = New Guna.UI.WinForms.GunaButton()
        Me.Data5 = New Guna.UI.WinForms.GunaButton()
        Me.Data4 = New Guna.UI.WinForms.GunaButton()
        Me.Data3 = New Guna.UI.WinForms.GunaButton()
        Me.Data2 = New Guna.UI.WinForms.GunaButton()
        Me.DataNumber10 = New System.Windows.Forms.Label()
        Me.DataNumber9 = New System.Windows.Forms.Label()
        Me.DataNumber8 = New System.Windows.Forms.Label()
        Me.DataNumber7 = New System.Windows.Forms.Label()
        Me.DataNumber6 = New System.Windows.Forms.Label()
        Me.DataNumber5 = New System.Windows.Forms.Label()
        Me.DataNumber4 = New System.Windows.Forms.Label()
        Me.DataNumber3 = New System.Windows.Forms.Label()
        Me.DataNumber2 = New System.Windows.Forms.Label()
        Me.DataNumber1 = New System.Windows.Forms.Label()
        Me.DataLabel = New System.Windows.Forms.Label()
        Me.PlaySend = New Guna.UI.WinForms.GunaButton()
        Me.PlayLoading = New Guna.UI.WinForms.GunaWinCircleProgressIndicator()
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl3 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl4 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl5 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PlayPanel = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaElipsePanel3 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.PlayConfiguration = New Guna.UI.WinForms.GunaCircleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PlayPalletControlPanel = New Guna.UI.WinForms.GunaElipsePanel()
        Me.PositionLabel = New System.Windows.Forms.Label()
        Me.PlayControlPosition = New Guna.UI.WinForms.GunaComboBox()
        Me.PlayControlArrange = New Guna.UI.WinForms.GunaButton()
        Me.StackLabel = New System.Windows.Forms.Label()
        Me.PlayControlStack = New Guna.UI.WinForms.GunaComboBox()
        Me.ArrangeLabel = New System.Windows.Forms.Label()
        Me.PlayBoxSizePanel = New Guna.UI.WinForms.GunaElipsePanel()
        Me.BoxHeight = New Guna.UI.WinForms.GunaLineTextBox()
        Me.HeightLabel = New System.Windows.Forms.Label()
        Me.BoxWidth = New Guna.UI.WinForms.GunaLineTextBox()
        Me.WidthLabel = New System.Windows.Forms.Label()
        Me.BoxLength = New Guna.UI.WinForms.GunaLineTextBox()
        Me.LengthLabel = New System.Windows.Forms.Label()
        Me.InputPanel = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.InputGripperAngel = New Guna.UI.WinForms.GunaComboBox()
        Me.GripperLabel = New System.Windows.Forms.Label()
        Me.InputGripperClear = New Guna.UI.WinForms.GunaButton()
        Me.InputGripper = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.InputLabelX = New System.Windows.Forms.Label()
        Me.InputX = New Guna.UI.WinForms.GunaLineTextBox()
        Me.InputLabelY = New System.Windows.Forms.Label()
        Me.InputY = New Guna.UI.WinForms.GunaLineTextBox()
        Me.InputLabelZ = New System.Windows.Forms.Label()
        Me.InputZ = New Guna.UI.WinForms.GunaLineTextBox()
        Me.InputConvert = New Guna.UI.WinForms.GunaButton()
        Me.InputNotif = New System.Windows.Forms.Label()
        Me.BunifuDragControl6 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl7 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.DataLogging = New System.Windows.Forms.TextBox()
        Me.DataLogButton = New Guna.UI.WinForms.GunaButton()
        Me.SideMenu.SuspendLayout()
        Me.PortPanel.SuspendLayout()
        Me.SidePanel.SuspendLayout()
        Me.DataPanel.SuspendLayout()
        Me.DataControlPanel.SuspendLayout()
        Me.DataListPanel.SuspendLayout()
        Me.PlayPanel.SuspendLayout()
        Me.GunaElipsePanel3.SuspendLayout()
        Me.PlayPalletControlPanel.SuspendLayout()
        Me.PlayBoxSizePanel.SuspendLayout()
        Me.InputPanel.SuspendLayout()
        Me.GunaElipsePanel2.SuspendLayout()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifPort
        '
        Me.NotifPort.AutoSize = True
        Me.NotifPort.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotifPort.ForeColor = System.Drawing.Color.White
        Me.NotifPort.Location = New System.Drawing.Point(70, 147)
        Me.NotifPort.Name = "NotifPort"
        Me.NotifPort.Size = New System.Drawing.Size(158, 14)
        Me.NotifPort.TabIndex = 2
        Me.NotifPort.Text = "* Select Port first, please . . ."
        '
        'SideMenu
        '
        Me.SideMenu.Controls.Add(Me.SidePlay)
        Me.SideMenu.Controls.Add(Me.SideInput)
        Me.SideMenu.Controls.Add(Me.SideRecord)
        Me.SideMenu.Location = New System.Drawing.Point(10, 440)
        Me.SideMenu.Name = "SideMenu"
        Me.SideMenu.Size = New System.Drawing.Size(300, 30)
        Me.SideMenu.TabIndex = 0
        '
        'SidePlay
        '
        Me.SidePlay.Animated = True
        Me.SidePlay.AnimationHoverSpeed = 0.07!
        Me.SidePlay.AnimationSpeed = 0.03!
        Me.SidePlay.BackColor = System.Drawing.Color.Transparent
        Me.SidePlay.BaseColor = System.Drawing.Color.DodgerBlue
        Me.SidePlay.BorderColor = System.Drawing.Color.White
        Me.SidePlay.BorderSize = 2
        Me.SidePlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SidePlay.DialogResult = System.Windows.Forms.DialogResult.None
        Me.SidePlay.FocusedColor = System.Drawing.Color.Empty
        Me.SidePlay.Font = New System.Drawing.Font("Ebrima", 10.0!)
        Me.SidePlay.ForeColor = System.Drawing.Color.White
        Me.SidePlay.Image = Nothing
        Me.SidePlay.ImageSize = New System.Drawing.Size(20, 20)
        Me.SidePlay.Location = New System.Drawing.Point(210, 3)
        Me.SidePlay.Name = "SidePlay"
        Me.SidePlay.OnHoverBaseColor = System.Drawing.Color.White
        Me.SidePlay.OnHoverBorderColor = System.Drawing.Color.White
        Me.SidePlay.OnHoverForeColor = System.Drawing.Color.DodgerBlue
        Me.SidePlay.OnHoverImage = Nothing
        Me.SidePlay.OnPressedColor = System.Drawing.SystemColors.Highlight
        Me.SidePlay.Radius = 5
        Me.SidePlay.Size = New System.Drawing.Size(80, 25)
        Me.SidePlay.TabIndex = 3
        Me.SidePlay.Text = "Control"
        Me.SidePlay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SideInput
        '
        Me.SideInput.Animated = True
        Me.SideInput.AnimationHoverSpeed = 0.07!
        Me.SideInput.AnimationSpeed = 0.03!
        Me.SideInput.BackColor = System.Drawing.Color.Transparent
        Me.SideInput.BaseColor = System.Drawing.Color.DodgerBlue
        Me.SideInput.BorderColor = System.Drawing.Color.White
        Me.SideInput.BorderSize = 2
        Me.SideInput.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideInput.DialogResult = System.Windows.Forms.DialogResult.None
        Me.SideInput.FocusedColor = System.Drawing.Color.Empty
        Me.SideInput.Font = New System.Drawing.Font("Ebrima", 10.0!)
        Me.SideInput.ForeColor = System.Drawing.Color.White
        Me.SideInput.Image = Nothing
        Me.SideInput.ImageSize = New System.Drawing.Size(20, 20)
        Me.SideInput.Location = New System.Drawing.Point(110, 4)
        Me.SideInput.Name = "SideInput"
        Me.SideInput.OnHoverBaseColor = System.Drawing.Color.White
        Me.SideInput.OnHoverBorderColor = System.Drawing.Color.White
        Me.SideInput.OnHoverForeColor = System.Drawing.Color.DodgerBlue
        Me.SideInput.OnHoverImage = Nothing
        Me.SideInput.OnPressedColor = System.Drawing.SystemColors.Highlight
        Me.SideInput.Radius = 5
        Me.SideInput.Size = New System.Drawing.Size(80, 25)
        Me.SideInput.TabIndex = 2
        Me.SideInput.Text = "Input"
        Me.SideInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SideRecord
        '
        Me.SideRecord.Animated = True
        Me.SideRecord.AnimationHoverSpeed = 0.07!
        Me.SideRecord.AnimationSpeed = 0.03!
        Me.SideRecord.BackColor = System.Drawing.Color.Transparent
        Me.SideRecord.BaseColor = System.Drawing.Color.DodgerBlue
        Me.SideRecord.BorderColor = System.Drawing.Color.White
        Me.SideRecord.BorderSize = 2
        Me.SideRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideRecord.DialogResult = System.Windows.Forms.DialogResult.None
        Me.SideRecord.FocusedColor = System.Drawing.Color.Empty
        Me.SideRecord.Font = New System.Drawing.Font("Ebrima", 10.0!)
        Me.SideRecord.ForeColor = System.Drawing.Color.White
        Me.SideRecord.Image = Nothing
        Me.SideRecord.ImageSize = New System.Drawing.Size(20, 20)
        Me.SideRecord.Location = New System.Drawing.Point(10, 3)
        Me.SideRecord.Name = "SideRecord"
        Me.SideRecord.OnHoverBaseColor = System.Drawing.Color.White
        Me.SideRecord.OnHoverBorderColor = System.Drawing.Color.White
        Me.SideRecord.OnHoverForeColor = System.Drawing.Color.DodgerBlue
        Me.SideRecord.OnHoverImage = Nothing
        Me.SideRecord.OnPressedColor = System.Drawing.SystemColors.Highlight
        Me.SideRecord.Radius = 5
        Me.SideRecord.Size = New System.Drawing.Size(80, 25)
        Me.SideRecord.TabIndex = 1
        Me.SideRecord.Text = "Record"
        Me.SideRecord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PortPanel
        '
        Me.PortPanel.Controls.Add(Me.ConnectPort)
        Me.PortPanel.Controls.Add(Me.SideRefresh)
        Me.PortPanel.Controls.Add(Me.PortLabel)
        Me.PortPanel.Location = New System.Drawing.Point(4, 48)
        Me.PortPanel.Name = "PortPanel"
        Me.PortPanel.Size = New System.Drawing.Size(310, 50)
        Me.PortPanel.TabIndex = 1
        '
        'ConnectPort
        '
        Me.ConnectPort.BackColor = System.Drawing.Color.Transparent
        Me.ConnectPort.BaseColor = System.Drawing.Color.DodgerBlue
        Me.ConnectPort.BorderColor = System.Drawing.Color.White
        Me.ConnectPort.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConnectPort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ConnectPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ConnectPort.DropDownWidth = 70
        Me.ConnectPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConnectPort.FocusedColor = System.Drawing.Color.Transparent
        Me.ConnectPort.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.ConnectPort.ForeColor = System.Drawing.Color.White
        Me.ConnectPort.Location = New System.Drawing.Point(112, 11)
        Me.ConnectPort.Name = "ConnectPort"
        Me.ConnectPort.OnHoverItemBaseColor = System.Drawing.Color.White
        Me.ConnectPort.OnHoverItemForeColor = System.Drawing.Color.DodgerBlue
        Me.ConnectPort.Radius = 13
        Me.ConnectPort.Size = New System.Drawing.Size(90, 28)
        Me.ConnectPort.Sorted = True
        Me.ConnectPort.TabIndex = 3
        '
        'SideRefresh
        '
        Me.SideRefresh.Animated = True
        Me.SideRefresh.AnimationHoverSpeed = 0.07!
        Me.SideRefresh.AnimationSpeed = 0.03!
        Me.SideRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SideRefresh.BaseColor = System.Drawing.Color.Transparent
        Me.SideRefresh.BorderColor = System.Drawing.Color.White
        Me.SideRefresh.BorderSize = 2
        Me.SideRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideRefresh.DialogResult = System.Windows.Forms.DialogResult.None
        Me.SideRefresh.FocusedColor = System.Drawing.Color.Empty
        Me.SideRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SideRefresh.ForeColor = System.Drawing.Color.White
        Me.SideRefresh.Image = Global.My_Controller_Flat_UI.My.Resources.Resources.Refresh
        Me.SideRefresh.ImageSize = New System.Drawing.Size(21, 21)
        Me.SideRefresh.Location = New System.Drawing.Point(208, 10)
        Me.SideRefresh.Margin = New System.Windows.Forms.Padding(10)
        Me.SideRefresh.Name = "SideRefresh"
        Me.SideRefresh.OnHoverBaseColor = System.Drawing.Color.White
        Me.SideRefresh.OnHoverBorderColor = System.Drawing.Color.White
        Me.SideRefresh.OnHoverForeColor = System.Drawing.Color.DodgerBlue
        Me.SideRefresh.OnHoverImage = Global.My_Controller_Flat_UI.My.Resources.Resources.RefreshX
        Me.SideRefresh.OnPressedColor = System.Drawing.Color.DodgerBlue
        Me.SideRefresh.Size = New System.Drawing.Size(30, 30)
        Me.SideRefresh.TabIndex = 4
        '
        'PortLabel
        '
        Me.PortLabel.AutoSize = True
        Me.PortLabel.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PortLabel.ForeColor = System.Drawing.Color.White
        Me.PortLabel.Location = New System.Drawing.Point(66, 13)
        Me.PortLabel.Name = "PortLabel"
        Me.PortLabel.Size = New System.Drawing.Size(46, 21)
        Me.PortLabel.TabIndex = 2
        Me.PortLabel.Text = "Port :"
        '
        'SideAbout
        '
        Me.SideAbout.Animated = True
        Me.SideAbout.AnimationHoverSpeed = 0.07!
        Me.SideAbout.AnimationSpeed = 0.03!
        Me.SideAbout.BackColor = System.Drawing.Color.Transparent
        Me.SideAbout.BaseColor = System.Drawing.Color.DodgerBlue
        Me.SideAbout.BorderColor = System.Drawing.Color.White
        Me.SideAbout.BorderSize = 2
        Me.SideAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideAbout.DialogResult = System.Windows.Forms.DialogResult.None
        Me.SideAbout.FocusedColor = System.Drawing.Color.Empty
        Me.SideAbout.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.SideAbout.ForeColor = System.Drawing.Color.White
        Me.SideAbout.Image = Nothing
        Me.SideAbout.ImageSize = New System.Drawing.Size(20, 20)
        Me.SideAbout.Location = New System.Drawing.Point(74, 170)
        Me.SideAbout.Name = "SideAbout"
        Me.SideAbout.OnHoverBaseColor = System.Drawing.Color.White
        Me.SideAbout.OnHoverBorderColor = System.Drawing.Color.White
        Me.SideAbout.OnHoverForeColor = System.Drawing.Color.DodgerBlue
        Me.SideAbout.OnHoverImage = Nothing
        Me.SideAbout.OnPressedColor = System.Drawing.SystemColors.Highlight
        Me.SideAbout.Radius = 20
        Me.SideAbout.Size = New System.Drawing.Size(168, 42)
        Me.SideAbout.TabIndex = 1
        Me.SideAbout.Text = "About Me"
        Me.SideAbout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SideConnect
        '
        Me.SideConnect.Animated = True
        Me.SideConnect.AnimationHoverSpeed = 0.07!
        Me.SideConnect.AnimationSpeed = 0.03!
        Me.SideConnect.BackColor = System.Drawing.Color.Transparent
        Me.SideConnect.BaseColor = System.Drawing.Color.DodgerBlue
        Me.SideConnect.BorderColor = System.Drawing.Color.White
        Me.SideConnect.BorderSize = 2
        Me.SideConnect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideConnect.DialogResult = System.Windows.Forms.DialogResult.None
        Me.SideConnect.FocusedColor = System.Drawing.Color.Empty
        Me.SideConnect.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.SideConnect.ForeColor = System.Drawing.Color.White
        Me.SideConnect.Image = Nothing
        Me.SideConnect.ImageSize = New System.Drawing.Size(20, 20)
        Me.SideConnect.Location = New System.Drawing.Point(73, 101)
        Me.SideConnect.Name = "SideConnect"
        Me.SideConnect.OnHoverBaseColor = System.Drawing.Color.White
        Me.SideConnect.OnHoverBorderColor = System.Drawing.Color.White
        Me.SideConnect.OnHoverForeColor = System.Drawing.Color.DodgerBlue
        Me.SideConnect.OnHoverImage = Nothing
        Me.SideConnect.OnPressedColor = System.Drawing.SystemColors.Highlight
        Me.SideConnect.Radius = 20
        Me.SideConnect.Size = New System.Drawing.Size(168, 42)
        Me.SideConnect.TabIndex = 0
        Me.SideConnect.Text = "Connect"
        Me.SideConnect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.SidePanel
        Me.BunifuDragControl1.Vertical = True
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.Transparent
        Me.SidePanel.BaseColor = System.Drawing.Color.DodgerBlue
        Me.SidePanel.Controls.Add(Me.NotifPort)
        Me.SidePanel.Controls.Add(Me.SideBack)
        Me.SidePanel.Controls.Add(Me.SideExit)
        Me.SidePanel.Controls.Add(Me.SideConnect)
        Me.SidePanel.Controls.Add(Me.PortPanel)
        Me.SidePanel.Controls.Add(Me.SideAbout)
        Me.SidePanel.Location = New System.Drawing.Point(15, 15)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Radius = 7
        Me.SidePanel.Size = New System.Drawing.Size(320, 228)
        Me.SidePanel.TabIndex = 3
        '
        'SideBack
        '
        Me.SideBack.Animated = True
        Me.SideBack.AnimationHoverSpeed = 0.07!
        Me.SideBack.AnimationSpeed = 0.03!
        Me.SideBack.BackColor = System.Drawing.Color.Transparent
        Me.SideBack.BaseColor = System.Drawing.Color.DodgerBlue
        Me.SideBack.BorderColor = System.Drawing.Color.White
        Me.SideBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideBack.DialogResult = System.Windows.Forms.DialogResult.None
        Me.SideBack.FocusedColor = System.Drawing.Color.Empty
        Me.SideBack.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.SideBack.ForeColor = System.Drawing.Color.White
        Me.SideBack.Image = Global.My_Controller_Flat_UI.My.Resources.Resources.Back
        Me.SideBack.ImageOffsetX = -8
        Me.SideBack.ImageSize = New System.Drawing.Size(16, 16)
        Me.SideBack.Location = New System.Drawing.Point(5, 5)
        Me.SideBack.Name = "SideBack"
        Me.SideBack.OnHoverBaseColor = System.Drawing.Color.White
        Me.SideBack.OnHoverBorderColor = System.Drawing.Color.White
        Me.SideBack.OnHoverForeColor = System.Drawing.Color.DodgerBlue
        Me.SideBack.OnHoverImage = Global.My_Controller_Flat_UI.My.Resources.Resources.BackX
        Me.SideBack.OnPressedColor = System.Drawing.SystemColors.Highlight
        Me.SideBack.Radius = 4
        Me.SideBack.Size = New System.Drawing.Size(62, 30)
        Me.SideBack.TabIndex = 5
        Me.SideBack.Text = "Back"
        Me.SideBack.TextOffsetX = -9
        '
        'SideExit
        '
        Me.SideExit.Animated = True
        Me.SideExit.AnimationHoverSpeed = 0.07!
        Me.SideExit.AnimationSpeed = 0.03!
        Me.SideExit.BackColor = System.Drawing.Color.Transparent
        Me.SideExit.BaseColor = System.Drawing.Color.DodgerBlue
        Me.SideExit.BorderColor = System.Drawing.Color.White
        Me.SideExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideExit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.SideExit.FocusedColor = System.Drawing.Color.Empty
        Me.SideExit.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.SideExit.ForeColor = System.Drawing.Color.White
        Me.SideExit.Image = Global.My_Controller_Flat_UI.My.Resources.Resources._Exit
        Me.SideExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SideExit.ImageOffsetX = -6
        Me.SideExit.ImageSize = New System.Drawing.Size(22, 22)
        Me.SideExit.Location = New System.Drawing.Point(244, 3)
        Me.SideExit.Name = "SideExit"
        Me.SideExit.OnHoverBaseColor = System.Drawing.Color.White
        Me.SideExit.OnHoverBorderColor = System.Drawing.Color.White
        Me.SideExit.OnHoverForeColor = System.Drawing.Color.DodgerBlue
        Me.SideExit.OnHoverImage = Global.My_Controller_Flat_UI.My.Resources.Resources.ExitX
        Me.SideExit.OnPressedColor = System.Drawing.SystemColors.Highlight
        Me.SideExit.Radius = 4
        Me.SideExit.Size = New System.Drawing.Size(63, 30)
        Me.SideExit.TabIndex = 4
        Me.SideExit.Text = "Exit"
        Me.SideExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Timer1
        '
        '
        'MyPort
        '
        Me.MyPort.PortName = " "
        '
        'Data1
        '
        Me.Data1.Animated = True
        Me.Data1.AnimationHoverSpeed = 0.07!
        Me.Data1.AnimationSpeed = 0.03!
        Me.Data1.BackColor = System.Drawing.Color.Transparent
        Me.Data1.BaseColor = System.Drawing.Color.Transparent
        Me.Data1.BorderColor = System.Drawing.Color.White
        Me.Data1.BorderSize = 2
        Me.Data1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Data1.FocusedColor = System.Drawing.Color.Empty
        Me.Data1.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Data1.ForeColor = System.Drawing.Color.White
        Me.Data1.Image = Nothing
        Me.Data1.ImageSize = New System.Drawing.Size(20, 20)
        Me.Data1.Location = New System.Drawing.Point(24, 9)
        Me.Data1.Name = "Data1"
        Me.Data1.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.Data1.OnHoverBorderColor = System.Drawing.Color.White
        Me.Data1.OnHoverForeColor = System.Drawing.Color.White
        Me.Data1.OnHoverImage = Nothing
        Me.Data1.OnPressedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Data1.Radius = 15
        Me.Data1.Size = New System.Drawing.Size(160, 32)
        Me.Data1.TabIndex = 11
        Me.Data1.Text = "No data"
        Me.Data1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RecordGetData
        '
        Me.RecordGetData.Animated = True
        Me.RecordGetData.AnimationHoverSpeed = 0.07!
        Me.RecordGetData.AnimationSpeed = 0.03!
        Me.RecordGetData.BackColor = System.Drawing.Color.Transparent
        Me.RecordGetData.BaseColor = System.Drawing.Color.White
        Me.RecordGetData.BorderColor = System.Drawing.Color.DodgerBlue
        Me.RecordGetData.BorderSize = 2
        Me.RecordGetData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RecordGetData.DialogResult = System.Windows.Forms.DialogResult.None
        Me.RecordGetData.FocusedColor = System.Drawing.Color.Empty
        Me.RecordGetData.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.RecordGetData.ForeColor = System.Drawing.Color.DodgerBlue
        Me.RecordGetData.Image = Nothing
        Me.RecordGetData.ImageSize = New System.Drawing.Size(20, 20)
        Me.RecordGetData.Location = New System.Drawing.Point(62, 269)
        Me.RecordGetData.Name = "RecordGetData"
        Me.RecordGetData.OnHoverBaseColor = System.Drawing.Color.DodgerBlue
        Me.RecordGetData.OnHoverBorderColor = System.Drawing.Color.DodgerBlue
        Me.RecordGetData.OnHoverForeColor = System.Drawing.Color.White
        Me.RecordGetData.OnHoverImage = Nothing
        Me.RecordGetData.OnPressedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RecordGetData.Radius = 10
        Me.RecordGetData.Size = New System.Drawing.Size(220, 42)
        Me.RecordGetData.TabIndex = 4
        Me.RecordGetData.Text = "Get Data"
        Me.RecordGetData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataPanel
        '
        Me.DataPanel.BackColor = System.Drawing.Color.Transparent
        Me.DataPanel.BaseColor = System.Drawing.Color.DodgerBlue
        Me.DataPanel.Controls.Add(Me.SideMenu)
        Me.DataPanel.Controls.Add(Me.DataControlPanel)
        Me.DataPanel.Controls.Add(Me.ActionLabel)
        Me.DataPanel.Controls.Add(Me.DataListPanel)
        Me.DataPanel.Controls.Add(Me.DataLabel)
        Me.DataPanel.Location = New System.Drawing.Point(358, 11)
        Me.DataPanel.Name = "DataPanel"
        Me.DataPanel.Radius = 7
        Me.DataPanel.Size = New System.Drawing.Size(320, 481)
        Me.DataPanel.TabIndex = 5
        '
        'DataControlPanel
        '
        Me.DataControlPanel.BackColor = System.Drawing.Color.Transparent
        Me.DataControlPanel.BaseColor = System.Drawing.Color.Transparent
        Me.DataControlPanel.Controls.Add(Me.DataControlUp)
        Me.DataControlPanel.Controls.Add(Me.DataControlDown)
        Me.DataControlPanel.Controls.Add(Me.DataControlErase)
        Me.DataControlPanel.Location = New System.Drawing.Point(10, 385)
        Me.DataControlPanel.Name = "DataControlPanel"
        Me.DataControlPanel.Size = New System.Drawing.Size(300, 50)
        Me.DataControlPanel.TabIndex = 26
        '
        'DataControlUp
        '
        Me.DataControlUp.Animated = True
        Me.DataControlUp.AnimationHoverSpeed = 0.07!
        Me.DataControlUp.AnimationSpeed = 0.03!
        Me.DataControlUp.BaseColor = System.Drawing.Color.DodgerBlue
        Me.DataControlUp.BorderColor = System.Drawing.Color.White
        Me.DataControlUp.BorderSize = 2
        Me.DataControlUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataControlUp.DialogResult = System.Windows.Forms.DialogResult.None
        Me.DataControlUp.FocusedColor = System.Drawing.Color.Empty
        Me.DataControlUp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DataControlUp.ForeColor = System.Drawing.Color.White
        Me.DataControlUp.Image = Global.My_Controller_Flat_UI.My.Resources.Resources.Up
        Me.DataControlUp.ImageSize = New System.Drawing.Size(30, 30)
        Me.DataControlUp.Location = New System.Drawing.Point(10, 4)
        Me.DataControlUp.Name = "DataControlUp"
        Me.DataControlUp.OnHoverBaseColor = System.Drawing.Color.White
        Me.DataControlUp.OnHoverBorderColor = System.Drawing.Color.White
        Me.DataControlUp.OnHoverForeColor = System.Drawing.Color.White
        Me.DataControlUp.OnHoverImage = Global.My_Controller_Flat_UI.My.Resources.Resources.UpX
        Me.DataControlUp.OnPressedColor = System.Drawing.Color.DodgerBlue
        Me.DataControlUp.Size = New System.Drawing.Size(40, 40)
        Me.DataControlUp.TabIndex = 22
        '
        'DataControlDown
        '
        Me.DataControlDown.Animated = True
        Me.DataControlDown.AnimationHoverSpeed = 0.07!
        Me.DataControlDown.AnimationSpeed = 0.03!
        Me.DataControlDown.BaseColor = System.Drawing.Color.DodgerBlue
        Me.DataControlDown.BorderColor = System.Drawing.Color.White
        Me.DataControlDown.BorderSize = 2
        Me.DataControlDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataControlDown.DialogResult = System.Windows.Forms.DialogResult.None
        Me.DataControlDown.FocusedColor = System.Drawing.Color.Empty
        Me.DataControlDown.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DataControlDown.ForeColor = System.Drawing.Color.White
        Me.DataControlDown.Image = Global.My_Controller_Flat_UI.My.Resources.Resources.Down
        Me.DataControlDown.ImageSize = New System.Drawing.Size(30, 30)
        Me.DataControlDown.Location = New System.Drawing.Point(60, 4)
        Me.DataControlDown.Name = "DataControlDown"
        Me.DataControlDown.OnHoverBaseColor = System.Drawing.Color.White
        Me.DataControlDown.OnHoverBorderColor = System.Drawing.Color.White
        Me.DataControlDown.OnHoverForeColor = System.Drawing.Color.White
        Me.DataControlDown.OnHoverImage = Global.My_Controller_Flat_UI.My.Resources.Resources.DownX
        Me.DataControlDown.OnPressedColor = System.Drawing.Color.DodgerBlue
        Me.DataControlDown.Size = New System.Drawing.Size(40, 40)
        Me.DataControlDown.TabIndex = 23
        '
        'DataControlErase
        '
        Me.DataControlErase.Animated = True
        Me.DataControlErase.AnimationHoverSpeed = 0.07!
        Me.DataControlErase.AnimationSpeed = 0.03!
        Me.DataControlErase.BackColor = System.Drawing.Color.Transparent
        Me.DataControlErase.BaseColor = System.Drawing.Color.DodgerBlue
        Me.DataControlErase.BorderColor = System.Drawing.Color.White
        Me.DataControlErase.BorderSize = 2
        Me.DataControlErase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataControlErase.DialogResult = System.Windows.Forms.DialogResult.None
        Me.DataControlErase.FocusedColor = System.Drawing.Color.Empty
        Me.DataControlErase.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.DataControlErase.ForeColor = System.Drawing.Color.White
        Me.DataControlErase.Image = Global.My_Controller_Flat_UI.My.Resources.Resources._Erase
        Me.DataControlErase.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataControlErase.ImageOffsetX = 9
        Me.DataControlErase.ImageSize = New System.Drawing.Size(30, 30)
        Me.DataControlErase.Location = New System.Drawing.Point(110, 4)
        Me.DataControlErase.Name = "DataControlErase"
        Me.DataControlErase.OnHoverBaseColor = System.Drawing.Color.White
        Me.DataControlErase.OnHoverBorderColor = System.Drawing.Color.White
        Me.DataControlErase.OnHoverForeColor = System.Drawing.Color.DodgerBlue
        Me.DataControlErase.OnHoverImage = Global.My_Controller_Flat_UI.My.Resources.Resources.EraseX
        Me.DataControlErase.OnPressedColor = System.Drawing.SystemColors.Highlight
        Me.DataControlErase.Radius = 20
        Me.DataControlErase.Size = New System.Drawing.Size(180, 42)
        Me.DataControlErase.TabIndex = 3
        Me.DataControlErase.Text = "Erase"
        Me.DataControlErase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataControlErase.TextOffsetX = -5
        '
        'ActionLabel
        '
        Me.ActionLabel.AutoSize = True
        Me.ActionLabel.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActionLabel.ForeColor = System.Drawing.Color.White
        Me.ActionLabel.Location = New System.Drawing.Point(216, 7)
        Me.ActionLabel.Name = "ActionLabel"
        Me.ActionLabel.Size = New System.Drawing.Size(70, 25)
        Me.ActionLabel.TabIndex = 27
        Me.ActionLabel.Text = "Action"
        '
        'DataListPanel
        '
        Me.DataListPanel.AutoScroll = True
        Me.DataListPanel.AutoScrollMargin = New System.Drawing.Size(2, 2)
        Me.DataListPanel.BackColor = System.Drawing.Color.Transparent
        Me.DataListPanel.Controls.Add(Me.Action10)
        Me.DataListPanel.Controls.Add(Me.Action9)
        Me.DataListPanel.Controls.Add(Me.Action8)
        Me.DataListPanel.Controls.Add(Me.Action7)
        Me.DataListPanel.Controls.Add(Me.Action6)
        Me.DataListPanel.Controls.Add(Me.Action5)
        Me.DataListPanel.Controls.Add(Me.Action4)
        Me.DataListPanel.Controls.Add(Me.Action3)
        Me.DataListPanel.Controls.Add(Me.Action2)
        Me.DataListPanel.Controls.Add(Me.Action1)
        Me.DataListPanel.Controls.Add(Me.Data10)
        Me.DataListPanel.Controls.Add(Me.Data9)
        Me.DataListPanel.Controls.Add(Me.Data8)
        Me.DataListPanel.Controls.Add(Me.Data7)
        Me.DataListPanel.Controls.Add(Me.Data6)
        Me.DataListPanel.Controls.Add(Me.Data5)
        Me.DataListPanel.Controls.Add(Me.Data4)
        Me.DataListPanel.Controls.Add(Me.Data3)
        Me.DataListPanel.Controls.Add(Me.Data2)
        Me.DataListPanel.Controls.Add(Me.Data1)
        Me.DataListPanel.Controls.Add(Me.DataNumber10)
        Me.DataListPanel.Controls.Add(Me.DataNumber9)
        Me.DataListPanel.Controls.Add(Me.DataNumber8)
        Me.DataListPanel.Controls.Add(Me.DataNumber7)
        Me.DataListPanel.Controls.Add(Me.DataNumber6)
        Me.DataListPanel.Controls.Add(Me.DataNumber5)
        Me.DataListPanel.Controls.Add(Me.DataNumber4)
        Me.DataListPanel.Controls.Add(Me.DataNumber3)
        Me.DataListPanel.Controls.Add(Me.DataNumber2)
        Me.DataListPanel.Controls.Add(Me.DataNumber1)
        Me.DataListPanel.GradientColor1 = System.Drawing.Color.Transparent
        Me.DataListPanel.GradientColor2 = System.Drawing.Color.Transparent
        Me.DataListPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.DataListPanel.Location = New System.Drawing.Point(10, 35)
        Me.DataListPanel.Name = "DataListPanel"
        Me.DataListPanel.Size = New System.Drawing.Size(310, 340)
        Me.DataListPanel.TabIndex = 25
        '
        'Action10
        '
        Me.Action10.Animated = True
        Me.Action10.AnimationHoverSpeed = 0.07!
        Me.Action10.AnimationSpeed = 0.03!
        Me.Action10.BackColor = System.Drawing.Color.Transparent
        Me.Action10.BaseColor = System.Drawing.Color.Transparent
        Me.Action10.BorderColor = System.Drawing.Color.White
        Me.Action10.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Action10.FocusedColor = System.Drawing.Color.Empty
        Me.Action10.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Action10.ForeColor = System.Drawing.Color.Transparent
        Me.Action10.Image = Nothing
        Me.Action10.ImageSize = New System.Drawing.Size(20, 20)
        Me.Action10.Location = New System.Drawing.Point(195, 297)
        Me.Action10.Name = "Action10"
        Me.Action10.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.Action10.OnHoverBorderColor = System.Drawing.Color.White
        Me.Action10.OnHoverForeColor = System.Drawing.Color.White
        Me.Action10.OnHoverImage = Nothing
        Me.Action10.OnPressedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Action10.Radius = 15
        Me.Action10.Size = New System.Drawing.Size(94, 32)
        Me.Action10.TabIndex = 29
        Me.Action10.Text = "-"
        Me.Action10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Action9
        '
        Me.Action9.Animated = True
        Me.Action9.AnimationHoverSpeed = 0.07!
        Me.Action9.AnimationSpeed = 0.03!
        Me.Action9.BackColor = System.Drawing.Color.Transparent
        Me.Action9.BaseColor = System.Drawing.Color.Transparent
        Me.Action9.BorderColor = System.Drawing.Color.White
        Me.Action9.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Action9.FocusedColor = System.Drawing.Color.Empty
        Me.Action9.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Action9.ForeColor = System.Drawing.Color.Transparent
        Me.Action9.Image = Nothing
        Me.Action9.ImageSize = New System.Drawing.Size(20, 20)
        Me.Action9.Location = New System.Drawing.Point(195, 265)
        Me.Action9.Name = "Action9"
        Me.Action9.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.Action9.OnHoverBorderColor = System.Drawing.Color.White
        Me.Action9.OnHoverForeColor = System.Drawing.Color.White
        Me.Action9.OnHoverImage = Nothing
        Me.Action9.OnPressedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Action9.Radius = 15
        Me.Action9.Size = New System.Drawing.Size(94, 32)
        Me.Action9.TabIndex = 28
        Me.Action9.Text = "-"
        Me.Action9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Action8
        '
        Me.Action8.Animated = True
        Me.Action8.AnimationHoverSpeed = 0.07!
        Me.Action8.AnimationSpeed = 0.03!
        Me.Action8.BackColor = System.Drawing.Color.Transparent
        Me.Action8.BaseColor = System.Drawing.Color.Transparent
        Me.Action8.BorderColor = System.Drawing.Color.White
        Me.Action8.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Action8.FocusedColor = System.Drawing.Color.Empty
        Me.Action8.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Action8.ForeColor = System.Drawing.Color.Transparent
        Me.Action8.Image = Nothing
        Me.Action8.ImageSize = New System.Drawing.Size(20, 20)
        Me.Action8.Location = New System.Drawing.Point(195, 233)
        Me.Action8.Name = "Action8"
        Me.Action8.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.Action8.OnHoverBorderColor = System.Drawing.Color.White
        Me.Action8.OnHoverForeColor = System.Drawing.Color.White
        Me.Action8.OnHoverImage = Nothing
        Me.Action8.OnPressedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Action8.Radius = 15
        Me.Action8.Size = New System.Drawing.Size(94, 32)
        Me.Action8.TabIndex = 27
        Me.Action8.Text = "-"
        Me.Action8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Action7
        '
        Me.Action7.Animated = True
        Me.Action7.AnimationHoverSpeed = 0.07!
        Me.Action7.AnimationSpeed = 0.03!
        Me.Action7.BackColor = System.Drawing.Color.Transparent
        Me.Action7.BaseColor = System.Drawing.Color.Transparent
        Me.Action7.BorderColor = System.Drawing.Color.White
        Me.Action7.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Action7.FocusedColor = System.Drawing.Color.Empty
        Me.Action7.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Action7.ForeColor = System.Drawing.Color.Transparent
        Me.Action7.Image = Nothing
        Me.Action7.ImageSize = New System.Drawing.Size(20, 20)
        Me.Action7.Location = New System.Drawing.Point(195, 201)
        Me.Action7.Name = "Action7"
        Me.Action7.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.Action7.OnHoverBorderColor = System.Drawing.Color.White
        Me.Action7.OnHoverForeColor = System.Drawing.Color.White
        Me.Action7.OnHoverImage = Nothing
        Me.Action7.OnPressedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Action7.Radius = 15
        Me.Action7.Size = New System.Drawing.Size(94, 32)
        Me.Action7.TabIndex = 26
        Me.Action7.Text = "-"
        Me.Action7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Action6
        '
        Me.Action6.Animated = True
        Me.Action6.AnimationHoverSpeed = 0.07!
        Me.Action6.AnimationSpeed = 0.03!
        Me.Action6.BackColor = System.Drawing.Color.Transparent
        Me.Action6.BaseColor = System.Drawing.Color.Transparent
        Me.Action6.BorderColor = System.Drawing.Color.White
        Me.Action6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Action6.FocusedColor = System.Drawing.Color.Empty
        Me.Action6.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Action6.ForeColor = System.Drawing.Color.Transparent
        Me.Action6.Image = Nothing
        Me.Action6.ImageSize = New System.Drawing.Size(20, 20)
        Me.Action6.Location = New System.Drawing.Point(195, 169)
        Me.Action6.Name = "Action6"
        Me.Action6.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.Action6.OnHoverBorderColor = System.Drawing.Color.White
        Me.Action6.OnHoverForeColor = System.Drawing.Color.White
        Me.Action6.OnHoverImage = Nothing
        Me.Action6.OnPressedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Action6.Radius = 15
        Me.Action6.Size = New System.Drawing.Size(94, 32)
        Me.Action6.TabIndex = 25
        Me.Action6.Text = "-"
        Me.Action6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Action5
        '
        Me.Action5.Animated = True
        Me.Action5.AnimationHoverSpeed = 0.07!
        Me.Action5.AnimationSpeed = 0.03!
        Me.Action5.BackColor = System.Drawing.Color.Transparent
        Me.Action5.BaseColor = System.Drawing.Color.Transparent
        Me.Action5.BorderColor = System.Drawing.Color.White
        Me.Action5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Action5.FocusedColor = System.Drawing.Color.Empty
        Me.Action5.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Action5.ForeColor = System.Drawing.Color.Transparent
        Me.Action5.Image = Nothing
        Me.Action5.ImageSize = New System.Drawing.Size(20, 20)
        Me.Action5.Location = New System.Drawing.Point(195, 137)
        Me.Action5.Name = "Action5"
        Me.Action5.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.Action5.OnHoverBorderColor = System.Drawing.Color.White
        Me.Action5.OnHoverForeColor = System.Drawing.Color.White
        Me.Action5.OnHoverImage = Nothing
        Me.Action5.OnPressedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Action5.Radius = 15
        Me.Action5.Size = New System.Drawing.Size(94, 32)
        Me.Action5.TabIndex = 24
        Me.Action5.Text = "-"
        Me.Action5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Action4
        '
        Me.Action4.Animated = True
        Me.Action4.AnimationHoverSpeed = 0.07!
        Me.Action4.AnimationSpeed = 0.03!
        Me.Action4.BackColor = System.Drawing.Color.Transparent
        Me.Action4.BaseColor = System.Drawing.Color.Transparent
        Me.Action4.BorderColor = System.Drawing.Color.White
        Me.Action4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Action4.FocusedColor = System.Drawing.Color.Empty
        Me.Action4.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Action4.ForeColor = System.Drawing.Color.Transparent
        Me.Action4.Image = Nothing
        Me.Action4.ImageSize = New System.Drawing.Size(20, 20)
        Me.Action4.Location = New System.Drawing.Point(195, 105)
        Me.Action4.Name = "Action4"
        Me.Action4.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.Action4.OnHoverBorderColor = System.Drawing.Color.White
        Me.Action4.OnHoverForeColor = System.Drawing.Color.White
        Me.Action4.OnHoverImage = Nothing
        Me.Action4.OnPressedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Action4.Radius = 15
        Me.Action4.Size = New System.Drawing.Size(94, 32)
        Me.Action4.TabIndex = 21
        Me.Action4.Text = "-"
        Me.Action4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Action3
        '
        Me.Action3.Animated = True
        Me.Action3.AnimationHoverSpeed = 0.07!
        Me.Action3.AnimationSpeed = 0.03!
        Me.Action3.BackColor = System.Drawing.Color.Transparent
        Me.Action3.BaseColor = System.Drawing.Color.Transparent
        Me.Action3.BorderColor = System.Drawing.Color.White
        Me.Action3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Action3.FocusedColor = System.Drawing.Color.Empty
        Me.Action3.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Action3.ForeColor = System.Drawing.Color.Transparent
        Me.Action3.Image = Nothing
        Me.Action3.ImageSize = New System.Drawing.Size(20, 20)
        Me.Action3.Location = New System.Drawing.Point(195, 73)
        Me.Action3.Name = "Action3"
        Me.Action3.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.Action3.OnHoverBorderColor = System.Drawing.Color.White
        Me.Action3.OnHoverForeColor = System.Drawing.Color.White
        Me.Action3.OnHoverImage = Nothing
        Me.Action3.OnPressedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Action3.Radius = 15
        Me.Action3.Size = New System.Drawing.Size(94, 32)
        Me.Action3.TabIndex = 23
        Me.Action3.Text = "-"
        Me.Action3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Action2
        '
        Me.Action2.Animated = True
        Me.Action2.AnimationHoverSpeed = 0.07!
        Me.Action2.AnimationSpeed = 0.03!
        Me.Action2.BackColor = System.Drawing.Color.Transparent
        Me.Action2.BaseColor = System.Drawing.Color.Transparent
        Me.Action2.BorderColor = System.Drawing.Color.White
        Me.Action2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Action2.FocusedColor = System.Drawing.Color.Empty
        Me.Action2.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Action2.ForeColor = System.Drawing.Color.Transparent
        Me.Action2.Image = Nothing
        Me.Action2.ImageSize = New System.Drawing.Size(20, 20)
        Me.Action2.Location = New System.Drawing.Point(195, 41)
        Me.Action2.Name = "Action2"
        Me.Action2.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.Action2.OnHoverBorderColor = System.Drawing.Color.White
        Me.Action2.OnHoverForeColor = System.Drawing.Color.White
        Me.Action2.OnHoverImage = Nothing
        Me.Action2.OnPressedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Action2.Radius = 15
        Me.Action2.Size = New System.Drawing.Size(94, 32)
        Me.Action2.TabIndex = 22
        Me.Action2.Text = "-"
        Me.Action2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Action1
        '
        Me.Action1.Animated = True
        Me.Action1.AnimationHoverSpeed = 0.07!
        Me.Action1.AnimationSpeed = 0.03!
        Me.Action1.BackColor = System.Drawing.Color.Transparent
        Me.Action1.BaseColor = System.Drawing.Color.Transparent
        Me.Action1.BorderColor = System.Drawing.Color.White
        Me.Action1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Action1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Action1.FocusedColor = System.Drawing.Color.Empty
        Me.Action1.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Action1.ForeColor = System.Drawing.Color.Transparent
        Me.Action1.Image = Nothing
        Me.Action1.ImageSize = New System.Drawing.Size(20, 20)
        Me.Action1.Location = New System.Drawing.Point(195, 9)
        Me.Action1.Name = "Action1"
        Me.Action1.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.Action1.OnHoverBorderColor = System.Drawing.Color.White
        Me.Action1.OnHoverForeColor = System.Drawing.Color.White
        Me.Action1.OnHoverImage = Nothing
        Me.Action1.OnPressedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Action1.Radius = 15
        Me.Action1.Size = New System.Drawing.Size(94, 32)
        Me.Action1.TabIndex = 20
        Me.Action1.Text = "-"
        Me.Action1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Data10
        '
        Me.Data10.Animated = True
        Me.Data10.AnimationHoverSpeed = 0.07!
        Me.Data10.AnimationSpeed = 0.03!
        Me.Data10.BackColor = System.Drawing.Color.Transparent
        Me.Data10.BaseColor = System.Drawing.Color.Transparent
        Me.Data10.BorderColor = System.Drawing.Color.White
        Me.Data10.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Data10.FocusedColor = System.Drawing.Color.Empty
        Me.Data10.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Data10.ForeColor = System.Drawing.Color.Transparent
        Me.Data10.Image = Nothing
        Me.Data10.ImageSize = New System.Drawing.Size(20, 20)
        Me.Data10.Location = New System.Drawing.Point(24, 297)
        Me.Data10.Name = "Data10"
        Me.Data10.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.Data10.OnHoverBorderColor = System.Drawing.Color.White
        Me.Data10.OnHoverForeColor = System.Drawing.Color.White
        Me.Data10.OnHoverImage = Nothing
        Me.Data10.OnPressedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Data10.Radius = 15
        Me.Data10.Size = New System.Drawing.Size(160, 32)
        Me.Data10.TabIndex = 19
        Me.Data10.Text = "No data"
        Me.Data10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Data9
        '
        Me.Data9.Animated = True
        Me.Data9.AnimationHoverSpeed = 0.07!
        Me.Data9.AnimationSpeed = 0.03!
        Me.Data9.BackColor = System.Drawing.Color.Transparent
        Me.Data9.BaseColor = System.Drawing.Color.Transparent
        Me.Data9.BorderColor = System.Drawing.Color.White
        Me.Data9.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Data9.FocusedColor = System.Drawing.Color.Empty
        Me.Data9.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Data9.ForeColor = System.Drawing.Color.Transparent
        Me.Data9.Image = Nothing
        Me.Data9.ImageSize = New System.Drawing.Size(20, 20)
        Me.Data9.Location = New System.Drawing.Point(24, 265)
        Me.Data9.Name = "Data9"
        Me.Data9.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.Data9.OnHoverBorderColor = System.Drawing.Color.White
        Me.Data9.OnHoverForeColor = System.Drawing.Color.White
        Me.Data9.OnHoverImage = Nothing
        Me.Data9.OnPressedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Data9.Radius = 15
        Me.Data9.Size = New System.Drawing.Size(160, 32)
        Me.Data9.TabIndex = 18
        Me.Data9.Text = "No data"
        Me.Data9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Data8
        '
        Me.Data8.Animated = True
        Me.Data8.AnimationHoverSpeed = 0.07!
        Me.Data8.AnimationSpeed = 0.03!
        Me.Data8.BackColor = System.Drawing.Color.Transparent
        Me.Data8.BaseColor = System.Drawing.Color.Transparent
        Me.Data8.BorderColor = System.Drawing.Color.White
        Me.Data8.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Data8.FocusedColor = System.Drawing.Color.Empty
        Me.Data8.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Data8.ForeColor = System.Drawing.Color.Transparent
        Me.Data8.Image = Nothing
        Me.Data8.ImageSize = New System.Drawing.Size(20, 20)
        Me.Data8.Location = New System.Drawing.Point(24, 233)
        Me.Data8.Name = "Data8"
        Me.Data8.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.Data8.OnHoverBorderColor = System.Drawing.Color.White
        Me.Data8.OnHoverForeColor = System.Drawing.Color.White
        Me.Data8.OnHoverImage = Nothing
        Me.Data8.OnPressedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Data8.Radius = 15
        Me.Data8.Size = New System.Drawing.Size(160, 32)
        Me.Data8.TabIndex = 17
        Me.Data8.Text = "No data"
        Me.Data8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Data7
        '
        Me.Data7.Animated = True
        Me.Data7.AnimationHoverSpeed = 0.07!
        Me.Data7.AnimationSpeed = 0.03!
        Me.Data7.BackColor = System.Drawing.Color.Transparent
        Me.Data7.BaseColor = System.Drawing.Color.Transparent
        Me.Data7.BorderColor = System.Drawing.Color.White
        Me.Data7.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Data7.FocusedColor = System.Drawing.Color.Empty
        Me.Data7.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Data7.ForeColor = System.Drawing.Color.Transparent
        Me.Data7.Image = Nothing
        Me.Data7.ImageSize = New System.Drawing.Size(20, 20)
        Me.Data7.Location = New System.Drawing.Point(24, 201)
        Me.Data7.Name = "Data7"
        Me.Data7.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.Data7.OnHoverBorderColor = System.Drawing.Color.White
        Me.Data7.OnHoverForeColor = System.Drawing.Color.White
        Me.Data7.OnHoverImage = Nothing
        Me.Data7.OnPressedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Data7.Radius = 15
        Me.Data7.Size = New System.Drawing.Size(160, 32)
        Me.Data7.TabIndex = 16
        Me.Data7.Text = "No data"
        Me.Data7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Data6
        '
        Me.Data6.Animated = True
        Me.Data6.AnimationHoverSpeed = 0.07!
        Me.Data6.AnimationSpeed = 0.03!
        Me.Data6.BackColor = System.Drawing.Color.Transparent
        Me.Data6.BaseColor = System.Drawing.Color.Transparent
        Me.Data6.BorderColor = System.Drawing.Color.White
        Me.Data6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Data6.FocusedColor = System.Drawing.Color.Empty
        Me.Data6.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Data6.ForeColor = System.Drawing.Color.Transparent
        Me.Data6.Image = Nothing
        Me.Data6.ImageSize = New System.Drawing.Size(20, 20)
        Me.Data6.Location = New System.Drawing.Point(24, 169)
        Me.Data6.Name = "Data6"
        Me.Data6.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.Data6.OnHoverBorderColor = System.Drawing.Color.White
        Me.Data6.OnHoverForeColor = System.Drawing.Color.White
        Me.Data6.OnHoverImage = Nothing
        Me.Data6.OnPressedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Data6.Radius = 15
        Me.Data6.Size = New System.Drawing.Size(160, 32)
        Me.Data6.TabIndex = 15
        Me.Data6.Text = "No data"
        Me.Data6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Data5
        '
        Me.Data5.Animated = True
        Me.Data5.AnimationHoverSpeed = 0.07!
        Me.Data5.AnimationSpeed = 0.03!
        Me.Data5.BackColor = System.Drawing.Color.Transparent
        Me.Data5.BaseColor = System.Drawing.Color.Transparent
        Me.Data5.BorderColor = System.Drawing.Color.White
        Me.Data5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Data5.FocusedColor = System.Drawing.Color.Empty
        Me.Data5.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Data5.ForeColor = System.Drawing.Color.Transparent
        Me.Data5.Image = Nothing
        Me.Data5.ImageSize = New System.Drawing.Size(20, 20)
        Me.Data5.Location = New System.Drawing.Point(24, 137)
        Me.Data5.Name = "Data5"
        Me.Data5.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.Data5.OnHoverBorderColor = System.Drawing.Color.White
        Me.Data5.OnHoverForeColor = System.Drawing.Color.White
        Me.Data5.OnHoverImage = Nothing
        Me.Data5.OnPressedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Data5.Radius = 15
        Me.Data5.Size = New System.Drawing.Size(160, 32)
        Me.Data5.TabIndex = 14
        Me.Data5.Text = "No data"
        Me.Data5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Data4
        '
        Me.Data4.Animated = True
        Me.Data4.AnimationHoverSpeed = 0.07!
        Me.Data4.AnimationSpeed = 0.03!
        Me.Data4.BackColor = System.Drawing.Color.Transparent
        Me.Data4.BaseColor = System.Drawing.Color.Transparent
        Me.Data4.BorderColor = System.Drawing.Color.White
        Me.Data4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Data4.FocusedColor = System.Drawing.Color.Empty
        Me.Data4.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Data4.ForeColor = System.Drawing.Color.Transparent
        Me.Data4.Image = Nothing
        Me.Data4.ImageSize = New System.Drawing.Size(20, 20)
        Me.Data4.Location = New System.Drawing.Point(24, 105)
        Me.Data4.Name = "Data4"
        Me.Data4.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.Data4.OnHoverBorderColor = System.Drawing.Color.White
        Me.Data4.OnHoverForeColor = System.Drawing.Color.White
        Me.Data4.OnHoverImage = Nothing
        Me.Data4.OnPressedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Data4.Radius = 15
        Me.Data4.Size = New System.Drawing.Size(160, 32)
        Me.Data4.TabIndex = 12
        Me.Data4.Text = "No data"
        Me.Data4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Data3
        '
        Me.Data3.Animated = True
        Me.Data3.AnimationHoverSpeed = 0.07!
        Me.Data3.AnimationSpeed = 0.03!
        Me.Data3.BackColor = System.Drawing.Color.Transparent
        Me.Data3.BaseColor = System.Drawing.Color.Transparent
        Me.Data3.BorderColor = System.Drawing.Color.White
        Me.Data3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Data3.FocusedColor = System.Drawing.Color.Empty
        Me.Data3.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Data3.ForeColor = System.Drawing.Color.Transparent
        Me.Data3.Image = Nothing
        Me.Data3.ImageSize = New System.Drawing.Size(20, 20)
        Me.Data3.Location = New System.Drawing.Point(24, 73)
        Me.Data3.Name = "Data3"
        Me.Data3.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.Data3.OnHoverBorderColor = System.Drawing.Color.White
        Me.Data3.OnHoverForeColor = System.Drawing.Color.White
        Me.Data3.OnHoverImage = Nothing
        Me.Data3.OnPressedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Data3.Radius = 15
        Me.Data3.Size = New System.Drawing.Size(160, 32)
        Me.Data3.TabIndex = 13
        Me.Data3.Text = "No data"
        Me.Data3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Data2
        '
        Me.Data2.Animated = True
        Me.Data2.AnimationHoverSpeed = 0.07!
        Me.Data2.AnimationSpeed = 0.03!
        Me.Data2.BackColor = System.Drawing.Color.Transparent
        Me.Data2.BaseColor = System.Drawing.Color.Transparent
        Me.Data2.BorderColor = System.Drawing.Color.White
        Me.Data2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Data2.FocusedColor = System.Drawing.Color.Empty
        Me.Data2.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Data2.ForeColor = System.Drawing.Color.Transparent
        Me.Data2.Image = Nothing
        Me.Data2.ImageSize = New System.Drawing.Size(20, 20)
        Me.Data2.Location = New System.Drawing.Point(24, 41)
        Me.Data2.Name = "Data2"
        Me.Data2.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.Data2.OnHoverBorderColor = System.Drawing.Color.White
        Me.Data2.OnHoverForeColor = System.Drawing.Color.White
        Me.Data2.OnHoverImage = Nothing
        Me.Data2.OnPressedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Data2.Radius = 15
        Me.Data2.Size = New System.Drawing.Size(160, 32)
        Me.Data2.TabIndex = 12
        Me.Data2.Text = "No data"
        Me.Data2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataNumber10
        '
        Me.DataNumber10.AutoSize = True
        Me.DataNumber10.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataNumber10.ForeColor = System.Drawing.Color.White
        Me.DataNumber10.Location = New System.Drawing.Point(-5, 303)
        Me.DataNumber10.Name = "DataNumber10"
        Me.DataNumber10.Size = New System.Drawing.Size(25, 19)
        Me.DataNumber10.TabIndex = 38
        Me.DataNumber10.Text = "10"
        Me.DataNumber10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DataNumber10.Visible = False
        '
        'DataNumber9
        '
        Me.DataNumber9.AutoSize = True
        Me.DataNumber9.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataNumber9.ForeColor = System.Drawing.Color.White
        Me.DataNumber9.Location = New System.Drawing.Point(0, 271)
        Me.DataNumber9.Name = "DataNumber9"
        Me.DataNumber9.Size = New System.Drawing.Size(17, 19)
        Me.DataNumber9.TabIndex = 37
        Me.DataNumber9.Text = "9"
        Me.DataNumber9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DataNumber9.Visible = False
        '
        'DataNumber8
        '
        Me.DataNumber8.AutoSize = True
        Me.DataNumber8.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataNumber8.ForeColor = System.Drawing.Color.White
        Me.DataNumber8.Location = New System.Drawing.Point(0, 239)
        Me.DataNumber8.Name = "DataNumber8"
        Me.DataNumber8.Size = New System.Drawing.Size(17, 19)
        Me.DataNumber8.TabIndex = 36
        Me.DataNumber8.Text = "8"
        Me.DataNumber8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DataNumber8.Visible = False
        '
        'DataNumber7
        '
        Me.DataNumber7.AutoSize = True
        Me.DataNumber7.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataNumber7.ForeColor = System.Drawing.Color.White
        Me.DataNumber7.Location = New System.Drawing.Point(0, 207)
        Me.DataNumber7.Name = "DataNumber7"
        Me.DataNumber7.Size = New System.Drawing.Size(17, 19)
        Me.DataNumber7.TabIndex = 35
        Me.DataNumber7.Text = "7"
        Me.DataNumber7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DataNumber7.Visible = False
        '
        'DataNumber6
        '
        Me.DataNumber6.AutoSize = True
        Me.DataNumber6.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataNumber6.ForeColor = System.Drawing.Color.White
        Me.DataNumber6.Location = New System.Drawing.Point(0, 175)
        Me.DataNumber6.Name = "DataNumber6"
        Me.DataNumber6.Size = New System.Drawing.Size(17, 19)
        Me.DataNumber6.TabIndex = 34
        Me.DataNumber6.Text = "6"
        Me.DataNumber6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DataNumber6.Visible = False
        '
        'DataNumber5
        '
        Me.DataNumber5.AutoSize = True
        Me.DataNumber5.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataNumber5.ForeColor = System.Drawing.Color.White
        Me.DataNumber5.Location = New System.Drawing.Point(0, 143)
        Me.DataNumber5.Name = "DataNumber5"
        Me.DataNumber5.Size = New System.Drawing.Size(17, 19)
        Me.DataNumber5.TabIndex = 33
        Me.DataNumber5.Text = "5"
        Me.DataNumber5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DataNumber5.Visible = False
        '
        'DataNumber4
        '
        Me.DataNumber4.AutoSize = True
        Me.DataNumber4.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataNumber4.ForeColor = System.Drawing.Color.White
        Me.DataNumber4.Location = New System.Drawing.Point(0, 111)
        Me.DataNumber4.Name = "DataNumber4"
        Me.DataNumber4.Size = New System.Drawing.Size(17, 19)
        Me.DataNumber4.TabIndex = 32
        Me.DataNumber4.Text = "4"
        Me.DataNumber4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DataNumber4.Visible = False
        '
        'DataNumber3
        '
        Me.DataNumber3.AutoSize = True
        Me.DataNumber3.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataNumber3.ForeColor = System.Drawing.Color.White
        Me.DataNumber3.Location = New System.Drawing.Point(0, 79)
        Me.DataNumber3.Name = "DataNumber3"
        Me.DataNumber3.Size = New System.Drawing.Size(17, 19)
        Me.DataNumber3.TabIndex = 31
        Me.DataNumber3.Text = "3"
        Me.DataNumber3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DataNumber3.Visible = False
        '
        'DataNumber2
        '
        Me.DataNumber2.AutoSize = True
        Me.DataNumber2.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataNumber2.ForeColor = System.Drawing.Color.White
        Me.DataNumber2.Location = New System.Drawing.Point(0, 47)
        Me.DataNumber2.Name = "DataNumber2"
        Me.DataNumber2.Size = New System.Drawing.Size(17, 19)
        Me.DataNumber2.TabIndex = 30
        Me.DataNumber2.Text = "2"
        Me.DataNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DataNumber2.Visible = False
        '
        'DataNumber1
        '
        Me.DataNumber1.AutoSize = True
        Me.DataNumber1.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataNumber1.ForeColor = System.Drawing.Color.White
        Me.DataNumber1.Location = New System.Drawing.Point(0, 15)
        Me.DataNumber1.Name = "DataNumber1"
        Me.DataNumber1.Size = New System.Drawing.Size(17, 19)
        Me.DataNumber1.TabIndex = 28
        Me.DataNumber1.Text = "1"
        Me.DataNumber1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DataNumber1.Visible = False
        '
        'DataLabel
        '
        Me.DataLabel.AutoSize = True
        Me.DataLabel.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataLabel.ForeColor = System.Drawing.Color.White
        Me.DataLabel.Location = New System.Drawing.Point(48, 7)
        Me.DataLabel.Name = "DataLabel"
        Me.DataLabel.Size = New System.Drawing.Size(130, 25)
        Me.DataLabel.TabIndex = 25
        Me.DataLabel.Text = "Angular Data"
        '
        'PlaySend
        '
        Me.PlaySend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlaySend.Animated = True
        Me.PlaySend.AnimationHoverSpeed = 0.07!
        Me.PlaySend.AnimationSpeed = 0.03!
        Me.PlaySend.BackColor = System.Drawing.Color.Transparent
        Me.PlaySend.BaseColor = System.Drawing.Color.White
        Me.PlaySend.BorderColor = System.Drawing.Color.DodgerBlue
        Me.PlaySend.BorderSize = 2
        Me.PlaySend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PlaySend.DialogResult = System.Windows.Forms.DialogResult.None
        Me.PlaySend.FocusedColor = System.Drawing.Color.Empty
        Me.PlaySend.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.PlaySend.ForeColor = System.Drawing.Color.DodgerBlue
        Me.PlaySend.Image = Nothing
        Me.PlaySend.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PlaySend.ImageOffsetX = 10
        Me.PlaySend.ImageSize = New System.Drawing.Size(23, 23)
        Me.PlaySend.Location = New System.Drawing.Point(45, 8)
        Me.PlaySend.Name = "PlaySend"
        Me.PlaySend.OnHoverBaseColor = System.Drawing.Color.DodgerBlue
        Me.PlaySend.OnHoverBorderColor = System.Drawing.Color.DodgerBlue
        Me.PlaySend.OnHoverForeColor = System.Drawing.Color.White
        Me.PlaySend.OnHoverImage = Nothing
        Me.PlaySend.OnPressedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PlaySend.Radius = 10
        Me.PlaySend.Size = New System.Drawing.Size(220, 42)
        Me.PlaySend.TabIndex = 4
        Me.PlaySend.Text = "Send to Arduino"
        Me.PlaySend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PlayLoading
        '
        Me.PlayLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PlayLoading.Enabled = False
        Me.PlayLoading.Location = New System.Drawing.Point(130, 4)
        Me.PlayLoading.Name = "PlayLoading"
        Me.PlayLoading.ProgressColor = System.Drawing.Color.DodgerBlue
        Me.PlayLoading.Size = New System.Drawing.Size(50, 50)
        Me.PlayLoading.TabIndex = 35
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me
        Me.BunifuDragControl2.Vertical = True
        '
        'BunifuDragControl3
        '
        Me.BunifuDragControl3.Fixed = True
        Me.BunifuDragControl3.Horizontal = True
        Me.BunifuDragControl3.TargetControl = Me.DataPanel
        Me.BunifuDragControl3.Vertical = True
        '
        'BunifuDragControl4
        '
        Me.BunifuDragControl4.Fixed = True
        Me.BunifuDragControl4.Horizontal = True
        Me.BunifuDragControl4.TargetControl = Me.DataListPanel
        Me.BunifuDragControl4.Vertical = True
        '
        'BunifuDragControl5
        '
        Me.BunifuDragControl5.Fixed = True
        Me.BunifuDragControl5.Horizontal = True
        Me.BunifuDragControl5.TargetControl = Me.PlayPanel
        Me.BunifuDragControl5.Vertical = True
        '
        'PlayPanel
        '
        Me.PlayPanel.BackColor = System.Drawing.Color.Transparent
        Me.PlayPanel.BaseColor = System.Drawing.Color.White
        Me.PlayPanel.Controls.Add(Me.GunaElipsePanel3)
        Me.PlayPanel.Controls.Add(Me.PlayConfiguration)
        Me.PlayPanel.Controls.Add(Me.Label1)
        Me.PlayPanel.Controls.Add(Me.PlayPalletControlPanel)
        Me.PlayPanel.Controls.Add(Me.PlayBoxSizePanel)
        Me.PlayPanel.Location = New System.Drawing.Point(705, 232)
        Me.PlayPanel.Name = "PlayPanel"
        Me.PlayPanel.Size = New System.Drawing.Size(320, 215)
        Me.PlayPanel.TabIndex = 7
        '
        'GunaElipsePanel3
        '
        Me.GunaElipsePanel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GunaElipsePanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel3.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel3.Controls.Add(Me.PlayLoading)
        Me.GunaElipsePanel3.Controls.Add(Me.PlaySend)
        Me.GunaElipsePanel3.Location = New System.Drawing.Point(5, 160)
        Me.GunaElipsePanel3.Name = "GunaElipsePanel3"
        Me.GunaElipsePanel3.Size = New System.Drawing.Size(310, 55)
        Me.GunaElipsePanel3.TabIndex = 46
        '
        'PlayConfiguration
        '
        Me.PlayConfiguration.Animated = True
        Me.PlayConfiguration.AnimationHoverSpeed = 0.07!
        Me.PlayConfiguration.AnimationSpeed = 0.03!
        Me.PlayConfiguration.BaseColor = System.Drawing.Color.White
        Me.PlayConfiguration.BorderColor = System.Drawing.Color.White
        Me.PlayConfiguration.BorderSize = 2
        Me.PlayConfiguration.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PlayConfiguration.DialogResult = System.Windows.Forms.DialogResult.None
        Me.PlayConfiguration.FocusedColor = System.Drawing.Color.Empty
        Me.PlayConfiguration.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PlayConfiguration.ForeColor = System.Drawing.Color.White
        Me.PlayConfiguration.Image = Global.My_Controller_Flat_UI.My.Resources.Resources.DownX
        Me.PlayConfiguration.ImageSize = New System.Drawing.Size(30, 30)
        Me.PlayConfiguration.Location = New System.Drawing.Point(211, 1)
        Me.PlayConfiguration.Name = "PlayConfiguration"
        Me.PlayConfiguration.OnHoverBaseColor = System.Drawing.Color.White
        Me.PlayConfiguration.OnHoverBorderColor = System.Drawing.Color.White
        Me.PlayConfiguration.OnHoverForeColor = System.Drawing.Color.White
        Me.PlayConfiguration.OnHoverImage = Global.My_Controller_Flat_UI.My.Resources.Resources.DownX
        Me.PlayConfiguration.OnPressedColor = System.Drawing.Color.DodgerBlue
        Me.PlayConfiguration.Size = New System.Drawing.Size(30, 30)
        Me.PlayConfiguration.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(73, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 25)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Configuration"
        '
        'PlayPalletControlPanel
        '
        Me.PlayPalletControlPanel.BackColor = System.Drawing.Color.Transparent
        Me.PlayPalletControlPanel.BaseColor = System.Drawing.Color.White
        Me.PlayPalletControlPanel.Controls.Add(Me.PositionLabel)
        Me.PlayPalletControlPanel.Controls.Add(Me.PlayControlPosition)
        Me.PlayPalletControlPanel.Controls.Add(Me.PlayControlArrange)
        Me.PlayPalletControlPanel.Controls.Add(Me.StackLabel)
        Me.PlayPalletControlPanel.Controls.Add(Me.PlayControlStack)
        Me.PlayPalletControlPanel.Controls.Add(Me.ArrangeLabel)
        Me.PlayPalletControlPanel.Location = New System.Drawing.Point(150, 28)
        Me.PlayPalletControlPanel.Name = "PlayPalletControlPanel"
        Me.PlayPalletControlPanel.Size = New System.Drawing.Size(165, 125)
        Me.PlayPalletControlPanel.TabIndex = 41
        '
        'PositionLabel
        '
        Me.PositionLabel.AutoSize = True
        Me.PositionLabel.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PositionLabel.ForeColor = System.Drawing.Color.DodgerBlue
        Me.PositionLabel.Location = New System.Drawing.Point(9, 54)
        Me.PositionLabel.Name = "PositionLabel"
        Me.PositionLabel.Size = New System.Drawing.Size(73, 21)
        Me.PositionLabel.TabIndex = 44
        Me.PositionLabel.Text = "Position :"
        '
        'PlayControlPosition
        '
        Me.PlayControlPosition.BackColor = System.Drawing.Color.Transparent
        Me.PlayControlPosition.BaseColor = System.Drawing.Color.White
        Me.PlayControlPosition.BorderColor = System.Drawing.Color.DodgerBlue
        Me.PlayControlPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.PlayControlPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PlayControlPosition.Enabled = False
        Me.PlayControlPosition.FocusedColor = System.Drawing.Color.Empty
        Me.PlayControlPosition.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.PlayControlPosition.ForeColor = System.Drawing.Color.DodgerBlue
        Me.PlayControlPosition.FormattingEnabled = True
        Me.PlayControlPosition.Location = New System.Drawing.Point(88, 52)
        Me.PlayControlPosition.Name = "PlayControlPosition"
        Me.PlayControlPosition.OnHoverItemBaseColor = System.Drawing.Color.DodgerBlue
        Me.PlayControlPosition.OnHoverItemForeColor = System.Drawing.Color.White
        Me.PlayControlPosition.Radius = 5
        Me.PlayControlPosition.Size = New System.Drawing.Size(67, 30)
        Me.PlayControlPosition.TabIndex = 43
        '
        'PlayControlArrange
        '
        Me.PlayControlArrange.Animated = True
        Me.PlayControlArrange.AnimationHoverSpeed = 0.07!
        Me.PlayControlArrange.AnimationSpeed = 0.03!
        Me.PlayControlArrange.BackColor = System.Drawing.Color.Transparent
        Me.PlayControlArrange.BaseColor = System.Drawing.Color.Gainsboro
        Me.PlayControlArrange.BorderColor = System.Drawing.Color.DarkGray
        Me.PlayControlArrange.BorderSize = 2
        Me.PlayControlArrange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PlayControlArrange.DialogResult = System.Windows.Forms.DialogResult.None
        Me.PlayControlArrange.FocusedColor = System.Drawing.Color.Empty
        Me.PlayControlArrange.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.PlayControlArrange.ForeColor = System.Drawing.Color.DodgerBlue
        Me.PlayControlArrange.Image = Global.My_Controller_Flat_UI.My.Resources.Resources.Circle
        Me.PlayControlArrange.ImageOffsetX = -6
        Me.PlayControlArrange.ImageSize = New System.Drawing.Size(18, 18)
        Me.PlayControlArrange.Location = New System.Drawing.Point(111, 15)
        Me.PlayControlArrange.Name = "PlayControlArrange"
        Me.PlayControlArrange.OnHoverBaseColor = System.Drawing.Color.Gainsboro
        Me.PlayControlArrange.OnHoverBorderColor = System.Drawing.Color.DodgerBlue
        Me.PlayControlArrange.OnHoverForeColor = System.Drawing.Color.White
        Me.PlayControlArrange.OnHoverImage = Nothing
        Me.PlayControlArrange.OnPressedColor = System.Drawing.Color.DodgerBlue
        Me.PlayControlArrange.Radius = 12
        Me.PlayControlArrange.Size = New System.Drawing.Size(42, 26)
        Me.PlayControlArrange.TabIndex = 42
        Me.PlayControlArrange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StackLabel
        '
        Me.StackLabel.AutoSize = True
        Me.StackLabel.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StackLabel.ForeColor = System.Drawing.Color.DodgerBlue
        Me.StackLabel.Location = New System.Drawing.Point(9, 91)
        Me.StackLabel.Name = "StackLabel"
        Me.StackLabel.Size = New System.Drawing.Size(70, 21)
        Me.StackLabel.TabIndex = 40
        Me.StackLabel.Text = "Stack     :"
        '
        'PlayControlStack
        '
        Me.PlayControlStack.BackColor = System.Drawing.Color.Transparent
        Me.PlayControlStack.BaseColor = System.Drawing.Color.White
        Me.PlayControlStack.BorderColor = System.Drawing.Color.DodgerBlue
        Me.PlayControlStack.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.PlayControlStack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PlayControlStack.Enabled = False
        Me.PlayControlStack.FocusedColor = System.Drawing.Color.Empty
        Me.PlayControlStack.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.PlayControlStack.ForeColor = System.Drawing.Color.DodgerBlue
        Me.PlayControlStack.FormattingEnabled = True
        Me.PlayControlStack.Location = New System.Drawing.Point(88, 89)
        Me.PlayControlStack.Name = "PlayControlStack"
        Me.PlayControlStack.OnHoverItemBaseColor = System.Drawing.Color.DodgerBlue
        Me.PlayControlStack.OnHoverItemForeColor = System.Drawing.Color.White
        Me.PlayControlStack.Radius = 5
        Me.PlayControlStack.Size = New System.Drawing.Size(67, 30)
        Me.PlayControlStack.TabIndex = 37
        '
        'ArrangeLabel
        '
        Me.ArrangeLabel.AutoSize = True
        Me.ArrangeLabel.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArrangeLabel.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ArrangeLabel.Location = New System.Drawing.Point(9, 14)
        Me.ArrangeLabel.Name = "ArrangeLabel"
        Me.ArrangeLabel.Size = New System.Drawing.Size(81, 21)
        Me.ArrangeLabel.TabIndex = 38
        Me.ArrangeLabel.Text = "Palletizing"
        '
        'PlayBoxSizePanel
        '
        Me.PlayBoxSizePanel.BackColor = System.Drawing.Color.Transparent
        Me.PlayBoxSizePanel.BaseColor = System.Drawing.Color.White
        Me.PlayBoxSizePanel.Controls.Add(Me.BoxHeight)
        Me.PlayBoxSizePanel.Controls.Add(Me.HeightLabel)
        Me.PlayBoxSizePanel.Controls.Add(Me.BoxWidth)
        Me.PlayBoxSizePanel.Controls.Add(Me.WidthLabel)
        Me.PlayBoxSizePanel.Controls.Add(Me.BoxLength)
        Me.PlayBoxSizePanel.Controls.Add(Me.LengthLabel)
        Me.PlayBoxSizePanel.Location = New System.Drawing.Point(5, 28)
        Me.PlayBoxSizePanel.Name = "PlayBoxSizePanel"
        Me.PlayBoxSizePanel.Size = New System.Drawing.Size(140, 125)
        Me.PlayBoxSizePanel.TabIndex = 39
        '
        'BoxHeight
        '
        Me.BoxHeight.Animated = True
        Me.BoxHeight.BackColor = System.Drawing.Color.White
        Me.BoxHeight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BoxHeight.FocusedLineColor = System.Drawing.Color.DodgerBlue
        Me.BoxHeight.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.BoxHeight.LineColor = System.Drawing.Color.Gainsboro
        Me.BoxHeight.Location = New System.Drawing.Point(79, 84)
        Me.BoxHeight.MaxLength = 2
        Me.BoxHeight.Name = "BoxHeight"
        Me.BoxHeight.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BoxHeight.SelectedText = ""
        Me.BoxHeight.Size = New System.Drawing.Size(43, 32)
        Me.BoxHeight.TabIndex = 33
        Me.BoxHeight.Text = "30"
        '
        'HeightLabel
        '
        Me.HeightLabel.AutoSize = True
        Me.HeightLabel.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeightLabel.ForeColor = System.Drawing.Color.DodgerBlue
        Me.HeightLabel.Location = New System.Drawing.Point(9, 88)
        Me.HeightLabel.Name = "HeightLabel"
        Me.HeightLabel.Size = New System.Drawing.Size(67, 21)
        Me.HeightLabel.TabIndex = 32
        Me.HeightLabel.Text = "Height  :"
        '
        'BoxWidth
        '
        Me.BoxWidth.Animated = True
        Me.BoxWidth.BackColor = System.Drawing.Color.White
        Me.BoxWidth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BoxWidth.FocusedLineColor = System.Drawing.Color.DodgerBlue
        Me.BoxWidth.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.BoxWidth.LineColor = System.Drawing.Color.Gainsboro
        Me.BoxWidth.Location = New System.Drawing.Point(79, 46)
        Me.BoxWidth.MaxLength = 2
        Me.BoxWidth.Name = "BoxWidth"
        Me.BoxWidth.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BoxWidth.SelectedText = ""
        Me.BoxWidth.Size = New System.Drawing.Size(43, 32)
        Me.BoxWidth.TabIndex = 31
        Me.BoxWidth.Text = "40"
        '
        'WidthLabel
        '
        Me.WidthLabel.AutoSize = True
        Me.WidthLabel.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WidthLabel.ForeColor = System.Drawing.Color.DodgerBlue
        Me.WidthLabel.Location = New System.Drawing.Point(9, 50)
        Me.WidthLabel.Name = "WidthLabel"
        Me.WidthLabel.Size = New System.Drawing.Size(67, 21)
        Me.WidthLabel.TabIndex = 30
        Me.WidthLabel.Text = "Width   :"
        '
        'BoxLength
        '
        Me.BoxLength.Animated = True
        Me.BoxLength.BackColor = System.Drawing.Color.White
        Me.BoxLength.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BoxLength.FocusedLineColor = System.Drawing.Color.DodgerBlue
        Me.BoxLength.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.BoxLength.LineColor = System.Drawing.Color.Gainsboro
        Me.BoxLength.Location = New System.Drawing.Point(79, 8)
        Me.BoxLength.MaxLength = 2
        Me.BoxLength.Name = "BoxLength"
        Me.BoxLength.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BoxLength.SelectedText = ""
        Me.BoxLength.Size = New System.Drawing.Size(43, 32)
        Me.BoxLength.TabIndex = 29
        Me.BoxLength.Text = "60"
        '
        'LengthLabel
        '
        Me.LengthLabel.AutoSize = True
        Me.LengthLabel.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LengthLabel.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LengthLabel.Location = New System.Drawing.Point(9, 12)
        Me.LengthLabel.Name = "LengthLabel"
        Me.LengthLabel.Size = New System.Drawing.Size(69, 21)
        Me.LengthLabel.TabIndex = 28
        Me.LengthLabel.Text = "Length  :"
        '
        'InputPanel
        '
        Me.InputPanel.BackColor = System.Drawing.Color.White
        Me.InputPanel.BaseColor = System.Drawing.Color.White
        Me.InputPanel.Controls.Add(Me.GunaElipsePanel2)
        Me.InputPanel.Controls.Add(Me.GunaElipsePanel1)
        Me.InputPanel.Controls.Add(Me.InputConvert)
        Me.InputPanel.Controls.Add(Me.InputNotif)
        Me.InputPanel.Location = New System.Drawing.Point(705, 11)
        Me.InputPanel.Name = "InputPanel"
        Me.InputPanel.Size = New System.Drawing.Size(320, 190)
        Me.InputPanel.TabIndex = 6
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel2.Controls.Add(Me.InputGripperAngel)
        Me.GunaElipsePanel2.Controls.Add(Me.GripperLabel)
        Me.GunaElipsePanel2.Controls.Add(Me.InputGripperClear)
        Me.GunaElipsePanel2.Controls.Add(Me.InputGripper)
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(177, 5)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(127, 89)
        Me.GunaElipsePanel2.TabIndex = 48
        '
        'InputGripperAngel
        '
        Me.InputGripperAngel.BackColor = System.Drawing.Color.Transparent
        Me.InputGripperAngel.BaseColor = System.Drawing.Color.White
        Me.InputGripperAngel.BorderColor = System.Drawing.Color.Gainsboro
        Me.InputGripperAngel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.InputGripperAngel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.InputGripperAngel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.InputGripperAngel.FocusedColor = System.Drawing.Color.DodgerBlue
        Me.InputGripperAngel.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.InputGripperAngel.ForeColor = System.Drawing.Color.DodgerBlue
        Me.InputGripperAngel.FormattingEnabled = True
        Me.InputGripperAngel.Location = New System.Drawing.Point(5, 49)
        Me.InputGripperAngel.Name = "InputGripperAngel"
        Me.InputGripperAngel.OnHoverItemBaseColor = System.Drawing.Color.DodgerBlue
        Me.InputGripperAngel.OnHoverItemForeColor = System.Drawing.Color.White
        Me.InputGripperAngel.Radius = 3
        Me.InputGripperAngel.Size = New System.Drawing.Size(114, 30)
        Me.InputGripperAngel.TabIndex = 31
        '
        'GripperLabel
        '
        Me.GripperLabel.AutoSize = True
        Me.GripperLabel.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GripperLabel.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GripperLabel.Location = New System.Drawing.Point(3, 17)
        Me.GripperLabel.Name = "GripperLabel"
        Me.GripperLabel.Size = New System.Drawing.Size(118, 21)
        Me.GripperLabel.TabIndex = 33
        Me.GripperLabel.Text = "Gripper Angle  :"
        '
        'InputGripperClear
        '
        Me.InputGripperClear.Animated = True
        Me.InputGripperClear.AnimationHoverSpeed = 0.07!
        Me.InputGripperClear.AnimationSpeed = 0.03!
        Me.InputGripperClear.BackColor = System.Drawing.Color.Transparent
        Me.InputGripperClear.BaseColor = System.Drawing.Color.White
        Me.InputGripperClear.BorderColor = System.Drawing.Color.DodgerBlue
        Me.InputGripperClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.InputGripperClear.DialogResult = System.Windows.Forms.DialogResult.None
        Me.InputGripperClear.FocusedColor = System.Drawing.Color.Empty
        Me.InputGripperClear.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.InputGripperClear.ForeColor = System.Drawing.Color.DodgerBlue
        Me.InputGripperClear.Image = Nothing
        Me.InputGripperClear.ImageSize = New System.Drawing.Size(20, 20)
        Me.InputGripperClear.Location = New System.Drawing.Point(80, 51)
        Me.InputGripperClear.Name = "InputGripperClear"
        Me.InputGripperClear.OnHoverBaseColor = System.Drawing.Color.DodgerBlue
        Me.InputGripperClear.OnHoverBorderColor = System.Drawing.Color.DodgerBlue
        Me.InputGripperClear.OnHoverForeColor = System.Drawing.Color.White
        Me.InputGripperClear.OnHoverImage = Nothing
        Me.InputGripperClear.OnPressedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.InputGripperClear.Radius = 3
        Me.InputGripperClear.Size = New System.Drawing.Size(26, 26)
        Me.InputGripperClear.TabIndex = 37
        Me.InputGripperClear.Text = "X"
        Me.InputGripperClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'InputGripper
        '
        Me.InputGripper.Animated = True
        Me.InputGripper.BackColor = System.Drawing.Color.White
        Me.InputGripper.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.InputGripper.FocusedLineColor = System.Drawing.Color.DodgerBlue
        Me.InputGripper.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.InputGripper.LineColor = System.Drawing.Color.Gainsboro
        Me.InputGripper.Location = New System.Drawing.Point(16, 49)
        Me.InputGripper.MaxLength = 4
        Me.InputGripper.Name = "InputGripper"
        Me.InputGripper.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.InputGripper.SelectedText = ""
        Me.InputGripper.Size = New System.Drawing.Size(89, 32)
        Me.InputGripper.TabIndex = 34
        Me.InputGripper.TextOffsetX = 10
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel1.Controls.Add(Me.InputLabelX)
        Me.GunaElipsePanel1.Controls.Add(Me.InputX)
        Me.GunaElipsePanel1.Controls.Add(Me.InputLabelY)
        Me.GunaElipsePanel1.Controls.Add(Me.InputY)
        Me.GunaElipsePanel1.Controls.Add(Me.InputLabelZ)
        Me.GunaElipsePanel1.Controls.Add(Me.InputZ)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(5, 5)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(158, 117)
        Me.GunaElipsePanel1.TabIndex = 47
        '
        'InputLabelX
        '
        Me.InputLabelX.AutoSize = True
        Me.InputLabelX.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabelX.ForeColor = System.Drawing.Color.DodgerBlue
        Me.InputLabelX.Location = New System.Drawing.Point(6, 6)
        Me.InputLabelX.Name = "InputLabelX"
        Me.InputLabelX.Size = New System.Drawing.Size(63, 21)
        Me.InputLabelX.TabIndex = 26
        Me.InputLabelX.Text = "Pos X   :"
        '
        'InputX
        '
        Me.InputX.Animated = True
        Me.InputX.BackColor = System.Drawing.Color.White
        Me.InputX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.InputX.FocusedLineColor = System.Drawing.Color.DodgerBlue
        Me.InputX.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.InputX.LineColor = System.Drawing.Color.Gainsboro
        Me.InputX.Location = New System.Drawing.Point(75, 2)
        Me.InputX.MaxLength = 4
        Me.InputX.Name = "InputX"
        Me.InputX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.InputX.SelectedText = ""
        Me.InputX.Size = New System.Drawing.Size(68, 32)
        Me.InputX.TabIndex = 31
        '
        'InputLabelY
        '
        Me.InputLabelY.AutoSize = True
        Me.InputLabelY.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabelY.ForeColor = System.Drawing.Color.DodgerBlue
        Me.InputLabelY.Location = New System.Drawing.Point(6, 46)
        Me.InputLabelY.Name = "InputLabelY"
        Me.InputLabelY.Size = New System.Drawing.Size(63, 21)
        Me.InputLabelY.TabIndex = 28
        Me.InputLabelY.Text = "Pos Y   :"
        '
        'InputY
        '
        Me.InputY.Animated = True
        Me.InputY.BackColor = System.Drawing.Color.White
        Me.InputY.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.InputY.FocusedLineColor = System.Drawing.Color.DodgerBlue
        Me.InputY.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.InputY.LineColor = System.Drawing.Color.Gainsboro
        Me.InputY.Location = New System.Drawing.Point(75, 42)
        Me.InputY.MaxLength = 4
        Me.InputY.Name = "InputY"
        Me.InputY.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.InputY.SelectedText = ""
        Me.InputY.Size = New System.Drawing.Size(68, 32)
        Me.InputY.TabIndex = 31
        '
        'InputLabelZ
        '
        Me.InputLabelZ.AutoSize = True
        Me.InputLabelZ.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabelZ.ForeColor = System.Drawing.Color.DodgerBlue
        Me.InputLabelZ.Location = New System.Drawing.Point(6, 86)
        Me.InputLabelZ.Name = "InputLabelZ"
        Me.InputLabelZ.Size = New System.Drawing.Size(63, 21)
        Me.InputLabelZ.TabIndex = 30
        Me.InputLabelZ.Text = "Pos Z   :"
        '
        'InputZ
        '
        Me.InputZ.Animated = True
        Me.InputZ.BackColor = System.Drawing.Color.White
        Me.InputZ.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.InputZ.FocusedLineColor = System.Drawing.Color.DodgerBlue
        Me.InputZ.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.InputZ.LineColor = System.Drawing.Color.Gainsboro
        Me.InputZ.Location = New System.Drawing.Point(75, 82)
        Me.InputZ.MaxLength = 4
        Me.InputZ.Name = "InputZ"
        Me.InputZ.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.InputZ.SelectedText = ""
        Me.InputZ.Size = New System.Drawing.Size(68, 32)
        Me.InputZ.TabIndex = 31
        '
        'InputConvert
        '
        Me.InputConvert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InputConvert.Animated = True
        Me.InputConvert.AnimationHoverSpeed = 0.07!
        Me.InputConvert.AnimationSpeed = 0.03!
        Me.InputConvert.BackColor = System.Drawing.Color.Transparent
        Me.InputConvert.BaseColor = System.Drawing.Color.White
        Me.InputConvert.BorderColor = System.Drawing.Color.DodgerBlue
        Me.InputConvert.BorderSize = 2
        Me.InputConvert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.InputConvert.DialogResult = System.Windows.Forms.DialogResult.None
        Me.InputConvert.FocusedColor = System.Drawing.Color.Empty
        Me.InputConvert.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.InputConvert.ForeColor = System.Drawing.Color.DodgerBlue
        Me.InputConvert.Image = Nothing
        Me.InputConvert.ImageSize = New System.Drawing.Size(20, 20)
        Me.InputConvert.Location = New System.Drawing.Point(44, 145)
        Me.InputConvert.Name = "InputConvert"
        Me.InputConvert.OnHoverBaseColor = System.Drawing.Color.DodgerBlue
        Me.InputConvert.OnHoverBorderColor = System.Drawing.Color.DodgerBlue
        Me.InputConvert.OnHoverForeColor = System.Drawing.Color.White
        Me.InputConvert.OnHoverImage = Nothing
        Me.InputConvert.OnPressedColor = System.Drawing.SystemColors.ButtonHighlight
        Me.InputConvert.Radius = 10
        Me.InputConvert.Size = New System.Drawing.Size(220, 42)
        Me.InputConvert.TabIndex = 32
        Me.InputConvert.Text = "Convert to Angular"
        Me.InputConvert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'InputNotif
        '
        Me.InputNotif.AutoSize = True
        Me.InputNotif.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputNotif.ForeColor = System.Drawing.Color.DodgerBlue
        Me.InputNotif.Location = New System.Drawing.Point(41, 130)
        Me.InputNotif.Name = "InputNotif"
        Me.InputNotif.Size = New System.Drawing.Size(51, 14)
        Me.InputNotif.TabIndex = 38
        Me.InputNotif.Text = "*No text"
        '
        'BunifuDragControl6
        '
        Me.BunifuDragControl6.Fixed = True
        Me.BunifuDragControl6.Horizontal = True
        Me.BunifuDragControl6.TargetControl = Me.InputPanel
        Me.BunifuDragControl6.Vertical = True
        '
        'BunifuDragControl7
        '
        Me.BunifuDragControl7.Fixed = True
        Me.BunifuDragControl7.Horizontal = True
        Me.BunifuDragControl7.TargetControl = Me.GunaElipsePanel3
        Me.BunifuDragControl7.Vertical = True
        '
        'DataLogging
        '
        Me.DataLogging.BackColor = System.Drawing.Color.White
        Me.DataLogging.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataLogging.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataLogging.Location = New System.Drawing.Point(196, 343)
        Me.DataLogging.Multiline = True
        Me.DataLogging.Name = "DataLogging"
        Me.DataLogging.ReadOnly = True
        Me.DataLogging.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataLogging.Size = New System.Drawing.Size(100, 43)
        Me.DataLogging.TabIndex = 8
        Me.DataLogging.TabStop = False
        Me.DataLogging.Visible = False
        '
        'DataLogButton
        '
        Me.DataLogButton.Animated = True
        Me.DataLogButton.AnimationHoverSpeed = 0.07!
        Me.DataLogButton.AnimationSpeed = 0.03!
        Me.DataLogButton.BackColor = System.Drawing.Color.Transparent
        Me.DataLogButton.BaseColor = System.Drawing.Color.White
        Me.DataLogButton.BorderColor = System.Drawing.Color.DarkGray
        Me.DataLogButton.BorderSize = 3
        Me.DataLogButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataLogButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.DataLogButton.FocusedColor = System.Drawing.Color.Empty
        Me.DataLogButton.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.DataLogButton.ForeColor = System.Drawing.Color.DodgerBlue
        Me.DataLogButton.Image = Nothing
        Me.DataLogButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataLogButton.ImageOffsetX = -6
        Me.DataLogButton.ImageSize = New System.Drawing.Size(18, 18)
        Me.DataLogButton.Location = New System.Drawing.Point(296, 277)
        Me.DataLogButton.Name = "DataLogButton"
        Me.DataLogButton.OnHoverBaseColor = System.Drawing.Color.White
        Me.DataLogButton.OnHoverBorderColor = System.Drawing.Color.DodgerBlue
        Me.DataLogButton.OnHoverForeColor = System.Drawing.Color.White
        Me.DataLogButton.OnHoverImage = Nothing
        Me.DataLogButton.OnPressedColor = System.Drawing.Color.DodgerBlue
        Me.DataLogButton.Radius = 11
        Me.DataLogButton.Size = New System.Drawing.Size(26, 26)
        Me.DataLogButton.TabIndex = 43
        Me.DataLogButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataLogButton.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1063, 650)
        Me.Controls.Add(Me.DataLogButton)
        Me.Controls.Add(Me.DataLogging)
        Me.Controls.Add(Me.RecordGetData)
        Me.Controls.Add(Me.InputPanel)
        Me.Controls.Add(Me.PlayPanel)
        Me.Controls.Add(Me.DataPanel)
        Me.Controls.Add(Me.SidePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.SideMenu.ResumeLayout(False)
        Me.PortPanel.ResumeLayout(False)
        Me.PortPanel.PerformLayout()
        Me.SidePanel.ResumeLayout(False)
        Me.SidePanel.PerformLayout()
        Me.DataPanel.ResumeLayout(False)
        Me.DataPanel.PerformLayout()
        Me.DataControlPanel.ResumeLayout(False)
        Me.DataListPanel.ResumeLayout(False)
        Me.DataListPanel.PerformLayout()
        Me.PlayPanel.ResumeLayout(False)
        Me.PlayPanel.PerformLayout()
        Me.GunaElipsePanel3.ResumeLayout(False)
        Me.PlayPalletControlPanel.ResumeLayout(False)
        Me.PlayPalletControlPanel.PerformLayout()
        Me.PlayBoxSizePanel.ResumeLayout(False)
        Me.PlayBoxSizePanel.PerformLayout()
        Me.InputPanel.ResumeLayout(False)
        Me.InputPanel.PerformLayout()
        Me.GunaElipsePanel2.ResumeLayout(False)
        Me.GunaElipsePanel2.PerformLayout()
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents SideMenu As Panel
    Friend WithEvents SideConnect As Guna.UI.WinForms.GunaButton
    Friend WithEvents SidePlay As Guna.UI.WinForms.GunaButton
    Friend WithEvents SideInput As Guna.UI.WinForms.GunaButton
    Friend WithEvents SideRecord As Guna.UI.WinForms.GunaButton
    Friend WithEvents SideAbout As Guna.UI.WinForms.GunaButton
    Friend WithEvents PortLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ConnectPort As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents SideRefresh As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents PortPanel As Panel
    Friend WithEvents NotifPort As Label
    Friend WithEvents MyPort As IO.Ports.SerialPort
    Friend WithEvents Data1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents SidePanel As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents RecordGetData As Guna.UI.WinForms.GunaButton
    Friend WithEvents DataPanel As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents DataListPanel As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents DataControlDown As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents DataControlUp As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents DataControlErase As Guna.UI.WinForms.GunaButton
    Friend WithEvents DataControlPanel As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Data10 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Data9 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Data8 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Data7 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Data6 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Data5 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Data4 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Data3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Data2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents DataLabel As Label
    Friend WithEvents BunifuDragControl3 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl4 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl5 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents InputPanel As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents InputConvert As Guna.UI.WinForms.GunaButton
    Friend WithEvents PlaySend As Guna.UI.WinForms.GunaButton
    Friend WithEvents SideExit As Guna.UI.WinForms.GunaButton
    Friend WithEvents SideBack As Guna.UI.WinForms.GunaButton
    Friend WithEvents PlayPanel As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents InputLabelX As Label
    Friend WithEvents InputZ As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents InputLabelZ As Label
    Friend WithEvents InputY As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents InputLabelY As Label
    Friend WithEvents InputX As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents InputGripperAngel As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents PlayLoading As Guna.UI.WinForms.GunaWinCircleProgressIndicator
    Friend WithEvents InputGripper As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GripperLabel As Label
    Friend WithEvents InputGripperClear As Guna.UI.WinForms.GunaButton
    Friend WithEvents InputNotif As Label
    Friend WithEvents ActionLabel As Label
    Friend WithEvents Action10 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Action9 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Action8 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Action7 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Action6 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Action5 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Action4 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Action3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Action2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Action1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents DataNumber1 As Label
    Friend WithEvents DataNumber10 As Label
    Friend WithEvents DataNumber9 As Label
    Friend WithEvents DataNumber8 As Label
    Friend WithEvents DataNumber7 As Label
    Friend WithEvents DataNumber6 As Label
    Friend WithEvents DataNumber5 As Label
    Friend WithEvents DataNumber4 As Label
    Friend WithEvents DataNumber3 As Label
    Friend WithEvents DataNumber2 As Label
    Friend WithEvents PlayPalletControlPanel As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents StackLabel As Label
    Friend WithEvents PlayBoxSizePanel As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents BoxHeight As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents HeightLabel As Label
    Friend WithEvents BoxWidth As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents WidthLabel As Label
    Friend WithEvents BoxLength As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents LengthLabel As Label
    Friend WithEvents ArrangeLabel As Label
    Friend WithEvents PlayControlStack As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents PlayControlArrange As Guna.UI.WinForms.GunaButton
    Friend WithEvents PositionLabel As Label
    Friend WithEvents PlayControlPosition As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents PlayConfiguration As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaElipsePanel3 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents BunifuDragControl6 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl7 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents DataLogging As TextBox
    Friend WithEvents DataLogButton As Guna.UI.WinForms.GunaButton
End Class
