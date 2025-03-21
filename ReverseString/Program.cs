
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(ReverseString3("Hello"));
    }



    public static string ReverseString(string input)
    {
        string reversed = string.Empty;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }
        return reversed;
    }
    public static string ReverseString1(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public static string ReverseString2(string input)
    {
        return new string(input.Reverse().ToArray());
    }

    public static string ReverseString3(string input)
    {
        string reversed = "";
        foreach (char c in input)
        {
            reversed = c + reversed;
        }
        return reversed;
    }
}




