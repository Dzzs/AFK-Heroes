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

        bool isCombat = false;
        private int currentRound = 1;
        private int currentCoins = 0;

        private void startButton_MouseUp(object sender, MouseEventArgs e)
        {
            startButton.Hide();
            Foes.Init();
            StartGameThread();
            tutorialBox.Hide();
            tutorialLabel.Hide();
        }

        private void StartGameThread()
        {
            Thread MainGameThread = new Thread(new ThreadStart(UpdateThread));

            //MainGameThread.IsBackground = true;

            MainGameThread.Start();
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

            while (true)
            {

                if (currentRound == 10)
                {
                    ShowDLC();
                }
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

                UpdateUIFromThread(HeroOne.GetDPS(), HeroTwo.GetDPS(), HeroThree.GetDPS(), enemyName, FindEnemyHealth(), currentCoins, HeroOne.GetLevel(), HeroTwo.GetLevel(), HeroThree.GetLevel(), FindUpgradeCost(1), FindUpgradeCost(2),FindUpgradeCost(3), currentRound);

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
                    }
                    EnemyHealthBarUpdater(startingHealth, currentEnemyHealth);
                    UpdateUIFromThread(HeroOne.GetDPS(), HeroTwo.GetDPS(), HeroThree.GetDPS(), enemyName, currentEnemyHealth, currentCoins, HeroOne.GetLevel(), HeroTwo.GetLevel(), HeroThree.GetLevel(), FindUpgradeCost(1), FindUpgradeCost(2), FindUpgradeCost(3), currentRound);
                    Thread.Sleep(250);
                }

                if ((currentRound % 10) == 0)
                {
                    currentCoins = currentCoins + RNG.Next(10,21);
                }
                currentCoins = currentCoins + RNG.Next(3,7);
                currentRound = currentRound + 1;
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
                costToUpgrade = currentLevel * 3;
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
                enemyHP = 20 + (currentRound * 7);
            }
            else if (currentRound > 25 && currentRound <= 50)
            {
                enemyHP = 45 + (currentRound * 11);
            }
            else if (currentRound > 50 && currentRound <= 100)
            {
                enemyHP = 600 + (currentRound * 15);
            }
            else if (currentRound > 100 && currentRound <= 250)
            {
                enemyHP = 1400 + (currentRound * 21);
            }
            else if (currentRound > 250 && currentRound <= 500)
            {
                enemyHP = 4500 + (currentRound * 28);
            }
            else if (currentRound > 500)
            {
                enemyHP = 10000 + (currentRound * 40);
            }

            if ((currentRound % 10) == 0)
            {
                enemyHP = enemyHP * 3;
            }
            return enemyHP;
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

        private void dlcButton_MouseDown(object sender, MouseEventArgs e)
        {
            trollLabel.Show();
        }

        void ShowDLC()
        {
            Invoke((MethodInvoker)delegate
            {
                dlcButton.Show();
                dlcLabel.Show();
            });
        }

        private void dismissDlcBox_MouseDown(object sender, MouseEventArgs e)
        {
            dlcButton.Hide();
            dlcLabel.Hide();
            trollLabel.Hide();
            enemyHealthBar.Increment(-19);
        }
    }
}
