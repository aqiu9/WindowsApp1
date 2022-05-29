Public Class Form3
    '因为所有的命令都是两步，所以每次在可能触发操作的时候，出前*1*次的操作即可
    Dim msgStack As New Stack(Of Role)
    Dim startPointUp As New Point(252, 96)
    Dim startPointDown As New Point(240, 113)
    Dim xIsDown As Boolean = True 'x的指向状态
    Dim mIsOutOfOrder As Boolean = False 'M的故障状态
    Enum Role
        A
        B
        C
        M
        LINE
        QUXIAO
        RENJIE
        NULL
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
        '这里是初始化form1的draw状态为Null
        drawInMainUI(Role.NULL, Color.Red, 3, 0, isPreClean:=False, isRealTimeUpdate:=False)
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

    '取消
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If msgStack.Count = 0 OrElse Not msgStack.Peek() = Role.QUXIAO Then
            msgStack.Push(Role.QUXIAO)
        End If
    End Sub
    '人解
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If msgStack.Count = 0 OrElse Not msgStack.Peek() = Role.RENJIE Then
            msgStack.Push(Role.RENJIE)
        End If
    End Sub

    '点击line反选checkbox.visible ______________________________________
    Private Sub X_down3_Click(sender As Object, e As EventArgs) Handles X_down3.Click
        '       msgStack.Push(Role.LINE)  关键不在于点没有点line，而是有没有设置故障，看isChecked即可
        Dim cb As CheckBox
        cb = Me.Controls.Find("CheckBox1", True)(0)
        cb.Visible = Not cb.Visible
    End Sub

    Private Sub Me_Click(sender As Object, e As EventArgs) Handles OvalShape_ME1.Click, OvalShape_ME2.Click, OvalShape2.Click, OvalShape1.Click
        Dim pre = Role.NULL
        If msgStack.Count > 0 Then
            pre = msgStack.Pop()
        End If

        Dim light1 As PowerPacks.OvalShape = getPowerPackComponent(Of PowerPacks.OvalShape)("OvalShape_ME1")
        Dim light2 As PowerPacks.OvalShape = getPowerPackComponent(Of PowerPacks.OvalShape)("OvalShape_ME2")

        Select Case pre
            '这里的取消不用初始化M的灯，因为renjie会初始化它，不renjie则无变化
            Case Role.QUXIAO
                '只要不是红白灯就说明非故障，就可以取消 设置故障得+一个目标，目标才算故障，单单isCheck不能说明不可取消。
                If light1.BackColor <> Color.Red AndAlso light2.BackColor <> Color.White Then
                    '取消+非红白->恢复
                    light1.BackColor = Color.Red
                    light2.BackStyle = PowerPacks.BackStyle.Transparent
                    setColorByRole(Role.M, Color.Black)
                    '联锁页面处理完，开始在mainUI中绘制，每个元器件之间延迟500ms
                    drawInMainUI(Role.NULL, Color.Red, 3, 500, True)
                    frm1.drawState = Role.NULL
                End If
            Case Role.RENJIE
                If light1.BackColor = Color.Red AndAlso light2.BackColor = Color.White Then
                    'renjie之后全恢复初始状态
                    mIsOutOfOrder = False
                    setChecked(False)  '注意这里 renjie之后把设置故障也取消了，否则点在checked状态下点renjie再点Me，会同时触发renjie和红蓝的绘制
                    light1.BackColor = Color.Red
                    light2.BackStyle = PowerPacks.BackStyle.Transparent
                    setColorByRole(Role.M, Color.Black)
                    drawInMainUI(Role.NULL, Color.Red, 3, 500, True)
                    frm1.drawState = Role.NULL
                End If
            Case Else
                '无对应操作的时候要不要把上一个操作重新压栈呢？貌似目前的实现都可以
                'msgStack.Push(pre)
        End Select

        '设置故障的逻辑放在select case后边更合适一点点，因为如果在checked状态下，点了取消再点Me，按理应该先取消，取消完了再设置故障
        '特别地，如果设置了故障ischecked()，点击me需要设置红白灯
        If isChecked() And frm1.drawState <> Role.LINE Then
            mIsOutOfOrder = True
            light1.BackStyle = PowerPacks.BackStyle.Opaque
            light1.BackColor = Color.Red
            light2.BackStyle = PowerPacks.BackStyle.Opaque
            light2.BackColor = Color.White

            '红白灯特殊，对应红色和蓝色两种色，所以要这么画，preclean的时候也特殊处理了一下
            drawInMainUI(Role.NULL, Color.Red, 3, 500, True)
            drawInMainUI(Role.LINE, Color.Blue, 3, 500, isPreClean:=False, isRealTimeUpdate:=True)
            frm1.drawState = Role.LINE
        End If

        msgStack.Push(Role.M)
    End Sub

    Private Sub A_Click(sender As Object, e As EventArgs) Handles OvalShape_A1.Click, OvalShape_A2.Click
        Dim pre = Role.NULL
        If msgStack.Count > 0 Then
            pre = msgStack.Pop()
        End If

        Select Case pre
            Case Role.QUXIAO
                If frm1.drawState = Role.A Then
                    setColorByRole(Role.A, Color.Black)

                    If Not mIsOutOfOrder Then
                        '无论是哪种取消，肯定都和M有关，M的灯要回到初始状态，单红
                        setLightColor("OvalShape_ME1", Color.Red, PowerPacks.BackStyle.Opaque)
                        setLightColor("OvalShape_ME2", Color.Tomato, PowerPacks.BackStyle.Transparent)
                        '联锁页面处理完，开始在mainUI中绘制，每个元器件之间延迟500ms
                        drawInMainUI(Role.NULL, Color.Red, 3, 500, True)
                        frm1.drawState = Role.NULL
                    End If
                End If
            Case Role.M
                '任何M+A/B/C的组合，都得保证M没有被设置故障
                If mIsOutOfOrder Then
                    Exit Select
                End If
                If Not xIsDown Then
                    flipX()
                    setColorByRole(Role.C, Color.Black) '如果flip了，应该取消之前点亮过的颜色，因为相当于之前(up/down)断路了
                End If
                'me→a    单黄  因为第二个灯透明，所以啥颜色无所谓  
                setLightColor("OvalShape_ME1", Color.Yellow, PowerPacks.BackStyle.Opaque)
                setLightColor("OvalShape_ME2", Color.Tomato, PowerPacks.BackStyle.Transparent)
                setColorByRole(Role.A, Color.DeepSkyBlue)
                '联锁页面处理完，开始在mainUI中绘制，每个元器件之间延迟500ms
                drawInMainUI(Role.A, Color.Yellow, 3, 500, True)
                frm1.drawState = Role.A
        End Select

        msgStack.Push(Role.A)
    End Sub

    Private Sub B_Click(sender As Object, e As EventArgs) Handles OvalShape_B1.Click, OvalShape_B2.Click
        Dim pre = Role.NULL
        If msgStack.Count > 0 Then
            pre = msgStack.Pop()
        End If

        Select Case pre
            Case Role.QUXIAO
                If frm1.drawState = Role.B Then
                    setColorByRole(Role.B, Color.Black)

                    If Not mIsOutOfOrder Then
                        '无论是哪种取消，肯定都和M有关，M的灯要回到初始状态，单红
                        setLightColor("OvalShape_ME1", Color.Red, PowerPacks.BackStyle.Opaque)
                        setLightColor("OvalShape_ME2", Color.Tomato, PowerPacks.BackStyle.Transparent)
                        '联锁页面处理完，开始在mainUI中绘制，每个元器件之间延迟500ms
                        drawInMainUI(Role.NULL, Color.Red, 3, 500, True)
                        frm1.drawState = Role.NULL
                    End If
                End If

            Case Role.M
                '任何M+A/B/C的组合，都得保证M没有被设置故障
                If mIsOutOfOrder Then
                    Exit Select
                End If
                If Not xIsDown Then
                    flipX()
                    setColorByRole(Role.C, Color.Black) '如果flip了，应该取消之前点亮过的颜色，因为相当于之前(up/down)断路了
                End If
                'me→b    单绿  因为第二个灯透明，所以啥颜色无所谓
                setLightColor("OvalShape_ME1", Color.Green, PowerPacks.BackStyle.Opaque)
                setLightColor("OvalShape_ME2", Color.Tomato, PowerPacks.BackStyle.Transparent)
                setColorByRole(Role.B, Color.DeepSkyBlue)
                '联锁页面处理完，开始在mainUI中绘制，每个元器件之间延迟500ms
                drawInMainUI(Role.B, Color.Green, 3, 500, True)
                frm1.drawState = Role.B
        End Select
        msgStack.Push(Role.B)
    End Sub

    Private Sub C_Click(sender As Object, e As EventArgs) Handles OvalShape_C1.Click, OvalShape_C2.Click
        Dim pre = Role.NULL
        If msgStack.Count > 0 Then
            pre = msgStack.Pop()
        End If
        'select does not need "break"
        Select Case pre
            Case Role.QUXIAO
                If frm1.drawState = Role.C Then
                    setColorByRole(Role.C, Color.Black)

                    If Not mIsOutOfOrder Then
                        '无论是哪种取消，肯定都和M有关，M的灯要回到初始状态，单红
                        setLightColor("OvalShape_ME1", Color.Red, PowerPacks.BackStyle.Opaque)
                        setLightColor("OvalShape_ME2", Color.Tomato, PowerPacks.BackStyle.Transparent)
                        '联锁页面处理完，开始在mainUI中绘制，每个元器件之间延迟500ms
                        drawInMainUI(Role.NULL, Color.Red, 3, 500, True)
                        frm1.drawState = Role.NULL
                    End If
                End If
            Case Role.M
                '任何M+A/B/C的组合，都得保证M没有被设置故障
                If mIsOutOfOrder Then
                    Exit Select
                End If
                If xIsDown Then
                    flipX()
                    'B的影响范围是A的超集，所以用B就可以
                    setColorByRole(Role.B, Color.Black) '如果flip了，应该取消之前点亮过的颜色，因为相当于之前(up/down)断路了
                End If
                'me→c    双黄
                setLightColor("OvalShape_ME1", Color.Yellow, PowerPacks.BackStyle.Opaque)
                setLightColor("OvalShape_ME2", Color.Yellow, PowerPacks.BackStyle.Opaque)
                setColorByRole(Role.C, Color.DeepSkyBlue)
                '联锁页面处理完，开始在mainUI中绘制，每个元器件之间延迟500ms
                drawInMainUI(Role.C, Color.Yellow, 3, 500, True)
                frm1.drawState = Role.C
        End Select
        msgStack.Push(Role.C)
    End Sub
    '_______________________________________________________

    'diy
    Private Sub setLineColor(name As String, color As Color)
        Dim line As PowerPacks.LineShape
        Dim shapes As PowerPacks.ShapeCollection 'powerpacks' stuffs are in ShapeContainer!!
        shapes = Me.ShapeContainer1.Shapes
        line = shapes.Item(shapes.IndexOfKey(name))
        line.BorderColor = color
        line.Update()
    End Sub

    '注意，这里是获取的form3的组件 用的Me
    Private Function getPowerPackComponent(Of T)(name As String)
        Dim stuff As T
        Dim shapes As PowerPacks.ShapeCollection 'powerpacks' stuffs are in ShapeContainer!!
        shapes = Me.ShapeContainer1.Shapes
        stuff = shapes.Item(shapes.IndexOfKey(name))
        Return stuff
    End Function

    Private Function getPowerPackComponentFromForm1(Of T)(name As String)
        Dim stuff As T
        Dim shapes As PowerPacks.ShapeCollection 'powerpacks' stuffs are in ShapeContainer!!
        shapes = frm1.ShapeContainer1.Shapes
        stuff = shapes.Item(shapes.IndexOfKey(name))
        Return stuff
    End Function

    Private Function isChecked()
        Dim cb As CheckBox
        cb = Me.Controls.Find("CheckBox1", True)(0)
        Return cb.Checked
    End Function

    Private Sub setChecked(value As Boolean)
        Dim cb As CheckBox
        cb = Me.Controls.Find("CheckBox1", True)(0)  '注意checkbox不是powerpacks里的组件，所以不能调用getPowerPackComponent(Of CheckBox)("CheckBox1")
        cb.Checked = value
    End Sub

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
        '反转X控件的'上/下'状态
        xIsDown = Not xIsDown
    End Sub

    Private Sub setColorByRole(role As Role, tar As Color)
        Select Case role
            Case Role.M
                '取消所有变化
                Dim shapes = Me.ShapeContainer1.Shapes
                Dim lines = shapes.OfType(Of PowerPacks.LineShape)
                For Each e In lines
                    '     If e.Name <> "X" And e.Name <> "X_down3" Then '这里有bug 如果没有isChecked的时候，对b全线点亮也应该恢复X_down3
                    Dim flippers As ArrayList = New ArrayList({"X", "XX", "XXX", "XXXX"})
                    If Not flippers.Contains(e.Name) Then
                        If e.Name = "X_down3" AndAlso isChecked() Then
                            Continue For
                        End If

                        e.BorderColor = tar
                    End If
                Next
            Case Role.A
                setLineColor("X_down1A", tar)
                setLineColor("X_down2", tar)
            Case Role.B
                'Role.B 牵扯到全线变色，如果没有isChecked，那M右边这段也变色
                setLineColor("X_down1", tar)
                setLineColor("X_down1A", tar)
                setLineColor("X_down2", tar)
                If Not isChecked() Then
                    setLineColor("X_down3", tar)
                End If
            Case Role.C
                setLineColor("X_up1", tar)
                setLineColor("X_up2", tar)
                setLineColor("X_down2", tar)
        End Select
    End Sub

    Private Sub setLightColor(name As String, tar As Color, backStyle As PowerPacks.BackStyle)
        Dim light As PowerPacks.OvalShape = getPowerPackComponent(Of PowerPacks.OvalShape)(name)
        light.BackStyle = backStyle
        light.BackColor = tar
        light.Update()
    End Sub

    Private Sub drawInMainUI(role As Form3.Role, tar As Color, lineWidth As Integer, interval As Integer, isPreClean As Boolean)
        Me.Enabled = False  '因为是同步的，单线程的，所以防止用户多次操作
        Me.Cursor = Cursors.WaitCursor

        If isPreClean Then
            '该参数为了让每次绘制前，把之前绘制过的痕迹给还原消去
            preClean()
        End If
        Dim dict = Form1.lineLightSeqDict
        'Dim colorLen As Integer = tar.Name.Length   '因为命名方式还是有点不统一，没法用这种方式
        Dim preName As String = ""
        For Each name As String In dict.Item(role)
            Dim lastIndex As Integer = name.LastIndexOf("_"c)  'LineShape_red1_1
            Dim temp As String = name.Substring(0, lastIndex)

            '是9说明和上一个不是一组的，不是一批同时亮的line || 从上一个name里搜indexOf(LineShape_red1)，返回是-1，说明不是一组的，是需要延迟一下的。
            If lastIndex = 9 OrElse preName.IndexOf(temp) < 0 Then
                Threading.Thread.Sleep(interval)
            End If
            setLineColorAndWidth(name, tar, lineWidth) '先绘制再sleep，可以避免第一次绘制的时候空等待,但是不能先绘制，你得看看要不要睡再绘制，不然会"错位"，测试一下就知道了
            preName = name
        Next

        Me.Cursor = Cursors.Default
        Me.Enabled = True
    End Sub

    Private Sub drawInMainUI(role As Form3.Role, tar As Color, lineWidth As Integer, interval As Integer, isPreClean As Boolean, isRealTimeUpdate As Boolean)
        If isPreClean Then
            '该参数为了让每次绘制前，把之前绘制过的痕迹给还原消去
            preClean()
        End If
        Dim dict = Form1.lineLightSeqDict
        'Dim colorLen As Integer = tar.Name.Length   '因为命名方式还是有点不统一，没法用这种方式
        Dim preName As String = ""
        For Each name As String In dict.Item(role)
            Dim lastIndex As Integer = name.LastIndexOf("_"c)  'LineShape_red1_1
            Dim temp As String = name.Substring(0, lastIndex)

            '是9说明和上一个不是一组的，不是一批同时亮的line || 从上一个name里搜indexOf(LineShape_red1)，返回是-1，说明不是一组的，是需要延迟一下的。
            If lastIndex = 9 OrElse preName.IndexOf(temp) < 0 Then
                Threading.Thread.Sleep(interval)
            End If
            setLineColorAndWidth(name, tar, lineWidth, isRealTimeUpdate) '先绘制再sleep，可以避免第一次绘制的时候空等待
            preName = name
        Next
    End Sub

    '每次绘制前，把之前绘制过的痕迹给还原消去
    Private Sub preClean()
        '       drawInMainUI(frm1.drawState, Color.Black, 1, 0, False)  不想带update，这样恢复的时候有点视觉延迟, 所以重载了一下
        drawInMainUI(frm1.drawState, Color.Black, 1, 0, False, False)

        If frm1.drawState = Role.LINE Then  'Role.line比较特殊，两种色但是两种色不一样，所以先绘制一下第一种颜色(red)
            drawInMainUI(Role.NULL, Color.Black, 1, 0, False, False)
        End If
    End Sub

    Private Sub setLineColorAndWidth(name As String, tar As Color, borderWidth As Integer)
        Dim line As PowerPacks.LineShape = getPowerPackComponentFromForm1(Of PowerPacks.LineShape)(name)
        line.BorderColor = tar
        line.BorderWidth = borderWidth
        frm1.Update() '这个方法真j8好用，就是立刻把在缓冲区里的绘制操作给绘制了，起到了flush的效果
    End Sub
    Private Sub setLineColorAndWidth(name As String, tar As Color, borderWidth As Integer, isRealTimeUpdate As Boolean)
        Dim line As PowerPacks.LineShape = getPowerPackComponentFromForm1(Of PowerPacks.LineShape)(name)
        line.BorderColor = tar
        line.BorderWidth = borderWidth
        If isRealTimeUpdate Then
            frm1.Update() '这个方法真j8好用，就是立刻把在缓冲区里的绘制操作给绘制了，起到了flush的效果
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



