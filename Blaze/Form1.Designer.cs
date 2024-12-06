namespace Blaze
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Blaze = new System.Windows.Forms.Label();
            this.iconSizeButton = new System.Windows.Forms.Button();
            this.closeAppButton = new System.Windows.Forms.Button();
            this.resizeAppButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.keepLoginCheckbox = new System.Windows.Forms.CheckBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Blaze
            // 
            this.Blaze.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Blaze.AutoSize = true;
            this.Blaze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Blaze.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Blaze.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Blaze.Location = new System.Drawing.Point(1, 5);
            this.Blaze.Name = "Blaze";
            this.Blaze.Size = new System.Drawing.Size(75, 35);
            this.Blaze.TabIndex = 2;
            this.Blaze.Text = "Blaze";
            this.Blaze.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // iconSizeButton
            // 
            this.iconSizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.iconSizeButton.BackgroundImage = global::Blaze.Properties.Resources.AsagiAlrecolor;
            this.iconSizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconSizeButton.FlatAppearance.BorderSize = 0;
            this.iconSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconSizeButton.Location = new System.Drawing.Point(1332, 7);
            this.iconSizeButton.Name = "iconSizeButton";
            this.iconSizeButton.Size = new System.Drawing.Size(25, 25);
            this.iconSizeButton.TabIndex = 5;
            this.iconSizeButton.UseVisualStyleBackColor = false;
            this.iconSizeButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // closeAppButton
            // 
            this.closeAppButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.closeAppButton.BackgroundImage = global::Blaze.Properties.Resources.closeRecolor;
            this.closeAppButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeAppButton.FlatAppearance.BorderSize = 0;
            this.closeAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeAppButton.Location = new System.Drawing.Point(1413, 7);
            this.closeAppButton.Name = "closeAppButton";
            this.closeAppButton.Size = new System.Drawing.Size(25, 25);
            this.closeAppButton.TabIndex = 4;
            this.closeAppButton.UseVisualStyleBackColor = false;
            this.closeAppButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // resizeAppButton
            // 
            this.resizeAppButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.resizeAppButton.BackgroundImage = global::Blaze.Properties.Resources.asagiAlrecolored2;
            this.resizeAppButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.resizeAppButton.FlatAppearance.BorderSize = 0;
            this.resizeAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resizeAppButton.Location = new System.Drawing.Point(1373, 7);
            this.resizeAppButton.Name = "resizeAppButton";
            this.resizeAppButton.Size = new System.Drawing.Size(25, 25);
            this.resizeAppButton.TabIndex = 3;
            this.resizeAppButton.UseVisualStyleBackColor = false;
            this.resizeAppButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pictureBox1.Location = new System.Drawing.Point(-12, -17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1466, 57);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(566, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(888, 777);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(21, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 57);
            this.label1.TabIndex = 7;
            this.label1.Text = "WELCOME TO BLAZE";
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(43, 251);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(315, 22);
            this.mailTextBox.TabIndex = 8;
            this.mailTextBox.Text = "e mail";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(43, 314);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(161, 22);
            this.passwordTextBox.TabIndex = 9;
            this.passwordTextBox.Text = "password";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(43, 429);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(128, 42);
            this.loginButton.TabIndex = 10;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // keepLoginCheckbox
            // 
            this.keepLoginCheckbox.AutoSize = true;
            this.keepLoginCheckbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.keepLoginCheckbox.Location = new System.Drawing.Point(43, 368);
            this.keepLoginCheckbox.Name = "keepLoginCheckbox";
            this.keepLoginCheckbox.Size = new System.Drawing.Size(142, 20);
            this.keepLoginCheckbox.TabIndex = 11;
            this.keepLoginCheckbox.Text = "Keep me logged in";
            this.keepLoginCheckbox.UseVisualStyleBackColor = true;
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(43, 577);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(91, 32);
            this.signUpButton.TabIndex = 12;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(40, 547);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Dont have a account?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1450, 800);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.keepLoginCheckbox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.iconSizeButton);
            this.Controls.Add(this.closeAppButton);
            this.Controls.Add(this.resizeAppButton);
            this.Controls.Add(this.Blaze);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Blaze;
        private System.Windows.Forms.Button resizeAppButton;
        private System.Windows.Forms.Button closeAppButton;
        private System.Windows.Forms.Button iconSizeButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.CheckBox keepLoginCheckbox;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label label2;
    }
}

