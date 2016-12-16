using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace AFK_Heroes
{
    public class HeroesClass
    {
        private double dps = 1;
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
            return (int)dps;
        }

        public void AddDPS(int dpsAdd)
        {
            dps = dps + dpsAdd;
        }

        public void UpdateDPS()
        {
            if (dps < 5)
            {
                dps = dps + 1;
            }
            else if (dps > 4)
            {
                double toAdd = dps * .25 ;
                dps = dps + toAdd;
            }
        }

        public int GetLevel()
        {
            return level;
        }

        public void SetLevel(int levelSet)
        {
            level = level + levelSet;
        }
    }
}

