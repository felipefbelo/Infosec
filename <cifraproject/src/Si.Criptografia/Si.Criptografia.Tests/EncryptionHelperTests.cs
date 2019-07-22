using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Si.Criptografia.Tests
{
    [TestClass]
    public class EncryptionHelperTests
    {
        [TestMethod]
        public void EncryptTest()
        {
            string encryptedString = EncryptionHelper.Encrypt("ADA", "IC");
            Assert.AreEqual(encryptedString, "00001000000001110000100001000011");
        }

        [TestMethod]
        public void DecryptTest()
        {
            string decryptedString = EncryptionHelper.Decrypt("00001000000001110000100001000011", "IC");
            Assert.AreEqual(decryptedString, "ADA");
        }

        [TestMethod]
        public void EncryptDecryptTest()
        {
            string key = "I";
            string input = "Danilo Singh";
            string encryptedString = EncryptionHelper.Encrypt(input, key);
            string decryptedString = EncryptionHelper.Decrypt(encryptedString, key);
            Assert.AreEqual(input, decryptedString);
        }
    }
}
