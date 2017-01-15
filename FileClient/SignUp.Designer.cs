namespace FileClient
{
    partial class SignUp
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
            this.btn_singIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_password = new System.Windows.Forms.TextBox();
            this.txbx_login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbx_passwordRep = new System.Windows.Forms.TextBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_singIn
            // 
            this.btn_singIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_singIn.Location = new System.Drawing.Point(182, 106);
            this.btn_singIn.Name = "btn_singIn";
            this.btn_singIn.Size = new System.Drawing.Size(192, 28);
            this.btn_singIn.TabIndex = 10;
            this.btn_singIn.Text = "Зарегистрироваться";
            this.btn_singIn.UseVisualStyleBackColor = true;
            this.btn_singIn.Click += new System.EventHandler(this.btn_singIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(105, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(117, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Логин:";
            // 
            // txbx_password
            // 
            this.txbx_password.Location = new System.Drawing.Point(182, 54);
            this.txbx_password.Name = "txbx_password";
            this.txbx_password.PasswordChar = '*';
            this.txbx_password.Size = new System.Drawing.Size(192, 20);
            this.txbx_password.TabIndex = 6;
            // 
            // txbx_login
            // 
            this.txbx_login.Location = new System.Drawing.Point(182, 28);
            this.txbx_login.Name = "txbx_login";
            this.txbx_login.Size = new System.Drawing.Size(192, 20);
            this.txbx_login.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Повторите пароль:";
            // 
            // txbx_passwordRep
            // 
            this.txbx_passwordRep.Location = new System.Drawing.Point(182, 80);
            this.txbx_passwordRep.Name = "txbx_passwordRep";
            this.txbx_passwordRep.PasswordChar = '*';
            this.txbx_passwordRep.Size = new System.Drawing.Size(192, 20);
            this.txbx_passwordRep.TabIndex = 9;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(20, 138);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 20);
            this.lbl_error.TabIndex = 12;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 167);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbx_passwordRep);
            this.Controls.Add(this.btn_singIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_password);
            this.Controls.Add(this.txbx_login);
            this.MaximumSize = new System.Drawing.Size(411, 194);
            this.MinimumSize = new System.Drawing.Size(411, 194);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_singIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_password;
        private System.Windows.Forms.TextBox txbx_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbx_passwordRep;
        private System.Windows.Forms.Label lbl_error;
    }
}