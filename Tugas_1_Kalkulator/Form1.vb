Public Class Form1
    Dim Angka1, Angka2 As Single
    Dim Lambang As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        tb_display.Text = tb_display.Text + btn_1.Text
    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        tb_display.Text = tb_display.Text + btn_2.Text
    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        tb_display.Text = tb_display.Text + btn_3.Text
    End Sub

    Private Sub btn_4_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        tb_display.Text = tb_display.Text + btn_4.Text
    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        tb_display.Text = tb_display.Text + btn_5.Text
    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        tb_display.Text = tb_display.Text + btn_6.Text
    End Sub

    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        tb_display.Text = tb_display.Text + btn_7.Text
    End Sub

    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        tb_display.Text = tb_display.Text + btn_8.Text
    End Sub

    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        tb_display.Text = tb_display.Text + btn_9.Text
    End Sub

    Private Sub btn_0_Click(sender As Object, e As EventArgs) Handles btn_0.Click
        If tb_display.Text = "" Then
            tb_display.Text = ""
        Else
            tb_display.Text = tb_display.Text + btn_0.Text
        End If
    End Sub

    Private Sub btn_Tambah_Click(sender As Object, e As EventArgs) Handles btn_Tambah.Click
        If tb_display.Text = "" Then Exit Sub
        Angka1 = CSng(tb_display.Text)
        Lambang = "+"
        tb_display.Clear()
    End Sub

    Private Sub btn_Kurang_Click(sender As Object, e As EventArgs) Handles btn_Kurang.Click
        If tb_display.Text = "" Then Exit Sub
        Angka1 = CSng(tb_display.Text)
        Lambang = "-"
        tb_display.Clear()
    End Sub

    Private Sub btn_Kali_Click(sender As Object, e As EventArgs) Handles btn_Kali.Click
        If tb_display.Text = "" Then Exit Sub
        Angka1 = CSng(tb_display.Text)
        Lambang = "*"
        tb_display.Clear()
    End Sub

    Private Sub btn_Bagi_Click(sender As Object, e As EventArgs) Handles btn_Bagi.Click
        If tb_display.Text = "" Then Exit Sub
        Angka1 = CSng(tb_display.Text)
        Lambang = "/"
        tb_display.Clear()
    End Sub

    Private Sub btn_Jumlah_Click(sender As Object, e As EventArgs) Handles btn_Jumlah.Click
        Dim Hasil As Single
        Angka2 = CSng(tb_display.Text)
        Select Case Lambang
            Case "+"
                Hasil = Angka1 + Angka2
            Case "-"
                Hasil = Angka1 - Angka2
            Case "*"
                Hasil = Angka1 * Angka2
            Case "/"
                Hasil = Angka1 / Angka2
            Case "^"
                Hasil = Angka1 ^ Angka2
        End Select
        tb_display.Text = Hasil
    End Sub

    Private Sub btn_PlusMinus_Click(sender As Object, e As EventArgs) Handles btn_PlusMinus.Click
        If tb_display.Text = "" Then Exit Sub
        If Val(tb_display.Text) > 0 Then
            tb_display.Text = Val(tb_display.Text) * -1
        Else
            tb_display.Text = Val(tb_display.Text) * -1
        End If
    End Sub

    Private Sub btn_Koma_Click(sender As Object, e As EventArgs) Handles btn_Koma.Click
        tb_display.Text = tb_display.Text + btn_Koma.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Hasil As Single
        Angka1 = CSng(tb_display.Text)
        Hasil = Math.Pow(Angka1, 2)
        tb_display.Text = Hasil
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Hasil As Single
        Angka1 = CSng(tb_display.Text)
        Hasil = Math.Sqrt(Angka1)
        tb_display.Text = Hasil
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Hasil As Single
        Angka1 = CSng(tb_display.Text)
        Hasil = 1 / Angka1
        tb_display.Text = Hasil
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Hasil As Single
        Angka1 = CSng(tb_display.Text)
        Hasil = Angka1 / 10
        tb_display.Text = Hasil
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If tb_display.Text = "" Then Exit Sub
        Angka1 = CSng(tb_display.Text)
        Lambang = "^"
        tb_display.Clear()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Hasil As Single
        Angka1 = CSng(tb_display.Text)
        Hasil = Math.Sin(Angka1)
        tb_display.Text = Hasil
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim Hasil As Single
        Angka1 = CSng(tb_display.Text)
        Hasil = Math.Cos(Angka1)
        tb_display.Text = Hasil
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim Hasil As Single
        Angka1 = CSng(tb_display.Text)
        Hasil = Math.Tan(Angka1)
        tb_display.Text = Hasil
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim Hasil As Single
        Angka1 = CSng(tb_display.Text)
        Hasil = Math.Log10(Angka1)
        tb_display.Text = Hasil
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim Hasil As Single
        Angka1 = CSng(tb_display.Text)
        Hasil = Math.Sinh(Angka1)
        tb_display.Text = Hasil
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim Hasil As Single
        Angka1 = CSng(tb_display.Text)
        Hasil = Math.Cosh(Angka1)
        tb_display.Text = Hasil
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim Hasil As Single
        Angka1 = CSng(tb_display.Text)
        Hasil = Math.Tanh(Angka1)
        tb_display.Text = Hasil
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        tb_display.Text = ""
    End Sub
End Class
