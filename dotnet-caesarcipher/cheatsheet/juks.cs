using System.Text;

class JukseProgram
{
    static void JukseMain(string[] args)
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


    /*
    Jeg prøvde å dektryptere out-encrypted-english.txt.
    Hvis du sammenligner in-english.txt og out-decrypted-english.txt 
    så ser du at den bommer på enkelte karakterer. 
    --> Her fungerer det altså ikke helt som det skal.
    */
    static string Encrypt(string text, int shiftAmount)
    {
        StringBuilder encryptedText = new StringBuilder();

        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                char encryptedChar = (char)(c + shiftAmount);
                if (!char.IsLetterOrDigit(encryptedChar))
                {
                    encryptedChar = (char)(c + shiftAmount - 26);
                }
                encryptedText.Append(encryptedChar);
            }
            else
            {
                encryptedText.Append(c);
            }
        }

        return encryptedText.ToString();
    }

    static string Decrypt(string text, int shift)
    {
        return Encrypt(text, -shift);
    }
}
