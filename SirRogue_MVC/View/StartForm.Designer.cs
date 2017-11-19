namespace SirRogue_MVC
{
    partial class StartForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.attackLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hpLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.manaLabel = new System.Windows.Forms.Label();
            this.questBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.attackLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.speedLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.hpLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.manaLabel);
            this.groupBox1.Location = new System.Drawing.Point(37, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Attack";
            // 
            // attackLabel
            // 
            this.attackLabel.AutoSize = true;
            this.attackLabel.Location = new System.Drawing.Point(88, 75);
            this.attackLabel.Name = "attackLabel";
            this.attackLabel.Size = new System.Drawing.Size(63, 13);
            this.attackLabel.TabIndex = 6;
            this.attackLabel.Text = "attackLabel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Speed";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(88, 97);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(62, 13);
            this.speedLabel.TabIndex = 4;
            this.speedLabel.Text = "speedLabel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "HP";
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.Location = new System.Drawing.Point(88, 30);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(45, 13);
            this.hpLabel.TabIndex = 2;
            this.hpLabel.Text = "hpLabel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mana";
            // 
            // manaLabel
            // 
            this.manaLabel.AutoSize = true;
            this.manaLabel.Location = new System.Drawing.Point(88, 52);
            this.manaLabel.Name = "manaLabel";
            this.manaLabel.Size = new System.Drawing.Size(59, 13);
            this.manaLabel.TabIndex = 0;
            this.manaLabel.Text = "manaLabel";
            // 
            // questBtn
            // 
            this.questBtn.Location = new System.Drawing.Point(65, 180);
            this.questBtn.Name = "questBtn";
            this.questBtn.Size = new System.Drawing.Size(107, 62);
            this.questBtn.TabIndex = 1;
            this.questBtn.Text = "Пройти какой-нибудь квест";
            this.questBtn.UseVisualStyleBackColor = true;
            this.questBtn.Click += new System.EventHandler(this.questBtn_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 265);
            this.Controls.Add(this.questBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label manaLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label attackLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Button questBtn;
    }
}

