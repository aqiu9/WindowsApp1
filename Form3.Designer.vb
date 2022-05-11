<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.M = New System.Windows.Forms.Label()
        Me.A = New System.Windows.Forms.Label()
        Me.B = New System.Windows.Forms.Label()
        Me.C = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.X_down3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.OvalShape_ME1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape_ME2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LineShape_ME = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.X_down1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape_B = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape_A = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.X_up2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.X_up1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape_C = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.OvalShape_C1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape_C2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape_B1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape_B2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape_A2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape_A1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.X = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.X_down2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.X_down1A = New Microsoft.VisualBasic.PowerPacks.LineShape()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.M)
        Me.SplitContainer1.Panel1.Controls.Add(Me.A)
        Me.SplitContainer1.Panel1.Controls.Add(Me.B)
        Me.SplitContainer1.Panel1.Controls.Add(Me.C)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.SplitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(482, 203)
        Me.SplitContainer1.SplitterDistance = 160
        Me.SplitContainer1.TabIndex = 0
        '
        'M
        '
        Me.M.Cursor = System.Windows.Forms.Cursors.Hand
        Me.M.Location = New System.Drawing.Point(363, 76)
        Me.M.Name = "M"
        Me.M.Size = New System.Drawing.Size(26, 15)
        Me.M.TabIndex = 4
        Me.M.Text = "ME"
        '
        'A
        '
        Me.A.Cursor = System.Windows.Forms.Cursors.Hand
        Me.A.Location = New System.Drawing.Point(137, 76)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(19, 15)
        Me.A.TabIndex = 3
        Me.A.Text = "A"
        '
        'B
        '
        Me.B.Cursor = System.Windows.Forms.Cursors.Hand
        Me.B.Location = New System.Drawing.Point(59, 76)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(19, 15)
        Me.B.TabIndex = 2
        Me.B.Text = "B"
        '
        'C
        '
        Me.C.Cursor = System.Windows.Forms.Cursors.Hand
        Me.C.Location = New System.Drawing.Point(154, 23)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(19, 15)
        Me.C.TabIndex = 1
        Me.C.Text = "C"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.X_down1A, Me.X_down3, Me.OvalShape_ME1, Me.OvalShape_ME2, Me.LineShape_ME, Me.X_down1, Me.LineShape_B, Me.LineShape_A, Me.X_up2, Me.X_up1, Me.LineShape_C, Me.OvalShape_C1, Me.OvalShape_C2, Me.OvalShape_B1, Me.OvalShape_B2, Me.OvalShape_A2, Me.OvalShape_A1, Me.X, Me.X_down2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(482, 160)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'X_down3
        '
        Me.X_down3.BorderWidth = 4
        Me.X_down3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.X_down3.Name = "X_down3"
        Me.X_down3.X1 = 362
        Me.X_down3.X2 = 460
        Me.X_down3.Y1 = 113
        Me.X_down3.Y2 = 113
        '
        'OvalShape_ME1
        '
        Me.OvalShape_ME1.BackColor = System.Drawing.Color.Red
        Me.OvalShape_ME1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape_ME1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OvalShape_ME1.Location = New System.Drawing.Point(362, 93)
        Me.OvalShape_ME1.Name = "OvalShape_ME1"
        Me.OvalShape_ME1.Size = New System.Drawing.Size(9, 9)
        '
        'OvalShape_ME2
        '
        Me.OvalShape_ME2.BackColor = System.Drawing.SystemColors.Window
        Me.OvalShape_ME2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OvalShape_ME2.FillColor = System.Drawing.Color.Thistle
        Me.OvalShape_ME2.Location = New System.Drawing.Point(371, 93)
        Me.OvalShape_ME2.Name = "OvalShape_ME2"
        Me.OvalShape_ME2.Size = New System.Drawing.Size(9, 9)
        '
        'LineShape_ME
        '
        Me.LineShape_ME.Name = "LineShape_ME"
        Me.LineShape_ME.X1 = 362
        Me.LineShape_ME.X2 = 362
        Me.LineShape_ME.Y1 = 97
        Me.LineShape_ME.Y2 = 111
        '
        'X_down1
        '
        Me.X_down1.BorderWidth = 4
        Me.X_down1.Name = "X_down1"
        Me.X_down1.X1 = 27
        Me.X_down1.X2 = 135
        Me.X_down1.Y1 = 113
        Me.X_down1.Y2 = 113
        '
        'LineShape_B
        '
        Me.LineShape_B.Name = "LineShape_B"
        Me.LineShape_B.X1 = 59
        Me.LineShape_B.X2 = 59
        Me.LineShape_B.Y1 = 99
        Me.LineShape_B.Y2 = 113
        '
        'LineShape_A
        '
        Me.LineShape_A.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LineShape_A.Name = "LineShape_A"
        Me.LineShape_A.X1 = 135
        Me.LineShape_A.X2 = 135
        Me.LineShape_A.Y1 = 99
        Me.LineShape_A.Y2 = 113
        '
        'X_up2
        '
        Me.X_up2.BorderWidth = 4
        Me.X_up2.Name = "X_up2"
        Me.X_up2.X1 = 125
        Me.X_up2.X2 = 228
        Me.X_up2.Y1 = 56
        Me.X_up2.Y2 = 56
        '
        'X_up1
        '
        Me.X_up1.BorderWidth = 4
        Me.X_up1.Name = "X_up1"
        Me.X_up1.X1 = 227
        Me.X_up1.X2 = 252
        Me.X_up1.Y1 = 56
        Me.X_up1.Y2 = 96
        '
        'LineShape_C
        '
        Me.LineShape_C.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LineShape_C.Name = "LineShape_C"
        Me.LineShape_C.X1 = 151
        Me.LineShape_C.X2 = 151
        Me.LineShape_C.Y1 = 42
        Me.LineShape_C.Y2 = 56
        '
        'OvalShape_C1
        '
        Me.OvalShape_C1.BackColor = System.Drawing.Color.Red
        Me.OvalShape_C1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape_C1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OvalShape_C1.Location = New System.Drawing.Point(151, 39)
        Me.OvalShape_C1.Name = "OvalShape_C1"
        Me.OvalShape_C1.Size = New System.Drawing.Size(9, 9)
        '
        'OvalShape_C2
        '
        Me.OvalShape_C2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OvalShape_C2.Location = New System.Drawing.Point(160, 39)
        Me.OvalShape_C2.Name = "OvalShape_C2"
        Me.OvalShape_C2.Size = New System.Drawing.Size(9, 9)
        '
        'OvalShape_B1
        '
        Me.OvalShape_B1.BackColor = System.Drawing.Color.Red
        Me.OvalShape_B1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape_B1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OvalShape_B1.Location = New System.Drawing.Point(59, 95)
        Me.OvalShape_B1.Name = "OvalShape_B1"
        Me.OvalShape_B1.Size = New System.Drawing.Size(9, 9)
        '
        'OvalShape_B2
        '
        Me.OvalShape_B2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OvalShape_B2.Location = New System.Drawing.Point(68, 95)
        Me.OvalShape_B2.Name = "OvalShape_B2"
        Me.OvalShape_B2.Size = New System.Drawing.Size(9, 9)
        '
        'OvalShape_A2
        '
        Me.OvalShape_A2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OvalShape_A2.Location = New System.Drawing.Point(144, 95)
        Me.OvalShape_A2.Name = "OvalShape_A2"
        Me.OvalShape_A2.Size = New System.Drawing.Size(9, 9)
        '
        'OvalShape_A1
        '
        Me.OvalShape_A1.BackColor = System.Drawing.Color.Red
        Me.OvalShape_A1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape_A1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OvalShape_A1.Location = New System.Drawing.Point(135, 95)
        Me.OvalShape_A1.Name = "OvalShape_A1"
        Me.OvalShape_A1.Size = New System.Drawing.Size(9, 9)
        '
        'X
        '
        Me.X.BorderColor = System.Drawing.Color.LimeGreen
        Me.X.BorderWidth = 4
        Me.X.Name = "X"
        Me.X.X1 = 240
        Me.X.X2 = 258
        Me.X.Y1 = 113
        Me.X.Y2 = 113
        '
        'X_down2
        '
        Me.X_down2.BorderWidth = 4
        Me.X_down2.Name = "X_down2"
        Me.X_down2.X1 = 258
        Me.X_down2.X2 = 362
        Me.X_down2.Y1 = 113
        Me.X_down2.Y2 = 113
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.Window
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Controls.Add(Me.CheckBox1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(482, 39)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button2.Location = New System.Drawing.Point(5, 5)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 29)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "取消"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(87, 5)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "人解"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Font = New System.Drawing.Font("宋体", 10.1!, System.Drawing.FontStyle.Underline)
        Me.CheckBox1.ForeColor = System.Drawing.Color.Red
        Me.CheckBox1.Location = New System.Drawing.Point(369, 5)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(200, 5, 5, 5)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(104, 29)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "设置故障"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'X_down1A
        '
        Me.X_down1A.BorderWidth = 4
        Me.X_down1A.Name = "X_down1A"
        Me.X_down1A.X1 = 135
        Me.X_down1A.X2 = 239
        Me.X_down1A.Y1 = 113
        Me.X_down1A.Y2 = 113
        '
        'Form3
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(482, 203)
        Me.Controls.Add(Me.SplitContainer1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "联锁"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents M As Label
    Friend WithEvents A As Label
    Friend WithEvents B As Label
    Friend WithEvents C As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents OvalShape_ME1 As PowerPacks.OvalShape
    Friend WithEvents OvalShape_ME2 As PowerPacks.OvalShape
    Friend WithEvents LineShape_ME As PowerPacks.LineShape
    Friend WithEvents X_down1 As PowerPacks.LineShape
    Friend WithEvents LineShape_B As PowerPacks.LineShape
    Friend WithEvents LineShape_A As PowerPacks.LineShape
    Friend WithEvents X_up2 As PowerPacks.LineShape
    Friend WithEvents X_up1 As PowerPacks.LineShape
    Friend WithEvents LineShape_C As PowerPacks.LineShape
    Friend WithEvents OvalShape_C1 As PowerPacks.OvalShape
    Friend WithEvents OvalShape_C2 As PowerPacks.OvalShape
    Friend WithEvents OvalShape_B1 As PowerPacks.OvalShape
    Friend WithEvents OvalShape_B2 As PowerPacks.OvalShape
    Friend WithEvents OvalShape_A2 As PowerPacks.OvalShape
    Friend WithEvents OvalShape_A1 As PowerPacks.OvalShape
    Friend WithEvents X As PowerPacks.LineShape
    Friend WithEvents X_down2 As PowerPacks.LineShape
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents X_down3 As PowerPacks.LineShape
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents X_down1A As PowerPacks.LineShape
End Class
