using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptio.Controls
{
    public partial class CryptoSzyfr : UserControl
    {
        #region Private Members

        /// <summary>
        /// Variable that stores the main form
        /// </summary>
        private Form1 mainForm;

        /// <summary>
        /// Variable that stores references to the file operations class
        /// </summary>
        private FileOperations fileOperations;

        /// <summary>
        /// A variable that stores references to the crypto abstract class
        /// </summary>
        private CryptoAbstract OdszyfrujZaszyfruj;

        /// <summary>
        /// Variable that stores the file search filters
        /// </summary>
        private string Filerts = "Pliki tekstowe (*.txt)|*.txt| Wszystkie pliki (*.*)|*.*";

        #endregion

        #region Methods

        /// <summary>
        /// A method showing a control
        /// </summary>
        public void Pokaz()
        {
            Visible = true;
        }

        /// <summary>
        /// Overloaded method showing the control
        /// </summary>
        public void Pokaz(CryptoAbstract _cryptoAbstract, string _title)
        {
            OdszyfrujZaszyfruj = _cryptoAbstract;
            lblTitle.Text = _title;
            numUpTwojKlucz.Value = KeyManager.GetPrivateUserKey;
            numUpKluczOdbiorcy.Value = KeyManager.GetpublicOtherUserKey;
            tbResults.Text = "";
            tbUserText.Text = "";
            Pokaz();
        }

        /// <summary>
        /// A method that hides the control
        /// </summary>
        public void Ukryj()
        {
            Visible = false;
        }

        /// <summary>
        /// Method for setting encryption results
        /// </summary>
        private void SetResults()
        {
            tbResults.Text = (OdszyfrujZaszyfruj.Crypto(tbUserText.Text, KeyManager.GetMainKey()));
        }

        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="form1"> Main form </param>
        public CryptoSzyfr(Form1 _form1)
        {
            InitializeComponent();
            fileOperations = new FileOperations();
            mainForm = _form1;
            Ukryj();
        }

        private void tbUserText_TextChanged(object sender, EventArgs e)
        {
            SetResults();
        }

        private void numUpTwojKlucz_ValueChanged(object sender, EventArgs e)
        {
            KeyManager.GetPrivateUserKey = (int)numUpTwojKlucz.Value;
            SetResults();
        }

        private void numUpKluczOdbiorcy_ValueChanged(object sender, EventArgs e)
        {
            KeyManager.GetpublicOtherUserKey = (int)numUpKluczOdbiorcy.Value;
            SetResults();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fileOperations.SaveData(tbResults.Text,Filerts,saveFileDialog1);
            SetResults();
        }

        private void btnUpLoad_Click(object sender, EventArgs e)
        {
            tbUserText.Text = fileOperations.ReadData(Filerts, openFileDialog1);
            SetResults();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ukryj();
            mainForm.menuCrypto.Pokaz();
        }
    }
}
