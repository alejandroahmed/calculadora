Public Class Calculadora
    Dim numerouno As Double
    Dim numerodos As Double
    Dim total As Double
    Dim operacion As Double

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Me.TextBox1.Text = TextBox1.Text & "0"
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.TextBox1.Text = TextBox1.Text & "1"
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.TextBox1.Text = TextBox1.Text & "2"
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.TextBox1.Text = TextBox1.Text & "3"
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.TextBox1.Text = TextBox1.Text & "4"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.TextBox1.Text = TextBox1.Text & "5"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.TextBox1.Text = TextBox1.Text & "6"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.TextBox1.Text = TextBox1.Text & "7"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.TextBox1.Text = TextBox1.Text & "8"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.TextBox1.Text = TextBox1.Text & "9"
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Me.TextBox1.Text = TextBox1.Text & ","
        Button14.Enabled = False

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Button14.Enabled = True
        operacion = "suma"
        numerouno = Val(TextBox1.Text)
        TextBox1.Clear()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Button14.Enabled = True
        operacion = "resta"
        numerouno = Val(TextBox1.Text)
        TextBox1.Clear()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Button14.Enabled = True
        operacion = "multiplicacion"
        numerouno = Val(TextBox1.Text)
        TextBox1.Clear()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button14.Enabled = True
        operacion = "division"
        numerouno = Val(TextBox1.Text)
        TextBox1.Clear()

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        numerodos = Val(TextBox1.Text)
        If operacion = "suma" Then
            total = numerouno + numerodos
            TextBox1.Text = total
        ElseIf operacion = "resta" Then
            total = numerouno - numerodos
            TextBox1.Text = total
        ElseIf operacion = "multiplicacion" Then
            total = numerouno * numerodos
            TextBox1.Text = total
        ElseIf operacion = "division" Then
            total = numerouno / numerodos
            TextBox1.Text = total
        End If

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Button14.Enabled = True
        TextBox1.Clear()

    End Sub
End Class
