namespace EncryptionDecryption;

/// <summary>
/// This class should be the place where RSA is used to encrypt and decrypt strings
/// </summary>
public class AsymmetricEncryptor
{
    public AsymmetricEncryptor()
    {
        // initialize RSA
    }

    public string Encrypt(string plaintext)
    {
        // 1. get the bytes from the encoded plaintext.
        // 2. use RSA to encrypt the bytes from the encoded plaintext. This will give you a byte array.
        // 3. convert byte array to base64 string and return.
        return null;
    }

    public string Decrypt(string encryptedBase64)
    {
        // 1. convert the encrypted base64 string to a byte array.
        // 2. use RSA to decrypt this byte array.
        // 3. Encode this byte array to a UTF8 string and return.
        return null;
    }
}