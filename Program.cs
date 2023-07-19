using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Syinc__
{
    internal class  Program
    {
       
        static public void plitaON_skovorodaON()
        {
            Console.WriteLine("Подготовка плиты и посуды");
            Thread.Sleep(5000);
            Console.WriteLine("Завершена подготовка плиты!");
        }
        static public void Dostat_I_Podgotovit_Produkt()
        {
            Console.WriteLine("Подготовка продуктов!");
            Thread.Sleep(7000);
            Console.WriteLine("Подготовка продуктов Завершена!");
        }
        static public void Prigotovlenie()
        {
            Console.WriteLine("Начало приготовления завтрака!");
            Thread.Sleep(10000);
            Console.WriteLine("Завершение приготовления");
        }
        static public async Task plitaON_skovorodaON_Async()
        {
            Console.WriteLine("Подготовка плиты и посуды");
            await Task.Delay(5000);
            Console.WriteLine("Завершена подготовка плиты!");
            
        }
        static public async Task Dostat_I_Podgotovit_Produkt_Async()
        {
            Console.WriteLine("Подготовка продуктов!");
            await Task.Delay(7000);
            Console.WriteLine("Подготовка продуктов Завершена!");
            
        }
        static public async Task Prigotovlenie_Async()
        {
            Console.WriteLine("Начало приготовления завтрака!");
            await Task.Delay(10000);
            Console.WriteLine("Завершение приготовления");
        }

        static async Task Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            plitaON_skovorodaON();
            Dostat_I_Podgotovit_Produkt();
            Prigotovlenie();
            sw.Stop();
            Console.WriteLine("Завершено за " + sw.ElapsedMilliseconds / 1000 + "сек");
            sw.Restart();
            await plitaON_skovorodaON_Async();
            await Dostat_I_Podgotovit_Produkt_Async();
            await Prigotovlenie_Async();
            sw.Stop();
            Console.WriteLine("Завершено за "+sw.ElapsedMilliseconds/1000 + "сек");
        }
    }
}
