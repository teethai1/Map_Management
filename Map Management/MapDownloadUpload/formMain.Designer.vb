<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
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
        Me.components = New System.ComponentModel.Container
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.btbrowser = New System.Windows.Forms.Button
        Me.btQR = New System.Windows.Forms.Button
        Me.lbLot = New System.Windows.Forms.Label
        Me.lbOP = New System.Windows.Forms.Label
        Me.tbPath = New System.Windows.Forms.TextBox
        Me.btGO = New System.Windows.Forms.Button
        Me.lbMode = New System.Windows.Forms.Label
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.lbMessage = New System.Windows.Forms.Label
        Me.lbL3 = New System.Windows.Forms.Label
        Me.lbL1 = New System.Windows.Forms.Label
        Me.lbL2 = New System.Windows.Forms.Label
        Me.lbR2 = New System.Windows.Forms.Label
        Me.lbR3 = New System.Windows.Forms.Label
        Me.lbR1 = New System.Windows.Forms.Label
        Me.lbL5 = New System.Windows.Forms.Label
        Me.lbL4 = New System.Windows.Forms.Label
        Me.lbR4 = New System.Windows.Forms.Label
        Me.lbR5 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DBxDataSet = New WindowsApplication1.DBxDataSet
        Me.MAP_MAPDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MAP_MAPDataTableAdapter = New WindowsApplication1.DBxDataSetTableAdapters.MAP_MAPDataTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.DBxDataSetTableAdapters.TableAdapterManager
        Me.lbFirst = New System.Windows.Forms.Label
        Me.lbSecond = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.btHelp = New System.Windows.Forms.Button
        CType(Me.DBxDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAP_MAPDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btbrowser
        '
        Me.btbrowser.BackColor = System.Drawing.Color.Gold
        Me.btbrowser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btbrowser.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btbrowser.ForeColor = System.Drawing.Color.MediumBlue
        Me.btbrowser.Location = New System.Drawing.Point(441, 133)
        Me.btbrowser.Name = "btbrowser"
        Me.btbrowser.Size = New System.Drawing.Size(122, 26)
        Me.btbrowser.TabIndex = 0
        Me.btbrowser.Text = "Browser"
        Me.btbrowser.UseVisualStyleBackColor = False
        '
        'btQR
        '
        Me.btQR.BackColor = System.Drawing.Color.Transparent
        Me.btQR.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.ROHM
        Me.btQR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btQR.Font = New System.Drawing.Font("Copperplate Gothic Bold", 30.0!, System.Drawing.FontStyle.Bold)
        Me.btQR.ForeColor = System.Drawing.Color.Snow
        Me.btQR.Location = New System.Drawing.Point(93, 235)
        Me.btQR.Name = "btQR"
        Me.btQR.Size = New System.Drawing.Size(115, 102)
        Me.btQR.TabIndex = 2
        Me.btQR.UseVisualStyleBackColor = False
        '
        'lbLot
        '
        Me.lbLot.AutoSize = True
        Me.lbLot.BackColor = System.Drawing.Color.Transparent
        Me.lbLot.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbLot.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbLot.Location = New System.Drawing.Point(148, 100)
        Me.lbLot.Name = "lbLot"
        Me.lbLot.Size = New System.Drawing.Size(42, 18)
        Me.lbLot.TabIndex = 3
        Me.lbLot.Text = "Lot"
        '
        'lbOP
        '
        Me.lbOP.AutoSize = True
        Me.lbOP.BackColor = System.Drawing.Color.Transparent
        Me.lbOP.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbOP.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbOP.Location = New System.Drawing.Point(376, 99)
        Me.lbOP.Name = "lbOP"
        Me.lbOP.Size = New System.Drawing.Size(36, 18)
        Me.lbOP.TabIndex = 4
        Me.lbOP.Text = "OP"
        '
        'tbPath
        '
        Me.tbPath.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tbPath.Location = New System.Drawing.Point(211, 133)
        Me.tbPath.Name = "tbPath"
        Me.tbPath.Size = New System.Drawing.Size(211, 25)
        Me.tbPath.TabIndex = 6
        '
        'btGO
        '
        Me.btGO.BackColor = System.Drawing.Color.Transparent
        Me.btGO.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.DDDD
        Me.btGO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btGO.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btGO.Location = New System.Drawing.Point(299, 235)
        Me.btGO.Name = "btGO"
        Me.btGO.Size = New System.Drawing.Size(115, 102)
        Me.btGO.TabIndex = 7
        Me.btGO.UseVisualStyleBackColor = False
        '
        'lbMode
        '
        Me.lbMode.AutoSize = True
        Me.lbMode.BackColor = System.Drawing.Color.Transparent
        Me.lbMode.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbMode.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbMode.Location = New System.Drawing.Point(562, 99)
        Me.lbMode.Name = "lbMode"
        Me.lbMode.Size = New System.Drawing.Size(59, 18)
        Me.lbMode.TabIndex = 8
        Me.lbMode.Text = "Mode"
        '
        'BackgroundWorker1
        '
        '
        'lbMessage
        '
        Me.lbMessage.AutoSize = True
        Me.lbMessage.BackColor = System.Drawing.Color.Transparent
        Me.lbMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbMessage.ForeColor = System.Drawing.Color.Red
        Me.lbMessage.Location = New System.Drawing.Point(161, 380)
        Me.lbMessage.Name = "lbMessage"
        Me.lbMessage.Size = New System.Drawing.Size(332, 46)
        Me.lbMessage.TabIndex = 10
        Me.lbMessage.Text = "กรุณารอสักครู่. . . . ."
        '
        'lbL3
        '
        Me.lbL3.AutoSize = True
        Me.lbL3.BackColor = System.Drawing.Color.Transparent
        Me.lbL3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbL3.ForeColor = System.Drawing.Color.DeepPink
        Me.lbL3.Location = New System.Drawing.Point(87, 392)
        Me.lbL3.Name = "lbL3"
        Me.lbL3.Size = New System.Drawing.Size(30, 31)
        Me.lbL3.TabIndex = 11
        Me.lbL3.Text = ">"
        '
        'lbL1
        '
        Me.lbL1.AutoSize = True
        Me.lbL1.BackColor = System.Drawing.Color.Transparent
        Me.lbL1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbL1.ForeColor = System.Drawing.Color.DeepPink
        Me.lbL1.Location = New System.Drawing.Point(38, 392)
        Me.lbL1.Name = "lbL1"
        Me.lbL1.Size = New System.Drawing.Size(30, 31)
        Me.lbL1.TabIndex = 11
        Me.lbL1.Text = ">"
        '
        'lbL2
        '
        Me.lbL2.AutoSize = True
        Me.lbL2.BackColor = System.Drawing.Color.Transparent
        Me.lbL2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbL2.ForeColor = System.Drawing.Color.DeepPink
        Me.lbL2.Location = New System.Drawing.Point(63, 392)
        Me.lbL2.Name = "lbL2"
        Me.lbL2.Size = New System.Drawing.Size(30, 31)
        Me.lbL2.TabIndex = 11
        Me.lbL2.Text = ">"
        '
        'lbR2
        '
        Me.lbR2.AutoSize = True
        Me.lbR2.BackColor = System.Drawing.Color.Transparent
        Me.lbR2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbR2.ForeColor = System.Drawing.Color.DeepPink
        Me.lbR2.Location = New System.Drawing.Point(581, 391)
        Me.lbR2.Name = "lbR2"
        Me.lbR2.Size = New System.Drawing.Size(30, 31)
        Me.lbR2.TabIndex = 11
        Me.lbR2.Text = "<"
        '
        'lbR3
        '
        Me.lbR3.AutoSize = True
        Me.lbR3.BackColor = System.Drawing.Color.Transparent
        Me.lbR3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbR3.ForeColor = System.Drawing.Color.DeepPink
        Me.lbR3.Location = New System.Drawing.Point(559, 391)
        Me.lbR3.Name = "lbR3"
        Me.lbR3.Size = New System.Drawing.Size(30, 31)
        Me.lbR3.TabIndex = 11
        Me.lbR3.Text = "<"
        '
        'lbR1
        '
        Me.lbR1.AutoSize = True
        Me.lbR1.BackColor = System.Drawing.Color.Transparent
        Me.lbR1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbR1.ForeColor = System.Drawing.Color.DeepPink
        Me.lbR1.Location = New System.Drawing.Point(603, 392)
        Me.lbR1.Name = "lbR1"
        Me.lbR1.Size = New System.Drawing.Size(30, 31)
        Me.lbR1.TabIndex = 11
        Me.lbR1.Text = "<"
        '
        'lbL5
        '
        Me.lbL5.AutoSize = True
        Me.lbL5.BackColor = System.Drawing.Color.Transparent
        Me.lbL5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbL5.ForeColor = System.Drawing.Color.DeepPink
        Me.lbL5.Location = New System.Drawing.Point(134, 392)
        Me.lbL5.Name = "lbL5"
        Me.lbL5.Size = New System.Drawing.Size(30, 31)
        Me.lbL5.TabIndex = 11
        Me.lbL5.Text = ">"
        '
        'lbL4
        '
        Me.lbL4.AutoSize = True
        Me.lbL4.BackColor = System.Drawing.Color.Transparent
        Me.lbL4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbL4.ForeColor = System.Drawing.Color.DeepPink
        Me.lbL4.Location = New System.Drawing.Point(111, 392)
        Me.lbL4.Name = "lbL4"
        Me.lbL4.Size = New System.Drawing.Size(30, 31)
        Me.lbL4.TabIndex = 11
        Me.lbL4.Text = ">"
        '
        'lbR4
        '
        Me.lbR4.AutoSize = True
        Me.lbR4.BackColor = System.Drawing.Color.Transparent
        Me.lbR4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbR4.ForeColor = System.Drawing.Color.DeepPink
        Me.lbR4.Location = New System.Drawing.Point(533, 390)
        Me.lbR4.Name = "lbR4"
        Me.lbR4.Size = New System.Drawing.Size(30, 31)
        Me.lbR4.TabIndex = 11
        Me.lbR4.Text = "<"
        '
        'lbR5
        '
        Me.lbR5.AutoSize = True
        Me.lbR5.BackColor = System.Drawing.Color.Transparent
        Me.lbR5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbR5.ForeColor = System.Drawing.Color.DeepPink
        Me.lbR5.Location = New System.Drawing.Point(511, 390)
        Me.lbR5.Name = "lbR5"
        Me.lbR5.Size = New System.Drawing.Size(30, 31)
        Me.lbR5.TabIndex = 11
        Me.lbR5.Text = "<"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'DBxDataSet
        '
        Me.DBxDataSet.DataSetName = "DBxDataSet"
        Me.DBxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MAP_MAPDataBindingSource
        '
        Me.MAP_MAPDataBindingSource.DataMember = "MAP_MAPData"
        Me.MAP_MAPDataBindingSource.DataSource = Me.DBxDataSet
        '
        'MAP_MAPDataTableAdapter
        '
        Me.MAP_MAPDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MAP_MAPDataTableAdapter = Me.MAP_MAPDataTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.DBxDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lbFirst
        '
        Me.lbFirst.AutoSize = True
        Me.lbFirst.BackColor = System.Drawing.Color.Transparent
        Me.lbFirst.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbFirst.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbFirst.Location = New System.Drawing.Point(240, 173)
        Me.lbFirst.Name = "lbFirst"
        Me.lbFirst.Size = New System.Drawing.Size(142, 18)
        Me.lbFirst.TabIndex = 9
        Me.lbFirst.Text = "ProcessFirst"
        '
        'lbSecond
        '
        Me.lbSecond.AutoSize = True
        Me.lbSecond.BackColor = System.Drawing.Color.Transparent
        Me.lbSecond.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbSecond.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbSecond.Location = New System.Drawing.Point(473, 173)
        Me.lbSecond.Name = "lbSecond"
        Me.lbSecond.Size = New System.Drawing.Size(163, 18)
        Me.lbSecond.TabIndex = 9
        Me.lbSecond.Text = "ProcessSecond"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Power
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(506, 235)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 102)
        Me.Button1.TabIndex = 12
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btHelp
        '
        Me.btHelp.BackColor = System.Drawing.Color.Black
        Me.btHelp.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Untitled_1
        Me.btHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btHelp.Location = New System.Drawing.Point(635, 7)
        Me.btHelp.Name = "btHelp"
        Me.btHelp.Size = New System.Drawing.Size(60, 60)
        Me.btHelp.TabIndex = 14
        Me.btHelp.UseVisualStyleBackColor = False
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BACJ
        Me.ClientSize = New System.Drawing.Size(705, 557)
        Me.ControlBox = False
        Me.Controls.Add(Me.btHelp)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbR5)
        Me.Controls.Add(Me.lbR3)
        Me.Controls.Add(Me.lbL4)
        Me.Controls.Add(Me.lbL2)
        Me.Controls.Add(Me.lbL1)
        Me.Controls.Add(Me.lbR4)
        Me.Controls.Add(Me.lbR1)
        Me.Controls.Add(Me.lbR2)
        Me.Controls.Add(Me.lbL5)
        Me.Controls.Add(Me.lbL3)
        Me.Controls.Add(Me.lbMessage)
        Me.Controls.Add(Me.lbSecond)
        Me.Controls.Add(Me.lbFirst)
        Me.Controls.Add(Me.lbMode)
        Me.Controls.Add(Me.btGO)
        Me.Controls.Add(Me.tbPath)
        Me.Controls.Add(Me.lbOP)
        Me.Controls.Add(Me.lbLot)
        Me.Controls.Add(Me.btQR)
        Me.Controls.Add(Me.btbrowser)
        Me.ForeColor = System.Drawing.Color.Snow
        Me.MaximumSize = New System.Drawing.Size(713, 584)
        Me.MinimumSize = New System.Drawing.Size(713, 584)
        Me.Name = "formMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MapData Download Upload"
        CType(Me.DBxDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAP_MAPDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btbrowser As System.Windows.Forms.Button
    Friend WithEvents btQR As System.Windows.Forms.Button
    Friend WithEvents lbLot As System.Windows.Forms.Label
    Friend WithEvents lbOP As System.Windows.Forms.Label
    Friend WithEvents tbPath As System.Windows.Forms.TextBox
    Friend WithEvents btGO As System.Windows.Forms.Button
    Friend WithEvents lbMode As System.Windows.Forms.Label
    Friend WithEvents DBxDataSet As WindowsApplication1.DBxDataSet
    Friend WithEvents MAP_MAPDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MAP_MAPDataTableAdapter As WindowsApplication1.DBxDataSetTableAdapters.MAP_MAPDataTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.DBxDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lbMessage As System.Windows.Forms.Label
    Friend WithEvents lbL3 As System.Windows.Forms.Label
    Friend WithEvents lbL1 As System.Windows.Forms.Label
    Friend WithEvents lbL2 As System.Windows.Forms.Label
    Friend WithEvents lbR2 As System.Windows.Forms.Label
    Friend WithEvents lbR3 As System.Windows.Forms.Label
    Friend WithEvents lbR1 As System.Windows.Forms.Label
    Friend WithEvents lbL5 As System.Windows.Forms.Label
    Friend WithEvents lbL4 As System.Windows.Forms.Label
    Friend WithEvents lbR4 As System.Windows.Forms.Label
    Friend WithEvents lbR5 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbFirst As System.Windows.Forms.Label
    Friend WithEvents lbSecond As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btHelp As System.Windows.Forms.Button

End Class
