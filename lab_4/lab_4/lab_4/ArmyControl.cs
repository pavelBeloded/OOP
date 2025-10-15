using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class ArmyControl
    {
        public BeingsArmy army;

        public ArmyControl()
        {
            this.army = new BeingsArmy();
        }

        public IntelligentBeing? FindSoldierByYear(int year)
        {
            return army.Army.FirstOrDefault(soldier =>
                (soldier is Human h && h.BirthYear == year) ||
                (soldier is Transformer t && t.BuildYear == year));
        }

        public void PrintTransformersByPower(int power)
        {
            Debug.Assert(army != null, "army was not initialized");
            var transformers = army.Army.OfType<Transformer>()
                .Where(t => t.Power == power);

            foreach (var t in transformers)
            {
                Console.WriteLine(t.Name);
            }
        }

        public int GetArmyCount() => army.Army.Count;
    }
}
