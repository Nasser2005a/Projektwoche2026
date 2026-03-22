using System;
using System.Windows.Forms;

namespace Projektwoche2026
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxAusgabe;
        private System.Windows.Forms.TextBox textBoxNeuerTitel;
        private System.Windows.Forms.Button btnAnzeigen;
        private System.Windows.Forms.Button btnHinzufuegen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxAusgabe = new System.Windows.Forms.TextBox();
            this.textBoxNeuerTitel = new System.Windows.Forms.TextBox();
            this.btnAnzeigen = new System.Windows.Forms.Button();
            this.btnHinzufuegen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAusgabe
            // 
            this.textBoxAusgabe.Location = new System.Drawing.Point(20, 50);
            this.textBoxAusgabe.Multiline = true;
            this.textBoxAusgabe.Name = "textBoxAusgabe";
            this.textBoxAusgabe.Size = new System.Drawing.Size(500, 150);
            this.textBoxAusgabe.TabIndex = 1;
            // 
            // textBoxNeuerTitel
            // 
            this.textBoxNeuerTitel.Location = new System.Drawing.Point(20, 280);
            this.textBoxNeuerTitel.Name = "textBoxNeuerTitel";
            this.textBoxNeuerTitel.Size = new System.Drawing.Size(300, 22);
            this.textBoxNeuerTitel.TabIndex = 4;
            // 
            // btnAnzeigen
            // 
            this.btnAnzeigen.Location = new System.Drawing.Point(20, 210);
            this.btnAnzeigen.Name = "btnAnzeigen";
            this.btnAnzeigen.Size = new System.Drawing.Size(100, 30);
            this.btnAnzeigen.TabIndex = 2;
            this.btnAnzeigen.Text = "Titel anzeigen";
            this.btnAnzeigen.Click += new System.EventHandler(this.btnAnzeigen_Click);
            // 
            // btnHinzufuegen
            // 
            this.btnHinzufuegen.Location = new System.Drawing.Point(340, 276);
            this.btnHinzufuegen.Name = "btnHinzufuegen";
            this.btnHinzufuegen.Size = new System.Drawing.Size(100, 26);
            this.btnHinzufuegen.TabIndex = 5;
            this.btnHinzufuegen.Text = "Hinzufügen";
            this.btnHinzufuegen.Click += new System.EventHandler(this.btnHinzufuegen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alle Workshop-Titel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Neuen Workshop hinzufügen:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(560, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAusgabe);
            this.Controls.Add(this.btnAnzeigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNeuerTitel);
            this.Controls.Add(this.btnHinzufuegen);
            this.Name = "Form1";
            this.Text = "Workshop Verwaltung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}