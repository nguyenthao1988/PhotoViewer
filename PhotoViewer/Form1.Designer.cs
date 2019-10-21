namespace PhotoViewer
{
    partial class Form1
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
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.photoEditor1 = new PhotoViewer.PhotoEditor();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Location = new System.Drawing.Point(808, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(55, 33);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // photoEditor1
            // 
            this.photoEditor1.AllowAddPicture = true;
            this.photoEditor1.AllowDeletePicture = false;
            this.photoEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.photoEditor1.IndexImage = 0;
            this.photoEditor1.Location = new System.Drawing.Point(0, 0);
            this.photoEditor1.Name = "photoEditor1";
            this.photoEditor1.Size = new System.Drawing.Size(891, 489);
            this.photoEditor1.TabIndex = 0;
            // 
            // Form1
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(891, 489);
            this.Controls.Add(this.photoEditor1);
            this.Controls.Add(this.btn_close);
            this.Name = "Form1";
            this.Text = "Photo Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PhotoEditor photoEditor1;
        private DevExpress.XtraEditors.SimpleButton btn_close;
    }
}

