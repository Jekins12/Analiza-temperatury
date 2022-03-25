using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
            dane.Clear();
            var lines = System.IO.File.ReadAllLines(openFileDialog1.FileName);
            

            for (int i = 0; i < lines.Length; i++)
            {
                double liczba;
                var line = lines[i].Replace(";", " ").Replace(",", ".").TrimEnd();
                double.TryParse(line, out liczba);
                if (liczba > 0 || liczba < 0) dane.Add(liczba);
            }
            this.dane = dane;


            try
            {
                if (dane.Any())
                {
                    openChart.Enabled = true;
                    zapisz.Enabled = true;
                    clear.Enabled = true;
                }

                textBox1.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
                max.Text = dane.Max().ToString();
                min.Text = dane.Min().ToString();
                avg.Text = (dane.Sum() / dane.Count).ToString();
                vari.Text = Wariancja().ToString();
                
            }
            catch (Exception)
            {
                textBox1.Text = " ";
                MessageBox.Show("Wybierz plik który zawiera próbki z pomiarami", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);              
            }
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

        private void zapisz_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Plik nie został zapisany", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {

                List<string> zapisz = new List<string> { };
                
                zapisz.Add("Wartość maksymalna: " + max.Text);
                zapisz.Add("Wartość minimalna: " + min.Text);
                zapisz.Add("Wartość średnia: " + avg.Text);
                zapisz.Add("Wariancja: " + Wariancja().ToString());

                try
                {
                    System.IO.File.AppendAllLines(saveFileDialog1.FileName,zapisz);
                    MessageBox.Show("Zapisano pomyślnie", "Zapisano", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

                catch (Exception)
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private double Wariancja()
        {
            double wariancja = 0;
            double avg = dane.Sum() / dane.Count();

            for(int i = 0; i < dane.Count(); i++)
                wariancja += Math.Pow(dane[i] - avg,2);
            wariancja /= dane.Count();

            return wariancja;
        }

        private void clear_Click(object sender, EventArgs e)
        {           
            textBox1.Text = "";
            max.Text = "";
            min.Text = "";
            avg.Text = "";
            vari.Text = "";
            zapisz.Enabled = false;            
            openChart.Enabled = false;
        }

        private void def_back_CheckedChanged(object sender, EventArgs e)
        {
            if (def_back.Checked) BackgroundImage = null;
        }
    }
}
