
Imports System.Windows.Forms
Imports System.Runtime.InteropServices


Public Class Histgram

    Declare Sub SaveMask Lib "demintel.dll" Alias "SaveMask" (<[In](), Out()> _
    ByRef flagSave As Integer, ByRef nNodeMask As Integer, ByVal Mask() As Integer, ByVal FileName As String, ByRef lName As Integer)

    Dim penBlack As Pen = New Pen(Color.Black, 3)
    Dim brushHG As SolidBrush = New SolidBrush(Color.Gray)
    Dim brushBrown As SolidBrush = New SolidBrush(Color.Brown)
    Dim penRed As Pen = New Pen(Color.Red, 3)
    Dim deltaFabric As Double
    Dim deltaStress As Double
    Dim penPrinAxis = New Pen(Color.Brown, 2)
    Dim flagSave As Integer
    Dim scaleRose As Single
    Dim maxBinFN As Single
    Dim scaleFNT As Single
    Dim scaleRoseFR As Single


    Private Sub Histgram_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ResetRoseFNScale()
    End Sub
    


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub rbGlobHist_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbGlobHist.CheckedChanged
        If rbGlobHist.Checked = True Then
            PPDEM.iHistMode = 0
        Else
            PPDEM.iHistMode = 1
        End If

    End Sub



    Private Sub roseForce_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles roseForce.Paint
        Dim roseF As Graphics = e.Graphics

        scaleRose = 120 / setScalePolar.Value

        If chkShowRefLine.Checked Then
            roseF.DrawLine(Pens.Gray, Convert.ToSingle(150 - Math.Cos(setAngRefLine.Value / 180 * Math.PI) * 135), Convert.ToSingle(164 + Math.Sin(setAngRefLine.Value / 180 * Math.PI) * 135), _
                Convert.ToSingle(150 + Math.Cos(setAngRefLine.Value / 180 * Math.PI) * 135), Convert.ToSingle(164 - Math.Sin(setAngRefLine.Value / 180 * Math.PI) * 135))
        End If

        For i As Integer = 0 To PPDEM.nBinForce * 2 - 1
            roseF.DrawLine(penBlack, 150 + PPDEM.ptBinF(0, 2 * i) * scaleRose, 164 - PPDEM.ptBinF(1, 2 * i) * scaleRose, 150 + PPDEM.ptBinF(0, 2 * i + 1) * scaleRose, 164 - PPDEM.ptBinF(1, 2 * i + 1) * scaleRose)

            'roseF.DrawLine(Pens.Brown, 150, 164, PPDEM.ptBinF(0, 2 * i), PPDEM.ptBinF(1, 2 * i))

        Next


        For i As Integer = 0 To PPDEM.nBinForce * 2 - 2
            roseF.DrawLine(penBlack, 150 + PPDEM.ptBinF(0, 2 * i + 1) * scaleRose, 164 - PPDEM.ptBinF(1, 2 * i + 1) * scaleRose, 150 + PPDEM.ptBinF(0, 2 * i + 2) * scaleRose, 164 - PPDEM.ptBinF(1, 2 * i + 2) * scaleRose)

        Next
        roseF.DrawLine(penBlack, 150 + PPDEM.ptBinF(0, 4 * PPDEM.nBinForce - 1) * scaleRose, 164 - PPDEM.ptBinF(1, 4 * PPDEM.nBinForce - 1) * scaleRose, 150 + PPDEM.ptBinF(0, 0) * scaleRose, 164 - PPDEM.ptBinF(1, 0) * scaleRose)

        roseF.DrawLine(penPrinAxis, Convert.ToSingle(150 - Math.Cos(PPDEM.angBodyStressAxis1) * 150), Convert.ToSingle(164 + Math.Sin(PPDEM.angBodyStressAxis1) * 150), Convert.ToSingle(150 + Math.Cos(PPDEM.angBodyStressAxis1) * 150), Convert.ToSingle(164 - Math.Sin(PPDEM.angBodyStressAxis1) * 150))


    End Sub

    Private Sub roseOrit_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles roseOrit.Paint
        Dim roseE As Graphics = e.Graphics

        scaleRose = 120 / setScalePolar.Value

        If chkShowRefLine.Checked Then
            roseE.DrawLine(Pens.Gray, Convert.ToSingle(150 - Math.Cos(setAngRefLine.Value / 180 * Math.PI) * 135), Convert.ToSingle(164 + Math.Sin(setAngRefLine.Value / 180 * Math.PI) * 135), _
                Convert.ToSingle(150 + Math.Cos(setAngRefLine.Value / 180 * Math.PI) * 135), Convert.ToSingle(164 - Math.Sin(setAngRefLine.Value / 180 * Math.PI) * 135))
        End If

        For i As Integer = 0 To PPDEM.nBinOri * 2 - 1

            roseE.DrawLine(penBlack, 150 + PPDEM.ptBinE(0, 2 * i) * scaleRose, 164 - PPDEM.ptBinE(1, 2 * i) * scaleRose, 150 + PPDEM.ptBinE(0, 2 * i + 1) * scaleRose, 164 - PPDEM.ptBinE(1, 2 * i + 1) * scaleRose)
            'roseE.DrawLine(Pens.Brown, 150, 164, PPDEM.ptBinE(0, 2 * i), PPDEM.ptBinE(1, 2 * i))

        Next

        For i As Integer = 0 To PPDEM.nBinOri * 2 - 2
            roseE.DrawLine(penBlack, 150 + PPDEM.ptBinE(0, 2 * i + 1) * scaleRose, 164 - PPDEM.ptBinE(1, 2 * i + 1) * scaleRose, 150 + PPDEM.ptBinE(0, 2 * i + 2) * scaleRose, 164 - PPDEM.ptBinE(1, 2 * i + 2) * scaleRose)

        Next

        roseE.DrawLine(penBlack, 150 + PPDEM.ptBinE(0, PPDEM.nBinOri * 4 - 1) * scaleRose, 164 - PPDEM.ptBinE(1, PPDEM.nBinOri * 4 - 1) * scaleRose, 150 + PPDEM.ptBinE(0, 0) * scaleRose, 164 - PPDEM.ptBinE(1, 0) * scaleRose)


        roseE.DrawLine(penPrinAxis, Convert.ToSingle(150 - Math.Cos(PPDEM.angFabAxis1) * 150), Convert.ToSingle(164 + Math.Sin(PPDEM.angFabAxis1) * 150), Convert.ToSingle(150 + Math.Cos(PPDEM.angFabAxis1) * 150), Convert.ToSingle(164 - Math.Sin(PPDEM.angFabAxis1) * 150))

        If chkShowRoseLegend.Checked = True Then
            roseE.DrawEllipse(Pens.Blue, 150 - scaleRose, 164 - scaleRose, scaleRose * 2, scaleRose * 2)
        End If

    End Sub

    Private Sub roseNorm_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles roseNorm.Paint
        Dim roseN As Graphics = e.Graphics

        scaleRose = 120 / setScalePolar.Value

        If chkShowRefLine.Checked Then
            roseN.DrawLine(Pens.Gray, Convert.ToSingle(150 - Math.Cos(setAngRefLine.Value / 180 * Math.PI) * 135), Convert.ToSingle(164 + Math.Sin(setAngRefLine.Value / 180 * Math.PI) * 135), _
                Convert.ToSingle(150 + Math.Cos(setAngRefLine.Value / 180 * Math.PI) * 135), Convert.ToSingle(164 - Math.Sin(setAngRefLine.Value / 180 * Math.PI) * 135))
        End If

        Dim triTemp() As Point = New Point(2) {}
        triTemp(0).X = 150
        triTemp(0).Y = 164

        For i As Integer = 0 To PPDEM.nBinNorm * 2 - 1

            roseN.DrawLine(penBlack, 150 + PPDEM.ptBinNorm(0, 2 * i) * scaleRose, 164 - PPDEM.ptBinNorm(1, 2 * i) * scaleRose, 150 + PPDEM.ptBinNorm(0, 2 * i + 1) * scaleRose, 164 - PPDEM.ptBinNorm(1, 2 * i + 1) * scaleRose)
            'roseN.DrawLine(Pens.Brown, 150, 164, PPDEM.ptBinNorm(0, 2 * i), PPDEM.ptBinNorm(1, 2 * i))

        Next

        For i As Integer = 0 To PPDEM.nBinNorm * 2 - 2
            roseN.DrawLine(penBlack, 150 + PPDEM.ptBinNorm(0, 2 * i + 1) * scaleRose, 164 - PPDEM.ptBinNorm(1, 2 * i + 1) * scaleRose, 150 + PPDEM.ptBinNorm(0, 2 * i + 2) * scaleRose, 164 - PPDEM.ptBinNorm(1, 2 * i + 2) * scaleRose)

        Next

        roseN.DrawLine(penBlack, 150 + PPDEM.ptBinNorm(0, PPDEM.nBinNorm * 4 - 1) * scaleRose, 164 - PPDEM.ptBinNorm(1, PPDEM.nBinNorm * 4 - 1) * scaleRose, 150 + PPDEM.ptBinNorm(0, 0) * scaleRose, 164 - PPDEM.ptBinNorm(1, 0) * scaleRose)



        'Dim rosePath As New System.Drawing.Drawing2D.GraphicsPath

        'For j As Integer = 0 To PPDEM.nBinNorm * 4 - 2
        'rosePath.AddLine(Convert.ToSingle(PPDEM.ptBinSlideNorm(0, j)), Convert.ToSingle(PPDEM.ptBinSlideNorm(1, j)), Convert.ToSingle(PPDEM.ptBinSlideNorm(0, j + 1)), Convert.ToSingle(PPDEM.ptBinSlideNorm(1, j + 1)))
        'Next

        'roseN.FillPath(Brushes.Blue, rosePath)


        If chkShowSldNorm.Checked = True Then

            For i As Integer = 0 To PPDEM.nBinNorm * 2 - 1

                triTemp(1).X = PPDEM.ptBinSlideNorm(0, 2 * i) * scaleRose + 150
                triTemp(1).Y = 164 - PPDEM.ptBinSlideNorm(1, 2 * i) * scaleRose
                triTemp(2).X = PPDEM.ptBinSlideNorm(0, 2 * i + 1) * scaleRose + 150
                triTemp(2).Y = 164 - PPDEM.ptBinSlideNorm(1, 2 * i + 1) * scaleRose


                roseN.FillPolygon(Brushes.Blue, triTemp)

            Next
        End If

        roseN.DrawLine(penPrinAxis, Convert.ToSingle(150 - Math.Cos(PPDEM.angFabCN1) * 150), Convert.ToSingle(164 + Math.Sin(PPDEM.angFabCN1) * 150), Convert.ToSingle(150 + Math.Cos(PPDEM.angFabCN1) * 150), Convert.ToSingle(164 - Math.Sin(PPDEM.angFabCN1) * 150))
        If chkShowRoseLegend.Checked = True Then
            roseN.DrawEllipse(Pens.Blue, 150 - scaleRose, 164 - scaleRose, scaleRose * 2, scaleRose * 2)
        End If


    End Sub

    Private Sub roseForceNormTang_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles roseForceNormTang.Paint
        If Me.Width > 800 Then

            Dim roseFNT As Graphics = e.Graphics
            scaleFNT = 120 / maxBinFN / Math.Max((Math.Abs(PPDEM.tsStress(4)) + Math.Abs(PPDEM.tsStress(7))), 0.000001) * setScaleForceNT.Value  ' normalized by the current mean stress
            Dim triTemp() As Point = New Point(2) {}
            triTemp(0).X = 150
            triTemp(0).Y = 164

            For i As Integer = 0 To PPDEM.nBinNorm * 2 - 1
                roseFNT.DrawLine(penBlack, 150 + PPDEM.ptBinFN(0, 2 * i) * scaleFNT, 164 - PPDEM.ptBinFN(1, 2 * i) * scaleFNT, 150 + PPDEM.ptBinFN(0, 2 * i + 1) * scaleFNT, 164 - PPDEM.ptBinFN(1, 2 * i + 1) * scaleFNT)
            Next

            For i As Integer = 0 To PPDEM.nBinNorm * 2 - 2
                roseFNT.DrawLine(penBlack, 150 + PPDEM.ptBinFN(0, 2 * i + 1) * scaleFNT, 164 - PPDEM.ptBinFN(1, 2 * i + 1) * scaleFNT, 150 + PPDEM.ptBinFN(0, 2 * i + 2) * scaleFNT, 164 - PPDEM.ptBinFN(1, 2 * i + 2) * scaleFNT)
            Next

            roseFNT.DrawLine(penBlack, 150 + PPDEM.ptBinFN(0, PPDEM.nBinNorm * 4 - 1) * scaleFNT, 164 - PPDEM.ptBinFN(1, PPDEM.nBinNorm * 4 - 1) * scaleFNT, 150 + PPDEM.ptBinFN(0, 0) * scaleFNT, 164 - PPDEM.ptBinFN(1, 0) * scaleFNT)

            For i As Integer = 0 To PPDEM.nBinNorm * 2 - 1

                triTemp(1).X = PPDEM.ptBinFT(0, 2 * i) * scaleFNT + 150
                triTemp(1).Y = 164 - PPDEM.ptBinFT(1, 2 * i) * scaleFNT
                triTemp(2).X = PPDEM.ptBinFT(0, 2 * i + 1) * scaleFNT + 150
                triTemp(2).Y = 164 - PPDEM.ptBinFT(1, 2 * i + 1) * scaleFNT


                roseFNT.FillPolygon(Brushes.Blue, triTemp)

            Next

        End If

    End Sub
    Private Sub roseShearRatio_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles roseShearRatio.Paint
        If Me.Width > 800 Then

            Dim roseFR As Graphics = e.Graphics
            scaleRoseFR = 120 * setScaleShearRatio.Value

            For i As Integer = 0 To PPDEM.nBinNorm * 2 - 1
                roseFR.DrawLine(penBlack, 150 + PPDEM.ptBinRoseFR(0, 2 * i) * scaleRoseFR, 164 - PPDEM.ptBinRoseFR(1, 2 * i) * scaleRoseFR, 150 + PPDEM.ptBinRoseFR(0, 2 * i + 1) * scaleRoseFR, 164 - PPDEM.ptBinRoseFR(1, 2 * i + 1) * scaleRoseFR)
            Next

            For i As Integer = 0 To PPDEM.nBinNorm * 2 - 2
                roseFR.DrawLine(penBlack, 150 + PPDEM.ptBinRoseFR(0, 2 * i + 1) * scaleRoseFR, 164 - PPDEM.ptBinRoseFR(1, 2 * i + 1) * scaleRoseFR, 150 + PPDEM.ptBinRoseFR(0, 2 * i + 2) * scaleRoseFR, 164 - PPDEM.ptBinRoseFR(1, 2 * i + 2) * scaleRoseFR)
            Next

            roseFR.DrawLine(penBlack, 150 + PPDEM.ptBinRoseFR(0, PPDEM.nBinNorm * 4 - 1) * scaleRoseFR, 164 - PPDEM.ptBinRoseFR(1, PPDEM.nBinNorm * 4 - 1) * scaleRoseFR, 150 + PPDEM.ptBinRoseFR(0, 0) * scaleRoseFR, 164 - PPDEM.ptBinRoseFR(1, 0) * scaleRoseFR)
            If chkShowRoseLegend.Checked = True Then
                roseFR.DrawEllipse(Pens.Blue, 150 - scaleRoseFR, 164 - scaleRoseFR, scaleRoseFR * 2, scaleRoseFR * 2)
            End If


        End If

    End Sub

    Private Sub hgFR_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles hgFR.Paint
        Dim FRPaint As Graphics = e.Graphics
        For i As Integer = 0 To PPDEM.nBinFR - 2
            FRPaint.FillRectangle(brushHG, PPDEM.ptBinFR(0, i), PPDEM.ptBinFR(1, i), PPDEM.ptBinFR(2, i), PPDEM.ptBinFR(3, i))
        Next

        FRPaint.FillRectangle(brushBrown, PPDEM.ptBinFR(0, PPDEM.nBinFR - 1), PPDEM.ptBinFR(1, PPDEM.nBinFR - 1), PPDEM.ptBinFR(2, PPDEM.nBinFR - 1), PPDEM.ptBinFR(3, PPDEM.nBinFR - 1))

        FRPaint.DrawString((PPDEM.BinFR(PPDEM.nBinFR - 1) * 100).ToString("F01") & "% contacts sliding.", Me.Font, Brushes.DarkGray, 150, 5)
    End Sub

    Private Sub btnNewMask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewMask.Click
        PPDEM.flagNewMask = 1
        PPDEM.flagMaskOn = 0
        PPDEM.timerTest.Enabled = False
        PPDEM.btnPause.Text = "Resume"
        PPDEM.nNodeMask = 0
        ReDim PPDEM.Mask(9)
        btnNewMask.Enabled = False

    End Sub

    Private Sub rbMaskHist_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMaskHist.CheckedChanged
        If rbMaskHist.Checked = True Then

            PPDEM.iHistMode = 1
            btnNewMask.Enabled = True
        Else
            PPDEM.iHistMode = 0
            btnNewMask.Enabled = False
        End If
    End Sub

    Private Sub rbWeighted_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbWeighted.CheckedChanged
        If rbWeighted.Checked = True Then
            PPDEM.iWeight = 1
        Else
            PPDEM.iWeight = 0
        End If
    End Sub

    Private Sub Histgram_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        PPDEM.modeHist.Checked = False
    End Sub


    Private Sub chkIBoundMode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIBoundMode.CheckedChanged
        If chkIBoundMode.Checked = True Then
            PPDEM.iBoundMode = 1
        Else
            PPDEM.iBoundMode = 0
        End If
    End Sub



    Private Sub groupTsStress_Invalidated(ByVal sender As Object, ByVal e As System.Windows.Forms.InvalidateEventArgs) Handles groupTsStress.Invalidated
        lbStress11.Text = (PPDEM.tsStress(0)).ToString("F05")
        lbStress12.Text = (PPDEM.tsStress(1)).ToString("F05")
        lbStress21.Text = (PPDEM.tsStress(2)).ToString("F05")
        lbStress22.Text = (PPDEM.tsStress(3)).ToString("F05")

        lbAngStressAxis1.Text = (PPDEM.angStressAxis1 / Math.PI * 180).ToString("F03") & "°"
        lbAngStressAxis2.Text = (PPDEM.angStressAxis2 / Math.PI * 180).ToString("F03") & "°"
        deltaStress = Math.Sqrt(0.25 * (PPDEM.tsStress(0) - PPDEM.tsStress(3)) ^ 2 + PPDEM.tsStress(1) ^ 2)
        lbPrnStress1.Text = (0.5 * (PPDEM.tsStress(0) + PPDEM.tsStress(3)) + deltaStress).ToString("F05")
        lbPrnStress2.Text = (0.5 * (PPDEM.tsStress(0) + PPDEM.tsStress(3)) - deltaStress).ToString("F05")

        lbContactNumber.Text = "Coordination Number: " & PPDEM.numContact.ToString("F03") '

        If checkStsBExp.Checked = True Then
            PPDEM.textEleQuery.AppendText(PPDEM.iCurStep(0).ToString & " , " _
                                          & lbStress11.Text & " , " & lbStress12.Text & " , " & lbStress21.Text & " , " & lbStress22.Text & " , " _
                                          & lbPrnStress1.Text & " , " & lbPrnStress2.Text & " , " & (PPDEM.angStressAxis1 / Math.PI * 180).ToString("F03") _
                                          & " , " & Environment.NewLine)
        End If


    End Sub


    Private Sub groupTsBodyStress_Invalidated(ByVal sender As Object, ByVal e As System.Windows.Forms.InvalidateEventArgs) Handles groupTsBodyStress.Invalidated
        lbBodyStress11.Text = (PPDEM.tsStress(4)).ToString("F05")
        lbBodyStress12.Text = (PPDEM.tsStress(5)).ToString("F05")
        lbBodyStress21.Text = (PPDEM.tsStress(6)).ToString("F05")
        lbBodyStress22.Text = (PPDEM.tsStress(7)).ToString("F05")

        lbAngBodyStressAxis1.Text = (PPDEM.angBodyStressAxis1 / Math.PI * 180).ToString("F03") & "°"
        lbAngBodyStressAxis2.Text = (PPDEM.angBodyStressAxis2 / Math.PI * 180).ToString("F03") & "°"
        deltaStress = Math.Sqrt(0.25 * (PPDEM.tsStress(4) - PPDEM.tsStress(7)) ^ 2 + PPDEM.tsStress(5) ^ 2)
        lbPrnBodyStress1.Text = (0.5 * (PPDEM.tsStress(4) + PPDEM.tsStress(7)) + deltaStress).ToString("F05")
        lbPrnBodyStress2.Text = (0.5 * (PPDEM.tsStress(4) + PPDEM.tsStress(7)) - deltaStress).ToString("F05")

        lbContactNumber.Text = "Coordination Number: " & PPDEM.numContact.ToString("F03") '

        If chkStsExp.Checked = True Then
            PPDEM.textEleQuery.AppendText(PPDEM.iCurStep(0).ToString & " , " _
                                          & lbBodyStress11.Text & " , " & lbBodyStress12.Text & " , " & lbBodyStress21.Text & " , " & lbBodyStress22.Text & " , " _
                                          & lbPrnBodyStress1.Text & " , " & lbPrnBodyStress2.Text & " , " & (PPDEM.angBodyStressAxis1 / Math.PI * 180).ToString("F03") _
                                          & " , " & Environment.NewLine)
        End If


    End Sub


    Private Sub groupTsFabric_Invalidated(ByVal sender As Object, ByVal e As System.Windows.Forms.InvalidateEventArgs) Handles groupTsFabric.Invalidated
        lbFb11.Text = PPDEM.tsFabric(0).ToString("F05")
        lbFb12.Text = PPDEM.tsFabric(1).ToString("F05")
        lbFb21.Text = PPDEM.tsFabric(2).ToString("F05")
        lbFb22.Text = PPDEM.tsFabric(3).ToString("F05")

        lbAngFabAxis1.Text = (PPDEM.angFabAxis1 / Math.PI * 180).ToString("F03") & "°"
        lbAngFabAxis2.Text = (PPDEM.angFabAxis2 / Math.PI * 180).ToString("F03") & "°"
        deltaFabric = Math.Sqrt(0.25 * (PPDEM.tsFabric(0) - PPDEM.tsFabric(3)) ^ 2 + PPDEM.tsFabric(1) ^ 2)
        lbF1.Text = (0.5 * (PPDEM.tsFabric(0) + PPDEM.tsFabric(3)) + deltaFabric).ToString("F05")
        lbF2.Text = (0.5 * (PPDEM.tsFabric(0) + PPDEM.tsFabric(3)) - deltaFabric).ToString("F05")

        If chkFabExp.Checked = True Then
            PPDEM.textEleQuery.AppendText(PPDEM.iCurStep(0).ToString & " , " & lbF1.Text & " , " & (PPDEM.angFabAxis1 / Math.PI * 180).ToString("F03") & " , " & lbFb11.Text & " , " & lbFb22.Text & " , " & lbFb12.Text & " , " & PPDEM.numContact.ToString("F03") & " , " & Environment.NewLine)
        End If

    End Sub

    Private Sub gbFabricConNorm_Invalidated(ByVal sender As Object, ByVal e As System.Windows.Forms.InvalidateEventArgs) Handles gbFabricConNorm.Invalidated
        lbCN11.Text = PPDEM.tsConNorm(0).ToString("F05")
        lbCN12.Text = PPDEM.tsConNorm(1).ToString("F05")
        lbCN21.Text = PPDEM.tsConNorm(2).ToString("F05")
        lbCN22.Text = PPDEM.tsConNorm(3).ToString("F05")

        lbAngFabCN1.Text = (PPDEM.angFabCN1 / Math.PI * 180).ToString("F03") & "°"
        lbAngFabCN2.Text = (PPDEM.angFabCN2 / Math.PI * 180).ToString("F03") & "°"
        deltaFabric = Math.Sqrt(0.25 * (PPDEM.tsConNorm(0) - PPDEM.tsConNorm(3)) ^ 2 + PPDEM.tsConNorm(1) ^ 2)
        lbCN1.Text = (0.5 * (PPDEM.tsConNorm(0) + PPDEM.tsConNorm(3)) + deltaFabric).ToString("F05")
        lbCN2.Text = (0.5 * (PPDEM.tsConNorm(0) + PPDEM.tsConNorm(3)) - deltaFabric).ToString("F05")

        If chkCNExp.Checked = True Then
            PPDEM.textEleQuery.AppendText(PPDEM.iCurStep(0).ToString & " , " & lbCN1.Text & " , " & (PPDEM.angFabCN1 / Math.PI * 180).ToString("F03") & " , " & lbCN11.Text & " , " & lbCN22.Text & " , " & lbCN12.Text & " , " & PPDEM.numContact.ToString("F03") & " , " & Environment.NewLine)
        End If

    End Sub

    Private Sub rbFabricWeightXX_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFabricWeightXX.CheckedChanged
        If rbFabricWeightXX.Checked = True Then
            PPDEM.jWeight = 1
        End If
    End Sub

    Private Sub rbFabricWeightYY_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFabricWeightYY.CheckedChanged
        If rbFabricWeightYY.Checked = True Then
            PPDEM.jWeight = 4
        End If
    End Sub

    Private Sub rbFabricWeightXY_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFabricWeightXY.CheckedChanged
        If rbFabricWeightXY.Checked = True Then
            PPDEM.jWeight = 2
        End If

    End Sub

    Private Sub rbFabricWeightBulk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFabricWeightBulk.CheckedChanged
        If rbFabricWeightBulk.Checked = True Then
            PPDEM.jWeight = 5
        End If

    End Sub

    Private Sub rbFabricWeightMaxShear_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFabricWeightMaxShear.CheckedChanged
        If rbFabricWeightMaxShear.Checked = True Then
            PPDEM.jWeight = 6
        End If

    End Sub

    Private Sub rbFabricWeightNone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFabricWeightNone.CheckedChanged
        If rbFabricWeightNone.Checked = True Then
            PPDEM.jWeight = 0
        End If

    End Sub

    Private Sub setTransHist_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setTransHist.Scroll
        Me.Opacity = 1 - setTransHist.Value / 25

    End Sub

    Private Sub setAngRefLine_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setAngRefLine.ValueChanged
        roseForce.Invalidate()
        roseNorm.Invalidate()
        roseOrit.Invalidate()


    End Sub

    Private Sub chkFabExp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFabExp.CheckedChanged
        If chkFabExp.Checked = True Then
            PPDEM.textEleQuery.Text = ""
            PPDEM.textEleQuery.AppendText("step" & " , " & "F_I" & " , " & "Ang_F_I" & " , " & "F_11" & " , " & "F_22" & " , " & "F_12" & " , " & "Coordination Num." & " , " & Environment.NewLine)

        End If
    End Sub

    Private Sub chkStsExp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStsExp.CheckedChanged
        If chkStsExp.Checked = True Then
            PPDEM.textEleQuery.Text = ""
            PPDEM.textEleQuery.AppendText("iStep" & " , " _
                              & "stress_11" & " , " & "stress_12" & " , " & "stress_21" & " , " & "stress_22" & " , " _
                              & "stress_I" & " , " & "stress_II" & " , " & "ang_I" _
                              & " , " & Environment.NewLine)

        End If
    End Sub

    Private Sub chkAlwaysTop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAlwaysTop.CheckedChanged
        If chkAlwaysTop.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If

    End Sub

    Private Sub btnExpMask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpMask.Click
        If PPDEM.nNodeMask < 1 Then
            MessageBox.Show("There is no active mask.")
        Else
            flagSave = 1

            PPDEM.SaveSnapshot.ShowDialog()
            PPDEM.FileName = PPDEM.SaveSnapshot.FileName
            PPDEM.lName = PPDEM.FileName.Length

            If PPDEM.lName > 0 Then
                Call SaveMask(flagSave, PPDEM.nNodeMask, PPDEM.Mask, PPDEM.FileName, PPDEM.lName)
            End If

        End If
    End Sub

    Private Sub btnImpMask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpMask.Click
        flagSave = 0

        PPDEM.dlgOpenTest.ShowDialog()
        PPDEM.FileName = PPDEM.dlgOpenTest.FileName
        PPDEM.lName = PPDEM.FileName.Length

        If PPDEM.lName > 0 Then
            Call SaveMask(flagSave, PPDEM.nNodeMask, PPDEM.Mask, PPDEM.FileName, PPDEM.lName)
        End If

        PPDEM.flagMaskOn = 1

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.DoubleClick
        PPDEM.textEleQuery.Text = ""
        For i As Integer = 0 To PPDEM.nBinOri * 4 - 1
            PPDEM.textEleQuery.AppendText(PPDEM.ptBinE(0, i).ToString("E03") & ", " & PPDEM.ptBinE(1, i).ToString("E03") & Environment.NewLine)
        Next
        PPDEM.textEleQuery.AppendText(PPDEM.ptBinE(0, 0).ToString("E03") & ", " & PPDEM.ptBinE(1, 0).ToString("E03") & Environment.NewLine)
        PPDEM.textEleQuery.SelectAll()
        PPDEM.textEleQuery.Copy()

    End Sub

    Private Sub setScaleRatio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setScalePolar.ValueChanged
        PPDEM.scalePolar = setScalePolar.Value
        PPDEM.canvas.Invalidate()
    End Sub


    Private Sub Label11_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label11.DoubleClick
        PPDEM.textEleQuery.Text = ""
        For i As Integer = 0 To PPDEM.nBinNorm * 4 - 1
            PPDEM.textEleQuery.AppendText(PPDEM.ptBinNorm(0, i).ToString("E03") & ", " & PPDEM.ptBinNorm(1, i).ToString("E03") & Environment.NewLine)
        Next
        PPDEM.textEleQuery.AppendText(PPDEM.ptBinNorm(0, 0).ToString("E03") & ", " & PPDEM.ptBinNorm(1, 0).ToString("E03") & Environment.NewLine)
        PPDEM.textEleQuery.SelectAll()
        PPDEM.textEleQuery.Copy()
    End Sub

    Private Sub Label13_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label13.DoubleClick
        PPDEM.textEleQuery.Text = ""
        For i As Integer = 0 To PPDEM.nBinFR - 1
            PPDEM.textEleQuery.AppendText(PPDEM.BinFR(i).ToString("E03") & Environment.NewLine)
        Next
        PPDEM.textEleQuery.SelectAll()
        PPDEM.textEleQuery.Copy()

    End Sub

    Private Sub chkCNExp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCNExp.CheckedChanged
        If chkCNExp.Checked = True Then
            PPDEM.textEleQuery.Text = ""
            PPDEM.textEleQuery.AppendText("step" & " , " & "FN_I" & " , " & "ang_N1" & " , " & "FN_11" & " , " & "FN_22" & " , " & "FN_12" & " , " & "coordination num." & " , " & Environment.NewLine)

        End If

    End Sub

   
    
    Private Sub lbExpandWindow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbExpandWindow.Click
        If Me.Width < 800 Then
            Me.Width = 940
            lbExpandWindow.Text = "<"
        Else
            Me.Width = 633
            lbExpandWindow.Text = ">"

        End If

        ResetRoseFNScale()

    End Sub

   
    Private Sub btnResetScaleForceNT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetScaleForceNT.Click
        ResetRoseFNScale()

    End Sub

    Private Sub ResetRoseFNScale()
        maxBinFN = 0.0001
        For i As Integer = 0 To PPDEM.nBinNorm - 1
            maxBinFN = Math.Max(maxBinFN, PPDEM.BinFN(i))
        Next
        If Math.Abs(PPDEM.tsStress(4)) * Math.Abs(PPDEM.tsStress(7)) > 0 Then
            maxBinFN = maxBinFN / (Math.Abs(PPDEM.tsStress(4)) + Math.Abs(PPDEM.tsStress(7)))

        End If
    End Sub

    Private Sub setScaleForceNT_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setScaleForceNT.ValueChanged
        PPDEM.canvas.Invalidate()
    End Sub

    Private Sub setScaleShearRatio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setScaleShearRatio.ValueChanged
        PPDEM.canvas.Invalidate()
    End Sub

   
 
    Private Sub checkStsBExp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkStsBExp.CheckedChanged
        If checkStsBExp.Checked = True Then
            PPDEM.textEleQuery.Text = "Stress by boundary forces"
            PPDEM.textEleQuery.AppendText("iStep" & " , " _
                              & "stress_11" & " , " & "stress_12" & " , " & "stress_21" & " , " & "stress_22" & " , " _
                              & "stress_I" & " , " & "stress_II" & " , " & "ang_I" _
                              & " , " & Environment.NewLine)

        End If

    End Sub


End Class
