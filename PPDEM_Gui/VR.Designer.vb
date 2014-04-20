<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VR))
        Me.VRBox = New System.Windows.Forms.PictureBox
        Me.setTransparency = New System.Windows.Forms.TrackBar
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.setVRRange = New System.Windows.Forms.NumericUpDown
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.showMaxDensity = New System.Windows.Forms.Label
        Me.showMinDensity = New System.Windows.Forms.Label
        Me.setMinDensity = New System.Windows.Forms.NumericUpDown
        Me.setMaxDensity = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnVoid = New System.Windows.Forms.Button
        Me.showBulkGrav = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.showBulkGravAll = New System.Windows.Forms.Label
        Me.btnNewVRMask = New System.Windows.Forms.Button
        Me.showVoidMask = New System.Windows.Forms.Label
        Me.VRContainer = New System.Windows.Forms.Panel
        Me.shwPpM = New System.Windows.Forms.Label
        Me.showHVR = New System.Windows.Forms.Label
        Me.showWVR = New System.Windows.Forms.Label
        Me.btnMagVR = New System.Windows.Forms.Button
        Me.setMagVR = New System.Windows.Forms.NumericUpDown
        Me.btnCloneMask = New System.Windows.Forms.Button
        Me.chkShowMagBMP = New System.Windows.Forms.CheckBox
        Me.btnTrack = New System.Windows.Forms.Button
        Me.chkAlwaysTop = New System.Windows.Forms.CheckBox
        Me.btnCellVR = New System.Windows.Forms.Button
        Me.setSizeVRCell = New System.Windows.Forms.NumericUpDown
        Me.chkGray = New System.Windows.Forms.CheckBox
        CType(Me.VRBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setTransparency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setVRRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setMinDensity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setMaxDensity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VRContainer.SuspendLayout()
        CType(Me.setMagVR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setSizeVRCell, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VRBox
        '
        Me.VRBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.VRBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VRBox.Location = New System.Drawing.Point(3, 1)
        Me.VRBox.Margin = New System.Windows.Forms.Padding(0)
        Me.VRBox.Name = "VRBox"
        Me.VRBox.Size = New System.Drawing.Size(397, 411)
        Me.VRBox.TabIndex = 0
        Me.VRBox.TabStop = False
        '
        'setTransparency
        '
        Me.setTransparency.AutoSize = False
        Me.setTransparency.Location = New System.Drawing.Point(9, 82)
        Me.setTransparency.Maximum = 90
        Me.setTransparency.Name = "setTransparency"
        Me.setTransparency.Size = New System.Drawing.Size(145, 30)
        Me.setTransparency.TabIndex = 1
        Me.setTransparency.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(24, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 25)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'setVRRange
        '
        Me.setVRRange.BackColor = System.Drawing.Color.DimGray
        Me.setVRRange.ForeColor = System.Drawing.Color.White
        Me.setVRRange.Location = New System.Drawing.Point(90, 211)
        Me.setVRRange.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.setVRRange.Name = "setVRRange"
        Me.setVRRange.Size = New System.Drawing.Size(64, 22)
        Me.setVRRange.TabIndex = 8
        Me.setVRRange.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'btnRefresh
        '
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Location = New System.Drawing.Point(9, 210)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 9
        Me.btnRefresh.Text = "Contour"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'showMaxDensity
        '
        Me.showMaxDensity.AutoSize = True
        Me.showMaxDensity.Location = New System.Drawing.Point(158, 7)
        Me.showMaxDensity.Name = "showMaxDensity"
        Me.showMaxDensity.Size = New System.Drawing.Size(33, 16)
        Me.showMaxDensity.TabIndex = 10
        Me.showMaxDensity.Text = "1.00"
        '
        'showMinDensity
        '
        Me.showMinDensity.AutoSize = True
        Me.showMinDensity.Location = New System.Drawing.Point(21, 7)
        Me.showMinDensity.Name = "showMinDensity"
        Me.showMinDensity.Size = New System.Drawing.Size(33, 16)
        Me.showMinDensity.TabIndex = 11
        Me.showMinDensity.Text = "0.00"
        '
        'setMinDensity
        '
        Me.setMinDensity.DecimalPlaces = 2
        Me.setMinDensity.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.setMinDensity.Location = New System.Drawing.Point(22, 50)
        Me.setMinDensity.Name = "setMinDensity"
        Me.setMinDensity.Size = New System.Drawing.Size(53, 22)
        Me.setMinDensity.TabIndex = 12
        Me.setMinDensity.Value = New Decimal(New Integer() {6, 0, 0, 65536})
        '
        'setMaxDensity
        '
        Me.setMaxDensity.DecimalPlaces = 2
        Me.setMaxDensity.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.setMaxDensity.Location = New System.Drawing.Point(136, 50)
        Me.setMaxDensity.Name = "setMaxDensity"
        Me.setMaxDensity.Size = New System.Drawing.Size(53, 22)
        Me.setMaxDensity.TabIndex = 12
        Me.setMaxDensity.Value = New Decimal(New Integer() {9, 0, 0, 65536})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Transparency"
        '
        'btnVoid
        '
        Me.btnVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoid.Location = New System.Drawing.Point(9, 173)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(75, 23)
        Me.btnVoid.TabIndex = 14
        Me.btnVoid.Text = "Void Ratio"
        Me.btnVoid.UseVisualStyleBackColor = True
        '
        'showBulkGrav
        '
        Me.showBulkGrav.AutoSize = True
        Me.showBulkGrav.Location = New System.Drawing.Point(97, 182)
        Me.showBulkGrav.Name = "showBulkGrav"
        Me.showBulkGrav.Size = New System.Drawing.Size(20, 16)
        Me.showBulkGrav.TabIndex = 15
        Me.showBulkGrav.Text = "---"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Global void ratio"
        '
        'showBulkGravAll
        '
        Me.showBulkGravAll.AutoSize = True
        Me.showBulkGravAll.Location = New System.Drawing.Point(177, 115)
        Me.showBulkGravAll.Name = "showBulkGravAll"
        Me.showBulkGravAll.Size = New System.Drawing.Size(20, 16)
        Me.showBulkGravAll.TabIndex = 17
        Me.showBulkGravAll.Text = "---"
        '
        'btnNewVRMask
        '
        Me.btnNewVRMask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewVRMask.Location = New System.Drawing.Point(9, 281)
        Me.btnNewVRMask.Name = "btnNewVRMask"
        Me.btnNewVRMask.Size = New System.Drawing.Size(75, 23)
        Me.btnNewVRMask.TabIndex = 18
        Me.btnNewVRMask.Text = "New Mask"
        Me.btnNewVRMask.UseVisualStyleBackColor = True
        '
        'showVoidMask
        '
        Me.showVoidMask.AutoSize = True
        Me.showVoidMask.Location = New System.Drawing.Point(97, 291)
        Me.showVoidMask.Name = "showVoidMask"
        Me.showVoidMask.Size = New System.Drawing.Size(20, 16)
        Me.showVoidMask.TabIndex = 15
        Me.showVoidMask.Text = "---"
        '
        'VRContainer
        '
        Me.VRContainer.AutoScroll = True
        Me.VRContainer.Controls.Add(Me.VRBox)
        Me.VRContainer.Location = New System.Drawing.Point(232, 0)
        Me.VRContainer.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.VRContainer.Name = "VRContainer"
        Me.VRContainer.Size = New System.Drawing.Size(408, 414)
        Me.VRContainer.TabIndex = 19
        '
        'shwPpM
        '
        Me.shwPpM.AutoSize = True
        Me.shwPpM.Location = New System.Drawing.Point(136, 144)
        Me.shwPpM.Name = "shwPpM"
        Me.shwPpM.Size = New System.Drawing.Size(69, 16)
        Me.shwPpM.TabIndex = 26
        Me.shwPpM.Text = "PixPerMM"
        '
        'showHVR
        '
        Me.showHVR.AutoSize = True
        Me.showHVR.Location = New System.Drawing.Point(71, 144)
        Me.showHVR.Name = "showHVR"
        Me.showHVR.Size = New System.Drawing.Size(58, 16)
        Me.showHVR.TabIndex = 25
        Me.showHVR.Text = "HVRBox"
        '
        'showWVR
        '
        Me.showWVR.AutoSize = True
        Me.showWVR.Location = New System.Drawing.Point(6, 144)
        Me.showWVR.Name = "showWVR"
        Me.showWVR.Size = New System.Drawing.Size(58, 16)
        Me.showWVR.TabIndex = 24
        Me.showWVR.Text = "wVRBox"
        '
        'btnMagVR
        '
        Me.btnMagVR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMagVR.Location = New System.Drawing.Point(9, 326)
        Me.btnMagVR.Name = "btnMagVR"
        Me.btnMagVR.Size = New System.Drawing.Size(75, 23)
        Me.btnMagVR.TabIndex = 20
        Me.btnMagVR.Text = "Magnify"
        Me.btnMagVR.UseVisualStyleBackColor = True
        '
        'setMagVR
        '
        Me.setMagVR.BackColor = System.Drawing.Color.DimGray
        Me.setMagVR.DecimalPlaces = 2
        Me.setMagVR.ForeColor = System.Drawing.Color.White
        Me.setMagVR.Location = New System.Drawing.Point(90, 326)
        Me.setMagVR.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.setMagVR.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.setMagVR.Name = "setMagVR"
        Me.setMagVR.Size = New System.Drawing.Size(54, 22)
        Me.setMagVR.TabIndex = 21
        Me.setMagVR.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnCloneMask
        '
        Me.btnCloneMask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloneMask.Location = New System.Drawing.Point(9, 365)
        Me.btnCloneMask.Name = "btnCloneMask"
        Me.btnCloneMask.Size = New System.Drawing.Size(75, 47)
        Me.btnCloneMask.TabIndex = 22
        Me.btnCloneMask.Text = "Clone Mask"
        Me.btnCloneMask.UseVisualStyleBackColor = True
        '
        'chkShowMagBMP
        '
        Me.chkShowMagBMP.AutoSize = True
        Me.chkShowMagBMP.Location = New System.Drawing.Point(156, 329)
        Me.chkShowMagBMP.Name = "chkShowMagBMP"
        Me.chkShowMagBMP.Size = New System.Drawing.Size(57, 20)
        Me.chkShowMagBMP.TabIndex = 23
        Me.chkShowMagBMP.Text = "show"
        Me.chkShowMagBMP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkShowMagBMP.UseVisualStyleBackColor = True
        '
        'btnTrack
        '
        Me.btnTrack.Enabled = False
        Me.btnTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrack.Location = New System.Drawing.Point(90, 389)
        Me.btnTrack.Name = "btnTrack"
        Me.btnTrack.Size = New System.Drawing.Size(64, 23)
        Me.btnTrack.TabIndex = 24
        Me.btnTrack.Text = "Track"
        Me.btnTrack.UseVisualStyleBackColor = True
        '
        'chkAlwaysTop
        '
        Me.chkAlwaysTop.AutoSize = True
        Me.chkAlwaysTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkAlwaysTop.Location = New System.Drawing.Point(165, 82)
        Me.chkAlwaysTop.Name = "chkAlwaysTop"
        Me.chkAlwaysTop.Size = New System.Drawing.Size(48, 20)
        Me.chkAlwaysTop.TabIndex = 25
        Me.chkAlwaysTop.Text = "Top"
        Me.chkAlwaysTop.UseVisualStyleBackColor = False
        '
        'btnCellVR
        '
        Me.btnCellVR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCellVR.Location = New System.Drawing.Point(9, 245)
        Me.btnCellVR.Name = "btnCellVR"
        Me.btnCellVR.Size = New System.Drawing.Size(75, 23)
        Me.btnCellVR.TabIndex = 27
        Me.btnCellVR.Text = "Cell VR"
        Me.btnCellVR.UseVisualStyleBackColor = True
        '
        'setSizeVRCell
        '
        Me.setSizeVRCell.BackColor = System.Drawing.Color.DimGray
        Me.setSizeVRCell.DecimalPlaces = 2
        Me.setSizeVRCell.ForeColor = System.Drawing.Color.White
        Me.setSizeVRCell.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.setSizeVRCell.Location = New System.Drawing.Point(90, 248)
        Me.setSizeVRCell.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.setSizeVRCell.Name = "setSizeVRCell"
        Me.setSizeVRCell.Size = New System.Drawing.Size(64, 22)
        Me.setSizeVRCell.TabIndex = 28
        Me.setSizeVRCell.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'chkGray
        '
        Me.chkGray.AutoSize = True
        Me.chkGray.Location = New System.Drawing.Point(161, 214)
        Me.chkGray.Name = "chkGray"
        Me.chkGray.Size = New System.Drawing.Size(55, 20)
        Me.chkGray.TabIndex = 29
        Me.chkGray.Text = "Gray"
        Me.chkGray.UseVisualStyleBackColor = True
        '
        'VR
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(644, 423)
        Me.Controls.Add(Me.chkGray)
        Me.Controls.Add(Me.setSizeVRCell)
        Me.Controls.Add(Me.btnCellVR)
        Me.Controls.Add(Me.shwPpM)
        Me.Controls.Add(Me.chkAlwaysTop)
        Me.Controls.Add(Me.showHVR)
        Me.Controls.Add(Me.showWVR)
        Me.Controls.Add(Me.btnTrack)
        Me.Controls.Add(Me.chkShowMagBMP)
        Me.Controls.Add(Me.btnCloneMask)
        Me.Controls.Add(Me.setMagVR)
        Me.Controls.Add(Me.btnMagVR)
        Me.Controls.Add(Me.VRContainer)
        Me.Controls.Add(Me.btnNewVRMask)
        Me.Controls.Add(Me.showBulkGravAll)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.showVoidMask)
        Me.Controls.Add(Me.showBulkGrav)
        Me.Controls.Add(Me.btnVoid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.setMaxDensity)
        Me.Controls.Add(Me.setMinDensity)
        Me.Controls.Add(Me.showMinDensity)
        Me.Controls.Add(Me.showMaxDensity)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.setVRRange)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.setTransparency)
        Me.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VR"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PPDEM - Void ratio "
        CType(Me.VRBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setTransparency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setVRRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setMinDensity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setMaxDensity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VRContainer.ResumeLayout(False)
        CType(Me.setMagVR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setSizeVRCell, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VRBox As System.Windows.Forms.PictureBox
    Friend WithEvents setTransparency As System.Windows.Forms.TrackBar
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents setVRRange As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents showMaxDensity As System.Windows.Forms.Label
    Friend WithEvents showMinDensity As System.Windows.Forms.Label
    Friend WithEvents setMinDensity As System.Windows.Forms.NumericUpDown
    Friend WithEvents setMaxDensity As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnVoid As System.Windows.Forms.Button
    Friend WithEvents showBulkGrav As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents showBulkGravAll As System.Windows.Forms.Label
    Friend WithEvents btnNewVRMask As System.Windows.Forms.Button
    Friend WithEvents showVoidMask As System.Windows.Forms.Label
    Friend WithEvents VRContainer As System.Windows.Forms.Panel
    Friend WithEvents btnMagVR As System.Windows.Forms.Button
    Friend WithEvents setMagVR As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnCloneMask As System.Windows.Forms.Button
    Friend WithEvents chkShowMagBMP As System.Windows.Forms.CheckBox
    Friend WithEvents showHVR As System.Windows.Forms.Label
    Friend WithEvents showWVR As System.Windows.Forms.Label
    Friend WithEvents btnTrack As System.Windows.Forms.Button
    Friend WithEvents shwPpM As System.Windows.Forms.Label
    Friend WithEvents chkAlwaysTop As System.Windows.Forms.CheckBox
    Friend WithEvents btnCellVR As System.Windows.Forms.Button
    Friend WithEvents setSizeVRCell As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkGray As System.Windows.Forms.CheckBox

End Class
