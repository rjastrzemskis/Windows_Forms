
namespace MemoryGame
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.Start = new System.Windows.Forms.Button();
            this.GameButton12 = new System.Windows.Forms.Button();
            this.GameButton11 = new System.Windows.Forms.Button();
            this.GameButton10 = new System.Windows.Forms.Button();
            this.GameButton9 = new System.Windows.Forms.Button();
            this.GameButton16 = new System.Windows.Forms.Button();
            this.GameButton15 = new System.Windows.Forms.Button();
            this.GameButton14 = new System.Windows.Forms.Button();
            this.GameButton13 = new System.Windows.Forms.Button();
            this.ScoreText = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.coundownTimer = new System.Windows.Forms.Timer(this.components);
            this.coundownTimerDisplay = new System.Windows.Forms.Label();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.welcomeLable = new System.Windows.Forms.Label();
            this.gameResultLabel = new System.Windows.Forms.Label();
            this.GameButton8 = new System.Windows.Forms.Button();
            this.GameButton7 = new System.Windows.Forms.Button();
            this.GameButton6 = new System.Windows.Forms.Button();
            this.GameButton5 = new System.Windows.Forms.Button();
            this.GameButton4 = new System.Windows.Forms.Button();
            this.GameButton3 = new System.Windows.Forms.Button();
            this.GameButton2 = new System.Windows.Forms.Button();
            this.GameButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(578, 168);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(129, 46);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // GameButton12
            // 
            this.GameButton12.BackgroundImage = global::MemoryGame.Properties.Resources._41367451;
            this.GameButton12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameButton12.Location = new System.Drawing.Point(391, 233);
            this.GameButton12.Name = "GameButton12";
            this.GameButton12.Size = new System.Drawing.Size(122, 108);
            this.GameButton12.TabIndex = 13;
            this.GameButton12.UseVisualStyleBackColor = true;
            this.GameButton12.Click += new System.EventHandler(this.GameButtonCheckerClick);
            // 
            // GameButton11
            // 
            this.GameButton11.BackgroundImage = global::MemoryGame.Properties.Resources._41367451;
            this.GameButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameButton11.Location = new System.Drawing.Point(263, 233);
            this.GameButton11.Name = "GameButton11";
            this.GameButton11.Size = new System.Drawing.Size(122, 108);
            this.GameButton11.TabIndex = 12;
            this.GameButton11.UseVisualStyleBackColor = true;
            this.GameButton11.Click += new System.EventHandler(this.GameButtonCheckerClick);
            // 
            // GameButton10
            // 
            this.GameButton10.BackgroundImage = global::MemoryGame.Properties.Resources._41367451;
            this.GameButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameButton10.Location = new System.Drawing.Point(135, 233);
            this.GameButton10.Name = "GameButton10";
            this.GameButton10.Size = new System.Drawing.Size(122, 108);
            this.GameButton10.TabIndex = 11;
            this.GameButton10.UseVisualStyleBackColor = true;
            this.GameButton10.Click += new System.EventHandler(this.GameButtonCheckerClick);
            // 
            // GameButton9
            // 
            this.GameButton9.BackgroundImage = global::MemoryGame.Properties.Resources._41367451;
            this.GameButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameButton9.Location = new System.Drawing.Point(7, 233);
            this.GameButton9.Name = "GameButton9";
            this.GameButton9.Size = new System.Drawing.Size(122, 108);
            this.GameButton9.TabIndex = 10;
            this.GameButton9.UseVisualStyleBackColor = true;
            this.GameButton9.Click += new System.EventHandler(this.GameButtonCheckerClick);
            // 
            // GameButton16
            // 
            this.GameButton16.BackgroundImage = global::MemoryGame.Properties.Resources._41367451;
            this.GameButton16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameButton16.Location = new System.Drawing.Point(391, 347);
            this.GameButton16.Name = "GameButton16";
            this.GameButton16.Size = new System.Drawing.Size(122, 108);
            this.GameButton16.TabIndex = 17;
            this.GameButton16.UseVisualStyleBackColor = true;
            this.GameButton16.Click += new System.EventHandler(this.GameButtonCheckerClick);
            // 
            // GameButton15
            // 
            this.GameButton15.BackgroundImage = global::MemoryGame.Properties.Resources._41367451;
            this.GameButton15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameButton15.Location = new System.Drawing.Point(263, 347);
            this.GameButton15.Name = "GameButton15";
            this.GameButton15.Size = new System.Drawing.Size(122, 108);
            this.GameButton15.TabIndex = 16;
            this.GameButton15.UseVisualStyleBackColor = true;
            this.GameButton15.Click += new System.EventHandler(this.GameButtonCheckerClick);
            // 
            // GameButton14
            // 
            this.GameButton14.BackgroundImage = global::MemoryGame.Properties.Resources._41367451;
            this.GameButton14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameButton14.Location = new System.Drawing.Point(135, 347);
            this.GameButton14.Name = "GameButton14";
            this.GameButton14.Size = new System.Drawing.Size(122, 108);
            this.GameButton14.TabIndex = 15;
            this.GameButton14.UseVisualStyleBackColor = true;
            this.GameButton14.Click += new System.EventHandler(this.GameButtonCheckerClick);
            // 
            // GameButton13
            // 
            this.GameButton13.BackgroundImage = global::MemoryGame.Properties.Resources._41367451;
            this.GameButton13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameButton13.Location = new System.Drawing.Point(7, 347);
            this.GameButton13.Name = "GameButton13";
            this.GameButton13.Size = new System.Drawing.Size(122, 108);
            this.GameButton13.TabIndex = 14;
            this.GameButton13.UseVisualStyleBackColor = true;
            this.GameButton13.Click += new System.EventHandler(this.GameButtonCheckerClick);
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreText.Location = new System.Drawing.Point(563, 418);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(133, 24);
            this.ScoreText.TabIndex = 18;
            this.ScoreText.Text = "Your Score : ";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(686, 418);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(21, 24);
            this.scoreLabel.TabIndex = 19;
            this.scoreLabel.Text = "0";
            // 
            // coundownTimer
            // 
            this.coundownTimer.Interval = 1000;
            this.coundownTimer.Tick += new System.EventHandler(this.CoundownTimerTick);
            // 
            // coundownTimerDisplay
            // 
            this.coundownTimerDisplay.AutoSize = true;
            this.coundownTimerDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coundownTimerDisplay.Location = new System.Drawing.Point(671, 394);
            this.coundownTimerDisplay.Name = "coundownTimerDisplay";
            this.coundownTimerDisplay.Size = new System.Drawing.Size(0, 24);
            this.coundownTimerDisplay.TabIndex = 20;
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.Location = new System.Drawing.Point(563, 394);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(108, 24);
            this.TimerLabel.TabIndex = 21;
            this.TimerLabel.Text = "Time left : ";
            // 
            // welcomeLable
            // 
            this.welcomeLable.AutoSize = true;
            this.welcomeLable.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLable.Location = new System.Drawing.Point(538, 21);
            this.welcomeLable.Name = "welcomeLable";
            this.welcomeLable.Size = new System.Drawing.Size(216, 115);
            this.welcomeLable.TabIndex = 22;
            this.welcomeLable.Text = "Welcome, player!\r\nYou have to press start\r\nbutton and then you will\r\nhave 2 secon" +
    "ds to\r\nremember black squares\r\n";
            this.welcomeLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gameResultLabel
            // 
            this.gameResultLabel.AutoSize = true;
            this.gameResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameResultLabel.Location = new System.Drawing.Point(598, 273);
            this.gameResultLabel.Name = "gameResultLabel";
            this.gameResultLabel.Size = new System.Drawing.Size(0, 24);
            this.gameResultLabel.TabIndex = 24;
            // 
            // GameButton8
            // 
            this.GameButton8.BackColor = System.Drawing.SystemColors.Control;
            this.GameButton8.BackgroundImage = global::MemoryGame.Properties.Resources._41367451;
            this.GameButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameButton8.Location = new System.Drawing.Point(391, 119);
            this.GameButton8.Name = "GameButton8";
            this.GameButton8.Size = new System.Drawing.Size(122, 108);
            this.GameButton8.TabIndex = 9;
            this.GameButton8.UseVisualStyleBackColor = false;
            this.GameButton8.Click += new System.EventHandler(this.GameButtonCheckerClick);
            // 
            // GameButton7
            // 
            this.GameButton7.BackgroundImage = global::MemoryGame.Properties.Resources._41367451;
            this.GameButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameButton7.Location = new System.Drawing.Point(263, 119);
            this.GameButton7.Name = "GameButton7";
            this.GameButton7.Size = new System.Drawing.Size(122, 108);
            this.GameButton7.TabIndex = 8;
            this.GameButton7.UseVisualStyleBackColor = true;
            this.GameButton7.Click += new System.EventHandler(this.GameButtonCheckerClick);
            // 
            // GameButton6
            // 
            this.GameButton6.BackgroundImage = global::MemoryGame.Properties.Resources._41367451;
            this.GameButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameButton6.Location = new System.Drawing.Point(135, 119);
            this.GameButton6.Name = "GameButton6";
            this.GameButton6.Size = new System.Drawing.Size(122, 108);
            this.GameButton6.TabIndex = 7;
            this.GameButton6.UseVisualStyleBackColor = true;
            this.GameButton6.Click += new System.EventHandler(this.GameButtonCheckerClick);
            // 
            // GameButton5
            // 
            this.GameButton5.BackgroundImage = global::MemoryGame.Properties.Resources._41367451;
            this.GameButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameButton5.Location = new System.Drawing.Point(7, 119);
            this.GameButton5.Name = "GameButton5";
            this.GameButton5.Size = new System.Drawing.Size(122, 108);
            this.GameButton5.TabIndex = 6;
            this.GameButton5.UseVisualStyleBackColor = true;
            this.GameButton5.Click += new System.EventHandler(this.GameButtonCheckerClick);
            // 
            // GameButton4
            // 
            this.GameButton4.BackgroundImage = global::MemoryGame.Properties.Resources._41367451;
            this.GameButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameButton4.Location = new System.Drawing.Point(391, 5);
            this.GameButton4.Name = "GameButton4";
            this.GameButton4.Size = new System.Drawing.Size(122, 108);
            this.GameButton4.TabIndex = 5;
            this.GameButton4.UseVisualStyleBackColor = true;
            this.GameButton4.Click += new System.EventHandler(this.GameButtonCheckerClick);
            // 
            // GameButton3
            // 
            this.GameButton3.BackgroundImage = global::MemoryGame.Properties.Resources._41367451;
            this.GameButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameButton3.Location = new System.Drawing.Point(263, 5);
            this.GameButton3.Name = "GameButton3";
            this.GameButton3.Size = new System.Drawing.Size(122, 108);
            this.GameButton3.TabIndex = 4;
            this.GameButton3.UseVisualStyleBackColor = true;
            this.GameButton3.Click += new System.EventHandler(this.GameButtonCheckerClick);
            // 
            // GameButton2
            // 
            this.GameButton2.BackgroundImage = global::MemoryGame.Properties.Resources._41367451;
            this.GameButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameButton2.Location = new System.Drawing.Point(135, 5);
            this.GameButton2.Name = "GameButton2";
            this.GameButton2.Size = new System.Drawing.Size(122, 108);
            this.GameButton2.TabIndex = 3;
            this.GameButton2.UseVisualStyleBackColor = true;
            this.GameButton2.Click += new System.EventHandler(this.GameButtonCheckerClick);
            // 
            // GameButton1
            // 
            this.GameButton1.BackColor = System.Drawing.SystemColors.Control;
            this.GameButton1.BackgroundImage = global::MemoryGame.Properties.Resources._41367451;
            this.GameButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameButton1.Location = new System.Drawing.Point(7, 5);
            this.GameButton1.Name = "GameButton1";
            this.GameButton1.Size = new System.Drawing.Size(122, 108);
            this.GameButton1.TabIndex = 2;
            this.GameButton1.UseVisualStyleBackColor = false;
            this.GameButton1.Click += new System.EventHandler(this.GameButtonCheckerClick);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 463);
            this.Controls.Add(this.gameResultLabel);
            this.Controls.Add(this.welcomeLable);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.coundownTimerDisplay);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.GameButton16);
            this.Controls.Add(this.GameButton15);
            this.Controls.Add(this.GameButton14);
            this.Controls.Add(this.GameButton13);
            this.Controls.Add(this.GameButton12);
            this.Controls.Add(this.GameButton11);
            this.Controls.Add(this.GameButton10);
            this.Controls.Add(this.GameButton9);
            this.Controls.Add(this.GameButton8);
            this.Controls.Add(this.GameButton7);
            this.Controls.Add(this.GameButton6);
            this.Controls.Add(this.GameButton5);
            this.Controls.Add(this.GameButton4);
            this.Controls.Add(this.GameButton3);
            this.Controls.Add(this.GameButton2);
            this.Controls.Add(this.GameButton1);
            this.Controls.Add(this.Start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(782, 502);
            this.MinimumSize = new System.Drawing.Size(782, 502);
            this.Name = "GameWindow";
            this.Text = "MemoryGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button GameButton1;
        private System.Windows.Forms.Button GameButton2;
        private System.Windows.Forms.Button GameButton3;
        private System.Windows.Forms.Button GameButton4;
        private System.Windows.Forms.Button GameButton8;
        private System.Windows.Forms.Button GameButton7;
        private System.Windows.Forms.Button GameButton6;
        private System.Windows.Forms.Button GameButton5;
        private System.Windows.Forms.Button GameButton12;
        private System.Windows.Forms.Button GameButton11;
        private System.Windows.Forms.Button GameButton10;
        private System.Windows.Forms.Button GameButton9;
        private System.Windows.Forms.Button GameButton16;
        private System.Windows.Forms.Button GameButton15;
        private System.Windows.Forms.Button GameButton14;
        private System.Windows.Forms.Button GameButton13;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer coundownTimer;
        private System.Windows.Forms.Label coundownTimerDisplay;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Label welcomeLable;
        private System.Windows.Forms.Label gameResultLabel;
    }
}

