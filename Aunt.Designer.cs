namespace _11._09._2001
{
    partial class Aunt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aunt));
            Button_Aunt = new Button();
            Text_Password = new TextBox();
            Text_Login = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Button_Aunt
            // 
            Button_Aunt.BackColor = Color.FromArgb(255, 192, 192);
            Button_Aunt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Button_Aunt.ForeColor = Color.Red;
            Button_Aunt.Location = new Point(324, 301);
            Button_Aunt.Name = "Button_Aunt";
            Button_Aunt.Size = new Size(159, 63);
            Button_Aunt.TabIndex = 0;
            Button_Aunt.Text = "Нажми на меня!";
            Button_Aunt.UseVisualStyleBackColor = false;
            Button_Aunt.Click += Button_Aunt_Click;
            // 
            // Text_Password
            // 
            Text_Password.Location = new Point(324, 209);
            Text_Password.MaxLength = 10;
            Text_Password.Name = "Text_Password";
            Text_Password.PasswordChar = '♥';
            Text_Password.Size = new Size(159, 23);
            Text_Password.TabIndex = 1;
            // 
            // Text_Login
            // 
            Text_Login.Location = new Point(324, 115);
            Text_Login.MaxLength = 10;
            Text_Login.Name = "Text_Login";
            Text_Login.Size = new Size(159, 23);
            Text_Login.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(365, 91);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 3;
            label1.Text = "Логин) :3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(365, 185);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 4;
            label2.Text = "Пароль) :3";
            // 
            // Aunt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Text_Login);
            Controls.Add(Text_Password);
            Controls.Add(Button_Aunt);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Aunt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aunt";
            FormClosed += Aunt_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button_Aunt;
        private TextBox Text_Password;
        private TextBox Text_Login;
        private Label label1;
        private Label label2;
    }
}