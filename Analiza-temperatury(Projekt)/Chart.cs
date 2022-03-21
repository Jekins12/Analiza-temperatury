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
    public partial class Chart : Form
    {
        public List<double> dane;
        public Chart()
        {
            InitializeComponent();
        }

        private void Chart_Load(object sender, EventArgs e)
        {
            for(int i=0; i<dane.Count(); i++)
            {
                wykres.Series["Wykres 1"].Points.AddXY(i, dane[i]);
            }
        }
        

    }
}
