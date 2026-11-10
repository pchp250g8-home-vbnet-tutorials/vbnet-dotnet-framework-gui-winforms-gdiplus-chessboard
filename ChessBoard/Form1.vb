Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Color.Aqua
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim Width As Integer = ClientSize.Width / 8
        Dim Height As Integer = ClientSize.Height / 8
        Dim rects(32) As Rectangle
        Dim g As Graphics = e.Graphics
        g.Clear(Color.Aqua)
        For k As Integer = 0 To 31
            Dim i As Integer = k \ 4
            Dim j As Integer = (k Mod 4) * 2 + (i Mod 2)
            Dim Left As Integer = i * Width
            Dim Top As Integer = j * Height
            rects(k) = New Rectangle(Left, Top, Width, Height)
        Next k
        g.FillRectangles(Brushes.Brown, rects)
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Invalidate()
    End Sub
End Class
