<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    ' تنظيف الموارد المستخدمة
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    ' مكونات النموذج
    Private components As System.ComponentModel.IContainer

    ' كود تصميم النموذج
    Private Sub InitializeComponent()
        txtValue = New TextBox()
        btnSave = New Button()
        lblTitle = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' txtValue
        ' 
        txtValue.Font = New Font("Arial", 12F)
        txtValue.Location = New Point(38, 52)
        txtValue.Margin = New Padding(2, 3, 2, 3)
        txtValue.Name = "txtValue"
        txtValue.Size = New Size(188, 26)
        txtValue.TabIndex = 1
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Arial", 12F, FontStyle.Bold)
        btnSave.Location = New Point(38, 96)
        btnSave.Margin = New Padding(2, 3, 2, 3)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(188, 35)
        btnSave.TabIndex = 2
        btnSave.Text = "حفظ البيانات"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Arial", 14F, FontStyle.Bold)
        lblTitle.Location = New Point(68, 18)
        lblTitle.Margin = New Padding(2, 0, 2, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(180, 22)
        lblTitle.TabIndex = 0
        lblTitle.Text = "إدخال بيانات إلى Access"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(267, 232)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 3
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(6F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(686, 399)
        Controls.Add(Button1)
        Controls.Add(lblTitle)
        Controls.Add(txtValue)
        Controls.Add(btnSave)
        Margin = New Padding(2, 3, 2, 3)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "إدارة البيانات"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    ' تعريف العناصر
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Button1 As Button
End Class
