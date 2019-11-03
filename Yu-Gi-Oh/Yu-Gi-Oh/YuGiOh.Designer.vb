<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YuGiOh
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
        Me.BtnSearchMonster = New System.Windows.Forms.Button()
        Me.btnSearchTrap = New System.Windows.Forms.Button()
        Me.btnSearchSpell = New System.Windows.Forms.Button()
        Me.btnEditNumbers = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnViewDeck = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSearchMonster
        '
        Me.BtnSearchMonster.Location = New System.Drawing.Point(91, 6)
        Me.BtnSearchMonster.Name = "BtnSearchMonster"
        Me.BtnSearchMonster.Size = New System.Drawing.Size(195, 76)
        Me.BtnSearchMonster.TabIndex = 0
        Me.BtnSearchMonster.Text = "Search Monster"
        Me.BtnSearchMonster.UseVisualStyleBackColor = True
        '
        'btnSearchTrap
        '
        Me.btnSearchTrap.Location = New System.Drawing.Point(91, 88)
        Me.btnSearchTrap.Name = "btnSearchTrap"
        Me.btnSearchTrap.Size = New System.Drawing.Size(195, 76)
        Me.btnSearchTrap.TabIndex = 1
        Me.btnSearchTrap.Text = "Search Trap"
        Me.btnSearchTrap.UseVisualStyleBackColor = True
        '
        'btnSearchSpell
        '
        Me.btnSearchSpell.Location = New System.Drawing.Point(91, 170)
        Me.btnSearchSpell.Name = "btnSearchSpell"
        Me.btnSearchSpell.Size = New System.Drawing.Size(195, 76)
        Me.btnSearchSpell.TabIndex = 2
        Me.btnSearchSpell.Text = "Search Spell"
        Me.btnSearchSpell.UseVisualStyleBackColor = True
        '
        'btnEditNumbers
        '
        Me.btnEditNumbers.Location = New System.Drawing.Point(91, 252)
        Me.btnEditNumbers.Name = "btnEditNumbers"
        Me.btnEditNumbers.Size = New System.Drawing.Size(195, 76)
        Me.btnEditNumbers.TabIndex = 3
        Me.btnEditNumbers.Text = "Edit Numbers"
        Me.btnEditNumbers.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Yu_Gi_Oh.My.Resources.Resources.HomeButton
        Me.PictureBox1.Location = New System.Drawing.Point(343, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnViewDeck
        '
        Me.btnViewDeck.Location = New System.Drawing.Point(91, 334)
        Me.btnViewDeck.Name = "btnViewDeck"
        Me.btnViewDeck.Size = New System.Drawing.Size(195, 76)
        Me.btnViewDeck.TabIndex = 5
        Me.btnViewDeck.Text = "View Decks"
        Me.btnViewDeck.UseVisualStyleBackColor = True
        '
        'YuGiOh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(389, 422)
        Me.Controls.Add(Me.btnViewDeck)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnEditNumbers)
        Me.Controls.Add(Me.btnSearchSpell)
        Me.Controls.Add(Me.btnSearchTrap)
        Me.Controls.Add(Me.BtnSearchMonster)
        Me.Name = "YuGiOh"
        Me.Text = "YuGiOh"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSearchMonster As Button
    Friend WithEvents btnSearchTrap As Button
    Friend WithEvents btnSearchSpell As Button
    Friend WithEvents btnEditNumbers As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnViewDeck As Button
End Class
