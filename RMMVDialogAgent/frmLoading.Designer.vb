<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoading
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
        Me.lbCap = New System.Windows.Forms.Label()
        Me.pBar = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'lbCap
        '
        Me.lbCap.AutoSize = True
        Me.lbCap.Location = New System.Drawing.Point(8, 9)
        Me.lbCap.Name = "lbCap"
        Me.lbCap.Size = New System.Drawing.Size(35, 12)
        Me.lbCap.TabIndex = 0
        Me.lbCap.Text = "lbCap"
        '
        'pBar
        '
        Me.pBar.Location = New System.Drawing.Point(10, 34)
        Me.pBar.Name = "pBar"
        Me.pBar.Size = New System.Drawing.Size(253, 25)
        Me.pBar.TabIndex = 1
        '
        'frmLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 74)
        Me.Controls.Add(Me.pBar)
        Me.Controls.Add(Me.lbCap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLoading"
        Me.Text = "frmLoading"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents lbCap As Label
    Public WithEvents pBar As ProgressBar
End Class
