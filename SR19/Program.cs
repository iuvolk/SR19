using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
                new Computer () { Code = 1, Name ="HUAWEI MateBook D 15", ProcessorType = "AMD Ryzen 5", ClockSpeed = 3.2, Ram = 8, HardDisk = 256, VideoCard = 8, Price =  48, Num = 15},
                new Computer () { Code = 2, Name ="Xiaomi Notebook Pro 15", ProcessorType = "Intel Core i7", ClockSpeed = 3.2, Ram = 16, HardDisk = 1000, VideoCard = 2, Price =  100, Num = 5},
                new Computer () { Code = 3, Name ="Apple MacBook Pro 16", ProcessorType = "Intel Core i7", ClockSpeed = 2.6, Ram = 16, HardDisk = 1000, VideoCard = 4, Price =  150, Num = 1},
                new Computer () { Code = 4, Name ="LENOVO G580", ProcessorType = "Intel Core i5", ClockSpeed = 2.5, Ram = 6, HardDisk = 1000, VideoCard = 2, Price =  40, Num = 35},
                new Computer () { Code = 5, Name ="Honor MagicBook 14", ProcessorType = "AMD Ryzen 5", ClockSpeed = 2.1, Ram = 8, HardDisk = 256, VideoCard = 2, Price =  56, Num = 20},
                new Computer () { Code = 6, Name ="ASUS VivoBook 15", ProcessorType = "Intel Core i3", ClockSpeed = 3, Ram = 8, HardDisk = 256, VideoCard = 2, Price =  56, Num = 15},

            };

            Console.WriteLine("Выборка по процессору");
            Console.WriteLine("Введите наименование процессора");
            string processor = Console.ReadLine();
            List<Computer> computer1 = computers.Where(x => x.ProcessorType == processor).ToList();
            Print(computer1);

            Console.WriteLine("Выборка по размеру ОЗУ не ниже указанного");
            Console.WriteLine("Введите размер ОЗУ");
            int ram = Convert.ToInt32(Console.ReadLine());
            List<Computer> computer2 = computers.Where(x => x.Ram >= ram).ToList();
            Print(computer2);

            Console.WriteLine("Сортировка по увеличению стоимости");
            List<Computer> computer3 = computers.OrderBy(x => x.Price).ToList();
            Print(computer3);

            Console.WriteLine("Список, сгруппированный по типам процессоров");
            IEnumerable<IGrouping<string, Computer>> computer4 = computers.GroupBy(x => x.ProcessorType);
            foreach (IGrouping<string, Computer> gr in computer4)
            {
                Console.WriteLine(gr.Key);
                foreach (Computer c in gr)
                {
                    Console.WriteLine($"Код {c.Code}, Наименование {c.Name}, Процессор {c.ProcessorType}, Частота процессора {c.ClockSpeed}, ОЗУ {c.Ram}, Жесткий диск {c.HardDisk}, Видео карта {c.VideoCard}, Цена {c.Price}, Количество {c.Num}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Самый дорогой компьютер");
            Computer computer5 = computers.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine($"Код {computer5.Code}, Наименование {computer5.Name}, Процессор {computer5.ProcessorType}, Частота процессора {computer5.ClockSpeed}, ОЗУ {computer5.Ram}, Жесткий диск {computer5.HardDisk}, Видео карта {computer5.VideoCard}, Цена {computer5.Price}, Количество {computer5.Num}");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Самый бюджетный компьютер");
            Computer computer6 = computers.OrderBy(x => x.Price).FirstOrDefault();
            Console.WriteLine($"Код {computer6.Code}, Наименование {computer6.Name}, Процессор {computer6.ProcessorType}, Частота процессора {computer6.ClockSpeed}, ОЗУ {computer6.Ram}, Жесткий диск {computer6.HardDisk}, Видео карта {computer6.VideoCard}, Цена {computer6.Price}, Количество {computer6.Num}");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Есть компьютеры в количестве не менее 30 шт");
            Console.WriteLine(computers.Any(x => x.Num >= 30));

            Console.ReadKey();
        }




        static void Print(List<Computer> computers)
        {
            foreach (Computer c in computers)
            {
                Console.WriteLine($"Код {c.Code}, Наименование {c.Name}, Процессор {c.ProcessorType}, Частота процессора {c.ClockSpeed}, ОЗУ {c.Ram}, Жесткий диск {c.HardDisk}, Видео карта {c.VideoCard}, Цена {c.Price}, Количество {c.Num}");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
