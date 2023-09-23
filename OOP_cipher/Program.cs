using OOP_cipher;

class Program
{

    static void Main(string[] args)
    {
        Cipher cipher = new ACipher("Hello world");
        string encodeCipher = cipher.Encode();
        Console.WriteLine($"REs after encoding is: {encodeCipher}");
        cipher.Decode(encodeCipher);
        //Разобрались с ACipher и проверили функциональность

        //Создаем BCipher и проверяем функциональность
        Console.WriteLine();
        Cipher bCipher = new BCipher("zyxcba");
        string res = bCipher.Encode();
        Console.WriteLine($"REs after encoding is: {res}");
        bCipher.Decode(res);

    }
}