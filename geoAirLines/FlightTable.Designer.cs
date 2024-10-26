namespace geoAirLines
{
    partial class FlightTable
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
            label1 = new Label();
            label2 = new Label();
            FlightCode = new TextBox();
            label3 = new Label();
            FlightSeats = new TextBox();
            label4 = new Label();
            label5 = new Label();
            Source = new ComboBox();
            label6 = new Label();
            Destinetion = new ComboBox();
            button1 = new Button();
            label7 = new Label();
            FlightDate = new DateTimePicker();
            FlightDVG = new DataGridView();
            label10 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)FlightDVG).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(175, 9);
            label1.Name = "label1";
            label1.Size = new Size(210, 25);
            label1.TabIndex = 2;
            label1.Text = "Georgian AirLines";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(209, 56);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 3;
            label2.Text = "View Flight";
            // 
            // FlightCode
            // 
            FlightCode.Location = new Point(221, 114);
            FlightCode.Name = "FlightCode";
            FlightCode.Size = new Size(210, 23);
            FlightCode.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(24, 112);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 11;
            label3.Text = "Flight Code";
            // 
            // FlightSeats
            // 
            FlightSeats.Location = new Point(221, 168);
            FlightSeats.Name = "FlightSeats";
            FlightSeats.Size = new Size(210, 23);
            FlightSeats.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(24, 163);
            label4.Name = "label4";
            label4.Size = new Size(191, 25);
            label4.TabIndex = 14;
            label4.Text = "Number of Seats";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(24, 273);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 15;
            label5.Text = "Source";
            // 
            // Source
            // 
            Source.FormattingEnabled = true;
            Source.Items.AddRange(new object[] { "bagladesh", "tbilisi", "london", "tokyo" });
            Source.Location = new Point(117, 278);
            Source.Name = "Source";
            Source.Size = new Size(121, 23);
            Source.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(250, 273);
            label6.Name = "label6";
            label6.Size = new Size(135, 25);
            label6.TabIndex = 17;
            label6.Text = "destination";
            // 
            // Destinetion
            // 
            Destinetion.FormattingEnabled = true;
            Destinetion.Items.AddRange(new object[] { "tbilisi", "batumi", "tokyo", "rome" });
            Destinetion.Location = new Point(391, 278);
            Destinetion.Name = "Destinetion";
            Destinetion.Size = new Size(121, 23);
            Destinetion.TabIndex = 18;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 64, 0);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("SuperFrench", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 2);
            button1.Location = new Point(24, 329);
            button1.Name = "button1";
            button1.Size = new Size(117, 61);
            button1.TabIndex = 19;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(24, 216);
            label7.Name = "label7";
            label7.Size = new Size(145, 25);
            label7.TabIndex = 21;
            label7.Text = "TakeOf Date";
            // 
            // FlightDate
            // 
            FlightDate.Location = new Point(221, 216);
            FlightDate.Name = "FlightDate";
            FlightDate.Size = new Size(210, 23);
            FlightDate.TabIndex = 23;
            // 
            // FlightDVG
            // 
            FlightDVG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FlightDVG.Location = new Point(-1, 420);
            FlightDVG.Name = "FlightDVG";
            FlightDVG.Size = new Size(551, 259);
            FlightDVG.TabIndex = 24;
            FlightDVG.CellContentClick += FlightDVG_CellContentClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(528, -3);
            label10.Name = "label10";
            label10.Size = new Size(22, 25);
            label10.TabIndex = 43;
            label10.Text = "x";
            label10.Click += label10_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 64, 0);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            button4.Font = new Font("SuperFrench", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 2);
            button4.Location = new Point(410, 329);
            button4.Name = "button4";
            button4.Size = new Size(117, 61);
            button4.TabIndex = 45;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 64, 0);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            button3.Font = new Font("SuperFrench", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 2);
            button3.Location = new Point(278, 329);
            button3.Name = "button3";
            button3.Size = new Size(117, 61);
            button3.TabIndex = 44;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 64, 0);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            button2.Font = new Font("SuperFrench", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 2);
            button2.Location = new Point(158, 329);
            button2.Name = "button2";
            button2.Size = new Size(104, 61);
            button2.TabIndex = 20;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            // 
            // FlightTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 679);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label10);
            Controls.Add(FlightDVG);
            Controls.Add(FlightDate);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Destinetion);
            Controls.Add(label6);
            Controls.Add(Source);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(FlightSeats);
            Controls.Add(label3);
            Controls.Add(FlightCode);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FlightTable";
            Text = "FlightTable";
            Load += FlightTable_Load;
            ((System.ComponentModel.ISupportInitialize)FlightDVG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox FlightCode;
        private Label label3;
        private TextBox FlightSeats;
        private Label label4;
        private Label label5;
        private ComboBox Source;
        private Label label6;
        private ComboBox Destinetion;
        private Button button1;
        private Label label7;
        private DateTimePicker FlightDate;
        private DataGridView FlightDVG;
        private Label label10;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}