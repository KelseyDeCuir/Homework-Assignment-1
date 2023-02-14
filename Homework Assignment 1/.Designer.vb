<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNumbers
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
        Me.btnOne = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.btnFour = New System.Windows.Forms.Button()
        Me.btnFive = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblFrench = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOne
        '
        Me.btnOne.Location = New System.Drawing.Point(80, 150)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(46, 23)
        Me.btnOne.TabIndex = 0
        Me.btnOne.Text = "1"
        Me.btnOne.UseVisualStyleBackColor = True
        '
        'btnTwo
        '
        Me.btnTwo.Location = New System.Drawing.Point(140, 150)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(46, 23)
        Me.btnTwo.TabIndex = 1
        Me.btnTwo.Text = "2"
        Me.btnTwo.UseVisualStyleBackColor = True
        '
        'btnThree
        '
        Me.btnThree.Location = New System.Drawing.Point(200, 150)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(46, 23)
        Me.btnThree.TabIndex = 2
        Me.btnThree.Text = "3"
        Me.btnThree.UseVisualStyleBackColor = True
        '
        'btnFour
        '
        Me.btnFour.Location = New System.Drawing.Point(260, 150)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(46, 23)
        Me.btnFour.TabIndex = 3
        Me.btnFour.Text = "4"
        Me.btnFour.UseVisualStyleBackColor = True
        '
        'btnFive
        '
        Me.btnFive.Location = New System.Drawing.Point(320, 150)
        Me.btnFive.Name = "btnFive"
        Me.btnFive.Size = New System.Drawing.Size(46, 23)
        Me.btnFive.TabIndex = 4
        Me.btnFive.Text = "5"
        Me.btnFive.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblInstructions.Location = New System.Drawing.Point(77, 78)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(289, 56)
        Me.lblInstructions.TabIndex = 5
        Me.lblInstructions.Text = "Do you know the French words for the numbers 1 through 5?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click the buttons belo" &
    "w to see them."
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblFrench
        '
        Me.lblFrench.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lblFrench.ForeColor = System.Drawing.Color.White
        Me.lblFrench.Location = New System.Drawing.Point(200, 200)
        Me.lblFrench.Name = "lblFrench"
        Me.lblFrench.Size = New System.Drawing.Size(46, 23)
        Me.lblFrench.TabIndex = 6
        Me.lblFrench.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(200, 254)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(46, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 431)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblFrench)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnFive)
        Me.Controls.Add(Me.btnFour)
        Me.Controls.Add(Me.btnThree)
        Me.Controls.Add(Me.btnTwo)
        Me.Controls.Add(Me.btnOne)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNumbers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "French Numbers "
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOne As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnThree As Button
    Friend WithEvents btnFour As Button
    Friend WithEvents btnFive As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblFrench As Label
    Friend WithEvents btnExit As Button
End Class
