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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(584, 461);
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
    }
}

