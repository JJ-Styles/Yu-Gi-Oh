<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchSpell
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
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtSubType = New System.Windows.Forms.TextBox()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.txtNumberOwned = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblSubType = New System.Windows.Forms.Label()
        Me.lblCardNumber = New System.Windows.Forms.Label()
        Me.lblNumberOwned = New System.Windows.Forms.Label()
        Me.LblCardName = New System.Windows.Forms.Label()
        Me.txtCardName = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(12, 249)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(365, 148)
        Me.txtDescription.TabIndex = 19
        '
        'txtSubType
        '
        Me.txtSubType.Location = New System.Drawing.Point(12, 198)
        Me.txtSubType.Name = "txtSubType"
        Me.txtSubType.ReadOnly = True
        Me.txtSubType.Size = New System.Drawing.Size(365, 20)
        Me.txtSubType.TabIndex = 18
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Location = New System.Drawing.Point(12, 147)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.ReadOnly = True
        Me.txtCardNumber.Size = New System.Drawing.Size(365, 20)
        Me.txtCardNumber.TabIndex = 17
        '
        'txtNumberOwned
        '
        Me.txtNumberOwned.Location = New System.Drawing.Point(12, 96)
        Me.txtNumberOwned.Name = "txtNumberOwned"
        Me.txtNumberOwned.ReadOnly = True
        Me.txtNumberOwned.Size = New System.Drawing.Size(365, 20)
        Me.txtNumberOwned.TabIndex = 16
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDescription.Location = New System.Drawing.Point(14, 221)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(120, 25)
        Me.lblDescription.TabIndex = 15
        Me.lblDescription.Text = "Description"
        '
        'lblSubType
        '
        Me.lblSubType.AutoSize = True
        Me.lblSubType.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubType.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblSubType.Location = New System.Drawing.Point(14, 170)
        Me.lblSubType.Name = "lblSubType"
        Me.lblSubType.Size = New System.Drawing.Size(104, 25)
        Me.lblSubType.TabIndex = 14
        Me.lblSubType.Text = "Sub Type"
        '
        'lblCardNumber
        '
        Me.lblCardNumber.AutoSize = True
        Me.lblCardNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardNumber.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblCardNumber.Location = New System.Drawing.Point(14, 119)
        Me.lblCardNumber.Name = "lblCardNumber"
        Me.lblCardNumber.Size = New System.Drawing.Size(139, 25)
        Me.lblCardNumber.TabIndex = 13
        Me.lblCardNumber.Text = "Card Number"
        '
        'lblNumberOwned
        '
        Me.lblNumberOwned.AutoSize = True
        Me.lblNumberOwned.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOwned.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblNumberOwned.Location = New System.Drawing.Point(14, 68)
        Me.lblNumberOwned.Name = "lblNumberOwned"
        Me.lblNumberOwned.Size = New System.Drawing.Size(160, 25)
        Me.lblNumberOwned.TabIndex = 12
        Me.lblNumberOwned.Text = "Number Owned"
        '
        'LblCardName
        '
        Me.LblCardName.AutoSize = True
        Me.LblCardName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCardName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblCardName.Location = New System.Drawing.Point(14, 9)
        Me.LblCardName.Name = "LblCardName"
        Me.LblCardName.Size = New System.Drawing.Size(120, 25)
        Me.LblCardName.TabIndex = 11
        Me.LblCardName.Text = "Card Name"
        '
        'txtCardName
        '
        Me.txtCardName.Location = New System.Drawing.Point(12, 45)
        Me.txtCardName.Name = "txtCardName"
        Me.txtCardName.Size = New System.Drawing.Size(365, 20)
        Me.txtCardName.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Yu_Gi_Oh.My.Resources.Resources.HomeButton
        Me.PictureBox1.Location = New System.Drawing.Point(335, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'SearchSpell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(389, 409)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtSubType)
        Me.Controls.Add(Me.txtCardNumber)
        Me.Controls.Add(Me.txtNumberOwned)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblSubType)
        Me.Controls.Add(Me.lblCardNumber)
        Me.Controls.Add(Me.lblNumberOwned)
        Me.Controls.Add(Me.LblCardName)
        Me.Controls.Add(Me.txtCardName)
        Me.Name = "SearchSpell"
        Me.Text = "SearchSpell"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtSubType As TextBox
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents txtNumberOwned As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblSubType As Label
    Friend WithEvents lblCardNumber As Label
    Friend WithEvents lblNumberOwned As Label
    Friend WithEvents LblCardName As Label
    Friend WithEvents txtCardName As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
