<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pgdTiere = New System.Windows.Forms.PropertyGrid()
        Me.cbxTiere = New System.Windows.Forms.ComboBox()
        Me.btnNeu = New System.Windows.Forms.Button()
        Me.btnFuettern = New System.Windows.Forms.Button()
        Me.btnEiLegen = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'pgdTiere
        '
        Me.pgdTiere.Location = New System.Drawing.Point(42, 104)
        Me.pgdTiere.Name = "pgdTiere"
        Me.pgdTiere.Size = New System.Drawing.Size(154, 220)
        Me.pgdTiere.TabIndex = 0
        '
        'cbxTiere
        '
        Me.cbxTiere.FormattingEnabled = True
        Me.cbxTiere.Location = New System.Drawing.Point(42, 23)
        Me.cbxTiere.Name = "cbxTiere"
        Me.cbxTiere.Size = New System.Drawing.Size(154, 21)
        Me.cbxTiere.TabIndex = 1
        '
        'btnNeu
        '
        Me.btnNeu.Location = New System.Drawing.Point(202, 21)
        Me.btnNeu.Name = "btnNeu"
        Me.btnNeu.Size = New System.Drawing.Size(75, 23)
        Me.btnNeu.TabIndex = 2
        Me.btnNeu.Text = "Neu"
        Me.btnNeu.UseVisualStyleBackColor = True
        '
        'btnFuettern
        '
        Me.btnFuettern.Location = New System.Drawing.Point(202, 130)
        Me.btnFuettern.Name = "btnFuettern"
        Me.btnFuettern.Size = New System.Drawing.Size(75, 23)
        Me.btnFuettern.TabIndex = 3
        Me.btnFuettern.Text = "Füttern"
        Me.btnFuettern.UseVisualStyleBackColor = True
        '
        'btnEiLegen
        '
        Me.btnEiLegen.Location = New System.Drawing.Point(202, 159)
        Me.btnEiLegen.Name = "btnEiLegen"
        Me.btnEiLegen.Size = New System.Drawing.Size(75, 23)
        Me.btnEiLegen.TabIndex = 4
        Me.btnEiLegen.Text = "Ei legen"
        Me.btnEiLegen.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(283, 130)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(158, 199)
        Me.ListBox1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 360)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnEiLegen)
        Me.Controls.Add(Me.btnFuettern)
        Me.Controls.Add(Me.btnNeu)
        Me.Controls.Add(Me.cbxTiere)
        Me.Controls.Add(Me.pgdTiere)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pgdTiere As PropertyGrid
    Friend WithEvents cbxTiere As ComboBox
    Friend WithEvents btnNeu As Button
    Friend WithEvents btnFuettern As Button
    Friend WithEvents btnEiLegen As Button
    Friend WithEvents ListBox1 As ListBox
End Class
