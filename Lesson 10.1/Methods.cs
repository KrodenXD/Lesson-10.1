using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10._1
{
    class Methods
    {
        public Methods()
        {
            
        }
        public Methods(int u)
        {
            t = u;
        }
        public int t;
        public const string Address = "Abovyan-1";
        public const string Number = "+37477777777";
        
        public decimal MakeFood(Menu menu,int count)
        {
            switch (menu)
            {
                case Menu.Hotdog:
                    return (decimal)Menu.Hotdog * (count+t);
                case Menu.Shushi:
                    return (decimal)Menu.Shushi * (count + t);
                case Menu.Pizza:
                    return (decimal)Menu.Pizza * (count + t);
                case Menu.Shawrma:
                    return (decimal)Menu.Shawrma * (count + t);
                case Menu.Xash:
                    return (decimal)Menu.Xash * (count + t);
                default:
                    return 0;
            }
        }
    }
    public enum Menu
    {
        Hotdog = 500,
        Shushi = 12000,
        Pizza = 300,
        Shawrma = 700,
        Xash = 4000
    }
}
