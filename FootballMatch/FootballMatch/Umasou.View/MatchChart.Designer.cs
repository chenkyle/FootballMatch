namespace FootballMatch.Umasou.View
{
    partial class MatchChart
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
            this.chart_match = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_match)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_match
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_match.ChartAreas.Add(chartArea1);
            this.chart_match.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_match.Legends.Add(legend1);
            this.chart_match.Location = new System.Drawing.Point(0, 0);
            this.chart_match.Name = "chart_match";
            this.chart_match.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_match.Series.Add(series1);
            this.chart_match.Size = new System.Drawing.Size(476, 348);
            this.chart_match.TabIndex = 1;
            this.chart_match.Text = "球赛统计图";
            this.chart_match.Click += new System.EventHandler(this.chart_match_Click);
            // 
            // MatchChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 348);
            this.Controls.Add(this.chart_match);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MatchChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "赛事统计视图";
            this.Load += new System.EventHandler(this.MatchChart_Load);
            this.Shown += new System.EventHandler(this.MatchChart_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.chart_match)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_match;
    }
}