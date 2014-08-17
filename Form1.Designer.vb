<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.DialogPercorso = New System.Windows.Forms.OpenFileDialog()
        Me.Sfoglia = New System.Windows.Forms.Button()
        Me.GruppoParametri = New System.Windows.Forms.GroupBox()
        Me.DEBUG = New System.Windows.Forms.CheckBox()
        Me.NovuoteCheck = New System.Windows.Forms.CheckBox()
        Me.rotazione = New System.Windows.Forms.ComboBox()
        Me.RuotaCheck = New System.Windows.Forms.CheckBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.PasswordCheck = New System.Windows.Forms.CheckBox()
        Me.percorso = New System.Windows.Forms.TextBox()
        Me.Converti = New System.Windows.Forms.Button()
        Me.AboutGpl = New System.Windows.Forms.PictureBox()
        Me.GruppoParametri.SuspendLayout()
        CType(Me.AboutGpl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DialogPercorso
        '
        Me.DialogPercorso.Filter = "File ps|*.ps"
        Me.DialogPercorso.Title = "Seleziona file"
        '
        'Sfoglia
        '
        Me.Sfoglia.Location = New System.Drawing.Point(13, 12)
        Me.Sfoglia.Name = "Sfoglia"
        Me.Sfoglia.Size = New System.Drawing.Size(249, 31)
        Me.Sfoglia.TabIndex = 0
        Me.Sfoglia.Text = "File da convertire"
        Me.Sfoglia.UseVisualStyleBackColor = True
        '
        'GruppoParametri
        '
        Me.GruppoParametri.Controls.Add(Me.DEBUG)
        Me.GruppoParametri.Controls.Add(Me.NovuoteCheck)
        Me.GruppoParametri.Controls.Add(Me.rotazione)
        Me.GruppoParametri.Controls.Add(Me.RuotaCheck)
        Me.GruppoParametri.Controls.Add(Me.password)
        Me.GruppoParametri.Controls.Add(Me.PasswordCheck)
        Me.GruppoParametri.Location = New System.Drawing.Point(13, 77)
        Me.GruppoParametri.Name = "GruppoParametri"
        Me.GruppoParametri.Size = New System.Drawing.Size(249, 106)
        Me.GruppoParametri.TabIndex = 1
        Me.GruppoParametri.TabStop = False
        Me.GruppoParametri.Text = "Parametri"
        '
        'DEBUG
        '
        Me.DEBUG.AutoSize = True
        Me.DEBUG.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.DEBUG.ForeColor = System.Drawing.Color.Red
        Me.DEBUG.Location = New System.Drawing.Point(138, 76)
        Me.DEBUG.Name = "DEBUG"
        Me.DEBUG.Size = New System.Drawing.Size(72, 21)
        Me.DEBUG.TabIndex = 5
        Me.DEBUG.Text = "Debug"
        Me.DEBUG.UseVisualStyleBackColor = False
        Me.DEBUG.Visible = False
        '
        'NovuoteCheck
        '
        Me.NovuoteCheck.AutoSize = True
        Me.NovuoteCheck.Location = New System.Drawing.Point(6, 75)
        Me.NovuoteCheck.Name = "NovuoteCheck"
        Me.NovuoteCheck.Size = New System.Drawing.Size(116, 21)
        Me.NovuoteCheck.TabIndex = 4
        Me.NovuoteCheck.Text = "Elimina Vuote"
        Me.NovuoteCheck.UseVisualStyleBackColor = True
        '
        'rotazione
        '
        Me.rotazione.Enabled = False
        Me.rotazione.FormattingEnabled = True
        Me.rotazione.Items.AddRange(New Object() {"90", "180", "270"})
        Me.rotazione.Location = New System.Drawing.Point(138, 46)
        Me.rotazione.Name = "rotazione"
        Me.rotazione.Size = New System.Drawing.Size(105, 24)
        Me.rotazione.TabIndex = 3
        Me.rotazione.Text = "90"
        '
        'RuotaCheck
        '
        Me.RuotaCheck.AutoSize = True
        Me.RuotaCheck.Location = New System.Drawing.Point(6, 48)
        Me.RuotaCheck.Name = "RuotaCheck"
        Me.RuotaCheck.Size = New System.Drawing.Size(116, 21)
        Me.RuotaCheck.TabIndex = 2
        Me.RuotaCheck.Text = "Ruota Pagine"
        Me.RuotaCheck.UseVisualStyleBackColor = True
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(138, 19)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.password.ReadOnly = True
        Me.password.Size = New System.Drawing.Size(105, 22)
        Me.password.TabIndex = 1
        '
        'PasswordCheck
        '
        Me.PasswordCheck.AutoSize = True
        Me.PasswordCheck.Location = New System.Drawing.Point(6, 21)
        Me.PasswordCheck.Name = "PasswordCheck"
        Me.PasswordCheck.Size = New System.Drawing.Size(116, 21)
        Me.PasswordCheck.TabIndex = 0
        Me.PasswordCheck.Text = "File password"
        Me.PasswordCheck.UseVisualStyleBackColor = True
        '
        'percorso
        '
        Me.percorso.Location = New System.Drawing.Point(13, 49)
        Me.percorso.Name = "percorso"
        Me.percorso.ReadOnly = True
        Me.percorso.Size = New System.Drawing.Size(249, 22)
        Me.percorso.TabIndex = 2
        '
        'Converti
        '
        Me.Converti.Enabled = False
        Me.Converti.Location = New System.Drawing.Point(13, 189)
        Me.Converti.Name = "Converti"
        Me.Converti.Size = New System.Drawing.Size(249, 31)
        Me.Converti.TabIndex = 3
        Me.Converti.Text = "CONVERTI"
        Me.Converti.UseVisualStyleBackColor = True
        '
        'AboutGpl
        '
        Me.AboutGpl.BackgroundImage = Global.ps2pdf.My.Resources.Resources.gpllogo
        Me.AboutGpl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AboutGpl.Location = New System.Drawing.Point(38, 233)
        Me.AboutGpl.Name = "AboutGpl"
        Me.AboutGpl.Size = New System.Drawing.Size(199, 31)
        Me.AboutGpl.TabIndex = 5
        Me.AboutGpl.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 272)
        Me.Controls.Add(Me.AboutGpl)
        Me.Controls.Add(Me.Converti)
        Me.Controls.Add(Me.percorso)
        Me.Controls.Add(Me.GruppoParametri)
        Me.Controls.Add(Me.Sfoglia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PS2PDF-GUI"
        Me.GruppoParametri.ResumeLayout(False)
        Me.GruppoParametri.PerformLayout()
        CType(Me.AboutGpl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DialogPercorso As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Sfoglia As System.Windows.Forms.Button
    Friend WithEvents GruppoParametri As System.Windows.Forms.GroupBox
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents PasswordCheck As System.Windows.Forms.CheckBox
    Friend WithEvents percorso As System.Windows.Forms.TextBox
    Friend WithEvents rotazione As System.Windows.Forms.ComboBox
    Friend WithEvents RuotaCheck As System.Windows.Forms.CheckBox
    Friend WithEvents NovuoteCheck As System.Windows.Forms.CheckBox
    Friend WithEvents Converti As System.Windows.Forms.Button
    Friend WithEvents AboutGpl As System.Windows.Forms.PictureBox
    Friend WithEvents DEBUG As System.Windows.Forms.CheckBox

End Class
