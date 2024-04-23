using System.Threading.Tasks;
using System.Threading;
namespace Parallel_and_Asynchronous
{
    public class IntroToAsync
    {
        public async static void AsyncMain()
        {
            Console.WriteLine("--->AsyncMain Start");

            //Some();
             await SomeAsync();
            //GFG.Demo();
            //Console.ReadLine();
            Console.WriteLine("--->AsyncMain End");
        }
        #region "Some" methods
        public static void Some()
        {
            Console.WriteLine("--->Some Start");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("---> "+ i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("--->Some End");
            #region Some output
            //Main Method Started......
            //--->Some Start
            //---> 0
            //---> 1
            //---> 2
            //---> 3
            //---> 4
            //--->Some End
            //Main Method End
            #endregion
        }
        public static async Task SomeAsync()
        {
            Console.WriteLine("------>SomeAsync Start");
            await Wait();
            Console.WriteLine("------>SomeAsync End");
        }
        private static async Task Wait()
        {
             await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("        ---------->\n        5 Seconds wait Completed\n        <----------");
        }
        #endregion
    }
}
public class GFG
{
    public async static void Demo()
    {
        var watch = new System.Diagnostics.Stopwatch();
        watch.Start();
        var task1 = StartSchoolAssembly();
        await task1;     //the position of this is important!!
        var task2 = TeachClass12();
        var task3 = TeachClass11();
        //var task4 = TeachClass11();
        //var task5 = TeachClass12();


        Task.WaitAll(task1, task2, task3);
        watch.Stop();
        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds}ms");
    }
    public static async Task StartSchoolAssembly()
    {
        await Task.Run(() =>
        {
            Thread.Sleep(6000);
            Console.WriteLine("School Started");
        });
    }
    public static async Task TeachClass12()
    {
        await Task.Run(() =>
        {
            Thread.Sleep(3000);
            Console.WriteLine("Taught class 12");
        });
    }
    public static async Task TeachClass11()
    {
        await Task.Run(() =>
        {
            Thread.Sleep(2000);
            Console.WriteLine("Taught class 11");
        });
    }
}

