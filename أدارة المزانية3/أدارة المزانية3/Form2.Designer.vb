<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        TextBox1 = New TextBox()
        btnSave = New Button()
        lblTitle = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Arial", 12F)
        TextBox1.Location = New Point(38, 52)
        TextBox1.Margin = New Padding(2, 3, 2, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(303, 26)
        TextBox1.TabIndex = 1
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Arial", 12F, FontStyle.Bold)
        btnSave.Location = New Point(471, 331)
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
        lblTitle.ForeColor = SystemColors.ButtonHighlight
        lblTitle.Location = New Point(68, 18)
        lblTitle.Margin = New Padding(2, 0, 2, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(180, 22)
        lblTitle.TabIndex = 0
        lblTitle.Text = "إدخال بيانات إلى Access"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Arial", 12F)
        TextBox2.Location = New Point(38, 102)
        TextBox2.Margin = New Padding(2, 3, 2, 3)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(303, 26)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Arial", 12F)
        TextBox3.Location = New Point(38, 159)
        TextBox3.Margin = New Padding(2, 3, 2, 3)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(303, 26)
        TextBox3.TabIndex = 4
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Arial", 12F)
        TextBox4.Location = New Point(38, 217)
        TextBox4.Margin = New Padding(2, 3, 2, 3)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(303, 26)
        TextBox4.TabIndex = 5
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Arial", 12F)
        TextBox5.Location = New Point(38, 278)
        TextBox5.Margin = New Padding(2, 3, 2, 3)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(303, 26)
        TextBox5.TabIndex = 6
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Arial", 12F)
        TextBox6.Location = New Point(38, 340)
        TextBox6.Margin = New Padding(2, 3, 2, 3)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(303, 26)
        TextBox6.TabIndex = 7
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Arial", 12F)
        TextBox7.Location = New Point(38, 407)
        TextBox7.Margin = New Padding(2, 3, 2, 3)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(303, 26)
        TextBox7.TabIndex = 8
        ' 
        ' TextBox8
        ' 
        TextBox8.Font = New Font("Arial", 12F)
        TextBox8.Location = New Point(38, 462)
        TextBox8.Margin = New Padding(2, 3, 2, 3)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(303, 26)
        TextBox8.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(380, 427)
        Label1.Name = "Label1"
        Label1.Size = New Size(344, 30)
        Label1.TabIndex = 10
        Label1.Text = "برمجة د.عبدالرحمن الحربي الشريف"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(6F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(789, 515)
        Controls.Add(Label1)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(lblTitle)
        Controls.Add(TextBox1)
        Controls.Add(btnSave)
        Margin = New Padding(2, 3, 2, 3)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "إدارة البيانات"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
