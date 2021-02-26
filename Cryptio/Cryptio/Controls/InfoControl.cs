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
    public partial class InfoControl : UserControl
    {
        /// <summary>
        /// Zmienna przechowywyująca główny formularz
        /// </summary>
        private Form1 mainForm;

        public InfoControl(Form1 _form1)
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

        private void InfoControl_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Ukryj();
            mainForm.menuCrypto.Pokaz();
        }
    }
}
