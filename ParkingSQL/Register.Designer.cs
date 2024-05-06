namespace ParkingSQL
{
    partial class Register
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
            label1 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            checkBox1 = new CheckBox();
            login_button = new Button();
            registerhere_label = new Label();
            label5 = new Label();
            close_label = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 600);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(194, 71);
            label1.Name = "label1";
            label1.Size = new Size(206, 41);
            label1.TabIndex = 13;
            label1.Text = "Get Started";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(194, 236);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(360, 33);
            textBox1.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(194, 208);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 16;
            label3.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(194, 160);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(360, 33);
            textBox2.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(194, 132);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 14;
            label2.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(190, 286);
            label4.Name = "label4";
            label4.Size = new Size(193, 25);
            label4.TabIndex = 18;
            label4.Text = "Confirm Password";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(194, 314);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(360, 33);
            textBox3.TabIndex = 19;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.Gray;
            checkBox1.Location = new Point(368, 353);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(186, 29);
            checkBox1.TabIndex = 20;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // login_button
            // 
            login_button.BackColor = Color.FromArgb(64, 64, 64);
            login_button.FlatAppearance.BorderSize = 0;
            login_button.FlatStyle = FlatStyle.Flat;
            login_button.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_button.ForeColor = SystemColors.Control;
            login_button.Location = new Point(194, 401);
            login_button.Name = "login_button";
            login_button.Size = new Size(360, 46);
            login_button.TabIndex = 21;
            login_button.Text = "REGISTER";
            login_button.UseVisualStyleBackColor = false;
            // 
            // registerhere_label
            // 
            registerhere_label.AutoSize = true;
            registerhere_label.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerhere_label.Location = new Point(460, 522);
            registerhere_label.Name = "registerhere_label";
            registerhere_label.Size = new Size(119, 25);
            registerhere_label.TabIndex = 23;
            registerhere_label.Text = "Login Here";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(167, 522);
            label5.Name = "label5";
            label5.Size = new Size(287, 25);
            label5.TabIndex = 22;
            label5.Text = "Already have an account?";
            // 
            // close_label
            // 
            close_label.AutoSize = true;
            close_label.Cursor = Cursors.Hand;
            close_label.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close_label.Location = new Point(577, 0);
            close_label.Name = "close_label";
            close_label.Size = new Size(23, 24);
            close_label.TabIndex = 24;
            close_label.Text = "X";
            close_label.Click += close_label_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 600);
            Controls.Add(close_label);
            Controls.Add(registerhere_label);
            Controls.Add(label5);
            Controls.Add(login_button);
            Controls.Add(checkBox1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Label label4;
        private TextBox textBox3;
        private CheckBox checkBox1;
        private Button login_button;
        private Label registerhere_label;
        private Label label5;
        private Label close_label;
    }
}