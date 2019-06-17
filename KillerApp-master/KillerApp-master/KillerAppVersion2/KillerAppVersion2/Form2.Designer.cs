namespace KillerAppVersion2
{
    partial class Form2
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
            this.BT_SetInfo = new System.Windows.Forms.Button();
            this.BT_SerieInfo = new System.Windows.Forms.Button();
            this.BT_CardInfo = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.BT_AddCard = new System.Windows.Forms.Button();
            this.BT_DeleteCard = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_CollectedCards = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_SetInfo
            // 
            this.BT_SetInfo.Location = new System.Drawing.Point(13, 13);
            this.BT_SetInfo.Name = "BT_SetInfo";
            this.BT_SetInfo.Size = new System.Drawing.Size(75, 23);
            this.BT_SetInfo.TabIndex = 0;
            this.BT_SetInfo.Text = "Set Info";
            this.BT_SetInfo.UseVisualStyleBackColor = true;
            this.BT_SetInfo.Click += new System.EventHandler(this.BT_SetInfo_Click);
            // 
            // BT_SerieInfo
            // 
            this.BT_SerieInfo.Location = new System.Drawing.Point(13, 43);
            this.BT_SerieInfo.Name = "BT_SerieInfo";
            this.BT_SerieInfo.Size = new System.Drawing.Size(75, 23);
            this.BT_SerieInfo.TabIndex = 1;
            this.BT_SerieInfo.Text = "Serie Info";
            this.BT_SerieInfo.UseVisualStyleBackColor = true;
            this.BT_SerieInfo.Click += new System.EventHandler(this.BT_SerieInfo_Click);
            // 
            // BT_CardInfo
            // 
            this.BT_CardInfo.Location = new System.Drawing.Point(13, 73);
            this.BT_CardInfo.Name = "BT_CardInfo";
            this.BT_CardInfo.Size = new System.Drawing.Size(75, 23);
            this.BT_CardInfo.TabIndex = 2;
            this.BT_CardInfo.Text = "Card info";
            this.BT_CardInfo.UseVisualStyleBackColor = true;
            this.BT_CardInfo.Click += new System.EventHandler(this.BT_CardInfo_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(94, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(220, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 4;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(346, 13);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 95);
            this.listBox3.TabIndex = 5;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(472, 12);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(120, 95);
            this.listBox4.TabIndex = 6;
            // 
            // BT_AddCard
            // 
            this.BT_AddCard.Location = new System.Drawing.Point(598, 13);
            this.BT_AddCard.Name = "BT_AddCard";
            this.BT_AddCard.Size = new System.Drawing.Size(75, 94);
            this.BT_AddCard.TabIndex = 7;
            this.BT_AddCard.Text = "Add To Colletion";
            this.BT_AddCard.UseVisualStyleBackColor = true;
            this.BT_AddCard.Click += new System.EventHandler(this.BT_AddCard_Click);
            // 
            // BT_DeleteCard
            // 
            this.BT_DeleteCard.Location = new System.Drawing.Point(679, 14);
            this.BT_DeleteCard.Name = "BT_DeleteCard";
            this.BT_DeleteCard.Size = new System.Drawing.Size(75, 94);
            this.BT_DeleteCard.TabIndex = 8;
            this.BT_DeleteCard.Text = "Delete From Collection";
            this.BT_DeleteCard.UseVisualStyleBackColor = true;
            this.BT_DeleteCard.Click += new System.EventHandler(this.BT_DeleteCard_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Label_CollectedCards);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Label_Username);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(472, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logged In User:";
            // 
            // Label_Username
            // 
            this.Label_Username.AutoSize = true;
            this.Label_Username.Location = new System.Drawing.Point(96, 20);
            this.Label_Username.Name = "Label_Username";
            this.Label_Username.Size = new System.Drawing.Size(89, 13);
            this.Label_Username.TabIndex = 1;
            this.Label_Username.Text = "U S E R N A M E";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Collected Cards:";
            // 
            // Label_CollectedCards
            // 
            this.Label_CollectedCards.AutoSize = true;
            this.Label_CollectedCards.Location = new System.Drawing.Point(96, 75);
            this.Label_CollectedCards.Name = "Label_CollectedCards";
            this.Label_CollectedCards.Size = new System.Drawing.Size(60, 13);
            this.Label_CollectedCards.TabIndex = 3;
            this.Label_CollectedCards.Text = "gagagagay";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BT_DeleteCard);
            this.Controls.Add(this.BT_AddCard);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BT_CardInfo);
            this.Controls.Add(this.BT_SerieInfo);
            this.Controls.Add(this.BT_SetInfo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_SetInfo;
        private System.Windows.Forms.Button BT_SerieInfo;
        private System.Windows.Forms.Button BT_CardInfo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button BT_AddCard;
        private System.Windows.Forms.Button BT_DeleteCard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Label_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_CollectedCards;
        private System.Windows.Forms.Label label2;
    }
}