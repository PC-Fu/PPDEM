<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Histgram
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Histgram))
        Me.roseForce = New System.Windows.Forms.PictureBox()
        Me.roseOrit = New System.Windows.Forms.PictureBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnImpMask = New System.Windows.Forms.Button()
        Me.btnExpMask = New System.Windows.Forms.Button()
        Me.rbMaskHist = New System.Windows.Forms.RadioButton()
        Me.rbGlobHist = New System.Windows.Forms.RadioButton()
        Me.btnNewMask = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbWeighted = New System.Windows.Forms.RadioButton()
        Me.rbCount = New System.Windows.Forms.RadioButton()
        Me.hgFR = New System.Windows.Forms.PictureBox()
        Me.roseNorm = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkIBoundMode = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbFb11 = New System.Windows.Forms.Label()
        Me.lbFb12 = New System.Windows.Forms.Label()
        Me.lbFb22 = New System.Windows.Forms.Label()
        Me.lbFb21 = New System.Windows.Forms.Label()
        Me.lbAngFabAxis1 = New System.Windows.Forms.Label()
        Me.lbF1 = New System.Windows.Forms.Label()
        Me.lbF2 = New System.Windows.Forms.Label()
        Me.lbAngFabAxis2 = New System.Windows.Forms.Label()
        Me.groupTsFabric = New System.Windows.Forms.GroupBox()
        Me.chkFabExp = New System.Windows.Forms.CheckBox()
        Me.groupTsStress = New System.Windows.Forms.GroupBox()
        Me.checkStsBExp = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbStress11 = New System.Windows.Forms.Label()
        Me.lbStress12 = New System.Windows.Forms.Label()
        Me.lbStress22 = New System.Windows.Forms.Label()
        Me.lbStress21 = New System.Windows.Forms.Label()
        Me.lbAngStressAxis2 = New System.Windows.Forms.Label()
        Me.lbPrnStress1 = New System.Windows.Forms.Label()
        Me.lbAngStressAxis1 = New System.Windows.Forms.Label()
        Me.lbPrnStress2 = New System.Windows.Forms.Label()
        Me.lbContactNumber = New System.Windows.Forms.Label()
        Me.groupTsBodyStress = New System.Windows.Forms.GroupBox()
        Me.chkStsExp = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbBodyStress11 = New System.Windows.Forms.Label()
        Me.lbBodyStress12 = New System.Windows.Forms.Label()
        Me.lbBodyStress22 = New System.Windows.Forms.Label()
        Me.lbBodyStress21 = New System.Windows.Forms.Label()
        Me.lbAngBodyStressAxis2 = New System.Windows.Forms.Label()
        Me.lbPrnBodyStress1 = New System.Windows.Forms.Label()
        Me.lbAngBodyStressAxis1 = New System.Windows.Forms.Label()
        Me.lbPrnBodyStress2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbFabricWeightNone = New System.Windows.Forms.RadioButton()
        Me.rbFabricWeightMaxShear = New System.Windows.Forms.RadioButton()
        Me.rbFabricWeightBulk = New System.Windows.Forms.RadioButton()
        Me.rbFabricWeightXY = New System.Windows.Forms.RadioButton()
        Me.rbFabricWeightYY = New System.Windows.Forms.RadioButton()
        Me.rbFabricWeightXX = New System.Windows.Forms.RadioButton()
        Me.setTransHist = New System.Windows.Forms.TrackBar()
        Me.setAngRefLine = New System.Windows.Forms.NumericUpDown()
        Me.chkShowRefLine = New System.Windows.Forms.CheckBox()
        Me.chkAlwaysTop = New System.Windows.Forms.CheckBox()
        Me.setScalePolar = New System.Windows.Forms.NumericUpDown()
        Me.gbFabricConNorm = New System.Windows.Forms.GroupBox()
        Me.chkCNExp = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbCN11 = New System.Windows.Forms.Label()
        Me.lbCN12 = New System.Windows.Forms.Label()
        Me.lbCN22 = New System.Windows.Forms.Label()
        Me.lbCN21 = New System.Windows.Forms.Label()
        Me.lbAngFabCN1 = New System.Windows.Forms.Label()
        Me.lbCN1 = New System.Windows.Forms.Label()
        Me.lbCN2 = New System.Windows.Forms.Label()
        Me.lbAngFabCN2 = New System.Windows.Forms.Label()
        Me.chkShowRoseLegend = New System.Windows.Forms.CheckBox()
        Me.chkShowSldNorm = New System.Windows.Forms.CheckBox()
        Me.roseForceNormTang = New System.Windows.Forms.PictureBox()
        Me.roseShearRatio = New System.Windows.Forms.PictureBox()
        Me.lbExpandWindow = New System.Windows.Forms.Label()
        Me.lbRoseForceNormTang = New System.Windows.Forms.Label()
        Me.lbRoseShearRatio = New System.Windows.Forms.Label()
        Me.setScaleShearRatio = New System.Windows.Forms.NumericUpDown()
        Me.setScaleForceNT = New System.Windows.Forms.NumericUpDown()
        Me.btnResetScaleForceNT = New System.Windows.Forms.Button()
        Me.chkAllExp = New System.Windows.Forms.CheckBox()
        CType(Me.roseForce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.roseOrit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.hgFR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.roseNorm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.groupTsFabric.SuspendLayout()
        Me.groupTsStress.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.groupTsBodyStress.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.setTransHist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setAngRefLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setScalePolar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFabricConNorm.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.roseForceNormTang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.roseShearRatio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setScaleShearRatio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setScaleForceNT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'roseForce
        '
        Me.roseForce.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.roseForce.BackgroundImage = CType(resources.GetObject("roseForce.BackgroundImage"), System.Drawing.Image)
        Me.roseForce.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.roseForce.Image = Global.PolyBall.My.Resources.Resources.RoseCanvas
        Me.roseForce.InitialImage = CType(resources.GetObject("roseForce.InitialImage"), System.Drawing.Image)
        Me.roseForce.Location = New System.Drawing.Point(8, 338)
        Me.roseForce.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.roseForce.Name = "roseForce"
        Me.roseForce.Size = New System.Drawing.Size(300, 328)
        Me.roseForce.TabIndex = 5
        Me.roseForce.TabStop = False
        '
        'roseOrit
        '
        Me.roseOrit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.roseOrit.BackgroundImage = CType(resources.GetObject("roseOrit.BackgroundImage"), System.Drawing.Image)
        Me.roseOrit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.roseOrit.Image = Global.PolyBall.My.Resources.Resources.RoseCanvas
        Me.roseOrit.InitialImage = CType(resources.GetObject("roseOrit.InitialImage"), System.Drawing.Image)
        Me.roseOrit.Location = New System.Drawing.Point(8, 2)
        Me.roseOrit.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.roseOrit.Name = "roseOrit"
        Me.roseOrit.Size = New System.Drawing.Size(300, 328)
        Me.roseOrit.TabIndex = 6
        Me.roseOrit.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnImpMask)
        Me.GroupBox5.Controls.Add(Me.btnExpMask)
        Me.GroupBox5.Controls.Add(Me.rbMaskHist)
        Me.GroupBox5.Controls.Add(Me.rbGlobHist)
        Me.GroupBox5.Controls.Add(Me.btnNewMask)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(6, 686)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(121, 111)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Mode"
        '
        'btnImpMask
        '
        Me.btnImpMask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImpMask.Location = New System.Drawing.Point(62, 79)
        Me.btnImpMask.Name = "btnImpMask"
        Me.btnImpMask.Size = New System.Drawing.Size(45, 26)
        Me.btnImpMask.TabIndex = 5
        Me.btnImpMask.Text = "Imp"
        Me.btnImpMask.UseVisualStyleBackColor = True
        '
        'btnExpMask
        '
        Me.btnExpMask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpMask.Location = New System.Drawing.Point(10, 79)
        Me.btnExpMask.Name = "btnExpMask"
        Me.btnExpMask.Size = New System.Drawing.Size(46, 26)
        Me.btnExpMask.TabIndex = 4
        Me.btnExpMask.Text = "Exp"
        Me.btnExpMask.UseVisualStyleBackColor = True
        '
        'rbMaskHist
        '
        Me.rbMaskHist.AutoSize = True
        Me.rbMaskHist.Location = New System.Drawing.Point(61, 19)
        Me.rbMaskHist.Name = "rbMaskHist"
        Me.rbMaskHist.Size = New System.Drawing.Size(50, 18)
        Me.rbMaskHist.TabIndex = 1
        Me.rbMaskHist.Text = "Mask"
        Me.rbMaskHist.UseVisualStyleBackColor = True
        '
        'rbGlobHist
        '
        Me.rbGlobHist.AutoSize = True
        Me.rbGlobHist.Checked = True
        Me.rbGlobHist.Location = New System.Drawing.Point(2, 19)
        Me.rbGlobHist.Name = "rbGlobHist"
        Me.rbGlobHist.Size = New System.Drawing.Size(55, 18)
        Me.rbGlobHist.TabIndex = 0
        Me.rbGlobHist.TabStop = True
        Me.rbGlobHist.Text = "Global"
        Me.rbGlobHist.UseVisualStyleBackColor = True
        '
        'btnNewMask
        '
        Me.btnNewMask.Enabled = False
        Me.btnNewMask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewMask.Location = New System.Drawing.Point(10, 46)
        Me.btnNewMask.Name = "btnNewMask"
        Me.btnNewMask.Size = New System.Drawing.Size(97, 27)
        Me.btnNewMask.TabIndex = 3
        Me.btnNewMask.Text = "New Mask"
        Me.btnNewMask.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Particle Orientation"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbWeighted)
        Me.GroupBox1.Controls.Add(Me.rbCount)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(133, 686)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 38)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'rbWeighted
        '
        Me.rbWeighted.AutoSize = True
        Me.rbWeighted.Location = New System.Drawing.Point(16, 13)
        Me.rbWeighted.Name = "rbWeighted"
        Me.rbWeighted.Size = New System.Drawing.Size(58, 18)
        Me.rbWeighted.TabIndex = 10
        Me.rbWeighted.Text = "Weight"
        Me.rbWeighted.UseVisualStyleBackColor = True
        '
        'rbCount
        '
        Me.rbCount.AutoSize = True
        Me.rbCount.Checked = True
        Me.rbCount.Location = New System.Drawing.Point(89, 12)
        Me.rbCount.Name = "rbCount"
        Me.rbCount.Size = New System.Drawing.Size(53, 18)
        Me.rbCount.TabIndex = 0
        Me.rbCount.TabStop = True
        Me.rbCount.Text = "Count"
        Me.rbCount.UseVisualStyleBackColor = True
        '
        'hgFR
        '
        Me.hgFR.BackgroundImage = CType(resources.GetObject("hgFR.BackgroundImage"), System.Drawing.Image)
        Me.hgFR.Location = New System.Drawing.Point(318, 338)
        Me.hgFR.Name = "hgFR"
        Me.hgFR.Size = New System.Drawing.Size(300, 175)
        Me.hgFR.TabIndex = 10
        Me.hgFR.TabStop = False
        '
        'roseNorm
        '
        Me.roseNorm.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.roseNorm.BackgroundImage = CType(resources.GetObject("roseNorm.BackgroundImage"), System.Drawing.Image)
        Me.roseNorm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.roseNorm.Image = Global.PolyBall.My.Resources.Resources.RoseCanvas
        Me.roseNorm.InitialImage = CType(resources.GetObject("roseNorm.InitialImage"), System.Drawing.Image)
        Me.roseNorm.Location = New System.Drawing.Point(317, 2)
        Me.roseNorm.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.roseNorm.Name = "roseNorm"
        Me.roseNorm.Size = New System.Drawing.Size(300, 328)
        Me.roseNorm.TabIndex = 6
        Me.roseNorm.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(326, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Contact Norm"
        '
        'chkIBoundMode
        '
        Me.chkIBoundMode.AutoSize = True
        Me.chkIBoundMode.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.chkIBoundMode.Location = New System.Drawing.Point(8, 805)
        Me.chkIBoundMode.Name = "chkIBoundMode"
        Me.chkIBoundMode.Size = New System.Drawing.Size(155, 18)
        Me.chkIBoundMode.TabIndex = 11
        Me.chkIBoundMode.Text = "Including Boundary Forces"
        Me.chkIBoundMode.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbFb11, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbFb12, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbFb22, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbFb21, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbAngFabAxis1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbF1, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbF2, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbAngFabAxis2, 2, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 22)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.41177!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.58823!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(263, 51)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'lbFb11
        '
        Me.lbFb11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbFb11.AutoSize = True
        Me.lbFb11.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbFb11.Location = New System.Drawing.Point(3, 6)
        Me.lbFb11.Name = "lbFb11"
        Me.lbFb11.Size = New System.Drawing.Size(30, 13)
        Me.lbFb11.TabIndex = 0
        Me.lbFb11.Text = "Fb11"
        '
        'lbFb12
        '
        Me.lbFb12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbFb12.AutoSize = True
        Me.lbFb12.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbFb12.Location = New System.Drawing.Point(68, 6)
        Me.lbFb12.Name = "lbFb12"
        Me.lbFb12.Size = New System.Drawing.Size(31, 13)
        Me.lbFb12.TabIndex = 0
        Me.lbFb12.Text = "Fb12"
        '
        'lbFb22
        '
        Me.lbFb22.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbFb22.AutoSize = True
        Me.lbFb22.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbFb22.Location = New System.Drawing.Point(68, 31)
        Me.lbFb22.Name = "lbFb22"
        Me.lbFb22.Size = New System.Drawing.Size(31, 13)
        Me.lbFb22.TabIndex = 0
        Me.lbFb22.Text = "Fb22"
        '
        'lbFb21
        '
        Me.lbFb21.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbFb21.AutoSize = True
        Me.lbFb21.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbFb21.Location = New System.Drawing.Point(3, 31)
        Me.lbFb21.Name = "lbFb21"
        Me.lbFb21.Size = New System.Drawing.Size(31, 13)
        Me.lbFb21.TabIndex = 0
        Me.lbFb21.Text = "Fb21"
        '
        'lbAngFabAxis1
        '
        Me.lbAngFabAxis1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbAngFabAxis1.AutoSize = True
        Me.lbAngFabAxis1.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbAngFabAxis1.Location = New System.Drawing.Point(137, 6)
        Me.lbAngFabAxis1.Name = "lbAngFabAxis1"
        Me.lbAngFabAxis1.Size = New System.Drawing.Size(50, 13)
        Me.lbAngFabAxis1.TabIndex = 0
        Me.lbAngFabAxis1.Text = "angAxis1"
        '
        'lbF1
        '
        Me.lbF1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbF1.AutoSize = True
        Me.lbF1.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbF1.Location = New System.Drawing.Point(221, 6)
        Me.lbF1.Name = "lbF1"
        Me.lbF1.Size = New System.Drawing.Size(16, 13)
        Me.lbF1.TabIndex = 0
        Me.lbF1.Text = "FI"
        '
        'lbF2
        '
        Me.lbF2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbF2.AutoSize = True
        Me.lbF2.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbF2.Location = New System.Drawing.Point(219, 31)
        Me.lbF2.Name = "lbF2"
        Me.lbF2.Size = New System.Drawing.Size(19, 13)
        Me.lbF2.TabIndex = 0
        Me.lbF2.Text = "FII"
        '
        'lbAngFabAxis2
        '
        Me.lbAngFabAxis2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbAngFabAxis2.AutoSize = True
        Me.lbAngFabAxis2.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbAngFabAxis2.Location = New System.Drawing.Point(137, 31)
        Me.lbAngFabAxis2.Name = "lbAngFabAxis2"
        Me.lbAngFabAxis2.Size = New System.Drawing.Size(50, 13)
        Me.lbAngFabAxis2.TabIndex = 0
        Me.lbAngFabAxis2.Text = "angAxis2"
        '
        'groupTsFabric
        '
        Me.groupTsFabric.Controls.Add(Me.chkFabExp)
        Me.groupTsFabric.Controls.Add(Me.TableLayoutPanel1)
        Me.groupTsFabric.ForeColor = System.Drawing.Color.White
        Me.groupTsFabric.Location = New System.Drawing.Point(314, 526)
        Me.groupTsFabric.Name = "groupTsFabric"
        Me.groupTsFabric.Size = New System.Drawing.Size(303, 80)
        Me.groupTsFabric.TabIndex = 13
        Me.groupTsFabric.TabStop = False
        Me.groupTsFabric.Text = "Ptcl Ori Fabric"
        '
        'chkFabExp
        '
        Me.chkFabExp.AutoSize = True
        Me.chkFabExp.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.chkFabExp.Location = New System.Drawing.Point(278, 22)
        Me.chkFabExp.Name = "chkFabExp"
        Me.chkFabExp.Size = New System.Drawing.Size(19, 33)
        Me.chkFabExp.TabIndex = 14
        Me.chkFabExp.Text = "E"
        Me.chkFabExp.UseVisualStyleBackColor = True
        '
        'groupTsStress
        '
        Me.groupTsStress.Controls.Add(Me.checkStsBExp)
        Me.groupTsStress.Controls.Add(Me.TableLayoutPanel2)
        Me.groupTsStress.ForeColor = System.Drawing.Color.White
        Me.groupTsStress.Location = New System.Drawing.Point(315, 700)
        Me.groupTsStress.Name = "groupTsStress"
        Me.groupTsStress.Size = New System.Drawing.Size(303, 91)
        Me.groupTsStress.TabIndex = 13
        Me.groupTsStress.TabStop = False
        Me.groupTsStress.Text = "Stress Tensor S"
        '
        'checkStsBExp
        '
        Me.checkStsBExp.AutoSize = True
        Me.checkStsBExp.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.checkStsBExp.Location = New System.Drawing.Point(278, 22)
        Me.checkStsBExp.Name = "checkStsBExp"
        Me.checkStsBExp.Size = New System.Drawing.Size(19, 33)
        Me.checkStsBExp.TabIndex = 13
        Me.checkStsBExp.Text = "E"
        Me.checkStsBExp.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lbStress11, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbStress12, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbStress22, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbStress21, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbAngStressAxis2, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbPrnStress1, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbAngStressAxis1, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbPrnStress2, 3, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(8, 22)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.41177!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.58823!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(263, 65)
        Me.TableLayoutPanel2.TabIndex = 12
        '
        'lbStress11
        '
        Me.lbStress11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbStress11.AutoSize = True
        Me.lbStress11.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbStress11.Location = New System.Drawing.Point(3, 9)
        Me.lbStress11.Name = "lbStress11"
        Me.lbStress11.Size = New System.Drawing.Size(45, 13)
        Me.lbStress11.TabIndex = 0
        Me.lbStress11.Text = "Stress11"
        '
        'lbStress12
        '
        Me.lbStress12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbStress12.AutoSize = True
        Me.lbStress12.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbStress12.Location = New System.Drawing.Point(68, 9)
        Me.lbStress12.Name = "lbStress12"
        Me.lbStress12.Size = New System.Drawing.Size(46, 13)
        Me.lbStress12.TabIndex = 0
        Me.lbStress12.Text = "Stress12"
        '
        'lbStress22
        '
        Me.lbStress22.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbStress22.AutoSize = True
        Me.lbStress22.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbStress22.Location = New System.Drawing.Point(68, 42)
        Me.lbStress22.Name = "lbStress22"
        Me.lbStress22.Size = New System.Drawing.Size(46, 13)
        Me.lbStress22.TabIndex = 0
        Me.lbStress22.Text = "Stress22"
        '
        'lbStress21
        '
        Me.lbStress21.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbStress21.AutoSize = True
        Me.lbStress21.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbStress21.Location = New System.Drawing.Point(3, 42)
        Me.lbStress21.Name = "lbStress21"
        Me.lbStress21.Size = New System.Drawing.Size(46, 13)
        Me.lbStress21.TabIndex = 0
        Me.lbStress21.Text = "Stress21"
        '
        'lbAngStressAxis2
        '
        Me.lbAngStressAxis2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbAngStressAxis2.AutoSize = True
        Me.lbAngStressAxis2.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbAngStressAxis2.Location = New System.Drawing.Point(137, 42)
        Me.lbAngStressAxis2.Name = "lbAngStressAxis2"
        Me.lbAngStressAxis2.Size = New System.Drawing.Size(50, 13)
        Me.lbAngStressAxis2.TabIndex = 0
        Me.lbAngStressAxis2.Text = "angAxis2"
        '
        'lbPrnStress1
        '
        Me.lbPrnStress1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbPrnStress1.AutoSize = True
        Me.lbPrnStress1.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbPrnStress1.Location = New System.Drawing.Point(210, 9)
        Me.lbPrnStress1.Name = "lbPrnStress1"
        Me.lbPrnStress1.Size = New System.Drawing.Size(37, 13)
        Me.lbPrnStress1.TabIndex = 0
        Me.lbPrnStress1.Text = "StressI"
        '
        'lbAngStressAxis1
        '
        Me.lbAngStressAxis1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbAngStressAxis1.AutoSize = True
        Me.lbAngStressAxis1.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbAngStressAxis1.Location = New System.Drawing.Point(137, 9)
        Me.lbAngStressAxis1.Name = "lbAngStressAxis1"
        Me.lbAngStressAxis1.Size = New System.Drawing.Size(50, 13)
        Me.lbAngStressAxis1.TabIndex = 0
        Me.lbAngStressAxis1.Text = "angAxis1"
        '
        'lbPrnStress2
        '
        Me.lbPrnStress2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbPrnStress2.AutoSize = True
        Me.lbPrnStress2.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbPrnStress2.Location = New System.Drawing.Point(209, 42)
        Me.lbPrnStress2.Name = "lbPrnStress2"
        Me.lbPrnStress2.Size = New System.Drawing.Size(40, 13)
        Me.lbPrnStress2.TabIndex = 0
        Me.lbPrnStress2.Text = "StressII"
        '
        'lbContactNumber
        '
        Me.lbContactNumber.AutoSize = True
        Me.lbContactNumber.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.lbContactNumber.Location = New System.Drawing.Point(5, 827)
        Me.lbContactNumber.Name = "lbContactNumber"
        Me.lbContactNumber.Size = New System.Drawing.Size(113, 14)
        Me.lbContactNumber.TabIndex = 14
        Me.lbContactNumber.Text = "Coordination  Number:"
        '
        'groupTsBodyStress
        '
        Me.groupTsBodyStress.Controls.Add(Me.chkStsExp)
        Me.groupTsBodyStress.Controls.Add(Me.TableLayoutPanel3)
        Me.groupTsBodyStress.ForeColor = System.Drawing.Color.White
        Me.groupTsBodyStress.Location = New System.Drawing.Point(315, 797)
        Me.groupTsBodyStress.Name = "groupTsBodyStress"
        Me.groupTsBodyStress.Size = New System.Drawing.Size(303, 88)
        Me.groupTsBodyStress.TabIndex = 13
        Me.groupTsBodyStress.TabStop = False
        Me.groupTsBodyStress.Text = "Stress Tensor V"
        '
        'chkStsExp
        '
        Me.chkStsExp.AutoSize = True
        Me.chkStsExp.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.chkStsExp.Location = New System.Drawing.Point(280, 15)
        Me.chkStsExp.Name = "chkStsExp"
        Me.chkStsExp.Size = New System.Drawing.Size(19, 33)
        Me.chkStsExp.TabIndex = 14
        Me.chkStsExp.Text = "E"
        Me.chkStsExp.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lbBodyStress11, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lbBodyStress12, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lbBodyStress22, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lbBodyStress21, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lbAngBodyStressAxis2, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lbPrnBodyStress1, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lbAngBodyStressAxis1, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lbPrnBodyStress2, 3, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(5, 17)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.41177!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.58823!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(266, 65)
        Me.TableLayoutPanel3.TabIndex = 12
        '
        'lbBodyStress11
        '
        Me.lbBodyStress11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbBodyStress11.AutoSize = True
        Me.lbBodyStress11.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbBodyStress11.Location = New System.Drawing.Point(3, 9)
        Me.lbBodyStress11.Name = "lbBodyStress11"
        Me.lbBodyStress11.Size = New System.Drawing.Size(45, 13)
        Me.lbBodyStress11.TabIndex = 0
        Me.lbBodyStress11.Text = "Stress11"
        '
        'lbBodyStress12
        '
        Me.lbBodyStress12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbBodyStress12.AutoSize = True
        Me.lbBodyStress12.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbBodyStress12.Location = New System.Drawing.Point(69, 9)
        Me.lbBodyStress12.Name = "lbBodyStress12"
        Me.lbBodyStress12.Size = New System.Drawing.Size(46, 13)
        Me.lbBodyStress12.TabIndex = 0
        Me.lbBodyStress12.Text = "Stress12"
        '
        'lbBodyStress22
        '
        Me.lbBodyStress22.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbBodyStress22.AutoSize = True
        Me.lbBodyStress22.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbBodyStress22.Location = New System.Drawing.Point(69, 42)
        Me.lbBodyStress22.Name = "lbBodyStress22"
        Me.lbBodyStress22.Size = New System.Drawing.Size(46, 13)
        Me.lbBodyStress22.TabIndex = 0
        Me.lbBodyStress22.Text = "Stress22"
        '
        'lbBodyStress21
        '
        Me.lbBodyStress21.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbBodyStress21.AutoSize = True
        Me.lbBodyStress21.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbBodyStress21.Location = New System.Drawing.Point(3, 42)
        Me.lbBodyStress21.Name = "lbBodyStress21"
        Me.lbBodyStress21.Size = New System.Drawing.Size(46, 13)
        Me.lbBodyStress21.TabIndex = 0
        Me.lbBodyStress21.Text = "Stress21"
        '
        'lbAngBodyStressAxis2
        '
        Me.lbAngBodyStressAxis2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbAngBodyStressAxis2.AutoSize = True
        Me.lbAngBodyStressAxis2.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbAngBodyStressAxis2.Location = New System.Drawing.Point(140, 42)
        Me.lbAngBodyStressAxis2.Name = "lbAngBodyStressAxis2"
        Me.lbAngBodyStressAxis2.Size = New System.Drawing.Size(50, 13)
        Me.lbAngBodyStressAxis2.TabIndex = 0
        Me.lbAngBodyStressAxis2.Text = "angAxis2"
        '
        'lbPrnBodyStress1
        '
        Me.lbPrnBodyStress1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbPrnBodyStress1.AutoSize = True
        Me.lbPrnBodyStress1.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbPrnBodyStress1.Location = New System.Drawing.Point(213, 9)
        Me.lbPrnBodyStress1.Name = "lbPrnBodyStress1"
        Me.lbPrnBodyStress1.Size = New System.Drawing.Size(37, 13)
        Me.lbPrnBodyStress1.TabIndex = 0
        Me.lbPrnBodyStress1.Text = "StressI"
        '
        'lbAngBodyStressAxis1
        '
        Me.lbAngBodyStressAxis1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbAngBodyStressAxis1.AutoSize = True
        Me.lbAngBodyStressAxis1.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbAngBodyStressAxis1.Location = New System.Drawing.Point(140, 9)
        Me.lbAngBodyStressAxis1.Name = "lbAngBodyStressAxis1"
        Me.lbAngBodyStressAxis1.Size = New System.Drawing.Size(50, 13)
        Me.lbAngBodyStressAxis1.TabIndex = 0
        Me.lbAngBodyStressAxis1.Text = "angAxis1"
        '
        'lbPrnBodyStress2
        '
        Me.lbPrnBodyStress2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbPrnBodyStress2.AutoSize = True
        Me.lbPrnBodyStress2.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbPrnBodyStress2.Location = New System.Drawing.Point(212, 42)
        Me.lbPrnBodyStress2.Name = "lbPrnBodyStress2"
        Me.lbPrnBodyStress2.Size = New System.Drawing.Size(40, 13)
        Me.lbPrnBodyStress2.TabIndex = 0
        Me.lbPrnBodyStress2.Text = "StressII"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(16, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 15)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Particle Orientation"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(323, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(145, 15)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Contact Normal Direction"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(16, 343)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(200, 15)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Contact Force Direction (not useful)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(321, 338)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 15)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Friction Ratio"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbFabricWeightNone)
        Me.GroupBox2.Controls.Add(Me.rbFabricWeightMaxShear)
        Me.GroupBox2.Controls.Add(Me.rbFabricWeightBulk)
        Me.GroupBox2.Controls.Add(Me.rbFabricWeightXY)
        Me.GroupBox2.Controls.Add(Me.rbFabricWeightYY)
        Me.GroupBox2.Controls.Add(Me.rbFabricWeightXX)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(133, 730)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(175, 67)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add. Fabric Weight"
        '
        'rbFabricWeightNone
        '
        Me.rbFabricWeightNone.AutoSize = True
        Me.rbFabricWeightNone.Checked = True
        Me.rbFabricWeightNone.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.rbFabricWeightNone.Location = New System.Drawing.Point(5, 20)
        Me.rbFabricWeightNone.Name = "rbFabricWeightNone"
        Me.rbFabricWeightNone.Size = New System.Drawing.Size(50, 17)
        Me.rbFabricWeightNone.TabIndex = 6
        Me.rbFabricWeightNone.TabStop = True
        Me.rbFabricWeightNone.Text = "None"
        Me.rbFabricWeightNone.UseVisualStyleBackColor = True
        '
        'rbFabricWeightMaxShear
        '
        Me.rbFabricWeightMaxShear.AutoSize = True
        Me.rbFabricWeightMaxShear.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.rbFabricWeightMaxShear.Location = New System.Drawing.Point(96, 41)
        Me.rbFabricWeightMaxShear.Name = "rbFabricWeightMaxShear"
        Me.rbFabricWeightMaxShear.Size = New System.Drawing.Size(76, 17)
        Me.rbFabricWeightMaxShear.TabIndex = 5
        Me.rbFabricWeightMaxShear.Text = "Max Shear"
        Me.rbFabricWeightMaxShear.UseVisualStyleBackColor = True
        '
        'rbFabricWeightBulk
        '
        Me.rbFabricWeightBulk.AutoSize = True
        Me.rbFabricWeightBulk.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.rbFabricWeightBulk.Location = New System.Drawing.Point(4, 41)
        Me.rbFabricWeightBulk.Name = "rbFabricWeightBulk"
        Me.rbFabricWeightBulk.Size = New System.Drawing.Size(45, 17)
        Me.rbFabricWeightBulk.TabIndex = 4
        Me.rbFabricWeightBulk.Text = "Bulk"
        Me.rbFabricWeightBulk.UseVisualStyleBackColor = True
        '
        'rbFabricWeightXY
        '
        Me.rbFabricWeightXY.AutoSize = True
        Me.rbFabricWeightXY.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.rbFabricWeightXY.Location = New System.Drawing.Point(54, 42)
        Me.rbFabricWeightXY.Name = "rbFabricWeightXY"
        Me.rbFabricWeightXY.Size = New System.Drawing.Size(39, 17)
        Me.rbFabricWeightXY.TabIndex = 3
        Me.rbFabricWeightXY.Text = "XY"
        Me.rbFabricWeightXY.UseVisualStyleBackColor = True
        '
        'rbFabricWeightYY
        '
        Me.rbFabricWeightYY.AutoSize = True
        Me.rbFabricWeightYY.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.rbFabricWeightYY.Location = New System.Drawing.Point(118, 22)
        Me.rbFabricWeightYY.Name = "rbFabricWeightYY"
        Me.rbFabricWeightYY.Size = New System.Drawing.Size(39, 17)
        Me.rbFabricWeightYY.TabIndex = 2
        Me.rbFabricWeightYY.Text = "YY"
        Me.rbFabricWeightYY.UseVisualStyleBackColor = True
        '
        'rbFabricWeightXX
        '
        Me.rbFabricWeightXX.AutoSize = True
        Me.rbFabricWeightXX.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.rbFabricWeightXX.Location = New System.Drawing.Point(67, 22)
        Me.rbFabricWeightXX.Name = "rbFabricWeightXX"
        Me.rbFabricWeightXX.Size = New System.Drawing.Size(39, 17)
        Me.rbFabricWeightXX.TabIndex = 1
        Me.rbFabricWeightXX.Text = "XX"
        Me.rbFabricWeightXX.UseVisualStyleBackColor = True
        '
        'setTransHist
        '
        Me.setTransHist.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.setTransHist.AutoSize = False
        Me.setTransHist.Location = New System.Drawing.Point(6, 852)
        Me.setTransHist.Maximum = 20
        Me.setTransHist.Name = "setTransHist"
        Me.setTransHist.Size = New System.Drawing.Size(147, 25)
        Me.setTransHist.TabIndex = 17
        Me.setTransHist.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'setAngRefLine
        '
        Me.setAngRefLine.BackColor = System.Drawing.Color.DimGray
        Me.setAngRefLine.DecimalPlaces = 1
        Me.setAngRefLine.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.setAngRefLine.ForeColor = System.Drawing.Color.White
        Me.setAngRefLine.Location = New System.Drawing.Point(224, 834)
        Me.setAngRefLine.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.setAngRefLine.Name = "setAngRefLine"
        Me.setAngRefLine.Size = New System.Drawing.Size(74, 20)
        Me.setAngRefLine.TabIndex = 18
        '
        'chkShowRefLine
        '
        Me.chkShowRefLine.AutoSize = True
        Me.chkShowRefLine.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.chkShowRefLine.Location = New System.Drawing.Point(224, 808)
        Me.chkShowRefLine.Name = "chkShowRefLine"
        Me.chkShowRefLine.Size = New System.Drawing.Size(69, 18)
        Me.chkShowRefLine.TabIndex = 19
        Me.chkShowRefLine.Text = "Ref. Line"
        Me.chkShowRefLine.UseVisualStyleBackColor = True
        '
        'chkAlwaysTop
        '
        Me.chkAlwaysTop.AutoSize = True
        Me.chkAlwaysTop.Checked = True
        Me.chkAlwaysTop.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAlwaysTop.Location = New System.Drawing.Point(159, 852)
        Me.chkAlwaysTop.Name = "chkAlwaysTop"
        Me.chkAlwaysTop.Size = New System.Drawing.Size(46, 19)
        Me.chkAlwaysTop.TabIndex = 20
        Me.chkAlwaysTop.Text = "Top"
        Me.chkAlwaysTop.UseVisualStyleBackColor = True
        '
        'setScalePolar
        '
        Me.setScalePolar.DecimalPlaces = 2
        Me.setScalePolar.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.setScalePolar.Location = New System.Drawing.Point(554, 307)
        Me.setScalePolar.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.setScalePolar.Name = "setScalePolar"
        Me.setScalePolar.Size = New System.Drawing.Size(60, 21)
        Me.setScalePolar.TabIndex = 21
        Me.setScalePolar.Value = New Decimal(New Integer() {5, 0, 0, 65536})
        '
        'gbFabricConNorm
        '
        Me.gbFabricConNorm.Controls.Add(Me.chkCNExp)
        Me.gbFabricConNorm.Controls.Add(Me.TableLayoutPanel4)
        Me.gbFabricConNorm.ForeColor = System.Drawing.Color.White
        Me.gbFabricConNorm.Location = New System.Drawing.Point(314, 612)
        Me.gbFabricConNorm.Name = "gbFabricConNorm"
        Me.gbFabricConNorm.Size = New System.Drawing.Size(303, 80)
        Me.gbFabricConNorm.TabIndex = 13
        Me.gbFabricConNorm.TabStop = False
        Me.gbFabricConNorm.Text = "Contact Norm Fabric"
        '
        'chkCNExp
        '
        Me.chkCNExp.AutoSize = True
        Me.chkCNExp.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.chkCNExp.Location = New System.Drawing.Point(278, 22)
        Me.chkCNExp.Name = "chkCNExp"
        Me.chkCNExp.Size = New System.Drawing.Size(19, 33)
        Me.chkCNExp.TabIndex = 14
        Me.chkCNExp.Text = "E"
        Me.chkCNExp.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lbCN11, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbCN12, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbCN22, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.lbCN21, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.lbAngFabCN1, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbCN1, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbCN2, 3, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.lbAngFabCN2, 2, 1)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(8, 22)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.41177!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.58823!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(263, 51)
        Me.TableLayoutPanel4.TabIndex = 12
        '
        'lbCN11
        '
        Me.lbCN11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbCN11.AutoSize = True
        Me.lbCN11.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbCN11.Location = New System.Drawing.Point(3, 6)
        Me.lbCN11.Name = "lbCN11"
        Me.lbCN11.Size = New System.Drawing.Size(30, 13)
        Me.lbCN11.TabIndex = 0
        Me.lbCN11.Text = "Fb11"
        '
        'lbCN12
        '
        Me.lbCN12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbCN12.AutoSize = True
        Me.lbCN12.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbCN12.Location = New System.Drawing.Point(68, 6)
        Me.lbCN12.Name = "lbCN12"
        Me.lbCN12.Size = New System.Drawing.Size(31, 13)
        Me.lbCN12.TabIndex = 0
        Me.lbCN12.Text = "Fb12"
        '
        'lbCN22
        '
        Me.lbCN22.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbCN22.AutoSize = True
        Me.lbCN22.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbCN22.Location = New System.Drawing.Point(68, 31)
        Me.lbCN22.Name = "lbCN22"
        Me.lbCN22.Size = New System.Drawing.Size(31, 13)
        Me.lbCN22.TabIndex = 0
        Me.lbCN22.Text = "Fb22"
        '
        'lbCN21
        '
        Me.lbCN21.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbCN21.AutoSize = True
        Me.lbCN21.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbCN21.Location = New System.Drawing.Point(3, 31)
        Me.lbCN21.Name = "lbCN21"
        Me.lbCN21.Size = New System.Drawing.Size(31, 13)
        Me.lbCN21.TabIndex = 0
        Me.lbCN21.Text = "Fb21"
        '
        'lbAngFabCN1
        '
        Me.lbAngFabCN1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbAngFabCN1.AutoSize = True
        Me.lbAngFabCN1.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbAngFabCN1.Location = New System.Drawing.Point(137, 6)
        Me.lbAngFabCN1.Name = "lbAngFabCN1"
        Me.lbAngFabCN1.Size = New System.Drawing.Size(50, 13)
        Me.lbAngFabCN1.TabIndex = 0
        Me.lbAngFabCN1.Text = "angAxis1"
        '
        'lbCN1
        '
        Me.lbCN1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbCN1.AutoSize = True
        Me.lbCN1.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbCN1.Location = New System.Drawing.Point(221, 6)
        Me.lbCN1.Name = "lbCN1"
        Me.lbCN1.Size = New System.Drawing.Size(16, 13)
        Me.lbCN1.TabIndex = 0
        Me.lbCN1.Text = "FI"
        '
        'lbCN2
        '
        Me.lbCN2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbCN2.AutoSize = True
        Me.lbCN2.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbCN2.Location = New System.Drawing.Point(219, 31)
        Me.lbCN2.Name = "lbCN2"
        Me.lbCN2.Size = New System.Drawing.Size(19, 13)
        Me.lbCN2.TabIndex = 0
        Me.lbCN2.Text = "FII"
        '
        'lbAngFabCN2
        '
        Me.lbAngFabCN2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbAngFabCN2.AutoSize = True
        Me.lbAngFabCN2.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.lbAngFabCN2.Location = New System.Drawing.Point(137, 31)
        Me.lbAngFabCN2.Name = "lbAngFabCN2"
        Me.lbAngFabCN2.Size = New System.Drawing.Size(50, 13)
        Me.lbAngFabCN2.TabIndex = 0
        Me.lbAngFabCN2.Text = "angAxis2"
        '
        'chkShowRoseLegend
        '
        Me.chkShowRoseLegend.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkShowRoseLegend.AutoSize = True
        Me.chkShowRoseLegend.BackColor = System.Drawing.Color.White
        Me.chkShowRoseLegend.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.chkShowRoseLegend.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.chkShowRoseLegend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowRoseLegend.ForeColor = System.Drawing.Color.Black
        Me.chkShowRoseLegend.Location = New System.Drawing.Point(543, 9)
        Me.chkShowRoseLegend.Name = "chkShowRoseLegend"
        Me.chkShowRoseLegend.Size = New System.Drawing.Size(59, 25)
        Me.chkShowRoseLegend.TabIndex = 22
        Me.chkShowRoseLegend.Text = "Legend"
        Me.chkShowRoseLegend.UseVisualStyleBackColor = False
        '
        'chkShowSldNorm
        '
        Me.chkShowSldNorm.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkShowSldNorm.AutoSize = True
        Me.chkShowSldNorm.BackColor = System.Drawing.Color.White
        Me.chkShowSldNorm.Enabled = False
        Me.chkShowSldNorm.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.chkShowSldNorm.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.chkShowSldNorm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowSldNorm.ForeColor = System.Drawing.Color.Black
        Me.chkShowSldNorm.Location = New System.Drawing.Point(320, 304)
        Me.chkShowSldNorm.Name = "chkShowSldNorm"
        Me.chkShowSldNorm.Size = New System.Drawing.Size(55, 25)
        Me.chkShowSldNorm.TabIndex = 23
        Me.chkShowSldNorm.Text = "Sliding"
        Me.chkShowSldNorm.UseVisualStyleBackColor = False
        '
        'roseForceNormTang
        '
        Me.roseForceNormTang.BackColor = System.Drawing.Color.White
        Me.roseForceNormTang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.roseForceNormTang.Location = New System.Drawing.Point(627, 2)
        Me.roseForceNormTang.Name = "roseForceNormTang"
        Me.roseForceNormTang.Size = New System.Drawing.Size(300, 328)
        Me.roseForceNormTang.TabIndex = 24
        Me.roseForceNormTang.TabStop = False
        '
        'roseShearRatio
        '
        Me.roseShearRatio.BackColor = System.Drawing.Color.White
        Me.roseShearRatio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.roseShearRatio.Location = New System.Drawing.Point(627, 336)
        Me.roseShearRatio.Name = "roseShearRatio"
        Me.roseShearRatio.Size = New System.Drawing.Size(300, 328)
        Me.roseShearRatio.TabIndex = 26
        Me.roseShearRatio.TabStop = False
        '
        'lbExpandWindow
        '
        Me.lbExpandWindow.AutoSize = True
        Me.lbExpandWindow.Location = New System.Drawing.Point(615, 2)
        Me.lbExpandWindow.Name = "lbExpandWindow"
        Me.lbExpandWindow.Size = New System.Drawing.Size(14, 15)
        Me.lbExpandWindow.TabIndex = 27
        Me.lbExpandWindow.Text = "<"
        '
        'lbRoseForceNormTang
        '
        Me.lbRoseForceNormTang.AutoSize = True
        Me.lbRoseForceNormTang.BackColor = System.Drawing.Color.White
        Me.lbRoseForceNormTang.ForeColor = System.Drawing.Color.Black
        Me.lbRoseForceNormTang.Location = New System.Drawing.Point(637, 9)
        Me.lbRoseForceNormTang.Name = "lbRoseForceNormTang"
        Me.lbRoseForceNormTang.Size = New System.Drawing.Size(143, 15)
        Me.lbRoseForceNormTang.TabIndex = 28
        Me.lbRoseForceNormTang.Text = "Normal-Tangential Force"
        '
        'lbRoseShearRatio
        '
        Me.lbRoseShearRatio.AutoSize = True
        Me.lbRoseShearRatio.BackColor = System.Drawing.Color.White
        Me.lbRoseShearRatio.ForeColor = System.Drawing.Color.Black
        Me.lbRoseShearRatio.Location = New System.Drawing.Point(632, 338)
        Me.lbRoseShearRatio.Name = "lbRoseShearRatio"
        Me.lbRoseShearRatio.Size = New System.Drawing.Size(72, 15)
        Me.lbRoseShearRatio.TabIndex = 29
        Me.lbRoseShearRatio.Text = "Shear Ratio"
        '
        'setScaleShearRatio
        '
        Me.setScaleShearRatio.DecimalPlaces = 2
        Me.setScaleShearRatio.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.setScaleShearRatio.Location = New System.Drawing.Point(860, 636)
        Me.setScaleShearRatio.Name = "setScaleShearRatio"
        Me.setScaleShearRatio.Size = New System.Drawing.Size(60, 21)
        Me.setScaleShearRatio.TabIndex = 30
        Me.setScaleShearRatio.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'setScaleForceNT
        '
        Me.setScaleForceNT.DecimalPlaces = 2
        Me.setScaleForceNT.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.setScaleForceNT.Location = New System.Drawing.Point(860, 304)
        Me.setScaleForceNT.Name = "setScaleForceNT"
        Me.setScaleForceNT.Size = New System.Drawing.Size(60, 21)
        Me.setScaleForceNT.TabIndex = 31
        Me.setScaleForceNT.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnResetScaleForceNT
        '
        Me.btnResetScaleForceNT.BackColor = System.Drawing.Color.White
        Me.btnResetScaleForceNT.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnResetScaleForceNT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetScaleForceNT.ForeColor = System.Drawing.Color.Black
        Me.btnResetScaleForceNT.Location = New System.Drawing.Point(630, 303)
        Me.btnResetScaleForceNT.Name = "btnResetScaleForceNT"
        Me.btnResetScaleForceNT.Size = New System.Drawing.Size(56, 23)
        Me.btnResetScaleForceNT.TabIndex = 32
        Me.btnResetScaleForceNT.Text = "Reset"
        Me.btnResetScaleForceNT.UseVisualStyleBackColor = False
        '
        'chkAllExp
        '
        Me.chkAllExp.AutoSize = True
        Me.chkAllExp.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.chkAllExp.Location = New System.Drawing.Point(224, 863)
        Me.chkAllExp.Name = "chkAllExp"
        Me.chkAllExp.Size = New System.Drawing.Size(47, 18)
        Me.chkAllExp.TabIndex = 33
        Me.chkAllExp.Text = "All E"
        Me.chkAllExp.UseVisualStyleBackColor = True
        '
        'Histgram
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(934, 886)
        Me.Controls.Add(Me.chkAllExp)
        Me.Controls.Add(Me.btnResetScaleForceNT)
        Me.Controls.Add(Me.setScaleForceNT)
        Me.Controls.Add(Me.setScaleShearRatio)
        Me.Controls.Add(Me.lbRoseShearRatio)
        Me.Controls.Add(Me.lbRoseForceNormTang)
        Me.Controls.Add(Me.roseShearRatio)
        Me.Controls.Add(Me.roseForceNormTang)
        Me.Controls.Add(Me.chkShowSldNorm)
        Me.Controls.Add(Me.chkShowRoseLegend)
        Me.Controls.Add(Me.setScalePolar)
        Me.Controls.Add(Me.chkAlwaysTop)
        Me.Controls.Add(Me.chkShowRefLine)
        Me.Controls.Add(Me.setAngRefLine)
        Me.Controls.Add(Me.setTransHist)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbContactNumber)
        Me.Controls.Add(Me.groupTsBodyStress)
        Me.Controls.Add(Me.groupTsStress)
        Me.Controls.Add(Me.gbFabricConNorm)
        Me.Controls.Add(Me.groupTsFabric)
        Me.Controls.Add(Me.chkIBoundMode)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.roseForce)
        Me.Controls.Add(Me.roseNorm)
        Me.Controls.Add(Me.roseOrit)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.hgFR)
        Me.Controls.Add(Me.lbExpandWindow)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Histgram"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PPDEM -  Histograms and other variables"
        Me.TopMost = True
        CType(Me.roseForce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.roseOrit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.hgFR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.roseNorm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.groupTsFabric.ResumeLayout(False)
        Me.groupTsFabric.PerformLayout()
        Me.groupTsStress.ResumeLayout(False)
        Me.groupTsStress.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.groupTsBodyStress.ResumeLayout(False)
        Me.groupTsBodyStress.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.setTransHist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setAngRefLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setScalePolar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFabricConNorm.ResumeLayout(False)
        Me.gbFabricConNorm.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.roseForceNormTang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.roseShearRatio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setScaleShearRatio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setScaleForceNT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents roseForce As System.Windows.Forms.PictureBox
    Friend WithEvents roseOrit As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rbMaskHist As System.Windows.Forms.RadioButton
    Friend WithEvents rbGlobHist As System.Windows.Forms.RadioButton
    Friend WithEvents btnNewMask As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbCount As System.Windows.Forms.RadioButton
    Friend WithEvents rbWeighted As System.Windows.Forms.RadioButton
    Friend WithEvents hgFR As System.Windows.Forms.PictureBox
    Friend WithEvents roseNorm As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkIBoundMode As System.Windows.Forms.CheckBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbFb11 As System.Windows.Forms.Label
    Friend WithEvents groupTsFabric As System.Windows.Forms.GroupBox
    Friend WithEvents groupTsStress As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbFb12 As System.Windows.Forms.Label
    Friend WithEvents lbFb22 As System.Windows.Forms.Label
    Friend WithEvents lbFb21 As System.Windows.Forms.Label
    Friend WithEvents lbStress11 As System.Windows.Forms.Label
    Friend WithEvents lbStress12 As System.Windows.Forms.Label
    Friend WithEvents lbStress22 As System.Windows.Forms.Label
    Friend WithEvents lbStress21 As System.Windows.Forms.Label
    Friend WithEvents lbAngFabAxis1 As System.Windows.Forms.Label
    Friend WithEvents lbF1 As System.Windows.Forms.Label
    Friend WithEvents lbF2 As System.Windows.Forms.Label
    Friend WithEvents lbAngFabAxis2 As System.Windows.Forms.Label
    Friend WithEvents lbAngStressAxis2 As System.Windows.Forms.Label
    Friend WithEvents lbPrnStress1 As System.Windows.Forms.Label
    Friend WithEvents lbAngStressAxis1 As System.Windows.Forms.Label
    Friend WithEvents lbPrnStress2 As System.Windows.Forms.Label
    Friend WithEvents lbContactNumber As System.Windows.Forms.Label
    Friend WithEvents groupTsBodyStress As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbBodyStress11 As System.Windows.Forms.Label
    Friend WithEvents lbBodyStress12 As System.Windows.Forms.Label
    Friend WithEvents lbBodyStress22 As System.Windows.Forms.Label
    Friend WithEvents lbBodyStress21 As System.Windows.Forms.Label
    Friend WithEvents lbAngBodyStressAxis2 As System.Windows.Forms.Label
    Friend WithEvents lbPrnBodyStress1 As System.Windows.Forms.Label
    Friend WithEvents lbAngBodyStressAxis1 As System.Windows.Forms.Label
    Friend WithEvents lbPrnBodyStress2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbFabricWeightYY As System.Windows.Forms.RadioButton
    Friend WithEvents rbFabricWeightXX As System.Windows.Forms.RadioButton
    Friend WithEvents rbFabricWeightMaxShear As System.Windows.Forms.RadioButton
    Friend WithEvents rbFabricWeightBulk As System.Windows.Forms.RadioButton
    Friend WithEvents rbFabricWeightXY As System.Windows.Forms.RadioButton
    Friend WithEvents rbFabricWeightNone As System.Windows.Forms.RadioButton
    Friend WithEvents setTransHist As System.Windows.Forms.TrackBar
    Friend WithEvents setAngRefLine As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkShowRefLine As System.Windows.Forms.CheckBox
    Friend WithEvents chkFabExp As System.Windows.Forms.CheckBox
    Friend WithEvents chkStsExp As System.Windows.Forms.CheckBox
    Friend WithEvents chkAlwaysTop As System.Windows.Forms.CheckBox
    Friend WithEvents btnImpMask As System.Windows.Forms.Button
    Friend WithEvents btnExpMask As System.Windows.Forms.Button
    Friend WithEvents setScalePolar As System.Windows.Forms.NumericUpDown
    Friend WithEvents gbFabricConNorm As System.Windows.Forms.GroupBox
    Friend WithEvents chkCNExp As System.Windows.Forms.CheckBox
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbCN11 As System.Windows.Forms.Label
    Friend WithEvents lbCN12 As System.Windows.Forms.Label
    Friend WithEvents lbCN22 As System.Windows.Forms.Label
    Friend WithEvents lbCN21 As System.Windows.Forms.Label
    Friend WithEvents lbAngFabCN1 As System.Windows.Forms.Label
    Friend WithEvents lbCN1 As System.Windows.Forms.Label
    Friend WithEvents lbCN2 As System.Windows.Forms.Label
    Friend WithEvents lbAngFabCN2 As System.Windows.Forms.Label
    Friend WithEvents chkShowRoseLegend As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowSldNorm As System.Windows.Forms.CheckBox
    Friend WithEvents roseForceNormTang As System.Windows.Forms.PictureBox
    Friend WithEvents roseShearRatio As System.Windows.Forms.PictureBox
    Friend WithEvents lbExpandWindow As System.Windows.Forms.Label
    Friend WithEvents lbRoseForceNormTang As System.Windows.Forms.Label
    Friend WithEvents lbRoseShearRatio As System.Windows.Forms.Label
    Friend WithEvents setScaleShearRatio As System.Windows.Forms.NumericUpDown
    Friend WithEvents setScaleForceNT As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnResetScaleForceNT As System.Windows.Forms.Button
    Friend WithEvents checkStsBExp As System.Windows.Forms.CheckBox
    Friend WithEvents chkAllExp As System.Windows.Forms.CheckBox

End Class
