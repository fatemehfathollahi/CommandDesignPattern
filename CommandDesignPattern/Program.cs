using System;

namespace CommandDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var printMachine = new PrintMachine();
            var turnOn = new TurnOnPrinter(printMachine);
            var turnOff = new TurnOffPrinter(printMachine);
            var print = new Printer(printMachine);
            var invoker = new Invoker();
            invoker.PressButton(turnOn);
            invoker.PressButton(print);
            invoker.PressButton(turnOff); 
           
        }
    }
}
