Imports System.IO

Public Class Form1
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
    Private Sub LineShape1_MouseHover(sender As Object, e As EventArgs) Handles LineShape1.MouseHover
        Dim tar As PowerPacks.LineShape
        Dim shapes As PowerPacks.ShapeCollection 'powerpacks' stuffs are in ShapeContainer!!
        shapes = Me.ShapeContainer1.Shapes
        tar = shapes.Item(shapes.IndexOfKey("LineShape1"))
        tar.BorderColor = Color.Red
        tar.BorderWidth = 3
    End Sub

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
