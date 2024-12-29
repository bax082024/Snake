namespace Snake
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            lblLevel = new Label();
            btnPause = new Button();
            lblScore = new Label();
            label1 = new Label();
            buttonExit = new Button();
            btnStart = new Button();
            playBox = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            gameTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(lblLevel);
            panel1.Controls.Add(btnPause);
            panel1.Controls.Add(lblScore);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonExit);
            panel1.Controls.Add(btnStart);
            panel1.Controls.Add(playBox);
            panel1.Controls.Add(statusStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(861, 690);
            panel1.TabIndex = 0;
            // 
            // lblLevel
            // 
            lblLevel.Anchor = AnchorStyles.None;
            lblLevel.AutoSize = true;
            lblLevel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLevel.ForeColor = Color.LawnGreen;
            lblLevel.Location = new Point(711, 46);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(71, 21);
            lblLevel.TabIndex = 7;
            lblLevel.Text = "Level : 1";
            // 
            // btnPause
            // 
            btnPause.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPause.Location = new Point(434, 581);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(116, 46);
            btnPause.TabIndex = 6;
            btnPause.Text = "PAUSE";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // lblScore
            // 
            lblScore.Anchor = AnchorStyles.None;
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.ForeColor = Color.LawnGreen;
            lblScore.Location = new Point(77, 46);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(73, 21);
            lblScore.TabIndex = 5;
            lblScore.Text = "Score : 0";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("OCR A Extended", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 204, 0);
            label1.Location = new Point(238, 0);
            label1.Name = "label1";
            label1.Size = new Size(388, 66);
            label1.TabIndex = 4;
            label1.Text = "Bax Snake";
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExit.Location = new Point(768, 610);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(70, 29);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(294, 581);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(116, 46);
            btnStart.TabIndex = 2;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // playBox
            // 
            playBox.Anchor = AnchorStyles.None;
            playBox.BackColor = Color.Silver;
            playBox.Location = new Point(31, 70);
            playBox.Name = "playBox";
            playBox.Size = new Size(796, 488);
            playBox.TabIndex = 1;
            playBox.Paint += playBox_Paint;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 668);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(861, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(74, 17);
            toolStripStatusLabel1.Text = "Bax Creation";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(861, 690);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Snake";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer gameTimer;
        private Panel playBox;
        private Button btnStart;
        private Button buttonExit;
        private Label lblScore;
        private Label label1;
        private Button btnPause;
        private Label lblLevel;
    }
}
