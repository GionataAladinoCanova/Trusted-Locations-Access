Imports Microsoft.Win32

Public Class Visualizzazione
    Dim MaxLocationID As Integer

    Private Sub AggiornaTreeview()
        ' Apre la chiave di registro che contiene tutti i percorsi già definiti
        Dim pRegKey As RegistryKey = Nothing

        TreeView1.Nodes.Clear()

        If RadioButton1.Checked Then
            pRegKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Office\\12.0\\Access\\Security\\Trusted Locations\\")
            If pRegKey Is Nothing Then
                MsgBox("Chiave non presente. Se Access 2007 è installato, avviare prima il Runtime di Access 2007. Se è già stato fatto, contattare l'amministratore.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If

        If RadioButton2.Checked Then
            pRegKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Office\\14.0\\Access\\Security\\Trusted Locations\\")
            If pRegKey Is Nothing Then
                MsgBox("Chiave non presente. Se Access 2010 è installato, avviare prima il Runtime di Access 2010. Se è già stato fatto, contattare l'amministratore.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If

        If RadioButton3.Checked Then
            pRegKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Office\\15.0\\Access\\Security\\Trusted Locations\\")
            If pRegKey Is Nothing Then
                MsgBox("Chiave non presente. Se Access 2013 è installato, avviare prima il Runtime di Access 2013. Se è già stato fatto, contattare l'amministratore.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If

        If RadioButton4.Checked Then
            pRegKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Office\\16.0\\Access\\Security\\Trusted Locations\\")
            If pRegKey Is Nothing Then
                MsgBox("Chiave non presente. Se Access 2016 è installato, avviare prima il Runtime di Access 2016. Se è già stato fatto, contattare l'amministratore.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If

        If pRegKey Is Nothing Then Exit Sub

        ' Li scorre tutti
        For Each subKeyName As String In pRegKey.GetSubKeyNames()
            Dim LocationKey As RegistryKey = pRegKey.OpenSubKey(subKeyName)

            Dim TempLocationID As Integer = Mid(subKeyName, 9, 10)

            If TempLocationID > MaxLocationID Then MaxLocationID = TempLocationID

            Dim NodoCorrente As TreeNode
            With TreeView1
                .BeginUpdate()
                NodoCorrente = .Nodes.Add(subKeyName, LocationKey.GetValue("Path"))
                If Not LocationKey.GetValue("Description") Is Nothing Then
                    NodoCorrente.Nodes.Add("Descrizione: " & LocationKey.GetValue("Description"))
                End If
                If Not LocationKey.GetValue("AllowSubfolders") Is Nothing Then
                    If LocationKey.GetValue("AllowSubfolders") = 1 Then
                        NodoCorrente.Nodes.Add("Accetta tutte le sottocartelle")
                    Else
                        NodoCorrente.Nodes.Add("Accetta solo la cartella corrente")
                    End If
                End If
                .EndUpdate()
            End With
        Next
    End Sub

    Private Sub btnAggiuntaPercorso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAggiuntaPercorso.Click
        AggiuntaPercorso.ShowDialog()
        If AggiuntaPercorso.DialogResult = Windows.Forms.DialogResult.Cancel Then Exit Sub

        If AggiuntaPercorso.CheckBoxAccess12.Checked Then ScriviRegistro("12.0")
        If AggiuntaPercorso.CheckBoxAccess14.Checked Then ScriviRegistro("14.0")
        If AggiuntaPercorso.CheckBoxAccess15.Checked Then ScriviRegistro("15.0")
        If AggiuntaPercorso.CheckBoxAccess16.Checked Then ScriviRegistro("16.0")

        AggiornaTreeview()
    End Sub

    Private Sub ScriviRegistro(ByVal Versione)
        ' Apre la chiave di registro che contiene tutti i percorsi già definiti
        Dim pRegKey As RegistryKey
        pRegKey = Registry.CurrentUser.OpenSubKey(String.Format("Software\\Microsoft\\Office\\{0}\\Access\\Security\\Trusted Locations\\", Versione), True)

        Dim newkey As RegistryKey = pRegKey.CreateSubKey("Location" & MaxLocationID + 1)

        ' Set value of sub key 
        newkey.SetValue("Path", AggiuntaPercorso.Percorso.Text)
        newkey.SetValue("Description", AggiuntaPercorso.Descrizione.Text)
        newkey.SetValue("Date", Now())

        Select Case AggiuntaPercorso.Sottocartelle.CheckState
            Case CheckState.Indeterminate, CheckState.Unchecked
                newkey.SetValue("AllowSubfolders", 1)
                newkey.DeleteValue("AllowSubfolders")
            Case CheckState.Checked
                newkey.SetValue("AllowSubfolders", 1)
        End Select
    End Sub

    Private Sub Visualizzazione_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AggiornaTreeview()
    End Sub

    Private Sub RimuoviChiaveSelezionataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RimuoviChiaveSelezionataToolStripMenuItem.Click

        If TreeView1.SelectedNode.Level > 0 Then
            MsgBox("Selezionare un percorso.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If MsgBox("Vuoi cancellare la chiave '" & TreeView1.SelectedNode.Text & "'?", MsgBoxStyle.Information _
                                                           + MsgBoxStyle.OkCancel _
                                                           + MsgBoxStyle.DefaultButton2) = MsgBoxResult.Cancel Then
            Exit Sub
        End If

        ' Apre la chiave di registro che contiene tutti i percorsi già definiti
        Dim pRegKey As RegistryKey = Nothing
        If Me.RadioButton1.Checked Then
            pRegKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Office\\12.0\\Access\\Security\\Trusted Locations\\", True)
        End If
        If Me.RadioButton2.Checked Then
            pRegKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Office\\14.0\\Access\\Security\\Trusted Locations\\", True)
        End If
        If Me.RadioButton3.Checked Then
            pRegKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Office\\15.0\\Access\\Security\\Trusted Locations\\", True)
        End If
        If Me.RadioButton4.Checked Then
            pRegKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Office\\16.0\\Access\\Security\\Trusted Locations\\", True)
        End If

        pRegKey.DeleteSubKeyTree(TreeView1.SelectedNode.Name)

        AggiornaTreeview()
    End Sub

    Private Sub SelezionaVersioneAccess(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged
        If sender.Checked Then AggiornaTreeview()
    End Sub

End Class
