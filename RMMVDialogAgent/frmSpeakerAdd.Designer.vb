<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpeakerAdd
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.txtIndex = New System.Windows.Forms.TextBox()
        Me.txtHeadset = New System.Windows.Forms.TextBox()
        Me.lbIndex = New System.Windows.Forms.Label()
        Me.lbHeadset = New System.Windows.Forms.Label()
        Me.cmdAccept = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbMore = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmdCancel, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtIndex, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtHeadset, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbIndex, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbHeadset, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdAccept, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtName, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbName, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbMore, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.13514!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.86487!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(333, 70)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Abort
        Me.cmdCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdCancel.Location = New System.Drawing.Point(223, 43)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(107, 24)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "取消"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'txtIndex
        '
        Me.txtIndex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtIndex.Location = New System.Drawing.Point(223, 17)
        Me.txtIndex.Name = "txtIndex"
        Me.txtIndex.Size = New System.Drawing.Size(107, 21)
        Me.txtIndex.TabIndex = 6
        '
        'txtHeadset
        '
        Me.txtHeadset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtHeadset.Location = New System.Drawing.Point(113, 17)
        Me.txtHeadset.Name = "txtHeadset"
        Me.txtHeadset.Size = New System.Drawing.Size(104, 21)
        Me.txtHeadset.TabIndex = 5
        '
        'lbIndex
        '
        Me.lbIndex.AutoSize = True
        Me.lbIndex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbIndex.Location = New System.Drawing.Point(223, 0)
        Me.lbIndex.Name = "lbIndex"
        Me.lbIndex.Size = New System.Drawing.Size(107, 14)
        Me.lbIndex.TabIndex = 3
        Me.lbIndex.Text = "序号:"
        '
        'lbHeadset
        '
        Me.lbHeadset.AutoSize = True
        Me.lbHeadset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbHeadset.Location = New System.Drawing.Point(113, 0)
        Me.lbHeadset.Name = "lbHeadset"
        Me.lbHeadset.Size = New System.Drawing.Size(104, 14)
        Me.lbHeadset.TabIndex = 2
        Me.lbHeadset.Text = "所属集:"
        '
        'cmdAccept
        '
        Me.cmdAccept.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdAccept.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdAccept.Location = New System.Drawing.Point(3, 43)
        Me.cmdAccept.Name = "cmdAccept"
        Me.cmdAccept.Size = New System.Drawing.Size(104, 24)
        Me.cmdAccept.TabIndex = 1
        Me.cmdAccept.Text = "确认"
        Me.cmdAccept.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtName.Location = New System.Drawing.Point(3, 17)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(104, 21)
        Me.txtName.TabIndex = 4
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbName.Location = New System.Drawing.Point(3, 0)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(104, 14)
        Me.lbName.TabIndex = 0
        Me.lbName.Text = "角色姓名:"
        '
        'lbMore
        '
        Me.lbMore.AutoSize = True
        Me.lbMore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbMore.Location = New System.Drawing.Point(113, 40)
        Me.lbMore.Name = "lbMore"
        Me.lbMore.Size = New System.Drawing.Size(104, 30)
        Me.lbMore.TabIndex = 7
        Me.lbMore.Text = "lbMore"
        '
        'frmSpeakerAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 70)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmSpeakerAdd"
        Me.Text = "添加"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cmdCancel As Button
    Friend WithEvents txtIndex As TextBox
    Friend WithEvents txtHeadset As TextBox
    Friend WithEvents lbIndex As Label
    Friend WithEvents lbHeadset As Label
    Friend WithEvents cmdAccept As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents lbName As Label
    Friend WithEvents lbMore As Label
End Class
