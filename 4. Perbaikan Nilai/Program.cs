using System;

namespace _4._Perbaikan_Nilai
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0; i<4; i++)
            {
                Random random = new Random();
                int test = random.Next(0, 10);
                Console.WriteLine("Angka" + (i + 1) + " = " + test);
            }
        }
    }
}
