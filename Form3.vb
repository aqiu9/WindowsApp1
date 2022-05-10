Public Class Form3
    Dim msgQueue As New Queue
    Dim startPointUp As New Point(252, 96)
    Dim startPointDown As New Point(240, 113)
    Enum Role
        A
        B
        C
        M
        LINE
    End Enum
    Private Sub Form3_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = False Then
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub Form3_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm1.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim cb As CheckBox
        cb = Me.Controls.Find("CheckBox1", True)(0)
        If cb.Checked Then
            setLineColor("X_down3", Color.Red)
        Else
            setLineColor("X_down3", Color.Black)
        End If
    End Sub



    '点击line反选checkbox.visible ______________________________________
    Private Sub X_down3_Click(sender As Object, e As EventArgs) Handles X_down3.Click
        msgQueue.Enqueue(Role.LINE)

        Dim cb As CheckBox
        cb = Me.Controls.Find("CheckBox1", True)(0)
        cb.Visible = Not cb.Visible
    End Sub

    Private Sub Me_Click(sender As Object, e As EventArgs) Handles OvalShape_ME1.Click, OvalShape_ME2.Click, M.Click
        msgQueue.Enqueue(Role.M)
        flipX()
    End Sub

    Private Sub A_Click(sender As Object, e As EventArgs) Handles OvalShape_A1.Click, OvalShape_A2.Click, A.Click
        msgQueue.Enqueue(Role.A)

    End Sub

    Private Sub B_Click(sender As Object, e As EventArgs) Handles OvalShape_B1.Click, OvalShape_B2.Click, B.Click
        msgQueue.Enqueue(Role.B)

    End Sub

    Private Sub C_Click(sender As Object, e As EventArgs) Handles OvalShape_C1.Click, OvalShape_C2.Click, C.Click
        msgQueue.Enqueue(Role.C)

    End Sub
    '_______________________________________________________

    'diy
    Private Sub setLineColor(name As String, color As Color)
        Dim line As PowerPacks.LineShape
        Dim shapes As PowerPacks.ShapeCollection 'powerpacks' stuffs are in ShapeContainer!!
        shapes = Me.ShapeContainer1.Shapes
        line = shapes.Item(shapes.IndexOfKey(name))
        line.BorderColor = color
    End Sub

    Private Function isChecked()
        Dim cb As CheckBox
        cb = Me.Controls.Find("CheckBox1", True)(0)
        Return cb.Checked
    End Function

    Private Sub flipX()
        Dim line As PowerPacks.LineShape
        Dim shapes As PowerPacks.ShapeCollection 'powerpacks' stuffs are in ShapeContainer!!
        shapes = Me.ShapeContainer1.Shapes
        line = shapes.Item(shapes.IndexOfKey("X"))
        If line.StartPoint.X = startPointUp.X Then
            line.StartPoint = startPointDown
        Else
            line.StartPoint = startPointUp
        End If
    End Sub

    'override
    'ban the close button at the top of form.
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim myCP As CreateParams = MyBase.CreateParams
            myCP.ClassStyle = myCP.ClassStyle Or &H200
            Return myCP
        End Get
    End Property

End Class



