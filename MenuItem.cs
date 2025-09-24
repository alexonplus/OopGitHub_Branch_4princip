using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGitHub_Branch_4princip
{
    public   class MenuItem : MenuItemBase
    {
        public string Name;
        protected double Price;

        public override void ShowInfo()
        {
            Console.WriteLine($"{Name} {Price}kr");
        }

        public void SetPrice(double price)
        {
            Price = price;
        }

        public void PlusPrice(double amount)
        {
            Price += amount;
        }

        public void MinusPrice(double amount)
        {
            Price -= amount;
        }


    }
}
