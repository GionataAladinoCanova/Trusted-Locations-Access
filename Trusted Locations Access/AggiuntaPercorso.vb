Imports System.Windows.Forms

Public Class AggiuntaPercorso

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.ShowDialog Then
            Me.Percorso.Text = FolderBrowserDialog1.SelectedPath & "\"
            EnableButtonOk()
        End If
    End Sub

    Private Sub SelezionaVersioneAccess(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxAccess12.CheckedChanged, CheckBoxAccess14.CheckedChanged, CheckBoxAccess15.CheckedChanged, CheckBoxAccess16.CheckedChanged
        EnableButtonOk()
    End Sub

    Private Sub EnableButtonOk()
        OK_Button.Enabled = Me.Percorso.Text.Length > 0 And (CheckBoxAccess12.Checked Or CheckBoxAccess14.Checked Or CheckBoxAccess15.Checked Or CheckBoxAccess16.Checked)
    End Sub

End Class
