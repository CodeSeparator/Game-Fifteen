namespace Appolo
{
    partial class Appolo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Fair = new System.Windows.Forms.Label();
            this.labelmoon = new System.Windows.Forms.Label();
            this.labelEngine = new System.Windows.Forms.Label();
            this.labelShip = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelFinish = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.labelFinish);
            this.panel1.Controls.Add(this.Fair);
            this.panel1.Controls.Add(this.labelmoon);
            this.panel1.Controls.Add(this.labelEngine);
            this.panel1.Controls.Add(this.labelShip);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 369);
            this.panel1.TabIndex = 0;
            // 
            // Fair
            // 
            this.Fair.BackColor = System.Drawing.Color.Yellow;
            this.Fair.Font = new System.Drawing.Font("RomanT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Fair.Location = new System.Drawing.Point(49, 5);
            this.Fair.Name = "Fair";
            this.Fair.Size = new System.Drawing.Size(45, 11);
            this.Fair.TabIndex = 1;
            this.Fair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelmoon
            // 
            this.labelmoon.BackColor = System.Drawing.SystemColors.Menu;
            this.labelmoon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelmoon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelmoon.Font = new System.Drawing.Font("RomanT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelmoon.ForeColor = System.Drawing.Color.Black;
            this.labelmoon.Location = new System.Drawing.Point(0, 330);
            this.labelmoon.Name = "labelmoon";
            this.labelmoon.Size = new System.Drawing.Size(291, 39);
            this.labelmoon.TabIndex = 0;
            this.labelmoon.Text = "Moon";
            this.labelmoon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelmoon.Click += new System.EventHandler(this.labelShip_Click);
            // 
            // labelEngine
            // 
            this.labelEngine.BackColor = System.Drawing.Color.Red;
            this.labelEngine.Font = new System.Drawing.Font("RomanT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEngine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelEngine.Location = new System.Drawing.Point(170, 10);
            this.labelEngine.Name = "labelEngine";
            this.labelEngine.Size = new System.Drawing.Size(118, 39);
            this.labelEngine.TabIndex = 0;
            this.labelEngine.Text = "Engine";
            this.labelEngine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEngine.Click += new System.EventHandler(this.labelShip_Click);
            this.labelEngine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelEngine_MouseDown);
            this.labelEngine.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelEngine_MouseUp);
            // 
            // labelShip
            // 
            this.labelShip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelShip.Font = new System.Drawing.Font("RomanT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShip.Location = new System.Drawing.Point(59, -45);
            this.labelShip.Name = "labelShip";
            this.labelShip.Size = new System.Drawing.Size(24, 50);
            this.labelShip.TabIndex = 0;
            this.labelShip.Text = "A";
            this.labelShip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelShip.Click += new System.EventHandler(this.labelShip_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelFinish
            // 
            this.labelFinish.BackColor = System.Drawing.Color.Black;
            this.labelFinish.Font = new System.Drawing.Font("RomanT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFinish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelFinish.Location = new System.Drawing.Point(170, 63);
            this.labelFinish.Name = "labelFinish";
            this.labelFinish.Size = new System.Drawing.Size(118, 39);
            this.labelFinish.TabIndex = 2;
            this.labelFinish.Text = "-";
            this.labelFinish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFinish.Click += new System.EventHandler(this.labelFinish_Click);
            // 
            // Appolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 394);
            this.Controls.Add(this.panel1);
            this.Name = "Appolo";
            this.Text = "Appolo";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelShip;
        private System.Windows.Forms.Label labelmoon;
        private System.Windows.Forms.Label labelEngine;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label Fair;
        private System.Windows.Forms.Label labelFinish;
    }
}

