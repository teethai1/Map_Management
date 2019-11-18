<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQR
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
        Me.components = New System.ComponentModel.Container()
        Me.ProBar1 = New System.Windows.Forms.ProgressBar()
        Me.lbCaption = New System.Windows.Forms.Label()
        Me.tbrev = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MapViewer = New System.Windows.Forms.Button()
        Me.Upload = New System.Windows.Forms.Button()
        Me.Download = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'ProBar1
        '
        Me.ProBar1.Location = New System.Drawing.Point(12, 103)
        Me.ProBar1.Maximum = 253
        Me.ProBar1.Name = "ProBar1"
        Me.ProBar1.Size = New System.Drawing.Size(558, 100)
        Me.ProBar1.TabIndex = 0
        '
        'lbCaption
        '
        Me.lbCaption.AutoSize = True
        Me.lbCaption.Font = New System.Drawing.Font("Copperplate Gothic Bold", 30.0!, System.Drawing.FontStyle.Bold)
        Me.lbCaption.Location = New System.Drawing.Point(12, 20)
        Me.lbCaption.Name = "lbCaption"
        Me.lbCaption.Size = New System.Drawing.Size(209, 44)
        Me.lbCaption.TabIndex = 1
        Me.lbCaption.Text = "Caption"
        '
        'tbrev
        '
        Me.tbrev.Location = New System.Drawing.Point(628, 20)
        Me.tbrev.Name = "tbrev"
        Me.tbrev.Size = New System.Drawing.Size(8, 20)
        Me.tbrev.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 400
        '
        'MapViewer
        '
        Me.MapViewer.BackColor = System.Drawing.Color.Aqua
        Me.MapViewer.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Mapviewer
        Me.MapViewer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MapViewer.Font = New System.Drawing.Font("Copperplate Gothic Bold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.MapViewer.Location = New System.Drawing.Point(147, 175)
        Me.MapViewer.Name = "MapViewer"
        Me.MapViewer.Size = New System.Drawing.Size(247, 100)
        Me.MapViewer.TabIndex = 2
        Me.MapViewer.TabStop = False
        Me.MapViewer.UseVisualStyleBackColor = False
        '
        'Upload
        '
        Me.Upload.BackColor = System.Drawing.Color.Salmon
        Me.Upload.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.MapUpload
        Me.Upload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Upload.Font = New System.Drawing.Font("Copperplate Gothic Bold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Upload.Location = New System.Drawing.Point(303, 47)
        Me.Upload.Name = "Upload"
        Me.Upload.Size = New System.Drawing.Size(247, 100)
        Me.Upload.TabIndex = 2
        Me.Upload.TabStop = False
        Me.Upload.UseVisualStyleBackColor = False
        '
        'Download
        '
        Me.Download.BackColor = System.Drawing.Color.GreenYellow
        Me.Download.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Mapdownload
        Me.Download.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Download.Font = New System.Drawing.Font("Copperplate Gothic Bold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Download.Location = New System.Drawing.Point(20, 47)
        Me.Download.Name = "Download"
        Me.Download.Size = New System.Drawing.Size(247, 100)
        Me.Download.TabIndex = 2
        Me.Download.TabStop = False
        Me.Download.UseVisualStyleBackColor = False
        '
        'frmQR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(582, 292)
        Me.Controls.Add(Me.MapViewer)
        Me.Controls.Add(Me.Upload)
        Me.Controls.Add(Me.Download)
        Me.Controls.Add(Me.tbrev)
        Me.Controls.Add(Me.lbCaption)
        Me.Controls.Add(Me.ProBar1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmQR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InputData"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lbCaption As System.Windows.Forms.Label
    Friend WithEvents tbrev As System.Windows.Forms.TextBox
    Friend WithEvents Download As System.Windows.Forms.Button
    Friend WithEvents Upload As System.Windows.Forms.Button
    Friend WithEvents MapViewer As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
