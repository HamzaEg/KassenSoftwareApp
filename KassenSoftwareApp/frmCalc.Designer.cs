
namespace KassenSoftwareApp
{
    partial class frmCalc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAnzahl = new System.Windows.Forms.Label();
            this.lblMenus = new System.Windows.Forms.Label();
            this.lblPlus = new System.Windows.Forms.Label();
            this.lblZero = new System.Windows.Forms.Label();
            this.lblHundred = new System.Windows.Forms.Label();
            this.lblFifty = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblFive = new System.Windows.Forms.Label();
            this.pZahlen = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblXClose = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pZahlen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAnzahl);
            this.panel1.Controls.Add(this.lblMenus);
            this.panel1.Controls.Add(this.lblPlus);
            this.panel1.Location = new System.Drawing.Point(12, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 168);
            this.panel1.TabIndex = 9;
            // 
            // lblAnzahl
            // 
            this.lblAnzahl.BackColor = System.Drawing.Color.Black;
            this.lblAnzahl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAnzahl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAnzahl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAnzahl.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnzahl.ForeColor = System.Drawing.Color.Lime;
            this.lblAnzahl.Location = new System.Drawing.Point(152, 0);
            this.lblAnzahl.Name = "lblAnzahl";
            this.lblAnzahl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAnzahl.Size = new System.Drawing.Size(315, 168);
            this.lblAnzahl.TabIndex = 6;
            this.lblAnzahl.Text = "1";
            this.lblAnzahl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnzahl.Click += new System.EventHandler(this.lblAnzahl_Click);
            this.lblAnzahl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblAnzahl_MouseClick);
            // 
            // lblMenus
            // 
            this.lblMenus.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblMenus.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMenus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMenus.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenus.Location = new System.Drawing.Point(0, 0);
            this.lblMenus.Name = "lblMenus";
            this.lblMenus.Size = new System.Drawing.Size(152, 168);
            this.lblMenus.TabIndex = 7;
            this.lblMenus.Text = "-";
            this.lblMenus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenus.Click += new System.EventHandler(this.lblMenus_Click);
            // 
            // lblPlus
            // 
            this.lblPlus.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPlus.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPlus.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus.Location = new System.Drawing.Point(467, 0);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(163, 168);
            this.lblPlus.TabIndex = 8;
            this.lblPlus.Text = "+";
            this.lblPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlus.Click += new System.EventHandler(this.lblPlus_Click);
            // 
            // lblZero
            // 
            this.lblZero.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblZero.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZero.Location = new System.Drawing.Point(5, 9);
            this.lblZero.Name = "lblZero";
            this.lblZero.Size = new System.Drawing.Size(224, 99);
            this.lblZero.TabIndex = 13;
            this.lblZero.Text = "0";
            this.lblZero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblZero.Click += new System.EventHandler(this.lblZero_Click);
            // 
            // lblHundred
            // 
            this.lblHundred.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblHundred.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHundred.Location = new System.Drawing.Point(24, 9);
            this.lblHundred.Name = "lblHundred";
            this.lblHundred.Size = new System.Drawing.Size(128, 116);
            this.lblHundred.TabIndex = 15;
            this.lblHundred.Text = "100";
            this.lblHundred.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHundred.Click += new System.EventHandler(this.lblHundred_Click);
            // 
            // lblFifty
            // 
            this.lblFifty.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblFifty.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFifty.Location = new System.Drawing.Point(172, 9);
            this.lblFifty.Name = "lblFifty";
            this.lblFifty.Size = new System.Drawing.Size(128, 116);
            this.lblFifty.TabIndex = 14;
            this.lblFifty.Text = "50";
            this.lblFifty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFifty.Click += new System.EventHandler(this.lblFifty_Click);
            // 
            // lblTen
            // 
            this.lblTen.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(328, 9);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(128, 116);
            this.lblTen.TabIndex = 12;
            this.lblTen.Text = "10";
            this.lblTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTen.Click += new System.EventHandler(this.lblTen_Click);
            // 
            // lblFive
            // 
            this.lblFive.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblFive.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFive.Location = new System.Drawing.Point(478, 9);
            this.lblFive.Name = "lblFive";
            this.lblFive.Size = new System.Drawing.Size(128, 116);
            this.lblFive.TabIndex = 11;
            this.lblFive.Text = "5";
            this.lblFive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFive.Click += new System.EventHandler(this.lblFive_Click);
            // 
            // pZahlen
            // 
            this.pZahlen.BackColor = System.Drawing.Color.LightGray;
            this.pZahlen.Controls.Add(this.lblFive);
            this.pZahlen.Controls.Add(this.lblHundred);
            this.pZahlen.Controls.Add(this.lblTen);
            this.pZahlen.Controls.Add(this.lblFifty);
            this.pZahlen.Location = new System.Drawing.Point(12, 303);
            this.pZahlen.Name = "pZahlen";
            this.pZahlen.Size = new System.Drawing.Size(623, 134);
            this.pZahlen.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-1, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(647, 186);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // lblXClose
            // 
            this.lblXClose.BackColor = System.Drawing.Color.Red;
            this.lblXClose.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblXClose.Location = new System.Drawing.Point(548, 9);
            this.lblXClose.Name = "lblXClose";
            this.lblXClose.Size = new System.Drawing.Size(94, 85);
            this.lblXClose.TabIndex = 19;
            this.lblXClose.Text = "X";
            this.lblXClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblXClose.Click += new System.EventHandler(this.lblXClose_Click);
            // 
            // frmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(647, 446);
            this.Controls.Add(this.lblXClose);
            this.Controls.Add(this.pZahlen);
            this.Controls.Add(this.lblZero);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCalc";
            this.Text = "frmCalc";
            this.panel1.ResumeLayout(false);
            this.pZahlen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAnzahl;
        private System.Windows.Forms.Label lblMenus;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Label lblZero;
        private System.Windows.Forms.Label lblHundred;
        private System.Windows.Forms.Label lblFifty;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblFive;
        private System.Windows.Forms.Panel pZahlen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblXClose;
    }
}