namespace SirRogue_MVC
{
    partial class QuestForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hpBox = new System.Windows.Forms.TextBox();
            this.manaBox = new System.Windows.Forms.TextBox();
            this.attackBox = new System.Windows.Forms.TextBox();
            this.speedBox = new System.Windows.Forms.TextBox();
            this.doneBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Примитивный квест.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "В результате прохождения изменится Stats.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.speedBox);
            this.groupBox1.Controls.Add(this.attackBox);
            this.groupBox1.Controls.Add(this.manaBox);
            this.groupBox1.Controls.Add(this.hpBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(18, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 126);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats изменится на:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Attack";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Speed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "HP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mana";
            // 
            // hpBox
            // 
            this.hpBox.Location = new System.Drawing.Point(78, 25);
            this.hpBox.Name = "hpBox";
            this.hpBox.Size = new System.Drawing.Size(100, 20);
            this.hpBox.TabIndex = 16;
            this.hpBox.Text = "1";
            // 
            // manaBox
            // 
            this.manaBox.Location = new System.Drawing.Point(78, 47);
            this.manaBox.Name = "manaBox";
            this.manaBox.Size = new System.Drawing.Size(100, 20);
            this.manaBox.TabIndex = 17;
            this.manaBox.Text = "2";
            // 
            // attackBox
            // 
            this.attackBox.Location = new System.Drawing.Point(78, 70);
            this.attackBox.Name = "attackBox";
            this.attackBox.Size = new System.Drawing.Size(100, 20);
            this.attackBox.TabIndex = 18;
            this.attackBox.Text = "3";
            // 
            // speedBox
            // 
            this.speedBox.Location = new System.Drawing.Point(78, 92);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(100, 20);
            this.speedBox.TabIndex = 19;
            this.speedBox.Text = "4";
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(96, 208);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(84, 34);
            this.doneBtn.TabIndex = 3;
            this.doneBtn.Text = "Выполнено";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // QuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 270);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuestForm";
            this.Text = "QuestForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox speedBox;
        private System.Windows.Forms.TextBox attackBox;
        private System.Windows.Forms.TextBox manaBox;
        private System.Windows.Forms.TextBox hpBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button doneBtn;
    }
}