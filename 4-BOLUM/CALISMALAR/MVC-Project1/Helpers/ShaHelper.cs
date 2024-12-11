using System.Security.Cryptography;
using System.Text;

public class ShaHelper
{
    public static string ToSha512(string rawData)
    {
        SHA512 sha512 = SHA512.Create();
        byte[] inputByte = Encoding.UTF8.GetBytes(rawData);
        byte[] hashByte = sha512.ComputeHash(inputByte);
        StringBuilder builder = new StringBuilder();
        foreach (byte b in hashByte)
        {
            builder.Append(b.ToString("x2"));
        }

        return builder.ToString();
    }

}
