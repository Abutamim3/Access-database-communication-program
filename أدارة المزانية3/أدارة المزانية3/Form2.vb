Imports System.Data.OleDb

Public Class Form2
    ' تعريف متغير الاتصال بقاعدة البيانات
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand

    ' تحميل النموذج وإنشاء اتصال بقاعدة البيانات
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dbPath As String = "D:\YourDatabase.accdb" ' تغيير مسار قاعدة البيانات
            conn = New OleDbConnection($"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={dbPath};")
            conn.Open()
            MsgBox("تم الاتصال بقاعدة البيانات بنجاح!", MsgBoxStyle.Information, "نجاح")
        Catch ex As Exception
            MsgBox("خطأ في الاتصال بقاعدة البيانات: " & ex.Message, MsgBoxStyle.Critical, "خطأ")
        End Try
    End Sub

    ' زر حفظ البيانات
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            ' قراءة القيم من مربعات النصوص
            Dim inputValue As String = TextBox1.Text.Trim() ' الحقل الأول
            Dim inputValue2 As String = TextBox2.Text.Trim() ' الحقل الثاني الجديد
            Dim inputValue3 As String = TextBox3.Text.Trim()
            Dim inputValue4 As String = TextBox4.Text.Trim() ' الحقل الأول
            Dim inputValue5 As String = TextBox5.Text.Trim() ' الحقل الثاني الجديد
            Dim inputValue6 As String = TextBox6.Text.Trim()
            Dim inputValue7 As String = TextBox7.Text.Trim()

            ' التحقق من أن الحقول ليست فارغة
            If String.IsNullOrWhiteSpace(inputValue) OrElse String.IsNullOrWhiteSpace(inputValue2) OrElse
               String.IsNullOrWhiteSpace(inputValue3) OrElse String.IsNullOrWhiteSpace(inputValue4) OrElse
               String.IsNullOrWhiteSpace(inputValue5) OrElse String.IsNullOrWhiteSpace(inputValue6) OrElse
               String.IsNullOrWhiteSpace(inputValue7) Then
                MsgBox("يرجى إدخال جميع القيم!", MsgBoxStyle.Exclamation, "تحذير")
                Exit Sub
            End If

            ' استعلام إدخال البيانات في الحقول
            Dim query As String = "INSERT INTO Budget ([Total balance], [Buy shares], [note], [Date and day], [Number of shares], [Investment funds], [Dividend distribution]) VALUES (@Value, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7)"
            cmd = New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@Value", inputValue)
            cmd.Parameters.AddWithValue("@Value2", inputValue2)
            cmd.Parameters.AddWithValue("@Value3", inputValue3)
            cmd.Parameters.AddWithValue("@Value4", inputValue4)
            cmd.Parameters.AddWithValue("@Value5", inputValue5)
            cmd.Parameters.AddWithValue("@Value6", inputValue6)
            cmd.Parameters.AddWithValue("@Value7", inputValue7)

            cmd.ExecuteNonQuery()

            MsgBox("تم حفظ البيانات بنجاح!", MsgBoxStyle.Information, "نجاح")

            ' مسح الحقول بعد الحفظ
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()

        Catch ex As Exception
            MsgBox("خطأ أثناء الحفظ: " & ex.Message, MsgBoxStyle.Critical, "خطأ")
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class

