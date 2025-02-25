﻿'共通エラーロギングクラス：singletonパターン
'TemporaryFolderRoot　プロパティを初期化しておくこと


Public Class clsErrorLog
    Private Shared _singleton As clsErrorLog = New clsErrorLog


    Private Sub New()
    End Sub

    Public Shared Function GetInstance() As clsErrorLog
        Return _singleton
    End Function

    Private Shared _errlogFileName As String '汎用エラーログファイル定義
    Property ErrLogFileName() As String
        Get
            Return _errlogFileName
        End Get
        Set(ByVal value As String)
            _errlogFileName = value
        End Set
    End Property
    Public Shared Sub addlog(ByVal strTEXT As String) '汎用エラーメッセージロガー
        Dim flnLog = FreeFile()
        If _errlogFileName = Nothing Then Exit Sub
        Try
            FileOpen(flnLog, _errlogFileName, OpenMode.Append)
            Print(flnLog, strTEXT & vbCrLf)
        Catch
        Finally
            Reset()
        End Try
        If FileLen(_errlogFileName) > (1 * 1024 * 1024) Then
            System.IO.File.Delete(_errlogFileName & ".bak")
            System.IO.File.Move(_errlogFileName, _errlogFileName & ".bak")
        End If
    End Sub

    Public Shared Sub addlogWT(ByVal strTEXT As String, ByVal strHeader As String)
        addlogWT(strHeader & ": " & strTEXT)
    End Sub

    Public Shared Sub addlogWT(ByVal strTEXT As String) 'addlog With Time

        Dim errlog As clsErrorLog = clsErrorLog.GetInstance()
        'errlog.ErrLogFileName = Environment.CurrentDirectory & "\err.log"
        errlog.ErrLogFileName = SelPath & "\LOG\err.log"
        If _errlogFileName Is Nothing OrElse _errlogFileName = "" Then
            Dim e As New System.Exception("clsErrorLog: Not initialized error")
            Throw e
        End If
        Dim flnLog = FreeFile()
        If _errlogFileName = Nothing Then Exit Sub
        Try
            FileOpen(flnLog, _errlogFileName, OpenMode.Append)
            Print(flnLog, strTEXT & ":" & Now.ToShortDateString & " " & Now.ToShortTimeString & vbCrLf)
        Catch
        Finally
            Reset()
        End Try
        If FileLen(_errlogFileName) > (10 * 1024 * 1024) Then
            System.IO.File.Delete(_errlogFileName & ".bak")
            System.IO.File.Move(_errlogFileName, _errlogFileName & ".bak")
        End If
    End Sub

    Public Shared Sub saveEx(ByVal ex As Exception)
        If _errlogFileName Is Nothing OrElse _errlogFileName = "" Then
            Dim e As New System.Exception("clsErrorLog: Not initialized error")
            Throw e
        End If
        Try
            addlog(ex.Message.ToString)
            addlog(ex.Source.ToString)
            addlog(ex.TargetSite.ToString)
            addlog(ex.StackTrace.ToString)
            addlog(Now.ToShortDateString & " " & Now.ToShortTimeString)
            addlog("---------------------------------------")
        Catch
        End Try
    End Sub

    'Public Shared Sub MessageErrorWithAddlog(ByVal strText As String, ByVal strSender As String)
    '    MessageBox.Show(strText, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    addlogWT(strSender & "," & strText)
    'End Sub
    'Public Shared Sub MessageWarningWithAddlog(ByVal strText As String, ByVal strSender As String)
    '    MessageBox.Show(strText, "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    addlogWT(strSender & "," & strText)
    'End Sub
End Class
