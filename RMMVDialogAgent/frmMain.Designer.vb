<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.cmdTransform = New System.Windows.Forms.Button()
        Me.txtStartLine = New System.Windows.Forms.TextBox()
        Me.lbStartLine = New System.Windows.Forms.Label()
        Me.grpCtrl = New System.Windows.Forms.GroupBox()
        Me.cmdAbout = New System.Windows.Forms.Button()
        Me.cmdSetting = New System.Windows.Forms.Button()
        Me.spC = New System.Windows.Forms.SplitContainer()
        Me.grpRaw = New System.Windows.Forms.GroupBox()
        Me.txtRaw = New System.Windows.Forms.TextBox()
        Me.grpJSON = New System.Windows.Forms.GroupBox()
        Me.txtTransformed = New System.Windows.Forms.TextBox()
        Me.bgW = New System.ComponentModel.BackgroundWorker()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.grpCtrl.SuspendLayout()
        CType(Me.spC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spC.Panel1.SuspendLayout()
        Me.spC.Panel2.SuspendLayout()
        Me.spC.SuspendLayout()
        Me.grpRaw.SuspendLayout()
        Me.grpJSON.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdTransform
        '
        Me.cmdTransform.Location = New System.Drawing.Point(9, 182)
        Me.cmdTransform.Name = "cmdTransform"
        Me.cmdTransform.Size = New System.Drawing.Size(112, 34)
        Me.cmdTransform.TabIndex = 2
        Me.cmdTransform.Text = "转换"
        Me.cmdTransform.UseVisualStyleBackColor = True
        '
        'txtStartLine
        '
        Me.txtStartLine.Location = New System.Drawing.Point(9, 35)
        Me.txtStartLine.Name = "txtStartLine"
        Me.txtStartLine.Size = New System.Drawing.Size(97, 21)
        Me.txtStartLine.TabIndex = 5
        Me.txtStartLine.Text = "1"
        Me.txtStartLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbStartLine
        '
        Me.lbStartLine.AutoSize = True
        Me.lbStartLine.Location = New System.Drawing.Point(7, 20)
        Me.lbStartLine.Name = "lbStartLine"
        Me.lbStartLine.Size = New System.Drawing.Size(65, 12)
        Me.lbStartLine.TabIndex = 6
        Me.lbStartLine.Text = "台词起始行"
        '
        'grpCtrl
        '
        Me.grpCtrl.Controls.Add(Me.cmdAbout)
        Me.grpCtrl.Controls.Add(Me.cmdSetting)
        Me.grpCtrl.Controls.Add(Me.lbStartLine)
        Me.grpCtrl.Controls.Add(Me.txtStartLine)
        Me.grpCtrl.Controls.Add(Me.cmdTransform)
        Me.grpCtrl.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpCtrl.Location = New System.Drawing.Point(0, 0)
        Me.grpCtrl.Name = "grpCtrl"
        Me.grpCtrl.Size = New System.Drawing.Size(132, 327)
        Me.grpCtrl.TabIndex = 7
        Me.grpCtrl.TabStop = False
        Me.grpCtrl.Text = "控制"
        '
        'cmdAbout
        '
        Me.cmdAbout.Location = New System.Drawing.Point(9, 262)
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Size = New System.Drawing.Size(112, 34)
        Me.cmdAbout.TabIndex = 8
        Me.cmdAbout.Text = "关于"
        Me.cmdAbout.UseVisualStyleBackColor = True
        '
        'cmdSetting
        '
        Me.cmdSetting.Location = New System.Drawing.Point(9, 222)
        Me.cmdSetting.Name = "cmdSetting"
        Me.cmdSetting.Size = New System.Drawing.Size(112, 34)
        Me.cmdSetting.TabIndex = 7
        Me.cmdSetting.Text = "设置"
        Me.cmdSetting.UseVisualStyleBackColor = True
        '
        'spC
        '
        Me.spC.Location = New System.Drawing.Point(153, 0)
        Me.spC.Name = "spC"
        '
        'spC.Panel1
        '
        Me.spC.Panel1.Controls.Add(Me.grpRaw)
        '
        'spC.Panel2
        '
        Me.spC.Panel2.Controls.Add(Me.grpJSON)
        Me.spC.Size = New System.Drawing.Size(330, 296)
        Me.spC.SplitterDistance = 163
        Me.spC.TabIndex = 8
        '
        'grpRaw
        '
        Me.grpRaw.Controls.Add(Me.txtRaw)
        Me.grpRaw.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpRaw.Location = New System.Drawing.Point(0, 0)
        Me.grpRaw.Name = "grpRaw"
        Me.grpRaw.Size = New System.Drawing.Size(163, 296)
        Me.grpRaw.TabIndex = 4
        Me.grpRaw.TabStop = False
        Me.grpRaw.Text = "源文本"
        '
        'txtRaw
        '
        Me.txtRaw.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRaw.Location = New System.Drawing.Point(3, 17)
        Me.txtRaw.Multiline = True
        Me.txtRaw.Name = "txtRaw"
        Me.txtRaw.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtRaw.Size = New System.Drawing.Size(157, 276)
        Me.txtRaw.TabIndex = 1
        Me.txtRaw.WordWrap = False
        '
        'grpJSON
        '
        Me.grpJSON.Controls.Add(Me.txtTransformed)
        Me.grpJSON.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpJSON.Location = New System.Drawing.Point(0, 0)
        Me.grpJSON.Name = "grpJSON"
        Me.grpJSON.Size = New System.Drawing.Size(163, 296)
        Me.grpJSON.TabIndex = 5
        Me.grpJSON.TabStop = False
        Me.grpJSON.Text = "JSON"
        '
        'txtTransformed
        '
        Me.txtTransformed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTransformed.Location = New System.Drawing.Point(3, 17)
        Me.txtTransformed.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTransformed.Multiline = True
        Me.txtTransformed.Name = "txtTransformed"
        Me.txtTransformed.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTransformed.Size = New System.Drawing.Size(157, 276)
        Me.txtTransformed.TabIndex = 1
        Me.txtTransformed.WordWrap = False
        '
        'bgW
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(132, 305)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(354, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbStatus
        '
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(54, 17)
        Me.lbStatus.Text = "lbStatus"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 327)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.spC)
        Me.Controls.Add(Me.grpCtrl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(400, 300)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.grpCtrl.ResumeLayout(False)
        Me.grpCtrl.PerformLayout()
        Me.spC.Panel1.ResumeLayout(False)
        Me.spC.Panel2.ResumeLayout(False)
        CType(Me.spC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spC.ResumeLayout(False)
        Me.grpRaw.ResumeLayout(False)
        Me.grpRaw.PerformLayout()
        Me.grpJSON.ResumeLayout(False)
        Me.grpJSON.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdTransform As Button
    Friend WithEvents txtStartLine As TextBox
    Friend WithEvents lbStartLine As Label
    Friend WithEvents grpCtrl As GroupBox
    Friend WithEvents spC As SplitContainer
    Friend WithEvents grpRaw As GroupBox
    Friend WithEvents txtRaw As TextBox
    Friend WithEvents grpJSON As GroupBox
    Friend WithEvents txtTransformed As TextBox
    Friend WithEvents cmdSetting As Button
    Friend WithEvents cmdAbout As Button
    Friend WithEvents bgW As System.ComponentModel.BackgroundWorker
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lbStatus As ToolStripStatusLabel
End Class
