using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace AFK_Heroes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random RNG = new Random();
        EnemyDict Foes = new EnemyDict();
        HeroesClass HeroOne = new HeroesClass();
        HeroesClass HeroTwo = new HeroesClass();
        HeroesClass HeroThree = new HeroesClass();
        SoundPlayer MusicPlayer = new SoundPlayer(AFK_Heroes.Properties.Resources.RSMusic);
        SoundPlayer CoinPlayer = new SoundPlayer(AFK_Heroes.Properties.Resources.Coins1);


        bool isClosing = false;
        bool afkMode = false;
        bool isCombat = false;
        bool coinKeepRunning = true;
        bool coinStarted = false;
        bool coinIsMoving = false;
        private int currentRound = 1;
        private int currentCoins = 0;

        private void startButton_MouseUp(object sender, MouseEventArgs e)
        {
            startButton.Hide();
            Foes.Init();
            StartGameThread(true);
            tutorialBox.Hide();
            tutorialLabel.Hide();
            //musicCheckBox.Checked = true;

            

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, coinBox.Width - 3, coinBox.Height - 3);
            Region rg = new Region(gp);
            coinBox.Region = rg;
        }

        private void StartGameThread(bool doStart)
        {

            Thread MainGameThread = new Thread(new ThreadStart(UpdateThread));
            MainGameThread.IsBackground = true;
            MainGameThread.Start();

            if (doStart == false)
            {
                MainGameThread.Abort();
            }
            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (isClosing == false)
            {
                isClosing = true;
                isCombat = false;
                coinIsMoving = false;
                coinStarted = false;
                StartGameThread(false);
                StartCoinMoveThread(false);
                e.Cancel = true;
                this.Hide();
                Thread.Sleep(5000);
            }

            e.Cancel = false;
            base.OnFormClosing(e);
        }

        private void StartCoinMoveThread(bool doStart)
        {
            Thread CoinMoveThread = new Thread(new ThreadStart(MoveCoinInfo));
            CoinMoveThread.IsBackground = true;
            CoinMoveThread.Start();

            if (doStart == false)
            {
                CoinMoveThread.Abort();                
            }
        }

        private void MoveCoinThread(int xPos, int yPos)
        {
            Invoke((MethodInvoker)delegate
            {
                coinBox.Location = new Point(xPos, yPos);
            });
        }

        private void CoinVisibility(bool doShow)
        {
            Invoke((MethodInvoker)delegate
            {
                if (doShow == true)
                {
                    coinBox.Show();
                }
                else if (doShow == false)
                {
                    coinBox.Hide();
                }
            });
        }

        private void SpawnCoin()
        {
            int coinXPosSpawn = RNG.Next(387, 592);
            int coinYPosSpawn = RNG.Next(121, 259);
            MoveCoinThread(coinXPosSpawn, coinYPosSpawn);
        }

        private void MoveCoinInfo()
        {
            int coinXMove = coinBox.Location.X;
            int coinYMove = coinBox.Location.Y;
            CoinVisibility(true);
            while (isClosing == false)
            {
                while (coinKeepRunning == false)
                {
                    coinBox.Hide();
                    Thread.Sleep(500);
                }
                coinXMove = coinBox.Location.X;
                coinYMove = coinBox.Location.Y;

                while (coinIsMoving == true)
                {
                    CoinVisibility(true);

                    if (coinBox.Location.X > 116)
                    {
                        coinXMove = coinXMove - 5;
                    }
                    if (coinBox.Location.Y < 385)
                    {
                        coinYMove = coinYMove + 3;
                    }

                    if (isClosing == false)
                    {
                        MoveCoinThread(coinXMove, coinYMove);
                    }

                    if (coinBox.Location.X < 120 && coinBox.Location.Y > 380)
                    {
                        CoinVisibility(false);
                        coinIsMoving = false;
                        if (afkMode == false)
                        {
                            if (((currentRound - 1) % 10) == 0)
                            {
                                currentCoins = currentCoins + RNG.Next(10, 21);
                            }
                            currentCoins = currentCoins + RNG.Next(3, 7);
                            if (muteCheckBox.Checked == false)
                            {
                                CoinPlayer.Play();
                            }
                            AFKUpgrade();
                            SpawnCoin();
                        }
                    }
                    if (afkMode == false)
                    {
                        Thread.Sleep(10);
                    }
                }
                if (afkMode == true)
                {
                    coinKeepRunning = false;
                    //StartCoinMoveThread(false);
                }
            }
        }

        private void EnemyHealthBarUpdater(int fullHP, int currentHP)
        {
            int incAmount = fullHP - currentHP;

            Invoke((MethodInvoker)delegate
            {
                enemyHealthBar.Maximum = fullHP;
                enemyHealthBar.Value = fullHP;
                enemyHealthBar.Increment(-incAmount);
            });
        }

        private void UpdateUIFromThread(int hDps1, int hDps2, int hDps3, string eName, int eHP, int coinCount, int h1Level, int h2Level, int h3Level, int h1Cost, int h2Cost, int h3Cost, int currentLvl)
        {
            Invoke((MethodInvoker)delegate
            {
                heroDpsLabel1.Text = "DPS: " + hDps1;
                heroDpsLabel2.Text = "DPS: " + hDps2;
                heroDpsLabel3.Text = "DPS: " + hDps3;
                enemyNameLabel.Text = "" + eName;
                enemyHealthLabel.Text = "Health: " + eHP;
                currentCoinsLabel.Text = "Coins: " + currentCoins;
                heroLevelLabel1.Text = "Level: " + h1Level;
                heroLevelLabel2.Text = "Level: " + h2Level;
                heroLevelLabel3.Text = "Level: " + h3Level;
                heroUpCostLabel1.Text = "Level up " + h1Cost;
                heroUpCostLabel2.Text = "Level up " + h2Cost;
                heroUpCostLabel3.Text = "Level up " + h3Cost;
                currentRoundLabel.Text = "Wave " + currentLvl;
                totalDPSLabel.Text = "Total DPS: " + (hDps1 + hDps2 + hDps3);
            });
        }

        private void UpdateThread()
        {
            string enemyName = "Default";
            int currentEnemyHealth = FindEnemyHealth();
            int startingHealth = FindEnemyHealth();

            while (isClosing == false)
            {           
                int totalDps = HeroOne.GetDPS() + HeroTwo.GetDPS() + HeroThree.GetDPS();
                int quarterDps = (int)Math.Round((double)totalDps / 4) + 1;

                if ((currentRound % 10) != 0)
                {
                    enemyName = "" + Foes.GetRandomEnemy();
                }
                else if ((currentRound % 10) == 0)
                {
                    int rngBoss = RNG.Next(1, Foes.GetBossCount() + 1);
                    enemyName = "" + Foes.GetRandomBoss(rngBoss);
                }

                if (isClosing == false)
                {
                    UpdateUIFromThread(HeroOne.GetDPS(), HeroTwo.GetDPS(), HeroThree.GetDPS(), enemyName, FindEnemyHealth(), currentCoins, HeroOne.GetLevel(), HeroTwo.GetLevel(), HeroThree.GetLevel(), FindUpgradeCost(1), FindUpgradeCost(2), FindUpgradeCost(3), currentRound);
                }
                currentEnemyHealth = FindEnemyHealth();
                startingHealth = FindEnemyHealth();

                isCombat = true;

                while(isCombat == true)
                {
                    if (currentEnemyHealth >= quarterDps)
                    {
                        currentEnemyHealth = currentEnemyHealth - quarterDps;
                    }
                    else if (currentEnemyHealth < quarterDps)
                    {
                        currentEnemyHealth = 0;
                        isCombat = false;
                        if (afkModeCheckBox.Checked == true)
                        {
                            if (((currentRound - 1) % 10) == 0)
                            {
                                currentCoins = currentCoins + RNG.Next(10, 21);
                            }
                            currentCoins = currentCoins + RNG.Next(3, 7);
                            AFKUpgrade();
                        }
                    }
                    EnemyHealthBarUpdater(startingHealth, currentEnemyHealth);
                    if (isClosing == false){
                        UpdateUIFromThread(HeroOne.GetDPS(), HeroTwo.GetDPS(), HeroThree.GetDPS(), enemyName, currentEnemyHealth, currentCoins, HeroOne.GetLevel(), HeroTwo.GetLevel(), HeroThree.GetLevel(), FindUpgradeCost(1), FindUpgradeCost(2), FindUpgradeCost(3), currentRound);
                    }
                    Thread.Sleep(250);
                }

                currentRound = currentRound + 1;
                if (coinStarted == false)
                {
                    StartCoinMoveThread(true);
                    coinStarted = true;
                }
                coinIsMoving = true;
            }   
        }

        private int FindUpgradeCost(int hero)
        {
            int costToUpgrade = 1;
            int currentLevel = 0;

            #region Which Hero
            if (hero == 1)
            {
                currentLevel = HeroOne.GetLevel();
            }
            else if (hero == 2)
            {
                currentLevel = HeroTwo.GetLevel();
            }
            else if (hero == 3)
            {
                currentLevel = HeroThree.GetLevel();
            }
            #endregion

            #region UpgradeCost
            if (currentLevel <= 5)
            {
                costToUpgrade = currentLevel * 5;
            }
            else if (currentLevel > 5 && currentLevel <= 10)
            {
                costToUpgrade = currentLevel * 6;
            }
            else if (currentLevel > 10 && currentLevel <= 20)
            {
                costToUpgrade = currentLevel * 7;
            }
            else if (currentLevel > 20 && currentLevel <= 40)
            {
                costToUpgrade = currentLevel * 11;
            }
            else if (currentLevel > 40 && currentLevel <= 45)
            {
                costToUpgrade = currentLevel * 16;
            }
            else if (currentLevel > 45 && currentLevel <= 50)
            {
                costToUpgrade = currentLevel * 21;
            }
            else
            {
                costToUpgrade = 999999;
            }
            #endregion

            return costToUpgrade;
        }

        private int FindEnemyHealth()
        {
            int enemyHP = 1;
            if (currentRound < 10)
            {
                enemyHP = 10 + (currentRound * 4);
            }
            else if (currentRound > 9 && currentRound <= 25)
            {
                enemyHP = 20 + (currentRound * 5);
            }
            else if (currentRound > 25 && currentRound <= 50)
            {
                enemyHP = 45 + (currentRound * 6);
            }
            else if (currentRound > 50 && currentRound <= 100)
            {
                enemyHP = 600 + (currentRound * 7);
            }
            else if (currentRound > 100 && currentRound <= 250)
            {
                enemyHP = 1400 + (currentRound * 8);
            }
            else if (currentRound > 250 && currentRound <= 500)
            {
                enemyHP = 4500 + (currentRound * 9);
            }
            else if (currentRound > 500)
            {
                enemyHP = 10000 + (currentRound * 10);
            }

            if ((currentRound % 10) == 0)
            {
                enemyHP = enemyHP * 3;
            }
            return enemyHP;
        }

        private void AFKUpgrade()
        {
            if (autoLevelCheckBox1.Checked == true)
            {
                if (currentCoins >= FindUpgradeCost(1))
                {
                    currentCoins = currentCoins - FindUpgradeCost(1);
                    HeroOne.UpdateDPS();
                    HeroOne.SetLevel(1);
                    heroDpsLabel1.Text = "DPS: " + HeroOne.GetDPS();
                    heroLevelLabel1.Text = "Level: " + HeroOne.GetLevel();
                    heroUpCostLabel1.Text = "Level up " + FindUpgradeCost(1);     
                }
            }

            if (autoLevelCheckBox2.Checked == true)
            {
                if (currentCoins >= FindUpgradeCost(2))
                {
                    currentCoins = currentCoins - FindUpgradeCost(2);
                    HeroTwo.UpdateDPS();
                    HeroTwo.SetLevel(1);
                    heroDpsLabel2.Text = "DPS: " + HeroTwo.GetDPS();
                    heroLevelLabel2.Text = "Level: " + HeroTwo.GetLevel();
                    heroUpCostLabel2.Text = "Level up " + FindUpgradeCost(2);
                }
            }

            if (autoLevelCheckBox3.Checked == true)
            {
                if (currentCoins >= FindUpgradeCost(3))
                {
                    currentCoins = currentCoins - FindUpgradeCost(3);
                    HeroThree.UpdateDPS();
                    HeroThree.SetLevel(1);
                    heroDpsLabel3.Text = "DPS: " + HeroThree.GetDPS();
                    heroLevelLabel3.Text = "Level: " + HeroThree.GetLevel();
                    heroUpCostLabel3.Text = "Level up " + FindUpgradeCost(3);
                }
            }
        }

        private void heroBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentCoins >= FindUpgradeCost(1))
            {
                currentCoins = currentCoins - FindUpgradeCost(1);
                HeroOne.UpdateDPS();
                HeroOne.SetLevel(1);
                heroDpsLabel1.Text = "DPS: " + HeroOne.GetDPS();
                heroLevelLabel1.Text = "Level: " + HeroOne.GetLevel();
                heroUpCostLabel1.Text = "Level up " + FindUpgradeCost(1);
            }
           // HeroOne.AddDPS(5000);
        }

        private void heroBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentCoins >= FindUpgradeCost(2))
            {
                currentCoins = currentCoins - FindUpgradeCost(2);
                HeroTwo.UpdateDPS();
                HeroTwo.SetLevel(1);
                heroDpsLabel2.Text = "DPS: " + HeroTwo.GetDPS();
                heroLevelLabel2.Text = "Level: " + HeroTwo.GetLevel();
                heroUpCostLabel2.Text = "Level up " + FindUpgradeCost(2);
            }
        }

        private void heroBox3_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentCoins >= FindUpgradeCost(3))
            {
                currentCoins = currentCoins - FindUpgradeCost(3);
                HeroThree.UpdateDPS();
                HeroThree.SetLevel(1);
                heroDpsLabel3.Text = "DPS: " + HeroOne.GetDPS();
                heroLevelLabel3.Text = "Level: " + HeroOne.GetLevel();
                heroUpCostLabel3.Text = "Level up " + FindUpgradeCost(3);
            }
        }

        private void musicCheckBox_CheckedChanged(object sender, EventArgs e)
        {

           if(musicCheckBox.Checked == true)
            {
                MusicPlayer.Play();
                MusicPlayer.PlayLooping();
            }
            else if (musicCheckBox.Checked == false)
            {
                MusicPlayer.Stop();
            }
            
        }

        private void muteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(muteCheckBox.Checked == true)
            {
                MusicPlayer.Stop();
            }
            else if (muteCheckBox.Checked == false && musicCheckBox.Checked == true)
            {
                MusicPlayer.PlayLooping();
            }
        }

        private void afkModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (afkModeCheckBox.Checked == true)
            {
                afkMode = true;
                muteCheckBox.Hide();
                coinKeepRunning = false;
                coinBox.Hide();
            }
            else if (afkModeCheckBox.Checked == false)
            {
                afkMode = false;
                muteCheckBox.Show();
                coinKeepRunning = true;
                //StartCoinMoveThread(true);
            }
        }
    }
}
