namespace flappyComputer
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
            this.components = new System.ComponentModel.Container();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.pipeUp = new System.Windows.Forms.PictureBox();
            this.pipeDown = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.ground1 = new System.Windows.Forms.PictureBox();
            this.virus = new System.Windows.Forms.PictureBox();
            this.ground2 = new System.Windows.Forms.PictureBox();
            this.ground3 = new System.Windows.Forms.PictureBox();
            this.ground4 = new System.Windows.Forms.PictureBox();
            this.ground5 = new System.Windows.Forms.PictureBox();
            this.ground6 = new System.Windows.Forms.PictureBox();
            this.ground7 = new System.Windows.Forms.PictureBox();
            this.ground8 = new System.Windows.Forms.PictureBox();
            this.ground9 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground9)).BeginInit();
            this.SuspendLayout();
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::flappyComputer.Properties.Resources.flappyComputer;
            this.flappyBird.Location = new System.Drawing.Point(179, 164);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(31, 54);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // pipeUp
            // 
            this.pipeUp.Image = global::flappyComputer.Properties.Resources.pipeUp;
            this.pipeUp.Location = new System.Drawing.Point(515, 12);
            this.pipeUp.Name = "pipeUp";
            this.pipeUp.Size = new System.Drawing.Size(100, 114);
            this.pipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeUp.TabIndex = 1;
            this.pipeUp.TabStop = false;
            // 
            // pipeDown
            // 
            this.pipeDown.Image = global::flappyComputer.Properties.Resources.pipeDown1;
            this.pipeDown.Location = new System.Drawing.Point(515, 306);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(100, 107);
            this.pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown.TabIndex = 2;
            this.pipeDown.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreText.Location = new System.Drawing.Point(22, 12);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(103, 29);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "score: 0";
            // 
            // ground1
            // 
            this.ground1.Image = global::flappyComputer.Properties.Resources.groundTrue;
            this.ground1.Location = new System.Drawing.Point(1, 419);
            this.ground1.Name = "ground1";
            this.ground1.Size = new System.Drawing.Size(98, 50);
            this.ground1.TabIndex = 3;
            this.ground1.TabStop = false;
            // 
            // virus
            // 
            this.virus.Image = global::flappyComputer.Properties.Resources.virus;
            this.virus.Location = new System.Drawing.Point(550, 198);
            this.virus.Name = "virus";
            this.virus.Size = new System.Drawing.Size(40, 35);
            this.virus.TabIndex = 5;
            this.virus.TabStop = false;
            // 
            // ground2
            // 
            this.ground2.Image = global::flappyComputer.Properties.Resources.groundTrue;
            this.ground2.Location = new System.Drawing.Point(96, 419);
            this.ground2.Name = "ground2";
            this.ground2.Size = new System.Drawing.Size(100, 50);
            this.ground2.TabIndex = 6;
            this.ground2.TabStop = false;
            // 
            // ground3
            // 
            this.ground3.Image = global::flappyComputer.Properties.Resources.groundTrue;
            this.ground3.Location = new System.Drawing.Point(191, 419);
            this.ground3.Name = "ground3";
            this.ground3.Size = new System.Drawing.Size(121, 50);
            this.ground3.TabIndex = 7;
            this.ground3.TabStop = false;
            // 
            // ground4
            // 
            this.ground4.Image = global::flappyComputer.Properties.Resources.groundTrue;
            this.ground4.Location = new System.Drawing.Point(287, 419);
            this.ground4.Name = "ground4";
            this.ground4.Size = new System.Drawing.Size(100, 50);
            this.ground4.TabIndex = 8;
            this.ground4.TabStop = false;
            // 
            // ground5
            // 
            this.ground5.Image = global::flappyComputer.Properties.Resources.groundTrue;
            this.ground5.Location = new System.Drawing.Point(384, 419);
            this.ground5.Name = "ground5";
            this.ground5.Size = new System.Drawing.Size(100, 50);
            this.ground5.TabIndex = 9;
            this.ground5.TabStop = false;
            // 
            // ground6
            // 
            this.ground6.Image = global::flappyComputer.Properties.Resources.groundTrue;
            this.ground6.Location = new System.Drawing.Point(481, 419);
            this.ground6.Name = "ground6";
            this.ground6.Size = new System.Drawing.Size(100, 50);
            this.ground6.TabIndex = 10;
            this.ground6.TabStop = false;
            // 
            // ground7
            // 
            this.ground7.Image = global::flappyComputer.Properties.Resources.groundTrue;
            this.ground7.Location = new System.Drawing.Point(578, 419);
            this.ground7.Name = "ground7";
            this.ground7.Size = new System.Drawing.Size(100, 50);
            this.ground7.TabIndex = 11;
            this.ground7.TabStop = false;
            // 
            // ground8
            // 
            this.ground8.Image = global::flappyComputer.Properties.Resources.groundTrue;
            this.ground8.Location = new System.Drawing.Point(669, 419);
            this.ground8.Name = "ground8";
            this.ground8.Size = new System.Drawing.Size(100, 50);
            this.ground8.TabIndex = 12;
            this.ground8.TabStop = false;
            // 
            // ground9
            // 
            this.ground9.Image = global::flappyComputer.Properties.Resources.groundTrue;
            this.ground9.Location = new System.Drawing.Point(736, 419);
            this.ground9.Name = "ground9";
            this.ground9.Size = new System.Drawing.Size(100, 50);
            this.ground9.TabIndex = 13;
            this.ground9.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(791, 469);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.ground9);
            this.Controls.Add(this.ground8);
            this.Controls.Add(this.ground7);
            this.Controls.Add(this.ground6);
            this.Controls.Add(this.ground5);
            this.Controls.Add(this.ground4);
            this.Controls.Add(this.ground3);
            this.Controls.Add(this.ground2);
            this.Controls.Add(this.virus);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground1);
            this.Controls.Add(this.pipeDown);
            this.Controls.Add(this.pipeUp);
            this.Name = "Form1";
            this.Text = "  ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox flappyBird;
        private PictureBox pipeUp;
        private PictureBox pipeDown;
        private Label scoreText;
        private PictureBox ground1;
        private PictureBox virus;
        private PictureBox ground2;
        private PictureBox ground3;
        private PictureBox ground4;
        private PictureBox ground5;
        private PictureBox ground6;
        private PictureBox ground7;
        private PictureBox ground8;
        private PictureBox ground9;
        private System.Windows.Forms.Timer gameTimer;
    }
}