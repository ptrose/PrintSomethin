using System;

namespace print
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any word");
            string anyWord = Console.ReadLine();
            Console.WriteLine("enter any integer");
            int anyInt = int.Parse(Console.ReadLine());
            int anyLayer = 1;
            for (int line = 1; line<2*anyInt; line++)
            {
                for (int times=0; times<anyInt; times++)
                {
                    for (int thing = 0; thing < 2 * anyInt + 1; thing++)
                    {
                        if (thing == (anyInt - anyLayer + 1))
                        {
                            for (int printCount = 0; printCount < 2 * anyLayer - 1; printCount++)
                            {
                                if (printCount % 2 == 1)
                                {
                                    Console.Write(" ");
                                }
                                else
                                {
                                    Console.Write("{0}", anyWord);
                                }
                                thing++;
                            }
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }

                if (line < anyInt)
                {
                    anyLayer++;
                }
                else
                {
                    anyLayer--;
                }
                Console.WriteLine("");
            }
        }
    }
}
