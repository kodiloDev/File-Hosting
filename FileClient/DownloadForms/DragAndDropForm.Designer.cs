namespace FileClient.DownloadForms
{
    partial class DragAndDropForm
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
            this.pnl_dragAndDrop = new System.Windows.Forms.Panel();
            this.pb_form = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // pnl_dragAndDrop
            // 
            this.pnl_dragAndDrop.AllowDrop = true;
            this.pnl_dragAndDrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_dragAndDrop.Location = new System.Drawing.Point(13, 13);
            this.pnl_dragAndDrop.Name = "pnl_dragAndDrop";
            this.pnl_dragAndDrop.Size = new System.Drawing.Size(267, 248);
            this.pnl_dragAndDrop.TabIndex = 0;
            this.pnl_dragAndDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnl_dragAndDrop_DragDrop);
            this.pnl_dragAndDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnl_dragAndDrop_DragEnter);
            // 
            // pb_form
            // 
            this.pb_form.Location = new System.Drawing.Point(13, 267);
            this.pb_form.Name = "pb_form";
            this.pb_form.Size = new System.Drawing.Size(267, 23);
            this.pb_form.TabIndex = 1;
            // 
            // DragAndDropForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 303);
            this.Controls.Add(this.pb_form);
            this.Controls.Add(this.pnl_dragAndDrop);
            this.MaximumSize = new System.Drawing.Size(300, 330);
            this.MinimumSize = new System.Drawing.Size(300, 330);
            this.Name = "DragAndDropForm";
            this.Text = "DragAndDropForm";
            this.Load += new System.EventHandler(this.DragAndDropForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_dragAndDrop;
        private System.Windows.Forms.ProgressBar pb_form;
    }
}