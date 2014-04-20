<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VoidVector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VoidVector))
        Me.canvasVVRose = New System.Windows.Forms.PictureBox
        Me.chkVVWeight = New System.Windows.Forms.CheckBox
        Me.chkVVTop = New System.Windows.Forms.CheckBox
        Me.gbVVFabric = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.lbVVTs11 = New System.Windows.Forms.Label
        Me.lbVVTs12 = New System.Windows.Forms.Label
        Me.lbVVTs21 = New System.Windows.Forms.Label
        Me.lbVVTs22 = New System.Windows.Forms.Label
        Me.lbVVTsI = New System.Windows.Forms.Label
        Me.lbVVTsII = New System.Windows.Forms.Label
        Me.lbVVTsAng1 = New System.Windows.Forms.Label
        Me.lbVVTsAng2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.canvasVVRose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbVVFabric.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'canvasVVRose
        '
        Me.canvasVVRose.BackColor = System.Drawing.Color.White
        Me.canvasVVRose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.canvasVVRose.Location = New System.Drawing.Point(3, 3)
        Me.canvasVVRose.Name = "canvasVVRose"
        Me.canvasVVRose.Size = New System.Drawing.Size(400, 400)
        Me.canvasVVRose.TabIndex = 0
        Me.canvasVVRose.TabStop = False
        '
        'chkVVWeight
        '
        Me.chkVVWeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkVVWeight.AutoSize = True
        Me.chkVVWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkVVWeight.ForeColor = System.Drawing.Color.White
        Me.chkVVWeight.Location = New System.Drawing.Point(3, 410)
        Me.chkVVWeight.Name = "chkVVWeight"
        Me.chkVVWeight.Size = New System.Drawing.Size(84, 21)
        Me.chkVVWeight.TabIndex = 1
        Me.chkVVWeight.Text = "Weighted"
        Me.chkVVWeight.UseVisualStyleBackColor = True
        '
        'chkVVTop
        '
        Me.chkVVTop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkVVTop.AutoSize = True
        Me.chkVVTop.Checked = True
        Me.chkVVTop.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVVTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkVVTop.ForeColor = System.Drawing.Color.White
        Me.chkVVTop.Location = New System.Drawing.Point(136, 409)
        Me.chkVVTop.Name = "chkVVTop"
        Me.chkVVTop.Size = New System.Drawing.Size(49, 21)
        Me.chkVVTop.TabIndex = 2
        Me.chkVVTop.Text = "Top"
        Me.chkVVTop.UseVisualStyleBackColor = True
        '
        'gbVVFabric
        '
        Me.gbVVFabric.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbVVFabric.Controls.Add(Me.TableLayoutPanel1)
        Me.gbVVFabric.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbVVFabric.ForeColor = System.Drawing.Color.White
        Me.gbVVFabric.Location = New System.Drawing.Point(3, 437)
        Me.gbVVFabric.Name = "gbVVFabric"
        Me.gbVVFabric.Size = New System.Drawing.Size(391, 107)
        Me.gbVVFabric.TabIndex = 3
        Me.gbVVFabric.TabStop = False
        Me.gbVVFabric.Text = "Void Fabric Tensor"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbVVTs11, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbVVTs12, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbVVTs21, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbVVTs22, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbVVTsI, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbVVTsII, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbVVTsAng1, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbVVTsAng2, 3, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(9, 21)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(376, 74)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lbVVTs11
        '
        Me.lbVVTs11.AutoSize = True
        Me.lbVVTs11.Location = New System.Drawing.Point(3, 0)
        Me.lbVVTs11.Name = "lbVVTs11"
        Me.lbVVTs11.Size = New System.Drawing.Size(51, 17)
        Me.lbVVTs11.TabIndex = 0
        Me.lbVVTs11.Text = "Label1"
        '
        'lbVVTs12
        '
        Me.lbVVTs12.AutoSize = True
        Me.lbVVTs12.Location = New System.Drawing.Point(97, 0)
        Me.lbVVTs12.Name = "lbVVTs12"
        Me.lbVVTs12.Size = New System.Drawing.Size(51, 17)
        Me.lbVVTs12.TabIndex = 1
        Me.lbVVTs12.Text = "Label2"
        '
        'lbVVTs21
        '
        Me.lbVVTs21.AutoSize = True
        Me.lbVVTs21.Location = New System.Drawing.Point(3, 37)
        Me.lbVVTs21.Name = "lbVVTs21"
        Me.lbVVTs21.Size = New System.Drawing.Size(51, 17)
        Me.lbVVTs21.TabIndex = 2
        Me.lbVVTs21.Text = "Label3"
        '
        'lbVVTs22
        '
        Me.lbVVTs22.AutoSize = True
        Me.lbVVTs22.Location = New System.Drawing.Point(97, 37)
        Me.lbVVTs22.Name = "lbVVTs22"
        Me.lbVVTs22.Size = New System.Drawing.Size(51, 17)
        Me.lbVVTs22.TabIndex = 3
        Me.lbVVTs22.Text = "Label4"
        '
        'lbVVTsI
        '
        Me.lbVVTsI.AutoSize = True
        Me.lbVVTsI.Location = New System.Drawing.Point(191, 0)
        Me.lbVVTsI.Name = "lbVVTsI"
        Me.lbVVTsI.Size = New System.Drawing.Size(51, 17)
        Me.lbVVTsI.TabIndex = 4
        Me.lbVVTsI.Text = "Label5"
        '
        'lbVVTsII
        '
        Me.lbVVTsII.AutoSize = True
        Me.lbVVTsII.Location = New System.Drawing.Point(191, 37)
        Me.lbVVTsII.Name = "lbVVTsII"
        Me.lbVVTsII.Size = New System.Drawing.Size(51, 17)
        Me.lbVVTsII.TabIndex = 5
        Me.lbVVTsII.Text = "Label6"
        '
        'lbVVTsAng1
        '
        Me.lbVVTsAng1.AutoSize = True
        Me.lbVVTsAng1.Location = New System.Drawing.Point(285, 0)
        Me.lbVVTsAng1.Name = "lbVVTsAng1"
        Me.lbVVTsAng1.Size = New System.Drawing.Size(51, 17)
        Me.lbVVTsAng1.TabIndex = 6
        Me.lbVVTsAng1.Text = "Label7"
        '
        'lbVVTsAng2
        '
        Me.lbVVTsAng2.AutoSize = True
        Me.lbVVTsAng2.Location = New System.Drawing.Point(285, 37)
        Me.lbVVTsAng2.Name = "lbVVTsAng2"
        Me.lbVVTsAng2.Size = New System.Drawing.Size(51, 17)
        Me.lbVVTsAng2.TabIndex = 7
        Me.lbVVTsAng2.Text = "Label8"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Rose diagram, void vector, weighted by length"
        '
        'VoidVector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(406, 648)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbVVFabric)
        Me.Controls.Add(Me.chkVVTop)
        Me.Controls.Add(Me.chkVVWeight)
        Me.Controls.Add(Me.canvasVVRose)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(414, 680)
        Me.Name = "VoidVector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Void Cell Fabric"
        Me.TopMost = True
        CType(Me.canvasVVRose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbVVFabric.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents canvasVVRose As System.Windows.Forms.PictureBox
    Friend WithEvents chkVVWeight As System.Windows.Forms.CheckBox
    Friend WithEvents chkVVTop As System.Windows.Forms.CheckBox
    Friend WithEvents gbVVFabric As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbVVTs11 As System.Windows.Forms.Label
    Friend WithEvents lbVVTs12 As System.Windows.Forms.Label
    Friend WithEvents lbVVTs21 As System.Windows.Forms.Label
    Friend WithEvents lbVVTs22 As System.Windows.Forms.Label
    Friend WithEvents lbVVTsI As System.Windows.Forms.Label
    Friend WithEvents lbVVTsII As System.Windows.Forms.Label
    Friend WithEvents lbVVTsAng1 As System.Windows.Forms.Label
    Friend WithEvents lbVVTsAng2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
