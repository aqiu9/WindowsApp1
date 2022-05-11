Imports System.IO

Public Class Form1
    Public lineLightSeqDict As New Dictionary(Of Form3.Role, String())
    Public Sub New()
        '这是form界面，构造函数里必须调用的，不然界面会是空的
        InitializeComponent()

        Dim NULL_RED() As String = {"LineShape_red1", "LineShape_red2", "LineShape_red3", "LineShape_red4_1", "LineShape_red4_2", "LineShape_red4_3", "LineShape_red4_4", "LineShape_red6_1", "LineShape_red6_2", "LineShape_red6_3", "LineShape_red6_4", "LineShape_red6_5", "LineShape_red6_6", "LineShape_red8", "LineShape_red9"}
        Dim MEA_YELLOW() As String = {"LineShape_red1", "LineShape_red2", "LineShape_red3", "LineShape_yellow4", "LineShape_yellow5_1", "LineShape_yellow5_2", "LineShape_yellow6", "LineShape_yellow7", "LineShape_yellow8_1", "LineShape_yellow8_2", "LineShape_yellow8_3", "LineShape_yellow9_1", "LineShape_yellow9_2", "LineShape_yellow9_3", "LineShape_yellow9_4", "LineShape_yellow9_5", "LineShape_red8", "LineShape_red9"}
        Dim MEB_GREEN() As String = {"LineShape_red1", "LineShape_red2", "LineShape_red3", "LineShape_yellow4", "LineShape_yellow5_1", "LineShape_green6_1", "LineShape_green6_2", "LineShape_green6_3", "LineShape_green7_1", "LineShape_green7_2", "LineShape_green7_3", "LineShape_green7_4", "LineShape_yellow9_5", "LineShape_red8", "LineShape_red9"}
        Dim MEC_DOUBLEYELLOW() As String = {"LineShape_red1", "LineShape_red2", "LineShape_red3", "LineShape_yellow4", "LineShape_yellow5_1", "LineShape_yellow5_2", "LineShape_yellow6", "LineShape_yellow7", "LineShape_yellow8_1", "LineShape_yellow8_2", "LineShape_yellow8_3", "LineShape_yellow9_1", "LineShape_yellow9_2", "LineShape_yellow9_3", "LineShape_yellow9_4", "LineShape_yellow9_5", "LineShape_red8", "LineShape_red9", "LineShape_dy1", "LineShape_dy2", "LineShape_dy3", "LineShape_dy4", "LineShape_dy5", "LineShape_dy6_1", "LineShape_dy6_2", "LineShape_dy6_3", "LineShape_dy7_1", "LineShape_dy7_2", "LineShape_dy7_3"}

        lineLightSeqDict.Add(Form3.Role.A, MEA_YELLOW)
        lineLightSeqDict.Add(Form3.Role.B, MEB_GREEN)
        lineLightSeqDict.Add(Form3.Role.C, MEC_DOUBLEYELLOW)
        lineLightSeqDict.Add(Form3.Role.NULL, NULL_RED)
    End Sub
    'Public Shared frm2 As New Form2  'shared equals static in Java
    ' Private frm2 As New Form2
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm2.Show()
        frm2.WindowState = FormWindowState.Minimized
        frm3.Show()
        frm3.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'frm2.Visible = Not frm2.Visible   最小化后再打开比隐藏再show绘制的更快一些
        If frm2.WindowState = FormWindowState.Minimized Then
            frm2.WindowState = FormWindowState.Normal
        Else
            frm2.WindowState = FormWindowState.Minimized   ' cuz max button has been banned
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'frm2.Visible = Not frm2.Visible   最小化后再打开比隐藏再show绘制的更快一些
        If frm3.WindowState = FormWindowState.Minimized Then
            frm3.WindowState = FormWindowState.Normal
        Else
            frm3.WindowState = FormWindowState.Minimized   ' cuz max button has been banned
        End If
    End Sub

    'test passed!
    '  Private Sub LineShape1_MouseHover(sender As Object, e As EventArgs) Handles LineShape1.MouseHover
    ' Dim tar As PowerPacks.LineShape
    'Dim shapes As PowerPacks.ShapeCollection 'powerpacks' stuffs are in ShapeContainer!!
    '   shapes = Me.ShapeContainer1.Shapes
    '  tar = shapes.Item(shapes.IndexOfKey("LineShape1"))
    ' tar.BorderColor = Color.Red
    'tar.BorderWidth = 3
    'End Sub

    '@deprecated
    Private Function getInstruction()
        'todo read csv? or plain txt
        'LineShape_red[1-7]_
        Dim line, path As String
        path = CreateObject("WScript.Shell").SpecialFolders("Desktop") & "/temp.txt"
        Dim sr As StreamReader = New StreamReader(path, System.Text.Encoding.Default)
        Do While sr.Peek() > 0
            line = sr.ReadLine()
        Loop
        sr.Close()

        Return 0
    End Function
End Class
