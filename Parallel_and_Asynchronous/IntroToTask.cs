

namespace Parallel_and_Asynchronous
{
    public class IntroToTask
    {
        public static async Task TaskMain()
        {
            await SomeMethod();
        }

        public async static Task SomeMethod()
        {
            Console.WriteLine("--->Some method started");
            await Wait();
            Console.WriteLine("--->Some method end");
        }

        private static async Task Wait()
        {
            Console.WriteLine("----->Wait Start");
            await Task.Delay(TimeSpan.FromSeconds(6));
            Console.WriteLine("\n----->6 seconds wait Completed");
            Console.WriteLine("----->Wait End");
        }
    }
}
