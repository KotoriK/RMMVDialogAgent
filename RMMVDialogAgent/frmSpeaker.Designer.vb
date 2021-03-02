<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpeaker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSpeaker))
        Me.tlpList = New System.Windows.Forms.TableLayoutPanel()
        Me.lstIndex = New System.Windows.Forms.ListBox()
        Me.lstHeadset = New System.Windows.Forms.ListBox()
        Me.tlpCtrl = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdRefreshfromFile = New System.Windows.Forms.Button()
        Me.cmdRefreshToFile = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.lstName = New System.Windows.Forms.ListBox()
        Me.tlpList.SuspendLayout()
        Me.tlpCtrl.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpList
        '
        Me.tlpList.ColumnCount = 4
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.75472!))
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.24528!))
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97.0!))
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104.0!))
        Me.tlpList.Controls.Add(Me.lstIndex, 2, 0)
        Me.tlpList.Controls.Add(Me.lstHeadset, 1, 0)
        Me.tlpList.Controls.Add(Me.tlpCtrl, 3, 0)
        Me.tlpList.Controls.Add(Me.lstName, 0, 0)
        Me.tlpList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpList.Location = New System.Drawing.Point(0, 0)
        Me.tlpList.Name = "tlpList"
        Me.tlpList.RowCount = 1
        Me.tlpList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpList.Size = New System.Drawing.Size(415, 278)
        Me.tlpList.TabIndex = 0
        '
        'lstIndex
        '
        Me.lstIndex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstIndex.FormattingEnabled = True
        Me.lstIndex.ItemHeight = 12
        Me.lstIndex.Location = New System.Drawing.Point(216, 3)
        Me.lstIndex.Name = "lstIndex"
        Me.lstIndex.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstIndex.Size = New System.Drawing.Size(91, 272)
        Me.lstIndex.TabIndex = 3
        '
        'lstHeadset
        '
        Me.lstHeadset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstHeadset.FormattingEnabled = True
        Me.lstHeadset.ItemHeight = 12
        Me.lstHeadset.Location = New System.Drawing.Point(100, 3)
        Me.lstHeadset.Name = "lstHeadset"
        Me.lstHeadset.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstHeadset.Size = New System.Drawing.Size(110, 272)
        Me.lstHeadset.TabIndex = 2
        '
        'tlpCtrl
        '
        Me.tlpCtrl.ColumnCount = 1
        Me.tlpCtrl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpCtrl.Controls.Add(Me.cmdDelete, 0, 1)
        Me.tlpCtrl.Controls.Add(Me.cmdAdd, 0, 0)
        Me.tlpCtrl.Controls.Add(Me.cmdRefreshfromFile, 0, 2)
        Me.tlpCtrl.Controls.Add(Me.cmdRefreshToFile, 0, 3)
        Me.tlpCtrl.Controls.Add(Me.cmdClose, 0, 4)
        Me.tlpCtrl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCtrl.Location = New System.Drawing.Point(313, 3)
        Me.tlpCtrl.Name = "tlpCtrl"
        Me.tlpCtrl.RowCount = 5
        Me.tlpCtrl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpCtrl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpCtrl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.tlpCtrl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.tlpCtrl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.tlpCtrl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpCtrl.Size = New System.Drawing.Size(99, 272)
        Me.tlpCtrl.TabIndex = 0
        '
        'cmdDelete
        '
        Me.cmdDelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdDelete.Location = New System.Drawing.Point(3, 61)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(93, 52)
        Me.cmdDelete.TabIndex = 1
        Me.cmdDelete.Text = "删除"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdAdd.Location = New System.Drawing.Point(3, 3)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(93, 52)
        Me.cmdAdd.TabIndex = 0
        Me.cmdAdd.Text = "添加"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdRefreshfromFile
        '
        Me.cmdRefreshfromFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdRefreshfromFile.Location = New System.Drawing.Point(3, 119)
        Me.cmdRefreshfromFile.Name = "cmdRefreshfromFile"
        Me.cmdRefreshfromFile.Size = New System.Drawing.Size(93, 48)
        Me.cmdRefreshfromFile.TabIndex = 3
        Me.cmdRefreshfromFile.Text = "从文件中更新"
        Me.cmdRefreshfromFile.UseVisualStyleBackColor = True
        '
        'cmdRefreshToFile
        '
        Me.cmdRefreshToFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdRefreshToFile.Enabled = False
        Me.cmdRefreshToFile.Location = New System.Drawing.Point(3, 173)
        Me.cmdRefreshToFile.Name = "cmdRefreshToFile"
        Me.cmdRefreshToFile.Size = New System.Drawing.Size(93, 41)
        Me.cmdRefreshToFile.TabIndex = 5
        Me.cmdRefreshToFile.Text = "更新至文件"
        Me.cmdRefreshToFile.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(3, 220)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(93, 49)
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.Text = "关闭"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'lstName
        '
        Me.lstName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstName.FormattingEnabled = True
        Me.lstName.ItemHeight = 12
        Me.lstName.Location = New System.Drawing.Point(3, 3)
        Me.lstName.Name = "lstName"
        Me.lstName.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstName.Size = New System.Drawing.Size(91, 272)
        Me.lstName.TabIndex = 1
        '
        'frmSpeaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 278)
        Me.Controls.Add(Me.tlpList)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSpeaker"
        Me.Text = "角色管理"
        Me.tlpList.ResumeLayout(False)
        Me.tlpCtrl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpList As TableLayoutPanel
    Friend WithEvents lstIndex As ListBox
    Friend WithEvents lstHeadset As ListBox
    Friend WithEvents tlpCtrl As TableLayoutPanel
    Friend WithEvents lstName As ListBox
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdRefreshfromFile As Button
    Friend WithEvents cmdRefreshToFile As Button
End Class
