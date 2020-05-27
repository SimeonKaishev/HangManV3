using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using HangManV2.Data;

namespace HangManV2.Commons
{
    /// <summary>
    /// This class handles hashing related operations
    /// </summary>
    static class Hasher
    {   
        /// <summary>
        /// Generates a salt to be iserted into the password
        /// </summary>
        /// <returns>
        /// The salt value in the form of an byte array
        /// </returns>
        /// <example>
        /// <code>
        /// byte[] salt = GenerateSalt();
        /// </code>
        /// </example>
        private static byte[] GenerateSalt()
        {
            byte[] salt = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }
        /// <summary>
        /// Generates a hashed password
        /// </summary>
        /// <returns>
        /// Salted and hashed password
        /// </returns>
        /// <example>
        /// <code>
        /// usr.Password = Hasher.GetHash(imputPass);
        /// </code>
        /// </example>
        public static string GetHash(string password)
        {
            byte[] salt = GenerateSalt();
            using (var hasher = new Rfc2898DeriveBytes(password, salt, 1000))
            {
                byte[] hashedPass = hasher.GetBytes(20);
                byte[] saltyHashedPassword = new byte[36];
                Array.Copy(hashedPass, 0, saltyHashedPassword, 0, 20);
                Array.Copy(salt, 0, saltyHashedPassword, 20, 16);
                string base64Password = Convert.ToBase64String(saltyHashedPassword);
                return base64Password;
            }
        }
        /// <summary>
        /// well its actaully kinda pointless dont know why its here but im scared to get rid of it
        /// </summary>
        /// <returns>
        /// Salted and hashed password
        /// </returns>
        /// <example>
        /// <code>
        /// idk
        /// </code>
        /// </example>
        public static string GetHash(string password, byte[] salt)
        {
            using (var hasher = new Rfc2898DeriveBytes(password, salt, 1000))
            {
                byte[] hashedPass = hasher.GetBytes(20);
                byte[] saltyHashedPassword = new byte[36];
                Array.Copy(hashedPass, 0, saltyHashedPassword, 0, 20);
                Array.Copy(salt, 0, saltyHashedPassword, 20, 16);
                string base64Password = Convert.ToBase64String(saltyHashedPassword);
                return base64Password;
            }
        }
        /// <summary>
        /// compares a password to the hash saved into the database
        /// </summary>
        /// <example>
        /// <code>
        ///       try
        ///       {
        ///         Hasher.CheckPass(usr, imputPass);
        ///       }
        /// </code>
        /// </example>
        /// <exception cref="HangManV2.Commons.IncorrectPassExeption">Thrown when the hashed values of the passwords don't match
        /// </exception>
        public static void CheckPass(User usr,string imputPass)
        {
            byte[] hashbytes = Convert.FromBase64String(usr.Password);
            byte[] saltExtracted = new byte[16];
            Array.Copy(hashbytes, 20, saltExtracted, 0, 16);
            using (var loginHasher = new Rfc2898DeriveBytes(imputPass, saltExtracted, 1000))
            {
                byte[] hashExtracted = loginHasher.GetBytes(20);
                for (int i = 0; i < 20; i++)
                {
                    if (hashbytes[i] != hashExtracted[i])
                    {
                        throw new IncorrectPassExeption();
                    }
                }
            }
        }
    }
}


