namespace kormushka
{
    partial class Admin
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
            this.loginField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLogAdm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginField
            // 
            this.loginField.Location = new System.Drawing.Point(220, 224);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(341, 43);
            this.loginField.TabIndex = 1;
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(220, 320);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(341, 22);
            this.passwordField.TabIndex = 2;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(356, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(332, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // buttonLogAdm
            // 
            this.buttonLogAdm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogAdm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogAdm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLogAdm.FlatAppearance.BorderSize = 0;
            this.buttonLogAdm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonLogAdm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.buttonLogAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogAdm.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogAdm.Location = new System.Drawing.Point(312, 405);
            this.buttonLogAdm.Name = "buttonLogAdm";
            this.buttonLogAdm.Size = new System.Drawing.Size(158, 33);
            this.buttonLogAdm.TabIndex = 5;
            this.buttonLogAdm.Text = "Enter";
            this.buttonLogAdm.UseVisualStyleBackColor = false;
            this.buttonLogAdm.Click += new System.EventHandler(this.buttonLogAdm_Click);
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
            this.button2.Location = new System.Drawing.Point(13, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "return";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kormushka.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(300, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(776, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonLogAdm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLogAdm;
        private System.Windows.Forms.Button button2;
    }
}