namespace kormushka
{
    partial class AddFeed
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
            this.button2 = new System.Windows.Forms.Button();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameFeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.condition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.feedtype = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "return";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistration.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonRegistration.FlatAppearance.BorderSize = 0;
            this.buttonRegistration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonRegistration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.buttonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistration.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegistration.Location = new System.Drawing.Point(311, 400);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(158, 33);
            this.buttonRegistration.TabIndex = 27;
            this.buttonRegistration.Text = "Add a feed";
            this.buttonRegistration.UseVisualStyleBackColor = false;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(555, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 31);
            this.label4.TabIndex = 26;
            this.label4.Text = "Feed type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(160, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 31);
            this.label3.TabIndex = 24;
            this.label3.Text = "Name";
            // 
            // nameFeed
            // 
            this.nameFeed.Location = new System.Drawing.Point(24, 199);
            this.nameFeed.Multiline = true;
            this.nameFeed.Name = "nameFeed";
            this.nameFeed.Size = new System.Drawing.Size(341, 24);
            this.nameFeed.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(555, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 31);
            this.label2.TabIndex = 22;
            this.label2.Text = "Condition";
            // 
            // condition
            // 
            this.condition.Location = new System.Drawing.Point(431, 315);
            this.condition.Multiline = true;
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(341, 28);
            this.condition.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(160, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Login";
            // 
            // loginField
            // 
            this.loginField.Location = new System.Drawing.Point(24, 315);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(341, 28);
            this.loginField.TabIndex = 19;
            // 
            // feedtype
            // 
            this.feedtype.FormattingEnabled = true;
            this.feedtype.Items.AddRange(new object[] {
            "wet",
            "dry"});
            this.feedtype.Location = new System.Drawing.Point(431, 199);
            this.feedtype.Name = "feedtype";
            this.feedtype.Size = new System.Drawing.Size(341, 24);
            this.feedtype.TabIndex = 28;
            this.feedtype.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AddFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.feedtype);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameFeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.condition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.button2);
            this.Name = "AddFeed";
            this.Text = "AddFeed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameFeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox condition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.ComboBox feedtype;
    }
}