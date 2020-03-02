using System;

namespace ChainOfResponse
{
    class Program
    {
        static void Main(string[] args)
        {
            var request = new Request();
            Console.WriteLine("Введите логин");
            request.Login = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            request.Password = Console.ReadLine();
            Console.WriteLine("Введите позицию");
            request.Position = Console.ReadLine();


            var client = new Client(request);
        }
    }

}
