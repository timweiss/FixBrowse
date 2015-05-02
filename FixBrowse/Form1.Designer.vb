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
        Me.AdressBarTextinput = New System.Windows.Forms.TextBox()
        Me.AdressBarGoButton = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AdressBarTextinput
        '
        Me.AdressBarTextinput.Location = New System.Drawing.Point(13, 13)
        Me.AdressBarTextinput.Name = "AdressBarTextinput"
        Me.AdressBarTextinput.Size = New System.Drawing.Size(445, 20)
        Me.AdressBarTextinput.TabIndex = 0
        '
        'AdressBarGoButton
        '
        Me.AdressBarGoButton.Location = New System.Drawing.Point(464, 13)
        Me.AdressBarGoButton.Name = "AdressBarGoButton"
        Me.AdressBarGoButton.Size = New System.Drawing.Size(75, 20)
        Me.AdressBarGoButton.TabIndex = 1
        Me.AdressBarGoButton.Text = "Go!"
        Me.AdressBarGoButton.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 64)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1062, 646)
        Me.WebBrowser1.TabIndex = 2
        Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(92, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(111, 35)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button1"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(209, 35)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Button1"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(973, 10)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(79, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Einstellungen"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 711)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.AdressBarGoButton)
        Me.Controls.Add(Me.AdressBarTextinput)
        Me.Name = "Form1"
        Me.Text = "FixBrowse by TezTeam"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdressBarTextinput As System.Windows.Forms.TextBox
    Friend WithEvents AdressBarGoButton As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
