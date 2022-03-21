using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analiza_temperatury_Projekt_
{
    public partial class Form1 : Form
    {
        private List<double> dane=new List<double> { };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Plik nie został wczytany", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                
                ReadData(dane);
            }
        }
       
        

        public void ReadData(List<double> dane)
        {
            var lines = System.IO.File.ReadAllLines(openFileDialog1.FileName);

            //List<double> dane = new List<double> { };

            for (int i = 0; i < lines.Length; i++)
            {
                double liczba;
                var line = lines[i].Replace(";", " ").Replace(",", ".").TrimEnd();
                double.TryParse(line, out liczba);
                if (liczba > 0 || liczba < 0) dane.Add(liczba);
            }

            if (dane.Any())
            {
                openChart.Enabled = true;
            }


            textBox1.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
            max.Text = dane[1].ToString();
            min.Text = dane.Min().ToString();
            avg.Text = (dane.Sum() / dane.Count).ToString();
            vari.Text = "null";
            this.dane = dane;
        }

        private void openChart_Click(object sender, EventArgs e)
        {
            Chart chart = new Chart();
            chart.dane = this.dane;
            chart.Show();
            
        }


        private void formClosingEvent(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Na pewno chcesz zamknąć program?", "",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result==System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
