namespace FootballMatch.Umasou.Business
{
    partial class CreateNewSeason
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
            this.groupBox_seasonInfo = new System.Windows.Forms.GroupBox();
            this.button_scheduleSet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_seasonDescInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_matchName = new System.Windows.Forms.ComboBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.textBox_numOfSeason = new System.Windows.Forms.TextBox();
            this.groupBox_seasonInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_seasonInfo
            // 
            this.groupBox_seasonInfo.Controls.Add(this.textBox_numOfSeason);
            this.groupBox_seasonInfo.Controls.Add(this.button_scheduleSet);
            this.groupBox_seasonInfo.Controls.Add(this.label4);
            this.groupBox_seasonInfo.Controls.Add(this.label3);
            this.groupBox_seasonInfo.Controls.Add(this.label2);
            this.groupBox_seasonInfo.Controls.Add(this.textBox_seasonDescInfo);
            this.groupBox_seasonInfo.Controls.Add(this.label1);
            this.groupBox_seasonInfo.Controls.Add(this.comboBox_matchName);
            this.groupBox_seasonInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_seasonInfo.Location = new System.Drawing.Point(0, 0);
            this.groupBox_seasonInfo.Name = "groupBox_seasonInfo";
            this.groupBox_seasonInfo.Size = new System.Drawing.Size(468, 205);
            this.groupBox_seasonInfo.TabIndex = 0;
            this.groupBox_seasonInfo.TabStop = false;
            this.groupBox_seasonInfo.Text = "赛季信息";
            // 
            // button_scheduleSet
            // 
            this.button_scheduleSet.Location = new System.Drawing.Point(213, 154);
            this.button_scheduleSet.Name = "button_scheduleSet";
            this.button_scheduleSet.Size = new System.Drawing.Size(77, 31);
            this.button_scheduleSet.TabIndex = 1;
            this.button_scheduleSet.Text = "赛程设定";
            this.button_scheduleSet.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(399, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "赛季";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(326, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "第";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F);
            this.label2.Location = new System.Drawing.Point(28, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "赛季描述";
            // 
            // textBox_seasonDescInfo
            // 
            this.textBox_seasonDescInfo.Location = new System.Drawing.Point(116, 58);
            this.textBox_seasonDescInfo.Multiline = true;
            this.textBox_seasonDescInfo.Name = "textBox_seasonDescInfo";
            this.textBox_seasonDescInfo.Size = new System.Drawing.Size(322, 67);
            this.textBox_seasonDescInfo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "赛事名称";
            // 
            // comboBox_matchName
            // 
            this.comboBox_matchName.FormattingEnabled = true;
            this.comboBox_matchName.Location = new System.Drawing.Point(116, 25);
            this.comboBox_matchName.Name = "comboBox_matchName";
            this.comboBox_matchName.Size = new System.Drawing.Size(121, 20);
            this.comboBox_matchName.TabIndex = 0;
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(244, 211);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 37);
            this.button_ok.TabIndex = 1;
            this.button_ok.Text = "确定";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(363, 210);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 37);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // textBox_numOfSeason
            // 
            this.textBox_numOfSeason.Location = new System.Drawing.Point(356, 24);
            this.textBox_numOfSeason.Name = "textBox_numOfSeason";
            this.textBox_numOfSeason.Size = new System.Drawing.Size(37, 21);
            this.textBox_numOfSeason.TabIndex = 5;
            // 
            // createNewSeason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 259);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.groupBox_seasonInfo);
            this.Name = "createNewSeason";
            this.Text = "新建赛季";
            this.Load += new System.EventHandler(this.createNewSeason_Load);
            this.groupBox_seasonInfo.ResumeLayout(false);
            this.groupBox_seasonInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_seasonInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_seasonDescInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_matchName;
        private System.Windows.Forms.Button button_scheduleSet;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox textBox_numOfSeason;
    }
}