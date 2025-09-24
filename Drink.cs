using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGitHub_Branch_4princip
{
    public class Drink : MenuItem
    {
        public override void ShowInfo()
        {
            Console.WriteLine($"{Name} {Price}kr (Drink)");
        }
    }
}
