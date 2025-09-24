using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopGitHub_Branch_4princip
{
    public abstract class MenuItemBase
    {
        public string Name;         // имя блюда или напитка
        protected double Price;     // цена, доступна в наследниках

        public abstract void ShowInfo(); // обязаны реализовать наследники

        public void SetPrice(double price)
        {
            Price = price;
        }
    }
}