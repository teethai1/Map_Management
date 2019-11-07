Public Class frmSelectQRLotNo
    Public LotNo As String
    Private Sub frmSelectQRLotNo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        btOK.Visible = False
        btCancel.Visible = False
        tbKeyLot.Visible = False
        PicLike.Visible = False


        btLotNo.Visible = True
        btQRCode.Visible = True

        lbCaption.Text = "กรุณาเลือกการกรอกข้อมูล"
        tbKeyLot.Text = ""
    End Sub

    Private Sub btQRCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQRCode.Click, btLotNo.Click
        Dim bt As Button = CType(sender, Button)
        If bt.Name = "btLotNo" Then
            btOK.Visible = True
            btCancel.Visible = True
            tbKeyLot.Visible = True


            btQRCode.Visible = False
            btLotNo.Visible = False

            lbCaption.Text = "กรุณาใส่ Lot No."

        Else
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If

    End Sub

    Private Sub tbKeyLot_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbKeyLot.TextChanged
        If tbKeyLot.Text.Length = 10 Then
            PicLike.Visible = True
        Else
            PicLike.Visible = False
        End If
    End Sub

    Private Sub btOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOK.Click, btCancel.Click
        Dim bt As Button = CType(sender, Button)
        If bt.Name = "btOK" Then
            If tbKeyLot.Text.Length = 10 Then
                LotNo = tbKeyLot.Text
                Me.DialogResult = Windows.Forms.DialogResult.No
            Else
                MsgBox("Lot No ไม่ถูกต้องกรุณากรอกใหม่")
            End If
        Else
            Me.Close()
            Exit Sub
        End If

    End Sub
End Class