namespace Design_paint
{
    partial class Form1
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
            this.paneltop = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picsave = new System.Windows.Forms.PictureBox();
            this.picotmenit = new System.Windows.Forms.PictureBox();
            this.tabmain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picotmenit)).BeginInit();
            this.tabmain.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.Controls.Add(this.pictureBox3);
            this.paneltop.Controls.Add(this.picsave);
            this.paneltop.Controls.Add(this.picotmenit);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.MinimumSize = new System.Drawing.Size(0, 30);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1184, 30);
            this.paneltop.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Design_paint.Properties.Resources.imagespovtorit;
            this.pictureBox3.Location = new System.Drawing.Point(55, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // picsave
            // 
            this.picsave.Image = global::Design_paint.Properties.Resources.imagesave;
            this.picsave.Location = new System.Drawing.Point(5, 5);
            this.picsave.Name = "picsave";
            this.picsave.Size = new System.Drawing.Size(16, 16);
            this.picsave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picsave.TabIndex = 1;
            this.picsave.TabStop = false;
            // 
            // picotmenit
            // 
            this.picotmenit.Image = global::Design_paint.Properties.Resources.imagesOtmenit;
            this.picotmenit.Location = new System.Drawing.Point(30, 5);
            this.picotmenit.Name = "picotmenit";
            this.picotmenit.Size = new System.Drawing.Size(16, 16);
            this.picotmenit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picotmenit.TabIndex = 0;
            this.picotmenit.TabStop = false;
            // 
            // tabmain
            // 
            this.tabmain.Controls.Add(this.tabPage1);
            this.tabmain.Controls.Add(this.tabPage2);
            this.tabmain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabmain.ItemSize = new System.Drawing.Size(58, 120);
            this.tabmain.Location = new System.Drawing.Point(0, 30);
            this.tabmain.MaximumSize = new System.Drawing.Size(0, 120);
            this.tabmain.MinimumSize = new System.Drawing.Size(0, 120);
            this.tabmain.Name = "tabmain";
            this.tabmain.Padding = new System.Drawing.Point(5, 3);
            this.tabmain.SelectedIndex = 0;
            this.tabmain.Size = new System.Drawing.Size(1184, 120);
            this.tabmain.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 124);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1176, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 124);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1176, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.tabmain);
            this.Controls.Add(this.paneltop);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.paneltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picotmenit)).EndInit();
            this.tabmain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picsave;
        private System.Windows.Forms.PictureBox picotmenit;
        private System.Windows.Forms.TabControl tabmain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

