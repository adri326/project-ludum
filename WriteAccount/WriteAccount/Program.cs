using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WriteAccount
{
    class Program
    {
        static void Main(string[] args)
        {

            string pseudo = "dieudonne";
            string password = "123456";

            string passwordHash = HashPassword(password);

            var file = @"C:\Users\jonletourneur\Desktop\test.csv";

            StreamReader csvReader = new StreamReader(file);
            string csvSave = csvReader.ReadToEnd();
            csvReader.Close();
            using (var stream = File.CreateText(file))
            {
                    string csvRow = string.Format(csvSave + "{0};{1}",pseudo,passwordHash);

                    stream.WriteLine(csvRow);
                
            }

            csvReader = new StreamReader(file);
            csvSave = csvReader.ReadToEnd();
            csvReader.Close();


        }

        static string HashPassword(string password)
        {
            var hashAlgorithm = new Org.BouncyCastle.Crypto.Digests.Sha3Digest(512);

            // Choose correct encoding based on your usecase
            byte[] input = Encoding.ASCII.GetBytes(password);

            hashAlgorithm.BlockUpdate(input, 0, input.Length);

            byte[] result = new byte[64]; // 512 / 8 = 64
            hashAlgorithm.DoFinal(result, 0);

            string hashString = BitConverter.ToString(result);
            hashString = hashString.Replace("-", "").ToLowerInvariant();

            return hashString;
        }

        
        
    }
}
