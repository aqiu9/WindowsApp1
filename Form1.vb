Imports System.IO

Public Class Form1

    Public lineLightSeqDict As New Dictionary(Of Form3.Role, String())
    Public drawState As Form3.Role = Form3.Role.NULL
    Public Sub New()
        '这是form界面，构造函数里必须调用的，不然界面会是空的
        InitializeComponent()

        Dim NULL_RED() As String = {"LineShape_red1", "LineShape_red2", "LineShape_red3", "LineShape_red4_1", "LineShape_red4_2", "LineShape_red4_3", "LineShape_red4_4", "LineShape_red6_1", "LineShape_red6_2", "LineShape_red6_3", "LineShape_red6_4", "LineShape_red6_5", "LineShape_red6_6", "LineShape_red8", "LineShape_red9"}
        Dim MEA_YELLOW() As String = {"LineShape_red1", "LineShape_red2", "LineShape_red3", "LineShape_yellow4", "LineShape_yellow5_1", "LineShape_yellow5_2", "LineShape_yellow6", "LineShape_yellow7", "LineShape_yellow8_1", "LineShape_yellow8_2", "LineShape_yellow8_3", "LineShape_yellow9_1", "LineShape_yellow9_2", "LineShape_yellow9_3", "LineShape_yellow9_4", "LineShape_yellow9_5", "LineShape_red8", "LineShape_red9"}
        Dim MEB_GREEN() As String = {"LineShape_red1", "LineShape_red2", "LineShape_red3", "LineShape_yellow4", "LineShape_yellow5_1", "LineShape_green6_1", "LineShape_green6_2", "LineShape_green6_3", "LineShape_green7_1", "LineShape_green7_2", "LineShape_green7_3", "LineShape_green7_4", "LineShape_yellow9_5", "LineShape_red8", "LineShape_red9"}
        Dim MEC_DOUBLEYELLOW() As String = {"LineShape_red1", "LineShape_red2", "LineShape_red3", "LineShape_yellow4", "LineShape_yellow5_1", "LineShape_yellow5_2", "LineShape_yellow6", "LineShape_yellow7", "LineShape_yellow8_1", "LineShape_yellow8_2", "LineShape_yellow8_3", "LineShape_yellow9_1", "LineShape_yellow9_2", "LineShape_yellow9_3", "LineShape_yellow9_4", "LineShape_yellow9_5", "LineShape_red8", "LineShape_red9", "LineShape_dy1", "LineShape_dy2", "LineShape_dy3", "LineShape_dy4", "LineShape_dy5", "LineShape_dy6_1", "LineShape_dy6_2", "LineShape_dy6_3", "LineShape_dy7_1", "LineShape_dy7_2", "LineShape_dy7_3"}
        '特殊地，在NULL_RED的基础上再绘制BLUE
        Dim MELINE_BLUE() As String = {"LineShape_dy1", "LineShape_dy2", "LineShape_dy3", "LineShape_blue4_1", "LineShape_blue4_2", "LineShape_blue5_1", "LineShape_blue5_2", "LineShape_blue5_3", "LineShape_blue6_0", "LineShape_blue6_1", "LineShape_blue6_2", "LineShape_blue6_3", "LineShape_blue6_4", "LineShape_blue7_1", "LineShape_blue7_2", "LineShape_red8", "LineShape_red9"}

        lineLightSeqDict.Add(Form3.Role.A, MEA_YELLOW)
        lineLightSeqDict.Add(Form3.Role.B, MEB_GREEN)
        lineLightSeqDict.Add(Form3.Role.C, MEC_DOUBLEYELLOW)
        lineLightSeqDict.Add(Form3.Role.NULL, NULL_RED)
        lineLightSeqDict.Add(Form3.Role.LINE, MELINE_BLUE)
    End Sub
    'Public Shared frm2 As New Form2  'shared equals static in Java
    ' Private frm2 As New Form2
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm2.Show()
        frm2.WindowState = FormWindowState.Minimized  '根据需求，form2表格想要一开始隐藏了，单击再弹出来
        frm3.Show()
        frm3.WindowState = FormWindowState.Normal
        '     Dim test As Form4 = New Form4
        '     test.Show()
    End Sub

    '这个是置顶、、窗口默认是可以点哪个哪个就在最前端的
    ' Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
    '  Me.TopMost = True
    ' End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '使用代理（委托）的关键就是，代理本身是一个模子，所以方法签名一样的跨线程ui操作都可以复用同一个代理声明。
        '默认单线程，即所有的form都在一个线程里
        '然后在使用的时候只需要把自己实现的function或子过程的地址传给代理类型的变量即可，这就算对代理实例化了。
        'Dim noArgDeleForm2 As Form2.no_arg_form2 = AddressOf flipForm2

        'Await Task.Run(New Action(Sub()
        ''原理应该是反射
        '   End Sub))

        flipForm2()
        ' frm2.TopMost = Not frm2.TopMost
    End Sub
    '为了多线程载入form2，这里实例化form2里声明的代理 子过程，然后才可以跨线程操作（美其名曰 代理）
    '注意private时不能跨文件访问
    Public Sub flipForm2()
        If frm2.WindowState = FormWindowState.Minimized Then
            frm2.WindowState = FormWindowState.Normal
        Else
            frm2.WindowState = FormWindowState.Minimized   ' cuz max button has been banned
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '  If frm3.WindowState = FormWindowState.Minimized Then
        '  frm3.WindowState = FormWindowState.Normal
        '    Else
        '   frm3.WindowState = FormWindowState.Minimized   ' cuz max button has been banned
        '  End If
        frm3.TopMost = Not frm3.TopMost
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
