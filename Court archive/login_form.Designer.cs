namespace Court_archive
{
    partial class login_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.login_field = new System.Windows.Forms.TextBox();
            this.password_field = new System.Windows.Forms.TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_field
            // 
            this.login_field.Location = new System.Drawing.Point(13, 30);
            this.login_field.Margin = new System.Windows.Forms.Padding(4);
            this.login_field.Name = "login_field";
            this.login_field.Size = new System.Drawing.Size(180, 24);
            this.login_field.TabIndex = 0;
            // 
            // password_field
            // 
            this.password_field.Location = new System.Drawing.Point(13, 71);
            this.password_field.Margin = new System.Windows.Forms.Padding(4);
            this.password_field.Name = "password_field";
            this.password_field.Size = new System.Drawing.Size(180, 24);
            this.password_field.TabIndex = 1;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_label.Location = new System.Drawing.Point(200, 30);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(52, 20);
            this.login_label.TabIndex = 2;
            this.login_label.Text = "Логин";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_label.Location = new System.Drawing.Point(200, 71);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(62, 20);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "Пароль";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(317, -2);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_button.Location = new System.Drawing.Point(93, 111);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(169, 44);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Войти";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // login_form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = global::Court_archive.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(354, 205);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.password_field);
            this.Controls.Add(this.login_field);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация в базе";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_field;
        private System.Windows.Forms.TextBox password_field;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

