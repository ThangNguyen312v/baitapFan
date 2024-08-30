using System;
namespace baitapfan{
    class Program{
        static void Main(string[] Args){
            Fan fan1 = new Fan(Fan.FAST,true,10,"yellow");

            Fan fan2 = new Fan(Fan.MEDIUM,false,5,"blue");

            Console.WriteLine(fan1.ToString());
            Console.WriteLine(fan2.ToString());
        }
    }
}
