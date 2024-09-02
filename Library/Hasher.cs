using System.Security.Cryptography;
using System.Text;

namespace Library;

public class Hasher
{
    public string Hash(string plaintext)
    {
        var sha256 = SHA256.Create();

        var bytes = Encoding.UTF8.GetBytes(plaintext);
        
        // Use hash function of sha256
        var hash = sha256.ComputeHash(bytes);
        
        return ByteArrayFunctions.ByteArrayToString(hash);
    }
}