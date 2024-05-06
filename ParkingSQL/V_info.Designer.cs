namespace ParkingSQL
{
    partial class V_info
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
            pn_label = new Label();
            pn_textBox = new TextBox();
            type_label = new Label();
            type_comboBox = new ComboBox();
            brand_comboBox = new ComboBox();
            brand_label = new Label();
            ok_button = new Button();
            close_label = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 800);
            panel1.TabIndex = 14;
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
            // pn_label
            // 
            pn_label.AutoSize = true;
            pn_label.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pn_label.ForeColor = Color.Gray;
            pn_label.Location = new Point(229, 129);
            pn_label.Name = "pn_label";
            pn_label.Size = new Size(151, 25);
            pn_label.TabIndex = 15;
            pn_label.Text = "Plate Number";
            // 
            // pn_textBox
            // 
            pn_textBox.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pn_textBox.Location = new Point(386, 126);
            pn_textBox.Name = "pn_textBox";
            pn_textBox.Size = new Size(216, 33);
            pn_textBox.TabIndex = 16;
            // 
            // type_label
            // 
            type_label.AutoSize = true;
            type_label.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            type_label.ForeColor = Color.Gray;
            type_label.Location = new Point(229, 180);
            type_label.Name = "type_label";
            type_label.Size = new Size(60, 25);
            type_label.TabIndex = 17;
            type_label.Text = "Type";
            // 
            // type_comboBox
            // 
            type_comboBox.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            type_comboBox.FormattingEnabled = true;
            type_comboBox.Location = new Point(295, 176);
            type_comboBox.Name = "type_comboBox";
            type_comboBox.Size = new Size(164, 32);
            type_comboBox.TabIndex = 18;
            // 
            // brand_comboBox
            // 
            brand_comboBox.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            brand_comboBox.FormattingEnabled = true;
            brand_comboBox.Location = new Point(565, 176);
            brand_comboBox.Name = "brand_comboBox";
            brand_comboBox.Size = new Size(164, 32);
            brand_comboBox.TabIndex = 20;
            brand_comboBox.SelectedIndexChanged += brand_comboBox_SelectedIndexChanged;
            // 
            // brand_label
            // 
            brand_label.AutoSize = true;
            brand_label.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brand_label.ForeColor = Color.Gray;
            brand_label.Location = new Point(487, 179);
            brand_label.Name = "brand_label";
            brand_label.Size = new Size(72, 25);
            brand_label.TabIndex = 19;
            brand_label.Text = "Brand";
            // 
            // ok_button
            // 
            ok_button.BackColor = Color.FromArgb(64, 64, 64);
            ok_button.Cursor = Cursors.Hand;
            ok_button.FlatAppearance.BorderSize = 0;
            ok_button.FlatStyle = FlatStyle.Flat;
            ok_button.Font = new Font("Century Gothic", 15.75F, FontStyle.Italic);
            ok_button.ForeColor = SystemColors.Control;
            ok_button.Location = new Point(752, 176);
            ok_button.Name = "ok_button";
            ok_button.Size = new Size(131, 32);
            ok_button.TabIndex = 23;
            ok_button.Text = "OK";
            ok_button.UseVisualStyleBackColor = false;
            ok_button.Click += ok_button_Click;
            // 
            // close_label
            // 
            close_label.AutoSize = true;
            close_label.Cursor = Cursors.Hand;
            close_label.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close_label.Location = new Point(979, 0);
            close_label.Name = "close_label";
            close_label.Size = new Size(23, 24);
            close_label.TabIndex = 45;
            close_label.Text = "X";
            // 
            // V_info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 800);
            Controls.Add(close_label);
            Controls.Add(ok_button);
            Controls.Add(brand_comboBox);
            Controls.Add(brand_label);
            Controls.Add(type_comboBox);
            Controls.Add(type_label);
            Controls.Add(pn_textBox);
            Controls.Add(pn_label);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_info";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_info";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button3;
        private Label pn_label;
        private TextBox pn_textBox;
        private Label type_label;
        private ComboBox type_comboBox;
        private ComboBox brand_comboBox;
        private Label brand_label;
        private Button ok_button;
        private Label close_label;
    }
}