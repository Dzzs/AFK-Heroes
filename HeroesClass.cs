using System;

namespace AFK_Heroes
{
    public class HeroesClass
    {
        private int dps = 1;
        private string name = "Default";
        private int level = 1;

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
    }
}
