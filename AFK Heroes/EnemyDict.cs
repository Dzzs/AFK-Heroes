using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFK_Heroes
{
    class EnemyDict
    {
        Random RNG = new Random();
        Dictionary<int, string> FirstNames = new Dictionary<int, string>();
        Dictionary<int, string> MiddleNames = new Dictionary<int, string>();
        Dictionary<int, string> LastNames = new Dictionary<int, string>();
        Dictionary<int, string> Bosses = new Dictionary<int, string>();

        public void Init()
        {
            FirstNames.Add(1, "Haz");
            FirstNames.Add(2, "Kun");
            FirstNames.Add(3, "Nu");
            FirstNames.Add(4, "Pa");
            FirstNames.Add(5, "Fun");
            FirstNames.Add(6, "Yak");
            FirstNames.Add(7, "Ben");
            FirstNames.Add(8, "Jake");
            FirstNames.Add(9, "Hom");
            FirstNames.Add(10, "Ger");
            FirstNames.Add(11, "Grab her");

            MiddleNames.Add(1, "'sun");
            MiddleNames.Add(2, "'kaz");
            MiddleNames.Add(3, "'muk");
            MiddleNames.Add(4, "'dun");
            MiddleNames.Add(5, "'err");
            MiddleNames.Add(6, "'sex");
            MiddleNames.Add(7, "'per");
            MiddleNames.Add(8, "'ran");
            MiddleNames.Add(9, "'jiz");
            MiddleNames.Add(10, "'pan");
            MiddleNames.Add(11, " by the");

            LastNames.Add(1, "er");
            LastNames.Add(2, "enson");
            LastNames.Add(3, " the 3rd");
            LastNames.Add(4, "'mcgee");
            LastNames.Add(5, " the great");
            LastNames.Add(6, " big dick");
            LastNames.Add(7, " tiny peen");
            LastNames.Add(8, " the bitch");
            LastNames.Add(9, " the unstraight");
            LastNames.Add(10, "'son");
            LastNames.Add(11, " pussy");

            Bosses.Add(1, "Ben the homosexual");
            Bosses.Add(2, "Jake the gay");
            Bosses.Add(3, "Zarya the dike");
            Bosses.Add(4, "D'va the slutty whore bag");
            Bosses.Add(5, "Dr. Jakedoesnthavenstein");
            Bosses.Add(6, "Jamboni the great");
            Bosses.Add(7, "Lord Trump");
        }

        public string GetRandomEnemy()
        {
            int first = RNG.Next(1,(FirstNames.Count + 1));
            int middle = RNG.Next(1, (MiddleNames.Count + 1));
            int last = RNG.Next(1, (LastNames.Count + 1));

            string fString = FirstNames[first];
            string sString = MiddleNames[middle];
            string lString = LastNames[last];


            return fString + sString + lString;
        }

        public string GetRandomBoss(int num)
        {
            return Bosses[num];
        }

        public int GetBossCount()
        {
            return Bosses.Count();
        }
    }
}
