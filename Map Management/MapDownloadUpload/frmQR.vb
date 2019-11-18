Public Class frmQR
    Dim count As Integer
    Public OP As String
    Public QR As String
    'Public LOTNo As String
    Public ModeTransfer As String
    Public PathTransfer As String

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        count = 0
        OP = 0
        QR = 0
        Me.BackColor = Color.DarkRed
        tbrev.Clear()
        Download.Visible = True
        Upload.Visible = True
        MapViewer.Visible = True
        tbrev.Enabled = False
        lbCaption.Visible = False
        ProBar1.Visible = False
        lbCaption.Text = "Working Slip"
    End Sub

    Private Sub tbrev_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbrev.KeyPress
        Try
            count = tbrev.Text.Length
            ProBar1.Value = count
        Catch ex As Exception

        End Try
        If e.KeyChar = Chr(13) Then
            Dim SubOP As String = tbrev.Text.Remove(1)

            If lbCaption.Text = "Working Slip" AndAlso tbrev.Text.Length = 252 Then
                QR = tbrev.Text.ToUpper
                tbrev.Clear()
                lbCaption.Text = "OP Number"
                ProBar1.Value = 0
                count = 0
            ElseIf lbCaption.Text = "OP Number" AndAlso tbrev.Text.Length = 6 Then

                Dim permission As New AuthenticationUser.AuthenUser
                If ModeTransfer = "Upload" AndAlso Not permission.AuthenUser(tbrev.Text, My.Settings.GL_MAPGroup) Then     'Authentication 140507
                    MsgBox("OP No นี้ไม่สามารถปฏิบัติงานได้")
                    tbrev.Text = ""
                    tbrev.Select()
                    count = 0
                    ProBar1.Value = 0
                    Exit Sub
                    'Authentication fail
                End If


                OP = tbrev.Text.ToUpper
                tbrev.Clear()
                ProBar1.Value = 0
                count = 0
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MsgBox("QR Code ไม่ถูกต้องกรุณาตรวจสอบ")
                tbrev.Clear()
                tbrev.Text = ""
                count = 0
                ProBar1.Value = 0
            End If

        End If
    End Sub

    Private Sub btDownLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Download.Click, Upload.Click, MapViewer.Click
        Dim bt As Button = CType(sender, Button)
        ModeTransfer = bt.Name
        If bt.Name = "Download" Then
            If frmSelectQRLotNo.ShowDialog = Windows.Forms.DialogResult.Yes Then ' QR Code
                Me.BackColor = Color.GreenYellow
                PathTransfer = "A:\"
            ElseIf frmSelectQRLotNo.DialogResult = Windows.Forms.DialogResult.No Then  'Key Lot No
                'LOTNo = frmSelectQRLotNo.LotNo
                Me.DialogResult = Windows.Forms.DialogResult.Yes
                PathTransfer = "A:\"
                Exit Sub
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Exit Sub
            End If
        ElseIf bt.Name = "MapViewer" Then
            PathTransfer = ""
            Me.BackColor = Color.Gold
        Else 'Upload
            PathTransfer = ""
            Dim frm As FolderBrowserDialog = New FolderBrowserDialog
            frm.ShowDialog()
            If frm.SelectedPath <> "" Then
                PathTransfer = frm.SelectedPath
                Me.DialogResult = Windows.Forms.DialogResult.Yes
            End If
        End If

        Download.Visible = False
        Upload.Visible = False
        MapViewer.Visible = False

        tbrev.Enabled = True
        tbrev.Focus()
        lbCaption.Visible = True
        ProBar1.Visible = True
    End Sub
End Class