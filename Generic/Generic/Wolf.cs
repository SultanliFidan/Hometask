using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic;

internal class Wolf : Animal
{
    public bool IsPrideLeader {  get; set; }
    public int AttackDamage { get; set; }

    public void Hunt <T>(T animal ) where T : Animal
    {
        animal.HP -= AttackDamage;
    }
}
