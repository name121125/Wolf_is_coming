<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class intro
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(295, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "遊戲說明"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(582, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "有三個關卡，玩家使用WASD進行上下左右控制"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(171, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(420, 34)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "遊戲前五秒，玩家可觀察迷宮路線"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(88, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(587, 34)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "五秒後玩家將可以移動，30秒倒數也會自動開始"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(158, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(447, 34)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "玩家出發三秒後，龍會開始追逐玩家"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(144, 287)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(474, 34)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "當龍追到玩家或倒數結束，即遊戲失敗"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微軟正黑體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(144, 332)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(474, 34)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "當玩家在時間內抵達終點即遊戲成功。"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.Location = New System.Drawing.Point(578, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 42)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "回主畫面"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'intro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "intro"
        Me.Text = "intro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
End Class
