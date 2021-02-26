using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cryptio
{
    public abstract class CryptoAbstract
    {
        /// <summary>
        /// Variable for the data to be encrypted
        /// </summary>
        protected string dataToCrypto;

        #region Converters

        /// <summary>
        /// A method to convert a string to byte array
        /// </summary>
        /// <returns> Byte array </returns>
        protected IEnumerable<byte> StringToByte(string _text)
        {
            byte[] data = Encoding.Default.GetBytes(_text);
            return data;
        }

        /// <summary>
        /// A method to convert a byte array to a string
        /// </summary>
        /// <returns> String </returns>
        protected string ByteToString(byte[] _data)
        {
            string ConvertedData = Encoding.Default.GetString(_data);
            return ConvertedData;
        }

        #endregion

        #region Abstract Methods

        /// <summary>
        /// A method to decrypt or encrypt a string
        /// </summary>
        /// <returns> Encrypted or decrypt a string </returns>
        abstract public string Crypto(string _ciangZnakow, int _mainKey);

        #endregion
    }
}
