<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class finish_screen
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(155, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(541, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "目前遊戲只做了三關(應該也不會有第四關了)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(325, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "感謝遊玩!!!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(186, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(407, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Made by 張柏鈞、徐尚恩、侯宛彤"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(529, 314)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(232, 61)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "回到主畫面"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'finish_screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "finish_screen"
        Me.Text = "finish_screen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
