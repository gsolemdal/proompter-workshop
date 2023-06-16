using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the command (encrypt/decrypt):");
        string inputCommand = Console.ReadLine();

        Console.WriteLine("Enter the key (shift number):");
        string key = Console.ReadLine();

        Console.WriteLine("Enter the input file path:");
        string inputFilePath = Console.ReadLine();

        Console.WriteLine("Enter the output file path:");
        string outputFilePath = Console.ReadLine();

        try
        {
            string text = File.ReadAllText(inputFilePath);

            if (inputCommand.ToLower() == "encrypt")
            {
                var encryptedText = Encrypt(text, int.Parse(key));
                File.WriteAllText(outputFilePath, encryptedText);
                Console.WriteLine("Encrypted text successfully written to the output file.");
            }

            if (inputCommand.ToLower() == "decrypt")
            {
                var decryptedText = Decrypt(text, int.Parse(key));
                File.WriteAllText(outputFilePath, decryptedText);
                Console.WriteLine("Decrypted text successfully written to the output file.");
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }


    static string Encrypt(string text, int shiftAmount)
    {
        // TODO: Implement this method
        return text;
    }

    static string Decrypt(string text, int shift)
    {
        // TODO: Implement this method
        return text;
    }
}
