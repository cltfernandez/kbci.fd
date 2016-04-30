Public Class RSACrypt

    Public Shared Function RSAEncrypt(ByVal STREncrypt As String, ByVal RSAKeyInfo As RSAParameters, ByVal DoOAEPPadding As Boolean) As String
        Dim ByteConverter As New UnicodeEncoding
        Dim DataToEncrypt As Byte() = ByteConverter.GetBytes(STREncrypt)
        Try
            Dim encryptedData() As Byte
            'Create a new instance of RSACryptoServiceProvider.
            Dim RSA As New RSACryptoServiceProvider

            'Import the RSA Key information. This only needs
            'toinclude the public key information.
            RSA.ImportParameters(RSAKeyInfo)

            'Encrypt the passed byte array and specify OAEP padding.  
            'OAEP padding is only available on Microsoft Windows XP or
            'later.  
            encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding)
            Return ByteConverter.GetString(encryptedData)
            'Catch and display a CryptographicException  
            'to the console.
        Catch e As CryptographicException
            Console.WriteLine(e.Message)

            Return Nothing
        End Try
    End Function


    Public Shared Function RSADecrypt(ByVal STRDecrypt As String, ByVal RSAKeyInfo As RSAParameters, ByVal DoOAEPPadding As Boolean) As String
        Dim ByteConverter As New UnicodeEncoding
        Dim DataToDecrypt As Byte() = ByteConverter.GetBytes(STRDecrypt)
        Try
            Dim decryptedData() As Byte
            'Create a new instance of RSACryptoServiceProvider.
            Dim RSA As New RSACryptoServiceProvider
            'Import the RSA Key information. This needs
            'to include the private key information.
            RSA.ImportParameters(RSAKeyInfo)

            'Decrypt the passed byte array and specify OAEP padding.  
            'OAEP padding is only available on Microsoft Windows XP or
            'later.  
            decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding)
            'Catch and display a CryptographicException  
            'to the console.
            Return ByteConverter.GetString(decryptedData)
        Catch e As CryptographicException
            Console.WriteLine(e.ToString())

            Return Nothing
        End Try
    End Function
End Class
