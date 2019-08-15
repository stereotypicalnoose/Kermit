namespace Kermit
{
    partial class FrmKermit
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
            this.PnlGame = new System.Windows.Forms.Panel();
            this.TmrPlanet = new System.Windows.Forms.Timer(this.components);
            this.TmrShip = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.LblScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblLives = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(73)))));
            this.PnlGame.Location = new System.Drawing.Point(41, 92);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(500, 400);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGame_Paint);
            // 
            // TmrPlanet
            // 
            this.TmrPlanet.Enabled = true;
            this.TmrPlanet.Tick += new System.EventHandler(this.TmrPlanet_Tick);
            // 
            // TmrShip
            // 
            this.TmrShip.Interval = 50;
            this.TmrShip.Tick += new System.EventHandler(this.TmrShip_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lives";
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.Location = new System.Drawing.Point(596, 260);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(13, 13);
            this.LblScore.TabIndex = 1;
            this.LblScore.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(596, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(596, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Planet Dodge";
            // 
            // LblLives
            // 
            this.LblLives.Location = new System.Drawing.Point(559, 343);
            this.LblLives.Name = "LblLives";
            this.LblLives.Size = new System.Drawing.Size(100, 20);
            this.LblLives.TabIndex = 5;
            this.LblLives.Text = "5";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(559, 183);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 6;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStart,
            this.MnuStop});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuStart
            // 
            this.mnuStart.Name = "mnuStart";
            this.mnuStart.Size = new System.Drawing.Size(42, 20);
            this.mnuStart.Text = "start";
            this.mnuStart.Click += new System.EventHandler(this.mnuStart_Click);
            // 
            // MnuStop
            // 
            this.MnuStop.Name = "MnuStop";
            this.MnuStop.Size = new System.Drawing.Size(42, 20);
            this.MnuStop.Text = "stop";
            this.MnuStop.Click += new System.EventHandler(this.MnuStop_Click);
            // 
            // FrmKermit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 541);
            this.Controls.Add(this.LblLives);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PnlGame);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmKermit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kermit";
            this.Load += new System.EventHandler(this.FrmKermit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmKermit_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmKermit_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Timer TmrPlanet;
        private System.Windows.Forms.Timer TmrShip;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox LblLives;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuStart;
        private System.Windows.Forms.ToolStripMenuItem MnuStop;
    }
}

