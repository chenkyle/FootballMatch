namespace FootballMatch.Umasou.Business
{
    partial class AlterMatch
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
            this.textBox_serialNum = new System.Windows.Forms.TextBox();
            this.richTextBox_description = new System.Windows.Forms.RichTextBox();
            this.textBox_switchNum = new System.Windows.Forms.TextBox();
            this.groupBox_num = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.groupBox_name = new System.Windows.Forms.GroupBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.groupBox_description = new System.Windows.Forms.GroupBox();
            this.groupBox_num.SuspendLayout();
            this.groupBox_name.SuspendLayout();
            this.groupBox_description.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_serialNum
            // 
            this.textBox_serialNum.Location = new System.Drawing.Point(315, 26);
            this.textBox_serialNum.Name = "textBox_serialNum";
            this.textBox_serialNum.Size = new System.Drawing.Size(53, 26);
            this.textBox_serialNum.TabIndex = 3;
            // 
            // richTextBox_description
            // 
            this.richTextBox_description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_description.Location = new System.Drawing.Point(3, 22);
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.Size = new System.Drawing.Size(371, 97);
            this.richTextBox_description.TabIndex = 0;
            this.richTextBox_description.Text = "";
            // 
            // textBox_switchNum
            // 
            this.textBox_switchNum.Location = new System.Drawing.Point(132, 27);
            this.textBox_switchNum.Name = "textBox_switchNum";
            this.textBox_switchNum.Size = new System.Drawing.Size(50, 26);
            this.textBox_switchNum.TabIndex = 2;
            // 
            // groupBox_num
            // 
            this.groupBox_num.Controls.Add(this.textBox_serialNum);
            this.groupBox_num.Controls.Add(this.textBox_switchNum);
            this.groupBox_num.Controls.Add(this.label2);
            this.groupBox_num.Controls.Add(this.label1);
            this.groupBox_num.Location = new System.Drawing.Point(15, 208);
            this.groupBox_num.Name = "groupBox_num";
            this.groupBox_num.Size = new System.Drawing.Size(374, 74);
            this.groupBox_num.TabIndex = 9;
            this.groupBox_num.TabStop = false;
            this.groupBox_num.Text = "数量设置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "赛事比赛数量";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "黄牌转红牌数量";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(312, 288);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(80, 30);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(226, 288);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(80, 30);
            this.OK.TabIndex = 7;
            this.OK.Text = "确定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // groupBox_name
            // 
            this.groupBox_name.Controls.Add(this.textBox_name);
            this.groupBox_name.Location = new System.Drawing.Point(12, 12);
            this.groupBox_name.Name = "groupBox_name";
            this.groupBox_name.Size = new System.Drawing.Size(380, 62);
            this.groupBox_name.TabIndex = 5;
            this.groupBox_name.TabStop = false;
            this.groupBox_name.Text = "赛事名称";
            // 
            // textBox_name
            // 
            this.textBox_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_name.Location = new System.Drawing.Point(3, 17);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.ReadOnly = true;
            this.textBox_name.Size = new System.Drawing.Size(374, 26);
            this.textBox_name.TabIndex = 0;
            // 
            // groupBox_description
            // 
            this.groupBox_description.Controls.Add(this.richTextBox_description);
            this.groupBox_description.Location = new System.Drawing.Point(12, 80);
            this.groupBox_description.Name = "groupBox_description";
            this.groupBox_description.Size = new System.Drawing.Size(377, 122);
            this.groupBox_description.TabIndex = 6;
            this.groupBox_description.TabStop = false;
            this.groupBox_description.Text = "赛事描述";
            // 
            // AlterMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 331);
            this.Controls.Add(this.groupBox_num);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.groupBox_name);
            this.Controls.Add(this.groupBox_description);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AlterMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改赛事";
            this.Shown += new System.EventHandler(this.AlterMatch_Shown);
            this.groupBox_num.ResumeLayout(false);
            this.groupBox_num.PerformLayout();
            this.groupBox_name.ResumeLayout(false);
            this.groupBox_name.PerformLayout();
            this.groupBox_description.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_serialNum;
        private System.Windows.Forms.RichTextBox richTextBox_description;
        private System.Windows.Forms.TextBox textBox_switchNum;
        private System.Windows.Forms.GroupBox groupBox_num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.GroupBox groupBox_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.GroupBox groupBox_description;
    }
}