<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSQL
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSQLQuery = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
<<<<<<< HEAD
        Me.dgvOutput = New System.Windows.Forms.DataGridView()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
=======
<<<<<<< HEAD
        Me.btnRun = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
=======
        Me.btnExecuteQuery = New System.Windows.Forms.Button()
        Me.dgvOutput = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDBName = New System.Windows.Forms.TextBox()
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).BeginInit()
>>>>>>> 1847373fed29409afa5ab8f16df2430bbe020e9f
>>>>>>> 67b1cbe9fdb458dca05292ad452a5996524bc65e
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
<<<<<<< HEAD
        Me.Label4.Location = New System.Drawing.Point(-91, 243)
=======
<<<<<<< HEAD
        Me.Label4.Location = New System.Drawing.Point(-91, 224)
=======
        Me.Label4.Location = New System.Drawing.Point(-91, 335)
>>>>>>> 1847373fed29409afa5ab8f16df2430bbe020e9f
>>>>>>> 67b1cbe9fdb458dca05292ad452a5996524bc65e
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "SQL Query:"
        '
        'txtSQLQuery
        '
        Me.txtSQLQuery.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSQLQuery.Location = New System.Drawing.Point(12, 27)
        Me.txtSQLQuery.Multiline = True
        Me.txtSQLQuery.Name = "txtSQLQuery"
        Me.txtSQLQuery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
<<<<<<< HEAD
        Me.txtSQLQuery.Size = New System.Drawing.Size(994, 115)
=======
        Me.txtSQLQuery.Size = New System.Drawing.Size(1028, 90)
>>>>>>> 67b1cbe9fdb458dca05292ad452a5996524bc65e
        Me.txtSQLQuery.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
<<<<<<< HEAD
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Generated SQL:"
=======
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Generated SQL"
>>>>>>> 67b1cbe9fdb458dca05292ad452a5996524bc65e
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(12, 441)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
<<<<<<< HEAD
        'dgvOutput
        '
        Me.dgvOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOutput.Location = New System.Drawing.Point(12, 194)
        Me.dgvOutput.Name = "dgvOutput"
        Me.dgvOutput.Size = New System.Drawing.Size(994, 315)
        Me.dgvOutput.TabIndex = 14
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(114, 152)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 23)
        Me.btnRun.TabIndex = 15
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 499)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1021, 22)
        Me.StatusStrip1.TabIndex = 16
=======
<<<<<<< HEAD
        'btnRun
        '
        Me.btnRun.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRun.Location = New System.Drawing.Point(108, 441)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 23)
        Me.btnRun.TabIndex = 14
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToOrderColumns = True
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(3, 16)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(1019, 275)
        Me.dgv.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1025, 294)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 480)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1055, 22)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = "StatusStrip1"
>>>>>>> 67b1cbe9fdb458dca05292ad452a5996524bc65e
        '
        'tssLabel1
        '
        Me.tssLabel1.Name = "tssLabel1"
        Me.tssLabel1.Size = New System.Drawing.Size(0, 17)
<<<<<<< HEAD
=======
=======
        'btnExecuteQuery
        '
        Me.btnExecuteQuery.Location = New System.Drawing.Point(374, 152)
        Me.btnExecuteQuery.Name = "btnExecuteQuery"
        Me.btnExecuteQuery.Size = New System.Drawing.Size(116, 23)
        Me.btnExecuteQuery.TabIndex = 14
        Me.btnExecuteQuery.Text = "Execute Query"
        Me.btnExecuteQuery.UseVisualStyleBackColor = True
        '
        'dgvOutput
        '
        Me.dgvOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOutput.Location = New System.Drawing.Point(12, 233)
        Me.dgvOutput.Name = "dgvOutput"
        Me.dgvOutput.Size = New System.Drawing.Size(849, 368)
        Me.dgvOutput.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Database:"
        '
        'txtDBName
        '
        Me.txtDBName.Location = New System.Drawing.Point(278, 6)
        Me.txtDBName.Name = "txtDBName"
        Me.txtDBName.Size = New System.Drawing.Size(311, 20)
        Me.txtDBName.TabIndex = 17
>>>>>>> 1847373fed29409afa5ab8f16df2430bbe020e9f
>>>>>>> 67b1cbe9fdb458dca05292ad452a5996524bc65e
        '
        'ViewSQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< HEAD
        Me.ClientSize = New System.Drawing.Size(1021, 521)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.dgvOutput)
=======
<<<<<<< HEAD
        Me.ClientSize = New System.Drawing.Size(1055, 502)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRun)
=======
        Me.ClientSize = New System.Drawing.Size(876, 613)
        Me.Controls.Add(Me.txtDBName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvOutput)
        Me.Controls.Add(Me.btnExecuteQuery)
>>>>>>> 1847373fed29409afa5ab8f16df2430bbe020e9f
>>>>>>> 67b1cbe9fdb458dca05292ad452a5996524bc65e
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSQLQuery)
        Me.Name = "ViewSQL"
        Me.Text = "ViewSQL"
<<<<<<< HEAD
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
=======
<<<<<<< HEAD
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
=======
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).EndInit()
>>>>>>> 1847373fed29409afa5ab8f16df2430bbe020e9f
>>>>>>> 67b1cbe9fdb458dca05292ad452a5996524bc65e
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents txtSQLQuery As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
<<<<<<< HEAD
    Friend WithEvents dgvOutput As DataGridView
    Friend WithEvents btnRun As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tssLabel1 As ToolStripStatusLabel
=======
<<<<<<< HEAD
    Friend WithEvents btnRun As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tssLabel1 As ToolStripStatusLabel
=======
    Friend WithEvents btnExecuteQuery As Button
    Friend WithEvents dgvOutput As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDBName As TextBox
>>>>>>> 1847373fed29409afa5ab8f16df2430bbe020e9f
>>>>>>> 67b1cbe9fdb458dca05292ad452a5996524bc65e
End Class
