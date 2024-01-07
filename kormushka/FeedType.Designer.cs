namespace kormushka
{
    partial class FeedType
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
            this.comboBoxFeedT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelU2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxFeedT
            // 
            this.comboBoxFeedT.FormattingEnabled = true;
            this.comboBoxFeedT.Items.AddRange(new object[] {
            "wet",
            "dry"});
            this.comboBoxFeedT.Location = new System.Drawing.Point(84, 159);
            this.comboBoxFeedT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxFeedT.Name = "comboBoxFeedT";
            this.comboBoxFeedT.Size = new System.Drawing.Size(166, 28);
            this.comboBoxFeedT.TabIndex = 30;
            this.comboBoxFeedT.SelectedIndexChanged += new System.EventHandler(this.comboBoxFeedT_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(47, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 39);
            this.label4.TabIndex = 29;
            this.label4.Text = "choose type of feed";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Sienna;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(119, 241);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 50);
            this.button1.TabIndex = 31;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelU2
            // 
            this.labelU2.AutoSize = true;
            this.labelU2.ForeColor = System.Drawing.SystemColors.Info;
            this.labelU2.Location = new System.Drawing.Point(274, 328);
            this.labelU2.Name = "labelU2";
            this.labelU2.Size = new System.Drawing.Size(51, 20);
            this.labelU2.TabIndex = 32;
            this.labelU2.Text = "label1";
            this.labelU2.Click += new System.EventHandler(this.labelU2_Click);
            // 
            // FeedType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(350, 359);
            this.Controls.Add(this.labelU2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxFeedT);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FeedType";
            this.Text = "FeedType";
            this.Load += new System.EventHandler(this.FeedType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFeedT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelU2;
    }
}