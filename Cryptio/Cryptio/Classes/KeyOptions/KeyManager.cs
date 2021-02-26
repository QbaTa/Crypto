using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptio
{
    static class KeyManager
    {
        /// <summary>
        /// Variable that stores the user's private key
        /// </summary>
        private static int privateUserKey ;

        /// <summary>
        /// A method that stores another user's public key
        /// </summary>
        private static int publicOtherUserKey ;

        /// <summary>
        /// Variable that holds the primary key
        /// </summary>
        private static int primaryKey ;

        /// <summary>
        /// Property for setting and reading another user's key
        /// </summary>
        public static int GetPrivateUserKey
        {
            get
            {
                return privateUserKey;
            }
            set
            {
                privateUserKey = value;
            }
        }

        /// <summary>
        /// Property for setting user key
        /// </summary>
        public static int GetpublicOtherUserKey
        {
            get
            {
                return publicOtherUserKey;
            }
            set
            {
                publicOtherUserKey = value;
            }
        }

        /// <summary>
        /// Method for computing the primary key
        /// </summary>
        /// <returns> MainKey </returns>
        public static int GetMainKey()
        {
            return privateUserKey + publicOtherUserKey;
        }

        /// <summary>
        /// The method of computing your public key
        /// </summary>
        /// <param name="_privateUserKey"></param>
        /// <param name="_PrimaryKey"></param>
        /// <returns></returns>
        public static int GetYourPublicKey(int _privateUserKey, int _PrimaryKey)
        {
            privateUserKey = _privateUserKey;
            primaryKey = _PrimaryKey;
            return _privateUserKey + _PrimaryKey;
        }

        /// <summary>
        /// Overloaded method that computes the primary key
        /// </summary>
        /// <param name="_privateUserKey"></param>
        /// <param name="_publicOtherUserKey"></param>
        /// <returns></returns>
        public static int GetMainKey(int _privateUserKey, int _publicOtherUserKey)
        {
            privateUserKey = _privateUserKey;
            publicOtherUserKey = _publicOtherUserKey;
            return _privateUserKey + _publicOtherUserKey;
        }
    }
}
