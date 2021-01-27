
namespace Encapsulation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMarka = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.btnEtiketOlustur = new System.Windows.Forms.Button();
            this.gbAyakkabi = new System.Windows.Forms.GroupBox();
            this.lblRenk = new System.Windows.Forms.Label();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.lblNumara = new System.Windows.Forms.Label();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.gbEtiket = new System.Windows.Forms.GroupBox();
            this.lblMarka2 = new System.Windows.Forms.Label();
            this.lblRenk2 = new System.Windows.Forms.Label();
            this.lblNumara2 = new System.Windows.Forms.Label();
            this.txtEtiketMarka = new System.Windows.Forms.TextBox();
            this.lblFiyat2 = new System.Windows.Forms.Label();
            this.txtEtiketRenk = new System.Windows.Forms.TextBox();
            this.txtEtiketNumara = new System.Windows.Forms.TextBox();
            this.txtEtiketFiyat = new System.Windows.Forms.TextBox();
            this.gbAyakkabi.SuspendLayout();
            this.gbEtiket.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMarka
            // 
            this.lblMarka.Location = new System.Drawing.Point(38, 58);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(107, 25);
            this.lblMarka.TabIndex = 0;
            this.lblMarka.Text = "Marka:";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(151, 55);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(175, 27);
            this.txtMarka.TabIndex = 1;
            // 
            // btnEtiketOlustur
            // 
            this.btnEtiketOlustur.Location = new System.Drawing.Point(190, 269);
            this.btnEtiketOlustur.Name = "btnEtiketOlustur";
            this.btnEtiketOlustur.Size = new System.Drawing.Size(136, 29);
            this.btnEtiketOlustur.TabIndex = 2;
            this.btnEtiketOlustur.Text = "Etiket Oluştur";
            this.btnEtiketOlustur.UseVisualStyleBackColor = true;
            this.btnEtiketOlustur.Click += new System.EventHandler(this.btnEtiketOlustur_Click);
            // 
            // gbAyakkabi
            // 
            this.gbAyakkabi.Controls.Add(this.txtFiyat);
            this.gbAyakkabi.Controls.Add(this.txtNumara);
            this.gbAyakkabi.Controls.Add(this.txtRenk);
            this.gbAyakkabi.Controls.Add(this.lblFiyat);
            this.gbAyakkabi.Controls.Add(this.txtMarka);
            this.gbAyakkabi.Controls.Add(this.lblNumara);
            this.gbAyakkabi.Controls.Add(this.btnEtiketOlustur);
            this.gbAyakkabi.Controls.Add(this.lblRenk);
            this.gbAyakkabi.Controls.Add(this.lblMarka);
            this.gbAyakkabi.Location = new System.Drawing.Point(85, 70);
            this.gbAyakkabi.Name = "gbAyakkabi";
            this.gbAyakkabi.Size = new System.Drawing.Size(369, 329);
            this.gbAyakkabi.TabIndex = 3;
            this.gbAyakkabi.TabStop = false;
            this.gbAyakkabi.Text = "Ayakkabı";
            // 
            // lblRenk
            // 
            this.lblRenk.Location = new System.Drawing.Point(38, 111);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(107, 25);
            this.lblRenk.TabIndex = 0;
            this.lblRenk.Text = "Renk:";
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(151, 108);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(175, 27);
            this.txtRenk.TabIndex = 1;
            // 
            // lblNumara
            // 
            this.lblNumara.Location = new System.Drawing.Point(38, 163);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(107, 25);
            this.lblNumara.TabIndex = 0;
            this.lblNumara.Text = "Numara:";
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(151, 160);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(175, 27);
            this.txtNumara.TabIndex = 1;
            // 
            // lblFiyat
            // 
            this.lblFiyat.Location = new System.Drawing.Point(38, 212);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(107, 25);
            this.lblFiyat.TabIndex = 0;
            this.lblFiyat.Text = "Fiyat:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(151, 209);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(175, 27);
            this.txtFiyat.TabIndex = 1;
            // 
            // gbEtiket
            // 
            this.gbEtiket.Controls.Add(this.txtEtiketFiyat);
            this.gbEtiket.Controls.Add(this.txtEtiketMarka);
            this.gbEtiket.Controls.Add(this.txtEtiketNumara);
            this.gbEtiket.Controls.Add(this.lblMarka2);
            this.gbEtiket.Controls.Add(this.txtEtiketRenk);
            this.gbEtiket.Controls.Add(this.lblRenk2);
            this.gbEtiket.Controls.Add(this.lblFiyat2);
            this.gbEtiket.Controls.Add(this.lblNumara2);
            this.gbEtiket.Location = new System.Drawing.Point(583, 70);
            this.gbEtiket.Name = "gbEtiket";
            this.gbEtiket.Size = new System.Drawing.Size(369, 329);
            this.gbEtiket.TabIndex = 4;
            this.gbEtiket.TabStop = false;
            this.gbEtiket.Text = "Etiket";
            // 
            // lblMarka2
            // 
            this.lblMarka2.Location = new System.Drawing.Point(36, 58);
            this.lblMarka2.Name = "lblMarka2";
            this.lblMarka2.Size = new System.Drawing.Size(107, 25);
            this.lblMarka2.TabIndex = 0;
            this.lblMarka2.Text = "Marka:";
            // 
            // lblRenk2
            // 
            this.lblRenk2.Location = new System.Drawing.Point(36, 111);
            this.lblRenk2.Name = "lblRenk2";
            this.lblRenk2.Size = new System.Drawing.Size(107, 25);
            this.lblRenk2.TabIndex = 0;
            this.lblRenk2.Text = "Renk:";
            // 
            // lblNumara2
            // 
            this.lblNumara2.Location = new System.Drawing.Point(36, 163);
            this.lblNumara2.Name = "lblNumara2";
            this.lblNumara2.Size = new System.Drawing.Size(107, 25);
            this.lblNumara2.TabIndex = 0;
            this.lblNumara2.Text = "Numara:";
            // 
            // txtEtiketMarka
            // 
            this.txtEtiketMarka.Location = new System.Drawing.Point(149, 55);
            this.txtEtiketMarka.Name = "txtEtiketMarka";
            this.txtEtiketMarka.Size = new System.Drawing.Size(175, 27);
            this.txtEtiketMarka.TabIndex = 1;
            // 
            // lblFiyat2
            // 
            this.lblFiyat2.Location = new System.Drawing.Point(36, 212);
            this.lblFiyat2.Name = "lblFiyat2";
            this.lblFiyat2.Size = new System.Drawing.Size(107, 25);
            this.lblFiyat2.TabIndex = 0;
            this.lblFiyat2.Text = "KDV\'li Fiyat:";
            // 
            // txtEtiketRenk
            // 
            this.txtEtiketRenk.Location = new System.Drawing.Point(149, 108);
            this.txtEtiketRenk.Name = "txtEtiketRenk";
            this.txtEtiketRenk.Size = new System.Drawing.Size(175, 27);
            this.txtEtiketRenk.TabIndex = 1;
            // 
            // txtEtiketNumara
            // 
            this.txtEtiketNumara.Location = new System.Drawing.Point(149, 160);
            this.txtEtiketNumara.Name = "txtEtiketNumara";
            this.txtEtiketNumara.Size = new System.Drawing.Size(175, 27);
            this.txtEtiketNumara.TabIndex = 1;
            // 
            // txtEtiketFiyat
            // 
            this.txtEtiketFiyat.Location = new System.Drawing.Point(149, 209);
            this.txtEtiketFiyat.Name = "txtEtiketFiyat";
            this.txtEtiketFiyat.Size = new System.Drawing.Size(175, 27);
            this.txtEtiketFiyat.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 662);
            this.Controls.Add(this.gbEtiket);
            this.Controls.Add(this.gbAyakkabi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbAyakkabi.ResumeLayout(false);
            this.gbAyakkabi.PerformLayout();
            this.gbEtiket.ResumeLayout(false);
            this.gbEtiket.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Button btnEtiketOlustur;
        private System.Windows.Forms.GroupBox gbAyakkabi;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.GroupBox gbEtiket;
        private System.Windows.Forms.TextBox txtEtiketFiyat;
        private System.Windows.Forms.TextBox txtEtiketMarka;
        private System.Windows.Forms.TextBox txtEtiketNumara;
        private System.Windows.Forms.Label lblMarka2;
        private System.Windows.Forms.TextBox txtEtiketRenk;
        private System.Windows.Forms.Label lblRenk2;
        private System.Windows.Forms.Label lblFiyat2;
        private System.Windows.Forms.Label lblNumara2;
    }
}

