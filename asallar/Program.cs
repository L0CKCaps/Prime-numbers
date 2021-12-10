using System;

namespace asallar
{
    class Program
    {
        static void Main(string[] args)
        { 
            for (int i = 2; i < 20; i++)
            {
               bool kontrol = false;
                for (int x = 2; x < i; x++)
                {
                    if (i % x == 0)
                    {                        
                        kontrol = true;
                        break;
                    }
                }
                if (kontrol == false)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
