using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel_and_Asynchronous
{
    public class ApiCall
    {
        public static async Task ApiMain()
        {
            Console.WriteLine();
            Console.WriteLine("--->Api main start....");
            Console.WriteLine("Enter a Name:");
            string Name = Console.ReadLine();

            await Intermediate(Name);

            Console.WriteLine("--->Api main End....");
            Console.WriteLine();
        }

        public async static Task Intermediate(string Name)
        {
            Console.WriteLine("------>Intermediate Starting....");
            var greetingMessage = await Greetings(Name);

            //Console.WriteLine($"------>{greetingMessage}");


            Console.WriteLine($"------>{(greetingMessage == "" ? "No message" : greetingMessage)}");

            Console.WriteLine("------>Intermediate End....");
        }

        private static async Task<string> Greetings(string name)
        {
            string message = string.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7172/");
                HttpResponseMessage response = await client.GetAsync($"api/greetings2/{name}");

                try
                {
                    response.EnsureSuccessStatusCode();
                }
                catch (Exception e)
                {
                    Console.WriteLine("--------->"+e.Message);
                }


                message = await response.Content.ReadAsStringAsync();
            }
            return message;
        }
    }
}
