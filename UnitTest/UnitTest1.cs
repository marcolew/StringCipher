using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod128()
        {
            string password = "yxcvbnm";
            string plaintext = "This is my string, not encrypted.";

            Console.WriteLine("Your encrypted string is:");
            string encryptedstring = StringCipher.StringCipher128.Encrypt(plaintext, password);
            Console.WriteLine(encryptedstring);

            Assert.AreNotEqual(plaintext, encryptedstring);


            Console.WriteLine("Your decrypted string is:");
            string decryptedstring = StringCipher.StringCipher128.Decrypt(encryptedstring, password);
            Console.WriteLine(decryptedstring);

            Assert.AreEqual(plaintext, decryptedstring);
        }
        [TestMethod]
        public void TestMethod256()
        {
            string password = "yxcvbnm";
            string plaintext = "This is my string, not encrypted.";

            Console.WriteLine("Your encrypted string is:");
            string encryptedstring = StringCipher.StringCipher.Encrypt(plaintext, password);
            Console.WriteLine(encryptedstring);

            Assert.AreNotEqual(plaintext, encryptedstring);


            Console.WriteLine("Your decrypted string is:");
            string decryptedstring = StringCipher.StringCipher.Decrypt(encryptedstring, password);
            Console.WriteLine(decryptedstring);

            Assert.AreEqual(plaintext, decryptedstring);
        }
    }
}
