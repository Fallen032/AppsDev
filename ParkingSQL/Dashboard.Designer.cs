namespace ParkingSQL
{
    partial class Dashboard
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            slots_button = new Button();
            login_button = new Button();
            close_label = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(slots_button);
            panel1.Controls.Add(login_button);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 800);
            panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 142);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(0, 651);
            button3.Name = "button3";
            button3.Size = new Size(200, 46);
            button3.TabIndex = 23;
            button3.Text = "Sign Out";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 15.75F, FontStyle.Italic);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(0, 290);
            button2.Name = "button2";
            button2.Size = new Size(200, 46);
            button2.TabIndex = 23;
            button2.Text = "Profile";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // slots_button
            // 
            slots_button.BackColor = Color.FromArgb(64, 64, 64);
            slots_button.Cursor = Cursors.Hand;
            slots_button.FlatAppearance.BorderSize = 0;
            slots_button.FlatStyle = FlatStyle.Flat;
            slots_button.Font = new Font("Century Gothic", 15.75F, FontStyle.Italic);
            slots_button.ForeColor = SystemColors.Control;
            slots_button.Location = new Point(0, 238);
            slots_button.Name = "slots_button";
            slots_button.Size = new Size(200, 46);
            slots_button.TabIndex = 23;
            slots_button.Text = "Parking Slots";
            slots_button.UseVisualStyleBackColor = false;
            slots_button.Click += slots_button_Click;
            // 
            // login_button
            // 
            login_button.BackColor = Color.FromArgb(64, 64, 64);
            login_button.Cursor = Cursors.Hand;
            login_button.FlatAppearance.BorderSize = 0;
            login_button.FlatStyle = FlatStyle.Flat;
            login_button.Font = new Font("Century Gothic", 15.75F, FontStyle.Italic);
            login_button.ForeColor = SystemColors.Control;
            login_button.Location = new Point(0, 186);
            login_button.Name = "login_button";
            login_button.Size = new Size(200, 46);
            login_button.TabIndex = 22;
            login_button.Text = "Dashboard";
            login_button.UseVisualStyleBackColor = false;
            // 
            // close_label
            // 
            close_label.AutoSize = true;
            close_label.Cursor = Cursors.Hand;
            close_label.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close_label.Location = new Point(977, 0);
            close_label.Name = "close_label";
            close_label.Size = new Size(23, 24);
            close_label.TabIndex = 25;
            close_label.Text = "X";
            // 
            // button1
            // 
            button1.Location = new Point(678, 447);
            button1.Name = "button1";
            button1.Size = new Size(179, 107);
            button1.TabIndex = 26;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 800);
            Controls.Add(button1);
            Controls.Add(close_label);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button slots_button;
        private Button login_button;
        private Label close_label;
        private PictureBox pictureBox1;
        private Button button1;
    }
}