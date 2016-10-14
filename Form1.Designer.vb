<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveOutputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstMeans = New System.Windows.Forms.ListBox()
        Me.btnMeans = New System.Windows.Forms.Button()
        Me.lstSizes = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pooledYes = New System.Windows.Forms.RadioButton()
        Me.PooledNo = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMeanSquared2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMeanSquared1 = New System.Windows.Forms.TextBox()
        Me.txtDegreesFree1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDegreesFree2 = New System.Windows.Forms.TextBox()
        Me.radF = New System.Windows.Forms.RadioButton()
        Me.radT = New System.Windows.Forms.RadioButton()
        Me.radQ = New System.Windows.Forms.RadioButton()
        Me.btnGenerateOutput = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSizes = New System.Windows.Forms.TextBox()
        Me.btnSizes = New System.Windows.Forms.Button()
        Me.txtMeans = New System.Windows.Forms.TextBox()
        Me.btnRSize = New System.Windows.Forms.Button()
        Me.btnRMeans = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtOutput
        '
        Me.txtOutput.BackColor = System.Drawing.SystemColors.Window
        Me.txtOutput.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(21, 373)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(500, 159)
        Me.txtOutput.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(234, 357)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Output"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Means"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(533, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveOutputToolStripMenuItem, Me.SaveAsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveOutputToolStripMenuItem
        '
        Me.SaveOutputToolStripMenuItem.Name = "SaveOutputToolStripMenuItem"
        Me.SaveOutputToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SaveOutputToolStripMenuItem.Text = "Save Output"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save Output As"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ManualToolStripMenuItem
        '
        Me.ManualToolStripMenuItem.Name = "ManualToolStripMenuItem"
        Me.ManualToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ManualToolStripMenuItem.Text = "Manual"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'lstMeans
        '
        Me.lstMeans.FormattingEnabled = True
        Me.lstMeans.Location = New System.Drawing.Point(12, 56)
        Me.lstMeans.Name = "lstMeans"
        Me.lstMeans.Size = New System.Drawing.Size(105, 238)
        Me.lstMeans.TabIndex = 0
        '
        'btnMeans
        '
        Me.btnMeans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnMeans.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnMeans.Location = New System.Drawing.Point(92, 300)
        Me.btnMeans.Name = "btnMeans"
        Me.btnMeans.Size = New System.Drawing.Size(25, 23)
        Me.btnMeans.TabIndex = 3
        Me.btnMeans.Text = "+"
        Me.btnMeans.UseVisualStyleBackColor = True
        '
        'lstSizes
        '
        Me.lstSizes.FormattingEnabled = True
        Me.lstSizes.Location = New System.Drawing.Point(123, 57)
        Me.lstSizes.Name = "lstSizes"
        Me.lstSizes.Size = New System.Drawing.Size(105, 238)
        Me.lstSizes.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(106, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Sample Size for Each Mean"
        '
        'pooledYes
        '
        Me.pooledYes.AutoSize = True
        Me.pooledYes.Location = New System.Drawing.Point(200, 19)
        Me.pooledYes.Name = "pooledYes"
        Me.pooledYes.Size = New System.Drawing.Size(43, 17)
        Me.pooledYes.TabIndex = 1
        Me.pooledYes.TabStop = True
        Me.pooledYes.Text = "Yes"
        Me.pooledYes.UseVisualStyleBackColor = True
        '
        'PooledNo
        '
        Me.PooledNo.AutoSize = True
        Me.PooledNo.Checked = True
        Me.PooledNo.Location = New System.Drawing.Point(141, 19)
        Me.PooledNo.Name = "PooledNo"
        Me.PooledNo.Size = New System.Drawing.Size(39, 17)
        Me.PooledNo.TabIndex = 0
        Me.PooledNo.TabStop = True
        Me.PooledNo.Text = "No"
        Me.PooledNo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Compute Pooled Error:"
        '
        'txtMeanSquared2
        '
        Me.txtMeanSquared2.Location = New System.Drawing.Point(437, 116)
        Me.txtMeanSquared2.Name = "txtMeanSquared2"
        Me.txtMeanSquared2.Size = New System.Drawing.Size(69, 20)
        Me.txtMeanSquared2.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(234, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Mean Squared Error"
        '
        'txtMeanSquared1
        '
        Me.txtMeanSquared1.Location = New System.Drawing.Point(362, 116)
        Me.txtMeanSquared1.Name = "txtMeanSquared1"
        Me.txtMeanSquared1.Size = New System.Drawing.Size(69, 20)
        Me.txtMeanSquared1.TabIndex = 9
        '
        'txtDegreesFree1
        '
        Me.txtDegreesFree1.Location = New System.Drawing.Point(362, 145)
        Me.txtDegreesFree1.Name = "txtDegreesFree1"
        Me.txtDegreesFree1.Size = New System.Drawing.Size(69, 20)
        Me.txtDegreesFree1.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(234, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Degrees of Freedom"
        '
        'txtDegreesFree2
        '
        Me.txtDegreesFree2.Location = New System.Drawing.Point(437, 145)
        Me.txtDegreesFree2.Name = "txtDegreesFree2"
        Me.txtDegreesFree2.Size = New System.Drawing.Size(69, 20)
        Me.txtDegreesFree2.TabIndex = 12
        '
        'radF
        '
        Me.radF.AutoSize = True
        Me.radF.Location = New System.Drawing.Point(173, 30)
        Me.radF.Name = "radF"
        Me.radF.Size = New System.Drawing.Size(76, 17)
        Me.radF.TabIndex = 2
        Me.radF.TabStop = True
        Me.radF.Text = "F-Statistics"
        Me.radF.UseVisualStyleBackColor = True
        '
        'radT
        '
        Me.radT.AutoSize = True
        Me.radT.Location = New System.Drawing.Point(90, 30)
        Me.radT.Name = "radT"
        Me.radT.Size = New System.Drawing.Size(77, 17)
        Me.radT.TabIndex = 1
        Me.radT.TabStop = True
        Me.radT.Text = "T-Statistics"
        Me.radT.UseVisualStyleBackColor = True
        '
        'radQ
        '
        Me.radQ.AutoSize = True
        Me.radQ.Checked = True
        Me.radQ.Location = New System.Drawing.Point(6, 30)
        Me.radQ.Name = "radQ"
        Me.radQ.Size = New System.Drawing.Size(78, 17)
        Me.radQ.TabIndex = 0
        Me.radQ.TabStop = True
        Me.radQ.Text = "Q-Statistics"
        Me.radQ.UseVisualStyleBackColor = True
        '
        'btnGenerateOutput
        '
        Me.btnGenerateOutput.Location = New System.Drawing.Point(265, 300)
        Me.btnGenerateOutput.Name = "btnGenerateOutput"
        Me.btnGenerateOutput.Size = New System.Drawing.Size(221, 49)
        Me.btnGenerateOutput.TabIndex = 14
        Me.btnGenerateOutput.Text = "Run"
        Me.btnGenerateOutput.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radQ)
        Me.GroupBox1.Controls.Add(Me.radT)
        Me.GroupBox1.Controls.Add(Me.radF)
        Me.GroupBox1.Location = New System.Drawing.Point(237, 199)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 66)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "StatisticType"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pooledYes)
        Me.GroupBox2.Controls.Add(Me.PooledNo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(237, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(269, 53)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'txtSizes
        '
        Me.txtSizes.Location = New System.Drawing.Point(123, 301)
        Me.txtSizes.Name = "txtSizes"
        Me.txtSizes.Size = New System.Drawing.Size(77, 20)
        Me.txtSizes.TabIndex = 5
        Me.txtSizes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSizes
        '
        Me.btnSizes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSizes.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnSizes.Location = New System.Drawing.Point(203, 300)
        Me.btnSizes.Name = "btnSizes"
        Me.btnSizes.Size = New System.Drawing.Size(25, 23)
        Me.btnSizes.TabIndex = 6
        Me.btnSizes.Text = "+"
        Me.btnSizes.UseVisualStyleBackColor = True
        '
        'txtMeans
        '
        Me.txtMeans.Location = New System.Drawing.Point(12, 300)
        Me.txtMeans.Name = "txtMeans"
        Me.txtMeans.Size = New System.Drawing.Size(77, 20)
        Me.txtMeans.TabIndex = 2
        Me.txtMeans.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnRSize
        '
        Me.btnRSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRSize.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnRSize.Location = New System.Drawing.Point(121, 326)
        Me.btnRSize.Name = "btnRSize"
        Me.btnRSize.Size = New System.Drawing.Size(107, 23)
        Me.btnRSize.TabIndex = 7
        Me.btnRSize.Text = "Remove Selected"
        Me.btnRSize.UseVisualStyleBackColor = True
        '
        'btnRMeans
        '
        Me.btnRMeans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRMeans.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnRMeans.Location = New System.Drawing.Point(12, 326)
        Me.btnRMeans.Name = "btnRMeans"
        Me.btnRMeans.Size = New System.Drawing.Size(105, 23)
        Me.btnRMeans.TabIndex = 4
        Me.btnRMeans.Text = "Remove Selected"
        Me.btnRMeans.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 544)
        Me.Controls.Add(Me.btnRMeans)
        Me.Controls.Add(Me.btnRSize)
        Me.Controls.Add(Me.txtMeans)
        Me.Controls.Add(Me.btnSizes)
        Me.Controls.Add(Me.txtSizes)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnGenerateOutput)
        Me.Controls.Add(Me.txtDegreesFree1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDegreesFree2)
        Me.Controls.Add(Me.txtMeanSquared1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMeanSquared2)
        Me.Controls.Add(Me.lstSizes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnMeans)
        Me.Controls.Add(Me.lstMeans)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "POSTHOC"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveOutputToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstMeans As ListBox
    Friend WithEvents btnMeans As Button
    Friend WithEvents lstSizes As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents pooledYes As RadioButton
    Friend WithEvents PooledNo As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMeanSquared2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMeanSquared1 As TextBox
    Friend WithEvents txtDegreesFree1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDegreesFree2 As TextBox
    Friend WithEvents radF As RadioButton
    Friend WithEvents radT As RadioButton
    Friend WithEvents radQ As RadioButton
    Friend WithEvents btnGenerateOutput As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtSizes As TextBox
    Friend WithEvents btnSizes As Button
    Friend WithEvents txtMeans As TextBox
    Friend WithEvents btnRSize As Button
    Friend WithEvents btnRMeans As Button
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
