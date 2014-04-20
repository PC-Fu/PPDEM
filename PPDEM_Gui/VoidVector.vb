Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Public Class VoidVector

    Dim scaleScr As Double
    Dim penBlack As Pen = New Pen(Color.Black, 3)

    Private Sub VoidVector_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        PPDEM.chkShowVCFabric.Checked = False
    End Sub

    Private Sub VoidVector_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim maxBin As Double
        Me.Width = 414
        Me.Height = 680
        scaleScr = 0.0
        For iBin As Integer = 0 To PPDEM.nBinVV - 1
            maxBin = Math.Max(maxBin, PPDEM.binVV(iBin))
        Next
        If maxBin > 0.0 Then
            scaleScr = canvasVVRose.Width * 0.4 / maxBin
        End If

        InvalidateMe()

    End Sub



    Private Sub VoidVector_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        canvasVVRose.Width = Math.Min(Me.Width - 14, Me.Height - 280)
        canvasVVRose.Height = canvasVVRose.Width
        InvalidateMe()


    End Sub


    Private Sub canvasVVRose_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles canvasVVRose.Paint
        Dim roseVV As Graphics = e.Graphics
        Dim r1, r2, q1, q2 As Double
        For iBin As Integer = 0 To PPDEM.nBinVV - 1
            q1 = iBin * Math.PI * 2 / PPDEM.nBinVV
            q2 = (iBin + 1) * Math.PI * 2 / PPDEM.nBinVV
            r1 = PPDEM.binVV(iBin)
            r2 = PPDEM.binVV(iBin)
            roseVV.DrawLine(penBlack, rq2ScrX(r1, q1, scaleScr), rq2ScrY(r1, q1, scaleScr), rq2ScrX(r2, q2, scaleScr), rq2ScrY(r2, q2, scaleScr))

            q1 = ((iBin + 1) Mod PPDEM.nBinVV) * Math.PI * 2 / PPDEM.nBinVV
            q2 = ((iBin + 1) Mod PPDEM.nBinVV) * Math.PI * 2 / PPDEM.nBinVV
            r1 = PPDEM.binVV(iBin)
            r2 = PPDEM.binVV((iBin + 1) Mod PPDEM.nBinVV)
            roseVV.DrawLine(penBlack, rq2ScrX(r1, q1, scaleScr), rq2ScrY(r1, q1, scaleScr), rq2ScrX(r2, q2, scaleScr), rq2ScrY(r2, q2, scaleScr))


        Next
    End Sub

    Private Function rq2ScrX(ByVal r As Double, ByVal q As Double, ByVal scale As Double) As Single
        rq2ScrX = canvasVVRose.Width / 2 + r * Math.Cos(q) * scale
    End Function
    Private Function rq2ScrY(ByVal r As Double, ByVal q As Double, ByVal scale As Double) As Single
        rq2ScrY = canvasVVRose.Height - (canvasVVRose.Height / 2 + r * Math.Sin(q) * scale)
    End Function


    Private Sub chkVVWeight_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVVWeight.CheckedChanged
        If chkVVWeight.Checked Then
            PPDEM.flagVVWeight = 1
        Else
            PPDEM.flagVVWeight = 0
        End If
    End Sub

    Public Sub InvalidateMe()
        canvasVVRose.Invalidate()
        lbVVTs11.Text = PPDEM.tsVV(0, 0).ToString("F05")
        lbVVTs12.Text = PPDEM.tsVV(1, 0).ToString("F05")
        lbVVTs21.Text = PPDEM.tsVV(0, 1).ToString("F05")
        lbVVTs22.Text = PPDEM.tsVV(1, 1).ToString("F05")
        lbVVTsI.Text = PPDEM.tsVVP(0).ToString("F05")
        lbVVTsII.Text = PPDEM.tsVVP(1).ToString("F05")
        lbVVTsAng1.Text = (PPDEM.tsVVPAng(0) / Math.PI * 180).ToString("F05")
        lbVVTsAng2.Text = (PPDEM.tsVVPAng(1) / Math.PI * 180).ToString("F05")

    End Sub

    Private Sub chkVVTop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVVTop.CheckedChanged
        If chkVVTop.Checked Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub Label1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.DoubleClick
        Dim r1, r2, q1, q2 As Double

        PPDEM.textEleQuery.Text = ""
        For iBin As Integer = 0 To PPDEM.nBinVV - 1
            q1 = iBin * Math.PI * 2 / PPDEM.nBinVV
            q2 = (iBin + 1) * Math.PI * 2 / PPDEM.nBinVV
            r1 = PPDEM.binVV(iBin)
            r2 = PPDEM.binVV(iBin)
            PPDEM.textEleQuery.AppendText(rq2ScrX(r1, q1, scaleScr).ToString("E03") & ", " & rq2ScrY(r1, q1, scaleScr).ToString("E03") & ", " & rq2ScrX(r2, q2, scaleScr).ToString("E03") & ", " & rq2ScrY(r2, q2, scaleScr).ToString("E03") & ", " & Environment.NewLine)


            q1 = ((iBin + 1) Mod PPDEM.nBinVV) * Math.PI * 2 / PPDEM.nBinVV
            q2 = ((iBin + 1) Mod PPDEM.nBinVV) * Math.PI * 2 / PPDEM.nBinVV
            r1 = PPDEM.binVV(iBin)
            r2 = PPDEM.binVV((iBin + 1) Mod PPDEM.nBinVV)
            PPDEM.textEleQuery.AppendText(rq2ScrX(r1, q1, scaleScr).ToString("E03") & ", " & rq2ScrY(r1, q1, scaleScr).ToString("E03") & ", " & rq2ScrX(r2, q2, scaleScr).ToString("E03") & ", " & rq2ScrY(r2, q2, scaleScr).ToString("E03") & ", " & Environment.NewLine)

        Next
        PPDEM.textEleQuery.SelectAll()
        PPDEM.textEleQuery.Copy()
    End Sub
End Class