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
    public partial class MenuCrypto : UserControl
    {
        #region Private Members

        /// <summary>
        /// Variable that stores the main form
        /// </summary>
        private Form1 mainForm;

        /// <summary>
        /// An array that stores references to the encoder and decryptor class
        /// </summary>
        CryptoAbstract[] cryptoOptions = new CryptoAbstract[]
        {
             new Szyfrator(),
             new Deszyfrator(),
        };

        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="form1"> Main form </param>
        public MenuCrypto(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
            Ukryj();
        }

        /// <summary>
        /// A method showing a control
        /// </summary>
        public void Pokaz()
        {
            Visible = true;
        }

        /// <summary>
        /// A method that hides the control
        /// </summary>
        public void Ukryj()
        {
            Visible = false;
        }

        /// <summary>
        /// The method responsible for clicking the button
        /// </summary>
        private void btnSzyruj_Click(object sender, EventArgs e)
        {
            mainForm.cryptoSzyfr.Pokaz(cryptoOptions[0], "Encrypt your message");
            Ukryj();
        }

        /// <summary>
        /// The method responsible for clicking the button
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.cryptoSzyfr.Pokaz(cryptoOptions[1], "Decrypt your message");
            Ukryj();
        }

        /// <summary>
        /// The method responsible for clicking the button
        /// </summary>
        private void btnInfo_Click(object sender, EventArgs e)
        {
            mainForm.infoControl.Pokaz();
            Ukryj();
        }

        private void btnSetKey_Click(object sender, EventArgs e)
        {
            mainForm.userKeyControl.Pokaz();
            Ukryj();
        }
    }
}
