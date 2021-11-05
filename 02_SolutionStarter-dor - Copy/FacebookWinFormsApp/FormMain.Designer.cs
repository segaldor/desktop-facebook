namespace BasicFacebookFeatures
{
    partial class FormMain
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
            this.buttonLogout = new System.Windows.Forms.Button();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.time = new System.Windows.Forms.TextBox();
            this.ProfileName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBoxPics = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(1060, 28);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(171, 74);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // profilePic
            // 
            this.profilePic.AccessibleDescription = "profilePic";
            this.profilePic.Location = new System.Drawing.Point(46, 85);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(307, 317);
            this.profilePic.TabIndex = 53;
            this.profilePic.TabStop = false;
            // 
            // time
            // 
            this.time.AccessibleName = "time";
            this.time.Location = new System.Drawing.Point(554, 85);
            this.time.Multiline = true;
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(255, 69);
            this.time.TabIndex = 55;
            // 
            // ProfileName
            // 
            this.ProfileName.AccessibleName = "ProfileName";
            this.ProfileName.AutoSize = true;
            this.ProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileName.Location = new System.Drawing.Point(46, 28);
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.Size = new System.Drawing.Size(0, 37);
            this.ProfileName.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 84);
            this.button1.TabIndex = 57;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 578);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 84);
            this.button2.TabIndex = 58;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(53, 695);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(300, 84);
            this.button3.TabIndex = 59;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listBoxPics
            // 
            this.listBoxPics.AccessibleName = "listBoxPics";
            this.listBoxPics.FormattingEnabled = true;
            this.listBoxPics.ItemHeight = 20;
            this.listBoxPics.Location = new System.Drawing.Point(430, 190);
            this.listBoxPics.Name = "listBoxPics";
            this.listBoxPics.Size = new System.Drawing.Size(731, 344);
            this.listBoxPics.TabIndex = 60;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 1011);
            this.Controls.Add(this.listBoxPics);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProfileName);
            this.Controls.Add(this.time);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.buttonLogout);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Label ProfileName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBoxPics;
    }
}

