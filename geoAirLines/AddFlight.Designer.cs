namespace geoAirLines
{
    partial class AddFlight
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
            button4 = new Button();
            label10 = new Label();
            FlightDate = new DateTimePicker();
            label7 = new Label();
            button1 = new Button();
            Destinetion = new ComboBox();
            label6 = new Label();
            Source = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            FlightSeats = new TextBox();
            label3 = new Label();
            FlightCode = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 64, 0);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            button4.Font = new Font("SuperFrench", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 2);
            button4.Location = new Point(274, 329);
            button4.Name = "button4";
            button4.Size = new Size(117, 61);
            button4.TabIndex = 62;
            button4.Text = "View";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(511, -3);
            label10.Name = "label10";
            label10.Size = new Size(22, 25);
            label10.TabIndex = 60;
            label10.Text = "x";
            label10.Click += label10_Click;
            // 
            // FlightDate
            // 
            FlightDate.Location = new Point(204, 216);
            FlightDate.Name = "FlightDate";
            FlightDate.Size = new Size(210, 23);
            FlightDate.TabIndex = 59;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(7, 216);
            label7.Name = "label7";
            label7.Size = new Size(145, 25);
            label7.TabIndex = 58;
            label7.Text = "TakeOf Date";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 64, 0);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("SuperFrench", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 2);
            button1.Location = new Point(138, 329);
            button1.Name = "button1";
            button1.Size = new Size(117, 61);
            button1.TabIndex = 56;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Destinetion
            // 
            Destinetion.FormattingEnabled = true;
            Destinetion.Items.AddRange(new object[] { "tbilisi", "batumi", "tokyo", "rome" });
            Destinetion.Location = new Point(374, 278);
            Destinetion.Name = "Destinetion";
            Destinetion.Size = new Size(121, 23);
            Destinetion.TabIndex = 55;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(233, 273);
            label6.Name = "label6";
            label6.Size = new Size(135, 25);
            label6.TabIndex = 54;
            label6.Text = "destination";
            // 
            // Source
            // 
            Source.FormattingEnabled = true;
            Source.Items.AddRange(new object[] { "bagladesh", "tbilisi", "london", "tokyo" });
            Source.Location = new Point(100, 278);
            Source.Name = "Source";
            Source.Size = new Size(121, 23);
            Source.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(7, 273);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 52;
            label5.Text = "Source";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(7, 163);
            label4.Name = "label4";
            label4.Size = new Size(191, 25);
            label4.TabIndex = 51;
            label4.Text = "Number of Seats";
            // 
            // FlightSeats
            // 
            FlightSeats.Location = new Point(204, 168);
            FlightSeats.Name = "FlightSeats";
            FlightSeats.Size = new Size(210, 23);
            FlightSeats.TabIndex = 50;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(7, 112);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 49;
            label3.Text = "Flight Code";
            // 
            // FlightCode
            // 
            FlightCode.Location = new Point(204, 114);
            FlightCode.Name = "FlightCode";
            FlightCode.Size = new Size(210, 23);
            FlightCode.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(192, 56);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 47;
            label2.Text = "Add Flight";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(158, 9);
            label1.Name = "label1";
            label1.Size = new Size(210, 25);
            label1.TabIndex = 46;
            label1.Text = "Georgian AirLines";
            // 
            // AddFlight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 422);
            Controls.Add(button4);
            Controls.Add(label10);
            Controls.Add(FlightDate);
            Controls.Add(label7);
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
            Name = "AddFlight";
            Text = "AddFlight";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Label label10;
        private DateTimePicker FlightDate;
        private Label label7;
        private Button button1;
        private ComboBox Destinetion;
        private Label label6;
        private ComboBox Source;
        private Label label5;
        private Label label4;
        private TextBox FlightSeats;
        private Label label3;
        private TextBox FlightCode;
        private Label label2;
        private Label label1;
    }
}