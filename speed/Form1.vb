Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim t, v, s As Double
        t = TextBox1.Text
        v = TextBox2.Text
        If TextBox1.Text = 0 Then
            MessageBox.Show("รับค่าเวลาตั้งแต่ 1 ขึ้นไป !!!")
        ElseIf TextBox2.Text = 0 Then
            MessageBox.Show("รับค่าเวลาตั้งแต่ 1 ขึ้นไป !!!")
        End If
        If RadioButton1.Checked Then
            s = v / (t / 60)
        End If

        If RadioButton2.Checked Then
            s = (v / t)
        End If
        TextBox3.Text = s

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
            MessageBox.Show("รับค่าเฉพาะตัวเลขเท่านั้น !!!")
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
            MessageBox.Show("รับค่าเฉพาะตัวเลขเท่านั้น !!!")
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox1.Text = 0 Then
            TextBox3.Text = 0
        ElseIf TextBox2.Text = 0 Then
            TextBox3.Text = 0
        End If
    End Sub
End Class
