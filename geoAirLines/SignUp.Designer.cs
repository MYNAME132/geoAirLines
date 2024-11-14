namespace geoAirLines
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            label5 = new Label();
            pictureBox1 = new PictureBox();
            Password = new TextBox();
            RepeatPassword = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            UserName = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(553, 5);
            label5.Name = "label5";
            label5.Size = new Size(24, 25);
            label5.TabIndex = 32;
            label5.Text = "x";
            label5.Click += label5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 402);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // Password
            // 
            Password.Location = new Point(329, 204);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(209, 23);
            Password.TabIndex = 30;
            // 
            // RepeatPassword
            // 
            RepeatPassword.Location = new Point(337, 296);
            RepeatPassword.Name = "RepeatPassword";
            RepeatPassword.PasswordChar = '*';
            RepeatPassword.Size = new Size(209, 23);
            RepeatPassword.TabIndex = 29;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 64, 0);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            button2.Font = new Font("Arial", 12F, FontStyle.Bold);
            button2.Location = new Point(443, 322);
            button2.Name = "button2";
            button2.Size = new Size(104, 61);
            button2.TabIndex = 28;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 64, 0);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("Arial", 12F, FontStyle.Bold);
            button1.Location = new Point(304, 322);
            button1.Name = "button1";
            button1.Size = new Size(117, 61);
            button1.TabIndex = 27;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(204, 294);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(304, 180);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 25;
            label3.Text = "Create Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(304, 272);
            label2.Name = "label2";
            label2.Size = new Size(128, 21);
            label2.TabIndex = 24;
            label2.Text = "Repeat Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(320, 9);
            label1.Name = "label1";
            label1.Size = new Size(210, 25);
            label1.TabIndex = 23;
            label1.Text = "Georgian AirLines";
            // 
            // UserName
            // 
            UserName.Location = new Point(329, 112);
            UserName.Name = "UserName";
            UserName.Size = new Size(209, 23);
            UserName.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(304, 88);
            label6.Name = "label6";
            label6.Size = new Size(137, 21);
            label6.TabIndex = 33;
            label6.Text = "Create User Name";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 404);
            Controls.Add(UserName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(Password);
            Controls.Add(RepeatPassword);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUp";
            Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private PictureBox pictureBox1;
        private TextBox Password;
        private TextBox RepeatPassword;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox UserName;
        private Label label6;
    }
}