using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class PrintMachine
    {
       public  void Turnon() { Console.WriteLine("machine is on"); }
       public  void TurnOff() { Console.WriteLine("machine is off"); }
       public  void Print() { Console.WriteLine("machine is print mode"); }

    }
}
