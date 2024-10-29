namespace geoAirLines
{
    partial class ViewPassenger
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
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            PassName = new TextBox();
            label3 = new Label();
            PassId = new TextBox();
            label5 = new Label();
            Pasport = new TextBox();
            Gender = new ComboBox();
            label8 = new Label();
            Nationality = new ComboBox();
            label7 = new Label();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            label10 = new Label();
            adres = new Label();
            PassAdd = new TextBox();
            PassengerDGV = new DataGridView();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)PassengerDGV).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(199, 56);
            label2.Name = "label2";
            label2.Size = new Size(182, 25);
            label2.TabIndex = 5;
            label2.Text = "View Passenger";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(184, 9);
            label1.Name = "label1";
            label1.Size = new Size(210, 25);
            label1.TabIndex = 4;
            label1.Text = "Georgian AirLines";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(2, 162);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 18;
            label4.Text = "Name";
            // 
            // PassName
            // 
            PassName.Location = new Point(215, 164);
            PassName.Name = "PassName";
            PassName.Size = new Size(273, 23);
            PassName.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(-2, 123);
            label3.Name = "label3";
            label3.Size = new Size(155, 25);
            label3.TabIndex = 16;
            label3.Text = "passenger ID";
            // 
            // PassId
            // 
            PassId.Location = new Point(215, 125);
            PassId.Name = "PassId";
            PassId.Size = new Size(277, 23);
            PassId.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(2, 213);
            label5.Name = "label5";
            label5.Size = new Size(192, 25);
            label5.TabIndex = 20;
            label5.Text = "Pasport Number";
            // 
            // Pasport
            // 
            Pasport.Location = new Point(215, 213);
            Pasport.Name = "Pasport";
            Pasport.Size = new Size(277, 23);
            Pasport.TabIndex = 19;
            // 
            // Gender
            // 
            Gender.FormattingEnabled = true;
            Gender.Items.AddRange(new object[] { "male", "female" });
            Gender.Location = new Point(367, 310);
            Gender.Name = "Gender";
            Gender.Size = new Size(121, 23);
            Gender.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(268, 312);
            label8.Name = "label8";
            label8.Size = new Size(93, 25);
            label8.TabIndex = 40;
            label8.Text = "Gender";
            // 
            // Nationality
            // 
            Nationality.FormattingEnabled = true;
            Nationality.Items.AddRange(new object[] { "Georgian", "german", "usa", "china", "italy" });
            Nationality.Location = new Point(141, 312);
            Nationality.Name = "Nationality";
            Nationality.Size = new Size(121, 23);
            Nationality.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(2, 310);
            label7.Name = "label7";
            label7.Size = new Size(133, 25);
            label7.TabIndex = 38;
            label7.Text = "Nationality";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 64, 0);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            button2.Font = new Font("SuperFrench", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 2);
            button2.Location = new Point(424, 360);
            button2.Name = "button2";
            button2.Size = new Size(104, 61);
            button2.TabIndex = 43;
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
            button1.Font = new Font("SuperFrench", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 2);
            button1.Location = new Point(288, 360);
            button1.Name = "button1";
            button1.Size = new Size(117, 61);
            button1.TabIndex = 42;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 64, 0);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            button3.Font = new Font("SuperFrench", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 2);
            button3.Location = new Point(169, 360);
            button3.Name = "button3";
            button3.Size = new Size(104, 61);
            button3.TabIndex = 45;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 64, 0);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            button4.Font = new Font("SuperFrench", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 2);
            button4.Location = new Point(36, 360);
            button4.Name = "button4";
            button4.Size = new Size(117, 61);
            button4.TabIndex = 44;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(526, -2);
            label10.Name = "label10";
            label10.Size = new Size(22, 25);
            label10.TabIndex = 47;
            label10.Text = "x";
            label10.Click += label10_Click;
            // 
            // adres
            // 
            adres.AutoSize = true;
            adres.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adres.ForeColor = Color.Red;
            adres.Location = new Point(2, 262);
            adres.Name = "adres";
            adres.Size = new Size(207, 25);
            adres.TabIndex = 50;
            adres.Text = "Passenger Addres";
            // 
            // PassAdd
            // 
            PassAdd.Location = new Point(215, 262);
            PassAdd.Name = "PassAdd";
            PassAdd.Size = new Size(273, 23);
            PassAdd.TabIndex = 49;
            // 
            // PassengerDGV
            // 
            PassengerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PassengerDGV.Location = new Point(2, 439);
            PassengerDGV.Name = "PassengerDGV";
            PassengerDGV.Size = new Size(546, 224);
            PassengerDGV.TabIndex = 51;
            PassengerDGV.CellContentClick += PassengerDGV_CellContentClick;
            // 
            // button6
            // 
            button6.BackColor = Color.Red;
            button6.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            button6.FlatAppearance.BorderSize = 2;
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 64, 0);
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            button6.Font = new Font("SuperFrench", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 2);
            button6.Location = new Point(-2, -4);
            button6.Name = "button6";
            button6.Size = new Size(77, 38);
            button6.TabIndex = 64;
            button6.Text = "HOME";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // ViewPassenger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 664);
            Controls.Add(button6);
            Controls.Add(PassengerDGV);
            Controls.Add(adres);
            Controls.Add(PassAdd);
            Controls.Add(label10);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Gender);
            Controls.Add(label8);
            Controls.Add(Nationality);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(Pasport);
            Controls.Add(label4);
            Controls.Add(PassName);
            Controls.Add(label3);
            Controls.Add(PassId);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewPassenger";
            Text = "ViewPassenger";
            Load += ViewPassenger_Load;
            ((System.ComponentModel.ISupportInitialize)PassengerDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox PassName;
        private Label label3;
        private TextBox PassId;
        private Label label5;
        private TextBox Pasport;
        private ComboBox Gender;
        private Label label8;
        private ComboBox Nationality;
        private Label label7;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Label label10;
        private Label adres;
        private TextBox PassAdd;
        private DataGridView PassengerDGV;
        private Button button6;
    }
}