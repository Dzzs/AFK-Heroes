using System;

namespace AFK_Heroes
{
    public class EnemyClass  // Currently unused
    {
        private int dps = 1;
        private string name = "Default";
        private int level = 1;
        private int health = 100;

        public string GetName()
        {
            return name;
        }

        public void SetName(string nameSet)
        {
            name = nameSet;
        }

        public int GetDPS()
        {
            return dps;
        }

        public void SetDPS(int dpsSet)
        {
            dps = dpsSet;
        }

        public int GetLevel()
        {
            return level;
        }

        public void SetLevel(int levelSet)
        {
            level = levelSet;
        }

        public int GetHealth()
        {
            return health;
        }

        public void SetHealth(healthSet)
        {
            health = healthSet;
        }

    }
}
