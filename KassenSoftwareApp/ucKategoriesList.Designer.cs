
namespace KassenSoftwareApp
{
    partial class ucKategoriesList
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
            this.flpKatList = new System.Windows.Forms.FlowLayoutPanel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.ucKategorie1 = new KassenSoftwareApp.ucKategorie();
            this.ucKategorie2 = new KassenSoftwareApp.ucKategorie();
            this.flpKatList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // flpKatList
            // 
            this.flpKatList.AutoScroll = true;
            this.flpKatList.BackColor = System.Drawing.Color.DarkGray;
            this.flpKatList.Controls.Add(this.ucKategorie1);
            this.flpKatList.Controls.Add(this.ucKategorie2);
            this.flpKatList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpKatList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpKatList.Location = new System.Drawing.Point(0, 0);
            this.flpKatList.Name = "flpKatList";
            this.flpKatList.Size = new System.Drawing.Size(419, 305);
            this.flpKatList.TabIndex = 0;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // ucKategorie1
            // 
            this.ucKategorie1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ucKategorie1.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucKategorie1.Location = new System.Drawing.Point(6, 7);
            this.ucKategorie1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ucKategorie1.Name = "ucKategorie1";
            this.ucKategorie1.PKategorie = "Kategorie";
            this.ucKategorie1.Size = new System.Drawing.Size(125, 58);
            this.ucKategorie1.TabIndex = 0;
            // 
            // ucKategorie2
            // 
            this.ucKategorie2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ucKategorie2.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucKategorie2.Location = new System.Drawing.Point(143, 7);
            this.ucKategorie2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ucKategorie2.Name = "ucKategorie2";
            this.ucKategorie2.PKategorie = "Kategorie";
            this.ucKategorie2.Size = new System.Drawing.Size(125, 58);
            this.ucKategorie2.TabIndex = 1;
            // 
            // ucKategoriesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpKatList);
            this.Name = "ucKategoriesList";
            this.Size = new System.Drawing.Size(419, 305);
            this.flpKatList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpKatList;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private ucKategorie ucKategorie1;
        private ucKategorie ucKategorie2;
    }
}
