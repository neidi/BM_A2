using System.Text;

namespace Library;

public static class ByteArrayFunctions
{
    public static string ByteArrayToString(byte[] bytearray)
    {
        var hex = new StringBuilder(bytearray.Length * 2);
        foreach (var b in bytearray)
        {
            hex.Append($"{b:x2}");
        }

        return hex.ToString();
    }
    
    public static byte[] StringToByteArray(string hex)
    {
        if (hex.Length % 2 != 0)
        {
            throw new ArgumentException("String has invalid length. It must use two characters per byte", nameof(hex));
        }

        var numberChars = hex.Length;
        var bytes = new byte[numberChars / 2];
        
        for (var i = 0; i < numberChars; i += 2)
        {
            bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
        }

        return bytes;
    }
}