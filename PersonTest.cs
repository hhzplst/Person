using System;

namespace Person {
    public class PersonTest {
        public static void Main(string[] args) {
            Console.WriteLine("Creating Ivy Chang...");
            Person testPerson = new Person("Ivy", "Chang");
            testPerson.PrintInfo();

            Console.WriteLine("Creating Elham Farhodi...");
            testPerson = new Person("Elham", "Farhodi");
            testPerson.PrintInfo();
        }
    }
}

/************************************TEST OUTPUT**************************************

➜  Person git:(master) ✗ dotnet run
Project Person (.NETCoreApp,Version=v1.0) will be compiled because inputs were modified
Compiling Person for .NETCoreApp,Version=v1.0

Compilation succeeded.
    0 Warning(s)
    0 Error(s)

Time elapsed 00:00:01.4004395
 

Creating Ivy Chang...
************************************************
ID    FIRSTNAME        LASTNAME        FULLNAME
************************************************
4648    Ivy             Chang         Ivy Chang

Creating Elham Farhodi...
************************************************
ID    FIRSTNAME        LASTNAME        FULLNAME
************************************************
9226  Elham           Farhodi     Elham Farhodi


***********************************END TEST OUTPUT************************************/