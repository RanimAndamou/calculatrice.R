Imports System.Windows.Forms.Design

Public Class Form1
    Dim op As Char
    Private Sub btplus_Click(sender As Object, e As EventArgs) Handles btplus.Click
        op = "+"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnfoix_Click(sender As Object, e As EventArgs) Handles btnfoix.Click
        op = "*"
    End Sub

    Private Sub btnmoin_Click(sender As Object, e As EventArgs) Handles btnmoin.Click
        op = "-"
    End Sub

    Private Sub btnsur_Click(sender As Object, e As EventArgs) Handles btnsur.Click
        op = "/"
    End Sub

    Private Sub btnm_Click(sender As Object, e As EventArgs) Handles btnm.Click
        op = "%"
    End Sub

    Private Sub btneq_Click(sender As Object, e As EventArgs) Handles btneq.Click
        Dim a = Integer.Parse(txt1.Text)
        Dim b = Integer.Parse(txt2.Text)
        Dim test = True
        Dim res As Double
        If IsNumeric(txt1.Text) And IsNumeric(txt2.Text) Then
            If op = "+" Then
                res = a + b
            ElseIf op = "-" Then
                res = a - b
            ElseIf op = "*" Then
                res = a * b
            ElseIf op = "/" Then
                res = a / b
            ElseIf op = "%" Then
                Dim c As Integer = a / b
                res = a - (b * c)
            Else
                MessageBox.Show("veuiller verfier si b!=0 que v avec l'operateur")
                test = False
            End If
        End If
        If test Then
            lbl_res.Text = a.ToString + "" + op + "" + b.ToString + "=" + res.ToString
        End If
    End Sub
End Class
