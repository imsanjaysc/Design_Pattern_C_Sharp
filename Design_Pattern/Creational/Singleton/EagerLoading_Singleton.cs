using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Creational.Singleton
{
    /*
     Note: Agar hame application startup me hi singleton ko intitialize karna ho to hame Eager use krte hai aur
     jab tak koi ise call na kre tab tak iska instance na bane tab ham lazy call krte hai
    */
    public sealed class SingletonEagerLoading
    {
        //This variable value will be increment by 1 each time the object of the class is created
        private static int Counter = 0;
        //This variable is going to store the Singleton Instance
        //Initiazling the Variable at the time of class start-up and make it ready to be used in Future
        private static readonly SingletonEagerLoading _instance = new SingletonEagerLoading();

        //The following Static Method is going to return the Singleton Instance
        //This is Thread-Safe as it use Eager Loading
        public static SingletonEagerLoading GetInstance()
        {
            //Now we don't need to use any NULL Checking code
            //We don't need to write Explicit code for thread-safety
            //Object initialization and Thread-Safety will be taken care by CLR as we are using Eager Loading
            //Return the Singleton Instance
            return _instance;
        }
        private SingletonEagerLoading()
        {
            //Each Time the Constructor is called, increment the Counter value by 1
            Counter++;
            Console.WriteLine("Counter Value " + Counter.ToString());
        }
        //The following method can be accessed from outside of the class by using the Singleton Instance
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}

/*
You can see that only one instance was created as the Counter value is 1. 
The above Singleton Class is thread-safe after removing the lock variables and null checking. 
The CLR (Common Language Runtime) will internally take care of the variable initialization and 
thread safety in the multithreaded environment as we use Eager Loading.

Program.cs
----------------
using Design_Pattern.Creational.Singleton;
using System;
using System.Threading.Tasks;
namespace SingletonDemo
{
    class Program
    {
        //Example to Understand Thraed-Safe Singleton Design Pattern using Eager Loading
        //When use in a Multithreaded Environment
        static void Main(string[] args)
        {
            //The following Code will Invoke both methods Parallely using two different Threads
            Parallel.Invoke(
                //Let us Assume PrintTeacherDetails method is Invoked by Thread-1
                () => PrintTeacherDetails(),
                //Let us Assume PrintStudentdetails method is Invoked by Thread-2
                () => PrintStudentdetails()
                );
            Console.ReadLine();
        }
        private static void PrintTeacherDetails()
        {
            //Thread-1 Calling the GetInstance() Method of the Singleton class
            SingletonEagerLoading fromTeacher = SingletonEagerLoading.GetInstance();
            fromTeacher.PrintDetails("From Teacher");
        }
        private static void PrintStudentdetails()
        {
            //At the same time, Thread-2 also Calling the GetInstance() Method of the Singleton Class
            SingletonEagerLoading fromStudent = SingletonEagerLoading.GetInstance();
            fromStudent.PrintDetails("From Student");
        }
    }
}
 */
