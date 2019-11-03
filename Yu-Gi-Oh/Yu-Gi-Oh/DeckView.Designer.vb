<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeckView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbxDeck = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbxDeck
        '
        Me.lbxDeck.BackColor = System.Drawing.SystemColors.Desktop
        Me.lbxDeck.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbxDeck.ForeColor = System.Drawing.SystemColors.Info
        Me.lbxDeck.FormattingEnabled = True
        Me.lbxDeck.Location = New System.Drawing.Point(4, 1)
        Me.lbxDeck.Name = "lbxDeck"
        Me.lbxDeck.Size = New System.Drawing.Size(381, 416)
        Me.lbxDeck.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Yu_Gi_Oh.My.Resources.Resources.HomeButton
        Me.PictureBox1.Location = New System.Drawing.Point(321, 378)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'DeckView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(389, 422)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbxDeck)
        Me.Name = "DeckView"
        Me.Text = "DeckView"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbxDeck As ListBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
