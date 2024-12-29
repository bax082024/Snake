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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            gameTimer = new System.Windows.Forms.Timer(components);
            playBox = new Panel();
            buttonStart = new Button();
            buttonExit = new Button();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(buttonExit);
            panel1.Controls.Add(buttonStart);
            panel1.Controls.Add(playBox);
            panel1.Controls.Add(statusStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(861, 690);
            panel1.TabIndex = 0;
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
            // playBox
            // 
            playBox.Anchor = AnchorStyles.None;
            playBox.BackColor = Color.Silver;
            playBox.Location = new Point(31, 70);
            playBox.Name = "playBox";
            playBox.Size = new Size(796, 488);
            playBox.TabIndex = 1;
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStart.Location = new Point(353, 582);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(116, 46);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "START";
            buttonStart.UseVisualStyleBackColor = true;
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
        private Button buttonStart;
        private Button buttonExit;
    }
}
