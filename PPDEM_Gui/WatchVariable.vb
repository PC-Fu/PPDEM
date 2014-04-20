Public NotInheritable Class MonitorSystemVariable

    Private Sub MonitorSystemVariable_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        PPDEM.chkMonitorSystemVariable.Checked = False
    End Sub

    Private Sub WatchVariable_Invalidated(ByVal sender As Object, ByVal e As System.Windows.Forms.InvalidateEventArgs) Handles Me.Invalidated
        Monitor1.Text = Math.Log(PPDEM.monitor(2)).ToString("F02")
        Monitor2.Text = PPDEM.monitor(0).ToString("E03")
        Monitor3.Text = PPDEM.monitor(1).ToString("E03")
        Monitor4.Text = PPDEM.nPair
        showOverRatio.Text = (PPDEM.aOverAll / PPDEM.volSld).ToString("E03")
        Monitor6.Text = PPDEM.monitor(3).ToString("E03")

        showTimeTotal.Text = (PPDEM.timeNow(8) - PPDEM.timeNow(0)).ToString("D")
        showTimeDomain.Text = (PPDEM.timeNow(1) - PPDEM.timeNow(0)).ToString("D")
        showTimeGrid.Text = (PPDEM.timeNow(2) - PPDEM.timeNow(1)).ToString("D")
        showTimeConfine.Text = (PPDEM.timeNow(3) - PPDEM.timeNow(2)).ToString("D")
        showTimeEleFrd.Text = (PPDEM.timeNow(4) - PPDEM.timeNow(3)).ToString("D")
        showTimeInheritPair.Text = (PPDEM.timeNow(5) - PPDEM.timeNow(4)).ToString("D")
        showTimeWallFrd.Text = (PPDEM.timeNow(6) - PPDEM.timeNow(5)).ToString("D")
        showTimeCalPoly.Text = (PPDEM.timeNow(7) - PPDEM.timeNow(6)).ToString("D")
        showTimePlot.Text = (PPDEM.timeNow(8) - PPDEM.timeNow(7)).ToString("D")

        setActEle.Value = PPDEM.actEle + 1

        If chkShowEleInfo.Checked = True Then
            showXEle.Text = PPDEM.xEle(PPDEM.actEle).ToString("E6")
            showYEle.Text = PPDEM.yEle(PPDEM.actEle).ToString("E6")
            showQEle.Text = PPDEM.qEle(PPDEM.actEle).ToString("E6")

        End If


    End Sub

    Private Sub WatchVariable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PPDEM.chkMonitorSystemVariable.Checked = False
        Me.Close()
    End Sub


    Private Sub setActEle_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setActEle.ValueChanged
        PPDEM.actEle = setActEle.Value - 1
        PPDEM.canvas.Invalidate()

    End Sub

End Class
