using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptio.Controls
{
    public partial class UserKeyControl : UserControl
    {
        /// <summary>
        /// Zmienna przechowywyująca główny formularz
        /// </summary>
        private Form1 mainForm;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="form1"> Główny formularz </param>
        public UserKeyControl(Form1 _form1)
        {
            InitializeComponent();

            mainForm = _form1;
            Ukryj();
        }

        /// <summary>
        /// Metoda pokazująca kontrolkę
        /// </summary>
        public void Pokaz()
        {
            Visible = true;
        }

        /// <summary>
        /// Metoda ukrywająca kontrolkę
        /// </summary>
        public void Ukryj()
        {
            Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Ukryj();
            mainForm.menuCrypto.Pokaz();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Ukryj();
            mainForm.menuCrypto.Pokaz();
        }

        private void numUpPrimaryKey_ValueChanged(object sender, EventArgs e)
        {
            ShowUserPublicKey();
        }

        private void numMyPrivateKey_ValueChanged(object sender, EventArgs e)
        {
            ShowUserPublicKey();
            ShowManiKey();
        }

        private void numPublicKeyMan_ValueChanged(object sender, EventArgs e)
        {
            ShowManiKey();
        }

        private void ShowUserPublicKey()
        {
            tbUserText.Text = (KeyManager.GetYourPublicKey((int)numMyPrivateKey.Value, (int)numUpPrimaryKey.Value)).ToString();
        }

        private void ShowManiKey()
        {
            tbMainKey.Text = (KeyManager.GetMainKey((int)numMyPrivateKey.Value, (int)numPublicKeyMan.Value)).ToString();
        }

        
    }
}
