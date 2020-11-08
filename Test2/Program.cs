using System;

namespace Test2
{
    class Program
    {
        const byte Up = 8;
        const byte Down = 2;
        const byte Right = 6;
        const byte Left = 4;
        static void Main(string[] args)
        {
            pole();

        }

        static void pole()
        {
            Random R = new Random();
            const byte maxX = 10;
            const byte maxY = 10;
            byte ColMonet = (byte)R.Next(2, 10);
            byte[,] MonetkaCord = new byte[2, ColMonet];
            for (byte i = 0; i < ColMonet; i++)
            {
                MonetkaCord[0, i] = (byte)R.Next(0, maxX - 1);
                MonetkaCord[1, i] = (byte)R.Next(1, maxY - 1);
            }
            byte[] BlackListMonet= {200, };
            byte[] cord = new byte[2];
            cord[0] = 1;
            cord[1] = 1;
            byte read;
            while (true)
            {
                for (byte i0 = 0; i0 < maxY; i0++)
                {
                    for (byte i1 = 0; i1 < maxX; i1++)
                    {
                        for (byte i = 0; i < ColMonet; i++)
                        {
                            if (cord[0] == i0 && cord[1] == i1)
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                            }
                            else if (MonetkaCord[0, i] == i0 && MonetkaCord[1, i] == i1)
                            {

                                /*for (byte B =0;B<BlackListMonet.Length;B++)
                                {
                                    if (i!=BlackListMonet[B])
                                    {*/
                                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                                        /*break;
                                    }

                                }
                                */
                                break;

                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                            }
                        }
                            Console.Write("  ");
                        
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                }
                while (true)
                {

                    read = Convert.ToByte(Console.ReadLine());
                    if (read == 4 || read == 8 || read == 6 || read == 2)
                    {
                        break;
                    }
                    Console.WriteLine("Введите число 4 или 8 или 6 или 2");
                }
                if (read == Left)
                {
                    if (cord[1] == 0)
                    {
                        cord[1] = maxX - 1;
                    }
                    else { cord[1]--; }

                }
                else if (read == Right)
                {
                    if (cord[1] == maxX - 1)
                    {
                        cord[1] = 0;

                    }
                    else
                    {
                        cord[1]++;
                    }
                }
                else if (read == Up)
                {
                    if (cord[0] == 0)
                    {
                        cord[0] = maxY - 1;
                    }
                    else { cord[0]--; }
                }
                else if (read == Down)
                {
                    if (cord[0] == maxY - 1)
                    {
                        cord[0] = 0;
                    }
                    else { cord[0]++; }
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
              /*  for (byte i = 0; i < ColMonet; i++)
                {
                    if (cord[0]==MonetkaCord[0,i]&& cord[1] == MonetkaCord[1, i])
                    {
                        BlackListMonet[BlackListMonet.Length] = i;
                        
                    }
                }*/
                Console.Clear();
            }

        }

        static void multiki()
        {
            Random R = new Random();
            char x;
            byte a;
            int h = 0, d = 0;
            while (true)
            {
                do
                {
                    a = Convert.ToByte(R.Next(48, 122));
                } while ((a > 57 && a <= 64) || (a > 90 && a <= 96));
                x = (char)(a);
                Console.Write(x);
                d = R.Next(0, 15);
                h = R.Next(0, 15);
                Console.ForegroundColor = ConsoleColor.Black + d;
                Console.BackgroundColor = ConsoleColor.Black + h;
            }
        }
    }
}



