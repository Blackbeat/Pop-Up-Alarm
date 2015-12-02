Public Class frmSimple
    Private settime As Integer
    Private origtime As Integer

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        settime = CInt(nudMain.Value)
        If settime = 0 Then
            MsgBox("시간을 설정해주십시오.", vbOKOnly + vbExclamation, "오류")
        Else
            Timer.Enabled = True
        End If

        If Timer.Enabled = True Then
            btnStart.Enabled = False
        End If
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        If Timer.Enabled = False Then
            Me.Close()
        Else
            btnStart.Enabled = True
            Timer.Enabled = False
            nudMain.Value = 0
            nudMain.Focus()
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Dim MsgAnswer As Integer

        Timer.Enabled = True
        origtime += 1
        If settime = origtime Then
            MsgAnswer = MsgBox("빼애애애애액!", MsgBoxStyle.Information + vbOKOnly)
            If MsgAnswer = MsgBoxResult.Ok Then
                btnStart.Enabled = True
                origtime = 0
                nudMain.Value = 0
                Timer.Enabled = False
            End If
        End If
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub mnuSimple_Click(sender As Object, e As EventArgs) Handles mnuSimple.Click
        If mnuSimple.Checked = True Then
            mnuSimple.Enabled = False
            mnuClock.Checked = False
            mnuClock.Enabled = True
            mnuExpert.Checked = False
            mnuExpert.Enabled = True
        End If
    End Sub

    Private Sub mnuClock_Click(sender As Object, e As EventArgs) Handles mnuClock.Click
        Me.Hide()
        frmClock.Show()
        If mnuClock.Checked = True Then
            mnuSimple.Enabled = True
            mnuSimple.Checked = False
            mnuClock.Enabled = False
            mnuExpert.Checked = False
            mnuExpert.Enabled = True
        End If
    End Sub

    Private Sub mnuExpert_Click(sender As Object, e As EventArgs) Handles mnuExpert.Click
        Me.Hide()
        frmExpert.Show()
        If mnuExpert.Checked = True Then
            mnuSimple.Enabled = True
            mnuSimple.Checked = False
            mnuClock.Enabled = True
            mnuClock.Checked = False
            mnuExpert.Enabled = False
        End If
    End Sub
End Class