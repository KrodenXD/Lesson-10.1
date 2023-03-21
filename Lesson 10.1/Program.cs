using System;

namespace Lesson_10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods();
            Methods methods1 = new Methods(66);

            Console.WriteLine(methods.t);
            Console.WriteLine(methods.MakeFood(Menu.Pizza,6));
        }

        
    }
}
