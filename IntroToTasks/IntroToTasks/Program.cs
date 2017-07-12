using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IntroToTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Task<int> carTask = Task.Factory.StartNew<int>(BookCar);
            Task<int> hotelTask = Task.Factory.StartNew<int>(BookHotel);
            Task<int> planeTask = Task.Factory.StartNew<int>(BookPlane);
            //Result in Lambda Expression keeps thread alive
            Task hotelFollowUpTask = hotelTask.ContinueWith(
                //Typically Lamda expression of the previous task used here
                taskPrev => Console.WriteLine("Adding view note for booking {0}", taskPrev.Result));

            Console.WriteLine("Finished booking: carId={0}, planeId={1}",
                carTask.Result, /*hotelTask.Result,*/ planeTask.Result);
            hotelFollowUpTask.Wait();

            Console.WriteLine("Finished in {0} sec.", sw.ElapsedMilliseconds / 1000.0);

            //4
            //Asking for the result of the task kept the thread alive
            //If not waiting for a longer task, the longer task will abort
            //Stopwatch sw = Stopwatch.StartNew();
            //Task<int> carTask = Task.Factory.StartNew<int>(BookCar);
            //Task<int> hotelTask = Task.Factory.StartNew<int>(BookHotel);
            //Task<int> planeTask = Task.Factory.StartNew<int>(BookPlane);

            //Console.WriteLine("Finished booking: carId={0}, planeId={1}",
            //    carTask.Result/*, hotelTask.Result*/, planeTask.Result);

            //Console.WriteLine("Finished in {0} sec.", sw.ElapsedMilliseconds / 1000.0);

            //3
            //In parallel
            //Using WaitAll make the total time take just as long as the longest task
            //Stopwatch sw = Stopwatch.StartNew();
            //Task<int> carTask = Task.Factory.StartNew<int>(BookCar);
            //Task<int> hotelTask = Task.Factory.StartNew<int>(BookHotel);
            //Task<int> planeTask = Task.Factory.StartNew<int>(BookPlane);

            //Task.WaitAll(carTask, hotelTask, planeTask);

            //Console.WriteLine("Finished in {0} sec.", sw.ElapsedMilliseconds / 1000.0);

            //2
            //Threads come out of thread pool
            //Threadpool threads are background threads
            //Background threads don't keep them main process alive
            //If the main thread exits, the background threads are aborted
            //Stopwatch sw = Stopwatch.StartNew();
            //Task<int> carTask = Task.Factory.StartNew<int>(BookCar);
            //Task<int> hotelTask = Task.Factory.StartNew<int>(BookHotel);
            //Task<int> planeTask = Task.Factory.StartNew<int>(BookPlane);

            //Console.WriteLine("Finished in {0} sec.", sw.ElapsedMilliseconds / 1000.0);

            //1
            //This is the serial way
            //Stopwatch sw = Stopwatch.StartNew();
            //int carId = BookCar();
            //int hotelId = BookHotel();
            //int planeId = BookPlane();

            //Console.WriteLine("Finished in {0} sec.", sw.ElapsedMilliseconds / 1000.0);
        }

        static Random rand = new Random();

        private static int BookPlane()
        {
            Console.WriteLine("Booking plane...") ;
            Thread.Sleep(5000);
            Console.WriteLine("Done with plane");
            return rand.Next(100);
        }

        private static int BookHotel()
        {
            Console.WriteLine("Booking hotel...");
            Thread.Sleep(8000);
            Console.WriteLine("Done with hotel");
            return rand.Next(100);
        }

        private static int BookCar()
        {
            Console.WriteLine("Booking car...");
            Thread.Sleep(3000);
            Console.WriteLine("Done with car");
            return rand.Next(100);
        }
    }
}
