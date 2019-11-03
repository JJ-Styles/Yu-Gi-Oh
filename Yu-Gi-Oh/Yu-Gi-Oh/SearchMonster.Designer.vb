<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchMonster
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
        Me.txtAttribute = New System.Windows.Forms.TextBox()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.txtNumberOwned = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblAttribute = New System.Windows.Forms.Label()
        Me.lblCardNumber = New System.Windows.Forms.Label()
        Me.lblNumberOwned = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCardName = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtATK = New System.Windows.Forms.TextBox()
        Me.lblATK = New System.Windows.Forms.Label()
        Me.txtDEF = New System.Windows.Forms.TextBox()
        Me.lblDEF = New System.Windows.Forms.Label()
        Me.txtLevel = New System.Windows.Forms.TextBox()
        Me.lblLevel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescription
        '
        Me.txtDescription.AcceptsReturn = True
        Me.txtDescription.AllowDrop = True
        Me.txtDescription.Location = New System.Drawing.Point(10, 241)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(365, 20)
        Me.txtDescription.TabIndex = 30
        '
        'txtAttribute
        '
        Me.txtAttribute.Location = New System.Drawing.Point(10, 190)
        Me.txtAttribute.Name = "txtAttribute"
        Me.txtAttribute.Size = New System.Drawing.Size(365, 20)
        Me.txtAttribute.TabIndex = 29
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Location = New System.Drawing.Point(10, 139)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(365, 20)
        Me.txtCardNumber.TabIndex = 28
        '
        'txtNumberOwned
        '
        Me.txtNumberOwned.Location = New System.Drawing.Point(10, 88)
        Me.txtNumberOwned.Name = "txtNumberOwned"
        Me.txtNumberOwned.Size = New System.Drawing.Size(365, 20)
        Me.txtNumberOwned.TabIndex = 27
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDescription.Location = New System.Drawing.Point(12, 213)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(120, 25)
        Me.lblDescription.TabIndex = 26
        Me.lblDescription.Text = "Description"
        '
        'lblAttribute
        '
        Me.lblAttribute.AutoSize = True
        Me.lblAttribute.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttribute.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblAttribute.Location = New System.Drawing.Point(12, 162)
        Me.lblAttribute.Name = "lblAttribute"
        Me.lblAttribute.Size = New System.Drawing.Size(92, 25)
        Me.lblAttribute.TabIndex = 25
        Me.lblAttribute.Text = "Attribute"
        '
        'lblCardNumber
        '
        Me.lblCardNumber.AutoSize = True
        Me.lblCardNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardNumber.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblCardNumber.Location = New System.Drawing.Point(12, 111)
        Me.lblCardNumber.Name = "lblCardNumber"
        Me.lblCardNumber.Size = New System.Drawing.Size(139, 25)
        Me.lblCardNumber.TabIndex = 24
        Me.lblCardNumber.Text = "Card Number"
        '
        'lblNumberOwned
        '
        Me.lblNumberOwned.AutoSize = True
        Me.lblNumberOwned.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOwned.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblNumberOwned.Location = New System.Drawing.Point(12, 60)
        Me.lblNumberOwned.Name = "lblNumberOwned"
        Me.lblNumberOwned.Size = New System.Drawing.Size(160, 25)
        Me.lblNumberOwned.TabIndex = 23
        Me.lblNumberOwned.Text = "Number Owned"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 25)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Card Name"
        '
        'txtCardName
        '
        Me.txtCardName.Location = New System.Drawing.Point(10, 37)
        Me.txtCardName.Name = "txtCardName"
        Me.txtCardName.Size = New System.Drawing.Size(365, 20)
        Me.txtCardName.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Yu_Gi_Oh.My.Resources.Resources.HomeButton
        Me.PictureBox1.Location = New System.Drawing.Point(335, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'txtATK
        '
        Me.txtATK.Location = New System.Drawing.Point(10, 292)
        Me.txtATK.Name = "txtATK"
        Me.txtATK.Size = New System.Drawing.Size(365, 20)
        Me.txtATK.TabIndex = 33
        '
        'lblATK
        '
        Me.lblATK.AutoSize = True
        Me.lblATK.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblATK.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblATK.Location = New System.Drawing.Point(12, 264)
        Me.lblATK.Name = "lblATK"
        Me.lblATK.Size = New System.Drawing.Size(53, 25)
        Me.lblATK.TabIndex = 32
        Me.lblATK.Text = "ATK"
        '
        'txtDEF
        '
        Me.txtDEF.Location = New System.Drawing.Point(10, 343)
        Me.txtDEF.Name = "txtDEF"
        Me.txtDEF.Size = New System.Drawing.Size(365, 20)
        Me.txtDEF.TabIndex = 35
        '
        'lblDEF
        '
        Me.lblDEF.AutoSize = True
        Me.lblDEF.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDEF.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDEF.Location = New System.Drawing.Point(11, 315)
        Me.lblDEF.Name = "lblDEF"
        Me.lblDEF.Size = New System.Drawing.Size(54, 25)
        Me.lblDEF.TabIndex = 34
        Me.lblDEF.Text = "DEF"
        '
        'txtLevel
        '
        Me.txtLevel.Location = New System.Drawing.Point(9, 394)
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.Size = New System.Drawing.Size(365, 20)
        Me.txtLevel.TabIndex = 37
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblLevel.Location = New System.Drawing.Point(11, 366)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(64, 25)
        Me.lblLevel.TabIndex = 36
        Me.lblLevel.Text = "Level"
        '
        'SearchMonster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(388, 418)
        Me.Controls.Add(Me.txtLevel)
        Me.Controls.Add(Me.lblLevel)
        Me.Controls.Add(Me.txtDEF)
        Me.Controls.Add(Me.lblDEF)
        Me.Controls.Add(Me.txtATK)
        Me.Controls.Add(Me.lblATK)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtAttribute)
        Me.Controls.Add(Me.txtCardNumber)
        Me.Controls.Add(Me.txtNumberOwned)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblAttribute)
        Me.Controls.Add(Me.lblCardNumber)
        Me.Controls.Add(Me.lblNumberOwned)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCardName)
        Me.Name = "SearchMonster"
        Me.Text = "SearchMonster"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtAttribute As TextBox
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents txtNumberOwned As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblAttribute As Label
    Friend WithEvents lblCardNumber As Label
    Friend WithEvents lblNumberOwned As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCardName As TextBox
    Friend WithEvents txtATK As TextBox
    Friend WithEvents lblATK As Label
    Friend WithEvents txtDEF As TextBox
    Friend WithEvents lblDEF As Label
    Friend WithEvents txtLevel As TextBox
    Friend WithEvents lblLevel As Label
End Class
