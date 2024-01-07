namespace kormushka
{
    partial class PetManagment
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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxP = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonLogAdm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(606, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 33);
            this.button3.TabIndex = 15;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(332, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxP
            // 
            this.listBoxP.FormattingEnabled = true;
            this.listBoxP.ItemHeight = 16;
            this.listBoxP.Location = new System.Drawing.Point(174, 46);
            this.listBoxP.Name = "listBoxP";
            this.listBoxP.Size = new System.Drawing.Size(467, 308);
            this.listBoxP.TabIndex = 14;
            this.listBoxP.SelectedIndexChanged += new System.EventHandler(this.listBoxP_SelectedIndexChanged);
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
            this.button2.Location = new System.Drawing.Point(36, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 37);
            this.button2.TabIndex = 13;
            this.button2.Text = "return";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.buttonLogAdm.Location = new System.Drawing.Point(69, 390);
            this.buttonLogAdm.Name = "buttonLogAdm";
            this.buttonLogAdm.Size = new System.Drawing.Size(158, 33);
            this.buttonLogAdm.TabIndex = 12;
            this.buttonLogAdm.Text = "Add";
            this.buttonLogAdm.UseVisualStyleBackColor = false;
            this.buttonLogAdm.Click += new System.EventHandler(this.buttonLogAdm_Click);
            // 
            // PetManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxP);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonLogAdm);
            this.Name = "PetManagment";
            this.Text = "PetManagment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxP;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonLogAdm;
    }
}