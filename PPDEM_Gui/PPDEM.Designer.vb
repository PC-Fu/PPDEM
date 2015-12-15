<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PPDEM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PPDEM))
        Me.timerTest = New System.Windows.Forms.Timer(Me.components)
        Me.tInc = New System.Windows.Forms.NumericUpDown()
        Me.refRate = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nIncr = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nIncDisp = New System.Windows.Forms.Label()
        Me.LbStiff = New System.Windows.Forms.Label()
        Me.setE = New System.Windows.Forms.NumericUpDown()
        Me.MovDown = New System.Windows.Forms.Button()
        Me.MovUp = New System.Windows.Forms.Button()
        Me.MovRight = New System.Windows.Forms.Button()
        Me.MovLeft = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.maxRFriend_label = New System.Windows.Forms.Label()
        Me.setGlobDamp = New System.Windows.Forms.NumericUpDown()
        Me.setMaxRFriend = New System.Windows.Forms.NumericUpDown()
        Me.lb_set_PPFricAng = New System.Windows.Forms.Label()
        Me.setTanTheta1 = New System.Windows.Forms.NumericUpDown()
        Me.btnCW = New System.Windows.Forms.Button()
        Me.btnCCW = New System.Windows.Forms.Button()
        Me.setAngle = New System.Windows.Forms.NumericUpDown()
        Me.chsWall = New System.Windows.Forms.Button()
        Me.setRollingDamp = New System.Windows.Forms.NumericUpDown()
        Me.setDampingRatio = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.OpenSnapshot = New System.Windows.Forms.OpenFileDialog()
        Me.SaveSnapshot = New System.Windows.Forms.SaveFileDialog()
        Me.btnOpenTest = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.setpInt = New System.Windows.Forms.NumericUpDown()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnZoomIn = New System.Windows.Forms.Button()
        Me.btnZoomOut = New System.Windows.Forms.Button()
        Me.setCurrentLoadRate = New System.Windows.Forms.NumericUpDown()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.timeSaveFile = New System.Windows.Forms.Timer(Me.components)
        Me.checkFlagDebug = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btGlue = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabSystem = New System.Windows.Forms.TabPage()
        Me.gbThinLayer = New System.Windows.Forms.GroupBox()
        Me.chkLayerNoRotation = New System.Windows.Forms.CheckBox()
        Me.chkLayerLowFric = New System.Windows.Forms.CheckBox()
        Me.setHThinLayer = New System.Windows.Forms.NumericUpDown()
        Me.setRotDamp = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.setOutputFreq = New System.Windows.Forms.NumericUpDown()
        Me.btnOutput = New System.Windows.Forms.Button()
        Me.chkMonitorSystemVariable = New System.Windows.Forms.CheckBox()
        Me.chkSave = New System.Windows.Forms.CheckBox()
        Me.setFreqSaveRST = New System.Windows.Forms.NumericUpDown()
        Me.lbCritDt = New System.Windows.Forms.Label()
        Me.chkMassNorm = New System.Windows.Forms.CheckBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.chkAutoMaxRFriend = New System.Windows.Forms.CheckBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ctrlNumProcessor = New System.Windows.Forms.NumericUpDown()
        Me.ctrlMaxNEle = New System.Windows.Forms.NumericUpDown()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.setTanTheta2 = New System.Windows.Forms.NumericUpDown()
        Me.tabView = New System.Windows.Forms.TabPage()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.setPenWidth = New System.Windows.Forms.NumericUpDown()
        Me.gbCanvas2File = New System.Windows.Forms.GroupBox()
        Me.btnSaveMovie = New System.Windows.Forms.Button()
        Me.rbExpAll = New System.Windows.Forms.RadioButton()
        Me.rbExpVisible = New System.Windows.Forms.RadioButton()
        Me.btnCanvas2File = New System.Windows.Forms.Button()
        Me.chkShowGrid = New System.Windows.Forms.CheckBox()
        Me.grpRotationMode = New System.Windows.Forms.GroupBox()
        Me.rbRotationMode2 = New System.Windows.Forms.RadioButton()
        Me.rbRotationMode1 = New System.Windows.Forms.RadioButton()
        Me.lbVelFactor = New System.Windows.Forms.Label()
        Me.btnCanvasColor = New System.Windows.Forms.Button()
        Me.grpHist = New System.Windows.Forms.GroupBox()
        Me.chkExportCon = New System.Windows.Forms.CheckBox()
        Me.modeHist = New System.Windows.Forms.CheckBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.setNBinFR = New System.Windows.Forms.NumericUpDown()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.setNBinOri = New System.Windows.Forms.NumericUpDown()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.setNBinForce = New System.Windows.Forms.NumericUpDown()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.setNBinNorm = New System.Windows.Forms.NumericUpDown()
        Me.chkMeasureMode = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkHideElement = New System.Windows.Forms.CheckBox()
        Me.chkShowEleNum = New System.Windows.Forms.CheckBox()
        Me.showLine = New System.Windows.Forms.CheckBox()
        Me.showARC = New System.Windows.Forms.CheckBox()
        Me.chkShowFriend = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkConForceByRadius = New System.Windows.Forms.CheckBox()
        Me.btnForLengScaleUp = New System.Windows.Forms.Button()
        Me.btnForLengScaleDown = New System.Windows.Forms.Button()
        Me.btnAutoFScaleLeng = New System.Windows.Forms.Button()
        Me.btnAutoFScaleThick = New System.Windows.Forms.Button()
        Me.btnFSceleThickUp = New System.Windows.Forms.Button()
        Me.btnFScaleThickDown = New System.Windows.Forms.Button()
        Me.grpForceViewMode = New System.Windows.Forms.GroupBox()
        Me.rbForceModeConn = New System.Windows.Forms.RadioButton()
        Me.rbForceModeDire = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.setFactorSlidContrast = New System.Windows.Forms.NumericUpDown()
        Me.btnSScaleUp = New System.Windows.Forms.Button()
        Me.btnSScaleDown = New System.Windows.Forms.Button()
        Me.btnAutoSScale = New System.Windows.Forms.Button()
        Me.chkShowSliding = New System.Windows.Forms.CheckBox()
        Me.chkIncWallForce = New System.Windows.Forms.CheckBox()
        Me.flagForceByLeng = New System.Windows.Forms.CheckBox()
        Me.chkShowForceColor = New System.Windows.Forms.CheckBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Constrast = New System.Windows.Forms.Label()
        Me.cstForceThickLeng = New System.Windows.Forms.NumericUpDown()
        Me.chkForceByThick = New System.Windows.Forms.CheckBox()
        Me.cstForceThickContrast = New System.Windows.Forms.NumericUpDown()
        Me.chkShowCohesion = New System.Windows.Forms.CheckBox()
        Me.chkShowCoord = New System.Windows.Forms.CheckBox()
        Me.flagRotation = New System.Windows.Forms.CheckBox()
        Me.btVelMinus = New System.Windows.Forms.Button()
        Me.checkShowVel = New System.Windows.Forms.CheckBox()
        Me.flagShowP = New System.Windows.Forms.CheckBox()
        Me.btnHalfPScale = New System.Windows.Forms.Button()
        Me.btnDoublePScale = New System.Windows.Forms.Button()
        Me.btVelPlus = New System.Windows.Forms.Button()
        Me.tabLoad = New System.Windows.Forms.TabPage()
        Me.grpLoadModeControl = New System.Windows.Forms.GroupBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.setLoadModeTopT = New System.Windows.Forms.ComboBox()
        Me.setLoadModeTopN = New System.Windows.Forms.ComboBox()
        Me.setLoadModeLeftT = New System.Windows.Forms.ComboBox()
        Me.setLoadModeBottomT = New System.Windows.Forms.ComboBox()
        Me.setLoadModeLeftN = New System.Windows.Forms.ComboBox()
        Me.setLoadModeRightT = New System.Windows.Forms.ComboBox()
        Me.setLoadModeBottomN = New System.Windows.Forms.ComboBox()
        Me.setLoadModeRightN = New System.Windows.Forms.ComboBox()
        Me.grpBatchLoading = New System.Windows.Forms.GroupBox()
        Me.cycDis = New System.Windows.Forms.Label()
        Me.setCyclicDisplacement = New System.Windows.Forms.NumericUpDown()
        Me.setInitialLoadDirection = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.setQLimit = New System.Windows.Forms.NumericUpDown()
        Me.cbSpecialLoad = New System.Windows.Forms.ComboBox()
        Me.lbICurStep3 = New System.Windows.Forms.Label()
        Me.lbICurStep2 = New System.Windows.Forms.Label()
        Me.lbICurStep1 = New System.Windows.Forms.Label()
        Me.rbBatchLoading = New System.Windows.Forms.RadioButton()
        Me.rbManualLoading = New System.Windows.Forms.RadioButton()
        Me.btnOpenBatchLoading = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.CentripetalG = New System.Windows.Forms.CheckBox()
        Me.setXGravity = New System.Windows.Forms.NumericUpDown()
        Me.setGX = New System.Windows.Forms.NumericUpDown()
        Me.setGY = New System.Windows.Forms.NumericUpDown()
        Me.setYGravity = New System.Windows.Forms.NumericUpDown()
        Me.grpDisplacementLoadControl = New System.Windows.Forms.GroupBox()
        Me.chkProgressiveLoading = New System.Windows.Forms.CheckBox()
        Me.setSteptoGo = New System.Windows.Forms.NumericUpDown()
        Me.setTargetLoadRate = New System.Windows.Forms.NumericUpDown()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.grpConfiningControl = New System.Windows.Forms.GroupBox()
        Me.setpxy = New System.Windows.Forms.NumericUpDown()
        Me.setPy = New System.Windows.Forms.NumericUpDown()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.setPx = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnAutoWall = New System.Windows.Forms.Button()
        Me.incWall = New System.Windows.Forms.NumericUpDown()
        Me.tabEdit = New System.Windows.Forms.TabPage()
        Me.grpDiscMask = New System.Windows.Forms.GroupBox()
        Me.chkExpDiscMask = New System.Windows.Forms.CheckBox()
        Me.chkShwDiscMask = New System.Windows.Forms.CheckBox()
        Me.btnApdDiscMask = New System.Windows.Forms.Button()
        Me.btnRstDiscMask = New System.Windows.Forms.Button()
        Me.textEleQuery = New System.Windows.Forms.TextBox()
        Me.grpCrop = New System.Windows.Forms.GroupBox()
        Me.btnMaskReverse = New System.Windows.Forms.Button()
        Me.btnEleQuery = New System.Windows.Forms.Button()
        Me.btnCrop = New System.Windows.Forms.Button()
        Me.btnMaskCrop = New System.Windows.Forms.Button()
        Me.grpMaskShape = New System.Windows.Forms.GroupBox()
        Me.rbMaskRect = New System.Windows.Forms.RadioButton()
        Me.rbMaskPoly = New System.Windows.Forms.RadioButton()
        Me.rbMaskCircular = New System.Windows.Forms.RadioButton()
        Me.grpEditOption = New System.Windows.Forms.GroupBox()
        Me.rbEleRomove = New System.Windows.Forms.RadioButton()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnRotate = New System.Windows.Forms.Button()
        Me.setAngRotate = New System.Windows.Forms.NumericUpDown()
        Me.setCAC = New System.Windows.Forms.NumericUpDown()
        Me.rbEleAdd = New System.Windows.Forms.RadioButton()
        Me.rbEleRotate = New System.Windows.Forms.RadioButton()
        Me.rbSampleRotate = New System.Windows.Forms.RadioButton()
        Me.rbEleCopy = New System.Windows.Forms.RadioButton()
        Me.rbEleShape = New System.Windows.Forms.RadioButton()
        Me.rbEleMove = New System.Windows.Forms.RadioButton()
        Me.rbView = New System.Windows.Forms.RadioButton()
        Me.tabPost = New System.Windows.Forms.TabPage()
        Me.grpGridDeform = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.rbDyeBand = New System.Windows.Forms.RadioButton()
        Me.rbDyeGrid = New System.Windows.Forms.RadioButton()
        Me.rbGridLine = New System.Windows.Forms.RadioButton()
        Me.setDyeDark = New System.Windows.Forms.NumericUpDown()
        Me.setIntvlDye = New System.Windows.Forms.NumericUpDown()
        Me.setAngDye = New System.Windows.Forms.NumericUpDown()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.setNumGD = New System.Windows.Forms.NumericUpDown()
        Me.btnNewGD = New System.Windows.Forms.Button()
        Me.groupPtclMotion = New System.Windows.Forms.GroupBox()
        Me.chkLockIStepJStep = New System.Windows.Forms.CheckBox()
        Me.showJStep = New System.Windows.Forms.Label()
        Me.gbShowSlideTrace = New System.Windows.Forms.GroupBox()
        Me.chkShowRollingTrace = New System.Windows.Forms.CheckBox()
        Me.chkShowSldTrace = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbContourCoordNum = New System.Windows.Forms.RadioButton()
        Me.setRefOri = New System.Windows.Forms.NumericUpDown()
        Me.rbRelaOri = New System.Windows.Forms.RadioButton()
        Me.rbContourOri = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.rbModeForce = New System.Windows.Forms.RadioButton()
        Me.rbModeStress = New System.Windows.Forms.RadioButton()
        Me.rbContourXY = New System.Windows.Forms.RadioButton()
        Me.rbContourYY = New System.Windows.Forms.RadioButton()
        Me.rbContourXX = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rbBlack = New System.Windows.Forms.RadioButton()
        Me.rbGray = New System.Windows.Forms.RadioButton()
        Me.rbColor = New System.Windows.Forms.RadioButton()
        Me.rbCountorBulk = New System.Windows.Forms.RadioButton()
        Me.rbContourShear = New System.Windows.Forms.RadioButton()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.chkMode1 = New System.Windows.Forms.RadioButton()
        Me.chkMode0 = New System.Windows.Forms.RadioButton()
        Me.setRelaMin = New System.Windows.Forms.NumericUpDown()
        Me.setRelaMax = New System.Windows.Forms.NumericUpDown()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.containerContourRange = New System.Windows.Forms.TableLayoutPanel()
        Me.lowContourRange = New System.Windows.Forms.TrackBar()
        Me.upContourRange = New System.Windows.Forms.TrackBar()
        Me.rbContourH = New System.Windows.Forms.RadioButton()
        Me.rbContourU = New System.Windows.Forms.RadioButton()
        Me.rbContourR = New System.Windows.Forms.RadioButton()
        Me.rbContourV = New System.Windows.Forms.RadioButton()
        Me.chkDefContour = New System.Windows.Forms.CheckBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.trackStateB = New System.Windows.Forms.TrackBar()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.setStepSparse = New System.Windows.Forms.NumericUpDown()
        Me.chkColorTrace = New System.Windows.Forms.CheckBox()
        Me.rbV = New System.Windows.Forms.RadioButton()
        Me.rbH = New System.Windows.Forms.RadioButton()
        Me.chkShowTrace = New System.Windows.Forms.CheckBox()
        Me.chkShowRotation = New System.Windows.Forms.CheckBox()
        Me.btnRotationScaleUp = New System.Windows.Forms.Button()
        Me.btnRotationScaleDown = New System.Windows.Forms.Button()
        Me.groupPostMode = New System.Windows.Forms.GroupBox()
        Me.chkHideElement2 = New System.Windows.Forms.CheckBox()
        Me.modeVR = New System.Windows.Forms.CheckBox()
        Me.modeGD = New System.Windows.Forms.CheckBox()
        Me.modeMotion = New System.Windows.Forms.CheckBox()
        Me.btnOpenResult = New System.Windows.Forms.Button()
        Me.tabStrain = New System.Windows.Forms.TabPage()
        Me.chkExpWallPosition = New System.Windows.Forms.CheckBox()
        Me.btnMaskCell = New System.Windows.Forms.Button()
        Me.gbShowStnDrct = New System.Windows.Forms.GroupBox()
        Me.rbDrctMaxShear = New System.Windows.Forms.RadioButton()
        Me.rbDrctStnXX = New System.Windows.Forms.RadioButton()
        Me.rbDrctShearFlow = New System.Windows.Forms.RadioButton()
        Me.rbDrctStnII = New System.Windows.Forms.RadioButton()
        Me.rbDrctStnI = New System.Windows.Forms.RadioButton()
        Me.gbStnMode = New System.Windows.Forms.GroupBox()
        Me.rbModeStnRate = New System.Windows.Forms.RadioButton()
        Me.rbModeStnInc = New System.Windows.Forms.RadioButton()
        Me.gbCellMode = New System.Windows.Forms.GroupBox()
        Me.rbDelauany = New System.Windows.Forms.RadioButton()
        Me.rbHomoTri = New System.Windows.Forms.RadioButton()
        Me.btnAllAct = New System.Windows.Forms.Button()
        Me.btnResetCell = New System.Windows.Forms.Button()
        Me.btnStrnTrack = New System.Windows.Forms.Button()
        Me.btnExpCellStrn = New System.Windows.Forms.Button()
        Me.btnClearActCell = New System.Windows.Forms.Button()
        Me.chkAddActCell = New System.Windows.Forms.CheckBox()
        Me.chkShwStrnVal = New System.Windows.Forms.CheckBox()
        Me.setValLegend = New System.Windows.Forms.NumericUpDown()
        Me.chkShowStnLegend = New System.Windows.Forms.CheckBox()
        Me.setStnContrast = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.chkLgthStrn = New System.Windows.Forms.CheckBox()
        Me.btnStnDrctScaleDown = New System.Windows.Forms.Button()
        Me.btnStnDrctScaleUp = New System.Windows.Forms.Button()
        Me.chkShowStnDrct = New System.Windows.Forms.CheckBox()
        Me.gbPickStnSign = New System.Windows.Forms.GroupBox()
        Me.rbShowBothStn = New System.Windows.Forms.RadioButton()
        Me.rbShowNegStn = New System.Windows.Forms.RadioButton()
        Me.rbShowPosiStn = New System.Windows.Forms.RadioButton()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.rbSpinTensor = New System.Windows.Forms.RadioButton()
        Me.rbShearFlowRate = New System.Windows.Forms.RadioButton()
        Me.rbStrainXYN = New System.Windows.Forms.RadioButton()
        Me.rbStrainN = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.setAngN = New System.Windows.Forms.NumericUpDown()
        Me.rbStrainXYMax = New System.Windows.Forms.RadioButton()
        Me.rbStrainII = New System.Windows.Forms.RadioButton()
        Me.rbStrainI = New System.Windows.Forms.RadioButton()
        Me.rbStrainXY = New System.Windows.Forms.RadioButton()
        Me.rbStrainYY = New System.Windows.Forms.RadioButton()
        Me.rbStrainXX = New System.Windows.Forms.RadioButton()
        Me.rbStrainV = New System.Windows.Forms.RadioButton()
        Me.btnStnScaleDown = New System.Windows.Forms.Button()
        Me.btnStnScaleUp = New System.Windows.Forms.Button()
        Me.chkShowStrain = New System.Windows.Forms.CheckBox()
        Me.chkShowCell = New System.Windows.Forms.CheckBox()
        Me.setNumCell = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.setRdStnCell = New System.Windows.Forms.NumericUpDown()
        Me.btnIniStnCell = New System.Windows.Forms.Button()
        Me.tabCellFabric = New System.Windows.Forms.TabPage()
        Me.gbStressRotation = New System.Windows.Forms.GroupBox()
        Me.setStressRotationRate = New System.Windows.Forms.NumericUpDown()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.btnOpenAngFile = New System.Windows.Forms.Button()
        Me.setPStressAng = New System.Windows.Forms.NumericUpDown()
        Me.chkStressRotation = New System.Windows.Forms.CheckBox()
        Me.setStressIncRate = New System.Windows.Forms.NumericUpDown()
        Me.setMaxStep = New System.Windows.Forms.NumericUpDown()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.chkExpVVTs = New System.Windows.Forms.CheckBox()
        Me.chkShowVCFabric = New System.Windows.Forms.CheckBox()
        Me.chkShowVoidVector = New System.Windows.Forms.CheckBox()
        Me.chkShowVCBound = New System.Windows.Forms.CheckBox()
        Me.chkShowVCNum = New System.Windows.Forms.CheckBox()
        Me.chkExtVC = New System.Windows.Forms.CheckBox()
        Me.chkShowDualCelll = New System.Windows.Forms.CheckBox()
        Me.chkShowEdgeNum = New System.Windows.Forms.CheckBox()
        Me.chkShowSolidCell = New System.Windows.Forms.CheckBox()
        Me.setCellOpacity = New System.Windows.Forms.TrackBar()
        Me.chkShowCellNum = New System.Windows.Forms.CheckBox()
        Me.chkShowEffEdge = New System.Windows.Forms.CheckBox()
        Me.rbShowCrctCell = New System.Windows.Forms.RadioButton()
        Me.rbShowOriCell = New System.Windows.Forms.RadioButton()
        Me.chkShowContNum = New System.Windows.Forms.CheckBox()
        Me.chkShowCellInEle = New System.Windows.Forms.CheckBox()
        Me.btnIniCellInEle = New System.Windows.Forms.Button()
        Me.tabLink = New System.Windows.Forms.TabPage()
        Me.chkHLLinks = New System.Windows.Forms.CheckBox()
        Me.btnExportLinks = New System.Windows.Forms.Button()
        Me.btnImpLinkID = New System.Windows.Forms.Button()
        Me.setLinkDampingRatio = New System.Windows.Forms.NumericUpDown()
        Me.btnLinkStiffMinus = New System.Windows.Forms.Button()
        Me.btnLinkStiffPlus = New System.Windows.Forms.Button()
        Me.btnImpLinkCoord = New System.Windows.Forms.Button()
        Me.tabAnalysis = New System.Windows.Forms.TabPage()
        Me.chkTrackMinDist = New System.Windows.Forms.CheckBox()
        Me.btnCalMinDist = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.chkFixDNColor = New System.Windows.Forms.CheckBox()
        Me.chkTracDNSpatial = New System.Windows.Forms.CheckBox()
        Me.setCNUpB = New System.Windows.Forms.NumericUpDown()
        Me.setCNLowB = New System.Windows.Forms.NumericUpDown()
        Me.btnExpCoordNumMatrix = New System.Windows.Forms.Button()
        Me.btnStartCoordNumMatrix = New System.Windows.Forms.Button()
        Me.chkShowCNMatrix = New System.Windows.Forms.CheckBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.setCoordNumMatrixSampIntv = New System.Windows.Forms.NumericUpDown()
        Me.setCoordNumMatrixBoxSize = New System.Windows.Forms.NumericUpDown()
        Me.btnSnapShot = New System.Windows.Forms.Button()
        Me.canvasContainer = New System.Windows.Forms.Panel()
        Me.mainTransparency = New System.Windows.Forms.TrackBar()
        Me.canvas = New System.Windows.Forms.PictureBox()
        Me.timerZoomIn = New System.Windows.Forms.Timer(Me.components)
        Me.dlgOpenTest = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.dlgSaveResults = New System.Windows.Forms.SaveFileDialog()
        Me.trackPost = New System.Windows.Forms.TrackBar()
        Me.dlgOpenResults = New System.Windows.Forms.OpenFileDialog()
        Me.setZoomFactor = New System.Windows.Forms.NumericUpDown()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.dlgCanvasColor = New System.Windows.Forms.ColorDialog()
        Me.showCurrentStepPost = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.timerPlay = New System.Windows.Forms.Timer(Me.components)
        Me.showPpM = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.tInc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.refRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nIncr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setGlobDamp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setMaxRFriend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setTanTheta1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setAngle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setRollingDamp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setDampingRatio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setpInt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setCurrentLoadRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.tabSystem.SuspendLayout()
        Me.gbThinLayer.SuspendLayout()
        CType(Me.setHThinLayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setRotDamp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setOutputFreq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setFreqSaveRST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ctrlNumProcessor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ctrlMaxNEle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setTanTheta2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabView.SuspendLayout()
        CType(Me.setPenWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCanvas2File.SuspendLayout()
        Me.grpRotationMode.SuspendLayout()
        Me.grpHist.SuspendLayout()
        CType(Me.setNBinFR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setNBinOri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setNBinForce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setNBinNorm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpForceViewMode.SuspendLayout()
        CType(Me.setFactorSlidContrast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cstForceThickLeng, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cstForceThickContrast, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabLoad.SuspendLayout()
        Me.grpLoadModeControl.SuspendLayout()
        Me.grpBatchLoading.SuspendLayout()
        CType(Me.setCyclicDisplacement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setQLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.setXGravity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setGX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setGY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setYGravity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDisplacementLoadControl.SuspendLayout()
        CType(Me.setSteptoGo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setTargetLoadRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConfiningControl.SuspendLayout()
        CType(Me.setpxy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setPy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setPx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.incWall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEdit.SuspendLayout()
        Me.grpDiscMask.SuspendLayout()
        Me.grpCrop.SuspendLayout()
        Me.grpMaskShape.SuspendLayout()
        Me.grpEditOption.SuspendLayout()
        CType(Me.setAngRotate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setCAC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPost.SuspendLayout()
        Me.grpGridDeform.SuspendLayout()
        CType(Me.setDyeDark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setIntvlDye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setAngDye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setNumGD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupPtclMotion.SuspendLayout()
        Me.gbShowSlideTrace.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.setRefOri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.setRelaMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setRelaMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.containerContourRange.SuspendLayout()
        CType(Me.lowContourRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.upContourRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackStateB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.setStepSparse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupPostMode.SuspendLayout()
        Me.tabStrain.SuspendLayout()
        Me.gbShowStnDrct.SuspendLayout()
        Me.gbStnMode.SuspendLayout()
        Me.gbCellMode.SuspendLayout()
        CType(Me.setValLegend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setStnContrast, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPickStnSign.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.setAngN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setNumCell, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setRdStnCell, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCellFabric.SuspendLayout()
        Me.gbStressRotation.SuspendLayout()
        CType(Me.setStressRotationRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setPStressAng, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setStressIncRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setMaxStep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setCellOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabLink.SuspendLayout()
        CType(Me.setLinkDampingRatio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAnalysis.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        CType(Me.setCNUpB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setCNLowB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setCoordNumMatrixSampIntv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setCoordNumMatrixBoxSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.canvasContainer.SuspendLayout()
        CType(Me.mainTransparency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.canvas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackPost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setZoomFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timerTest
        '
        Me.timerTest.Interval = 10000
        '
        'tInc
        '
        Me.tInc.BackColor = System.Drawing.Color.DimGray
        Me.tInc.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.tInc.ForeColor = System.Drawing.Color.White
        Me.tInc.Location = New System.Drawing.Point(181, 52)
        Me.tInc.Margin = New System.Windows.Forms.Padding(4)
        Me.tInc.Name = "tInc"
        Me.tInc.Size = New System.Drawing.Size(90, 20)
        Me.tInc.TabIndex = 1
        Me.tInc.Value = New Decimal(New Integer() {14, 0, 0, 0})
        '
        'refRate
        '
        Me.refRate.BackColor = System.Drawing.Color.DimGray
        Me.refRate.DecimalPlaces = 1
        Me.refRate.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.refRate.ForeColor = System.Drawing.Color.White
        Me.refRate.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.refRate.Location = New System.Drawing.Point(181, 122)
        Me.refRate.Margin = New System.Windows.Forms.Padding(4)
        Me.refRate.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.refRate.Name = "refRate"
        Me.refRate.Size = New System.Drawing.Size(90, 20)
        Me.refRate.TabIndex = 1
        Me.refRate.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(52, 54)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "TimeInc"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(86, 124)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "RefreshRate"
        '
        'nIncr
        '
        Me.nIncr.BackColor = System.Drawing.Color.DimGray
        Me.nIncr.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.nIncr.ForeColor = System.Drawing.Color.White
        Me.nIncr.Location = New System.Drawing.Point(181, 87)
        Me.nIncr.Margin = New System.Windows.Forms.Padding(4)
        Me.nIncr.Name = "nIncr"
        Me.nIncr.Size = New System.Drawing.Size(90, 20)
        Me.nIncr.TabIndex = 8
        Me.nIncr.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(59, 89)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 14)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Num. Inc per Call"
        '
        'nIncDisp
        '
        Me.nIncDisp.AutoSize = True
        Me.nIncDisp.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.nIncDisp.ForeColor = System.Drawing.Color.White
        Me.nIncDisp.Location = New System.Drawing.Point(165, 115)
        Me.nIncDisp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nIncDisp.Name = "nIncDisp"
        Me.nIncDisp.Size = New System.Drawing.Size(0, 14)
        Me.nIncDisp.TabIndex = 7
        '
        'LbStiff
        '
        Me.LbStiff.AutoSize = True
        Me.LbStiff.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.LbStiff.ForeColor = System.Drawing.Color.White
        Me.LbStiff.Location = New System.Drawing.Point(112, 159)
        Me.LbStiff.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbStiff.Name = "LbStiff"
        Me.LbStiff.Size = New System.Drawing.Size(51, 14)
        Me.LbStiff.TabIndex = 3
        Me.LbStiff.Text = "Stiffness"
        '
        'setE
        '
        Me.setE.BackColor = System.Drawing.Color.DimGray
        Me.setE.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.setE.ForeColor = System.Drawing.Color.White
        Me.setE.Location = New System.Drawing.Point(181, 157)
        Me.setE.Margin = New System.Windows.Forms.Padding(4)
        Me.setE.Name = "setE"
        Me.setE.Size = New System.Drawing.Size(90, 20)
        Me.setE.TabIndex = 10
        Me.setE.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'MovDown
        '
        Me.MovDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.MovDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MovDown.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.MovDown.Location = New System.Drawing.Point(54, 72)
        Me.MovDown.Margin = New System.Windows.Forms.Padding(4)
        Me.MovDown.Name = "MovDown"
        Me.MovDown.Size = New System.Drawing.Size(51, 22)
        Me.MovDown.TabIndex = 13
        Me.MovDown.Text = "Down"
        Me.MovDown.UseVisualStyleBackColor = True
        '
        'MovUp
        '
        Me.MovUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.MovUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MovUp.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.MovUp.Location = New System.Drawing.Point(55, 22)
        Me.MovUp.Margin = New System.Windows.Forms.Padding(4)
        Me.MovUp.Name = "MovUp"
        Me.MovUp.Size = New System.Drawing.Size(50, 22)
        Me.MovUp.TabIndex = 14
        Me.MovUp.Text = "Up"
        Me.MovUp.UseVisualStyleBackColor = True
        '
        'MovRight
        '
        Me.MovRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.MovRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MovRight.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.MovRight.Location = New System.Drawing.Point(112, 48)
        Me.MovRight.Margin = New System.Windows.Forms.Padding(4)
        Me.MovRight.Name = "MovRight"
        Me.MovRight.Size = New System.Drawing.Size(40, 22)
        Me.MovRight.TabIndex = 15
        Me.MovRight.Text = "Right"
        Me.MovRight.UseVisualStyleBackColor = True
        '
        'MovLeft
        '
        Me.MovLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.MovLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MovLeft.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.MovLeft.Location = New System.Drawing.Point(7, 47)
        Me.MovLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.MovLeft.Name = "MovLeft"
        Me.MovLeft.Size = New System.Drawing.Size(40, 22)
        Me.MovLeft.TabIndex = 16
        Me.MovLeft.Text = "Left"
        Me.MovLeft.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 14)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Gravity Center"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(71, 194)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 14)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Glob. Damping"
        '
        'maxRFriend_label
        '
        Me.maxRFriend_label.AutoSize = True
        Me.maxRFriend_label.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.maxRFriend_label.ForeColor = System.Drawing.Color.White
        Me.maxRFriend_label.Location = New System.Drawing.Point(77, 339)
        Me.maxRFriend_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.maxRFriend_label.Name = "maxRFriend_label"
        Me.maxRFriend_label.Size = New System.Drawing.Size(73, 14)
        Me.maxRFriend_label.TabIndex = 21
        Me.maxRFriend_label.Text = "Friend Radius"
        '
        'setGlobDamp
        '
        Me.setGlobDamp.BackColor = System.Drawing.Color.DimGray
        Me.setGlobDamp.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.setGlobDamp.ForeColor = System.Drawing.Color.White
        Me.setGlobDamp.Location = New System.Drawing.Point(181, 192)
        Me.setGlobDamp.Margin = New System.Windows.Forms.Padding(4)
        Me.setGlobDamp.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.setGlobDamp.Name = "setGlobDamp"
        Me.setGlobDamp.Size = New System.Drawing.Size(90, 20)
        Me.setGlobDamp.TabIndex = 23
        Me.setGlobDamp.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'setMaxRFriend
        '
        Me.setMaxRFriend.BackColor = System.Drawing.Color.DimGray
        Me.setMaxRFriend.DecimalPlaces = 3
        Me.setMaxRFriend.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.setMaxRFriend.ForeColor = System.Drawing.Color.White
        Me.setMaxRFriend.Location = New System.Drawing.Point(181, 337)
        Me.setMaxRFriend.Margin = New System.Windows.Forms.Padding(4)
        Me.setMaxRFriend.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.setMaxRFriend.Name = "setMaxRFriend"
        Me.setMaxRFriend.Size = New System.Drawing.Size(90, 20)
        Me.setMaxRFriend.TabIndex = 25
        Me.setMaxRFriend.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'lb_set_PPFricAng
        '
        Me.lb_set_PPFricAng.AutoSize = True
        Me.lb_set_PPFricAng.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.lb_set_PPFricAng.ForeColor = System.Drawing.Color.White
        Me.lb_set_PPFricAng.Location = New System.Drawing.Point(52, 374)
        Me.lb_set_PPFricAng.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_set_PPFricAng.Name = "lb_set_PPFricAng"
        Me.lb_set_PPFricAng.Size = New System.Drawing.Size(92, 14)
        Me.lb_set_PPFricAng.TabIndex = 38
        Me.lb_set_PPFricAng.Text = "Fric. Ang. Par-Par"
        '
        'setTanTheta1
        '
        Me.setTanTheta1.BackColor = System.Drawing.Color.DimGray
        Me.setTanTheta1.DecimalPlaces = 1
        Me.setTanTheta1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.setTanTheta1.ForeColor = System.Drawing.Color.White
        Me.setTanTheta1.Location = New System.Drawing.Point(181, 372)
        Me.setTanTheta1.Margin = New System.Windows.Forms.Padding(4)
        Me.setTanTheta1.Maximum = New Decimal(New Integer() {89, 0, 0, 0})
        Me.setTanTheta1.Name = "setTanTheta1"
        Me.setTanTheta1.Size = New System.Drawing.Size(90, 20)
        Me.setTanTheta1.TabIndex = 39
        Me.setTanTheta1.Value = New Decimal(New Integer() {40, 0, 0, 0})
        '
        'btnCW
        '
        Me.btnCW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnCW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCW.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.btnCW.Location = New System.Drawing.Point(161, 22)
        Me.btnCW.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCW.Name = "btnCW"
        Me.btnCW.Size = New System.Drawing.Size(50, 22)
        Me.btnCW.TabIndex = 40
        Me.btnCW.Text = "CW"
        Me.btnCW.UseVisualStyleBackColor = True
        '
        'btnCCW
        '
        Me.btnCCW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnCCW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCCW.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.btnCCW.Location = New System.Drawing.Point(161, 72)
        Me.btnCCW.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCCW.Name = "btnCCW"
        Me.btnCCW.Size = New System.Drawing.Size(50, 22)
        Me.btnCCW.TabIndex = 40
        Me.btnCCW.Text = "CCW"
        Me.btnCCW.UseVisualStyleBackColor = True
        '
        'setAngle
        '
        Me.setAngle.BackColor = System.Drawing.Color.DimGray
        Me.setAngle.ForeColor = System.Drawing.Color.White
        Me.setAngle.Location = New System.Drawing.Point(161, 49)
        Me.setAngle.Margin = New System.Windows.Forms.Padding(4)
        Me.setAngle.Name = "setAngle"
        Me.setAngle.Size = New System.Drawing.Size(50, 20)
        Me.setAngle.TabIndex = 41
        Me.setAngle.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'chsWall
        '
        Me.chsWall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.chsWall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chsWall.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.chsWall.Location = New System.Drawing.Point(218, 17)
        Me.chsWall.Margin = New System.Windows.Forms.Padding(4)
        Me.chsWall.Name = "chsWall"
        Me.chsWall.Size = New System.Drawing.Size(50, 40)
        Me.chsWall.TabIndex = 42
        Me.chsWall.Text = "Next Wall"
        Me.chsWall.UseVisualStyleBackColor = True
        '
        'setRollingDamp
        '
        Me.setRollingDamp.BackColor = System.Drawing.Color.DimGray
        Me.setRollingDamp.DecimalPlaces = 3
        Me.setRollingDamp.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.setRollingDamp.ForeColor = System.Drawing.Color.White
        Me.setRollingDamp.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.setRollingDamp.Location = New System.Drawing.Point(181, 267)
        Me.setRollingDamp.Margin = New System.Windows.Forms.Padding(4)
        Me.setRollingDamp.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.setRollingDamp.Name = "setRollingDamp"
        Me.setRollingDamp.Size = New System.Drawing.Size(90, 20)
        Me.setRollingDamp.TabIndex = 50
        Me.setRollingDamp.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'setDampingRatio
        '
        Me.setDampingRatio.BackColor = System.Drawing.Color.DimGray
        Me.setDampingRatio.DecimalPlaces = 3
        Me.setDampingRatio.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.setDampingRatio.ForeColor = System.Drawing.Color.White
        Me.setDampingRatio.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.setDampingRatio.Location = New System.Drawing.Point(181, 302)
        Me.setDampingRatio.Margin = New System.Windows.Forms.Padding(4)
        Me.setDampingRatio.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.setDampingRatio.Minimum = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
        Me.setDampingRatio.Name = "setDampingRatio"
        Me.setDampingRatio.Size = New System.Drawing.Size(90, 20)
        Me.setDampingRatio.TabIndex = 50
        Me.setDampingRatio.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(21, 269)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 14)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Rolling Damping Coeff."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(73, 304)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 14)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "Damping Ratio"
        '
        'MenuStrip
        '
        Me.MenuStrip.Enabled = False
        Me.MenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip.Size = New System.Drawing.Size(1192, 24)
        Me.MenuStrip.TabIndex = 53
        Me.MenuStrip.Text = "MenuStrip1"
        Me.MenuStrip.Visible = False
        '
        'OpenSnapshot
        '
        Me.OpenSnapshot.FileName = "OpenFileDialog1"
        '
        'SaveSnapshot
        '
        Me.SaveSnapshot.Filter = "Data files (*.dat)|*.dat|All files (*.*)|*.*"
        '
        'btnOpenTest
        '
        Me.btnOpenTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOpenTest.BackColor = System.Drawing.Color.Maroon
        Me.btnOpenTest.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnOpenTest.FlatAppearance.BorderSize = 2
        Me.btnOpenTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.btnOpenTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenTest.Font = New System.Drawing.Font("Arial", 9.5!)
        Me.btnOpenTest.ForeColor = System.Drawing.Color.White
        Me.btnOpenTest.Location = New System.Drawing.Point(4, 787)
        Me.btnOpenTest.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOpenTest.Name = "btnOpenTest"
        Me.btnOpenTest.Size = New System.Drawing.Size(76, 30)
        Me.btnOpenTest.TabIndex = 55
        Me.btnOpenTest.Text = "Open File"
        Me.btnOpenTest.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(51, 19)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 14)
        Me.Label18.TabIndex = 57
        Me.Label18.Text = "Pressure X"
        '
        'setpInt
        '
        Me.setpInt.BackColor = System.Drawing.Color.DimGray
        Me.setpInt.DecimalPlaces = 7
        Me.setpInt.ForeColor = System.Drawing.Color.White
        Me.setpInt.Increment = New Decimal(New Integer() {1, 0, 0, 262144})
        Me.setpInt.Location = New System.Drawing.Point(161, 83)
        Me.setpInt.Margin = New System.Windows.Forms.Padding(4)
        Me.setpInt.Minimum = New Decimal(New Integer() {1, 0, 0, 458752})
        Me.setpInt.Name = "setpInt"
        Me.setpInt.Size = New System.Drawing.Size(93, 20)
        Me.setpInt.TabIndex = 60
        Me.setpInt.Value = New Decimal(New Integer() {1, 0, 0, 196608})
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(158, 67)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 14)
        Me.Label19.TabIndex = 61
        Me.Label19.Text = "p-Interval"
        '
        'btnZoomIn
        '
        Me.btnZoomIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZoomIn.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.btnZoomIn.ForeColor = System.Drawing.Color.White
        Me.btnZoomIn.Location = New System.Drawing.Point(1031, 781)
        Me.btnZoomIn.Margin = New System.Windows.Forms.Padding(4)
        Me.btnZoomIn.Name = "btnZoomIn"
        Me.btnZoomIn.Size = New System.Drawing.Size(50, 41)
        Me.btnZoomIn.TabIndex = 64
        Me.btnZoomIn.Text = "Zoom In"
        Me.btnZoomIn.UseVisualStyleBackColor = True
        '
        'btnZoomOut
        '
        Me.btnZoomOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZoomOut.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.btnZoomOut.ForeColor = System.Drawing.Color.White
        Me.btnZoomOut.Location = New System.Drawing.Point(1086, 781)
        Me.btnZoomOut.Margin = New System.Windows.Forms.Padding(4)
        Me.btnZoomOut.Name = "btnZoomOut"
        Me.btnZoomOut.Size = New System.Drawing.Size(50, 41)
        Me.btnZoomOut.TabIndex = 65
        Me.btnZoomOut.Text = "Zoom Out"
        Me.btnZoomOut.UseVisualStyleBackColor = True
        '
        'setCurrentLoadRate
        '
        Me.setCurrentLoadRate.BackColor = System.Drawing.Color.DimGray
        Me.setCurrentLoadRate.DecimalPlaces = 7
        Me.setCurrentLoadRate.ForeColor = System.Drawing.Color.White
        Me.setCurrentLoadRate.Increment = New Decimal(New Integer() {1, 0, 0, 327680})
        Me.setCurrentLoadRate.Location = New System.Drawing.Point(97, 25)
        Me.setCurrentLoadRate.Margin = New System.Windows.Forms.Padding(4)
        Me.setCurrentLoadRate.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.setCurrentLoadRate.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.setCurrentLoadRate.Name = "setCurrentLoadRate"
        Me.setCurrentLoadRate.Size = New System.Drawing.Size(103, 20)
        Me.setCurrentLoadRate.TabIndex = 68
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(2, 27)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(68, 14)
        Me.Label22.TabIndex = 69
        Me.Label22.Text = "Current Rate"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(51, 66)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(62, 14)
        Me.Label23.TabIndex = 70
        Me.Label23.Text = "Pressure Y"
        '
        'timeSaveFile
        '
        Me.timeSaveFile.Enabled = True
        Me.timeSaveFile.Interval = 300000
        '
        'checkFlagDebug
        '
        Me.checkFlagDebug.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.checkFlagDebug.AutoSize = True
        Me.checkFlagDebug.Enabled = False
        Me.checkFlagDebug.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.checkFlagDebug.ForeColor = System.Drawing.Color.White
        Me.checkFlagDebug.Location = New System.Drawing.Point(194, 549)
        Me.checkFlagDebug.Margin = New System.Windows.Forms.Padding(4)
        Me.checkFlagDebug.Name = "checkFlagDebug"
        Me.checkFlagDebug.Size = New System.Drawing.Size(56, 18)
        Me.checkFlagDebug.TabIndex = 72
        Me.checkFlagDebug.Text = "debug"
        Me.checkFlagDebug.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(8, 54)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 14)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "gX,  gY"
        '
        'btGlue
        '
        Me.btGlue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btGlue.BackColor = System.Drawing.Color.Maroon
        Me.btGlue.Enabled = False
        Me.btGlue.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btGlue.FlatAppearance.BorderSize = 2
        Me.btGlue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.btGlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGlue.Font = New System.Drawing.Font("Arial", 9.5!)
        Me.btGlue.ForeColor = System.Drawing.Color.White
        Me.btGlue.Location = New System.Drawing.Point(232, 787)
        Me.btGlue.Margin = New System.Windows.Forms.Padding(4)
        Me.btGlue.Name = "btGlue"
        Me.btGlue.Size = New System.Drawing.Size(74, 30)
        Me.btGlue.TabIndex = 75
        Me.btGlue.Text = "Cohesion"
        Me.btGlue.UseVisualStyleBackColor = False
        '
        'btnPause
        '
        Me.btnPause.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPause.BackColor = System.Drawing.Color.Maroon
        Me.btnPause.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPause.FlatAppearance.BorderSize = 2
        Me.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPause.Font = New System.Drawing.Font("Arial", 9.5!)
        Me.btnPause.ForeColor = System.Drawing.Color.White
        Me.btnPause.Location = New System.Drawing.Point(82, 787)
        Me.btnPause.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(76, 30)
        Me.btnPause.TabIndex = 76
        Me.btnPause.Text = "Start"
        Me.btnPause.UseVisualStyleBackColor = False
        '
        'tabMain
        '
        Me.tabMain.AllowDrop = True
        Me.tabMain.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tabMain.Controls.Add(Me.tabSystem)
        Me.tabMain.Controls.Add(Me.tabView)
        Me.tabMain.Controls.Add(Me.tabLoad)
        Me.tabMain.Controls.Add(Me.tabEdit)
        Me.tabMain.Controls.Add(Me.tabPost)
        Me.tabMain.Controls.Add(Me.tabStrain)
        Me.tabMain.Controls.Add(Me.tabCellFabric)
        Me.tabMain.Controls.Add(Me.tabLink)
        Me.tabMain.Controls.Add(Me.tabAnalysis)
        Me.tabMain.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.tabMain.ItemSize = New System.Drawing.Size(100, 24)
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Multiline = True
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(309, 775)
        Me.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabMain.TabIndex = 77
        '
        'tabSystem
        '
        Me.tabSystem.AutoScroll = True
        Me.tabSystem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tabSystem.Controls.Add(Me.gbThinLayer)
        Me.tabSystem.Controls.Add(Me.setRotDamp)
        Me.tabSystem.Controls.Add(Me.Label9)
        Me.tabSystem.Controls.Add(Me.setOutputFreq)
        Me.tabSystem.Controls.Add(Me.btnOutput)
        Me.tabSystem.Controls.Add(Me.chkMonitorSystemVariable)
        Me.tabSystem.Controls.Add(Me.chkSave)
        Me.tabSystem.Controls.Add(Me.setFreqSaveRST)
        Me.tabSystem.Controls.Add(Me.lbCritDt)
        Me.tabSystem.Controls.Add(Me.chkMassNorm)
        Me.tabSystem.Controls.Add(Me.Label27)
        Me.tabSystem.Controls.Add(Me.Label3)
        Me.tabSystem.Controls.Add(Me.chkAutoMaxRFriend)
        Me.tabSystem.Controls.Add(Me.Label24)
        Me.tabSystem.Controls.Add(Me.ctrlNumProcessor)
        Me.tabSystem.Controls.Add(Me.ctrlMaxNEle)
        Me.tabSystem.Controls.Add(Me.Label5)
        Me.tabSystem.Controls.Add(Me.tInc)
        Me.tabSystem.Controls.Add(Me.refRate)
        Me.tabSystem.Controls.Add(Me.Label4)
        Me.tabSystem.Controls.Add(Me.LbStiff)
        Me.tabSystem.Controls.Add(Me.nIncr)
        Me.tabSystem.Controls.Add(Me.checkFlagDebug)
        Me.tabSystem.Controls.Add(Me.nIncDisp)
        Me.tabSystem.Controls.Add(Me.setE)
        Me.tabSystem.Controls.Add(Me.Label26)
        Me.tabSystem.Controls.Add(Me.Label2)
        Me.tabSystem.Controls.Add(Me.setGlobDamp)
        Me.tabSystem.Controls.Add(Me.maxRFriend_label)
        Me.tabSystem.Controls.Add(Me.setMaxRFriend)
        Me.tabSystem.Controls.Add(Me.Label58)
        Me.tabSystem.Controls.Add(Me.lb_set_PPFricAng)
        Me.tabSystem.Controls.Add(Me.setTanTheta2)
        Me.tabSystem.Controls.Add(Me.setTanTheta1)
        Me.tabSystem.Controls.Add(Me.setRollingDamp)
        Me.tabSystem.Controls.Add(Me.setDampingRatio)
        Me.tabSystem.Controls.Add(Me.Label7)
        Me.tabSystem.Controls.Add(Me.Label17)
        Me.tabSystem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tabSystem.Location = New System.Drawing.Point(4, 82)
        Me.tabSystem.Name = "tabSystem"
        Me.tabSystem.Size = New System.Drawing.Size(301, 689)
        Me.tabSystem.TabIndex = 2
        Me.tabSystem.Text = "System"
        Me.tabSystem.UseVisualStyleBackColor = True
        '
        'gbThinLayer
        '
        Me.gbThinLayer.Controls.Add(Me.chkLayerNoRotation)
        Me.gbThinLayer.Controls.Add(Me.chkLayerLowFric)
        Me.gbThinLayer.Controls.Add(Me.setHThinLayer)
        Me.gbThinLayer.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.gbThinLayer.ForeColor = System.Drawing.Color.White
        Me.gbThinLayer.Location = New System.Drawing.Point(24, 474)
        Me.gbThinLayer.Name = "gbThinLayer"
        Me.gbThinLayer.Size = New System.Drawing.Size(247, 67)
        Me.gbThinLayer.TabIndex = 86
        Me.gbThinLayer.TabStop = False
        '
        'chkLayerNoRotation
        '
        Me.chkLayerNoRotation.AutoSize = True
        Me.chkLayerNoRotation.Location = New System.Drawing.Point(117, 40)
        Me.chkLayerNoRotation.Name = "chkLayerNoRotation"
        Me.chkLayerNoRotation.Size = New System.Drawing.Size(81, 18)
        Me.chkLayerNoRotation.TabIndex = 2
        Me.chkLayerNoRotation.Text = "No Rotation"
        Me.chkLayerNoRotation.UseVisualStyleBackColor = True
        '
        'chkLayerLowFric
        '
        Me.chkLayerLowFric.AutoSize = True
        Me.chkLayerLowFric.Location = New System.Drawing.Point(117, 14)
        Me.chkLayerLowFric.Name = "chkLayerLowFric"
        Me.chkLayerLowFric.Size = New System.Drawing.Size(86, 18)
        Me.chkLayerLowFric.TabIndex = 1
        Me.chkLayerLowFric.Text = "Low Friction"
        Me.chkLayerLowFric.UseVisualStyleBackColor = True
        '
        'setHThinLayer
        '
        Me.setHThinLayer.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.setHThinLayer.DecimalPlaces = 5
        Me.setHThinLayer.ForeColor = System.Drawing.Color.White
        Me.setHThinLayer.Location = New System.Drawing.Point(7, 12)
        Me.setHThinLayer.Name = "setHThinLayer"
        Me.setHThinLayer.Size = New System.Drawing.Size(94, 20)
        Me.setHThinLayer.TabIndex = 0
        '
        'setRotDamp
        '
        Me.setRotDamp.BackColor = System.Drawing.Color.DimGray
        Me.setRotDamp.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.setRotDamp.ForeColor = System.Drawing.Color.White
        Me.setRotDamp.Location = New System.Drawing.Point(180, 227)
        Me.setRotDamp.Name = "setRotDamp"
        Me.setRotDamp.Size = New System.Drawing.Size(91, 20)
        Me.setRotDamp.TabIndex = 85
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(177, 593)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 14)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "Every X steps"
        '
        'setOutputFreq
        '
        Me.setOutputFreq.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.setOutputFreq.BackColor = System.Drawing.Color.DimGray
        Me.setOutputFreq.Enabled = False
        Me.setOutputFreq.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.setOutputFreq.ForeColor = System.Drawing.Color.White
        Me.setOutputFreq.Location = New System.Drawing.Point(180, 612)
        Me.setOutputFreq.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.setOutputFreq.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.setOutputFreq.Name = "setOutputFreq"
        Me.setOutputFreq.Size = New System.Drawing.Size(91, 20)
        Me.setOutputFreq.TabIndex = 83
        Me.setOutputFreq.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'btnOutput
        '
        Me.btnOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOutput.BackColor = System.Drawing.Color.DimGray
        Me.btnOutput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOutput.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.btnOutput.ForeColor = System.Drawing.Color.White
        Me.btnOutput.Location = New System.Drawing.Point(14, 609)
        Me.btnOutput.Name = "btnOutput"
        Me.btnOutput.Size = New System.Drawing.Size(119, 26)
        Me.btnOutput.TabIndex = 82
        Me.btnOutput.Text = "Open Output File"
        Me.btnOutput.UseVisualStyleBackColor = False
        '
        'chkMonitorSystemVariable
        '
        Me.chkMonitorSystemVariable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkMonitorSystemVariable.AutoSize = True
        Me.chkMonitorSystemVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkMonitorSystemVariable.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.chkMonitorSystemVariable.ForeColor = System.Drawing.Color.White
        Me.chkMonitorSystemVariable.Location = New System.Drawing.Point(17, 573)
        Me.chkMonitorSystemVariable.Name = "chkMonitorSystemVariable"
        Me.chkMonitorSystemVariable.Size = New System.Drawing.Size(145, 18)
        Me.chkMonitorSystemVariable.TabIndex = 81
        Me.chkMonitorSystemVariable.Text = "Monitor System Variables"
        Me.chkMonitorSystemVariable.UseVisualStyleBackColor = True
        '
        'chkSave
        '
        Me.chkSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkSave.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkSave.AutoSize = True
        Me.chkSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkSave.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue
        Me.chkSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkSave.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.chkSave.ForeColor = System.Drawing.Color.White
        Me.chkSave.Location = New System.Drawing.Point(14, 653)
        Me.chkSave.Name = "chkSave"
        Me.chkSave.Size = New System.Drawing.Size(93, 24)
        Me.chkSave.TabIndex = 80
        Me.chkSave.Text = "Save Simulation"
        Me.chkSave.UseVisualStyleBackColor = False
        '
        'setFreqSaveRST
        '
        Me.setFreqSaveRST.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.setFreqSaveRST.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.setFreqSaveRST.Enabled = False
        Me.setFreqSaveRST.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.setFreqSaveRST.ForeColor = System.Drawing.Color.White
        Me.setFreqSaveRST.Location = New System.Drawing.Point(180, 654)
        Me.setFreqSaveRST.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.setFreqSaveRST.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.setFreqSaveRST.Name = "setFreqSaveRST"
        Me.setFreqSaveRST.Size = New System.Drawing.Size(91, 20)
        Me.setFreqSaveRST.TabIndex = 78
        Me.setFreqSaveRST.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'lbCritDt
        '
        Me.lbCritDt.AutoSize = True
        Me.lbCritDt.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.lbCritDt.ForeColor = System.Drawing.Color.White
        Me.lbCritDt.Location = New System.Drawing.Point(118, 54)
        Me.lbCritDt.Name = "lbCritDt"
        Me.lbCritDt.Size = New System.Drawing.Size(43, 14)
        Me.lbCritDt.TabIndex = 3
        Me.lbCritDt.Text = "Crit Intv"
        '
        'chkMassNorm
        '
        Me.chkMassNorm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkMassNorm.AutoSize = True
        Me.chkMassNorm.Enabled = False
        Me.chkMassNorm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkMassNorm.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.chkMassNorm.ForeColor = System.Drawing.Color.White
        Me.chkMassNorm.Location = New System.Drawing.Point(17, 548)
        Me.chkMassNorm.Name = "chkMassNorm"
        Me.chkMassNorm.Size = New System.Drawing.Size(77, 18)
        Me.chkMassNorm.TabIndex = 76
        Me.chkMassNorm.Text = "Mass Norm"
        Me.chkMassNorm.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(112, 19)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(48, 14)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "maxNEle"
        '
        'chkAutoMaxRFriend
        '
        Me.chkAutoMaxRFriend.AutoSize = True
        Me.chkAutoMaxRFriend.Checked = True
        Me.chkAutoMaxRFriend.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoMaxRFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkAutoMaxRFriend.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.chkAutoMaxRFriend.ForeColor = System.Drawing.Color.White
        Me.chkAutoMaxRFriend.Location = New System.Drawing.Point(14, 335)
        Me.chkAutoMaxRFriend.Name = "chkAutoMaxRFriend"
        Me.chkAutoMaxRFriend.Size = New System.Drawing.Size(46, 18)
        Me.chkAutoMaxRFriend.TabIndex = 75
        Me.chkAutoMaxRFriend.Text = "Auto"
        Me.chkAutoMaxRFriend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkAutoMaxRFriend.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(66, 444)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(84, 14)
        Me.Label24.TabIndex = 74
        Me.Label24.Text = "Num. Processor"
        '
        'ctrlNumProcessor
        '
        Me.ctrlNumProcessor.BackColor = System.Drawing.Color.DimGray
        Me.ctrlNumProcessor.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.ctrlNumProcessor.ForeColor = System.Drawing.Color.White
        Me.ctrlNumProcessor.Location = New System.Drawing.Point(181, 442)
        Me.ctrlNumProcessor.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ctrlNumProcessor.Name = "ctrlNumProcessor"
        Me.ctrlNumProcessor.Size = New System.Drawing.Size(90, 20)
        Me.ctrlNumProcessor.TabIndex = 73
        Me.ctrlNumProcessor.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ctrlMaxNEle
        '
        Me.ctrlMaxNEle.BackColor = System.Drawing.Color.DimGray
        Me.ctrlMaxNEle.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.ctrlMaxNEle.ForeColor = System.Drawing.Color.White
        Me.ctrlMaxNEle.Increment = New Decimal(New Integer() {500, 0, 0, 0})
        Me.ctrlMaxNEle.Location = New System.Drawing.Point(181, 17)
        Me.ctrlMaxNEle.Margin = New System.Windows.Forms.Padding(4)
        Me.ctrlMaxNEle.Maximum = New Decimal(New Integer() {600000, 0, 0, 0})
        Me.ctrlMaxNEle.Name = "ctrlMaxNEle"
        Me.ctrlMaxNEle.Size = New System.Drawing.Size(90, 20)
        Me.ctrlMaxNEle.TabIndex = 1
        Me.ctrlMaxNEle.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(53, 227)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(90, 14)
        Me.Label26.TabIndex = 19
        Me.Label26.Text = "Rotation Damping"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Label58.ForeColor = System.Drawing.Color.White
        Me.Label58.Location = New System.Drawing.Point(47, 409)
        Me.Label58.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(96, 14)
        Me.Label58.TabIndex = 38
        Me.Label58.Text = "Fric. Ang. Par-Wall"
        '
        'setTanTheta2
        '
        Me.setTanTheta2.BackColor = System.Drawing.Color.DimGray
        Me.setTanTheta2.DecimalPlaces = 1
        Me.setTanTheta2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.setTanTheta2.ForeColor = System.Drawing.Color.White
        Me.setTanTheta2.Location = New System.Drawing.Point(181, 407)
        Me.setTanTheta2.Margin = New System.Windows.Forms.Padding(4)
        Me.setTanTheta2.Maximum = New Decimal(New Integer() {89, 0, 0, 0})
        Me.setTanTheta2.Name = "setTanTheta2"
        Me.setTanTheta2.Size = New System.Drawing.Size(90, 20)
        Me.setTanTheta2.TabIndex = 39
        Me.setTanTheta2.Value = New Decimal(New Integer() {40, 0, 0, 0})
        '
        'tabView
        '
        Me.tabView.AllowDrop = True
        Me.tabView.AutoScroll = True
        Me.tabView.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tabView.Controls.Add(Me.Label25)
        Me.tabView.Controls.Add(Me.setPenWidth)
        Me.tabView.Controls.Add(Me.gbCanvas2File)
        Me.tabView.Controls.Add(Me.chkShowGrid)
        Me.tabView.Controls.Add(Me.grpRotationMode)
        Me.tabView.Controls.Add(Me.lbVelFactor)
        Me.tabView.Controls.Add(Me.btnCanvasColor)
        Me.tabView.Controls.Add(Me.grpHist)
        Me.tabView.Controls.Add(Me.chkMeasureMode)
        Me.tabView.Controls.Add(Me.GroupBox2)
        Me.tabView.Controls.Add(Me.GroupBox1)
        Me.tabView.Controls.Add(Me.chkShowCohesion)
        Me.tabView.Controls.Add(Me.chkShowCoord)
        Me.tabView.Controls.Add(Me.flagRotation)
        Me.tabView.Controls.Add(Me.btVelMinus)
        Me.tabView.Controls.Add(Me.checkShowVel)
        Me.tabView.Controls.Add(Me.flagShowP)
        Me.tabView.Controls.Add(Me.btnHalfPScale)
        Me.tabView.Controls.Add(Me.btnDoublePScale)
        Me.tabView.Controls.Add(Me.btVelPlus)
        Me.tabView.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.tabView.ForeColor = System.Drawing.Color.White
        Me.tabView.Location = New System.Drawing.Point(4, 82)
        Me.tabView.Name = "tabView"
        Me.tabView.Padding = New System.Windows.Forms.Padding(3)
        Me.tabView.Size = New System.Drawing.Size(301, 689)
        Me.tabView.TabIndex = 0
        Me.tabView.Text = " View"
        Me.tabView.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(100, 610)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(55, 14)
        Me.Label25.TabIndex = 112
        Me.Label25.Text = "Pen Width"
        '
        'setPenWidth
        '
        Me.setPenWidth.DecimalPlaces = 1
        Me.setPenWidth.Location = New System.Drawing.Point(13, 607)
        Me.setPenWidth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.setPenWidth.Name = "setPenWidth"
        Me.setPenWidth.Size = New System.Drawing.Size(80, 20)
        Me.setPenWidth.TabIndex = 111
        Me.setPenWidth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'gbCanvas2File
        '
        Me.gbCanvas2File.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbCanvas2File.Controls.Add(Me.btnSaveMovie)
        Me.gbCanvas2File.Controls.Add(Me.rbExpAll)
        Me.gbCanvas2File.Controls.Add(Me.rbExpVisible)
        Me.gbCanvas2File.Controls.Add(Me.btnCanvas2File)
        Me.gbCanvas2File.ForeColor = System.Drawing.Color.White
        Me.gbCanvas2File.Location = New System.Drawing.Point(114, 621)
        Me.gbCanvas2File.Name = "gbCanvas2File"
        Me.gbCanvas2File.Size = New System.Drawing.Size(181, 65)
        Me.gbCanvas2File.TabIndex = 110
        Me.gbCanvas2File.TabStop = False
        Me.gbCanvas2File.Text = "Export Image"
        '
        'btnSaveMovie
        '
        Me.btnSaveMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveMovie.Location = New System.Drawing.Point(61, 20)
        Me.btnSaveMovie.Name = "btnSaveMovie"
        Me.btnSaveMovie.Size = New System.Drawing.Size(42, 39)
        Me.btnSaveMovie.TabIndex = 112
        Me.btnSaveMovie.Text = "Avi"
        Me.btnSaveMovie.UseVisualStyleBackColor = True
        '
        'rbExpAll
        '
        Me.rbExpAll.AutoSize = True
        Me.rbExpAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.rbExpAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbExpAll.Location = New System.Drawing.Point(110, 39)
        Me.rbExpAll.Name = "rbExpAll"
        Me.rbExpAll.Size = New System.Drawing.Size(36, 18)
        Me.rbExpAll.TabIndex = 111
        Me.rbExpAll.Text = "All"
        Me.rbExpAll.UseVisualStyleBackColor = True
        '
        'rbExpVisible
        '
        Me.rbExpVisible.AutoSize = True
        Me.rbExpVisible.Checked = True
        Me.rbExpVisible.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.rbExpVisible.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbExpVisible.Location = New System.Drawing.Point(110, 18)
        Me.rbExpVisible.Name = "rbExpVisible"
        Me.rbExpVisible.Size = New System.Drawing.Size(56, 18)
        Me.rbExpVisible.TabIndex = 110
        Me.rbExpVisible.TabStop = True
        Me.rbExpVisible.Text = "Visible"
        Me.rbExpVisible.UseVisualStyleBackColor = True
        '
        'btnCanvas2File
        '
        Me.btnCanvas2File.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnCanvas2File.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCanvas2File.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.btnCanvas2File.Location = New System.Drawing.Point(9, 20)
        Me.btnCanvas2File.Name = "btnCanvas2File"
        Me.btnCanvas2File.Size = New System.Drawing.Size(46, 39)
        Me.btnCanvas2File.TabIndex = 109
        Me.btnCanvas2File.Text = "Img"
        Me.btnCanvas2File.UseVisualStyleBackColor = True
        '
        'chkShowGrid
        '
        Me.chkShowGrid.AutoSize = True
        Me.chkShowGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowGrid.Location = New System.Drawing.Point(13, 580)
        Me.chkShowGrid.Name = "chkShowGrid"
        Me.chkShowGrid.Size = New System.Drawing.Size(75, 18)
        Me.chkShowGrid.TabIndex = 108
        Me.chkShowGrid.Text = "Show Grid"
        Me.chkShowGrid.UseVisualStyleBackColor = True
        '
        'grpRotationMode
        '
        Me.grpRotationMode.Controls.Add(Me.rbRotationMode2)
        Me.grpRotationMode.Controls.Add(Me.rbRotationMode1)
        Me.grpRotationMode.Location = New System.Drawing.Point(150, 430)
        Me.grpRotationMode.Name = "grpRotationMode"
        Me.grpRotationMode.Size = New System.Drawing.Size(142, 32)
        Me.grpRotationMode.TabIndex = 103
        Me.grpRotationMode.TabStop = False
        '
        'rbRotationMode2
        '
        Me.rbRotationMode2.AutoSize = True
        Me.rbRotationMode2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbRotationMode2.Location = New System.Drawing.Point(73, 9)
        Me.rbRotationMode2.Name = "rbRotationMode2"
        Me.rbRotationMode2.Size = New System.Drawing.Size(59, 18)
        Me.rbRotationMode2.TabIndex = 1
        Me.rbRotationMode2.TabStop = True
        Me.rbRotationMode2.Text = "Mode 2"
        Me.rbRotationMode2.UseVisualStyleBackColor = True
        '
        'rbRotationMode1
        '
        Me.rbRotationMode1.AutoSize = True
        Me.rbRotationMode1.Checked = True
        Me.rbRotationMode1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbRotationMode1.Location = New System.Drawing.Point(6, 9)
        Me.rbRotationMode1.Name = "rbRotationMode1"
        Me.rbRotationMode1.Size = New System.Drawing.Size(59, 18)
        Me.rbRotationMode1.TabIndex = 0
        Me.rbRotationMode1.TabStop = True
        Me.rbRotationMode1.Text = "Mode 1"
        Me.rbRotationMode1.UseVisualStyleBackColor = True
        '
        'lbVelFactor
        '
        Me.lbVelFactor.AutoSize = True
        Me.lbVelFactor.Location = New System.Drawing.Point(225, 470)
        Me.lbVelFactor.Name = "lbVelFactor"
        Me.lbVelFactor.Size = New System.Drawing.Size(52, 14)
        Me.lbVelFactor.TabIndex = 107
        Me.lbVelFactor.Text = "velFactor"
        '
        'btnCanvasColor
        '
        Me.btnCanvasColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCanvasColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnCanvasColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCanvasColor.Location = New System.Drawing.Point(12, 644)
        Me.btnCanvasColor.Name = "btnCanvasColor"
        Me.btnCanvasColor.Size = New System.Drawing.Size(80, 31)
        Me.btnCanvasColor.TabIndex = 106
        Me.btnCanvasColor.Text = "Canvas Color"
        Me.btnCanvasColor.UseVisualStyleBackColor = True
        '
        'grpHist
        '
        Me.grpHist.Controls.Add(Me.chkExportCon)
        Me.grpHist.Controls.Add(Me.modeHist)
        Me.grpHist.Controls.Add(Me.Label35)
        Me.grpHist.Controls.Add(Me.setNBinFR)
        Me.grpHist.Controls.Add(Me.Label38)
        Me.grpHist.Controls.Add(Me.setNBinOri)
        Me.grpHist.Controls.Add(Me.Label36)
        Me.grpHist.Controls.Add(Me.setNBinForce)
        Me.grpHist.Controls.Add(Me.Label37)
        Me.grpHist.Controls.Add(Me.setNBinNorm)
        Me.grpHist.ForeColor = System.Drawing.Color.White
        Me.grpHist.Location = New System.Drawing.Point(6, 310)
        Me.grpHist.Name = "grpHist"
        Me.grpHist.Size = New System.Drawing.Size(292, 116)
        Me.grpHist.TabIndex = 105
        Me.grpHist.TabStop = False
        Me.grpHist.Text = "Rose Charts"
        '
        'chkExportCon
        '
        Me.chkExportCon.AutoSize = True
        Me.chkExportCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkExportCon.Location = New System.Drawing.Point(154, 15)
        Me.chkExportCon.Name = "chkExportCon"
        Me.chkExportCon.Size = New System.Drawing.Size(92, 18)
        Me.chkExportCon.TabIndex = 103
        Me.chkExportCon.Text = "Export Con 3D"
        Me.chkExportCon.UseVisualStyleBackColor = True
        '
        'modeHist
        '
        Me.modeHist.AutoSize = True
        Me.modeHist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modeHist.Location = New System.Drawing.Point(7, 17)
        Me.modeHist.Name = "modeHist"
        Me.modeHist.Size = New System.Drawing.Size(115, 18)
        Me.modeHist.TabIndex = 7
        Me.modeHist.Text = "Show Rose Charts"
        Me.modeHist.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(6, 51)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(49, 14)
        Me.Label35.TabIndex = 102
        Me.Label35.Text = "N Bin Ori"
        '
        'setNBinFR
        '
        Me.setNBinFR.BackColor = System.Drawing.Color.DimGray
        Me.setNBinFR.ForeColor = System.Drawing.Color.White
        Me.setNBinFR.Location = New System.Drawing.Point(223, 84)
        Me.setNBinFR.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.setNBinFR.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.setNBinFR.Name = "setNBinFR"
        Me.setNBinFR.Size = New System.Drawing.Size(58, 20)
        Me.setNBinFR.TabIndex = 101
        Me.setNBinFR.Value = New Decimal(New Integer() {11, 0, 0, 0})
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(143, 87)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(48, 14)
        Me.Label38.TabIndex = 102
        Me.Label38.Text = "N Bin FR"
        '
        'setNBinOri
        '
        Me.setNBinOri.BackColor = System.Drawing.Color.DimGray
        Me.setNBinOri.ForeColor = System.Drawing.Color.White
        Me.setNBinOri.Location = New System.Drawing.Point(76, 48)
        Me.setNBinOri.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.setNBinOri.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.setNBinOri.Name = "setNBinOri"
        Me.setNBinOri.Size = New System.Drawing.Size(58, 20)
        Me.setNBinOri.TabIndex = 101
        Me.setNBinOri.Value = New Decimal(New Integer() {18, 0, 0, 0})
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(143, 51)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(60, 14)
        Me.Label36.TabIndex = 102
        Me.Label36.Text = "N Bin Norm"
        '
        'setNBinForce
        '
        Me.setNBinForce.BackColor = System.Drawing.Color.DimGray
        Me.setNBinForce.ForeColor = System.Drawing.Color.White
        Me.setNBinForce.Location = New System.Drawing.Point(76, 84)
        Me.setNBinForce.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.setNBinForce.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.setNBinForce.Name = "setNBinForce"
        Me.setNBinForce.Size = New System.Drawing.Size(58, 20)
        Me.setNBinForce.TabIndex = 101
        Me.setNBinForce.Value = New Decimal(New Integer() {18, 0, 0, 0})
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(6, 87)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(63, 14)
        Me.Label37.TabIndex = 102
        Me.Label37.Text = "N Bin Force"
        '
        'setNBinNorm
        '
        Me.setNBinNorm.BackColor = System.Drawing.Color.DimGray
        Me.setNBinNorm.ForeColor = System.Drawing.Color.White
        Me.setNBinNorm.Location = New System.Drawing.Point(223, 48)
        Me.setNBinNorm.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.setNBinNorm.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.setNBinNorm.Name = "setNBinNorm"
        Me.setNBinNorm.Size = New System.Drawing.Size(58, 20)
        Me.setNBinNorm.TabIndex = 101
        Me.setNBinNorm.Value = New Decimal(New Integer() {18, 0, 0, 0})
        '
        'chkMeasureMode
        '
        Me.chkMeasureMode.AutoSize = True
        Me.chkMeasureMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkMeasureMode.Location = New System.Drawing.Point(150, 554)
        Me.chkMeasureMode.Name = "chkMeasureMode"
        Me.chkMeasureMode.Size = New System.Drawing.Size(65, 18)
        Me.chkMeasureMode.TabIndex = 104
        Me.chkMeasureMode.Text = "Measure"
        Me.chkMeasureMode.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkHideElement)
        Me.GroupBox2.Controls.Add(Me.chkShowEleNum)
        Me.GroupBox2.Controls.Add(Me.showLine)
        Me.GroupBox2.Controls.Add(Me.showARC)
        Me.GroupBox2.Controls.Add(Me.chkShowFriend)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(6, 234)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 70)
        Me.GroupBox2.TabIndex = 100
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Particle Display"
        '
        'chkHideElement
        '
        Me.chkHideElement.AutoSize = True
        Me.chkHideElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkHideElement.Location = New System.Drawing.Point(7, 42)
        Me.chkHideElement.Name = "chkHideElement"
        Me.chkHideElement.Size = New System.Drawing.Size(84, 18)
        Me.chkHideElement.TabIndex = 103
        Me.chkHideElement.Text = "Hide Element"
        Me.chkHideElement.UseVisualStyleBackColor = True
        '
        'chkShowEleNum
        '
        Me.chkShowEleNum.AutoSize = True
        Me.chkShowEleNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowEleNum.Location = New System.Drawing.Point(144, 42)
        Me.chkShowEleNum.Name = "chkShowEleNum"
        Me.chkShowEleNum.Size = New System.Drawing.Size(99, 18)
        Me.chkShowEleNum.TabIndex = 102
        Me.chkShowEleNum.Text = "Show Ele. Num."
        Me.chkShowEleNum.UseVisualStyleBackColor = True
        '
        'showLine
        '
        Me.showLine.AutoSize = True
        Me.showLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.showLine.Location = New System.Drawing.Point(108, 18)
        Me.showLine.Name = "showLine"
        Me.showLine.Size = New System.Drawing.Size(75, 18)
        Me.showLine.TabIndex = 102
        Me.showLine.Text = "Show Line"
        Me.showLine.UseVisualStyleBackColor = True
        '
        'showARC
        '
        Me.showARC.AutoSize = True
        Me.showARC.Checked = True
        Me.showARC.CheckState = System.Windows.Forms.CheckState.Checked
        Me.showARC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.showARC.Location = New System.Drawing.Point(7, 18)
        Me.showARC.Name = "showARC"
        Me.showARC.Size = New System.Drawing.Size(72, 18)
        Me.showARC.TabIndex = 101
        Me.showARC.Text = "Show Arc"
        Me.showARC.UseVisualStyleBackColor = True
        '
        'chkShowFriend
        '
        Me.chkShowFriend.AutoSize = True
        Me.chkShowFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowFriend.Location = New System.Drawing.Point(203, 18)
        Me.chkShowFriend.Margin = New System.Windows.Forms.Padding(4)
        Me.chkShowFriend.Name = "chkShowFriend"
        Me.chkShowFriend.Size = New System.Drawing.Size(72, 18)
        Me.chkShowFriend.TabIndex = 75
        Me.chkShowFriend.Text = "Neighbors"
        Me.chkShowFriend.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkConForceByRadius)
        Me.GroupBox1.Controls.Add(Me.btnForLengScaleUp)
        Me.GroupBox1.Controls.Add(Me.btnForLengScaleDown)
        Me.GroupBox1.Controls.Add(Me.btnAutoFScaleLeng)
        Me.GroupBox1.Controls.Add(Me.btnAutoFScaleThick)
        Me.GroupBox1.Controls.Add(Me.btnFSceleThickUp)
        Me.GroupBox1.Controls.Add(Me.btnFScaleThickDown)
        Me.GroupBox1.Controls.Add(Me.grpForceViewMode)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.setFactorSlidContrast)
        Me.GroupBox1.Controls.Add(Me.btnSScaleUp)
        Me.GroupBox1.Controls.Add(Me.btnSScaleDown)
        Me.GroupBox1.Controls.Add(Me.btnAutoSScale)
        Me.GroupBox1.Controls.Add(Me.chkShowSliding)
        Me.GroupBox1.Controls.Add(Me.chkIncWallForce)
        Me.GroupBox1.Controls.Add(Me.flagForceByLeng)
        Me.GroupBox1.Controls.Add(Me.chkShowForceColor)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.Constrast)
        Me.GroupBox1.Controls.Add(Me.cstForceThickLeng)
        Me.GroupBox1.Controls.Add(Me.chkForceByThick)
        Me.GroupBox1.Controls.Add(Me.cstForceThickContrast)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 222)
        Me.GroupBox1.TabIndex = 99
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Show Force"
        '
        'chkConForceByRadius
        '
        Me.chkConForceByRadius.AutoSize = True
        Me.chkConForceByRadius.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkConForceByRadius.Location = New System.Drawing.Point(6, 73)
        Me.chkConForceByRadius.Name = "chkConForceByRadius"
        Me.chkConForceByRadius.Size = New System.Drawing.Size(56, 18)
        Me.chkConForceByRadius.TabIndex = 108
        Me.chkConForceByRadius.Text = "Radius"
        Me.chkConForceByRadius.UseVisualStyleBackColor = True
        '
        'btnForLengScaleUp
        '
        Me.btnForLengScaleUp.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnForLengScaleUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnForLengScaleUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForLengScaleUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.163636!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForLengScaleUp.Location = New System.Drawing.Point(167, 20)
        Me.btnForLengScaleUp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnForLengScaleUp.Name = "btnForLengScaleUp"
        Me.btnForLengScaleUp.Size = New System.Drawing.Size(25, 25)
        Me.btnForLengScaleUp.TabIndex = 79
        Me.btnForLengScaleUp.Text = "+"
        Me.btnForLengScaleUp.UseVisualStyleBackColor = True
        '
        'btnForLengScaleDown
        '
        Me.btnForLengScaleDown.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnForLengScaleDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnForLengScaleDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForLengScaleDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.163636!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForLengScaleDown.Location = New System.Drawing.Point(140, 20)
        Me.btnForLengScaleDown.Margin = New System.Windows.Forms.Padding(4)
        Me.btnForLengScaleDown.Name = "btnForLengScaleDown"
        Me.btnForLengScaleDown.Size = New System.Drawing.Size(25, 25)
        Me.btnForLengScaleDown.TabIndex = 80
        Me.btnForLengScaleDown.Text = "-"
        Me.btnForLengScaleDown.UseVisualStyleBackColor = True
        '
        'btnAutoFScaleLeng
        '
        Me.btnAutoFScaleLeng.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnAutoFScaleLeng.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAutoFScaleLeng.Location = New System.Drawing.Point(87, 20)
        Me.btnAutoFScaleLeng.Name = "btnAutoFScaleLeng"
        Me.btnAutoFScaleLeng.Size = New System.Drawing.Size(50, 25)
        Me.btnAutoFScaleLeng.TabIndex = 89
        Me.btnAutoFScaleLeng.Text = "Auto"
        Me.btnAutoFScaleLeng.UseVisualStyleBackColor = True
        '
        'btnAutoFScaleThick
        '
        Me.btnAutoFScaleThick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnAutoFScaleThick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAutoFScaleThick.Location = New System.Drawing.Point(87, 57)
        Me.btnAutoFScaleThick.Name = "btnAutoFScaleThick"
        Me.btnAutoFScaleThick.Size = New System.Drawing.Size(50, 25)
        Me.btnAutoFScaleThick.TabIndex = 91
        Me.btnAutoFScaleThick.Text = "Auto"
        Me.btnAutoFScaleThick.UseVisualStyleBackColor = True
        '
        'btnFSceleThickUp
        '
        Me.btnFSceleThickUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnFSceleThickUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFSceleThickUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.163636!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFSceleThickUp.Location = New System.Drawing.Point(166, 57)
        Me.btnFSceleThickUp.Name = "btnFSceleThickUp"
        Me.btnFSceleThickUp.Size = New System.Drawing.Size(25, 25)
        Me.btnFSceleThickUp.TabIndex = 92
        Me.btnFSceleThickUp.Text = "+"
        Me.btnFSceleThickUp.UseVisualStyleBackColor = True
        '
        'btnFScaleThickDown
        '
        Me.btnFScaleThickDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnFScaleThickDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFScaleThickDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.163636!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFScaleThickDown.Location = New System.Drawing.Point(140, 57)
        Me.btnFScaleThickDown.Name = "btnFScaleThickDown"
        Me.btnFScaleThickDown.Size = New System.Drawing.Size(25, 25)
        Me.btnFScaleThickDown.TabIndex = 93
        Me.btnFScaleThickDown.Text = "-"
        Me.btnFScaleThickDown.UseVisualStyleBackColor = True
        '
        'grpForceViewMode
        '
        Me.grpForceViewMode.Controls.Add(Me.rbForceModeConn)
        Me.grpForceViewMode.Controls.Add(Me.rbForceModeDire)
        Me.grpForceViewMode.Location = New System.Drawing.Point(196, 11)
        Me.grpForceViewMode.Name = "grpForceViewMode"
        Me.grpForceViewMode.Size = New System.Drawing.Size(84, 71)
        Me.grpForceViewMode.TabIndex = 107
        Me.grpForceViewMode.TabStop = False
        '
        'rbForceModeConn
        '
        Me.rbForceModeConn.AutoSize = True
        Me.rbForceModeConn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbForceModeConn.Location = New System.Drawing.Point(7, 42)
        Me.rbForceModeConn.Name = "rbForceModeConn"
        Me.rbForceModeConn.Size = New System.Drawing.Size(64, 18)
        Me.rbForceModeConn.TabIndex = 1
        Me.rbForceModeConn.Text = "Connect"
        Me.rbForceModeConn.UseVisualStyleBackColor = True
        '
        'rbForceModeDire
        '
        Me.rbForceModeDire.AutoSize = True
        Me.rbForceModeDire.Checked = True
        Me.rbForceModeDire.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbForceModeDire.Location = New System.Drawing.Point(7, 14)
        Me.rbForceModeDire.Name = "rbForceModeDire"
        Me.rbForceModeDire.Size = New System.Drawing.Size(66, 18)
        Me.rbForceModeDire.TabIndex = 0
        Me.rbForceModeDire.TabStop = True
        Me.rbForceModeDire.Text = "Direction"
        Me.rbForceModeDire.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(131, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 14)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "Contrast"
        '
        'setFactorSlidContrast
        '
        Me.setFactorSlidContrast.BackColor = System.Drawing.Color.DimGray
        Me.setFactorSlidContrast.DecimalPlaces = 1
        Me.setFactorSlidContrast.ForeColor = System.Drawing.Color.White
        Me.setFactorSlidContrast.Location = New System.Drawing.Point(193, 190)
        Me.setFactorSlidContrast.Name = "setFactorSlidContrast"
        Me.setFactorSlidContrast.Size = New System.Drawing.Size(55, 20)
        Me.setFactorSlidContrast.TabIndex = 105
        Me.setFactorSlidContrast.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnSScaleUp
        '
        Me.btnSScaleUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnSScaleUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSScaleUp.Location = New System.Drawing.Point(223, 159)
        Me.btnSScaleUp.Name = "btnSScaleUp"
        Me.btnSScaleUp.Size = New System.Drawing.Size(25, 25)
        Me.btnSScaleUp.TabIndex = 104
        Me.btnSScaleUp.Text = "+"
        Me.btnSScaleUp.UseVisualStyleBackColor = True
        '
        'btnSScaleDown
        '
        Me.btnSScaleDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnSScaleDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSScaleDown.Location = New System.Drawing.Point(193, 159)
        Me.btnSScaleDown.Name = "btnSScaleDown"
        Me.btnSScaleDown.Size = New System.Drawing.Size(25, 25)
        Me.btnSScaleDown.TabIndex = 103
        Me.btnSScaleDown.Text = "-"
        Me.btnSScaleDown.UseVisualStyleBackColor = True
        '
        'btnAutoSScale
        '
        Me.btnAutoSScale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnAutoSScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAutoSScale.Location = New System.Drawing.Point(138, 159)
        Me.btnAutoSScale.Name = "btnAutoSScale"
        Me.btnAutoSScale.Size = New System.Drawing.Size(50, 25)
        Me.btnAutoSScale.TabIndex = 102
        Me.btnAutoSScale.Text = "Auto"
        Me.btnAutoSScale.UseVisualStyleBackColor = True
        '
        'chkShowSliding
        '
        Me.chkShowSliding.AutoSize = True
        Me.chkShowSliding.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowSliding.Location = New System.Drawing.Point(6, 161)
        Me.chkShowSliding.Name = "chkShowSliding"
        Me.chkShowSliding.Size = New System.Drawing.Size(86, 18)
        Me.chkShowSliding.TabIndex = 101
        Me.chkShowSliding.Text = "Show Sliding"
        Me.chkShowSliding.UseVisualStyleBackColor = True
        '
        'chkIncWallForce
        '
        Me.chkIncWallForce.AutoSize = True
        Me.chkIncWallForce.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkIncWallForce.Location = New System.Drawing.Point(6, 135)
        Me.chkIncWallForce.Name = "chkIncWallForce"
        Me.chkIncWallForce.Size = New System.Drawing.Size(99, 18)
        Me.chkIncWallForce.TabIndex = 100
        Me.chkIncWallForce.Text = "Incld Wall Force"
        Me.chkIncWallForce.UseVisualStyleBackColor = True
        '
        'flagForceByLeng
        '
        Me.flagForceByLeng.AutoSize = True
        Me.flagForceByLeng.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.flagForceByLeng.Location = New System.Drawing.Point(6, 22)
        Me.flagForceByLeng.Margin = New System.Windows.Forms.Padding(4)
        Me.flagForceByLeng.Name = "flagForceByLeng"
        Me.flagForceByLeng.Size = New System.Drawing.Size(72, 18)
        Me.flagForceByLeng.TabIndex = 77
        Me.flagForceByLeng.Text = "By Length"
        Me.flagForceByLeng.UseVisualStyleBackColor = True
        '
        'chkShowForceColor
        '
        Me.chkShowForceColor.AutoSize = True
        Me.chkShowForceColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowForceColor.Location = New System.Drawing.Point(137, 135)
        Me.chkShowForceColor.Name = "chkShowForceColor"
        Me.chkShowForceColor.Size = New System.Drawing.Size(120, 18)
        Me.chkShowForceColor.TabIndex = 98
        Me.chkShowForceColor.Text = "Color - Friction Ratio"
        Me.chkShowForceColor.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(144, 102)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(40, 14)
        Me.Label29.TabIndex = 97
        Me.Label29.Text = "Length"
        '
        'Constrast
        '
        Me.Constrast.AutoSize = True
        Me.Constrast.Location = New System.Drawing.Point(27, 102)
        Me.Constrast.Name = "Constrast"
        Me.Constrast.Size = New System.Drawing.Size(48, 14)
        Me.Constrast.TabIndex = 96
        Me.Constrast.Text = "Contrast"
        '
        'cstForceThickLeng
        '
        Me.cstForceThickLeng.BackColor = System.Drawing.Color.DimGray
        Me.cstForceThickLeng.DecimalPlaces = 1
        Me.cstForceThickLeng.ForeColor = System.Drawing.Color.White
        Me.cstForceThickLeng.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.cstForceThickLeng.Location = New System.Drawing.Point(193, 100)
        Me.cstForceThickLeng.Name = "cstForceThickLeng"
        Me.cstForceThickLeng.Size = New System.Drawing.Size(55, 20)
        Me.cstForceThickLeng.TabIndex = 95
        Me.cstForceThickLeng.Value = New Decimal(New Integer() {6, 0, 0, 65536})
        '
        'chkForceByThick
        '
        Me.chkForceByThick.AutoSize = True
        Me.chkForceByThick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkForceByThick.Location = New System.Drawing.Point(6, 52)
        Me.chkForceByThick.Name = "chkForceByThick"
        Me.chkForceByThick.Size = New System.Drawing.Size(66, 18)
        Me.chkForceByThick.TabIndex = 90
        Me.chkForceByThick.Text = "By Width"
        Me.chkForceByThick.UseVisualStyleBackColor = True
        '
        'cstForceThickContrast
        '
        Me.cstForceThickContrast.BackColor = System.Drawing.Color.DimGray
        Me.cstForceThickContrast.DecimalPlaces = 1
        Me.cstForceThickContrast.ForeColor = System.Drawing.Color.White
        Me.cstForceThickContrast.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.cstForceThickContrast.Location = New System.Drawing.Point(87, 100)
        Me.cstForceThickContrast.Name = "cstForceThickContrast"
        Me.cstForceThickContrast.Size = New System.Drawing.Size(49, 20)
        Me.cstForceThickContrast.TabIndex = 94
        Me.cstForceThickContrast.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'chkShowCohesion
        '
        Me.chkShowCohesion.AutoSize = True
        Me.chkShowCohesion.Enabled = False
        Me.chkShowCohesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowCohesion.Location = New System.Drawing.Point(13, 526)
        Me.chkShowCohesion.Name = "chkShowCohesion"
        Me.chkShowCohesion.Size = New System.Drawing.Size(100, 18)
        Me.chkShowCohesion.TabIndex = 87
        Me.chkShowCohesion.Text = "Show Cohesion"
        Me.chkShowCohesion.UseVisualStyleBackColor = True
        '
        'chkShowCoord
        '
        Me.chkShowCoord.AutoSize = True
        Me.chkShowCoord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowCoord.Location = New System.Drawing.Point(13, 554)
        Me.chkShowCoord.Name = "chkShowCoord"
        Me.chkShowCoord.Size = New System.Drawing.Size(107, 18)
        Me.chkShowCoord.TabIndex = 86
        Me.chkShowCoord.Text = "Show Coordinate"
        Me.chkShowCoord.UseVisualStyleBackColor = True
        '
        'flagRotation
        '
        Me.flagRotation.AutoSize = True
        Me.flagRotation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.flagRotation.Location = New System.Drawing.Point(13, 442)
        Me.flagRotation.Margin = New System.Windows.Forms.Padding(4)
        Me.flagRotation.Name = "flagRotation"
        Me.flagRotation.Size = New System.Drawing.Size(94, 18)
        Me.flagRotation.TabIndex = 81
        Me.flagRotation.Text = "Show Rotation"
        Me.flagRotation.UseVisualStyleBackColor = True
        '
        'btVelMinus
        '
        Me.btVelMinus.Cursor = System.Windows.Forms.Cursors.Default
        Me.btVelMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btVelMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btVelMinus.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.btVelMinus.Location = New System.Drawing.Point(150, 468)
        Me.btVelMinus.Margin = New System.Windows.Forms.Padding(4)
        Me.btVelMinus.Name = "btVelMinus"
        Me.btVelMinus.Size = New System.Drawing.Size(25, 22)
        Me.btVelMinus.TabIndex = 85
        Me.btVelMinus.Text = "-"
        Me.btVelMinus.UseVisualStyleBackColor = True
        '
        'checkShowVel
        '
        Me.checkShowVel.AutoSize = True
        Me.checkShowVel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkShowVel.Location = New System.Drawing.Point(13, 470)
        Me.checkShowVel.Margin = New System.Windows.Forms.Padding(4)
        Me.checkShowVel.Name = "checkShowVel"
        Me.checkShowVel.Size = New System.Drawing.Size(93, 18)
        Me.checkShowVel.TabIndex = 76
        Me.checkShowVel.Text = "Show Velocity"
        Me.checkShowVel.UseVisualStyleBackColor = True
        '
        'flagShowP
        '
        Me.flagShowP.AutoSize = True
        Me.flagShowP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.flagShowP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.flagShowP.Location = New System.Drawing.Point(13, 498)
        Me.flagShowP.Margin = New System.Windows.Forms.Padding(4)
        Me.flagShowP.Name = "flagShowP"
        Me.flagShowP.Size = New System.Drawing.Size(83, 18)
        Me.flagShowP.TabIndex = 84
        Me.flagShowP.Text = "Confinement"
        Me.flagShowP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.flagShowP.UseVisualStyleBackColor = True
        '
        'btnHalfPScale
        '
        Me.btnHalfPScale.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnHalfPScale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnHalfPScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHalfPScale.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.btnHalfPScale.Location = New System.Drawing.Point(150, 498)
        Me.btnHalfPScale.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHalfPScale.Name = "btnHalfPScale"
        Me.btnHalfPScale.Size = New System.Drawing.Size(25, 22)
        Me.btnHalfPScale.TabIndex = 83
        Me.btnHalfPScale.Text = "-"
        Me.btnHalfPScale.UseVisualStyleBackColor = True
        '
        'btnDoublePScale
        '
        Me.btnDoublePScale.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDoublePScale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnDoublePScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDoublePScale.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.btnDoublePScale.Location = New System.Drawing.Point(181, 498)
        Me.btnDoublePScale.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoublePScale.Name = "btnDoublePScale"
        Me.btnDoublePScale.Size = New System.Drawing.Size(25, 22)
        Me.btnDoublePScale.TabIndex = 82
        Me.btnDoublePScale.Text = "+"
        Me.btnDoublePScale.UseVisualStyleBackColor = True
        '
        'btVelPlus
        '
        Me.btVelPlus.Cursor = System.Windows.Forms.Cursors.Default
        Me.btVelPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btVelPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btVelPlus.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.btVelPlus.Location = New System.Drawing.Point(181, 468)
        Me.btVelPlus.Margin = New System.Windows.Forms.Padding(4)
        Me.btVelPlus.Name = "btVelPlus"
        Me.btVelPlus.Size = New System.Drawing.Size(25, 22)
        Me.btVelPlus.TabIndex = 78
        Me.btVelPlus.Text = "+"
        Me.btVelPlus.UseVisualStyleBackColor = True
        '
        'tabLoad
        '
        Me.tabLoad.AutoScroll = True
        Me.tabLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tabLoad.Controls.Add(Me.grpLoadModeControl)
        Me.tabLoad.Controls.Add(Me.grpBatchLoading)
        Me.tabLoad.Controls.Add(Me.GroupBox8)
        Me.tabLoad.Controls.Add(Me.grpDisplacementLoadControl)
        Me.tabLoad.Controls.Add(Me.grpConfiningControl)
        Me.tabLoad.Controls.Add(Me.GroupBox5)
        Me.tabLoad.ForeColor = System.Drawing.Color.White
        Me.tabLoad.Location = New System.Drawing.Point(4, 82)
        Me.tabLoad.Margin = New System.Windows.Forms.Padding(1)
        Me.tabLoad.Name = "tabLoad"
        Me.tabLoad.Size = New System.Drawing.Size(301, 689)
        Me.tabLoad.TabIndex = 1
        Me.tabLoad.Text = "Load"
        Me.tabLoad.UseVisualStyleBackColor = True
        '
        'grpLoadModeControl
        '
        Me.grpLoadModeControl.Controls.Add(Me.Label48)
        Me.grpLoadModeControl.Controls.Add(Me.Label47)
        Me.grpLoadModeControl.Controls.Add(Me.Label50)
        Me.grpLoadModeControl.Controls.Add(Me.Label49)
        Me.grpLoadModeControl.Controls.Add(Me.Label46)
        Me.grpLoadModeControl.Controls.Add(Me.Label6)
        Me.grpLoadModeControl.Controls.Add(Me.setLoadModeTopT)
        Me.grpLoadModeControl.Controls.Add(Me.setLoadModeTopN)
        Me.grpLoadModeControl.Controls.Add(Me.setLoadModeLeftT)
        Me.grpLoadModeControl.Controls.Add(Me.setLoadModeBottomT)
        Me.grpLoadModeControl.Controls.Add(Me.setLoadModeLeftN)
        Me.grpLoadModeControl.Controls.Add(Me.setLoadModeRightT)
        Me.grpLoadModeControl.Controls.Add(Me.setLoadModeBottomN)
        Me.grpLoadModeControl.Controls.Add(Me.setLoadModeRightN)
        Me.grpLoadModeControl.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.grpLoadModeControl.ForeColor = System.Drawing.Color.White
        Me.grpLoadModeControl.Location = New System.Drawing.Point(8, 243)
        Me.grpLoadModeControl.Name = "grpLoadModeControl"
        Me.grpLoadModeControl.Size = New System.Drawing.Size(287, 144)
        Me.grpLoadModeControl.TabIndex = 82
        Me.grpLoadModeControl.TabStop = False
        Me.grpLoadModeControl.Text = "Loading Mode"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(4, 118)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(23, 14)
        Me.Label48.TabIndex = 81
        Me.Label48.Text = "Bot"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(4, 92)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(24, 14)
        Me.Label47.TabIndex = 81
        Me.Label47.Text = "Top"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(185, 16)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(55, 14)
        Me.Label50.TabIndex = 81
        Me.Label50.Text = "Tangential"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(70, 16)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(40, 14)
        Me.Label49.TabIndex = 81
        Me.Label49.Text = "Normal"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(4, 38)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(26, 14)
        Me.Label46.TabIndex = 81
        Me.Label46.Text = "Left"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 14)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Right"
        '
        'setLoadModeTopT
        '
        Me.setLoadModeTopT.BackColor = System.Drawing.Color.DimGray
        Me.setLoadModeTopT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.setLoadModeTopT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.setLoadModeTopT.ForeColor = System.Drawing.Color.White
        Me.setLoadModeTopT.FormattingEnabled = True
        Me.setLoadModeTopT.Items.AddRange(New Object() {"Wall Move Rate", "Stress on Particles", "Stress on Walls"})
        Me.setLoadModeTopT.Location = New System.Drawing.Point(163, 89)
        Me.setLoadModeTopT.Name = "setLoadModeTopT"
        Me.setLoadModeTopT.Size = New System.Drawing.Size(113, 22)
        Me.setLoadModeTopT.TabIndex = 80
        '
        'setLoadModeTopN
        '
        Me.setLoadModeTopN.BackColor = System.Drawing.Color.DimGray
        Me.setLoadModeTopN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.setLoadModeTopN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.setLoadModeTopN.ForeColor = System.Drawing.Color.White
        Me.setLoadModeTopN.FormattingEnabled = True
        Me.setLoadModeTopN.Items.AddRange(New Object() {"Wall Move Rate", "Stress on Particles", "Stress on Walls", "Triaxial Mode"})
        Me.setLoadModeTopN.Location = New System.Drawing.Point(47, 89)
        Me.setLoadModeTopN.Name = "setLoadModeTopN"
        Me.setLoadModeTopN.Size = New System.Drawing.Size(113, 22)
        Me.setLoadModeTopN.TabIndex = 80
        '
        'setLoadModeLeftT
        '
        Me.setLoadModeLeftT.BackColor = System.Drawing.Color.DimGray
        Me.setLoadModeLeftT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.setLoadModeLeftT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.setLoadModeLeftT.ForeColor = System.Drawing.Color.White
        Me.setLoadModeLeftT.FormattingEnabled = True
        Me.setLoadModeLeftT.Items.AddRange(New Object() {"Wall Move Rate", "Stress on Particles", "Stress on Walls"})
        Me.setLoadModeLeftT.Location = New System.Drawing.Point(163, 35)
        Me.setLoadModeLeftT.Name = "setLoadModeLeftT"
        Me.setLoadModeLeftT.Size = New System.Drawing.Size(113, 22)
        Me.setLoadModeLeftT.TabIndex = 77
        Me.setLoadModeLeftT.Tag = ""
        '
        'setLoadModeBottomT
        '
        Me.setLoadModeBottomT.BackColor = System.Drawing.Color.DimGray
        Me.setLoadModeBottomT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.setLoadModeBottomT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.setLoadModeBottomT.ForeColor = System.Drawing.Color.White
        Me.setLoadModeBottomT.FormattingEnabled = True
        Me.setLoadModeBottomT.Items.AddRange(New Object() {"Wall Move Rate", "Stress on Particles", "Stress on Walls"})
        Me.setLoadModeBottomT.Location = New System.Drawing.Point(163, 115)
        Me.setLoadModeBottomT.Name = "setLoadModeBottomT"
        Me.setLoadModeBottomT.Size = New System.Drawing.Size(113, 22)
        Me.setLoadModeBottomT.TabIndex = 79
        '
        'setLoadModeLeftN
        '
        Me.setLoadModeLeftN.BackColor = System.Drawing.Color.DimGray
        Me.setLoadModeLeftN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.setLoadModeLeftN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.setLoadModeLeftN.ForeColor = System.Drawing.Color.White
        Me.setLoadModeLeftN.FormattingEnabled = True
        Me.setLoadModeLeftN.Items.AddRange(New Object() {"Wall Move Rate", "Stress on Particles", "Stress on Walls"})
        Me.setLoadModeLeftN.Location = New System.Drawing.Point(47, 35)
        Me.setLoadModeLeftN.Name = "setLoadModeLeftN"
        Me.setLoadModeLeftN.Size = New System.Drawing.Size(113, 22)
        Me.setLoadModeLeftN.TabIndex = 77
        Me.setLoadModeLeftN.Tag = ""
        '
        'setLoadModeRightT
        '
        Me.setLoadModeRightT.BackColor = System.Drawing.Color.DimGray
        Me.setLoadModeRightT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.setLoadModeRightT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.setLoadModeRightT.ForeColor = System.Drawing.Color.White
        Me.setLoadModeRightT.FormattingEnabled = True
        Me.setLoadModeRightT.Items.AddRange(New Object() {"Wall Move Rate", "Stress on Particles", "Stress on Walls"})
        Me.setLoadModeRightT.Location = New System.Drawing.Point(163, 62)
        Me.setLoadModeRightT.Name = "setLoadModeRightT"
        Me.setLoadModeRightT.Size = New System.Drawing.Size(113, 22)
        Me.setLoadModeRightT.TabIndex = 78
        '
        'setLoadModeBottomN
        '
        Me.setLoadModeBottomN.BackColor = System.Drawing.Color.DimGray
        Me.setLoadModeBottomN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.setLoadModeBottomN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.setLoadModeBottomN.ForeColor = System.Drawing.Color.White
        Me.setLoadModeBottomN.FormattingEnabled = True
        Me.setLoadModeBottomN.Items.AddRange(New Object() {"Wall Move Rate", "Stress on Particles", "Stress on Walls", "Triaxial Mode"})
        Me.setLoadModeBottomN.Location = New System.Drawing.Point(47, 115)
        Me.setLoadModeBottomN.Name = "setLoadModeBottomN"
        Me.setLoadModeBottomN.Size = New System.Drawing.Size(113, 22)
        Me.setLoadModeBottomN.TabIndex = 79
        '
        'setLoadModeRightN
        '
        Me.setLoadModeRightN.BackColor = System.Drawing.Color.DimGray
        Me.setLoadModeRightN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.setLoadModeRightN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.setLoadModeRightN.ForeColor = System.Drawing.Color.White
        Me.setLoadModeRightN.FormattingEnabled = True
        Me.setLoadModeRightN.Items.AddRange(New Object() {"Wall Move Rate", "Stress on Particles", "Stress on Walls"})
        Me.setLoadModeRightN.Location = New System.Drawing.Point(47, 62)
        Me.setLoadModeRightN.Name = "setLoadModeRightN"
        Me.setLoadModeRightN.Size = New System.Drawing.Size(113, 22)
        Me.setLoadModeRightN.TabIndex = 78
        '
        'grpBatchLoading
        '
        Me.grpBatchLoading.Controls.Add(Me.cycDis)
        Me.grpBatchLoading.Controls.Add(Me.setCyclicDisplacement)
        Me.grpBatchLoading.Controls.Add(Me.setInitialLoadDirection)
        Me.grpBatchLoading.Controls.Add(Me.Label16)
        Me.grpBatchLoading.Controls.Add(Me.setQLimit)
        Me.grpBatchLoading.Controls.Add(Me.cbSpecialLoad)
        Me.grpBatchLoading.Controls.Add(Me.lbICurStep3)
        Me.grpBatchLoading.Controls.Add(Me.lbICurStep2)
        Me.grpBatchLoading.Controls.Add(Me.lbICurStep1)
        Me.grpBatchLoading.Controls.Add(Me.rbBatchLoading)
        Me.grpBatchLoading.Controls.Add(Me.rbManualLoading)
        Me.grpBatchLoading.Controls.Add(Me.btnOpenBatchLoading)
        Me.grpBatchLoading.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.grpBatchLoading.ForeColor = System.Drawing.Color.White
        Me.grpBatchLoading.Location = New System.Drawing.Point(8, 628)
        Me.grpBatchLoading.Name = "grpBatchLoading"
        Me.grpBatchLoading.Size = New System.Drawing.Size(285, 163)
        Me.grpBatchLoading.TabIndex = 81
        Me.grpBatchLoading.TabStop = False
        Me.grpBatchLoading.Text = "Batch Loading"
        '
        'cycDis
        '
        Me.cycDis.AutoSize = True
        Me.cycDis.Location = New System.Drawing.Point(8, 138)
        Me.cycDis.Name = "cycDis"
        Me.cycDis.Size = New System.Drawing.Size(31, 14)
        Me.cycDis.TabIndex = 9
        Me.cycDis.Text = "Disp:"
        '
        'setCyclicDisplacement
        '
        Me.setCyclicDisplacement.DecimalPlaces = 7
        Me.setCyclicDisplacement.Increment = New Decimal(New Integer() {1, 0, 0, 524288})
        Me.setCyclicDisplacement.Location = New System.Drawing.Point(50, 136)
        Me.setCyclicDisplacement.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.setCyclicDisplacement.Name = "setCyclicDisplacement"
        Me.setCyclicDisplacement.Size = New System.Drawing.Size(120, 20)
        Me.setCyclicDisplacement.TabIndex = 8
        '
        'setInitialLoadDirection
        '
        Me.setInitialLoadDirection.AutoSize = True
        Me.setInitialLoadDirection.Location = New System.Drawing.Point(138, 111)
        Me.setInitialLoadDirection.Name = "setInitialLoadDirection"
        Me.setInitialLoadDirection.Size = New System.Drawing.Size(99, 18)
        Me.setInitialLoadDirection.TabIndex = 7
        Me.setInitialLoadDirection.Text = "Initial Extension"
        Me.setInitialLoadDirection.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 112)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 14)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "q max:"
        '
        'setQLimit
        '
        Me.setQLimit.DecimalPlaces = 1
        Me.setQLimit.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.setQLimit.Location = New System.Drawing.Point(50, 110)
        Me.setQLimit.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.setQLimit.Name = "setQLimit"
        Me.setQLimit.Size = New System.Drawing.Size(70, 20)
        Me.setQLimit.TabIndex = 5
        '
        'cbSpecialLoad
        '
        Me.cbSpecialLoad.AutoCompleteCustomSource.AddRange(New String() {"No special load", "Cyclinc liquefaction", "Const P flexible", "Const P wall"})
        Me.cbSpecialLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbSpecialLoad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSpecialLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSpecialLoad.ForeColor = System.Drawing.Color.White
        Me.cbSpecialLoad.FormattingEnabled = True
        Me.cbSpecialLoad.Items.AddRange(New Object() {"No special load", "UD cyclic", "Const P flexible", "Const P wall"})
        Me.cbSpecialLoad.Location = New System.Drawing.Point(138, 19)
        Me.cbSpecialLoad.Name = "cbSpecialLoad"
        Me.cbSpecialLoad.Size = New System.Drawing.Size(140, 22)
        Me.cbSpecialLoad.TabIndex = 4
        '
        'lbICurStep3
        '
        Me.lbICurStep3.AutoSize = True
        Me.lbICurStep3.Location = New System.Drawing.Point(155, 91)
        Me.lbICurStep3.Name = "lbICurStep3"
        Me.lbICurStep3.Size = New System.Drawing.Size(51, 14)
        Me.lbICurStep3.TabIndex = 3
        Me.lbICurStep3.Text = "SubStep:"
        '
        'lbICurStep2
        '
        Me.lbICurStep2.AutoSize = True
        Me.lbICurStep2.Location = New System.Drawing.Point(154, 72)
        Me.lbICurStep2.Name = "lbICurStep2"
        Me.lbICurStep2.Size = New System.Drawing.Size(86, 14)
        Me.lbICurStep2.TabIndex = 3
        Me.lbICurStep2.Text = "Load Sequence:"
        '
        'lbICurStep1
        '
        Me.lbICurStep1.AutoSize = True
        Me.lbICurStep1.Location = New System.Drawing.Point(154, 51)
        Me.lbICurStep1.Name = "lbICurStep1"
        Me.lbICurStep1.Size = New System.Drawing.Size(32, 14)
        Me.lbICurStep1.TabIndex = 3
        Me.lbICurStep1.Text = "Step:"
        '
        'rbBatchLoading
        '
        Me.rbBatchLoading.AutoSize = True
        Me.rbBatchLoading.Enabled = False
        Me.rbBatchLoading.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbBatchLoading.Location = New System.Drawing.Point(7, 86)
        Me.rbBatchLoading.Name = "rbBatchLoading"
        Me.rbBatchLoading.Size = New System.Drawing.Size(113, 18)
        Me.rbBatchLoading.TabIndex = 2
        Me.rbBatchLoading.Text = "Automatic Loading"
        Me.rbBatchLoading.UseVisualStyleBackColor = True
        '
        'rbManualLoading
        '
        Me.rbManualLoading.AutoSize = True
        Me.rbManualLoading.Checked = True
        Me.rbManualLoading.Enabled = False
        Me.rbManualLoading.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbManualLoading.Location = New System.Drawing.Point(7, 66)
        Me.rbManualLoading.Name = "rbManualLoading"
        Me.rbManualLoading.Size = New System.Drawing.Size(99, 18)
        Me.rbManualLoading.TabIndex = 1
        Me.rbManualLoading.TabStop = True
        Me.rbManualLoading.Text = "Manual Loading"
        Me.rbManualLoading.UseVisualStyleBackColor = True
        '
        'btnOpenBatchLoading
        '
        Me.btnOpenBatchLoading.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnOpenBatchLoading.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenBatchLoading.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.btnOpenBatchLoading.Location = New System.Drawing.Point(7, 19)
        Me.btnOpenBatchLoading.Name = "btnOpenBatchLoading"
        Me.btnOpenBatchLoading.Size = New System.Drawing.Size(113, 41)
        Me.btnOpenBatchLoading.TabIndex = 0
        Me.btnOpenBatchLoading.Text = "Open Loading Sequence"
        Me.btnOpenBatchLoading.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.CentripetalG)
        Me.GroupBox8.Controls.Add(Me.Label1)
        Me.GroupBox8.Controls.Add(Me.Label21)
        Me.GroupBox8.Controls.Add(Me.setXGravity)
        Me.GroupBox8.Controls.Add(Me.setGX)
        Me.GroupBox8.Controls.Add(Me.setGY)
        Me.GroupBox8.Controls.Add(Me.setYGravity)
        Me.GroupBox8.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.GroupBox8.ForeColor = System.Drawing.Color.White
        Me.GroupBox8.Location = New System.Drawing.Point(8, 513)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(287, 109)
        Me.GroupBox8.TabIndex = 80
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Gravity Control"
        '
        'CentripetalG
        '
        Me.CentripetalG.AutoSize = True
        Me.CentripetalG.Location = New System.Drawing.Point(103, 85)
        Me.CentripetalG.Name = "CentripetalG"
        Me.CentripetalG.Size = New System.Drawing.Size(77, 18)
        Me.CentripetalG.TabIndex = 77
        Me.CentripetalG.Text = "Centripetal"
        Me.CentripetalG.UseVisualStyleBackColor = True
        '
        'setXGravity
        '
        Me.setXGravity.BackColor = System.Drawing.Color.DimGray
        Me.setXGravity.DecimalPlaces = 3
        Me.setXGravity.ForeColor = System.Drawing.Color.White
        Me.setXGravity.Location = New System.Drawing.Point(103, 25)
        Me.setXGravity.Maximum = New Decimal(New Integer() {276447232, 23283, 0, 0})
        Me.setXGravity.Minimum = New Decimal(New Integer() {1874919424, 2328306, 0, -2147483648})
        Me.setXGravity.Name = "setXGravity"
        Me.setXGravity.Size = New System.Drawing.Size(77, 20)
        Me.setXGravity.TabIndex = 76
        '
        'setGX
        '
        Me.setGX.BackColor = System.Drawing.Color.DimGray
        Me.setGX.DecimalPlaces = 3
        Me.setGX.ForeColor = System.Drawing.Color.White
        Me.setGX.Location = New System.Drawing.Point(103, 53)
        Me.setGX.Maximum = New Decimal(New Integer() {1874919424, 2328306, 0, 0})
        Me.setGX.Minimum = New Decimal(New Integer() {-1486618624, 232830643, 0, -2147483648})
        Me.setGX.Name = "setGX"
        Me.setGX.Size = New System.Drawing.Size(77, 20)
        Me.setGX.TabIndex = 76
        '
        'setGY
        '
        Me.setGY.BackColor = System.Drawing.Color.DimGray
        Me.setGY.DecimalPlaces = 3
        Me.setGY.ForeColor = System.Drawing.Color.White
        Me.setGY.Location = New System.Drawing.Point(194, 53)
        Me.setGY.Maximum = New Decimal(New Integer() {276447232, 23283, 0, 0})
        Me.setGY.Minimum = New Decimal(New Integer() {1874919424, 2328306, 0, -2147483648})
        Me.setGY.Name = "setGY"
        Me.setGY.Size = New System.Drawing.Size(77, 20)
        Me.setGY.TabIndex = 76
        Me.setGY.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'setYGravity
        '
        Me.setYGravity.BackColor = System.Drawing.Color.DimGray
        Me.setYGravity.DecimalPlaces = 3
        Me.setYGravity.ForeColor = System.Drawing.Color.White
        Me.setYGravity.Location = New System.Drawing.Point(194, 25)
        Me.setYGravity.Maximum = New Decimal(New Integer() {-1530494976, 232830, 0, 0})
        Me.setYGravity.Minimum = New Decimal(New Integer() {1569325056, 23283064, 0, -2147483648})
        Me.setYGravity.Name = "setYGravity"
        Me.setYGravity.Size = New System.Drawing.Size(77, 20)
        Me.setYGravity.TabIndex = 76
        '
        'grpDisplacementLoadControl
        '
        Me.grpDisplacementLoadControl.Controls.Add(Me.chkProgressiveLoading)
        Me.grpDisplacementLoadControl.Controls.Add(Me.setSteptoGo)
        Me.grpDisplacementLoadControl.Controls.Add(Me.setTargetLoadRate)
        Me.grpDisplacementLoadControl.Controls.Add(Me.Label33)
        Me.grpDisplacementLoadControl.Controls.Add(Me.setCurrentLoadRate)
        Me.grpDisplacementLoadControl.Controls.Add(Me.Label34)
        Me.grpDisplacementLoadControl.Controls.Add(Me.Label22)
        Me.grpDisplacementLoadControl.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.grpDisplacementLoadControl.ForeColor = System.Drawing.Color.White
        Me.grpDisplacementLoadControl.Location = New System.Drawing.Point(8, 392)
        Me.grpDisplacementLoadControl.Name = "grpDisplacementLoadControl"
        Me.grpDisplacementLoadControl.Size = New System.Drawing.Size(287, 120)
        Me.grpDisplacementLoadControl.TabIndex = 9
        Me.grpDisplacementLoadControl.TabStop = False
        Me.grpDisplacementLoadControl.Text = "Displacement Loading Rate Control"
        '
        'chkProgressiveLoading
        '
        Me.chkProgressiveLoading.AutoSize = True
        Me.chkProgressiveLoading.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.chkProgressiveLoading.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkProgressiveLoading.Location = New System.Drawing.Point(203, 50)
        Me.chkProgressiveLoading.Name = "chkProgressiveLoading"
        Me.chkProgressiveLoading.Size = New System.Drawing.Size(69, 29)
        Me.chkProgressiveLoading.TabIndex = 71
        Me.chkProgressiveLoading.Text = "Progressive"
        Me.chkProgressiveLoading.UseVisualStyleBackColor = True
        '
        'setSteptoGo
        '
        Me.setSteptoGo.BackColor = System.Drawing.Color.DimGray
        Me.setSteptoGo.ForeColor = System.Drawing.Color.White
        Me.setSteptoGo.Location = New System.Drawing.Point(97, 56)
        Me.setSteptoGo.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.setSteptoGo.Name = "setSteptoGo"
        Me.setSteptoGo.Size = New System.Drawing.Size(103, 20)
        Me.setSteptoGo.TabIndex = 70
        '
        'setTargetLoadRate
        '
        Me.setTargetLoadRate.BackColor = System.Drawing.Color.DimGray
        Me.setTargetLoadRate.DecimalPlaces = 7
        Me.setTargetLoadRate.ForeColor = System.Drawing.Color.White
        Me.setTargetLoadRate.Increment = New Decimal(New Integer() {1, 0, 0, 393216})
        Me.setTargetLoadRate.Location = New System.Drawing.Point(97, 88)
        Me.setTargetLoadRate.Margin = New System.Windows.Forms.Padding(4)
        Me.setTargetLoadRate.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.setTargetLoadRate.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.setTargetLoadRate.Name = "setTargetLoadRate"
        Me.setTargetLoadRate.Size = New System.Drawing.Size(103, 20)
        Me.setTargetLoadRate.TabIndex = 68
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(2, 90)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(62, 14)
        Me.Label33.TabIndex = 69
        Me.Label33.Text = "Target Rate"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(2, 60)
        Me.Label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(64, 14)
        Me.Label34.TabIndex = 69
        Me.Label34.Text = "Steps to Go"
        '
        'grpConfiningControl
        '
        Me.grpConfiningControl.Controls.Add(Me.setpxy)
        Me.grpConfiningControl.Controls.Add(Me.setpInt)
        Me.grpConfiningControl.Controls.Add(Me.Label19)
        Me.grpConfiningControl.Controls.Add(Me.setPy)
        Me.grpConfiningControl.Controls.Add(Me.Label18)
        Me.grpConfiningControl.Controls.Add(Me.Label20)
        Me.grpConfiningControl.Controls.Add(Me.setPx)
        Me.grpConfiningControl.Controls.Add(Me.Label23)
        Me.grpConfiningControl.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.grpConfiningControl.ForeColor = System.Drawing.Color.White
        Me.grpConfiningControl.Location = New System.Drawing.Point(8, 119)
        Me.grpConfiningControl.Name = "grpConfiningControl"
        Me.grpConfiningControl.Size = New System.Drawing.Size(287, 116)
        Me.grpConfiningControl.TabIndex = 9
        Me.grpConfiningControl.TabStop = False
        Me.grpConfiningControl.Text = "Confining Pressure Control"
        '
        'setpxy
        '
        Me.setpxy.BackColor = System.Drawing.Color.DimGray
        Me.setpxy.DecimalPlaces = 1
        Me.setpxy.ForeColor = System.Drawing.Color.White
        Me.setpxy.Location = New System.Drawing.Point(161, 36)
        Me.setpxy.Maximum = New Decimal(New Integer() {-138625024, 2793, 0, 0})
        Me.setpxy.Minimum = New Decimal(New Integer() {-138625024, 2793, 0, -2147483648})
        Me.setpxy.Name = "setpxy"
        Me.setpxy.Size = New System.Drawing.Size(93, 20)
        Me.setpxy.TabIndex = 76
        '
        'setPy
        '
        Me.setPy.BackColor = System.Drawing.Color.DimGray
        Me.setPy.DecimalPlaces = 1
        Me.setPy.ForeColor = System.Drawing.Color.White
        Me.setPy.Location = New System.Drawing.Point(54, 82)
        Me.setPy.Maximum = New Decimal(New Integer() {-138625024, 2793, 0, 0})
        Me.setPy.Minimum = New Decimal(New Integer() {-138625024, 2793, 0, -2147483648})
        Me.setPy.Name = "setPy"
        Me.setPy.Size = New System.Drawing.Size(95, 20)
        Me.setPy.TabIndex = 75
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(158, 20)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 14)
        Me.Label20.TabIndex = 70
        Me.Label20.Text = "Shear Stress"
        '
        'setPx
        '
        Me.setPx.BackColor = System.Drawing.Color.DimGray
        Me.setPx.DecimalPlaces = 1
        Me.setPx.ForeColor = System.Drawing.Color.White
        Me.setPx.Location = New System.Drawing.Point(54, 35)
        Me.setPx.Maximum = New Decimal(New Integer() {1874919424, 2328306, 0, 0})
        Me.setPx.Minimum = New Decimal(New Integer() {-138625024, 2793, 0, -2147483648})
        Me.setPx.Name = "setPx"
        Me.setPx.Size = New System.Drawing.Size(95, 20)
        Me.setPx.TabIndex = 74
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnAutoWall)
        Me.GroupBox5.Controls.Add(Me.incWall)
        Me.GroupBox5.Controls.Add(Me.setAngle)
        Me.GroupBox5.Controls.Add(Me.btnCCW)
        Me.GroupBox5.Controls.Add(Me.btnCW)
        Me.GroupBox5.Controls.Add(Me.chsWall)
        Me.GroupBox5.Controls.Add(Me.MovLeft)
        Me.GroupBox5.Controls.Add(Me.MovRight)
        Me.GroupBox5.Controls.Add(Me.MovDown)
        Me.GroupBox5.Controls.Add(Me.MovUp)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(8, 10)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(287, 104)
        Me.GroupBox5.TabIndex = 79
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Wall Control"
        '
        'btnAutoWall
        '
        Me.btnAutoWall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnAutoWall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAutoWall.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.btnAutoWall.Location = New System.Drawing.Point(218, 59)
        Me.btnAutoWall.Name = "btnAutoWall"
        Me.btnAutoWall.Size = New System.Drawing.Size(50, 40)
        Me.btnAutoWall.TabIndex = 78
        Me.btnAutoWall.Text = "Auto Wall"
        Me.btnAutoWall.UseVisualStyleBackColor = True
        '
        'incWall
        '
        Me.incWall.BackColor = System.Drawing.Color.DimGray
        Me.incWall.ForeColor = System.Drawing.Color.White
        Me.incWall.Location = New System.Drawing.Point(55, 48)
        Me.incWall.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.incWall.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.incWall.Name = "incWall"
        Me.incWall.Size = New System.Drawing.Size(50, 20)
        Me.incWall.TabIndex = 77
        Me.incWall.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'tabEdit
        '
        Me.tabEdit.AutoScroll = True
        Me.tabEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tabEdit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabEdit.Controls.Add(Me.grpDiscMask)
        Me.tabEdit.Controls.Add(Me.textEleQuery)
        Me.tabEdit.Controls.Add(Me.grpCrop)
        Me.tabEdit.Controls.Add(Me.grpEditOption)
        Me.tabEdit.ForeColor = System.Drawing.Color.White
        Me.tabEdit.Location = New System.Drawing.Point(4, 82)
        Me.tabEdit.Name = "tabEdit"
        Me.tabEdit.Size = New System.Drawing.Size(301, 689)
        Me.tabEdit.TabIndex = 3
        Me.tabEdit.Text = "Edit"
        Me.tabEdit.UseVisualStyleBackColor = True
        '
        'grpDiscMask
        '
        Me.grpDiscMask.Controls.Add(Me.chkExpDiscMask)
        Me.grpDiscMask.Controls.Add(Me.chkShwDiscMask)
        Me.grpDiscMask.Controls.Add(Me.btnApdDiscMask)
        Me.grpDiscMask.Controls.Add(Me.btnRstDiscMask)
        Me.grpDiscMask.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.grpDiscMask.ForeColor = System.Drawing.Color.White
        Me.grpDiscMask.Location = New System.Drawing.Point(12, 312)
        Me.grpDiscMask.Name = "grpDiscMask"
        Me.grpDiscMask.Size = New System.Drawing.Size(276, 72)
        Me.grpDiscMask.TabIndex = 7
        Me.grpDiscMask.TabStop = False
        Me.grpDiscMask.Text = "Discrete Mask"
        '
        'chkExpDiscMask
        '
        Me.chkExpDiscMask.AutoSize = True
        Me.chkExpDiscMask.Location = New System.Drawing.Point(168, 42)
        Me.chkExpDiscMask.Name = "chkExpDiscMask"
        Me.chkExpDiscMask.Size = New System.Drawing.Size(44, 18)
        Me.chkExpDiscMask.TabIndex = 3
        Me.chkExpDiscMask.Text = "Exp"
        Me.chkExpDiscMask.UseVisualStyleBackColor = True
        '
        'chkShwDiscMask
        '
        Me.chkShwDiscMask.AutoSize = True
        Me.chkShwDiscMask.Location = New System.Drawing.Point(168, 16)
        Me.chkShwDiscMask.Name = "chkShwDiscMask"
        Me.chkShwDiscMask.Size = New System.Drawing.Size(55, 18)
        Me.chkShwDiscMask.TabIndex = 2
        Me.chkShwDiscMask.Text = "Show"
        Me.chkShwDiscMask.UseVisualStyleBackColor = True
        '
        'btnApdDiscMask
        '
        Me.btnApdDiscMask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApdDiscMask.Location = New System.Drawing.Point(6, 22)
        Me.btnApdDiscMask.Name = "btnApdDiscMask"
        Me.btnApdDiscMask.Size = New System.Drawing.Size(70, 31)
        Me.btnApdDiscMask.TabIndex = 1
        Me.btnApdDiscMask.Text = "Append"
        Me.btnApdDiscMask.UseVisualStyleBackColor = True
        '
        'btnRstDiscMask
        '
        Me.btnRstDiscMask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRstDiscMask.Location = New System.Drawing.Point(81, 22)
        Me.btnRstDiscMask.Name = "btnRstDiscMask"
        Me.btnRstDiscMask.Size = New System.Drawing.Size(70, 31)
        Me.btnRstDiscMask.TabIndex = 0
        Me.btnRstDiscMask.Text = "Reset"
        Me.btnRstDiscMask.UseVisualStyleBackColor = True
        '
        'textEleQuery
        '
        Me.textEleQuery.BackColor = System.Drawing.Color.Gray
        Me.textEleQuery.Cursor = System.Windows.Forms.Cursors.Default
        Me.textEleQuery.ForeColor = System.Drawing.Color.White
        Me.textEleQuery.Location = New System.Drawing.Point(12, 390)
        Me.textEleQuery.MaxLength = 1000000
        Me.textEleQuery.Multiline = True
        Me.textEleQuery.Name = "textEleQuery"
        Me.textEleQuery.ReadOnly = True
        Me.textEleQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textEleQuery.Size = New System.Drawing.Size(276, 290)
        Me.textEleQuery.TabIndex = 6
        Me.textEleQuery.WordWrap = False
        '
        'grpCrop
        '
        Me.grpCrop.Controls.Add(Me.btnMaskReverse)
        Me.grpCrop.Controls.Add(Me.btnEleQuery)
        Me.grpCrop.Controls.Add(Me.btnCrop)
        Me.grpCrop.Controls.Add(Me.btnMaskCrop)
        Me.grpCrop.Controls.Add(Me.grpMaskShape)
        Me.grpCrop.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.grpCrop.ForeColor = System.Drawing.Color.White
        Me.grpCrop.Location = New System.Drawing.Point(12, 218)
        Me.grpCrop.Name = "grpCrop"
        Me.grpCrop.Size = New System.Drawing.Size(276, 88)
        Me.grpCrop.TabIndex = 5
        Me.grpCrop.TabStop = False
        Me.grpCrop.Text = "Crop the Assembly"
        '
        'btnMaskReverse
        '
        Me.btnMaskReverse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnMaskReverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaskReverse.Location = New System.Drawing.Point(81, 22)
        Me.btnMaskReverse.Name = "btnMaskReverse"
        Me.btnMaskReverse.Size = New System.Drawing.Size(70, 23)
        Me.btnMaskReverse.TabIndex = 7
        Me.btnMaskReverse.Text = "Reverse Mask"
        Me.btnMaskReverse.UseVisualStyleBackColor = True
        '
        'btnEleQuery
        '
        Me.btnEleQuery.Enabled = False
        Me.btnEleQuery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnEleQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEleQuery.ForeColor = System.Drawing.Color.White
        Me.btnEleQuery.Location = New System.Drawing.Point(81, 51)
        Me.btnEleQuery.Name = "btnEleQuery"
        Me.btnEleQuery.Size = New System.Drawing.Size(70, 23)
        Me.btnEleQuery.TabIndex = 6
        Me.btnEleQuery.Text = "Query"
        Me.btnEleQuery.UseVisualStyleBackColor = True
        '
        'btnCrop
        '
        Me.btnCrop.Enabled = False
        Me.btnCrop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnCrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrop.ForeColor = System.Drawing.Color.White
        Me.btnCrop.Location = New System.Drawing.Point(6, 51)
        Me.btnCrop.Name = "btnCrop"
        Me.btnCrop.Size = New System.Drawing.Size(70, 23)
        Me.btnCrop.TabIndex = 6
        Me.btnCrop.Text = "Crop"
        Me.btnCrop.UseVisualStyleBackColor = True
        '
        'btnMaskCrop
        '
        Me.btnMaskCrop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnMaskCrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaskCrop.Location = New System.Drawing.Point(6, 22)
        Me.btnMaskCrop.Name = "btnMaskCrop"
        Me.btnMaskCrop.Size = New System.Drawing.Size(70, 23)
        Me.btnMaskCrop.TabIndex = 5
        Me.btnMaskCrop.Text = "Create  Mask"
        Me.btnMaskCrop.UseVisualStyleBackColor = True
        '
        'grpMaskShape
        '
        Me.grpMaskShape.Controls.Add(Me.rbMaskRect)
        Me.grpMaskShape.Controls.Add(Me.rbMaskPoly)
        Me.grpMaskShape.Controls.Add(Me.rbMaskCircular)
        Me.grpMaskShape.Enabled = False
        Me.grpMaskShape.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpMaskShape.Location = New System.Drawing.Point(161, 12)
        Me.grpMaskShape.Name = "grpMaskShape"
        Me.grpMaskShape.Size = New System.Drawing.Size(107, 66)
        Me.grpMaskShape.TabIndex = 4
        Me.grpMaskShape.TabStop = False
        '
        'rbMaskRect
        '
        Me.rbMaskRect.AutoSize = True
        Me.rbMaskRect.Checked = True
        Me.rbMaskRect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbMaskRect.Location = New System.Drawing.Point(7, 9)
        Me.rbMaskRect.Name = "rbMaskRect"
        Me.rbMaskRect.Size = New System.Drawing.Size(72, 18)
        Me.rbMaskRect.TabIndex = 0
        Me.rbMaskRect.TabStop = True
        Me.rbMaskRect.Text = "Rectangle"
        Me.rbMaskRect.UseVisualStyleBackColor = True
        '
        'rbMaskPoly
        '
        Me.rbMaskPoly.AutoSize = True
        Me.rbMaskPoly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbMaskPoly.Location = New System.Drawing.Point(7, 43)
        Me.rbMaskPoly.Name = "rbMaskPoly"
        Me.rbMaskPoly.Size = New System.Drawing.Size(62, 18)
        Me.rbMaskPoly.TabIndex = 3
        Me.rbMaskPoly.Text = "Polygon"
        Me.rbMaskPoly.UseVisualStyleBackColor = True
        '
        'rbMaskCircular
        '
        Me.rbMaskCircular.AutoSize = True
        Me.rbMaskCircular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbMaskCircular.Location = New System.Drawing.Point(7, 25)
        Me.rbMaskCircular.Name = "rbMaskCircular"
        Me.rbMaskCircular.Size = New System.Drawing.Size(51, 18)
        Me.rbMaskCircular.TabIndex = 2
        Me.rbMaskCircular.Text = "Circle"
        Me.rbMaskCircular.UseVisualStyleBackColor = True
        '
        'grpEditOption
        '
        Me.grpEditOption.Controls.Add(Me.rbEleRomove)
        Me.grpEditOption.Controls.Add(Me.btnRemove)
        Me.grpEditOption.Controls.Add(Me.btnRotate)
        Me.grpEditOption.Controls.Add(Me.setAngRotate)
        Me.grpEditOption.Controls.Add(Me.setCAC)
        Me.grpEditOption.Controls.Add(Me.rbEleAdd)
        Me.grpEditOption.Controls.Add(Me.rbEleRotate)
        Me.grpEditOption.Controls.Add(Me.rbSampleRotate)
        Me.grpEditOption.Controls.Add(Me.rbEleCopy)
        Me.grpEditOption.Controls.Add(Me.rbEleShape)
        Me.grpEditOption.Controls.Add(Me.rbEleMove)
        Me.grpEditOption.Controls.Add(Me.rbView)
        Me.grpEditOption.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.grpEditOption.ForeColor = System.Drawing.Color.White
        Me.grpEditOption.Location = New System.Drawing.Point(12, 5)
        Me.grpEditOption.Name = "grpEditOption"
        Me.grpEditOption.Size = New System.Drawing.Size(276, 210)
        Me.grpEditOption.TabIndex = 4
        Me.grpEditOption.TabStop = False
        Me.grpEditOption.Text = "ElementEdit Options"
        '
        'rbEleRomove
        '
        Me.rbEleRomove.AutoSize = True
        Me.rbEleRomove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbEleRomove.Location = New System.Drawing.Point(6, 180)
        Me.rbEleRomove.Name = "rbEleRomove"
        Me.rbEleRomove.Size = New System.Drawing.Size(103, 18)
        Me.rbEleRomove.TabIndex = 8
        Me.rbEleRomove.TabStop = True
        Me.rbEleRomove.Text = "Remove Element"
        Me.rbEleRomove.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Enabled = False
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(206, 180)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(58, 23)
        Me.btnRemove.TabIndex = 7
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnRotate
        '
        Me.btnRotate.Enabled = False
        Me.btnRotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRotate.ForeColor = System.Drawing.Color.White
        Me.btnRotate.Location = New System.Drawing.Point(206, 144)
        Me.btnRotate.Name = "btnRotate"
        Me.btnRotate.Size = New System.Drawing.Size(58, 23)
        Me.btnRotate.TabIndex = 6
        Me.btnRotate.Text = "Rotate"
        Me.btnRotate.UseVisualStyleBackColor = True
        '
        'setAngRotate
        '
        Me.setAngRotate.BackColor = System.Drawing.Color.DimGray
        Me.setAngRotate.DecimalPlaces = 1
        Me.setAngRotate.Enabled = False
        Me.setAngRotate.ForeColor = System.Drawing.Color.White
        Me.setAngRotate.Location = New System.Drawing.Point(127, 145)
        Me.setAngRotate.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.setAngRotate.Minimum = New Decimal(New Integer() {180, 0, 0, -2147483648})
        Me.setAngRotate.Name = "setAngRotate"
        Me.setAngRotate.Size = New System.Drawing.Size(72, 20)
        Me.setAngRotate.TabIndex = 5
        Me.setAngRotate.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'setCAC
        '
        Me.setCAC.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound
        Me.setCAC.BackColor = System.Drawing.Color.DimGray
        Me.setCAC.DecimalPlaces = 3
        Me.setCAC.Enabled = False
        Me.setCAC.ForeColor = System.Drawing.Color.White
        Me.setCAC.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.setCAC.Location = New System.Drawing.Point(127, 65)
        Me.setCAC.Maximum = New Decimal(New Integer() {314, 0, 0, 131072})
        Me.setCAC.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.setCAC.Name = "setCAC"
        Me.setCAC.Size = New System.Drawing.Size(72, 20)
        Me.setCAC.TabIndex = 4
        Me.setCAC.Value = New Decimal(New Integer() {2, 0, 0, 65536})
        '
        'rbEleAdd
        '
        Me.rbEleAdd.AutoSize = True
        Me.rbEleAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbEleAdd.Location = New System.Drawing.Point(6, 88)
        Me.rbEleAdd.Name = "rbEleAdd"
        Me.rbEleAdd.Size = New System.Drawing.Size(108, 18)
        Me.rbEleAdd.TabIndex = 0
        Me.rbEleAdd.TabStop = True
        Me.rbEleAdd.Text = "Add New Particle"
        Me.rbEleAdd.UseVisualStyleBackColor = True
        '
        'rbEleRotate
        '
        Me.rbEleRotate.AutoSize = True
        Me.rbEleRotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbEleRotate.Location = New System.Drawing.Point(6, 134)
        Me.rbEleRotate.Name = "rbEleRotate"
        Me.rbEleRotate.Size = New System.Drawing.Size(95, 18)
        Me.rbEleRotate.TabIndex = 0
        Me.rbEleRotate.TabStop = True
        Me.rbEleRotate.Text = "Rotate Element"
        Me.rbEleRotate.UseVisualStyleBackColor = True
        '
        'rbSampleRotate
        '
        Me.rbSampleRotate.AutoSize = True
        Me.rbSampleRotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbSampleRotate.Location = New System.Drawing.Point(6, 157)
        Me.rbSampleRotate.Name = "rbSampleRotate"
        Me.rbSampleRotate.Size = New System.Drawing.Size(93, 18)
        Me.rbSampleRotate.TabIndex = 0
        Me.rbSampleRotate.TabStop = True
        Me.rbSampleRotate.Text = "Rotate Sample"
        Me.rbSampleRotate.UseVisualStyleBackColor = True
        '
        'rbEleCopy
        '
        Me.rbEleCopy.AutoSize = True
        Me.rbEleCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbEleCopy.Location = New System.Drawing.Point(6, 111)
        Me.rbEleCopy.Name = "rbEleCopy"
        Me.rbEleCopy.Size = New System.Drawing.Size(87, 18)
        Me.rbEleCopy.TabIndex = 0
        Me.rbEleCopy.TabStop = True
        Me.rbEleCopy.Text = "Copy Particle"
        Me.rbEleCopy.UseVisualStyleBackColor = True
        '
        'rbEleShape
        '
        Me.rbEleShape.AutoSize = True
        Me.rbEleShape.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbEleShape.Location = New System.Drawing.Point(6, 65)
        Me.rbEleShape.Name = "rbEleShape"
        Me.rbEleShape.Size = New System.Drawing.Size(75, 18)
        Me.rbEleShape.TabIndex = 0
        Me.rbEleShape.TabStop = True
        Me.rbEleShape.Text = "Edit Shape"
        Me.rbEleShape.UseVisualStyleBackColor = True
        '
        'rbEleMove
        '
        Me.rbEleMove.AutoSize = True
        Me.rbEleMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbEleMove.Location = New System.Drawing.Point(6, 42)
        Me.rbEleMove.Name = "rbEleMove"
        Me.rbEleMove.Size = New System.Drawing.Size(88, 18)
        Me.rbEleMove.TabIndex = 0
        Me.rbEleMove.TabStop = True
        Me.rbEleMove.Text = "Move Particle"
        Me.rbEleMove.UseVisualStyleBackColor = True
        '
        'rbView
        '
        Me.rbView.AutoSize = True
        Me.rbView.Checked = True
        Me.rbView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbView.Location = New System.Drawing.Point(6, 19)
        Me.rbView.Name = "rbView"
        Me.rbView.Size = New System.Drawing.Size(50, 18)
        Me.rbView.TabIndex = 0
        Me.rbView.TabStop = True
        Me.rbView.Text = "View"
        Me.rbView.UseVisualStyleBackColor = True
        '
        'tabPost
        '
        Me.tabPost.AutoScroll = True
        Me.tabPost.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tabPost.Controls.Add(Me.grpGridDeform)
        Me.tabPost.Controls.Add(Me.groupPtclMotion)
        Me.tabPost.Controls.Add(Me.groupPostMode)
        Me.tabPost.Controls.Add(Me.btnOpenResult)
        Me.tabPost.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.tabPost.ForeColor = System.Drawing.Color.White
        Me.tabPost.Location = New System.Drawing.Point(4, 82)
        Me.tabPost.Name = "tabPost"
        Me.tabPost.Size = New System.Drawing.Size(301, 689)
        Me.tabPost.TabIndex = 4
        Me.tabPost.Text = "Postprocess"
        Me.tabPost.UseVisualStyleBackColor = True
        '
        'grpGridDeform
        '
        Me.grpGridDeform.Controls.Add(Me.Label15)
        Me.grpGridDeform.Controls.Add(Me.rbDyeBand)
        Me.grpGridDeform.Controls.Add(Me.rbDyeGrid)
        Me.grpGridDeform.Controls.Add(Me.rbGridLine)
        Me.grpGridDeform.Controls.Add(Me.setDyeDark)
        Me.grpGridDeform.Controls.Add(Me.setIntvlDye)
        Me.grpGridDeform.Controls.Add(Me.setAngDye)
        Me.grpGridDeform.Controls.Add(Me.Label31)
        Me.grpGridDeform.Controls.Add(Me.setNumGD)
        Me.grpGridDeform.Controls.Add(Me.btnNewGD)
        Me.grpGridDeform.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpGridDeform.Font = New System.Drawing.Font("Arial", 7.854546!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGridDeform.ForeColor = System.Drawing.Color.White
        Me.grpGridDeform.Location = New System.Drawing.Point(8, 614)
        Me.grpGridDeform.Name = "grpGridDeform"
        Me.grpGridDeform.Size = New System.Drawing.Size(286, 99)
        Me.grpGridDeform.TabIndex = 4
        Me.grpGridDeform.TabStop = False
        Me.grpGridDeform.Text = "Grid Deformation"
        Me.grpGridDeform.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 52)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 14)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "BandAng"
        '
        'rbDyeBand
        '
        Me.rbDyeBand.AutoSize = True
        Me.rbDyeBand.Location = New System.Drawing.Point(9, 75)
        Me.rbDyeBand.Name = "rbDyeBand"
        Me.rbDyeBand.Size = New System.Drawing.Size(72, 18)
        Me.rbDyeBand.TabIndex = 9
        Me.rbDyeBand.Text = "Dye Band"
        Me.rbDyeBand.UseVisualStyleBackColor = True
        '
        'rbDyeGrid
        '
        Me.rbDyeGrid.AutoSize = True
        Me.rbDyeGrid.Location = New System.Drawing.Point(103, 75)
        Me.rbDyeGrid.Name = "rbDyeGrid"
        Me.rbDyeGrid.Size = New System.Drawing.Size(67, 18)
        Me.rbDyeGrid.TabIndex = 8
        Me.rbDyeGrid.Text = "Dye Grid"
        Me.rbDyeGrid.UseVisualStyleBackColor = True
        '
        'rbGridLine
        '
        Me.rbGridLine.AutoSize = True
        Me.rbGridLine.Checked = True
        Me.rbGridLine.Location = New System.Drawing.Point(195, 75)
        Me.rbGridLine.Name = "rbGridLine"
        Me.rbGridLine.Size = New System.Drawing.Size(68, 18)
        Me.rbGridLine.TabIndex = 7
        Me.rbGridLine.TabStop = True
        Me.rbGridLine.Text = "Grid Line"
        Me.rbGridLine.UseVisualStyleBackColor = True
        '
        'setDyeDark
        '
        Me.setDyeDark.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.setDyeDark.ForeColor = System.Drawing.Color.White
        Me.setDyeDark.Location = New System.Drawing.Point(215, 48)
        Me.setDyeDark.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.setDyeDark.Name = "setDyeDark"
        Me.setDyeDark.Size = New System.Drawing.Size(64, 20)
        Me.setDyeDark.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.setDyeDark, "Grayscale of the dark bands. 0-black; 255-white.")
        Me.setDyeDark.Value = New Decimal(New Integer() {128, 0, 0, 0})
        '
        'setIntvlDye
        '
        Me.setIntvlDye.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.setIntvlDye.DecimalPlaces = 4
        Me.setIntvlDye.ForeColor = System.Drawing.Color.White
        Me.setIntvlDye.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.setIntvlDye.Location = New System.Drawing.Point(134, 48)
        Me.setIntvlDye.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.setIntvlDye.Name = "setIntvlDye"
        Me.setIntvlDye.Size = New System.Drawing.Size(71, 20)
        Me.setIntvlDye.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.setIntvlDye, "Widths of the bands.")
        Me.setIntvlDye.Value = New Decimal(New Integer() {1, 0, 0, 196608})
        '
        'setAngDye
        '
        Me.setAngDye.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.setAngDye.ForeColor = System.Drawing.Color.White
        Me.setAngDye.Location = New System.Drawing.Point(70, 48)
        Me.setAngDye.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.setAngDye.Name = "setAngDye"
        Me.setAngDye.Size = New System.Drawing.Size(55, 20)
        Me.setAngDye.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.setAngDye, "Angle of the band")
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(129, 23)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(66, 14)
        Me.Label31.TabIndex = 2
        Me.Label31.Text = "Grid Density"
        '
        'setNumGD
        '
        Me.setNumGD.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.setNumGD.ForeColor = System.Drawing.Color.White
        Me.setNumGD.Location = New System.Drawing.Point(215, 19)
        Me.setNumGD.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.setNumGD.Name = "setNumGD"
        Me.setNumGD.Size = New System.Drawing.Size(64, 20)
        Me.setNumGD.TabIndex = 1
        Me.setNumGD.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'btnNewGD
        '
        Me.btnNewGD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnNewGD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewGD.Location = New System.Drawing.Point(8, 17)
        Me.btnNewGD.Name = "btnNewGD"
        Me.btnNewGD.Size = New System.Drawing.Size(119, 24)
        Me.btnNewGD.TabIndex = 0
        Me.btnNewGD.Text = "New Grid"
        Me.btnNewGD.UseVisualStyleBackColor = True
        '
        'groupPtclMotion
        '
        Me.groupPtclMotion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.groupPtclMotion.Controls.Add(Me.chkLockIStepJStep)
        Me.groupPtclMotion.Controls.Add(Me.showJStep)
        Me.groupPtclMotion.Controls.Add(Me.gbShowSlideTrace)
        Me.groupPtclMotion.Controls.Add(Me.GroupBox3)
        Me.groupPtclMotion.Controls.Add(Me.Label32)
        Me.groupPtclMotion.Controls.Add(Me.trackStateB)
        Me.groupPtclMotion.Controls.Add(Me.GroupBox4)
        Me.groupPtclMotion.Font = New System.Drawing.Font("Arial", 7.854546!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupPtclMotion.ForeColor = System.Drawing.Color.White
        Me.groupPtclMotion.Location = New System.Drawing.Point(9, 129)
        Me.groupPtclMotion.Name = "groupPtclMotion"
        Me.groupPtclMotion.Size = New System.Drawing.Size(286, 479)
        Me.groupPtclMotion.TabIndex = 3
        Me.groupPtclMotion.TabStop = False
        Me.groupPtclMotion.Text = "Particle Motion"
        Me.groupPtclMotion.Visible = False
        '
        'chkLockIStepJStep
        '
        Me.chkLockIStepJStep.AutoSize = True
        Me.chkLockIStepJStep.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkLockIStepJStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkLockIStepJStep.Location = New System.Drawing.Point(213, 40)
        Me.chkLockIStepJStep.Name = "chkLockIStepJStep"
        Me.chkLockIStepJStep.Size = New System.Drawing.Size(58, 18)
        Me.chkLockIStepJStep.TabIndex = 15
        Me.chkLockIStepJStep.Text = "Locked"
        Me.chkLockIStepJStep.UseVisualStyleBackColor = True
        '
        'showJStep
        '
        Me.showJStep.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.showJStep.AutoSize = True
        Me.showJStep.Location = New System.Drawing.Point(255, 12)
        Me.showJStep.Name = "showJStep"
        Me.showJStep.Size = New System.Drawing.Size(13, 14)
        Me.showJStep.TabIndex = 14
        Me.showJStep.Text = "0"
        '
        'gbShowSlideTrace
        '
        Me.gbShowSlideTrace.Controls.Add(Me.chkShowRollingTrace)
        Me.gbShowSlideTrace.Controls.Add(Me.chkShowSldTrace)
        Me.gbShowSlideTrace.Enabled = False
        Me.gbShowSlideTrace.Location = New System.Drawing.Point(7, 147)
        Me.gbShowSlideTrace.Name = "gbShowSlideTrace"
        Me.gbShowSlideTrace.Size = New System.Drawing.Size(273, 41)
        Me.gbShowSlideTrace.TabIndex = 13
        Me.gbShowSlideTrace.TabStop = False
        '
        'chkShowRollingTrace
        '
        Me.chkShowRollingTrace.AutoSize = True
        Me.chkShowRollingTrace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowRollingTrace.Location = New System.Drawing.Point(137, 18)
        Me.chkShowRollingTrace.Name = "chkShowRollingTrace"
        Me.chkShowRollingTrace.Size = New System.Drawing.Size(85, 18)
        Me.chkShowRollingTrace.TabIndex = 1
        Me.chkShowRollingTrace.Text = "Rolling Trace"
        Me.chkShowRollingTrace.UseVisualStyleBackColor = True
        '
        'chkShowSldTrace
        '
        Me.chkShowSldTrace.AutoSize = True
        Me.chkShowSldTrace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowSldTrace.Location = New System.Drawing.Point(5, 18)
        Me.chkShowSldTrace.Name = "chkShowSldTrace"
        Me.chkShowSldTrace.Size = New System.Drawing.Size(85, 18)
        Me.chkShowSldTrace.TabIndex = 0
        Me.chkShowSldTrace.Text = "Sliding Trace"
        Me.chkShowSldTrace.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbContourCoordNum)
        Me.GroupBox3.Controls.Add(Me.setRefOri)
        Me.GroupBox3.Controls.Add(Me.rbRelaOri)
        Me.GroupBox3.Controls.Add(Me.rbContourOri)
        Me.GroupBox3.Controls.Add(Me.GroupBox7)
        Me.GroupBox3.Controls.Add(Me.rbContourXY)
        Me.GroupBox3.Controls.Add(Me.rbContourYY)
        Me.GroupBox3.Controls.Add(Me.rbContourXX)
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.rbCountorBulk)
        Me.GroupBox3.Controls.Add(Me.rbContourShear)
        Me.GroupBox3.Controls.Add(Me.GroupBox10)
        Me.GroupBox3.Controls.Add(Me.setRelaMin)
        Me.GroupBox3.Controls.Add(Me.setRelaMax)
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.containerContourRange)
        Me.GroupBox3.Controls.Add(Me.rbContourH)
        Me.GroupBox3.Controls.Add(Me.rbContourU)
        Me.GroupBox3.Controls.Add(Me.rbContourR)
        Me.GroupBox3.Controls.Add(Me.rbContourV)
        Me.GroupBox3.Controls.Add(Me.chkDefContour)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 189)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(274, 279)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        '
        'rbContourCoordNum
        '
        Me.rbContourCoordNum.AutoSize = True
        Me.rbContourCoordNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbContourCoordNum.Location = New System.Drawing.Point(8, 111)
        Me.rbContourCoordNum.Name = "rbContourCoordNum"
        Me.rbContourCoordNum.Size = New System.Drawing.Size(83, 18)
        Me.rbContourCoordNum.TabIndex = 22
        Me.rbContourCoordNum.TabStop = True
        Me.rbContourCoordNum.Text = "Coord. Num."
        Me.rbContourCoordNum.UseVisualStyleBackColor = True
        '
        'setRefOri
        '
        Me.setRefOri.Location = New System.Drawing.Point(145, 106)
        Me.setRefOri.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.setRefOri.Name = "setRefOri"
        Me.setRefOri.Size = New System.Drawing.Size(44, 20)
        Me.setRefOri.TabIndex = 21
        '
        'rbRelaOri
        '
        Me.rbRelaOri.AutoSize = True
        Me.rbRelaOri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbRelaOri.Location = New System.Drawing.Point(195, 105)
        Me.rbRelaOri.Name = "rbRelaOri"
        Me.rbRelaOri.Size = New System.Drawing.Size(59, 18)
        Me.rbRelaOri.TabIndex = 20
        Me.rbRelaOri.TabStop = True
        Me.rbRelaOri.Text = "RelaOri"
        Me.rbRelaOri.UseVisualStyleBackColor = True
        '
        'rbContourOri
        '
        Me.rbContourOri.AutoSize = True
        Me.rbContourOri.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbContourOri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbContourOri.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.rbContourOri.Location = New System.Drawing.Point(240, 14)
        Me.rbContourOri.Name = "rbContourOri"
        Me.rbContourOri.Size = New System.Drawing.Size(25, 29)
        Me.rbContourOri.TabIndex = 19
        Me.rbContourOri.TabStop = True
        Me.rbContourOri.Text = "Ori"
        Me.rbContourOri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbContourOri.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.rbModeForce)
        Me.GroupBox7.Controls.Add(Me.rbModeStress)
        Me.GroupBox7.Location = New System.Drawing.Point(66, 46)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(63, 59)
        Me.GroupBox7.TabIndex = 18
        Me.GroupBox7.TabStop = False
        '
        'rbModeForce
        '
        Me.rbModeForce.AutoSize = True
        Me.rbModeForce.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbModeForce.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.rbModeForce.Location = New System.Drawing.Point(6, 29)
        Me.rbModeForce.Name = "rbModeForce"
        Me.rbModeForce.Size = New System.Drawing.Size(50, 17)
        Me.rbModeForce.TabIndex = 1
        Me.rbModeForce.Text = "Force"
        Me.rbModeForce.UseVisualStyleBackColor = True
        '
        'rbModeStress
        '
        Me.rbModeStress.AutoSize = True
        Me.rbModeStress.Checked = True
        Me.rbModeStress.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbModeStress.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.rbModeStress.Location = New System.Drawing.Point(6, 11)
        Me.rbModeStress.Name = "rbModeStress"
        Me.rbModeStress.Size = New System.Drawing.Size(51, 17)
        Me.rbModeStress.TabIndex = 0
        Me.rbModeStress.TabStop = True
        Me.rbModeStress.Text = "Stress"
        Me.rbModeStress.UseVisualStyleBackColor = True
        '
        'rbContourXY
        '
        Me.rbContourXY.AutoSize = True
        Me.rbContourXY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbContourXY.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.rbContourXY.Location = New System.Drawing.Point(231, 80)
        Me.rbContourXY.Name = "rbContourXY"
        Me.rbContourXY.Size = New System.Drawing.Size(38, 17)
        Me.rbContourXY.TabIndex = 17
        Me.rbContourXY.TabStop = True
        Me.rbContourXY.Text = "XY"
        Me.rbContourXY.UseVisualStyleBackColor = True
        '
        'rbContourYY
        '
        Me.rbContourYY.AutoSize = True
        Me.rbContourYY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbContourYY.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.rbContourYY.Location = New System.Drawing.Point(181, 80)
        Me.rbContourYY.Name = "rbContourYY"
        Me.rbContourYY.Size = New System.Drawing.Size(38, 17)
        Me.rbContourYY.TabIndex = 16
        Me.rbContourYY.TabStop = True
        Me.rbContourYY.Text = "YY"
        Me.rbContourYY.UseVisualStyleBackColor = True
        '
        'rbContourXX
        '
        Me.rbContourXX.AutoSize = True
        Me.rbContourXX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbContourXX.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.rbContourXX.Location = New System.Drawing.Point(134, 80)
        Me.rbContourXX.Name = "rbContourXX"
        Me.rbContourXX.Size = New System.Drawing.Size(38, 17)
        Me.rbContourXX.TabIndex = 15
        Me.rbContourXX.TabStop = True
        Me.rbContourXX.Text = "XX"
        Me.rbContourXX.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rbBlack)
        Me.GroupBox6.Controls.Add(Me.rbGray)
        Me.GroupBox6.Controls.Add(Me.rbColor)
        Me.GroupBox6.Location = New System.Drawing.Point(4, 35)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(62, 70)
        Me.GroupBox6.TabIndex = 14
        Me.GroupBox6.TabStop = False
        '
        'rbBlack
        '
        Me.rbBlack.AutoSize = True
        Me.rbBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbBlack.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.rbBlack.Location = New System.Drawing.Point(4, 44)
        Me.rbBlack.Name = "rbBlack"
        Me.rbBlack.Size = New System.Drawing.Size(54, 17)
        Me.rbBlack.TabIndex = 2
        Me.rbBlack.TabStop = True
        Me.rbBlack.Text = "All Blk"
        Me.rbBlack.UseVisualStyleBackColor = True
        '
        'rbGray
        '
        Me.rbGray.AutoSize = True
        Me.rbGray.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbGray.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.rbGray.Location = New System.Drawing.Point(4, 27)
        Me.rbGray.Name = "rbGray"
        Me.rbGray.Size = New System.Drawing.Size(46, 17)
        Me.rbGray.TabIndex = 1
        Me.rbGray.Text = "Gray"
        Me.rbGray.UseVisualStyleBackColor = True
        '
        'rbColor
        '
        Me.rbColor.AutoSize = True
        Me.rbColor.Checked = True
        Me.rbColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbColor.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.rbColor.Location = New System.Drawing.Point(4, 11)
        Me.rbColor.Name = "rbColor"
        Me.rbColor.Size = New System.Drawing.Size(49, 17)
        Me.rbColor.TabIndex = 0
        Me.rbColor.TabStop = True
        Me.rbColor.Text = "Color"
        Me.rbColor.UseVisualStyleBackColor = True
        '
        'rbCountorBulk
        '
        Me.rbCountorBulk.AutoSize = True
        Me.rbCountorBulk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbCountorBulk.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.rbCountorBulk.Location = New System.Drawing.Point(134, 55)
        Me.rbCountorBulk.Name = "rbCountorBulk"
        Me.rbCountorBulk.Size = New System.Drawing.Size(44, 17)
        Me.rbCountorBulk.TabIndex = 13
        Me.rbCountorBulk.TabStop = True
        Me.rbCountorBulk.Text = "Bulk"
        Me.rbCountorBulk.UseVisualStyleBackColor = True
        '
        'rbContourShear
        '
        Me.rbContourShear.AutoSize = True
        Me.rbContourShear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbContourShear.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.rbContourShear.Location = New System.Drawing.Point(193, 55)
        Me.rbContourShear.Name = "rbContourShear"
        Me.rbContourShear.Size = New System.Drawing.Size(75, 17)
        Me.rbContourShear.TabIndex = 12
        Me.rbContourShear.TabStop = True
        Me.rbContourShear.Text = "Max Shear"
        Me.rbContourShear.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.chkMode1)
        Me.GroupBox10.Controls.Add(Me.chkMode0)
        Me.GroupBox10.Location = New System.Drawing.Point(6, 216)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(132, 56)
        Me.GroupBox10.TabIndex = 11
        Me.GroupBox10.TabStop = False
        '
        'chkMode1
        '
        Me.chkMode1.AutoSize = True
        Me.chkMode1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkMode1.Location = New System.Drawing.Point(8, 34)
        Me.chkMode1.Name = "chkMode1"
        Me.chkMode1.Size = New System.Drawing.Size(85, 18)
        Me.chkMode1.TabIndex = 1
        Me.chkMode1.Text = "Static Range"
        Me.chkMode1.UseVisualStyleBackColor = True
        '
        'chkMode0
        '
        Me.chkMode0.AutoSize = True
        Me.chkMode0.Checked = True
        Me.chkMode0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkMode0.Location = New System.Drawing.Point(8, 11)
        Me.chkMode0.Name = "chkMode0"
        Me.chkMode0.Size = New System.Drawing.Size(99, 18)
        Me.chkMode0.TabIndex = 0
        Me.chkMode0.TabStop = True
        Me.chkMode0.Text = "Dynamic Range"
        Me.chkMode0.UseVisualStyleBackColor = True
        '
        'setRelaMin
        '
        Me.setRelaMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.setRelaMin.DecimalPlaces = 6
        Me.setRelaMin.Enabled = False
        Me.setRelaMin.ForeColor = System.Drawing.Color.White
        Me.setRelaMin.Location = New System.Drawing.Point(177, 224)
        Me.setRelaMin.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.setRelaMin.Minimum = New Decimal(New Integer() {-727379968, 232, 0, -2147483648})
        Me.setRelaMin.Name = "setRelaMin"
        Me.setRelaMin.Size = New System.Drawing.Size(93, 20)
        Me.setRelaMin.TabIndex = 10
        '
        'setRelaMax
        '
        Me.setRelaMax.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.setRelaMax.DecimalPlaces = 6
        Me.setRelaMax.Enabled = False
        Me.setRelaMax.ForeColor = System.Drawing.Color.White
        Me.setRelaMax.Location = New System.Drawing.Point(177, 251)
        Me.setRelaMax.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        Me.setRelaMax.Minimum = New Decimal(New Integer() {1410065408, 2, 0, -2147483648})
        Me.setRelaMax.Name = "setRelaMax"
        Me.setRelaMax.Size = New System.Drawing.Size(92, 20)
        Me.setRelaMax.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(3, 190)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(262, 25)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'containerContourRange
        '
        Me.containerContourRange.ColumnCount = 1
        Me.containerContourRange.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.containerContourRange.Controls.Add(Me.lowContourRange, 0, 0)
        Me.containerContourRange.Controls.Add(Me.upContourRange, 0, 1)
        Me.containerContourRange.Location = New System.Drawing.Point(5, 130)
        Me.containerContourRange.Name = "containerContourRange"
        Me.containerContourRange.RowCount = 2
        Me.containerContourRange.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.containerContourRange.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.containerContourRange.Size = New System.Drawing.Size(262, 56)
        Me.containerContourRange.TabIndex = 5
        '
        'lowContourRange
        '
        Me.lowContourRange.AutoSize = False
        Me.lowContourRange.Location = New System.Drawing.Point(3, 3)
        Me.lowContourRange.Maximum = 500
        Me.lowContourRange.Minimum = -500
        Me.lowContourRange.Name = "lowContourRange"
        Me.lowContourRange.Size = New System.Drawing.Size(250, 22)
        Me.lowContourRange.TabIndex = 6
        Me.lowContourRange.TickStyle = System.Windows.Forms.TickStyle.None
        Me.lowContourRange.Value = -500
        '
        'upContourRange
        '
        Me.upContourRange.AutoSize = False
        Me.upContourRange.Location = New System.Drawing.Point(3, 31)
        Me.upContourRange.Maximum = 500
        Me.upContourRange.Minimum = -500
        Me.upContourRange.Name = "upContourRange"
        Me.upContourRange.Size = New System.Drawing.Size(250, 22)
        Me.upContourRange.TabIndex = 5
        Me.upContourRange.TickStyle = System.Windows.Forms.TickStyle.None
        Me.upContourRange.Value = 500
        '
        'rbContourH
        '
        Me.rbContourH.AutoSize = True
        Me.rbContourH.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbContourH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbContourH.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.rbContourH.Location = New System.Drawing.Point(131, 14)
        Me.rbContourH.Name = "rbContourH"
        Me.rbContourH.Size = New System.Drawing.Size(18, 29)
        Me.rbContourH.TabIndex = 4
        Me.rbContourH.Text = "H"
        Me.rbContourH.UseVisualStyleBackColor = True
        '
        'rbContourU
        '
        Me.rbContourU.AutoSize = True
        Me.rbContourU.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbContourU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbContourU.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.rbContourU.Location = New System.Drawing.Point(185, 14)
        Me.rbContourU.Name = "rbContourU"
        Me.rbContourU.Size = New System.Drawing.Size(18, 29)
        Me.rbContourU.TabIndex = 3
        Me.rbContourU.Text = "U"
        Me.rbContourU.UseVisualStyleBackColor = True
        '
        'rbContourR
        '
        Me.rbContourR.AutoSize = True
        Me.rbContourR.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbContourR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbContourR.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.rbContourR.Location = New System.Drawing.Point(214, 14)
        Me.rbContourR.Name = "rbContourR"
        Me.rbContourR.Size = New System.Drawing.Size(18, 29)
        Me.rbContourR.TabIndex = 2
        Me.rbContourR.Text = "R"
        Me.rbContourR.UseVisualStyleBackColor = True
        '
        'rbContourV
        '
        Me.rbContourV.AutoSize = True
        Me.rbContourV.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbContourV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbContourV.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.rbContourV.Location = New System.Drawing.Point(159, 14)
        Me.rbContourV.Name = "rbContourV"
        Me.rbContourV.Size = New System.Drawing.Size(18, 29)
        Me.rbContourV.TabIndex = 1
        Me.rbContourV.Text = "V"
        Me.rbContourV.UseVisualStyleBackColor = True
        '
        'chkDefContour
        '
        Me.chkDefContour.AutoSize = True
        Me.chkDefContour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDefContour.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDefContour.ForeColor = System.Drawing.Color.Gold
        Me.chkDefContour.Location = New System.Drawing.Point(6, 13)
        Me.chkDefContour.Name = "chkDefContour"
        Me.chkDefContour.Size = New System.Drawing.Size(103, 20)
        Me.chkDefContour.TabIndex = 0
        Me.chkDefContour.Text = "Def. Contour"
        Me.chkDefContour.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(86, 42)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(86, 14)
        Me.Label32.TabIndex = 11
        Me.Label32.Text = "Reference State"
        '
        'trackStateB
        '
        Me.trackStateB.AutoSize = False
        Me.trackStateB.Enabled = False
        Me.trackStateB.Location = New System.Drawing.Point(3, 21)
        Me.trackStateB.Name = "trackStateB"
        Me.trackStateB.Size = New System.Drawing.Size(277, 38)
        Me.trackStateB.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.setStepSparse)
        Me.GroupBox4.Controls.Add(Me.chkColorTrace)
        Me.GroupBox4.Controls.Add(Me.rbV)
        Me.GroupBox4.Controls.Add(Me.rbH)
        Me.GroupBox4.Controls.Add(Me.chkShowTrace)
        Me.GroupBox4.Controls.Add(Me.chkShowRotation)
        Me.GroupBox4.Controls.Add(Me.btnRotationScaleUp)
        Me.GroupBox4.Controls.Add(Me.btnRotationScaleDown)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 53)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(273, 94)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(140, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 14)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Sparse"
        '
        'setStepSparse
        '
        Me.setStepSparse.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.setStepSparse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.setStepSparse.ForeColor = System.Drawing.Color.White
        Me.setStepSparse.Location = New System.Drawing.Point(195, 13)
        Me.setStepSparse.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.setStepSparse.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.setStepSparse.Name = "setStepSparse"
        Me.setStepSparse.Size = New System.Drawing.Size(68, 20)
        Me.setStepSparse.TabIndex = 10
        Me.setStepSparse.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'chkColorTrace
        '
        Me.chkColorTrace.AutoSize = True
        Me.chkColorTrace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkColorTrace.Location = New System.Drawing.Point(82, 40)
        Me.chkColorTrace.Name = "chkColorTrace"
        Me.chkColorTrace.Size = New System.Drawing.Size(79, 18)
        Me.chkColorTrace.TabIndex = 7
        Me.chkColorTrace.Text = "Color Trace"
        Me.chkColorTrace.UseVisualStyleBackColor = True
        '
        'rbV
        '
        Me.rbV.AutoSize = True
        Me.rbV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbV.Location = New System.Drawing.Point(235, 39)
        Me.rbV.Name = "rbV"
        Me.rbV.Size = New System.Drawing.Size(32, 18)
        Me.rbV.TabIndex = 9
        Me.rbV.Text = "V"
        Me.rbV.UseVisualStyleBackColor = True
        '
        'rbH
        '
        Me.rbH.AutoSize = True
        Me.rbH.Checked = True
        Me.rbH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbH.Location = New System.Drawing.Point(195, 40)
        Me.rbH.Name = "rbH"
        Me.rbH.Size = New System.Drawing.Size(31, 18)
        Me.rbH.TabIndex = 8
        Me.rbH.TabStop = True
        Me.rbH.Text = "H"
        Me.rbH.UseVisualStyleBackColor = True
        '
        'chkShowTrace
        '
        Me.chkShowTrace.AutoSize = True
        Me.chkShowTrace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowTrace.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowTrace.ForeColor = System.Drawing.Color.Gold
        Me.chkShowTrace.Location = New System.Drawing.Point(5, 11)
        Me.chkShowTrace.Name = "chkShowTrace"
        Me.chkShowTrace.Size = New System.Drawing.Size(99, 20)
        Me.chkShowTrace.TabIndex = 5
        Me.chkShowTrace.Text = "Show Trace"
        Me.chkShowTrace.UseVisualStyleBackColor = True
        '
        'chkShowRotation
        '
        Me.chkShowRotation.AutoSize = True
        Me.chkShowRotation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowRotation.Location = New System.Drawing.Point(81, 65)
        Me.chkShowRotation.Name = "chkShowRotation"
        Me.chkShowRotation.Size = New System.Drawing.Size(94, 18)
        Me.chkShowRotation.TabIndex = 6
        Me.chkShowRotation.Text = "Show Rotation"
        Me.chkShowRotation.UseVisualStyleBackColor = True
        '
        'btnRotationScaleUp
        '
        Me.btnRotationScaleUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnRotationScaleUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRotationScaleUp.Font = New System.Drawing.Font("Arial", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRotationScaleUp.Location = New System.Drawing.Point(238, 63)
        Me.btnRotationScaleUp.Name = "btnRotationScaleUp"
        Me.btnRotationScaleUp.Size = New System.Drawing.Size(25, 25)
        Me.btnRotationScaleUp.TabIndex = 1
        Me.btnRotationScaleUp.Text = "+"
        Me.btnRotationScaleUp.UseVisualStyleBackColor = True
        '
        'btnRotationScaleDown
        '
        Me.btnRotationScaleDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnRotationScaleDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRotationScaleDown.Font = New System.Drawing.Font("Arial", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRotationScaleDown.Location = New System.Drawing.Point(196, 63)
        Me.btnRotationScaleDown.Name = "btnRotationScaleDown"
        Me.btnRotationScaleDown.Size = New System.Drawing.Size(25, 25)
        Me.btnRotationScaleDown.TabIndex = 2
        Me.btnRotationScaleDown.Text = "-"
        Me.btnRotationScaleDown.UseVisualStyleBackColor = True
        '
        'groupPostMode
        '
        Me.groupPostMode.Controls.Add(Me.chkHideElement2)
        Me.groupPostMode.Controls.Add(Me.modeVR)
        Me.groupPostMode.Controls.Add(Me.modeGD)
        Me.groupPostMode.Controls.Add(Me.modeMotion)
        Me.groupPostMode.Font = New System.Drawing.Font("Arial", 7.854546!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupPostMode.ForeColor = System.Drawing.Color.White
        Me.groupPostMode.Location = New System.Drawing.Point(9, 56)
        Me.groupPostMode.Name = "groupPostMode"
        Me.groupPostMode.Size = New System.Drawing.Size(286, 67)
        Me.groupPostMode.TabIndex = 2
        Me.groupPostMode.TabStop = False
        Me.groupPostMode.Text = "Mode"
        '
        'chkHideElement2
        '
        Me.chkHideElement2.AutoSize = True
        Me.chkHideElement2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkHideElement2.Location = New System.Drawing.Point(145, 43)
        Me.chkHideElement2.Name = "chkHideElement2"
        Me.chkHideElement2.Size = New System.Drawing.Size(84, 18)
        Me.chkHideElement2.TabIndex = 104
        Me.chkHideElement2.Text = "Hide Element"
        Me.chkHideElement2.UseVisualStyleBackColor = True
        '
        'modeVR
        '
        Me.modeVR.AutoSize = True
        Me.modeVR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modeVR.Location = New System.Drawing.Point(7, 44)
        Me.modeVR.Name = "modeVR"
        Me.modeVR.Size = New System.Drawing.Size(71, 18)
        Me.modeVR.TabIndex = 7
        Me.modeVR.Text = "Void Ratio"
        Me.modeVR.UseVisualStyleBackColor = True
        '
        'modeGD
        '
        Me.modeGD.AutoSize = True
        Me.modeGD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modeGD.Location = New System.Drawing.Point(145, 19)
        Me.modeGD.Name = "modeGD"
        Me.modeGD.Size = New System.Drawing.Size(104, 18)
        Me.modeGD.TabIndex = 6
        Me.modeGD.Text = "Grid Deformation"
        Me.modeGD.UseVisualStyleBackColor = True
        '
        'modeMotion
        '
        Me.modeMotion.AutoSize = True
        Me.modeMotion.Enabled = False
        Me.modeMotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modeMotion.Location = New System.Drawing.Point(7, 19)
        Me.modeMotion.Name = "modeMotion"
        Me.modeMotion.Size = New System.Drawing.Size(89, 18)
        Me.modeMotion.TabIndex = 5
        Me.modeMotion.Text = "Particle Trace"
        Me.modeMotion.UseVisualStyleBackColor = True
        '
        'btnOpenResult
        '
        Me.btnOpenResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOpenResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnOpenResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenResult.Location = New System.Drawing.Point(9, 15)
        Me.btnOpenResult.Name = "btnOpenResult"
        Me.btnOpenResult.Size = New System.Drawing.Size(286, 35)
        Me.btnOpenResult.TabIndex = 1
        Me.btnOpenResult.Text = "Open Results"
        Me.btnOpenResult.UseVisualStyleBackColor = False
        '
        'tabStrain
        '
        Me.tabStrain.AutoScroll = True
        Me.tabStrain.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tabStrain.Controls.Add(Me.chkExpWallPosition)
        Me.tabStrain.Controls.Add(Me.btnMaskCell)
        Me.tabStrain.Controls.Add(Me.gbShowStnDrct)
        Me.tabStrain.Controls.Add(Me.gbStnMode)
        Me.tabStrain.Controls.Add(Me.gbCellMode)
        Me.tabStrain.Controls.Add(Me.btnAllAct)
        Me.tabStrain.Controls.Add(Me.btnResetCell)
        Me.tabStrain.Controls.Add(Me.btnStrnTrack)
        Me.tabStrain.Controls.Add(Me.btnExpCellStrn)
        Me.tabStrain.Controls.Add(Me.btnClearActCell)
        Me.tabStrain.Controls.Add(Me.chkAddActCell)
        Me.tabStrain.Controls.Add(Me.chkShwStrnVal)
        Me.tabStrain.Controls.Add(Me.setValLegend)
        Me.tabStrain.Controls.Add(Me.chkShowStnLegend)
        Me.tabStrain.Controls.Add(Me.setStnContrast)
        Me.tabStrain.Controls.Add(Me.Label14)
        Me.tabStrain.Controls.Add(Me.chkLgthStrn)
        Me.tabStrain.Controls.Add(Me.btnStnDrctScaleDown)
        Me.tabStrain.Controls.Add(Me.btnStnDrctScaleUp)
        Me.tabStrain.Controls.Add(Me.chkShowStnDrct)
        Me.tabStrain.Controls.Add(Me.gbPickStnSign)
        Me.tabStrain.Controls.Add(Me.GroupBox9)
        Me.tabStrain.Controls.Add(Me.btnStnScaleDown)
        Me.tabStrain.Controls.Add(Me.btnStnScaleUp)
        Me.tabStrain.Controls.Add(Me.chkShowStrain)
        Me.tabStrain.Controls.Add(Me.chkShowCell)
        Me.tabStrain.Controls.Add(Me.setNumCell)
        Me.tabStrain.Controls.Add(Me.Label12)
        Me.tabStrain.Controls.Add(Me.Label11)
        Me.tabStrain.Controls.Add(Me.setRdStnCell)
        Me.tabStrain.Controls.Add(Me.btnIniStnCell)
        Me.tabStrain.ForeColor = System.Drawing.Color.White
        Me.tabStrain.Location = New System.Drawing.Point(4, 82)
        Me.tabStrain.Name = "tabStrain"
        Me.tabStrain.Size = New System.Drawing.Size(301, 689)
        Me.tabStrain.TabIndex = 5
        Me.tabStrain.Text = "Strain"
        Me.tabStrain.UseVisualStyleBackColor = True
        '
        'chkExpWallPosition
        '
        Me.chkExpWallPosition.AutoSize = True
        Me.chkExpWallPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkExpWallPosition.Location = New System.Drawing.Point(9, 597)
        Me.chkExpWallPosition.Name = "chkExpWallPosition"
        Me.chkExpWallPosition.Size = New System.Drawing.Size(118, 19)
        Me.chkExpWallPosition.TabIndex = 32
        Me.chkExpWallPosition.Text = "Exp Wall Position"
        Me.chkExpWallPosition.UseVisualStyleBackColor = True
        '
        'btnMaskCell
        '
        Me.btnMaskCell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaskCell.Location = New System.Drawing.Point(126, 88)
        Me.btnMaskCell.Name = "btnMaskCell"
        Me.btnMaskCell.Size = New System.Drawing.Size(59, 26)
        Me.btnMaskCell.TabIndex = 31
        Me.btnMaskCell.Text = "Mask"
        Me.btnMaskCell.UseVisualStyleBackColor = True
        '
        'gbShowStnDrct
        '
        Me.gbShowStnDrct.Controls.Add(Me.rbDrctMaxShear)
        Me.gbShowStnDrct.Controls.Add(Me.rbDrctStnXX)
        Me.gbShowStnDrct.Controls.Add(Me.rbDrctShearFlow)
        Me.gbShowStnDrct.Controls.Add(Me.rbDrctStnII)
        Me.gbShowStnDrct.Controls.Add(Me.rbDrctStnI)
        Me.gbShowStnDrct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbShowStnDrct.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.gbShowStnDrct.ForeColor = System.Drawing.Color.White
        Me.gbShowStnDrct.Location = New System.Drawing.Point(9, 473)
        Me.gbShowStnDrct.Name = "gbShowStnDrct"
        Me.gbShowStnDrct.Size = New System.Drawing.Size(272, 67)
        Me.gbShowStnDrct.TabIndex = 30
        Me.gbShowStnDrct.TabStop = False
        Me.gbShowStnDrct.Text = "Show Direction"
        '
        'rbDrctMaxShear
        '
        Me.rbDrctMaxShear.AutoSize = True
        Me.rbDrctMaxShear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbDrctMaxShear.Location = New System.Drawing.Point(97, 44)
        Me.rbDrctMaxShear.Name = "rbDrctMaxShear"
        Me.rbDrctMaxShear.Size = New System.Drawing.Size(108, 18)
        Me.rbDrctMaxShear.TabIndex = 4
        Me.rbDrctMaxShear.TabStop = True
        Me.rbDrctMaxShear.Text = "Strain-Max Shear"
        Me.rbDrctMaxShear.UseVisualStyleBackColor = True
        '
        'rbDrctStnXX
        '
        Me.rbDrctStnXX.AutoSize = True
        Me.rbDrctStnXX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbDrctStnXX.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.rbDrctStnXX.Location = New System.Drawing.Point(207, 20)
        Me.rbDrctStnXX.Name = "rbDrctStnXX"
        Me.rbDrctStnXX.Size = New System.Drawing.Size(42, 18)
        Me.rbDrctStnXX.TabIndex = 3
        Me.rbDrctStnXX.Text = "X'X'"
        Me.rbDrctStnXX.UseVisualStyleBackColor = True
        '
        'rbDrctShearFlow
        '
        Me.rbDrctShearFlow.AutoSize = True
        Me.rbDrctShearFlow.Checked = True
        Me.rbDrctShearFlow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbDrctShearFlow.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.rbDrctShearFlow.Location = New System.Drawing.Point(97, 19)
        Me.rbDrctShearFlow.Name = "rbDrctShearFlow"
        Me.rbDrctShearFlow.Size = New System.Drawing.Size(80, 18)
        Me.rbDrctShearFlow.TabIndex = 2
        Me.rbDrctShearFlow.TabStop = True
        Me.rbDrctShearFlow.Text = "Shear Flow"
        Me.rbDrctShearFlow.UseVisualStyleBackColor = True
        '
        'rbDrctStnII
        '
        Me.rbDrctStnII.AutoSize = True
        Me.rbDrctStnII.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbDrctStnII.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.rbDrctStnII.Location = New System.Drawing.Point(16, 44)
        Me.rbDrctStnII.Name = "rbDrctStnII"
        Me.rbDrctStnII.Size = New System.Drawing.Size(60, 18)
        Me.rbDrctStnII.TabIndex = 1
        Me.rbDrctStnII.Text = "Strain-II"
        Me.rbDrctStnII.UseVisualStyleBackColor = True
        '
        'rbDrctStnI
        '
        Me.rbDrctStnI.AutoSize = True
        Me.rbDrctStnI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbDrctStnI.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.rbDrctStnI.Location = New System.Drawing.Point(16, 20)
        Me.rbDrctStnI.Name = "rbDrctStnI"
        Me.rbDrctStnI.Size = New System.Drawing.Size(58, 18)
        Me.rbDrctStnI.TabIndex = 0
        Me.rbDrctStnI.Text = "Strain-I"
        Me.rbDrctStnI.UseVisualStyleBackColor = True
        '
        'gbStnMode
        '
        Me.gbStnMode.Controls.Add(Me.rbModeStnRate)
        Me.gbStnMode.Controls.Add(Me.rbModeStnInc)
        Me.gbStnMode.Location = New System.Drawing.Point(162, 118)
        Me.gbStnMode.Name = "gbStnMode"
        Me.gbStnMode.Size = New System.Drawing.Size(132, 53)
        Me.gbStnMode.TabIndex = 29
        Me.gbStnMode.TabStop = False
        '
        'rbModeStnRate
        '
        Me.rbModeStnRate.AutoSize = True
        Me.rbModeStnRate.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.rbModeStnRate.Location = New System.Drawing.Point(7, 30)
        Me.rbModeStnRate.Name = "rbModeStnRate"
        Me.rbModeStnRate.Size = New System.Drawing.Size(78, 18)
        Me.rbModeStnRate.TabIndex = 1
        Me.rbModeStnRate.Text = "Strain Rate"
        Me.rbModeStnRate.UseVisualStyleBackColor = True
        '
        'rbModeStnInc
        '
        Me.rbModeStnInc.AutoSize = True
        Me.rbModeStnInc.Checked = True
        Me.rbModeStnInc.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.rbModeStnInc.Location = New System.Drawing.Point(7, 11)
        Me.rbModeStnInc.Name = "rbModeStnInc"
        Me.rbModeStnInc.Size = New System.Drawing.Size(70, 18)
        Me.rbModeStnInc.TabIndex = 0
        Me.rbModeStnInc.TabStop = True
        Me.rbModeStnInc.Text = "Strain Inc"
        Me.rbModeStnInc.UseVisualStyleBackColor = True
        '
        'gbCellMode
        '
        Me.gbCellMode.Controls.Add(Me.rbDelauany)
        Me.gbCellMode.Controls.Add(Me.rbHomoTri)
        Me.gbCellMode.Location = New System.Drawing.Point(9, 118)
        Me.gbCellMode.Name = "gbCellMode"
        Me.gbCellMode.Size = New System.Drawing.Size(142, 53)
        Me.gbCellMode.TabIndex = 28
        Me.gbCellMode.TabStop = False
        '
        'rbDelauany
        '
        Me.rbDelauany.AutoSize = True
        Me.rbDelauany.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.rbDelauany.Location = New System.Drawing.Point(15, 30)
        Me.rbDelauany.Name = "rbDelauany"
        Me.rbDelauany.Size = New System.Drawing.Size(70, 18)
        Me.rbDelauany.TabIndex = 1
        Me.rbDelauany.Text = "Delaunay"
        Me.rbDelauany.UseVisualStyleBackColor = True
        '
        'rbHomoTri
        '
        Me.rbHomoTri.AutoSize = True
        Me.rbHomoTri.Checked = True
        Me.rbHomoTri.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.rbHomoTri.Location = New System.Drawing.Point(15, 11)
        Me.rbHomoTri.Name = "rbHomoTri"
        Me.rbHomoTri.Size = New System.Drawing.Size(87, 18)
        Me.rbHomoTri.TabIndex = 0
        Me.rbHomoTri.TabStop = True
        Me.rbHomoTri.Text = "Hom Triangle"
        Me.rbHomoTri.UseVisualStyleBackColor = True
        '
        'btnAllAct
        '
        Me.btnAllAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAllAct.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.btnAllAct.Location = New System.Drawing.Point(68, 88)
        Me.btnAllAct.Name = "btnAllAct"
        Me.btnAllAct.Size = New System.Drawing.Size(52, 26)
        Me.btnAllAct.TabIndex = 27
        Me.btnAllAct.Text = "SltAll"
        Me.btnAllAct.UseVisualStyleBackColor = True
        '
        'btnResetCell
        '
        Me.btnResetCell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetCell.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.btnResetCell.Location = New System.Drawing.Point(9, 54)
        Me.btnResetCell.Name = "btnResetCell"
        Me.btnResetCell.Size = New System.Drawing.Size(142, 26)
        Me.btnResetCell.TabIndex = 26
        Me.btnResetCell.Text = "Reset Cells"
        Me.btnResetCell.UseVisualStyleBackColor = True
        '
        'btnStrnTrack
        '
        Me.btnStrnTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStrnTrack.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.btnStrnTrack.Location = New System.Drawing.Point(9, 568)
        Me.btnStrnTrack.Name = "btnStrnTrack"
        Me.btnStrnTrack.Size = New System.Drawing.Size(75, 23)
        Me.btnStrnTrack.TabIndex = 25
        Me.btnStrnTrack.Text = "Track"
        Me.btnStrnTrack.UseVisualStyleBackColor = True
        '
        'btnExpCellStrn
        '
        Me.btnExpCellStrn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpCellStrn.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.btnExpCellStrn.Location = New System.Drawing.Point(240, 88)
        Me.btnExpCellStrn.Name = "btnExpCellStrn"
        Me.btnExpCellStrn.Size = New System.Drawing.Size(54, 26)
        Me.btnExpCellStrn.TabIndex = 24
        Me.btnExpCellStrn.Text = "Expo"
        Me.btnExpCellStrn.UseVisualStyleBackColor = True
        '
        'btnClearActCell
        '
        Me.btnClearActCell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearActCell.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.btnClearActCell.Location = New System.Drawing.Point(190, 88)
        Me.btnClearActCell.Name = "btnClearActCell"
        Me.btnClearActCell.Size = New System.Drawing.Size(49, 26)
        Me.btnClearActCell.TabIndex = 23
        Me.btnClearActCell.Text = "Clear"
        Me.btnClearActCell.UseVisualStyleBackColor = True
        '
        'chkAddActCell
        '
        Me.chkAddActCell.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkAddActCell.AutoSize = True
        Me.chkAddActCell.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkAddActCell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkAddActCell.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.chkAddActCell.Location = New System.Drawing.Point(9, 88)
        Me.chkAddActCell.Name = "chkAddActCell"
        Me.chkAddActCell.Size = New System.Drawing.Size(50, 24)
        Me.chkAddActCell.TabIndex = 22
        Me.chkAddActCell.Text = " AdAct"
        Me.chkAddActCell.UseVisualStyleBackColor = True
        '
        'chkShwStrnVal
        '
        Me.chkShwStrnVal.AutoSize = True
        Me.chkShwStrnVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShwStrnVal.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.chkShwStrnVal.Location = New System.Drawing.Point(8, 291)
        Me.chkShwStrnVal.Name = "chkShwStrnVal"
        Me.chkShwStrnVal.Size = New System.Drawing.Size(50, 18)
        Me.chkShwStrnVal.TabIndex = 21
        Me.chkShwStrnVal.Text = "Value"
        Me.chkShwStrnVal.UseVisualStyleBackColor = True
        '
        'setValLegend
        '
        Me.setValLegend.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.setValLegend.DecimalPlaces = 8
        Me.setValLegend.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.setValLegend.ForeColor = System.Drawing.Color.White
        Me.setValLegend.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.setValLegend.Location = New System.Drawing.Point(195, 292)
        Me.setValLegend.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.setValLegend.Name = "setValLegend"
        Me.setValLegend.Size = New System.Drawing.Size(98, 20)
        Me.setValLegend.TabIndex = 20
        Me.setValLegend.Value = New Decimal(New Integer() {1, 0, 0, 196608})
        '
        'chkShowStnLegend
        '
        Me.chkShowStnLegend.AutoSize = True
        Me.chkShowStnLegend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowStnLegend.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.chkShowStnLegend.Location = New System.Drawing.Point(97, 290)
        Me.chkShowStnLegend.Name = "chkShowStnLegend"
        Me.chkShowStnLegend.Size = New System.Drawing.Size(59, 18)
        Me.chkShowStnLegend.TabIndex = 19
        Me.chkShowStnLegend.Text = "Legend"
        Me.chkShowStnLegend.UseVisualStyleBackColor = True
        '
        'setStnContrast
        '
        Me.setStnContrast.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.setStnContrast.DecimalPlaces = 1
        Me.setStnContrast.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.setStnContrast.ForeColor = System.Drawing.Color.White
        Me.setStnContrast.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.setStnContrast.Location = New System.Drawing.Point(206, 213)
        Me.setStnContrast.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.setStnContrast.Name = "setStnContrast"
        Me.setStnContrast.Size = New System.Drawing.Size(42, 20)
        Me.setStnContrast.TabIndex = 18
        Me.setStnContrast.Value = New Decimal(New Integer() {5, 0, 0, 65536})
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Label14.Location = New System.Drawing.Point(153, 214)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 14)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Contrast"
        '
        'chkLgthStrn
        '
        Me.chkLgthStrn.AutoSize = True
        Me.chkLgthStrn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkLgthStrn.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.chkLgthStrn.Location = New System.Drawing.Point(155, 253)
        Me.chkLgthStrn.Name = "chkLgthStrn"
        Me.chkLgthStrn.Size = New System.Drawing.Size(56, 18)
        Me.chkLgthStrn.TabIndex = 14
        Me.chkLgthStrn.Text = "Length"
        Me.chkLgthStrn.UseVisualStyleBackColor = True
        '
        'btnStnDrctScaleDown
        '
        Me.btnStnDrctScaleDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStnDrctScaleDown.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.btnStnDrctScaleDown.Location = New System.Drawing.Point(97, 250)
        Me.btnStnDrctScaleDown.Name = "btnStnDrctScaleDown"
        Me.btnStnDrctScaleDown.Size = New System.Drawing.Size(26, 23)
        Me.btnStnDrctScaleDown.TabIndex = 13
        Me.btnStnDrctScaleDown.Text = "-"
        Me.btnStnDrctScaleDown.UseVisualStyleBackColor = True
        '
        'btnStnDrctScaleUp
        '
        Me.btnStnDrctScaleUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStnDrctScaleUp.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.btnStnDrctScaleUp.Location = New System.Drawing.Point(125, 250)
        Me.btnStnDrctScaleUp.Name = "btnStnDrctScaleUp"
        Me.btnStnDrctScaleUp.Size = New System.Drawing.Size(26, 23)
        Me.btnStnDrctScaleUp.TabIndex = 12
        Me.btnStnDrctScaleUp.Text = "+"
        Me.btnStnDrctScaleUp.UseVisualStyleBackColor = True
        '
        'chkShowStnDrct
        '
        Me.chkShowStnDrct.AutoSize = True
        Me.chkShowStnDrct.Enabled = False
        Me.chkShowStnDrct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowStnDrct.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.chkShowStnDrct.Location = New System.Drawing.Point(8, 253)
        Me.chkShowStnDrct.Name = "chkShowStnDrct"
        Me.chkShowStnDrct.Size = New System.Drawing.Size(75, 18)
        Me.chkShowStnDrct.TabIndex = 11
        Me.chkShowStnDrct.Text = "Show Drct"
        Me.chkShowStnDrct.UseVisualStyleBackColor = True
        '
        'gbPickStnSign
        '
        Me.gbPickStnSign.Controls.Add(Me.rbShowBothStn)
        Me.gbPickStnSign.Controls.Add(Me.rbShowNegStn)
        Me.gbPickStnSign.Controls.Add(Me.rbShowPosiStn)
        Me.gbPickStnSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbPickStnSign.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.gbPickStnSign.Location = New System.Drawing.Point(254, 201)
        Me.gbPickStnSign.Name = "gbPickStnSign"
        Me.gbPickStnSign.Size = New System.Drawing.Size(40, 85)
        Me.gbPickStnSign.TabIndex = 10
        Me.gbPickStnSign.TabStop = False
        '
        'rbShowBothStn
        '
        Me.rbShowBothStn.AutoSize = True
        Me.rbShowBothStn.Checked = True
        Me.rbShowBothStn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbShowBothStn.Location = New System.Drawing.Point(6, 10)
        Me.rbShowBothStn.Name = "rbShowBothStn"
        Me.rbShowBothStn.Size = New System.Drawing.Size(34, 18)
        Me.rbShowBothStn.TabIndex = 2
        Me.rbShowBothStn.TabStop = True
        Me.rbShowBothStn.Text = "+-"
        Me.rbShowBothStn.UseVisualStyleBackColor = True
        '
        'rbShowNegStn
        '
        Me.rbShowNegStn.AutoSize = True
        Me.rbShowNegStn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbShowNegStn.Location = New System.Drawing.Point(6, 60)
        Me.rbShowNegStn.Name = "rbShowNegStn"
        Me.rbShowNegStn.Size = New System.Drawing.Size(28, 18)
        Me.rbShowNegStn.TabIndex = 1
        Me.rbShowNegStn.TabStop = True
        Me.rbShowNegStn.Text = "-"
        Me.rbShowNegStn.UseVisualStyleBackColor = True
        '
        'rbShowPosiStn
        '
        Me.rbShowPosiStn.AutoSize = True
        Me.rbShowPosiStn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbShowPosiStn.Location = New System.Drawing.Point(6, 35)
        Me.rbShowPosiStn.Name = "rbShowPosiStn"
        Me.rbShowPosiStn.Size = New System.Drawing.Size(30, 18)
        Me.rbShowPosiStn.TabIndex = 0
        Me.rbShowPosiStn.TabStop = True
        Me.rbShowPosiStn.Text = "+"
        Me.rbShowPosiStn.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.rbSpinTensor)
        Me.GroupBox9.Controls.Add(Me.rbShearFlowRate)
        Me.GroupBox9.Controls.Add(Me.rbStrainXYN)
        Me.GroupBox9.Controls.Add(Me.rbStrainN)
        Me.GroupBox9.Controls.Add(Me.Label13)
        Me.GroupBox9.Controls.Add(Me.setAngN)
        Me.GroupBox9.Controls.Add(Me.rbStrainXYMax)
        Me.GroupBox9.Controls.Add(Me.rbStrainII)
        Me.GroupBox9.Controls.Add(Me.rbStrainI)
        Me.GroupBox9.Controls.Add(Me.rbStrainXY)
        Me.GroupBox9.Controls.Add(Me.rbStrainYY)
        Me.GroupBox9.Controls.Add(Me.rbStrainXX)
        Me.GroupBox9.Controls.Add(Me.rbStrainV)
        Me.GroupBox9.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.GroupBox9.ForeColor = System.Drawing.Color.White
        Me.GroupBox9.Location = New System.Drawing.Point(8, 316)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(273, 151)
        Me.GroupBox9.TabIndex = 9
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Show Magnitude"
        '
        'rbSpinTensor
        '
        Me.rbSpinTensor.AutoSize = True
        Me.rbSpinTensor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbSpinTensor.Location = New System.Drawing.Point(17, 123)
        Me.rbSpinTensor.Name = "rbSpinTensor"
        Me.rbSpinTensor.Size = New System.Drawing.Size(45, 18)
        Me.rbSpinTensor.TabIndex = 18
        Me.rbSpinTensor.TabStop = True
        Me.rbSpinTensor.Text = "Spin"
        Me.rbSpinTensor.UseVisualStyleBackColor = True
        '
        'rbShearFlowRate
        '
        Me.rbShearFlowRate.AutoSize = True
        Me.rbShearFlowRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbShearFlowRate.Location = New System.Drawing.Point(98, 71)
        Me.rbShearFlowRate.Name = "rbShearFlowRate"
        Me.rbShearFlowRate.Size = New System.Drawing.Size(77, 18)
        Me.rbShearFlowRate.TabIndex = 17
        Me.rbShearFlowRate.TabStop = True
        Me.rbShearFlowRate.Text = "ShearFlow"
        Me.rbShearFlowRate.UseVisualStyleBackColor = True
        '
        'rbStrainXYN
        '
        Me.rbStrainXYN.AutoSize = True
        Me.rbStrainXYN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbStrainXYN.Location = New System.Drawing.Point(98, 96)
        Me.rbStrainXYN.Name = "rbStrainXYN"
        Me.rbStrainXYN.Size = New System.Drawing.Size(75, 18)
        Me.rbStrainXYN.TabIndex = 8
        Me.rbStrainXYN.TabStop = True
        Me.rbStrainXYN.Text = "Strain-X'Y'"
        Me.rbStrainXYN.UseVisualStyleBackColor = True
        '
        'rbStrainN
        '
        Me.rbStrainN.AutoSize = True
        Me.rbStrainN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbStrainN.Location = New System.Drawing.Point(17, 96)
        Me.rbStrainN.Name = "rbStrainN"
        Me.rbStrainN.Size = New System.Drawing.Size(70, 18)
        Me.rbStrainN.TabIndex = 7
        Me.rbStrainN.TabStop = True
        Me.rbStrainN.Text = "StrainX'X'"
        Me.rbStrainN.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(195, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 14)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "X'X'"
        '
        'setAngN
        '
        Me.setAngN.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.setAngN.DecimalPlaces = 1
        Me.setAngN.ForeColor = System.Drawing.Color.White
        Me.setAngN.Location = New System.Drawing.Point(194, 96)
        Me.setAngN.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.setAngN.Name = "setAngN"
        Me.setAngN.Size = New System.Drawing.Size(70, 20)
        Me.setAngN.TabIndex = 16
        '
        'rbStrainXYMax
        '
        Me.rbStrainXYMax.AutoSize = True
        Me.rbStrainXYMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbStrainXYMax.Location = New System.Drawing.Point(16, 71)
        Me.rbStrainXYMax.Name = "rbStrainXYMax"
        Me.rbStrainXYMax.Size = New System.Drawing.Size(73, 18)
        Me.rbStrainXYMax.TabIndex = 6
        Me.rbStrainXYMax.TabStop = True
        Me.rbStrainXYMax.Text = "MaxShear"
        Me.rbStrainXYMax.UseVisualStyleBackColor = True
        '
        'rbStrainII
        '
        Me.rbStrainII.AutoSize = True
        Me.rbStrainII.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbStrainII.Location = New System.Drawing.Point(182, 20)
        Me.rbStrainII.Name = "rbStrainII"
        Me.rbStrainII.Size = New System.Drawing.Size(60, 18)
        Me.rbStrainII.TabIndex = 5
        Me.rbStrainII.TabStop = True
        Me.rbStrainII.Text = "Strain-II"
        Me.rbStrainII.UseVisualStyleBackColor = True
        '
        'rbStrainI
        '
        Me.rbStrainI.AutoSize = True
        Me.rbStrainI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbStrainI.Location = New System.Drawing.Point(98, 20)
        Me.rbStrainI.Name = "rbStrainI"
        Me.rbStrainI.Size = New System.Drawing.Size(58, 18)
        Me.rbStrainI.TabIndex = 4
        Me.rbStrainI.TabStop = True
        Me.rbStrainI.Text = "Strain-I"
        Me.rbStrainI.UseVisualStyleBackColor = True
        '
        'rbStrainXY
        '
        Me.rbStrainXY.AutoSize = True
        Me.rbStrainXY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbStrainXY.Location = New System.Drawing.Point(182, 45)
        Me.rbStrainXY.Name = "rbStrainXY"
        Me.rbStrainXY.Size = New System.Drawing.Size(71, 18)
        Me.rbStrainXY.TabIndex = 3
        Me.rbStrainXY.TabStop = True
        Me.rbStrainXY.Text = "Strain-XY"
        Me.rbStrainXY.UseVisualStyleBackColor = True
        '
        'rbStrainYY
        '
        Me.rbStrainYY.AutoSize = True
        Me.rbStrainYY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbStrainYY.Location = New System.Drawing.Point(98, 45)
        Me.rbStrainYY.Name = "rbStrainYY"
        Me.rbStrainYY.Size = New System.Drawing.Size(72, 18)
        Me.rbStrainYY.TabIndex = 2
        Me.rbStrainYY.TabStop = True
        Me.rbStrainYY.Text = "Strain-YY"
        Me.rbStrainYY.UseVisualStyleBackColor = True
        '
        'rbStrainXX
        '
        Me.rbStrainXX.AutoSize = True
        Me.rbStrainXX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbStrainXX.Location = New System.Drawing.Point(16, 46)
        Me.rbStrainXX.Name = "rbStrainXX"
        Me.rbStrainXX.Size = New System.Drawing.Size(70, 18)
        Me.rbStrainXX.TabIndex = 1
        Me.rbStrainXX.TabStop = True
        Me.rbStrainXX.Text = "Strain-XX"
        Me.rbStrainXX.UseVisualStyleBackColor = True
        '
        'rbStrainV
        '
        Me.rbStrainV.AutoSize = True
        Me.rbStrainV.Checked = True
        Me.rbStrainV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbStrainV.Location = New System.Drawing.Point(16, 20)
        Me.rbStrainV.Name = "rbStrainV"
        Me.rbStrainV.Size = New System.Drawing.Size(64, 18)
        Me.rbStrainV.TabIndex = 0
        Me.rbStrainV.TabStop = True
        Me.rbStrainV.Text = "Strain-V"
        Me.rbStrainV.UseVisualStyleBackColor = True
        '
        'btnStnScaleDown
        '
        Me.btnStnScaleDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStnScaleDown.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.btnStnScaleDown.Location = New System.Drawing.Point(97, 213)
        Me.btnStnScaleDown.Name = "btnStnScaleDown"
        Me.btnStnScaleDown.Size = New System.Drawing.Size(26, 23)
        Me.btnStnScaleDown.TabIndex = 8
        Me.btnStnScaleDown.Text = "-"
        Me.btnStnScaleDown.UseVisualStyleBackColor = True
        '
        'btnStnScaleUp
        '
        Me.btnStnScaleUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStnScaleUp.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.btnStnScaleUp.Location = New System.Drawing.Point(125, 213)
        Me.btnStnScaleUp.Name = "btnStnScaleUp"
        Me.btnStnScaleUp.Size = New System.Drawing.Size(26, 23)
        Me.btnStnScaleUp.TabIndex = 7
        Me.btnStnScaleUp.Text = "+"
        Me.btnStnScaleUp.UseVisualStyleBackColor = True
        '
        'chkShowStrain
        '
        Me.chkShowStrain.AutoSize = True
        Me.chkShowStrain.Enabled = False
        Me.chkShowStrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowStrain.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.chkShowStrain.Location = New System.Drawing.Point(8, 213)
        Me.chkShowStrain.Name = "chkShowStrain"
        Me.chkShowStrain.Size = New System.Drawing.Size(83, 18)
        Me.chkShowStrain.TabIndex = 6
        Me.chkShowStrain.Text = "Show Strain"
        Me.chkShowStrain.UseVisualStyleBackColor = True
        '
        'chkShowCell
        '
        Me.chkShowCell.AutoSize = True
        Me.chkShowCell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowCell.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.chkShowCell.Location = New System.Drawing.Point(8, 189)
        Me.chkShowCell.Name = "chkShowCell"
        Me.chkShowCell.Size = New System.Drawing.Size(72, 18)
        Me.chkShowCell.TabIndex = 5
        Me.chkShowCell.Text = "Show Cell"
        Me.chkShowCell.UseVisualStyleBackColor = True
        '
        'setNumCell
        '
        Me.setNumCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.setNumCell.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.setNumCell.ForeColor = System.Drawing.Color.White
        Me.setNumCell.Location = New System.Drawing.Point(216, 55)
        Me.setNumCell.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.setNumCell.Name = "setNumCell"
        Me.setNumCell.Size = New System.Drawing.Size(78, 20)
        Me.setNumCell.TabIndex = 4
        Me.setNumCell.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Label12.Location = New System.Drawing.Point(154, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 14)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Cell Dens."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Label11.Location = New System.Drawing.Point(154, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 14)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Cell Size"
        '
        'setRdStnCell
        '
        Me.setRdStnCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.setRdStnCell.DecimalPlaces = 6
        Me.setRdStnCell.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.setRdStnCell.ForeColor = System.Drawing.Color.White
        Me.setRdStnCell.Location = New System.Drawing.Point(216, 20)
        Me.setRdStnCell.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.setRdStnCell.Name = "setRdStnCell"
        Me.setRdStnCell.Size = New System.Drawing.Size(78, 20)
        Me.setRdStnCell.TabIndex = 1
        Me.setRdStnCell.Value = New Decimal(New Integer() {1, 0, 0, 196608})
        '
        'btnIniStnCell
        '
        Me.btnIniStnCell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnIniStnCell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniStnCell.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.btnIniStnCell.Location = New System.Drawing.Point(9, 20)
        Me.btnIniStnCell.Name = "btnIniStnCell"
        Me.btnIniStnCell.Size = New System.Drawing.Size(142, 26)
        Me.btnIniStnCell.TabIndex = 0
        Me.btnIniStnCell.Text = "Auto Cells"
        Me.btnIniStnCell.UseVisualStyleBackColor = True
        '
        'tabCellFabric
        '
        Me.tabCellFabric.AutoScroll = True
        Me.tabCellFabric.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tabCellFabric.Controls.Add(Me.gbStressRotation)
        Me.tabCellFabric.Controls.Add(Me.chkExpVVTs)
        Me.tabCellFabric.Controls.Add(Me.chkShowVCFabric)
        Me.tabCellFabric.Controls.Add(Me.chkShowVoidVector)
        Me.tabCellFabric.Controls.Add(Me.chkShowVCBound)
        Me.tabCellFabric.Controls.Add(Me.chkShowVCNum)
        Me.tabCellFabric.Controls.Add(Me.chkExtVC)
        Me.tabCellFabric.Controls.Add(Me.chkShowDualCelll)
        Me.tabCellFabric.Controls.Add(Me.chkShowEdgeNum)
        Me.tabCellFabric.Controls.Add(Me.chkShowSolidCell)
        Me.tabCellFabric.Controls.Add(Me.setCellOpacity)
        Me.tabCellFabric.Controls.Add(Me.chkShowCellNum)
        Me.tabCellFabric.Controls.Add(Me.chkShowEffEdge)
        Me.tabCellFabric.Controls.Add(Me.rbShowCrctCell)
        Me.tabCellFabric.Controls.Add(Me.rbShowOriCell)
        Me.tabCellFabric.Controls.Add(Me.chkShowContNum)
        Me.tabCellFabric.Controls.Add(Me.chkShowCellInEle)
        Me.tabCellFabric.Controls.Add(Me.btnIniCellInEle)
        Me.tabCellFabric.ForeColor = System.Drawing.Color.White
        Me.tabCellFabric.Location = New System.Drawing.Point(4, 82)
        Me.tabCellFabric.Name = "tabCellFabric"
        Me.tabCellFabric.Size = New System.Drawing.Size(301, 689)
        Me.tabCellFabric.TabIndex = 6
        Me.tabCellFabric.Text = "CellFabric"
        Me.tabCellFabric.UseVisualStyleBackColor = True
        '
        'gbStressRotation
        '
        Me.gbStressRotation.Controls.Add(Me.setStressRotationRate)
        Me.gbStressRotation.Controls.Add(Me.Label41)
        Me.gbStressRotation.Controls.Add(Me.btnOpenAngFile)
        Me.gbStressRotation.Controls.Add(Me.setPStressAng)
        Me.gbStressRotation.Controls.Add(Me.chkStressRotation)
        Me.gbStressRotation.Controls.Add(Me.setStressIncRate)
        Me.gbStressRotation.Controls.Add(Me.setMaxStep)
        Me.gbStressRotation.Controls.Add(Me.Label30)
        Me.gbStressRotation.Controls.Add(Me.Label28)
        Me.gbStressRotation.Location = New System.Drawing.Point(8, 459)
        Me.gbStressRotation.Name = "gbStressRotation"
        Me.gbStressRotation.Size = New System.Drawing.Size(287, 190)
        Me.gbStressRotation.TabIndex = 80
        Me.gbStressRotation.TabStop = False
        Me.gbStressRotation.Text = "Stress Rotation"
        '
        'setStressRotationRate
        '
        Me.setStressRotationRate.DecimalPlaces = 4
        Me.setStressRotationRate.Location = New System.Drawing.Point(159, 88)
        Me.setStressRotationRate.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.setStressRotationRate.Name = "setStressRotationRate"
        Me.setStressRotationRate.Size = New System.Drawing.Size(120, 21)
        Me.setStressRotationRate.TabIndex = 18
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(13, 121)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(71, 15)
        Me.Label41.TabIndex = 23
        Me.Label41.Text = "NStep Limit"
        '
        'btnOpenAngFile
        '
        Me.btnOpenAngFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenAngFile.Location = New System.Drawing.Point(159, 18)
        Me.btnOpenAngFile.Name = "btnOpenAngFile"
        Me.btnOpenAngFile.Size = New System.Drawing.Size(119, 32)
        Me.btnOpenAngFile.TabIndex = 79
        Me.btnOpenAngFile.Text = "Open Ang File"
        Me.btnOpenAngFile.UseVisualStyleBackColor = True
        '
        'setPStressAng
        '
        Me.setPStressAng.DecimalPlaces = 3
        Me.setPStressAng.Location = New System.Drawing.Point(160, 56)
        Me.setPStressAng.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.setPStressAng.Minimum = New Decimal(New Integer() {1000000000, 0, 0, -2147483648})
        Me.setPStressAng.Name = "setPStressAng"
        Me.setPStressAng.Size = New System.Drawing.Size(120, 21)
        Me.setPStressAng.TabIndex = 17
        '
        'chkStressRotation
        '
        Me.chkStressRotation.AutoSize = True
        Me.chkStressRotation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkStressRotation.Location = New System.Drawing.Point(16, 39)
        Me.chkStressRotation.Name = "chkStressRotation"
        Me.chkStressRotation.Size = New System.Drawing.Size(93, 19)
        Me.chkStressRotation.TabIndex = 78
        Me.chkStressRotation.Text = "Sts. Rotation"
        Me.chkStressRotation.UseVisualStyleBackColor = True
        '
        'setStressIncRate
        '
        Me.setStressIncRate.DecimalPlaces = 5
        Me.setStressIncRate.Location = New System.Drawing.Point(159, 152)
        Me.setStressIncRate.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.setStressIncRate.Name = "setStressIncRate"
        Me.setStressIncRate.Size = New System.Drawing.Size(120, 21)
        Me.setStressIncRate.TabIndex = 19
        '
        'setMaxStep
        '
        Me.setMaxStep.Location = New System.Drawing.Point(159, 121)
        Me.setMaxStep.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.setMaxStep.Name = "setMaxStep"
        Me.setMaxStep.Size = New System.Drawing.Size(120, 21)
        Me.setMaxStep.TabIndex = 20
        Me.setMaxStep.Value = New Decimal(New Integer() {1000000, 0, 0, 0})
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(13, 95)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(52, 15)
        Me.Label30.TabIndex = 22
        Me.Label30.Text = "P.S.A Inc"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(13, 63)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(94, 15)
        Me.Label28.TabIndex = 21
        Me.Label28.Text = "Prcp Stress Ang"
        '
        'chkExpVVTs
        '
        Me.chkExpVVTs.AutoSize = True
        Me.chkExpVVTs.Location = New System.Drawing.Point(9, 432)
        Me.chkExpVVTs.Name = "chkExpVVTs"
        Me.chkExpVVTs.Size = New System.Drawing.Size(118, 19)
        Me.chkExpVVTs.TabIndex = 16
        Me.chkExpVVTs.Text = "Export VV Tensor"
        Me.chkExpVVTs.UseVisualStyleBackColor = True
        '
        'chkShowVCFabric
        '
        Me.chkShowVCFabric.AutoSize = True
        Me.chkShowVCFabric.Location = New System.Drawing.Point(9, 404)
        Me.chkShowVCFabric.Name = "chkShowVCFabric"
        Me.chkShowVCFabric.Size = New System.Drawing.Size(113, 19)
        Me.chkShowVCFabric.TabIndex = 15
        Me.chkShowVCFabric.Text = "Show VC Fabric"
        Me.chkShowVCFabric.UseVisualStyleBackColor = True
        '
        'chkShowVoidVector
        '
        Me.chkShowVoidVector.AutoSize = True
        Me.chkShowVoidVector.Location = New System.Drawing.Point(9, 376)
        Me.chkShowVoidVector.Name = "chkShowVoidVector"
        Me.chkShowVoidVector.Size = New System.Drawing.Size(119, 19)
        Me.chkShowVoidVector.TabIndex = 14
        Me.chkShowVoidVector.Text = "Show Void Vector"
        Me.chkShowVoidVector.UseVisualStyleBackColor = True
        '
        'chkShowVCBound
        '
        Me.chkShowVCBound.AutoSize = True
        Me.chkShowVCBound.Location = New System.Drawing.Point(9, 348)
        Me.chkShowVCBound.Name = "chkShowVCBound"
        Me.chkShowVCBound.Size = New System.Drawing.Size(115, 19)
        Me.chkShowVCBound.TabIndex = 13
        Me.chkShowVCBound.Text = "Show VC Bound"
        Me.chkShowVCBound.UseVisualStyleBackColor = True
        '
        'chkShowVCNum
        '
        Me.chkShowVCNum.AutoSize = True
        Me.chkShowVCNum.Location = New System.Drawing.Point(9, 320)
        Me.chkShowVCNum.Name = "chkShowVCNum"
        Me.chkShowVCNum.Size = New System.Drawing.Size(106, 19)
        Me.chkShowVCNum.TabIndex = 12
        Me.chkShowVCNum.Text = "Show VC Num"
        Me.chkShowVCNum.UseVisualStyleBackColor = True
        '
        'chkExtVC
        '
        Me.chkExtVC.AutoSize = True
        Me.chkExtVC.Location = New System.Drawing.Point(9, 292)
        Me.chkExtVC.Name = "chkExtVC"
        Me.chkExtVC.Size = New System.Drawing.Size(82, 19)
        Me.chkExtVC.TabIndex = 11
        Me.chkExtVC.Text = "Extend VC"
        Me.chkExtVC.UseVisualStyleBackColor = True
        '
        'chkShowDualCelll
        '
        Me.chkShowDualCelll.AutoSize = True
        Me.chkShowDualCelll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowDualCelll.Location = New System.Drawing.Point(156, 26)
        Me.chkShowDualCelll.Name = "chkShowDualCelll"
        Me.chkShowDualCelll.Size = New System.Drawing.Size(108, 19)
        Me.chkShowDualCelll.TabIndex = 10
        Me.chkShowDualCelll.Text = "Show Dual Cell"
        Me.chkShowDualCelll.UseVisualStyleBackColor = True
        '
        'chkShowEdgeNum
        '
        Me.chkShowEdgeNum.AutoSize = True
        Me.chkShowEdgeNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowEdgeNum.Location = New System.Drawing.Point(167, 105)
        Me.chkShowEdgeNum.Name = "chkShowEdgeNum"
        Me.chkShowEdgeNum.Size = New System.Drawing.Size(119, 19)
        Me.chkShowEdgeNum.TabIndex = 9
        Me.chkShowEdgeNum.Text = "Show Edge Num."
        Me.chkShowEdgeNum.UseVisualStyleBackColor = True
        '
        'chkShowSolidCell
        '
        Me.chkShowSolidCell.AutoSize = True
        Me.chkShowSolidCell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowSolidCell.Location = New System.Drawing.Point(156, 65)
        Me.chkShowSolidCell.Name = "chkShowSolidCell"
        Me.chkShowSolidCell.Size = New System.Drawing.Size(110, 19)
        Me.chkShowSolidCell.TabIndex = 8
        Me.chkShowSolidCell.Text = "Show Solid Cell"
        Me.chkShowSolidCell.UseVisualStyleBackColor = True
        '
        'setCellOpacity
        '
        Me.setCellOpacity.Location = New System.Drawing.Point(9, 241)
        Me.setCellOpacity.Maximum = 255
        Me.setCellOpacity.Name = "setCellOpacity"
        Me.setCellOpacity.Size = New System.Drawing.Size(289, 45)
        Me.setCellOpacity.TabIndex = 7
        Me.setCellOpacity.TickFrequency = 8
        Me.setCellOpacity.Value = 100
        '
        'chkShowCellNum
        '
        Me.chkShowCellNum.AutoSize = True
        Me.chkShowCellNum.Location = New System.Drawing.Point(9, 214)
        Me.chkShowCellNum.Name = "chkShowCellNum"
        Me.chkShowCellNum.Size = New System.Drawing.Size(115, 19)
        Me.chkShowCellNum.TabIndex = 6
        Me.chkShowCellNum.Text = "Show Cell Num."
        Me.chkShowCellNum.UseVisualStyleBackColor = True
        '
        'chkShowEffEdge
        '
        Me.chkShowEffEdge.AutoSize = True
        Me.chkShowEffEdge.Location = New System.Drawing.Point(8, 186)
        Me.chkShowEffEdge.Name = "chkShowEffEdge"
        Me.chkShowEffEdge.Size = New System.Drawing.Size(106, 19)
        Me.chkShowEffEdge.TabIndex = 5
        Me.chkShowEffEdge.Text = "Show Eff Edge"
        Me.chkShowEffEdge.UseVisualStyleBackColor = True
        '
        'rbShowCrctCell
        '
        Me.rbShowCrctCell.AutoSize = True
        Me.rbShowCrctCell.Location = New System.Drawing.Point(9, 159)
        Me.rbShowCrctCell.Name = "rbShowCrctCell"
        Me.rbShowCrctCell.Size = New System.Drawing.Size(104, 19)
        Me.rbShowCrctCell.TabIndex = 4
        Me.rbShowCrctCell.Text = "Corrected Cell"
        Me.rbShowCrctCell.UseVisualStyleBackColor = True
        '
        'rbShowOriCell
        '
        Me.rbShowOriCell.AutoSize = True
        Me.rbShowOriCell.Checked = True
        Me.rbShowOriCell.Location = New System.Drawing.Point(8, 132)
        Me.rbShowOriCell.Name = "rbShowOriCell"
        Me.rbShowOriCell.Size = New System.Drawing.Size(93, 19)
        Me.rbShowOriCell.TabIndex = 3
        Me.rbShowOriCell.TabStop = True
        Me.rbShowOriCell.Text = "Original Cell"
        Me.rbShowOriCell.UseVisualStyleBackColor = True
        '
        'chkShowContNum
        '
        Me.chkShowContNum.AutoSize = True
        Me.chkShowContNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowContNum.Location = New System.Drawing.Point(9, 105)
        Me.chkShowContNum.Name = "chkShowContNum"
        Me.chkShowContNum.Size = New System.Drawing.Size(129, 19)
        Me.chkShowContNum.TabIndex = 2
        Me.chkShowContNum.Text = "Show Contact Num"
        Me.chkShowContNum.UseVisualStyleBackColor = True
        '
        'chkShowCellInEle
        '
        Me.chkShowCellInEle.AutoSize = True
        Me.chkShowCellInEle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowCellInEle.Location = New System.Drawing.Point(9, 66)
        Me.chkShowCellInEle.Name = "chkShowCellInEle"
        Me.chkShowCellInEle.Size = New System.Drawing.Size(113, 19)
        Me.chkShowCellInEle.TabIndex = 1
        Me.chkShowCellInEle.Text = "Show Cell In Ele"
        Me.chkShowCellInEle.UseVisualStyleBackColor = True
        '
        'btnIniCellInEle
        '
        Me.btnIniCellInEle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniCellInEle.Location = New System.Drawing.Point(8, 16)
        Me.btnIniCellInEle.Name = "btnIniCellInEle"
        Me.btnIniCellInEle.Size = New System.Drawing.Size(120, 32)
        Me.btnIniCellInEle.TabIndex = 0
        Me.btnIniCellInEle.Text = "Ini Cell in Ele"
        Me.btnIniCellInEle.UseVisualStyleBackColor = True
        '
        'tabLink
        '
        Me.tabLink.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tabLink.Controls.Add(Me.chkHLLinks)
        Me.tabLink.Controls.Add(Me.btnExportLinks)
        Me.tabLink.Controls.Add(Me.btnImpLinkID)
        Me.tabLink.Controls.Add(Me.setLinkDampingRatio)
        Me.tabLink.Controls.Add(Me.btnLinkStiffMinus)
        Me.tabLink.Controls.Add(Me.btnLinkStiffPlus)
        Me.tabLink.Controls.Add(Me.btnImpLinkCoord)
        Me.tabLink.ForeColor = System.Drawing.Color.White
        Me.tabLink.Location = New System.Drawing.Point(4, 82)
        Me.tabLink.Name = "tabLink"
        Me.tabLink.Size = New System.Drawing.Size(301, 689)
        Me.tabLink.TabIndex = 7
        Me.tabLink.Text = "Links"
        '
        'chkHLLinks
        '
        Me.chkHLLinks.AutoSize = True
        Me.chkHLLinks.Checked = True
        Me.chkHLLinks.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHLLinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkHLLinks.Location = New System.Drawing.Point(9, 199)
        Me.chkHLLinks.Name = "chkHLLinks"
        Me.chkHLLinks.Size = New System.Drawing.Size(158, 19)
        Me.chkHLLinks.TabIndex = 6
        Me.chkHLLinks.Text = "Highlight linked particles"
        Me.chkHLLinks.UseVisualStyleBackColor = True
        '
        'btnExportLinks
        '
        Me.btnExportLinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportLinks.Location = New System.Drawing.Point(4, 83)
        Me.btnExportLinks.Name = "btnExportLinks"
        Me.btnExportLinks.Size = New System.Drawing.Size(294, 36)
        Me.btnExportLinks.TabIndex = 5
        Me.btnExportLinks.Text = "Export Links"
        Me.btnExportLinks.UseVisualStyleBackColor = True
        '
        'btnImpLinkID
        '
        Me.btnImpLinkID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImpLinkID.Location = New System.Drawing.Point(4, 43)
        Me.btnImpLinkID.Name = "btnImpLinkID"
        Me.btnImpLinkID.Size = New System.Drawing.Size(294, 33)
        Me.btnImpLinkID.TabIndex = 4
        Me.btnImpLinkID.Text = "ImportLinks by Element ID"
        Me.btnImpLinkID.UseVisualStyleBackColor = True
        '
        'setLinkDampingRatio
        '
        Me.setLinkDampingRatio.DecimalPlaces = 3
        Me.setLinkDampingRatio.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.setLinkDampingRatio.Location = New System.Drawing.Point(4, 167)
        Me.setLinkDampingRatio.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.setLinkDampingRatio.Name = "setLinkDampingRatio"
        Me.setLinkDampingRatio.Size = New System.Drawing.Size(136, 21)
        Me.setLinkDampingRatio.TabIndex = 3
        Me.setLinkDampingRatio.Value = New Decimal(New Integer() {5, 0, 0, 65536})
        '
        'btnLinkStiffMinus
        '
        Me.btnLinkStiffMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLinkStiffMinus.Location = New System.Drawing.Point(156, 125)
        Me.btnLinkStiffMinus.Name = "btnLinkStiffMinus"
        Me.btnLinkStiffMinus.Size = New System.Drawing.Size(136, 36)
        Me.btnLinkStiffMinus.TabIndex = 2
        Me.btnLinkStiffMinus.Text = "Link Stiffness -"
        Me.btnLinkStiffMinus.UseVisualStyleBackColor = True
        '
        'btnLinkStiffPlus
        '
        Me.btnLinkStiffPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLinkStiffPlus.Location = New System.Drawing.Point(4, 125)
        Me.btnLinkStiffPlus.Name = "btnLinkStiffPlus"
        Me.btnLinkStiffPlus.Size = New System.Drawing.Size(137, 36)
        Me.btnLinkStiffPlus.TabIndex = 1
        Me.btnLinkStiffPlus.Text = "Link Stiffness +"
        Me.btnLinkStiffPlus.UseVisualStyleBackColor = True
        '
        'btnImpLinkCoord
        '
        Me.btnImpLinkCoord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImpLinkCoord.Location = New System.Drawing.Point(3, 3)
        Me.btnImpLinkCoord.Name = "btnImpLinkCoord"
        Me.btnImpLinkCoord.Size = New System.Drawing.Size(295, 33)
        Me.btnImpLinkCoord.TabIndex = 0
        Me.btnImpLinkCoord.Text = "Import Links by Coordinates"
        Me.btnImpLinkCoord.UseVisualStyleBackColor = True
        '
        'tabAnalysis
        '
        Me.tabAnalysis.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tabAnalysis.Controls.Add(Me.chkTrackMinDist)
        Me.tabAnalysis.Controls.Add(Me.btnCalMinDist)
        Me.tabAnalysis.Controls.Add(Me.GroupBox11)
        Me.tabAnalysis.Location = New System.Drawing.Point(4, 82)
        Me.tabAnalysis.Name = "tabAnalysis"
        Me.tabAnalysis.Size = New System.Drawing.Size(301, 689)
        Me.tabAnalysis.TabIndex = 8
        Me.tabAnalysis.Text = "Analysis"
        '
        'chkTrackMinDist
        '
        Me.chkTrackMinDist.AutoSize = True
        Me.chkTrackMinDist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkTrackMinDist.Location = New System.Drawing.Point(203, 171)
        Me.chkTrackMinDist.Name = "chkTrackMinDist"
        Me.chkTrackMinDist.Size = New System.Drawing.Size(49, 19)
        Me.chkTrackMinDist.TabIndex = 2
        Me.chkTrackMinDist.Text = "track"
        Me.chkTrackMinDist.UseVisualStyleBackColor = True
        '
        'btnCalMinDist
        '
        Me.btnCalMinDist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalMinDist.Location = New System.Drawing.Point(3, 161)
        Me.btnCalMinDist.Name = "btnCalMinDist"
        Me.btnCalMinDist.Size = New System.Drawing.Size(182, 40)
        Me.btnCalMinDist.TabIndex = 1
        Me.btnCalMinDist.Text = "Cal Min Distance"
        Me.btnCalMinDist.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.chkFixDNColor)
        Me.GroupBox11.Controls.Add(Me.chkTracDNSpatial)
        Me.GroupBox11.Controls.Add(Me.setCNUpB)
        Me.GroupBox11.Controls.Add(Me.setCNLowB)
        Me.GroupBox11.Controls.Add(Me.btnExpCoordNumMatrix)
        Me.GroupBox11.Controls.Add(Me.btnStartCoordNumMatrix)
        Me.GroupBox11.Controls.Add(Me.chkShowCNMatrix)
        Me.GroupBox11.Controls.Add(Me.Label45)
        Me.GroupBox11.Controls.Add(Me.Label44)
        Me.GroupBox11.Controls.Add(Me.setCoordNumMatrixSampIntv)
        Me.GroupBox11.Controls.Add(Me.setCoordNumMatrixBoxSize)
        Me.GroupBox11.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(298, 154)
        Me.GroupBox11.TabIndex = 0
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Coordination Num Matrix"
        '
        'chkFixDNColor
        '
        Me.chkFixDNColor.AutoSize = True
        Me.chkFixDNColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkFixDNColor.Location = New System.Drawing.Point(13, 95)
        Me.chkFixDNColor.Name = "chkFixDNColor"
        Me.chkFixDNColor.Size = New System.Drawing.Size(96, 19)
        Me.chkFixDNColor.TabIndex = 11
        Me.chkFixDNColor.Text = "Fix plot range"
        Me.chkFixDNColor.UseVisualStyleBackColor = True
        '
        'chkTracDNSpatial
        '
        Me.chkTracDNSpatial.AutoSize = True
        Me.chkTracDNSpatial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkTracDNSpatial.Location = New System.Drawing.Point(127, 127)
        Me.chkTracDNSpatial.Name = "chkTracDNSpatial"
        Me.chkTracDNSpatial.Size = New System.Drawing.Size(49, 19)
        Me.chkTracDNSpatial.TabIndex = 10
        Me.chkTracDNSpatial.Text = "track"
        Me.chkTracDNSpatial.UseVisualStyleBackColor = True
        '
        'setCNUpB
        '
        Me.setCNUpB.DecimalPlaces = 3
        Me.setCNUpB.Location = New System.Drawing.Point(219, 92)
        Me.setCNUpB.Name = "setCNUpB"
        Me.setCNUpB.Size = New System.Drawing.Size(73, 21)
        Me.setCNUpB.TabIndex = 8
        Me.setCNUpB.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'setCNLowB
        '
        Me.setCNLowB.DecimalPlaces = 3
        Me.setCNLowB.Location = New System.Drawing.Point(127, 92)
        Me.setCNLowB.Name = "setCNLowB"
        Me.setCNLowB.Size = New System.Drawing.Size(86, 21)
        Me.setCNLowB.TabIndex = 7
        Me.setCNLowB.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'btnExpCoordNumMatrix
        '
        Me.btnExpCoordNumMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpCoordNumMatrix.Location = New System.Drawing.Point(219, 57)
        Me.btnExpCoordNumMatrix.Name = "btnExpCoordNumMatrix"
        Me.btnExpCoordNumMatrix.Size = New System.Drawing.Size(73, 26)
        Me.btnExpCoordNumMatrix.TabIndex = 6
        Me.btnExpCoordNumMatrix.Text = "Export"
        Me.btnExpCoordNumMatrix.UseVisualStyleBackColor = True
        '
        'btnStartCoordNumMatrix
        '
        Me.btnStartCoordNumMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartCoordNumMatrix.Location = New System.Drawing.Point(219, 14)
        Me.btnStartCoordNumMatrix.Name = "btnStartCoordNumMatrix"
        Me.btnStartCoordNumMatrix.Size = New System.Drawing.Size(73, 37)
        Me.btnStartCoordNumMatrix.TabIndex = 5
        Me.btnStartCoordNumMatrix.Text = "Analyze"
        Me.btnStartCoordNumMatrix.UseVisualStyleBackColor = True
        '
        'chkShowCNMatrix
        '
        Me.chkShowCNMatrix.AutoSize = True
        Me.chkShowCNMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowCNMatrix.Location = New System.Drawing.Point(13, 127)
        Me.chkShowCNMatrix.Name = "chkShowCNMatrix"
        Me.chkShowCNMatrix.Size = New System.Drawing.Size(54, 19)
        Me.chkShowCNMatrix.TabIndex = 4
        Me.chkShowCNMatrix.Text = "Show"
        Me.chkShowCNMatrix.UseVisualStyleBackColor = True
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(9, 57)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(102, 15)
        Me.Label45.TabIndex = 3
        Me.Label45.Text = "Sampling Interval"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label44.Location = New System.Drawing.Point(9, 31)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(53, 15)
        Me.Label44.TabIndex = 2
        Me.Label44.Text = "Box Size"
        '
        'setCoordNumMatrixSampIntv
        '
        Me.setCoordNumMatrixSampIntv.DecimalPlaces = 4
        Me.setCoordNumMatrixSampIntv.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.setCoordNumMatrixSampIntv.Location = New System.Drawing.Point(127, 54)
        Me.setCoordNumMatrixSampIntv.Minimum = New Decimal(New Integer() {1, 0, 0, 393216})
        Me.setCoordNumMatrixSampIntv.Name = "setCoordNumMatrixSampIntv"
        Me.setCoordNumMatrixSampIntv.Size = New System.Drawing.Size(86, 21)
        Me.setCoordNumMatrixSampIntv.TabIndex = 1
        Me.setCoordNumMatrixSampIntv.Value = New Decimal(New Integer() {1, 0, 0, 393216})
        '
        'setCoordNumMatrixBoxSize
        '
        Me.setCoordNumMatrixBoxSize.DecimalPlaces = 4
        Me.setCoordNumMatrixBoxSize.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.setCoordNumMatrixBoxSize.Location = New System.Drawing.Point(127, 23)
        Me.setCoordNumMatrixBoxSize.Minimum = New Decimal(New Integer() {1, 0, 0, 327680})
        Me.setCoordNumMatrixBoxSize.Name = "setCoordNumMatrixBoxSize"
        Me.setCoordNumMatrixBoxSize.Size = New System.Drawing.Size(86, 21)
        Me.setCoordNumMatrixBoxSize.TabIndex = 0
        Me.setCoordNumMatrixBoxSize.Value = New Decimal(New Integer() {1, 0, 0, 327680})
        '
        'btnSnapShot
        '
        Me.btnSnapShot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSnapShot.BackColor = System.Drawing.Color.Maroon
        Me.btnSnapShot.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSnapShot.FlatAppearance.BorderSize = 2
        Me.btnSnapShot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate
        Me.btnSnapShot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSnapShot.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.btnSnapShot.ForeColor = System.Drawing.Color.White
        Me.btnSnapShot.Location = New System.Drawing.Point(160, 787)
        Me.btnSnapShot.Name = "btnSnapShot"
        Me.btnSnapShot.Size = New System.Drawing.Size(70, 30)
        Me.btnSnapShot.TabIndex = 82
        Me.btnSnapShot.Text = "Snapshot"
        Me.btnSnapShot.UseVisualStyleBackColor = False
        '
        'canvasContainer
        '
        Me.canvasContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.canvasContainer.Controls.Add(Me.mainTransparency)
        Me.canvasContainer.Controls.Add(Me.canvas)
        Me.canvasContainer.Location = New System.Drawing.Point(312, 0)
        Me.canvasContainer.Name = "canvasContainer"
        Me.canvasContainer.Size = New System.Drawing.Size(875, 780)
        Me.canvasContainer.TabIndex = 78
        '
        'mainTransparency
        '
        Me.mainTransparency.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainTransparency.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mainTransparency.Location = New System.Drawing.Point(843, 10)
        Me.mainTransparency.Maximum = 20
        Me.mainTransparency.Name = "mainTransparency"
        Me.mainTransparency.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.mainTransparency.Size = New System.Drawing.Size(45, 271)
        Me.mainTransparency.TabIndex = 107
        Me.mainTransparency.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'canvas
        '
        Me.canvas.BackColor = System.Drawing.Color.White
        Me.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.canvas.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.canvas.Enabled = False
        Me.canvas.Location = New System.Drawing.Point(0, 0)
        Me.canvas.Name = "canvas"
        Me.canvas.Size = New System.Drawing.Size(1092, 899)
        Me.canvas.TabIndex = 1
        Me.canvas.TabStop = False
        Me.canvas.Visible = False
        '
        'timerZoomIn
        '
        Me.timerZoomIn.Interval = 20
        '
        'dlgOpenTest
        '
        Me.dlgOpenTest.Filter = """Data File (*.dat)|*.dat|All files (*.*)|*.*"""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'dlgSaveResults
        '
        Me.dlgSaveResults.Filter = "Result files (*.rst)|*.rst|All files (*.*)|*.*"
        Me.dlgSaveResults.Title = "Save Results "
        '
        'trackPost
        '
        Me.trackPost.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trackPost.AutoSize = False
        Me.trackPost.Enabled = False
        Me.trackPost.Location = New System.Drawing.Point(360, 789)
        Me.trackPost.Name = "trackPost"
        Me.trackPost.Size = New System.Drawing.Size(665, 30)
        Me.trackPost.TabIndex = 0
        Me.trackPost.Tag = ""
        Me.trackPost.Visible = False
        '
        'dlgOpenResults
        '
        Me.dlgOpenResults.Filter = "Result files (*.rst)|*.rst|All files (*.*)|*.*"
        '
        'setZoomFactor
        '
        Me.setZoomFactor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.setZoomFactor.BackColor = System.Drawing.Color.DimGray
        Me.setZoomFactor.DecimalPlaces = 1
        Me.setZoomFactor.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.setZoomFactor.ForeColor = System.Drawing.Color.White
        Me.setZoomFactor.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.setZoomFactor.Location = New System.Drawing.Point(1140, 781)
        Me.setZoomFactor.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.setZoomFactor.Name = "setZoomFactor"
        Me.setZoomFactor.Size = New System.Drawing.Size(50, 20)
        Me.setZoomFactor.TabIndex = 81
        Me.setZoomFactor.Value = New Decimal(New Integer() {12, 0, 0, 65536})
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(22, 133)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(16, 13)
        Me.Label43.TabIndex = 1
        Me.Label43.Text = "θ:"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(22, 109)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(17, 13)
        Me.Label42.TabIndex = 1
        Me.Label42.Text = "Y:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(22, 87)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(17, 13)
        Me.Label40.TabIndex = 1
        Me.Label40.Text = "X:"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(9, 19)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(78, 13)
        Me.Label39.TabIndex = 1
        Me.Label39.Text = "Active Element"
        '
        'dlgCanvasColor
        '
        Me.dlgCanvasColor.AnyColor = True
        Me.dlgCanvasColor.Color = System.Drawing.Color.DimGray
        '
        'showCurrentStepPost
        '
        Me.showCurrentStepPost.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.showCurrentStepPost.AutoSize = True
        Me.showCurrentStepPost.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.showCurrentStepPost.ForeColor = System.Drawing.Color.White
        Me.showCurrentStepPost.Location = New System.Drawing.Point(912, 783)
        Me.showCurrentStepPost.Name = "showCurrentStepPost"
        Me.showCurrentStepPost.Size = New System.Drawing.Size(65, 14)
        Me.showCurrentStepPost.TabIndex = 83
        Me.showCurrentStepPost.Text = "CurrentStep"
        Me.showCurrentStepPost.Visible = False
        '
        'btnPlay
        '
        Me.btnPlay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnPlay.ForeColor = System.Drawing.Color.White
        Me.btnPlay.Location = New System.Drawing.Point(313, 787)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(21, 30)
        Me.btnPlay.TabIndex = 84
        Me.btnPlay.Text = ">"
        Me.btnPlay.UseVisualStyleBackColor = True
        Me.btnPlay.Visible = False
        '
        'btnStop
        '
        Me.btnStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.ForeColor = System.Drawing.Color.White
        Me.btnStop.Location = New System.Drawing.Point(336, 787)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(21, 30)
        Me.btnStop.TabIndex = 84
        Me.btnStop.Text = "="
        Me.btnStop.UseVisualStyleBackColor = True
        Me.btnStop.Visible = False
        '
        'timerPlay
        '
        Me.timerPlay.Interval = 10
        '
        'showPpM
        '
        Me.showPpM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.showPpM.AutoSize = True
        Me.showPpM.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.showPpM.ForeColor = System.Drawing.Color.White
        Me.showPpM.Location = New System.Drawing.Point(1145, 806)
        Me.showPpM.Name = "showPpM"
        Me.showPpM.Size = New System.Drawing.Size(27, 14)
        Me.showPpM.TabIndex = 85
        Me.showPpM.Text = "ppm"
        '
        'PPDEM
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1192, 823)
        Me.Controls.Add(Me.showPpM)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.showCurrentStepPost)
        Me.Controls.Add(Me.btnSnapShot)
        Me.Controls.Add(Me.setZoomFactor)
        Me.Controls.Add(Me.trackPost)
        Me.Controls.Add(Me.canvasContainer)
        Me.Controls.Add(Me.btnZoomOut)
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.btGlue)
        Me.Controls.Add(Me.btnZoomIn)
        Me.Controls.Add(Me.btnOpenTest)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.MenuStrip)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(8, 750)
        Me.Name = "PPDEM"
        Me.Text = " PPDEM - by Pengcheng Fu of LLNL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.tInc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.refRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nIncr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setGlobDamp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setMaxRFriend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setTanTheta1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setAngle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setRollingDamp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setDampingRatio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setpInt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setCurrentLoadRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.tabSystem.ResumeLayout(False)
        Me.tabSystem.PerformLayout()
        Me.gbThinLayer.ResumeLayout(False)
        Me.gbThinLayer.PerformLayout()
        CType(Me.setHThinLayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setRotDamp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setOutputFreq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setFreqSaveRST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ctrlNumProcessor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ctrlMaxNEle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setTanTheta2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabView.ResumeLayout(False)
        Me.tabView.PerformLayout()
        CType(Me.setPenWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCanvas2File.ResumeLayout(False)
        Me.gbCanvas2File.PerformLayout()
        Me.grpRotationMode.ResumeLayout(False)
        Me.grpRotationMode.PerformLayout()
        Me.grpHist.ResumeLayout(False)
        Me.grpHist.PerformLayout()
        CType(Me.setNBinFR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setNBinOri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setNBinForce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setNBinNorm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpForceViewMode.ResumeLayout(False)
        Me.grpForceViewMode.PerformLayout()
        CType(Me.setFactorSlidContrast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cstForceThickLeng, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cstForceThickContrast, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabLoad.ResumeLayout(False)
        Me.grpLoadModeControl.ResumeLayout(False)
        Me.grpLoadModeControl.PerformLayout()
        Me.grpBatchLoading.ResumeLayout(False)
        Me.grpBatchLoading.PerformLayout()
        CType(Me.setCyclicDisplacement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setQLimit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.setXGravity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setGX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setGY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setYGravity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDisplacementLoadControl.ResumeLayout(False)
        Me.grpDisplacementLoadControl.PerformLayout()
        CType(Me.setSteptoGo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setTargetLoadRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConfiningControl.ResumeLayout(False)
        Me.grpConfiningControl.PerformLayout()
        CType(Me.setpxy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setPy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setPx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.incWall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEdit.ResumeLayout(False)
        Me.tabEdit.PerformLayout()
        Me.grpDiscMask.ResumeLayout(False)
        Me.grpDiscMask.PerformLayout()
        Me.grpCrop.ResumeLayout(False)
        Me.grpMaskShape.ResumeLayout(False)
        Me.grpMaskShape.PerformLayout()
        Me.grpEditOption.ResumeLayout(False)
        Me.grpEditOption.PerformLayout()
        CType(Me.setAngRotate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setCAC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPost.ResumeLayout(False)
        Me.grpGridDeform.ResumeLayout(False)
        Me.grpGridDeform.PerformLayout()
        CType(Me.setDyeDark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setIntvlDye, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setAngDye, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setNumGD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupPtclMotion.ResumeLayout(False)
        Me.groupPtclMotion.PerformLayout()
        Me.gbShowSlideTrace.ResumeLayout(False)
        Me.gbShowSlideTrace.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.setRefOri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        CType(Me.setRelaMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setRelaMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.containerContourRange.ResumeLayout(False)
        CType(Me.lowContourRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.upContourRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackStateB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.setStepSparse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupPostMode.ResumeLayout(False)
        Me.groupPostMode.PerformLayout()
        Me.tabStrain.ResumeLayout(False)
        Me.tabStrain.PerformLayout()
        Me.gbShowStnDrct.ResumeLayout(False)
        Me.gbShowStnDrct.PerformLayout()
        Me.gbStnMode.ResumeLayout(False)
        Me.gbStnMode.PerformLayout()
        Me.gbCellMode.ResumeLayout(False)
        Me.gbCellMode.PerformLayout()
        CType(Me.setValLegend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setStnContrast, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPickStnSign.ResumeLayout(False)
        Me.gbPickStnSign.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.setAngN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setNumCell, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setRdStnCell, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCellFabric.ResumeLayout(False)
        Me.tabCellFabric.PerformLayout()
        Me.gbStressRotation.ResumeLayout(False)
        Me.gbStressRotation.PerformLayout()
        CType(Me.setStressRotationRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setPStressAng, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setStressIncRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setMaxStep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setCellOpacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabLink.ResumeLayout(False)
        Me.tabLink.PerformLayout()
        CType(Me.setLinkDampingRatio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAnalysis.ResumeLayout(False)
        Me.tabAnalysis.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        CType(Me.setCNUpB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setCNLowB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setCoordNumMatrixSampIntv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setCoordNumMatrixBoxSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.canvasContainer.ResumeLayout(False)
        Me.canvasContainer.PerformLayout()
        CType(Me.mainTransparency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.canvas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackPost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setZoomFactor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timerTest As System.Windows.Forms.Timer
    Friend WithEvents tInc As System.Windows.Forms.NumericUpDown
    Friend WithEvents refRate As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nIncr As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nIncDisp As System.Windows.Forms.Label
    Friend WithEvents LbStiff As System.Windows.Forms.Label
    Friend WithEvents setE As System.Windows.Forms.NumericUpDown
    Friend WithEvents MovDown As System.Windows.Forms.Button
    Friend WithEvents MovUp As System.Windows.Forms.Button
    Friend WithEvents MovRight As System.Windows.Forms.Button
    Friend WithEvents MovLeft As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents maxRFriend_label As System.Windows.Forms.Label
    Friend WithEvents setGlobDamp As System.Windows.Forms.NumericUpDown
    Friend WithEvents setMaxRFriend As System.Windows.Forms.NumericUpDown
    Friend WithEvents lb_set_PPFricAng As System.Windows.Forms.Label
    Friend WithEvents setTanTheta1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnCW As System.Windows.Forms.Button
    Friend WithEvents btnCCW As System.Windows.Forms.Button
    Friend WithEvents setAngle As System.Windows.Forms.NumericUpDown
    Friend WithEvents chsWall As System.Windows.Forms.Button
    Friend WithEvents setRollingDamp As System.Windows.Forms.NumericUpDown
    Friend WithEvents setDampingRatio As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents OpenSnapshot As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveSnapshot As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnOpenTest As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents setpInt As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnZoomIn As System.Windows.Forms.Button
    Friend WithEvents btnZoomOut As System.Windows.Forms.Button
    Friend WithEvents setCurrentLoadRate As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents timeSaveFile As System.Windows.Forms.Timer
    Friend WithEvents checkFlagDebug As System.Windows.Forms.CheckBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btGlue As System.Windows.Forms.Button
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents tabMain As System.Windows.Forms.TabControl
    Friend WithEvents tabView As System.Windows.Forms.TabPage
    Friend WithEvents tabLoad As System.Windows.Forms.TabPage
    Friend WithEvents tabSystem As System.Windows.Forms.TabPage
    Friend WithEvents flagRotation As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowFriend As System.Windows.Forms.CheckBox
    Friend WithEvents flagForceByLeng As System.Windows.Forms.CheckBox
    Friend WithEvents btVelMinus As System.Windows.Forms.Button
    Friend WithEvents checkShowVel As System.Windows.Forms.CheckBox
    Friend WithEvents btnForLengScaleDown As System.Windows.Forms.Button
    Friend WithEvents btnForLengScaleUp As System.Windows.Forms.Button
    Friend WithEvents flagShowP As System.Windows.Forms.CheckBox
    Friend WithEvents btnHalfPScale As System.Windows.Forms.Button
    Friend WithEvents btnDoublePScale As System.Windows.Forms.Button
    Friend WithEvents btVelPlus As System.Windows.Forms.Button
    Friend WithEvents ctrlNumProcessor As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents canvas As System.Windows.Forms.PictureBox
    Friend WithEvents canvasContainer As System.Windows.Forms.Panel
    Friend WithEvents chkAutoMaxRFriend As System.Windows.Forms.CheckBox
    Friend WithEvents tabEdit As System.Windows.Forms.TabPage
    Friend WithEvents timerZoomIn As System.Windows.Forms.Timer
    Friend WithEvents dlgOpenTest As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents ctrlMaxNEle As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkMassNorm As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowCoord As System.Windows.Forms.CheckBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents setPx As System.Windows.Forms.NumericUpDown
    Friend WithEvents setPy As System.Windows.Forms.NumericUpDown
    Friend WithEvents setGY As System.Windows.Forms.NumericUpDown
    Friend WithEvents setYGravity As System.Windows.Forms.NumericUpDown
    Friend WithEvents setGX As System.Windows.Forms.NumericUpDown
    Friend WithEvents setXGravity As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbCritDt As System.Windows.Forms.Label
    Friend WithEvents incWall As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkShowCohesion As System.Windows.Forms.CheckBox
    Friend WithEvents btnAutoWall As System.Windows.Forms.Button
    Friend WithEvents chkForceByThick As System.Windows.Forms.CheckBox
    Friend WithEvents btnAutoFScaleLeng As System.Windows.Forms.Button
    Friend WithEvents btnFScaleThickDown As System.Windows.Forms.Button
    Friend WithEvents btnFSceleThickUp As System.Windows.Forms.Button
    Friend WithEvents btnAutoFScaleThick As System.Windows.Forms.Button
    Friend WithEvents Constrast As System.Windows.Forms.Label
    Friend WithEvents cstForceThickLeng As System.Windows.Forms.NumericUpDown
    Friend WithEvents cstForceThickContrast As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkShowForceColor As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tabPost As System.Windows.Forms.TabPage
    Friend WithEvents chkSave As System.Windows.Forms.CheckBox
    Friend WithEvents dlgSaveResults As System.Windows.Forms.SaveFileDialog
    Friend WithEvents setFreqSaveRST As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnOpenResult As System.Windows.Forms.Button
    Friend WithEvents trackPost As System.Windows.Forms.TrackBar
    Friend WithEvents dlgOpenResults As System.Windows.Forms.OpenFileDialog
    Friend WithEvents groupPostMode As System.Windows.Forms.GroupBox
    Friend WithEvents groupPtclMotion As System.Windows.Forms.GroupBox
    Friend WithEvents trackStateB As System.Windows.Forms.TrackBar
    Friend WithEvents btnRotationScaleDown As System.Windows.Forms.Button
    Friend WithEvents btnRotationScaleUp As System.Windows.Forms.Button
    Friend WithEvents chkShowRotation As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowTrace As System.Windows.Forms.CheckBox
    Friend WithEvents grpGridDeform As System.Windows.Forms.GroupBox
    Friend WithEvents setNumGD As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnNewGD As System.Windows.Forms.Button
    Friend WithEvents modeMotion As System.Windows.Forms.CheckBox
    Friend WithEvents modeHist As System.Windows.Forms.CheckBox
    Friend WithEvents modeGD As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkColorTrace As System.Windows.Forms.CheckBox
    Friend WithEvents rbV As System.Windows.Forms.RadioButton
    Friend WithEvents rbH As System.Windows.Forms.RadioButton
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbContourH As System.Windows.Forms.RadioButton
    Friend WithEvents rbContourU As System.Windows.Forms.RadioButton
    Friend WithEvents rbContourR As System.Windows.Forms.RadioButton
    Friend WithEvents rbContourV As System.Windows.Forms.RadioButton
    Friend WithEvents chkDefContour As System.Windows.Forms.CheckBox
    Friend WithEvents upContourRange As System.Windows.Forms.TrackBar
    Friend WithEvents lowContourRange As System.Windows.Forms.TrackBar
    Friend WithEvents containerContourRange As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents showLine As System.Windows.Forms.CheckBox
    Friend WithEvents showARC As System.Windows.Forms.CheckBox
    Friend WithEvents setCAC As System.Windows.Forms.NumericUpDown
    Friend WithEvents modeVR As System.Windows.Forms.CheckBox
    Friend WithEvents chkHideElement As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents grpConfiningControl As System.Windows.Forms.GroupBox
    Friend WithEvents grpDisplacementLoadControl As System.Windows.Forms.GroupBox
    Friend WithEvents setTargetLoadRate As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents setSteptoGo As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents chkProgressiveLoading As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents setNBinOri As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents setNBinFR As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents setNBinNorm As System.Windows.Forms.NumericUpDown
    Friend WithEvents setNBinForce As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents chkShowEleNum As System.Windows.Forms.CheckBox
    Friend WithEvents setRelaMax As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents chkMode1 As System.Windows.Forms.RadioButton
    Friend WithEvents chkMode0 As System.Windows.Forms.RadioButton
    Friend WithEvents setRelaMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents setZoomFactor As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkIncWallForce As System.Windows.Forms.CheckBox
    Friend WithEvents chkMeasureMode As System.Windows.Forms.CheckBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents setpxy As System.Windows.Forms.NumericUpDown
    Friend WithEvents grpEditOption As System.Windows.Forms.GroupBox
    Friend WithEvents rbEleAdd As System.Windows.Forms.RadioButton
    Friend WithEvents rbSampleRotate As System.Windows.Forms.RadioButton
    Friend WithEvents rbEleCopy As System.Windows.Forms.RadioButton
    Friend WithEvents rbEleShape As System.Windows.Forms.RadioButton
    Friend WithEvents rbEleMove As System.Windows.Forms.RadioButton
    Friend WithEvents rbView As System.Windows.Forms.RadioButton
    Friend WithEvents rbEleRotate As System.Windows.Forms.RadioButton
    Friend WithEvents btnRotate As System.Windows.Forms.Button
    Friend WithEvents setAngRotate As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents rbEleRomove As System.Windows.Forms.RadioButton
    Friend WithEvents grpCrop As System.Windows.Forms.GroupBox
    Friend WithEvents rbMaskRect As System.Windows.Forms.RadioButton
    Friend WithEvents grpMaskShape As System.Windows.Forms.GroupBox
    Friend WithEvents rbMaskPoly As System.Windows.Forms.RadioButton
    Friend WithEvents rbMaskCircular As System.Windows.Forms.RadioButton
    Friend WithEvents btnCrop As System.Windows.Forms.Button
    Friend WithEvents btnMaskCrop As System.Windows.Forms.Button
    Friend WithEvents btnMaskReverse As System.Windows.Forms.Button
    Friend WithEvents btnSnapShot As System.Windows.Forms.Button
    Friend WithEvents grpBatchLoading As System.Windows.Forms.GroupBox
    Friend WithEvents rbBatchLoading As System.Windows.Forms.RadioButton
    Friend WithEvents rbManualLoading As System.Windows.Forms.RadioButton
    Friend WithEvents btnOpenBatchLoading As System.Windows.Forms.Button
    Friend WithEvents setLoadModeTopN As System.Windows.Forms.ComboBox
    Friend WithEvents setLoadModeBottomN As System.Windows.Forms.ComboBox
    Friend WithEvents setLoadModeRightN As System.Windows.Forms.ComboBox
    Friend WithEvents setLoadModeLeftN As System.Windows.Forms.ComboBox
    Friend WithEvents grpLoadModeControl As System.Windows.Forms.GroupBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbICurStep3 As System.Windows.Forms.Label
    Friend WithEvents lbICurStep2 As System.Windows.Forms.Label
    Friend WithEvents lbICurStep1 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents setLoadModeTopT As System.Windows.Forms.ComboBox
    Friend WithEvents setLoadModeLeftT As System.Windows.Forms.ComboBox
    Friend WithEvents setLoadModeBottomT As System.Windows.Forms.ComboBox
    Friend WithEvents setLoadModeRightT As System.Windows.Forms.ComboBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents grpHist As System.Windows.Forms.GroupBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents setTanTheta2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents textEleQuery As System.Windows.Forms.TextBox
    Friend WithEvents btnEleQuery As System.Windows.Forms.Button
    Friend WithEvents chkMonitorSystemVariable As System.Windows.Forms.CheckBox
    Friend WithEvents btnCanvasColor As System.Windows.Forms.Button
    Friend WithEvents dlgCanvasColor As System.Windows.Forms.ColorDialog
    Friend WithEvents btnOutput As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents setOutputFreq As System.Windows.Forms.NumericUpDown
    Friend WithEvents showCurrentStepPost As System.Windows.Forms.Label
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents timerPlay As System.Windows.Forms.Timer
    Friend WithEvents chkShowSliding As System.Windows.Forms.CheckBox
    Friend WithEvents btnAutoSScale As System.Windows.Forms.Button
    Friend WithEvents btnSScaleDown As System.Windows.Forms.Button
    Friend WithEvents btnSScaleUp As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents setFactorSlidContrast As System.Windows.Forms.NumericUpDown
    Friend WithEvents grpForceViewMode As System.Windows.Forms.GroupBox
    Friend WithEvents rbForceModeConn As System.Windows.Forms.RadioButton
    Friend WithEvents rbForceModeDire As System.Windows.Forms.RadioButton
    Friend WithEvents gbShowSlideTrace As System.Windows.Forms.GroupBox
    Friend WithEvents chkShowRollingTrace As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowSldTrace As System.Windows.Forms.CheckBox
    Friend WithEvents showJStep As System.Windows.Forms.Label
    Friend WithEvents chkHideElement2 As System.Windows.Forms.CheckBox
    Friend WithEvents lbVelFactor As System.Windows.Forms.Label
    Friend WithEvents mainTransparency As System.Windows.Forms.TrackBar
    Friend WithEvents rbCountorBulk As System.Windows.Forms.RadioButton
    Friend WithEvents rbContourShear As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rbGray As System.Windows.Forms.RadioButton
    Friend WithEvents rbColor As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents rbModeForce As System.Windows.Forms.RadioButton
    Friend WithEvents rbModeStress As System.Windows.Forms.RadioButton
    Friend WithEvents rbContourXY As System.Windows.Forms.RadioButton
    Friend WithEvents rbContourYY As System.Windows.Forms.RadioButton
    Friend WithEvents rbContourXX As System.Windows.Forms.RadioButton
    Friend WithEvents rbContourOri As System.Windows.Forms.RadioButton
    Friend WithEvents setRefOri As System.Windows.Forms.NumericUpDown
    Friend WithEvents rbRelaOri As System.Windows.Forms.RadioButton
    Friend WithEvents grpRotationMode As System.Windows.Forms.GroupBox
    Friend WithEvents rbRotationMode2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbRotationMode1 As System.Windows.Forms.RadioButton
    Friend WithEvents tabStrain As System.Windows.Forms.TabPage
    Friend WithEvents btnIniStnCell As System.Windows.Forms.Button
    Friend WithEvents setRdStnCell As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkShowCell As System.Windows.Forms.CheckBox
    Friend WithEvents setNumCell As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chkShowStrain As System.Windows.Forms.CheckBox
    Friend WithEvents btnStnScaleDown As System.Windows.Forms.Button
    Friend WithEvents btnStnScaleUp As System.Windows.Forms.Button
    Friend WithEvents chkLockIStepJStep As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents rbStrainV As System.Windows.Forms.RadioButton
    Friend WithEvents rbStrainXYN As System.Windows.Forms.RadioButton
    Friend WithEvents rbStrainN As System.Windows.Forms.RadioButton
    Friend WithEvents rbStrainXYMax As System.Windows.Forms.RadioButton
    Friend WithEvents rbStrainII As System.Windows.Forms.RadioButton
    Friend WithEvents rbStrainI As System.Windows.Forms.RadioButton
    Friend WithEvents rbStrainXY As System.Windows.Forms.RadioButton
    Friend WithEvents rbStrainYY As System.Windows.Forms.RadioButton
    Friend WithEvents rbStrainXX As System.Windows.Forms.RadioButton
    Friend WithEvents gbPickStnSign As System.Windows.Forms.GroupBox
    Friend WithEvents rbShowBothStn As System.Windows.Forms.RadioButton
    Friend WithEvents rbShowNegStn As System.Windows.Forms.RadioButton
    Friend WithEvents rbShowPosiStn As System.Windows.Forms.RadioButton
    Friend WithEvents chkShowStnDrct As System.Windows.Forms.CheckBox
    Friend WithEvents chkLgthStrn As System.Windows.Forms.CheckBox
    Friend WithEvents btnStnDrctScaleDown As System.Windows.Forms.Button
    Friend WithEvents btnStnDrctScaleUp As System.Windows.Forms.Button
    Friend WithEvents setAngN As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents setStnContrast As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents chkShowStnLegend As System.Windows.Forms.CheckBox
    Friend WithEvents setValLegend As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkShowGrid As System.Windows.Forms.CheckBox
    Friend WithEvents btnCanvas2File As System.Windows.Forms.Button
    Friend WithEvents gbCanvas2File As System.Windows.Forms.GroupBox
    Friend WithEvents rbExpAll As System.Windows.Forms.RadioButton
    Friend WithEvents rbExpVisible As System.Windows.Forms.RadioButton
    Friend WithEvents rbContourCoordNum As System.Windows.Forms.RadioButton
    Friend WithEvents grpDiscMask As System.Windows.Forms.GroupBox
    Friend WithEvents btnApdDiscMask As System.Windows.Forms.Button
    Friend WithEvents btnRstDiscMask As System.Windows.Forms.Button
    Friend WithEvents chkShwDiscMask As System.Windows.Forms.CheckBox
    Friend WithEvents chkExpDiscMask As System.Windows.Forms.CheckBox
    Friend WithEvents chkShwStrnVal As System.Windows.Forms.CheckBox
    Friend WithEvents btnClearActCell As System.Windows.Forms.Button
    Friend WithEvents chkAddActCell As System.Windows.Forms.CheckBox
    Friend WithEvents btnExpCellStrn As System.Windows.Forms.Button
    Friend WithEvents setIntvlDye As System.Windows.Forms.NumericUpDown
    Friend WithEvents setAngDye As System.Windows.Forms.NumericUpDown
    Friend WithEvents setDyeDark As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnStrnTrack As System.Windows.Forms.Button
    Friend WithEvents showPpM As System.Windows.Forms.Label
    Friend WithEvents setStepSparse As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnResetCell As System.Windows.Forms.Button
    Friend WithEvents btnAllAct As System.Windows.Forms.Button
    Friend WithEvents gbCellMode As System.Windows.Forms.GroupBox
    Friend WithEvents rbDelauany As System.Windows.Forms.RadioButton
    Friend WithEvents rbHomoTri As System.Windows.Forms.RadioButton
    Friend WithEvents gbStnMode As System.Windows.Forms.GroupBox
    Friend WithEvents rbModeStnRate As System.Windows.Forms.RadioButton
    Friend WithEvents rbModeStnInc As System.Windows.Forms.RadioButton
    Friend WithEvents gbShowStnDrct As System.Windows.Forms.GroupBox
    Friend WithEvents rbDrctStnXX As System.Windows.Forms.RadioButton
    Friend WithEvents rbDrctShearFlow As System.Windows.Forms.RadioButton
    Friend WithEvents rbDrctStnII As System.Windows.Forms.RadioButton
    Friend WithEvents rbDrctStnI As System.Windows.Forms.RadioButton
    Friend WithEvents rbShearFlowRate As System.Windows.Forms.RadioButton
    Friend WithEvents rbDrctMaxShear As System.Windows.Forms.RadioButton
    Friend WithEvents rbDyeGrid As System.Windows.Forms.RadioButton
    Friend WithEvents rbGridLine As System.Windows.Forms.RadioButton
    Friend WithEvents rbDyeBand As System.Windows.Forms.RadioButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnMaskCell As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents setPenWidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents setRotDamp As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents gbThinLayer As System.Windows.Forms.GroupBox
    Friend WithEvents setHThinLayer As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkLayerLowFric As System.Windows.Forms.CheckBox
    Friend WithEvents chkLayerNoRotation As System.Windows.Forms.CheckBox
    Friend WithEvents tabCellFabric As System.Windows.Forms.TabPage
    Friend WithEvents btnIniCellInEle As System.Windows.Forms.Button
    Friend WithEvents chkShowCellInEle As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowContNum As System.Windows.Forms.CheckBox
    Friend WithEvents rbShowCrctCell As System.Windows.Forms.RadioButton
    Friend WithEvents rbShowOriCell As System.Windows.Forms.RadioButton
    Friend WithEvents chkShowEffEdge As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowCellNum As System.Windows.Forms.CheckBox
    Friend WithEvents setCellOpacity As System.Windows.Forms.TrackBar
    Friend WithEvents chkShowSolidCell As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowEdgeNum As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowDualCelll As System.Windows.Forms.CheckBox
    Friend WithEvents chkExtVC As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowVCNum As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowVCBound As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowVoidVector As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowVCFabric As System.Windows.Forms.CheckBox
    Friend WithEvents cbSpecialLoad As System.Windows.Forms.ComboBox
    Friend WithEvents chkExportCon As System.Windows.Forms.CheckBox
    Friend WithEvents chkExpVVTs As System.Windows.Forms.CheckBox
    Friend WithEvents btnSaveMovie As System.Windows.Forms.Button
    Friend WithEvents rbBlack As System.Windows.Forms.RadioButton
    Friend WithEvents setPStressAng As System.Windows.Forms.NumericUpDown
    Friend WithEvents setStressRotationRate As System.Windows.Forms.NumericUpDown
    Friend WithEvents setStressIncRate As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents setMaxStep As System.Windows.Forms.NumericUpDown
    Friend WithEvents rbSpinTensor As System.Windows.Forms.RadioButton
    Friend WithEvents chkStressRotation As System.Windows.Forms.CheckBox
    Friend WithEvents btnOpenAngFile As System.Windows.Forms.Button
    Friend WithEvents gbStressRotation As System.Windows.Forms.GroupBox
    Friend WithEvents tabLink As System.Windows.Forms.TabPage
    Friend WithEvents btnImpLinkCoord As System.Windows.Forms.Button
    Friend WithEvents btnLinkStiffMinus As System.Windows.Forms.Button
    Friend WithEvents btnLinkStiffPlus As System.Windows.Forms.Button
    Friend WithEvents setLinkDampingRatio As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnImpLinkID As System.Windows.Forms.Button
    Protected WithEvents btnExportLinks As System.Windows.Forms.Button
    Friend WithEvents chkHLLinks As System.Windows.Forms.CheckBox
    Friend WithEvents chkExpWallPosition As System.Windows.Forms.CheckBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents setQLimit As System.Windows.Forms.NumericUpDown
    Friend WithEvents setInitialLoadDirection As System.Windows.Forms.CheckBox
    Friend WithEvents cycDis As System.Windows.Forms.Label
    Friend WithEvents setCyclicDisplacement As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkConForceByRadius As System.Windows.Forms.CheckBox
    Friend WithEvents tabAnalysis As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExpCoordNumMatrix As System.Windows.Forms.Button
    Friend WithEvents btnStartCoordNumMatrix As System.Windows.Forms.Button
    Friend WithEvents chkShowCNMatrix As System.Windows.Forms.CheckBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents setCoordNumMatrixSampIntv As System.Windows.Forms.NumericUpDown
    Friend WithEvents setCoordNumMatrixBoxSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents setCNUpB As System.Windows.Forms.NumericUpDown
    Friend WithEvents setCNLowB As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkTracDNSpatial As System.Windows.Forms.CheckBox
    Friend WithEvents chkFixDNColor As System.Windows.Forms.CheckBox
    Friend WithEvents btnCalMinDist As System.Windows.Forms.Button
    Friend WithEvents chkTrackMinDist As System.Windows.Forms.CheckBox
    Friend WithEvents CentripetalG As System.Windows.Forms.CheckBox

End Class
