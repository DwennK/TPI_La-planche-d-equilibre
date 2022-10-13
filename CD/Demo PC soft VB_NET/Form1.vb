Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents VScrollBar2 As System.Windows.Forms.VScrollBar
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents VScrollBar3 As System.Windows.Forms.VScrollBar
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents VScrollBar4 As System.Windows.Forms.VScrollBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.VScrollBar2 = New System.Windows.Forms.VScrollBar
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.VScrollBar3 = New System.Windows.Forms.VScrollBar
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.VScrollBar4 = New System.Windows.Forms.VScrollBar
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(364, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(172, 40)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inputs"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(364, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 40)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Outputs"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(108, 44)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Card Address"
        '
        'CheckBox2
        '
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(56, 20)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(48, 16)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "SK6"
        '
        'CheckBox1
        '
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckBox1.Location = New System.Drawing.Point(8, 20)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(48, 16)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "SK5"
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(8, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 24)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Connect"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "- - -"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(364, 120)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(120, 184)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Counter1"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Debounce Time"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(8, 44)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 24)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Reset"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(8, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(104, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "0"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Controls.Add(Me.TextBox2)
        Me.GroupBox5.Location = New System.Drawing.Point(504, 120)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(120, 184)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Counter2"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Debounce Time"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(8, 44)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 24)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Reset"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(8, 16)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(104, 20)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = "0"
        '
        'Timer2
        '
        '
        'CheckBox3
        '
        Me.CheckBox3.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox3.Location = New System.Drawing.Point(8, 280)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(108, 24)
        Me.CheckBox3.TabIndex = 7
        Me.CheckBox3.Text = "Output Test"
        Me.CheckBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(8, 152)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 24)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Set All Digital"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(8, 184)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(108, 24)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Clear All Digital"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(8, 248)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(108, 24)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Clear All Analog"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(8, 216)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(108, 24)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "Set All Analog"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.VScrollBar1)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(140, 4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(44, 300)
        Me.GroupBox6.TabIndex = 13
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "DA1"
        '
        'VScrollBar1
        '
        Me.VScrollBar1.LargeChange = 1
        Me.VScrollBar1.Location = New System.Drawing.Point(14, 20)
        Me.VScrollBar1.Maximum = 255
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(16, 252)
        Me.VScrollBar1.TabIndex = 13
        Me.VScrollBar1.Value = 255
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = " 00"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.VScrollBar2)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(188, 4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(44, 300)
        Me.GroupBox7.TabIndex = 14
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "DA2"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = " 00"
        '
        'VScrollBar2
        '
        Me.VScrollBar2.LargeChange = 1
        Me.VScrollBar2.Location = New System.Drawing.Point(14, 20)
        Me.VScrollBar2.Maximum = 255
        Me.VScrollBar2.Name = "VScrollBar2"
        Me.VScrollBar2.Size = New System.Drawing.Size(16, 252)
        Me.VScrollBar2.TabIndex = 13
        Me.VScrollBar2.Value = 255
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label6)
        Me.GroupBox8.Controls.Add(Me.VScrollBar3)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(252, 4)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(44, 300)
        Me.GroupBox8.TabIndex = 15
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "AD1"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = " 00"
        '
        'VScrollBar3
        '
        Me.VScrollBar3.LargeChange = 1
        Me.VScrollBar3.Location = New System.Drawing.Point(14, 20)
        Me.VScrollBar3.Maximum = 255
        Me.VScrollBar3.Name = "VScrollBar3"
        Me.VScrollBar3.Size = New System.Drawing.Size(16, 252)
        Me.VScrollBar3.TabIndex = 13
        Me.VScrollBar3.Value = 255
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label7)
        Me.GroupBox9.Controls.Add(Me.VScrollBar4)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(300, 4)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(44, 300)
        Me.GroupBox9.TabIndex = 16
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "AD2"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(12, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = " 00"
        '
        'VScrollBar4
        '
        Me.VScrollBar4.LargeChange = 1
        Me.VScrollBar4.Location = New System.Drawing.Point(14, 20)
        Me.VScrollBar4.Maximum = 255
        Me.VScrollBar4.Name = "VScrollBar4"
        Me.VScrollBar4.Size = New System.Drawing.Size(16, 252)
        Me.VScrollBar4.TabIndex = 13
        Me.VScrollBar4.Value = 255
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(632, 313)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "K8055 Visual Basic .NET Demo"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim n As Integer
    Dim cbi(5) As CheckBox
    Dim cbo(8) As CheckBox
    Dim rb1(4) As RadioButton
    Dim rb2(4) As RadioButton
    Private Declare Function OpenDevice Lib "k8055d.dll" (ByVal CardAddress As Integer) As Integer
    Private Declare Sub CloseDevice Lib "k8055d.dll" ()
    Private Declare Function ReadAnalogChannel Lib "k8055d.dll" (ByVal Channel As Integer) As Integer
    Private Declare Sub ReadAllAnalog Lib "k8055d.dll" (ByRef Data1 As Integer, ByRef Data2 As Integer)
    Private Declare Sub OutputAnalogChannel Lib "k8055d.dll" (ByVal Channel As Integer, ByVal Data As Integer)
    Private Declare Sub OutputAllAnalog Lib "k8055d.dll" (ByVal Data1 As Integer, ByVal Data2 As Integer)
    Private Declare Sub ClearAnalogChannel Lib "k8055d.dll" (ByVal Channel As Integer)
    Private Declare Sub SetAllAnalog Lib "k8055d.dll" ()
    Private Declare Sub ClearAllAnalog Lib "k8055d.dll" ()
    Private Declare Sub SetAnalogChannel Lib "k8055d.dll" (ByVal Channel As Integer)
    Private Declare Sub WriteAllDigital Lib "k8055d.dll" (ByVal Data As Integer)
    Private Declare Sub ClearDigitalChannel Lib "k8055d.dll" (ByVal Channel As Integer)
    Private Declare Sub ClearAllDigital Lib "k8055d.dll" ()
    Private Declare Sub SetDigitalChannel Lib "k8055d.dll" (ByVal Channel As Integer)
    Private Declare Sub SetAllDigital Lib "k8055d.dll" ()
    Private Declare Function ReadDigitalChannel Lib "k8055d.dll" (ByVal Channel As Integer) As Boolean
    Private Declare Function ReadAllDigital Lib "k8055d.dll" () As Integer
    Private Declare Function ReadCounter Lib "k8055d.dll" (ByVal CounterNr As Integer) As Integer
    Private Declare Sub ResetCounter Lib "k8055d.dll" (ByVal CounterNr As Integer)
    Private Declare Sub SetCounterDebounceTime Lib "k8055d.dll" (ByVal CounterNr As Integer, ByVal DebounceTime As Integer)



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        n = 7
        ' Create control arrays
        Dim i As Integer
        For i = 1 To 5
            cbi(i) = New System.Windows.Forms.CheckBox
            cbi(i).Size = New System.Drawing.Size(30, 16)
            cbi(i).Text = CStr(i)
            cbi(i).Cursor = System.Windows.Forms.Cursors.No
            cbi(i).Location = New System.Drawing.Point(30 * i - 20, 15)
            Me.GroupBox1.Controls.Add(cbi(i))
        Next
        For i = 1 To 8
            cbo(i) = New System.Windows.Forms.CheckBox
            cbo(i).Size = New System.Drawing.Size(30, 16)
            cbo(i).Text = CStr(i)
            cbo(i).Tag = 2 ^ (i - 1)
            cbo(i).Location = New System.Drawing.Point(30 * i - 20, 15)
            Me.GroupBox2.Controls.Add(cbo(i))
            AddHandler cbo(i).Click, AddressOf CheckBox2_CheckedChanged
        Next
        For i = 0 To 3
            rb1(i) = New System.Windows.Forms.RadioButton
            rb1(i).Size = New System.Drawing.Size(100, 16)
            Select Case i
                Case 0
                    rb1(i).Text = "0ms"
                Case 1
                    rb1(i).Text = "2ms"
                    rb1(i).Checked = True
                Case 2
                    rb1(i).Text = "10ms"
                Case 3
                    rb1(i).Text = "1000ms"
            End Select
            rb1(i).Tag = i
            rb1(i).Location = New System.Drawing.Point(10, 95 + 20 * i)
            Me.GroupBox4.Controls.Add(rb1(i))
            AddHandler rb1(i).Click, AddressOf RadioButton1_CheckedChanged
        Next
        For i = 0 To 3
            rb2(i) = New System.Windows.Forms.RadioButton
            rb2(i).Size = New System.Drawing.Size(100, 16)
            Select Case i
                Case 0
                    rb2(i).Text = "0ms"
                Case 1
                    rb2(i).Text = "2ms"
                    rb2(i).Checked = True
                Case 2
                    rb2(i).Text = "10ms"
                Case 3
                    rb2(i).Text = "1000ms"
            End Select
            rb2(i).Tag = i
            rb2(i).Location = New System.Drawing.Point(10, 95 + 20 * i)
            Me.GroupBox5.Controls.Add(rb2(i))
            AddHandler rb2(i).Click, AddressOf RadioButton2_CheckedChanged
        Next
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer
        Dim n As Integer
        n = 0
        For i = 1 To 8
            If cbo(i).Checked Then n = n + cbo(i).Tag
        Next
        WriteAllDigital(n)
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t1 As Integer
        Select Case sender.tag
            Case 0
                t1 = 0
            Case 1
                t1 = 2
            Case 2
                t1 = 10
            Case 3
                t1 = 1000
        End Select
        SetCounterDebounceTime(1, t1)
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t2 As Integer
        Select Case sender.tag
            Case 0
                t2 = 0
            Case 1
                t2 = 2
            Case 2
                t2 = 10
            Case 3
                t2 = 1000
        End Select
        SetCounterDebounceTime(2, t2)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim CardAddress As Integer
        Dim h As Integer
        CardAddress = 3
        If CheckBox1.Checked Then CardAddress = CardAddress - 1
        If CheckBox2.Checked Then CardAddress = CardAddress - 2
        h = OpenDevice(CardAddress)
        Select Case h
            Case 0, 1, 2, 3
                Label1.Text = "Card " + Str(h) + " connected"
            Case -1
                Label1.Text = "Card " + Str(CardAddress) + " not found"
            Case -2
                Label1.Text = "K8055E" + Mid(Str(CardAddress), 2, 1) + ".EXE not found"
        End Select
        If h >= 0 Then Timer1.Enabled = True
    End Sub

    Private Sub Form1_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        CloseDevice()
    End Sub


    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ClearDigitalChannel(n)
        cbo(n).Checked = False
        n = n + 1
        If n = 9 Then n = 1
        SetDigitalChannel(n)
        cbo(n).Checked = True
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then Timer2.Enabled = True Else Timer2.Enabled = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim i As Integer
        For i = 1 To 8
            cbo(i).Checked = True
        Next
        SetAllDigital()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim i As Integer
        For i = 1 To 8
            cbo(i).Checked = False
        Next
        ClearAllDigital()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        SetAllAnalog()
        VScrollBar1.Value = 0
        VScrollBar2.Value = 0
        Label4.Text = "255"
        Label5.Text = "255"
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ClearAllAnalog()
        VScrollBar1.Value = 255
        VScrollBar2.Value = 255
        Label4.Text = "0"
        Label5.Text = "0"
    End Sub

    Private Sub VScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VScrollBar1.Scroll
        Label4.Text = CStr(255 - VScrollBar1.Value)
        OutputAnalogChannel(1, 255 - VScrollBar1.Value)
    End Sub

    Private Sub VScrollBar2_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VScrollBar2.Scroll
        Label5.Text = CStr(255 - VScrollBar2.Value)
        OutputAnalogChannel(2, 255 - VScrollBar2.Value)
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Dim i As Integer
        Dim Data1 As Integer
        Dim Data2 As Integer
        i = ReadAllDigital
        cbi(1).Checked = (i And 1)
        cbi(2).Checked = (i And 2) \ 2
        cbi(3).Checked = (i And 4) \ 4
        cbi(4).Checked = (i And 8) \ 8
        cbi(5).Checked = (i And 16) \ 16
        ReadAllAnalog(Data1, Data2)
        VScrollBar3.Value = 255 - Data1
        VScrollBar4.Value = 255 - Data2
        Label6.Text = CStr(Data1)
        Label7.Text = CStr(Data2)
        TextBox1.Text = CStr(ReadCounter(1))
        TextBox2.Text = CStr(ReadCounter(2))
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ResetCounter(1)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ResetCounter(2)
    End Sub
End Class
