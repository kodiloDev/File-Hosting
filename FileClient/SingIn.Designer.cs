namespace FileClient
{
    partial class SingIn
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
            this.txbx_login = new System.Windows.Forms.TextBox();
            this.txbx_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_singIn = new System.Windows.Forms.Button();
            this.btn_signUp = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbx_login
            // 
            this.txbx_login.Location = new System.Drawing.Point(138, 17);
            this.txbx_login.Name = "txbx_login";
            this.txbx_login.Size = new System.Drawing.Size(192, 20);
            this.txbx_login.TabIndex = 0;
            // 
            // txbx_password
            // 
            this.txbx_password.Location = new System.Drawing.Point(138, 61);
            this.txbx_password.Name = "txbx_password";
            this.txbx_password.PasswordChar = '*';
            this.txbx_password.Size = new System.Drawing.Size(192, 20);
            this.txbx_password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(73, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(61, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль:";
            // 
            // btn_singIn
            // 
            this.btn_singIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_singIn.Location = new System.Drawing.Point(246, 99);
            this.btn_singIn.Name = "btn_singIn";
            this.btn_singIn.Size = new System.Drawing.Size(84, 28);
            this.btn_singIn.TabIndex = 4;
            this.btn_singIn.Text = "Войти";
            this.btn_singIn.UseVisualStyleBackColor = true;
            this.btn_singIn.Click += new System.EventHandler(this.btn_singIn_Click);
            // 
            // btn_signUp
            // 
            this.btn_signUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_signUp.Location = new System.Drawing.Point(138, 99);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(102, 28);
            this.btn_signUp.TabIndex = 5;
            this.btn_signUp.Text = "Регистрация";
            this.btn_signUp.UseVisualStyleBackColor = true;
            this.btn_signUp.Click += new System.EventHandler(this.btn_signUp_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(134, 147);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 20);
            this.lbl_error.TabIndex = 6;
            // 
            // SingIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 167);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_signUp);
            this.Controls.Add(this.btn_singIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_password);
            this.Controls.Add(this.txbx_login);
            this.MaximumSize = new System.Drawing.Size(411, 194);
            this.MinimumSize = new System.Drawing.Size(411, 194);
            this.Name = "SingIn";
            this.Text = "Sign in";
            this.Load += new System.EventHandler(this.SingIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_login;
        private System.Windows.Forms.TextBox txbx_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_singIn;
        private System.Windows.Forms.Button btn_signUp;
        private System.Windows.Forms.Label lbl_error;
    }
}

