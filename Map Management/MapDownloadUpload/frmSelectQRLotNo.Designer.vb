<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectQRLotNo
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
        Me.btQRCode = New System.Windows.Forms.Button
        Me.btLotNo = New System.Windows.Forms.Button
        Me.lbCaption = New System.Windows.Forms.Label
        Me.tbKeyLot = New System.Windows.Forms.TextBox
        Me.btOK = New System.Windows.Forms.Button
        Me.btCancel = New System.Windows.Forms.Button
        Me.PicLike = New System.Windows.Forms.PictureBox
        CType(Me.PicLike, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btQRCode
        '
        Me.btQRCode.BackColor = System.Drawing.Color.LightPink
        Me.btQRCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btQRCode.Location = New System.Drawing.Point(49, 62)
        Me.btQRCode.Name = "btQRCode"
        Me.btQRCode.Size = New System.Drawing.Size(121, 81)
        Me.btQRCode.TabIndex = 0
        Me.btQRCode.Text = "QR Code"
        Me.btQRCode.UseVisualStyleBackColor = False
        '
        'btLotNo
        '
        Me.btLotNo.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btLotNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btLotNo.Location = New System.Drawing.Point(208, 62)
        Me.btLotNo.Name = "btLotNo"
        Me.btLotNo.Size = New System.Drawing.Size(120, 81)
        Me.btLotNo.TabIndex = 1
        Me.btLotNo.Text = "Key Lot No"
        Me.btLotNo.UseVisualStyleBackColor = False
        '
        'lbCaption
        '
        Me.lbCaption.AutoSize = True
        Me.lbCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbCaption.ForeColor = System.Drawing.Color.White
        Me.lbCaption.Location = New System.Drawing.Point(88, 19)
        Me.lbCaption.Name = "lbCaption"
        Me.lbCaption.Size = New System.Drawing.Size(207, 22)
        Me.lbCaption.TabIndex = 2
        Me.lbCaption.Text = "กรุณาเลือกการกรอกข้อมูล"
        '
        'tbKeyLot
        '
        Me.tbKeyLot.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.tbKeyLot.Location = New System.Drawing.Point(82, 87)
        Me.tbKeyLot.Name = "tbKeyLot"
        Me.tbKeyLot.Size = New System.Drawing.Size(194, 30)
        Me.tbKeyLot.TabIndex = 3
        '
        'btOK
        '
        Me.btOK.BackColor = System.Drawing.Color.Lime
        Me.btOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btOK.Location = New System.Drawing.Point(82, 149)
        Me.btOK.Name = "btOK"
        Me.btOK.Size = New System.Drawing.Size(88, 41)
        Me.btOK.TabIndex = 4
        Me.btOK.Text = "OK"
        Me.btOK.UseVisualStyleBackColor = False
        '
        'btCancel
        '
        Me.btCancel.BackColor = System.Drawing.Color.Crimson
        Me.btCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btCancel.Location = New System.Drawing.Point(188, 149)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(88, 41)
        Me.btCancel.TabIndex = 4
        Me.btCancel.Text = "Cancel"
        Me.btCancel.UseVisualStyleBackColor = False
        '
        'PicLike
        '
        Me.PicLike.Image = Global.WindowsApplication1.My.Resources.Resources.Like1
        Me.PicLike.Location = New System.Drawing.Point(282, 73)
        Me.PicLike.Name = "PicLike"
        Me.PicLike.Size = New System.Drawing.Size(66, 56)
        Me.PicLike.TabIndex = 5
        Me.PicLike.TabStop = False
        '
        'frmSelectQRLotNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(377, 202)
        Me.Controls.Add(Me.PicLike)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btOK)
        Me.Controls.Add(Me.tbKeyLot)
        Me.Controls.Add(Me.lbCaption)
        Me.Controls.Add(Me.btLotNo)
        Me.Controls.Add(Me.btQRCode)
        Me.Name = "frmSelectQRLotNo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSelectQRLotNo"
        CType(Me.PicLike, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btQRCode As System.Windows.Forms.Button
    Friend WithEvents btLotNo As System.Windows.Forms.Button
    Friend WithEvents lbCaption As System.Windows.Forms.Label
    Friend WithEvents tbKeyLot As System.Windows.Forms.TextBox
    Friend WithEvents btOK As System.Windows.Forms.Button
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents PicLike As System.Windows.Forms.PictureBox
End Class
