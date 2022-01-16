
namespace KassenSoftwareApp
{
    partial class ucKategorie
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
            this.lblKategorie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKategorie
            // 
            this.lblKategorie.BackColor = System.Drawing.Color.Silver;
            this.lblKategorie.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorie.Location = new System.Drawing.Point(0, 0);
            this.lblKategorie.Name = "lblKategorie";
            this.lblKategorie.Size = new System.Drawing.Size(125, 58);
            this.lblKategorie.TabIndex = 1;
            this.lblKategorie.Text = "Kategorie";
            this.lblKategorie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKategorie.Click += new System.EventHandler(this.lblKategorie_Click);
            // 
            // ucKategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.lblKategorie);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ucKategorie";
            this.Size = new System.Drawing.Size(125, 58);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ucKategorie_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblKategorie;
    }
}
