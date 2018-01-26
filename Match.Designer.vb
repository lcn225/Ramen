<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Match
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.close_Button = New System.Windows.Forms.Button()
        Me.save_Button = New System.Windows.Forms.Button()
        Me.match_DataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.match_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'close_Button
        '
        Me.close_Button.Location = New System.Drawing.Point(741, 674)
        Me.close_Button.Name = "close_Button"
        Me.close_Button.Size = New System.Drawing.Size(75, 23)
        Me.close_Button.TabIndex = 5
        Me.close_Button.Text = "关闭"
        Me.close_Button.UseVisualStyleBackColor = True
        '
        'save_Button
        '
        Me.save_Button.Location = New System.Drawing.Point(65, 674)
        Me.save_Button.Name = "save_Button"
        Me.save_Button.Size = New System.Drawing.Size(75, 23)
        Me.save_Button.TabIndex = 4
        Me.save_Button.Text = "保存"
        Me.save_Button.UseVisualStyleBackColor = True
        '
        'match_DataGridView
        '
        Me.match_DataGridView.AllowUserToAddRows = False
        Me.match_DataGridView.AllowUserToDeleteRows = False
        Me.match_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.match_DataGridView.Location = New System.Drawing.Point(51, 24)
        Me.match_DataGridView.Name = "match_DataGridView"
        Me.match_DataGridView.RowTemplate.Height = 23
        Me.match_DataGridView.Size = New System.Drawing.Size(1651, 628)
        Me.match_DataGridView.TabIndex = 3
        '
        'Match
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1747, 715)
        Me.Controls.Add(Me.close_Button)
        Me.Controls.Add(Me.save_Button)
        Me.Controls.Add(Me.match_DataGridView)
        Me.Name = "Match"
        Me.Text = "配菜匹配表"
        CType(Me.match_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents close_Button As Button
    Friend WithEvents save_Button As Button
    Friend WithEvents match_DataGridView As DataGridView
End Class
