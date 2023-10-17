using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Practika3
{
    class Program
    {
        public static void Main()
        {
            int[] Actava1 = new int[] { 527, 497, 469, 443, 418, 395, 372, 344 };
            int[] Actava2 = new int[] { 333,296,279,263,248,234,221,209 };
            int[] Actava3 = new int[] { 197,186,172,166,156,148,139,131 };
            int[] Actava4 = new int[] { 124,117,110,104,98,93,88,83 };
            WriteLine("Выберите октаву:\n 1. Октава 5-4\n 2. Октава 3-2");
            int n = Convert.ToInt32(ReadLine());
            Clear();
            if (n == 2)
            {
                for (int i = 0; i < Actava1.Length; i++) Actava1[i] = Actava3[i];
                for (int i = 0; i < Actava1.Length; i++) Actava2[i] = Actava4[i]; 
            }
            Start(Actava1, Actava2);
        }
        public static void Start( int[] Actava1, int[] Actava2)
        {   
            WriteLine("F6 - сменить октаву\nEsc - закончить программу");
            ConsoleKeyInfo Key = ReadKey(true);
            switch (Key.Key)
            {
                case ConsoleKey.D1: Beep(Actava1[0], 400); break;
                case ConsoleKey.D2: Beep(Actava1[1], 400); break;
                case ConsoleKey.D3: Beep(Actava1[2], 400); break;
                case ConsoleKey.D4: Beep(Actava1[3], 400); break;
                case ConsoleKey.D5: Beep(Actava1[4], 400); break;
                case ConsoleKey.D6: Beep(Actava1[5], 400); break;
                case ConsoleKey.D7: Beep(Actava1[6], 400); break;
                case ConsoleKey.D8: Beep(Actava1[7], 400); break;
                case ConsoleKey.Q: Beep(Actava2[0], 400); break;
                case ConsoleKey.W: Beep(Actava2[1], 400); break;
                case ConsoleKey.E: Beep(Actava2[2], 400); break;
                case ConsoleKey.R: Beep(Actava2[3], 400); break;
                case ConsoleKey.T: Beep(Actava2[4], 400); break;
                case ConsoleKey.Y: Beep(Actava2[5], 400); break;
                case ConsoleKey.U: Beep(Actava2[6], 400); break;
                case ConsoleKey.I: Beep(Actava2[7], 400); break;
                case ConsoleKey.Escape: return;
                case ConsoleKey.F6: Main(); break;
            }
            Clear();
            Start(Actava1, Actava2);
        }
    }
}
