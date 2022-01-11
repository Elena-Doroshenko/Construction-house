using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DZ_5_Сonstruction
{
    class Program
    {
        /*
         Над строительством дома работает бригада из 5 строителей во главе с бригадиром. Бригада работает одновременно.
         Бригадир время от времени включается в работу и составляет отчёт о проделанной работе. Дом состоит из фундамента,
         4-х стен, и крыши. Все действия строителей должны отображаться на консоли. Все отчёты бригадира логируются.
         (указание даты, данных бригадира, данных о том, что уже построено на момент проверки (можно в процентном соотношении)).
         */
        private delegate void BuildingHouse();
        static object locker = new object();
        public static void Foundation()
        {
            Console.SetCursorPosition(1, 0);
            Console.Write("Бригадир: ");
            Console.SetCursorPosition(13, 0);
            Console.Write($"Строительство фундамента начато: {DateTime.Now.ToLongTimeString()}"); ;
            Thread.Sleep(500);
            Building(2);
            Thread.Sleep(1000);
            Console.SetCursorPosition(1, 8);
            Console.Write("Бригадир: ");
            Console.SetCursorPosition(13, 8);
            Console.WriteLine($"Строительство фундамента завершено! {DateTime.Now.ToLongTimeString()}");
            Console.WriteLine("-----------------------------------------------------------");
            Thread.Sleep(1000);
        }
        public static void Walls()
        {
            Console.SetCursorPosition(1, 10);
            Console.Write("Бригадир: ");
            Console.SetCursorPosition(13, 10);
            Console.Write($"Строительство стен начато: {DateTime.Now.ToLongTimeString()}");
            Thread.Sleep(600);
            Building(12);
            Thread.Sleep(1000);
            Console.SetCursorPosition(1, 18);
            Console.Write("Бригадир: ");
            Console.SetCursorPosition(13, 18);
            Console.WriteLine($"Строительство стен завершено! {DateTime.Now.ToLongTimeString()}");
            Console.WriteLine("-----------------------------------------------------------");
            Thread.Sleep(1000);
        }
        public static void Roof()
        {
            Console.SetCursorPosition(1, 20);
            Console.Write("Бригадир: ");
            Console.SetCursorPosition(13, 20);
            Console.Write($"Строительство крыши начато: {DateTime.Now.ToLongTimeString()}");
            Thread.Sleep(500);
            Building(22);
            Thread.Sleep(1000);
            Console.SetCursorPosition(1, 28);
            Console.Write("Бригадир: ");
            Console.SetCursorPosition(13, 28);
            Console.WriteLine($"Строительство крыши завершено! {DateTime.Now.ToLongTimeString()}");
            Console.WriteLine("-----------------------------------------------------------");
            Thread.Sleep(600);
        }
        public static void BuildingAll(object cursorPosithion)
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.SetCursorPosition(1, (int)cursorPosithion);
                Console.Write("Brigadier: ");
                Console.SetCursorPosition(15, (int)cursorPosithion);
                Console.Write($"Строительство {Thread.CurrentThread.Name}:");
                Console.WriteLine("\n---------------------------------------------");
                Console.SetCursorPosition(1, (int)cursorPosithion+2);
                Console.Write("builder1: ");
                Console.SetCursorPosition(15, (int)cursorPosithion+2);
                for (int k = 0; k < i; k++)
                {
                    Console.Write("\u25ba");
                }
                Console.Write($"{i}%"); Thread.Sleep(100);
                Console.SetCursorPosition(1, (int)cursorPosithion +3);
                Console.Write("builder2: ");
                Console.SetCursorPosition(15, (int)cursorPosithion +3);
                for (int k = 0; k < i; k++)
                {
                    Console.Write("\u25ba");
                }
                Console.Write($"{i}%"); Thread.Sleep(100);
                Console.SetCursorPosition(1, (int)cursorPosithion +4);
                Console.Write("builder3: ");
                Console.SetCursorPosition(15, (int)cursorPosithion +4);
                for (int k = 0; k < i; k++)
                {
                    Console.Write("\u25ba");
                }
                Console.Write($"{i}%"); Thread.Sleep(100);
                Console.SetCursorPosition(1, (int)cursorPosithion +5);
                Console.Write("builder4: ");
                Console.SetCursorPosition(15, (int)cursorPosithion +5);
                for (int k = 0; k < i; k++)
                {
                    Console.Write("\u25ba");
                }
                Console.Write($"{i}%"); Thread.Sleep(100);
                Console.SetCursorPosition(1, (int)cursorPosithion +6);
                Console.Write("builder5: "); Thread.Sleep(100);
                Console.SetCursorPosition(15, (int)cursorPosithion +6);
                for (int k = 0; k < i; k++)
                {
                    Console.Write("\u25ba");
                }
                Console.Write($"{i}%"); Thread.Sleep(100);
            }
            Console.SetCursorPosition(1, (int)cursorPosithion+8);
            Console.Write("Brigadier: ");
            Console.SetCursorPosition(15, (int)cursorPosithion+8);
            Console.Write($"Строительство {Thread.CurrentThread.Name} окончено!");
            Console.WriteLine("\n---------------------------------------------");
        }
        public static void Building(object cursorPosithion)
        {
            for (int i = 1; i <= 20; i++)
            {
                if(Thread.CurrentThread.Name == "builder1")
                {
                    Console.SetCursorPosition(1, (int)cursorPosithion);
                    Console.Write("Строитель 1:");
                    Console.SetCursorPosition(15, (int)cursorPosithion);
                    for (int k = 0; k < i; k++)
                    {
                        Console.Write("\u25ba");
                    }
                    Console.Write( $"{i}%");
                }
                else if (Thread.CurrentThread.Name == "builder2")
                {
                    Console.SetCursorPosition(1, (int)cursorPosithion+1);
                    Console.Write("Строитель 2:");
                    Console.SetCursorPosition(15, (int)cursorPosithion+1);
                    for (int k = 0; k < i; k++)
                    {
                        Console.Write("\u25ba");
                    }
                    Console.Write(i + "%");
                }
                else if (Thread.CurrentThread.Name == "builder3")
                {
                    Console.SetCursorPosition(1, (int)cursorPosithion+2);
                    Console.Write("Строитель 3:");
                    Console.SetCursorPosition(15, (int)cursorPosithion+2);
                    for (int k = 0; k < i; k++)
                    {
                        Console.Write('\u25ba');
                    }
                    Console.Write(i + "%");
                }
                else if (Thread.CurrentThread.Name == "builder4")
                {
                    Console.SetCursorPosition(1, (int)cursorPosithion+3);
                    Console.Write("Строитель 4:");
                    Console.SetCursorPosition(15, (int)cursorPosithion+3);
                    for (int k = 0; k < i; k++)
                    {
                        Console.Write("\u25ba");
                    }
                    Console.Write(i + "%");
                }
                else if (Thread.CurrentThread.Name == "builder5")
                {
                    Console.SetCursorPosition(1, (int)cursorPosithion+4);
                    Console.Write("Строитель 5:");
                    Console.SetCursorPosition(15, (int)cursorPosithion+4);
                    for (int k = 0; k < i; k++)
                    {
                        Console.Write("\u25ba");
                    }
                    Console.Write(i + "%");
                }
                Thread.Sleep(500);
            }
        }


        static void Main(string[] args)
        {

            //=====================1-й вариант (в потоках - части дома)====================//
            #region 1_option
            /*
            List<Thread> house_pathes = new List<Thread>() {
                    new Thread(BuildingAll){Name = "Foundation" },
                    new Thread(BuildingAll){Name = "Walls" },
                    new Thread(BuildingAll){Name = "Roof" }
            };
            lock (locker)
            {
                for (int i = 0; i < house_pathes.Count; i++)
                {
                    house_pathes[i].Start(i * 10);
                    Thread.Sleep(15000);
                }
            }
            int n = 0;
            foreach (var item in house_pathes)
            {
                n += item.IsAlive == false ? 1 : 0;
            }
            if (n == 3)
                Console.WriteLine("Строительство дома завершено!");
            */
            #endregion
            //=============================конец 1-го варианта=============================//


            //======================2-й вариант (в потоках - строители)===================//
            #region 2_option
            
            List<Thread> builders = new List<Thread>(){

                new Thread(Foundation){Name = "builder1" },
                new Thread(Foundation){Name = "builder2" },
                new Thread(Foundation){Name = "builder3" },
                new Thread(Foundation){Name = "builder4" },
                new Thread(Foundation){Name = "builder5" }
            };
            foreach (var item in builders)
            {
                item.Start();
                Thread.Sleep(300);
            }
            Thread.Sleep(11000);

            List<Thread> builders2 = new List<Thread>(){

                new Thread(Walls){Name = "builder1" },
                new Thread(Walls){Name = "builder2" },
                new Thread(Walls){Name = "builder3" },
                new Thread(Walls){Name = "builder4" },
                new Thread(Walls){Name = "builder5" }
            };
            
            foreach (var item in builders2)
            {
                item.Start();
                Thread.Sleep(300);
            }
            Thread.Sleep(11000);
            List<Thread> builders3 = new List<Thread>(){

                new Thread(Roof){Name = "builder1" },
                new Thread(Roof){Name = "builder2" },
                new Thread(Roof){Name = "builder3" },
                new Thread(Roof){Name = "builder4" },
                new Thread(Roof){Name = "builder5" }
            };
            foreach (var item in builders3)
            {
                item.Start();
                Thread.Sleep(300);
            }
            Thread.Sleep(11000);

            Console.WriteLine(" Бригадир:  Строительство дома завершено! " + DateTime.Now.ToLongTimeString());
            
            #endregion
            //==============================конец 2-го варианта===========================//
            
            Console.ReadKey();
        }

    }
}
