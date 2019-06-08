namespace RanSanMoi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripScore = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelnumber5 = new System.Windows.Forms.Label();
            this.labelnumber4 = new System.Windows.Forms.Label();
            this.labelnumber3 = new System.Windows.Forms.Label();
            this.labelnumber2 = new System.Windows.Forms.Label();
            this.labelnumber1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelScorehigh = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripScore,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabelScorehigh});
            this.statusStrip1.Location = new System.Drawing.Point(0, 314);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(475, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Score";
            // 
            // toolStripScore
            // 
            this.toolStripScore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripScore.Name = "toolStripScore";
            this.toolStripScore.Size = new System.Drawing.Size(14, 17);
            this.toolStripScore.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bấm phím Enter để bắt đầu chơi !";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(310, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 248);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(17, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "F2: Pause";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(17, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "F1: New Game";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.labelnumber5);
            this.panel2.Controls.Add(this.labelnumber4);
            this.panel2.Controls.Add(this.labelnumber3);
            this.panel2.Controls.Add(this.labelnumber2);
            this.panel2.Controls.Add(this.labelnumber1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(310, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 55);
            this.panel2.TabIndex = 3;
            // 
            // labelnumber5
            // 
            this.labelnumber5.AutoSize = true;
            this.labelnumber5.BackColor = System.Drawing.Color.Yellow;
            this.labelnumber5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelnumber5.Location = new System.Drawing.Point(140, 20);
            this.labelnumber5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnumber5.Name = "labelnumber5";
            this.labelnumber5.Size = new System.Drawing.Size(14, 13);
            this.labelnumber5.TabIndex = 6;
            this.labelnumber5.Text = "5";
            this.labelnumber5.Click += new System.EventHandler(this.labelnumber5_Click);
            // 
            // labelnumber4
            // 
            this.labelnumber4.AutoSize = true;
            this.labelnumber4.BackColor = System.Drawing.Color.Yellow;
            this.labelnumber4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelnumber4.Location = new System.Drawing.Point(108, 20);
            this.labelnumber4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnumber4.Name = "labelnumber4";
            this.labelnumber4.Size = new System.Drawing.Size(14, 13);
            this.labelnumber4.TabIndex = 5;
            this.labelnumber4.Text = "4";
            this.labelnumber4.Click += new System.EventHandler(this.labelnumber4_Click);
            // 
            // labelnumber3
            // 
            this.labelnumber3.AutoSize = true;
            this.labelnumber3.BackColor = System.Drawing.Color.Yellow;
            this.labelnumber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelnumber3.Location = new System.Drawing.Point(77, 20);
            this.labelnumber3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnumber3.Name = "labelnumber3";
            this.labelnumber3.Size = new System.Drawing.Size(14, 13);
            this.labelnumber3.TabIndex = 4;
            this.labelnumber3.Text = "3";
            this.labelnumber3.Click += new System.EventHandler(this.labelnumber3_Click);
            // 
            // labelnumber2
            // 
            this.labelnumber2.AutoSize = true;
            this.labelnumber2.BackColor = System.Drawing.Color.Yellow;
            this.labelnumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelnumber2.Location = new System.Drawing.Point(48, 20);
            this.labelnumber2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnumber2.Name = "labelnumber2";
            this.labelnumber2.Size = new System.Drawing.Size(14, 13);
            this.labelnumber2.TabIndex = 3;
            this.labelnumber2.Text = "2";
            this.labelnumber2.Click += new System.EventHandler(this.labelnumber2_Click);
            // 
            // labelnumber1
            // 
            this.labelnumber1.AutoSize = true;
            this.labelnumber1.BackColor = System.Drawing.Color.Yellow;
            this.labelnumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelnumber1.Location = new System.Drawing.Point(17, 20);
            this.labelnumber1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnumber1.Name = "labelnumber1";
            this.labelnumber1.Size = new System.Drawing.Size(14, 13);
            this.labelnumber1.TabIndex = 2;
            this.labelnumber1.Text = "1";
            this.labelnumber1.Click += new System.EventHandler(this.labelnumber1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.OrangeRed;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(48, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Select speed";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel2.Text = "High Score";
            // 
            // toolStripStatusLabelScorehigh
            // 
            this.toolStripStatusLabelScorehigh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripStatusLabelScorehigh.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabelScorehigh.Name = "toolStripStatusLabelScorehigh";
            this.toolStripStatusLabelScorehigh.Size = new System.Drawing.Size(14, 17);
            this.toolStripStatusLabelScorehigh.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(475, 336);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Snake Funny";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelnumber5;
        private System.Windows.Forms.Label labelnumber4;
        private System.Windows.Forms.Label labelnumber3;
        private System.Windows.Forms.Label labelnumber2;
        private System.Windows.Forms.Label labelnumber1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelScorehigh;
    }
}

