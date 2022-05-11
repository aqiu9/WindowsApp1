Module Module1
    '声明一个全局变量
    Public frm1 As Form1
    Public frm2 As Form2
    Public frm3 As Form3
    Public Sub Main()
        'IF语句，符合条件则显示窗体Form1，这里略过直接显示窗体
        frm1 = New Form1()
        frm2 = New Form2()
        frm3 = New Form3()
        frm1.ShowDialog()
    End Sub

End Module
