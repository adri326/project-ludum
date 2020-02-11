using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WriteAccount;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestCreateAccount()
        {
            //arrange
            var file = @"C:\Users\jonletourneur\Desktop\test.csv";
            using (var stream = File.CreateText(file))
            {
                stream.Flush();

            }

            //act
            Program.CreateAccount("Utilisateur1","Utilisateur1@gmail.com","123456");
            
            StreamReader csvReader = new StreamReader(file);

            //assert

        }
    }
}
