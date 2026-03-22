using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projektwoche2026
{
    public partial class Form1 : Form
    {
        WorkshopController controller = new WorkshopController();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnzeigen_Click(object sender, EventArgs e)
        {
            textBoxAusgabe.Clear();
            List<Workshop> liste = controller.LadeTitel();
            foreach (Workshop w in liste)
            {
                textBoxAusgabe.AppendText(w.Titel + Environment.NewLine);
            }
        }

        private void btnHinzufuegen_Click(object sender, EventArgs e)
        {
            string titel = textBoxNeuerTitel.Text;
            if (string.IsNullOrWhiteSpace(titel))
            {
                MessageBox.Show("Bitte Titel eingeben!");
                return;
            }
            controller.NeuerWorkshop(titel);
            MessageBox.Show("Workshop hinzugefügt!");
            textBoxNeuerTitel.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}