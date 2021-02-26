
namespace Cryptio.Controls
{
    partial class UserKeyControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.numUpPrimaryKey = new System.Windows.Forms.NumericUpDown();
            this.numMyPrivateKey = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUserText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numPublicKeyMan = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMainKey = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numUpPrimaryKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMyPrivateKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPublicKeyMan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(294, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create your key";
            // 
            // numUpPrimaryKey
            // 
            this.numUpPrimaryKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.numUpPrimaryKey.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numUpPrimaryKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.numUpPrimaryKey.Location = new System.Drawing.Point(291, 124);
            this.numUpPrimaryKey.Name = "numUpPrimaryKey";
            this.numUpPrimaryKey.Size = new System.Drawing.Size(120, 29);
            this.numUpPrimaryKey.TabIndex = 17;
            this.numUpPrimaryKey.ValueChanged += new System.EventHandler(this.numUpPrimaryKey_ValueChanged);
            // 
            // numMyPrivateKey
            // 
            this.numMyPrivateKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.numMyPrivateKey.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numMyPrivateKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.numMyPrivateKey.Location = new System.Drawing.Point(291, 187);
            this.numMyPrivateKey.Name = "numMyPrivateKey";
            this.numMyPrivateKey.Size = new System.Drawing.Size(120, 29);
            this.numMyPrivateKey.TabIndex = 18;
            this.numMyPrivateKey.ValueChanged += new System.EventHandler(this.numMyPrivateKey_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(173, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Primary key :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(137, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Your private key :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(444, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Here is your public key :";
            // 
            // tbUserText
            // 
            this.tbUserText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.tbUserText.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbUserText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.tbUserText.Location = new System.Drawing.Point(651, 157);
            this.tbUserText.Name = "tbUserText";
            this.tbUserText.ReadOnly = true;
            this.tbUserText.Size = new System.Drawing.Size(59, 29);
            this.tbUserText.TabIndex = 22;
            this.tbUserText.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(385, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 128);
            this.label5.TabIndex = 23;
            this.label5.Text = "}";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(155, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 22);
            this.label7.TabIndex = 26;
            this.label7.Text = "Recipient\'s public key :";
            // 
            // numPublicKeyMan
            // 
            this.numPublicKeyMan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.numPublicKeyMan.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numPublicKeyMan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.numPublicKeyMan.Location = new System.Drawing.Point(357, 355);
            this.numPublicKeyMan.Name = "numPublicKeyMan";
            this.numPublicKeyMan.Size = new System.Drawing.Size(120, 29);
            this.numPublicKeyMan.TabIndex = 24;
            this.numPublicKeyMan.ValueChanged += new System.EventHandler(this.numPublicKeyMan_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(470, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 36);
            this.label6.TabIndex = 27;
            this.label6.Text = "}";
            // 
            // tbMainKey
            // 
            this.tbMainKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.tbMainKey.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbMainKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.tbMainKey.Location = new System.Drawing.Point(690, 356);
            this.tbMainKey.Name = "tbMainKey";
            this.tbMainKey.ReadOnly = true;
            this.tbMainKey.Size = new System.Drawing.Size(59, 29);
            this.tbMainKey.TabIndex = 29;
            this.tbMainKey.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(493, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 22);
            this.label8.TabIndex = 28;
            this.label8.Text = "Here is your secret key:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(274, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(285, 36);
            this.label9.TabIndex = 30;
            this.label9.Text = "Create a master key";
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.btnBack.Location = new System.Drawing.Point(18, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(43, 38);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.btnOk.Location = new System.Drawing.Point(352, 416);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(144, 39);
            this.btnOk.TabIndex = 31;
            this.btnOk.Text = "Done";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // UserKeyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbMainKey);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numPublicKeyMan);
            this.Controls.Add(this.tbUserText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numMyPrivateKey);
            this.Controls.Add(this.numUpPrimaryKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.Name = "UserKeyControl";
            this.Size = new System.Drawing.Size(816, 489);
            ((System.ComponentModel.ISupportInitialize)(this.numUpPrimaryKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMyPrivateKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPublicKeyMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUpPrimaryKey;
        private System.Windows.Forms.NumericUpDown numMyPrivateKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUserText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numPublicKeyMan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMainKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
