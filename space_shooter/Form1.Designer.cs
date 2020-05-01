namespace space_shooter
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
            this.MoveBgTimer = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.MoveUp = new System.Windows.Forms.Timer(this.components);
            this.MoveDown = new System.Windows.Forms.Timer(this.components);
            this.MoveRight = new System.Windows.Forms.Timer(this.components);
            this.MoveLeft = new System.Windows.Forms.Timer(this.components);
            this.MoveBulletTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemyMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemyBulletTimer = new System.Windows.Forms.Timer(this.components);
            this.label = new System.Windows.Forms.Label();
            this.reablyBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.levelLbl = new System.Windows.Forms.Label();
            this.scoreLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBgTimer
            // 
            this.MoveBgTimer.Enabled = true;
            this.MoveBgTimer.Interval = 10;
            this.MoveBgTimer.Tick += new System.EventHandler(this.MoveBgTimer_Tick);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(232, 390);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(70, 59);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // MoveUp
            // 
            this.MoveUp.Interval = 5;
            this.MoveUp.Tick += new System.EventHandler(this.MoveUp_Tick);
            // 
            // MoveDown
            // 
            this.MoveDown.Interval = 5;
            this.MoveDown.Tick += new System.EventHandler(this.MoveDown_Tick);
            // 
            // MoveRight
            // 
            this.MoveRight.Interval = 5;
            this.MoveRight.Tick += new System.EventHandler(this.MoveRight_Tick);
            // 
            // MoveLeft
            // 
            this.MoveLeft.Interval = 5;
            this.MoveLeft.Tick += new System.EventHandler(this.MoveLeft_Tick);
            // 
            // MoveBulletTimer
            // 
            this.MoveBulletTimer.Enabled = true;
            this.MoveBulletTimer.Interval = 20;
            this.MoveBulletTimer.Tick += new System.EventHandler(this.MoveBulletTimer_Tick);
            // 
            // EnemyMoveTimer
            // 
            this.EnemyMoveTimer.Enabled = true;
            this.EnemyMoveTimer.Tick += new System.EventHandler(this.EnemyMoveTimer_Tick);
            // 
            // EnemyBulletTimer
            // 
            this.EnemyBulletTimer.Enabled = true;
            this.EnemyBulletTimer.Interval = 20;
            this.EnemyBulletTimer.Tick += new System.EventHandler(this.EnemyBulletTimer_Tick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.RoyalBlue;
            this.label.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label.Location = new System.Drawing.Point(119, 102);
            this.label.Name = "label";
            this.label.Padding = new System.Windows.Forms.Padding(25);
            this.label.Size = new System.Drawing.Size(108, 73);
            this.label.TabIndex = 1;
            this.label.Text = "label1";
            this.label.Visible = false;
            // 
            // reablyBtn
            // 
            this.reablyBtn.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.reablyBtn.Location = new System.Drawing.Point(397, 221);
            this.reablyBtn.Name = "reablyBtn";
            this.reablyBtn.Size = new System.Drawing.Size(99, 46);
            this.reablyBtn.TabIndex = 2;
            this.reablyBtn.Text = "REPLAY";
            this.reablyBtn.UseVisualStyleBackColor = true;
            this.reablyBtn.Visible = false;
            this.reablyBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.exitBtn.Location = new System.Drawing.Point(61, 221);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(99, 46);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Visible = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // levelLbl
            // 
            this.levelLbl.AutoSize = true;
            this.levelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLbl.Location = new System.Drawing.Point(506, 5);
            this.levelLbl.Name = "levelLbl";
            this.levelLbl.Size = new System.Drawing.Size(66, 24);
            this.levelLbl.TabIndex = 4;
            this.levelLbl.Text = "label1";
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.Location = new System.Drawing.Point(12, 9);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(57, 20);
            this.scoreLbl.TabIndex = 5;
            this.scoreLbl.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.levelLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.reablyBtn);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.Text = "Egyption Air Force";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MoveBgTimer;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer MoveUp;
        private System.Windows.Forms.Timer MoveDown;
        private System.Windows.Forms.Timer MoveRight;
        private System.Windows.Forms.Timer MoveLeft;
        private System.Windows.Forms.Timer MoveBulletTimer;
        private System.Windows.Forms.Timer EnemyMoveTimer;
        private System.Windows.Forms.Timer EnemyBulletTimer;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button reablyBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label levelLbl;
        private System.Windows.Forms.Label scoreLbl;
    }
}

