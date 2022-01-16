
namespace KassenSoftwareApp
{
    partial class Form1
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblProjektTime = new System.Windows.Forms.Label();
            this.lblProjektName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flpKassenPON = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLbPonListClear = new System.Windows.Forms.Button();
            this.btnClearItem = new System.Windows.Forms.Button();
            this.lbPonList = new System.Windows.Forms.ListBox();
            this.lblSumme = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.ucKategoriesList1 = new KassenSoftwareApp.ucKategoriesList();
            this.ucProductsList1 = new KassenSoftwareApp.ucProductsList();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flpKassenPON.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btnTest);
            this.panel1.Controls.Add(this.btnNewProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 710);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 42);
            this.panel1.TabIndex = 0;
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNewProduct.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNewProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnNewProduct.Location = new System.Drawing.Point(1043, 0);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(111, 42);
            this.btnNewProduct.TabIndex = 0;
            this.btnNewProduct.Text = "New Product";
            this.btnNewProduct.UseVisualStyleBackColor = false;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.lblProjektTime);
            this.panel2.Controls.Add(this.lblProjektName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1154, 35);
            this.panel2.TabIndex = 1;
            // 
            // lblProjektTime
            // 
            this.lblProjektTime.AutoSize = true;
            this.lblProjektTime.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjektTime.ForeColor = System.Drawing.Color.Yellow;
            this.lblProjektTime.Location = new System.Drawing.Point(728, 6);
            this.lblProjektTime.Name = "lblProjektTime";
            this.lblProjektTime.Size = new System.Drawing.Size(40, 21);
            this.lblProjektTime.TabIndex = 1;
            this.lblProjektTime.Text = "time";
            // 
            // lblProjektName
            // 
            this.lblProjektName.AutoSize = true;
            this.lblProjektName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjektName.ForeColor = System.Drawing.Color.Yellow;
            this.lblProjektName.Location = new System.Drawing.Point(394, 7);
            this.lblProjektName.Name = "lblProjektName";
            this.lblProjektName.Size = new System.Drawing.Size(251, 21);
            this.lblProjektName.TabIndex = 0;
            this.lblProjektName.Text = "Kassensoftware IT-Hardware GmbH";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 35);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Size = new System.Drawing.Size(1154, 675);
            this.splitContainer1.SplitterDistance = 327;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ucKategoriesList1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flpKassenPON);
            this.splitContainer2.Size = new System.Drawing.Size(327, 675);
            this.splitContainer2.SplitterDistance = 260;
            this.splitContainer2.TabIndex = 3;
            // 
            // flpKassenPON
            // 
            this.flpKassenPON.Controls.Add(this.btnLbPonListClear);
            this.flpKassenPON.Controls.Add(this.btnClearItem);
            this.flpKassenPON.Controls.Add(this.lbPonList);
            this.flpKassenPON.Controls.Add(this.lblSumme);
            this.flpKassenPON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpKassenPON.Location = new System.Drawing.Point(0, 0);
            this.flpKassenPON.Name = "flpKassenPON";
            this.flpKassenPON.Size = new System.Drawing.Size(327, 411);
            this.flpKassenPON.TabIndex = 0;
            // 
            // btnLbPonListClear
            // 
            this.btnLbPonListClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLbPonListClear.Location = new System.Drawing.Point(3, 3);
            this.btnLbPonListClear.Name = "btnLbPonListClear";
            this.btnLbPonListClear.Size = new System.Drawing.Size(133, 64);
            this.btnLbPonListClear.TabIndex = 2;
            this.btnLbPonListClear.Text = "Clear PON";
            this.btnLbPonListClear.UseVisualStyleBackColor = true;
            this.btnLbPonListClear.Click += new System.EventHandler(this.btnLbPonListClear_Click);
            // 
            // btnClearItem
            // 
            this.btnClearItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClearItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearItem.Location = new System.Drawing.Point(142, 3);
            this.btnClearItem.Name = "btnClearItem";
            this.btnClearItem.Size = new System.Drawing.Size(133, 66);
            this.btnClearItem.TabIndex = 5;
            this.btnClearItem.Text = "Clear Item";
            this.btnClearItem.UseVisualStyleBackColor = false;
            this.btnClearItem.Click += new System.EventHandler(this.btnClearItem_Click);
            // 
            // lbPonList
            // 
            this.lbPonList.BackColor = System.Drawing.Color.Honeydew;
            this.lbPonList.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPonList.FormattingEnabled = true;
            this.lbPonList.ItemHeight = 23;
            this.lbPonList.Location = new System.Drawing.Point(3, 75);
            this.lbPonList.Name = "lbPonList";
            this.lbPonList.Size = new System.Drawing.Size(321, 303);
            this.lbPonList.TabIndex = 3;
            // 
            // lblSumme
            // 
            this.lblSumme.BackColor = System.Drawing.Color.Lime;
            this.lblSumme.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSumme.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumme.Location = new System.Drawing.Point(3, 381);
            this.lblSumme.Name = "lblSumme";
            this.lblSumme.Size = new System.Drawing.Size(184, 32);
            this.lblSumme.TabIndex = 3;
            this.lblSumme.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.ucProductsList1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(823, 621);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAll);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(823, 54);
            this.panel4.TabIndex = 2;
            // 
            // btnAll
            // 
            this.btnAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAll.Location = new System.Drawing.Point(731, 0);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(92, 54);
            this.btnAll.TabIndex = 1;
            this.btnAll.Text = "Show All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(780, 3);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(80, 35);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "btnTest";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // ucKategoriesList1
            // 
            this.ucKategoriesList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucKategoriesList1.Location = new System.Drawing.Point(0, 0);
            this.ucKategoriesList1.Name = "ucKategoriesList1";
            this.ucKategoriesList1.Size = new System.Drawing.Size(327, 260);
            this.ucKategoriesList1.TabIndex = 0;
            // 
            // ucProductsList1
            // 
            this.ucProductsList1.AutoScroll = true;
            this.ucProductsList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProductsList1.Location = new System.Drawing.Point(0, 0);
            this.ucProductsList1.Name = "ucProductsList1";
            this.ucProductsList1.Size = new System.Drawing.Size(823, 621);
            this.ucProductsList1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 752);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KassenSoftware 2020";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flpKassenPON.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnLbPonListClear;
        private System.Windows.Forms.Button btnClearItem;
        private System.Windows.Forms.FlowLayoutPanel flpKassenPON;
        private System.Windows.Forms.ListBox lbPonList;
        private System.Windows.Forms.Label lblSumme;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblProjektName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblProjektTime;
        private ucKategoriesList ucKategoriesList1;
        private System.Windows.Forms.Button btnTest;
        private ucProductsList ucProductsList1;
    }
}

