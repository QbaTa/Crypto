using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Cryptio
{
    class FileOperations
    {
        #region Private Members

        /// <summary>
        /// Variable that stores streamWriter
        /// </summary>
        StreamWriter streamWriter;

        /// <summary>
        /// Variable that stores streaReadera
        /// </summary>
        StreamReader streamReader;

        #endregion

        #region Save Data Methods

        /// <summary>
        /// Method for saving data
        /// </summary>
        /// <param name="_data"> data to write </param>
        /// <param name="_saveFileDialog"> dialogue window </param>
        public void SaveData (string _data,string _filtres, SaveFileDialog _saveFileDialog)
        {
            if (OpenDialog(_saveFileDialog, _filtres) == DialogResult.OK)
            { 
                string path = Path.GetFullPath(_saveFileDialog.FileName);
                streamWriter = new StreamWriter(path);
                streamWriter.WriteLine(_data);
                streamWriter.Close(); 
            }
        }

        /// <summary>
        /// Overloaded method to save
        /// </summary>
        /// <param name="_data"> data to write </param>
        /// <param name="_path"> path to save </param>
        public void SaveData(string _data, string _path, string _filtres, SaveFileDialog _saveFileDialog)
        {
            if (OpenDialog(_saveFileDialog, _filtres) == DialogResult.OK)
            {
                streamWriter = new StreamWriter(_path);
                streamWriter.WriteLine(_data);
                streamWriter.Close();
            }
        }

        #endregion

        #region Read Data Methods
        /// <summary>
        /// Method for reading the data
        /// </summary>
        /// <param name="_filtres"> filters to search for files </param>
        /// <param name="_fileDialog"> dialogue window </param>
        /// <returns></returns>
        public string ReadData(string _filtres, FileDialog _fileDialog)
        {
            string DataToReturn = "";
            if (OpenDialog(_fileDialog, _filtres) == DialogResult.OK)
            {
                string path = Path.GetFullPath(_fileDialog.FileName);
                streamReader = new StreamReader(path);
                while (!streamReader.EndOfStream)
                {
                    DataToReturn += streamReader.ReadLine(); 
                }
                streamReader.Close();
            }
            return DataToReturn;
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Method for opening dialog boxes
        /// </summary>
        /// <param name="_fileDialog"> dialogue window </param>
        /// <param name="_filters"> filters </param>
        /// <returns> DialogResult </returns>
        private DialogResult OpenDialog(FileDialog _fileDialog, string _filters)
        {
            _fileDialog.Filter = _filters;
            DialogResult result = _fileDialog.ShowDialog();

            if (result == DialogResult.OK)
                return DialogResult.OK;
            return result;
        }

        #endregion
    }
}
