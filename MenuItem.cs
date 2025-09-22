using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGitHub_Branch_4princip
{
    public class MenuItem
    {
        public string Name;
        public int Price;

        public void ShowInfo()
        {
            Console.WriteLine($"{Name} {Price} kr");
        }
    }
}
