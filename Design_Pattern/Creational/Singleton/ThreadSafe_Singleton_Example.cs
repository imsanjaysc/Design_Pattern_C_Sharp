
namespace Design_Pattern.Creational.Singleton
{
    internal class ThreadSafe_Singleton_Example
    {
        public static void PrintTeacherDetails()
        {
            //Thread-1 Calling the GetInstance() Method of the Singleton class
            Singleton_DesignPattern fromTeacher = Singleton_DesignPattern.GetInstance();
            fromTeacher.PrintDetails("From Teacher");
        }
        public static void PrintStudentDetails()
        {
            //At the same time, Thread-2 also Calling the GetInstance() Method of the Singleton Class
            Singleton_DesignPattern fromStudent = Singleton_DesignPattern.GetInstance();
            fromStudent.PrintDetails("From Student");
        }
    }
}

/*
 * 
 ThreadSafe_Singleton_Example Program.cs Code
-------------------
using Design_Pattern.Creational.Singleton;

Parallel.Invoke(
                //Let us Assume PrintTeacherDetails method is Invoked by Thread-1
                () => ThreadSafe_Singleton_Example.PrintTeacherDetails(),
                //Let us Assume PrintStudentDetails method is Invoked by Thread-2
                () => ThreadSafe_Singleton_Example.PrintStudentDetails()
                );
Console.ReadLine();
 */
