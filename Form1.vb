Public Class Main

    Private Sub AboutGpl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutGpl.Click
        MsgBox("Tool by Leprechaun - tardis.leprechaun@gmail.com" + vbCrLf + vbCrLf + "Rilasciato sotto licenza GPLv3")
    End Sub

    Private Sub Sfoglia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sfoglia.Click
        DialogPercorso.ShowDialog()
        percorso.Text = DialogPercorso.FileName
    End Sub

    Private Sub PasswordCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordCheck.CheckedChanged
        If PasswordCheck.Checked = True Then
            password.ReadOnly = False
        Else
            password.ReadOnly = True
        End If
    End Sub

    Private Sub RuotaCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RuotaCheck.CheckedChanged
        If RuotaCheck.Checked = True Then
            rotazione.Enabled = True
        Else
            rotazione.Enabled = False
        End If
    End Sub

    Private Sub percorso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles percorso.TextChanged
        If percorso.Text = "" Then
            Converti.Enabled = False
        Else
            Converti.Enabled = True
        End If
    End Sub

    Private Sub Converti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Converti.Click
        Dim paramvar As String
        paramvar = ""
        If PasswordCheck.Checked = True Then
            paramvar = paramvar + "-openpwd " + password.Text + " "
        End If
        If RuotaCheck.Checked = True Then
            paramvar = paramvar + "-rotate " + rotazione.Text + " "
        End If
        If NovuoteCheck.Checked = True Then
            paramvar = paramvar + "-noempty "
        End If

        If DEBUG.Checked = True Then
            MsgBox("ps2pdf.exe " + paramvar + """" + percorso.Text + """")
        Else
            System.Diagnostics.Process.Start("ps2pdf.exe", paramvar + """" + percorso.Text + """")
        End If
    End Sub

    Private Sub Main_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        If DEBUG.Visible = True Then
            DEBUG.Visible = False
        Else
            DEBUG.Visible = True
        End If
    End Sub
End Class
