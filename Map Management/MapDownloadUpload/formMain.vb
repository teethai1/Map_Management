Imports System.IO

Public Class formMain
    Dim pathUnzipDownLoad As String
    Dim BufferDownload As String
    Dim ProcessFirst As String
    Dim ProcessSecond As String
    Dim LED As Integer
    Dim StatusMapview As Boolean
    Dim MapViewerVersion As String
    Dim _MapDownload As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbrowser.Click
        Dim FolderBrowser As New FolderBrowserDialog
        If FolderBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then
            tbPath.Text = FolderBrowser.SelectedPath
        End If
    End Sub

    Private Sub btDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQR.Click

        If frmQR.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim LotNo As String
            Dim OPNo As String
            Dim PathT As String = frmQR.PathTransfer
            Dim ModeData As String = frmQR.ModeTransfer
            Dim Mapview As String = Path.Combine("D:\", "AutoLoadMapData")
            OPNo = Trim(frmQR.OP)
            LotNo = Trim(frmQR.QR.Substring(30, 10))
            lbOP.Text = OPNo
            lbLot.Text = LotNo
            tbPath.Text = PathT
            lbMode.Text = ModeData
            If lbMode.Text = "Upload" Then
                tbPath.Clear()
                tbPath.Enabled = False
                btbrowser.Enabled = False
            ElseIf lbMode.Text = "MapViewer" Then
                tbPath.Text = Mapview
                tbPath.Enabled = False
                btbrowser.Enabled = False
            Else
                tbPath.Enabled = True
                btbrowser.Enabled = True
            End If

        ElseIf frmQR.DialogResult = Windows.Forms.DialogResult.Yes Then   'Key Lot
            Dim strLotNo As String = frmSelectQRLotNo.LotNo
            Dim MapKeyLot As String = Path.Combine("D:\", "DownloadMapData\" & strLotNo)
            lbMode.Text = frmQR.ModeTransfer
            lbLot.Text = strLotNo
            tbPath.Text = MapKeyLot
            _MapDownload = MapKeyLot
            lbOP.Text = ""

            tbPath.Enabled = False
            btbrowser.Enabled = False

        End If

    End Sub

    Private Sub AddComLog(ByVal m As String)
        Dim logfile As String = SelPath & "\LOG\ComLoG.txt"
        Try
            Dim outfile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(logfile, True)
            outfile.WriteLine(Date.Now & "  " & ComName & "  ,  " & m)
            outfile.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim sr As StreamReader = File.OpenText(logfile)
        If sr.BaseStream.Length > 2000000 Then
            sr.Close()
            File.Delete(logfile)
        End If
        sr.Close()
    End Sub


    Private Sub btGO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGO.Click



        If InputBox("กรุณาใส่ Password", "Password") <> "MAP" Then
            MsgBox("Password ไม่ถูกต้อง")
            Exit Sub
        End If

        If lbMode.Text = "Download" Then
            If lbLot.Text = "" OrElse tbPath.Text = "" OrElse lbMode.Text = "" Then
                MsgBox("กรุณา Input ข้อมูลให้ครบด้วยครับ")
                Exit Sub
            End If
        Else
            If lbLot.Text = "" OrElse lbMode.Text = "" Then
                MsgBox("กรุณา Input ข้อมูลให้ครบด้วยครับ")
                Exit Sub
            End If
        End If


        If My.Computer.Network.IsAvailable Then
            If Not My.Computer.Network.Ping("172.16.0.100") Then
                MsgBox("ไม่สามารถทำงานได้  Network มีปัญหา")
            End If
        Else
            MsgBox("ไม่สามารถทำงานได้ กรุณาตรวจสอบสาย LAN")
            Exit Sub
        End If

        If lbMode.Text = "Download" OrElse lbMode.Text = "MapViewer" Then
            Dim folderMode As String = Path.Combine("D:\SelCon MapOSFT", lbMode.Text)
            Dim folderBuffer As String = Path.Combine("D:\SelCon MapOSFT", "Buffer")
            Dim Mapview As String = Path.Combine("D:\", "AutoLoadMapData")
            Dim MapKeyLot As String = Path.Combine("D:\", "DownloadMapData")
            Dim BinMapDownload As Byte() = Nothing
            If Not Directory.Exists(folderMode) Then
                Directory.CreateDirectory(folderMode)
            End If

            If Not Directory.Exists(folderBuffer) Then
                Directory.CreateDirectory(folderBuffer)
            End If

            If Not Directory.Exists(Mapview) Then
                Directory.CreateDirectory(Mapview)
            End If

            If Not Directory.Exists(MapKeyLot) Then
                Directory.CreateDirectory(MapKeyLot)
            End If


            BufferDownload = folderBuffer

            MAP_MAPDataTableAdapter.FilterLotInMapData(DBxDataSet.MAP_MAPData, lbLot.Text)
            If DBxDataSet.MAP_MAPData.Rows.Count = 0 Then
                MsgBox("ไม่พบข้อมูล")
                Exit Sub
            End If

            Dim CheckData As Boolean = False
            For Each row As DBxDataSet.MAP_MAPDataRow In DBxDataSet.MAP_MAPData.Rows
                If lbLot.Text = row.LotNo Then
                    BinMapDownload = row.MAPData
                    lbFirst.Text = row.ProcessMode
                    CheckData = True
                End If
            Next

            If CheckData = False Then
                MsgBox("ข้อมูลไม่ถูกต้อง")
                Exit Sub
            Else
                If MessageBox.Show("กรุณาตรวจสอบข้อมูล  ต้องการ Download MapData หรือไม่", "MapData DownLoad", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
                    If lbOP.Text = "" Then
                        Dim strMapKeyLot As String = Path.Combine("D:\", "DownloadMapData\" & lbLot.Text)
                        If Not Directory.Exists(strMapKeyLot) Then
                            Directory.CreateDirectory(strMapKeyLot)
                        End If
                    ElseIf "A:\" <> tbPath.Text AndAlso lbMode.Text <> "MapViewer" Then
                        _MapDownload = Path.Combine(tbPath.Text, lbLot.Text)
                        If Not Directory.Exists(_MapDownload) Then
                            Directory.CreateDirectory(_MapDownload)
                        End If
                    Else
                        _MapDownload = tbPath.Text
                    End If


                    DisableButton()


                    Dim FileNameDelete As String() = Directory.GetFiles(folderMode)
                    For Each fDelete As String In FileNameDelete
                        Kill(fDelete)
                    Next

                    Dim ProcMode As String = DBxDataSet.MAP_MAPData.Rows(0)("ProcessMode")
                    Dim UnZipDir As String = folderMode & "\" & DBxDataSet.MAP_MAPData.Rows(0)("LotNo") & "_" & ProcMode & ".zip"
                    Dim SplitDataPath As String()
                    SplitDataPath = UnZipDir.Split("\")


                    AddComLog(lbMode.Text & "," & lbOP.Text & "," & SplitDataPath(3))
                    File.WriteAllBytes(UnZipDir, BinMapDownload)

                    pathUnzipDownLoad = UnZipDir
                    BackgroundWorker1.RunWorkerAsync()
                Else
                    Clear()
                End If



            End If

        Else
            Dim folderMode As String = Path.Combine("D:\SelCon MapOSFT", lbMode.Text)
            Dim FlobbyDisk As String = "A:\"
            Dim BinMapUpload As Byte() = Nothing

            If Not Directory.Exists(folderMode) Then
                Directory.CreateDirectory(folderMode)
            End If

            Try

                Dim XmlCount As Integer = Directory.GetFiles(FlobbyDisk, "*.Xml").Length
                Dim XMLDoc As New XDocument

                If XmlCount = 1 Then

                    DisableButton()

                    Dim FileName As String = Directory.GetFiles(FlobbyDisk, "*.Xml")(0)
                    If FileName.Contains(lbLot.Text) = False Then
                        EnableButton()
                        MsgBox("LotNo ใน Working Slip ไม่ตรงกับไฟล์ใน Flobby Disk")
                        Exit Sub
                    End If

                    XMLDoc = XDocument.Load(FileName)
                    Dim log = From l In XMLDoc.Descendants("log") Select l                 '<Log> Child
                    If log.Count > 0 Then                                                  '<Log> Exist is >0
                        Dim TestType = From tt In log(log.Count - 1).Descendants("test_type") Select tt.Value       'Last<Log>,Test type get
                        Dim TestMode = From tm In log(log.Count - 1).Descendants("test_mode") Select tm.Value
                        Dim _TestMode As String = TestMode.First
                        Dim NumberTestType As String
                        Dim NumberTestTypeCompare As String = ""

                        NumberTestType = TestType.First()

                        MAP_MAPDataTableAdapter.FilterLotInMapData(DBxDataSet.MAP_MAPData, lbLot.Text)

                        If DBxDataSet.MAP_MAPData.Rows.Count <> 0 Then

                            Dim row As DataRow = DBxDataSet.MAP_MAPData.Rows(0)
                            lbSecond.Text = "Server :  " & row("Process")
                            NumberTestTypeCompare = ConvertProcessToNumber(row("Process"))

                        End If

                        Dim Process As String = ""
                        Dim ProcessMode As String = ""

                        Select Case NumberTestType
                            Case 0
                                Process = "OS"
                            Case 1
                                Process = "AUTO1"
                            Case 2
                                Process = "AUTO2"
                            Case 3
                                Process = "AUTO3"
                            Case 4
                                Process = "AUTO4"
                            Case 5
                                Process = "OSFT"
                            Case 6
                                Process = "TP"
                        End Select

                        Select Case _TestMode
                            Case 0
                                ProcessMode = Process & "_NEW"
                            Case 1
                                ProcessMode = Process & "_RGood"
                            Case 2
                                ProcessMode = Process & "_RNG"
                            Case 3
                                ProcessMode = Process & "_ADD"
                        End Select
                        lbFirst.Text = "A:\    " & Process
                        If NumberTestType < NumberTestTypeCompare Then
                            MsgBox("ไม่สามารถ Upload ได้เพราะเป็นกระบวนย้อนกลับ")
                            EnableButton()
                            Exit Sub
                        End If

                        AddComLog(lbMode.Text & "," & lbOP.Text & "," & lbLot.Text & "_" & ProcessMode & ".zip")

                        clsNfdMap.zipFiles(FlobbyDisk, folderMode & "\A.zip")
                        BinMapUpload = File.ReadAllBytes(folderMode & "\A.zip")

                        If File.Exists("D:\SelCon MapOSFT\Upload\A.zip") Then
                            Kill("D:\SelCon MapOSFT\Upload\A.zip")
                        End If

                        If MessageBox.Show("กรุณาตรวจสอบข้อมูล  ต้องการ Upload ลงฐานข้อมูลหรือไม่", "MapData Upload", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then

                            Dim m_MapData As DBxDataSet.MAP_MAPDataRow
                            Dim newRow As DBxDataSet.MAP_MAPDataRow = DBxDataSet.MAP_MAPData.NewMAP_MAPDataRow()
                            m_MapData = newRow
                            m_MapData.MCNo = ComName
                            m_MapData.Process = Process
                            m_MapData.ProcessMode = ProcessMode
                            m_MapData.LotNo = lbLot.Text
                            m_MapData.MAPData = BinMapUpload
                            m_MapData.LotStartTime = Format(Now, "yyyy/MM/dd HH:mm:ss")
                            m_MapData.LotEndTime = Format(Now, "yyyy/MM/dd HH:mm:ss")
                            m_MapData.Remark = "Upload"
                            DBxDataSet.MAP_MAPData.Rows.Add(m_MapData)

                            If MAP_MAPDataTableAdapter.Update(DBxDataSet.MAP_MAPData) = 1 Then
                                DBxDataSet.MAP_MAPData.Rows.Clear()
                                Clear()
                                MsgBox("Upload Data เรียบร้อยครับ")
                            End If
                        Else
                            Clear()
                        End If

                    Else

                        MsgBox("ไม่มี Log ในไฟล์ XML กรุราตรวจสอบ")
                        Clear()

                        EnableButton()
                        Exit Sub
                    End If
                Else
                    MsgBox("ไม่มีข้อมูลใน Flobby Disk")
                End If

            Catch ex As Exception
                EnableButton()
                MsgBox("กรุณาใส่แผ่นหรือ Path ไม่ถูกต้อง")
                Exit Sub
            End Try

            EnableButton()
        End If

    End Sub
    Function ConvertProcessToNumber(ByVal Process As String) As Integer
        Dim ret As Integer = 99
        Select Case Process
            Case "OS"
                ret = 0
            Case "AUTO1"
                ret = 1
            Case "AUTO2"
                ret = 2
            Case "AUTO3"
                ret = 3
            Case "AUTO4"
                ret = 4
            Case "OSFT"
                ret = 5
            Case "TP"
                ret = 6
        End Select
        Return ret
    End Function
    Sub Clear()
        lbLot.Text = ""
        lbMode.Text = ""
        lbOP.Text = ""
        tbPath.Text = ""
        lbFirst.Text = "-"
        lbSecond.Text = "-"
        lbMessage.Text = ""
    End Sub
    Private Sub formMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Clear()
        MapViewerVersion = Config_Get(My.Application.Info.DirectoryPath & "\MapVersion.txt")
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Try
                If _MapDownload = "A:\" Then
                    Dim FilePathDelete As String() = Directory.GetFiles(_MapDownload)
                    For Each fDelete As String In FilePathDelete
                        Kill(fDelete)
                    Next
                ElseIf lbMode.Text = "MapViewer" Then
                    Dim FilePathDelete As String() = Directory.GetFiles("D:\AutoLoadMapData")
                    For Each fDelete As String In FilePathDelete
                        Kill(fDelete)
                    Next
                End If
            Catch ex As Exception
                MsgBox("กรุณาตรวจสอบแผ่น Flobby disk หรือ Path ไม่ถูกต้อง")
                Exit Sub
            End Try

            clsNfdMap.unzipFiles(pathUnzipDownLoad, BufferDownload)
            Dim FilesBuffer As String() = Directory.GetFiles(BufferDownload)

            For Each filesdata As String In FilesBuffer
                Dim Filesplit As String() = filesdata.Split("\")
                Dim strPath As String = Path.Combine(_MapDownload, Filesplit(3))
                File.Copy(filesdata, strPath)
            Next

            For Each filesdataA As String In FilesBuffer
                Kill(filesdataA)
            Next
            StatusMapview = False
            If lbMode.Text = "MapViewer" Then
                Dim App As String = Path.Combine(SelPath, MapViewerVersion)
                Dim Mapview As String = Path.Combine("D:\AutoLoadMapData", lbLot.Text & "_LOT.xml")
                Process.Start(App, Mapview)
                StatusMapview = True
            Else
                MsgBox("Unzip เรียบร้อยครับ")
            End If



        Catch ex As Exception

            Dim FilesBuffer As String() = Directory.GetFiles(BufferDownload)
            For Each filesdataA As String In FilesBuffer
                Kill(filesdataA)
            Next
            MsgBox(ex.Message)
            MsgBox("ไม่สามารถ Unzip ได้")
        End Try
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Clear()
        EnableButton()
        If StatusMapview = True Then
            Me.WindowState = FormWindowState.Minimized
            MsgBox("Unzip เรียบร้อยครับ")
        End If
    End Sub
   


    Sub EnableButton()
        Clear()
        lbMessage.Text = ""
        btQR.Enabled = True
        btbrowser.Enabled = True
        btGO.Enabled = True
        tbPath.Enabled = True
    End Sub

    Private Sub DisableButton()

   
        lbMessage.Text = "กรุณารอสักครู่. . . . ."
        btQR.Enabled = False
        btbrowser.Enabled = False
        btGO.Enabled = False
        tbPath.Enabled = False

        Application.DoEvents()

    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LED += 1

        Select Case LED
            Case 1
                _LED()
                lbL1.Visible = True
                lbR1.Visible = True
            Case 2
                _LED()
                lbL2.Visible = True
                lbR2.Visible = True
            Case 3
                _LED()
                lbL3.Visible = True
                lbR3.Visible = True
            Case 4
                _LED()
                lbL4.Visible = True
                lbR4.Visible = True
            Case 5
                _LED()
                lbL5.Visible = True
                lbR5.Visible = True
        End Select




        If LED > 5 Then
            LED = 0
        End If
    End Sub
    Sub _LED()
        lbL1.Visible = False
        lbL2.Visible = False
        lbL3.Visible = False
        lbL4.Visible = False
        lbL5.Visible = False
        lbR1.Visible = False
        lbR1.Visible = False
        lbR2.Visible = False
        lbR3.Visible = False
        lbR4.Visible = False
        lbR5.Visible = False
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("คุณต้องการออกจากโปรแกรมหรือไม่ ???", "Do you want exit program ?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub btHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btHelp.Click
        Process.Start(Application.StartupPath & "\MapManualx.pdf")
    End Sub
    Function Config_Get(ByVal File As String) As String
        Dim strBuff As String = ""
        Dim fInfo As New IO.FileInfo(File)
        Dim StmRe As IO.StreamReader = fInfo.OpenText
        Do While StmRe.Peek >= 0
            strBuff += StmRe.ReadLine
        Loop
        StmRe.Close()
        Return strBuff
    End Function

  
End Class
