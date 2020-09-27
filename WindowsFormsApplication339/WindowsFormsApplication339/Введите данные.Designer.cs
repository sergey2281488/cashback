namespace WindowsFormsApplication339
{
    partial class Form1
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
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btEnter = new System.Windows.Forms.Button();
            this.cbSignup = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(100, 58);
            this.tbUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(187, 22);
            this.tbUser.TabIndex = 1;
            this.tbUser.TextChanged += new System.EventHandler(this.tbUser_TextChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(100, 90);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(187, 22);
            this.tbPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btEnter
            // 
            this.btEnter.Location = new System.Drawing.Point(188, 167);
            this.btEnter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(100, 28);
            this.btEnter.TabIndex = 4;
            this.btEnter.Text = "Enter";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // cbSignup
            // 
            this.cbSignup.AutoSize = true;
            this.cbSignup.Location = new System.Drawing.Point(100, 122);
            this.cbSignup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSignup.Name = "cbSignup";
            this.cbSignup.Size = new System.Drawing.Size(135, 21);
            this.cbSignup.TabIndex = 5;
            this.cbSignup.Text = "Signup new user";
            this.cbSignup.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(323, 238);
            this.Controls.Add(this.cbSignup);
            this.Controls.Add(this.btEnter);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.CheckBox cbSignup;








    }
}

