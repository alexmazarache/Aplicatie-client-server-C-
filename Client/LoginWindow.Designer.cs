namespace Client
{
    partial class LoginWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindow));
            this.LoginBttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.LoginImage = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoginImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBttn
            // 
            this.LoginBttn.Location = new System.Drawing.Point(709, 393);
            this.LoginBttn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginBttn.Name = "LoginBttn";
            this.LoginBttn.Size = new System.Drawing.Size(217, 43);
            this.LoginBttn.TabIndex = 0;
            this.LoginBttn.Text = "Login";
            this.LoginBttn.UseVisualStyleBackColor = true;
            this.LoginBttn.Click += new System.EventHandler(this.loginBttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 258);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 322);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(709, 258);
            this.User.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(216, 22);
            this.User.TabIndex = 3;
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(709, 319);
            this.Pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '*';
            this.Pass.Size = new System.Drawing.Size(216, 22);
            this.Pass.TabIndex = 4;
            this.Pass.UseSystemPasswordChar = true;
            this.Pass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LoginImage
            // 
            this.LoginImage.Image = ((System.Drawing.Image)(resources.GetObject("LoginImage.Image")));
            this.LoginImage.Location = new System.Drawing.Point(-2, -2);
            this.LoginImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginImage.Name = "LoginImage";
            this.LoginImage.Size = new System.Drawing.Size(487, 560);
            this.LoginImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginImage.TabIndex = 5;
            this.LoginImage.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(568, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sign in to continue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(559, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(451, 69);
            this.label3.TabIndex = 8;
            this.label3.Text = "Welcome back,";
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoginImage);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBttn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginWindow";
            this.Text = "LoginWindow";
            ((System.ComponentModel.ISupportInitialize)(this.LoginImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginBttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.PictureBox LoginImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}