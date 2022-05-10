Public Class Form3
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
