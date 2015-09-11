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
            this.label_numHelp = new System.Windows.Forms.Label();
            this.textBox_MatchName = new System.Windows.Forms.TextBox();
            this.textBox_numOfSeason = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_seasonDescInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_NumOfTurn = new System.Windows.Forms.TextBox();
            this.groupBox_seasonInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_seasonInfo
            // 
            this.groupBox_seasonInfo.Controls.Add(this.textBox_NumOfTurn);
            this.groupBox_seasonInfo.Controls.Add(this.label5);
            this.groupBox_seasonInfo.Controls.Add(this.label_numHelp);
            this.groupBox_seasonInfo.Controls.Add(this.textBox_MatchName);
            this.groupBox_seasonInfo.Controls.Add(this.textBox_numOfSeason);
            this.groupBox_seasonInfo.Controls.Add(this.label4);
            this.groupBox_seasonInfo.Controls.Add(this.label3);
            this.groupBox_seasonInfo.Controls.Add(this.label2);
            this.groupBox_seasonInfo.Controls.Add(this.textBox_seasonDescInfo);
            this.groupBox_seasonInfo.Controls.Add(this.label1);
            this.groupBox_seasonInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_seasonInfo.Location = new System.Drawing.Point(0, 0);
            this.groupBox_seasonInfo.Name = "groupBox_seasonInfo";
            this.groupBox_seasonInfo.Size = new System.Drawing.Size(606, 237);
            this.groupBox_seasonInfo.TabIndex = 0;
            this.groupBox_seasonInfo.TabStop = false;
            this.groupBox_seasonInfo.Text = "赛季信息";
            // 
            // label_numHelp
            // 
            this.label_numHelp.AutoSize = true;
            this.label_numHelp.ForeColor = System.Drawing.Color.Red;
            this.label_numHelp.Location = new System.Drawing.Point(461, 28);
            this.label_numHelp.Name = "label_numHelp";
            this.label_numHelp.Size = new System.Drawing.Size(0, 12);
            this.label_numHelp.TabIndex = 7;
            // 
            // textBox_MatchName
            // 
            this.textBox_MatchName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_MatchName.Location = new System.Drawing.Point(117, 26);
            this.textBox_MatchName.Name = "textBox_MatchName";
            this.textBox_MatchName.ReadOnly = true;
            this.textBox_MatchName.Size = new System.Drawing.Size(154, 21);
            this.textBox_MatchName.TabIndex = 6;
            // 
            // textBox_numOfSeason
            // 
            this.textBox_numOfSeason.Location = new System.Drawing.Point(356, 25);
            this.textBox_numOfSeason.Name = "textBox_numOfSeason";
            this.textBox_numOfSeason.Size = new System.Drawing.Size(37, 21);
            this.textBox_numOfSeason.TabIndex = 5;
            this.textBox_numOfSeason.Click += new System.EventHandler(this.textBox_numOfSeason_Click);
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
            this.label2.Location = new System.Drawing.Point(28, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "赛季描述";
            // 
            // textBox_seasonDescInfo
            // 
            this.textBox_seasonDescInfo.Location = new System.Drawing.Point(116, 108);
            this.textBox_seasonDescInfo.Multiline = true;
            this.textBox_seasonDescInfo.Name = "textBox_seasonDescInfo";
            this.textBox_seasonDescInfo.Size = new System.Drawing.Size(461, 107);
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
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(343, 244);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 38);
            this.button_ok.TabIndex = 1;
            this.button_ok.Text = "确定";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(492, 243);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 38);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(296, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "轮次数";
            // 
            // textBox_NumOfTurn
            // 
            this.textBox_NumOfTurn.Location = new System.Drawing.Point(356, 77);
            this.textBox_NumOfTurn.Name = "textBox_NumOfTurn";
            this.textBox_NumOfTurn.Size = new System.Drawing.Size(37, 21);
            this.textBox_NumOfTurn.TabIndex = 9;
            // 
            // CreateNewSeason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 308);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.groupBox_seasonInfo);
            this.Name = "CreateNewSeason";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox textBox_numOfSeason;
        private System.Windows.Forms.TextBox textBox_MatchName;
        private System.Windows.Forms.Label label_numHelp;
        private System.Windows.Forms.TextBox textBox_NumOfTurn;
        private System.Windows.Forms.Label label5;
    }
}