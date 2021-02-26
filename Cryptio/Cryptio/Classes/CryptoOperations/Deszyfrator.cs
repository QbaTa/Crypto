using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptio
{
    public class Deszyfrator : CryptoAbstract
    {
        /// <summary>
        /// A method to decrypt data
        /// </summary>
        /// <param name="_ciangZnakow"> string to decrypt </param>
        /// <param name="_privateUserKey"> user's private key </param>
        /// <param name="_publicOtherUserKey"> the public key of the second user </param>
        /// <returns> Returns an encrypted string </returns>
        public override string Crypto(string _ciangZnakow, int _mainKey)
        {
            byte[] data = StringToByte(_ciangZnakow).ToArray();
            for(int i = 0; i < data.Length; i++)
            {
                data[i] -= (byte)_mainKey;
            }
            return ByteToString(data);
        }
    }
}
