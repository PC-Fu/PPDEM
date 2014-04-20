Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class VR

    Declare Sub VR Lib "demintel.dll" Alias "VR" (<[In](), Out()> _
    ByRef wVRBox As Integer, ByRef hVRBox As Integer, ByVal mapbase(,) As Byte, ByVal RGBBase() As Byte, _
    ByRef VRRange As Integer, ByVal rangeContour() As Double, ByRef relaMin As Double, ByRef relaMax As Double, ByVal VRValue(,) As Single, _
    ByRef bulkGrav As Double, ByRef VRMode As Integer, ByRef nNodeVRMask As Integer, ByVal xVRMask(,) As Double, ByVal flagMask(,) As Byte)



    Public wVRBox As Integer
    Public hVRBox As Integer
    Public VRRange As Integer = 10
    Public boxOffset() As Integer = New Integer(1) {}
    Dim mapBase(,) As Byte
    Dim RGBBase() As Byte
    Dim flagMask(,) As Byte
    Public rangeContour() As Double = New Double(1) {-50, 50}
    Public relaMin As Double
    Public relamax As Double
    Public VRValue(,) As Single
    Public bulkGrav As Double
    Public VRMode As Integer
    Public BMPbase As Bitmap

    Dim flagNewVRMask As Integer = 0
    Dim flagMaskOn As Integer = 0
    Dim nNodeVRMask As Integer = 0
    Dim xVRMask(,) As Double = New Double(1, 9) {}
    Dim xMagVRMask(,) As Double = New Double(1, 9) {}
    Dim magVR As Single = 1
    Dim sizeVRCell As Integer = 100



    Dim ptVRMask() As PointF = New PointF(9) {}
    Public brushMask As SolidBrush = New SolidBrush(Color.FromArgb(100, 200, 50, 200))




    Private Sub VR_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        btnTrack.Enabled = PPDEM.trackPost.Enabled
        Me.SetDesktopLocation(PPDEM.Location.X + 312 + Math.Min(PPDEM.ptBox1.X, PPDEM.ptBox2.X) - 235 + 7, PPDEM.Location.Y + Math.Min(PPDEM.ptBox1.Y, PPDEM.ptBox2.Y) + 7)

        VRBox.Width = wVRBox
        VRBox.Height = hVRBox
        VRContainer.Width = wVRBox + 5
        VRContainer.Height = Math.Max(hVRBox + 5, 100)
        VRRange = setVRRange.Value
        setMagVR.Maximum = 32767 / VRBox.Width
        setMagVR.Value = 1
        showWVR.Text = wVRBox.ToString
        showHVR.Text = hVRBox.ToString

        If wVRBox > 400 Then
            Me.Width = wVRBox + 250
        End If
        If hVRBox > 400 Then
            Me.Height = hVRBox + 50
        Else
            Me.Height = 450
        End If

        DrawBase(1.0)



    End Sub






    Private Sub VR_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        PPDEM.flagNewVRBox = 1
        PPDEM.modeVR.Checked = False
        PPDEM.canvas.Invalidate()

    End Sub



 

    Private Sub setVRRange_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setVRRange.ValueChanged
        VRRange = setVRRange.Value

        VRBox.Invalidate()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        If chkGray.Checked Then
            VRMode = 4
        Else
            VRMode = 1
        End If

        If VRRange > 40 Then
            MessageBox.Show("If the moving average range is large, say > 25, this operation could take few seconds or several minutes.")
        End If
        rangeContour(0) = setMinDensity.Value
        rangeContour(1) = setMaxDensity.Value

        

        Call VR(wVRBox * magVR, hVRBox * magVR, mapBase, RGBBase, VRRange, rangeContour, relaMin, relamax, VRValue, bulkGrav, VRMode, nNodeVRMask, xVRMask, flagMask)

        ShowVR(magVR)
        showMinDensity.Text = relaMin.ToString("F2")
        showMaxDensity.Text = relamax.ToString("F2")




    End Sub

    Private Sub setTransparency_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setTransparency.Scroll
        Me.Opacity = 1 - setTransparency.Value / 100.0
    End Sub

    Private Sub btnVoid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoid.Click
        VRMode = 0

        Call VR(wVRBox * magVR, hVRBox * magVR, mapBase, RGBBase, VRRange, rangeContour, relaMin, relamax, VRValue, bulkGrav, VRMode, nNodeVRMask, xVRMask, flagMask)
        showBulkGrav.Text = ((1 - bulkGrav) / bulkGrav).ToString("F4")

    End Sub

    Private Sub btnNewVRMask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewVRMask.Click
        flagNewVRMask = 1
        nNodeVRMask = 0
        ReDim xVRMask(1, 9)
        btnNewVRMask.Enabled = False

    End Sub

    Private Sub VRBox_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles VRBox.MouseClick

        If e.Button = Windows.Forms.MouseButtons.Middle And flagNewVRMask = 1 And nNodeVRMask < 9 Then

            xVRMask(0, nNodeVRMask) = Convert.ToDouble(e.X)
            xVRMask(1, nNodeVRMask) = Convert.ToDouble(e.Y)

            If nNodeVRMask = 0 Then

                For j As Integer = 1 To 9
                    xVRMask(0, j) = xVRMask(0, 0)    'Initiate all nodes of the mask to the same point.  Otherwise the plot of the mask would be messy.
                    xVRMask(1, j) = xVRMask(1, 0)
                Next

            End If

            nNodeVRMask += 1

            If nNodeVRMask = 9 Then
                InitiateMask()
            End If




        End If


        VRBox.Invalidate()

    End Sub

    Private Sub VRBox_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles VRBox.MouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Left And flagNewVRMask = 1 Then

            Call InitiateMask()
        End If
    End Sub


    Private Sub VRBox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles VRBox.Paint
        Dim VRPaint As Graphics = e.Graphics
        If flagNewVRMask = 1 Then
            For i As Integer = 0 To 9
                ptVRMask(i).X = xVRMask(0, i)
                ptVRMask(i).Y = xVRMask(1, i)
            Next
            VRPaint.FillPolygon(brushMask, ptVRMask)
            VRPaint.DrawPolygon(Pens.Red, ptVRMask)


        End If


    End Sub

   
    Private Sub btnMagVR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMagVR.Click


        magVR = setMagVR.Value

        VRBox.Width = wVRBox * magVR
        VRBox.Height = hVRBox * magVR

        VRContainer.Width = Math.Min(Screen.PrimaryScreen.Bounds.Width - 235, wVRBox * magVR + 10)
        VRContainer.Height = Math.Min(Screen.PrimaryScreen.Bounds.Height - 55, hVRBox * magVR + 50)

        Me.Width = VRContainer.Width + 235
        Me.Height = Math.Max(VRContainer.Height + 35, 450)

        DrawBase(magVR)


        flagNewVRMask = 0
        flagMaskOn = 1

        If nNodeVRMask = 0 Then
            VRMode = 0
        Else
            VRMode = 2

        End If

        For j As Integer = 0 To 9
            xMagVRMask(0, j) = xVRMask(0, j) * magVR
            xMagVRMask(1, j) = xVRMask(1, j) * magVR
        Next
        Call VR(wVRBox * magVR, hVRBox * magVR, mapBase, RGBBase, VRRange, rangeContour, relaMin, relamax, VRValue, bulkGrav, VRMode, nNodeVRMask, xMagVRMask, flagMask)

        ShowVR(magVR)

        btnNewVRMask.Enabled = True
        showVoidMask.Text = ((1 - bulkGrav) / bulkGrav).ToString("F4")



    End Sub

    Private Sub btnCloneMask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloneMask.Click
        cloneMask()

    End Sub

    Private Sub InitiateMask()
        flagNewVRMask = 0
        flagMaskOn = 1
        VRMode = 2

        Call VR(wVRBox * magVR, hVRBox * magVR, mapBase, RGBBase, VRRange, rangeContour, relaMin, relamax, VRValue, bulkGrav, VRMode, nNodeVRMask, xVRMask, flagMask)

        ShowVR(magVR)


        btnNewVRMask.Enabled = 1
        showVoidMask.Text = ((1 - bulkGrav) / bulkGrav).ToString("F4")

    End Sub


  
    Private Sub setMagVR_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setMagVR.ValueChanged
        showWVR.Text = (wVRBox * setMagVR.Value).ToString("F00")
        showHVR.Text = (hVRBox * setMagVR.Value).ToString("F00")
        shwPpM.Text = (0.001 * PPDEM.zoomScale * setMagVR.Value).ToString("F00") & " pixels per mm length"


    End Sub

    Private Sub btnTrack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrack.Click
        PPDEM.textEleQuery.Text = ""

        'For i As Integer = PPDEM.trackPost.Value To PPDEM.trackPost.Maximum - 1
        Do While (PPDEM.trackPost.Value < PPDEM.trackPost.Maximum And PPDEM.flagPause < 1)
            PPDEM.trackPost.Value += 1
            If nNodeVRMask = 0 Then
                DrawBase(magVR)
            Else
                DrawBase(magVR)

                CloneMask()

            End If

            PPDEM.textEleQuery.AppendText(PPDEM.iCurStep(0).ToString & "   " & ((1 - bulkGrav) / bulkGrav).ToString("F4") & Environment.NewLine)
            Call PPDEM.ReadPauseFile(PPDEM.flagPause, PPDEM.curDir, PPDEM.lCurDir)
        Loop

    End Sub

    Private Sub DrawBase(ByVal magVR)

        Dim BMPBase As New Bitmap(Convert.ToInt32(wVRBox * magVR), Convert.ToInt32(hVRBox * magVR))

        Dim drawBMPBase As Graphics = Graphics.FromImage(BMPBase)

        drawBMPBase.FillRectangle(Brushes.White, 0, 0, Convert.ToInt32(wVRBox * magVR), Convert.ToInt32(hVRBox * magVR))

        For i As Integer = 0 To PPDEM.nActEle - 1

            If PPDEM.nVertex(i) = 0 Then
                drawBMPBase.FillEllipse(Brushes.Brown, Convert.ToSingle((PPDEM.xEle(i) - PPDEM.rEle(i)) * PPDEM.zoomScale * magVR) + magVR * PPDEM.xOrigin - magVR * boxOffset(0), _
                PPDEM.canvasContainer.Height * magVR - Convert.ToSingle((PPDEM.yEle(i) + PPDEM.rEle(i)) * PPDEM.zoomScale * magVR) + magVR * PPDEM.yOrigin - magVR * boxOffset(1), _
                Convert.ToSingle(2 * PPDEM.rEle(i) * PPDEM.zoomScale * magVR), _
                Convert.ToSingle(2 * PPDEM.rEle(i) * PPDEM.zoomScale * magVR))

            Else

                Dim polyPath As New System.Drawing.Drawing2D.GraphicsPath

                For j As Integer = 0 To PPDEM.nVertex(i) - 1
                    polyPath.AddArc(Convert.ToSingle((PPDEM.xCE(0, j, i) - PPDEM.rqCE(2, j, i)) * PPDEM.zoomScale * magVR) + PPDEM.xOrigin * magVR - boxOffset(0) * magVR, _
                    PPDEM.canvasContainer.Height * magVR - Convert.ToSingle(((PPDEM.xCE(1, j, i) + PPDEM.rqCE(2, j, i))) * PPDEM.zoomScale * magVR) + PPDEM.yOrigin * magVR - boxOffset(1) * magVR, _
                    Convert.ToSingle(2 * PPDEM.rqCE(2, j, i) * PPDEM.zoomScale * magVR), _
                    Convert.ToSingle(2 * PPDEM.rqCE(2, j, i) * PPDEM.zoomScale * magVR), Convert.ToSingle(-PPDEM.rqCE(3, j, i) / 3.14159 * 180), Convert.ToSingle(-PPDEM.CAC(j, i) / 3.14159 * 180))
                Next

                drawBMPBase.FillPath(Brushes.Brown, polyPath)
            End If

        Next


        VRBox.Image = BMPBase


        ReDim RGBBase(BMPBase.Width * BMPBase.Height * 4 - 1)
        ReDim mapBase(hVRBox * magVR, wVRBox * magVR)
        ReDim VRValue(hVRBox * magVR - 1, wVRBox * magVR - 1)
        ReDim flagMask(hVRBox * magVR - 1, wVRBox * magVR - 1)


        Dim rectBMP As New Rectangle(0, 0, BMPBase.Width, BMPBase.Height)

        Dim dataBMPBase As System.Drawing.Imaging.BitmapData = BMPBase.LockBits(rectBMP, _
        Drawing.Imaging.ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb)

        Dim ptr As IntPtr = dataBMPBase.Scan0

        Dim nByteBMPBase As Integer = dataBMPBase.Stride * BMPBase.Height
        System.Runtime.InteropServices.Marshal.Copy(ptr, RGBBase, 0, nByteBMPBase)


        ' Unlock the bits.
        BMPBase.UnlockBits(dataBMPBase)


        showBulkGravAll.Text = ((1 - (PPDEM.volSld / PPDEM.vol)) / (PPDEM.volSld / PPDEM.vol)).ToString("F4")
    End Sub

    Private Sub CloneMask()
        If PPDEM.nNodeMask > 0 Then
            nNodeVRMask = PPDEM.nNodeMask

            For iM As Integer = 0 To 9

                xVRMask(0, iM) = (PPDEM.xEle(PPDEM.Mask(iM) - 1) * PPDEM.zoomScale + PPDEM.xOrigin - boxOffset(0)) * magVR
                xVRMask(1, iM) = (PPDEM.canvasContainer.Height - (PPDEM.yEle(PPDEM.Mask(iM) - 1) * PPDEM.zoomScale) + PPDEM.yOrigin - boxOffset(1)) * magVR

            Next

            Call InitiateMask()
        End If
    End Sub

    Private Sub ShowVR(ByVal magvr)

        Dim BMPBase As New Bitmap(Convert.ToInt32(wVRBox * magVR), Convert.ToInt32(hVRBox * magVR))

        Dim rectBMP As New Rectangle(0, 0, Convert.ToInt32(wVRBox * magVR), Convert.ToInt32(hVRBox * magVR))

        Dim dataBMPbase As System.Drawing.Imaging.BitmapData = BMPBase.LockBits(rectBMP, _
        Drawing.Imaging.ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb)

        Dim ptr As IntPtr = dataBMPbase.Scan0

        Dim nByteBMPBase As Integer = Convert.ToInt32(wVRBox * magvr) * Convert.ToInt32(hVRBox * magvr) * 4

        System.Runtime.InteropServices.Marshal.Copy(RGBBase, 0, ptr, nByteBMPBase)

        ' Unlock the bits.
        BMPBase.UnlockBits(dataBMPbase)

        VRBox.Image = BMPBase

    End Sub

    
    Private Sub chkAlwaysTop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAlwaysTop.CheckedChanged
        If chkAlwaysTop.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

 
    Private Sub VRBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VRBox.DoubleClick
        PPDEM.SaveSnapshot.Filter = "Tiff Image (*.tif)|*.tiff|All files (*.*)|*.*"
        PPDEM.SaveSnapshot.ShowDialog()
        Dim FileName As String = PPDEM.SaveSnapshot.FileName

        Dim BMPBase As New Bitmap(Convert.ToInt32(wVRBox * magVR), Convert.ToInt32(hVRBox * magVR))

        Dim rectBMP As New Rectangle(0, 0, Convert.ToInt32(wVRBox * magVR), Convert.ToInt32(hVRBox * magVR))

        Dim dataBMPbase As System.Drawing.Imaging.BitmapData = BMPBase.LockBits(rectBMP, _
        Drawing.Imaging.ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb)

        Dim ptr As IntPtr = dataBMPbase.Scan0

        Dim nByteBMPBase As Integer = Convert.ToInt32(wVRBox * magVR) * Convert.ToInt32(hVRBox * magVR) * 4

        System.Runtime.InteropServices.Marshal.Copy(RGBBase, 0, ptr, nByteBMPBase)

        ' Unlock the bits.
        BMPBase.UnlockBits(dataBMPbase)



        BMPbase.Save(FileName, System.Drawing.Imaging.ImageFormat.Tiff)

    End Sub

 
    Private Sub btnCellVR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCellVR.Click
        sizeVRCell = Convert.ToInt32(0.001 * PPDEM.zoomScale * setMagVR.Value * setSizeVRCell.Value)
        If chkGray.Checked Then
            VRMode = 5
        Else
            VRMode = 3
        End If
        rangeContour(0) = setMinDensity.Value
        rangeContour(1) = setMaxDensity.Value
        Call VR(wVRBox * magVR, hVRBox * magVR, mapBase, RGBBase, sizeVRCell, rangeContour, relaMin, relamax, VRValue, bulkGrav, VRMode, nNodeVRMask, xMagVRMask, flagMask)
        ShowVR(magVR)
        showMinDensity.Text = relaMin.ToString("F2")
        showMaxDensity.Text = relamax.ToString("F2")
    End Sub
End Class
