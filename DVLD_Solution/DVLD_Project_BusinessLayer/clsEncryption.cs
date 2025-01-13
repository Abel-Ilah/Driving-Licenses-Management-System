using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace BusinessLayer
{
    public static class clsEncryption
    {
        static Random rand = new Random();
        static char GetRandomCapitaleLetter()
        {
            return Convert.ToChar(rand.Next(65, 90));
        }
        static char GetRandomSmallLetter()
        {
            return Convert.ToChar(rand.Next(97, 123));
        }
        static char GetRandomDigit()
        {
            return Convert.ToChar(rand.Next(48, 58));
        }
        static char GetRandomLetterOrDigit()
        {
            char[] Chars = { GetRandomCapitaleLetter(), GetRandomSmallLetter(), GetRandomDigit() };

            return Chars[rand.Next(0, 3)];
        }
        static string FirstEncryption(string Text)
        {
           // string EncryptedText = "";

            StringBuilder EncryptedText = new StringBuilder();

            EncryptedText.Append(GetRandomLetterOrDigit());//add Random Prefix

            for (int i = Text.Length - 1; i >= 0; i--)
            {
                EncryptedText.Append(Text[i]);
            }

            for (int i = 0; i < 3; i++) //add 3 random characters (suffix)
            {
                EncryptedText.Append(GetRandomLetterOrDigit());
            }
            return EncryptedText.ToString();
        }
        static string SecondEncryption(string Text)
        {
            //string EncryptedText = string.Empty;

            StringBuilder EncryptedText=new StringBuilder();
            for (int i = 0; i < Text.Length; i++)
            {
                int DecimalValueOfCharacter = Convert.ToInt32(Text[i]);
                EncryptedText.Append($"{DecimalValueOfCharacter}-");
            }
            EncryptedText = EncryptedText.Remove(EncryptedText.Length-1,1);
            return EncryptedText.ToString();
        }
        static string ReverseText(StringBuilder Text)
        {
            StringBuilder reversedText = new StringBuilder(Text.Length);

            for (int i = Text.Length - 1; i >= 0; i--)
            {
                reversedText.Append(Text[i]);
            }

            return reversedText.ToString();
        }

        public static string EncrypteText(string Text)
        {
            string EncryptedText = string.Empty;
            EncryptedText = FirstEncryption(Text);
            EncryptedText = SecondEncryption(EncryptedText);
            return EncryptedText;
        }
        public  static string DecryptText(string Text)
        {
            StringBuilder DecryptedText = new StringBuilder();
            string[] DecimalValuesOfTextCharacters = Text.Split('-');

            foreach (string DecimalValue in DecimalValuesOfTextCharacters)
            {
                DecryptedText.Append( Convert.ToChar(Convert.ToInt32(DecimalValue)));
            }
            DecryptedText = DecryptedText.Remove(DecryptedText.Length - 3, 3);
            DecryptedText = DecryptedText.Remove(0,1);


            return ReverseText(DecryptedText);
        }

        public static string ComputeHash(string input)
        {
            //SHA is Secured Hash Algorithm.
            // Create an instance of the SHA-256 algorithm
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash value from the UTF-8 encoded input string
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Convert the byte array to a lowercase hexadecimal string
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        public static bool IsHash(string input)
        {
            // Example checks for SHA-256 hash format
            if (input.Length == 64 && Regex.IsMatch(input, @"^[a-fA-F0-9]+$"))
            {
                return true;
            }

            // Example checks for Bcrypt hash format
            if (input.Length == 60 && (input.StartsWith("$2a$") || input.StartsWith("$2b$") || input.StartsWith("$2y$")))
            {
                return true;
            }

            return false;
        }
    }
}
