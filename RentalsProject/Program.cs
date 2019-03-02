using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalsProject
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Student[] s = new Student[10];

            //recebe os valores
            for (int i = 1; i <= n; i++)
            {
                //variáveis para inserir no vetor
                string name, email;
                int room;

                Console.WriteLine("Rent #" + i + ":");
                //Nome
                Console.Write("Name: ");
                name = Console.ReadLine();

                //Email
                Console.Write("Email: ");
                email = Console.ReadLine();

                //Quarto
                Console.Write("Room: ");
                room = int.Parse(Console.ReadLine());

                s[room] = new Student(name, email);

                Console.WriteLine();
            }

            Console.WriteLine("Busy rooms:");

            for (int i = 0; i < 10; i++)
            {

                if (s[i] != null)
                {
                    Console.WriteLine(i + ": " + s[i]);
                }

            }

            Console.ReadLine();
            
        }
    }
}
