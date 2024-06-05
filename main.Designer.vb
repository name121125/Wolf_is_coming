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
        Me.intro_button = New System.Windows.Forms.Button()
        Me.start_button = New System.Windows.Forms.Button()
        Me.close_form = New System.Windows.Forms.Button()
        Me.volume = New System.Windows.Forms.Label()
        Me.volume_bar = New System.Windows.Forms.TrackBar()
        Me.music_value = New System.Windows.Forms.Label()
        Me.setting_back_btn = New System.Windows.Forms.Button()
        Me.setting_btn = New System.Windows.Forms.Button()
        Me.Change_music = New System.Windows.Forms.Button()
        Me.Label_music = New System.Windows.Forms.Label()
        Me.music_name = New System.Windows.Forms.Label()
        Me.Credits_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Credits_back_btn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.volume_bar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(322, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 61)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "龍來了"
        '
        'intro_button
        '
        Me.intro_button.Font = New System.Drawing.Font("微軟正黑體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.intro_button.Location = New System.Drawing.Point(79, 434)
        Me.intro_button.Name = "intro_button"
        Me.intro_button.Size = New System.Drawing.Size(193, 57)
        Me.intro_button.TabIndex = 3
        Me.intro_button.Text = "遊戲說明"
        Me.intro_button.UseVisualStyleBackColor = True
        '
        'start_button
        '
        Me.start_button.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.start_button.Location = New System.Drawing.Point(311, 434)
        Me.start_button.Name = "start_button"
        Me.start_button.Size = New System.Drawing.Size(193, 57)
        Me.start_button.TabIndex = 4
        Me.start_button.Text = "Start!"
        Me.start_button.UseVisualStyleBackColor = True
        '
        'close_form
        '
        Me.close_form.Font = New System.Drawing.Font("微軟正黑體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.close_form.Location = New System.Drawing.Point(547, 434)
        Me.close_form.Name = "close_form"
        Me.close_form.Size = New System.Drawing.Size(193, 57)
        Me.close_form.TabIndex = 5
        Me.close_form.Text = "結束遊戲"
        Me.close_form.UseVisualStyleBackColor = True
        '
        'volume
        '
        Me.volume.AutoSize = True
        Me.volume.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.volume.Location = New System.Drawing.Point(212, 165)
        Me.volume.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.volume.Name = "volume"
        Me.volume.Size = New System.Drawing.Size(88, 40)
        Me.volume.TabIndex = 6
        Me.volume.Tag = ""
        Me.volume.Text = "音量:"
        Me.volume.Visible = False
        '
        'volume_bar
        '
        Me.volume_bar.Location = New System.Drawing.Point(383, 165)
        Me.volume_bar.Margin = New System.Windows.Forms.Padding(2)
        Me.volume_bar.Maximum = 100
        Me.volume_bar.Name = "volume_bar"
        Me.volume_bar.Size = New System.Drawing.Size(261, 45)
        Me.volume_bar.TabIndex = 7
        Me.volume_bar.Value = 100
        Me.volume_bar.Visible = False
        '
        'music_value
        '
        Me.music_value.AutoSize = True
        Me.music_value.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.music_value.Location = New System.Drawing.Point(305, 165)
        Me.music_value.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.music_value.Name = "music_value"
        Me.music_value.Size = New System.Drawing.Size(74, 40)
        Me.music_value.TabIndex = 8
        Me.music_value.Text = "100"
        Me.music_value.Visible = False
        '
        'setting_back_btn
        '
        Me.setting_back_btn.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.setting_back_btn.Location = New System.Drawing.Point(600, 311)
        Me.setting_back_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.setting_back_btn.Name = "setting_back_btn"
        Me.setting_back_btn.Size = New System.Drawing.Size(162, 53)
        Me.setting_back_btn.TabIndex = 9
        Me.setting_back_btn.Text = "回主畫面"
        Me.setting_back_btn.UseVisualStyleBackColor = True
        Me.setting_back_btn.Visible = False
        '
        'setting_btn
        '
        Me.setting_btn.Font = New System.Drawing.Font("微軟正黑體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.setting_btn.Location = New System.Drawing.Point(582, 36)
        Me.setting_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.setting_btn.Name = "setting_btn"
        Me.setting_btn.Size = New System.Drawing.Size(158, 47)
        Me.setting_btn.TabIndex = 10
        Me.setting_btn.Text = "Settings"
        Me.setting_btn.UseVisualStyleBackColor = True
        '
        'Change_music
        '
        Me.Change_music.Font = New System.Drawing.Font("微軟正黑體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Change_music.Location = New System.Drawing.Point(508, 239)
        Me.Change_music.Margin = New System.Windows.Forms.Padding(2)
        Me.Change_music.Name = "Change_music"
        Me.Change_music.Size = New System.Drawing.Size(160, 55)
        Me.Change_music.TabIndex = 11
        Me.Change_music.Text = "Change"
        Me.Change_music.UseVisualStyleBackColor = True
        Me.Change_music.Visible = False
        '
        'Label_music
        '
        Me.Label_music.AutoSize = True
        Me.Label_music.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label_music.Location = New System.Drawing.Point(122, 244)
        Me.Label_music.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_music.Name = "Label_music"
        Me.Label_music.Size = New System.Drawing.Size(113, 40)
        Me.Label_music.TabIndex = 12
        Me.Label_music.Text = "音樂："
        Me.Label_music.Visible = False
        '
        'music_name
        '
        Me.music_name.AutoSize = True
        Me.music_name.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.music_name.Location = New System.Drawing.Point(240, 252)
        Me.music_name.Name = "music_name"
        Me.music_name.Size = New System.Drawing.Size(263, 30)
        Me.music_name.TabIndex = 13
        Me.music_name.Text = "Default - Hold it down"
        Me.music_name.Visible = False
        '
        'Credits_btn
        '
        Me.Credits_btn.Font = New System.Drawing.Font("微軟正黑體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Credits_btn.Location = New System.Drawing.Point(79, 36)
        Me.Credits_btn.Name = "Credits_btn"
        Me.Credits_btn.Size = New System.Drawing.Size(156, 47)
        Me.Credits_btn.TabIndex = 14
        Me.Credits_btn.Text = "Credit"
        Me.Credits_btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(329, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 30)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "圖片：徐尚恩"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(188, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(438, 30)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "書面報告&PPT：侯宛彤、徐尚恩、張柏鈞"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(281, 311)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(253, 30)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "遊戲程式設計：張柏鈞"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(273, 347)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(269, 30)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "迷宮：Maze Generator"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(316, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(182, 30)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "音樂：Youtube"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(281, 390)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(253, 30)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "設計：徐尚恩、侯宛彤"
        Me.Label7.Visible = False
        '
        'Credits_back_btn
        '
        Me.Credits_back_btn.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Credits_back_btn.Location = New System.Drawing.Point(578, 376)
        Me.Credits_back_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.Credits_back_btn.Name = "Credits_back_btn"
        Me.Credits_back_btn.Size = New System.Drawing.Size(162, 53)
        Me.Credits_back_btn.TabIndex = 21
        Me.Credits_back_btn.Text = "回主畫面"
        Me.Credits_back_btn.UseVisualStyleBackColor = True
        Me.Credits_back_btn.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Wolf_is_coming.My.Resources.Resources.S__6455299
        Me.PictureBox2.Location = New System.Drawing.Point(515, 141)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(266, 223)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Wolf_is_coming.My.Resources.Resources.S__6455301_反_
        Me.PictureBox1.Location = New System.Drawing.Point(79, 133)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(230, 274)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(841, 503)
        Me.Controls.Add(Me.Credits_back_btn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Credits_btn)
        Me.Controls.Add(Me.music_name)
        Me.Controls.Add(Me.Label_music)
        Me.Controls.Add(Me.Change_music)
        Me.Controls.Add(Me.setting_btn)
        Me.Controls.Add(Me.setting_back_btn)
        Me.Controls.Add(Me.music_value)
        Me.Controls.Add(Me.volume_bar)
        Me.Controls.Add(Me.volume)
        Me.Controls.Add(Me.close_form)
        Me.Controls.Add(Me.start_button)
        Me.Controls.Add(Me.intro_button)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "main"
        Me.Text = "main"
        CType(Me.volume_bar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents intro_button As Button
    Friend WithEvents start_button As Button
    Friend WithEvents close_form As Button
    Friend WithEvents volume As Label
    Friend WithEvents volume_bar As TrackBar
    Friend WithEvents music_value As Label
    Friend WithEvents setting_back_btn As Button
    Friend WithEvents setting_btn As Button
    Friend WithEvents Change_music As Button
    Friend WithEvents Label_music As Label
    Friend WithEvents music_name As Label
    Friend WithEvents Credits_btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Credits_back_btn As Button
End Class
