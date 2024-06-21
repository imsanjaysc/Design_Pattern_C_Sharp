using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    /*
     In C#, an extension method is a static method used to extend the functionality of an existing type without modifying 
    the original type or creating a new derived type. Extension methods allow developers to add methods to existing types, 
    such as classes, structs, interfaces, enums, etc., not originally defined in those types.

    Extension methods are declared in a static class and are defined as static methods with a special first parameter called the 
    "this" parameter. The "this" parameter specifies the type being extended and allows the extension method to be called as 
    if it were an instance method of that type.
     */
    public static class StringExtensions
    {
        public static string CapitalizeFirstLetter(this string str) {
            if (!string.IsNullOrEmpty(str))
                return str;
            return Char.ToUpper(str[0]) + str.Substring(1);
        }
    }
}

/*
 Program.cs
--------------
using Design_Pattern;

string ssc = "sanjay";
Console.WriteLine(ssc.CapitalizeFirstLetter());



Output:
---------
Sanjay
 */