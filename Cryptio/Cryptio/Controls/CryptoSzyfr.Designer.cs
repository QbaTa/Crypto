
namespace Cryptio.Controls
{
    partial class CryptoSzyfr
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbUserText = new System.Windows.Forms.TextBox();
            this.tbResults = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpLoad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.numUpTwojKlucz = new System.Windows.Forms.NumericUpDown();
            this.numUpKluczOdbiorcy = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpTwojKlucz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpKluczOdbiorcy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(248, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(316, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Encrypt your message";
            // 
            // tbUserText
            // 
            this.tbUserText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.tbUserText.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbUserText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.tbUserText.Location = new System.Drawing.Point(230, 190);
            this.tbUserText.Name = "tbUserText";
            this.tbUserText.Size = new System.Drawing.Size(359, 33);
            this.tbUserText.TabIndex = 1;
            this.tbUserText.Text = "Hello World";
            this.tbUserText.TextChanged += new System.EventHandler(this.tbUserText_TextChanged);
            // 
            // tbResults
            // 
            this.tbResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.tbResults.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.tbResults.Location = new System.Drawing.Point(230, 291);
            this.tbResults.Name = "tbResults";
            this.tbResults.ReadOnly = true;
            this.tbResults.Size = new System.Drawing.Size(359, 33);
            this.tbResults.TabIndex = 2;
            this.tbResults.Text = "Hello World";
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(230, 416);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 53);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpLoad
            // 
            this.btnUpLoad.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpLoad.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.btnUpLoad.Location = new System.Drawing.Point(445, 416);
            this.btnUpLoad.Name = "btnUpLoad";
            this.btnUpLoad.Size = new System.Drawing.Size(144, 53);
            this.btnUpLoad.TabIndex = 5;
            this.btnUpLoad.Text = "Load";
            this.btnUpLoad.UseVisualStyleBackColor = true;
            this.btnUpLoad.Click += new System.EventHandler(this.btnUpLoad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(201, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "💎";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(570, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "💎";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(25, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 128);
            this.label8.TabIndex = 12;
            this.label8.Text = "🛡";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(636, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 128);
            this.label3.TabIndex = 13;
            this.label3.Text = "🛡";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // numUpTwojKlucz
            // 
            this.numUpTwojKlucz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.numUpTwojKlucz.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numUpTwojKlucz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.numUpTwojKlucz.Location = new System.Drawing.Point(379, 87);
            this.numUpTwojKlucz.Name = "numUpTwojKlucz";
            this.numUpTwojKlucz.Size = new System.Drawing.Size(120, 29);
            this.numUpTwojKlucz.TabIndex = 15;
            this.numUpTwojKlucz.ValueChanged += new System.EventHandler(this.numUpTwojKlucz_ValueChanged);
            // 
            // numUpKluczOdbiorcy
            // 
            this.numUpKluczOdbiorcy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.numUpKluczOdbiorcy.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numUpKluczOdbiorcy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.numUpKluczOdbiorcy.Location = new System.Drawing.Point(379, 133);
            this.numUpKluczOdbiorcy.Name = "numUpKluczOdbiorcy";
            this.numUpKluczOdbiorcy.Size = new System.Drawing.Size(120, 29);
            this.numUpKluczOdbiorcy.TabIndex = 16;
            this.numUpKluczOdbiorcy.ValueChanged += new System.EventHandler(this.numUpKluczOdbiorcy_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(287, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Your key:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(251, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Recipient key:";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(17, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 38);
            this.button1.TabIndex = 19;
            this.button1.Text = "←";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CryptoSzyfr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numUpKluczOdbiorcy);
            this.Controls.Add(this.numUpTwojKlucz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbResults);
            this.Controls.Add(this.tbUserText);
            this.Controls.Add(this.lblTitle);
            this.Name = "CryptoSzyfr";
            this.Size = new System.Drawing.Size(816, 489);
            ((System.ComponentModel.ISupportInitialize)(this.numUpTwojKlucz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpKluczOdbiorcy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbUserText;
        private System.Windows.Forms.TextBox tbResults;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NumericUpDown numUpTwojKlucz;
        private System.Windows.Forms.NumericUpDown numUpKluczOdbiorcy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}
