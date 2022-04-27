Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

' Credits : https://github.com/Ammaar9/FileEncDecVer1 (Pas de notre niveau actuel)
Public Class Security
    ''' <summary>
    ''' Necessary declaration
    ''' </summary>
    Private KEY_128 As Byte() = {32, 11, 52, 67, 211, 43, 90, 141, 123, 0, 4, 52, 62, 51, 0, 121, 41, 80, 24, 141, 113, 241, 104, 12, 75, 229, 107, 150, 10, 45, 78, 21}
    Private IV_128 As Byte() = {214, 17, 22, 34, 224, 221, 230, 209, 1, 92, 55, 56, 98, 43, 25, 18}
    Private enc As New UTF8Encoding
    Private encryptor As ICryptoTransform
    Private decryptor As ICryptoTransform
    Private symmetricKey As New RijndaelManaged()
    ''' <summary>
    ''' Class default constructor
    ''' </summary>
    Public Sub New()
        symmetricKey.Mode = CipherMode.CBC
        Me.encryptor = symmetricKey.CreateEncryptor(KEY_128, IV_128)
        Me.decryptor = symmetricKey.CreateDecryptor(KEY_128, IV_128)
    End Sub
    ''' <summary>
    ''' This function encrypts the string file
    ''' </summary>
    ''' <param name="sPlainText">String: plain text file content</param>
    ''' <returns>String: Encrypted file content</returns>
    Public Function doEncrypt(ByVal sPlainText As String) As String
        Dim answer As String = ""
        If Not String.IsNullOrEmpty(sPlainText) Then
            Dim memoryStream As MemoryStream = New MemoryStream()
            Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, Me.encryptor, CryptoStreamMode.Write)
            cryptoStream.Write(Me.enc.GetBytes(sPlainText), 0, sPlainText.Length)
            cryptoStream.FlushFinalBlock()
            answer = Convert.ToBase64String(memoryStream.ToArray())
            memoryStream.Close()
            cryptoStream.Close()
        End If
        Return answer
    End Function
    ''' <summary>
    ''' This function decrypt the content of the encrypted file
    ''' </summary>
    ''' <param name="sCypherText">String: The encrypted file</param>
    ''' <returns>String: the plain text file decrypted</returns>
    Public Function doDecrypt(ByVal sCypherText As String) As String
        Dim answer As String = ""
        Dim cypherTextBytes As Byte() = Convert.FromBase64String(sCypherText)
        Dim memoryStream As MemoryStream = New MemoryStream(cypherTextBytes)
        Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, Me.decryptor, CryptoStreamMode.Read)
        Dim plainTextBytes(cypherTextBytes.Length) As Byte
        Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)
        memoryStream.Close()
        cryptoStream.Close()
        answer = Me.enc.GetString(plainTextBytes, 0, decryptedByteCount)
        Return answer
    End Function
End Class
