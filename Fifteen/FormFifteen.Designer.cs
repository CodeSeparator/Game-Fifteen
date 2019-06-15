namespace Fifteen
{
    partial class FormFifteen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFifteen));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLevel3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLevel4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLevel5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLevel6 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStart,
            this.menuLevel});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(484, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // menuStart
            // 
            this.menuStart.Name = "menuStart";
            this.menuStart.Size = new System.Drawing.Size(76, 20);
            this.menuStart.Text = "Start game";
            this.menuStart.Click += new System.EventHandler(this.menuStart_Click);
            // 
            // menuLevel
            // 
            this.menuLevel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLevel3,
            this.menuLevel4,
            this.menuLevel5,
            this.menuLevel6});
            this.menuLevel.Name = "menuLevel";
            this.menuLevel.Size = new System.Drawing.Size(46, 20);
            this.menuLevel.Text = "Level";
            // 
            // menuLevel3
            // 
            this.menuLevel3.Name = "menuLevel3";
            this.menuLevel3.Size = new System.Drawing.Size(152, 22);
            this.menuLevel3.Text = "3X3";
            this.menuLevel3.Click += new System.EventHandler(this.menuLevel3_Click);
            // 
            // menuLevel4
            // 
            this.menuLevel4.Name = "menuLevel4";
            this.menuLevel4.Size = new System.Drawing.Size(152, 22);
            this.menuLevel4.Text = "4X4";
            this.menuLevel4.Click += new System.EventHandler(this.menuLevel4_Click);
            // 
            // menuLevel5
            // 
            this.menuLevel5.Name = "menuLevel5";
            this.menuLevel5.Size = new System.Drawing.Size(152, 22);
            this.menuLevel5.Text = "5X5";
            this.menuLevel5.Click += new System.EventHandler(this.menuLevel5_Click);
            // 
            // menuLevel6
            // 
            this.menuLevel6.Name = "menuLevel6";
            this.menuLevel6.Size = new System.Drawing.Size(152, 22);
            this.menuLevel6.Text = "6X6";
            this.menuLevel6.Click += new System.EventHandler(this.menuLevel6_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 438);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(69, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormFifteen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "FormFifteen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fifteen";
            this.Load += new System.EventHandler(this.FormFifteen_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuStart;
        private System.Windows.Forms.ToolStripMenuItem menuLevel;
        private System.Windows.Forms.ToolStripMenuItem menuLevel3;
        private System.Windows.Forms.ToolStripMenuItem menuLevel4;
        private System.Windows.Forms.ToolStripMenuItem menuLevel5;
        private System.Windows.Forms.ToolStripMenuItem menuLevel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

