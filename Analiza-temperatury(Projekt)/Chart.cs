using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Analiza_temperatury_Projekt_
{
    public partial class Chart : Form
    {
        public static Series s1, s2;
        public static Legend legend;
        public static ChartArea area;
        public List<double> dane;



        public Chart()
        {
            InitializeComponent();
        }

        private void Chart_Load(object sender, EventArgs e)
        {
            Chart_draw();
            kolor1.SelectedIndex = 0;
            kolor2.SelectedIndex = 1;
            gruboscS1.Value = 3;
            gruboscS2.Value = 3;
            legend = wykres.Legends[0];
            legend.Title = "Legenda";
            area = wykres.ChartAreas[0];
            area.Axes[0].Title = "Numer pomiaru";
            area.Axes[1].Title = "Wynik pomiaru";
            


        }
        
        private List<double> Middle()
        {
            List<double> mid_val = new List<double> { };
            double mid = dane.Sum() / dane.Count();
            for(int i=0; i < dane.Count(); i++)
            {
                if (dane[i] >= mid) mid_val.Add(dane[i] - mid);
                else mid_val.Add(mid - dane[i]);
            }
            return dane;
        }

        private void Legenda_CheckedChanged(object sender, EventArgs e)
        {
            legend = wykres.Legends[0];
            if (legend.Enabled)
                legend.Enabled = false;
            else
                legend.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (s1.Enabled)
            {
                s1.Enabled = false;
                gruboscS1.Enabled = false;
                kolor1.Enabled = false;
                gruboscProb.Enabled = false;
            }

            else
            {
                s1.Enabled = true;
                gruboscS1.Enabled = true;
                kolor1.Enabled = true;
                gruboscProb.Enabled = true;
            }
               
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (s2.Enabled)
            {
                s2.Enabled = false;
                gruboscS2.Enabled = false;
                kolor2.Enabled = false;
                gruboscRozn.Enabled = false;
            }

            else
            {
                s2.Enabled = true;
                gruboscS2.Enabled = true;
                kolor2.Enabled = true;
                gruboscRozn.Enabled = true;
            }
        }

        private void kolor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            area = wykres.ChartAreas[0];

            switch (kolor1.SelectedIndex)
            {
                case 0:
                    s1.Color = Color.Red;
                    area.Axes[0].LineColor = Color.Red;
                    area.Axes[1].LineColor = Color.Red;
                    break;

                case 1:
                    s1.Color = Color.Green;
                    area.Axes[0].LineColor = Color.Green;
                    area.Axes[1].LineColor = Color.Green;
                    break;

                case 2:
                    s1.Color = Color.Blue;
                    area.Axes[0].LineColor = Color.Blue;
                    area.Axes[1].LineColor = Color.Blue;
                    break;

                case 3:
                    s1.Color = Color.Yellow;
                    area.Axes[0].LineColor = Color.Yellow;
                    area.Axes[1].LineColor = Color.Yellow;
                    break;

                default:
                    break;
                    
            }
               
        }

        private void kolor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            area = wykres.ChartAreas[0];

            switch (kolor2.SelectedIndex)
            {
                case 0:
                    s2.Color = Color.Red;
                    area.Axes[2].LineColor = Color.Red;
                    area.Axes[3].LineColor = Color.Red;
                    break;

                case 1:
                    s2.Color = Color.Green;
                    area.Axes[2].LineColor = Color.Green;
                    area.Axes[3].LineColor = Color.Green;
                    break;

                case 2:
                    s2.Color = Color.Blue;
                    area.Axes[2].LineColor = Color.Blue;
                    area.Axes[3].LineColor = Color.Blue;
                    break;

                case 3:
                    s2.Color = Color.Yellow;
                    area.Axes[2].LineColor = Color.Yellow;
                    area.Axes[3].LineColor = Color.Yellow;
                    break;

                default:
                    break;

            }
        }


        private void gruboscS1_Scroll_1(object sender, EventArgs e)
        {
            s1.BorderWidth = gruboscS1.Value;
        }

        private void gruboscS2_Scroll(object sender, EventArgs e)
        {
            s2.BorderWidth = gruboscS2.Value;
        }

        private void strzalki_CheckedChanged(object sender, EventArgs e)
        {
            if (strzalki.Checked)
                for (int i = 0; i < 4; i++)
                    area.Axes[i].ArrowStyle = AxisArrowStyle.None;
            else
                for (int i = 0; i < 4; i++)
                    area.Axes[i].ArrowStyle = AxisArrowStyle.Triangle;
        }

        private void podstawowyKol_CheckedChanged(object sender, EventArgs e)
        {
            if (podstawowyKol.Checked)
                for (int i = 0; i < 4; i++)
                    area.Axes[i].LineColor = Color.Black;

            else
            {
                kolor1_SelectedIndexChanged(sender, e);
                kolor2_SelectedIndexChanged(sender, e);
            }
                
            
        }

        private void Chart_draw()
        {
            s1 = wykres.Series[0];
            s2 = wykres.Series[1];
            List<double> mid_val = new List<double> { };
            mid_val = Middle();
            
           
            for (int i = 0; i < dane.Count(); i++)
                s1.Points.AddXY(i, dane[i]);

            for (int i = 1; i < dane.Count(); i++)
                s2.Points.AddXY(i, dane[i] - dane[i - 1]);
        }
    }
}
