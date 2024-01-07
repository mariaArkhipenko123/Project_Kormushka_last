namespace kormushka
{
    partial class Pet
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
            this.buttonLogUs = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogUs
            // 
            this.buttonLogUs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogUs.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLogUs.FlatAppearance.BorderSize = 0;
            this.buttonLogUs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonLogUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.buttonLogUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogUs.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogUs.Location = new System.Drawing.Point(288, 396);
            this.buttonLogUs.Name = "buttonLogUs";
            this.buttonLogUs.Size = new System.Drawing.Size(158, 33);
            this.buttonLogUs.TabIndex = 20;
            this.buttonLogUs.Text = "Enter";
            this.buttonLogUs.UseVisualStyleBackColor = false;
            this.buttonLogUs.Click += new System.EventHandler(this.buttonLogUs_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(309, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(333, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Login";
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(197, 333);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(341, 22);
            this.passwordField.TabIndex = 17;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // loginField
            // 
            this.loginField.Location = new System.Drawing.Point(197, 237);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(341, 43);
            this.loginField.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 37);
            this.button2.TabIndex = 14;
            this.button2.Text = "return";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kormushka.Properties.Resources.cat;
            this.pictureBox1.Location = new System.Drawing.Point(276, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Pet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLogUs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Name = "Pet";
            this.Text = "Pet";
            this.Load += new System.EventHandler(this.Pet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogUs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}