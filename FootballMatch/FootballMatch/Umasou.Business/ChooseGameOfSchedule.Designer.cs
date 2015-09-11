namespace FootballMatch.Umasou.Business
{
    partial class ChooseGameOfSchedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_schedule = new System.Windows.Forms.DataGridView();
            this.label_MatchName = new System.Windows.Forms.Label();
            this.label_seasonNum = new System.Windows.Forms.Label();
            this.label_turn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_guestTeam = new System.Windows.Forms.TextBox();
            this.textBox_homeTeam = new System.Windows.Forms.TextBox();
            this.label_gameDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_choose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.homeTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfTurn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seasonNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_schedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.button_choose);
            this.splitContainer1.Panel2.Controls.Add(this.button_cancel);
            this.splitContainer1.Size = new System.Drawing.Size(599, 329);
            this.splitContainer1.SplitterDistance = 257;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView_schedule);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Green;
            this.splitContainer2.Panel2.Controls.Add(this.label8);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer2.Panel2.Controls.Add(this.label_gameDate);
            this.splitContainer2.Panel2.Controls.Add(this.textBox_homeTeam);
            this.splitContainer2.Panel2.Controls.Add(this.textBox_guestTeam);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.label_turn);
            this.splitContainer2.Panel2.Controls.Add(this.label_seasonNum);
            this.splitContainer2.Panel2.Controls.Add(this.label_MatchName);
            this.splitContainer2.Size = new System.Drawing.Size(599, 257);
            this.splitContainer2.SplitterDistance = 204;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridView_schedule
            // 
            this.dataGridView_schedule.AllowUserToAddRows = false;
            this.dataGridView_schedule.AllowUserToDeleteRows = false;
            this.dataGridView_schedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_schedule.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_schedule.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_schedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridView_schedule.ColumnHeadersHeight = 25;
            this.dataGridView_schedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.homeTeam,
            this.guestTeam,
            this.numOfTurn,
            this.gameDate,
            this.seasonNum,
            this.matchName});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_schedule.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridView_schedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_schedule.EnableHeadersVisualStyles = false;
            this.dataGridView_schedule.GridColor = System.Drawing.Color.White;
            this.dataGridView_schedule.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_schedule.Name = "dataGridView_schedule";
            this.dataGridView_schedule.RowTemplate.Height = 23;
            this.dataGridView_schedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_schedule.Size = new System.Drawing.Size(204, 257);
            this.dataGridView_schedule.TabIndex = 0;
            this.dataGridView_schedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_schedule_CellClick);
            this.dataGridView_schedule.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_schedule_RowPostPaint);
            // 
            // label_MatchName
            // 
            this.label_MatchName.AutoSize = true;
            this.label_MatchName.Location = new System.Drawing.Point(147, 12);
            this.label_MatchName.Name = "label_MatchName";
            this.label_MatchName.Size = new System.Drawing.Size(29, 12);
            this.label_MatchName.TabIndex = 0;
            this.label_MatchName.Text = "赛事";
            // 
            // label_seasonNum
            // 
            this.label_seasonNum.AutoSize = true;
            this.label_seasonNum.Location = new System.Drawing.Point(32, 33);
            this.label_seasonNum.Name = "label_seasonNum";
            this.label_seasonNum.Size = new System.Drawing.Size(0, 12);
            this.label_seasonNum.TabIndex = 1;
            // 
            // label_turn
            // 
            this.label_turn.AutoSize = true;
            this.label_turn.Location = new System.Drawing.Point(338, 33);
            this.label_turn.Name = "label_turn";
            this.label_turn.Size = new System.Drawing.Size(0, 12);
            this.label_turn.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "VS";
            // 
            // textBox_guestTeam
            // 
            this.textBox_guestTeam.Location = new System.Drawing.Point(236, 79);
            this.textBox_guestTeam.Name = "textBox_guestTeam";
            this.textBox_guestTeam.ReadOnly = true;
            this.textBox_guestTeam.Size = new System.Drawing.Size(134, 21);
            this.textBox_guestTeam.TabIndex = 3;
            this.textBox_guestTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_homeTeam
            // 
            this.textBox_homeTeam.Location = new System.Drawing.Point(15, 79);
            this.textBox_homeTeam.Name = "textBox_homeTeam";
            this.textBox_homeTeam.ReadOnly = true;
            this.textBox_homeTeam.Size = new System.Drawing.Size(132, 21);
            this.textBox_homeTeam.TabIndex = 3;
            this.textBox_homeTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_gameDate
            // 
            this.label_gameDate.AutoSize = true;
            this.label_gameDate.Location = new System.Drawing.Point(153, 221);
            this.label_gameDate.Name = "label_gameDate";
            this.label_gameDate.Size = new System.Drawing.Size(0, 12);
            this.label_gameDate.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::FootballMatch.Properties.Resources.足球场;
            this.pictureBox1.Location = new System.Drawing.Point(30, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FootballMatch.Properties.Resources.足球场2;
            this.pictureBox2.Location = new System.Drawing.Point(261, 119);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(487, 33);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 0;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_choose
            // 
            this.button_choose.Location = new System.Drawing.Point(386, 33);
            this.button_choose.Name = "button_choose";
            this.button_choose.Size = new System.Drawing.Size(75, 23);
            this.button_choose.TabIndex = 0;
            this.button_choose.Text = "选择";
            this.button_choose.UseVisualStyleBackColor = true;
            this.button_choose.Click += new System.EventHandler(this.button_choose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "主队";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "客队";
            // 
            // homeTeam
            // 
            this.homeTeam.HeaderText = "主队";
            this.homeTeam.Name = "homeTeam";
            this.homeTeam.Width = 54;
            // 
            // guestTeam
            // 
            this.guestTeam.HeaderText = "客队";
            this.guestTeam.Name = "guestTeam";
            this.guestTeam.Width = 54;
            // 
            // numOfTurn
            // 
            this.numOfTurn.HeaderText = "轮次";
            this.numOfTurn.Name = "numOfTurn";
            this.numOfTurn.Width = 54;
            // 
            // gameDate
            // 
            this.gameDate.HeaderText = "比赛日期";
            this.gameDate.Name = "gameDate";
            this.gameDate.Width = 78;
            // 
            // seasonNum
            // 
            this.seasonNum.HeaderText = "赛季";
            this.seasonNum.Name = "seasonNum";
            this.seasonNum.Width = 54;
            // 
            // matchName
            // 
            this.matchName.HeaderText = "赛事名称";
            this.matchName.Name = "matchName";
            this.matchName.Width = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "第";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "季";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "第";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "轮";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "比赛日期";
            // 
            // ChooseGameOfSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 329);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ChooseGameOfSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择赛程中的比赛";
            this.Load += new System.EventHandler(this.ChooseGameOfSchedule_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_schedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView_schedule;
        private System.Windows.Forms.TextBox textBox_homeTeam;
        private System.Windows.Forms.TextBox textBox_guestTeam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_turn;
        private System.Windows.Forms.Label label_seasonNum;
        private System.Windows.Forms.Label label_MatchName;
        private System.Windows.Forms.Label label_gameDate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_choose;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfTurn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn seasonNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
    }
}