<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.frsttreeview = New System.Windows.Forms.TreeView()
        Me.ADDNODE = New System.Windows.Forms.Button()
        Me.delnode = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'frsttreeview
        '
        Me.frsttreeview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.frsttreeview.Location = New System.Drawing.Point(12, 67)
        Me.frsttreeview.Name = "frsttreeview"
        Me.frsttreeview.Size = New System.Drawing.Size(265, 595)
        Me.frsttreeview.TabIndex = 0
        '
        'ADDNODE
        '
        Me.ADDNODE.Location = New System.Drawing.Point(307, 67)
        Me.ADDNODE.Name = "ADDNODE"
        Me.ADDNODE.Size = New System.Drawing.Size(129, 35)
        Me.ADDNODE.TabIndex = 1
        Me.ADDNODE.Text = "ADD NODE"
        Me.ADDNODE.UseVisualStyleBackColor = True
        '
        'delnode
        '
        Me.delnode.Location = New System.Drawing.Point(307, 132)
        Me.delnode.Name = "delnode"
        Me.delnode.Size = New System.Drawing.Size(129, 35)
        Me.delnode.TabIndex = 2
        Me.delnode.Text = "DELETE NODE"
        Me.delnode.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "SAMPLE TREE VIEW"
        '
        'Form1
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 683)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.delnode)
        Me.Controls.Add(Me.ADDNODE)
        Me.Controls.Add(Me.frsttreeview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents frsttreeview As TreeView
    Friend WithEvents ADDNODE As Button
    Friend WithEvents delnode As Button
    Friend WithEvents Label1 As Label
End Class
