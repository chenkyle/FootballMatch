namespace FootballMatch.Umasou.Business
{
    partial class ReportOfInfo
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
            this.label_match = new System.Windows.Forms.Label();
            this.label_season = new System.Windows.Forms.Label();
            this.label_Turn = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // label_match
            // 
            this.label_match.AutoSize = true;
            this.label_match.Location = new System.Drawing.Point(231, 21);
            this.label_match.Name = "label_match";
            this.label_match.Size = new System.Drawing.Size(29, 12);
            this.label_match.TabIndex = 0;
            this.label_match.Text = "赛事";
            // 
            // label_season
            // 
            this.label_season.AutoSize = true;
            this.label_season.Location = new System.Drawing.Point(289, 21);
            this.label_season.Name = "label_season";
            this.label_season.Size = new System.Drawing.Size(29, 12);
            this.label_season.TabIndex = 0;
            this.label_season.Text = "赛季";
            // 
            // label_Turn
            // 
            this.label_Turn.AutoSize = true;
            this.label_Turn.Location = new System.Drawing.Point(508, 21);
            this.label_Turn.Name = "label_Turn";
            this.label_Turn.Size = new System.Drawing.Size(29, 12);
            this.label_Turn.TabIndex = 0;
            this.label_Turn.Text = "轮次";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(685, 319);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // ReportOfInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 319);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.label_Turn);
            this.Controls.Add(this.label_season);
            this.Controls.Add(this.label_match);
            this.Name = "ReportOfInfo";
            this.Text = "ReportOfInfo";
            this.Shown += new System.EventHandler(this.ReportOfInfo_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_match;
        private System.Windows.Forms.Label label_season;
        private System.Windows.Forms.Label label_Turn;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;

    }
}