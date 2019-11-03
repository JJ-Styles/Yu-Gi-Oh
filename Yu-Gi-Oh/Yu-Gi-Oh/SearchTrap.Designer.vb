<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchTrap
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
        Me.txtCardName = New System.Windows.Forms.TextBox()
        Me.lblCardName = New System.Windows.Forms.Label()
        Me.lblNumberOwned = New System.Windows.Forms.Label()
        Me.lblCardNo = New System.Windows.Forms.Label()
        Me.lblSubType = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtNumberOwned = New System.Windows.Forms.TextBox()
        Me.txtCardNo = New System.Windows.Forms.TextBox()
        Me.txtSubType = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCardName
        '
        Me.txtCardName.Location = New System.Drawing.Point(12, 45)
        Me.txtCardName.Name = "txtCardName"
        Me.txtCardName.Size = New System.Drawing.Size(365, 20)
        Me.txtCardName.TabIndex = 0
        '
        'lblCardName
        '
        Me.lblCardName.AutoSize = True
        Me.lblCardName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblCardName.Location = New System.Drawing.Point(14, 9)
        Me.lblCardName.Name = "lblCardName"
        Me.lblCardName.Size = New System.Drawing.Size(120, 25)
        Me.lblCardName.TabIndex = 1
        Me.lblCardName.Text = "Card Name"
        '
        'lblNumberOwned
        '
        Me.lblNumberOwned.AutoSize = True
        Me.lblNumberOwned.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOwned.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblNumberOwned.Location = New System.Drawing.Point(14, 68)
        Me.lblNumberOwned.Name = "lblNumberOwned"
        Me.lblNumberOwned.Size = New System.Drawing.Size(160, 25)
        Me.lblNumberOwned.TabIndex = 2
        Me.lblNumberOwned.Text = "Number Owned"
        '
        'lblCardNo
        '
        Me.lblCardNo.AutoSize = True
        Me.lblCardNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardNo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblCardNo.Location = New System.Drawing.Point(14, 119)
        Me.lblCardNo.Name = "lblCardNo"
        Me.lblCardNo.Size = New System.Drawing.Size(139, 25)
        Me.lblCardNo.TabIndex = 3
        Me.lblCardNo.Text = "Card Number"
        '
        'lblSubType
        '
        Me.lblSubType.AutoSize = True
        Me.lblSubType.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubType.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblSubType.Location = New System.Drawing.Point(14, 170)
        Me.lblSubType.Name = "lblSubType"
        Me.lblSubType.Size = New System.Drawing.Size(104, 25)
        Me.lblSubType.TabIndex = 4
        Me.lblSubType.Text = "Sub Type"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDescription.Location = New System.Drawing.Point(14, 221)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(120, 25)
        Me.lblDescription.TabIndex = 5
        Me.lblDescription.Text = "Description"
        '
        'txtNumberOwned
        '
        Me.txtNumberOwned.Location = New System.Drawing.Point(12, 96)
        Me.txtNumberOwned.Name = "txtNumberOwned"
        Me.txtNumberOwned.ReadOnly = True
        Me.txtNumberOwned.Size = New System.Drawing.Size(365, 20)
        Me.txtNumberOwned.TabIndex = 6
        '
        'txtCardNo
        '
        Me.txtCardNo.Location = New System.Drawing.Point(12, 147)
        Me.txtCardNo.Name = "txtCardNo"
        Me.txtCardNo.ReadOnly = True
        Me.txtCardNo.Size = New System.Drawing.Size(365, 20)
        Me.txtCardNo.TabIndex = 7
        '
        'txtSubType
        '
        Me.txtSubType.Location = New System.Drawing.Point(12, 198)
        Me.txtSubType.Name = "txtSubType"
        Me.txtSubType.ReadOnly = True
        Me.txtSubType.Size = New System.Drawing.Size(365, 20)
        Me.txtSubType.TabIndex = 8
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(12, 249)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(365, 148)
        Me.txtDescription.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Yu_Gi_Oh.My.Resources.Resources.HomeButton
        Me.PictureBox1.Location = New System.Drawing.Point(344, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'SearchTrap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(389, 409)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtSubType)
        Me.Controls.Add(Me.txtCardNo)
        Me.Controls.Add(Me.txtNumberOwned)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblSubType)
        Me.Controls.Add(Me.lblCardNo)
        Me.Controls.Add(Me.lblNumberOwned)
        Me.Controls.Add(Me.lblCardName)
        Me.Controls.Add(Me.txtCardName)
        Me.Name = "SearchTrap"
        Me.Text = "SearchTrap"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCardName As TextBox
    Friend WithEvents lblCardName As Label
    Friend WithEvents lblNumberOwned As Label
    Friend WithEvents lblCardNo As Label
    Friend WithEvents lblSubType As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtNumberOwned As TextBox
    Friend WithEvents txtCardNo As TextBox
    Friend WithEvents txtSubType As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
