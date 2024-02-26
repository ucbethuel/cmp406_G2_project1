namespace CMP406_G2
{
    partial class Login
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
            this.passwdBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.headingLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwdBox
            // 
            this.passwdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdBox.Location = new System.Drawing.Point(163, 159);
            this.passwdBox.Multiline = true;
            this.passwdBox.Name = "passwdBox";
            this.passwdBox.Size = new System.Drawing.Size(214, 48);
            this.passwdBox.TabIndex = 0;
            this.passwdBox.Text = "Password";
            this.passwdBox.TextChanged += new System.EventHandler(this.passwdBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.headingLabel);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.passwdBox);
            this.panel1.Location = new System.Drawing.Point(127, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 295);
            this.panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(163, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 48);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Username";
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.Brown;
            this.loginBtn.Location = new System.Drawing.Point(100, 232);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(345, 41);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.ForeColor = System.Drawing.Color.Brown;
            this.headingLabel.Location = new System.Drawing.Point(3, 12);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(538, 39);
            this.headingLabel.TabIndex = 3;
            this.headingLabel.Text = "WELCOME TO CMP406 CLINIC";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox passwdBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}

