namespace SCPFoundation.Models;

public class RandomStringGenerator
{
    private static Random _random = new Random();
    private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

    public static string Generate(int length)
    {
        char[] result = new char[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = chars[_random.Next(chars.Length)];
        }
        return new string(result);
    }
}
