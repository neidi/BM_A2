using System.Security.Cryptography;
using System.Text;

namespace Library;

/// <summary>
/// This class is where AES should be used to encrypt and decrypt strings
/// </summary>
public class SymmetricEncryptor
{
    private readonly Aes _aes;

    public SymmetricEncryptor()
    {
        // initialize AES
        _aes = Aes.Create();
        _aes.Key = ByteArrayFunctions.StringToByteArray("eb213655ce7ac25591def2aad983e4f0c261ec890577a3f5babeea0670d6d110");
        _aes.IV = ByteArrayFunctions.StringToByteArray("c8ef77b5f071d8d30c9a0592a98f00e9");
    }

    public string Encrypt(string plaintext)
    {
        // 1. get the bytes from the encoded plaintext.
        var bytes = Encoding.UTF8.GetBytes(plaintext);
        // 2. use AES to encrypt the bytes from the encoded plaintext. This will give you a byte array.
        var encrypted = _aes.EncryptCbc(bytes, _aes.IV);
        // 3. convert byte array to base64 string and return.
        return ByteArrayFunctions.ByteArrayToString(encrypted);
    }

    public string Decrypt(string base64)
    {
        // 1. convert the encrypted base64 string to a byte array.
        var encrypted = ByteArrayFunctions.StringToByteArray(base64);
        // 2. use AES to decrypt this byte array.
        var decrypted = _aes.DecryptCbc(encrypted, _aes.IV);
        // 3. Encode this byte array to a UTF8 string and return.
        return Encoding.UTF8.GetString(decrypted);
    }
}