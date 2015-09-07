namespace FootballMatch.Umasou.Business
{
    partial class addPlayerCardRecordcs
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
            this.OK = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.groupBox_playerCardRecord = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_addCardRecord = new System.Windows.Forms.DateTimePicker();
            this.textBox_matchSerial = new System.Windows.Forms.TextBox();
            this.textBox_playerName = new System.Windows.Forms.TextBox();
            this.textBox_yellowCardNum = new System.Windows.Forms.TextBox();
            this.textBox_redCardNum = new System.Windows.Forms.TextBox();
            this.textBox_matchName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_playerCardRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(337, 204);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(80, 30);
            this.OK.TabIndex = 0;
            this.OK.Text = "确定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(423, 204);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(80, 30);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // groupBox_playerCardRecord
            // 
            this.groupBox_playerCardRecord.Controls.Add(this.dateTimePicker_addCardRecord);
            this.groupBox_playerCardRecord.Controls.Add(this.textBox_matchSerial);
            this.groupBox_playerCardRecord.Controls.Add(this.textBox_playerName);
            this.groupBox_playerCardRecord.Controls.Add(this.textBox_yellowCardNum);
            this.groupBox_playerCardRecord.Controls.Add(this.textBox_redCardNum);
            this.groupBox_playerCardRecord.Controls.Add(this.textBox_matchName);
            this.groupBox_playerCardRecord.Controls.Add(this.label6);
            this.groupBox_playerCardRecord.Controls.Add(this.label5);
            this.groupBox_playerCardRecord.Controls.Add(this.label4);
            this.groupBox_playerCardRecord.Controls.Add(this.label3);
            this.groupBox_playerCardRecord.Controls.Add(this.label2);
            this.groupBox_playerCardRecord.Controls.Add(this.label1);
            this.groupBox_playerCardRecord.Location = new System.Drawing.Point(12, 12);
            this.groupBox_playerCardRecord.Name = "groupBox_playerCardRecord";
            this.groupBox_playerCardRecord.Size = new System.Drawing.Size(491, 186);
            this.groupBox_playerCardRecord.TabIndex = 2;
            this.groupBox_playerCardRecord.TabStop = false;
            this.groupBox_playerCardRecord.Text = "罚牌记录";
            // 
            // dateTimePicker_addCardRecord
            // 
            this.dateTimePicker_addCardRecord.Location = new System.Drawing.Point(318, 82);
            this.dateTimePicker_addCardRecord.Name = "dateTimePicker_addCardRecord";
            this.dateTimePicker_addCardRecord.Size = new System.Drawing.Size(154, 26);
            this.dateTimePicker_addCardRecord.TabIndex = 9;
            // 
            // textBox_matchSerial
            // 
            this.textBox_matchSerial.Location = new System.Drawing.Point(318, 36);
            this.textBox_matchSerial.Name = "textBox_matchSerial";
            this.textBox_matchSerial.ReadOnly = true;
            this.textBox_matchSerial.Size = new System.Drawing.Size(154, 26);
            this.textBox_matchSerial.TabIndex = 4;
            this.textBox_matchSerial.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox_matchSerial_MouseDoubleClick);
            // 
            // textBox_playerName
            // 
            this.textBox_playerName.Location = new System.Drawing.Point(105, 86);
            this.textBox_playerName.Name = "textBox_playerName";
            this.textBox_playerName.ReadOnly = true;
            this.textBox_playerName.Size = new System.Drawing.Size(129, 26);
            this.textBox_playerName.TabIndex = 5;
            this.textBox_playerName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox_playerName_MouseDoubleClick);
            // 
            // textBox_yellowCardNum
            // 
            this.textBox_yellowCardNum.Location = new System.Drawing.Point(105, 139);
            this.textBox_yellowCardNum.Name = "textBox_yellowCardNum";
            this.textBox_yellowCardNum.Size = new System.Drawing.Size(129, 26);
            this.textBox_yellowCardNum.TabIndex = 7;
            // 
            // textBox_redCardNum
            // 
            this.textBox_redCardNum.Location = new System.Drawing.Point(318, 139);
            this.textBox_redCardNum.Name = "textBox_redCardNum";
            this.textBox_redCardNum.Size = new System.Drawing.Size(154, 26);
            this.textBox_redCardNum.TabIndex = 8;
            // 
            // textBox_matchName
            // 
            this.textBox_matchName.Location = new System.Drawing.Point(105, 36);
            this.textBox_matchName.Name = "textBox_matchName";
            this.textBox_matchName.ReadOnly = true;
            this.textBox_matchName.Size = new System.Drawing.Size(129, 26);
            this.textBox_matchName.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "球员姓名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "罚牌日期";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "比赛序号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "红牌数量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "黄牌数量";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "赛事名称";
            // 
            // addPlayerCardRecordcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 246);
            this.Controls.Add(this.groupBox_playerCardRecord);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.OK);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "addPlayerCardRecordcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加球员罚牌记录";
            this.Shown += new System.EventHandler(this.addPlayerCardRecordcs_Shown);
            this.groupBox_playerCardRecord.ResumeLayout(false);
            this.groupBox_playerCardRecord.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.GroupBox groupBox_playerCardRecord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_matchName;
        private System.Windows.Forms.TextBox textBox_matchSerial;
        private System.Windows.Forms.TextBox textBox_playerName;
        private System.Windows.Forms.TextBox textBox_yellowCardNum;
        private System.Windows.Forms.TextBox textBox_redCardNum;
        private System.Windows.Forms.DateTimePicker dateTimePicker_addCardRecord;
    }
}