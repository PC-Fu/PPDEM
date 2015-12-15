
Imports System.Runtime.InteropServices
Public Class PPDEM

    Public Declare Function timeGetTime Lib "winmm.dll" () As Integer


    Declare Sub PreInit Lib "demintel.dll" Alias "PreInit" (<[In](), Out()> _
    ByRef nEle As Integer, ByRef nWall As Integer, ByVal FileName As String, ByRef lName As Integer)


    Declare Sub Initiate Lib "demintel.dll" Alias "Initiate" (<[In](), Out()> _
    ByRef nEle As Integer, ByRef nActEle As Integer, ByVal xEle() As Double, ByVal yEle() As Double, ByVal qEle() As Double, ByVal nVertex() As Integer, ByVal xVertex(,) As Double, ByVal yVertex(,) As Double, _
    ByVal qVertex(,) As Double, ByVal rVertex(,) As Double, ByVal rEle() As Double, ByVal area() As Double, ByVal MIEle() As Double, ByVal vxEle() As Double, ByVal vyEle() As Double, _
    ByVal vqEle() As Double, ByRef nWall As Integer, ByVal x1Wall() As Double, ByVal x2Wall() As Double, ByVal y1Wall() As Double, ByVal y2Wall() As Double, _
    ByRef dEleMax As Double, ByVal flagPairCohe() As Integer, ByRef alwNEleFrd As Integer, ByRef minREle As Double, ByVal rqCE(,,) As Double, ByVal xCE(,,) As Double, ByVal hSector() As Double, _
    ByRef flagNewTest As Integer, ByVal Params() As Double, ByVal CAC(,) As Double, ByRef volSld As Double, ByVal FileName As String, ByRef lName As Int32)

    Declare Sub Mass Lib "demintel.dll" Alias "Mass" (<[In](), Out()> _
    ByRef nEle As Integer, ByRef nActEle As Integer, ByVal areaEle() As Double, ByVal mGravEle() As Double, ByVal mInertEle() As Double, ByVal MIEle() As Double, ByVal MIInertEle() As Double, _
    ByRef dt As Double, ByRef density As Double, ByRef E As Double, ByRef flagMassNorm As Integer)


    Declare Sub CalPOLY Lib "demintel.dll" Alias "CalPOLY" (<[In](), Out()> _
    ByRef nEle As Integer, ByRef nActEle As Integer, ByVal xEle() As Double, ByVal yEle() As Double, ByVal qEle() As Double, _
    ByVal nVertex() As Integer, ByVal xVertex(,) As Double, ByVal yVertex(,) As Double, ByVal qVertex(,) As Double, ByVal rVertex(,) As Double, _
    ByVal rEle() As Double, ByVal boundEle(,) As Double, ByVal MIEle() As Double, _
    ByVal vxEle() As Double, ByVal vyEle() As Double, ByVal vqEle() As Double, _
    ByRef nWall As Integer, ByVal x1Wall() As Double, ByVal x2Wall() As Double, ByVal y1Wall() As Double, ByVal y2Wall() As Double, _
    ByRef nInc As Integer, ByRef dt As Double, ByRef E As Double, ByRef density As Double, ByVal tanTheta() As Double, ByVal xGravity() As Double, ByVal gXgY() As Double, ByVal monitor() As Double, _
    ByRef globdamp As Double, ByRef rotDamp As Double, ByVal FtPair() As Double, ByVal FtWP(,) As Double, ByRef dampingRatio As Double, ByRef rollingDamp As Double, ByRef flagDebug As Integer, _
    ByVal xCon() As Double, ByVal yCon() As Double, ByVal FxCon() As Double, ByVal FyCon() As Double, ByVal fricRatio() As Double, _
    ByVal tanNorm() As Double, ByVal FRGB(,) As Integer, ByVal rCon() As Double, ByRef nCon As Integer, _
    ByRef nPCon As Integer, ByVal pPlot(,) As Double, ByVal flagConBoun() As Integer, ByVal pairCon(,) As Integer, _
    ByRef nPair As Integer, ByVal pair(,) As Integer, ByRef nWallFrd As Integer, ByVal lWallFrd(,) As Integer, _
    ByVal FxC() As Double, ByVal FyC() As Double, ByVal FMC() As Double, _
    ByRef flagGlue As Integer, ByVal flagPairCohe() As Integer, ByVal dMotionWall() As Double, ByRef actWall As Integer, _
    ByRef actEle As Integer, ByVal xCursor() As Double, ByRef rAnchor As Double, ByRef cosQAnchor As Double, ByRef sinQAnchor As Double, ByRef flagDrag As Integer, _
    ByVal cosQiAM() As Double, ByVal sinQiAM() As Double, ByVal cosQiAN() As Double, ByVal sinQiAN() As Double, _
    ByVal cosQiBM() As Double, ByVal sinQiBM() As Double, ByVal cosQiBN() As Double, ByVal sinQiBN() As Double, _
    ByVal rMA() As Double, ByVal rNA() As Double, ByVal rMB() As Double, ByVal rNB() As Double, ByVal ECohe() As Double, _
    ByRef nPtHL As Integer, ByVal xPtHL(,) As Double, ByVal strgTensl() As Double, ByRef numThread As Integer, ByRef alwNEleFrd As Integer, _
    ByVal mGravEle() As Double, ByVal mInertEle() As Double, ByVal MIInertEle() As Double, ByRef zoomScale As Double, ByVal rqCE(,,) As Double, ByVal xCE(,,) As Double, _
    ByVal hSector() As Double, ByVal limitAll() As Double, ByVal vWall(,) As Double, ByRef aOverAll As Double, ByRef vol As Double, _
     ByRef flagLoadMode As Integer, ByVal intLoadPara(,) As Integer, ByVal realLoadPara(,) As Double, ByVal iCurStep() As Integer, _
     ByVal eleOut() As Integer, ByVal FWall(,) As Double, ByVal iniFWall(,) As Double, ByVal FxWall() As Double, ByVal FyWall() As Double, ByVal FMWall() As Double, ByVal Fx() As Double, ByVal Fy() As Double, ByVal FM() As Double, _
     ByVal iniOri() As Double, ByVal elong() As Double, ByRef flagOutInied As Integer, ByRef factorSlow As Double, _
     ByRef hThinLayer As Double, ByVal flagThinLayer() As Integer, ByRef iDirecCyc As Integer, ByRef flagSpecialLoad As Integer, ByRef qMax As Double, ByRef cDisp As Double, _
     ByRef nLinks As Integer, ByVal iEleLink(,) As Integer, ByVal l0Link() As Double, ByVal kLinkPos() As Double, ByVal kLinkNeg() As Double, ByRef linkDampingRatio As Double)

    Declare Sub DomainLimit Lib "demintel.dll" Alias "DomainLimit" (<[In](), Out()> _
    ByRef nEle As Integer, ByRef nActEle As Integer, ByVal xEle() As Double, ByVal yEle() As Double, ByVal rEle() As Double, _
    ByVal nVertex() As Integer, ByVal xVertex(,) As Double, ByVal yVertex(,) As Double, ByVal boundele(,) As Double, ByVal limitAll() As Double, ByVal hSector() As Double)

    Declare Sub Grid Lib "demintel.dll" Alias "Grid" (<[In](), Out()> _
    ByRef nEle As Integer, ByRef nActEle As Integer, ByVal nVertex() As Integer, ByVal xEle() As Double, ByVal yEle() As Double, ByVal rEle() As Double, ByVal xVertex(,) As Double, _
    ByVal yVertex(,) As Double, ByRef nGridX As Integer, ByRef nGridY As Integer, ByVal nEleGrid(,) As Integer, ByVal lEG(,,) As Integer, ByRef xGrid As Double, _
     ByVal boundEle(,) As Double, ByVal limitAll() As Double, ByRef maxNEleGrid As Integer)


    Declare Sub Confinement Lib "demintel.dll" Alias "Confinement" (<[In](), Out()> _
    ByRef nEle As Integer, ByVal xEle() As Double, ByVal yEle() As Double, ByVal rEle() As Double, _
    ByVal nVertex() As Integer, ByVal xVertex(,) As Double, ByVal yVertex(,) As Double, ByVal boundEle(,) As Double, ByVal limitAll() As Double, _
    ByRef pInt As Double, ByRef nPCon As Integer, ByVal pPlot(,) As Double, _
    ByVal FxC() As Double, ByVal FyC() As Double, ByVal FMC() As Double, ByRef nGridX As Integer, ByRef nGridY As Integer, _
    ByVal NEleGrid(,) As Integer, ByVal lEG(,,) As Integer, ByRef xGrid As Double, ByRef flagDebug As Integer, ByRef maxNEleGrid As Integer, ByRef vol As Double, _
    ByVal pairCon(,) As Integer, ByRef nWall As Integer, ByVal iniFWall(,) As Double, ByVal x1Wall() As Double, ByVal x2Wall() As Double, ByVal y1Wall() As Double, ByVal y2Wall() As Double, _
    ByRef flagLoadMode As Integer, ByVal intLoadPara(,) As Integer, ByVal realLoadPara(,) As Double, ByVal iCurStep() As Integer)


    Declare Sub EleFrd Lib "demintel.dll" Alias "EleFrd" (<[In](), Out()> _
    ByRef nEle As Integer, ByVal xEle() As Double, ByVal yEle() As Double, ByVal rEle() As Double, ByVal nVertex() As Integer, _
    ByVal xVertex(,) As Double, ByVal yVertex(,) As Double, ByVal pair(,) As Integer, ByRef nPair As Integer, ByRef nGridX As Integer, _
    ByRef nGridY As Integer, ByVal nEleGrid(,) As Integer, ByVal lEG(,,) As Integer, ByRef maxGap As Double, _
    ByVal nEleFrd() As Integer, ByVal pairIndex(,,) As Integer, _
    ByRef oldNPair As Integer, ByVal oldPair(,) As Integer, ByVal oldNEleFrd() As Integer, ByVal oldPairIndex(,,) As Integer, _
    ByRef alwNEleFrd As Integer, ByRef maxNEleFrd As Integer, ByRef flag1stEF As Integer, ByRef maxNEleGrid As Integer, _
    ByVal hSector() As Double)

    Declare Sub WallFrd Lib "demintel.dll" Alias "WallFrd" (<[In](), Out()> _
    ByRef nEle As Integer, ByRef nActEle As Integer, ByVal xEle() As Double, ByVal yEle() As Double, ByVal rEle() As Double, ByVal nVertex() As Integer, _
    ByVal xVertex(,) As Double, ByVal yVertex(,) As Double, ByRef nWall As Integer, ByVal x1Wall() As Double, ByVal x2Wall() As Double, ByVal y1Wall() As Double, _
    ByVal y2Wall() As Double, ByRef nWallFrd As Integer, ByVal lWallFrd(,) As Integer, ByRef maxGap As Double, ByVal hSector() As Double, ByRef flagDebug As Integer)

    Declare Sub InheritPair Lib "demintel.dll" Alias "InheritPair" (<[In](), Out()> _
    ByRef nEle As Integer, ByRef nPair As Integer, ByRef oldNFrd As Integer, ByVal pair(,) As Integer, ByVal oldPair(,) As Integer, _
    ByVal nEleFrd() As Integer, ByVal oldNEleFrd() As Integer, ByVal pairIndex(,,) As Integer, ByVal oldPairIndex(,,) As Integer, _
    ByVal FtPair() As Double, ByVal oldFtpair() As Double, ByVal flagPairCohe() As Integer, ByVal oldFlagPairCohe() As Integer, _
    ByVal cosQiAM() As Double, ByVal oldCosQiAM() As Double, ByVal sinQiAM() As Double, ByVal oldSinQiAM() As Double, ByVal cosQiAN() As Double, ByVal oldCosQiAN() As Double, _
    ByVal sinQiAN() As Double, ByVal oldSinQiAN() As Double, ByVal cosQiBM() As Double, ByVal oldCosQiBM() As Double, ByVal sinQiBM() As Double, ByVal oldSinQiBM() As Double, _
    ByVal cosQiBN() As Double, ByVal oldCosQiBN() As Double, ByVal sinQiBN() As Double, ByVal oldSinQiBN() As Double, ByVal rMA() As Double, ByVal oldRMA() As Double, ByVal rNA() As Double, ByVal oldRNA() As Double, _
    ByVal rMB() As Double, ByVal oldRMB() As Double, ByVal rNB() As Double, ByVal oldRNB() As Double, _
    ByVal ECohe() As Double, ByVal oldECohe() As Double, ByVal strgTensl() As Double, ByVal oldStrgTensl() As Double, ByRef alwNEleFrd As Integer)

    Declare Sub Snapshot Lib "demintel.dll" Alias "Snapshot" (<[In](), Out()> _
     ByRef nEle As Integer, ByRef nActEle As Integer, ByVal xEle() As Double, ByVal yEle() As Double, ByVal rEle() As Double, ByVal nVertex() As Integer, _
     ByVal xVertex(,) As Double, ByVal yVertex(,) As Double, ByVal CAC(,) As Double, ByRef nWall As Integer, ByVal x1Wall() As Double, ByVal x2Wall() As Double, _
     ByVal y1Wall() As Double, ByVal y2Wall() As Double, ByVal params() As Double, ByVal FileName As String, ByRef lName As Integer)

    Declare Sub WriteResult Lib "demintel.dll" Alias "WriteResult" (<[In](), Out()> _
    ByRef nEle As Integer, ByRef nActEle As Integer, ByVal xEle() As Double, ByVal yEle() As Double, ByVal qEle() As Double, _
     ByVal vxEle() As Double, ByVal vyEle() As Double, ByVal vqEle() As Double, _
    ByRef nWall As Integer, ByVal x1Wall() As Double, ByVal x2Wall() As Double, ByVal y1Wall() As Double, ByVal y2Wall() As Double, _
    ByRef nCon As Integer, ByVal xCon() As Double, ByVal yCon() As Double, ByVal rCon() As Double, ByVal FxCon() As Double, _
    ByVal FyCon() As Double, ByVal fricRatio() As Double, ByVal tanNorm() As Double, ByVal flagConBoun() As Integer, ByVal pairCon(,) As Integer, _
    ByRef nPtHL As Integer, ByVal xPtHL(,) As Double, ByVal strgTensl() As Double, _
    ByVal strgRatio() As Double, ByVal Params() As Double, ByRef alwNEleFrd As Integer, ByRef flagWriteOpen As Integer, ByVal iCurStep() As Integer, _
    ByVal FileName As String, ByRef lName As Int32)

    Declare Sub ReadResult Lib "demintel.dll" Alias "ReadResult" (<[In](), Out()> _
    ByRef nEle As Integer, ByRef nActEle As Integer, ByVal xEle() As Double, ByVal yEle() As Double, ByVal qEle() As Double, _
     ByVal vxEle() As Double, ByVal vyEle() As Double, ByVal vqEle() As Double, _
     ByVal qVertex(,) As Double, ByVal rVertex(,) As Double, ByVal xVertex(,) As Double, ByVal yVertex(,) As Double, _
    ByVal rqCE(,,) As Double, ByVal xCE(,,) As Double, ByVal nVertex() As Integer, _
    ByRef nWall As Integer, ByVal x1Wall() As Double, ByVal x2Wall() As Double, ByVal y1Wall() As Double, ByVal y2Wall() As Double, _
    ByRef nCon As Integer, ByVal xCon() As Double, ByVal yCon() As Double, ByVal rCon() As Double, ByVal FxCon() As Double, ByVal FyCon() As Double, _
    ByVal fricRatio() As Double, ByVal tanNorm() As Double, ByVal flagConBoun() As Integer, ByVal pairCon(,) As Integer, ByVal FRGB(,) As Integer, _
    ByRef nPtHL As Integer, ByVal xPtHL(,) As Double, ByVal strgTensl() As Double, ByVal strgRatio() As Double, ByVal Params() As Double, ByRef alwNEleFrd As Integer, _
    ByRef nStep As Integer, ByRef preStep As Integer, ByRef iStep As Integer, _
    ByRef flagReadOpen As Integer, ByRef verRead As Integer, ByVal iCurStep() As Integer, ByVal FileName As String, ByRef lName As Int32)

    Declare Sub ReadTrace Lib "demintel.dll" Alias "ReadTrace" (<[In](), Out()> _
    ByRef nEle As Integer, ByRef nActEle As Integer, ByRef nWall As Integer, ByVal xEleTrace(,) As Double, ByVal yEleTrace(,) As Double, ByVal qEleTrace(,) As Double, ByRef nStep As Integer, ByRef verRead As Integer, _
     ByVal rSldTrace(,) As Single, ByVal qSldTrace(,) As Single, ByVal frSldTrace(,) As Single, ByVal normSldTrace(,) As Single, ByVal eleSldTrace(,) As Integer, ByVal CBSldTrace(,) As Integer, ByVal nConSldTrace() As Integer, _
     ByVal x1Wall() As Double, ByVal x2Wall() As Double, ByVal y1Wall() As Double, ByVal y2Wall() As Double, _
     ByVal xCon() As Double, ByVal yCon() As Double, ByVal fricRatio() As Double, ByVal tanNorm() As Double, ByVal pairCon(,) As Integer, ByVal flagConBoun() As Integer)

    Declare Sub PlotSldTrace Lib "demintel.dll" Alias "PlotSldTrace" (<[In](), Out()> _
    ByRef nEle As Integer, ByRef nActEle As Integer, ByRef nWall As Integer, ByRef iStep As Integer, ByRef jStep As Integer, _
     ByRef nStep As Integer, ByVal xEle() As Double, ByVal yEle() As Double, ByVal qEle() As Double, ByVal rSldTrace(,) As Single, ByVal qSldTrace(,) As Single, ByVal frSldTrace(,) As Single, _
     ByVal normSldTrace(,) As Single, ByVal eleSldTrace(,) As Integer, ByVal CBSldTrace(,) As Integer, ByVal nConSldTrace() As Integer, _
     ByVal x1Wall() As Double, ByVal x2Wall() As Double, ByVal y1Wall() As Double, ByVal y2Wall() As Double, ByRef nPlotSld As Integer, ByRef nPlotRol As Integer, _
     ByVal xPlotSld(,) As Single, ByVal xPlotRol(,) As Single)

    Declare Sub IniGD Lib "demintel.dll" Alias "IniGD" (<[In](), Out()> _
    ByRef nEle As Integer, ByVal xEle() As Double, ByVal yEle() As Double, ByVal rEle() As Double, ByVal qEle() As Double, ByVal nVertex() As Integer, ByVal xVertex(,) As Double, _
    ByVal yVertex(,) As Double, ByVal limitAll() As Double, ByRef nGridX As Integer, ByRef nGridY As Integer, ByVal nEleGrid(,) As Integer, ByVal lEG(,,) As Integer, _
    ByRef wCellGD As Double, ByRef xGrid As Double, ByRef maxNEleGrid As Integer, ByRef nHLine As Integer, ByRef nVLine As Integer, _
    ByVal nHPtGD() As Integer, ByVal nVPtGD() As Integer, ByVal iHElePtGD(,) As Integer, ByVal iVElePtGD(,) As Integer, ByVal rqiHPtGD(,,) As Double, ByVal rqiVPtGD(,,) As Double, _
    ByVal xHPtGD(,,) As Double, ByVal xVPtGD(,,) As Double, ByVal flagDyeGrid() As Integer)

    Declare Sub UdGD Lib "demintel.dll" Alias "UdGD" (<[In](), Out()> _
    ByRef nEle As Integer, ByVal xEle() As Double, ByVal yEle() As Double, ByVal qEle() As Double, ByRef nHLine As Integer, ByRef nVLine As Integer, _
    ByVal nHPtGD() As Integer, ByVal nVPtGD() As Integer, ByVal iHElePtGD(,) As Integer, ByVal iVElePtGD(,) As Integer, ByVal rqiHPtGD(,,) As Double, ByVal rqiVPtGD(,,) As Double, _
    ByVal xHPtGD(,,) As Double, ByVal xVPtGD(,,) As Double)


    Declare Sub ColorDeform Lib "demintel.dll" Alias "ColorDeform" (<[In](), Out()> _
    ByRef nEle As Integer, ByRef nActEle As Integer, ByVal xEleTrace(,) As Double, ByVal yEleTrace(,) As Double, ByVal qEleTrace(,) As Double, _
    ByVal rangeContour() As Double, ByRef relaMin As Double, ByRef relaMax As Double, _
    ByRef nStep As Integer, ByRef iStep As Integer, ByRef jStep As Integer, ByRef iMode As Integer, ByRef jMode As Integer, _
    ByRef kMode As Integer, ByRef mMode As Integer, ByVal TraceRGB(,) As Integer, ByVal ptcStress(,) As Double, ByVal areaEle() As Double, _
    ByVal iniOri() As Double, ByVal Ori() As Double, ByRef refOri As Double, ByVal numECon() As Integer)


    Declare Sub IniOrient Lib "demintel.dll" Alias "IniOrient" (<[In](), Out()> _
    ByRef nEle As Integer, ByRef nActEle As Integer, ByVal xEle() As Double, ByVal yEle() As Double, ByVal nVertex() As Integer, _
    ByVal xVertex(,) As Double, ByVal yVertex(,) As Double, ByVal qiVertex(,) As Double, ByVal rVertex(,) As Double, ByVal rEle() As Double, _
    ByVal qEle() As Double, ByVal hSector() As Double, ByVal rqCE(,,) As Double, ByVal xCE(,,) As Double, ByVal boundEle(,) As Double, ByVal iniOri() As Double, ByVal elong() As Double)


    Declare Sub Histogram Lib "demintel.dll" Alias "Histogram" (<[In](), Out()> _
    ByRef nEle As Integer, ByRef nActEle As Integer, ByVal xEle() As Double, ByVal yEle() As Double, ByVal mInertEle() As Double, ByVal qEle() As Double, ByVal iniOri() As Double, ByVal Ori() As Double, _
    ByVal elong() As Double, ByVal nVertex() As Integer, ByRef nCon As Integer, ByVal xCon() As Double, ByVal yCon() As Double, _
    ByVal FxCon() As Double, ByVal FyCon() As Double, ByVal FCon() As Double, ByVal flagConBoun() As Integer, ByVal FAngle() As Double, ByVal fricRatio() As Double, ByVal tanNorm() As Double, ByVal qNorm() As Double, _
    ByRef nNodeMask As Integer, ByVal Mask() As Integer, ByVal BinForce() As Double, ByVal BinOri() As Double, ByVal BinFR() As Double, ByVal BinNorm() As Double, ByVal BinSlideNorm() As Double, ByVal BinFN() As Double, ByVal BinFT() As Double, _
    ByVal BinRoseFR() As Double, ByRef iHistMode As Integer, _
    ByRef iWeight As Integer, ByRef jWeight As Integer, ByRef iBoundMode As Integer, ByVal flagFMask() As Integer, ByVal flagEmask() As Integer, _
    ByRef nBinForce As Integer, ByRef nBinOri As Integer, ByRef nBinFR As Integer, ByRef nBinNorm As Integer, _
    ByVal ptBinF(,) As Single, ByVal ptBinE(,) As Single, ByVal ptBinFR(,) As Single, ByVal ptBinNorm(,) As Single, ByVal ptBinSlideNorm(,) As Single, _
    ByVal ptBinFN(,) As Single, ByVal ptBinFT(,) As Single, ByVal ptBinRoseFR(,) As Single, _
    ByVal tsFabric() As Double, ByVal tsStress() As Double, ByVal tsConNorm() As Double, ByRef numContact As Double, ByVal pairCon(,) As Integer, _
    ByRef flagOutput As Integer, ByRef vol As Double, ByVal iCurStep() As Integer, ByVal ptcStress(,) As Double, ByRef nEleMask As Integer, ByRef factorSldNorm As Double, ByRef scalePolar As Single)

    Declare Sub MaskCrop Lib "demintel.dll" Alias "MaskCrop" (<[In](), Out()> _
    ByRef nEle As Integer, ByRef nActEle As Integer, ByVal xEle() As Double, ByVal yEle() As Double, ByVal flagEMask() As Integer, _
    ByVal xMaskCrop(,) As Double, ByRef nPtMaskCrop As Integer, ByRef nEleMasked As Integer)

    Declare Sub Crop Lib "demintel.dll" Alias "Crop" (<[In](), Out()> _
    ByRef nEle As Integer, ByRef nActEle As Integer, ByVal xEle() As Double, ByVal yEle() As Double, ByVal rEle() As Double, ByVal nVertex() As Integer, _
     ByVal xVertex(,) As Double, ByVal yVertex(,) As Double, ByVal CAC(,) As Double, ByVal flagEMask() As Integer)

    Declare Sub ReadBatchLoad Lib "demintel.dll" Alias "ReadBatchLoad" (<[In](), Out()> _
    ByVal intLoadPara(,) As Integer, ByVal realLoadPara(,) As Double, ByVal FileName As String, ByRef lName As Int32)

    Declare Sub ReadAngFile Lib "demintel.dll" Alias "ReadAngFile" (<[In](), Out()> _
    ByRef nAng As Integer, ByVal angSequence() As Double, ByVal FileName As String, ByRef lName As Int32)

    Declare Sub IniOutput Lib "demintel.dll" Alias "IniOutput" (<[In](), Out()> _
    ByVal EleOut() As Integer, ByVal EleMaskout(,) As Integer, ByVal Filename As String, ByRef lName As Int32, ByVal curDir As String, ByRef lCurDir As Int32)

    Declare Sub ParticleStress Lib "demintel.dll" Alias "ParticleStress" (<[In](), Out()> _
    ByRef nEle As Integer, ByRef nActEle As Integer, ByVal xEle() As Double, ByVal yEle() As Double, ByVal areaEle() As Double, ByRef nCon As Integer, ByVal xCon() As Double, ByVal yCon() As Double, _
    ByVal FxCon() As Double, ByVal FyCon() As Double, ByVal flagConBoun() As Integer, ByVal pairCon(,) As Integer, ByVal ptcStress(,) As Double)

    Declare Sub AutoCellCenter Lib "demintel.dll" Alias "AutoCellCenter" (<[In](), Out()> _
    ByRef numCell As Integer, ByVal xPt(,) As Double, ByVal iEleCell() As Integer, ByRef nEle As Integer, _
    ByVal xEle() As Double, ByVal yEle() As Double, ByVal limitAll() As Double, ByRef xGrid As Double, ByRef nGridX As Integer, ByRef nGridY As Integer, ByVal nEleGrid(,) As Integer, _
    ByVal lEG(,,) As Integer, ByRef maxNEleGrid As Integer, ByVal flagEffCell() As Integer)

    Declare Sub IniStrainCell Lib "demintel.dll" Alias "IniStrainCell" (<[In](), Out()> _
    ByRef numCell As Integer, ByVal iEleCell() As Integer, ByRef rStrainCell As Double, ByRef nEle As Integer, ByVal xEle() As Double, ByVal yEle() As Double, ByVal areaEle() As Double, _
     ByVal limitAll() As Double, ByRef xGrid As Double, ByRef nGridX As Integer, ByRef nGridY As Integer, ByVal nEleGrid(,) As Integer, ByVal lEG(,,) As Integer, ByRef maxNEleGrid As Integer, ByVal eleStnCell(,) As Integer, _
     ByVal eleBuffer() As Integer, ByRef nEleTop As Integer, ByVal wgtBuffer() As Double, ByVal flagEffCell() As Integer)

    Declare Sub StrainCell Lib "demintel.dll" Alias "StrainCell" (<[In](), Out()> _
    ByRef nEle As Integer, ByVal xEleTrace(,) As Double, ByVal yEleTrace(,) As Double, ByVal vXEle() As Double, ByVal vYEle() As Double, _
     ByRef nStep As Integer, ByRef iStep As Integer, ByRef jStep As Integer, ByVal strainOut() As Double, ByVal drctStn() As Double, ByVal AreaCell() As Double, ByRef numCell As Integer, ByVal eleStnCell(,) As Integer, _
     ByVal flagEffCell() As Integer, ByRef flagStnOut As Integer, ByRef flagDrctStnOut As Integer, ByRef flagStnMode As Integer, ByRef angN As Double)

    Declare Sub MaskStrainCell Lib "demintel.dll" Alias "MaskStrainCell" (<[In](), Out()> _
    ByRef numCell As Integer, ByRef nActCell As Integer, ByRef nEle As Integer, _
    ByVal xEle() As Double, ByVal yEle() As Double, ByVal eleStnCell(,) As Integer, ByVal cellAct() As Integer, ByVal flagEffCell() As Integer, _
    ByRef nNodeMask As Integer, ByVal Mask() As Integer)


    Declare Sub DrawRange Lib "demintel.dll" Alias "DrawRange" (<[In](), Out()> _
    ByRef nEle As Integer, ByRef nActEle As Integer, ByVal limitAll() As Double, _
    ByRef xGrid As Double, ByRef nGridX As Integer, ByRef nGridY As Integer, ByVal xCanvas() As Double, ByRef nEleV As Integer, ByRef nConV As Integer, _
        ByRef nCon As Integer, ByVal xCon() As Double, ByVal yCon() As Double, ByVal EleView() As Integer, ByVal ConView() As Integer, ByRef flagShowCon As Integer, _
       ByVal nEleGrid(,) As Integer, ByVal lEG(,,) As Integer, ByRef maxNEleGrid As Integer)

    Declare Sub CoordNum Lib "demintel.dll" Alias "CoordNum" (<[In](), Out()> _
    ByRef nEle As Integer, ByRef nActEle As Integer, ByRef nCon As Integer, ByVal flagConBoun() As Integer, ByVal pairCon(,) As Integer, ByVal numECon() As Integer)

    Declare Sub IniDelaunay Lib "demintel.dll" Alias "IniDelaunay" (<[In](), Out()> _
    ByRef nEle As Integer, ByRef nActEle As Integer, ByVal xEle() As Double, ByVal yele() As Double, _
    ByRef numCell As Integer, ByVal eleStnCell(,) As Integer, ByVal flagEffCell() As Integer, _
    ByRef nVMax As Integer, ByRef nFMax As Integer, ByRef nHMax As Integer, ByRef nKMax As Integer, ByRef nJMax As Integer, ByRef nPMax As Integer, _
    ByVal ix() As Integer, ByVal iy() As Integer, ByVal ix2() As Integer, ByVal iy2() As Integer, ByVal iss() As Integer, ByVal icon(,) As Integer, ByVal id() As Integer, ByVal iave() As Integer, ByVal iaze() As Integer)

    Declare Sub StrainDelaunay Lib "demintel.dll" Alias "StrainDelaunay" (<[In](), Out()> _
    ByRef nEle As Integer, ByRef nActEle As Integer, ByVal xEle() As Double, ByVal yEle() As Double, ByRef nCon As Integer, ByVal pairCon(,) As Integer, ByVal flagConBoun() As Integer, _
    ByRef numCell As Integer, ByVal eleStnCell(,) As Integer, ByVal flagEffCell() As Integer, _
    ByRef nEffEle As Integer, ByVal xEffEle(,) As Double, ByVal iNdStn() As Integer, ByVal TILStn(,) As Integer, ByVal TNBRStn(,) As Integer, ByVal mapEffEle() As Integer, ByVal nConPEleStn() As Integer)


    Declare Sub VoidCell Lib "demintel.dll" Alias "VoidCell" (<[In](), Out()> _
    ByRef nEle As Integer, ByRef nActEle As Integer, ByRef nCon As Integer, _
    ByRef maxConAll As Integer, ByRef maxConPEle As Integer, ByRef maxEdgePEle As Integer, _
    ByVal xEle() As Double, ByVal yEle() As Double, ByVal xCon() As Double, ByVal yCon() As Double, ByVal pairCon(,) As Integer, ByVal flagConBoun() As Integer, _
    ByRef nEffCon As Integer, ByVal xEffCon(,) As Double, ByVal effCon2Glob() As Integer, ByVal iEleEffCon(,) As Integer, _
    ByRef nTriAllCon As Integer, ByVal iConTriAllCon(,) As Integer, ByVal iEConTriAllCon(,) As Integer, ByVal fgDeadTri() As Integer, _
    ByVal nConPEle() As Integer, ByVal iConPEle(,) As Integer, ByVal iConCellInEle(,) As Integer, ByRef nCellInEle As Integer, _
    ByRef nDlnBound As Integer, ByVal iConDlnBound(,) As Integer, ByVal iEleDlnBound() As Integer, ByVal nGstDlnBound() As Integer, ByVal iEffGstDlnBound(,) As Integer, _
    ByRef nEdgeAll As Integer, ByVal fgEffEdge() As Integer, ByVal iEleEffEdge() As Integer, ByVal nEdgePt() As Integer, ByVal jPtEdgeiPt(,) As Integer, _
    ByVal iEdgeiPt(,) As Integer, ByVal iPtEdge(,) As Integer, ByVal iCellEdge(,) As Integer, ByVal iEdgeCell(,) As Integer, ByVal fgSolidCell() As Integer, _
    ByVal iVCCell() As Integer, ByRef nVC As Integer, ByVal mapVC() As Integer, ByVal nCellVC() As Integer, ByVal iCellVC(,) As Integer, ByVal nEConVC() As Integer, ByVal iEConVC(,) As Integer, _
    ByVal maxNGrid() As Integer, ByRef maxDlnPGrid As Integer, ByVal nDlnBPGrid(,) As Integer, ByVal iDlnBPGrid(,,) As Integer, _
    ByVal nSldTriPVC() As Integer, ByVal iEConSldTri(,,) As Integer, ByVal xSldCell(,) As Double, ByVal fgSeenMe() As Integer, ByVal fgBridgeEdge() As Integer, _
    ByVal fgBndEle() As Integer, ByVal fgBndVC() As Integer, ByVal xVC(,) As Double, _
    ByRef flagMask As Integer, ByRef flagWeight As Integer, ByRef nNodeMask As Integer, ByVal Mask() As Integer, _
    ByVal flagVCMask() As Integer, ByVal vecVV(,) As Double, ByVal rqVV(,) As Double, ByRef nBinVV As Integer, ByVal binVV() As Double, ByVal tsVV(,) As Double, _
    ByVal xPtEff(,) As Double, ByVal iNd2() As Integer, ByVal TIL(,) As Integer, ByVal TNBR(,) As Integer)


    Declare Sub ExportCon Lib "demintel.dll" Alias "ExportCon" (<[In](), Out()> _
    ByRef nEle As Integer, ByRef nCon As Integer, _
    ByVal FCon() As Double, ByVal fricRatio() As Double, ByVal qNorm() As Double, ByVal flagFMask() As Integer, ByRef iStep As Integer)


    Declare Sub RotateArray Lib "demintel.dll" Alias "RotateArray" (<[In](), Out()> _
    ByRef nMax As Integer, ByRef nEle As Integer, ByRef ang As Double, ByVal x() As Double, ByVal y() As Double, ByVal Rx() As Double, ByVal Ry() As Double)

    Declare Sub RotatePPlot Lib "demintel.dll" Alias "RotatePPlot" (<[In](), Out()> _
    ByRef nMax As Integer, ByRef nCon As Integer, ByRef ang As Double, ByVal RpPlotx(,) As Double, ByVal pPlot(,) As Double)

    Declare Sub Rotate2DArray Lib "demintel.dll" Alias "Rotate2DArray" (<[In](), Out()> _
    ByRef nMax As Integer, ByRef maxChild As Integer, _
    ByRef nEle As Integer, ByVal nChild() As Integer, ByRef ang As Double, ByVal x(,) As Double, ByVal y(,) As Double, ByVal Rx(,) As Double, ByVal Ry(,) As Double)

    Declare Sub RConfinement Lib "demintel.dll" Alias "RConfinement" (<[In](), Out()> _
    ByRef nEle As Integer, ByVal xEle() As Double, ByVal yEle() As Double, ByVal rEle() As Double, ByVal nVertex() As Integer, _
    ByVal xVertex(,) As Double, ByVal yVertex(,) As Double, ByVal boundEle(,) As Double, ByVal limitAll() As Double, _
    ByRef pInt As Double, ByRef nPCon As Integer, ByVal pPlot(,) As Double, ByVal FxC() As Double, ByVal FyC() As Double, ByVal FMC() As Double, _
    ByRef nGridX As Integer, ByRef nGridY As Integer, ByVal nEleGrid(,) As Integer, ByVal lEG(,,) As Integer, ByRef xGrid As Double, ByRef maxNEleGrid As Integer, ByRef vol As Double, _
    ByVal pairCon(,) As Integer, ByVal PStress() As Double)

    Declare Sub InitPauseFile Lib "demintel.dll" Alias "InitPauseFile" (<[In](), Out()> _
    ByVal curDir As String, ByRef lCurDir As Integer)

    Declare Sub ReadPauseFile Lib "demintel.dll" Alias "ReadPauseFile" (<[In](), Out()> _
    ByRef flagPause As Integer, ByVal curDir As String, ByRef lCurDir As Integer)

    Declare Sub ImportLinks Lib "demintel.dll" Alias "ImportLinks" (<[In](), Out()> _
    ByRef nLinks As Integer, ByRef minR As Double, ByRef maxR As Double, ByVal iEleLink(,) As Integer, ByVal l0Link() As Double, ByVal kLinkPos() As Double, ByVal kLinkNeg() As Double, _
    ByRef nEle As Integer, ByVal xEle() As Double, ByVal yEle() As Double, ByVal rEle() As Double, ByRef nActEle As Integer, _
    ByVal FileName As String, ByRef lName As Int32)

    Declare Sub ExPortLinks Lib "demintel.dll" Alias "ExportLinks" (<[In](), Out()> _
    ByRef nLinks As Integer, ByVal iEleLink(,) As Integer, ByVal l0Link() As Double, ByVal kLinkPos() As Double, ByVal kLinkNeg() As Double, _
    ByRef nEle As Integer, ByVal xEle() As Double, ByVal yEle() As Double, _
    ByVal FileName As String, ByRef lName As Int32)

    Declare Sub ImportLinksByID Lib "demintel.dll" Alias "ImportLinksByID" (<[In](), Out()> _
    ByRef nLinks As Integer, ByVal iEleLink(,) As Integer, ByVal l0Link() As Double, ByVal kLinkPos() As Double, ByVal kLinkNeg() As Double, _
    ByRef nEle As Integer, ByVal xEle() As Double, ByVal yEle() As Double, _
    ByVal FileName As String, ByRef lName As Int32)

    Declare Sub BoxCN Lib "demintel.dll" Alias "BoxCN" (<[In](), Out()> _
    ByRef x As Double, ByRef y As Double, ByRef lBox As Double, ByRef CN As Double,
    ByRef nEle As Integer, ByRef nActEle As Integer, ByVal xEle() As Double, ByVal yEle() As Double, _
    ByRef nCon As Integer, ByVal xCon() As Double, ByVal yCon() As Double, ByVal flagConBoun() As Integer, ByVal pairCon(,) As Integer, ByVal flagEMask() As Integer)

    Declare Sub ColorValue Lib "demintel.dll" Alias "ColorValue" (<[In](), Out()> _
    ByRef rValue As Double, ByRef rMin As Double, ByRef rMax As Double, ByVal RGB() As Integer)

    Declare Sub CalMinDist Lib "demintel.dll" Alias "CalMinDist" (<[In](), Out()> _
    ByRef nEle As Integer, ByRef nEle As Integer, ByVal xEle() As Double, ByVal yEle() As Double, ByVal rEle() As Double, ByVal nVertex() As Integer, _
    ByVal pair(,) As Integer, ByRef nPair As Integer, ByRef alwNEleFrd As Integer, _
    ByVal nDistEle() As Integer, ByVal distEle(,) As Double, ByVal meanDist() As Double, ByVal stdevDist() As Double)


#Const USEKEY = 0
#Const STRESSROTATE = 1

    Public nEle As Integer
    Public nActEle As Integer = 0
    Public alwNEleFrd As Integer = 25
    Public limitAll() As Double = New Double(3) {}

    Public vol As Double
    Public volSld As Double   ' total volume/mass of solids/particles
    Public aOverAll As Double
    Public pInt As Double = 2
    Public nPCon As Integer
    Public pPlot(,) As Double = New Double(3, 14999) {}


    Public Params() As Double = New Double(19) {}

    Public nWall As Integer
    Public dEleMax As Double
    Public dxWall As Double

    Public nGridX As Integer
    Public nGridY As Integer
    Public nEleGrid As Integer(,)
    Public lEG As Integer(,,)
    Public xGrid As Double
    Public maxNEleGrid As Integer = 100

    Public maxGap As Double
    Public nPair As Integer
    Public oldNPair As Integer
    Public nWallFrd As Integer

    Public nCon As Integer

    Public scalePolar As Single = 6.0
    Public zoomScale As Single
    Public FLenScale As Double
    Public FThickScale As Double
    Public SlidScale As Double
    Public pScale As Double = 1
    Public factorContrast As Double
    Public factorLenThick As Double
    Public factorSlid As Double
    Public rotationScale As Double = 1.0
    Public maxForce As Double

    Public scaleVel As Double = 1

    Public xOrigin As Integer = 0
    Public yOrigin As Integer = 0
    Public xOriginStart As Integer
    Public yOriginStart As Integer
    Public xDragStart As Integer
    Public yDragStart As Integer
    Public flagMove As Integer = 0
    Dim xMeasure0 As Single
    Dim yMeasure0 As Single
    Dim xMeasure1 As Single
    Dim yMeasure1 As Single
    Dim distMeasure As Double
    Dim angMeasure As Double

    Public nInc As Integer
    Public stiff As Double
    Public density As Double = 2400
    Public tanTheta() As Double = New Double(1) {}
    Public d_PPCOF As Double = 0
    Public dt As Double
    Public factorSlow As Double = 1
    Public dtCrit As Double
    Public globdamp As Double
    Public rotDamp As Double
    Public dampingRatio As Double
    Public rollingDamp As Double
    Public xGravity() As Double = New Double(1) {}
    Public gXgY() As Double = New Double(1) {}

    Public flagDebug As Integer
    Public flagF As Integer
    Public flagMassNorm As Integer = 0
    Public flag1stEF As Integer


    Public monitor() As Double = New Double(4) {}
    Public maxVEle As Double
    Public minREle As Double
    Public iCurStep() As Integer = New Integer(3) {0, 0, 0, 0}
    ' iCurrentStep(0) is the step number of the entire simulation; 
    ' iCurrentStep(1) is the step number of the batched loading
    ' iCurrentStep(2) is the substep number within each batch; 
    ' iCurrentStep(3) is the flag wheter this step needs output
    '

    Public maxNEleFrd As Integer

    Public pen As Pen = New Pen(Color.FromArgb(10, 20, 30), 1)
    Public brush As Pen = New Pen(Color.Red)
    Public penblk As Pen = New Pen(Color.BlueViolet)
    Public penForce As Pen = New Pen(Color.DarkOrange, 3)
    Public penForceColor As Pen = New Pen(Color.DarkGreen)
    Public penP As Pen = New Pen(Color.FromArgb(255, 27, 20, 100))
    Public penAct As Pen
    Public penHL As Pen = New Pen(Color.FromArgb(255, 234, 135, 2), 3)
    Public brushPoint As Brush = Brushes.Brown
    Public penActWall As Pen = New Pen(Color.DarkRed, 3)
    Public penInactWall As Pen = New Pen(Color.DarkGoldenrod, 2)
    Public penFrd As Pen = New Pen(Color.DarkBlue)
    Public penWall As Pen
    Public penGreen As Pen = New Pen(Color.Green, 3)
    Public brushRotation As Brush
    Public penTrace As Pen
    Public penRed As Pen = New Pen(Color.Red)
    Public penBlue As Pen = New Pen(Color.Blue)
    Public penGD As Pen = New Pen(Color.Brown, 3)
    Public penGD2 As Pen = New Pen(Color.White, 3)
    Public brushContour As SolidBrush = New SolidBrush(Color.AliceBlue)
    Public brushBlue As SolidBrush = New SolidBrush(Color.FromArgb(150, 20, 60, 240))
    Public brushMask As SolidBrush = New SolidBrush(Color.FromArgb(200, 255, 145, 0))
    Public brushHLMask As SolidBrush = New SolidBrush(Color.FromArgb(75, 20, 40, 255))
    Public brushTransGray As SolidBrush = New SolidBrush(Color.FromArgb(230, 180, 180, 180))
    Public brushSldTrace As SolidBrush
    Public penStrain As Pen

    Public FileName As String
    Public lName As Int32

    Public curDir As String
    Public lCurDir As Integer

    Public actWall As Integer = 0
    Public dAngle As Double
    Public sinO As Double
    Public cosO As Double
    Public sinD As Double
    Public cosD As Double
    Public lWall As Double
    Public x0Wall As Double
    Public y0Wall As Double
    Public cosN As Double
    Public sinN As Double

    Public flagGlue As Integer = 0

    Public dMotionWall() As Double = New Double(3) {}  '(dx1,dy1,dx2,dy2)

    Public actEle As Integer = 0
    Public distActEle As Double
    Public xEleStart() As Double = New Double(1) {}
    Public xCursorStart() As Double = New Double(1) {}
    Public flagEleDrag As Integer = 0
    Public rAnchor As Double
    Public qAnchor As Double
    Public cosQAnchor As Double
    Public sinQAnchor As Double
    Public xCursor() As Double = New Double(1) {}




    Public nPtHL As Integer = 0
    Public xPtHL(,) As Double = New Double(1, 10 * nEle - 1) {} ' points to highlight

    Public numThreads As Integer = 1
    Public timeNow() As Integer = New Integer(8) {}
    Public action As String
    Public lAction As Long

    Public xEle As Double()
    Public yEle As Double()
    Public qEle() As Double = New Double(3) {}
    Public iniOri() As Double = New Double(1) {0, 0}
    Public Ori() As Double = New Double(1) {0, 0}
    Public elong() As Double = New Double(1) {0, 0}
    Public nVertex() As Integer
    Public qVertex(,) As Double
    Public rVertex(,) As Double
    Public xVertex(,) As Double
    Public yVertex(,) As Double
    Public rEle() As Double
    Public areaEle() As Double
    Public mGravEle() As Double
    Public mInertEle() As Double
    Public MIEle() As Double
    Public MIInertEle() As Double
    Public vxEle() As Double
    Public vyEle() As Double
    Public vqEle() As Double
    Public boundELe(,) As Double
    Public ptcStress(,) As Double
    Public numECon() As Integer

    Public Fx() As Double
    Public Fy() As Double
    Public FM() As Double
    Public FxWall() As Double
    Public FyWall() As Double
    Public FMWall() As Double
    Public FWall(,) As Double
    Public iniFWall(,) As Double

    Public rqCE(,,) As Double
    Public xCE(,,) As Double
    Public iniXCE(,) As Double = New Double(1, 9) {}
    Public CAC(,) As Double = New Double(0, 0) {}
    Public hSector() As Double

    Public xVNew(,) As Double = New Double(9, 1) {}
    Public nVNew As Integer = 0
    Public flagAdd As Integer = 0
    Public flagNewTest As Integer = 1
    Public flagEditEle As Integer = 0
    Public flagEditVertex As Integer = 0
    Public flagCopy As Integer = 0
    Public flagEleRotate As Integer = 0
    Public flagSampleRotate As Integer = 0
    Public flagEleRemove As Integer = 0
    Public flagMaskCropOn As Integer = 0
    Public flagCreatingMaskOn As Integer = 0
    Public iniXCursor() As Double = New Double(1) {}
    Public curXCursor() As Double = New Double(1) {}
    Public iniXEle() As Double = New Double(1) {}
    Public iniXVertex(,) As Double = New Double(9, 1) {}
    Public actVertex As Integer = 0
    Public distVertex As Double
    Public iniXActVertex() As Double = New Double(1) {}
    Public xOffsetCopy() As Double = New Double(1) {}
    Public xRotationCenter() As Double = New Double(1) {}
    Public cosAngRotate As Double
    Public sinAngRotate As Double
    Public xMaskCrop(,) As Double = New Double(1, 9) {}
    Public nPtMaskCrop As Integer = 0
    Public ratioWHMask As Double
    Public nEleMasked As Integer = 0



    Public FxC() As Double
    Public FyC() As Double
    Public FMC() As Double

    Public x1Wall() As Double
    Public x2Wall() As Double
    Public y1Wall() As Double
    Public y2Wall() As Double
    Public vWall(,) As Double = New Double(1, 3) {}

    Public pair(,) As Integer
    Public oldPair(,) As Integer
    Public lWallFrd(,) As Integer
    Public nEleFrd() As Integer
    Public oldNEleFrd() As Integer
    Public pairIndex(,,) As Integer
    Public oldPairIndex(,,) As Integer

    Public xCon() As Double
    Public yCon() As Double
    Public FxCon() As Double
    Public FyCon() As Double
    Public FCon() As Double
    Public FAngle() As Double
    Public rCon() As Double
    Public wForce As Double
    Public hForce As Double
    Public FConTemp As Double
    Public FRGB(,) As Integer
    Public fricRatio() As Double
    Public tanNorm() As Double
    Public qNorm() As Double
    Public flagConBoun() As Integer
    Public pairCon(,) As Integer


    Public FtPair() As Double
    Public oldFtPair() As Double
    Public FtWP(,) As Double

    Public flagPairCohe() As Integer
    Public OldFlagPairCohe() As Integer
    Public cosQiAM() As Double
    Public oldCosQiAM() As Double
    Public sinQiAM() As Double
    Public oldSinQiAM() As Double
    Public cosQiAN() As Double
    Public oldCosQiAN() As Double
    Public sinQiAN() As Double
    Public oldSinQiAN() As Double
    Public cosQiBM() As Double
    Public oldCosQiBM() As Double
    Public sinQiBM() As Double
    Public oldSinQiBM() As Double
    Public cosQiBN() As Double
    Public oldCosQiBN() As Double
    Public sinQiBN() As Double
    Public oldSinQiBN() As Double
    Public rMA() As Double
    Public oldRMA() As Double
    Public rMB() As Double
    Public oldRMB() As Double
    Public rNA() As Double
    Public oldRNA() As Double
    Public rNB() As Double
    Public oldRNB() As Double
    Public ECohe() As Double
    Public oldECohe() As Double
    Public strgTensl() As Double
    Public oldStrgTensl() As Double
    Public strgRatio() As Double

    Public iZoom As Integer = 100
    Public zoomFactor As Double = 1.0

    Public flagReadOpen As Integer = 1
    Public flagWriteOpen As Integer = 1
    Public verRead As Integer = 0

    Public nStep As Integer = 0
    Public iStep As Integer = 0
    Public preStep As Integer = 0
    Public jStep As Integer = 0

    Public xEleTrace(,) As Double
    Public yEleTrace(,) As Double
    Public qEleTrace(,) As Double

    Public freqSave As Integer = 10
    Public iEle As Integer

    Public wCellGD As Double
    Public nHLine As Integer
    Public nVLine As Integer
    Public nHPtGD() As Integer
    Public nVPtGD() As Integer
    Public iHElePtGD(,) As Integer
    Public iVElePtGD(,) As Integer
    Public rqiHPtGD(,,) As Double
    Public rqiVPtGD(,,) As Double
    Public xHPtGD(,,) As Double
    Public xVPtGD(,,) As Double
    Dim flagGDExist As Integer = 0
    Dim flagDyeGrid() As Integer

    Public iMode As Integer = 3
    Public jMode As Integer = 0
    Public kMode As Integer = 0
    Public mMode As Integer = 0
    Public TraceRGB(,) As Integer
    Public PolyPath() As PointF
    Public rangeContour() As Double = New Double(1) {-500, 500}
    Public relaMin As Double
    Public relamax As Double
    Public refOri As Double = 0

    Public iHistMode As Integer = 0
    Public iOutHistMode As Integer = 0
    Public iWeight As Integer = 0
    Public jWeight As Integer = 0
    Public iBoundMode As Integer = 0
    Public nNodeMask As Integer = 0
    Public nOutNodeMask As Integer = 0
    Public Mask() As Integer = New Integer(9) {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Public MaskOut() As Integer = New Integer(9) {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Public nBinForce As Integer = 19
    Public nBinOri As Integer = 19
    Public nBinFR As Integer = 11
    Public nBinNorm As Integer = 19
    Public BinForce() As Double = New Double(nBinForce - 1) {}
    Public BinOri() As Double = New Double(nBinOri - 1) {}
    Public BinFR() As Double = New Double(nBinFR - 1) {}
    Public BinNorm() As Double = New Double(nBinNorm - 1) {}
    Public BinSlideNorm() As Double = New Double(nBinNorm - 1) {}
    Public BinFN() As Double = New Double(nBinNorm - 1) {}
    Public BinFT() As Double = New Double(nBinNorm - 1) {}
    Public BinRoseFR() As Double = New Double(nBinNorm - 1) {}
    Public ptBinF(,) As Single = New Single(1, nBinForce * 4 - 1) {}
    Public ptBinE(,) As Single = New Single(1, nBinOri * 4 - 1) {}
    Public ptBinFR(,) As Single = New Single(3, nBinFR - 1) {}
    Public ptBinNorm(,) As Single = New Single(1, nBinNorm * 4 - 1) {}
    Public ptBinSlideNorm(,) As Single = New Single(1, nBinNorm * 4 - 1) {}
    Public ptBinFN(,) As Single = New Single(1, nBinNorm * 4 - 1) {}
    Public ptBinFT(,) As Single = New Single(1, nBinNorm * 4 - 1) {}
    Public ptBinRoseFR(,) As Single = New Single(1, nBinNorm * 4 - 1) {}
    Public factorSlideNorm As Double = 1
    Public angFabAxis1 As Double = 0
    Public angFabAxis2 As Double = 1.571
    Public angStressAxis1 As Double = 0
    Public angStressAxis2 As Double = 1.571
    Public angBodyStressAxis1 As Double = 0
    Public angBodyStressAxis2 As Double = 1.571
    Public angFabCN1 As Double = 0
    Public angFabCN2 As Double = 1.571
    Public nEleMask As Integer   'num of element in Histogram mask


    Public rSldTrace(,) As Single
    Public qSldTrace(,) As Single
    Public frSldTrace(,) As Single
    Public normSldTrace(,) As Single
    Public eleSldTrace(,) As Integer
    Public CBSldTrace(,) As Integer
    Public nConSldTrace() As Integer



    Public flagNewMask As Integer = 0
    Public flagMaskOn As Integer = 0
    Dim ptMask() As PointF = New PointF(9) {}
    Public flagEMask() As Integer
    Public flagFMask() As Integer

    Public flagNewVRBox As Integer = 0
    Public ptBox1 As Point
    Public ptBox2 As Point

    Public EleA As Integer
    Public EleB As Integer
    Public xEleAIni As Double
    Public xEleBini As Double
    Public strainShear As Double
    Public strainVol As Double
    Public volIni As Double

    Public tsFabric() As Double = New Double(3) {}
    Public tsConNorm() As Double = New Double(3) {}
    Public tsStress() As Double = New Double(7) {}
    Public numContact As Double

    Public cosTemp As Double
    Public sinTemp As Double
    Public lTemp As Double

    Public tempX1Wall() As Double
    Public tempX2Wall() As Double
    Public tempY1Wall() As Double
    Public tempY2Wall() As Double
    Public tempXCon() As Double
    Public tempYCon() As Double
    Public tempFricRatio() As Double
    Public tempTanNorm() As Double
    Public tempPairCon(,) As Integer
    Public tempX As Single
    Public tempY As Single
    Public xPlotSld(,) As Single
    Public xPlotRol(,) As Single
    Public nPlotSld As Integer
    Public nPlotRol As Integer

    Public iEleCell() As Integer
    Public numCell As Integer
    Public numCellX As Integer
    Public numCellY As Integer
    Public nEleTop As Integer = 10
    Public rStainCell As Double = 0
    Public xPt(,) As Double
    Public eleStnCell(,) As Integer
    Public eleBuffer() As Integer = New Integer(9999) {}
    Public wgtBuffer() As Double = New Double(9999) {}
    Public strainOut() As Double
    Public drctStn() As Double
    Dim triangleCell() As Drawing.Point = New Point(2) {}
    Public angN As Double = 0
    Public intvCell As Double
    Public iCell As Integer
    Public scaleStnOut As Double = 0.01
    Public scaleStnDrct As Double = 0.01
    Public flagStnOut As Integer = 0
    Public flagDrctStnOut As Integer = 0
    Public flagEffCell() As Integer
    Public areaCell() As Double
    Dim cellCenter() As Single = New Single(1) {}
    Dim lgthStrn As Single = 0
    Dim stnContrast As Single = 0.5
    Dim valLegend As Single = 0.001
    Dim xCell(,) As Single = New Single(1, 99999) {}
    Dim flagStnMode As Integer = 1

    Dim nEffEle As Integer = 0
    Dim xEffEle(,) As Double
    Dim iNdStn() As Integer
    Dim TILStn(,) As Integer
    Dim TNBRStn(,) As Integer
    Dim mapEffEle() As Integer
    Dim nConPEleStn() As Integer


    Dim nEleDiscMask As Integer = 0
    Dim eleDiscMask() As Integer = New Integer(999) {}
    Dim flagAddDiscMask As Integer = 0

    Dim nActCell As Integer = 0
    Dim cellAct() As Integer
    Dim distActCell As Single = 0



    Dim flagReDrawTab = 0

    Dim intLoadPara(,) As Integer = New Integer(8, 100000) {}
    ' in the dll, define intLoadPara(0:1000,0:5)
    '(0,0) is the total number of load batches; arrary (0,:) is used for manual control
    'arries(i,:) are for batched loading


    Dim realLoadPara(,) As Double = New Double(7, 100000) {}
    Dim flagLoadMode As Integer = 0   ' =0 manula loading; =1 automatic batched loading


    Dim eleOut() As Integer = New Integer(1000) {}
    Dim eleMaskOut(,) As Integer = New Integer(8, 100) {}   ' A mask can have up to eight vertices, eleMask(0,i) is the number of vertices of the (i+1)th mask

    Dim flagOutput As Integer = 0   ' for tensor output operation
    Dim flagOutInied As Integer = 0

    Dim xDyeRef() As Single = New Single(1) {1.0, 0}

    Dim stepSparse As Integer = 10
    Dim iniSparse As Integer = 0

    Dim hThinLayer As Double = 0
    Dim flagThinLayer() As Integer = New Integer(1) {0, 0}

    Dim appID As Long
    Dim nRet As Long
    Dim keyHandles(7) As Long
    Dim numKey As Long
    Dim NoxMemo(3) As Double



    Dim maxConAll As Integer
    Dim maxConPEle As Integer = 24
    Dim maxEdgePEle As Integer = 24

    Dim nEffCon As Integer = 0
    Dim xEffCon(,) As Double
    Dim effCon2Glob() As Integer
    Dim iEleEffCon(,) As Integer

    Dim nTriAllCon As Integer = 0
    Dim iConTriAllCon(,) As Integer
    Dim iEConTriAllCon(,) As Integer
    Dim fgDeadTri() As Integer

    Dim nConPEle() As Integer
    Dim iConPEle(,) As Integer
    Dim iConCellInEle(,) As Integer
    Dim nCellinEle As Integer

    Dim iConDlnBound(,) As Integer
    Dim iEleDlnBound() As Integer
    Dim nGstDlnBound() As Integer
    Dim iEffGstDlnBound(,) As Integer
    Dim nDlnBound As Integer

    Dim nEdgeAll As Integer = 0
    Dim fgEffEdge() As Integer
    Dim iEleEffEdge() As Integer
    Dim nEdgePt() As Integer
    Dim jPtEdgeiPt(,) As Integer

    Dim iEdgeiPt(,) As Integer
    Dim iPtEdge(,) As Integer
    Dim iCellEdge(,) As Integer
    Dim iEdgeCell(,) As Integer
    Dim fgSolidCell() As Integer

    Dim iVCCell() As Integer
    Dim nVC As Integer
    Dim mapVC() As Integer
    Dim nCellVC() As Integer
    Dim iCellVC(,) As Integer
    Dim nEConVC() As Integer
    Dim iEConVC(,) As Integer

    Dim maxNGrid() As Integer = New Integer(1) {}
    Dim maxDlnPGrid As Integer
    Dim nDlnBPGrid(,) As Integer
    Dim iDlnBPGrid(,,) As Integer

    Dim nSldTriPVC() As Integer
    Dim iEConSldTri(,,) As Integer
    Dim xSldCell(,) As Double
    Dim fgSeenMe() As Integer
    Dim fgBridgeEdge() As Integer

    Dim xVC(,) As Double

    Public flagVVWeight As Integer = 0
    Dim flagVCMask() As Integer
    Dim vecVV(,) As Double
    Dim rqVV(,) As Double
    Public nBinVV As Integer = 24
    Public binVV() As Double
    Public tsVV(,) As Double = New Double(1, 1) {}
    Public tsVVP(1) As Double
    Public tsVVPAng(1) As Double


    Dim fgBndEle() As Integer
    Dim fgBndVC() As Integer

    Dim xPtEff(,) As Double
    Dim iNd2() As Integer
    Dim TIL(,) As Integer
    Dim TNBR(,) As Integer

    Dim VCColor(,) As Integer
    Dim opacityCell As Integer = 100

    Dim iDirecCyc As Integer = 1
    Dim flagSpecialLoad As Integer = 0
    Dim qMax As Double = 0.0
    Dim cDisp As Double = 0.0


#If STRESSROTATE = 1 Then
    Public RxEle As Double()
    Public RyEle As Double()
    Public RxVertex(,) As Double
    Public RyVertex(,) As Double
    Public RpPlot(,) As Double
    Public RFxC() As Double
    Public RFyC() As Double
    Public RboundELe(,) As Double
    Public RlimitAll() As Double = New Double(3) {}
    Public RnGridX As Integer
    Public RnGridY As Integer
    Public RnEleGrid As Integer(,)
    Public RlEG As Integer(,,)
    Public PStress() As Double = New Double(1) {}
    Public PStressAng As Double = 0.0
    Dim angSequence() As Double
    Dim nStressRotationSteps As Integer = 0
    Dim currentRotationStep As Integer = 0
#End If

    Public flagPause As Integer = 0

    Dim nLinks As Integer = 0
    Dim minR As Double
    Dim maxR As Double
    Dim iEleLink(,) As Integer
    Dim l0Link() As Double
    Dim kLinkPos() As Double
    Dim kLinkNeg() As Double
    Dim linkDampingRatio As Double = 0

    Dim coordNumMatrix(,) As Double
    Dim colorCNMatrix(,,) As Integer
    Dim xCNBox() As Single
    Dim yCNBox() As Single




    Private Sub PolyBall_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

#If USEKEY = 1 Then

        Histgram.Width = 633
        Histgram.lbExpandWindow.Enabled = False
        Histgram.lbExpandWindow.Visible = False
        Histgram.roseForceNormTang.Enabled = False
        Histgram.roseShearRatio.Enabled = False
        IniKey()
#End If



        nInc = 2 ^ nIncr.Value
        stiff = 2 ^ setE.Value
        tanTheta(0) = Math.Tan(setTanTheta1.Value / 180 * 3.14159)
        tanTheta(1) = Math.Tan(setTanTheta2.Value / 180 * 3.14159)

        dt = 2 ^ (-tInc.Value)
        globdamp = 2 ^ setGlobDamp.Value
        rotDamp = 2 ^ setRotDamp.Value
        dampingRatio = setDampingRatio.Value
        rollingDamp = setRollingDamp.Value
        rStainCell = setRdStnCell.Value

        dxWall = setCurrentLoadRate.Value

        flagDebug = 0

        zoomScale = 1.0
        FLenScale = 0.0001
        FThickScale = 0.001
        SlidScale = 0.001

        maxGap = setMaxRFriend.Value


        xGravity(0) = setXGravity.Value
        xGravity(1) = setYGravity.Value
        gXgY(0) = setGX.Value
        gXgY(1) = setGY.Value

        factorContrast = cstForceThickContrast.Value
        factorLenThick = cstForceThickLeng.Value
        factorSlid = setFactorSlidContrast.Value

        tabMain.DrawMode = TabDrawMode.OwnerDrawFixed

        setLoadModeLeftN.SelectedIndex = 1
        setLoadModeRightN.SelectedIndex = 1
        setLoadModeBottomN.SelectedIndex = 1
        setLoadModeTopN.SelectedIndex = 1
        setLoadModeLeftT.SelectedIndex = 1
        setLoadModeRightT.SelectedIndex = 1
        setLoadModeBottomT.SelectedIndex = 1
        setLoadModeTopT.SelectedIndex = 1

        linkDampingRatio = setLinkDampingRatio.Value

#If USEKEY = 1 Then
        WriteNoxMemo()

#End If


    End Sub

    Private Sub btnOpenTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenTest.Click
        dlgOpenTest.ShowDialog()
        FileName = dlgOpenTest.FileName
        lName = FileName.Length
        lCurDir = FileName.LastIndexOfAny("\") + 1
        curDir = FileName.Substring(0, lCurDir)

        If lName > 0 Then

            Call InitPauseFile(curDir, lCurDir)

            Me.Text = FileName & "   PPDEM - by Pengcheng Fu at UCD"
            btnOpenTest.Enabled = False

            mainTransparency.BackColor = canvas.BackColor

            Call PreInit(nActEle, nWall, FileName, lName)

            nEle = ctrlMaxNEle.Value

            If nActEle > nEle Then
                nEle = nActEle + 100
            End If

            ReDim xEle(nEle - 1)
            ReDim yEle(nEle - 1)
            ReDim qEle(nEle - 1)
            ReDim iniOri(nEle - 1)
            ReDim Ori(nEle - 1)
            ReDim elong(nEle - 1)
            ReDim nVertex(nEle - 1)
            ReDim qVertex(9, nEle - 1)
            ReDim rVertex(9, nEle - 1)
            ReDim xVertex(9, nEle - 1)
            ReDim yVertex(9, nEle - 1)
            ReDim rEle(nEle - 1)
            ReDim areaEle(nEle - 1)
            ReDim mInertEle(nEle - 1)
            ReDim mGravEle(nEle - 1)
            ReDim MIEle(nEle - 1)
            ReDim MIInertEle(nEle - 1)
            ReDim vxEle(nEle - 1)
            ReDim vyEle(nEle - 1)
            ReDim vqEle(nEle - 1)
            ReDim boundELe(3, nEle - 1)
            ReDim ptcStress(5, nEle - 1)   ' 0=xx, 1=xy, 3=yy, 4=bulk stress; 5=max shear; 2 is not used.
            ReDim flagEMask(nEle - 1)

            ReDim flagDyeGrid(nEle - 1)

            ReDim Fx(nEle - 1)
            ReDim Fy(nEle - 1)
            ReDim FM(nEle - 1)

            ReDim rqCE(3, 9, nEle - 1)
            ReDim xCE(1, 9, nEle - 1)
            ReDim hSector(nEle - 1)
            ReDim CAC(9, nEle - 1)

            ReDim FxC(nEle - 1)
            ReDim FyC(nEle - 1)
            ReDim FMC(nEle - 1)
            ReDim FxWall(nEle - 1)
            ReDim FyWall(nEle - 1)
            ReDim FMWall(nEle - 1)
            ReDim iniFWall(1, nWall - 1)
            ReDim FWall(1, nWall - 1)
            For iWall As Integer = 0 To nWall - 1
                FWall(0, iWall) = 0
                FWall(1, iWall) = 0
            Next


            ReDim x1Wall(nWall - 1)
            ReDim x2Wall(nWall - 1)
            ReDim y1Wall(nWall - 1)
            ReDim y2Wall(nWall - 1)

            ReDim pair(1, nEle * alwNEleFrd - 1)
            ReDim oldPair(1, nEle * alwNEleFrd - 1)
            ReDim lWallFrd(1, nEle * nWall - 1)
            ReDim nEleFrd(nEle - 1)
            ReDim oldNEleFrd(nEle - 1)
            ReDim pairIndex(1, alwNEleFrd - 1, nEle - 1)
            ReDim oldPairIndex(1, alwNEleFrd - 1, nEle - 1)

            ReDim xCon(nEle * 10 - 1)
            ReDim yCon(nEle * 10 - 1)
            ReDim FxCon(nEle * 10 - 1)
            ReDim FyCon(nEle * 10 - 1)
            ReDim FCon(nEle * 10 - 1)
            ReDim FAngle(nEle * 10 - 1)
            ReDim rCon(nEle * 10 - 1)
            ReDim FRGB(2, nEle * 10 - 1)
            ReDim fricRatio(nEle * 10 - 1)
            ReDim tanNorm(nEle * 10 - 1)
            ReDim qNorm(nEle * 10 - 1)
            ReDim flagFMask(nEle * 10 - 1)
            ReDim pPlot(3, nEle * 10 - 1)
            ReDim flagConBoun(nEle * 10 - 1)
            ReDim pairCon(1, nEle * 10 - 1)
            ReDim xPtHL(1, 10 * nEle - 1)

            ReDim FtPair(nEle * alwNEleFrd - 1)
            ReDim oldFtPair(nEle * alwNEleFrd - 1)
            ReDim FtWP(nWall - 1, nEle - 1)

            ReDim flagPairCohe(nEle * alwNEleFrd - 1)
            ReDim OldFlagPairCohe(nEle * alwNEleFrd - 1)
            ReDim cosQiAM(nEle * 11 - 1)
            ReDim oldCosQiAM(nEle * 11 - 1)
            ReDim sinQiAM(nEle * 11 - 1)
            ReDim oldSinQiAM(nEle * 11 - 1)
            ReDim cosQiAN(nEle * 11 - 1)
            ReDim oldCosQiAN(nEle * 11 - 1)
            ReDim sinQiAN(nEle * 11 - 1)
            ReDim oldSinQiAN(nEle * 11 - 1)
            ReDim cosQiBM(nEle * 11 - 1)
            ReDim oldCosQiBM(nEle * 11 - 1)
            ReDim sinQiBM(nEle * 11 - 1)
            ReDim oldSinQiBM(nEle * 11 - 1)
            ReDim cosQiBN(nEle * 11 - 1)
            ReDim oldCosQiBN(nEle * 11 - 1)
            ReDim sinQiBN(nEle * 11 - 1)
            ReDim oldSinQiBN(nEle * 11 - 1)
            ReDim rMA(nEle * 11 - 1)
            ReDim oldRMA(nEle * 11 - 1)
            ReDim rMB(nEle * 11 - 1)
            ReDim oldRMB(nEle * 11 - 1)
            ReDim rNA(nEle * 11 - 1)
            ReDim oldRNA(nEle * 11 - 1)
            ReDim rNB(nEle * 11 - 1)
            ReDim oldRNB(nEle * 11 - 1)
            ReDim ECohe(nEle * 11 - 1)
            ReDim oldECohe(nEle * 11 - 1)
            ReDim strgTensl(nEle * 11 - 1)
            ReDim oldStrgTensl(nEle * 11 - 1)
            ReDim strgRatio(nEle * 11 - 1)

            'ReDim flagPairCohe(nEle * alwNEleFrd - 1)
            'ReDim OldFlagPairCohe(nEle * alwNEleFrd - 1)
            'ReDim cosQiAM(0)
            'ReDim oldCosQiAM(0)
            'ReDim sinQiAM(0)
            'ReDim oldSinQiAM(0)
            'ReDim cosQiAN(0)
            'ReDim oldCosQiAN(0)
            'ReDim sinQiAN(0)
            'ReDim oldSinQiAN(0)
            'ReDim cosQiBM(0)
            'ReDim oldCosQiBM(0)
            'ReDim sinQiBM(0)
            'ReDim oldSinQiBM(0)
            'ReDim cosQiBN(0)
            'ReDim oldCosQiBN(0)
            'ReDim sinQiBN(0)
            'ReDim oldSinQiBN(0)
            'ReDim rMA(0)
            'ReDim oldRMA(0)
            'ReDim rMB(0)
            'ReDim oldRMB(0)
            'ReDim rNA(0)
            'ReDim oldRNA(0)
            'ReDim rNB(0)
            'ReDim oldRNB(0)
            'ReDim ECohe(0)
            'ReDim oldECohe(0)
            'ReDim strgTensl(0)
            'ReDim oldStrgTensl(0)
            'ReDim strgRatio(0)

            ReDim tempX1Wall(nWall - 1)
            ReDim tempX2Wall(nWall - 1)
            ReDim tempY1Wall(nWall - 1)
            ReDim tempY2Wall(nWall - 1)
            ReDim tempXCon(nEle * 10 - 1)
            ReDim tempYCon(nEle * 10 - 1)
            ReDim tempFricRatio(nEle * 10 - 1)
            ReDim tempTanNorm(nEle * 10 - 1)
            ReDim tempPairCon(1, nEle * 10 - 1)

            ReDim numECon(nEle - 1)

            ReDim cellAct(nEle * 2 - 1)


#If STRESSROTATE = 1 Then
            ReDim RxEle(nEle - 1)
            ReDim RyEle(nEle - 1)
            ReDim RxVertex(9, nEle - 1)
            ReDim RyVertex(9, nEle - 1)
            ReDim RpPlot(3, nEle * 10 - 1)
            ReDim RFxC(nEle - 1)
            ReDim RFyC(nEle - 1)
            ReDim RboundELe(3, nEle - 1)
            ReDim RnEleGrid(nGridY - 1, nGridX - 1)
            ReDim RlEG(maxNEleGrid - 1, nGridY - 1, nGridX - 1)
#End If


            MonitorSystemVariable.setActEle.Maximum = nActEle




            Call Initiate(nEle, nActEle, xEle, yEle, qEle, nVertex, xVertex, yVertex, qVertex, rVertex, rEle, areaEle, MIEle, _
             vxEle, vyEle, vqEle, nWall, x1Wall, x2Wall, y1Wall, y2Wall, dEleMax, flagPairCohe, alwNEleFrd, minREle, rqCE, xCE, hSector, flagNewTest, _
             Params, CAC, volSld, FileName, lName)

            Call IniOrient(nEle, nActEle, xEle, yEle, nVertex, xVertex, _
             yVertex, qVertex, rVertex, rEle, qEle, hSector, rqCE, xCE, boundELe, iniOri, elong)

            Call Initiate(nEle, nActEle, xEle, yEle, qEle, nVertex, xVertex, yVertex, qVertex, rVertex, rEle, areaEle, MIEle, _
             vxEle, vyEle, vqEle, nWall, x1Wall, x2Wall, y1Wall, y2Wall, dEleMax, flagPairCohe, alwNEleFrd, minREle, rqCE, xCE, hSector, flagNewTest, Params, CAC, volSld, FileName, lName)


            dt = Params(0)
            tInc.Value = -Math.Log(dt) / Math.Log(2)

            stiff = Params(1)
            setE.Value = Math.Log(stiff) / Math.Log(2)

            globdamp = Params(2)
            rotDamp = Params(3)
            setGlobDamp.Value = Math.Log(globdamp) / Math.Log(2)
            setRotDamp.Value = setGlobDamp.Value

            rollingDamp = Params(3)
            setRollingDamp.Value = rollingDamp

            dampingRatio = Params(4)
            setDampingRatio.Value = dampingRatio

            maxGap = Params(5)
            setMaxRFriend.Value = maxGap

            tanTheta(0) = Params(6)
            setTanTheta1.Value = Math.Atan(tanTheta(0)) / 3.1415926 * 180

            tanTheta(1) = Params(16)
            setTanTheta2.Value = Math.Atan(tanTheta(1)) / 3.1415926 * 180

            realLoadPara(4, 0) = Params(7)
            realLoadPara(6, 0) = Params(7)
            setPx.Value = Params(7)

            realLoadPara(0, 0) = Params(8)
            realLoadPara(2, 0) = Params(8)
            setPy.Value = Params(8)

            pInt = Params(9)
            setpInt.Value = pInt

            gXgY(0) = Params(10)
            setGX.Value = gXgY(0)

            gXgY(1) = Params(11)
            setGY.Value = gXgY(1)

            xGravity(0) = Params(12)
            setXGravity.Value = xGravity(0)

            xGravity(1) = Params(13)
            setYGravity.Value = xGravity(1)

            realLoadPara(1, 0) = Params(14)
            realLoadPara(3, 0) = Params(14)
            realLoadPara(5, 0) = Params(14)
            realLoadPara(7, 0) = Params(14)
            setpxy.Value = Params(14)

            intLoadPara(1, 0) = 2
            intLoadPara(2, 0) = 2
            intLoadPara(3, 0) = 2
            intLoadPara(4, 0) = 2
            intLoadPara(5, 0) = 2
            intLoadPara(6, 0) = 2
            intLoadPara(7, 0) = 2
            intLoadPara(8, 0) = 2



            xGrid = dEleMax + maxGap
            setRdStnCell.Value = xGrid
            setRdStnCell.Increment = xGrid / 5


            Call Mass(nEle, nActEle, areaEle, mGravEle, mInertEle, MIEle, MIInertEle, dt, density, stiff, flagMassNorm)

            Call DomainLimit(nEle, nActEle, xEle, yEle, rEle, nVertex, xVertex, yVertex, boundELe, limitAll, hSector)

            limitAll(0) -= maxGap
            limitAll(1) += maxGap
            limitAll(2) -= maxGap
            limitAll(3) += maxGap

            nGridY = (limitAll(3) - limitAll(2)) / xGrid + 1
            nGridX = (limitAll(1) - limitAll(0)) / xGrid + 1
            maxNEleGrid = Math.Max((xGrid ^ 2 / (volSld / nActEle) * 4), 10)   'Potentially problematic
            ReDim nEleGrid(nGridY - 1, nGridX - 1)
            ReDim lEG(maxNEleGrid - 1, nGridY - 1, nGridX - 1)


            Call Grid(nEle, nActEle, nVertex, xEle, yEle, rEle, xVertex, yVertex, nGridX, nGridY, nEleGrid, lEG, xGrid, boundELe, limitAll, maxNEleGrid)


            zoomScale = 600 / Math.Max((limitAll(3) - limitAll(2)), (limitAll(1) - limitAll(0)))
            xOrigin = canvasContainer.Width / 2 - (limitAll(0) + limitAll(1)) / 2 * zoomScale
            yOrigin = -canvasContainer.Height / 2 + (limitAll(2) + limitAll(3)) / 2 * zoomScale
            actEle = 0

            ctrlMaxNEle.Value = nEle


            ' Initialize the coordination number matrix
            setCoordNumMatrixBoxSize.Value = (limitAll(1) - limitAll(0)) / 10
            setCoordNumMatrixBoxSize.Increment = (limitAll(1) - limitAll(0)) / 20
            setCoordNumMatrixSampIntv.Value = (limitAll(1) - limitAll(0)) / 20
            setCoordNumMatrixSampIntv.Increment = (limitAll(1) - limitAll(0)) / 40



        End If
        canvas.Visible = True
        canvas.Enabled = True


#If STRESSROTATE = 1 Then
        Call RotateArray(nEle, nActEle, PStressAng, xEle, yEle, RxEle, RyEle)
        Call Rotate2DArray(nEle, 10, nActEle, nVertex, PStressAng, xVertex, yVertex, RxVertex, RyVertex)

#End If


        canvas.Invalidate()

    End Sub
    Private Sub Timer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timerTest.Tick
        factorSlow = 1.0

        iCurStep(0) += 1

        timeNow(8) = timeGetTime

        MonitorSystemVariable.Invalidate()

        timeNow(0) = timeGetTime


        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' For anisotropic thin shearing only.  Change the value of particle-wall friction at the end of anisotrpic consolidation.
        'If intLoadPara(0, iCurStep(1)) = 987654321 Then
        '    intLoadPara(0, iCurStep(1)) = 200
        '    setTanTheta2.Value = 80
        '    setGlobDamp.Value = 0
        '    setFreqSaveRST.Value = 5
        'End If

        'If iCurStep(1) = 800 Then
        'setFreqSaveRST.Value = 100
        'End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ' For progressive loading
        If setTargetLoadRate.Value = setCurrentLoadRate.Value Then
            chkProgressiveLoading.Checked = False
        End If

        If chkProgressiveLoading.Checked = True And setSteptoGo.Value > 0 Then
            setCurrentLoadRate.Value += (setTargetLoadRate.Value - setCurrentLoadRate.Value) / setSteptoGo.Value
            setSteptoGo.Value -= 1
        End If


        Call DomainLimit(nEle, nActEle, xEle, yEle, rEle, nVertex, xVertex, yVertex, boundELe, limitAll, hSector)

        timeNow(1) = timeGetTime


        limitAll(0) -= maxGap
        limitAll(1) += maxGap
        limitAll(2) -= maxGap
        limitAll(3) += maxGap


        nGridY = (limitAll(3) - limitAll(2)) / xGrid + 1
        nGridX = (limitAll(1) - limitAll(0)) / xGrid + 1
        maxNEleGrid = Math.Max((xGrid ^ 2 / (volSld / nActEle) * 4), 10)   'Potentially problematic
        ReDim nEleGrid(nGridY - 1, nGridX - 1)
        ReDim lEG(maxNEleGrid - 1, nGridY - 1, nGridX - 1)


        Call Grid(nEle, nActEle, nVertex, xEle, yEle, rEle, xVertex, yVertex, nGridX, nGridY, nEleGrid, lEG, xGrid, boundELe, limitAll, maxNEleGrid)

        If d_PPCOF <> 0 Then
            tanTheta(0) += d_PPCOF
            If tanTheta(0) < 0 Then
                tanTheta(0) = 0
            End If
            setTanTheta1.Value = Math.Atan(tanTheta(0)) / Math.PI * 180
        End If

        timeNow(2) = timeGetTime

        If chkStressRotation.Checked Then

            If nStressRotationSteps > 0 Then
                setStressRotationRate.Value = angSequence(currentRotationStep) - setPStressAng.Value
                currentRotationStep += 1
            End If

            setPStressAng.Value += setStressRotationRate.Value
            setPx.Value -= setStressIncRate.Value
            setPy.Value += setStressIncRate.Value

            PStressAng = setPStressAng.Value

            Call RotateArray(nEle, nActEle, PStressAng, xEle, yEle, RxEle, RyEle)
            Call Rotate2DArray(nEle, 10, nActEle, nVertex, PStressAng, xVertex, yVertex, RxVertex, RyVertex)
            Call DomainLimit(nEle, nActEle, RxEle, RyEle, rEle, nVertex, RxVertex, RyVertex, RboundELe, RlimitAll, hSector)
            RlimitAll(0) -= maxGap
            RlimitAll(1) += maxGap
            RlimitAll(2) -= maxGap
            RlimitAll(3) += maxGap
            RnGridY = (RlimitAll(3) - RlimitAll(2)) / xGrid + 1
            RnGridX = (RlimitAll(1) - RlimitAll(0)) / xGrid + 1
            ReDim RnEleGrid(RnGridY - 1, RnGridX - 1)
            ReDim RlEG(maxNEleGrid - 1, RnGridY - 1, RnGridX - 1)
            Call Grid(nEle, nActEle, nVertex, RxEle, RyEle, rEle, RxVertex, RyVertex, RnGridX, RnGridY, RnEleGrid, RlEG, xGrid, RboundELe, RlimitAll, maxNEleGrid)

            PStress(0) = setPx.Value
            PStress(1) = setPy.Value

            Call RConfinement(nEle, RxEle, RyEle, rEle, nVertex, RxVertex, _
            RyVertex, RboundELe, RlimitAll, pInt, nPCon, RpPlot, RFxC, RFyC, FMC, _
            RnGridX, RnGridY, RnEleGrid, RlEG, xGrid, maxNEleGrid, vol, pairCon, _
            PStress)

            Call RotateArray(nEle, nActEle, -PStressAng, RFxC, RFyC, FxC, FyC)

            Call RotatePPlot(nEle, nPCon, -PStressAng, RpPlot, pPlot)


        Else

            Call Confinement(nEle, xEle, yEle, rEle, nVertex, xVertex, yVertex, boundELe, limitAll, _
            pInt, nPCon, pPlot, FxC, FyC, FMC, nGridX, nGridY, nEleGrid, lEG, xGrid, flagDebug, maxNEleGrid, vol, pairCon, _
            nWall, iniFWall, x1Wall, x2Wall, y1Wall, y2Wall, flagLoadMode, intLoadPara, realLoadPara, iCurStep)

        End If


        timeNow(3) = timeGetTime


        flag1stEF = 1  ' only transfer npair to oldnpair when EleFrd is called the first time
        Call EleFrd(nEle, xEle, yEle, rEle, nVertex, xVertex, yVertex, pair, nPair, nGridX, nGridY, nEleGrid, _
            lEG, maxGap, nEleFrd, pairIndex, oldNPair, oldPair, oldNEleFrd, oldPairIndex, alwNEleFrd, _
            maxNEleFrd, flag1stEF, maxNEleGrid, hSector)

        timeNow(4) = timeGetTime

        Do While maxNEleFrd > alwNEleFrd - 1

            factorSlow *= 2
            dt = 2 ^ (-tInc.Value) / factorSlow

            Call Mass(nEle, nActEle, areaEle, mGravEle, mInertEle, MIEle, MIInertEle, dt, density, stiff, flagMassNorm)

            setMaxRFriend.Value = Math.Max(monitor(3) * 2 * dt * nInc, minREle)
            maxGap = setMaxRFriend.Value
            Call EleFrd(nEle, xEle, yEle, rEle, nVertex, xVertex, yVertex, pair, nPair, nGridX, nGridY, nEleGrid, _
                lEG, maxGap, nEleFrd, pairIndex, oldNPair, oldPair, oldNEleFrd, oldPairIndex, alwNEleFrd, _
                maxNEleFrd, flag1stEF, maxNEleGrid, hSector)

        Loop


        Call InheritPair(nEle, nPair, oldNPair, pair, oldPair, _
            nEleFrd, oldNEleFrd, pairIndex, oldPairIndex, _
            FtPair, oldFtPair, flagPairCohe, OldFlagPairCohe, _
            cosQiAM, oldCosQiAM, sinQiAM, oldSinQiAM, cosQiAN, oldCosQiAN, _
            sinQiAN, oldSinQiAN, cosQiBM, oldCosQiBM, sinQiBM, oldSinQiBM, _
            cosQiBN, oldCosQiBN, sinQiBN, oldSinQiBN, rMA, oldRMA, rNA, oldRNA, _
            rMB, oldRMB, rNB, oldRNB, ECohe, oldECohe, strgTensl, oldStrgTensl, alwNEleFrd)

        timeNow(5) = timeGetTime

        Call WallFrd(nEle, nActEle, xEle, yEle, rEle, nVertex, xVertex, yVertex, nWall, x1Wall, x2Wall, y1Wall, y2Wall, _
         nWallFrd, lWallFrd, maxGap, hSector, flagDebug)

        timeNow(6) = timeGetTime


        If iCurStep(0) Mod setOutputFreq.Value = 0 Then
            iCurStep(3) = 1
        Else
            iCurStep(3) = 0

        End If

#If USEKEY = 1 Then

        Dim NoxRead(3) As Double

        nRet = NoxReadMemory(keyHandles(0), NoxRead(0))

        If nRet <> 0 Then
            MessageBox.Show("Could not find license key for PPDEM.  Please plug your key in and restart PPDEM.  Bye.")
            timerTest.Enabled = False
            tabMain.Enabled = False
        End If

        Call CalPOLY(nEle, nActEle, xEle, yEle, qEle, nVertex, xVertex, yVertex, qVertex, _
        rVertex, rEle, boundELe, MIEle, vxEle, vyEle, vqEle, nWall, _
        x1Wall, x2Wall, y1Wall, y2Wall, nInc, NoxRead(0), NoxRead(1), density, tanTheta, xGravity, gXgY, monitor, _
        globdamp, rotDamp, FtPair, FtWP, _
        NoxRead(2), NoxRead(3), flagDebug, xCon, yCon, FxCon, FyCon, fricRatio, tanNorm, FRGB, rCon, nCon, _
        nPCon, pPlot, flagConBoun, pairCon, _
        nPair, pair, nWallFrd, lWallFrd, _
        FxC, FyC, FMC, flagGlue, flagPairCohe, dMotionWall, actWall, actEle, xCursor, rAnchor, cosQAnchor, sinQAnchor, flagEleDrag, _
        cosQiAM, sinQiAM, cosQiAN, sinQiAN, cosQiBM, sinQiBM, cosQiBN, sinQiBN, _
        rMA, rNA, rMB, rNB, ECohe, nPtHL, xPtHL, strgTensl, numThreads, alwNEleFrd, _
        mGravEle, mInertEle, MIInertEle, zoomScale, rqCE, xCE, hSector, limitAll, vWall, aOverAll, vol, _
         flagLoadMode, intLoadPara, realLoadPara, iCurStep, eleOut, FWall, iniFWall, FxWall, FyWall, FMWall, Fx, Fy, FM, iniOri, elong, flagOutInied, factorSlow, _
         hThinLayer, flagThinLayer, iDirecCyc, flagSpecialLoad, qMax, cDisp, _
         nLinks, iEleLink, l0Link, kLinkPos, kLinkNeg, linkDampingRatio )

#Else
        Call CalPOLY(nEle, nActEle, xEle, yEle, qEle, nVertex, xVertex, yVertex, qVertex, _
        rVertex, rEle, boundELe, MIEle, vxEle, vyEle, vqEle, nWall, _
        x1Wall, x2Wall, y1Wall, y2Wall, nInc, dt, stiff, density, tanTheta, xGravity, gXgY, monitor, _
        globdamp, rotDamp, FtPair, FtWP, _
        dampingRatio, rollingDamp, flagDebug, xCon, yCon, FxCon, FyCon, fricRatio, tanNorm, FRGB, rCon, nCon, _
        nPCon, pPlot, flagConBoun, pairCon, _
        nPair, pair, nWallFrd, lWallFrd, _
        FxC, FyC, FMC, flagGlue, flagPairCohe, dMotionWall, actWall, actEle, xCursor, rAnchor, cosQAnchor, sinQAnchor, flagEleDrag, _
        cosQiAM, sinQiAM, cosQiAN, sinQiAN, cosQiBM, sinQiBM, cosQiBN, sinQiBN, _
        rMA, rNA, rMB, rNB, ECohe, nPtHL, xPtHL, strgTensl, numThreads, alwNEleFrd, _
        mGravEle, mInertEle, MIInertEle, zoomScale, rqCE, xCE, hSector, limitAll, vWall, aOverAll, vol, _
         flagLoadMode, intLoadPara, realLoadPara, iCurStep, eleOut, FWall, iniFWall, FxWall, FyWall, FMWall, Fx, Fy, FM, iniOri, elong, flagOutInied, factorSlow, _
         hThinLayer, flagThinLayer, iDirecCyc, flagSpecialLoad, qMax, cDisp, _
         nLinks, iEleLink, l0Link, kLinkPos, kLinkNeg, linkDampingRatio)

#End If
        lbICurStep1.Text = "Step:           " & iCurStep(0).ToString
        lbICurStep2.Text = "Load Sequence:  " & iCurStep(1).ToString
        lbICurStep3.Text = "SubStep:        " & iCurStep(2).ToString


        '''''''''''''Strange statement.  Forgot why it is here.
        'If chkShowEleNum.Checked = True Then
        'Call ParticleStress(nEle, nActEle, xEle(0), yEle(0), areaEle(0), nCon, xCon(0), yCon(0), FxCon(0), FyCon(0), flagConBoun(0), pairCon(0, 0), ptcStress(0, 0))
        'End If

        Call updateLoadParams()
        If iCurStep(1) > intLoadPara(0, 0) Then    ' The automatic loading sequence has finished, pause running and go back to manula mode
            timerTest.Enabled = False
            btnPause.Text = "Resume"
            iCurStep(1) = 0
            For i As Integer = 0 To 7
                intLoadPara(i + 1, 0) = intLoadPara(i + 1, intLoadPara(0, 0))
                realLoadPara(i, 0) = realLoadPara(i, intLoadPara(0, 0))
            Next
            grpConfiningControl.Enabled = True
            grpDisplacementLoadControl.Enabled = True
            grpLoadModeControl.Enabled = True
            updateLoadParams()
            flagLoadMode = 0

        End If


        If iCurStep(3) = 1 And setOutputFreq.Enabled = True Then  ' output the fabric and stress tensors, global first and then in masks if masks were defined


            ' Get the global tensor first
            flagOutput = 1
            nOutNodeMask = 0
            iOutHistMode = 0
            If eleMaskOut(0, 0) = 0 Then
                flagOutput = 2  ' if no mask has been defined, then need a line break
            End If

            Call Histogram(nEle, nActEle, xEle, yEle, mInertEle, qEle, iniOri, Ori, elong, _
             nVertex, nCon, xCon, yCon, FxCon, FyCon, FCon, flagConBoun, FAngle, fricRatio, tanNorm, qNorm, _
            nOutNodeMask, MaskOut, BinForce, BinOri, BinFR, BinNorm, BinSlideNorm, BinFN, BinFT, BinRoseFR, _
             iOutHistMode, iWeight, jWeight, iBoundMode, flagFMask, flagEMask, _
            nBinForce, nBinOri, nBinFR, nBinNorm, ptBinF, ptBinE, ptBinFR, ptBinNorm, ptBinSlideNorm, ptBinFN, ptBinFT, ptBinRoseFR, _
            tsFabric, tsStress, tsConNorm, numContact, pairCon, flagOutput, vol, iCurStep, ptcStress, nEleMask, factorSlideNorm, scalePolar)


            If eleMaskOut(0, 0) > 0 Then


                ' Get the masked tensor one by one

                For i As Integer = 1 To eleMaskOut(0, 0)
                    iOutHistMode = 1
                    If i = eleMaskOut(0, 0) Then
                        flagOutput = 2
                    Else
                        flagOutput = 1
                    End If
                    nOutNodeMask = eleMaskOut(0, i)
                    For j As Integer = 0 To nOutNodeMask - 1
                        MaskOut(j) = eleMaskOut(j + 1, i)
                    Next

                    Call Histogram(nEle, nActEle, xEle, yEle, mInertEle, qEle, iniOri, Ori, elong, _
                     nVertex, nCon, xCon, yCon, FxCon, FyCon, FCon, flagConBoun, FAngle, fricRatio, tanNorm, qNorm, _
                    nOutNodeMask, MaskOut, BinForce, BinOri, BinFR, BinNorm, BinSlideNorm, BinFN, BinFT, BinRoseFR, _
                    iOutHistMode, iWeight, jWeight, iBoundMode, flagFMask, flagEMask, _
                    nBinForce, nBinOri, nBinFR, nBinNorm, ptBinF, ptBinE, ptBinFR, ptBinNorm, ptBinSlideNorm, ptBinFN, ptBinFT, ptBinRoseFR, _
                    tsFabric, tsStress, tsConNorm, numContact, pairCon, flagOutput, vol, iCurStep, ptcStress, nEleMask, factorSlideNorm, scalePolar)

                Next


            End If

        End If


        If modeHist.Checked = True Then
            flagOutput = 0
            Call Histogram(nEle, nActEle, xEle, yEle, mInertEle, qEle, iniOri, Ori, elong, _
             nVertex, nCon, xCon, yCon, FxCon, FyCon, FCon, flagConBoun, FAngle, fricRatio, tanNorm, qNorm, _
            nNodeMask, Mask, BinForce, BinOri, BinFR, BinNorm, BinSlideNorm, BinFN, BinFT, BinRoseFR, _
            iHistMode, iWeight, jWeight, iBoundMode, flagFMask, flagEMask, _
            nBinForce, nBinOri, nBinFR, nBinNorm, ptBinF, ptBinE, ptBinFR, ptBinNorm, ptBinSlideNorm, ptBinFN, ptBinFT, ptBinRoseFR, _
            tsFabric, tsStress, tsConNorm, numContact, pairCon, flagOutput, vol, iCurStep, ptcStress, nEleMask, factorSlideNorm, scalePolar)

            'angFabAxis1 = 0.5 * Math.Atan(2 * tsFabric(1) / (tsFabric(0) - tsFabric(3)))
            'angFabAxis2 = angFabAxis1 + 1.57

            'angStressAxis1 = 0.5 * Math.Atan(2 * tsStress(1) / (tsStress(0) - tsStress(3)))
            'angStressAxis2 = angStressAxis1 + 1.57

            'angBodyStressAxis1 = 0.5 * Math.Atan(2 * tsStress(5) / (tsStress(4) - tsStress(7)))
            'angBodyStressAxis2 = angBodyStressAxis1 + 1.57

            Call TensorAxis(angFabAxis1, angFabAxis2, tsFabric(0), tsFabric(1), tsFabric(3))

            Call TensorAxis(angFabCN1, angFabCN2, tsConNorm(0), tsConNorm(1), tsConNorm(3))

            Call TensorAxis(angBodyStressAxis1, angBodyStressAxis2, tsStress(4), tsStress(5), tsStress(7))

            Call TensorAxis(angStressAxis1, angStressAxis2, tsStress(0), tsStress(1), tsStress(3))

        End If


        timeNow(7) = timeGetTime


        If chkAutoMaxRFriend.Checked = True Then
            setMaxRFriend.Value = Math.Max(monitor(3) * 2 * dt * nInc, minREle)

        End If




        canvas.Invalidate()

        flagGlue = 0

        dtCrit = -Math.Log(Math.Sqrt(density * 3.14 * minREle / stiff)) / Math.Log(2) + 2

        If chkSave.Checked = True And (iCurStep(0) Mod freqSave = 0 Or iCurStep(0) = 1) Then
            Params(0) = dt
            Params(1) = stiff
            Params(2) = globdamp
            Params(3) = rollingDamp
            Params(4) = dampingRatio
            Params(5) = maxGap
            Params(6) = tanTheta(0)
            Params(7) = setPx.Value
            Params(8) = setPy.Value
            Params(9) = pInt
            Params(10) = gXgY(0)
            Params(11) = gXgY(1)
            Params(12) = xGravity(0)
            Params(13) = xGravity(1)
            Params(14) = setpxy.Value
            Params(15) = vol
            Params(16) = tanTheta(1)



            Call WriteResult(nEle, nActEle, xEle, yEle, qEle, _
                             vxEle, vyEle, vqEle, nWall, x1Wall, x2Wall, y1Wall, y2Wall, nCon, xCon, yCon, _
           rCon, FxCon, FyCon, fricRatio, tanNorm, flagConBoun, pairCon, _
           nPtHL, xPtHL, strgTensl, strgRatio, Params, alwNEleFrd, flagWriteOpen, iCurStep, FileName, lName)

        End If

        setFreqSaveRST.Value = freqSave

        If iCurStep(0) >= setMaxStep.Value Then
            timerTest.Enabled = False
        End If


    End Sub

    Private Sub canvas_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles canvas.BackColorChanged
        mainTransparency.BackColor = canvas.BackColor
    End Sub




    Private Sub Canvas_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles canvas.Paint
        Dim graphObj As Graphics = e.Graphics

        Dim xCanvas() As Double = New Double(3) {}
        Dim nEleV As Integer = 0
        Dim nConV As Integer = 0
        Dim eleView() As Integer = New Integer(nEle - 1) {}
        Dim conView() As Integer = New Integer(nEle * 10 - 1) {}
        Dim flagShowCon As Integer = 0


        If chkForceByThick.Checked Or flagForceByLeng.Checked Or flagShowP.Checked Or chkShowSliding.Checked Then
            flagShowCon = 1
        End If


        Dim i As Integer

        xCanvas(0) = 0 - xOrigin / zoomScale
        xCanvas(1) = (canvasContainer.Width - xOrigin) / zoomScale
        xCanvas(2) = yOrigin / zoomScale
        xCanvas(3) = (canvasContainer.Height + yOrigin) / zoomScale


        Call DrawRange(nEle, nActEle, limitAll, _
        xGrid, nGridX, nGridY, xCanvas, nEleV, nConV, _
        nCon, xCon, yCon, eleView, conView, flagShowCon, _
        nEleGrid, lEG, maxNEleGrid)





        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''' Draw motion contour, draw motion trace  '''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If modeMotion.Checked = True Then

            subDrawMotion(graphObj, nEleV, eleView)

        End If




        '''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''' Draw Elements  '''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''

        If chkHideElement.Checked = False And dEleMax * zoomScale > 10 Then

            subDrawElement(graphObj, nEleV, eleView)

        End If

        If chkShwDiscMask.Checked = True Then
            subDrawDiscMask(graphObj)
        End If

        '''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''' Draw Element Orientation  '''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''

        If flagRotation.Checked = True Or (chkHideElement.Checked = False And dEleMax * zoomScale < 10) Then

            subDrawOrientation(graphObj, nEleV, eleView)

        End If


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If chkShowDualCelll.Checked Then
            subDrawCellInEle(graphObj)
        End If

        If chkShowContNum.Checked Then
            subDrawContNum(graphObj)

        End If


        '''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''' Draw Walls  '''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''



        For iWall As Integer = 0 To nWall - 1
            If iWall = actWall Then
                penWall = penActWall
            Else
                penWall = penInactWall
            End If
            graphObj.DrawLine(penWall, Convert.ToSingle(x1Wall(iWall) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((y1Wall(iWall)) * zoomScale) + yOrigin, Convert.ToSingle(x2Wall(iWall) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((y2Wall(iWall)) * zoomScale) + yOrigin)
        Next


        '''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''' Draw Force by Length  '''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''

        If flagForceByLeng.Checked = True Then

            Dim iCon As Integer
            For iList As Integer = 0 To nConV - 1
                iCon = conView(iList) - 1
                If (flagConBoun(iCon) = 0) Or ((flagConBoun(iCon) = 2 And chkIncWallForce.Checked = True)) Then

                    If chkShowForceColor.Checked Then
                        penForceColor.Color = Color.FromArgb(FRGB(0, iCon), FRGB(1, iCon), FRGB(2, iCon))
                    Else

                        penForceColor.Color = Color.FromArgb(255, 121, 0, 38)

                    End If




                    graphObj.DrawLine(penForceColor, Convert.ToSingle((xCon(iCon) - FLenScale * FxCon(iCon)) * zoomScale) + xOrigin, _
                                          canvasContainer.Height - Convert.ToSingle(((yCon(iCon) - FLenScale * FyCon(iCon))) * zoomScale) + yOrigin, _
                                          Convert.ToSingle((xCon(iCon) + FLenScale * FxCon(iCon)) * zoomScale) + xOrigin, _
                                          canvasContainer.Height - Convert.ToSingle(((yCon(iCon) + FLenScale * FyCon(iCon))) * zoomScale) + yOrigin)

                End If

            Next

        End If

        penForce.Color = Color.FromArgb(255, 121, 0, 38)

        '''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''' Draw Force by Thickness '''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''


        If chkForceByThick.Checked Then
            Dim myColor As New Color
            myColor = Color.FromArgb(255, 121, 0, 38)
            Dim brushForce As New SolidBrush(myColor)
            penForceColor.Color = myColor
            Dim iCon As Integer
            For iList As Integer = 0 To nConV - 1
                iCon = conView(iList) - 1
                If (flagConBoun(iCon) = 0) Or ((flagConBoun(iCon) = 2 And chkIncWallForce.Checked = True)) Then

                    If chkShowForceColor.Checked Then
                        myColor = Color.FromArgb(FRGB(0, iCon), FRGB(1, iCon), FRGB(2, iCon))
                        penForceColor.Color = myColor
                        brushForce.Color = myColor
                    End If

                    ''Temp

                    FConTemp = Math.Sqrt(FxCon(iCon) ^ 2 + FyCon(iCon) ^ 2)

                    penForceColor.Width = FThickScale * FConTemp ^ factorContrast

                    If rbForceModeDire.Checked = True Then
                        If Not chkConForceByRadius.Checked Then
                            wForce = rCon(iCon) * FxCon(iCon) / FConTemp * factorLenThick
                            hForce = rCon(iCon) * FyCon(iCon) / FConTemp * factorLenThick
                            graphObj.DrawLine(penForceColor, Convert.ToSingle((xCon(iCon) - wForce) * zoomScale) + xOrigin, _
                                              canvasContainer.Height - Convert.ToSingle(((yCon(iCon) - hForce)) * zoomScale) + yOrigin, _
                                              Convert.ToSingle((xCon(iCon) + wForce) * zoomScale) + xOrigin, _
                                              canvasContainer.Height - Convert.ToSingle(((yCon(iCon) + hForce)) * zoomScale) + yOrigin)

                        Else
                            graphObj.FillEllipse(brushForce, (X2Scr(xCon(iCon)) - penForceColor.Width), (Y2Scr(yCon(iCon)) - penForceColor.Width), _
                                                 2 * penForceColor.Width, 2 * penForceColor.Width)

                        End If
                    ElseIf flagConBoun(iCon) = 0 Then
                        graphObj.DrawLine(penForceColor, Convert.ToSingle(xEle(pairCon(1, iCon) - 1) * zoomScale) + xOrigin, _
                                          canvasContainer.Height - Convert.ToSingle(yEle(pairCon(1, iCon) - 1) * zoomScale) + yOrigin, _
                                          Convert.ToSingle(xEle(pairCon(0, iCon) - 1) * zoomScale) + xOrigin, _
                                          canvasContainer.Height - Convert.ToSingle(yEle(pairCon(0, iCon) - 1) * zoomScale) + yOrigin)
                    End If
                End If


            Next


        End If



        '''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''' Slding '''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''


        If chkShowSliding.Checked = True Then

            Dim iCon As Integer
            For iList As Integer = 0 To nConV - 1
                iCon = conView(iList) - 1
                If fricRatio(iCon) > 0.9999999 Then

                    FConTemp = Math.Sqrt(FxCon(iCon) ^ 2 + FyCon(iCon) ^ 2)
                    wForce = SlidScale * FConTemp ^ factorSlid


                    graphObj.FillEllipse(Brushes.Red, Convert.ToSingle((xCon(iCon)) * zoomScale) + xOrigin - Convert.ToSingle(wForce), _
                                         canvasContainer.Height - Convert.ToSingle(((yCon(iCon))) * zoomScale) + yOrigin - Convert.ToSingle(wForce), _
                                         2 * Convert.ToSingle(wForce), 2 * Convert.ToSingle(wForce))
                    graphObj.FillEllipse(Brushes.Orange, Convert.ToSingle((xCon(iCon)) * zoomScale) + xOrigin - 2, canvasContainer.Height - Convert.ToSingle(((yCon(iCon))) * zoomScale) + yOrigin - 2, 4, 4)

                End If

            Next


        End If

        lbCritDt.Text = ">" & dtCrit.ToString("F01")


        '''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''' Draw Confining pressure '''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''

        If flagShowP.Checked = True Then

            If trackPost.Visible = False Then


                For iCon As Integer = 0 To nPCon - 1 Step setStepSparse.Value

                    graphObj.DrawLine(penP, Convert.ToSingle(pPlot(0, iCon) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((pPlot(1, iCon)) * zoomScale) + yOrigin, Convert.ToSingle(pPlot(0, iCon) * zoomScale - pPlot(2, iCon) * pScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((pPlot(1, iCon)) * zoomScale - pPlot(3, iCon) * pScale) + yOrigin)

                Next

            Else

                Dim iCon As Integer
                For iList As Integer = 0 To nConV - 1 Step setStepSparse.Value
                    iCon = conView(iList) - 1
                    If flagConBoun(iCon) = 1 Then
                        graphObj.DrawLine(penP, Convert.ToSingle(xCon(iCon) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((yCon(iCon)) * zoomScale) + yOrigin, Convert.ToSingle(xCon(iCon) * zoomScale - FxCon(iCon) * pScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((yCon(iCon)) * zoomScale - FyCon(iCon) * pScale) + yOrigin)

                    End If

                Next

            End If


        End If


        '''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''' Draw velocity '''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''

        If checkShowVel.Checked = True Then

            For iEle As Integer = 0 To nEleV - 1
                i = eleView(iEle) - 1
                graphObj.DrawLine(Pens.Crimson, Convert.ToSingle(xEle(i) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((yEle(i))) * zoomScale) + yOrigin, Convert.ToSingle((xEle(i) + vxEle(i) * scaleVel) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((yEle(i) + vyEle(i) * scaleVel)) * zoomScale) + yOrigin)

            Next

            lbVelFactor.Text = (scaleVel / dt / nInc).ToString("E01")
        End If

        If chkShowCohesion.Checked = True Then
            For iPt As Integer = 0 To nPtHL - 1
                graphObj.FillEllipse(Brushes.Red, Convert.ToSingle(xPtHL(0, iPt) * zoomScale) + xOrigin - 2, canvasContainer.Height - Convert.ToSingle((xPtHL(1, iPt)) * zoomScale) + yOrigin - 2, 4, 4)
            Next

        End If

        If chkShowFriend.Checked = True Then


            For iPair As Integer = 0 To nPair - 1
                If pair(0, iPair) = actEle + 1 Then
                    If nVertex(pair(1, iPair) - 1) = 0 Then
                        graphObj.DrawEllipse(penFrd, Convert.ToSingle((xEle(pair(1, iPair) - 1) - rEle(pair(1, iPair) - 1)) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((yEle(pair(1, iPair) - 1) + rEle(pair(1, iPair) - 1))) * zoomScale) + yOrigin, Convert.ToSingle(2 * rEle(pair(1, iPair) - 1) * zoomScale), Convert.ToSingle(2 * rEle(pair(1, iPair) - 1) * zoomScale))
                    Else
                        For j As Integer = 0 To nVertex(pair(1, iPair) - 1) - 1
                            graphObj.DrawLine(penFrd, Convert.ToSingle(xVertex(j, pair(1, iPair) - 1) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((yVertex(j, pair(1, iPair) - 1)) * zoomScale) + yOrigin, Convert.ToSingle(xVertex(j + 1, pair(1, iPair) - 1) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((yVertex(j + 1, pair(1, iPair) - 1)) * zoomScale) + yOrigin)
                        Next

                    End If
                End If

                If pair(1, iPair) = actEle + 1 Then

                    If nVertex(pair(0, iPair) - 1) = 0 Then
                        graphObj.DrawEllipse(penFrd, Convert.ToSingle((xEle(pair(0, iPair) - 1) - rEle(pair(0, iPair) - 1)) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((yEle(pair(0, iPair) - 1) + rEle(pair(0, iPair) - 1))) * zoomScale) + yOrigin, Convert.ToSingle(2 * rEle(pair(0, iPair) - 1) * zoomScale), Convert.ToSingle(2 * rEle(pair(0, iPair) - 1) * zoomScale))
                    Else
                        For j As Integer = 0 To nVertex(pair(0, iPair) - 1) - 1
                            graphObj.DrawLine(penFrd, Convert.ToSingle(xVertex(j, pair(0, iPair) - 1) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((yVertex(j, pair(0, iPair) - 1)) * zoomScale) + yOrigin, Convert.ToSingle(xVertex(j + 1, pair(0, iPair) - 1) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((yVertex(j + 1, pair(0, iPair) - 1)) * zoomScale) + yOrigin)
                        Next

                    End If


                End If
            Next

        End If






        If flagAdd = 1 Then
            For iV As Integer = 0 To nVNew - 2
                graphObj.DrawLine(penGreen, Convert.ToSingle(xVNew(iV, 0) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(xVNew(iV, 1) * zoomScale) + yOrigin, Convert.ToSingle(xVNew(iV + 1, 0) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(xVNew(iV + 1, 1) * zoomScale) + yOrigin)
            Next

        End If

        If flagEditVertex = 1 Then
            If nVertex(actEle) > 0 Then
                graphObj.DrawEllipse(penGreen, Convert.ToSingle(xVertex(actVertex, actEle) * zoomScale) + xOrigin - 3, canvasContainer.Height - Convert.ToSingle(yVertex(actVertex, actEle) * zoomScale) + yOrigin - 3, 6, 6)
            Else
                graphObj.DrawEllipse(penGreen, Convert.ToSingle((xEle(actEle) + rEle(actEle)) * zoomScale) + xOrigin - 3, canvasContainer.Height - Convert.ToSingle(yEle(actEle) * zoomScale) + yOrigin - 3, 6, 6)

            End If
        End If


        If modeGD.Checked And rbGridLine.Checked Then


            For iLine As Integer = 0 To nHLine - 1
                For iPt As Integer = 0 To nHPtGD(iLine) - 2 Step 2
                    graphObj.DrawLine(penGD2, Convert.ToSingle(xHPtGD(0, iPt, iLine) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((xHPtGD(1, iPt, iLine)) * zoomScale) + yOrigin, Convert.ToSingle(xHPtGD(0, iPt + 1, iLine) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((xHPtGD(1, iPt + 1, iLine)) * zoomScale) + yOrigin)
                    graphObj.DrawLine(penGD, Convert.ToSingle(xHPtGD(0, iPt, iLine) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((xHPtGD(1, iPt, iLine)) * zoomScale) + yOrigin, Convert.ToSingle(xHPtGD(0, iPt + 1, iLine) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((xHPtGD(1, iPt + 1, iLine)) * zoomScale) + yOrigin)

                Next
            Next

            For iLine As Integer = 0 To nVLine - 1
                For iPt As Integer = 0 To nVPtGD(iLine) - 2 Step 2
                    graphObj.DrawLine(penGD2, Convert.ToSingle(xVPtGD(0, iPt, iLine) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((xVPtGD(1, iPt, iLine)) * zoomScale) + yOrigin, Convert.ToSingle(xVPtGD(0, iPt + 1, iLine) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((xVPtGD(1, iPt + 1, iLine)) * zoomScale) + yOrigin)
                    graphObj.DrawLine(penGD, Convert.ToSingle(xVPtGD(0, iPt, iLine) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((xVPtGD(1, iPt, iLine)) * zoomScale) + yOrigin, Convert.ToSingle(xVPtGD(0, iPt + 1, iLine) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((xVPtGD(1, iPt + 1, iLine)) * zoomScale) + yOrigin)

                Next
            Next

        End If

        If modeHist.Checked = True Then
            Histgram.roseForce.Invalidate()
            Histgram.roseOrit.Invalidate()
            Histgram.roseNorm.Invalidate()
            Histgram.hgFR.Invalidate()
            Histgram.roseForceNormTang.Invalidate()
            Histgram.roseShearRatio.Invalidate()
            Histgram.groupTsStress.Invalidate()
            Histgram.groupTsFabric.Invalidate()
            Histgram.gbFabricConNorm.Invalidate()
            Histgram.groupTsBodyStress.Invalidate()

        End If

        If chkShowVCFabric.Checked Then
            VoidVector.InvalidateMe()

        End If


        If flagNewVRBox = 1 Then

            graphObj.DrawRectangle(Pens.OrangeRed, ptBox1.X, ptBox1.Y, ptBox2.X - ptBox1.X, ptBox2.Y - ptBox1.Y)

        End If



        If chkMeasureMode.Checked = True Then

            graphObj.FillRectangle(brushTransGray, xMeasure1 + 15, yMeasure1 - 36, 120, 42)
            graphObj.DrawRectangle(Pens.White, xMeasure1 + 15, yMeasure1 - 36, 120, 42)
            graphObj.DrawString("Distance = " & distMeasure.ToString("F05"), Me.Font, Brushes.Black, xMeasure1 + 20, yMeasure1 - 28)
            graphObj.DrawString("  Angle  =" & angMeasure.ToString("F01") & "  deg", Me.Font, Brushes.Black, xMeasure1 + 20, yMeasure1 - 12)
            graphObj.DrawLine(Pens.Blue, xMeasure0, yMeasure0, xMeasure1, yMeasure1)

        End If


        If flagSampleRotate = 1 Then
            graphObj.DrawEllipse(New Pen(Color.LightBlue, 6), Convert.ToSingle((xRotationCenter(0) - 0.4 * (limitAll(1) - limitAll(0))) * zoomScale) + xOrigin, _
                                 canvasContainer.Height - Convert.ToSingle((xRotationCenter(1) + 0.4 * (limitAll(1) - limitAll(0))) * zoomScale) + yOrigin, _
                                 Convert.ToSingle((limitAll(1) - limitAll(0)) * zoomScale * 0.8), Convert.ToSingle((limitAll(1) - limitAll(0)) * zoomScale * 0.8))
            graphObj.DrawEllipse(New Pen(Color.LightBlue, 6), Convert.ToSingle((xRotationCenter(0) - 0.2 * (limitAll(1) - limitAll(0))) * zoomScale) + xOrigin, _
                                 canvasContainer.Height - Convert.ToSingle((xRotationCenter(1) + 0.2 * (limitAll(1) - limitAll(0))) * zoomScale) + yOrigin, _
                                 Convert.ToSingle((limitAll(1) - limitAll(0)) * zoomScale * 0.4), Convert.ToSingle((limitAll(1) - limitAll(0)) * zoomScale * 0.4))
            graphObj.DrawEllipse(New Pen(Color.LightBlue, 6), Convert.ToSingle((xRotationCenter(0) - 0.6 * (limitAll(1) - limitAll(0))) * zoomScale) + xOrigin, _
                                 canvasContainer.Height - Convert.ToSingle((xRotationCenter(1) + 0.6 * (limitAll(1) - limitAll(0))) * zoomScale) + yOrigin, _
                                 Convert.ToSingle((limitAll(1) - limitAll(0)) * zoomScale * 1.2), Convert.ToSingle((limitAll(1) - limitAll(0)) * zoomScale * 1.2))
        End If


        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''' Draw the mask for cropping ''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If flagMaskCropOn = 1 Then


            If rbMaskCircular.Checked = True And nPtMaskCrop = 1 Then

                graphObj.FillEllipse(brushMask, Convert.ToSingle((xMaskCrop(0, 0) - xMaskCrop(0, 1)) * zoomScale + xOrigin), _
                                       Convert.ToSingle(canvasContainer.Height - ((xMaskCrop(1, 0) + xMaskCrop(0, 1)) * zoomScale) + yOrigin), _
                                       Convert.ToSingle(2 * xMaskCrop(0, 1) * zoomScale), Convert.ToSingle(2 * xMaskCrop(0, 1) * zoomScale))

            ElseIf rbMaskRect.Checked = True And nPtMaskCrop = 1 Then

                graphObj.FillRectangle(brushMask, Math.Min(Convert.ToSingle(xMaskCrop(0, 0) * zoomScale + xOrigin), Convert.ToSingle(xMaskCrop(0, 2) * zoomScale + xOrigin)), _
                                       Math.Min(Convert.ToSingle(canvasContainer.Height - (xMaskCrop(1, 0) * zoomScale) + yOrigin), Convert.ToSingle(canvasContainer.Height - (xMaskCrop(1, 2) * zoomScale) + yOrigin)), _
                                       Math.Abs(Convert.ToSingle((xMaskCrop(0, 2) - xMaskCrop(0, 0)) * zoomScale)), _
                                       Math.Abs(Convert.ToSingle((xMaskCrop(1, 0) - xMaskCrop(1, 2)) * zoomScale)))

                graphObj.DrawString(ratioWHMask.ToString("F03") & ":1", Me.Font, Brushes.DarkBlue, Convert.ToSingle(xMaskCrop(0, 2) * zoomScale + xOrigin) - 75, Convert.ToSingle(canvasContainer.Height - (xMaskCrop(1, 2) * zoomScale) + yOrigin) - 20)
            ElseIf rbMaskPoly.Checked = True Then

                If nPtMaskCrop > 1 And flagCreatingMaskOn = 1 Then

                    ReDim ptMask(nPtMaskCrop)
                    For iM As Integer = 0 To nPtMaskCrop
                        ptMask(iM).X = xMaskCrop(0, iM) * zoomScale + xOrigin
                        ptMask(iM).Y = canvasContainer.Height - xMaskCrop(1, iM) * zoomScale + yOrigin
                    Next
                    graphObj.FillPolygon(brushMask, ptMask)


                End If

                If nPtMaskCrop > 0 And flagCreatingMaskOn = 1 Then
                    graphObj.DrawLine(penActWall, Convert.ToSingle(xMaskCrop(0, nPtMaskCrop - 1) * zoomScale) + xOrigin, _
                                       canvasContainer.Height - Convert.ToSingle(xMaskCrop(1, nPtMaskCrop - 1) * zoomScale) + yOrigin, _
                                        Convert.ToSingle(xMaskCrop(0, nPtMaskCrop) * zoomScale) + xOrigin, _
                                       canvasContainer.Height - Convert.ToSingle(xMaskCrop(1, nPtMaskCrop) * zoomScale) + yOrigin)

                End If

            End If
        End If

        If chkShowCoord.Checked = True Then

            graphObj.FillRectangle(brushTransGray, Convert.ToSingle(xCursor(0)) + 14, Convert.ToSingle(xCursor(1)) - 20, 120, 42)
            graphObj.FillEllipse(Brushes.Red, Convert.ToSingle(xCursor(0)) - 2, Convert.ToSingle(xCursor(1)) - 2, 4, 4)

            graphObj.DrawRectangle(Pens.White, Convert.ToSingle(xCursor(0)) + 14, Convert.ToSingle(xCursor(1)) - 20, 120, 42)
            graphObj.DrawString("x = " & ((xCursor(0) - xOrigin) / zoomScale).ToString("E06"), Me.Font, Brushes.Black, Convert.ToSingle(xCursor(0)) + 19, Convert.ToSingle(xCursor(1)) - 12)
            graphObj.DrawString("y  =" & ((canvasContainer.Height - xCursor(1) + yOrigin) / zoomScale).ToString("E06"), Me.Font, Brushes.Black, Convert.ToSingle(xCursor(0)) + 19, Convert.ToSingle(xCursor(1)) + 4)

        End If

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''' Draw sliding trace  ''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If chkShowSldTrace.Checked = True Then

            For iPtSld As Integer = 0 To nPlotSld - 1
                graphObj.DrawEllipse(Pens.Red, (xPlotSld(iPtSld, 0) * zoomScale) + xOrigin - 2, canvasContainer.Height - (xPlotSld(iPtSld, 1) * zoomScale) + yOrigin - 2, 4, 4)
                'graphObj.DrawLine(Pens.Green, (xPlotSld(iPtSld, 0) * zoomScale) + xOrigin, canvasContainer.Height - (xPlotSld(iPtSld, 1) * zoomScale) + yOrigin, (xPlotSld(iPtSld, 2) * zoomScale) + xOrigin, canvasContainer.Height - (xPlotSld(iPtSld, 3) * zoomScale) + yOrigin)
            Next

        End If

        If chkShowRollingTrace.Checked = True Then

            For iPtSld As Integer = 0 To nPlotRol - 1
                graphObj.FillEllipse(Brushes.DarkGreen, Convert.ToSingle(xPlotRol(iPtSld, 0) * zoomScale) + xOrigin - 1, canvasContainer.Height - Convert.ToSingle(xPlotRol(iPtSld, 1) * zoomScale) + yOrigin - 1, 3, 3)
            Next

        End If


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''' Draw strain cells    ''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If chkShowCell.Checked = True Then

            Dim randNum As Random = New Random()

            For iCell As Integer = 0 To numCell - 1
                If flagEffCell(iCell) = 1 Then
                    For iEle As Integer = 1 To 3
                        graphObj.DrawLine(Pens.Gray, Convert.ToSingle(xEle(eleStnCell(iEle Mod 3, iCell) - 1) * zoomScale) + xOrigin, _
                          canvasContainer.Height - Convert.ToSingle(yEle(eleStnCell(iEle Mod 3, iCell) - 1) * zoomScale) + yOrigin, _
                          Convert.ToSingle(xEle(eleStnCell((iEle + 1) Mod 3, iCell) - 1) * zoomScale) + xOrigin, _
                          canvasContainer.Height - Convert.ToSingle(yEle(eleStnCell((iEle + 1) Mod 3, iCell) - 1) * zoomScale) + yOrigin)

                    Next

                    triangleCell(0) = New Point(Convert.ToSingle(xEle(eleStnCell(0, iCell) - 1) * zoomScale) + xOrigin, _
                                             canvasContainer.Height - Convert.ToSingle(yEle(eleStnCell(0, iCell) - 1) * zoomScale) + yOrigin)
                    triangleCell(1) = New Point(Convert.ToSingle(xEle(eleStnCell(1, iCell) - 1) * zoomScale) + xOrigin, _
                                             canvasContainer.Height - Convert.ToSingle(yEle(eleStnCell(1, iCell) - 1) * zoomScale) + yOrigin)
                    triangleCell(2) = New Point(Convert.ToSingle(xEle(eleStnCell(2, iCell) - 1) * zoomScale) + xOrigin, _
                                             canvasContainer.Height - Convert.ToSingle(yEle(eleStnCell(2, iCell) - 1) * zoomScale) + yOrigin)

                    Dim brushRand As SolidBrush = New SolidBrush(Color.FromArgb(120, randNum.Next(50, 250), randNum.Next(30, 230), randNum.Next(20, 210)))

                    graphObj.FillPolygon(brushRand, triangleCell)
                End If

            Next
            For iCell As Integer = 0 To numCell - 1
                If flagEffCell(iCell) = 1 Then
                    xCell(0, iCell) = (xEle(eleStnCell(0, iCell) - 1) + xEle(eleStnCell(1, iCell) - 1) + xEle(eleStnCell(2, iCell) - 1)) / 3
                    xCell(1, iCell) = (yEle(eleStnCell(0, iCell) - 1) + yEle(eleStnCell(1, iCell) - 1) + yEle(eleStnCell(2, iCell) - 1)) / 3

                    '    graphObj.FillRectangle(Brushes.Brown, Convert.ToSingle(xCell(0, iCell) * zoomScale) + xOrigin - 3, _
                    '                             canvasContainer.Height - Convert.ToSingle(xCell(1, iCell) * zoomScale) + yOrigin - 3, _
                    '                             6, 6)
                End If

            Next

            For iCell As Integer = 0 To nActCell - 1

                triangleCell(0) = New Point(Convert.ToSingle(xEle(eleStnCell(0, cellAct(iCell)) - 1) * zoomScale) + xOrigin, _
                                         canvasContainer.Height - Convert.ToSingle(yEle(eleStnCell(0, cellAct(iCell)) - 1) * zoomScale) + yOrigin)
                triangleCell(1) = New Point(Convert.ToSingle(xEle(eleStnCell(1, cellAct(iCell)) - 1) * zoomScale) + xOrigin, _
                                         canvasContainer.Height - Convert.ToSingle(yEle(eleStnCell(1, cellAct(iCell)) - 1) * zoomScale) + yOrigin)
                triangleCell(2) = New Point(Convert.ToSingle(xEle(eleStnCell(2, cellAct(iCell)) - 1) * zoomScale) + xOrigin, _
                                         canvasContainer.Height - Convert.ToSingle(yEle(eleStnCell(2, cellAct(iCell)) - 1) * zoomScale) + yOrigin)

                graphObj.FillPolygon(brushes.DarkBlue, triangleCell)

            Next

        End If

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''' Draw strain outputs   ''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If chkShowStrain.Checked Then
            Dim penStnPos As Pen = New Pen(Color.DarkRed, setPenWidth.Value)
            Dim penStnNeg As Pen = New Pen(Color.DarkBlue, setPenWidth.Value)

            For iCell As Integer = 0 To numCell - 1

                If (flagEffCell(iCell) = 1) And (rbShowBothStn.Checked = True Or (rbShowPosiStn.Checked = True And strainOut(iCell) >= 0) Or (rbShowNegStn.Checked = True And strainOut(iCell) < 0)) Then
                    Dim cellCenter() As Single = New Single(1) {}

                    cellCenter(0) = Convert.ToSingle((xEle(eleStnCell(0, iCell) - 1) + xEle(eleStnCell(1, iCell) - 1) + xEle(eleStnCell(2, iCell) - 1)) / 3 * zoomScale) + xOrigin
                    cellCenter(1) = canvasContainer.Height - Convert.ToSingle((yEle(eleStnCell(0, iCell) - 1) + yEle(eleStnCell(1, iCell) - 1) + yEle(eleStnCell(2, iCell) - 1)) / 3 * zoomScale) + yOrigin



                    If strainOut(iCell) < 0 Then
                        graphObj.DrawRectangle(penStnNeg, Convert.ToSingle(cellCenter(0) - Math.Abs(strainOut(iCell)) ^ stnContrast * scaleStnOut * zoomScale), _
                                  Convert.ToSingle(cellCenter(1) - Math.Abs(strainOut(iCell)) ^ stnContrast * scaleStnOut * zoomScale), _
                                  Convert.ToSingle(2 * Math.Abs(strainOut(iCell)) ^ stnContrast * scaleStnOut * zoomScale), _
                                  Convert.ToSingle(2 * Math.Abs(strainOut(iCell)) ^ stnContrast * scaleStnOut * zoomScale))
                    Else
                        graphObj.DrawEllipse(penStnPos, Convert.ToSingle(cellCenter(0) - Math.Abs(strainOut(iCell)) ^ stnContrast * scaleStnOut * zoomScale), _
                                  Convert.ToSingle(cellCenter(1) - Math.Abs(strainOut(iCell)) ^ stnContrast * scaleStnOut * zoomScale), _
                                  Convert.ToSingle(2 * Math.Abs(strainOut(iCell)) ^ stnContrast * scaleStnOut * zoomScale), _
                                  Convert.ToSingle(2 * Math.Abs(strainOut(iCell)) ^ stnContrast * scaleStnOut * zoomScale))

                    End If

                End If

            Next


        End If
        If chkShowStnLegend.Checked Then
            graphObj.DrawRectangle(Pens.Red, Convert.ToSingle(X2Scr(limitAll(1)) + 100 - setValLegend.Value ^ stnContrast * scaleStnOut * zoomScale), _
                                              Convert.ToSingle(Y2Scr(limitAll(2)) - 100 - setValLegend.Value ^ stnContrast * scaleStnOut * zoomScale), _
                                                  Convert.ToSingle(2 * setValLegend.Value ^ stnContrast * scaleStnOut * zoomScale), _
                                                 Convert.ToSingle(2 * setValLegend.Value ^ stnContrast * scaleStnOut * zoomScale))

        End If

        If chkShowStnDrct.Checked Then
            For iCell As Integer = 0 To numCell - 1

                If (flagEffCell(iCell) = 1) And (rbShowBothStn.Checked = True Or (rbShowPosiStn.Checked = True And strainOut(iCell) >= 0) Or (rbShowNegStn.Checked = True And strainOut(iCell) < 0)) Then

                    cellCenter(0) = Convert.ToSingle((xEle(eleStnCell(0, iCell) - 1) + xEle(eleStnCell(1, iCell) - 1) + xEle(eleStnCell(2, iCell) - 1)) / 3 * zoomScale) + xOrigin
                    cellCenter(1) = canvasContainer.Height - Convert.ToSingle((yEle(eleStnCell(0, iCell) - 1) + yEle(eleStnCell(1, iCell) - 1) + yEle(eleStnCell(2, iCell) - 1)) / 3 * zoomScale) + yOrigin

                    If strainOut(iCell) > 0 Then
                        penStrain = Pens.DarkRed
                    Else
                        penStrain = Pens.Blue
                    End If

                    If chkLgthStrn.Checked = True Then
                        lgthStrn = Math.Abs(strainOut(iCell)) ^ stnContrast * scaleStnOut * zoomScale
                    Else
                        lgthStrn = scaleStnDrct * scaleStnOut * zoomScale
                    End If

                    'penStrain = New Pen(Color.Black, 1)
                    graphObj.DrawLine(penStrain, Convert.ToSingle(cellCenter(0) - lgthStrn * Math.Cos(drctStn(iCell))), _
                                                      Convert.ToSingle(cellCenter(1) + lgthStrn * Math.Sin(drctStn(iCell))), _
                                                       Convert.ToSingle(cellCenter(0) + lgthStrn * Math.Cos(drctStn(iCell))), _
                                                      Convert.ToSingle(cellCenter(1) - lgthStrn * Math.Sin(drctStn(iCell))))

                End If

            Next

        End If

        If chkShwStrnVal.Checked Then
            For iCell As Integer = 0 To numCell - 1
                If flagEffCell(iCell) = 1 Then
                    cellCenter(0) = Convert.ToSingle((xEle(eleStnCell(0, iCell) - 1) + xEle(eleStnCell(1, iCell) - 1) + xEle(eleStnCell(2, iCell) - 1)) / 3 * zoomScale) + xOrigin
                    cellCenter(1) = canvasContainer.Height - Convert.ToSingle((yEle(eleStnCell(0, iCell) - 1) + yEle(eleStnCell(1, iCell) - 1) + yEle(eleStnCell(2, iCell) - 1)) / 3 * zoomScale) + yOrigin
                    graphObj.DrawString(strainOut(iCell).ToString("E02"), Me.Font, Brushes.DarkBlue, Convert.ToSingle(cellCenter(0)), Convert.ToSingle(cellCenter(1)))
                    'graphObj.DrawString((iCell + 1).ToString("E02"), Me.Font, Brushes.DarkBlue, Convert.ToSingle(cellCenter(0)), Convert.ToSingle(cellCenter(1)))
                End If
            Next
        End If



        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''' Draw grids
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If chkShowGrid.Checked Then

            subDrawGrid(graphObj)
        End If


        'Draw mask
        If modeHist.Checked = True And Histgram.rbMaskHist.Checked = True And flagMaskOn = 1 Then
            For iM As Integer = 0 To 9
                ptMask(iM).X = xEle(Mask(iM) - 1) * zoomScale + xOrigin
                ptMask(iM).Y = canvasContainer.Height - yEle(Mask(iM) - 1) * zoomScale + yOrigin
            Next
            graphObj.FillPolygon(brushMask, ptMask)
            graphObj.DrawPolygon(penActWall, ptMask)
            graphObj.FillRectangle(brushMask, 15, 15, 200, 30)
            graphObj.DrawString(nEleMask.ToString & " elements are in the mask.", Me.Font, Brushes.LightYellow, 20, 20)


        End If


        subDrawLinks(graphObj)

        If chkHLLinks.Checked Then
            subDrawLinkedElements(graphObj)
        End If

        'Draw coordination number matrix
        If chkShowCNMatrix.Checked Then
            subDrawCNMatrix(graphObj)

        End If

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' '' Temp movie making
        'Dim penBlack As Pen = New Pen(Color.Black, 3)
        'Dim scaleRose As Single = 120 / Histgram.setScalePolar.Value
        'Dim brushWite As SolidBrush = New SolidBrush(Color.FromArgb(245, 255, 255, 255))
        'graphObj.FillRectangle(brushWite, 0, 0, 300, 300)

        'For ii As Integer = 0 To nBinOri * 2 - 1

        '    graphObj.DrawLine(penBlack, 150 + ptBinE(0, 2 * ii) * scalerose, 164 - ptBinE(1, 2 * ii) * scalerose, 150 + ptBinE(0, 2 * ii + 1) * scalerose, 164 - ptBinE(1, 2 * ii + 1) * scalerose)
        '    'roseE.DrawLine(Pens.Brown, 150, 164, ptBinE(0, 2 * i), ptBinE(1, 2 * i))

        'Next

        'For ii As Integer = 0 To nBinOri * 2 - 2
        '    graphObj.DrawLine(penBlack, 150 + ptBinE(0, 2 * ii + 1) * scalerose, 164 - ptBinE(1, 2 * ii + 1) * scalerose, 150 + ptBinE(0, 2 * ii + 2) * scalerose, 164 - ptBinE(1, 2 * ii + 2) * scalerose)

        'Next

        'graphObj.DrawLine(penBlack, 150 + ptBinE(0, nBinOri * 4 - 1) * scalerose, 164 - ptBinE(1, nBinOri * 4 - 1) * scalerose, 150 + ptBinE(0, 0) * scalerose, 164 - ptBinE(1, 0) * scalerose)

    End Sub

    Private Sub Canvas_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles canvas.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right And chkMeasureMode.Checked = False Then
            flagMove = 1
            xDragStart = e.X
            yDragStart = e.Y
            xOriginStart = xOrigin
            yOriginStart = yOrigin

            Me.Cursor = Cursors.SizeAll

        End If

        If e.Button = Windows.Forms.MouseButtons.Right And chkMeasureMode.Checked = True Then
            xMeasure0 = e.X
            yMeasure0 = e.Y
        End If



        If e.Button = Windows.Forms.MouseButtons.Left And timerTest.Enabled Then

            Dim xiAnchor As Double
            Dim yiAnchor As Double
            Dim cosQiAnchor As Double
            Dim sinQiAnchor As Double


            xCursor(0) = (e.X - xOrigin) / zoomScale
            xCursor(1) = (canvasContainer.Height - e.Y + yOrigin) / zoomScale


            flagEleDrag = 1
            xiAnchor = (e.X - xOrigin) / zoomScale
            yiAnchor = (canvasContainer.Height - e.Y + yOrigin) / zoomScale
            rAnchor = Math.Sqrt((xiAnchor - xEle(actEle)) ^ 2 + (yiAnchor - yEle(actEle)) ^ 2)
            cosQiAnchor = (xiAnchor - xEle(actEle)) / rAnchor
            sinQiAnchor = (yiAnchor - yEle(actEle)) / rAnchor
            cosQAnchor = cosQiAnchor * Math.Cos(qEle(actEle)) + sinQiAnchor * Math.Sin(qEle(actEle))
            sinQAnchor = sinQiAnchor * Math.Cos(qEle(actEle)) - cosQiAnchor * Math.Sin(qEle(actEle))


        End If

        If e.Button = Windows.Forms.MouseButtons.Left And flagEditEle = 1 Then
            iniXCursor(0) = (e.X - xOrigin) / zoomScale
            iniXCursor(1) = (canvasContainer.Height - e.Y + yOrigin) / zoomScale
            iniXEle(0) = xEle(actEle)
            iniXEle(1) = yEle(actEle)
            If nVertex(actEle) > 0 Then
                For i As Integer = 0 To nVertex(actEle)
                    iniXVertex(i, 0) = xVertex(i, actEle)
                    iniXVertex(i, 1) = yVertex(i, actEle)
                    iniXCE(0, i) = xCE(0, i, actEle)
                    iniXCE(1, i) = xCE(1, i, actEle)
                Next
            End If
        End If

        If e.Button = Windows.Forms.MouseButtons.Left And flagEditVertex = 1 Then
            iniXCursor(0) = (e.X - xOrigin) / zoomScale
            iniXCursor(1) = (canvasContainer.Height - e.Y + yOrigin) / zoomScale
            If nVertex(actEle) > 0 Then
                iniXActVertex(0) = xVertex(actVertex, actEle)
                iniXActVertex(1) = yVertex(actVertex, actEle)

            Else
                iniXActVertex(0) = xEle(actEle) + rEle(actEle)
                iniXActVertex(1) = yEle(actEle)

            End If

        End If

        If e.Button = Windows.Forms.MouseButtons.Left And flagNewVRBox = 1 Then
            ptBox1 = e.Location
        End If

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''' Start making a mask for assembly crop ''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If e.Button = Windows.Forms.MouseButtons.Left And flagMaskCropOn = 1 Then

            If rbMaskCircular.Checked = True Then

                nPtMaskCrop = 1
                xMaskCrop(0, 0) = (e.X - xOrigin) / zoomScale
                xMaskCrop(1, 0) = (canvasContainer.Height + yOrigin - e.Y) / zoomScale

            ElseIf rbMaskRect.Checked = True Then

                nPtMaskCrop = 1

                xMaskCrop(0, 0) = (e.X - xOrigin) / zoomScale
                xMaskCrop(1, 0) = (canvasContainer.Height + yOrigin - e.Y) / zoomScale
            ElseIf rbMaskPoly.Checked = True Then

            End If


        End If



    End Sub

    Private Sub Canvas_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles canvas.MouseMove



        If e.Button = Windows.Forms.MouseButtons.Right And chkMeasureMode.Checked = False Then
            If flagMove = 1 Then
                xOrigin = xOriginStart + e.X - xDragStart
                yOrigin = yOriginStart + e.Y - yDragStart
            End If
            canvas.Invalidate()

        End If


        If e.Button = Windows.Forms.MouseButtons.Right And chkMeasureMode.Checked = True Then

            xMeasure1 = e.X
            yMeasure1 = e.Y
            distMeasure = Math.Sqrt((xMeasure1 - xMeasure0) ^ 2 + (yMeasure1 - yMeasure0) ^ 2)
            If distMeasure > 0 Then
                angMeasure = Math.Acos((xMeasure1 - xMeasure0) / distMeasure) / Math.PI * 180
                If yMeasure1 > yMeasure0 Then

                    angMeasure = 360 - angMeasure
                End If
            End If
            distMeasure = distMeasure / zoomScale
            canvas.Invalidate()

        End If


        If flagEleDrag = 1 Then

            xCursor(0) = (e.X - xOrigin) / zoomScale
            xCursor(1) = (canvasContainer.Height - e.Y + yOrigin) / zoomScale

            'Canvas.Invalidate()


        End If

        If chkShowCoord.Checked = True Then

            xCursor(0) = e.X
            xCursor(1) = e.Y
            canvas.Invalidate()


        End If

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''' Move element in the edit mode '''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If e.Button = Windows.Forms.MouseButtons.Left And flagEditEle = 1 Then
            curXCursor(0) = (e.X - xOrigin) / zoomScale
            curXCursor(1) = (canvasContainer.Height - e.Y + yOrigin) / zoomScale

            If nVertex(actEle) = 0 Then
                xEle(actEle) = curXCursor(0) - iniXCursor(0) + iniXEle(0)
                yEle(actEle) = curXCursor(1) - iniXCursor(1) + iniXEle(1)
            ElseIf nVertex(actEle) > 0 Then
                xEle(actEle) = curXCursor(0) - iniXCursor(0) + iniXEle(0)
                yEle(actEle) = curXCursor(1) - iniXCursor(1) + iniXEle(1)
                For i As Integer = 0 To nVertex(actEle)
                    xVertex(i, actEle) = iniXVertex(i, 0) + curXCursor(0) - iniXCursor(0)
                    yVertex(i, actEle) = iniXVertex(i, 1) + curXCursor(1) - iniXCursor(1)
                    xCE(0, i, actEle) = iniXCE(0, i) + curXCursor(0) - iniXCursor(0)
                    xCE(1, i, actEle) = iniXCE(1, i) + curXCursor(1) - iniXCursor(1)

                Next
            End If
            canvas.Invalidate()
        End If


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''' Move vertex in the edit mode '''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If e.Button = Windows.Forms.MouseButtons.Left And flagEditVertex = 1 Then
            curXCursor(0) = (e.X - xOrigin) / zoomScale
            curXCursor(1) = (canvasContainer.Height - e.Y + yOrigin) / zoomScale
            If nVertex(actEle) > 0 Then
                xVertex(actVertex, actEle) = curXCursor(0) - iniXCursor(0) + iniXActVertex(0)
                yVertex(actVertex, actEle) = curXCursor(1) - iniXCursor(1) + iniXActVertex(1)
                If actVertex = 0 Then
                    xVertex(nVertex(actEle), actEle) = xVertex(0, actEle)
                    yVertex(nVertex(actEle), actEle) = yVertex(0, actEle)
                End If
            Else
                rEle(actEle) = Math.Sqrt((curXCursor(0) - iniXCursor(0) + iniXActVertex(0) - xEle(actEle)) ^ 2 + (curXCursor(1) - iniXCursor(1) + iniXActVertex(1) - yEle(actEle)) ^ 2)

            End If
            canvas.Invalidate()


        End If

        If e.Button = Windows.Forms.MouseButtons.Left And flagNewVRBox = 1 Then
            ptBox2 = e.Location
            canvas.Invalidate()

        End If



        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''' Creating the mask for cropping '''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If flagMaskCropOn = 1 Then

            If rbMaskCircular.Checked = True Then

                xMaskCrop(0, 1) = Math.Sqrt(((e.X - xOrigin) / zoomScale - xMaskCrop(0, 0)) ^ 2 + ((canvasContainer.Height + yOrigin - e.Y) / zoomScale - xMaskCrop(1, 0)) ^ 2)

            ElseIf rbMaskRect.Checked = True And nPtMaskCrop = 1 Then

                xMaskCrop(0, 2) = (e.X - xOrigin) / zoomScale
                xMaskCrop(1, 2) = (canvasContainer.Height + yOrigin - e.Y) / zoomScale
                ratioWHMask = Math.Abs((xMaskCrop(1, 2) - xMaskCrop(1, 0)) / (xMaskCrop(0, 2) - xMaskCrop(0, 0)))

            ElseIf rbMaskPoly.Checked = True And nPtMaskCrop < 9 Then
                xMaskCrop(0, nPtMaskCrop) = (e.X - xOrigin) / zoomScale
                xMaskCrop(1, nPtMaskCrop) = (canvasContainer.Height + yOrigin - e.Y) / zoomScale


            End If

            canvas.Invalidate()

        End If



    End Sub

    Private Sub Canvas_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles canvas.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            flagMove = 0
            Me.Cursor = Cursors.Arrow

        End If
        flagEleDrag = 0

        If flagNewVRBox = 1 Then
            VR.boxOffset(0) = Math.Min(ptBox1.X, ptBox2.X)
            VR.boxOffset(1) = Math.Min(ptBox1.Y, ptBox2.Y)
            VR.wVRBox = Math.Abs(ptBox1.X - ptBox2.X)
            VR.hVRBox = Math.Abs(ptBox1.Y - ptBox2.Y)
            flagNewVRBox = 0
            Me.Cursor = Cursors.Arrow
            VR.Show()



        End If


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''' Finish editing vertex location, and update shape '''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        '''''''''''''''''''''''''''''''''''''''''''

        If flagEditVertex = 1 And e.Button = Windows.Forms.MouseButtons.Left Then


            Call reInitiate()

            canvas.Invalidate()

        End If

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''  Finish creating the mask for cropping'''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If flagMaskCropOn = 1 And e.Button = Windows.Forms.MouseButtons.Left Then

            If rbMaskCircular.Checked = True And nPtMaskCrop = 1 Then

                btnCrop.Enabled = True
                btnEleQuery.Enabled = True
                btnMaskCrop.Enabled = True
                nPtMaskCrop = 0

                Call MaskCrop(nEle, nActEle, xEle, yEle, flagEMask, xMaskCrop, nPtMaskCrop, nEleMasked)
                canvas.Invalidate()


            ElseIf rbMaskRect.Checked = True And nPtMaskCrop = 1 Then

                nPtMaskCrop = 4

                xMaskCrop(0, 1) = xMaskCrop(0, 0)
                xMaskCrop(1, 1) = xMaskCrop(1, 2)
                xMaskCrop(0, 3) = xMaskCrop(0, 2)
                xMaskCrop(1, 3) = xMaskCrop(1, 0)
                btnCrop.Enabled = True
                btnEleQuery.Enabled = True
                btnMaskCrop.Enabled = True

                Call MaskCrop(nEle, nActEle, xEle, yEle, flagEMask, xMaskCrop, nPtMaskCrop, nEleMasked)
                canvas.Invalidate()

            End If


        End If


    End Sub

    Private Sub Canvas_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles canvas.MouseClick


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''' Select the active element that is picked by the mouse middle button.'''''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If e.Button = Windows.Forms.MouseButtons.Middle Then
            distActEle = 1000000000000.0
            For i As Integer = 0 To nActEle - 1
                If distActEle > ((e.X - xOrigin) / zoomScale - xEle(i)) ^ 2 + ((canvasContainer.Height - e.Y + yOrigin) / zoomScale - yEle(i)) ^ 2 Then
                    distActEle = ((e.X - xOrigin) / zoomScale - xEle(i)) ^ 2 + ((canvasContainer.Height - e.Y + yOrigin) / zoomScale - yEle(i)) ^ 2
                    actEle = i
                End If
            Next

            If chkMonitorSystemVariable.Checked = True Then
                MonitorSystemVariable.Invalidate()
            End If

            If flagNewMask = 1 Then
                If nNodeMask = 0 Then
                    For j As Integer = 0 To 9
                        Mask(j) = actEle + 1    'Initiate all nodes of the mask to the same point.  Otherwise the plot of the mask would be messy.
                    Next

                End If

                flagMaskOn = 1
                nNodeMask += 1
                Mask(nNodeMask - 1) = actEle + 1

                If nNodeMask = 9 Then
                    flagNewMask = 0
                    flagMaskOn = 1
                    Histgram.btnNewMask.Enabled = True
                    Call Histogram(nEle, nActEle, xEle, yEle, mInertEle, qEle, iniOri, Ori, elong, _
                     nVertex, nCon, xCon, yCon, FxCon, FyCon, FCon, flagConBoun, FAngle, fricRatio, tanNorm, qNorm, _
                    nNodeMask, Mask, BinForce, BinOri, BinFR, BinNorm, BinSlideNorm, BinFN, BinFT, BinRoseFR, _
                    iHistMode, iWeight, jWeight, iBoundMode, flagFMask, flagEMask, _
                    nBinForce, nBinOri, nBinFR, nBinNorm, ptBinF, ptBinE, ptBinFR, ptBinNorm, ptBinSlideNorm, ptBinFN, ptBinFT, ptBinRoseFR, _
                    tsFabric, tsStress, tsConNorm, numContact, pairCon, flagOutput, vol, iCurStep, ptcStress, nEleMask, factorSlideNorm, scalePolar)

                    canvas.Invalidate()
                End If



            End If

            If flagAddDiscMask = 1 Then
                eleDiscMask(nEleDiscMask) = actEle
                nEleDiscMask += 1

            End If


            canvas.Invalidate()
        End If


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''' Adding new vertices for a new element'''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


        If flagAdd = 1 And e.Button = Windows.Forms.MouseButtons.Left Then

            xVNew(nVNew, 0) = (e.X - xOrigin) / zoomScale
            xVNew(nVNew, 1) = (canvasContainer.Height + yOrigin - e.Y) / zoomScale
            nVNew += 1
            canvas.Invalidate()

        End If


        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''  Select a vertex using the mouse for vertex editing.
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


        If flagEditVertex = 1 And e.Button = Windows.Forms.MouseButtons.Right And nVertex(actEle) > 0 Then

            distVertex = 1000000000000.0
            For i As Integer = 0 To nVertex(actEle) - 1
                If distVertex > ((e.X - xOrigin) / zoomScale - xVertex(i, actEle)) ^ 2 + ((canvasContainer.Height - e.Y + yOrigin) / zoomScale - yVertex(i, actEle)) ^ 2 Then
                    distVertex = ((e.X - xOrigin) / zoomScale - xVertex(i, actEle)) ^ 2 + ((canvasContainer.Height - e.Y + yOrigin) / zoomScale - yVertex(i, actEle)) ^ 2
                    actVertex = i
                End If
            Next
            setCAC.Value = CAC(actVertex, actEle)
            canvas.Invalidate()

        End If



        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''  Create vertex points for the polygonal mask for cropping  ''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If e.Button = Windows.Forms.MouseButtons.Left And flagMaskCropOn = 1 And rbMaskPoly.Checked = True Then

            If nPtMaskCrop <= 8 Then

                nPtMaskCrop += 1
                flagCreatingMaskOn = 1

                xMaskCrop(0, nPtMaskCrop - 1) = (e.X - xOrigin) / zoomScale
                xMaskCrop(1, nPtMaskCrop - 1) = (canvasContainer.Height + yOrigin - e.Y) / zoomScale

                If nPtMaskCrop = 9 Then
                    flagCreatingMaskOn = 0
                    btnCrop.Enabled = True
                    btnEleQuery.Enabled = True
                    btnMaskCrop.Enabled = True
                    Call MaskCrop(nEle, nActEle, xEle, yEle, flagEMask, xMaskCrop, nPtMaskCrop, nEleMasked)
                    canvas.Invalidate()


                End If

            End If

        End If


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''  Pick strain cells for output  ''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If e.Button = Windows.Forms.MouseButtons.Left And chkAddActCell.Checked Then
            nActCell += 1
            distActCell = 9.0E+99
            xCursor(0) = (e.X - xOrigin) / zoomScale
            xCursor(1) = (canvasContainer.Height + yOrigin - e.Y) / zoomScale

            For iCell = 0 To numCell - 1

                If flagEffCell(iCell) = 1 Then
                    If distActCell > (xCursor(0) - xCell(0, iCell)) ^ 2 + (xCursor(1) - xCell(1, iCell)) ^ 2 Then
                        distActCell = (xCursor(0) - xCell(0, iCell)) ^ 2 + (xCursor(1) - xCell(1, iCell)) ^ 2
                        cellAct(nActCell - 1) = iCell
                    End If

                End If

            Next

            canvas.Invalidate()


        End If



        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''' Debug only, pick center of a strain cell ''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'If e.Button = Windows.Forms.MouseButtons.Middle Then
        ' xPt(0) = (e.X - xOrigin) / zoomScale
        ' xPt(1) = (canvasContainer.Height + yOrigin - e.Y) / zoomScale
        ' rStainCell = setRdStnCell.Value
        ' Call StrainCell(xPt(0), rStainCell, nEle, xEle(0), yEle(0), areaEle(0), _
        '      limitAll(0), xGrid, nGridX, nGridY, nEleGrid(0, 0), lEG(0, 0, 0), maxNEleGrid, eleStnCell(0), _
        '     eleBuffer(0), nEleTop, wgtBuffer(0), flagEffCell)
        ' If flagEffCell = 1 Then
        ' btnIniStnCell.BackColor = Color.DimGray
        ' End If
        ' End If


    End Sub
    Private Sub Canvas_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles canvas.MouseDoubleClick

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''' Finish adding a new element '''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If flagAdd = 1 Then
            nVNew -= 1
            xVNew(nVNew, 0) = (e.X - xOrigin) / zoomScale
            xVNew(nVNew, 1) = (canvasContainer.Height + yOrigin - e.Y) / zoomScale
            nActEle += 1
            If nActEle > nEle - 2 Then
                MessageBox.Show("You can only add up to 100 new element in this mode due to limitations of memory use.  Save the date and reopen it; you will be able to add more.  Sorry for the inconvenience.")
            End If

            MonitorSystemVariable.setActEle.Maximum = nActEle + 1

            If nVNew = 1 Then
                xEle(nActEle - 1) = xVNew(0, 0)
                yEle(nActEle - 1) = xVNew(0, 1)
                rEle(nActEle - 1) = Math.Sqrt((xVNew(1, 0) - xVNew(0, 0)) ^ 2 + (xVNew(1, 1) - xVNew(0, 1)) ^ 2)
                CAC(0, nActEle - 1) = setCAC.Value
                CAC(1, nActEle - 1) = setCAC.Value
                nVertex(nActEle - 1) = 0
            ElseIf nVNew > 1 Then
                For i As Integer = 0 To nVNew
                    xVertex(i, nActEle - 1) = xVNew(i, 0)
                    yVertex(i, nActEle - 1) = xVNew(i, 1)
                    CAC(i, nActEle - 1) = setCAC.Value

                Next
                xVertex(nVNew + 1, nActEle - 1) = xVertex(0, nActEle - 1)
                yVertex(nVNew + 1, nActEle - 1) = yVertex(0, nActEle - 1)
                xEle(nActEle - 1) = xVertex(0, nActEle - 1)
                yEle(nActEle - 1) = yVertex(1, nActEle - 1) 'Temperorily calculate xele and yele for element editing.  Real value will be calculated when invoving initiate().
                nVertex(nActEle - 1) = nVNew + 1

            End If
            nVNew = 0
            flagAdd = 0
            rbEleAdd.Checked = False
            rbView.Checked = True



            Call reInitiate()

            If nActEle > nEle - 2 Then

            End If

            canvas.Invalidate()


        End If



        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''' Finish creating a new mask ''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If flagNewMask = 1 And e.Button = Windows.Forms.MouseButtons.Left Then
            flagNewMask = 0
            flagMaskOn = 1
            Histgram.btnNewMask.Enabled = True
            Call Histogram(nEle, nActEle, xEle, yEle, mInertEle, qEle, iniOri, Ori, elong, _
             nVertex, nCon, xCon, yCon, FxCon, FyCon, FCon, flagConBoun, FAngle, fricRatio, tanNorm, qNorm, _
            nNodeMask, Mask, BinForce, BinOri, BinFR, BinNorm, BinSlideNorm, BinFN, BinFT, BinRoseFR, _
            iHistMode, iWeight, jWeight, iBoundMode, flagFMask, flagEMask, _
            nBinForce, nBinOri, nBinFR, nBinNorm, ptBinF, ptBinE, ptBinFR, ptBinNorm, ptBinSlideNorm, ptBinFN, ptBinFT, ptBinRoseFR, _
            tsFabric, tsStress, tsConNorm, numContact, pairCon, flagOutput, vol, iCurStep, ptcStress, nEleMask, factorSlideNorm, scalePolar)

            canvas.Invalidate()

        End If


        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''  Copy an element '''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If flagCopy = 1 And e.Button = Windows.Forms.MouseButtons.Left Then

            nActEle += 1
            MonitorSystemVariable.setActEle.Maximum = nActEle + 1
            If nActEle > nEle - 2 Then
                MessageBox.Show("You can only add up to 100 new element in this mode due to limitations of memory use.  Save the date and reopen it; you will be able to add more.  Sorry for the inconvenience.")
            End If


            xOffsetCopy(0) = (e.X - xOrigin) / zoomScale - xEle(actEle)
            xOffsetCopy(1) = (canvasContainer.Height - e.Y + yOrigin) / zoomScale - yEle(actEle)

            If nVertex(actEle) = 0 Then
                xEle(nActEle - 1) = xEle(actEle) + xOffsetCopy(0)
                yEle(nActEle - 1) = yEle(actEle) + xOffsetCopy(1)
                rEle(nActEle - 1) = rEle(actEle)
                CAC(0, nActEle - 1) = setCAC.Value
                CAC(1, nActEle - 1) = setCAC.Value
                nVertex(nActEle - 1) = 0
            Else
                For i As Integer = 0 To nVertex(actEle) - 1
                    xVertex(i, nActEle - 1) = xVertex(i, actEle) + xOffsetCopy(0)
                    yVertex(i, nActEle - 1) = yVertex(i, actEle) + xOffsetCopy(1)
                    CAC(i, nActEle - 1) = CAC(i, actEle)
                Next
                xVertex(nVertex(actEle), nActEle - 1) = xVertex(0, nActEle - 1)
                yVertex(nVertex(actEle), nActEle - 1) = yVertex(0, nActEle - 1)
                xEle(nActEle - 1) = xEle(actEle) + xOffsetCopy(0)
                yEle(nActEle - 1) = yEle(actEle) + xOffsetCopy(1)
                nVertex(nActEle - 1) = nVertex(actEle)

            End If



            Call reInitiate()

            canvas.Invalidate()




        End If

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''' Finish the polygonal mask for cropping '''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If e.Button = Windows.Forms.MouseButtons.Left And flagMaskCropOn = 1 And rbMaskPoly.Checked = True Then


            xMaskCrop(0, nPtMaskCrop - 1) = (e.X - xOrigin) / zoomScale
            xMaskCrop(1, nPtMaskCrop - 1) = (canvasContainer.Height + yOrigin - e.Y) / zoomScale

            Call MaskCrop(nEle, nActEle, xEle, yEle, flagEMask, xMaskCrop, nPtMaskCrop, nEleMasked)
            canvas.Invalidate()

            flagCreatingMaskOn = 0

            btnCrop.Enabled = True
            btnEleQuery.Enabled = True
            btnMaskCrop.Enabled = True



        End If


    End Sub

    Private Sub tInc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tInc.ValueChanged, ctrlMaxNEle.ValueChanged
        dt = 2 ^ (-tInc.Value)

#If USEKEY = 1 Then
        WriteNoxMemo()
#End If

        If nActEle > 0 Then
            Call Mass(nEle, nActEle, areaEle, mGravEle, mInertEle, MIEle, MIInertEle, dt, density, stiff, flagMassNorm)
        End If

    End Sub

    Private Sub nIncr_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nIncr.ValueChanged
        nInc = 2 ^ nIncr.Value
    End Sub

    Private Sub refRate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refRate.ValueChanged
        timerTest.Interval = 1000.0 / refRate.Value
    End Sub

    Private Sub setE_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setE.ValueChanged
        stiff = 2 ^ setE.Value
#If USEKEY = 1 Then
        WriteNoxMemo()
#End If
    End Sub

    Private Sub setTanTheta1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setTanTheta1.ValueChanged
        tanTheta(0) = Math.Tan(setTanTheta1.Value / 180 * 3.14159)
    End Sub
    Private Sub setTanTheta2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setTanTheta2.ValueChanged
        tanTheta(1) = Math.Tan(setTanTheta2.Value / 180 * 3.14159)
    End Sub

    Private Sub controlGlobDamp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setGlobDamp.ValueChanged
        globdamp = 2 ^ setGlobDamp.Value
    End Sub

    Private Sub setRotDamp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setRotDamp.ValueChanged
        rotDamp = 2 ^ setRotDamp.Value
    End Sub

    Private Sub checkFlagDebug_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkFlagDebug.CheckedChanged
        If checkFlagDebug.Checked = True Then
            flagDebug = 1
        Else
            flagDebug = 0
        End If
    End Sub

    Private Sub btnZoomIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZoomIn.Click
        zoomFactor = setZoomFactor.Value
        zoomScale *= zoomFactor
        xOrigin = canvasContainer.Width / 2 - (canvasContainer.Width / 2 - xOrigin) * zoomFactor
        yOrigin = (yOrigin + canvasContainer.Height / 2) * zoomFactor - canvasContainer.Height / 2
        showPpM.Text = (0.001 * zoomScale).ToString("F00")

        canvas.Invalidate()


    End Sub

    Private Sub btnZoomOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZoomOut.Click
        'timerZoomIn.Enabled = True
        'iZoom = 0
        zoomFactor = 1 / setZoomFactor.Value
        zoomScale *= zoomFactor
        xOrigin = canvasContainer.Width / 2 - (canvasContainer.Width / 2 - xOrigin) * zoomFactor
        yOrigin = (yOrigin + canvasContainer.Height / 2) * zoomFactor - canvasContainer.Height / 2

        showPpM.Text = (0.001 * zoomScale).ToString("F00")
        canvas.Invalidate()

    End Sub

    Private Sub flagForce_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If flagForceByLeng.Checked = True Then
            flagF = 1
        Else
            flagF = 0
        End If
    End Sub


    Private Sub setpInt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setpInt.ValueChanged
        pInt = setpInt.Value
    End Sub



    Private Sub controlMaxRFriend_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setMaxRFriend.ValueChanged
        maxGap = setMaxRFriend.Value
    End Sub


    Private Sub chsWall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chsWall.Click
        actWall += 1
        If actWall = nWall Then
            actWall = 0
        End If
    End Sub

    Private Sub btnCW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCW.Click
        lWall = Math.Sqrt((x2Wall(actWall) - x1Wall(actWall)) ^ 2 + (y2Wall(actWall) - y1Wall(actWall)) ^ 2)
        x0Wall = 0.5 * (x2Wall(actWall) + x1Wall(actWall))
        y0Wall = 0.5 * (y2Wall(actWall) + y1Wall(actWall))

        cosO = (x2Wall(actWall) - x1Wall(actWall)) / lWall
        sinO = (y2Wall(actWall) - y1Wall(actWall)) / lWall
        cosD = Math.Cos(-setAngle.Value / 180.0 * 3.14159)
        sinD = Math.Sin(-setAngle.Value / 180.0 * 3.14159)
        cosN = cosO * cosD - sinO * sinD
        sinN = sinO * cosD + cosO * sinD
        dMotionWall(0) = x0Wall - 0.5 * lWall * cosN - x1Wall(actWall)
        dMotionWall(1) = y0Wall - 0.5 * lWall * sinN - y1Wall(actWall)
        dMotionWall(2) = x0Wall + 0.5 * lWall * cosN - x2Wall(actWall)
        dMotionWall(3) = y0Wall + 0.5 * lWall * sinN - y2Wall(actWall)

        If flagEditEle = 1 Or flagEditVertex = 1 Then
            y1Wall(actWall) += dMotionWall(1)
            y2Wall(actWall) += dMotionWall(3)
            x1Wall(actWall) += dMotionWall(0)
            x2Wall(actWall) += dMotionWall(2)

            ReDim dMotionWall(3)
            canvas.Invalidate()
        End If

    End Sub

    Private Sub btnCCW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCCW.Click
        lWall = Math.Sqrt((x2Wall(actWall) - x1Wall(actWall)) ^ 2 + (y2Wall(actWall) - y1Wall(actWall)) ^ 2)
        x0Wall = 0.5 * (x2Wall(actWall) + x1Wall(actWall))
        y0Wall = 0.5 * (y2Wall(actWall) + y1Wall(actWall))

        cosO = (x2Wall(actWall) - x1Wall(actWall)) / lWall
        sinO = (y2Wall(actWall) - y1Wall(actWall)) / lWall
        cosD = Math.Cos(setAngle.Value / 180.0 * 3.14159)
        sinD = Math.Sin(setAngle.Value / 180.0 * 3.14159)
        cosN = cosO * cosD - sinO * sinD
        sinN = sinO * cosD + cosO * sinD
        dMotionWall(0) = x0Wall - 0.5 * lWall * cosN - x1Wall(actWall)
        dMotionWall(1) = y0Wall - 0.5 * lWall * sinN - y1Wall(actWall)
        dMotionWall(2) = x0Wall + 0.5 * lWall * cosN - x2Wall(actWall)
        dMotionWall(3) = y0Wall + 0.5 * lWall * sinN - y2Wall(actWall)

        If flagEditEle = 1 Or flagEditVertex = 1 Then
            y1Wall(actWall) += dMotionWall(1)
            y2Wall(actWall) += dMotionWall(3)
            x1Wall(actWall) += dMotionWall(0)
            x2Wall(actWall) += dMotionWall(2)

            ReDim dMotionWall(3)
            canvas.Invalidate()
        End If



    End Sub

    Private Sub MovDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovDown.Click
        dMotionWall(1) = -incWall.Value / zoomScale
        dMotionWall(3) = -incWall.Value / zoomScale

        If flagEditEle = 1 Or flagEditVertex = 1 Then
            y1Wall(actWall) += dMotionWall(1)
            y2Wall(actWall) += dMotionWall(3)
            ReDim dMotionWall(3)
            canvas.Invalidate()
        End If
    End Sub

    Private Sub MovUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovUp.Click
        dMotionWall(1) = incWall.Value / zoomScale
        dMotionWall(3) = incWall.Value / zoomScale
        If flagEditEle = 1 Or flagEditVertex = 1 Then
            y1Wall(actWall) += dMotionWall(1)
            y2Wall(actWall) += dMotionWall(3)
            ReDim dMotionWall(3)
            canvas.Invalidate()
        End If


    End Sub

    Private Sub MovLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovLeft.Click
        dMotionWall(0) = -incWall.Value / zoomScale
        dMotionWall(2) = -incWall.Value / zoomScale
        If flagEditEle = 1 Or flagEditVertex = 1 Then
            x1Wall(actWall) += dMotionWall(0)
            x2Wall(actWall) += dMotionWall(2)
            ReDim dMotionWall(3)
            canvas.Invalidate()
        End If


    End Sub

    Private Sub MovRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovRight.Click
        dMotionWall(0) = incWall.Value / zoomScale
        dMotionWall(2) = incWall.Value / zoomScale
        If flagEditEle = 1 Or flagEditVertex = 1 Then
            x1Wall(actWall) += dMotionWall(0)
            x2Wall(actWall) += dMotionWall(2)
            ReDim dMotionWall(3)
            canvas.Invalidate()
        End If

    End Sub




    Private Sub btGlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGlue.Click
        flagGlue = 1
    End Sub

    Private Sub btnPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPause.Click
        If timerTest.Enabled = True Then
            timerTest.Enabled = False
            btnPause.Text = "Resume"
        Else

#If USEKEY = 1 Then
            IniKey()
            WriteNoxMemo()
#End If


            timerTest.Enabled = True
            btnPause.Text = "Pause"
        End If

    End Sub


    Private Sub btnDoubleScale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForLengScaleUp.Click
        FLenScale = FLenScale * 1.11
        canvas.Invalidate()


    End Sub

    Private Sub btnHalFLenScale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForLengScaleDown.Click
        FLenScale = FLenScale * 0.8
        canvas.Invalidate()

    End Sub

    Private Sub btVelPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVelPlus.Click
        scaleVel *= 2
        canvas.Invalidate()
    End Sub

    Private Sub btVelMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVelMinus.Click
        scaleVel *= 0.5
        canvas.Invalidate()

    End Sub

    Private Sub btnDoublePScale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoublePScale.Click
        pScale *= 2
        canvas.Invalidate()
    End Sub

    Private Sub btnHalfPScale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHalfPScale.Click
        pScale *= 0.5
        canvas.Invalidate()
    End Sub

    Private Sub ctrlNumProcessor_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctrlNumProcessor.ValueChanged
        numThreads = ctrlNumProcessor.Value

    End Sub

    Private Sub PolyBall_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        canvasContainer.Width = Me.Width - 325
        canvasContainer.Height = Me.Height - 85
        canvas.Width = Me.Width - 325
        canvas.Height = Me.Height - 85
        tabMain.Height = Me.Height - 85
        trackPost.Width = Me.Width - 545
        flagReDrawTab = 0
        textEleQuery.Height = Me.Height - 570
        canvas.Invalidate()

    End Sub

    Private Sub setDampingRatio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setDampingRatio.ValueChanged
        dampingRatio = setDampingRatio.Value
#If USEKEY = 1 Then
        WriteNoxMemo()
#End If

    End Sub



    Private Sub chkMassNorm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMassNorm.CheckedChanged
        If chkMassNorm.Checked = True Then
            flagMassNorm = 1
        Else
            flagMassNorm = 0
        End If
        Call Mass(nEle, nActEle, areaEle, mGravEle, mInertEle, MIEle, MIInertEle, dt, density, stiff, flagMassNorm)
    End Sub




    Private Sub setPx_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setPx.ValueChanged
        If intLoadPara(5, 0) > 1 Then
            realLoadPara(4, 0) = setPx.Value
        End If
        If intLoadPara(7, 0) > 1 Then
            realLoadPara(6, 0) = setPx.Value
        End If

#If STRESSROTATE = 1 Then
        PStress(0) = setPx.Value
#End If
    End Sub

    Private Sub setPy_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setPy.ValueChanged
        If intLoadPara(1, 0) > 1 Then
            realLoadPara(0, 0) = setPy.Value
        End If
        If intLoadPara(3, 0) > 1 Then
            realLoadPara(2, 0) = setPy.Value
        End If
#If STRESSROTATE = 1 Then
        PStress(1) = setPy.Value
#End If
    End Sub

    Private Sub setpxy_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setpxy.ValueChanged
        If intLoadPara(2, 0) > 1 Then
            realLoadPara(1, 0) = setpxy.Value
        End If
        If intLoadPara(4, 0) > 1 Then
            realLoadPara(3, 0) = setpxy.Value
        End If
        If intLoadPara(6, 0) > 1 Then
            realLoadPara(5, 0) = setpxy.Value
        End If
        If intLoadPara(8, 0) > 1 Then
            realLoadPara(7, 0) = setpxy.Value
        End If

    End Sub


    Private Sub setGX_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setGX.ValueChanged
        gXgY(0) = setGX.Value

    End Sub

    Private Sub setGY_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setGY.ValueChanged
        gXgY(1) = setGY.Value

    End Sub

    Private Sub setXGravity_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setXGravity.ValueChanged
        xGravity(0) = setXGravity.Value

    End Sub

    Private Sub setYGravity_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setYGravity.ValueChanged
        xGravity(1) = setYGravity.Value

    End Sub




    Private Sub tabEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabEdit.Click

    End Sub






    Private Sub btnAutoWall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutoWall.Click

        x1Wall(0) = limitAll(0) - canvasContainer.Width / zoomScale / 2
        y1Wall(0) = limitAll(2)
        x2Wall(0) = limitAll(1) + canvasContainer.Width / zoomScale / 2
        y2Wall(0) = limitAll(2)

        x1Wall(1) = limitAll(1) + canvasContainer.Width / zoomScale / 2
        y1Wall(1) = limitAll(3)
        x2Wall(1) = limitAll(0) - canvasContainer.Width / zoomScale / 2
        y2Wall(1) = limitAll(3)

        x1Wall(2) = limitAll(0)
        y1Wall(2) = limitAll(3) + canvasContainer.Width / zoomScale / 2
        x2Wall(2) = limitAll(0)
        y2Wall(2) = limitAll(2) - canvasContainer.Width / zoomScale / 2

        x1Wall(3) = limitAll(1)
        y1Wall(3) = limitAll(2) - canvasContainer.Width / zoomScale / 2
        x2Wall(3) = limitAll(1)
        y2Wall(3) = limitAll(3) + canvasContainer.Width / zoomScale / 2
        canvas.Invalidate()

    End Sub

    Private Sub timerZoomIn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerZoomIn.Tick
        If iZoom < 8 Then
            zoomScale *= zoomFactor
            xOrigin = canvasContainer.Width / 2 - (canvasContainer.Width / 2 - xOrigin) * zoomFactor
            yOrigin = (yOrigin + canvasContainer.Height / 2) * zoomFactor - canvasContainer.Height / 2
            canvas.Invalidate()
            iZoom += 1
        Else
            timerZoomIn.Enabled = False


        End If



    End Sub

    Private Sub btnFSceleThickDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFSceleThickUp.Click
        FThickScale *= 1.25
        canvas.Invalidate()
    End Sub

    Private Sub btnFScaleThickDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFScaleThickDown.Click
        FThickScale *= 0.8
        canvas.Invalidate()
    End Sub

    Private Sub btnAutoFScaleThick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutoFScaleThick.Click
        maxForce = 0
        For iCon As Integer = 0 To nCon - 1
            If FxCon(iCon) > maxForce Then
                maxForce = FxCon(iCon)
            End If
            If FyCon(iCon) > maxForce Then
                maxForce = FyCon(iCon)
            End If
        Next

        FThickScale = 10 / maxForce ^ factorContrast
        canvas.Invalidate()
    End Sub

    Private Sub btnAutoFScaleLeng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutoFScaleLeng.Click
        maxForce = 0
        For iCon As Integer = 0 To nCon - 1
            If FxCon(iCon) > maxForce Then
                maxForce = FxCon(iCon)
            End If
            If FyCon(iCon) > maxForce Then
                maxForce = FyCon(iCon)
            End If
        Next

        FLenScale = 30 / maxForce / zoomScale
        canvas.Invalidate()
    End Sub

    Private Sub cstForceThickLeng_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cstForceThickLeng.ValueChanged
        factorLenThick = cstForceThickLeng.Value
        canvas.Invalidate()

    End Sub

    Private Sub cstForceThickContrast_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cstForceThickContrast.ValueChanged
        factorContrast = cstForceThickContrast.Value
    End Sub

    Private Sub showArc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        canvas.Invalidate()
    End Sub

    Private Sub chkSave_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSave.CheckedChanged
        If chkSave.Checked = True And flagWriteOpen = 1 Then
            timerTest.Enabled = False
            btnPause.Text = "Resume"

            dlgSaveResults.ShowDialog()
            FileName = dlgSaveResults.FileName
            lName = FileName.Length

            If lName > 1 Then
                Call WriteResult(nEle, nActEle, xEle, yEle, qEle, _
                vxEle, vyEle, vqEle, nWall, x1Wall, x2Wall, y1Wall, y2Wall, nCon, xCon, yCon, _
               rCon, FxCon, FyCon, fricRatio, tanNorm, flagConBoun, pairCon, _
               nPtHL, xPtHL, strgTensl, strgRatio, Params, alwNEleFrd, flagWriteOpen, iCurStep, FileName, lName)

                flagWriteOpen = 0
                setFreqSaveRST.Enabled = True

            Else
                chkSave.Checked = False
            End If

        End If

        If chkSave.Checked = False Then
            setFreqSaveRST.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenResult.Click
        timerTest.Enabled = False
        btnPause.Text = "Post"
        'btnPause.Enabled = False

        dlgOpenResults.ShowDialog()
        FileName = dlgOpenResults.FileName
        lName = FileName.Length

        If lName > 1 Then
            Call ReadResult(nEle, nActEle, xEle, yEle, qEle, vxEle, vyEle, vqEle, qVertex, rVertex, _
            xVertex, yVertex, rqCE, xCE, nVertex, _
            nWall, x1Wall, x2Wall, y1Wall, y2Wall, nCon, xCon, yCon, rCon, _
             FxCon, FyCon, fricRatio, tanNorm, flagConBoun, pairCon, _
             FRGB, nPtHL, xPtHL, strgTensl, strgRatio, Params, _
             alwNEleFrd, nStep, iStep, preStep, flagReadOpen, verRead, iCurStep, FileName, lName)

            trackPost.Maximum = nStep - 1
            trackPost.Enabled = True
            btnPlay.Visible = True
            btnStop.Visible = True
            trackPost.Visible = True
            showCurrentStepPost.Visible = True
            trackStateB.Maximum = nStep - 1


            iStep = 1
            preStep = 0

            Call ReadResult(nEle, nActEle, xEle, yEle, qEle, vxEle, vyEle, vqEle, qVertex, rVertex, _
            xVertex, yVertex, rqCE, xCE, nVertex, _
            nWall, x1Wall, x2Wall, y1Wall, y2Wall, nCon, xCon, yCon, rCon, _
             FxCon, FyCon, fricRatio, tanNorm, flagConBoun, pairCon, _
             FRGB, nPtHL, xPtHL, strgTensl, strgRatio, Params, _
             alwNEleFrd, nStep, iStep, preStep, flagReadOpen, verRead, iCurStep, FileName, lName)

            modeGD.Enabled = True
            modeMotion.Enabled = True
        End If

    End Sub

    Private Sub trackPost_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trackPost.ValueChanged  'trackPost.Scroll, 

        If chkLockIStepJStep.Checked = True Then
            trackStateB.Value = Math.Max(Math.Min(trackPost.Value + jStep - iStep, trackStateB.Maximum), trackStateB.Minimum)

        End If

        iStep = trackPost.Value + 1

#If USEKEY = 1 Then
        IniKey()
#End If


        Call ReadResult(nEle, nActEle, xEle, yEle, qEle, vxEle, vyEle, vqEle, qVertex, rVertex, _
        xVertex, yVertex, rqCE, xCE, nVertex, _
        nWall, x1Wall, x2Wall, y1Wall, y2Wall, nCon, xCon, yCon, rCon, _
         FxCon, FyCon, fricRatio, tanNorm, flagConBoun, pairCon, _
         FRGB, nPtHL, xPtHL, strgTensl, strgRatio, Params, _
         alwNEleFrd, nStep, iStep, preStep, flagReadOpen, verRead, iCurStep, FileName, lName)


        showJStep.Text = (jStep - iStep).ToString


        showCurrentStepPost.Text = "Step " & iCurStep(0).ToString("D")

        dt = Params(0)
        tInc.Value = -Math.Log(dt) / Math.Log(2)

        stiff = Params(1)
        setE.Value = Math.Log(stiff) / Math.Log(2)

        globdamp = Params(2)
        setGlobDamp.Value = Math.Log(globdamp) / Math.Log(2)

        rollingDamp = Params(3)
        setRollingDamp.Value = rollingDamp

        dampingRatio = Params(4)
        setDampingRatio.Value = dampingRatio

        maxGap = Params(5)
        setMaxRFriend.Value = maxGap

        tanTheta(0) = Params(6)
        setTanTheta1.Value = Math.Atan(tanTheta(0)) / 3.1415926 * 180
        tanTheta(1) = Params(16)
        setTanTheta2.Value = Math.Atan(tanTheta(1)) / 3.1415926 * 180

        'pX = Params(7)
        setPx.Value = Params(7)

        ' pY = Params(8)
        setPy.Value = Params(8)

        pInt = Params(9)
        setpInt.Value = pInt

        gXgY(0) = Params(10)
        setGX.Value = gXgY(0)

        gXgY(1) = Params(11)
        setGY.Value = gXgY(1)

        xGravity(0) = Params(12)
        setXGravity.Value = xGravity(0)

        xGravity(1) = Params(13)
        setYGravity.Value = xGravity(1)

        'pXY = Params(14)
        setpxy.Value = Params(14)

        vol = Params(15)

        ' CAC = Params(14)

        lbICurStep1.Text = "Step:        " & iCurStep(0)

        Call DomainLimit(nEle, nActEle, xEle, yEle, rEle, nVertex, xVertex, yVertex, boundELe, limitAll, hSector)

        limitAll(0) -= maxGap
        limitAll(1) += maxGap
        limitAll(2) -= maxGap
        limitAll(3) += maxGap


        nGridY = (limitAll(3) - limitAll(2)) / xGrid + 1
        nGridX = (limitAll(1) - limitAll(0)) / xGrid + 1
        maxNEleGrid = Math.Max((xGrid ^ 2 / (volSld / nActEle) * 3), 10)   'Potentially problematic
        ReDim nEleGrid(nGridY - 1, nGridX - 1)
        ReDim lEG(maxNEleGrid - 1, nGridY - 1, nGridX - 1)

        Call Grid(nEle, nActEle, nVertex, xEle, yEle, rEle, xVertex, yVertex, nGridX, nGridY, nEleGrid, lEG, xGrid, boundELe, limitAll, maxNEleGrid)


        Call ParticleStress(nEle, nActEle, xEle, yEle, areaEle, nCon, xCon, yCon, FxCon, FyCon, flagConBoun, pairCon, ptcStress)
        Call CoordNum(nEle, nActEle, nCon, flagConBoun, pairCon, numECon)

        If modeGD.Checked = True Then
            Call UdGD(nEle, xEle, yEle, qEle, nHLine, nVLine, _
            nHPtGD, nVPtGD, iHElePtGD, iVElePtGD, rqiHPtGD, rqiVPtGD, _
            xHPtGD, xVPtGD)
        End If

        If chkDefContour.Checked = True And modeMotion.Checked = True Then
            Call ColorDeform(nEle, nActEle, xEleTrace, yEleTrace, qEleTrace, rangeContour, relaMin, relamax, nStep, iStep, jStep, iMode, jMode, kMode, mMode, TraceRGB, ptcStress, areaEle, iniOri, Ori, refOri, numECon)
            setRelaMax.Value = relamax
            setRelaMin.Value = relaMin
            lowContourRange.Value = rangeContour(0)
            upContourRange.Value = rangeContour(1)
        End If

        If modeHist.Checked = True Or chkExportCon.Checked Then
            Call Histogram(nEle, nActEle, xEle, yEle, mInertEle, qEle, iniOri, Ori, elong, _
             nVertex, nCon, xCon, yCon, FxCon, FyCon, FCon, flagConBoun, FAngle, fricRatio, tanNorm, qNorm, _
            nNodeMask, Mask, BinForce, BinOri, BinFR, BinNorm, BinSlideNorm, BinFN, BinFT, BinRoseFR, _
            iHistMode, iWeight, jWeight, iBoundMode, flagFMask, flagEMask, _
            nBinForce, nBinOri, nBinFR, nBinNorm, ptBinF, ptBinE, ptBinFR, ptBinNorm, ptBinSlideNorm, ptBinFN, ptBinFT, ptBinRoseFR, _
            tsFabric, tsStress, tsConNorm, numContact, pairCon, flagOutput, vol, iCurStep, ptcStress, nEleMask, factorSlideNorm, scalePolar)

            Call TensorAxis(angFabAxis1, angFabAxis2, tsFabric(0), tsFabric(1), tsFabric(3))

            Call TensorAxis(angFabCN1, angFabCN2, tsConNorm(0), tsConNorm(1), tsConNorm(3))

            Call TensorAxis(angBodyStressAxis1, angBodyStressAxis2, tsStress(4), tsStress(5), tsStress(7))

            Call TensorAxis(angStressAxis1, angStressAxis2, tsStress(0), tsStress(1), tsStress(3))


        End If

        If chkExportCon.Checked Then
            Call ExportCon(nEle, nCon, FCon, fricRatio, qNorm, flagFMask, iCurStep(0))
        End If

        If chkMonitorSystemVariable.Checked = True Then
            MonitorSystemVariable.Invalidate()

        End If


        If chkShowSldTrace.Checked = True Or chkShowRollingTrace.Checked = True Then
            Call PlotSldTrace(nEle, nActEle, nWall, iStep, jStep, _
                   nStep, xEle, yEle, qEle, rSldTrace, qSldTrace, frSldTrace, normSldTrace, _
                    eleSldTrace, CBSldTrace, nConSldTrace, _
                    x1Wall, x2Wall, y1Wall, y2Wall, nPlotSld, nPlotRol, _
                    xPlotSld, xPlotRol)

        End If

        If chkShowStrain.Checked = True Or chkShowStnDrct.Checked = True Or chkShwStrnVal.Checked = True Then
            Call StrainCell(nEle, xEleTrace, yEleTrace, vxEle, vyEle, _
            nStep, iStep, jStep, strainOut, drctStn, areaCell, numCell, eleStnCell, _
            flagEffCell, flagStnOut, flagDrctStnOut, flagStnMode, angN)

        End If


        If chkExpDiscMask.Checked = True And nEleDiscMask > 0 Then
            textEleQuery.AppendText(iCurStep(0).ToString & ", ")

            For i As Integer = 0 To nEleDiscMask - 1
                textEleQuery.AppendText(qEle(eleDiscMask(i)).ToString("F02") & ", ")
            Next

            textEleQuery.AppendText(Environment.NewLine)
        End If

        If chkShowDualCelll.Checked Then
            UDDualCell()
            If chkExpVVTs.Checked Then
                textEleQuery.AppendText(iCurStep(0).ToString & " , " & tsVVP(0).ToString("F05") & " , " _
                                        & (tsVVPAng(0) * 180 / Math.PI).ToString("F03") & " , " _
                                        & tsVV(0, 0).ToString("F05") & " , " _
                                        & tsVV(1, 1).ToString("F05") & " , " _
                                        & tsVV(0, 1).ToString("F05") & " , " _
                                        & Environment.NewLine)

            End If
        End If

        If chkExpWallPosition.Checked Then
            textEleQuery.AppendText(iCurStep(0).ToString & ", ")
            For iWall As Integer = 0 To nWall - 1
                textEleQuery.AppendText(x1Wall(iWall).ToString & ", " & y1Wall(iWall).ToString & ", " & x2Wall(iWall).ToString & ", " & y2Wall(iWall).ToString & ", ")
            Next
            textEleQuery.AppendText(Environment.NewLine)
        End If

        If chkTracDNSpatial.Checked Then
            CalculateDNMatrix()
        End If

        If chkTrackMinDist.Checked Then
            CalculateMinDistance()
        End If

        canvas.Invalidate()




    End Sub


    Private Sub trackStateB_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trackStateB.Scroll, trackStateB.ValueChanged


        jStep = trackStateB.Value + 1

        showJStep.Text = (jStep - iStep).ToString
        If chkDefContour.Checked = True And modeMotion.Checked = True Then
            Call ColorDeform(nEle, nActEle, xEleTrace, yEleTrace, qEleTrace, rangeContour, relaMin, relamax, nStep, iStep, jStep, iMode, jMode, kMode, mMode, TraceRGB, ptcStress, areaEle, iniOri, Ori, refOri, numECon)


            setRelaMax.Value = relamax
            setRelaMin.Value = relaMin

        End If

        If chkShowSldTrace.Checked = True Or chkShowRollingTrace.Checked = True Then
            Call PlotSldTrace(nEle, nActEle, nWall, iStep, jStep, _
                   nStep, xEle, yEle, qEle, rSldTrace, qSldTrace, frSldTrace, normSldTrace, _
                    eleSldTrace, CBSldTrace, nConSldTrace, _
                    x1Wall, x2Wall, y1Wall, y2Wall, nPlotSld, nPlotRol, _
                    xPlotSld, xPlotRol)

        End If


        If chkShowStrain.Checked = True Or chkShowStnDrct.Checked = True Or chkShwStrnVal.Checked = True Then
            Call StrainCell(nEle, xEleTrace, yEleTrace, vxEle, vyEle, _
            nStep, iStep, jStep, strainOut, drctStn, areaCell, numCell, eleStnCell, _
            flagEffCell, flagStnOut, flagDrctStnOut, flagStnMode, angN)
        End If


        canvas.Invalidate()
    End Sub

    Private Sub btnRotationScaleUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRotationScaleUp.Click
        rotationScale *= 1.5
        canvas.Invalidate()

    End Sub

    Private Sub btnRotationScaleDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRotationScaleDown.Click
        rotationScale /= 1.5
        canvas.Invalidate()
    End Sub

    Private Sub setFreqSave_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setFreqSaveRST.ValueChanged
        freqSave = setFreqSaveRST.Value
    End Sub

    Private Sub btnNewGD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewGD.Click
        wCellGD = Math.Abs(limitAll(1) - limitAll(0)) / setNumGD.Value
        nVLine = setNumGD.Value + 1
        nHLine = Math.Abs(limitAll(3) - limitAll(2)) / wCellGD + 2
        ReDim nHPtGD(nHLine - 1)
        ReDim nVPtGD(nVLine - 1)
        ReDim iHElePtGD(999, nHLine - 1)
        ReDim iVElePtGD(999, nVLine - 1)
        ReDim rqiHPtGD(1, 999, nHLine - 1)
        ReDim rqiVPtGD(1, 999, nVLine - 1)
        ReDim xHPtGD(1, 999, nHLine - 1)
        ReDim xVPtGD(1, 999, nVLine - 1)

        Call DomainLimit(nEle, nActEle, xEle, yEle, rEle, nVertex, xVertex, yVertex, boundELe, limitAll, hSector)

        limitAll(0) -= maxGap
        limitAll(1) += maxGap
        limitAll(2) -= maxGap
        limitAll(3) += maxGap


        nGridY = (limitAll(3) - limitAll(2)) / xGrid + 1
        nGridX = (limitAll(1) - limitAll(0)) / xGrid + 1
        maxNEleGrid = Math.Max((xGrid ^ 2 / (volSld / nActEle) * 4), 10)   'Potentially problematic
        ReDim nEleGrid(nGridY - 1, nGridX - 1)
        ReDim lEG(maxNEleGrid - 1, nGridY - 1, nGridX - 1)


        Call Grid(nEle, nActEle, nVertex, xEle, yEle, rEle, xVertex, yVertex, nGridX, nGridY, nEleGrid, lEG, xGrid, boundELe, limitAll, maxNEleGrid)


        Call IniGD(nEle, xEle, yEle, rEle, qEle, nVertex, xVertex, _
         yVertex, limitAll, nGridX, nGridY, nEleGrid, lEG, _
          wCellGD, xGrid, maxNEleGrid, nHLine, nVLine, nHPtGD, nVPtGD, iHElePtGD, iVElePtGD, rqiHPtGD, rqiVPtGD, _
          xHPtGD, xVPtGD, flagDyeGrid)


        canvas.Invalidate()

    End Sub



    Private Sub modeMotion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modeMotion.CheckedChanged
        If modeMotion.Checked = True And flagReadOpen = 0 Then
            groupPtclMotion.Visible = True
            trackStateB.Enabled = True

            ReDim xEleTrace(nStep - 1, nEle - 1)
            ReDim yEleTrace(nStep - 1, nEle - 1)
            ReDim qEleTrace(nStep - 1, nEle - 1)
            ReDim TraceRGB(2, nEle - 1)

            ''''''''''''''''''''''''''''''''''''''''''''''''''''
            '' Disable the capability of drawing contact trace to save memory.
            'ReDim rSldTrace(nStep - 1, nEle * 6 - 1)
            'ReDim qSldTrace(nStep - 1, nEle * 6 - 1)
            'ReDim frSldTrace(nStep - 1, nEle * 6 - 1)
            'ReDim normSldTrace(nStep - 1, nEle * 6 - 1)
            'ReDim eleSldTrace(nStep - 1, nEle * 6 - 1)
            'ReDim CBSldTrace(nStep - 1, nEle * 6 - 1)
            'ReDim nConSldTrace(nStep - 1)
            'ReDim xPlotRol(nEle * 6 * nStep - 1, 1)
            'ReDim xPlotSld(nEle * 6 * nStep - 1, 3)

            ReDim rSldTrace(0, 0)
            ReDim qSldTrace(0, 0)
            ReDim frSldTrace(0, 0)
            ReDim normSldTrace(0, 0)
            ReDim eleSldTrace(0, 0)
            ReDim CBSldTrace(0, 0)
            ReDim nConSldTrace(0)
            ReDim xPlotRol(0, 0)
            ReDim xPlotSld(0, 0)
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


            jStep = trackStateB.Value + 1

            Call ReadTrace(nEle, nActEle, nWall, xEleTrace, yEleTrace, qEleTrace, nStep, verRead, _
                 rSldTrace, qSldTrace, frSldTrace, normSldTrace, eleSldTrace, CBSldTrace, nConSldTrace, _
                  tempX1Wall, tempX2Wall, tempY1Wall, tempY2Wall, tempXCon, tempYCon, _
                  tempFricRatio, tempTanNorm, tempPairCon, flagConBoun)

            preStep = 0
            iStep = 1
            trackPost.Value = 0

            Call PlotSldTrace(nEle, nActEle, nWall, iStep, jStep, _
                   nStep, xEle, yEle, qEle, rSldTrace, qSldTrace, frSldTrace, normSldTrace, _
                    eleSldTrace, CBSldTrace, nConSldTrace, _
                    x1Wall, x2Wall, y1Wall, y2Wall, nPlotSld, nPlotRol, _
                    xPlotSld, xPlotRol)


            chkShowStrain.Enabled = True
            chkShowStnDrct.Enabled = True
        Else
            trackStateB.Enabled = False
            groupPtclMotion.Visible = False
            Erase rSldTrace, qSldTrace, frSldTrace, normSldTrace, eleSldTrace, CBSldTrace, nConSldTrace, xPlotRol, xPlotSld
        End If

    End Sub

    Private Sub modeGD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modeGD.CheckedChanged

        If modeGD.Checked = True Then

            grpGridDeform.Visible = True

            If flagGDExist = 0 Then
                flagGDExist = 1

                wCellGD = Math.Abs(limitAll(1) - limitAll(0)) / setNumGD.Value
                nVLine = setNumGD.Value + 1
                nHLine = Math.Abs(limitAll(3) - limitAll(2)) / wCellGD + 2
                ReDim nHPtGD(nHLine - 1)
                ReDim nVPtGD(nVLine - 1)
                ReDim iHElePtGD(999, nHLine - 1)
                ReDim iVElePtGD(999, nVLine - 1)
                ReDim rqiHPtGD(1, 999, nHLine - 1)
                ReDim rqiVPtGD(1, 999, nVLine - 1)
                ReDim xHPtGD(1, 999, nHLine - 1)
                ReDim xVPtGD(1, 999, nVLine - 1)

                Call IniGD(nEle, xEle, yEle, rEle, qEle, nVertex, xVertex, _
                 yVertex, limitAll, nGridX, nGridY, nEleGrid, lEG, _
                  wCellGD, xGrid, maxNEleGrid, nHLine, nVLine, nHPtGD, nVPtGD, iHElePtGD, iVElePtGD, rqiHPtGD, rqiVPtGD, _
                  xHPtGD, xVPtGD, flagDyeGrid)

            End If

        Else
            grpGridDeform.Visible = False


        End If

        canvas.Invalidate()




    End Sub

    Private Sub rbContourH_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbContourH.CheckedChanged
        If rbContourH.Checked = True Then
            iMode = 1
            Call ColorDeform(nEle, nActEle, xEleTrace, yEleTrace, qEleTrace, rangeContour, relaMin, relamax, nStep, iStep, jStep, iMode, jMode, kMode, mMode, TraceRGB, ptcStress, areaEle, iniOri, Ori, refOri, numECon)


        End If
    End Sub

    Private Sub rbContourV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbContourV.CheckedChanged
        If rbContourV.Checked = True Then
            iMode = 2
            Call ColorDeform(nEle, nActEle, xEleTrace, yEleTrace, qEleTrace, rangeContour, relaMin, relamax, nStep, iStep, jStep, iMode, jMode, kMode, mMode, TraceRGB, ptcStress, areaEle, iniOri, Ori, refOri, numECon)



        End If
        canvas.Invalidate()

    End Sub

    Private Sub rbContourU_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbContourU.CheckedChanged
        If rbContourU.Checked = True Then
            iMode = 3
            Call ColorDeform(nEle, nActEle, xEleTrace, yEleTrace, qEleTrace, rangeContour, relaMin, relamax, nStep, iStep, jStep, iMode, jMode, kMode, mMode, TraceRGB, ptcStress, areaEle, iniOri, Ori, refOri, numECon)


        End If
        canvas.Invalidate()

    End Sub

    Private Sub rbContourR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbContourR.CheckedChanged
        If rbContourR.Checked = True Then
            iMode = 4
            Call ColorDeform(nEle, nActEle, xEleTrace, yEleTrace, qEleTrace, rangeContour, relaMin, relamax, nStep, iStep, jStep, iMode, jMode, kMode, mMode, TraceRGB, ptcStress, areaEle, iniOri, Ori, refOri, numECon)


        End If
        canvas.Invalidate()

    End Sub


    Private Sub chkDefContour_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDefContour.CheckedChanged
        Call ColorDeform(nEle, nActEle, xEleTrace, yEleTrace, qEleTrace, rangeContour, relaMin, relamax, nStep, iStep, jStep, iMode, jMode, kMode, mMode, TraceRGB, ptcStress, areaEle, iniOri, Ori, refOri, numECon)



        setRelaMax.Value = relamax
        setRelaMin.Value = relaMin
        canvas.Invalidate()

    End Sub


    Private Sub lowContourRange_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lowContourRange.Scroll
        rangeContour(0) = lowContourRange.Value

        If chkDefContour.Checked = True And modeMotion.Checked = True Then
            Call ColorDeform(nEle, nActEle, xEleTrace, yEleTrace, qEleTrace, rangeContour, relaMin, relamax, nStep, iStep, jStep, iMode, jMode, kMode, mMode, TraceRGB, ptcStress, areaEle, iniOri, Ori, refOri, numECon)


        End If
        setRelaMax.Value = relamax
        setRelaMin.Value = relaMin

        canvas.Invalidate()

    End Sub


    Private Sub upContourRange_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upContourRange.Scroll
        rangeContour(1) = upContourRange.Value
        If chkDefContour.Checked = True And modeMotion.Checked = True Then
            Call ColorDeform(nEle, nActEle, xEleTrace, yEleTrace, qEleTrace, rangeContour, relaMin, relamax, nStep, iStep, jStep, iMode, jMode, kMode, mMode, TraceRGB, ptcStress, areaEle, iniOri, Ori, refOri, numECon)



        End If
        setRelaMax.Value = relamax
        setRelaMin.Value = relaMin

        canvas.Invalidate()


    End Sub


    Private Sub modeHist_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modeHist.CheckedChanged
        If modeHist.Checked = True Then
            Call Histogram(nEle, nActEle, xEle, yEle, mInertEle, qEle, iniOri, Ori, elong, _
                           nVertex, nCon, xCon, yCon, FxCon, FyCon, FCon, flagConBoun, FAngle, fricRatio, tanNorm, qNorm, _
                           nNodeMask, Mask, BinForce, BinOri, BinFR, BinNorm, BinSlideNorm, BinFN, BinFT, BinRoseFR, _
                           iHistMode, iWeight, jWeight, iBoundMode, flagFMask, flagEMask, _
                           nBinForce, nBinOri, nBinFR, nBinNorm, ptBinF, ptBinE, ptBinFR, ptBinNorm, ptBinSlideNorm, ptBinFN, ptBinFT, ptBinRoseFR, _
                           tsFabric, tsStress, tsConNorm, numContact, pairCon, flagOutput, vol, iCurStep, ptcStress, nEleMask, factorSlideNorm, scalePolar)

            Histgram.Show()
            canvas.Invalidate()
        End If
    End Sub

    Private Sub setCAC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setCAC.ValueChanged
        If flagEditVertex = 1 Then

            CAC(actVertex, actEle) = setCAC.Value
            Call reInitiate()

            canvas.Invalidate()
        End If

    End Sub


    Private Sub modeVR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modeVR.CheckedChanged
        If modeVR.Checked = True Then
            flagNewVRBox = 1
            timerTest.Enabled = False
            btnPause.Text = "Resume"

            Me.Cursor = Cursors.SizeNWSE
            Call DomainLimit(nEle, nActEle, xEle, yEle, rEle, nVertex, xVertex, yVertex, boundELe, limitAll, hSector)

            limitAll(0) -= maxGap
            limitAll(1) += maxGap
            limitAll(2) -= maxGap
            limitAll(3) += maxGap


            nGridY = (limitAll(3) - limitAll(2)) / xGrid + 1
            nGridX = (limitAll(1) - limitAll(0)) / xGrid + 1
            maxNEleGrid = Math.Max((xGrid ^ 2 / (volSld / nActEle) * 4), 10)   'Potentially problematic
            ReDim nEleGrid(nGridY - 1, nGridX - 1)
            ReDim lEG(maxNEleGrid - 1, nGridY - 1, nGridX - 1)


            Call Grid(nEle, nActEle, nVertex, xEle, yEle, rEle, xVertex, yVertex, nGridX, nGridY, nEleGrid, lEG, xGrid, boundELe, limitAll, maxNEleGrid)

            Call Confinement(nEle, xEle, yEle, rEle, nVertex, xVertex, yVertex, boundELe, limitAll, _
            pInt, nPCon, pPlot, FxC, FyC, FMC, nGridX, nGridY, nEleGrid, lEG, xGrid, flagDebug, maxNEleGrid, vol, pairCon, _
            nWall, iniFWall, x1Wall, x2Wall, y1Wall, y2Wall, flagLoadMode, intLoadPara, realLoadPara, iCurStep)





        Else
            flagNewVRBox = 0

        End If
    End Sub

    Private Sub setCurrentLoadRate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setCurrentLoadRate.ValueChanged
        setCurrentLoadRate.Increment = Math.Abs(setCurrentLoadRate.Value)

        For i As Integer = 0 To 7
            If intLoadPara(i + 1, 0) = 1 Then
                realLoadPara(i, 0) = setCurrentLoadRate.Value
            End If
        Next

    End Sub

    Private Sub setNBinOri_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setNBinOri.ValueChanged

        nBinOri = setNBinOri.Value
        ReDim BinOri(nBinOri - 1)
        ReDim ptBinE(1, nBinOri * 4 - 1)

        If modeHist.Checked = True Then
            Call Histogram(nEle, nActEle, xEle, yEle, mInertEle, qEle, iniOri, Ori, elong, _
             nVertex, nCon, xCon, yCon, FxCon, FyCon, FCon, flagConBoun, FAngle, fricRatio, tanNorm, qNorm, _
            nNodeMask, Mask, BinForce, BinOri, BinFR, BinNorm, BinSlideNorm, BinFN, BinFT, BinRoseFR, _
            iHistMode, iWeight, jWeight, iBoundMode, flagFMask, flagEMask, _
            nBinForce, nBinOri, nBinFR, nBinNorm, ptBinF, ptBinE, ptBinFR, ptBinNorm, ptBinSlideNorm, ptBinFN, ptBinFT, ptBinRoseFR, _
            tsFabric, tsStress, tsConNorm, numContact, pairCon, flagOutput, vol, iCurStep, ptcStress, nEleMask, factorSlideNorm, scalePolar)

            Histgram.roseForce.Invalidate()
            Histgram.roseOrit.Invalidate()
            Histgram.roseNorm.Invalidate()
            Histgram.hgFR.Invalidate()
            Histgram.groupTsStress.Invalidate()
            Histgram.groupTsFabric.Invalidate()
            Histgram.gbFabricConNorm.Invalidate()
            Histgram.groupTsBodyStress.Invalidate()

        End If
    End Sub

    Private Sub setNBinNorm_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setNBinNorm.ValueChanged
        nBinNorm = setNBinNorm.Value

        ReDim BinNorm(nBinNorm - 1)
        ReDim ptBinNorm(1, nBinNorm * 4 - 1)
        ReDim BinSlideNorm(nBinNorm - 1)
        ReDim ptBinSlideNorm(1, nBinNorm * 4 - 1)
        ReDim BinFN(nBinNorm - 1)
        ReDim BinFT(nBinNorm - 1)
        ReDim BinRoseFR(nBinNorm - 1)
        ReDim ptBinFN(1, nBinNorm * 4 - 1)
        ReDim ptBinFT(1, nBinNorm * 4 - 1)
        ReDim ptBinRoseFR(1, nBinNorm * 4 - 1)


        If modeHist.Checked = True Then
            Call Histogram(nEle, nActEle, xEle, yEle, mInertEle, qEle, iniOri, Ori, elong, _
             nVertex, nCon, xCon, yCon, FxCon, FyCon, FCon, flagConBoun, FAngle, fricRatio, tanNorm, qNorm, _
            nNodeMask, Mask, BinForce, BinOri, BinFR, BinNorm, BinSlideNorm, BinFN, BinFT, BinRoseFR, _
            iHistMode, iWeight, jWeight, iBoundMode, flagFMask, flagEMask, _
            nBinForce, nBinOri, nBinFR, nBinNorm, ptBinF, ptBinE, ptBinFR, ptBinNorm, ptBinSlideNorm, ptBinFN, ptBinFT, ptBinRoseFR, _
            tsFabric, tsStress, tsConNorm, numContact, pairCon, flagOutput, vol, iCurStep, ptcStress, nEleMask, factorSlideNorm, scalePolar)
            Histgram.roseForce.Invalidate()
            Histgram.roseOrit.Invalidate()
            Histgram.roseNorm.Invalidate()
            Histgram.hgFR.Invalidate()
            Histgram.groupTsStress.Invalidate()
            Histgram.groupTsFabric.Invalidate()
            Histgram.gbFabricConNorm.Invalidate()
            Histgram.groupTsBodyStress.Invalidate()

        End If

    End Sub

    Private Sub setNBinForce_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setNBinForce.ValueChanged
        nBinForce = setNBinForce.Value
        ReDim BinForce(nBinForce - 1)
        ReDim ptBinF(1, nBinForce * 4 - 1)
        If modeHist.Checked = True Then
            Call Histogram(nEle, nActEle, xEle, yEle, mInertEle, qEle, iniOri, Ori, elong, _
             nVertex, nCon, xCon, yCon, FxCon, FyCon, FCon, flagConBoun, FAngle, fricRatio, tanNorm, qNorm, _
            nNodeMask, Mask, BinForce, BinOri, BinFR, BinNorm, BinSlideNorm, BinFN, BinFT, BinRoseFR, _
            iHistMode, iWeight, jWeight, iBoundMode, flagFMask, flagEMask, _
            nBinForce, nBinOri, nBinFR, nBinNorm, ptBinF, ptBinE, ptBinFR, ptBinNorm, ptBinSlideNorm, ptBinFN, ptBinFT, ptBinRoseFR, _
            tsFabric, tsStress, tsConNorm, numContact, pairCon, flagOutput, vol, iCurStep, ptcStress, nEleMask, factorSlideNorm, scalePolar)
            Histgram.roseForce.Invalidate()
            Histgram.roseOrit.Invalidate()
            Histgram.roseNorm.Invalidate()
            Histgram.hgFR.Invalidate()
            Histgram.groupTsStress.Invalidate()
            Histgram.groupTsFabric.Invalidate()
            Histgram.gbFabricConNorm.Invalidate()
            Histgram.groupTsBodyStress.Invalidate()

        End If

        nBinVV = setNBinForce.Value
        ReDim binVV(nBinVV)


    End Sub

    Private Sub setNBinFR_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setNBinFR.ValueChanged
        nBinFR = setNBinFR.Value
        ReDim BinFR(nBinFR - 1)
        ReDim ptBinFR(3, nBinFR - 1)
        If modeHist.Checked = True Then
            Call Histogram(nEle, nActEle, xEle, yEle, mInertEle, qEle, iniOri, Ori, elong, _
             nVertex, nCon, xCon, yCon, FxCon, FyCon, FCon, flagConBoun, FAngle, fricRatio, tanNorm, qNorm, _
            nNodeMask, Mask, BinForce, BinOri, BinFR, BinNorm, BinSlideNorm, BinFN, BinFT, BinRoseFR, _
            iHistMode, iWeight, jWeight, iBoundMode, flagFMask, flagEMask, _
            nBinForce, nBinOri, nBinFR, nBinNorm, ptBinF, ptBinE, ptBinFR, ptBinNorm, ptBinSlideNorm, ptBinFN, ptBinFT, ptBinRoseFR, _
            tsFabric, tsStress, tsConNorm, numContact, pairCon, flagOutput, vol, iCurStep, ptcStress, nEleMask, factorSlideNorm, scalePolar)
            Histgram.roseForce.Invalidate()
            Histgram.roseOrit.Invalidate()
            Histgram.roseNorm.Invalidate()
            Histgram.hgFR.Invalidate()
            Histgram.groupTsStress.Invalidate()
            Histgram.groupTsFabric.Invalidate()
            Histgram.gbFabricConNorm.Invalidate()
            Histgram.groupTsBodyStress.Invalidate()

        End If

    End Sub

    ' This legacy function is not used anymore
    '    Private Sub setFacSldNorm_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '       factorSlideNorm = setFacSldNorm.Value
    '      If modeHist.Checked = True Then
    '         Call Histogram(nEle, nActEle, xEle, yEle, mInertEle, qEle, iniOri, Ori, elong, _
    '         nVertex, nCon, xCon, yCon, FxCon, FyCon, FCon, flagConBoun, FAngle, fricRatio, tanNorm, qNorm, _
    '       nNodeMask, Mask, BinForce, BinOri, BinFR, BinNorm, BinSlideNorm, BinFN, BinFT, BinRoseFR, _
    '      iHistMode, iWeight, jWeight, iBoundMode, flagFMask, flagEMask, _
    '     nBinForce, nBinOri, nBinFR, nBinNorm, ptBinF, ptBinE, ptBinFR, ptBinNorm, ptBinSlideNorm, ptBinFN, ptBinFT, ptBinRoseFR, _
    '    tsFabric, tsStress, tsConNorm, numContact, pairCon, flagOutput, vol, iCurStep, ptcStress, nEleMask, factorSlideNorm, scalePolar)
    '
    '       Histgram.roseForce.Invalidate()
    '      Histgram.roseOrit.Invalidate()
    '     Histgram.roseNorm.Invalidate()
    '    Histgram.hgFR.Invalidate()
    '   Histgram.groupTsStress.Invalidate()
    '  Histgram.groupTsFabric.Invalidate()
    ' Histgram.gbFabricConNorm.Invalidate()
    'Histgram.groupTsBodyStress.Invalidate()

    '    End If
    'End Sub


    Private Sub chkMode0_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMode0.CheckedChanged
        If chkMode0.Checked = True Then
            jMode = 0
            setRelaMax.Enabled = False
            setRelaMin.Enabled = False
            lowContourRange.Enabled = True
            upContourRange.Enabled = True
        Else
            jMode = 1
            setRelaMax.Enabled = True
            setRelaMin.Enabled = True
            lowContourRange.Enabled = False
            upContourRange.Enabled = False

        End If
    End Sub

    Private Sub setRelaMin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setRelaMin.ValueChanged

        relaMin = setRelaMin.Value
        relamax = setRelaMax.Value

        If chkDefContour.Checked = True And modeMotion.Checked = True Then
            Call ColorDeform(nEle, nActEle, xEleTrace, yEleTrace, qEleTrace, rangeContour, relaMin, relamax, nStep, iStep, jStep, iMode, jMode, kMode, mMode, TraceRGB, ptcStress, areaEle, iniOri, Ori, refOri, numECon)



        End If
        lowContourRange.Value = rangeContour(0)
        upContourRange.Value = rangeContour(1)

        canvas.Invalidate()


    End Sub

    Private Sub setRelaMax_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setRelaMax.ValueChanged

        relaMin = setRelaMin.Value
        relamax = setRelaMax.Value

        If chkDefContour.Checked = True And modeMotion.Checked = True Then
            Call ColorDeform(nEle, nActEle, xEleTrace, yEleTrace, qEleTrace, rangeContour, relaMin, relamax, nStep, iStep, jStep, iMode, jMode, kMode, mMode, TraceRGB, ptcStress, areaEle, iniOri, Ori, refOri, numECon)



        End If
        lowContourRange.Value = rangeContour(0)
        upContourRange.Value = rangeContour(1)

        canvas.Invalidate()

    End Sub








    Private Sub rbView_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbView.CheckedChanged
        If rbView.Checked = False Then
            flagAdd = 0
            nVNew = 0
            flagEditEle = 0
            flagEditVertex = 0
            btnRotate.Enabled = False
            timerTest.Enabled = False
            btnPause.Text = "Resume"
            btnPause.Enabled = False
            setAngRotate.Enabled = False
            setCAC.Enabled = False
            canvas.Invalidate()
        Else
            btnPause.Enabled = True
            canvas.Invalidate()


        End If

    End Sub

    Private Sub rbEleMove_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEleMove.CheckedChanged
        If rbEleMove.Checked = True Then
            flagEditEle = 1
        Else
            flagEditEle = 0
        End If
    End Sub

    Private Sub rbEleShape_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEleShape.CheckedChanged
        If rbEleShape.Checked = True Then
            flagEditVertex = 1
            If nVertex(actEle) > 2 Then
                setCAC.Value = CAC(actVertex, actEle)
            End If
            setCAC.Enabled = True


        Else
            flagEditVertex = 0
            setCAC.Enabled = False

        End If
        canvas.Invalidate()

    End Sub

    Private Sub rbEleAdd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEleAdd.CheckedChanged
        If rbEleAdd.Checked = True Then
            flagAdd = 1
            setCAC.Enabled = True
        Else
            flagAdd = 0
            setCAC.Enabled = False
        End If

    End Sub

    Private Sub rbEleCopy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEleCopy.CheckedChanged
        If rbEleCopy.Checked = True Then
            flagCopy = 1
        Else
            flagCopy = 0

        End If
    End Sub

    Private Sub rbEleRotate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEleRotate.CheckedChanged
        If rbEleRotate.Checked = True Then
            flagEleRotate = 1
            setAngRotate.Enabled = True
            btnRotate.Enabled = True
        Else
            flagEleRotate = 0
            setAngRotate.Enabled = False
            btnRotate.Enabled = False

        End If
    End Sub

    Private Sub btnRotate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRotate.Click

        If flagEleRotate = 1 Then


            qEle(actEle) += setAngRotate.Value / 180 * Math.PI

            If nVertex(actEle) > 0 Then
                For iV As Integer = 0 To nVertex(actEle) - 1
                    qVertex(iV, actEle) += setAngRotate.Value / 180 * Math.PI
                    xVertex(iV, actEle) = xEle(actEle) + rVertex(iV, actEle) * Math.Cos(qVertex(iV, actEle))
                    yVertex(iV, actEle) = yEle(actEle) + rVertex(iV, actEle) * Math.Sin(qVertex(iV, actEle))
                Next

                xVertex(nVertex(actEle), actEle) = xVertex(0, actEle)
                yVertex(nVertex(actEle), actEle) = yVertex(0, actEle)
            End If



            Call reInitiate()


        End If

        If flagSampleRotate = 1 Then
            cosAngRotate = Math.Cos(setAngRotate.Value / 180 * Math.PI)
            sinAngRotate = Math.Sin(setAngRotate.Value / 180 * Math.PI)

            For i As Integer = 0 To nActEle - 1

                If nVertex(i) = 0 Then

                    If xEle(i) <> xRotationCenter(0) And yEle(i) <> xRotationCenter(1) Then

                        lTemp = Math.Sqrt((xEle(i) - xRotationCenter(0)) ^ 2 + (yEle(i) - xRotationCenter(1)) ^ 2)
                        cosTemp = (xEle(i) - xRotationCenter(0)) / lTemp
                        sinTemp = (yEle(i) - xRotationCenter(1)) / lTemp

                        xEle(i) = xRotationCenter(0) + lTemp * (cosAngRotate * cosTemp - sinAngRotate * sinTemp)
                        yEle(i) = xRotationCenter(1) + lTemp * (cosAngRotate * sinTemp + sinAngRotate * cosTemp)
                    End If



                Else
                    For j As Integer = 0 To nVertex(i) - 1

                        If xVertex(j, i) <> xRotationCenter(0) And yVertex(j, i) <> xRotationCenter(1) Then

                            lTemp = Math.Sqrt((xVertex(j, i) - xRotationCenter(0)) ^ 2 + (yVertex(j, i) - xRotationCenter(1)) ^ 2)
                            cosTemp = (xVertex(j, i) - xRotationCenter(0)) / lTemp
                            sinTemp = (yVertex(j, i) - xRotationCenter(1)) / lTemp

                            xVertex(j, i) = xRotationCenter(0) + lTemp * (cosAngRotate * cosTemp - sinAngRotate * sinTemp)
                            yVertex(j, i) = xRotationCenter(1) + lTemp * (cosAngRotate * sinTemp + sinAngRotate * cosTemp)
                        End If


                    Next

                End If


            Next

            For iWall As Integer = 0 To nWall - 1

                lTemp = Math.Sqrt((x1Wall(iWall) - xRotationCenter(0)) ^ 2 + (y1Wall(iWall) - xRotationCenter(1)) ^ 2)
                cosTemp = (x1Wall(iWall) - xRotationCenter(0)) / lTemp
                sinTemp = (y1Wall(iWall) - xRotationCenter(1)) / lTemp

                x1Wall(iWall) = xRotationCenter(0) + lTemp * (cosAngRotate * cosTemp - sinAngRotate * sinTemp)
                y1Wall(iWall) = xRotationCenter(1) + lTemp * (cosAngRotate * sinTemp + sinAngRotate * cosTemp)


                lTemp = Math.Sqrt((x2Wall(iWall) - xRotationCenter(0)) ^ 2 + (y2Wall(iWall) - xRotationCenter(1)) ^ 2)
                cosTemp = (x2Wall(iWall) - xRotationCenter(0)) / lTemp
                sinTemp = (y2Wall(iWall) - xRotationCenter(1)) / lTemp

                x2Wall(iWall) = xRotationCenter(0) + lTemp * (cosAngRotate * cosTemp - sinAngRotate * sinTemp)
                y2Wall(iWall) = xRotationCenter(1) + lTemp * (cosAngRotate * sinTemp + sinAngRotate * cosTemp)



            Next




            Call reInitiate()

        End If

        canvas.Invalidate()

    End Sub

    Private Sub rbSampleRotate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSampleRotate.CheckedChanged
        If rbSampleRotate.Checked = True Then
            flagSampleRotate = 1
            btnRotate.Enabled = True
            setAngRotate.Enabled = True
            xRotationCenter(0) = (limitAll(0) + limitAll(1)) / 2
            xRotationCenter(1) = (limitAll(2) + limitAll(3)) / 2
            canvas.Invalidate()
        Else
            flagSampleRotate = 0
            btnRotate.Enabled = False
            setAngRotate.Enabled = False
        End If
    End Sub


    Private Sub rbEleRomove_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEleRomove.CheckedChanged
        If rbEleRomove.Checked = True Then
            flagEleRemove = 1
            btnRemove.Enabled = True
        Else
            flagEleRemove = 0
            btnRemove.Enabled = False
        End If
    End Sub






    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click

        For i As Integer = actEle To nActEle - 2

            If nVertex(i + 1) = 0 Then
                xEle(i) = xEle(i + 1)
                yEle(i) = yEle(i + 1)
                rEle(i) = rEle(i + 1)

            Else
                For j As Integer = 0 To nVertex(i + 1) - 1
                    xVertex(j, i) = xVertex(j, i + 1)
                    yVertex(j, i) = yVertex(j, i + 1)

                Next


            End If

        Next

        nActEle -= 1

        Call reInitiate()

        canvas.Invalidate()

    End Sub



    Private Sub btnMaskCrop_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaskCrop.Click

        timerTest.Enabled = False
        btnPause.Enabled = False
        btnPause.Text = "Resume"
        btnMaskCrop.Enabled = False
        grpMaskShape.Enabled = True

        flagMaskCropOn = 1

        nPtMaskCrop = 0
        xMaskCrop(0, 0) = (limitAll(0) + limitAll(1)) / 2   ' initialize the center for circular mask
        xMaskCrop(1, 0) = (limitAll(2) + limitAll(3)) / 2



        ReDim xMaskCrop(1, 9)


    End Sub

    Private Sub rbMaskCircular_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMaskCircular.CheckedChanged
        If rbMaskCircular.Checked = True And flagMaskCropOn = 1 Then
            nPtMaskCrop = 0
            xMaskCrop(0, 0) = (limitAll(0) + limitAll(1)) / 2
            xMaskCrop(1, 0) = (limitAll(2) + limitAll(3)) / 2
        End If
    End Sub

    Private Sub btnCrop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrop.Click
        Call Crop(nEle, nActEle, xEle, yEle, rEle, nVertex, xVertex, yVertex, CAC, flagEMask)
        ReDim flagEMask(nEle)
        Call reInitiate()
        flagMaskCropOn = 0
        btnCrop.Enabled = False
        btnPause.Enabled = True
        grpMaskShape.Enabled = False
        canvas.Invalidate()
    End Sub

    Private Sub rbMaskPoly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMaskPoly.CheckedChanged
        If rbMaskPoly.Checked = True Then
            nPtMaskCrop = 0
        End If
    End Sub

    Private Sub btnMaskReverse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaskReverse.Click
        For i As Integer = 0 To nActEle - 1
            flagEMask(i) = 1 - flagEMask(i)
        Next
        canvas.Invalidate()
    End Sub

    Private Sub setRollingDamp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setRollingDamp.ValueChanged
        rollingDamp = setRollingDamp.Value
#If USEKEY = 1 Then
        WriteNoxMemo()
#End If

    End Sub

    Private Sub btnSnapShot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSnapShot.Click
        timerTest.Enabled = False
        btnPause.Text = "Resume"
        SaveSnapshot.ShowDialog()
        FileName = SaveSnapshot.FileName
        lName = FileName.Length

        If lName > 0 Then

            Params(0) = dt
            Params(1) = stiff
            Params(2) = globdamp
            Params(3) = rollingDamp
            Params(4) = dampingRatio
            Params(5) = maxGap
            Params(6) = tanTheta(0)
            Params(7) = setPx.Value
            Params(8) = setPy.Value
            Params(9) = pInt
            Params(10) = gXgY(0)
            Params(11) = gXgY(1)
            Params(12) = xGravity(0)
            Params(13) = xGravity(1)
            Params(14) = setpxy.Value
            Params(16) = tanTheta(1)



            Call Snapshot(nEle, nActEle, xEle, yEle, rEle, nVertex, xVertex, yVertex, CAC, nWall, x1Wall, x2Wall, y1Wall, y2Wall, Params, FileName, lName)


        End If
    End Sub



    Private Sub tabMain_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles tabMain.DrawItem

        If flagReDrawTab = 0 Then
            Dim header_rect As New Rectangle(tabMain.ClientRectangle.X - 10, tabMain.ClientRectangle.Y - 10, tabMain.ClientRectangle.Width + 20, tabMain.ClientRectangle.Height + 20)

            e.Graphics.FillRectangle(New SolidBrush(Color.DimGray), header_rect)
            flagReDrawTab = 1

        End If

        Dim rectButton As New Rectangle(e.Bounds.X - 3, e.Bounds.Y - 3, e.Bounds.Width + 6, e.Bounds.Height + 6)


        e.Graphics.FillRectangle(New SolidBrush(Color.Gray), rectButton)

        Dim tempfont As System.Drawing.Font = New Font(Me.Font.Name, 10, FontStyle.Bold, GraphicsUnit.Point)
        If e.Index = tabMain.SelectedIndex Then
            TextRenderer.DrawText(e.Graphics, tabMain.TabPages(e.Index).Text, tempfont, e.Bounds, Color.FromArgb(255, 255, 240, 200))
        Else
            TextRenderer.DrawText(e.Graphics, tabMain.TabPages(e.Index).Text, Me.Font, e.Bounds, Color.LightGray)
        End If

    End Sub

    Sub reInitiate()

        flagNewTest = 0
        Call Initiate(nEle, nActEle, xEle, yEle, qEle, nVertex, xVertex, yVertex, qVertex, rVertex, rEle, areaEle, MIEle, _
        vxEle, vyEle, vqEle, nWall, x1Wall, x2Wall, y1Wall, y2Wall, dEleMax, flagPairCohe, alwNEleFrd, minREle, rqCE, xCE, _
        hSector, flagNewTest, Params, CAC, volSld, FileName, lName)
        xGrid = dEleMax + maxGap

        Call IniOrient(nEle, nActEle, xEle, yEle, nVertex, xVertex, _
         yVertex, qVertex, rVertex, rEle, qEle, hSector, rqCE, xCE, boundELe, iniOri, elong)

        Call Mass(nEle, nActEle, areaEle, mGravEle, mInertEle, MIEle, MIInertEle, dt, density, stiff, flagMassNorm)

        Call DomainLimit(nEle, nActEle, xEle, yEle, rEle, nVertex, xVertex, yVertex, boundELe, limitAll, hSector)
        limitAll(0) -= maxGap
        limitAll(1) += maxGap
        limitAll(2) -= maxGap
        limitAll(3) += maxGap


    End Sub

    Private Sub btnOpenBatchLoading_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenBatchLoading.Click
        timerTest.Enabled = False
        btnPause.Text = "Resume"
        dlgOpenTest.ShowDialog()
        FileName = dlgOpenTest.FileName
        lName = FileName.Length

        If lName > 0 Then

            btnOpenBatchLoading.Enabled = False

            Call ReadBatchLoad(intLoadPara, realLoadPara, FileName, lName)

            rbManualLoading.Enabled = True
            rbBatchLoading.Enabled = True

        End If

    End Sub

    Private Sub rbBatchLoading_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbBatchLoading.CheckedChanged
        If rbBatchLoading.Checked = True Then
            flagLoadMode = 1
            grpDisplacementLoadControl.Enabled = False
            grpLoadModeControl.Enabled = False
            grpConfiningControl.Enabled = False
            iCurStep(1) = 1
        Else
            flagLoadMode = 0
            grpDisplacementLoadControl.Enabled = True
            grpLoadModeControl.Enabled = True
            grpConfiningControl.Enabled = True
            grpBatchLoading.Enabled = True   ' It allows to user to switch the loading mode from the initial manual mode to batch and then switch back, but doesn't allow to switch to the batching mode again.
            iCurStep(1) = 0

        End If
    End Sub


    Private Sub setLoadModeBottomN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setLoadModeBottomN.SelectedIndexChanged
        intLoadPara(1, 0) = setLoadModeBottomN.SelectedIndex + 1



        If setLoadModeBottomN.SelectedIndex = 0 Then
            realLoadPara(0, 0) = setCurrentLoadRate.Value
            vWall(1, 0) = 0
        ElseIf setLoadModeBottomN.SelectedIndex = 1 Then
            realLoadPara(0, 0) = setPy.Value
            vWall(1, 0) = 0
        Else
            realLoadPara(0, 0) = setPy.Value
        End If

    End Sub
    Private Sub setLoadModeBottomT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setLoadModeBottomT.SelectedIndexChanged
        intLoadPara(2, 0) = setLoadModeBottomT.SelectedIndex + 1

        If flagLoadMode = 0 Then

            If setLoadModeBottomT.SelectedIndex = 0 Then
                realLoadPara(1, 0) = setCurrentLoadRate.Value
                vWall(0, 0) = 0
            ElseIf setLoadModeBottomT.SelectedIndex = 1 Then
                vWall(0, 0) = 0
                realLoadPara(1, 0) = setpxy.Value
            Else
                realLoadPara(1, 0) = setpxy.Value
            End If
        End If
    End Sub



    Private Sub setLoadModeTopN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setLoadModeTopN.SelectedIndexChanged
        intLoadPara(3, 0) = setLoadModeTopN.SelectedIndex + 1

        If setLoadModeTopN.SelectedIndex = 0 Then
            realLoadPara(2, 0) = setCurrentLoadRate.Value
            vWall(1, 1) = 0
        ElseIf setLoadModeTopN.SelectedIndex = 1 Then
            vWall(1, 1) = 0
            realLoadPara(2, 0) = setPy.Value
        Else
            realLoadPara(2, 0) = setPy.Value
        End If

    End Sub
    Private Sub setLoadModeTopT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setLoadModeTopT.SelectedIndexChanged



        intLoadPara(4, 0) = setLoadModeTopT.SelectedIndex + 1

        If setLoadModeTopT.SelectedIndex = 0 Then
            realLoadPara(3, 0) = setCurrentLoadRate.Value
            vWall(0, 1) = 0
        ElseIf setLoadModeTopT.SelectedIndex = 1 Then
            vWall(0, 1) = 0
            realLoadPara(3, 0) = setpxy.Value
        Else
            realLoadPara(3, 0) = setpxy.Value
        End If
    End Sub


    Private Sub setLoadModeLeftN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setLoadModeLeftN.SelectedIndexChanged


        intLoadPara(5, 0) = setLoadModeLeftN.SelectedIndex + 1

        If setLoadModeLeftN.SelectedIndex = 0 Then
            realLoadPara(4, 0) = setCurrentLoadRate.Value
            vWall(0, 2) = 0
        ElseIf setLoadModeLeftN.SelectedIndex = 1 Then
            vWall(0, 2) = 0
            realLoadPara(4, 0) = setPx.Value
        Else
            realLoadPara(4, 0) = setPx.Value
        End If

    End Sub

    Private Sub setLoadModeLeftT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setLoadModeLeftT.SelectedIndexChanged
        intLoadPara(6, 0) = setLoadModeLeftT.SelectedIndex + 1

        If setLoadModeLeftT.SelectedIndex = 0 Then
            realLoadPara(5, 0) = setCurrentLoadRate.Value
            vWall(1, 2) = 0
        ElseIf setLoadModeLeftT.SelectedIndex = 1 Then
            vWall(1, 2) = 0
            realLoadPara(5, 0) = setpxy.Value
        Else
            realLoadPara(5, 0) = setpxy.Value
        End If

    End Sub



    Private Sub setLoadModeRightN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setLoadModeRightN.SelectedIndexChanged

        intLoadPara(7, 0) = setLoadModeRightN.SelectedIndex + 1

        If setLoadModeRightN.SelectedIndex = 0 Then
            realLoadPara(6, 0) = setCurrentLoadRate.Value
            vWall(0, 3) = 0
        ElseIf setLoadModeRightN.SelectedIndex = 1 Then
            vWall(0, 3) = 0
            realLoadPara(6, 0) = setPx.Value
        Else
            realLoadPara(6, 0) = setPx.Value
        End If


    End Sub
    Private Sub setLoadModeRightT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setLoadModeRightT.SelectedIndexChanged


        intLoadPara(8, 0) = setLoadModeRightT.SelectedIndex + 1

        If setLoadModeRightT.SelectedIndex = 0 Then
            vWall(1, 3) = 0
            realLoadPara(7, 0) = setCurrentLoadRate.Value
        ElseIf setLoadModeRightT.SelectedIndex = 1 Then
            vWall(1, 3) = 0
            realLoadPara(7, 0) = setpxy.Value
        Else
            realLoadPara(7, 0) = setpxy.Value
        End If

    End Sub

    Private Sub cbSpecialLoad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSpecialLoad.SelectedIndexChanged
        flagSpecialLoad = cbSpecialLoad.SelectedIndex
    End Sub


    Private Sub updateLoadParams()
        If flagLoadMode = 1 Then
            setLoadModeBottomN.SelectedIndex = intLoadPara(1, iCurStep(1)) - 1
            setLoadModeBottomT.SelectedIndex = intLoadPara(2, iCurStep(1)) - 1
            setLoadModeTopN.SelectedIndex = intLoadPara(3, iCurStep(1)) - 1
            setLoadModeTopT.SelectedIndex = intLoadPara(4, iCurStep(1)) - 1
            setLoadModeLeftN.SelectedIndex = intLoadPara(5, iCurStep(1)) - 1

            setLoadModeLeftT.SelectedIndex = intLoadPara(6, iCurStep(1)) - 1
            setLoadModeRightN.SelectedIndex = intLoadPara(7, iCurStep(1)) - 1
            setLoadModeRightT.SelectedIndex = intLoadPara(8, iCurStep(1)) - 1

            setCurrentLoadRate.Value = 0
            setPx.Value = 0
            setPy.Value = 0
            setpxy.Value = 0

            For i As Integer = 1 To 8
                If intLoadPara(i, iCurStep(1)) = 1 Then
                    setCurrentLoadRate.Value = realLoadPara(i - 1, iCurStep(1))
                End If
            Next

            If intLoadPara(1, iCurStep(1)) > 1 Or intLoadPara(3, iCurStep(1)) > 1 Then
                setPy.Value = Math.Max(realLoadPara(0, iCurStep(1)), realLoadPara(2, iCurStep(1)))
            End If

            If intLoadPara(2, iCurStep(1)) > 1 Or intLoadPara(4, iCurStep(1)) > 1 Or intLoadPara(6, iCurStep(1)) > 1 Or intLoadPara(8, iCurStep(1)) > 1 Then
                setpxy.Value = Math.Max(Math.Max(realLoadPara(1, iCurStep(1)), realLoadPara(3, iCurStep(1))), Math.Max(realLoadPara(5, iCurStep(1)), realLoadPara(7, iCurStep(1))))
            End If
            If intLoadPara(5, iCurStep(1)) > 1 Or intLoadPara(7, iCurStep(1)) > 1 Then
                setPx.Value = Math.Max(realLoadPara(4, iCurStep(1)), realLoadPara(6, iCurStep(1)))
            End If
        End If

    End Sub



    Private Sub btnEleQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEleQuery.Click

        If flagMaskCropOn = 1 Then
            textEleQuery.Text = ""
            textEleQuery.AppendText("Ele, xEle, yEle,mEle, qEle , iniOri   " & Environment.NewLine)
            For i As Integer = 0 To nActEle - 1
                If flagEMask(i) = 1 Then
                    textEleQuery.AppendText((i + 1).ToString("d6") & ",   " & xEle(i).ToString("E04") & ",   " & yEle(i).ToString("E04") & ",  " & mInertEle(i).ToString("E04") & ",   " & qEle(i).ToString("E04") & ",  " & iniOri(i).ToString("E04") & Environment.NewLine)
                End If
            Next
        End If
    End Sub

    Private Sub chkMonitorSystemVariable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMonitorSystemVariable.CheckedChanged
        MonitorSystemVariable.Show()
    End Sub

    Private Sub btnCanvasColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanvasColor.Click
        dlgCanvasColor.Color = Color.Gainsboro
        dlgCanvasColor.ShowDialog()
        If (dlgCanvasColor.ShowDialog() = DialogResult.OK) Then
            canvas.BackColor = dlgCanvasColor.Color
        End If
    End Sub

    Private Sub btnOutput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOutput.Click
        timerTest.Enabled = False
        btnPause.Text = "Resume"

        FileName = ""

        dlgOpenTest.ShowDialog()

        FileName = dlgOpenTest.FileName
        lName = FileName.Length
        If lName > 0 Then
            Call IniOutput(eleOut, eleMaskOut, FileName, lName, curDir, lCurDir)
            btnOutput.Enabled = False
            setOutputFreq.Enabled = True
            iCurStep(3) = 0
            flagOutInied = 1
        End If

    End Sub

    Private Sub chkShowTrace_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowTrace.CheckedChanged
        stepSparse = setStepSparse.Value
        iniSparse = Rnd() * stepSparse
        canvas.Invalidate()
    End Sub

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        timerPlay.Enabled = True
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        timerPlay.Enabled = False
    End Sub

    Private Sub timerPlay_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timerPlay.Tick
        If trackPost.Value < trackPost.Maximum Then
            trackPost.Value += 1
        Else
            timerPlay.Enabled = False
        End If
    End Sub


    Private Sub setFactorSlidContrast_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setFactorSlidContrast.ValueChanged
        factorSlid = setFactorSlidContrast.Value
    End Sub

    Private Sub btnSScaleUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSScaleUp.Click
        SlidScale *= 1.25
        canvas.Invalidate()
    End Sub

    Private Sub btnSScaleDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSScaleDown.Click
        SlidScale *= 0.8
        canvas.Invalidate()
    End Sub

    Private Sub btnAutoSScale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutoSScale.Click
        maxForce = 0
        For iCon As Integer = 0 To nCon - 1
   

            If FxCon(iCon) > maxForce And fricRatio(iCon) > 0.999999 Then
                maxForce = FxCon(iCon)
            End If
            If FyCon(iCon) > maxForce And fricRatio(iCon) > 0.999999 Then
                maxForce = FyCon(iCon)
            End If
        Next

        SlidScale = 5 / maxForce ^ factorSlid
        canvas.Invalidate()

    End Sub

    Private Sub rbForceModeConn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbForceModeConn.CheckedChanged
        canvas.Invalidate()

    End Sub

    Private Sub chkShowSldTrace_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowSldTrace.CheckedChanged

        If chkShowSldTrace.Checked Then
            Call PlotSldTrace(nEle, nActEle, nWall, iStep, jStep, _
                   nStep, xEle, yEle, qEle, rSldTrace, qSldTrace, frSldTrace, normSldTrace, _
                    eleSldTrace, CBSldTrace, nConSldTrace, _
                    x1Wall, x2Wall, y1Wall, y2Wall, nPlotSld, nPlotRol, _
                    xPlotSld, xPlotRol)

        End If

        canvas.Invalidate()

    End Sub

    Private Sub chkShowRollingTrace_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowRollingTrace.CheckedChanged

        If chkShowRollingTrace.Checked = True Then
            Call PlotSldTrace(nEle, nActEle, nWall, iStep, jStep, _
                   nStep, xEle, yEle, qEle, rSldTrace, qSldTrace, frSldTrace, normSldTrace, _
                    eleSldTrace, CBSldTrace, nConSldTrace, _
                    x1Wall, x2Wall, y1Wall, y2Wall, nPlotSld, nPlotRol, _
                    xPlotSld, xPlotRol)

        End If
        canvas.Invalidate()
    End Sub

    Private Sub chkHideElement_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHideElement.CheckedChanged
        chkHideElement2.Checked = chkHideElement.Checked
        canvas.Invalidate()
    End Sub

    Private Sub chkHideElement2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHideElement2.CheckedChanged
        chkHideElement.Checked = chkHideElement2.Checked
        canvas.Invalidate()

    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mainTransparency.Scroll
        Me.Opacity = 1 - mainTransparency.Value / 25
    End Sub


    Private Sub flagShowP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles flagShowP.CheckedChanged
        canvas.Invalidate()
    End Sub

    Private Sub rbPtcForce_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCountorBulk.CheckedChanged
        If rbCountorBulk.Checked = True Then
            iMode = 5
            Call ColorDeform(nEle, nActEle, xEleTrace, yEleTrace, qEleTrace, rangeContour, relaMin, relamax, nStep, iStep, jStep, iMode, jMode, kMode, mMode, TraceRGB, ptcStress, areaEle, iniOri, Ori, refOri, numECon)




        End If
        canvas.Invalidate()

    End Sub

    Private Sub rbPtcStress_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbContourShear.CheckedChanged
        If rbContourShear.Checked = True Then
            iMode = 6
            Call ColorDeform(nEle, nActEle, xEleTrace, yEleTrace, qEleTrace, rangeContour, relaMin, relamax, nStep, iStep, jStep, iMode, jMode, kMode, mMode, TraceRGB, ptcStress, areaEle, iniOri, Ori, refOri, numECon)



        End If
        canvas.Invalidate()

    End Sub

    Private Sub rbGray_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbGray.CheckedChanged
        If rbGray.Checked = True Then
            kMode = 1
            Call ColorDeform(nEle, nActEle, xEleTrace, yEleTrace, qEleTrace, rangeContour, relaMin, relamax, nStep, iStep, jStep, iMode, jMode, kMode, mMode, TraceRGB, ptcStress, areaEle, iniOri, Ori, refOri, numECon)

        End If

        canvas.Invalidate()
    End Sub

    Private Sub rbColor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbColor.CheckedChanged

        If rbColor.Checked Then
            kMode = 0
            Call ColorDeform(nEle, nActEle, xEleTrace, yEleTrace, qEleTrace, rangeContour, relaMin, relamax, nStep, iStep, jStep, iMode, jMode, kMode, mMode, TraceRGB, ptcStress, areaEle, iniOri, Ori, refOri, numECon)

        End If

        canvas.Invalidate()

    End Sub

    Private Sub rbBlack_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbBlack.CheckedChanged
        If rbBlack.Checked Then
            kMode = 2
            Call ColorDeform(nEle, nActEle, xEleTrace, yEleTrace, qEleTrace, rangeContour, relaMin, relamax, nStep, iStep, jStep, iMode, jMode, kMode, mMode, TraceRGB, ptcStress, areaEle, iniOri, Ori, refOri, numECon)

        End If

        canvas.Invalidate()
    End Sub


    Private Sub chkForceByThick_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkForceByThick.CheckedChanged
        canvas.Invalidate()
    End Sub

    Private Sub chkConForceByRadius_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkConForceByRadius.CheckedChanged
        canvas.Invalidate()
    End Sub
    Private Sub rbModeForce_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbModeForce.CheckedChanged
        If rbModeStress.Checked = True Then
            mMode = 0
        Else
            mMode = 1
        End If
        Call ColorDeform(nEle, nActEle, xEleTrace, yEleTrace, qEleTrace, rangeContour, relaMin, relamax, nStep, iStep, jStep, iMode, jMode, kMode, mMode, TraceRGB, ptcStress, areaEle, iniOri, Ori, refOri, numECon)

        canvas.Invalidate()

    End Sub

    Private Sub rbContourXX_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbContourXX.CheckedChanged
        If rbContourXX.Checked = True Then
            iMode = 7
            Call ColorDeform(nEle, nActEle, xEleTrace, yEleTrace, qEleTrace, rangeContour, relaMin, relamax, nStep, iStep, jStep, iMode, jMode, kMode, mMode, TraceRGB, ptcStress, areaEle, iniOri, Ori, refOri, numECon)



        End If
        canvas.Invalidate()

    End Sub

    Private Sub rbContourYY_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbContourYY.CheckedChanged
        If rbContourYY.Checked = True Then
            iMode = 8
            Call ColorDeform(nEle, nActEle, xEleTrace, yEleTrace, qEleTrace, rangeContour, relaMin, relamax, nStep, iStep, jStep, iMode, jMode, kMode, mMode, TraceRGB, ptcStress, areaEle, iniOri, Ori, refOri, numECon)



        End If
        canvas.Invalidate()

    End Sub

    Private Sub rbContourXY_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbContourXY.CheckedChanged
        If rbContourXY.Checked = True Then
            iMode = 9
            Call ColorDeform(nEle, nActEle, xEleTrace, yEleTrace, qEleTrace, rangeContour, relaMin, relamax, nStep, iStep, jStep, iMode, jMode, kMode, mMode, TraceRGB, ptcStress, areaEle, iniOri, Ori, refOri, numECon)



        End If
        canvas.Invalidate()

    End Sub


    Private Sub rbContourOri_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbContourOri.CheckedChanged
        If rbContourOri.Checked = True Then
            iMode = 10
            Call ColorDeform(nEle, nActEle, xEleTrace, yEleTrace, qEleTrace, rangeContour, relaMin, relamax, nStep, iStep, jStep, iMode, jMode, kMode, mMode, TraceRGB, ptcStress, areaEle, iniOri, Ori, refOri, numECon)


        End If
        canvas.Invalidate()

    End Sub

    Private Sub setRefOri_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setRefOri.ValueChanged
        refOri = setRefOri.Value / 180 * Math.PI
        canvas.Invalidate()

    End Sub

    Private Sub rbRelaOri_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRelaOri.CheckedChanged
        If rbRelaOri.Checked = True Then
            iMode = 11
            Call ColorDeform(nEle, nActEle, xEleTrace, yEleTrace, qEleTrace, rangeContour, relaMin, relamax, nStep, iStep, jStep, iMode, jMode, kMode, mMode, TraceRGB, ptcStress, areaEle, iniOri, Ori, refOri, numECon)


        End If
        canvas.Invalidate()

    End Sub

    Private Sub btnIniStnCell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniStnCell.Click
        nActCell = 0
        If rbHomoTri.Checked Then
            If setNumCell.Value > 0 Then

                numCellX = setNumCell.Value
                intvCell = (limitAll(1) - limitAll(0)) / numCellX
                numCellY = (limitAll(3) - limitAll(2)) / (limitAll(1) - limitAll(0)) * numCellX
                numCell = numCellX * numCellY

                ReDim xPt(1, numCell - 1)
                ReDim iEleCell(numCell - 1)
                ReDim eleStnCell(2, numCell - 1)
                ReDim flagEffCell(numCell - 1)
                ReDim strainOut(numCell - 1)
                ReDim drctStn(numCell - 1)
                ReDim areaCell(numCell - 1)


                rStainCell = setRdStnCell.Value

                iCell = 0
                For iCellY As Integer = 0 To numCellY - 1
                    For iCellX As Integer = 0 To numCellX - 1

                        xPt(0, iCell) = limitAll(0) + intvCell / 2 + iCellX * intvCell
                        xPt(1, iCell) = limitAll(2) + intvCell / 2 + iCellY * intvCell
                        iCell += 1

                    Next


                Next
                Call AutoCellCenter(numCell, xPt, iEleCell, nEle, xEle, yEle, limitAll, xGrid, nGridX, _
                                     nGridY, nEleGrid, lEG, maxNEleGrid, flagEffCell)

                Call IniStrainCell(numCell, iEleCell, rStainCell, nEle, xEle, yEle, areaEle, _
                      limitAll, xGrid, nGridX, nGridY, nEleGrid, lEG, maxNEleGrid, eleStnCell, _
                     eleBuffer, nEleTop, wgtBuffer, flagEffCell)



                chkShowCell.Checked = True
            End If
        Else

            numCell = nEle * 3
            ' for strain cells, we know how many we are making before making them.  For Delaunay triangles, we don't know.  Numcell is passed into dll and used for declaration of array demensions.
            ' we actually use flagEffCell to judge whether this cell is used or not

            ReDim eleStnCell(2, numCell - 1)
            ReDim flagEffCell(nEle * 3 - 1)
            ReDim strainOut(numCell - 1)
            ReDim drctStn(numCell - 1)
            ReDim areaCell(numCell - 1)

            ReDim xEffEle(nEle - 1, 1)
            ReDim iNdStn(nEle - 1)
            ReDim TILStn(nEle * 2 - 1, 2)
            ReDim TNBRStn(nEle * 2 - 1, 2)
            ReDim mapEffEle(nEle - 1)
            ReDim nConPEleStn(nEle - 1)


            Call StrainDelaunay(nEle, nActEle, xEle, yEle, nCon, pairCon, flagConBoun, _
                                numCell, eleStnCell, flagEffCell, _
                                nEffEle, xEffEle, iNdStn, TILStn, TNBRStn, mapEffEle, nConPEleStn)

            'Call IniDelaunay(nEle, nActEle, xEle, yEle, numCell, eleStnCell, flagEffCell, _
            '       nVMax, nFMax, nHMax, nKMax, nJMax, nPMax, _
            '       iXTemp, iYTemp, iX2Temp, iY2Temp, iSSTemp, iConTemp, iDTemp, iAveTemp, iAzeTemp)

            'Dim nVMax As Integer = nEle * 3
            'Dim nFMax As Integer = nEle
            'Dim nHMax As Integer = nEle
            'Dim nKMax As Integer = nEle
            'Dim nJMax As Integer = nEle
            'Dim nPMax As Integer = nEle
            'Dim iXTemp() As Integer = New Integer(nEle - 1) {}
            'Dim iYTemp() As Integer = New Integer(nEle - 1) {}
            'Dim iX2Temp() As Integer = New Integer(nEle - 1) {}
            'Dim iY2Temp() As Integer = New Integer(nEle - 1) {}
            'Dim iSSTemp() As Integer = New Integer(nEle - 1) {}
            'Dim iConTemp(,) As Integer = New Integer(nVMax - 1, 5) {}
            'Dim iDTemp() As Integer = New Integer(nVMax - 1) {}
            'Dim iAveTemp() As Integer = New Integer(nJMax - 1) {}
            'Dim iAzeTemp() As Integer = New Integer(nKMax - 1) {}

            'numCell = nVMax

            'ReDim eleStnCell(2, nVMax - 1)
            'ReDim flagEffCell(nVMax - 1)
            ''This call only gets the number of cells
            'Call IniDelaunay(nEle, nActEle, xEle, yEle, numCell, eleStnCell, flagEffCell, _
            '                   nVMax, nFMax, nHMax, nKMax, nJMax, nPMax, _
            '                   iXTemp, iYTemp, iX2Temp, iY2Temp, iSSTemp, iConTemp, iDTemp, iAveTemp, iAzeTemp)

            'nVMax = numCell
            'ReDim xPt(1, numCell - 1)
            'ReDim iEleCell(numCell - 1)
            'ReDim eleStnCell(2, numCell - 1)
            'ReDim flagEffCell(numCell - 1)
            'ReDim strainOut(numCell - 1)
            'ReDim drctStn(numCell - 1)
            'ReDim iConTemp(numCell - 1, 5)
            'ReDim iDTemp(numCell - 1)
            'Call IniDelaunay(nEle, nActEle, xEle, yEle, numCell, eleStnCell, flagEffCell, _
            '       nVMax, nFMax, nHMax, nKMax, nJMax, nPMax, _
            '       iXTemp, iYTemp, iX2Temp, iY2Temp, iSSTemp, iConTemp, iDTemp, iAveTemp, iAzeTemp)

        End If

        canvas.Invalidate()


    End Sub

    Private Sub btnScaleUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStnScaleUp.Click
        scaleStnOut *= 1.2
        canvas.Invalidate()

    End Sub

    Private Sub btnScaleDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStnScaleDown.Click
        scaleStnOut /= 1.2
        canvas.Invalidate()
    End Sub

    Private Sub chkShowStrain_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowStrain.CheckedChanged
        If chkShowStrain.Checked = True Or chkShowStnDrct.Checked = True Or chkShwStrnVal.Checked = True Then
            Call StrainCell(nEle, xEleTrace, yEleTrace, vxEle, vyEle, _
            nStep, iStep, jStep, strainOut, drctStn, areaCell, numCell, eleStnCell, _
            flagEffCell, flagStnOut, flagDrctStnOut, flagStnMode, angN)
        End If
        canvas.Invalidate()
    End Sub

    Private Sub rbStrainV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbStrainV.CheckedChanged
        If rbStrainV.Checked = True Then
            flagStnOut = 0
        End If
        UpdateStrain()
    End Sub

    Private Sub rbStrainXX_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbStrainXX.CheckedChanged
        If rbStrainXX.Checked = True Then
            flagStnOut = 1
        End If
        UpdateStrain()
    End Sub

    Private Sub rbStrainYY_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbStrainYY.CheckedChanged
        If rbStrainYY.Checked = True Then
            flagStnOut = 2
        End If
        UpdateStrain()
    End Sub

    Private Sub rbStrainXY_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbStrainXY.CheckedChanged
        If rbStrainXY.Checked = True Then
            flagStnOut = 3
        End If
        UpdateStrain()
    End Sub

    Private Sub rbStrainI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbStrainI.CheckedChanged
        If rbStrainI.Checked = True Then
            flagStnOut = 4
        End If
        UpdateStrain()
    End Sub

    Private Sub rbStrainII_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbStrainII.CheckedChanged
        If rbStrainII.Checked = True Then
            flagStnOut = 5
        End If
        UpdateStrain()
    End Sub

    Private Sub rbStrainXYMax_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbStrainXYMax.CheckedChanged
        If rbStrainXYMax.Checked = True Then
            flagStnOut = 6
        End If
        UpdateStrain()
    End Sub

    Private Sub rbStrainN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbStrainN.CheckedChanged
        If rbStrainN.Checked = True Then
            flagStnOut = 7
        End If
        UpdateStrain()
    End Sub

    Private Sub rbStrainXYN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbStrainXYN.CheckedChanged
        If rbStrainXYN.Checked = True Then
            flagStnOut = 8
        End If
        UpdateStrain()
    End Sub

    Private Sub rbShearFlowRate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbShearFlowRate.CheckedChanged
        If rbShearFlowRate.Checked Then
            flagStnOut = 9
        End If
        UpdateStrain()
    End Sub
    Private Sub rbSpinTensor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSpinTensor.CheckedChanged
        If rbSpinTensor.Checked Then
            flagStnOut = 10
        End If
        UpdateStrain()

    End Sub

    Private Sub setAngN_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setAngN.ValueChanged
        angN = setAngN.Value / 180 * Math.PI
        UpdateStrain()
    End Sub

    Private Sub btnStnDrctScaleUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStnDrctScaleUp.Click
        scaleStnDrct *= 1.2
        canvas.Invalidate()
    End Sub

    Private Sub btnStnDrctScaleDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStnDrctScaleDown.Click
        scaleStnDrct /= 1.2
        canvas.Invalidate()
    End Sub

    Private Sub chkShowStnDrct_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowStnDrct.CheckedChanged
        UpdateStrain()

    End Sub

    Private Sub rbShowBothStn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbShowBothStn.CheckedChanged
        canvas.Invalidate()

    End Sub

    Private Sub rbShowPosiStn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbShowPosiStn.CheckedChanged
        canvas.Invalidate()
    End Sub

    Private Sub chkLgthStrn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLgthStrn.CheckedChanged
        canvas.Invalidate()
    End Sub

    Private Sub setStnContrast_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setStnContrast.ValueChanged
        stnContrast = setStnContrast.Value
        canvas.Invalidate()
    End Sub

    Private Sub setValLegend_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setValLegend.ValueChanged
        valLegend = setValLegend.Value
        canvas.Invalidate()

    End Sub

    Private Sub chkShowCell_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowCell.CheckedChanged
        canvas.Invalidate()
    End Sub

    Private Sub chkShowStnLegend_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowStnLegend.CheckedChanged
        canvas.Invalidate()
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanvas2File.Click

        SaveSnapshot.Filter = "Tiff Image (*.tif)|*.tiff|All files (*.*)|*.*"
        SaveSnapshot.ShowDialog()
        FileName = SaveSnapshot.FileName

        Call SaveImg(FileName, "TIF")





    End Sub
    Private Sub subDrawCellInEle(ByRef graphObj As Graphics)
        If chkShowSolidCell.Checked Then
            For iCell As Integer = 0 To nCellinEle - 1
                For iPt As Integer = 0 To 2
                    triangleCell(iPt) = New Point(X2Scr(xCon(iConCellInEle(iPt, iCell) - 1)), _
                                            Y2Scr(yCon(iConCellInEle(iPt, iCell) - 1)))
                    graphObj.DrawLine(Pens.Red, X2Scr(xCon(iConCellInEle(iPt, iCell) - 1)), Y2Scr(yCon(iConCellInEle(iPt, iCell) - 1)), _
                      X2Scr(xCon(iConCellInEle((iPt + 1) Mod 3, iCell) - 1)), Y2Scr(yCon(iConCellInEle((iPt + 1) Mod 3, iCell) - 1)))

                Next



                graphObj.FillPolygon(Brushes.Green, triangleCell)

            Next
        End If

        If chkShowCellInEle.Checked Then
            Dim penThick As Pen = New Pen(Color.DarkRed, 3)
            Dim brushRand As SolidBrush

            For iCell As Integer = 0 To nTriAllCon - 1
                If fgDeadTri(iCell) = 0 And fgSolidCell(iCell) = 0 Then
                    If nCellVC(iVCCell(iCell) - 1) < 25 Then

                        triangleCell(0) = New Point(X2Scr(xEffCon(0, iEConTriAllCon(0, iCell) - 1)), Y2Scr(xEffCon(1, iEConTriAllCon(0, iCell) - 1)))
                        triangleCell(1) = New Point(X2Scr(xEffCon(0, iEConTriAllCon(1, iCell) - 1)), Y2Scr(xEffCon(1, iEConTriAllCon(1, iCell) - 1)))
                        triangleCell(2) = New Point(X2Scr(xEffCon(0, iEConTriAllCon(2, iCell) - 1)), Y2Scr(xEffCon(1, iEConTriAllCon(2, iCell) - 1)))
                        If fgSolidCell(iCell) = 1 Then
                            brushRand = New SolidBrush(Color.FromArgb(opacityCell, 255, 255, 255))
                        Else
                            brushRand = New SolidBrush(Color.FromArgb(opacityCell, VCColor(iVCCell(iCell) - 1, 0), VCColor(iVCCell(iCell) - 1, 1), VCColor(iVCCell(iCell) - 1, 2)))

                        End If
                        'Dim brushRand As SolidBrush = New SolidBrush(Color.FromArgb(120, randNum.Next(50, 250), randNum.Next(30, 230), randNum.Next(20, 210)))

                        graphObj.FillPolygon(brushRand, triangleCell)

                    End If


                End If
            Next

            If chkExtVC.Checked Then
                For iVC As Integer = 0 To nVC - 1
                    brushRand = New SolidBrush(Color.FromArgb(opacityCell, VCColor(iVC, 0), VCColor(iVC, 1), VCColor(iVC, 2)))

                    For iTri As Integer = 0 To nSldTriPVC(iVC) - 1
                        triangleCell(0) = New Point(X2Scr(xSldCell(0, iEConSldTri(0, iTri, iVC) - 1)), Y2Scr(xSldCell(1, iEConSldTri(0, iTri, iVC) - 1)))
                        triangleCell(1) = New Point(X2Scr(xEffCon(0, iEConSldTri(1, iTri, iVC) - 1)), Y2Scr(xEffCon(1, iEConSldTri(1, iTri, iVC) - 1)))
                        triangleCell(2) = New Point(X2Scr(xEffCon(0, iEConSldTri(2, iTri, iVC) - 1)), Y2Scr(xEffCon(1, iEConSldTri(2, iTri, iVC) - 1)))
                        graphObj.FillPolygon(brushRand, triangleCell)
                        graphObj.DrawLine(Pens.DarkGreen, triangleCell(0), triangleCell(1))
                        'graphObj.DrawLine(Pens.DarkGreen, triangleCell(1), triangleCell(2))
                        graphObj.DrawLine(Pens.DarkGreen, triangleCell(2), triangleCell(0))

                    Next
                Next
            End If
        End If

        If chkShowVoidVector.Checked Then
            Dim penVV As Pen = New Pen(Color.Red, 2)
            For iVC As Integer = 0 To nVC - 1
                If fgBndVC(iVC) = 0 Then
                    For iPt As Integer = 0 To nEConVC(iVC) - 1
                        graphObj.DrawLine(penVV, X2Scr(xVC(0, iVC)), Y2Scr(xVC(1, iVC)), _
                                          X2Scr(xEffCon(0, iEConVC(iPt, iVC) - 1)), Y2Scr(xEffCon(1, iEConVC(iPt, iVC) - 1)))
                    Next
                End If
            Next

        End If


        If chkShowCellNum.Checked Then
            For iCell As Integer = 0 To nTriAllCon - 1
                If fgDeadTri(iCell) = 0 Then
                    graphObj.DrawString((iCell + 1).ToString, Me.Font, Brushes.DarkGreen, _
                                          X2Scr((xEffCon(0, iEConTriAllCon(0, iCell) - 1) + xEffCon(0, iEConTriAllCon(1, iCell) - 1) + xEffCon(0, iEConTriAllCon(2, iCell) - 1)) / 3) - (iCell + 1).ToString.Length * Me.FontHeight / 3, _
                                          Y2Scr((xEffCon(1, iEConTriAllCon(0, iCell) - 1) + xEffCon(1, iEConTriAllCon(1, iCell) - 1) + xEffCon(1, iEConTriAllCon(2, iCell) - 1)) / 3) - Me.FontHeight / 2)
                    graphObj.DrawLine(Pens.Gray, _
                                      X2Scr((xEffCon(0, iEConTriAllCon(0, iCell) - 1) + xEffCon(0, iEConTriAllCon(1, iCell) - 1) + xEffCon(0, iEConTriAllCon(2, iCell) - 1)) / 3), _
                                      Y2Scr((xEffCon(1, iEConTriAllCon(0, iCell) - 1) + xEffCon(1, iEConTriAllCon(1, iCell) - 1) + xEffCon(1, iEConTriAllCon(2, iCell) - 1)) / 3), _
                                      X2Scr((xEffCon(0, iEConTriAllCon(0, iCell) - 1))), _
                                      Y2Scr((xEffCon(1, iEConTriAllCon(0, iCell) - 1))))
                    graphObj.DrawLine(Pens.Gray, _
                                      X2Scr((xEffCon(0, iEConTriAllCon(0, iCell) - 1) + xEffCon(0, iEConTriAllCon(1, iCell) - 1) + xEffCon(0, iEConTriAllCon(2, iCell) - 1)) / 3), _
                                      Y2Scr((xEffCon(1, iEConTriAllCon(0, iCell) - 1) + xEffCon(1, iEConTriAllCon(1, iCell) - 1) + xEffCon(1, iEConTriAllCon(2, iCell) - 1)) / 3), _
                                      X2Scr((xEffCon(0, iEConTriAllCon(1, iCell) - 1))), _
                                      Y2Scr((xEffCon(1, iEConTriAllCon(1, iCell) - 1))))
                    graphObj.DrawLine(Pens.Gray, _
                                      X2Scr((xEffCon(0, iEConTriAllCon(0, iCell) - 1) + xEffCon(0, iEConTriAllCon(1, iCell) - 1) + xEffCon(0, iEConTriAllCon(2, iCell) - 1)) / 3), _
                                      Y2Scr((xEffCon(1, iEConTriAllCon(0, iCell) - 1) + xEffCon(1, iEConTriAllCon(1, iCell) - 1) + xEffCon(1, iEConTriAllCon(2, iCell) - 1)) / 3), _
                                      X2Scr((xEffCon(0, iEConTriAllCon(2, iCell) - 1))), _
                                      Y2Scr((xEffCon(1, iEConTriAllCon(2, iCell) - 1))))

                End If
            Next
        End If


        If chkShowEffEdge.Checked Then
            Dim penThick As Pen = New Pen(Color.DarkRed, 3)

            For iEdge As Integer = 0 To nEdgeAll - 1
                If fgEffEdge(iEdge) = 0 Then
                    graphObj.DrawLine(Pens.DarkRed, X2Scr(xEffCon(0, iPtEdge(0, iEdge) - 1)), Y2Scr(xEffCon(1, iPtEdge(0, iEdge) - 1)), _
                    X2Scr(xEffCon(0, iPtEdge(1, iEdge) - 1)), Y2Scr(xEffCon(1, iPtEdge(1, iEdge) - 1)))
                Else
                    graphObj.DrawLine(penThick, X2Scr(xEffCon(0, iPtEdge(0, iEdge) - 1)), Y2Scr(xEffCon(1, iPtEdge(0, iEdge) - 1)), _
                    X2Scr(xEffCon(0, iPtEdge(1, iEdge) - 1)), Y2Scr(xEffCon(1, iPtEdge(1, iEdge) - 1)))

                End If

                If chkShowEdgeNum.Checked Then
                    graphObj.DrawString((iEdge + 1).ToString, Me.Font, Brushes.Black, _
                                          X2Scr((xEffCon(0, iPtEdge(0, iEdge) - 1) + xEffCon(0, iPtEdge(1, iEdge) - 1)) / 2) - 8, _
                                        Y2Scr((xEffCon(1, iPtEdge(0, iEdge) - 1) + xEffCon(1, iPtEdge(1, iEdge) - 1)) / 2) - 18)
                End If
            Next

        End If

        If chkShowEdgeNum.Checked Then
            For iEdge As Integer = 0 To nDlnBound - 1
                graphObj.FillRectangle(Brushes.White, X2Scr(xCon(iConDlnBound(0, iEdge) - 1) / 2 + xCon(iConDlnBound(1, iEdge) - 1) / 2) - 8, _
                      Y2Scr(yCon(iConDlnBound(0, iEdge) - 1) / 2 + yCon(iConDlnBound(1, iEdge) - 1) / 2) - 4, 20, 14)

                graphObj.DrawString((iEdge + 1).ToString, Me.Font, Brushes.Coral, _
                                      X2Scr(xCon(iConDlnBound(0, iEdge) - 1) / 2 + xCon(iConDlnBound(1, iEdge) - 1) / 2) - 8, _
                                      Y2Scr(yCon(iConDlnBound(0, iEdge) - 1) / 2 + yCon(iConDlnBound(1, iEdge) - 1) / 2) - 4)

            Next
        End If

        If chkShowVCNum.Checked Then
            For iVC As Integer = 0 To nVC - 1
                If fgBndVC(iVC) = 0 Then
                    graphObj.DrawString((iVC + 1).ToString, Me.Font, Brushes.DarkOliveGreen, X2Scr(xVC(0, iVC)) - 8, Y2Scr(xVC(1, iVC)) - 8)
                Else
                    graphObj.DrawString((iVC + 1).ToString, Me.Font, Brushes.Red, X2Scr(xVC(0, iVC)) - 8, Y2Scr(xVC(1, iVC)) - 8)
                End If
            Next
        End If

        If chkShowVCBound.Checked Then
            Dim penThick As Pen = New Pen(Color.White, 2)

            For iEdge As Integer = 0 To nEdgeAll - 1
                If fgBridgeEdge(iEdge) = 1 Then
                    graphObj.DrawLine(penThick, X2Scr(xEffCon(0, iPtEdge(0, iEdge) - 1)), Y2Scr(xEffCon(1, iPtEdge(0, iEdge) - 1)), _
                    X2Scr(xEffCon(0, iPtEdge(1, iEdge) - 1)), Y2Scr(xEffCon(1, iPtEdge(1, iEdge) - 1)))

                End If

            Next

            For iVC As Integer = 0 To nVC - 1

                For iTri As Integer = 0 To nSldTriPVC(iVC) - 1
                    triangleCell(0) = New Point(X2Scr(xSldCell(0, iEConSldTri(0, iTri, iVC) - 1)), Y2Scr(xSldCell(1, iEConSldTri(0, iTri, iVC) - 1)))
                    triangleCell(1) = New Point(X2Scr(xEffCon(0, iEConSldTri(1, iTri, iVC) - 1)), Y2Scr(xEffCon(1, iEConSldTri(1, iTri, iVC) - 1)))
                    triangleCell(2) = New Point(X2Scr(xEffCon(0, iEConSldTri(2, iTri, iVC) - 1)), Y2Scr(xEffCon(1, iEConSldTri(2, iTri, iVC) - 1)))

                    graphObj.DrawLine(penThick, triangleCell(0), triangleCell(1))
                    graphObj.DrawLine(penThick, triangleCell(2), triangleCell(0))

                Next
            Next

        End If


        'For iPt As Integer = 0 To nEffCon - 1
        '    graphObj.DrawString(iEleEffCon(0, iPt).ToString & "," & iEleEffCon(1, iPt).ToString, Me.Font, Brushes.Blue, _
        '             X2Scr(xEffCon(0, iPt)) - 15, Y2Scr(xEffCon(1, iPt)) - 8)

        'Next

        'If rbShowOriCell.Checked Then
        '    For iCell As Integer = 0 To nTriAllCon - 1
        '        For iPt As Integer = 0 To 2
        '            graphObj.DrawLine(Pens.Blue, X2Scr(xCon(iConTriAllCon(iPt, iCell) - 1)), Y2Scr(yCon(iConTriAllCon(iPt, iCell) - 1)), _
        '                                  X2Scr(xCon(iConTriAllCon((iPt + 1) Mod 3, iCell) - 1)), Y2Scr(yCon(iConTriAllCon((iPt + 1) Mod 3, iCell) - 1)))
        '        Next
        '    Next
        'Else
        '    For iCell As Integer = 0 To nNewCell - 1
        '        For iPt As Integer = 0 To 2
        '            graphObj.DrawLine(Pens.Orange, X2Scr(xEffCon(0, iEffConNewCell(iPt, iCell) - 1)), Y2Scr(xEffCon(1, iEffConNewCell(iPt, iCell) - 1)), _
        '                                  X2Scr(xEffCon(0, iEffConNewCell((iPt + 1) Mod 3, iCell) - 1)), Y2Scr(xEffCon(1, iEffConNewCell((iPt + 1) Mod 3, iCell) - 1)))
        '        Next

        '    Next

        'End If

        'For iCell As Integer = 0 To nCellInEle - 1
        '    For iPt As Integer = 0 To 2
        '        triangleCell(iPt) = New Point(X2Scr(xCon(iConCellInEle(iPt, iCell) - 1)), _
        '                                Y2Scr(yCon(iConCellInEle(iPt, iCell) - 1)))
        '        graphObj.DrawLine(Pens.Red, X2Scr(xCon(iConCellInEle(iPt, iCell) - 1)), Y2Scr(yCon(iConCellInEle(iPt, iCell) - 1)), _
        '          X2Scr(xCon(iConCellInEle((iPt + 1) Mod 3, iCell) - 1)), Y2Scr(yCon(iConCellInEle((iPt + 1) Mod 3, iCell) - 1)))

        '    Next




        'Next


    End Sub


    Private Sub subDrawContNum(ByRef graphObj As Graphics)
        For iCon As Integer = 0 To nEffCon - 1


            graphObj.DrawString((iCon + 1).ToString, Me.Font, Brushes.BlueViolet, _
                                X2Scr(xEffCon(0, iCon)) - 15, Y2Scr(xEffCon(1, iCon)) - 8)



        Next

    End Sub

    ''Draw objects on canvas



    Private Sub subDrawGrid(ByRef graphObj As Graphics)
        Dim xLeft As Single = limitAll(0) * zoomScale + xOrigin
        Dim xRight As Single = (limitAll(0) + xGrid * nGridX) * zoomScale + xOrigin
        Dim yBot As Single = canvasContainer.Height - limitAll(2) * zoomScale + yOrigin
        Dim yTop As Single = canvasContainer.Height - (limitAll(2) + xGrid * nGridY) * zoomScale + yOrigin

        For iLine As Integer = 0 To nGridY
            graphObj.DrawLine(Pens.DarkGreen, xLeft, canvas.Height - Convert.ToSingle((iLine * xGrid + limitAll(2)) * zoomScale) + yOrigin, xRight, canvas.Height - Convert.ToSingle((iLine * xGrid + limitAll(2)) * zoomScale) + yOrigin)
        Next
        For iLine As Integer = 0 To nGridX
            graphObj.DrawLine(Pens.DarkGreen, Convert.ToSingle((limitAll(0) + iLine * xGrid) * zoomScale) + xOrigin, yBot, Convert.ToSingle((limitAll(0) + iLine * xGrid) * zoomScale) + xOrigin, yTop)
        Next

    End Sub

    Private Sub subDrawMotion(ByRef graphObj As Graphics, ByRef nEleV As Integer, ByRef eleView() As Integer)

        Dim i As Integer

        Dim distPL As Single


        If chkDefContour.Checked = True Then

            For iEle As Integer = 0 To nEleV - 1
                i = eleView(iEle) - 1


                If rbDyeBand.Checked Then

                    distPL = Math.Abs(xDyeRef(0) * (0 - yEleTrace(jStep - 1, i)) - (0 - xEleTrace(jStep - 1, i)) * xDyeRef(1))

                    If Convert.ToInt32(distPL / setIntvlDye.Value) Mod 2 = 0 Then
                        brushContour.Color = Color.FromArgb(setDyeDark.Value, setDyeDark.Value, setDyeDark.Value)
                    Else
                        brushContour.Color = Color.FromArgb(255, 255, 255)
                    End If

                ElseIf rbDyeGrid.Checked Then

                    If flagDyeGrid(i) = 1 Then
                        brushContour.Color = Color.FromArgb(setDyeDark.Value, setDyeDark.Value, setDyeDark.Value)
                    Else
                        brushContour.Color = Color.FromArgb(255, 255, 255)
                    End If

                Else

                    brushContour.Color = Color.FromArgb(TraceRGB(0, i), TraceRGB(1, i), TraceRGB(2, i))

                End If


                If nVertex(i) = 0 Then
                    graphObj.FillEllipse(brushContour, Convert.ToSingle((xEle(i) - rEle(i)) * zoomScale) + xOrigin, _
                    canvasContainer.Height - Convert.ToSingle((yEle(i) + rEle(i)) * zoomScale) + yOrigin, _
                    Convert.ToSingle(2 * rEle(i) * zoomScale), _
                    Convert.ToSingle(2 * rEle(i) * zoomScale))

                Else
                    'ReDim PolyPath(nVertex(i) - 1)
                    'For j As Integer = 0 To nVertex(i) - 1
                    ' polypath(j).X = xVertex(j, i) * zoomScale + xOrigin
                    'polypath(j).Y = canvasContainer.Height - yVertex(j, i) * zoomScale + yOrigin
                    'Next

                    Dim polyPath As New System.Drawing.Drawing2D.GraphicsPath

                    For j As Integer = 0 To nVertex(i) - 1
                        polyPath.AddArc(Convert.ToSingle((xCE(0, j, i) - rqCE(2, j, i)) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((xCE(1, j, i) + rqCE(2, j, i))) * zoomScale) + yOrigin, Convert.ToSingle(2 * rqCE(2, j, i) * zoomScale), Convert.ToSingle(2 * rqCE(2, j, i) * zoomScale), Convert.ToSingle(-rqCE(3, j, i) / 3.14159 * 180), Convert.ToSingle(-CAC(j, i) / 3.14159 * 180))
                    Next

                    graphObj.FillPath(brushContour, polyPath)
                End If


            Next



        End If

        If chkShowRotation.Checked = True Then

            For iEle As Integer = 0 To nEleV - 1
                i = eleView(iEle) - 1
                If qEleTrace(jStep - 1, i) > qEleTrace(iStep - 1, i) Then
                    brushRotation = Brushes.DarkSalmon
                Else
                    brushRotation = Brushes.Blue
                End If
                graphObj.FillEllipse(brushRotation, Convert.ToSingle((xEle(i) * zoomScale - (qEleTrace(jStep - 1, i) - qEleTrace(iStep - 1, i)) * rotationScale)) + xOrigin, _
                canvasContainer.Height - Convert.ToSingle((yEle(i) * zoomScale + (qEleTrace(jStep - 1, i) - qEleTrace(iStep - 1, i)) * rotationScale)) + yOrigin, _
                Convert.ToSingle(2 * (qEleTrace(jStep - 1, i) - qEleTrace(iStep - 1, i)) * rotationScale), _
                Convert.ToSingle(2 * (qEleTrace(jStep - 1, i) - qEleTrace(iStep - 1, i)) * rotationScale))

            Next



        End If


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''   Draw Particle Trace   '''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


        If chkShowTrace.Checked = True Then


            For iEle As Integer = iniSparse To nEleV - 1 Step stepSparse
                i = eleView(iEle) - 1

                If chkColorTrace.Checked = True Then
                    If rbH.Checked = True Then
                        If xEleTrace(iStep - 1, i) > xEleTrace(jStep - 1, i) Then
                            penTrace = penRed
                        Else
                            penTrace = penBlue
                        End If
                    Else
                        If yEleTrace(iStep - 1, i) > yEleTrace(jStep - 1, i) Then
                            penTrace = penRed
                        Else
                            penTrace = penBlue
                        End If

                    End If
                Else
                    penTrace = Pens.DarkRed
                End If


                For j As Integer = Math.Min(iStep, jStep) To Math.Max(iStep, jStep) - 1
                    graphObj.DrawLine(penTrace, Convert.ToSingle(xEleTrace(j - 1, i) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((yEleTrace(j - 1, i)) * zoomScale) + yOrigin, Convert.ToSingle(xEleTrace(j, i) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((yEleTrace(j, i)) * zoomScale) + yOrigin)
                Next


            Next






            iEle = actEle
            For j As Integer = Math.Min(iStep, jStep) To Math.Max(iStep, jStep) - 1
                graphObj.DrawLine(penActWall, Convert.ToSingle(xEleTrace(j - 1, iEle) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((yEleTrace(j - 1, iEle)) * zoomScale) + yOrigin, Convert.ToSingle(xEleTrace(j, iEle) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((yEleTrace(j, iEle)) * zoomScale) + yOrigin)
            Next

        End If


    End Sub


    Private Sub subDrawElement(ByRef graphObj As Graphics, ByRef nEleV As Integer, ByRef eleView() As Integer)

        Dim i As Integer
        For iEle As Integer = 0 To nEleV - 1
            i = eleView(iEle) - 1


            If chkShowEleNum.Checked = True Then
                graphObj.DrawString((i + 1).ToString, Me.Font, Brushes.Brown, Convert.ToSingle(xEle(i) * zoomScale) + xOrigin - 15, canvasContainer.Height - Convert.ToSingle((yEle(i)) * zoomScale) + yOrigin - 8)

            End If

            penAct = pen
            If (flagMaskCropOn = 1 And flagEMask(i) = 1) Then    'Or (modeHist.Checked = True And flagEMask(i) = 1)
                penAct = penHL
            End If

            If nVertex(i) = 0 Then
                graphObj.DrawEllipse(penAct, Convert.ToSingle((xEle(i) - rEle(i)) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((yEle(i) + rEle(i))) * zoomScale) + yOrigin, Convert.ToSingle(2 * rEle(i) * zoomScale), Convert.ToSingle(2 * rEle(i) * zoomScale))
            Else
                For j As Integer = 0 To nVertex(i) - 1

                    If flagEditEle = 1 Or flagEditVertex = 1 Or flagEleRotate = 1 Or showLine.Checked = True Then
                        graphObj.DrawLine(penAct, Convert.ToSingle(xVertex(j, i) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((yVertex(j, i)) * zoomScale) + yOrigin, Convert.ToSingle(xVertex(j + 1, i) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((yVertex(j + 1, i)) * zoomScale) + yOrigin)

                    End If

                    'graphObj.DrawEllipse(pen, Convert.ToSingle(xEle(i) - rEle(i)), canvasContainer.Height - Convert.ToSingle(yEle(i) + rEle(i)), Convert.ToSingle(2 * rEle(i)), Convert.ToSingle(2 * rEle(i)))
                    If showARC.Checked = True Then
                        graphObj.DrawArc(penAct, Convert.ToSingle((xCE(0, j, i) - rqCE(2, j, i)) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((xCE(1, j, i) + rqCE(2, j, i))) * zoomScale) + yOrigin, Convert.ToSingle(2 * rqCE(2, j, i) * zoomScale), Convert.ToSingle(2 * rqCE(2, j, i) * zoomScale), Convert.ToSingle(-rqCE(3, j, i) / 3.14159 * 180), Convert.ToSingle(-CAC(j, i) / 3.14159 * 180))

                    End If
                Next

            End If

        Next

#If 1 = 0 Then
        For iEle As Integer = 0 To nActEle - 1
            If nVertex(iEle) = 0 Then
                graphObj.DrawEllipse(penAct, Convert.ToSingle((RxEle(iEle) - rEle(iEle)) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((RyEle(iEle) + rEle(iEle))) * zoomScale) + yOrigin, Convert.ToSingle(2 * rEle(iEle) * zoomScale), Convert.ToSingle(2 * rEle(iEle) * zoomScale))
            Else
                For j As Integer = 0 To nVertex(iEle) - 1
                    graphObj.DrawLine(penAct, Convert.ToSingle(RxVertex(j, iEle) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((RyVertex(j, iEle)) * zoomScale) + yOrigin, Convert.ToSingle(RxVertex(j + 1, iEle) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((RyVertex(j + 1, iEle)) * zoomScale) + yOrigin)

                Next
            End If
        Next

#End If



        ''''''''''''''''''''''''''
        '' Draw the active element

        i = actEle
        If nVertex(actEle) = 0 Then
            graphObj.DrawEllipse(penHL, Convert.ToSingle((xEle(i) - rEle(i)) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((yEle(i) + rEle(i))) * zoomScale) + yOrigin, Convert.ToSingle(2 * rEle(i) * zoomScale), Convert.ToSingle(2 * rEle(i) * zoomScale))

        Else
            For j As Integer = 0 To nVertex(i) - 1

                If showARC.Checked = True Then
                    graphObj.DrawArc(penHL, Convert.ToSingle((xCE(0, j, i) - rqCE(2, j, i)) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((xCE(1, j, i) + rqCE(2, j, i))) * zoomScale) + yOrigin, Convert.ToSingle(2 * rqCE(2, j, i) * zoomScale), Convert.ToSingle(2 * rqCE(2, j, i) * zoomScale), Convert.ToSingle(-rqCE(3, j, i) / 3.14159 * 180), Convert.ToSingle(-CAC(j, i) / 3.14159 * 180))

                End If
            Next
        End If


        '''''''''''''''''''''
        '' Draw the discrete mask

        If nEleDiscMask > 0 And chkShwDiscMask.Checked = True Then

            For iEle As Integer = 0 To nEleDiscMask - 1
                i = eleDiscMask(iEle)

                If nVertex(i) = 0 Then
                    graphObj.DrawEllipse(Pens.Red, Convert.ToSingle((xEle(i) - rEle(i)) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((yEle(i) + rEle(i))) * zoomScale) + yOrigin, Convert.ToSingle(2 * rEle(i) * zoomScale), Convert.ToSingle(2 * rEle(i) * zoomScale))
                Else
                    For j As Integer = 0 To nVertex(i) - 1

                        graphObj.DrawArc(Pens.Red, Convert.ToSingle((xCE(0, j, i) - rqCE(2, j, i)) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((xCE(1, j, i) + rqCE(2, j, i))) * zoomScale) + yOrigin, Convert.ToSingle(2 * rqCE(2, j, i) * zoomScale), Convert.ToSingle(2 * rqCE(2, j, i) * zoomScale), Convert.ToSingle(-rqCE(3, j, i) / 3.14159 * 180), Convert.ToSingle(-CAC(j, i) / 3.14159 * 180))

                    Next

                End If

            Next

        End If




        If flagMaskCropOn = 1 Then
            graphObj.FillRectangle(brushMask, 15, 15, 200, 30)
            graphObj.DrawString(nEleMasked.ToString & " elements are in the mask.", Me.Font, Brushes.LightYellow, 20, 20)
        End If

    End Sub


    Private Sub subDrawDiscMask(ByRef graphObj As Graphics)
        '''''''''''''''''''''
        '' Draw the discrete mask

        Dim i As Integer

        If nEleDiscMask > 0 Then

            For iEle As Integer = 0 To nEleDiscMask - 1
                i = eleDiscMask(iEle)

                If nVertex(i) = 0 Then
                    graphObj.DrawEllipse(Pens.Red, Convert.ToSingle((xEle(i) - rEle(i)) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((yEle(i) + rEle(i))) * zoomScale) + yOrigin, Convert.ToSingle(2 * rEle(i) * zoomScale), Convert.ToSingle(2 * rEle(i) * zoomScale))
                Else
                    For j As Integer = 0 To nVertex(i) - 1

                        graphObj.DrawArc(Pens.Red, Convert.ToSingle((xCE(0, j, i) - rqCE(2, j, i)) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((xCE(1, j, i) + rqCE(2, j, i))) * zoomScale) + yOrigin, Convert.ToSingle(2 * rqCE(2, j, i) * zoomScale), Convert.ToSingle(2 * rqCE(2, j, i) * zoomScale), Convert.ToSingle(-rqCE(3, j, i) / 3.14159 * 180), Convert.ToSingle(-CAC(j, i) / 3.14159 * 180))

                    Next

                End If

            Next

        End If


    End Sub

    Private Sub subDrawOrientation(ByRef graphObj As Graphics, ByRef nEleV As Integer, ByRef eleView() As Integer)

        Dim i As Integer
        If rbRotationMode1.Checked = True Then

            For iEle As Integer = 0 To nEleV - 1
                i = eleView(iEle) - 1

                If (flagMaskCropOn = 1 And flagEMask(i) = 1) Then    'Or (modeHist.Checked = True And flagEMask(i) = 1)
                    penAct = penHL
                Else
                    penAct = pen
                End If

                If nVertex(i) = 0 Then
                    graphObj.DrawLine(penAct, Convert.ToSingle((xEle(i) - rEle(i) * Math.Cos(qEle(i))) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((yEle(i) - rEle(i) * Math.Sin(qEle(i)))) * zoomScale) + yOrigin, Convert.ToSingle((xEle(i) + rEle(i) * Math.Cos(qEle(i))) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((yEle(i) + rEle(i) * Math.Sin(qEle(i)))) * zoomScale) + yOrigin)
                Else

                    graphObj.DrawLine(penAct, Convert.ToSingle((xEle(i) - rEle(i) / Math.Sqrt(elong(i)) * Math.Cos(qEle(i) + iniOri(i))) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((yEle(i) - rEle(i) / Math.Sqrt(elong(i)) * Math.Sin(qEle(i) + iniOri(i)))) * zoomScale) + yOrigin, Convert.ToSingle((xEle(i) + rEle(i) / Math.Sqrt(elong(i)) * Math.Cos(qEle(i) + iniOri(i))) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((yEle(i) + rEle(i) / Math.Sqrt(elong(i)) * Math.Sin(qEle(i) + iniOri(i)))) * zoomScale) + yOrigin)

                End If
            Next


        Else

            If trackStateB.Visible = False Or modeMotion.Checked = False Then    '  test running, not post-processing
                For iEle As Integer = 0 To nEleV - 1
                    i = eleView(iEle) - 1

                    If (flagMaskCropOn = 1 And flagEMask(i) = 1) Then    'Or (modeHist.Checked = True And flagEMask(i) = 1)
                        penAct = penHL
                    Else
                        penAct = pen
                    End If

                    If nVertex(i) = 0 Then
                        graphObj.DrawLine(penAct, Convert.ToSingle((xEle(i) - rEle(i) * Math.Cos(qEle(i))) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((yEle(i) - rEle(i) * Math.Sin(qEle(i)))) * zoomScale) + yOrigin, Convert.ToSingle((xEle(i) + rEle(i) * Math.Cos(qEle(i))) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((yEle(i) + rEle(i) * Math.Sin(qEle(i)))) * zoomScale) + yOrigin)
                    Else

                        graphObj.DrawLine(penAct, Convert.ToSingle((xEle(i) - rEle(i) / Math.Sqrt(elong(i)) * Math.Cos(qEle(i))) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((yEle(i) - rEle(i) / Math.Sqrt(elong(i)) * Math.Sin(qEle(i)))) * zoomScale) + yOrigin, Convert.ToSingle((xEle(i) + rEle(i) / Math.Sqrt(elong(i)) * Math.Cos(qEle(i))) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((yEle(i) + rEle(i) / Math.Sqrt(elong(i)) * Math.Sin(qEle(i)))) * zoomScale) + yOrigin)

                    End If


                Next


            Else
                For iEle As Integer = 0 To nEleV - 1
                    i = eleView(iEle) - 1

                    If (flagMaskCropOn = 1 And flagEMask(i) = 1) Then    'Or (modeHist.Checked = True And flagEMask(i) = 1)
                        penAct = penHL
                    Else
                        penAct = pen
                    End If

                    graphObj.DrawLine(penAct, Convert.ToSingle((xEle(i) - rEle(i) / Math.Sqrt(elong(i)) * Math.Cos(qEleTrace(iStep - 1, i) - qEleTrace(jStep - 1, i))) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((yEle(i) - rEle(i) / Math.Sqrt(elong(i)) * Math.Sin(qEleTrace(iStep - 1, i) - qEleTrace(jStep - 1, i)))) * zoomScale) + yOrigin, Convert.ToSingle((xEle(i) + rEle(i) / Math.Sqrt(elong(i)) * Math.Cos(qEleTrace(iStep - 1, i) - qEleTrace(jStep - 1, i))) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((yEle(i) + rEle(i) / Math.Sqrt(elong(i)) * Math.Sin(qEleTrace(iStep - 1, i) - qEleTrace(jStep - 1, i)))) * zoomScale) + yOrigin)

                Next



            End If


        End If


        If flagMaskCropOn = 1 Then
            graphObj.FillRectangle(brushMask, 15, 15, 200, 30)
            graphObj.DrawString(nEleMasked.ToString & " elements are in the mask.", Me.Font, Brushes.LightYellow, 20, 20)
        End If


    End Sub



    Private Sub subDrawLinks(ByRef graphObj As Graphics)

        penAct = penHL

        For iLink As Integer = 0 To nLinks - 1
            graphObj.DrawLine(penAct, X2Scr(xEle(iEleLink(0, iLink) - 1)), Y2Scr(yEle(iEleLink(0, iLink) - 1)), X2Scr(xEle(iEleLink(1, iLink) - 1)), Y2Scr(yEle(iEleLink(1, iLink) - 1)))
        Next



    End Sub

    Private Sub subDrawLinkedElements(ByRef graphObj As Graphics)


        For iLink As Integer = 0 To nLinks - 1
            If nVertex(iEleLink(0, iLink) - 1) = 0 Then
                graphObj.FillEllipse(brushBlue, Convert.ToSingle((xEle(iEleLink(0, iLink) - 1) - rEle(iEleLink(0, iLink) - 1)) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((yEle(iEleLink(0, iLink) - 1) + rEle(iEleLink(0, iLink) - 1))) * zoomScale) + yOrigin, Convert.ToSingle(2 * rEle(iEleLink(0, iLink) - 1) * zoomScale), Convert.ToSingle(2 * rEle(iEleLink(0, iLink) - 1) * zoomScale))
                graphObj.DrawEllipse(penHL, Convert.ToSingle((xEle(iEleLink(0, iLink) - 1) - rEle(iEleLink(0, iLink) - 1)) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((yEle(iEleLink(0, iLink) - 1) + rEle(iEleLink(0, iLink) - 1))) * zoomScale) + yOrigin, Convert.ToSingle(2 * rEle(iEleLink(0, iLink) - 1) * zoomScale), Convert.ToSingle(2 * rEle(iEleLink(0, iLink) - 1) * zoomScale))
            Else
                Dim polyPath As New System.Drawing.Drawing2D.GraphicsPath
                For j As Integer = 0 To nVertex(iEleLink(0, iLink) - 1) - 1
                    polyPath.AddArc(Convert.ToSingle((xCE(0, j, iEleLink(0, iLink) - 1) - rqCE(2, j, iEleLink(0, iLink) - 1)) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((xCE(1, j, iEleLink(0, iLink) - 1) + rqCE(2, j, iEleLink(0, iLink) - 1))) * zoomScale) + yOrigin, Convert.ToSingle(2 * rqCE(2, j, iEleLink(0, iLink) - 1) * zoomScale), Convert.ToSingle(2 * rqCE(2, j, iEleLink(0, iLink) - 1) * zoomScale), Convert.ToSingle(-rqCE(3, j, iEleLink(0, iLink) - 1) / 3.14159 * 180), Convert.ToSingle(-CAC(j, iEleLink(0, iLink) - 1) / 3.14159 * 180))
                    If showARC.Checked = True Then
                        graphObj.DrawArc(penHL, Convert.ToSingle((xCE(0, j, iEleLink(0, iLink) - 1) - rqCE(2, j, iEleLink(0, iLink) - 1)) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((xCE(1, j, iEleLink(0, iLink) - 1) + rqCE(2, j, iEleLink(0, iLink) - 1))) * zoomScale) + yOrigin, Convert.ToSingle(2 * rqCE(2, j, iEleLink(0, iLink) - 1) * zoomScale), Convert.ToSingle(2 * rqCE(2, j, iEleLink(0, iLink) - 1) * zoomScale), Convert.ToSingle(-rqCE(3, j, iEleLink(0, iLink) - 1) / 3.14159 * 180), Convert.ToSingle(-CAC(j, iEleLink(0, iLink) - 1) / 3.14159 * 180))

                    End If
                Next
                graphObj.FillPath(brushBlue, polyPath)
            End If
            If nVertex(iEleLink(1, iLink) - 1) = 0 Then
                graphObj.FillEllipse(brushBlue, Convert.ToSingle((xEle(iEleLink(1, iLink) - 1) - rEle(iEleLink(1, iLink) - 1)) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((yEle(iEleLink(1, iLink) - 1) + rEle(iEleLink(1, iLink) - 1))) * zoomScale) + yOrigin, Convert.ToSingle(2 * rEle(iEleLink(1, iLink) - 1) * zoomScale), Convert.ToSingle(2 * rEle(iEleLink(1, iLink) - 1) * zoomScale))
                graphObj.DrawEllipse(penHL, Convert.ToSingle((xEle(iEleLink(1, iLink) - 1) - rEle(iEleLink(1, iLink) - 1)) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((yEle(iEleLink(1, iLink) - 1) + rEle(iEleLink(1, iLink) - 1))) * zoomScale) + yOrigin, Convert.ToSingle(2 * rEle(iEleLink(1, iLink) - 1) * zoomScale), Convert.ToSingle(2 * rEle(iEleLink(1, iLink) - 1) * zoomScale))
            Else
                Dim polyPath As New System.Drawing.Drawing2D.GraphicsPath
                For j As Integer = 0 To nVertex(iEleLink(1, iLink) - 1) - 1
                    polyPath.AddArc(Convert.ToSingle((xCE(0, j, iEleLink(1, iLink) - 1) - rqCE(2, j, iEleLink(1, iLink) - 1)) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((xCE(1, j, iEleLink(1, iLink) - 1) + rqCE(2, j, iEleLink(1, iLink) - 1))) * zoomScale) + yOrigin, Convert.ToSingle(2 * rqCE(2, j, iEleLink(1, iLink) - 1) * zoomScale), Convert.ToSingle(2 * rqCE(2, j, iEleLink(1, iLink) - 1) * zoomScale), Convert.ToSingle(-rqCE(3, j, iEleLink(1, iLink) - 1) / 3.14159 * 180), Convert.ToSingle(-CAC(j, iEleLink(1, iLink) - 1) / 3.14159 * 180))
                    If showARC.Checked = True Then
                        graphObj.DrawArc(penHL, Convert.ToSingle((xCE(0, j, iEleLink(1, iLink) - 1) - rqCE(2, j, iEleLink(1, iLink) - 1)) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((xCE(1, j, iEleLink(1, iLink) - 1) + rqCE(2, j, iEleLink(1, iLink) - 1))) * zoomScale) + yOrigin, Convert.ToSingle(2 * rqCE(2, j, iEleLink(1, iLink) - 1) * zoomScale), Convert.ToSingle(2 * rqCE(2, j, iEleLink(1, iLink) - 1) * zoomScale), Convert.ToSingle(-rqCE(3, j, iEleLink(1, iLink) - 1) / 3.14159 * 180), Convert.ToSingle(-CAC(j, iEleLink(1, iLink) - 1) / 3.14159 * 180))

                    End If
                Next
                graphObj.FillPath(brushBlue, polyPath)
            End If
        Next
        

    End Sub

    Private Sub rbContourCoordNum_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbContourCoordNum.CheckedChanged
        If rbContourCoordNum.Checked = True Then
            iMode = 12
            Call ColorDeform(nEle, nActEle, xEleTrace, yEleTrace, qEleTrace, rangeContour, relaMin, relamax, nStep, iStep, jStep, iMode, jMode, kMode, mMode, TraceRGB, ptcStress, areaEle, iniOri, Ori, refOri, numECon)
        End If
    End Sub



    Private Sub btnRstDiscMask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRstDiscMask.Click
        nEleDiscMask = 0
        flagAddDiscMask = 0
        ReDim eleDiscMask(999)
    End Sub

    Private Sub btnApdDiscMask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApdDiscMask.Click
        If flagAddDiscMask = 0 Then
            btnApdDiscMask.BackColor = Color.Brown
            flagAddDiscMask = 1
            btnApdDiscMask.Text = "Adding"
        Else
            btnApdDiscMask.BackColor = Color.DarkGray
            flagAddDiscMask = 0
            btnApdDiscMask.Text = "Append"

        End If
    End Sub

    Private Sub chkExpDiscMask_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkExpDiscMask.CheckedChanged
        If chkExpDiscMask.Checked = True Then
            textEleQuery.Text = ""
            If nEleDiscMask > 0 Then

                textEleQuery.AppendText(iCurStep(0).ToString & ", ")

                For i As Integer = 0 To nEleDiscMask - 1
                    textEleQuery.AppendText((eleDiscMask(i) + 1).ToString & ", ")
                Next

                textEleQuery.AppendText(Environment.NewLine)


                textEleQuery.AppendText(iCurStep(0).ToString & ", ")

                For i As Integer = 0 To nEleDiscMask - 1
                    textEleQuery.AppendText(iniOri(eleDiscMask(i)).ToString("F02") & ", ")
                Next

                textEleQuery.AppendText(Environment.NewLine)
            End If


        End If

    End Sub




    Private Sub btnClearActCell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearActCell.Click
        nActCell = 0
        ReDim cellAct(2 * nEle - 1)
    End Sub

    Private Sub btnAllAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllAct.Click
        nActCell = 0

        For iCell As Integer = 0 To numCell - 1
            If flagEffCell(iCell) = 1 Then
                cellAct(nActCell) = iCell
                nActCell += 1

            End If

        Next
        canvas.Invalidate()
    End Sub


    Private Sub btnMaskCell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaskCell.Click
        nActCell = 0
        Call MaskStrainCell(numCell, nActCell, nEle, xEle, yEle, eleStnCell, cellAct, flagEffCell, nNodeMask, Mask)
        canvas.Invalidate()

    End Sub

    Private Sub btnExpCellStrn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpCellStrn.Click

        Dim jCell As Integer
        textEleQuery.Clear()
        textEleQuery.AppendText("Step:" & iCurStep(0) & ", ")
        textEleQuery.AppendText(Environment.NewLine)
        textEleQuery.AppendText("Cell ID" & ", " & "x_Cell" & ", " & "y_Cell" & ", " & "Strain_Inc_Magnitude" & ", " & "Orientation" & ", " & "Cell Area" & Environment.NewLine)
        For iCell = 0 To nActCell - 1
            jCell = cellAct(iCell)

            If flagEffCell(jCell) = 1 Then

                textEleQuery.AppendText((iCell + 1).ToString & ", " & _
                                        ((xEle(eleStnCell(0, jCell) - 1) + xEle(eleStnCell(1, jCell) - 1) + xEle(eleStnCell(2, jCell) - 1)) / 3).ToString("E02") & ", " & _
                                        ((yEle(eleStnCell(0, jCell) - 1) + yEle(eleStnCell(1, jCell) - 1) + yEle(eleStnCell(2, jCell) - 1)) / 3).ToString("E02") & ", " & _
                                        strainOut(jCell).ToString("E02") & ", " & _
                                        drctStn(jCell).ToString("E02") & ", " & _
                                        areaCell(jCell).ToString("E03"))
                textEleQuery.AppendText(Environment.NewLine)
            End If

        Next
    End Sub

    Private Sub TensorAxis(ByRef axis1 As Double, ByRef axis2 As Double, _
                            ByRef ts11 As Double, ByRef ts12 As Double, ByRef ts22 As Double)
        axis1 = 0.5 * Math.Atan(2 * ts12 / (ts11 - ts22))
        If ts12 > 0 Then
            If ts22 > ts11 Then
                axis1 += Math.PI / 2
            End If
        Else
            If ts22 > ts11 Then
                axis1 += Math.PI / 2
            Else
                axis1 += Math.PI

            End If

        End If

        axis2 = axis1 + Math.PI / 2


    End Sub



    'Private Sub axisFabOri()
    '    angFabAxis1 = 0.5 * Math.Atan(2 * tsFabric(1) / (tsFabric(0) - tsFabric(3)))

    '    If tsFabric(1) > 0 Then
    '        If tsFabric(3) > tsFabric(0) Then
    '            angFabAxis1 += Math.PI / 2
    '        End If
    '    Else
    '        If tsFabric(3) > tsFabric(0) Then
    '            angFabAxis1 += Math.PI / 2
    '        Else
    '            angFabAxis1 += Math.PI

    '        End If

    '    End If

    '    angFabAxis2 = angFabAxis1 + 1.57

    'End Sub

    'Private Sub axisFabCN()
    '    angFabCN1 = 0.5 * Math.Atan(2 * tsConNorm(1) / (tsConNorm(0) - tsConNorm(3)))

    '    If tsConNorm(1) > 0 Then
    '        If tsConNorm(3) > tsConNorm(0) Then
    '            angFabCN1 += Math.PI / 2
    '        End If
    '    Else
    '        If tsConNorm(3) > tsConNorm(0) Then
    '            angFabCN1 += Math.PI / 2
    '        Else
    '            angFabCN1 += Math.PI

    '        End If

    '    End If

    '    angFabCN2 = angFabCN1 + 1.57

    'End Sub


    Private Sub setAngDye_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setAngDye.ValueChanged
        xDyeRef(0) = Math.Cos(setAngDye.Value / 180 * Math.PI)
        xDyeRef(1) = Math.Sin(setAngDye.Value / 180 * Math.PI)
        canvas.Invalidate()
    End Sub

    Private Sub setIntvlDye_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setIntvlDye.ValueChanged
        canvas.Invalidate()
    End Sub

    Private Sub btnStrnTrack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStrnTrack.Click
        textEleQuery.Clear()
        Do While (trackPost.Value < trackPost.Maximum And flagPause < 1)
            canvas.Invalidate()

            Dim strainTemp() As Double = New Double(nActCell - 1) {}
            Dim oriTemp() As Double = New Double(nActCell - 1) {}
            Dim areaTemp() As Double = New Double(nActCell - 1) {}

            For iCell = 0 To nActCell - 1
                strainTemp(iCell) = strainOut(cellAct(iCell))
                oriTemp(iCell) = drctStn(cellAct(iCell))
            Next
            Array.Sort(strainTemp, oriTemp)

            For iCell = 0 To nActCell - 1
                strainTemp(iCell) = strainOut(cellAct(iCell))
                areaTemp(iCell) = areaCell(cellAct(iCell))
            Next
            Array.Sort(strainTemp, areaTemp)



            textEleQuery.AppendText("Strain" & ", ")
            textEleQuery.AppendText(iCurStep(0) & ", ")
            For iCell = 0 To nActCell - 1
                textEleQuery.AppendText(strainTemp(iCell).ToString("E02") & ", ")
            Next
            textEleQuery.AppendText(Environment.NewLine)

            textEleQuery.AppendText("Orientation" & ", ")
            textEleQuery.AppendText(iCurStep(0) & ", ")
            For iCell = 0 To nActCell - 1
                textEleQuery.AppendText(oriTemp(iCell).ToString("E02") & ", ")
            Next
            textEleQuery.AppendText(Environment.NewLine)

            textEleQuery.AppendText("Cell_Area" & ", ")
            textEleQuery.AppendText(iCurStep(0) & ", ")
            For iCell = 0 To nActCell - 1
                textEleQuery.AppendText(areaTemp(iCell).ToString("E02") & ", ")
            Next
            textEleQuery.AppendText(Environment.NewLine)

            If setNumCell.Value > 0 Then


                Call IniStrainCell(numCell, iEleCell, rStainCell, nEle, xEle, yEle, areaEle, _
                      limitAll, xGrid, nGridX, nGridY, nEleGrid, lEG, maxNEleGrid, eleStnCell, _
                     eleBuffer, nEleTop, wgtBuffer, flagEffCell)

                nActCell = 0
                Call MaskStrainCell(numCell, nActCell, nEle, xEle, yEle, eleStnCell, cellAct, flagEffCell, nNodeMask, Mask)

            End If
            trackPost.Value += 1
            Call ReadPauseFile(flagPause, curDir, lCurDir)


        Loop
    End Sub

    Private Sub PictureBox2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim graphObj As Graphics = e.Graphics
        graphObj.FillEllipse(Brushes.Transparent, 0, 0, 40, 40)
    End Sub



    Private Sub setStepSparse_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setStepSparse.ValueChanged
        stepSparse = setStepSparse.Value
        iniSparse = Rnd() * stepSparse
    End Sub


    Private Sub btnResetCell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetCell.Click

        Call ResetStrainCell()


        canvas.Invalidate()

    End Sub

    Private Sub rbModeStnInc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbModeStnInc.CheckedChanged
        If rbModeStnInc.Checked Then
            flagStnMode = 1
        Else
            flagStnMode = 2
        End If
    End Sub


    Private Function X2Scr(ByVal x) As Single
        X2Scr = Convert.ToSingle(x * zoomScale) + xOrigin
    End Function
    Private Function Y2Scr(ByVal y) As Single
        Y2Scr = canvasContainer.Height - Convert.ToSingle(y * zoomScale) + yOrigin

    End Function
#If USEKEY = 1 Then

    Private Sub IniKey()
        appID = &H46555043

        nRet = NoxFind(appID, keyHandles(0), numKey)
        If nRet <> 0 Then
            MessageBox.Show("Could not find license key for PPDEM.  You can open a data file to test system compatibility but you cannot run simulation or view simulation results. _Please plug your key in and restart PPDEM.  ")
            tabMain.Enabled = False
            tabMain.Visible = False
            btnPause.Enabled = False
            btnSnapShot.Enabled = False
            timerTest.Enabled = False
            'Me.Close()

        Else
            Dim userPin As String
            userPin = "7b6610951d5e1db41b6a0d66376db408"
            nRet = NoxOpen(keyHandles(0), userPin)

        End If
    End Sub

    Private Sub WriteNoxMemo()
        NoxMemo(0) = dt
        NoxMemo(1) = stiff
        NoxMemo(2) = dampingRatio
        NoxMemo(3) = rollingDamp
        nRet = NoxWriteMemory(keyHandles(0), NoxMemo(0))

    End Sub
#End If


    Private Sub rbDrctMaxShear_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDrctShearFlow.CheckedChanged
        If rbDrctShearFlow.Checked Then
            flagDrctStnOut = 0

        End If
        UpdateStrain()

    End Sub

    Private Sub rbDrctStnI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDrctStnI.CheckedChanged
        If rbDrctStnI.Checked Then
            flagDrctStnOut = 1
        End If
        UpdateStrain()
    End Sub

    Private Sub rbDrctStnII_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDrctStnII.CheckedChanged
        If rbDrctStnII.Checked Then
            flagDrctStnOut = 2
        End If
        UpdateStrain()
    End Sub

    Private Sub rbDrctStnXX_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDrctStnXX.CheckedChanged
        If rbDrctStnXX.Checked Then
            flagDrctStnOut = 3
        End If
        UpdateStrain()
    End Sub

    Private Sub rbDrctMaxShear_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDrctMaxShear.CheckedChanged
        If rbDrctMaxShear.Checked Then
            flagDrctStnOut = 4
        End If
        UpdateStrain()
    End Sub

    Private Sub UpdateStrain()
        If chkShowStrain.Checked = True Or chkShowStnDrct.Checked = True Then
            Call StrainCell(nEle, xEleTrace, yEleTrace, vxEle, vyEle, _
            nStep, iStep, jStep, strainOut, drctStn, areaCell, numCell, eleStnCell, _
            flagEffCell, flagStnOut, flagDrctStnOut, flagStnMode, angN)
        End If
        canvas.Invalidate()

    End Sub

    Private Sub rbDyeGrid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDyeGrid.CheckedChanged
        canvas.Invalidate()

    End Sub

    Private Sub ResetStrainCell()
        If rbHomoTri.Checked Then
            Call IniStrainCell(numCell, iEleCell, rStainCell, nEle, xEle, yEle, areaEle, _
                  limitAll, xGrid, nGridX, nGridY, nEleGrid, lEG, maxNEleGrid, eleStnCell, _
                 eleBuffer, nEleTop, wgtBuffer, flagEffCell)
        Else
            Dim nVMax As Integer = nEle * 3
            Dim nFMax As Integer = nEle
            Dim nHMax As Integer = nEle
            Dim nKMax As Integer = nEle
            Dim nJMax As Integer = nEle
            Dim nPMax As Integer = nEle
            Dim iX() As Integer = New Integer(nEle - 1) {}
            Dim iY() As Integer = New Integer(nEle - 1) {}
            Dim iX2() As Integer = New Integer(nEle - 1) {}
            Dim iY2() As Integer = New Integer(nEle - 1) {}
            Dim iSS() As Integer = New Integer(nEle - 1) {}
            Dim iConTemp(,) As Integer = New Integer(nVMax - 1, 5) {}
            Dim iD() As Integer = New Integer(nVMax - 1) {}
            Dim iAve() As Integer = New Integer(nJMax - 1) {}
            Dim iAze() As Integer = New Integer(nKMax - 1) {}

            ReDim eleStnCell(2, nVMax - 1)
            ReDim flagEffCell(nVMax - 1)
            'This call only gets the number of cells
            Call IniDelaunay(nEle, nActEle, xEle, yEle, numCell, eleStnCell, flagEffCell, _
                               nVMax, nFMax, nHMax, nKMax, nJMax, nPMax, _
                               iX, iY, iX2, iY2, iSS, iConTemp, iD, iAve, iAze)

            nVMax = numCell
            ReDim xPt(1, numCell - 1)
            ReDim iEleCell(numCell - 1)
            ReDim eleStnCell(2, numCell - 1)
            ReDim flagEffCell(numCell - 1)
            ReDim strainOut(numCell - 1)
            ReDim drctStn(numCell - 1)
            ReDim iConTemp(numCell - 1, 5)
            ReDim iD(numCell - 1)
            Call IniDelaunay(nEle, nActEle, xEle, yEle, numCell, eleStnCell, flagEffCell, _
                   nVMax, nFMax, nHMax, nKMax, nJMax, nPMax, _
                   iX, iY, iX2, iY2, iSS, iConTemp, iD, iAve, iAze)

        End If
    End Sub



    Private Sub chkLayerLowFric_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLayerLowFric.CheckedChanged
        If chkLayerLowFric.Checked Then
            flagThinLayer(0) = 1
        Else
            flagThinLayer(0) = 0
        End If
    End Sub

    Private Sub chkLayerNoRotation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLayerNoRotation.CheckedChanged
        If chkLayerNoRotation.Checked Then
            flagThinLayer(1) = 1
        Else
            flagThinLayer(1) = 0
        End If
    End Sub

    Private Sub setHThinLayer_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setHThinLayer.ValueChanged
        hThinLayer = setHThinLayer.Value
    End Sub

    Private Sub btnIniCellInEle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniCellInEle.Click

        UDDualCell()
        canvas.Invalidate()

    End Sub

    Private Sub rbShowOriCell_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbShowOriCell.CheckedChanged
        canvas.Invalidate()
    End Sub

    Private Sub setCellOpacity_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setCellOpacity.Scroll
        opacityCell = setCellOpacity.Value
        canvas.Invalidate()
    End Sub

    Private Sub UDDualCell()
        If nCon > 3 Then

            maxConAll = nEle * 3
            maxConPEle = 24
            maxEdgePEle = 24

            ReDim xEffCon(1, maxConAll * 2 - 1)
            ReDim effCon2Glob(maxConAll * 2 - 1)
            ReDim iEleEffCon(1, maxConAll * 2 - 1)

            ReDim iConTriAllCon(2, maxConAll * 3 - 1)
            ReDim iEConTriAllCon(2, maxConAll * 3 - 1)
            ReDim fgDeadTri(maxConAll * 3 - 1)

            ReDim nConPEle(nEle - 1)
            ReDim iConPEle(maxConPEle - 1, nEle - 1)
            ReDim iConCellInEle(2, nEle * maxConPEle - 1)

            ReDim iConDlnBound(1, maxConAll * 2 - 1)
            ReDim iEleDlnBound(maxConAll * 2 - 1)
            ReDim nGstDlnBound(maxConAll * 2 - 1)
            ReDim iEffGstDlnBound(11, maxConAll * 2 - 1)

            ReDim fgEffEdge(maxConAll * 3 - 1)
            ReDim iEleEffEdge(maxConAll * 3 - 1)
            ReDim nEdgePt(maxConAll * 2 - 1)
            ReDim jPtEdgeiPt(maxEdgePEle - 1, maxConAll * 2 - 1)

            ReDim iEdgeiPt(maxEdgePEle - 1, maxConAll * 2 - 1)
            ReDim iPtEdge(1, maxConAll * 3 - 1)
            ReDim iCellEdge(1, maxConAll * 3 - 1)
            ReDim iEdgeCell(2, maxConAll * 3 - 1)
            ReDim fgSolidCell(maxConAll * 3 - 1)

            ReDim iVCCell(maxConAll * 3 - 1)
            ReDim mapVC(maxConAll * 3 - 1)
            ReDim nCellVC(maxConAll)
            ReDim iCellVC(maxConPEle - 1, maxConAll - 1)
            ReDim nEConVC(maxConAll - 1)
            ReDim iEConVC(maxConPEle - 1, maxConAll - 1)


            maxNGrid(0) = (limitAll(1) - limitAll(0)) / dEleMax * 4
            maxNGrid(1) = (limitAll(3) - limitAll(2)) / dEleMax * 4
            maxDlnPGrid = nEle / maxNGrid(0) / maxNGrid(1) * 500
            ReDim nDlnBPGrid(maxNGrid(1) - 1, maxNGrid(0) - 1)
            ReDim iDlnBPGrid(maxDlnPGrid - 1, maxNGrid(1) - 1, maxNGrid(0) - 1)

            ReDim nSldTriPVC(maxConAll - 1)
            ReDim iEConSldTri(2, maxEdgePEle - 1, maxConAll - 1)
            ReDim xSldCell(1, nEle - 1)
            ReDim fgSeenMe(maxConAll * 2 - 1)
            ReDim fgBridgeEdge(maxConAll * 3 - 1)

            ReDim xVC(1, maxConAll - 1)

            ReDim flagVCMask(maxConAll - 1)
            ReDim vecVV(1, maxConAll * maxConPEle / 2 - 1)
            ReDim rqVV(1, maxConAll * maxConPEle / 2 - 1)
            ReDim binVV(nBinVV - 1)

            ReDim fgBndEle(nEle - 1)
            ReDim fgBndVC(maxConAll - 1)

            ReDim xPtEff(maxConAll - 1, 1)
            ReDim iNd2(maxConAll - 1)
            ReDim TIL(maxConAll * 2 - 1, 2)
            ReDim TNBR(maxConAll * 2 - 1, 2)



            Call VoidCell(nEle, nActEle, nCon, _
                            maxConAll, maxConPEle, maxEdgePEle, _
                            xEle, yEle, xCon, yCon, pairCon, flagConBoun, _
                            nEffCon, xEffCon, effCon2Glob, iEleEffCon, _
                            nTriAllCon, iConTriAllCon, iEConTriAllCon, fgDeadTri, _
                            nConPEle, iConPEle, iConCellInEle, nCellinEle, _
                            nDlnBound, iConDlnBound, iEleDlnBound, nGstDlnBound, iEffGstDlnBound, _
                            nEdgeAll, fgEffEdge, iEleEffEdge, nEdgePt, jPtEdgeiPt, _
                            iEdgeiPt, iPtEdge, iCellEdge, iEdgeCell, fgSolidCell, _
                            iVCCell, nVC, mapVC, nCellVC, iCellVC, nEConVC, iEConVC, _
                            maxNGrid, maxDlnPGrid, nDlnBPGrid, iDlnBPGrid, _
                            nSldTriPVC, iEConSldTri, xSldCell, fgSeenMe, fgBridgeEdge, _
                            fgBndEle, fgBndVC, xVC, _
                            iHistMode, flagVVWeight, nNodeMask, Mask, _
                            flagVCMask, vecVV, rqVV, nBinVV, binVV, tsVV, _
                             xPtEff, iNd2, TIL, TNBR)


            ReDim VCColor(nVC - 1, 2)

            Dim randNum As Random = New Random()

            For iVC As Integer = 0 To nVC - 1
                VCColor(iVC, 0) = randNum.Next(50, 250)
                VCColor(iVC, 1) = randNum.Next(30, 230)
                VCColor(iVC, 2) = randNum.Next(20, 210)
            Next

            Call TensorAxis(tsVVPAng(0), tsVVPAng(1), tsVV(0, 0), tsVV(1, 0), tsVV(1, 1))
            tsVVP(0) = 0.5 * (tsVV(0, 0) + tsVV(1, 1)) + Math.Sqrt(0.25 * (tsVV(1, 1) - tsVV(0, 0)) ^ 2 + tsVV(1, 0) ^ 2)
            tsVVP(1) = 0.5 * (tsVV(0, 0) + tsVV(1, 1)) - Math.Sqrt(0.25 * (tsVV(1, 1) - tsVV(0, 0)) ^ 2 + tsVV(1, 0) ^ 2)
        End If

    End Sub

    Private Sub chkShowCellInEle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowCellInEle.CheckedChanged
        canvas.Invalidate()

    End Sub

    Private Sub chkShowSolidCell_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowSolidCell.CheckedChanged
        canvas.Invalidate()

    End Sub

    Private Sub chkShowEffEdge_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowEffEdge.CheckedChanged
        canvas.Invalidate()

    End Sub

    Private Sub chkShowDualCelll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowDualCelll.CheckedChanged
        canvas.Invalidate()

    End Sub

    Private Sub chkExtVC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkExtVC.CheckedChanged
        canvas.Invalidate()
    End Sub

    Private Sub chkShowVCNum_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowVCNum.CheckedChanged
        canvas.Invalidate()

    End Sub

    Private Sub chkShowCellNum_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowCellNum.CheckedChanged
        canvas.Invalidate()

    End Sub

    Private Sub chkShowVCBound_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowVCBound.CheckedChanged
        canvas.Invalidate()
    End Sub

    Private Sub chkShowVoidVector_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowVoidVector.CheckedChanged
        canvas.Invalidate()
    End Sub

    Private Sub chkShowVCFabric_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowVCFabric.CheckedChanged
        If chkShowVCFabric.Checked Then
            VoidVector.Show()

        End If
    End Sub

    Private Sub chkExpVVTs_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkExpVVTs.CheckedChanged
        If chkExpVVTs.Checked Then
            textEleQuery.Text = ""
            textEleQuery.AppendText("step" & " , " & "FVV_I" & " , " & "Ang_F_I" & " , " & "F_11" & " , " & "F_22" & " , " & "F_12" & " , " & Environment.NewLine)

        End If
    End Sub

    Private Sub SaveImg(ByVal FileName As String, ByVal ImgFormat As String)
        Dim tempXOrigin As Single
        Dim tempYOrigin As Single

        Dim wBM As Integer
        Dim hBM As Integer
        If rbExpAll.Checked Then
            wBM = Convert.ToInt16((limitAll(1) - limitAll(0)) * zoomScale)
            hBM = Convert.ToInt16((limitAll(3) - limitAll(2)) * zoomScale)
            tempXOrigin = xOrigin
            tempYOrigin = yOrigin

            xOrigin = -limitAll(0) * zoomScale
            yOrigin = limitAll(3) * zoomScale - canvasContainer.Height
        Else
            wBM = canvasContainer.Width
            hBM = canvasContainer.Height
        End If

        If Math.Max(wBM, hBM) < 32000 Then
            lName = FileName.Length
            Dim BM As New Bitmap(wBM, hBM)

            If lName > 0 Then

                Dim graphObj As Graphics = Graphics.FromImage(BM)

                graphObj.Clear(canvas.BackColor)

                Dim xCanvas() As Double = New Double(3) {}
                Dim nEleV As Integer = 0
                Dim nConV As Integer = 0
                Dim eleView() As Integer = New Integer(nEle - 1) {}
                Dim conView() As Integer = New Integer(nEle * 10 - 1) {}
                Dim flagShowCon As Integer = 0


                If chkForceByThick.Checked Or flagForceByLeng.Checked Or flagShowP.Checked Or chkShowSliding.Checked Then
                    flagShowCon = 1
                End If


                Dim i As Integer

                If rbExpAll.Checked Then
                    xCanvas(0) = limitAll(0)
                    xCanvas(1) = limitAll(1)
                    xCanvas(2) = limitAll(2)
                    xCanvas(3) = limitAll(3)
                Else
                    xCanvas(0) = 0 - xOrigin / zoomScale
                    xCanvas(1) = (canvasContainer.Width - xOrigin) / zoomScale
                    xCanvas(2) = yOrigin / zoomScale
                    xCanvas(3) = (canvasContainer.Height + yOrigin) / zoomScale
                End If



                Call DrawRange(nEle, nActEle, limitAll, _
                xGrid, nGridX, nGridY, xCanvas, nEleV, nConV, _
                nCon, xCon, yCon, eleView, conView, flagShowCon, _
                nEleGrid, lEG, maxNEleGrid)


                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                '''''''' Draw motion contour, draw motion trace  '''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                If modeMotion.Checked = True Then

                    subDrawMotion(graphObj, nEleV, eleView)

                End If




                '''''''''''''''''''''''''''''''''''''''''''''''''''''
                '''''''' Draw Elements  '''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''''''''''

                If chkHideElement.Checked = False Then

                    subDrawElement(graphObj, nEleV, eleView)

                End If


                '''''''''''''''''''''''''''''''''''''''''''''''''''''
                '''''''' Draw Element Orientation  '''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''''''''''

                If flagRotation.Checked = True Then

                    subDrawOrientation(graphObj, nEleV, eleView)

                End If


                '''''''''''''''''''''''''''''''''''''''''''''''''''''
                '''''''' Draw Walls  '''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''''''''''



                For iWall As Integer = 0 To nWall - 1
                    If iWall = actWall Then
                        penWall = penActWall
                    Else
                        penWall = penInactWall
                    End If
                    graphObj.DrawLine(penWall, Convert.ToSingle(x1Wall(iWall) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((y1Wall(iWall)) * zoomScale) + yOrigin, Convert.ToSingle(x2Wall(iWall) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((y2Wall(iWall)) * zoomScale) + yOrigin)
                Next


                '''''''''''''''''''''''''''''''''''''''''''''''''''''
                '''''''' Draw Forch by Length  '''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''''''''''

                If flagForceByLeng.Checked = True Then

                    Dim iCon As Integer
                    For iList As Integer = 0 To nConV - 1
                        iCon = conView(iList) - 1
                        If (flagConBoun(iCon) = 0) Or ((flagConBoun(iCon) = 2 And chkIncWallForce.Checked = True)) Then

                            penForce.Color = Color.FromArgb(255, 121, 0, 38)



                            graphObj.DrawLine(penForce, Convert.ToSingle((xCon(iCon) - FLenScale * FxCon(iCon)) * zoomScale) + xOrigin, _
                                                  canvasContainer.Height - Convert.ToSingle(((yCon(iCon) - FLenScale * FyCon(iCon))) * zoomScale) + yOrigin, _
                                                  Convert.ToSingle((xCon(iCon) + FLenScale * FxCon(iCon)) * zoomScale) + xOrigin, _
                                                  canvasContainer.Height - Convert.ToSingle(((yCon(iCon) + FLenScale * FyCon(iCon))) * zoomScale) + yOrigin)

                        End If

                    Next

                End If


                '''''''''''''''''''''''''''''''''''''''''''''''''''''
                '''''''' Draw Force by Thickness '''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''''''''''



                If chkForceByThick.Checked Then
                    Dim myColor As New Color
                    myColor = Color.FromArgb(255, 121, 0, 38)
                    Dim brushForce As New SolidBrush(myColor)
                    penForceColor.Color = myColor
                    Dim iCon As Integer
                    For iList As Integer = 0 To nConV - 1
                        iCon = conView(iList) - 1
                        If (flagConBoun(iCon) = 0) Or ((flagConBoun(iCon) = 2 And chkIncWallForce.Checked = True)) Then

                            If chkShowForceColor.Checked Then
                                myColor = Color.FromArgb(FRGB(0, iCon), FRGB(1, iCon), FRGB(2, iCon))
                                penForceColor.Color = myColor
                                brushForce.Color = myColor
                            End If

                            ''Temp

                            FConTemp = Math.Sqrt(FxCon(iCon) ^ 2 + FyCon(iCon) ^ 2)

                            penForceColor.Width = FThickScale * FConTemp ^ factorContrast

                            If rbForceModeDire.Checked = True Then
                                If Not chkConForceByRadius.Checked Then
                                    wForce = rCon(iCon) * FxCon(iCon) / FConTemp * factorLenThick
                                    hForce = rCon(iCon) * FyCon(iCon) / FConTemp * factorLenThick
                                    graphObj.DrawLine(penForceColor, Convert.ToSingle((xCon(iCon) - wForce) * zoomScale) + xOrigin, _
                                                      canvasContainer.Height - Convert.ToSingle(((yCon(iCon) - hForce)) * zoomScale) + yOrigin, _
                                                      Convert.ToSingle((xCon(iCon) + wForce) * zoomScale) + xOrigin, _
                                                      canvasContainer.Height - Convert.ToSingle(((yCon(iCon) + hForce)) * zoomScale) + yOrigin)

                                Else
                                    graphObj.FillEllipse(brushForce, (X2Scr(xCon(iCon)) - penForceColor.Width), (Y2Scr(yCon(iCon)) - penForceColor.Width), _
                                                         2 * penForceColor.Width, 2 * penForceColor.Width)

                                End If
                            ElseIf flagConBoun(iCon) = 0 Then
                                graphObj.DrawLine(penForceColor, Convert.ToSingle(xEle(pairCon(1, iCon) - 1) * zoomScale) + xOrigin, _
                                                  canvasContainer.Height - Convert.ToSingle(yEle(pairCon(1, iCon) - 1) * zoomScale) + yOrigin, _
                                                  Convert.ToSingle(xEle(pairCon(0, iCon) - 1) * zoomScale) + xOrigin, _
                                                  canvasContainer.Height - Convert.ToSingle(yEle(pairCon(0, iCon) - 1) * zoomScale) + yOrigin)
                            End If
                        End If


                    Next


                End If




                '''''''''''''''''''''''''''''''''''''''''''''''''''''
                '''''''' Slding '''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''''''''''


                If chkShowSliding.Checked = True Then

                    Dim iCon As Integer
                    For iList As Integer = 0 To nConV - 1
                        iCon = conView(iList) - 1
                        If fricRatio(iCon) > 0.9999999 Then

                            FConTemp = Math.Sqrt(FxCon(iCon) ^ 2 + FyCon(iCon) ^ 2)
                            wForce = SlidScale * FConTemp ^ factorSlid


                            graphObj.FillEllipse(Brushes.Red, Convert.ToSingle((xCon(iCon)) * zoomScale) + xOrigin - Convert.ToSingle(wForce), _
                                                 canvasContainer.Height - Convert.ToSingle(((yCon(iCon))) * zoomScale) + yOrigin - Convert.ToSingle(wForce), _
                                                 2 * Convert.ToSingle(wForce), 2 * Convert.ToSingle(wForce))
                            graphObj.FillEllipse(Brushes.Orange, Convert.ToSingle((xCon(iCon)) * zoomScale) + xOrigin - 2, canvasContainer.Height - Convert.ToSingle(((yCon(iCon))) * zoomScale) + yOrigin - 2, 4, 4)

                        End If

                    Next


                End If

                lbCritDt.Text = ">" & dtCrit.ToString("F01")


                '''''''''''''''''''''''''''''''''''''''''''''''''''''
                '''''''' Draw Confining pressure '''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''''''''''

                If flagShowP.Checked = True Then

                    If trackPost.Visible = False Then


                        For iCon As Integer = 0 To nPCon - 1

                            graphObj.DrawLine(penP, Convert.ToSingle(pPlot(0, iCon) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((pPlot(1, iCon)) * zoomScale) + yOrigin, Convert.ToSingle(pPlot(0, iCon) * zoomScale - pPlot(2, iCon) * pScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((pPlot(1, iCon)) * zoomScale - pPlot(3, iCon) * pScale) + yOrigin)

                        Next

                    Else

                        Dim iCon As Integer
                        For iList As Integer = 0 To nConV - 1 Step setStepSparse.Value
                            iCon = conView(iList) - 1
                            If flagConBoun(iCon) = 1 Then
                                graphObj.DrawLine(penP, Convert.ToSingle(xCon(iCon) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((yCon(iCon)) * zoomScale) + yOrigin, Convert.ToSingle(xCon(iCon) * zoomScale - FxCon(iCon) * pScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((yCon(iCon)) * zoomScale - FyCon(iCon) * pScale) + yOrigin)

                            End If

                        Next

                    End If


                End If

                '''''''''''''''''''''''''''''''''''''''''''''''''''''
                '''''''' Draw velocity '''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''''''''''

                If checkShowVel.Checked = True Then

                    For iEle As Integer = 0 To nEleV - 1
                        i = eleView(iEle) - 1
                        graphObj.DrawLine(Pens.Crimson, Convert.ToSingle(xEle(i) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((yEle(i))) * zoomScale) + yOrigin, Convert.ToSingle((xEle(i) + vxEle(i) * scaleVel) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((yEle(i) + vyEle(i) * scaleVel)) * zoomScale) + yOrigin)

                    Next

                    lbVelFactor.Text = (scaleVel / dt / nInc).ToString("E01")
                End If

                If chkShowCohesion.Checked = True Then
                    For iPt As Integer = 0 To nPtHL - 1
                        graphObj.FillEllipse(Brushes.Red, Convert.ToSingle(xPtHL(0, iPt) * zoomScale) + xOrigin - 2, canvasContainer.Height - Convert.ToSingle((xPtHL(1, iPt)) * zoomScale) + yOrigin - 2, 4, 4)
                    Next

                End If

                If chkShowFriend.Checked = True Then


                    For iPair As Integer = 0 To nPair - 1
                        If pair(0, iPair) = actEle + 1 Then
                            If nVertex(pair(1, iPair) - 1) = 0 Then
                                graphObj.DrawEllipse(penFrd, Convert.ToSingle((xEle(pair(1, iPair) - 1) - rEle(pair(1, iPair) - 1)) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((yEle(pair(1, iPair) - 1) + rEle(pair(1, iPair) - 1))) * zoomScale) + yOrigin, Convert.ToSingle(2 * rEle(pair(1, iPair) - 1) * zoomScale), Convert.ToSingle(2 * rEle(pair(1, iPair) - 1) * zoomScale))
                            Else
                                For j As Integer = 0 To nVertex(pair(1, iPair) - 1) - 1
                                    graphObj.DrawLine(penFrd, Convert.ToSingle(xVertex(j, pair(1, iPair) - 1) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((yVertex(j, pair(1, iPair) - 1)) * zoomScale) + yOrigin, Convert.ToSingle(xVertex(j + 1, pair(1, iPair) - 1) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((yVertex(j + 1, pair(1, iPair) - 1)) * zoomScale) + yOrigin)
                                Next

                            End If
                        End If

                        If pair(1, iPair) = actEle + 1 Then

                            If nVertex(pair(0, iPair) - 1) = 0 Then
                                graphObj.DrawEllipse(penFrd, Convert.ToSingle((xEle(pair(0, iPair) - 1) - rEle(pair(0, iPair) - 1)) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(((yEle(pair(0, iPair) - 1) + rEle(pair(0, iPair) - 1))) * zoomScale) + yOrigin, Convert.ToSingle(2 * rEle(pair(0, iPair) - 1) * zoomScale), Convert.ToSingle(2 * rEle(pair(0, iPair) - 1) * zoomScale))
                            Else
                                For j As Integer = 0 To nVertex(pair(0, iPair) - 1) - 1
                                    graphObj.DrawLine(penFrd, Convert.ToSingle(xVertex(j, pair(0, iPair) - 1) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((yVertex(j, pair(0, iPair) - 1)) * zoomScale) + yOrigin, Convert.ToSingle(xVertex(j + 1, pair(0, iPair) - 1) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((yVertex(j + 1, pair(0, iPair) - 1)) * zoomScale) + yOrigin)
                                Next

                            End If


                        End If
                    Next

                End If






                If flagAdd = 1 Then
                    For iV As Integer = 0 To nVNew - 2
                        graphObj.DrawLine(penGreen, Convert.ToSingle(xVNew(iV, 0) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(xVNew(iV, 1) * zoomScale) + yOrigin, Convert.ToSingle(xVNew(iV + 1, 0) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle(xVNew(iV + 1, 1) * zoomScale) + yOrigin)
                    Next

                End If

                If flagEditVertex = 1 Then
                    If nVertex(actEle) > 0 Then
                        graphObj.DrawEllipse(penGreen, Convert.ToSingle(xVertex(actVertex, actEle) * zoomScale) + xOrigin - 3, canvasContainer.Height - Convert.ToSingle(yVertex(actVertex, actEle) * zoomScale) + yOrigin - 3, 6, 6)
                    Else
                        graphObj.DrawEllipse(penGreen, Convert.ToSingle((xEle(actEle) + rEle(actEle)) * zoomScale) + xOrigin - 3, canvasContainer.Height - Convert.ToSingle(yEle(actEle) * zoomScale) + yOrigin - 3, 6, 6)

                    End If
                End If


                If modeGD.Checked And rbGridLine.Checked Then


                    For iLine As Integer = 0 To nHLine - 1
                        For iPt As Integer = 0 To nHPtGD(iLine) - 2 Step 2
                            graphObj.DrawLine(penGD, Convert.ToSingle(xHPtGD(0, iPt, iLine) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((xHPtGD(1, iPt, iLine)) * zoomScale) + yOrigin, Convert.ToSingle(xHPtGD(0, iPt + 1, iLine) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((xHPtGD(1, iPt + 1, iLine)) * zoomScale) + yOrigin)

                        Next
                    Next

                    For iLine As Integer = 0 To nVLine - 1
                        For iPt As Integer = 0 To nVPtGD(iLine) - 2 Step 2
                            graphObj.DrawLine(penGD, Convert.ToSingle(xVPtGD(0, iPt, iLine) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((xVPtGD(1, iPt, iLine)) * zoomScale) + yOrigin, Convert.ToSingle(xVPtGD(0, iPt + 1, iLine) * zoomScale) + xOrigin, canvasContainer.Height - Convert.ToSingle((xVPtGD(1, iPt + 1, iLine)) * zoomScale) + yOrigin)

                        Next
                    Next

                End If

                If modeHist.Checked = True Then
                    Histgram.roseForce.Invalidate()
                    Histgram.roseOrit.Invalidate()
                    Histgram.roseNorm.Invalidate()
                    Histgram.hgFR.Invalidate()
                    Histgram.groupTsStress.Invalidate()
                    Histgram.groupTsFabric.Invalidate()
                    Histgram.gbFabricConNorm.Invalidate()
                    Histgram.groupTsBodyStress.Invalidate()

                End If

                If 0 = 1 Then ' modeHist.Checked = True And Histgram.rbMaskHist.Checked = True And flagMaskOn = 1 Then
                    For iM As Integer = 0 To 9
                        ptMask(iM).X = xEle(Mask(iM) - 1) * zoomScale + xOrigin
                        ptMask(iM).Y = canvasContainer.Height - yEle(Mask(iM) - 1) * zoomScale + yOrigin
                    Next
                    graphObj.FillPolygon(brushMask, ptMask)
                    graphObj.DrawPolygon(penActWall, ptMask)

                End If

                If flagNewVRBox = 1 Then

                    graphObj.DrawRectangle(penActWall, ptBox1.X, ptBox1.Y, ptBox2.X - ptBox1.X, ptBox2.Y - ptBox1.Y)

                End If



                If chkMeasureMode.Checked = True Then

                    graphObj.FillRectangle(brushTransGray, xMeasure1 + 15, yMeasure1 - 36, 120, 42)
                    graphObj.DrawRectangle(Pens.White, xMeasure1 + 15, yMeasure1 - 36, 120, 42)
                    graphObj.DrawString("Distance = " & distMeasure.ToString("F05"), Me.Font, Brushes.Black, xMeasure1 + 20, yMeasure1 - 28)
                    graphObj.DrawString("  Angle  =" & angMeasure.ToString("F01") & "  deg", Me.Font, Brushes.Black, xMeasure1 + 20, yMeasure1 - 12)
                    graphObj.DrawLine(Pens.Blue, xMeasure0, yMeasure0, xMeasure1, yMeasure1)

                End If


                If flagSampleRotate = 1 Then
                    graphObj.DrawEllipse(New Pen(Color.LightBlue, 6), Convert.ToSingle((xRotationCenter(0) - 0.4 * (limitAll(1) - limitAll(0))) * zoomScale) + xOrigin, _
                                         canvasContainer.Height - Convert.ToSingle((xRotationCenter(1) + 0.4 * (limitAll(1) - limitAll(0))) * zoomScale) + yOrigin, _
                                         Convert.ToSingle((limitAll(1) - limitAll(0)) * zoomScale * 0.8), Convert.ToSingle((limitAll(1) - limitAll(0)) * zoomScale * 0.8))
                    graphObj.DrawEllipse(New Pen(Color.LightBlue, 6), Convert.ToSingle((xRotationCenter(0) - 0.2 * (limitAll(1) - limitAll(0))) * zoomScale) + xOrigin, _
                                         canvasContainer.Height - Convert.ToSingle((xRotationCenter(1) + 0.2 * (limitAll(1) - limitAll(0))) * zoomScale) + yOrigin, _
                                         Convert.ToSingle((limitAll(1) - limitAll(0)) * zoomScale * 0.4), Convert.ToSingle((limitAll(1) - limitAll(0)) * zoomScale * 0.4))
                    graphObj.DrawEllipse(New Pen(Color.LightBlue, 6), Convert.ToSingle((xRotationCenter(0) - 0.6 * (limitAll(1) - limitAll(0))) * zoomScale) + xOrigin, _
                                         canvasContainer.Height - Convert.ToSingle((xRotationCenter(1) + 0.6 * (limitAll(1) - limitAll(0))) * zoomScale) + yOrigin, _
                                         Convert.ToSingle((limitAll(1) - limitAll(0)) * zoomScale * 1.2), Convert.ToSingle((limitAll(1) - limitAll(0)) * zoomScale * 1.2))
                End If


                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ''''''''' Draw the mask for cropping ''''''''''''''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                If flagMaskCropOn = 1 Then


                    If rbMaskCircular.Checked = True And nPtMaskCrop = 1 Then

                        graphObj.FillEllipse(brushMask, Convert.ToSingle((xMaskCrop(0, 0) - xMaskCrop(0, 1)) * zoomScale + xOrigin), _
                                               Convert.ToSingle(canvasContainer.Height - ((xMaskCrop(1, 0) + xMaskCrop(0, 1)) * zoomScale) + yOrigin), _
                                               Convert.ToSingle(2 * xMaskCrop(0, 1) * zoomScale), Convert.ToSingle(2 * xMaskCrop(0, 1) * zoomScale))

                    ElseIf rbMaskRect.Checked = True And nPtMaskCrop = 1 Then

                        graphObj.FillRectangle(brushMask, Math.Min(Convert.ToSingle(xMaskCrop(0, 0) * zoomScale + xOrigin), Convert.ToSingle(xMaskCrop(0, 2) * zoomScale + xOrigin)), _
                                               Math.Min(Convert.ToSingle(canvasContainer.Height - (xMaskCrop(1, 0) * zoomScale) + yOrigin), Convert.ToSingle(canvasContainer.Height - (xMaskCrop(1, 2) * zoomScale) + yOrigin)), _
                                               Math.Abs(Convert.ToSingle((xMaskCrop(0, 2) - xMaskCrop(0, 0)) * zoomScale)), _
                                               Math.Abs(Convert.ToSingle((xMaskCrop(1, 0) - xMaskCrop(1, 2)) * zoomScale)))

                        graphObj.DrawString(ratioWHMask.ToString("F03") & ":1", Me.Font, Brushes.White, Convert.ToSingle(xMaskCrop(0, 2) * zoomScale + xOrigin) - 55, Convert.ToSingle(canvasContainer.Height - (xMaskCrop(1, 2) * zoomScale) + yOrigin) - 11)
                    ElseIf rbMaskPoly.Checked = True Then

                        If nPtMaskCrop > 1 And flagCreatingMaskOn = 1 Then

                            ReDim ptMask(nPtMaskCrop)
                            For iM As Integer = 0 To nPtMaskCrop
                                ptMask(iM).X = xMaskCrop(0, iM) * zoomScale + xOrigin
                                ptMask(iM).Y = canvasContainer.Height - xMaskCrop(1, iM) * zoomScale + yOrigin
                            Next
                            graphObj.FillPolygon(brushMask, ptMask)


                        End If

                        If nPtMaskCrop > 0 And flagCreatingMaskOn = 1 Then
                            graphObj.DrawLine(penActWall, Convert.ToSingle(xMaskCrop(0, nPtMaskCrop - 1) * zoomScale) + xOrigin, _
                                               canvasContainer.Height - Convert.ToSingle(xMaskCrop(1, nPtMaskCrop - 1) * zoomScale) + yOrigin, _
                                                Convert.ToSingle(xMaskCrop(0, nPtMaskCrop) * zoomScale) + xOrigin, _
                                               canvasContainer.Height - Convert.ToSingle(xMaskCrop(1, nPtMaskCrop) * zoomScale) + yOrigin)

                        End If

                    End If
                End If

                If chkShowCoord.Checked = True Then

                    graphObj.FillRectangle(brushTransGray, Convert.ToSingle(xCursor(0)) + 14, Convert.ToSingle(xCursor(1)) - 20, 120, 42)
                    graphObj.FillEllipse(Brushes.Red, Convert.ToSingle(xCursor(0)) - 2, Convert.ToSingle(xCursor(1)) - 2, 4, 4)

                    graphObj.DrawRectangle(Pens.White, Convert.ToSingle(xCursor(0)) + 14, Convert.ToSingle(xCursor(1)) - 20, 120, 42)
                    graphObj.DrawString("x = " & ((xCursor(0) - xOrigin) / zoomScale).ToString("E06"), Me.Font, Brushes.Black, Convert.ToSingle(xCursor(0)) + 19, Convert.ToSingle(xCursor(1)) - 12)
                    graphObj.DrawString("y  =" & ((canvasContainer.Height - xCursor(1) + yOrigin) / zoomScale).ToString("E06"), Me.Font, Brushes.Black, Convert.ToSingle(xCursor(0)) + 19, Convert.ToSingle(xCursor(1)) + 4)

                End If

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                '''''''''''''' Draw sliding trace  ''''''''''''''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                If chkShowSldTrace.Checked = True Then

                    For iPtSld As Integer = 0 To nPlotSld - 1
                        graphObj.DrawEllipse(Pens.Red, Convert.ToSingle(xPlotSld(iPtSld, 0) * zoomScale) + xOrigin - 2, canvasContainer.Height - Convert.ToSingle(xPlotSld(iPtSld, 1) * zoomScale) + yOrigin - 2, 4, 4)
                    Next

                End If

                If chkShowRollingTrace.Checked = True Then

                    For iPtSld As Integer = 0 To nPlotRol - 1
                        graphObj.FillEllipse(Brushes.DarkGreen, Convert.ToSingle(xPlotRol(iPtSld, 0) * zoomScale) + xOrigin - 1, canvasContainer.Height - Convert.ToSingle(xPlotRol(iPtSld, 1) * zoomScale) + yOrigin - 1, 3, 3)
                    Next

                End If


                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                '''''''''''' Draw strain cells    ''''''''''''''''''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                If chkShowCell.Checked = True Then

                    Dim randNum As Random = New Random()

                    For iCell As Integer = 0 To numCell - 1
                        If flagEffCell(iCell) = 1 Then
                            For iEle As Integer = 1 To 3
                                graphObj.DrawLine(Pens.Black, Convert.ToSingle(xEle(eleStnCell(iEle Mod 3, iCell) - 1) * zoomScale) + xOrigin, _
                                  canvasContainer.Height - Convert.ToSingle(yEle(eleStnCell(iEle Mod 3, iCell) - 1) * zoomScale) + yOrigin, _
                                  Convert.ToSingle(xEle(eleStnCell((iEle + 1) Mod 3, iCell) - 1) * zoomScale) + xOrigin, _
                                  canvasContainer.Height - Convert.ToSingle(yEle(eleStnCell((iEle + 1) Mod 3, iCell) - 1) * zoomScale) + yOrigin)

                            Next

                            triangleCell(0) = New Point(Convert.ToSingle(xEle(eleStnCell(0, iCell) - 1) * zoomScale) + xOrigin, _
                                                     canvasContainer.Height - Convert.ToSingle(yEle(eleStnCell(0, iCell) - 1) * zoomScale) + yOrigin)
                            triangleCell(1) = New Point(Convert.ToSingle(xEle(eleStnCell(1, iCell) - 1) * zoomScale) + xOrigin, _
                                                     canvasContainer.Height - Convert.ToSingle(yEle(eleStnCell(1, iCell) - 1) * zoomScale) + yOrigin)
                            triangleCell(2) = New Point(Convert.ToSingle(xEle(eleStnCell(2, iCell) - 1) * zoomScale) + xOrigin, _
                                                     canvasContainer.Height - Convert.ToSingle(yEle(eleStnCell(2, iCell) - 1) * zoomScale) + yOrigin)

                            Dim brushRand As SolidBrush = New SolidBrush(Color.FromArgb(120, randNum.Next(50, 250), randNum.Next(30, 230), randNum.Next(20, 210)))

                            graphObj.FillPolygon(brushRand, triangleCell)
                        End If

                    Next
                    'For iCell As Integer = 0 To numCell - 1
                    '    If flagEffCell(iCell) = 1 Then
                    '        graphObj.FillRectangle(Brushes.Brown, Convert.ToSingle((xEle(eleStnCell(0, iCell) - 1) + xEle(eleStnCell(1, iCell) - 1) + xEle(eleStnCell(2, iCell) - 1)) / 3 * zoomScale) + xOrigin - 3, _
                    '                                 canvasContainer.Height - Convert.ToSingle((yEle(eleStnCell(0, iCell) - 1) + yEle(eleStnCell(1, iCell) - 1) + yEle(eleStnCell(2, iCell) - 1)) / 3 * zoomScale) + yOrigin - 3, _
                    '                                 6, 6)
                    '    End If

                    'Next


                End If

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                '''''''''''' Draw strain outputs   ''''''''''''''''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                If chkShowStrain.Checked Then

                    Dim penStnPos As Pen = New Pen(Color.DarkRed, setPenWidth.Value)
                    Dim penStnNeg As Pen = New Pen(Color.DarkBlue, setPenWidth.Value)

                    For iCell As Integer = 0 To numCell - 1

                        If (flagEffCell(iCell) = 1) And (rbShowBothStn.Checked = True Or (rbShowPosiStn.Checked = True And strainOut(iCell) >= 0) Or (rbShowNegStn.Checked = True And strainOut(iCell) < 0)) Then
                            Dim cellCenter() As Single = New Single(1) {}

                            cellCenter(0) = Convert.ToSingle((xEle(eleStnCell(0, iCell) - 1) + xEle(eleStnCell(1, iCell) - 1) + xEle(eleStnCell(2, iCell) - 1)) / 3 * zoomScale) + xOrigin
                            cellCenter(1) = canvasContainer.Height - Convert.ToSingle((yEle(eleStnCell(0, iCell) - 1) + yEle(eleStnCell(1, iCell) - 1) + yEle(eleStnCell(2, iCell) - 1)) / 3 * zoomScale) + yOrigin



                            If strainOut(iCell) < 0 Then
                                graphObj.DrawRectangle(penStnNeg, Convert.ToSingle(cellCenter(0) - Math.Abs(strainOut(iCell)) ^ stnContrast * scaleStnOut * zoomScale), _
                                          Convert.ToSingle(cellCenter(1) - Math.Abs(strainOut(iCell)) ^ stnContrast * scaleStnOut * zoomScale), _
                                          Convert.ToSingle(2 * Math.Abs(strainOut(iCell)) ^ stnContrast * scaleStnOut * zoomScale), _
                                          Convert.ToSingle(2 * Math.Abs(strainOut(iCell)) ^ stnContrast * scaleStnOut * zoomScale))
                            Else
                                graphObj.DrawEllipse(penStnPos, Convert.ToSingle(cellCenter(0) - Math.Abs(strainOut(iCell)) ^ stnContrast * scaleStnOut * zoomScale), _
                                          Convert.ToSingle(cellCenter(1) - Math.Abs(strainOut(iCell)) ^ stnContrast * scaleStnOut * zoomScale), _
                                          Convert.ToSingle(2 * Math.Abs(strainOut(iCell)) ^ stnContrast * scaleStnOut * zoomScale), _
                                          Convert.ToSingle(2 * Math.Abs(strainOut(iCell)) ^ stnContrast * scaleStnOut * zoomScale))

                            End If

                        End If

                    Next


                End If
                If chkShowStnLegend.Checked Then
                    graphObj.DrawRectangle(Pens.Red, Convert.ToSingle(X2Scr(limitAll(1)) + 100 - setValLegend.Value ^ stnContrast * scaleStnOut * zoomScale), _
                                                      Convert.ToSingle(Y2Scr(limitAll(2)) - 100 - setValLegend.Value ^ stnContrast * scaleStnOut * zoomScale), _
                                                          Convert.ToSingle(2 * setValLegend.Value ^ stnContrast * scaleStnOut * zoomScale), _
                                                         Convert.ToSingle(2 * setValLegend.Value ^ stnContrast * scaleStnOut * zoomScale))


                End If

                If chkShowStnDrct.Checked Then
                    For iCell As Integer = 0 To numCell - 1

                        If (flagEffCell(iCell) = 1) And (rbShowBothStn.Checked = True Or (rbShowPosiStn.Checked = True And strainOut(iCell) >= 0) Or (rbShowNegStn.Checked = True And strainOut(iCell) < 0)) Then

                            cellCenter(0) = Convert.ToSingle((xEle(eleStnCell(0, iCell) - 1) + xEle(eleStnCell(1, iCell) - 1) + xEle(eleStnCell(2, iCell) - 1)) / 3 * zoomScale) + xOrigin
                            cellCenter(1) = canvasContainer.Height - Convert.ToSingle((yEle(eleStnCell(0, iCell) - 1) + yEle(eleStnCell(1, iCell) - 1) + yEle(eleStnCell(2, iCell) - 1)) / 3 * zoomScale) + yOrigin

                            If strainOut(iCell) > 0 Then
                                penStrain = New Pen(Color.DarkRed, 2)
                            Else
                                penStrain = New Pen(Color.DarkBlue, 2)
                            End If

                            If chkLgthStrn.Checked = True Then
                                lgthStrn = Math.Abs(strainOut(iCell)) ^ stnContrast * scaleStnOut * zoomScale
                            Else
                                lgthStrn = scaleStnDrct * scaleStnOut * zoomScale
                            End If
                            graphObj.DrawLine(penStrain, Convert.ToSingle(cellCenter(0) - lgthStrn * Math.Cos(drctStn(iCell))), _
                                                              Convert.ToSingle(cellCenter(1) + lgthStrn * Math.Sin(drctStn(iCell))), _
                                                               Convert.ToSingle(cellCenter(0) + lgthStrn * Math.Cos(drctStn(iCell))), _
                                                              Convert.ToSingle(cellCenter(1) - lgthStrn * Math.Sin(drctStn(iCell))))

                        End If

                    Next

                End If



                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                '''' Draw grids
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                If chkShowGrid.Checked Then

                    subDrawGrid(graphObj)
                End If
                If chkShowDualCelll.Checked Then
                    subDrawCellInEle(graphObj)
                End If

                If chkShowCNMatrix.Checked Then
                    subDrawCNMatrix(graphObj)

                End If


                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ' '' Temp movie making
                'Dim penBlack As Pen = New Pen(Color.Black, 3)
                'Dim scaleRose As Single = 120 / Histgram.setScalePolar.Value
                'Dim brushWite As SolidBrush = New SolidBrush(Color.FromArgb(245, 255, 255, 255))
                'graphObj.FillRectangle(brushWite, 0, 0, 300, 300)

                'For ii As Integer = 0 To nBinOri * 2 - 1

                '    graphObj.DrawLine(penBlack, 150 + ptBinE(0, 2 * ii) * scaleRose, 164 - ptBinE(1, 2 * ii) * scaleRose, 150 + ptBinE(0, 2 * ii + 1) * scaleRose, 164 - ptBinE(1, 2 * ii + 1) * scaleRose)
                '    'roseE.DrawLine(Pens.Brown, 150, 164, ptBinE(0, 2 * i), ptBinE(1, 2 * i))

                'Next

                'For ii As Integer = 0 To nBinOri * 2 - 2
                '    graphObj.DrawLine(penBlack, 150 + ptBinE(0, 2 * ii + 1) * scaleRose, 164 - ptBinE(1, 2 * ii + 1) * scaleRose, 150 + ptBinE(0, 2 * ii + 2) * scaleRose, 164 - ptBinE(1, 2 * ii + 2) * scaleRose)

                'Next

                'graphObj.DrawLine(penBlack, 150 + ptBinE(0, nBinOri * 4 - 1) * scaleRose, 164 - ptBinE(1, nBinOri * 4 - 1) * scaleRose, 150 + ptBinE(0, 0) * scaleRose, 164 - ptBinE(1, 0) * scaleRose)


                If Microsoft.VisualBasic.Left(Microsoft.VisualBasic.LCase(ImgFormat), 1) = "j" Then
                    BM.Save(FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                Else
                    BM.Save(FileName, System.Drawing.Imaging.ImageFormat.Tiff)

                End If

            End If

            If rbExpAll.Checked Then
                xOrigin = tempXOrigin
                yOrigin = tempYOrigin
                canvas.Invalidate()

            End If


        Else

            MessageBox.Show("The maximum dimension of the image to be exported is 10,000 pixels.  The current dimention is" & Math.Max(wBM, hBM).ToString & ".  You need to zoom out the screen by " & (Math.Max(wBM, hBM) / 10000).ToString("F02"))
        End If


    End Sub

    Private Sub btnSaveMovie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveMovie.Click
        SaveSnapshot.Filter = "JPEG Image (*.jpg)|*.jpg|All files (*.*)|*.*"
        SaveSnapshot.ShowDialog()
        Dim FileBase As String = SaveSnapshot.FileName
        Dim lFileBase As Integer = FileBase.LastIndexOf(".")
        Dim iMovie As Integer = trackPost.Minimum - 1
        Do While (iMovie < trackPost.Maximum And flagPause < 1)
            iMovie += 1
            trackPost.Value = iMovie
            FileName = Microsoft.VisualBasic.Left(FileBase, lFileBase) & iMovie.ToString("D5") & ".jpg"
            Call SaveImg(FileName, "jpg")
            Call ReadPauseFile(flagPause, curDir, lCurDir)
        Loop
    End Sub


    Private Sub setPStressAng_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setPStressAng.ValueChanged
#If STRESSROTATE = 1 Then
        PStressAng = setPStressAng.Value / 180.0 * Math.PI

#End If
    End Sub


    Private Sub lb_set_PPFricAng_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lb_set_PPFricAng.DoubleClick
        If timerTest.Enabled = True Then
            timerTest.Enabled = False
            btnPause.Text = "Resume"
        End If
        VariableInc.ShowDialog()

    End Sub


    Private Sub setPenWidth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setPenWidth.ValueChanged
        pen.Width = setPenWidth.Value
    End Sub

    Private Sub btnOpenAngFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenAngFile.Click
        dlgOpenTest.ShowDialog()
        FileName = dlgOpenTest.FileName
        lName = FileName.Length
        ReDim angSequence(1000000)

        If lName > 0 Then
            Call ReadAngFile(nStressRotationSteps, angSequence, FileName, lName)
            setMaxStep.Value = iCurStep(0) + nStressRotationSteps - 1
            chkStressRotation.Checked = True


        End If


    End Sub


    Private Sub btnImpLinkCoord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpLinkCoord.Click
        dlgOpenTest.ShowDialog()
        FileName = dlgOpenTest.FileName
        lName = FileName.Length

        nLinks = 0
        ReDim iEleLink(1, Math.Max(nLinks - 1, 0))
        ReDim l0Link(Math.Max(nLinks - 1, 0))
        ReDim kLinkPos(Math.Max(nLinks - 1, 0))
        ReDim kLinkNeg(Math.Max(nLinks - 1, 0))
        Call ImportLinks(nLinks, minR, maxR, iEleLink, l0Link, kLinkPos, kLinkNeg, nEle, xEle, yEle, rEle, nActEle, FileName, lName)
        'First call get the number of links so that we can redim the variables

        ReDim iEleLink(1, Math.Max(nLinks - 1, 0))
        ReDim l0Link(Math.Max(nLinks - 1, 0))
        ReDim kLinkPos(Math.Max(nLinks - 1, 0))
        ReDim kLinkNeg(Math.Max(nLinks - 1, 0))
        Call ImportLinks(nLinks, minR, maxR, iEleLink, l0Link, kLinkPos, kLinkNeg, nEle, xEle, yEle, rEle, nActEle, FileName, lName)

        btnImpLinkCoord.Enabled = False
        btnImpLinkID.Enabled = False
        canvas.Invalidate()

    End Sub


    Private Sub btnLinkStiffPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLinkStiffPlus.Click
        For iLink As Integer = 0 To nLinks - 1
            kLinkNeg(iLink) *= 2.0
            kLinkPos(iLink) *= 2.0
        Next
    End Sub

    Private Sub btnLinkStiffMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLinkStiffMinus.Click
        For iLink As Integer = 0 To nLinks - 1
            kLinkNeg(iLink) *= 0.5
            kLinkPos(iLink) *= 0.5
        Next
    End Sub


    Private Sub setLinkDampingRatio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setLinkDampingRatio.ValueChanged
        linkDampingRatio = setLinkDampingRatio.Value
    End Sub

    Private Sub btnImpLinkID_Click(sender As System.Object, e As System.EventArgs) Handles btnImpLinkID.Click
        dlgOpenTest.ShowDialog()
        FileName = dlgOpenTest.FileName
        lName = FileName.Length

        nLinks = 0
        ReDim iEleLink(1, Math.Max(nLinks - 1, 0))
        ReDim l0Link(Math.Max(nLinks - 1, 0))
        ReDim kLinkPos(Math.Max(nLinks - 1, 0))
        ReDim kLinkNeg(Math.Max(nLinks - 1, 0))
        Call ImportLinksByID(nLinks, iEleLink, l0Link, kLinkPos, kLinkNeg, nEle, xEle, yEle, FileName, lName)
        'First call get the number of links so that we can redim the variables

        ReDim iEleLink(1, Math.Max(nLinks - 1, 0))
        ReDim l0Link(Math.Max(nLinks - 1, 0))
        ReDim kLinkPos(Math.Max(nLinks - 1, 0))
        ReDim kLinkNeg(Math.Max(nLinks - 1, 0))
        Call ImportLinksByID(nLinks, iEleLink, l0Link, kLinkPos, kLinkNeg, nEle, xEle, yEle, FileName, lName)

        btnImpLinkCoord.Enabled = False
        btnImpLinkID.Enabled = False
        canvas.Invalidate()

    End Sub

    Private Sub btnExportLinks_Click(sender As System.Object, e As System.EventArgs) Handles btnExportLinks.Click
        SaveSnapshot.ShowDialog()
        FileName = SaveSnapshot.FileName
        lName = FileName.Length

        Call ExPortLinks(nLinks, iEleLink, l0Link, kLinkPos, kLinkNeg, nEle, xEle, yEle, FileName, lName)
    End Sub

    Private Sub chkHLLinks_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkHLLinks.CheckedChanged
        canvas.Invalidate()

    End Sub


    Private Sub setQLimit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setQLimit.ValueChanged
        qMax = setQLimit.Value
    End Sub

    Private Sub setInitialLoadDirection_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setInitialLoadDirection.CheckedChanged
        If setInitialLoadDirection.Checked = True Then
            iDirecCyc = -1
        Else
            iDirecCyc = 1
        End If
    End Sub

    Private Sub setCyclicDisplacement_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setCyclicDisplacement.ValueChanged
        cDisp = setCyclicDisplacement.Value
    End Sub

    Private Sub chkExpWallPosition_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkExpWallPosition.CheckedChanged
        If chkExpWallPosition.Checked Then
            textEleQuery.Text = ""
            textEleQuery.AppendText("step" & " , ")
            For iWall As Integer = 0 To nWall - 1
                textEleQuery.AppendText("W_" & (iWall + 1).ToString() & "_ax, " & "W_" & (iWall + 1).ToString() & "_ay, " & "W_" & (iWall + 1).ToString() & "_bx, " & "W_" & (iWall + 1).ToString() & "_by, ")
            Next
            textEleQuery.AppendText(Environment.NewLine)
        End If
    End Sub

    Private Sub btnStartCoordNumMatrix_Click(sender As System.Object, e As System.EventArgs) Handles btnStartCoordNumMatrix.Click
        CalculateDNMatrix()
        chkShowCNMatrix.Checked = True
        canvas.Invalidate()

    End Sub

    Private Sub CalculateDNMatrix()
        Dim nX As Integer = (limitAll(1) - limitAll(0)) / setCoordNumMatrixSampIntv.Value + 1
        Dim nY As Integer = (limitAll(3) - limitAll(2)) / setCoordNumMatrixSampIntv.Value + 1
        ReDim xCNBox(nX - 1)
        ReDim yCNBox(nY - 1)
        Dim lBox As Double = setCoordNumMatrixBoxSize.Value
        Dim dX As Double = setCoordNumMatrixSampIntv.Value
        ReDim coordNumMatrix(nX - 1, nY - 1)
        ReDim colorCNMatrix(2, nX - 1, nY - 1)

        Dim maxCN As Double = -1.0E+100
        Dim minCN As Double = 1.0E+100
        ' It will be faster if we get the rgb values through a loop in Fortran, but I just want something quick today.  Will revisit if speed becomes a issue.
        For ix As Integer = 0 To nX - 1
            xCNBox(ix) = limitAll(0) + ix * dX
            For iy As Integer = 0 To nY - 1
                yCNBox(iy) = limitAll(2) + iy * dX
                Call BoxCN(xCNBox(ix), yCNBox(iy), lBox, coordNumMatrix(ix, iy), _
                                             nEle, nActEle, xEle, yEle, nCon, xCon, yCon, flagConBoun, pairCon, flagEMask)
                If coordNumMatrix(ix, iy) > 0 Then
                    maxCN = Math.Max(maxCN, coordNumMatrix(ix, iy))
                    minCN = Math.Min(minCN, coordNumMatrix(ix, iy))
                    'textEleQuery.AppendText(xCNBox(ix).ToString() & ", " & yCNBox(iy).ToString() & ", " & coordNumMatrix(ix, iy).ToString() & Environment.NewLine)
                End If
            Next
        Next

        If chkFixDNColor.Checked = False Then
            setCNLowB.Value = minCN
            setCNUpB.Value = maxCN
        End If
        SummaryDNMatrix(2)
    End Sub


    Private Sub subDrawCNMatrix(ByRef graphObj As Graphics)
        Dim dX As Double = setCoordNumMatrixSampIntv.Value
        Dim rMin As Double = setCNLowB.Value
        Dim rMax As Double = setCNUpB.Value
        Dim RGB() As Integer = New Integer(2) {}
        Dim brushCN As SolidBrush = New SolidBrush(Color.Beige)

        For ix As Integer = 0 To xCNBox.Length - 1
            For iy As Integer = 0 To yCNBox.Length - 1
                If coordNumMatrix(ix, iy) > 0 Then
                    Call ColorValue(coordNumMatrix(ix, iy), rMin, rMax, RGB)
                    brushCN.Color = Color.FromArgb(200, RGB(0), RGB(1), RGB(2))
                    graphObj.FillRectangle(brushCN, X2Scr(xCNBox(ix) - dX / 2), Y2Scr(yCNBox(iy) + dX / 2), Convert.ToSingle(dX * zoomScale), Convert.ToSingle(dX * zoomScale))
                End If
            Next
        Next
    End Sub

    Private Sub setCNLowB_ValueChanged(sender As System.Object, e As System.EventArgs) Handles setCNLowB.ValueChanged
        canvas.Invalidate()

    End Sub

    Private Sub setCNUpB_ValueChanged(sender As System.Object, e As System.EventArgs) Handles setCNUpB.ValueChanged
        canvas.Invalidate()
    End Sub

    Private Sub btnExpCoordNumMatrix_Click(sender As System.Object, e As System.EventArgs) Handles btnExpCoordNumMatrix.Click
        textEleQuery.Text = ""
        For ix As Integer = 0 To xCNBox.Length - 1
            For iy As Integer = 0 To yCNBox.Length - 1
                If coordNumMatrix(ix, iy) > 0 Then
                    textEleQuery.AppendText(xCNBox(ix).ToString() & ", " & yCNBox(iy).ToString() & ", " & coordNumMatrix(ix, iy).ToString() & Environment.NewLine)
                End If
            Next
        Next
    End Sub

    Private Sub SummaryDNMatrix(exclLayer As Integer) ' We excelude the boundary cells (variable determines the number of layers)
        Dim meanDN As Double = 0.0
        Dim stdevDN As Double = 0.0
        Dim count As Integer = 0
        For ix As Integer = exclLayer To xCNBox.Length - 1 - exclLayer
            For iy As Integer = exclLayer To yCNBox.Length - 1 - exclLayer
                If coordNumMatrix(ix, iy) > 0 Then
                    count += 1
                    meanDN += coordNumMatrix(ix, iy)
                End If
            Next
        Next

        If count > 1 Then
            meanDN /= count
            For ix As Integer = exclLayer To xCNBox.Length - 1 - exclLayer
                For iy As Integer = exclLayer To yCNBox.Length - 1 - exclLayer
                    If coordNumMatrix(ix, iy) > 0 Then
                        stdevDN += (coordNumMatrix(ix, iy) - meanDN) ^ 2.0
                    End If
                Next
            Next
            stdevDN = (stdevDN / (count - 1)) ^ 0.5
        End If
        textEleQuery.AppendText(iCurStep(0).ToString() & ", " & meanDN.ToString() & ", " & stdevDN.ToString() & Environment.NewLine)
    End Sub

 
    Private Sub chkTracDNSpatial_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTracDNSpatial.CheckedChanged
        textEleQuery.Text = ""
    End Sub

    Private Sub btnCalMinDist_Click(sender As System.Object, e As System.EventArgs) Handles btnCalMinDist.Click
        CalculateMinDistance()
    End Sub

    Private Sub CalculateMinDistance()
        Call DomainLimit(nEle, nActEle, xEle, yEle, rEle, nVertex, xVertex, yVertex, boundELe, limitAll, hSector)

        limitAll(0) -= maxGap
        limitAll(1) += maxGap
        limitAll(2) -= maxGap
        limitAll(3) += maxGap


        nGridY = (limitAll(3) - limitAll(2)) / xGrid + 1
        nGridX = (limitAll(1) - limitAll(0)) / xGrid + 1
        maxNEleGrid = Math.Max((xGrid ^ 2 / (volSld / nActEle) * 4), 10)   'Potentially problematic
        ReDim nEleGrid(nGridY - 1, nGridX - 1)
        ReDim lEG(maxNEleGrid - 1, nGridY - 1, nGridX - 1)


        Call Grid(nEle, nActEle, nVertex, xEle, yEle, rEle, xVertex, yVertex, nGridX, nGridY, nEleGrid, lEG, xGrid, boundELe, limitAll, maxNEleGrid)

  
        flag1stEF = 1  ' only transfer npair to oldnpair when EleFrd is called the first time
        Call EleFrd(nEle, xEle, yEle, rEle, nVertex, xVertex, yVertex, pair, nPair, nGridX, nGridY, nEleGrid, _
            lEG, maxGap, nEleFrd, pairIndex, oldNPair, oldPair, oldNEleFrd, oldPairIndex, alwNEleFrd, _
            maxNEleFrd, flag1stEF, maxNEleGrid, hSector)

        Dim nDistEle() As Integer = New Integer(nEle - 1) {}
        Dim distEle(,) As Double = New Double(nEle - 1, alwNEleFrd - 1) {}
        Dim meanDist() As Double = New Double(2) {}
        Dim stdevDist() As Double = New Double(2) {}

        Call CalMinDist(nEle, nActEle, xEle, yEle, rEle, nVertex, pair, nPair, alwNEleFrd, nDistEle, distEle, meanDist, stdevDist)
        If chkTrackMinDist.Checked Then
            textEleQuery.AppendText(iCurStep(0).ToString() & ", " & meanDist(0).ToString() & ", " & meanDist(1).ToString() & ", " & meanDist(2).ToString() & ", " _
                                    & stdevDist(0).ToString() & ", " & stdevDist(1).ToString() & ", " & stdevDist(2).ToString() & ", " & Environment.NewLine)
        End If

    End Sub

    Private Sub chkTrackMinDist_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTrackMinDist.CheckedChanged
        If chkTrackMinDist.Checked Then
            textEleQuery.Text = "step, mean1, mean2, mean3, stdev1, stdev2, stdev3" & Environment.NewLine
        End If
    End Sub
End Class
