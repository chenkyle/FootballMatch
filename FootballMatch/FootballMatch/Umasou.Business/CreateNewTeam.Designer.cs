namespace FootballMatch.Umasou.Business
{
    partial class CreateNewTeam
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
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.groupBox_team = new System.Windows.Forms.GroupBox();
            this.textBox_matchNameOfTeam = new System.Windows.Forms.TextBox();
            this.textBox_location = new System.Windows.Forms.TextBox();
            this.label_location = new System.Windows.Forms.Label();
            this.dateTimePicker_birthDate = new System.Windows.Forms.DateTimePicker();
            this.textBox_teamCoach = new System.Windows.Forms.TextBox();
            this.textBox_teamManager = new System.Windows.Forms.TextBox();
            this.textBox_introduction = new System.Windows.Forms.TextBox();
            this.textBox_teamLeader = new System.Windows.Forms.TextBox();
            this.textBox_teamFullName = new System.Windows.Forms.TextBox();
            this.textBox_teamName = new System.Windows.Forms.TextBox();
            this.label_teamCoach = new System.Windows.Forms.Label();
            this.label_teamDesc = new System.Windows.Forms.Label();
            this.label_teamManager = new System.Windows.Forms.Label();
            this.label_teamLeader = new System.Windows.Forms.Label();
            this.label_fullName = new System.Windows.Forms.Label();
            this.label_matchNameOfTeam = new System.Windows.Forms.Label();
            this.label_birthDate = new System.Windows.Forms.Label();
            this.label_teamName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox_team.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(555, 403);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(80, 30);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(381, 403);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(80, 30);
            this.OK.TabIndex = 6;
            this.OK.Text = "确定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // groupBox_team
            // 
            this.groupBox_team.Controls.Add(this.textBox_matchNameOfTeam);
            this.groupBox_team.Controls.Add(this.textBox_location);
            this.groupBox_team.Controls.Add(this.label_location);
            this.groupBox_team.Controls.Add(this.dateTimePicker_birthDate);
            this.groupBox_team.Controls.Add(this.textBox_teamCoach);
            this.groupBox_team.Controls.Add(this.textBox_teamManager);
            this.groupBox_team.Controls.Add(this.textBox_introduction);
            this.groupBox_team.Controls.Add(this.textBox_teamLeader);
            this.groupBox_team.Controls.Add(this.textBox_teamFullName);
            this.groupBox_team.Controls.Add(this.textBox_teamName);
            this.groupBox_team.Controls.Add(this.label_teamCoach);
            this.groupBox_team.Controls.Add(this.label_teamDesc);
            this.groupBox_team.Controls.Add(this.label_teamManager);
            this.groupBox_team.Controls.Add(this.label_teamLeader);
            this.groupBox_team.Controls.Add(this.label_fullName);
            this.groupBox_team.Controls.Add(this.label_matchNameOfTeam);
            this.groupBox_team.Controls.Add(this.label_birthDate);
            this.groupBox_team.Controls.Add(this.label_teamName);
            this.groupBox_team.Location = new System.Drawing.Point(12, 12);
            this.groupBox_team.Name = "groupBox_team";
            this.groupBox_team.Size = new System.Drawing.Size(666, 361);
            this.groupBox_team.TabIndex = 8;
            this.groupBox_team.TabStop = false;
            // 
            // textBox_matchNameOfTeam
            // 
            this.textBox_matchNameOfTeam.Location = new System.Drawing.Point(98, 26);
            this.textBox_matchNameOfTeam.Name = "textBox_matchNameOfTeam";
            this.textBox_matchNameOfTeam.ReadOnly = true;
            this.textBox_matchNameOfTeam.Size = new System.Drawing.Size(199, 26);
            this.textBox_matchNameOfTeam.TabIndex = 12;
            // 
            // textBox_location
            // 
            this.textBox_location.Location = new System.Drawing.Point(96, 163);
            this.textBox_location.Name = "textBox_location";
            this.textBox_location.Size = new System.Drawing.Size(201, 26);
            this.textBox_location.TabIndex = 11;
            // 
            // label_location
            // 
            this.label_location.AutoSize = true;
            this.label_location.Location = new System.Drawing.Point(12, 166);
            this.label_location.Name = "label_location";
            this.label_location.Size = new System.Drawing.Size(88, 16);
            this.label_location.TabIndex = 10;
            this.label_location.Text = "球队所在地";
            // 
            // dateTimePicker_birthDate
            // 
            this.dateTimePicker_birthDate.Location = new System.Drawing.Point(98, 116);
            this.dateTimePicker_birthDate.Name = "dateTimePicker_birthDate";
            this.dateTimePicker_birthDate.Size = new System.Drawing.Size(199, 26);
            this.dateTimePicker_birthDate.TabIndex = 9;
            // 
            // textBox_teamCoach
            // 
            this.textBox_teamCoach.Location = new System.Drawing.Point(415, 161);
            this.textBox_teamCoach.Name = "textBox_teamCoach";
            this.textBox_teamCoach.Size = new System.Drawing.Size(233, 26);
            this.textBox_teamCoach.TabIndex = 7;
            // 
            // textBox_teamManager
            // 
            this.textBox_teamManager.Location = new System.Drawing.Point(415, 115);
            this.textBox_teamManager.Name = "textBox_teamManager";
            this.textBox_teamManager.Size = new System.Drawing.Size(233, 26);
            this.textBox_teamManager.TabIndex = 6;
            // 
            // textBox_introduction
            // 
            this.textBox_introduction.Location = new System.Drawing.Point(96, 249);
            this.textBox_introduction.Multiline = true;
            this.textBox_introduction.Name = "textBox_introduction";
            this.textBox_introduction.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_introduction.Size = new System.Drawing.Size(552, 94);
            this.textBox_introduction.TabIndex = 5;
            // 
            // textBox_teamLeader
            // 
            this.textBox_teamLeader.Location = new System.Drawing.Point(96, 205);
            this.textBox_teamLeader.Name = "textBox_teamLeader";
            this.textBox_teamLeader.Size = new System.Drawing.Size(201, 26);
            this.textBox_teamLeader.TabIndex = 5;
            // 
            // textBox_teamFullName
            // 
            this.textBox_teamFullName.Location = new System.Drawing.Point(414, 71);
            this.textBox_teamFullName.Name = "textBox_teamFullName";
            this.textBox_teamFullName.Size = new System.Drawing.Size(234, 26);
            this.textBox_teamFullName.TabIndex = 4;
            // 
            // textBox_teamName
            // 
            this.textBox_teamName.Location = new System.Drawing.Point(96, 71);
            this.textBox_teamName.Name = "textBox_teamName";
            this.textBox_teamName.Size = new System.Drawing.Size(201, 26);
            this.textBox_teamName.TabIndex = 4;
            // 
            // label_teamCoach
            // 
            this.label_teamCoach.AutoSize = true;
            this.label_teamCoach.Location = new System.Drawing.Point(327, 165);
            this.label_teamCoach.Name = "label_teamCoach";
            this.label_teamCoach.Size = new System.Drawing.Size(72, 16);
            this.label_teamCoach.TabIndex = 3;
            this.label_teamCoach.Text = "球队教练";
            // 
            // label_teamDesc
            // 
            this.label_teamDesc.AutoSize = true;
            this.label_teamDesc.Location = new System.Drawing.Point(19, 253);
            this.label_teamDesc.Name = "label_teamDesc";
            this.label_teamDesc.Size = new System.Drawing.Size(72, 16);
            this.label_teamDesc.TabIndex = 1;
            this.label_teamDesc.Text = "球队简介";
            // 
            // label_teamManager
            // 
            this.label_teamManager.AutoSize = true;
            this.label_teamManager.Location = new System.Drawing.Point(327, 118);
            this.label_teamManager.Name = "label_teamManager";
            this.label_teamManager.Size = new System.Drawing.Size(72, 16);
            this.label_teamManager.TabIndex = 2;
            this.label_teamManager.Text = "球队经理";
            // 
            // label_teamLeader
            // 
            this.label_teamLeader.AutoSize = true;
            this.label_teamLeader.Location = new System.Drawing.Point(19, 209);
            this.label_teamLeader.Name = "label_teamLeader";
            this.label_teamLeader.Size = new System.Drawing.Size(72, 16);
            this.label_teamLeader.TabIndex = 1;
            this.label_teamLeader.Text = "球队队长";
            // 
            // label_fullName
            // 
            this.label_fullName.AutoSize = true;
            this.label_fullName.Location = new System.Drawing.Point(327, 76);
            this.label_fullName.Name = "label_fullName";
            this.label_fullName.Size = new System.Drawing.Size(72, 16);
            this.label_fullName.TabIndex = 0;
            this.label_fullName.Text = "球队全称";
            // 
            // label_matchNameOfTeam
            // 
            this.label_matchNameOfTeam.AutoSize = true;
            this.label_matchNameOfTeam.Location = new System.Drawing.Point(17, 25);
            this.label_matchNameOfTeam.Name = "label_matchNameOfTeam";
            this.label_matchNameOfTeam.Size = new System.Drawing.Size(72, 16);
            this.label_matchNameOfTeam.TabIndex = 0;
            this.label_matchNameOfTeam.Text = "联赛名称";
            // 
            // label_birthDate
            // 
            this.label_birthDate.AutoSize = true;
            this.label_birthDate.Location = new System.Drawing.Point(18, 122);
            this.label_birthDate.Name = "label_birthDate";
            this.label_birthDate.Size = new System.Drawing.Size(72, 16);
            this.label_birthDate.TabIndex = 0;
            this.label_birthDate.Text = "建队日期";
            // 
            // label_teamName
            // 
            this.label_teamName.AutoSize = true;
            this.label_teamName.Location = new System.Drawing.Point(17, 74);
            this.label_teamName.Name = "label_teamName";
            this.label_teamName.Size = new System.Drawing.Size(72, 16);
            this.label_teamName.TabIndex = 0;
            this.label_teamName.Text = "球队名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "太慢？请批量";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(142, 414);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 16);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "批量导入";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // CreateNewTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 462);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_team);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CreateNewTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新建球队";
            this.Load += new System.EventHandler(this.CreateNewTeam_Load);
            this.groupBox_team.ResumeLayout(false);
            this.groupBox_team.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.GroupBox groupBox_team;
        private System.Windows.Forms.Label label_teamCoach;
        private System.Windows.Forms.Label label_teamManager;
        private System.Windows.Forms.Label label_teamLeader;
        private System.Windows.Forms.Label label_teamName;
        private System.Windows.Forms.TextBox textBox_teamCoach;
        private System.Windows.Forms.TextBox textBox_teamManager;
        private System.Windows.Forms.TextBox textBox_teamLeader;
        private System.Windows.Forms.TextBox textBox_teamName;
        private System.Windows.Forms.Label label_matchNameOfTeam;
        private System.Windows.Forms.TextBox textBox_location;
        private System.Windows.Forms.Label label_location;
        private System.Windows.Forms.DateTimePicker dateTimePicker_birthDate;
        private System.Windows.Forms.TextBox textBox_teamFullName;
        private System.Windows.Forms.Label label_fullName;
        private System.Windows.Forms.Label label_birthDate;
        private System.Windows.Forms.TextBox textBox_introduction;
        private System.Windows.Forms.Label label_teamDesc;
        private System.Windows.Forms.TextBox textBox_matchNameOfTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}