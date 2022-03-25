
namespace Analiza_temperatury_Projekt_
{
    partial class Chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chart));
            this.wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Legenda = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.kolor1 = new System.Windows.Forms.ComboBox();
            this.kolor2 = new System.Windows.Forms.ComboBox();
            this.gruboscS1 = new System.Windows.Forms.TrackBar();
            this.gruboscS2 = new System.Windows.Forms.TrackBar();
            this.gruboscProb = new System.Windows.Forms.Label();
            this.gruboscRozn = new System.Windows.Forms.Label();
            this.strzalki = new System.Windows.Forms.CheckBox();
            this.podstawowyKol = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.wykres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruboscS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruboscS2)).BeginInit();
            this.SuspendLayout();
            // 
            // wykres
            // 
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.Title = "Numer pomiaru";
            chartArea1.AxisX2.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY2.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.wykres.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.wykres.Legends.Add(legend1);
            this.wykres.Location = new System.Drawing.Point(13, 13);
            this.wykres.Name = "wykres";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Probki";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Roznica";
            series2.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.wykres.Series.Add(series1);
            this.wykres.Series.Add(series2);
            this.wykres.Size = new System.Drawing.Size(775, 425);
            this.wykres.TabIndex = 0;
            this.wykres.Text = "chart1";
            // 
            // Legenda
            // 
            this.Legenda.AutoSize = true;
            this.Legenda.Checked = true;
            this.Legenda.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Legenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Legenda.Location = new System.Drawing.Point(13, 444);
            this.Legenda.Name = "Legenda";
            this.Legenda.Size = new System.Drawing.Size(117, 17);
            this.Legenda.TabIndex = 1;
            this.Legenda.Text = "Wyświetlaj legendę";
            this.Legenda.UseVisualStyleBackColor = true;
            this.Legenda.CheckedChanged += new System.EventHandler(this.Legenda_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Location = new System.Drawing.Point(13, 468);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(155, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Wyświetlaj serię z próbkami";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.Location = new System.Drawing.Point(12, 491);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(156, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Wyświetlaj serię z różnicami";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // kolor1
            // 
            this.kolor1.FormattingEnabled = true;
            this.kolor1.Items.AddRange(new object[] {
            "Czerwony",
            "Zielony",
            "Niebieski",
            "Żółty"});
            this.kolor1.Location = new System.Drawing.Point(185, 466);
            this.kolor1.Name = "kolor1";
            this.kolor1.Size = new System.Drawing.Size(121, 21);
            this.kolor1.TabIndex = 4;
            this.kolor1.SelectedIndexChanged += new System.EventHandler(this.kolor1_SelectedIndexChanged);
            // 
            // kolor2
            // 
            this.kolor2.FormattingEnabled = true;
            this.kolor2.Items.AddRange(new object[] {
            "Czerwony",
            "Zielony",
            "Niebieski",
            "Żółty"});
            this.kolor2.Location = new System.Drawing.Point(185, 489);
            this.kolor2.Name = "kolor2";
            this.kolor2.Size = new System.Drawing.Size(121, 21);
            this.kolor2.TabIndex = 5;
            this.kolor2.SelectedIndexChanged += new System.EventHandler(this.kolor2_SelectedIndexChanged);
            // 
            // gruboscS1
            // 
            this.gruboscS1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gruboscS1.LargeChange = 1;
            this.gruboscS1.Location = new System.Drawing.Point(340, 453);
            this.gruboscS1.Minimum = 1;
            this.gruboscS1.Name = "gruboscS1";
            this.gruboscS1.Size = new System.Drawing.Size(104, 45);
            this.gruboscS1.TabIndex = 8;
            this.gruboscS1.Value = 1;
            this.gruboscS1.Scroll += new System.EventHandler(this.gruboscS1_Scroll_1);
            // 
            // gruboscS2
            // 
            this.gruboscS2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gruboscS2.LargeChange = 1;
            this.gruboscS2.Location = new System.Drawing.Point(491, 453);
            this.gruboscS2.Minimum = 1;
            this.gruboscS2.Name = "gruboscS2";
            this.gruboscS2.Size = new System.Drawing.Size(104, 45);
            this.gruboscS2.TabIndex = 9;
            this.gruboscS2.Value = 1;
            this.gruboscS2.Scroll += new System.EventHandler(this.gruboscS2_Scroll);
            // 
            // gruboscProb
            // 
            this.gruboscProb.AutoSize = true;
            this.gruboscProb.Location = new System.Drawing.Point(344, 485);
            this.gruboscProb.Name = "gruboscProb";
            this.gruboscProb.Size = new System.Drawing.Size(100, 13);
            this.gruboscProb.TabIndex = 10;
            this.gruboscProb.Text = "Grubość linii próbek";
            // 
            // gruboscRozn
            // 
            this.gruboscRozn.AutoSize = true;
            this.gruboscRozn.Location = new System.Drawing.Point(500, 485);
            this.gruboscRozn.Name = "gruboscRozn";
            this.gruboscRozn.Size = new System.Drawing.Size(95, 13);
            this.gruboscRozn.TabIndex = 11;
            this.gruboscRozn.Text = "Grubość linii różnic";
            // 
            // strzalki
            // 
            this.strzalki.AutoSize = true;
            this.strzalki.Location = new System.Drawing.Point(614, 453);
            this.strzalki.Name = "strzalki";
            this.strzalki.Size = new System.Drawing.Size(160, 17);
            this.strzalki.TabIndex = 12;
            this.strzalki.Text = "Wyłączyć strzałki na osiach";
            this.strzalki.UseVisualStyleBackColor = true;
            this.strzalki.CheckedChanged += new System.EventHandler(this.strzalki_CheckedChanged);
            // 
            // podstawowyKol
            // 
            this.podstawowyKol.AutoSize = true;
            this.podstawowyKol.Location = new System.Drawing.Point(614, 481);
            this.podstawowyKol.Name = "podstawowyKol";
            this.podstawowyKol.Size = new System.Drawing.Size(154, 17);
            this.podstawowyKol.TabIndex = 13;
            this.podstawowyKol.Text = "Podstawowy kolor wykresu";
            this.podstawowyKol.UseVisualStyleBackColor = true;
            this.podstawowyKol.CheckedChanged += new System.EventHandler(this.podstawowyKol_CheckedChanged);
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.podstawowyKol);
            this.Controls.Add(this.strzalki);
            this.Controls.Add(this.gruboscRozn);
            this.Controls.Add(this.gruboscProb);
            this.Controls.Add(this.gruboscS2);
            this.Controls.Add(this.gruboscS1);
            this.Controls.Add(this.kolor2);
            this.Controls.Add(this.kolor1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Legenda);
            this.Controls.Add(this.wykres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Chart";
            this.Text = "Wykres";
            this.Load += new System.EventHandler(this.Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wykres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruboscS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruboscS2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart wykres;
        private System.Windows.Forms.CheckBox Legenda;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox kolor1;
        private System.Windows.Forms.ComboBox kolor2;
        private System.Windows.Forms.TrackBar gruboscS1;
        private System.Windows.Forms.TrackBar gruboscS2;
        private System.Windows.Forms.Label gruboscProb;
        private System.Windows.Forms.Label gruboscRozn;
        private System.Windows.Forms.CheckBox strzalki;
        private System.Windows.Forms.CheckBox podstawowyKol;
    }
}