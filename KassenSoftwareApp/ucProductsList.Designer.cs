
namespace KassenSoftwareApp
{
    partial class ucProductsList
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
            this.flpProductsflp = new System.Windows.Forms.FlowLayoutPanel();
            this.ucProduct1 = new KassenSoftwareApp.ucProduct();
            this.flpProductsflp.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpProductsflp
            // 
            this.flpProductsflp.AutoScroll = true;
            this.flpProductsflp.AutoSize = true;
            this.flpProductsflp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.flpProductsflp.Controls.Add(this.ucProduct1);
            this.flpProductsflp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpProductsflp.Location = new System.Drawing.Point(0, 0);
            this.flpProductsflp.Name = "flpProductsflp";
            this.flpProductsflp.Size = new System.Drawing.Size(859, 597);
            this.flpProductsflp.TabIndex = 0;
            // 
            // ucProduct1
            // 
            this.ucProduct1.BackColor = System.Drawing.Color.SlateGray;
            this.ucProduct1.Location = new System.Drawing.Point(3, 3);
            this.ucProduct1.Name = "ucProduct1";
            this.ucProduct1.PKategorie = "kategorie";
            this.ucProduct1.PName = "Product Name";
            this.ucProduct1.Size = new System.Drawing.Size(191, 236);
            this.ucProduct1.TabIndex = 0;
            // 
            // ucProductsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpProductsflp);
            this.Name = "ucProductsList";
            this.Size = new System.Drawing.Size(859, 597);
            this.flpProductsflp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpProductsflp;
        private ucProduct ucProduct1;
    }
}
