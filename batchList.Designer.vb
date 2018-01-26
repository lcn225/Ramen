<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class batchList
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
        Me.batchList_DataGridView = New System.Windows.Forms.DataGridView()
        Me.save_Button = New System.Windows.Forms.Button()
        Me.close_Button = New System.Windows.Forms.Button()
        CType(Me.batchList_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'batchList_DataGridView
        '
        Me.batchList_DataGridView.AllowUserToAddRows = False
        Me.batchList_DataGridView.AllowUserToDeleteRows = False
        Me.batchList_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.batchList_DataGridView.Location = New System.Drawing.Point(57, 23)
        Me.batchList_DataGridView.Name = "batchList_DataGridView"
        Me.batchList_DataGridView.RowHeadersVisible = False
        Me.batchList_DataGridView.RowTemplate.Height = 23
        Me.batchList_DataGridView.Size = New System.Drawing.Size(292, 296)
        Me.batchList_DataGridView.TabIndex = 0
        '
        'save_Button
        '
        Me.save_Button.Location = New System.Drawing.Point(57, 339)
        Me.save_Button.Name = "save_Button"
        Me.save_Button.Size = New System.Drawing.Size(75, 23)
        Me.save_Button.TabIndex = 1
        Me.save_Button.Text = "保存"
        Me.save_Button.UseVisualStyleBackColor = True
        '
        'close_Button
        '
        Me.close_Button.Location = New System.Drawing.Point(274, 339)
        Me.close_Button.Name = "close_Button"
        Me.close_Button.Size = New System.Drawing.Size(75, 23)
        Me.close_Button.TabIndex = 2
        Me.close_Button.Text = "关闭"
        Me.close_Button.UseVisualStyleBackColor = True
        '
        'batchList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 403)
        Me.Controls.Add(Me.close_Button)
        Me.Controls.Add(Me.save_Button)
        Me.Controls.Add(Me.batchList_DataGridView)
        Me.Name = "batchList"
        Me.Text = "配料表"
        CType(Me.batchList_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents batchList_DataGridView As DataGridView
    Friend WithEvents save_Button As Button
    Friend WithEvents close_Button As Button
End Class
