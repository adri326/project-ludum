using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WriteAccount
{
    public class Program
    {
        static void Main(string[] args)
        {

            CreateAccount("1","2","3");

            Console.WriteLine(ConnectAccount("2","4"));
            Console.ReadLine();
            


        }

        /// <summary>
        /// Permet de se connecter à un compte
        /// </summary>
        /// <param name="mail">Le mail de connection</param>
        /// <param name="password">Le mot de passe pour la connection</param>
        /// <returns>Retourne si la connection a marché ou pas</returns>
        public static bool ConnectAccount(string mail, string password)
        {
            //Cette variable sera à modifier d'après le chemin d'accés du fichier csv
            var file = @"C:\Users\jonletourneur\Desktop\test.csv";
            StreamReader csvReader = new StreamReader(file);
            string[] csvSave;

            while(!csvReader.EndOfStream)
            {
                csvSave = csvReader.ReadLine().Split(';');
                if(mail == csvSave[1] && csvSave[2] == HashPassword(password))
                {
                    return true;
                }
            }


            return false;
        }

        /// <summary>
        /// Sert à créer un compte
        /// </summary>
        /// <param name="pseudo">le pseudo du compte créé</param>
        /// <param name="mail">le mail qui servira d'identifiant</param>
        /// <param name="password">le mot de passe de la personne</param>
        public static bool CreateAccount(string pseudo, string mail, string password)
        {
            string passwordHash = HashPassword(password);

            //Cette variable sera à modifier d'après le chemin d'accés du fichier csv
            var file = @"C:\Users\jonletourneur\Desktop\test.csv";

            StreamReader csvReader = new StreamReader(file);
            string csvSave = csvReader.ReadToEnd();
            csvReader.Close();
            using (var stream = File.CreateText(file))
            {
                string csvRow = string.Format(csvSave + "{0};{1};{2}", pseudo, mail, passwordHash);

                stream.WriteLine(csvRow);

            }

            return true;
        }

        /// <summary>
        /// Code qui sert à hasher un mot de passe, le code provien de https://stackoverflow.com/questions/57857330/how-can-i-get-sha3-512-hash-in-c par l'utilisateur NineBerry
        /// </summary>
        /// <param name="password">Mot de passe qui vas être hashé</param>
        /// <returns>mot de passe hashé</returns>
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
