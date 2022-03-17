<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AggiuntaPercorso
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Percorso = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Descrizione = New System.Windows.Forms.TextBox()
        Me.Sottocartelle = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBoxAccess12 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAccess14 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAccess15 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAccess16 = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(289, 258)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Enabled = False
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Annulla"
        '
        'Percorso
        '
        Me.Percorso.Location = New System.Drawing.Point(31, 42)
        Me.Percorso.Name = "Percorso"
        Me.Percorso.Size = New System.Drawing.Size(411, 20)
        Me.Percorso.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Percorso"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descrizione"
        '
        'Descrizione
        '
        Me.Descrizione.Location = New System.Drawing.Point(31, 126)
        Me.Descrizione.Multiline = True
        Me.Descrizione.Name = "Descrizione"
        Me.Descrizione.Size = New System.Drawing.Size(411, 54)
        Me.Descrizione.TabIndex = 3
        '
        'Sottocartelle
        '
        Me.Sottocartelle.AutoSize = True
        Me.Sottocartelle.Location = New System.Drawing.Point(31, 75)
        Me.Sottocartelle.Name = "Sottocartelle"
        Me.Sottocartelle.Size = New System.Drawing.Size(314, 17)
        Me.Sottocartelle.TabIndex = 5
        Me.Sottocartelle.Text = "Considera attendibili anche le sottocartelle di questo percorso"
        Me.Sottocartelle.ThreeState = True
        Me.Sottocartelle.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(367, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "S&foglia"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBoxAccess12
        '
        Me.CheckBoxAccess12.AutoSize = True
        Me.CheckBoxAccess12.Location = New System.Drawing.Point(56, 209)
        Me.CheckBoxAccess12.Name = "CheckBoxAccess12"
        Me.CheckBoxAccess12.Size = New System.Drawing.Size(88, 17)
        Me.CheckBoxAccess12.TabIndex = 7
        Me.CheckBoxAccess12.Text = "Access 2007"
        Me.CheckBoxAccess12.UseVisualStyleBackColor = True
        '
        'CheckBoxAccess14
        '
        Me.CheckBoxAccess14.AutoSize = True
        Me.CheckBoxAccess14.Location = New System.Drawing.Point(56, 231)
        Me.CheckBoxAccess14.Name = "CheckBoxAccess14"
        Me.CheckBoxAccess14.Size = New System.Drawing.Size(88, 17)
        Me.CheckBoxAccess14.TabIndex = 8
        Me.CheckBoxAccess14.Text = "Access 2010"
        Me.CheckBoxAccess14.UseVisualStyleBackColor = True
        '
        'CheckBoxAccess15
        '
        Me.CheckBoxAccess15.AutoSize = True
        Me.CheckBoxAccess15.Location = New System.Drawing.Point(56, 253)
        Me.CheckBoxAccess15.Name = "CheckBoxAccess15"
        Me.CheckBoxAccess15.Size = New System.Drawing.Size(88, 17)
        Me.CheckBoxAccess15.TabIndex = 9
        Me.CheckBoxAccess15.Text = "Access 2013"
        Me.CheckBoxAccess15.UseVisualStyleBackColor = True
        '
        'CheckBoxAccess16
        '
        Me.CheckBoxAccess16.AutoSize = True
        Me.CheckBoxAccess16.Location = New System.Drawing.Point(56, 276)
        Me.CheckBoxAccess16.Name = "CheckBoxAccess16"
        Me.CheckBoxAccess16.Size = New System.Drawing.Size(88, 17)
        Me.CheckBoxAccess16.TabIndex = 10
        Me.CheckBoxAccess16.Text = "Access 2016"
        Me.CheckBoxAccess16.UseVisualStyleBackColor = True
        '
        'AggiuntaPercorso
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(483, 324)
        Me.Controls.Add(Me.CheckBoxAccess16)
        Me.Controls.Add(Me.CheckBoxAccess15)
        Me.Controls.Add(Me.CheckBoxAccess14)
        Me.Controls.Add(Me.CheckBoxAccess12)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Sottocartelle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Descrizione)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Percorso)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AggiuntaPercorso"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Percorso attendibile di Microsoft Access"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Percorso As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Descrizione As System.Windows.Forms.TextBox
    Friend WithEvents Sottocartelle As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBoxAccess12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxAccess14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxAccess15 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxAccess16 As CheckBox
End Class
