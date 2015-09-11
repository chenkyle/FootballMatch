namespace FootballMatch.Umasou.Business
{
    partial class CreateNewPlayer
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
            this.comboBox_teamName = new System.Windows.Forms.ComboBox();
            this.textBox_IDnum = new System.Windows.Forms.TextBox();
            this.textBox_teamManager = new System.Windows.Forms.TextBox();
            this.textBox_teamLeader = new System.Windows.Forms.TextBox();
            this.textBox_teamName = new System.Windows.Forms.TextBox();
            this.label_IDnum = new System.Windows.Forms.Label();
            this.label_teamCoach = new System.Windows.Forms.Label();
            this.label_teamManager = new System.Windows.Forms.Label();
            this.label_teamLeader = new System.Windows.Forms.Label();
            this.label_teamName = new System.Windows.Forms.Label();
            this.groupBox_team.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(294, 285);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(80, 30);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(208, 285);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(80, 30);
            this.OK.TabIndex = 4;
            this.OK.Text = "确定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // groupBox_team
            // 
            this.groupBox_team.BackColor = System.Drawing.Color.White;
            this.groupBox_team.Controls.Add(this.comboBox_teamName);
            this.groupBox_team.Controls.Add(this.textBox_IDnum);
            this.groupBox_team.Controls.Add(this.textBox_teamManager);
            this.groupBox_team.Controls.Add(this.textBox_teamLeader);
            this.groupBox_team.Controls.Add(this.textBox_teamName);
            this.groupBox_team.Controls.Add(this.label_IDnum);
            this.groupBox_team.Controls.Add(this.label_teamCoach);
            this.groupBox_team.Controls.Add(this.label_teamManager);
            this.groupBox_team.Controls.Add(this.label_teamLeader);
            this.groupBox_team.Controls.Add(this.label_teamName);
            this.groupBox_team.Location = new System.Drawing.Point(12, 12);
            this.groupBox_team.Name = "groupBox_team";
            this.groupBox_team.Size = new System.Drawing.Size(363, 267);
            this.groupBox_team.TabIndex = 9;
            this.groupBox_team.TabStop = false;
            // 
            // comboBox_teamName
            // 
            this.comboBox_teamName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_teamName.FormattingEnabled = true;
            this.comboBox_teamName.Location = new System.Drawing.Point(126, 177);
            this.comboBox_teamName.Name = "comboBox_teamName";
            this.comboBox_teamName.Size = new System.Drawing.Size(192, 24);
            this.comboBox_teamName.TabIndex = 7;
            // 
            // textBox_IDnum
            // 
            this.textBox_IDnum.Location = new System.Drawing.Point(126, 221);
            this.textBox_IDnum.Name = "textBox_IDnum";
            this.textBox_IDnum.Size = new System.Drawing.Size(192, 26);
            this.textBox_IDnum.TabIndex = 6;
            // 
            // textBox_teamManager
            // 
            this.textBox_teamManager.Location = new System.Drawing.Point(126, 126);
            this.textBox_teamManager.Name = "textBox_teamManager";
            this.textBox_teamManager.Size = new System.Drawing.Size(192, 26);
            this.textBox_teamManager.TabIndex = 6;
            // 
            // textBox_teamLeader
            // 
            this.textBox_teamLeader.Location = new System.Drawing.Point(126, 74);
            this.textBox_teamLeader.Name = "textBox_teamLeader";
            this.textBox_teamLeader.Size = new System.Drawing.Size(192, 26);
            this.textBox_teamLeader.TabIndex = 5;
            // 
            // textBox_teamName
            // 
            this.textBox_teamName.Location = new System.Drawing.Point(126, 22);
            this.textBox_teamName.Name = "textBox_teamName";
            this.textBox_teamName.Size = new System.Drawing.Size(192, 26);
            this.textBox_teamName.TabIndex = 4;
            // 
            // label_IDnum
            // 
            this.label_IDnum.AutoSize = true;
            this.label_IDnum.Location = new System.Drawing.Point(38, 224);
            this.label_IDnum.Name = "label_IDnum";
            this.label_IDnum.Size = new System.Drawing.Size(72, 16);
            this.label_IDnum.TabIndex = 2;
            this.label_IDnum.Text = "身份证号";
            // 
            // label_teamCoach
            // 
            this.label_teamCoach.AutoSize = true;
            this.label_teamCoach.Location = new System.Drawing.Point(38, 180);
            this.label_teamCoach.Name = "label_teamCoach";
            this.label_teamCoach.Size = new System.Drawing.Size(72, 16);
            this.label_teamCoach.TabIndex = 3;
            this.label_teamCoach.Text = "球员球队";
            // 
            // label_teamManager
            // 
            this.label_teamManager.AutoSize = true;
            this.label_teamManager.Location = new System.Drawing.Point(38, 129);
            this.label_teamManager.Name = "label_teamManager";
            this.label_teamManager.Size = new System.Drawing.Size(72, 16);
            this.label_teamManager.TabIndex = 2;
            this.label_teamManager.Text = "球员位置";
            // 
            // label_teamLeader
            // 
            this.label_teamLeader.AutoSize = true;
            this.label_teamLeader.Location = new System.Drawing.Point(38, 77);
            this.label_teamLeader.Name = "label_teamLeader";
            this.label_teamLeader.Size = new System.Drawing.Size(72, 16);
            this.label_teamLeader.TabIndex = 1;
            this.label_teamLeader.Text = "球员号码";
            // 
            // label_teamName
            // 
            this.label_teamName.AutoSize = true;
            this.label_teamName.Location = new System.Drawing.Point(38, 25);
            this.label_teamName.Name = "label_teamName";
            this.label_teamName.Size = new System.Drawing.Size(72, 16);
            this.label_teamName.TabIndex = 0;
            this.label_teamName.Text = "球员姓名";
            // 
            // CreateNewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(392, 320);
            this.Controls.Add(this.groupBox_team);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CreateNewPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新建球员";
            this.Load += new System.EventHandler(this.CreateNewPlayer_Load);
            this.groupBox_team.ResumeLayout(false);
            this.groupBox_team.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.GroupBox groupBox_team;
        private System.Windows.Forms.TextBox textBox_teamManager;
        private System.Windows.Forms.TextBox textBox_teamLeader;
        private System.Windows.Forms.TextBox textBox_teamName;
        private System.Windows.Forms.Label label_teamCoach;
        private System.Windows.Forms.Label label_teamManager;
        private System.Windows.Forms.Label label_teamLeader;
        private System.Windows.Forms.Label label_teamName;
        private System.Windows.Forms.ComboBox comboBox_teamName;
        private System.Windows.Forms.TextBox textBox_IDnum;
        private System.Windows.Forms.Label label_IDnum;
    }
}