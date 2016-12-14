namespace AFK_Heroes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.heroBox1 = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.heroDpsLabel1 = new System.Windows.Forms.Label();
            this.heroBox2 = new System.Windows.Forms.PictureBox();
            this.heroDpsLabel2 = new System.Windows.Forms.Label();
            this.heroBox3 = new System.Windows.Forms.PictureBox();
            this.heroDpsLabel3 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.enemyBox = new System.Windows.Forms.PictureBox();
            this.enemyNameLabel = new System.Windows.Forms.Label();
            this.enemyHealthLabel = new System.Windows.Forms.Label();
            this.currentCoinsLabel = new System.Windows.Forms.Label();
            this.heroUpCostLabel1 = new System.Windows.Forms.Label();
            this.heroLevelLabel1 = new System.Windows.Forms.Label();
            this.heroLevelLabel2 = new System.Windows.Forms.Label();
            this.heroUpCostLabel2 = new System.Windows.Forms.Label();
            this.heroLevelLabel3 = new System.Windows.Forms.Label();
            this.heroUpCostLabel3 = new System.Windows.Forms.Label();
            this.currentRoundLabel = new System.Windows.Forms.Label();
            this.totalDPSLabel = new System.Windows.Forms.Label();
            this.dlcLabel = new System.Windows.Forms.Label();
            this.dlcButton = new System.Windows.Forms.Button();
            this.trollLabel = new System.Windows.Forms.Label();
            this.dismissDlcBox = new System.Windows.Forms.PictureBox();
            this.enemyHealthBar = new System.Windows.Forms.ProgressBar();
            this.tutorialBox = new System.Windows.Forms.PictureBox();
            this.tutorialLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heroBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dismissDlcBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorialBox)).BeginInit();
            this.SuspendLayout();
            // 
            // heroBox1
            // 
            this.heroBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.heroBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("heroBox1.BackgroundImage")));
            this.heroBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heroBox1.Location = new System.Drawing.Point(49, 62);
            this.heroBox1.Margin = new System.Windows.Forms.Padding(2);
            this.heroBox1.Name = "heroBox1";
            this.heroBox1.Size = new System.Drawing.Size(90, 75);
            this.heroBox1.TabIndex = 0;
            this.heroBox1.TabStop = false;
            this.heroBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.heroBox1_MouseUp);
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Location = new System.Drawing.Point(387, 301);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(50, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.startButton_MouseUp);
            // 
            // heroDpsLabel1
            // 
            this.heroDpsLabel1.AutoSize = true;
            this.heroDpsLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroDpsLabel1.Location = new System.Drawing.Point(49, 47);
            this.heroDpsLabel1.Name = "heroDpsLabel1";
            this.heroDpsLabel1.Size = new System.Drawing.Size(47, 13);
            this.heroDpsLabel1.TabIndex = 2;
            this.heroDpsLabel1.Text = "DPS: 1";
            // 
            // heroBox2
            // 
            this.heroBox2.BackColor = System.Drawing.SystemColors.Window;
            this.heroBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("heroBox2.BackgroundImage")));
            this.heroBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heroBox2.Location = new System.Drawing.Point(49, 171);
            this.heroBox2.Name = "heroBox2";
            this.heroBox2.Size = new System.Drawing.Size(90, 75);
            this.heroBox2.TabIndex = 3;
            this.heroBox2.TabStop = false;
            this.heroBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.heroBox2_MouseUp);
            // 
            // heroDpsLabel2
            // 
            this.heroDpsLabel2.AutoSize = true;
            this.heroDpsLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroDpsLabel2.Location = new System.Drawing.Point(49, 155);
            this.heroDpsLabel2.Name = "heroDpsLabel2";
            this.heroDpsLabel2.Size = new System.Drawing.Size(47, 13);
            this.heroDpsLabel2.TabIndex = 4;
            this.heroDpsLabel2.Text = "DPS: 1";
            // 
            // heroBox3
            // 
            this.heroBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.heroBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("heroBox3.BackgroundImage")));
            this.heroBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heroBox3.Location = new System.Drawing.Point(49, 284);
            this.heroBox3.Name = "heroBox3";
            this.heroBox3.Size = new System.Drawing.Size(90, 75);
            this.heroBox3.TabIndex = 5;
            this.heroBox3.TabStop = false;
            this.heroBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.heroBox3_MouseUp);
            // 
            // heroDpsLabel3
            // 
            this.heroDpsLabel3.AutoSize = true;
            this.heroDpsLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroDpsLabel3.Location = new System.Drawing.Point(49, 268);
            this.heroDpsLabel3.Name = "heroDpsLabel3";
            this.heroDpsLabel3.Size = new System.Drawing.Size(47, 13);
            this.heroDpsLabel3.TabIndex = 6;
            this.heroDpsLabel3.Text = "DPS: 1";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titleLabel.Location = new System.Drawing.Point(304, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(222, 37);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "AFK HEROES";
            // 
            // enemyBox
            // 
            this.enemyBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemyBox.BackgroundImage")));
            this.enemyBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemyBox.Location = new System.Drawing.Point(387, 121);
            this.enemyBox.Name = "enemyBox";
            this.enemyBox.Size = new System.Drawing.Size(250, 175);
            this.enemyBox.TabIndex = 8;
            this.enemyBox.TabStop = false;
            // 
            // enemyNameLabel
            // 
            this.enemyNameLabel.AutoSize = true;
            this.enemyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyNameLabel.Location = new System.Drawing.Point(432, 57);
            this.enemyNameLabel.Name = "enemyNameLabel";
            this.enemyNameLabel.Size = new System.Drawing.Size(114, 20);
            this.enemyNameLabel.TabIndex = 9;
            this.enemyNameLabel.Text = "Enemy Name";
            // 
            // enemyHealthLabel
            // 
            this.enemyHealthLabel.AutoSize = true;
            this.enemyHealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyHealthLabel.Location = new System.Drawing.Point(473, 86);
            this.enemyHealthLabel.Name = "enemyHealthLabel";
            this.enemyHealthLabel.Size = new System.Drawing.Size(85, 16);
            this.enemyHealthLabel.TabIndex = 10;
            this.enemyHealthLabel.Text = "Health: 100";
            // 
            // currentCoinsLabel
            // 
            this.currentCoinsLabel.AutoSize = true;
            this.currentCoinsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentCoinsLabel.Location = new System.Drawing.Point(44, 398);
            this.currentCoinsLabel.Name = "currentCoinsLabel";
            this.currentCoinsLabel.Size = new System.Drawing.Size(91, 25);
            this.currentCoinsLabel.TabIndex = 11;
            this.currentCoinsLabel.Text = "Coins: 0";
            // 
            // heroUpCostLabel1
            // 
            this.heroUpCostLabel1.AutoSize = true;
            this.heroUpCostLabel1.Location = new System.Drawing.Point(144, 121);
            this.heroUpCostLabel1.Name = "heroUpCostLabel1";
            this.heroUpCostLabel1.Size = new System.Drawing.Size(60, 13);
            this.heroUpCostLabel1.TabIndex = 12;
            this.heroUpCostLabel1.Text = "Level up: 5";
            // 
            // heroLevelLabel1
            // 
            this.heroLevelLabel1.AutoSize = true;
            this.heroLevelLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroLevelLabel1.Location = new System.Drawing.Point(144, 62);
            this.heroLevelLabel1.Name = "heroLevelLabel1";
            this.heroLevelLabel1.Size = new System.Drawing.Size(49, 13);
            this.heroLevelLabel1.TabIndex = 13;
            this.heroLevelLabel1.Text = "Level 1";
            // 
            // heroLevelLabel2
            // 
            this.heroLevelLabel2.AutoSize = true;
            this.heroLevelLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroLevelLabel2.Location = new System.Drawing.Point(144, 171);
            this.heroLevelLabel2.Name = "heroLevelLabel2";
            this.heroLevelLabel2.Size = new System.Drawing.Size(49, 13);
            this.heroLevelLabel2.TabIndex = 14;
            this.heroLevelLabel2.Text = "Level 1";
            // 
            // heroUpCostLabel2
            // 
            this.heroUpCostLabel2.AutoSize = true;
            this.heroUpCostLabel2.Location = new System.Drawing.Point(144, 233);
            this.heroUpCostLabel2.Name = "heroUpCostLabel2";
            this.heroUpCostLabel2.Size = new System.Drawing.Size(60, 13);
            this.heroUpCostLabel2.TabIndex = 15;
            this.heroUpCostLabel2.Text = "Level up: 5";
            // 
            // heroLevelLabel3
            // 
            this.heroLevelLabel3.AutoSize = true;
            this.heroLevelLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroLevelLabel3.Location = new System.Drawing.Point(144, 283);
            this.heroLevelLabel3.Name = "heroLevelLabel3";
            this.heroLevelLabel3.Size = new System.Drawing.Size(49, 13);
            this.heroLevelLabel3.TabIndex = 16;
            this.heroLevelLabel3.Text = "Level 1";
            // 
            // heroUpCostLabel3
            // 
            this.heroUpCostLabel3.AutoSize = true;
            this.heroUpCostLabel3.Location = new System.Drawing.Point(144, 346);
            this.heroUpCostLabel3.Name = "heroUpCostLabel3";
            this.heroUpCostLabel3.Size = new System.Drawing.Size(60, 13);
            this.heroUpCostLabel3.TabIndex = 17;
            this.heroUpCostLabel3.Text = "Level up: 5";
            // 
            // currentRoundLabel
            // 
            this.currentRoundLabel.AutoSize = true;
            this.currentRoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentRoundLabel.Location = new System.Drawing.Point(467, 398);
            this.currentRoundLabel.Name = "currentRoundLabel";
            this.currentRoundLabel.Size = new System.Drawing.Size(91, 25);
            this.currentRoundLabel.TabIndex = 18;
            this.currentRoundLabel.Text = "Wave 1";
            // 
            // totalDPSLabel
            // 
            this.totalDPSLabel.AutoSize = true;
            this.totalDPSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDPSLabel.Location = new System.Drawing.Point(215, 398);
            this.totalDPSLabel.Name = "totalDPSLabel";
            this.totalDPSLabel.Size = new System.Drawing.Size(145, 25);
            this.totalDPSLabel.TabIndex = 19;
            this.totalDPSLabel.Text = "Total DPS: 3";
            // 
            // dlcLabel
            // 
            this.dlcLabel.AutoSize = true;
            this.dlcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlcLabel.Location = new System.Drawing.Point(648, 9);
            this.dlcLabel.Name = "dlcLabel";
            this.dlcLabel.Size = new System.Drawing.Size(192, 31);
            this.dlcLabel.TabIndex = 20;
            this.dlcLabel.Text = "Buy 500 coins!";
            this.dlcLabel.Visible = false;
            // 
            // dlcButton
            // 
            this.dlcButton.Location = new System.Drawing.Point(702, 43);
            this.dlcButton.Name = "dlcButton";
            this.dlcButton.Size = new System.Drawing.Size(75, 23);
            this.dlcButton.TabIndex = 21;
            this.dlcButton.Text = "$4.99";
            this.dlcButton.UseVisualStyleBackColor = true;
            this.dlcButton.Visible = false;
            this.dlcButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dlcButton_MouseDown);
            // 
            // trollLabel
            // 
            this.trollLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trollLabel.Location = new System.Drawing.Point(668, 69);
            this.trollLabel.Name = "trollLabel";
            this.trollLabel.Size = new System.Drawing.Size(159, 87);
            this.trollLabel.TabIndex = 22;
            this.trollLabel.Text = "Oops! Looks like you don\'t have enough. A nude picture sent to Ben@benisafaggot.o" +
    "rg will work as well.";
            this.trollLabel.Visible = false;
            // 
            // dismissDlcBox
            // 
            this.dismissDlcBox.Location = new System.Drawing.Point(798, 398);
            this.dismissDlcBox.Name = "dismissDlcBox";
            this.dismissDlcBox.Size = new System.Drawing.Size(42, 34);
            this.dismissDlcBox.TabIndex = 23;
            this.dismissDlcBox.TabStop = false;
            this.dismissDlcBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dismissDlcBox_MouseDown);
            // 
            // enemyHealthBar
            // 
            this.enemyHealthBar.Location = new System.Drawing.Point(411, 105);
            this.enemyHealthBar.Name = "enemyHealthBar";
            this.enemyHealthBar.Size = new System.Drawing.Size(202, 10);
            this.enemyHealthBar.TabIndex = 24;
            // 
            // tutorialBox
            // 
            this.tutorialBox.Location = new System.Drawing.Point(12, 15);
            this.tutorialBox.Name = "tutorialBox";
            this.tutorialBox.Size = new System.Drawing.Size(815, 408);
            this.tutorialBox.TabIndex = 25;
            this.tutorialBox.TabStop = false;
            // 
            // tutorialLabel
            // 
            this.tutorialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialLabel.Location = new System.Drawing.Point(307, 183);
            this.tutorialLabel.Name = "tutorialLabel";
            this.tutorialLabel.Size = new System.Drawing.Size(239, 83);
            this.tutorialLabel.TabIndex = 26;
            this.tutorialLabel.Text = "Click the placeholder picture to level up when you have enough coins. \'Level up:\'" +
    " is current cost to level.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(839, 432);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.tutorialLabel);
            this.Controls.Add(this.tutorialBox);
            this.Controls.Add(this.enemyHealthBar);
            this.Controls.Add(this.dismissDlcBox);
            this.Controls.Add(this.trollLabel);
            this.Controls.Add(this.dlcButton);
            this.Controls.Add(this.dlcLabel);
            this.Controls.Add(this.totalDPSLabel);
            this.Controls.Add(this.currentRoundLabel);
            this.Controls.Add(this.heroUpCostLabel3);
            this.Controls.Add(this.heroLevelLabel3);
            this.Controls.Add(this.heroUpCostLabel2);
            this.Controls.Add(this.heroLevelLabel2);
            this.Controls.Add(this.heroLevelLabel1);
            this.Controls.Add(this.heroUpCostLabel1);
            this.Controls.Add(this.currentCoinsLabel);
            this.Controls.Add(this.enemyHealthLabel);
            this.Controls.Add(this.enemyNameLabel);
            this.Controls.Add(this.enemyBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.heroDpsLabel3);
            this.Controls.Add(this.heroBox3);
            this.Controls.Add(this.heroDpsLabel2);
            this.Controls.Add(this.heroBox2);
            this.Controls.Add(this.heroDpsLabel1);
            this.Controls.Add(this.heroBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "AFK Heroes";
            ((System.ComponentModel.ISupportInitialize)(this.heroBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dismissDlcBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorialBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox heroBox1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label heroDpsLabel1;
        private System.Windows.Forms.PictureBox heroBox2;
        private System.Windows.Forms.Label heroDpsLabel2;
        private System.Windows.Forms.PictureBox heroBox3;
        private System.Windows.Forms.Label heroDpsLabel3;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox enemyBox;
        private System.Windows.Forms.Label enemyNameLabel;
        private System.Windows.Forms.Label enemyHealthLabel;
        private System.Windows.Forms.Label currentCoinsLabel;
        private System.Windows.Forms.Label heroUpCostLabel1;
        private System.Windows.Forms.Label heroLevelLabel1;
        private System.Windows.Forms.Label heroLevelLabel2;
        private System.Windows.Forms.Label heroUpCostLabel2;
        private System.Windows.Forms.Label heroLevelLabel3;
        private System.Windows.Forms.Label heroUpCostLabel3;
        private System.Windows.Forms.Label currentRoundLabel;
        private System.Windows.Forms.Label totalDPSLabel;
        private System.Windows.Forms.Label dlcLabel;
        private System.Windows.Forms.Button dlcButton;
        private System.Windows.Forms.Label trollLabel;
        private System.Windows.Forms.PictureBox dismissDlcBox;
        private System.Windows.Forms.ProgressBar enemyHealthBar;
        private System.Windows.Forms.PictureBox tutorialBox;
        private System.Windows.Forms.Label tutorialLabel;
    }
}

