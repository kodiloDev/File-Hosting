namespace FileClient
{
    partial class MainForm
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
            this.dgv_allFiles = new System.Windows.Forms.DataGridView();
            this.grbx_DebitorsDetails = new System.Windows.Forms.GroupBox();
            this.btn_download = new System.Windows.Forms.Button();
            this.btn_delFile = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.rtxbx_description = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbx_created = new System.Windows.Forms.TextBox();
            this.txbx_FileSize = new System.Windows.Forms.TextBox();
            this.txbx_contentType = new System.Windows.Forms.TextBox();
            this.txbx_fileName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьФайлыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.draganddropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allFiles)).BeginInit();
            this.grbx_DebitorsDetails.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_allFiles
            // 
            this.dgv_allFiles.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_allFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_allFiles.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_allFiles.Location = new System.Drawing.Point(2, 58);
            this.dgv_allFiles.Name = "dgv_allFiles";
            this.dgv_allFiles.ReadOnly = true;
            this.dgv_allFiles.Size = new System.Drawing.Size(443, 374);
            this.dgv_allFiles.TabIndex = 0;
            // 
            // grbx_DebitorsDetails
            // 
            this.grbx_DebitorsDetails.Controls.Add(this.btn_download);
            this.grbx_DebitorsDetails.Controls.Add(this.btn_delFile);
            this.grbx_DebitorsDetails.Controls.Add(this.btn_save);
            this.grbx_DebitorsDetails.Controls.Add(this.rtxbx_description);
            this.grbx_DebitorsDetails.Controls.Add(this.label1);
            this.grbx_DebitorsDetails.Controls.Add(this.label4);
            this.grbx_DebitorsDetails.Controls.Add(this.label3);
            this.grbx_DebitorsDetails.Controls.Add(this.label2);
            this.grbx_DebitorsDetails.Controls.Add(this.label5);
            this.grbx_DebitorsDetails.Controls.Add(this.txbx_created);
            this.grbx_DebitorsDetails.Controls.Add(this.txbx_FileSize);
            this.grbx_DebitorsDetails.Controls.Add(this.txbx_contentType);
            this.grbx_DebitorsDetails.Controls.Add(this.txbx_fileName);
            this.grbx_DebitorsDetails.Location = new System.Drawing.Point(451, 53);
            this.grbx_DebitorsDetails.Name = "grbx_DebitorsDetails";
            this.grbx_DebitorsDetails.Size = new System.Drawing.Size(354, 260);
            this.grbx_DebitorsDetails.TabIndex = 2;
            this.grbx_DebitorsDetails.TabStop = false;
            this.grbx_DebitorsDetails.Text = "Информация";
            this.grbx_DebitorsDetails.Enter += new System.EventHandler(this.grbx_DebitorsDetails_Enter);
            // 
            // btn_download
            // 
            this.btn_download.Location = new System.Drawing.Point(9, 223);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(108, 23);
            this.btn_download.TabIndex = 12;
            this.btn_download.Text = "Загрузить";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // btn_delFile
            // 
            this.btn_delFile.Location = new System.Drawing.Point(123, 223);
            this.btn_delFile.Name = "btn_delFile";
            this.btn_delFile.Size = new System.Drawing.Size(77, 23);
            this.btn_delFile.TabIndex = 11;
            this.btn_delFile.Text = "Удалить";
            this.btn_delFile.UseVisualStyleBackColor = true;
            this.btn_delFile.Click += new System.EventHandler(this.btn_delFile_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(206, 223);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(138, 23);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Сохранить изменения";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // rtxbx_description
            // 
            this.rtxbx_description.BackColor = System.Drawing.SystemColors.Info;
            this.rtxbx_description.Location = new System.Drawing.Point(123, 122);
            this.rtxbx_description.Name = "rtxbx_description";
            this.rtxbx_description.Size = new System.Drawing.Size(221, 95);
            this.rtxbx_description.TabIndex = 9;
            this.rtxbx_description.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Описание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата загрузки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Размер файла, мб";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Тип контента";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Имя файла";
            // 
            // txbx_created
            // 
            this.txbx_created.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_created.Location = new System.Drawing.Point(123, 95);
            this.txbx_created.Name = "txbx_created";
            this.txbx_created.ReadOnly = true;
            this.txbx_created.Size = new System.Drawing.Size(221, 20);
            this.txbx_created.TabIndex = 3;
            // 
            // txbx_FileSize
            // 
            this.txbx_FileSize.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_FileSize.Location = new System.Drawing.Point(123, 69);
            this.txbx_FileSize.Name = "txbx_FileSize";
            this.txbx_FileSize.ReadOnly = true;
            this.txbx_FileSize.Size = new System.Drawing.Size(221, 20);
            this.txbx_FileSize.TabIndex = 2;
            // 
            // txbx_contentType
            // 
            this.txbx_contentType.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_contentType.Location = new System.Drawing.Point(123, 42);
            this.txbx_contentType.Name = "txbx_contentType";
            this.txbx_contentType.ReadOnly = true;
            this.txbx_contentType.Size = new System.Drawing.Size(221, 20);
            this.txbx_contentType.TabIndex = 1;
            // 
            // txbx_fileName
            // 
            this.txbx_fileName.BackColor = System.Drawing.SystemColors.Info;
            this.txbx_fileName.Location = new System.Drawing.Point(123, 16);
            this.txbx_fileName.Name = "txbx_fileName";
            this.txbx_fileName.ReadOnly = true;
            this.txbx_fileName.Size = new System.Drawing.Size(221, 20);
            this.txbx_fileName.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьФайлыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьФайлыToolStripMenuItem
            // 
            this.добавитьФайлыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.draganddropToolStripMenuItem,
            this.fileDialogToolStripMenuItem});
            this.добавитьФайлыToolStripMenuItem.Name = "добавитьФайлыToolStripMenuItem";
            this.добавитьФайлыToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.добавитьФайлыToolStripMenuItem.Text = "Добавить файлы";
            // 
            // draganddropToolStripMenuItem
            // 
            this.draganddropToolStripMenuItem.Name = "draganddropToolStripMenuItem";
            this.draganddropToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.draganddropToolStripMenuItem.Text = "Drag-and-drop";
            this.draganddropToolStripMenuItem.Click += new System.EventHandler(this.draganddropToolStripMenuItem_Click);
            // 
            // fileDialogToolStripMenuItem
            // 
            this.fileDialogToolStripMenuItem.Name = "fileDialogToolStripMenuItem";
            this.fileDialogToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fileDialogToolStripMenuItem.Text = "FileDialog";
            this.fileDialogToolStripMenuItem.Click += new System.EventHandler(this.fileDialogToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 444);
            this.Controls.Add(this.grbx_DebitorsDetails);
            this.Controls.Add(this.dgv_allFiles);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(815, 471);
            this.MinimumSize = new System.Drawing.Size(815, 471);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allFiles)).EndInit();
            this.grbx_DebitorsDetails.ResumeLayout(false);
            this.grbx_DebitorsDetails.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_allFiles;
        private System.Windows.Forms.GroupBox grbx_DebitorsDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbx_created;
        private System.Windows.Forms.TextBox txbx_FileSize;
        private System.Windows.Forms.TextBox txbx_contentType;
        private System.Windows.Forms.TextBox txbx_fileName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьФайлыToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtxbx_description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.Button btn_delFile;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ToolStripMenuItem draganddropToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileDialogToolStripMenuItem;
    }
}