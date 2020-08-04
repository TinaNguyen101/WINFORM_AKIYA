<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdit
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.DarkKhaki
        Me.lblTitle.Font = New System.Drawing.Font("Meiryo UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(177, 38)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "土地納税通知先情報"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Font = New System.Drawing.Font("Meiryo UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(110, 66)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(333, 20)
        Me.TextBox7.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(12, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.Label8.Size = New System.Drawing.Size(435, 28)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "番号"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Meiryo UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(110, 100)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(333, 20)
        Me.TextBox1.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(435, 28)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "名義"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Meiryo UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(110, 168)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(333, 20)
        Me.TextBox2.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(435, 28)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "住所"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Meiryo UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(110, 134)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(333, 20)
        Me.TextBox3.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.Label4.Size = New System.Drawing.Size(435, 28)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "郵便番号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckBox2
        '
        Me.CheckBox2.BackColor = System.Drawing.Color.DarkKhaki
        Me.CheckBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CheckBox2.Location = New System.Drawing.Point(12, 198)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.CheckBox2.Size = New System.Drawing.Size(99, 28)
        Me.CheckBox2.TabIndex = 26
        Me.CheckBox2.Text = "出力フラグ"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Green
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(351, 207)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(92, 37)
        Me.btnClose.TabIndex = 28
        Me.btnClose.Text = "閉じる"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegister.BackColor = System.Drawing.Color.Green
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegister.Location = New System.Drawing.Point(251, 207)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(92, 37)
        Me.btnRegister.TabIndex = 27
        Me.btnRegister.Text = "登録"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'frmEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 258)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Meiryo UI", 9.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmEdit"
        Me.Text = "個人情報編集"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnRegister As Button
End Class
