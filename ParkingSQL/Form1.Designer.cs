namespace ParkingSQL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            label3 = new Label();
            login_button = new Button();
            label4 = new Label();
            registerhere_label = new Label();
            panel1 = new Panel();
            close_label = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(177, 82);
            label1.Name = "label1";
            label1.Size = new Size(384, 41);
            label1.TabIndex = 0;
            label1.Text = "Login to your account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(189, 169);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(189, 196);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(360, 33);
            textBox2.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.Gray;
            checkBox1.Location = new Point(363, 312);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(186, 29);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(189, 273);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(360, 33);
            textBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(189, 246);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // login_button
            // 
            login_button.BackColor = Color.FromArgb(64, 64, 64);
            login_button.FlatAppearance.BorderSize = 0;
            login_button.FlatStyle = FlatStyle.Flat;
            login_button.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_button.ForeColor = SystemColors.Control;
            login_button.Location = new Point(189, 363);
            login_button.Name = "login_button";
            login_button.Size = new Size(360, 46);
            login_button.TabIndex = 8;
            login_button.Text = "LOGIN";
            login_button.UseVisualStyleBackColor = false;
            login_button.Click += login_button_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(167, 467);
            label4.Name = "label4";
            label4.Size = new Size(258, 25);
            label4.TabIndex = 9;
            label4.Text = "Don't have an account?";
            // 
            // registerhere_label
            // 
            registerhere_label.AutoSize = true;
            registerhere_label.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerhere_label.Location = new Point(431, 467);
            registerhere_label.Name = "registerhere_label";
            registerhere_label.Size = new Size(144, 25);
            registerhere_label.TabIndex = 10;
            registerhere_label.Text = "Register Here";
            registerhere_label.Click += registerhere_label_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 600);
            panel1.TabIndex = 11;
            // 
            // close_label
            // 
            close_label.AutoSize = true;
            close_label.Cursor = Cursors.Hand;
            close_label.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close_label.Location = new Point(578, 0);
            close_label.Name = "close_label";
            close_label.Size = new Size(23, 24);
            close_label.TabIndex = 12;
            close_label.Text = "X";
            close_label.Click += close_label_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 600);
            Controls.Add(close_label);
            Controls.Add(panel1);
            Controls.Add(registerhere_label);
            Controls.Add(label4);
            Controls.Add(login_button);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private Label label3;
        private Button login_button;
        private Label label4;
        private Label registerhere_label;
        private Panel panel1;
        private Label close_label;
    }
}
