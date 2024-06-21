using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Creational.Singleton
{
    public sealed class Singleton_DesignPattern
    {
        /*It's not mandatory to sealed a class but if you don't make it sealed 
         then someone can create a child class and create multiple objects of the child class. 
        Sealed class will prevent the inheritance.*/
        private static Singleton_DesignPattern _instance;
        private static object _lock = new object();
        private Singleton_DesignPattern()
        {

        }

        public static Singleton_DesignPattern GetInstance()
        {
            if (_instance == null) //Double Checked Locking Approach to Implement Thread-Safe Singleton Design Pattern in C#.
            {
                // if we do not check instance == null then every time thread needs to wait bcz of lock keyword
                lock (_lock) //Implementation of Thread - safe Singleton Design Pattern in C# using Locks.
                {
                    _instance ??= new Singleton_DesignPattern();
                    Console.WriteLine("Instance Initiated");
                    //if (instance == null)
                    //{
                    //    instance = new Singleton_DesignPattern();
                    //    Console.WriteLine("Instance Initiated");
                    //}
                }
            }
            else
                Console.WriteLine("Instance Pre Initiated");
            return _instance;
        }

        //To log Error in DB                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
        public void ErrorLogging(string error)
        {
            Console.WriteLine($"Date: {DateTime.Now} | Error Logged: {error}");
        }

        //Print message
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
        //public class InheritSingletonClass : Singleton_DesignPattern
        //{
        //    //To stop inherit here we make this class sealed
        //}

    }
    //public class InheritSingletonClass : Singleton_DesignPattern
    //{
    //We cannot inherit here beacuse of private constructor
    //}
}
//Program.cs Code
/*
using Design_Pattern.Creational;

Singleton_DesignPattern stn = Singleton_DesignPattern.GetInstance();
stn.ErrorLogging("Exception occured");
Singleton_DesignPattern stn2 = Singleton_DesignPattern.GetInstance();
stn2.ErrorLogging("Exception occured Twice");
Singleton_DesignPattern stn3 = Singleton_DesignPattern.GetInstance();
stn3.ErrorLogging("Exception occured Thrice");
*/


/* Note: 
C# Lock
---------------
C# Lock keyword ensures that one thread is executing a piece of code at one time. 
The lock keyword ensures that one thread does not enter a critical section of code 
while another thread is in that critical section.

Lock is a keyword shortcut for acquiring a lock for the piece of code for only one thread.

Simple words: Ye dusre thread ko access karne nahi dega jabtak isko execute kar raha 
thread release nahi kar deta hai..
 
 */


/*
Where I used This
--------------------
In my project we created a logger component which is getting used for logging in the application 
to different sources (e.g. text file, XML, and database, based on configurations). 

So there is a log manager which creates the only one instance of the logger class across the application 
for logging the message, errors, etc.
 */