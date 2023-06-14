using System;
using System.Collections.Generic;

//ref link:https://www.youtube.com/watch?v=1hK6vGqaNkw&list=PLAE7FECFFFCBE1A54&index=6
//

delegate int MeDelegate();

class MainClass
{
    static void Main()
    {
        //Delegate -> MulticastDelegate -> MeDelegate
        MeDelegate d = ReturnFive;
        d += ReturnTen;
        d += Return22;
        int value = d();
        //Console.WriteLine(value);
        /*List<int> ints = new List<int>();
        foreach (MeDelegate del in d.GetInvocationList())
            ints.Add(del());*/
        foreach (int i in GetAllReturnValues(d))
            Console.WriteLine(i);
    }
    static List<int> GetAllReturnValues(MeDelegate d)
    {
        List<int> ints = new List<int>();
        foreach (MeDelegate del in d.GetInvocationList())
            ints.Add(del());
        return ints;
    }
    static int ReturnFive() { return 5; }
    static int ReturnTen() { return 10; }
    static int Return22() { return 22; }
}