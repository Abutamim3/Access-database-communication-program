Imports System.Data.OleDb

Public Class Form1
    ' تعريف متغير الاتصال بقاعدة البيانات
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand

    ' تحميل النموذج وإنشاء اتصال بقاعدة البيانات
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Dim inputValue As String = txtValue.Text.Trim()

            ' التحقق من عدم ترك الحقل فارغًا
            If String.IsNullOrWhiteSpace(inputValue) Then
                MsgBox("يرجى إدخال قيمة!", MsgBoxStyle.Exclamation, "تحذير")
                Exit Sub
            End If

            ' إدخال البيانات إلى الجدول
            Dim query As String = "INSERT INTO MyTable (MyField) VALUES (@Value)"
            cmd = New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@Value", inputValue)
            cmd.ExecuteNonQuery()

            MsgBox("تم حفظ البيانات بنجاح!", MsgBoxStyle.Information, "نجاح")
            txtValue.Clear()

        Catch ex As Exception
            MsgBox("خطأ أثناء الحفظ: " & ex.Message, MsgBoxStyle.Critical, "خطأ")
        End Try
    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub
End Class
