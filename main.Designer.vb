<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.intro_button = New System.Windows.Forms.Button()
        Me.start_button = New System.Windows.Forms.Button()
        Me.close_form = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(482, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 91)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "龍來了"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(118, 159)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(345, 464)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(820, 159)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(322, 462)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'intro_button
        '
        Me.intro_button.Location = New System.Drawing.Point(118, 651)
        Me.intro_button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.intro_button.Name = "intro_button"
        Me.intro_button.Size = New System.Drawing.Size(290, 86)
        Me.intro_button.TabIndex = 3
        Me.intro_button.Text = "Game introduction"
        Me.intro_button.UseVisualStyleBackColor = True
        '
        'start_button
        '
        Me.start_button.Location = New System.Drawing.Point(465, 651)
        Me.start_button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.start_button.Name = "start_button"
        Me.start_button.Size = New System.Drawing.Size(290, 86)
        Me.start_button.TabIndex = 4
        Me.start_button.Text = "Start!"
        Me.start_button.UseVisualStyleBackColor = True
        '
        'close_form
        '
        Me.close_form.Location = New System.Drawing.Point(820, 651)
        Me.close_form.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.close_form.Name = "close_form"
        Me.close_form.Size = New System.Drawing.Size(290, 86)
        Me.close_form.TabIndex = 5
        Me.close_form.Text = "End game"
        Me.close_form.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 765)
        Me.Controls.Add(Me.close_form)
        Me.Controls.Add(Me.start_button)
        Me.Controls.Add(Me.intro_button)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "main"
        Me.Text = "main"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents intro_button As Button
    Friend WithEvents start_button As Button
    Friend WithEvents close_form As Button
End Class
