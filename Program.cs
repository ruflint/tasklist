using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Task
    {
        public String Name { get; }
        public bool IsDone { get; set; }

        public Task(string Name)
        {
            this.Name = Name;
            IsDone = false;
        }
    }

    class Program
    {
        private static string com;
        private static List<Task> suqalist = new List<Task>();

        static void Main(string[] args)
        {
            Console.WriteLine("Нажмите 1 для добавления новой задачи\n");
            Console.WriteLine("Нажмите 2 для вывода списка задач\n");
            Console.WriteLine("Напишите 'exit' для выхода");
            do
            {
                com = Console.ReadLine();
                switch (com)
                {
                    case "1":
                        Console.WriteLine("Введите задачу");
                        suqalist.Add(new Task(Console.ReadLine()));
                        Console.WriteLine("Задача добавлена, список задач можно увидеть нажав 2");


                        break;
                    case "2":
                        foreach (Task suqa in suqalist)
                            Console.WriteLine(suqa.Name);
                        break;
                    case "3":
                        Console.WriteLine("exit");
                        break;
                }
                

            } while (com != "exit");
            
        }
        
    }
}
