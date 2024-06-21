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

    //Singleton_DesignPattern class is a Lazy Loading or Deferred Loading in Singleton Design Patterns

    /* With C# 4.0 onwards, we can use the Lazy<T> Generic class to make the 
     Singleton Instance Lazy Loading. Let us proceed and see how we can implement 
     Lazy Loading in the Singleton Design Pattern using the Lazy<T> Generic Class in C#.
     */

    //Example to Understand Lazy Loading of Singleton Instance using Lazy<T> Generic Class.

    /*
     The Lazy<T> Generic Class, introduced as part of .NET Framework 4.0, 
    provides built-in support for lazy initialization, i.e., on-demand object initialization. 
    If you want to make an object (such as Singleton) lazily initialized, i.e., 
    on-demand object initialization. You need to pass the type (Singleton) of the object to the 
    Lazy generic class. Within the Lazy<T> constructor, using the lambda expression, 
    we need to create the instance, which is shown below.

    i.e Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());
     */
    public sealed class SingletonLazyLoading
    {
        //This variable value will be increment by 1 each time the object of the class is created
        private static int Counter = 0;
        //This will make the Singleton Instance Lazy Loading
        //Lazy Object are Thread-Safe by default
        private static readonly Lazy<SingletonLazyLoading> _instance = new Lazy<SingletonLazyLoading>(() => new SingletonLazyLoading());
        //The following Static Method is going to return the Singleton Instance
        //This is Thread-Safe as it uses Lazy<T> Object
        public static SingletonLazyLoading GetInstance()
        {
            //Now we don't need to use any NULL Checking code
            //We don't need to write Explicit code for thread-safety
            //Call the Value property of the Lazy object which will return the Singleton Instance
            return _instance.Value;
        }
        private SingletonLazyLoading()
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
 We got the same output as Eager Loading. 
 This is because the lazy keyword creates only one singleton instance, 
 and they are, by default, thread-safe. 
 This is why we do not get any error while invoking the methods parallelly.
 
 Program.cs Code
------------------
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
            SingletonLazyLoading fromTeacher = SingletonLazyLoading.GetInstance();
            fromTeacher.PrintDetails("From Teacher");
        }
        private static void PrintStudentdetails()
        {
            //At the same time, Thread-2 also Calling the GetInstance() Method of the Singleton Class
            SingletonLazyLoading fromStudent = SingletonLazyLoading.GetInstance();
            fromStudent.PrintDetails("From Student");
        }
    }
}
 */
