
namespace KassenSoftwareApp
{
    partial class ucProduct
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProductSN = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblKategorie = new System.Windows.Forms.Label();
            this.picProductBild = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picProductBild)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductSN
            // 
            this.lblProductSN.AutoSize = true;
            this.lblProductSN.BackColor = System.Drawing.Color.White;
            this.lblProductSN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductSN.ForeColor = System.Drawing.Color.Red;
            this.lblProductSN.Location = new System.Drawing.Point(5, 94);
            this.lblProductSN.Name = "lblProductSN";
            this.lblProductSN.Size = new System.Drawing.Size(94, 17);
            this.lblProductSN.TabIndex = 1;
            this.lblProductSN.Text = "Serial No. 1234";
            this.lblProductSN.Click += new System.EventHandler(this.picProductBild_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDescription.Location = new System.Drawing.Point(3, 153);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(186, 83);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description of this Itemhjghjghjghjghjghjghhgh";
            this.lblDescription.Click += new System.EventHandler(this.picProductBild_Click);
            // 
            // lblKategorie
            // 
            this.lblKategorie.AutoSize = true;
            this.lblKategorie.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorie.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblKategorie.Location = new System.Drawing.Point(5, 111);
            this.lblKategorie.Name = "lblKategorie";
            this.lblKategorie.Size = new System.Drawing.Size(66, 17);
            this.lblKategorie.TabIndex = 4;
            this.lblKategorie.Text = "kategorie";
            this.lblKategorie.Click += new System.EventHandler(this.picProductBild_Click);
            // 
            // picProductBild
            // 
            this.picProductBild.BackColor = System.Drawing.Color.White;
            this.picProductBild.Image = global::KassenSoftwareApp.Properties.Resources.festplatte;
            this.picProductBild.Location = new System.Drawing.Point(3, 3);
            this.picProductBild.Name = "picProductBild";
            this.picProductBild.Size = new System.Drawing.Size(186, 108);
            this.picProductBild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProductBild.TabIndex = 3;
            this.picProductBild.TabStop = false;
            this.picProductBild.Click += new System.EventHandler(this.picProductBild_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Lime;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(1, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(69, 25);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price €";
            this.lblPrice.Click += new System.EventHandler(this.picProductBild_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.Color.SlateGray;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(3, 128);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(136, 25);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            this.lblProductName.Click += new System.EventHandler(this.picProductBild_Click);
            // 
            // ucProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblKategorie);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblProductSN);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.picProductBild);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(191, 236);
            ((System.ComponentModel.ISupportInitialize)(this.picProductBild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProductSN;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox picProductBild;
        private System.Windows.Forms.Label lblKategorie;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProductName;
    }
}
