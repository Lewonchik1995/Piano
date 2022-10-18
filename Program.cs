using System;

namespace piano
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для выхода из приложения нажмите \"ESC\"");
            Console.WriteLine("Смена октавы:\n" +
                "\t F5 - 5-я октава\n" +
                "\t F6 - 6-я октава");
            int[] mhz = Octave(5); 
            Console.WriteLine("\n\nВыбрана 5-я октава\n");
            bool endApp = false; 
            do
            {
                ConsoleKeyInfo clavisha = Console.ReadKey(); 

                if (clavisha.Key == ConsoleKey.F5) 
                {
                    mhz = Octave(5);
                    Console.WriteLine("\n\nВыбрана 5-я октава\n");
                }
                else if (clavisha.Key == ConsoleKey.F6)
                {
                    mhz = Octave(6);
                    Console.WriteLine("\n\nВыбрана 6-я октава\n");
                }
                else if (clavisha.Key == ConsoleKey.D)
                {
                    Beep(mhz[0]);
                }
                else if (clavisha.Key == ConsoleKey.R)
                {
                    Beep(mhz[1]);
                }
                else if (clavisha.Key == ConsoleKey.F)
                {
                    Beep(mhz[2]);
                }
                else if (clavisha.Key == ConsoleKey.T)
                {
                    Beep(mhz[3]);
                }
                else if (clavisha.Key == ConsoleKey.G)
                {
                    Beep(mhz[4]);
                }
                else if (clavisha.Key == ConsoleKey.H)
                {
                    Beep(mhz[5]);
                }
                else if (clavisha.Key == ConsoleKey.U)
                {
                    Beep(mhz[6]);
                }
                else if (clavisha.Key == ConsoleKey.J)
                {
                    Beep(mhz[7]);
                }
                else if (clavisha.Key == ConsoleKey.I)
                {
                    Beep(mhz[8]);
                }
                else if (clavisha.Key == ConsoleKey.K)
                {
                    Beep(mhz[9]);
                }
                else if (clavisha.Key == ConsoleKey.O)
                {
                    Beep(mhz[10]);
                }
                else if (clavisha.Key == ConsoleKey.L)
                {
                    Beep(mhz[11]);
                }
                else if (clavisha.Key == ConsoleKey.Escape)
                {
                    endApp = true;
                }
                else
                {
                    Console.WriteLine("\nЭта клавиша не работает!");
                }
            } while (!endApp);

        }

        static void Beep(int mhz)
        {
            Console.Beep(mhz, 1000);
        }

        static int[] Octave(int octave)
        {
            int[] fiveOctave = new int[] { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 };
            int[] sixOctave = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };

            if (octave == 5)
            {
                return fiveOctave;
            }
            else if (octave  == 6)
            {
                return sixOctave;
            }
            else
            {
                return null;
            }
        }
    }
}