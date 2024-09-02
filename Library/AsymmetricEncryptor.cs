using System.Security.Cryptography;
using System.Text;

namespace Library;

/// <summary>
/// This class should be the place where RSA is used to encrypt and decrypt strings
/// </summary>
public class AsymmetricEncryptor
{
    private readonly RSA _rsa;

    public AsymmetricEncryptor()
    {
        _rsa = RSA.Create();
        // initialize RSA
    }

    public string Encrypt(string plaintext)
    {
        // 1. get the bytes from the encoded plaintext.
        var bytes = Encoding.UTF8.GetBytes(plaintext);
        // 2. use AES to encrypt the bytes from the encoded plaintext. This will give you a byte array.
        var encrypted = _rsa.Encrypt(bytes, RSAEncryptionPadding.OaepSHA256);
        // 3. convert byte array to base64 string and return.
        return Convert.ToBase64String(encrypted);
    }

    public string Decrypt(string encryptedBase64)
    {
        // 1. convert the encrypted base64 string to a byte array.
        var encrypted = Convert.FromBase64String(encryptedBase64);
        // 2. use AES to decrypt this byte array.
        var decrypted = _rsa.Decrypt(encrypted, RSAEncryptionPadding.OaepSHA256);
        // 3. Encode this byte array to a UTF8 string and return.
        return Encoding.UTF8.GetString(decrypted);
    }
}