using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class BeingsArmy
    {
        List<IntelligentBeing> army;
        public BeingsArmy()
        {
            this.army = new List<IntelligentBeing>();
        }

        public List<IntelligentBeing> Army
        {
            get
            {
                return this.army;
            }

            set {
                this.army = value;
            }
        }

        public void addSoldier(IntelligentBeing soldier)
        {
            army.Add(soldier);
        }

        public void removeSoldier(IntelligentBeing soldier)
        {
            army.Remove(soldier);
        }

        public void printArmy()
        {
            foreach (var soldier in army)
            {
                Console.WriteLine(soldier.ToString());
            }
        }
    }
}
