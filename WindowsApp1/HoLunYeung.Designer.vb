<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHoLunYeung
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.BillName = New System.Windows.Forms.Label()
        Me.BellysName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(71, 70)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(123, 76)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Tag = ""
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'BillName
        '
        Me.BillName.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BillName.Location = New System.Drawing.Point(46, 9)
        Me.BillName.Name = "BillName"
        Me.BillName.Size = New System.Drawing.Size(182, 58)
        Me.BillName.TabIndex = 1
        Me.BillName.Text = "Name"
        Me.BillName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BellysName
        '
        Me.BellysName.BackColor = System.Drawing.Color.Yellow
        Me.BellysName.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BellysName.Location = New System.Drawing.Point(2, 149)
        Me.BellysName.Name = "BellysName"
        Me.BellysName.Size = New System.Drawing.Size(286, 58)
        Me.BellysName.TabIndex = 2
        Me.BellysName.Text = "HO LUN YEUNG"
        Me.BellysName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmHoLunYeung
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.BellysName)
        Me.Controls.Add(Me.BillName)
        Me.Controls.Add(Me.btnExit)
        Me.MaximumSize = New System.Drawing.Size(300, 300)
        Me.Name = "frmHoLunYeung"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "My first 115 lab."
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents BillName As Label
    Friend WithEvents BellysName As Label
End Class
