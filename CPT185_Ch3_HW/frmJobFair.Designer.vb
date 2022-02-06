<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJobFair
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.picFair = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblHall = New System.Windows.Forms.Label()
        Me.lblRoom = New System.Windows.Forms.Label()
        CType(Me.picFair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Honeydew
        Me.btnExit.Location = New System.Drawing.Point(50, 352)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(133, 34)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnDetails
        '
        Me.btnDetails.BackColor = System.Drawing.Color.Honeydew
        Me.btnDetails.Location = New System.Drawing.Point(50, 120)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(133, 34)
        Me.btnDetails.TabIndex = 1
        Me.btnDetails.Text = "View Job Fair Details"
        Me.btnDetails.UseVisualStyleBackColor = False
        '
        'picFair
        '
        Me.picFair.Image = Global.CPT185_Ch3_HW.My.Resources.Resources.Fair
        Me.picFair.Location = New System.Drawing.Point(262, 24)
        Me.picFair.Name = "picFair"
        Me.picFair.Size = New System.Drawing.Size(318, 362)
        Me.picFair.TabIndex = 2
        Me.picFair.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(12, 24)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(209, 35)
        Me.lblHeading.TabIndex = 3
        Me.lblHeading.Text = "Tech Job Fair"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(29, 72)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(174, 18)
        Me.lblWelcome.TabIndex = 4
        Me.lblWelcome.Text = "All Students are Welcome"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(71, 189)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(91, 18)
        Me.lblDate.TabIndex = 5
        Me.lblDate.Text = "May 2, 2016"
        Me.lblDate.Visible = False
        '
        'lblHall
        '
        Me.lblHall.AutoSize = True
        Me.lblHall.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHall.Location = New System.Drawing.Point(39, 237)
        Me.lblHall.Name = "lblHall"
        Me.lblHall.Size = New System.Drawing.Size(154, 18)
        Me.lblHall.TabIndex = 6
        Me.lblHall.Text = "Located in Lochlan Hall"
        Me.lblHall.Visible = False
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoom.Location = New System.Drawing.Point(79, 277)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(75, 18)
        Me.lblRoom.TabIndex = 7
        Me.lblRoom.Text = "Room 101"
        Me.lblRoom.Visible = False
        '
        'frmJobFair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(592, 411)
        Me.Controls.Add(Me.lblRoom)
        Me.Controls.Add(Me.lblHall)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picFair)
        Me.Controls.Add(Me.btnDetails)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "frmJobFair"
        CType(Me.picFair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnDetails As Button
    Friend WithEvents picFair As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblHall As Label
    Friend WithEvents lblRoom As Label
End Class
