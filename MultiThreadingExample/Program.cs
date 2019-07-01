using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreadingExample
{
    class MTProgram
    {
        //The new thread will be created here.
        static System.Threading.Thread m_NewThread;

        //Main entry point for the program to run.
        static void Main(string[] args)
        {
            //Print a simple message.
            Console.WriteLine("Welcome to Multithreading in C#");

            //Creating a new thread that uses the NewThread() function.
            m_NewThread = new System.Threading.Thread(MTProgram.NewThread);
            //Start our new thread.
            m_NewThread.Start();

            //This loop will run on the main thread.
            int Tcount = 0;
            while (true)
            {
                //Sleep for less than a quarter second.
                Thread.Sleep(200);

                //Display this thread's current count.
                Console.WriteLine("The primary thread is running the iteration {0}", Tcount);

                //Increment the count.
                Tcount++;
            }
        }

        //This function is used in the new thread.
        public static void NewThread()
        {
            //This loop will run on the secondary thread.
            int Tcount = 0;
            while (true)
            {
                //Sleep for 150ms.
                Thread.Sleep(150);

                //Display the new thread's current count.
                Console.WriteLine("The secondary thread is running the iteration {0}", Tcount);

                //Increment the count.
                Tcount++;
            }
        }
    }
}
