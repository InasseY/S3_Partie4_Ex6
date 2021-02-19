using System;
using System.Linq;

namespace Partie4_Ex6
{
    class Program
    {
        //variable en dehors du mains figé
        enum week
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche

        }
        static void Main(string[] args)
        {
            //String[] weeks = Enum.GetNames(typeof(Week));

            foreach (string day in Enum.GetNames(typeof(Week)))
                Console.WriteLine(day);

            Console.WriteLine((Week)4);
            //Console.WriteLine(Enum.GetName(typeof(Week), 4));
            //Console.WriteLine(Enum.GetNames(typeof(Week)).GetValue(4));   
        }
    }
}
