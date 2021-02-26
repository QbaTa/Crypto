using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cryptio.Controls;

namespace Cryptio
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Variables for controls
        /// </summary>
        public CryptoSzyfr cryptoSzyfr;
        public MenuCrypto menuCrypto;
        public InfoControl infoControl;
        public UserKeyControl userKeyControl;

        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            /// <summary>
            /// We create controls
            /// </summary>
            cryptoSzyfr = new CryptoSzyfr(this);
            menuCrypto = new MenuCrypto(this);
            infoControl = new InfoControl(this);
            userKeyControl = new UserKeyControl(this);

            /// <summary>
            /// We set the controls to be stretched across the screen
            /// </summary>
            cryptoSzyfr.Dock = DockStyle.Fill;
            menuCrypto.Dock = DockStyle.Fill;
            infoControl.Dock = DockStyle.Fill;
            userKeyControl.Dock = DockStyle.Fill;

            /// <summary>
            /// We add controls
            /// </summary>
            Controls.Add(cryptoSzyfr);
            Controls.Add(menuCrypto);
            Controls.Add(infoControl);
            Controls.Add(userKeyControl);

            menuCrypto.Pokaz();

        }
    }
}
