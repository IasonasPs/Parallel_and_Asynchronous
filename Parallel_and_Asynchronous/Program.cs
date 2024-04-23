

namespace Parallel_and_Asynchronous
{
    internal partial class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Main Method Started......");

            //IntroToAsync.AsyncMain();
            //await IntroToTask.TaskMain();
           await ApiCall.ApiMain();


            Console.WriteLine("Main Method End");
            Console.ReadKey();
        }

    }
}
