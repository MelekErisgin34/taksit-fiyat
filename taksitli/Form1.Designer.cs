namespace taksitli
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.lblTaksittutari = new System.Windows.Forms.Label();
            this.lblTaksitsayisi = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.tbTaksitsayisi = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbTaksitsayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHesapla.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnHesapla.Location = new System.Drawing.Point(420, 103);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(59, 42);
            this.btnHesapla.TabIndex = 11;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(169, 47);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(190, 20);
            this.txtFiyat.TabIndex = 10;
            // 
            // lblTaksittutari
            // 
            this.lblTaksittutari.AutoSize = true;
            this.lblTaksittutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaksittutari.Location = new System.Drawing.Point(50, 178);
            this.lblTaksittutari.Name = "lblTaksittutari";
            this.lblTaksittutari.Size = new System.Drawing.Size(129, 24);
            this.lblTaksittutari.TabIndex = 9;
            this.lblTaksittutari.Text = "Taksit Tutari:";
            // 
            // lblTaksitsayisi
            // 
            this.lblTaksitsayisi.AutoSize = true;
            this.lblTaksitsayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaksitsayisi.Location = new System.Drawing.Point(38, 100);
            this.lblTaksitsayisi.Name = "lblTaksitsayisi";
            this.lblTaksitsayisi.Size = new System.Drawing.Size(130, 24);
            this.lblTaksitsayisi.TabIndex = 8;
            this.lblTaksitsayisi.Text = "Taksit Sayısı:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(65, 47);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(60, 24);
            this.lblFiyat.TabIndex = 7;
            this.lblFiyat.Text = "Fiyat:";
            // 
            // tbTaksitsayisi
            // 
            this.tbTaksitsayisi.Location = new System.Drawing.Point(186, 100);
            this.tbTaksitsayisi.Maximum = 12;
            this.tbTaksitsayisi.Minimum = 1;
            this.tbTaksitsayisi.Name = "tbTaksitsayisi";
            this.tbTaksitsayisi.Size = new System.Drawing.Size(190, 45);
            this.tbTaksitsayisi.TabIndex = 6;
            this.tbTaksitsayisi.Value = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(500, 399);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.lblTaksittutari);
            this.Controls.Add(this.lblTaksitsayisi);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.tbTaksitsayisi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbTaksitsayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label lblTaksittutari;
        private System.Windows.Forms.Label lblTaksitsayisi;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TrackBar tbTaksitsayisi;
    }
}

