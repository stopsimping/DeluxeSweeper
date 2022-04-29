Imports System.IO
Module Encryption
    ' Credits : https://github.com/Ammaar9/FileEncDecVer1 (Pas de notre niveau actuel)
    Dim SecurityLayer As New Security
    Public Sub Encrypt(filePath As String)
        Try
            Dim PText As String = My.Computer.FileSystem.ReadAllText(filePath)
            Dim CText As String = SecurityLayer.doEncrypt(PText)
            My.Computer.FileSystem.WriteAllText(filePath, CText, False)
            'MsgBox("File has been encrypted successfully.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function Decrypt(filePath As String)
        Try
            Dim CText As String = My.Computer.FileSystem.ReadAllText(filePath)
            Dim PText As String = SecurityLayer.doDecrypt(CText)
            Return PText
        Catch ex As Exception
            MsgBox(ex.Message)
            Return "unknown:0:0"
        End Try
    End Function

    ' Our function
    Public Sub Write(filePath As String, entry As String)
        Try
            If (System.IO.File.ReadAllText(Settings.saveFilePath).Length = 0) Then
                Dim CText As String = SecurityLayer.doEncrypt(entry)
                My.Computer.FileSystem.WriteAllText(filePath, CText, False)
                Return
            Else
                Dim PText As String = Encryption.Decrypt(filePath)
                Dim CText As String = SecurityLayer.doEncrypt(PText & Environment.NewLine & entry)
                My.Computer.FileSystem.WriteAllText(filePath, CText, False)
            End If
            'MsgBox("Message written successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
