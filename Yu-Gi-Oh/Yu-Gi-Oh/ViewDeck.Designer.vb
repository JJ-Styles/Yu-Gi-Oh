<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewDeck
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnJasonsDeck = New System.Windows.Forms.Button()
        Me.btnCharlysDeck = New System.Windows.Forms.Button()
        Me.btnMatthewsDeck = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnJasonsDeck
        '
        Me.btnJasonsDeck.Location = New System.Drawing.Point(96, 53)
        Me.btnJasonsDeck.Name = "btnJasonsDeck"
        Me.btnJasonsDeck.Size = New System.Drawing.Size(188, 71)
        Me.btnJasonsDeck.TabIndex = 0
        Me.btnJasonsDeck.Text = "Jason's Deck"
        Me.btnJasonsDeck.UseVisualStyleBackColor = True
        '
        'btnCharlysDeck
        '
        Me.btnCharlysDeck.Location = New System.Drawing.Point(96, 176)
        Me.btnCharlysDeck.Name = "btnCharlysDeck"
        Me.btnCharlysDeck.Size = New System.Drawing.Size(188, 71)
        Me.btnCharlysDeck.TabIndex = 1
        Me.btnCharlysDeck.Text = "Charly's Deck"
        Me.btnCharlysDeck.UseVisualStyleBackColor = True
        '
        'btnMatthewsDeck
        '
        Me.btnMatthewsDeck.Location = New System.Drawing.Point(96, 291)
        Me.btnMatthewsDeck.Name = "btnMatthewsDeck"
        Me.btnMatthewsDeck.Size = New System.Drawing.Size(188, 71)
        Me.btnMatthewsDeck.TabIndex = 2
        Me.btnMatthewsDeck.Text = "Matthew's Deck"
        Me.btnMatthewsDeck.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Yu_Gi_Oh.My.Resources.Resources.HomeButton
        Me.PictureBox1.Location = New System.Drawing.Point(335, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'ViewDeck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(389, 422)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnMatthewsDeck)
        Me.Controls.Add(Me.btnCharlysDeck)
        Me.Controls.Add(Me.btnJasonsDeck)
        Me.Name = "ViewDeck"
        Me.Text = "ViewDeck"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnJasonsDeck As Button
    Friend WithEvents btnCharlysDeck As Button
    Friend WithEvents btnMatthewsDeck As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
