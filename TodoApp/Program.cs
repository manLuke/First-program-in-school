using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            var todos = new List<String>();
            Console.WriteLine("Type showMyTodos if you want to see all your Todos");
            Console.WriteLine("Type exit if you want to exit");
            Console.WriteLine("Just type your Todo, which you want to add");
            while (!end)
            {
                Console.WriteLine("");
                Console.WriteLine("Add todo: ");
                string todo = Console.ReadLine();
                if (todo == "showMyTodos") {
                    Console.WriteLine("");
                    Console.WriteLine("Your Todos: ");
                    todos.ForEach(Console.WriteLine);
                    Console.WriteLine("");
                } else if (todo == "exit") {
                    end = true;
                } else {
                    todos.Add(todo);
                }
            }
        }
    }
}
