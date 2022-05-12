Imports System.ComponentModel

Public Class Form2
    'vb.net里()表示数组
    Private consts_k() As String
    Public Sub New()
        InitializeComponent()

        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.ResizeRedraw, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

        Me.consts_k = {
            72, 82,
            71, 81,
            73, 83,
            52, 62,
            51, 61,
            53, 63,
            32, 42,
            31, 41,
            33, 43,
            12, 22,
            11, 21,
            13, 23,
            3, 4,
            1, 2
        }

        For i As Integer = 0 To 9 '左边10个表格
            Dim tar As TableLayoutPanel
            tar = Me.Controls.Find("TableLayoutPanel_left_" & i, True)(0) '注意这里的0 都是从0里找，具体的还没深究
            For j As Integer = 0 To 13  '每个表格14行
                Dim lb1, lb2 As Label
                lb1 = getALabel(consts_k(j * 2))
                lb2 = getALabel(consts_k(j * 2 + 1))
                tar.Controls.Add(lb1, 0, j)
                tar.Controls.Add(lb2, 2, j)

                'The following is to add input components.
                Dim tbox1, tbox2 As TextBox
                tbox1 = getAInput()
                tbox2 = getAInput()
                tar.Controls.Add(tbox1, 1, j)
                tar.Controls.Add(tbox2, 3, j)
            Next

        Next

        Dim tar1 As TableLayoutPanel
        tar1 = Me.Controls.Find("TableLayoutPanel_right", True)(0)
        For i As Integer = 1 To 18
            For j As Integer = 0 To 10 Step 2
                Dim lb As Label
                lb = getALabel(i.ToString)
                tar1.Controls.Add(lb, j, i - 1)
            Next

            For j As Integer = 1 To 11 Step 2
                'The following is to add input components.
                Dim tbox As TextBox
                tbox = getAInput()
                tar1.Controls.Add(tbox, j, i - 1)
            Next
        Next

        '左侧表格的表头部分 的input components
        For i As Integer = 3 To 12 '这些目标控件的名字后缀
            For j As Integer = 0 To 1 '都是两行
                Dim tbox As TextBox
                tbox = getAInput()
                tar1 = Me.Controls.Find("TableLayoutPanel" & i, True)(0)
                tar1.Controls.Add(tbox, 0, j)
            Next
        Next
        'Dim lb = getALabel("1")
        'Me.TableLayoutPanel2.Controls.Add(lb)
        'Dim lb2 = getALabel("22222")
        'lb2.AutoSize = True
        'lb2.TextAlign = ContentAlignment.MiddleLeft
        'lb2.Dock = DockStyle.Fill
        'Me.TableLayoutPanel2.Controls.Add(lb2)

    End Sub

    Private Sub Form2_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = False Then
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm1.Close()
    End Sub

    ' Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
    '
    '  End Sub

    'override
    'ban the close button at the top of form.
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim myCP As CreateParams = MyBase.CreateParams
            myCP.ClassStyle = myCP.ClassStyle Or &H200
            Return myCP
        End Get
    End Property

    'DIY function
    Private Function getALabel(text As String)
        Dim lb As New Label
        lb.AutoSize = False
        lb.Font = New Font("宋体", 7.5, FontStyle.Bold)
        lb.Text = text
        lb.Height = 1
        lb.Width = 1
        lb.Padding = Padding.Empty
        lb.Margin = Padding.Empty
        lb.TextAlign = ContentAlignment.MiddleLeft
        lb.Dock = DockStyle.Fill
        Return lb
    End Function
    Private Function getAInput()
        Dim tb As New TextBox
        'tb.Height = 1
        tb.Font = New Font("宋体", 10, FontStyle.Bold)
        tb.ForeColor = Color.DeepSkyBlue
        tb.Padding = Padding.Empty
        tb.Margin = Padding.Empty
        tb.TextAlign = HorizontalAlignment.Center
        tb.Dock = DockStyle.Fill
        Return tb
    End Function

End Class